using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Token: 0x02000160 RID: 352
internal sealed class Class189
{
	// Token: 0x06000A12 RID: 2578 RVA: 0x00046458 File Offset: 0x00044658
	internal static void smethod_0()
	{
		Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Defender", "disable.bat", false);
		GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "disable.bat"), false);
		File.Delete(Path.Combine(Class169.string_4, "disable.bat"));
		foreach (string str in Class189.hashSet_0)
		{
			Class808.smethod_27("taskkill.exe /f /im \"" + str + "\"");
			GClass290.smethod_0("cmd.exe /c taskkill.exe /f /im \"" + str + "\"", false);
		}
		IEnumerable<string> source = Directory.GetDirectories("C:\\Program Files\\WindowsApps").Where(new Func<string, bool>(Class189.Class190.class190_0.method_0));
		if (source.Count<string>() > 0)
		{
			source.ToList<string>().ForEach(new Action<string>(Class189.Class190.class190_0.method_1));
		}
		string text = Path.Combine(Class169.string_4, "RemoveDefenderRegs.bat");
		Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Defender", "RemoveDefenderRegs.bat", false);
		GClass290.smethod_0("cmd.exe /c \"" + text + "\"", false);
		File.Delete(text);
		foreach (string str2 in Class189.hashSet_3)
		{
			GClass290.smethod_0("cmd.exe /c del /f /q \"" + str2 + "\"", false);
		}
		foreach (string searchPattern in Class189.hashSet_4)
		{
			Directory.GetFiles("C:\\Windows\\WinSxS\\FileMaps", searchPattern).ToList<string>().ForEach(new Action<string>(Class189.Class190.class190_0.method_2));
		}
		foreach (string str3 in Class189.hashSet_2)
		{
			GClass290.smethod_0("cmd.exe /c rmdir /s /q \"" + str3 + "\"", false);
		}
		foreach (string path in Class189.hashSet_1)
		{
			try
			{
				IEnumerable<string> source2 = Directory.GetDirectories(path).Where(new Func<string, bool>(Class189.Class190.class190_0.method_3));
				if (source2.Count<string>() > 0)
				{
					source2.ToList<string>().ForEach(new Action<string>(Class189.Class190.class190_0.method_4));
				}
			}
			catch
			{
			}
		}
		Class808.smethod_27("start %windir%\\explorer.exe");
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00003C75 File Offset: 0x00001E75
	internal static void smethod_1()
	{
		throw new NotImplementedException();
	}

	// Token: 0x040006AE RID: 1710
	private static HashSet<string> hashSet_0 = new HashSet<string>
	{
		"explorer.exe",
		"CompatTelRunner.exe",
		"DWWIN.exe",
		"DeviceCensus.exe",
		"GameBarPresenceWriter.exe",
		"SecurityHealthHost.exe",
		"SecurityHealthService.exe",
		"SecurityHealthSystray.exe",
		"smartscreen.exe",
		"MsMpEng.exe"
	};

	// Token: 0x040006AF RID: 1711
	private static HashSet<string> hashSet_1 = new HashSet<string>
	{
		"C:\\Windows\\WinSxS\\amd64_security-octagon*",
		"C:\\Windows\\WinSxS\\amd64_windows-defender*",
		"C:\\Windows\\WinSxS\\wow64_windows-defender*",
		"C:\\Windows\\WinSxS\\x86_windows-defender*",
		"C:\\Windows\\SystemApps\\Microsoft.Windows.SecHealthUI*"
	};

	// Token: 0x040006B0 RID: 1712
	private static HashSet<string> hashSet_2 = new HashSet<string>
	{
		"C:\\Program Files (x86)\\Windows Defender",
		"C:\\Program Files (x86)\\Windows Defender Advanced Threat Protection",
		"C:\\Program Files\\Windows Defender",
		"C:\\Program Files\\Windows Defender Advanced Threat Protection",
		"C:\\ProgramData\\Microsoft\\Storage Health",
		"C:\\ProgramData\\Microsoft\\Windows Defender",
		"C:\\ProgramData\\Microsoft\\Windows Defender Advanced Threat Protection",
		"C:\\ProgramData\\Microsoft\\Windows Security Health",
		"C:\\WINDOWS\\System32\\drivers\\wd",
		"C:\\Windows\\Containers\\WindowsDefenderApplicationGuard.wim",
		"C:\\Windows\\Containers\\serviced\\WindowsDefenderApplicationGuard.wim",
		"C:\\Windows\\GameBarPresenceWriter",
		"C:\\Windows\\SysWOW64\\WindowsPowerShell\\v1.0\\Modules\\Defender",
		"C:\\Windows\\SysWOW64\\WindowsPowerShell\\v1.0\\Modules\\DefenderPerformance",
		"C:\\Windows\\System32\\HealthAttestationClient",
		"C:\\Windows\\System32\\SecurityHealth",
		"C:\\Windows\\System32\\Sgrm",
		"C:\\Windows\\System32\\Tasks\\Microsoft\\Windows\\Windows Defender",
		"C:\\Windows\\System32\\Tasks_Migrated\\Microsoft\\Windows\\Windows Defender",
		"C:\\Windows\\System32\\WebThreatDefSvc",
		"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\Modules\\Defender",
		"C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\Modules\\DefenderPerformance",
		"C:\\Windows\\SystemApps\\Microsoft.Windows.AppRep.ChxApp_cw5n1h2txyewy",
		"C:\\Windows\\bcastdvr"
	};

	// Token: 0x040006B1 RID: 1713
	private static HashSet<string> hashSet_3 = new HashSet<string>
	{
		"C:\\Windows\\SysWOW64\\CompatTelRunner.exe",
		"C:\\Windows\\SysWOW64\\DeviceCensus.exe",
		"C:\\Windows\\SysWOW64\\GameBarPresenceWriter.exe",
		"C:\\Windows\\SysWOW64\\smartscreen.dll",
		"C:\\Windows\\SysWOW64\\smartscreen.exe",
		"C:\\Windows\\SysWOW64\\smartscreenps.dll",
		"C:\\Windows\\System32\\DWWIN.exe",
		"C:\\Windows\\System32\\GameBarPresenceWriter.exe",
		"C:\\Windows\\System32\\SecurityAndMaintenance.png",
		"C:\\Windows\\System32\\SecurityAndMaintenance_Error.png",
		"C:\\Windows\\System32\\SecurityHealthAgent.dll",
		"C:\\Windows\\System32\\SecurityHealthCore.dll",
		"C:\\Windows\\System32\\SecurityHealthHost.exe",
		"C:\\Windows\\System32\\SecurityHealthProxyStub.dll",
		"C:\\Windows\\System32\\SecurityHealthService.exe",
		"C:\\Windows\\System32\\SecurityHealthSsoUdk.dll",
		"C:\\Windows\\System32\\SecurityHealthSystray.exe",
		"C:\\Windows\\System32\\SecurityHealthUdk.dll",
		"C:\\Windows\\System32\\drivers\\SgrmAgent.sys",
		"C:\\Windows\\System32\\drivers\\WdBoot.sys",
		"C:\\Windows\\System32\\drivers\\WdDevFlt.sys",
		"C:\\Windows\\System32\\drivers\\WdFilter.sys",
		"C:\\Windows\\System32\\drivers\\WdNisDrv.sys",
		"C:\\Windows\\System32\\smartscreen.dll",
		"C:\\Windows\\System32\\smartscreen.exe",
		"C:\\Windows\\System32\\smartscreenps.dll",
		"C:\\Windows\\System32\\wscadminui.exe",
		"C:\\Windows\\System32\\wscapi.dll",
		"C:\\Windows\\System32\\wscisvif.dll",
		"C:\\Windows\\System32\\wscproxystub.dll",
		"C:\\Windows\\System32\\wscsvc.dll",
		"C:\\Windows\\system32\\drivers\\msseccore.sys"
	};

	// Token: 0x040006B2 RID: 1714
	private static HashSet<string> hashSet_4 = new HashSet<string>
	{
		"amd64_windows-defender*.manifest",
		"wow64_windows-defender*.manifest",
		"x86_windows-defender*.manifest"
	};

	// Token: 0x02000161 RID: 353
	[Serializable]
	private sealed class Class190
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x00008173 File Offset: 0x00006373
		internal bool method_0(string string_0)
		{
			return string_0.StartsWith("Microsoft.SecHealthUI", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00008182 File Offset: 0x00006382
		internal void method_1(string string_0)
		{
			GClass290.smethod_0("cmd.exe /c rmdir /s /q \"" + string_0 + "\"", false);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0000819D File Offset: 0x0000639D
		internal void method_2(string string_0)
		{
			GClass290.smethod_0("cmd.exe /c del /f /q \"" + string_0 + "\"", false);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00008173 File Offset: 0x00006373
		internal bool method_3(string string_0)
		{
			return string_0.StartsWith("Microsoft.SecHealthUI", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00008182 File Offset: 0x00006382
		internal void method_4(string string_0)
		{
			GClass290.smethod_0("cmd.exe /c rmdir /s /q \"" + string_0 + "\"", false);
		}

		// Token: 0x040006B3 RID: 1715
		public static readonly Class189.Class190 class190_0 = new Class189.Class190();

		// Token: 0x040006B4 RID: 1716
		public static Func<string, bool> func_0;

		// Token: 0x040006B5 RID: 1717
		public static Action<string> action_0;

		// Token: 0x040006B6 RID: 1718
		public static Action<string> action_1;

		// Token: 0x040006B7 RID: 1719
		public static Func<string, bool> func_1;

		// Token: 0x040006B8 RID: 1720
		public static Action<string> action_2;
	}
}
