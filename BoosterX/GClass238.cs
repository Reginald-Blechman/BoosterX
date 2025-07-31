using System;
using LibreHardwareMonitor.Hardware.Cpu;

// Token: 0x02000545 RID: 1349
public sealed class GClass238
{
	// Token: 0x0600220C RID: 8716 RVA: 0x0008852C File Offset: 0x0008672C
	public static ValueTuple<Vendor, int, int, int, string> smethod_0()
	{
		CpuId cpuId = CpuId.Get(0, 0);
		if (cpuId != null && cpuId.Vendor != null)
		{
			int family = (int)cpuId.Family;
			int model = (int)cpuId.Model;
			int stepping = (int)cpuId.Stepping;
			Vendor vendor = cpuId.Vendor;
			string text;
			if (vendor != 1)
			{
				if (vendor != 2)
				{
					throw new NotSupportedException(string.Format("Неизвестный Vendor: {0}", cpuId.Vendor));
				}
				text = "AMD";
			}
			else
			{
				text = "Intel";
			}
			string text2 = text;
			string text3 = family.ToString("X2");
			string text4 = model.ToString("X2");
			string item = string.Concat(new string[]
			{
				text2,
				"_F",
				text3,
				"_M",
				text4
			});
			return new ValueTuple<Vendor, int, int, int, string>(cpuId.Vendor, family, model, stepping, item);
		}
		throw new InvalidOperationException("Не удалось выполнить CPUID или неизвестный Vendor.");
	}
}
