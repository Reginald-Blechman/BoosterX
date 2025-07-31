using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;
using PIManagerX;

// Token: 0x020000EA RID: 234
public sealed class GClass2
{
	// Token: 0x060006F2 RID: 1778 RVA: 0x0003D1F4 File Offset: 0x0003B3F4
	public static string smethod_0()
	{
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select Name from Win32_Processor");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					string text = ((managementBaseObject != null) ? managementBaseObject["Name"] : null) as string;
					if (text != null && !string.IsNullOrWhiteSpace(text))
					{
						return text.Trim();
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch (Exception ex) when (ex is ManagementException || ex is UnauthorizedAccessException || ex is SecurityException)
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
			string text2 = ((registryKey != null) ? registryKey.GetValue("ProcessorNameString") : null) as string;
			if (!string.IsNullOrWhiteSpace(text2))
			{
				return text2.Trim();
			}
		}
		catch
		{
		}
		return "Unknown CPU";
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0003D328 File Offset: 0x0003B528
	public static string smethod_1()
	{
		List<GClass2.Class146> list = new List<GClass2.Class146>();
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Name, AdapterCompatibility, AdapterRAM, PNPDeviceID FROM Win32_VideoController");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					string text = (managementObject["Name"] as string) ?? string.Empty;
					string text2 = (managementObject["AdapterCompatibility"] as string) ?? string.Empty;
					ulong ulong_ = 0UL;
					object obj = managementObject["AdapterRAM"];
					if (obj == null)
					{
						goto IL_8F;
					}
					string s;
					if ((s = obj.ToString()) == null)
					{
						goto IL_8F;
					}
					IL_96:
					ulong.TryParse(s, out ulong_);
					string string_ = (managementObject["PNPDeviceID"] as string) ?? string.Empty;
					list.Add(new GClass2.Class146(text.Trim(), text2.Trim(), ulong_, string_));
					continue;
					IL_8F:
					s = "0";
					goto IL_96;
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
		if (list.Count == 0)
		{
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Video"))
				{
					if (registryKey != null)
					{
						foreach (string str in registryKey.GetSubKeyNames())
						{
							using (RegistryKey registryKey2 = registryKey.OpenSubKey(str + "\\0000"))
							{
								string text3;
								if ((text3 = (((registryKey2 != null) ? registryKey2.GetValue("DriverDesc") : null) as string)) == null)
								{
									text3 = (((registryKey2 != null) ? registryKey2.GetValue("HardwareInformation.AdapterString") : null) as string);
								}
								string text4 = text3;
								if (!string.IsNullOrWhiteSpace(text4))
								{
									list.Add(new GClass2.Class146(text4.Trim(), text4.Trim(), 0UL, string.Empty));
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}
		if (list.Count == 0)
		{
			return "Unknown GPU";
		}
		return (list.Where(new Func<GClass2.Class146, bool>(GClass2.Class147.class147_0.method_0)).OrderByDescending(new Func<GClass2.Class146, ulong>(GClass2.Class147.class147_0.method_1)).FirstOrDefault<GClass2.Class146>() ?? list[0]).Name;
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x0003D5CC File Offset: 0x0003B7CC
	public static string smethod_2()
	{
		try
		{
			Screen primaryScreen = Screen.PrimaryScreen;
			if (primaryScreen != null)
			{
				return string.Format("{0}x{1}", primaryScreen.Bounds.Width, primaryScreen.Bounds.Height);
			}
		}
		catch
		{
		}
		try
		{
			PManagerX.MonitorModel monitorModel = PManagerX.GetMonitors().FirstOrDefault(new Func<PManagerX.MonitorModel, bool>(GClass2.Class147.class147_0.method_2));
			if (monitorModel != null)
			{
				return string.Format("{0}x{1}", monitorModel.Width, monitorModel.Height);
			}
		}
		catch
		{
		}
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "\r\n                SELECT CurrentHorizontalResolution, CurrentVerticalResolution\r\n                FROM Win32_VideoController\r\n                WHERE CurrentHorizontalResolution > 0\r\n                  AND CurrentVerticalResolution  > 0");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object obj = managementObject["CurrentHorizontalResolution"];
					if (obj is uint)
					{
						uint num = (uint)obj;
						obj = managementObject["CurrentVerticalResolution"];
						if (obj is uint)
						{
							uint num2 = (uint)obj;
							if (num > 0U && num2 > 0U)
							{
								return string.Format("{0}x{1}", num, num2);
							}
						}
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch (ManagementException)
		{
		}
		catch
		{
		}
		return "Unknown";
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x0000649D File Offset: 0x0000469D
	private static string smethod_3(ulong ulong_0)
	{
		return string.Format("{0} MB", ulong_0 / 1048576UL);
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x000064BA File Offset: 0x000046BA
	private static string smethod_4(long long_0)
	{
		if (long_0 <= 0L)
		{
			return "Unknown";
		}
		return string.Format("{0} MB", long_0);
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x0003D78C File Offset: 0x0003B98C
	public static string smethod_5()
	{
		try
		{
			long num = GClass2.smethod_9();
			if (num > 0L)
			{
				return GClass2.smethod_4(num);
			}
		}
		catch
		{
		}
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					object obj = ((ManagementObject)managementBaseObject)["TotalPhysicalMemory"];
					if (obj is ulong)
					{
						ulong num2 = (ulong)obj;
						if (num2 > 0UL)
						{
							return GClass2.smethod_3(num2);
						}
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x0003D878 File Offset: 0x0003BA78
	public static string smethod_6()
	{
		try
		{
			long num = GClass2.smethod_8();
			if (num > 0L)
			{
				return GClass2.smethod_4(num);
			}
		}
		catch
		{
		}
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT FreePhysicalMemory FROM Win32_OperatingSystem");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					object obj = ((ManagementObject)managementBaseObject)["FreePhysicalMemory"];
					if (obj is ulong)
					{
						ulong num2 = (ulong)obj;
						if (num2 > 0UL)
						{
							return string.Format("{0} MB", num2 / 1024UL);
						}
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x0003D978 File Offset: 0x0003BB78
	public static string smethod_7()
	{
		try
		{
			long num = GClass2.smethod_9();
			long num2 = GClass2.smethod_8();
			if (num > 0L && num2 >= 0L && num >= num2)
			{
				return GClass2.smethod_3((ulong)((num - num2) * 1048576L));
			}
		}
		catch
		{
		}
		try
		{
			ulong num3 = 0UL;
			ulong num4 = 0UL;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize, FreePhysicalMemory FROM Win32_OperatingSystem");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object obj = managementObject["TotalVisibleMemorySize"];
					if (obj is ulong)
					{
						ulong num5 = (ulong)obj;
						num3 = num5;
					}
					obj = managementObject["FreePhysicalMemory"];
					if (obj is ulong)
					{
						ulong num6 = (ulong)obj;
						num4 = num6;
					}
				}
				if (num3 > 0UL && num3 >= num4)
				{
					return string.Format("{0} MB", (num3 - num4) / 1024UL);
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
	public static long smethod_8()
	{
		PManagerX.PerformanceInformation structure = default(PManagerX.PerformanceInformation);
		if (PManagerX.GetPerformanceInfo(ref structure, Marshal.SizeOf<PManagerX.PerformanceInformation>(structure)))
		{
			return Convert.ToInt64(structure.PhysicalAvailable.ToInt64() * structure.PageSize.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x0003DB38 File Offset: 0x0003BD38
	public static long smethod_9()
	{
		PManagerX.PerformanceInformation structure = default(PManagerX.PerformanceInformation);
		if (PManagerX.GetPerformanceInfo(ref structure, Marshal.SizeOf<PManagerX.PerformanceInformation>(structure)))
		{
			return Convert.ToInt64(structure.PhysicalTotal.ToInt64() * structure.PageSize.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x000064E0 File Offset: 0x000046E0
	public static string smethod_10()
	{
		return GClass2.smethod_11() ?? "Unknown";
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x0003DB90 File Offset: 0x0003BD90
	private static string smethod_11()
	{
		string result;
		try
		{
			int num = GClass2.smethod_14("SELECT SerialNumber, PartNumber, BankLabel, DeviceLocator FROM Win32_PhysicalMemory").Cast<ManagementObject>().Select(new Func<ManagementObject, string>(GClass2.Class147.class147_0.method_3)).Distinct(StringComparer.OrdinalIgnoreCase).Count<string>();
			result = ((num <= 0 || num > 8) ? null : num.ToString());
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x000064F1 File Offset: 0x000046F1
	public static string smethod_12()
	{
		string result;
		if ((result = GClass2.smethod_15()) == null && (result = GClass2.smethod_16()) == null)
		{
			result = (GClass2.smethod_17() ?? "Unknown");
		}
		return result;
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00006514 File Offset: 0x00004714
	public static string smethod_13()
	{
		string result;
		if ((result = GClass2.smethod_18()) == null)
		{
			result = (GClass2.smethod_19() ?? "Unknown");
		}
		return result;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x0000652E File Offset: 0x0000472E
	private static ManagementObjectCollection smethod_14(string string_0)
	{
		return new ManagementObjectSearcher(string_0).Get();
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x0003DC0C File Offset: 0x0003BE0C
	private static string smethod_15()
	{
		string result;
		try
		{
			uint? num = GClass2.smethod_14("SELECT ConfiguredClockSpeed FROM Win32_PhysicalMemory").Cast<ManagementObject>().Select(new Func<ManagementObject, uint?>(GClass2.Class147.class147_0.method_4)).Where(new Func<uint?, bool>(GClass2.Class147.class147_0.method_5)).Min<uint?>();
			result = ((num != null) ? num.Value.ToString() : null);
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x0003DCAC File Offset: 0x0003BEAC
	private static string smethod_16()
	{
		string result;
		try
		{
			uint? num = GClass2.smethod_14("SELECT Speed FROM Win32_PhysicalMemory").Cast<ManagementObject>().Select(new Func<ManagementObject, uint?>(GClass2.Class147.class147_0.method_6)).Where(new Func<uint?, bool>(GClass2.Class147.class147_0.method_7)).Min<uint?>();
			result = ((num != null) ? num.Value.ToString() : null);
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x0003DD4C File Offset: 0x0003BF4C
	private static string smethod_17()
	{
		string result;
		try
		{
			uint? num = GClass2.smethod_14("SELECT ExtClock FROM Win32_Processor").Cast<ManagementObject>().Select(new Func<ManagementObject, uint?>(GClass2.Class147.class147_0.method_8)).FirstOrDefault(new Func<uint?, bool>(GClass2.Class147.class147_0.method_9));
			result = ((num != null) ? (num.Value * 2U).ToString() : null);
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x0003DDE8 File Offset: 0x0003BFE8
	private static string smethod_18()
	{
		string result;
		try
		{
			ushort num = GClass2.smethod_14("SELECT SMBIOSMemoryType, MemoryType FROM Win32_PhysicalMemory").Cast<ManagementObject>().Select(new Func<ManagementObject, ushort>(GClass2.Class147.class147_0.method_10)).FirstOrDefault<ushort>();
			switch (num)
			{
			case 20:
				return "DDR";
			case 21:
				return "DDR2";
			case 22:
			case 23:
			case 25:
				break;
			case 24:
				return "DDR3";
			case 26:
				return "DDR4";
			default:
				if (num == 36)
				{
					return "DDR5";
				}
				break;
			}
			result = null;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x0003DEA4 File Offset: 0x0003C0A4
	private static string smethod_19()
	{
		int num;
		if (!int.TryParse(GClass2.smethod_12(), out num))
		{
			return null;
		}
		if (num >= 4800)
		{
			return "DDR5";
		}
		if (num >= 2133)
		{
			return "DDR4";
		}
		if (num >= 1066)
		{
			return "DDR3";
		}
		if (num >= 400)
		{
			return "DDR2";
		}
		return "DDR";
	}

	// Token: 0x020000EB RID: 235
	private sealed class Class146
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x0000653B File Offset: 0x0000473B
		public Class146(string string_3, string string_4, ulong ulong_1, string string_5)
		{
			this.string_0 = string_3;
			this.string_1 = string_4;
			this.ulong_0 = ulong_1;
			this.string_2 = string_5;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00006560 File Offset: 0x00004760
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00006568 File Offset: 0x00004768
		public string method_0()
		{
			return this.string_1;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00006570 File Offset: 0x00004770
		public ulong method_1()
		{
			return this.ulong_0;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00006578 File Offset: 0x00004778
		public string method_2()
		{
			return this.string_2;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0003DF04 File Offset: 0x0003C104
		public bool method_3()
		{
			return this.method_0().IndexOf("NVIDIA", StringComparison.OrdinalIgnoreCase) >= 0 || this.method_0().IndexOf("AMD", StringComparison.OrdinalIgnoreCase) >= 0 || this.method_0().IndexOf("ATI", StringComparison.OrdinalIgnoreCase) >= 0 || this.method_2().StartsWith("PCI\\VEN_10DE", StringComparison.OrdinalIgnoreCase) || this.method_2().StartsWith("PCI\\VEN_1002", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x040003CF RID: 975
		private readonly string string_0;

		// Token: 0x040003D0 RID: 976
		private readonly string string_1;

		// Token: 0x040003D1 RID: 977
		private readonly ulong ulong_0;

		// Token: 0x040003D2 RID: 978
		private readonly string string_2;
	}

	// Token: 0x020000EC RID: 236
	[Serializable]
	private sealed class Class147
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x0000658C File Offset: 0x0000478C
		internal bool method_0(GClass2.Class146 class146_0)
		{
			return class146_0.method_3();
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00006594 File Offset: 0x00004794
		internal ulong method_1(GClass2.Class146 class146_0)
		{
			return class146_0.method_1();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0000659C File Offset: 0x0000479C
		internal bool method_2(PManagerX.MonitorModel monitorModel_0)
		{
			return monitorModel_0.Width > 0 && monitorModel_0.Height > 0;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0003DF80 File Offset: 0x0003C180
		internal string method_3(ManagementObject managementObject_0)
		{
			string text = (managementObject_0["SerialNumber"] ?? string.Empty).ToString().Trim();
			if (!string.IsNullOrEmpty(text) && text != "00000000")
			{
				return text;
			}
			string text2 = (managementObject_0["PartNumber"] ?? string.Empty).ToString().Trim();
			if (!string.IsNullOrEmpty(text2))
			{
				return text2;
			}
			string str = (managementObject_0["BankLabel"] ?? string.Empty).ToString().Trim();
			string str2 = (managementObject_0["DeviceLocator"] ?? string.Empty).ToString().Trim();
			return str + "|" + str2;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000065B2 File Offset: 0x000047B2
		internal uint? method_4(ManagementObject managementObject_0)
		{
			return managementObject_0["ConfiguredClockSpeed"] as uint?;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000065CA File Offset: 0x000047CA
		internal bool method_5(uint? nullable_0)
		{
			return nullable_0 != null && nullable_0.Value > 0U;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000065E1 File Offset: 0x000047E1
		internal uint? method_6(ManagementObject managementObject_0)
		{
			return managementObject_0["Speed"] as uint?;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000065CA File Offset: 0x000047CA
		internal bool method_7(uint? nullable_0)
		{
			return nullable_0 != null && nullable_0.Value > 0U;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000065F9 File Offset: 0x000047F9
		internal uint? method_8(ManagementObject managementObject_0)
		{
			return managementObject_0["ExtClock"] as uint?;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000065CA File Offset: 0x000047CA
		internal bool method_9(uint? nullable_0)
		{
			return nullable_0 != null && nullable_0.Value > 0U;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0003E03C File Offset: 0x0003C23C
		internal ushort method_10(ManagementObject managementObject_0)
		{
			ushort valueOrDefault = (managementObject_0["SMBIOSMemoryType"] as ushort?).GetValueOrDefault();
			if (valueOrDefault == 0)
			{
				return (managementObject_0["MemoryType"] as ushort?).GetValueOrDefault();
			}
			return valueOrDefault;
		}

		// Token: 0x040003D3 RID: 979
		public static readonly GClass2.Class147 class147_0 = new GClass2.Class147();

		// Token: 0x040003D4 RID: 980
		public static Func<GClass2.Class146, bool> func_0;

		// Token: 0x040003D5 RID: 981
		public static Func<GClass2.Class146, ulong> func_1;

		// Token: 0x040003D6 RID: 982
		public static Func<PManagerX.MonitorModel, bool> func_2;

		// Token: 0x040003D7 RID: 983
		public static Func<ManagementObject, string> func_3;

		// Token: 0x040003D8 RID: 984
		public static Func<ManagementObject, uint?> func_4;

		// Token: 0x040003D9 RID: 985
		public static Func<uint?, bool> func_5;

		// Token: 0x040003DA RID: 986
		public static Func<ManagementObject, uint?> func_6;

		// Token: 0x040003DB RID: 987
		public static Func<uint?, bool> func_7;

		// Token: 0x040003DC RID: 988
		public static Func<ManagementObject, uint?> func_8;

		// Token: 0x040003DD RID: 989
		public static Func<uint?, bool> func_9;

		// Token: 0x040003DE RID: 990
		public static Func<ManagementObject, ushort> func_10;
	}
}
