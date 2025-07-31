using System;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x02000617 RID: 1559
public static class GClass267
{
	// Token: 0x060027B2 RID: 10162 RVA: 0x0001A57D File Offset: 0x0001877D
	public static bool smethod_0(int int_0)
	{
		return (ulong)GClass267.smethod_1() >= (ulong)((long)int_0);
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x0009B9D0 File Offset: 0x00099BD0
	public static uint smethod_1()
	{
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"))
		{
			uint result;
			if (registryKey != null && uint.TryParse((registryKey.GetValue("CurrentBuildNumber") as string) ?? (registryKey.GetValue("CurrentBuild") as string), out result))
			{
				return result;
			}
		}
		return 0U;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x0001A58C File Offset: 0x0001878C
	public static string smethod_2()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x0001A595 File Offset: 0x00018795
	public static bool smethod_3()
	{
		return Class243.smethod_0().Contains("11");
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x0001A5A7 File Offset: 0x000187A7
	public static bool smethod_4()
	{
		return Class243.smethod_0().Contains("10");
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x0009BA44 File Offset: 0x00099C44
	public static bool smethod_5()
	{
		string text = Class243.smethod_1();
		return text.Count<char>() == 4 && Convert.ToInt32(text.Substring(0, 2)) > 21;
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x0001A5B9 File Offset: 0x000187B9
	public static bool smethod_6()
	{
		return SystemInformation.PowerStatus.BatteryChargeStatus != BatteryChargeStatus.NoSystemBattery;
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x0009BA74 File Offset: 0x00099C74
	public static bool smethod_7()
	{
		bool result;
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0"))
			{
				result = registryKey.GetValue("ProcessorNameString").ToString().Contains("Intel(R)");
			}
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x0009BAE0 File Offset: 0x00099CE0
	public static bool smethod_8()
	{
		string text = string.Empty;
		try
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					text = ((ManagementObject)enumerator.Current)["Name"].ToString();
				}
			}
			if (text.Split(new char[]
			{
				'-'
			}).Last<string>().Contains("K"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x0009BB8C File Offset: 0x00099D8C
	public static bool smethod_9()
	{
		int num = 1050;
		int num2 = 5600;
		int num3 = 1000;
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_VideoController");
		try
		{
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				string text = managementBaseObject["Name"].ToString();
				if (text.Contains("NVIDIA"))
				{
					if (GClass267.smethod_10(text) >= num)
					{
						return true;
					}
				}
				else if (text.Contains("Radeon"))
				{
					if (GClass267.smethod_10(text) >= num2)
					{
						return true;
					}
				}
				else if (text.Contains("Intel") && GClass267.smethod_10(text) >= num3)
				{
					return true;
				}
			}
		}
		catch
		{
			return false;
		}
		return false;
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x0009BC74 File Offset: 0x00099E74
	private static int smethod_10(string string_0)
	{
		Match match = Regex.Match(string_0, "\\d+");
		int result;
		if (match.Success && int.TryParse(match.Value, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x0009BCA8 File Offset: 0x00099EA8
	public static Version smethod_11()
	{
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", false))
			{
				if (registryKey != null)
				{
					object value = registryKey.GetValue("CurrentMajorVersionNumber");
					object value2 = registryKey.GetValue("CurrentMinorVersionNumber");
					object value3 = registryKey.GetValue("CurrentBuildNumber");
					object value4 = registryKey.GetValue("UBR");
					int major;
					int minor;
					if (value is int)
					{
						int num = (int)value;
						if (value2 is int)
						{
							int num2 = (int)value2;
							major = num;
							minor = num2;
							goto IL_B6;
						}
					}
					string text = registryKey.GetValue("CurrentVersion") as string;
					Version version;
					if (string.IsNullOrEmpty(text) || !Version.TryParse(text, out version))
					{
						throw new InvalidOperationException("Не удалось определить Major/Minor из реестра");
					}
					major = version.Major;
					minor = version.Minor;
					IL_B6:
					string text2 = value3 as string;
					int num3;
					int build;
					if (text2 != null && int.TryParse(text2, out num3))
					{
						build = num3;
					}
					else
					{
						if (!(value3 is int))
						{
							throw new InvalidOperationException("Не удалось определить Build из реестра");
						}
						int num4 = (int)value3;
						build = num4;
					}
					int revision;
					if (value4 is int)
					{
						int num5 = (int)value4;
						revision = num5;
					}
					else
					{
						revision = 0;
					}
					return new Version(major, minor, build, revision);
				}
			}
		}
		catch
		{
		}
		Version result;
		try
		{
			result = Environment.OSVersion.Version;
		}
		catch
		{
			result = new Version(0, 0, 0, 0);
		}
		return result;
	}
}
