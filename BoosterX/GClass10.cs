using System;
using RAMSPDToolkit.I2CSMBus;
using RAMSPDToolkit.SPD;
using RAMSPDToolkit.SPD.Interfaces;
using WinRing0Driver.Driver;

// Token: 0x0200011D RID: 285
public sealed class GClass10
{
	// Token: 0x06000844 RID: 2116 RVA: 0x00040DAC File Offset: 0x0003EFAC
	public static void smethod_0()
	{
		if (!DriverManager.LoadDriver())
		{
			Console.WriteLine("***** DRIVER ERROR *****");
			Console.WriteLine(string.Format("-> OLS Status Code: {0}", DriverManager.Ols.OLSStatus));
			Console.WriteLine(string.Format("-> DLL Status Code: {0}", DriverManager.Ols.GetDllStatus.Invoke()));
			Environment.Exit(1);
		}
		else
		{
			Console.WriteLine("***** Driver is open *****");
		}
		foreach (SMBusInterface smbusInterface in SMBusManager.RegisteredSMBuses)
		{
			for (byte b = 80; b <= 87; b += 1)
			{
				SPDDetector spddetector = new SPDDetector(smbusInterface, b, 0);
				if (spddetector.IsValid)
				{
					Console.WriteLine(string.Format("DIMM #{0}: Found RAM module.", (int)(b - 80)));
					Console.WriteLine("  Accessor Type: " + spddetector.Accessor.GetType().FullName);
					Console.WriteLine(string.Format("  Memory Type Enum: {0}", spddetector.Accessor.MemoryType()));
					try
					{
						DDR5Accessor ddr5Accessor = spddetector.Accessor as DDR5Accessor;
						if (ddr5Accessor != null)
						{
							Console.WriteLine(new GClass228(ddr5Accessor).ToString());
						}
						else if (spddetector.Accessor is DDR4Accessor)
						{
							Console.WriteLine("  DDR4 parsing not shown here.");
						}
						else
						{
							Console.WriteLine("  Timings parsing for this Accessor type is not implemented.");
						}
						goto IL_1CA;
					}
					catch (Exception ex)
					{
						Console.WriteLine("  Error parsing timings: " + ex.Message);
						Console.WriteLine("  Stack Trace: " + ex.StackTrace);
						goto IL_1CA;
					}
					goto IL_17D;
					IL_1B5:
					Console.WriteLine("------------------------------------");
					goto IL_1C0;
					IL_17D:
					IThermalSensor thermalSensor;
					if (thermalSensor.HasThermalSensor && thermalSensor.UpdateTemperature())
					{
						Console.WriteLine(string.Format("  Temperature: {0}°C", thermalSensor.Temperature));
						goto IL_1B5;
					}
					Console.WriteLine("  Temperature: Not available or failed to update.");
					goto IL_1B5;
					IL_1CA:
					thermalSensor = (spddetector.Accessor as IThermalSensor);
					if (thermalSensor != null)
					{
						goto IL_17D;
					}
					goto IL_1B5;
				}
				IL_1C0:;
			}
		}
		DriverManager.UnloadDriver();
		Console.WriteLine("***** Closed driver *****");
		Console.WriteLine("Press enter to exit...");
		Console.ReadLine();
	}
}
