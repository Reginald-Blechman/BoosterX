using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using PIManagerX;

// Token: 0x02000615 RID: 1557
internal sealed class Class747
{
	// Token: 0x06002799 RID: 10137 RVA: 0x0009ACE8 File Offset: 0x00098EE8
	public static void smethod_0(string string_0, string string_1)
	{
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 3:
				if (!(string_0 == "LIR"))
				{
					return;
				}
				Class747.smethod_1(string_1);
				break;
			case 4:
			case 5:
			case 6:
			case 9:
			case 10:
				break;
			case 7:
				if (!(string_0 == "MITWEAK"))
				{
					return;
				}
				Class747.smethod_6(string_1);
				return;
			case 8:
			{
				char c = string_0[0];
				if (c != 'D')
				{
					if (c != 'M')
					{
						if (c != 'W')
						{
							return;
						}
						if (!(string_0 == "WFPTWEAK"))
						{
							return;
						}
						Class747.smethod_2(string_1);
						return;
					}
					else
					{
						if (!(string_0 == "MELTDOWN"))
						{
							return;
						}
						Class747.smethod_3("MELTDOWN", string_1);
						return;
					}
				}
				else
				{
					if (!(string_0 == "DOWNFALL"))
					{
						return;
					}
					Class747.smethod_3("DOWNFALL", string_1);
					return;
				}
				break;
			}
			case 11:
			{
				char c = string_0[4];
				if (c <= 'O')
				{
					if (c != 'A')
					{
						if (c != 'F')
						{
							if (c != 'O')
							{
								return;
							}
							if (!(string_0 == "DEBLOATEDGE"))
							{
								return;
							}
							Class600.smethod_0();
							return;
						}
						else
						{
							if (!(string_0 == "DWMOFFTWEAK"))
							{
								return;
							}
							Class747.smethod_9(string_1);
							return;
						}
					}
					else
					{
						if (!(string_0 == "VISUALTWEAK"))
						{
							return;
						}
						Class747.smethod_11(string_1);
						return;
					}
				}
				else if (c != 'R')
				{
					if (c != 'V')
					{
						if (c != 'W')
						{
							return;
						}
						if (string_0 == "VBSTWEAKW11")
						{
							Class747.smethod_4(string_1);
							return;
						}
						if (!(string_0 == "VBSTWEAKW10"))
						{
							return;
						}
						Class747.smethod_5(string_1);
						return;
					}
					else
					{
						if (!(string_0 == "REMOVEFONTS"))
						{
							return;
						}
						Class747.smethod_8(string_1);
						return;
					}
				}
				else
				{
					if (!(string_0 == "HYBERNATION"))
					{
						return;
					}
					Class747.smethod_7(string_1);
					return;
				}
				break;
			}
			case 12:
				if (!(string_0 == "SVCHOSTTWEAK"))
				{
					return;
				}
				Class747.smethod_16(string_1);
				return;
			case 13:
			{
				char c = string_0[0];
				if (c != 'D')
				{
					if (c != 'S')
					{
						return;
					}
					if (!(string_0 == "SPECTREONBEST"))
					{
						return;
					}
					Class747.smethod_3("SPECTREONBEST", string_1);
					return;
				}
				else
				{
					if (!(string_0 == "DEFENDERTWEAK"))
					{
						return;
					}
					Class747.smethod_12(string_1);
					return;
				}
				break;
			}
			case 14:
				if (!(string_0 == "SPECTREOFFBEST"))
				{
					return;
				}
				Class747.smethod_3("SPECTREOFFBEST", string_1);
				return;
			case 15:
			{
				char c = string_0[0];
				if (c != 'D')
				{
					if (c != 'R')
					{
						return;
					}
					if (!(string_0 == "RUNTRUSTEDTWEAK"))
					{
						return;
					}
					Class747.smethod_10(string_1);
					return;
				}
				else
				{
					if (!(string_0 == "DEFENDERDEBLOAT"))
					{
						return;
					}
					Class189.smethod_0();
					return;
				}
				break;
			}
			case 16:
				if (!(string_0 == "SMARTSCREENTWEAK"))
				{
					return;
				}
				Class747.smethod_15(string_1);
				return;
			default:
				return;
			}
		}
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x0009AF6C File Offset: 0x0009916C
	public static bool smethod_1(string string_0)
	{
		int num = string.Equals(string_0, "BEST", StringComparison.OrdinalIgnoreCase) ? 4 : 2;
		string arg = Class747.guid_0.ToString("D");
		string arg2 = Class747.guid_1.ToString("D");
		string string_ = string.Format("powercfg /SETACVALUEINDEX SCHEME_CURRENT {0} {1} {2}", arg, arg2, num);
		string string_2 = string.Format("powercfg /SETDCVALUEINDEX SCHEME_CURRENT {0} {1} {2}", arg, arg2, num);
		bool result;
		try
		{
			Class808.smethod_27(string_);
			Class808.smethod_27(string_2);
			result = true;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x0009B004 File Offset: 0x00099204
	private static void smethod_2(string string_0)
	{
		try
		{
			if (string_0 == "BEST")
			{
				WfpManager.Enable();
			}
			else
			{
				WfpManager.Disable();
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x0009B044 File Offset: 0x00099244
	private static void smethod_3(string string_0, string string_1)
	{
		string_1 = ((string_1 != null) ? string_1.ToUpperInvariant() : null);
		uint num;
		bool flag;
		if (!(string_0 == "SPECTREONBEST"))
		{
			if (!(string_0 == "SPECTREOFFBEST"))
			{
				if (!(string_0 == "MELTDOWN"))
				{
					if (!(string_0 == "DOWNFALL"))
					{
						return;
					}
					num = 33554432U;
					flag = (string_1 == "BEST");
				}
				else
				{
					num = 2U;
					flag = (string_1 == "BEST");
				}
			}
			else
			{
				num = 1U;
				flag = (string_1 == "BEST");
			}
		}
		else
		{
			num = 1U;
			flag = (string_1 == "DEFAULT");
		}
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true))
		{
			if (registryKey != null)
			{
				uint num2 = Class747.smethod_17(registryKey, "FeatureSettingsOverride");
				uint num3 = Class747.smethod_17(registryKey, "FeatureSettingsOverrideMask");
				if (flag)
				{
					num2 |= num;
				}
				else
				{
					num2 &= ~num;
				}
				num3 |= num;
				registryKey.SetValue("FeatureSettingsOverride", num2, RegistryValueKind.DWord);
				registryKey.SetValue("FeatureSettingsOverrideMask", num3, RegistryValueKind.DWord);
			}
		}
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x0009B16C File Offset: 0x0009936C
	private static void smethod_4(string string_0)
	{
		if (string_0 == "BEST")
		{
			GClass290.smethod_1("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\HypervisorEnforcedCodeIntegrity\" /v \"Enabled\" /t REG_DWORD /d \"0\" /f", false);
			GClass290.smethod_1("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\KernelShadowStacks\" /v \"Enabled\" /t REG_DWORD /d \"0\" /f", false);
			GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\KernelShadowStacks\" /v \"ChangedInBootCycle\" /f", false);
			GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\KernelShadowStacks\" /v \"WasEnabledBy\" /f", false);
			GClass290.smethod_1("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\CredentialGuard\" /v \"Enabled\" /t REG_DWORD /d \"0\" /f", false);
			GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\CredentialGuard\" /v \"ChangedInBootCycle\" /f", false);
			GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\CredentialGuard\" /v \"WasEnabledBy\" /f", false);
			GClass290.smethod_1("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Lsa\" /v \"RunAsPPL\" /t REG_DWORD /d \"0\" /f", false);
			GClass290.smethod_1("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /v \"EnableVirtualizationBasedSecurity\" /t REG_DWORD /d \"0\" /f", false);
			return;
		}
		GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\HypervisorEnforcedCodeIntegrity\" /f", false);
		GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\KernelShadowStacks\" /f", false);
		GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\CredentialGuard\" /f", false);
		GClass290.smethod_1("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Lsa\" /v \"RunAsPPL\" /t REG_DWORD /d \"2\" /f", false);
		GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /v \"EnableVirtualizationBasedSecurity\" /f", false);
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x0001A443 File Offset: 0x00018643
	private static void smethod_5(string string_0)
	{
		if (string_0 == "BEST")
		{
			GClass290.smethod_1("Reg.exe add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /v \"EnableVirtualizationBasedSecurity\" /t REG_DWORD /d \"0\" /f", false);
			return;
		}
		GClass290.smethod_1("Reg.exe delete \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /v \"EnableVirtualizationBasedSecurity\" /f", false);
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x0001A46E File Offset: 0x0001866E
	private static void smethod_6(string string_0)
	{
		if (string_0 == "BEST")
		{
			GClass290.smethod_1("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\HypervisorEnforcedCodeIntegrity\" /v \"Enabled\" /t REG_DWORD /d \"0\" /f", false);
			return;
		}
		GClass290.smethod_1("Reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\HypervisorEnforcedCodeIntegrity\" /v \"Enabled\" /f", false);
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x0001A499 File Offset: 0x00018699
	private static void smethod_7(string string_0)
	{
		if (string_0 == "BEST")
		{
			Class808.smethod_27("powercfg /h off");
			Class808.smethod_27("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power\" /v \"HiberbootEnabled\" /t REG_DWORD /d \"0\" /f");
			return;
		}
		Class808.smethod_27("powercfg /h on");
		Class808.smethod_27("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power\" /v \"HiberbootEnabled\" /t REG_DWORD /d \"1\" /f");
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x0009B244 File Offset: 0x00099444
	private static void smethod_8(string string_0)
	{
		if (string_0 == "BEST")
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts");
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (string text in registryKey.GetValueNames())
			{
				dictionary.Add(text, registryKey.GetValue(text).ToString());
			}
			string[] array2 = new string[]
			{
				"Segoe UI",
				"Segoe MDL2 Assets",
				"Consolas",
				"Lucida Console",
				"Microsoft Sans Serif",
				"Tahoma"
			};
			using (Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				IL_175:
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					bool flag = false;
					string[] array = array2;
					int i = 0;
					while (i < array.Length)
					{
						string value = array[i];
						if (!keyValuePair.Key.StartsWith(value))
						{
							i++;
						}
						else
						{
							flag = true;
							IL_DA:
							if (!flag)
							{
								Class808.smethod_27("Reg.exe delete \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts\" /v \"" + keyValuePair.Key + "\" /f");
								Class808.smethod_27("Reg.exe delete \"HKLM\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Fonts\" /v \"" + keyValuePair.Key + "\" /f");
								string text2 = Path.Combine("C:\\Windows\\Fonts", keyValuePair.Value);
								GClass290.smethod_0("cmd /c del /f /q \"" + text2 + "\"", false);
								GClass290.smethod_0("cmd /c del /f /q \"" + text2.Split(new char[]
								{
									'.'
								})[0] + ".fon\"", false);
								goto IL_175;
							}
							goto IL_175;
						}
					}
					goto IL_DA;
				}
			}
		}
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x0009B3F4 File Offset: 0x000995F4
	private static void smethod_9(string string_0)
	{
		Class808.smethod_22();
		Class808.smethod_23("explorer");
		Class808.smethod_23("sihost");
		GClass290.smethod_0("cmd /c REN C:\\Windows\\System32\\dwm.exe dwmx.exe", false);
		GClass290.smethod_0("cmd /c copy C:\\Windows\\System32\\rundll32.exe C:\\Windows\\System32\\dwm.exe", false);
		GClass290.smethod_0("cmd /c REN C:\\Windows\\System32\\Windows.UI.Logon.dll Windows.UI.LogonX.dll", false);
		GClass290.smethod_0("cmd /c REN C:\\Windows\\SystemApps SystemAppsX", false);
		Class808.smethod_26("winlogon");
		Class808.smethod_18();
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x0009B460 File Offset: 0x00099660
	private static void smethod_10(string string_0)
	{
		if (string_0 == "BEST")
		{
			Class808.smethod_27("Reg.exe add \"HKCR\\regfile\\shell\\BoosterX\" /v \"MUIVerb\" /t REG_SZ /d \"" + Class298.smethod_2("RunAsTrusted") + "\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\regfile\\shell\\BoosterX\" /v \"Icon\" /t REG_SZ /d \"\\\\\"" + Class551.class753_0.method_6() + "\\\\\", 4\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\regfile\\shell\\BoosterX\\Command\" /ve /t REG_SZ /d \"\\\"" + Class551.class753_0.method_6() + "\\\" \\\"%1\\\"\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\exefile\\shell\\BoosterX\" /v \"MUIVerb\" /t REG_SZ /d \"" + Class298.smethod_2("RunAsTrusted") + "\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\exefile\\shell\\BoosterX\" /v \"Icon\" /t REG_SZ /d \"\\\"" + Class551.class753_0.method_6() + "\\\", 4\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\exefile\\shell\\BoosterX\\Command\" /ve /t REG_SZ /d \"\\\"" + Class551.class753_0.method_6() + "\\\" \\\"%1\\\"\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\batfile\\shell\\BoosterX\" /v \"MUIVerb\" /t REG_SZ /d \"" + Class298.smethod_2("RunAsTrusted") + "\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\batfile\\shell\\BoosterX\" /v \"Icon\" /t REG_SZ /d \"\\\"" + Class551.class753_0.method_6() + "\\\", 4\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\batfile\\shell\\BoosterX\\Command\" /ve /t REG_SZ /d \"\\\"" + Class551.class753_0.method_6() + "\\\" \\\"%1\\\"\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\Microsoft.PowerShellScript.1\\shell\\BoosterX\" /v \"MUIVerb\" /t REG_SZ /d \"" + Class298.smethod_2("RunAsTrusted") + "\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\Microsoft.PowerShellScript.1\\shell\\BoosterX\" /v \"Icon\" /t REG_SZ /d \"\\\"" + Class551.class753_0.method_6() + "\\\", 4\" /f");
			Class808.smethod_27("Reg.exe add \"HKCR\\Microsoft.PowerShellScript.1\\shell\\BoosterX\\Command\" /ve /t REG_SZ /d \"\\\"" + Class551.class753_0.method_6() + "\\\" \\\"%1\\\"\" /f");
			return;
		}
		Class808.smethod_27("Reg.exe delete \"HKCR\\regfile\\shell\\BoosterX\" /f\"");
		Class808.smethod_27("Reg.exe delete \"HKCR\\exefile\\shell\\BoosterX\" /f\"");
		Class808.smethod_27("Reg.exe delete \"HKCR\\batfile\\shell\\BoosterX\" /f\"");
		Class808.smethod_27("Reg.exe delete \"HKCR\\Microsoft.PowerShellScript.1\\shell\\BoosterX\" /f\"");
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x0001A4D6 File Offset: 0x000186D6
	private static void smethod_11(string string_0)
	{
		if (string_0 == "BEST")
		{
			Class811.smethod_0(true);
			return;
		}
		if (string_0 == "OPTIMAL")
		{
			Class811.smethod_0(true);
			return;
		}
		Class811.smethod_0(false);
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x0001A508 File Offset: 0x00018708
	public static void smethod_12(string string_0)
	{
		if (string_0 == "BEST")
		{
			Class747.smethod_13();
			return;
		}
		Class747.smethod_14();
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x0009B630 File Offset: 0x00099830
	public static void smethod_13()
	{
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!DisableAntiSpyware", "1", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!AllowFastServiceStartup", "0", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!ServiceKeepAlive", "0", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableIOAVProtection", "1", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableOnAccessProtection", "1", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
		Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Defender", "disable.bat", false);
		GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "disable.bat"), false);
		File.Delete(Path.Combine(Class169.string_4, "disable.bat"));
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x0009B724 File Offset: 0x00099924
	public static void smethod_14()
	{
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!DisableAntiSpyware", "0", RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!AllowFastServiceStartup", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender!ServiceKeepAlive", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableRealtimeMonitoring", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableBehaviorMonitoring", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableIOAVProtection", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableOnAccessProtection", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection!DisableScanOnRealtimeEnable", null, RegistryValueKind.DWord);
		Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Defender", "enable.bat", false);
		GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "enable.bat"), false);
		File.Delete(Path.Combine(Class169.string_4, "enable.bat"));
		if (!Directory.Exists("C:\\Windows\\System32\\SecurityHealth"))
		{
			return;
		}
		string[] directories = Directory.GetDirectories("C:\\Windows\\System32\\SecurityHealth");
		if (directories.Length != 0)
		{
			Array.Sort<string>(directories);
			GClass290.smethod_1("cmd /c Reg.exe add \"HKLM\\SOFTWARE\\Microsoft\\Windows Security Health\\Platform\" /v \"CoreLocation\" /t REG_SZ /d \"" + directories.Last<string>() + "\" /f", false);
		}
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x0009B834 File Offset: 0x00099A34
	private static void smethod_15(string string_0)
	{
		if (string_0 == "BEST")
		{
			GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows\\System!EnableSmartScreen", "0", RegistryValueKind.DWord);
			GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\SmartScreen!ConfigureAppInstallControlEnabled", "1", RegistryValueKind.DWord);
			GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\SmartScreen!ConfigureAppInstallControl", "Anywhere", RegistryValueKind.String);
			Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Smartscreen", "disable.bat", false);
			GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "disable.bat"), false);
			File.Delete(Path.Combine(Class169.string_4, "disable.bat"));
			return;
		}
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows\\System!EnableSmartScreen", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\SmartScreen!ConfigureAppInstallControlEnabled", null, RegistryValueKind.DWord);
		GClass201.smethod_2("HKLM\\Software\\Policies\\Microsoft\\Windows Defender\\SmartScreen!ConfigureAppInstallControl", null, RegistryValueKind.String);
		Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Smartscreen", "enable.bat", false);
		GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "enable.bat"), false);
		File.Delete(Path.Combine(Class169.string_4, "enable.bat"));
	}

	// Token: 0x060027A9 RID: 10153 RVA: 0x0001A523 File Offset: 0x00018723
	public static void smethod_16(string string_0)
	{
		if (string_0 == "BEST")
		{
			Class808.smethod_27("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\" /v \"SvcHostSplitThresholdInKB\" /t REG_DWORD /d \"0xffffffff\" /f");
			return;
		}
		Class808.smethod_27("Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\" /v \"SvcHostSplitThresholdInKB\" /t REG_DWORD /d \"0x00380000\" /f");
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x0009B958 File Offset: 0x00099B58
	internal static uint smethod_17(RegistryKey registryKey_0, string string_0)
	{
		object value = registryKey_0.GetValue(string_0);
		uint result;
		if (value is int)
		{
			int num = (int)value;
			result = (uint)num;
		}
		else if (value is uint)
		{
			uint num2 = (uint)value;
			result = num2;
		}
		else if (value is long)
		{
			long num3 = (long)value;
			result = (uint)num3;
		}
		else
		{
			string text = value as string;
			uint num4;
			if (text != null && uint.TryParse(text, NumberStyles.HexNumber, null, out num4))
			{
				result = num4;
			}
			else
			{
				result = 0U;
			}
		}
		return result;
	}

	// Token: 0x04001A17 RID: 6679
	private static Guid guid_0 = new Guid("48672f38-7a9a-4bb2-8bf8-3d85be19de4e");

	// Token: 0x04001A18 RID: 6680
	private static Guid guid_1 = new Guid("2bfc24f9-5ea2-4801-8213-3dbae01aa39d");
}
