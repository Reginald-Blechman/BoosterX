using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

// Token: 0x02000119 RID: 281
internal sealed class Class169
{
	// Token: 0x06000823 RID: 2083 RVA: 0x00040CA4 File Offset: 0x0003EEA4
	internal static void smethod_0()
	{
		string path;
		try
		{
			path = Path.GetTempPath();
		}
		catch
		{
			path = "C:\\Windows\\Temp";
		}
		Class169.string_0 = Path.Combine(path, "BoosterX");
	}

	// Token: 0x04000488 RID: 1160
	public static string string_0 = string.Empty;

	// Token: 0x04000489 RID: 1161
	public static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	// Token: 0x0400048A RID: 1162
	public static string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	// Token: 0x0400048B RID: 1163
	public static string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	// Token: 0x0400048C RID: 1164
	public static string string_4 = Path.Combine(Class169.string_2, "BoosterX");

	// Token: 0x0400048D RID: 1165
	public static string string_5 = Path.Combine(Class169.string_4, "Dlls");

	// Token: 0x0400048E RID: 1166
	public static string string_6 = Path.Combine(Class169.string_4, "BackUp", "Profiles");

	// Token: 0x0400048F RID: 1167
	public static string string_7 = Path.Combine(Class169.string_4, "Data");

	// Token: 0x04000490 RID: 1168
	public static string string_8 = Path.Combine(Class169.string_7, "InputLagProfiles");

	// Token: 0x04000491 RID: 1169
	public static string string_9 = Path.Combine(Class169.string_7, "InternetTestFiles");

	// Token: 0x04000492 RID: 1170
	public static string string_10 = Path.Combine(Class169.string_7, "MyTweaks");

	// Token: 0x04000493 RID: 1171
	public static string string_11 = Path.Combine(Class169.string_4, "StoreX");

	// Token: 0x04000494 RID: 1172
	public static string string_12 = Path.Combine(Class169.string_4, "pnp");

	// Token: 0x04000495 RID: 1173
	public static string string_13 = Path.Combine(Class169.string_12, "en-US");

	// Token: 0x04000496 RID: 1174
	public static string string_14 = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\system32\\drivers\\etc\\hosts";

	// Token: 0x04000497 RID: 1175
	public static List<RegistryKey> list_0 = new List<RegistryKey>
	{
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"),
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled"),
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"),
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled"),
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run"),
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Run\\AutorunsDisabled")
	};

	// Token: 0x04000498 RID: 1176
	public static List<string> list_1 = new List<string>
	{
		"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup",
		"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\AutorunsDisabled",
		Class169.string_2 + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup",
		Class169.string_2 + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\AutorunsDisabled"
	};

	// Token: 0x04000499 RID: 1177
	public static string[] string_15 = new string[]
	{
		"Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\FirstFolder",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\LastVisitedPidlMRU",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\LastVisitedPidlMRULegacy",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\OpenSavePidlMRU",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\UserAssist",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Paint\\Recent File List",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Wordpad\\Recent File List",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU",
		"Software\\Microsoft\\Search Assistant\\ACMru",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RecentDocs",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ComDlg32\\OpenSaveMRU",
		"Software\\Microsoft\\MediaPlayer\\Player\\RecentFileList",
		"Software\\Microsoft\\MediaPlayer\\Player\\RecentURLList",
		"Software\\Microsoft\\Direct3D\\MostRecentApplication",
		"Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\TypedPaths"
	};

	// Token: 0x0400049A RID: 1178
	public static string[] string_16 = new string[]
	{
		"SYSTEM\\CurrentControlSet\\Control\\Session Manager\\AppCompatCache",
		"SYSTEM\\ControlSet001\\Control\\Session Manager\\AppCompatCache",
		"SOFTWARE\\Microsoft\\RADAR\\HeapLeakDetection\\DiagnosedApplications",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit\\Favorites",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Applets\\Paint\\Recent File List",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RecentDocs",
		"SOFTWARE\\Microsoft\\MediaPlayer\\Player\\RecentFileList",
		"SOFTWARE\\Microsoft\\MediaPlayer\\Player\\RecentURLList",
		"SOFTWARE\\Microsoft\\Direct3D\\MostRecentApplication"
	};

	// Token: 0x0400049B RID: 1179
	public static string[] string_17 = new string[]
	{
		"C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Temp",
		"C:\\Users\\%username%\\AppData\\Local\\CrashDumps",
		"C:\\ProgramData\\Microsoft\\Windows Defender\\Definition Updates\\Backup",
		"C:\\Documents and Settings\\All Users\\Application Data\\Microsoft\\Windows Defender\\Scans",
		"C:\\Users\\%username%\\AppData\\Roaming\\Adobe\\Common\\Media Cache",
		"C:\\Users\\%username%\\AppData\\Roaming\\Adobe\\Common\\Media Cache Files",
		"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE",
		"C:\\Users\\%username%\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache\\MetaData",
		"C:\\Users\\%username%\\AppData\\Local\\Temp\\filmoralog",
		"C:\\Windows\\Logs",
		"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\CLR_v4.0\\UsageLogs",
		"C:\\ProgramData\\Microsoft\\Windows Defender\\Scans",
		"C:\\Windows\\Temp\\CreativeCloud\\ACC",
		"C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue",
		"C:\\Windows\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Windows\\DeliveryOptimization\\Logs",
		"C:\\ProgramData\\Apple\\Installer Cache",
		"C:\\ProgramData\\Microsoft\\Windows\\WER\\Temp",
		"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\VisualStudio\\SettingsLogs",
		"C:\\Users\\%username%\\AppData\\Roaming\\Notepad++",
		"C:\\Users\\%username%\\Saved Games\\My Games\\Warface\\modelscache",
		"C:\\Windows\\LiveKernelReports"
	};

	// Token: 0x0400049C RID: 1180
	public static string[] string_18 = new string[]
	{
		"C:\\Windows\\Temp",
		"C:\\Windows\\SoftwareDistribution\\Download",
		Class169.string_3 + "\\Temp"
	};

	// Token: 0x0400049D RID: 1181
	public static string[] string_19 = new string[]
	{
		"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppModel\\PackageRepository\\Packages"
	};
}
