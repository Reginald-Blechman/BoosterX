using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ElevRightsX;
using Microsoft.Win32;

// Token: 0x020004E9 RID: 1257
internal sealed class Class600
{
	// Token: 0x06001FDF RID: 8159 RVA: 0x00081590 File Offset: 0x0007F790
	public static void smethod_0()
	{
		Class600.smethod_2();
		if (Class673.smethod_19() == "BEST")
		{
			return;
		}
		Class600.smethod_3();
		if (Class673.smethod_19() == "BEST")
		{
			return;
		}
		Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Debloat", "RemoveEgde.bat", false);
		Class808.smethod_27(Path.Combine(Class169.string_4, "RemoveEgde.bat"));
		File.Delete(Path.Combine(Class169.string_4, "RemoveEgde.bat"));
		if (Class673.smethod_19() == "BEST")
		{
			return;
		}
		Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Debloat", "EdgeRemover2.bat", false);
		Class808.smethod_27(Path.Combine(Class169.string_4, "EdgeRemover2.bat"));
		Class808.smethod_27(Path.Combine(Class169.string_4, "EdgeRemover2.bat"));
		Class808.smethod_27(Path.Combine(Class169.string_4, "EdgeRemover2.bat"));
		File.Delete(Path.Combine(Class169.string_4, "EdgeRemover2.bat"));
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x0008169C File Offset: 0x0007F89C
	public static void smethod_1(string string_0)
	{
		try
		{
			string keyName = "HKEY_USERS\\.DEFAULT\\Control Panel\\International\\Geo";
			object value = Registry.GetValue(keyName, "Nation", null);
			Registry.SetValue(keyName, "Nation", "84", RegistryValueKind.String);
			string name = "ClientState\\" + string_0;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(name, true))
				{
					if (registryKey2 == null)
					{
						return;
					}
					try
					{
						registryKey2.DeleteValue("experiment_control_labels", false);
					}
					catch
					{
					}
					string environmentVariable = Environment.GetEnvironmentVariable("SystemRoot");
					if (string.IsNullOrEmpty(environmentVariable))
					{
						return;
					}
					string text = Path.Combine(environmentVariable, "SystemApps", "Microsoft.MicrosoftEdge_8wekyb3d8bbwe");
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllBytes(Path.Combine(text, "MicrosoftEdge.exe"), new byte[0]);
					Environment.SetEnvironmentVariable("windir", string.Empty, EnvironmentVariableTarget.Process);
					string text2 = registryKey2.GetValue("UninstallString") as string;
					string text3 = registryKey2.GetValue("UninstallArguments") as string;
					if (string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
					{
						return;
					}
					text3 += " --force-uninstall --delete-profile";
					text2 = text2.Trim(new char[]
					{
						'"'
					});
					if (!File.Exists(text2))
					{
						return;
					}
					Process.Start(new ProcessStartInfo
					{
						FileName = text2,
						Arguments = text3,
						UseShellExecute = false,
						CreateNoWindow = true
					}).WaitForExit();
				}
			}
			Registry.SetValue(keyName, "Nation", value, RegistryValueKind.String);
			using (RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
			{
				using (RegistryKey registryKey4 = registryKey3.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\EdgeUpdate", false))
				{
					if (registryKey4 != null)
					{
						object value2 = registryKey4.GetValue("IsEdgeStableUninstalled");
						if (value2 != null)
						{
							value2.ToString();
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x00081930 File Offset: 0x0007FB30
	public static bool smethod_2()
	{
		bool result;
		try
		{
			string name = "SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Microsoft Edge";
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(name, true))
				{
					if (registryKey2 != null)
					{
						try
						{
							registryKey2.DeleteValue("NoRemove", false);
						}
						catch
						{
						}
					}
				}
			}
			string name2 = "SOFTWARE\\WOW6432Node\\Microsoft\\EdgeUpdateDev";
			using (RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
			{
				using (RegistryKey registryKey4 = registryKey3.OpenSubKey(name2, true))
				{
					if (registryKey4 != null)
					{
						registryKey4.SetValue("AllowUninstall", 1, RegistryValueKind.DWord);
					}
				}
			}
			Class600.smethod_1("{56EB18F8-B008-4CBD-B6D2-8C97FE7E9062}");
			string[] array = new string[]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory),
				Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
			};
			for (int i = 0; i < array.Length; i++)
			{
				string path = Path.Combine(array[i], "Microsoft Edge.lnk");
				if (File.Exists(path))
				{
					try
					{
						File.Delete(path);
					}
					catch
					{
					}
				}
			}
			return true;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x00081B00 File Offset: 0x0007FD00
	public static bool smethod_3()
	{
		bool result;
		try
		{
			string text = "C:\\Windows\\System32\\IntegratedServicesRegionPolicySet.json";
			TrustedBypass.TrustedCrack("cmd /c del \"" + text + "\"", false);
			Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Debloat", "edge.json", false);
			TrustedBypass.TrustedCrack(string.Concat(new string[]
			{
				"cmd /c move \"",
				Path.Combine(Class169.string_4, "edge.json"),
				"\" \"",
				text,
				"\""
			}), false);
			Class808.smethod_27("taskkill /F /IM msedge.exe");
			Class808.smethod_27("taskkill /F /IM MicrosoftEdgeUpdate.exe");
			Class808.smethod_27("reg add \"HKLM\\SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Microsoft Edge\" /v \"NoRemove\" /t REG_DWORD /d 0 /f");
			Class808.smethod_27("reg delete \"HKLM\\SOFTWARE\\WOW6432Node\\Microsoft\\EdgeUpdate\\ClientState\\{56EB18F8-B008-4CBD-B6D2-8C97FE7E9062}\" /v \"experiment_control_labels\" /f");
			Class808.smethod_27("reg add \"HKLM\\SOFTWARE\\WOW6432Node\\Microsoft\\EdgeUpdateDev\" /v \"AllowUninstall\" /t REG_DWORD /d 1 /f");
			List<string> list = new List<string>();
			try
			{
				list.AddRange(Directory.GetDirectories("C:\\Program Files (x86)\\Microsoft\\Edge\\Application").ToList<string>().Where(new Func<string, bool>(Class600.Class601.class601_0.method_0)).ToList<string>());
				foreach (string str in list)
				{
					Class808.smethod_27("\"" + str + "\\Installer\\setup.exe\" --uninstall --force-uninstall --msedge --system-level --verbose-logging");
					Class808.smethod_27("\"" + str + "\\Installer\\setup.exe\" --uninstall --force-uninstall --msedge --system-level --verbose-logging");
					Class808.smethod_29("Get-AppxPackage *MicrosoftEdge* | Remove-AppxPackage");
				}
			}
			catch (Exception exception_)
			{
				GClass268.smethod_1(exception_);
			}
			if (list != null || list.Count > 0)
			{
				list.Clear();
			}
			try
			{
				list.AddRange(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages").GetSubKeyNames().ToList<string>().Where(new Func<string, bool>(Class600.Class601.class601_0.method_1)).ToList<string>());
				foreach (string text2 in list)
				{
					Class808.smethod_27("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text2 + "\" /v Visibility /t REG_DWORD /d 1 /f");
					Class808.smethod_27("reg delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text2 + "\\Owners\" /va /f");
					Class359.smethod_2(text2);
					Class808.smethod_29("Get-AppxPackage *MicrosoftEdge* | Remove-AppxPackage");
				}
			}
			catch
			{
			}
			if (list != null || list.Count > 0)
			{
				list.Clear();
			}
			try
			{
				list.AddRange(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages").GetSubKeyNames().ToList<string>().Where(new Func<string, bool>(Class600.Class601.class601_0.method_2)).ToList<string>());
				foreach (string text3 in list)
				{
					Class808.smethod_27("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text3 + "\" /v Visibility /t REG_DWORD /d 1 /f");
					Class808.smethod_27("reg delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Component Based Servicing\\Packages\\" + text3 + "\\Owners\" /va /f");
					Class359.smethod_2(text3);
					Class808.smethod_29("Get-AppxPackage *edge* | Remove-AppxPackage");
				}
			}
			catch
			{
			}
			Class808.smethod_27("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\EdgeUpdate\" /v \"DoNotUpdateToEdgeWithChromium\" /t REG_DWORD /d 1 /f");
			return true;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x020004EA RID: 1258
	[Serializable]
	private sealed class Class601
	{
		// Token: 0x06001FE5 RID: 8165 RVA: 0x000151A9 File Offset: 0x000133A9
		internal bool method_0(string string_0)
		{
			return string_0 != "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\SetupMetrics";
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000151B7 File Offset: 0x000133B7
		internal bool method_1(string string_0)
		{
			return string_0.StartsWith("Microsoft-Windows-Internet-Browser-Package");
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000151C5 File Offset: 0x000133C5
		internal bool method_2(string string_0)
		{
			return string_0.StartsWith("Microsoft-Windows-MicrosoftEdgeDevToolsClient-Package");
		}

		// Token: 0x04001543 RID: 5443
		public static readonly Class600.Class601 class601_0 = new Class600.Class601();

		// Token: 0x04001544 RID: 5444
		public static Func<string, bool> func_0;

		// Token: 0x04001545 RID: 5445
		public static Func<string, bool> func_1;

		// Token: 0x04001546 RID: 5446
		public static Func<string, bool> func_2;
	}
}
