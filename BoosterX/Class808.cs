using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Threading;
using ElevRightsX;
using ns0;
using PIManagerX;

// Token: 0x02000691 RID: 1681
internal static class Class808
{
	// Token: 0x06002A74 RID: 10868 RVA: 0x000A3BD4 File Offset: 0x000A1DD4
	public static List<GClass236> smethod_0()
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"Idle",
			"System",
			"Registry",
			"smss",
			"csrss",
			"wininit",
			"services",
			"lsass",
			"winlogon",
			"svchost",
			"fontdrvhost",
			"dllhost",
			"dasHost",
			"conhost",
			"audiodg",
			"WUDFHost",
			"WmiPrvSE",
			"sihost",
			"RuntimeBroker"
		};
		Process[] processes = Process.GetProcesses();
		Class808.Struct453 @struct;
		@struct.hashSet_0 = new HashSet<int>(processes.Where(new Func<Process, bool>(Class808.Class809.class809_0.method_0)).Select(new Func<Process, int>(Class808.Class809.class809_0.method_1)));
		@struct.dictionary_0 = Class808.smethod_1();
		List<GClass236> list = new List<GClass236>();
		Process[] array = processes;
		for (int i = 0; i < array.Length; i++)
		{
			Class808.Class810 @class = new Class808.Class810();
			@class.process_0 = array[i];
			if (!hashSet.Contains(@class.process_0.ProcessName) && !@struct.hashSet_0.Contains(@class.process_0.Id) && !Class808.smethod_38(@class.process_0.Id, ref @struct))
			{
				GClass236 gclass = new GClass236();
				gclass.method_1(@class.process_0.ProcessName);
				gclass.method_3(Class808.smethod_3(new Func<string>(@class.method_0)) ?? "N/A");
				gclass.method_5(Class808.smethod_4(Class808.smethod_2<long>(new Func<long>(@class.method_1)).GetValueOrDefault()));
				gclass.method_7(Class808.smethod_2<ulong>(new Func<ulong>(@class.method_2)));
				GClass236 item = gclass;
				list.Add(item);
			}
		}
		return list.OrderByDescending(new Func<GClass236, long>(Class808.Class809.class809_0.method_2)).ToList<GClass236>();
	}

	// Token: 0x06002A75 RID: 10869 RVA: 0x000A3E6C File Offset: 0x000A206C
	private static Dictionary<int, int> smethod_1()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessId, ParentProcessId FROM Win32_Process");
		Dictionary<int, int> result;
		try
		{
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				int key = (int)((uint)managementObject["ProcessId"]);
				int value = (int)((uint)managementObject["ParentProcessId"]);
				dictionary[key] = value;
			}
			result = dictionary;
		}
		finally
		{
			((IDisposable)managementObjectSearcher).Dispose();
		}
		return result;
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x000A3F10 File Offset: 0x000A2110
	private static T? smethod_2<T>(Func<T> func_0) where T : struct
	{
		T? result;
		try
		{
			result = new T?(func_0());
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06002A77 RID: 10871 RVA: 0x000A3F4C File Offset: 0x000A214C
	private static string smethod_3(Func<string> func_0)
	{
		string result;
		try
		{
			result = func_0();
		}
		catch
		{
			result = "N/A";
		}
		return result;
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x000A3F80 File Offset: 0x000A2180
	private static string smethod_4(long long_0)
	{
		if ((double)long_0 < 1024.0)
		{
			return string.Format("{0} B", long_0);
		}
		if ((double)long_0 < 1048576.0)
		{
			return string.Format("{0:F1} KB", (double)long_0 / 1024.0);
		}
		if ((double)long_0 < 1073741824.0)
		{
			return string.Format("{0:F1} MB", (double)long_0 / 1024.0 / 1024.0);
		}
		return string.Format("{0:F1} GB", (double)long_0 / 1024.0 / 1024.0 / 1024.0);
	}

	// Token: 0x06002A79 RID: 10873 RVA: 0x000A403C File Offset: 0x000A223C
	private static long smethod_5(string string_0)
	{
		long result;
		if (!long.TryParse(string_0.Split(new char[]
		{
			' '
		})[0], out result))
		{
			return 0L;
		}
		return result;
	}

	// Token: 0x06002A7A RID: 10874 RVA: 0x000A4070 File Offset: 0x000A2270
	private static long smethod_6(Process process_0)
	{
		PerformanceCounter performanceCounter = new PerformanceCounter("Process", "Context Switches/sec", process_0.ProcessName, true);
		long result;
		try
		{
			performanceCounter.NextValue();
			Thread.Sleep(200);
			result = (long)((double)performanceCounter.NextValue() * process_0.StartTime.Subtract(Process.GetCurrentProcess().StartTime).TotalSeconds);
		}
		finally
		{
			((IDisposable)performanceCounter).Dispose();
		}
		return result;
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x000A40EC File Offset: 0x000A22EC
	public static bool smethod_7(Process process_0)
	{
		string text = Class808.smethod_20(process_0.ProcessName);
		return !string.IsNullOrEmpty(text) && text.StartsWith("C:\\Program Files\\WindowsApps\\", StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x0001BA32 File Offset: 0x00019C32
	public static void smethod_8(Process process_0)
	{
		Class808.smethod_10(process_0.ProcessName);
	}

	// Token: 0x06002A7D RID: 10877 RVA: 0x000A411C File Offset: 0x000A231C
	public static void smethod_9(string string_0, string string_1)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = string_0,
				Arguments = string_1,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch
		{
		}
	}

	// Token: 0x06002A7E RID: 10878 RVA: 0x000A4170 File Offset: 0x000A2370
	public static void smethod_10(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = string_0,
				UseShellExecute = true,
				Arguments = "-silent",
				WindowStyle = ProcessWindowStyle.Minimized
			});
		}
		catch
		{
		}
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x000A41C0 File Offset: 0x000A23C0
	public static bool smethod_11(string string_0)
	{
		string[] array = string_0.Split(new char[]
		{
			'\\'
		});
		if (array.Length < 5)
		{
			return false;
		}
		string[] array2 = array[3].Split(new char[]
		{
			'_'
		});
		if (array2.Length < 5)
		{
			return false;
		}
		string text = array2[0];
		string text2 = array2[4];
		string text3 = Class808.smethod_36(text);
		if (text3 == null)
		{
			return false;
		}
		Class808.smethod_27(string.Concat(new string[]
		{
			"explorer.exe shell:appsFolder\\",
			text,
			"_",
			text2,
			"!",
			text3
		}));
		return true;
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x000A4254 File Offset: 0x000A2454
	public static double smethod_12(DirectoryInfo directoryInfo_0)
	{
		double result;
		try
		{
			result = Math.Round((double)Class808.smethod_16(directoryInfo_0) / 1048576.0, 2);
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x06002A81 RID: 10881 RVA: 0x000A429C File Offset: 0x000A249C
	public static double smethod_13(string string_0)
	{
		double result;
		try
		{
			result = Math.Round((double)Class808.smethod_15(string_0) / 1048576.0, 2);
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x000A42E4 File Offset: 0x000A24E4
	public static double smethod_14(string string_0)
	{
		double result;
		try
		{
			result = Math.Round((double)Class808.smethod_15(string_0) / 1073741824.0, 2);
		}
		catch
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x06002A83 RID: 10883 RVA: 0x000A432C File Offset: 0x000A252C
	public static long smethod_15(string string_0)
	{
		long result;
		try
		{
			result = Class808.smethod_16(new DirectoryInfo(string_0));
		}
		catch
		{
			result = 0L;
		}
		return result;
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x000A4368 File Offset: 0x000A2568
	public static long smethod_16(DirectoryInfo directoryInfo_0)
	{
		long num = 0L;
		Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();
		stack.Push(directoryInfo_0);
		while (stack.Count > 0)
		{
			DirectoryInfo directoryInfo = stack.Pop();
			FileInfo[] array;
			try
			{
				array = directoryInfo.GetFiles();
				goto IL_8D;
			}
			catch
			{
				array = Array.Empty<FileInfo>();
				goto IL_8D;
			}
			goto IL_3B;
			IL_4F:
			int i;
			FileInfo[] array2;
			if (i >= array2.Length)
			{
				DirectoryInfo[] array3;
				try
				{
					array3 = directoryInfo.GetDirectories();
				}
				catch
				{
					array3 = Array.Empty<DirectoryInfo>();
				}
				foreach (DirectoryInfo item in array3)
				{
					stack.Push(item);
				}
				continue;
			}
			IL_3B:
			FileInfo fileInfo = array2[i];
			num += fileInfo.Length;
			i++;
			goto IL_4F;
			IL_8D:
			array2 = array;
			i = 0;
			goto IL_4F;
		}
		return num;
	}

	// Token: 0x06002A85 RID: 10885 RVA: 0x000A4428 File Offset: 0x000A2628
	public static string smethod_17(string string_0)
	{
		string result;
		try
		{
			string text = Class808.smethod_35(string_0);
			if (!File.Exists(text))
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				text = Directory.GetFiles(string_0, fileNameWithoutExtension + "*.png", SearchOption.AllDirectories).First<string>();
			}
			string text2 = Path.Combine(Path.GetTempPath(), Path.GetFileName(string_0).Split(new char[]
			{
				'_'
			}).First<string>() + Path.GetFileName(text));
			if (!File.Exists(text2))
			{
				File.Copy(text, text2, true);
			}
			result = text2;
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x000A44C4 File Offset: 0x000A26C4
	public static void smethod_18()
	{
		try
		{
			string path = "explorer.exe";
			Process.Start(new ProcessStartInfo
			{
				FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), path),
				UseShellExecute = true
			});
		}
		catch
		{
		}
	}

	// Token: 0x06002A87 RID: 10887 RVA: 0x0001BA3F File Offset: 0x00019C3F
	public static string smethod_19(Process process_0)
	{
		return Class808.smethod_20(process_0.ProcessName);
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x000A4514 File Offset: 0x000A2714
	public static string smethod_20(string string_0)
	{
		string result;
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			if (processesByName.Length == 0)
			{
				result = string.Empty;
			}
			else
			{
				result = processesByName[0].MainModule.FileName;
			}
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06002A89 RID: 10889 RVA: 0x0001BA4C File Offset: 0x00019C4C
	public static void smethod_21(Process process_0)
	{
		Class808.smethod_23(process_0.ProcessName);
	}

	// Token: 0x06002A8A RID: 10890 RVA: 0x000A4560 File Offset: 0x000A2760
	public static void smethod_22()
	{
		if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_4)
		{
			Class808.smethod_23("SearchApp.exe");
			Class808.smethod_23("TextInputHost.exe");
			Class808.smethod_23("StartMenuExperienceHost.exe");
			Class808.smethod_23("ShellExperienceHost.exe");
			Class808.smethod_25("winlogon");
			Class808.smethod_23("dwm.exe");
		}
	}

	// Token: 0x06002A8B RID: 10891 RVA: 0x000A45B8 File Offset: 0x000A27B8
	public static void smethod_23(string string_0)
	{
		foreach (Process process in Process.GetProcessesByName(string_0))
		{
			try
			{
				process.Kill();
			}
			catch
			{
			}
		}
		if (!string_0.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			string_0 += ".exe";
		}
		Class808.smethod_27("taskkill /F /IM " + string_0 + " && exit");
	}

	// Token: 0x06002A8C RID: 10892 RVA: 0x000A4630 File Offset: 0x000A2830
	public static bool smethod_24(string string_0)
	{
		bool result;
		try
		{
			result = (Process.GetProcessesByName(string_0).Length != 0);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06002A8D RID: 10893 RVA: 0x000A4660 File Offset: 0x000A2860
	public static void smethod_25(string string_0)
	{
		try
		{
			Process process = Class746.smethod_2<Process>(Process.GetProcessesByName(string_0));
			if (process != null)
			{
				foreach (object obj in process.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = PManagerX.OpenThread(2, false, (uint)processThread.Id);
					if (!(intPtr == IntPtr.Zero))
					{
						PManagerX.SuspendThread(intPtr);
						PManagerX.CloseHandle(intPtr);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002A8E RID: 10894 RVA: 0x000A4700 File Offset: 0x000A2900
	public static void smethod_26(string string_0)
	{
		try
		{
			Process process = Class746.smethod_2<Process>(Process.GetProcessesByName(string_0));
			if (process != null)
			{
				foreach (object obj in process.Threads)
				{
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = PManagerX.OpenThread(2, false, (uint)processThread.Id);
					if (!(intPtr == IntPtr.Zero))
					{
						int num;
						do
						{
							num = PManagerX.ResumeThread(intPtr);
						}
						while (num > 0);
						PManagerX.CloseHandle(intPtr);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002A8F RID: 10895 RVA: 0x000A47A8 File Offset: 0x000A29A8
	public static void smethod_27(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch
		{
			TrustedBypass.TrustedCrack("cmd.exe /c " + string_0, false);
		}
	}

	// Token: 0x06002A90 RID: 10896 RVA: 0x000A4820 File Offset: 0x000A2A20
	public static void smethod_28(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Normal
			}).WaitForExit();
		}
		catch
		{
			TrustedBypass.TrustedCrack("cmd.exe /c " + string_0, false);
		}
	}

	// Token: 0x06002A91 RID: 10897 RVA: 0x0004026C File Offset: 0x0003E46C
	public static void smethod_29(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch
		{
		}
	}

	// Token: 0x06002A92 RID: 10898 RVA: 0x000A4898 File Offset: 0x000A2A98
	public static void smethod_30(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			});
		}
		catch
		{
		}
	}

	// Token: 0x06002A93 RID: 10899 RVA: 0x000A48F8 File Offset: 0x000A2AF8
	public static void smethod_31(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Normal
			});
		}
		catch
		{
		}
	}

	// Token: 0x06002A94 RID: 10900 RVA: 0x000A4958 File Offset: 0x000A2B58
	public static void smethod_32(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "C:\\Windows\\system32\\cmd.exe",
				Arguments = "/c " + string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch
		{
		}
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x000A49BC File Offset: 0x000A2BBC
	public static string smethod_33(string string_0)
	{
		string result = string.Empty;
		try
		{
			Process process = new Process();
			try
			{
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c " + string_0;
				process.StartInfo.Verb = "runas";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				process.Start();
				result = process.StandardOutput.ReadToEnd();
				process.StandardError.ReadToEnd();
				process.WaitForExit();
			}
			finally
			{
				((IDisposable)process).Dispose();
			}
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x06002A96 RID: 10902 RVA: 0x000A4A84 File Offset: 0x000A2C84
	public static string smethod_34(string string_0)
	{
		string result = string.Empty;
		try
		{
			Process process = new Process();
			try
			{
				process.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
				process.StartInfo.Arguments = "/c " + string_0;
				process.StartInfo.Verb = "runas";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.UseShellExecute = false;
				process.Start();
				result = process.StandardOutput.ReadToEnd();
				process.StandardError.ReadToEnd();
				process.WaitForExit();
			}
			finally
			{
				((IDisposable)process).Dispose();
			}
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x06002A97 RID: 10903 RVA: 0x000A4B58 File Offset: 0x000A2D58
	public static string smethod_35(string string_0)
	{
		string key = Path.GetFileName(string_0).Split(new char[]
		{
			'_'
		}).First<string>();
		object obj = Class808.object_0;
		lock (obj)
		{
			while (Class808.bool_0)
			{
				Monitor.Wait(Class808.object_0);
			}
			string path;
			if (Class808.dictionary_0.TryGetValue(key, out path))
			{
				return Path.Combine(string_0, path);
			}
			Class808.bool_0 = true;
		}
		Class808.smethod_37();
		obj = Class808.object_0;
		string result;
		lock (obj)
		{
			string path2;
			if (Class808.dictionary_0.TryGetValue(key, out path2))
			{
				result = Path.Combine(string_0, path2);
			}
			else
			{
				result = null;
			}
		}
		return result;
	}

	// Token: 0x06002A98 RID: 10904 RVA: 0x000A4C2C File Offset: 0x000A2E2C
	public static string smethod_36(string string_0)
	{
		object obj = Class808.object_0;
		lock (obj)
		{
			while (Class808.bool_0)
			{
				Monitor.Wait(Class808.object_0);
			}
			string result;
			if (Class808.dictionary_1.TryGetValue(string_0, out result))
			{
				return result;
			}
			Class808.bool_0 = true;
		}
		Class808.smethod_37();
		obj = Class808.object_0;
		string result2;
		lock (obj)
		{
			string text;
			if (Class808.dictionary_1.TryGetValue(string_0, out text))
			{
				result2 = text;
			}
			else
			{
				result2 = "App";
			}
		}
		return result2;
	}

	// Token: 0x06002A99 RID: 10905 RVA: 0x000A4CDC File Offset: 0x000A2EDC
	private static void smethod_37()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		try
		{
			using (PowerShell powerShell = PowerShell.Create())
			{
				powerShell.AddScript("\r\n$apps = Get-AppxPackage | ForEach-Object {\r\n    $manifest = Get-AppxPackageManifest -Package $_.PackageFullName;\r\n    [PSCustomObject]@{\r\n       Name = $_.Name;\r\n       Logo = $manifest.package.properties.logo;\r\n       AppId = $manifest.package.applications.application.id;\r\n    }\r\n}\r\n$apps\r\n");
				foreach (PSObject psobject in powerShell.Invoke())
				{
					PSMemberInfo psmemberInfo = psobject.Members["Name"];
					string text;
					if (psmemberInfo == null)
					{
						text = null;
					}
					else
					{
						object value = psmemberInfo.Value;
						text = ((value != null) ? value.ToString() : null);
					}
					string text2 = text;
					PSMemberInfo psmemberInfo2 = psobject.Members["Logo"];
					string text3;
					if (psmemberInfo2 == null)
					{
						text3 = null;
					}
					else
					{
						object value2 = psmemberInfo2.Value;
						text3 = ((value2 != null) ? value2.ToString() : null);
					}
					string value3 = text3;
					PSMemberInfo psmemberInfo3 = psobject.Members["AppId"];
					string text4;
					if (psmemberInfo3 == null)
					{
						text4 = null;
					}
					else
					{
						object value4 = psmemberInfo3.Value;
						text4 = ((value4 != null) ? value4.ToString() : null);
					}
					string value5 = text4;
					if (!string.IsNullOrEmpty(text2))
					{
						if (!string.IsNullOrEmpty(value3))
						{
							dictionary[text2] = value3;
						}
						if (!string.IsNullOrEmpty(value5))
						{
							dictionary2[text2] = value5;
						}
					}
				}
			}
		}
		catch
		{
		}
		object obj = Class808.object_0;
		lock (obj)
		{
			Class808.dictionary_0.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				Class808.dictionary_0[keyValuePair.Key] = keyValuePair.Value;
			}
			Class808.dictionary_1.Clear();
			foreach (KeyValuePair<string, string> keyValuePair2 in dictionary2)
			{
				Class808.dictionary_1[keyValuePair2.Key] = keyValuePair2.Value;
			}
			Class808.bool_0 = false;
			Monitor.PulseAll(Class808.object_0);
		}
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x000A4F1C File Offset: 0x000A311C
	internal static bool smethod_38(int int_0, ref Class808.Struct453 struct453_0)
	{
		int num;
		while (struct453_0.dictionary_0.TryGetValue(int_0, out num) && num != 0)
		{
			if (struct453_0.hashSet_0.Contains(num))
			{
				return true;
			}
			int_0 = num;
		}
		return false;
	}

	// Token: 0x04001BB1 RID: 7089
	private static readonly object object_0 = new object();

	// Token: 0x04001BB2 RID: 7090
	private static readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04001BB3 RID: 7091
	private static readonly Dictionary<string, string> dictionary_1 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04001BB4 RID: 7092
	private static bool bool_0 = false;

	// Token: 0x02000692 RID: 1682
	[Serializable]
	private sealed class Class809
	{
		// Token: 0x06002A9D RID: 10909 RVA: 0x0001BA65 File Offset: 0x00019C65
		internal bool method_0(Process process_0)
		{
			return process_0.MainWindowHandle != IntPtr.Zero;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0001BA77 File Offset: 0x00019C77
		internal int method_1(Process process_0)
		{
			return process_0.Id;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0001BA7F File Offset: 0x00019C7F
		internal long method_2(GClass236 gclass236_0)
		{
			return Class808.smethod_5(gclass236_0.method_4());
		}

		// Token: 0x04001BB5 RID: 7093
		public static readonly Class808.Class809 class809_0 = new Class808.Class809();

		// Token: 0x04001BB6 RID: 7094
		public static Func<Process, bool> func_0;

		// Token: 0x04001BB7 RID: 7095
		public static Func<Process, int> func_1;

		// Token: 0x04001BB8 RID: 7096
		public static Func<GClass236, long> func_2;
	}

	// Token: 0x02000693 RID: 1683
	private sealed class Class810
	{
		// Token: 0x06002AA1 RID: 10913 RVA: 0x0001BA8C File Offset: 0x00019C8C
		internal string method_0()
		{
			ProcessModule mainModule = this.process_0.MainModule;
			if (mainModule == null)
			{
				return null;
			}
			return mainModule.FileName;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		internal long method_1()
		{
			return this.process_0.WorkingSet64;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0001BAB1 File Offset: 0x00019CB1
		internal ulong method_2()
		{
			return PManagerX.GetCpuCycles(this.process_0);
		}

		// Token: 0x04001BB9 RID: 7097
		public Process process_0;
	}

	// Token: 0x02000694 RID: 1684
	[StructLayout(LayoutKind.Auto)]
	private struct Struct453
	{
		// Token: 0x04001BBA RID: 7098
		public Dictionary<int, int> dictionary_0;

		// Token: 0x04001BBB RID: 7099
		public HashSet<int> hashSet_0;
	}
}
