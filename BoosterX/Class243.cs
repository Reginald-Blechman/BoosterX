using System;
using System.Linq;
using System.Management;
using System.Security.Principal;
using Microsoft.Win32;

// Token: 0x02000207 RID: 519
internal sealed class Class243
{
	// Token: 0x06000E07 RID: 3591 RVA: 0x00050D00 File Offset: 0x0004EF00
	public static string smethod_0()
	{
		object obj = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>().Select(new Func<ManagementObject, object>(Class243.Class244.class244_0.method_0)).FirstOrDefault<object>();
		if (obj == null)
		{
			return "Unknown";
		}
		return obj.ToString();
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00050D5C File Offset: 0x0004EF5C
	public static string smethod_1()
	{
		string result;
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"))
			{
				result = registryKey.GetValue("DisplayVersion").ToString();
			}
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x0000A701 File Offset: 0x00008901
	public static int smethod_2()
	{
		return new ManagementObjectSearcher("Select * from Win32_Processor").Get().Cast<ManagementBaseObject>().Sum(new Func<ManagementBaseObject, int>(Class243.Class244.class244_0.method_1));
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x0000A73C File Offset: 0x0000893C
	public static int smethod_3()
	{
		return new ManagementObjectSearcher("Select * from Win32_Processor").Get().Cast<ManagementBaseObject>().Sum(new Func<ManagementBaseObject, int>(Class243.Class244.class244_0.method_2));
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00050DC0 File Offset: 0x0004EFC0
	public static void smethod_4(string string_1, bool bool_0)
	{
		string text = null;
		try
		{
			text = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer").GetValue("SettingsPageVisibility").ToString();
		}
		catch
		{
			if (bool_0)
			{
				return;
			}
		}
		if (bool_0 && text != null)
		{
			if (!text.EndsWith(";") && !text.EndsWith(":"))
			{
				text += ";";
			}
			string str = text.Replace(string_1 + ";", string.Empty);
			Class808.smethod_27("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v SettingsPageVisibility /t REG_SZ /d " + str + " /f");
			return;
		}
		if (!bool_0 && text != null)
		{
			if (!text.EndsWith(";") && !text.EndsWith(":"))
			{
				text += ";";
			}
			string str = text + string_1 + ";";
			Class808.smethod_27("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v SettingsPageVisibility /t REG_SZ /d " + str + " /f");
			return;
		}
		if (!bool_0 && text == null)
		{
			string str = "hide:" + string_1 + ";";
			Class808.smethod_27("REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v SettingsPageVisibility /t REG_SZ /d " + str + " /f");
			return;
		}
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x0000A777 File Offset: 0x00008977
	public static string smethod_5()
	{
		if (!Class243.string_0.smethod_9())
		{
			return Class243.string_0;
		}
		Class243.string_0 = WindowsIdentity.GetCurrent().User.Value;
		return Class243.string_0;
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00050EF4 File Offset: 0x0004F0F4
	public static bool smethod_6()
	{
		if (Class243.nullable_0 != null)
		{
			return Class243.nullable_0.Value;
		}
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem WHERE BootupState LIKE 'Fail-safe%'");
			try
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					Class243.nullable_0 = new bool?(managementObjectCollection.Count > 0);
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
			Class243.nullable_0 = new bool?(false);
		}
		return Class243.nullable_0.Value;
	}

	// Token: 0x04000910 RID: 2320
	public static string string_0 = string.Empty;

	// Token: 0x04000911 RID: 2321
	private static bool? nullable_0;

	// Token: 0x02000208 RID: 520
	[Serializable]
	private sealed class Class244
	{
		// Token: 0x06000E10 RID: 3600 RVA: 0x0000A7B0 File Offset: 0x000089B0
		internal object method_0(ManagementObject managementObject_0)
		{
			return managementObject_0.GetPropertyValue("Caption");
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0000A7BE File Offset: 0x000089BE
		internal int method_1(ManagementBaseObject managementBaseObject_0)
		{
			return int.Parse(managementBaseObject_0["NumberOfLogicalProcessors"].ToString());
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0000A7D6 File Offset: 0x000089D6
		internal int method_2(ManagementBaseObject managementBaseObject_0)
		{
			return int.Parse(managementBaseObject_0["NumberOfCores"].ToString());
		}

		// Token: 0x04000912 RID: 2322
		public static readonly Class243.Class244 class244_0 = new Class243.Class244();

		// Token: 0x04000913 RID: 2323
		public static Func<ManagementObject, object> func_0;

		// Token: 0x04000914 RID: 2324
		public static Func<ManagementBaseObject, int> func_1;

		// Token: 0x04000915 RID: 2325
		public static Func<ManagementBaseObject, int> func_2;
	}
}
