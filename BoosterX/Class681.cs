using System;
using Microsoft.Win32;

// Token: 0x02000582 RID: 1410
internal sealed class Class681
{
	// Token: 0x06002377 RID: 9079 RVA: 0x0008B5E0 File Offset: 0x000897E0
	public static string smethod_0(string string_0, string string_1)
	{
		string text = string_0.Split(new char[]
		{
			'\\'
		})[0].ToLower();
		RegistryKey registryKey = Class681.smethod_1(text);
		string name = string_0.ToLower().Replace(text + "\\", string.Empty);
		string result;
		try
		{
			result = registryKey.OpenSubKey(name).GetValue((string_1 == "/ve") ? string.Empty : string_1).ToString();
		}
		catch
		{
			result = "Null";
		}
		return result;
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x0008B670 File Offset: 0x00089870
	private static RegistryKey smethod_1(string string_0)
	{
		if (string_0 == "hklm")
		{
			return Registry.LocalMachine;
		}
		if (string_0 == "hkey_local_machine")
		{
			return Registry.LocalMachine;
		}
		if (string_0 == "hkcu")
		{
			return Registry.CurrentUser;
		}
		if (string_0 == "hkey_current_user")
		{
			return Registry.CurrentUser;
		}
		if (string_0 == "hkcr")
		{
			return Registry.ClassesRoot;
		}
		if (!(string_0 == "hkey_classes_root"))
		{
			return Registry.LocalMachine;
		}
		return Registry.ClassesRoot;
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x0008B6FC File Offset: 0x000898FC
	public static bool smethod_2(string string_0, string string_1)
	{
		string text = string_0.Split(new char[]
		{
			'\\'
		})[0].ToLower();
		RegistryKey registryKey = Class681.smethod_1(text);
		string name = string_0.ToLower().Replace(text + "\\", string.Empty);
		bool result;
		try
		{
			registryKey.OpenSubKey(name).GetValue((string_1 == "/ve") ? string.Empty : string_1).ToString();
			result = true;
		}
		catch
		{
			result = false;
		}
		return result;
	}
}
