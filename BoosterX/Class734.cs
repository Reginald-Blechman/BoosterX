using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using ns0;

// Token: 0x02000604 RID: 1540
internal sealed class Class734
{
	// Token: 0x0600274D RID: 10061 RVA: 0x00099E3C File Offset: 0x0009803C
	public static List<Class265> smethod_0()
	{
		List<Class265> list = new List<Class265>();
		ServiceController[] services = ServiceController.GetServices();
		ServiceController[] devices = ServiceController.GetDevices();
		foreach (ServiceController serviceController in services)
		{
			list.Add(new Class265
			{
				Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Service,
				Name = serviceController.ServiceName,
				State = Class734.smethod_4(serviceController)
			});
		}
		foreach (ServiceController serviceController2 in devices)
		{
			list.Add(new Class265
			{
				Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Service,
				Name = serviceController2.ServiceName,
				State = Class734.smethod_4(serviceController2)
			});
		}
		return list;
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x00099EDC File Offset: 0x000980DC
	public static List<Class265> smethod_1()
	{
		List<Class265> list = new List<Class265>();
		ServiceController[] services = ServiceController.GetServices();
		ServiceController[] devices = ServiceController.GetDevices();
		foreach (ServiceController serviceController in services)
		{
			list.Add(new Class265
			{
				Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Service,
				Name = Class734.smethod_2(serviceController.ServiceName),
				State = Class734.smethod_4(serviceController)
			});
		}
		foreach (ServiceController serviceController2 in devices)
		{
			list.Add(new Class265
			{
				Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Service,
				Name = serviceController2.ServiceName,
				State = Class734.smethod_4(serviceController2)
			});
		}
		return list;
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x00099F80 File Offset: 0x00098180
	public static string smethod_2(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		string pattern = "_[0-9a-fA-F]{5,6}$";
		if (Regex.IsMatch(string_0, pattern))
		{
			return Regex.Replace(string_0, pattern, string.Empty);
		}
		return string_0;
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x0001A1AF File Offset: 0x000183AF
	public static List<ServiceController> smethod_3()
	{
		List<ServiceController> list = ServiceController.GetServices().ToList<ServiceController>();
		list.AddRange(ServiceController.GetDevices());
		return list;
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x00099FB8 File Offset: 0x000981B8
	private static string smethod_4(ServiceController serviceController_0)
	{
		string result;
		try
		{
			switch (serviceController_0.StartType)
			{
			case ServiceStartMode.Boot:
				result = "0";
				break;
			case ServiceStartMode.System:
				result = "1";
				break;
			case ServiceStartMode.Automatic:
				result = "2";
				break;
			case ServiceStartMode.Manual:
				result = "3";
				break;
			case ServiceStartMode.Disabled:
				result = "4";
				break;
			default:
				result = "0";
				break;
			}
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x0009A038 File Offset: 0x00098238
	public static void smethod_5(string string_0)
	{
		Class734.Class735 @class = new Class734.Class735();
		@class.string_0 = string_0;
		if (Class734.list_0 == null)
		{
			Class734.list_0 = ServiceController.GetServices().ToList<ServiceController>();
			Class734.list_0.AddRange(ServiceController.GetDevices().ToList<ServiceController>());
		}
		GClass290.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"Start\" /t REG_DWORD /d \"4\" /f", false);
		GClass290.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"LaunchProtected\" /t REG_DWORD /d \"4\" /f", false);
		GClass290.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"ErrorControl\" /t REG_DWORD /d \"0\" /f", false);
		GClass290.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"DelayedAutoStart\" /t REG_DWORD /d \"0\" /f", false);
		@class.string_1 = GClass219.smethod_15(Class734.list_0);
		if (Class734.list_0.Any(new Func<ServiceController, bool>(@class.method_0)))
		{
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"Start\" /t REG_DWORD /d \"4\" /f"
			}), false);
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"LaunchProtected\" /t REG_DWORD /d \"4\" /f"
			}), false);
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"ErrorControl\" /t REG_DWORD /d \"0\" /f"
			}), false);
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"DelayedAutoStart\" /t REG_DWORD /d \"0\" /f"
			}), false);
		}
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x0009A21C File Offset: 0x0009841C
	public static void smethod_6(string string_0, string string_1)
	{
		Class734.Class737 @class = new Class734.Class737();
		@class.string_0 = string_0;
		if (Class734.list_0 == null)
		{
			Class734.list_0 = ServiceController.GetServices().ToList<ServiceController>();
			Class734.list_0.AddRange(ServiceController.GetDevices().ToList<ServiceController>());
		}
		GClass290.smethod_1(string.Concat(new string[]
		{
			"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
			@class.string_0,
			"\" /v \"Start\" /t REG_DWORD /d \"",
			string_1,
			"\" /f"
		}), false);
		GClass290.smethod_1("cmd /c reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"LaunchProtected\" /f", false);
		GClass290.smethod_1("cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"ErrorControl\" /t REG_DWORD /d \"1\" /f", false);
		GClass290.smethod_1("cmd /c reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\" + @class.string_0 + "\" /v \"DelayedAutoStart\" /f", false);
		@class.string_1 = GClass219.smethod_15(Class734.list_0);
		if (Class734.list_0.Any(new Func<ServiceController, bool>(@class.method_0)))
		{
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"Start\" /t REG_DWORD /d \"",
				string_1,
				"\" /f"
			}), false);
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"LaunchProtected\" /f"
			}), false);
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"ErrorControl\" /t REG_DWORD /d \"1\" /f"
			}), false);
			GClass290.smethod_1(string.Concat(new string[]
			{
				"cmd /c reg.exe delete \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\",
				@class.string_0,
				"_",
				@class.string_1,
				"\" /v \"DelayedAutoStart\" /f"
			}), false);
		}
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x0009A428 File Offset: 0x00098628
	public static void smethod_7(string string_0)
	{
		Class734.Class741 @class = new Class734.Class741();
		@class.string_0 = string_0;
		if (Class734.list_0 == null)
		{
			Class734.list_0 = ServiceController.GetServices().ToList<ServiceController>();
			Class734.list_0.AddRange(ServiceController.GetDevices().ToList<ServiceController>());
		}
		Class808.smethod_27("sc start " + @class.string_0);
		GClass290.smethod_1("cmd /c sc start " + @class.string_0, false);
		@class.string_1 = GClass219.smethod_15(Class734.list_0);
		if (Class734.list_0.Any(new Func<ServiceController, bool>(@class.method_0)))
		{
			Class808.smethod_27("sc start " + @class.string_0 + "_" + @class.string_1);
			GClass290.smethod_1("cmd /c sc start " + @class.string_0 + "_" + @class.string_1, false);
		}
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x0009A508 File Offset: 0x00098708
	public static bool smethod_8(string string_0)
	{
		Class734.Class736 @class = new Class734.Class736();
		@class.string_0 = string_0;
		return Class734.smethod_0().Any(new Func<Class265, bool>(@class.method_0));
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x0009A538 File Offset: 0x00098738
	public static bool smethod_9(string string_0)
	{
		Class734.Class739 @class = new Class734.Class739();
		@class.string_0 = string_0;
		return Class734.smethod_0().First(new Func<Class265, bool>(@class.method_0)).State == "4";
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x0009A578 File Offset: 0x00098778
	public static bool smethod_10(string string_0)
	{
		Class734.Class740 @class = new Class734.Class740();
		@class.string_0 = string_0;
		return ServiceController.GetServices().ToList<ServiceController>().First(new Func<ServiceController, bool>(@class.method_0)).Status == ServiceControllerStatus.Running;
	}

	// Token: 0x06002758 RID: 10072 RVA: 0x0009A5B8 File Offset: 0x000987B8
	internal static ServiceControllerStatus smethod_11(string string_0)
	{
		Class734.Class738 @class = new Class734.Class738();
		@class.string_0 = string_0;
		return Class734.smethod_3().First(new Func<ServiceController, bool>(@class.method_0)).Status;
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x0009A5F0 File Offset: 0x000987F0
	public static List<GClass9> smethod_12()
	{
		HashSet<string> hashSet = new HashSet<string>(GClass60.smethod_0(), StringComparer.OrdinalIgnoreCase);
		List<GClass9> list = new List<GClass9>();
		foreach (ServiceController serviceController in Class734.smethod_3().Where(new Func<ServiceController, bool>(Class734.Class742.class742_0.method_0)))
		{
			if (hashSet.Contains(serviceController.ServiceName))
			{
				bool flag = (serviceController.ServiceType & (ServiceType.Adapter | ServiceType.FileSystemDriver | ServiceType.KernelDriver | ServiceType.RecognizerDriver)) > (ServiceType)0;
				string text = Class734.smethod_14(Class734.smethod_13(serviceController.ServiceName));
				ValueTuple<FileVersionInfo, string, long>? valueTuple = Class734.smethod_15(text);
				List<GClass9> list2 = list;
				GClass9 gclass = new GClass9();
				gclass.method_1(serviceController.DisplayName ?? serviceController.ServiceName);
				if (valueTuple == null)
				{
					goto IL_C9;
				}
				string string_;
				if ((string_ = valueTuple.GetValueOrDefault().Item1.CompanyName) == null)
				{
					goto IL_C9;
				}
				IL_D0:
				gclass.method_3(string_);
				gclass.method_5(flag ? "Driver" : "Service");
				if (valueTuple == null)
				{
					goto IL_109;
				}
				string string_2;
				if ((string_2 = valueTuple.GetValueOrDefault().Item2) == null)
				{
					goto IL_109;
				}
				IL_11A:
				gclass.method_7(string_2);
				string string_3;
				if (valueTuple != null)
				{
					long item = valueTuple.GetValueOrDefault().Item3;
					string_3 = Class734.smethod_16(item);
				}
				else
				{
					string_3 = "-";
				}
				gclass.method_9(string_3);
				list2.Add(gclass);
				continue;
				IL_109:
				string_2 = (Path.GetFileName(text) ?? "-");
				goto IL_11A;
				IL_C9:
				string_ = "Unknown";
				goto IL_D0;
			}
		}
		return list;
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x0009A784 File Offset: 0x00098984
	private static string smethod_13(string string_0)
	{
		string result2;
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + string_0))
		{
			string text;
			if (registryKey != null)
			{
				object value = registryKey.GetValue("ImagePath");
				if (value != null)
				{
					if ((text = value.ToString()) != null)
					{
						goto IL_3E;
					}
				}
			}
			text = string.Empty;
			IL_3E:
			string text2 = text;
			if (text2.ToLower().Contains("svchost.exe"))
			{
				using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + string_0 + "\\Parameters"))
				{
					string result;
					if (registryKey2 != null)
					{
						object value2 = registryKey2.GetValue("ServiceDll");
						if (value2 != null)
						{
							if ((result = value2.ToString()) != null)
							{
								goto IL_96;
							}
						}
					}
					result = string.Empty;
					IL_96:
					return result;
				}
			}
			result2 = text2;
		}
		return result2;
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x0001A1C6 File Offset: 0x000183C6
	private static string smethod_14(string string_0)
	{
		if (!string.IsNullOrWhiteSpace(string_0))
		{
			return Environment.ExpandEnvironmentVariables(Regex.Replace(string_0.Trim(), "^\"|\"$", string.Empty));
		}
		return string.Empty;
	}

	// Token: 0x0600275C RID: 10076 RVA: 0x0009A860 File Offset: 0x00098A60
	private static ValueTuple<FileVersionInfo, string, long>? smethod_15(string string_0)
	{
		ValueTuple<FileVersionInfo, string, long>? valueTuple;
		try
		{
			if (!File.Exists(string_0))
			{
				valueTuple = null;
				valueTuple = valueTuple;
			}
			else
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(string_0);
				FileInfo fileInfo = new FileInfo(string_0);
				valueTuple = new ValueTuple<FileVersionInfo, string, long>?(new ValueTuple<FileVersionInfo, string, long>(versionInfo, fileInfo.Name, fileInfo.Length));
			}
		}
		catch
		{
			valueTuple = null;
		}
		return valueTuple;
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x0009A8C8 File Offset: 0x00098AC8
	private static string smethod_16(long long_0)
	{
		string result;
		if (long_0 < 1048576L)
		{
			if (long_0 >= 1024L)
			{
				result = string.Format("{0:F1} KB", (double)long_0 / 1024.0);
			}
			else
			{
				result = string.Format("{0} B", long_0);
			}
		}
		else if (long_0 >= 1073741824L)
		{
			result = string.Format("{0:F1} GB", (double)long_0 / 1073741824.0);
		}
		else
		{
			result = string.Format("{0:F1} MB", (double)long_0 / 1048576.0);
		}
		return result;
	}

	// Token: 0x040019FA RID: 6650
	private static List<ServiceController> list_0;

	// Token: 0x02000605 RID: 1541
	private sealed class Class735
	{
		// Token: 0x0600275F RID: 10079 RVA: 0x0001A1F1 File Offset: 0x000183F1
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName == this.string_0 + "_" + this.string_1;
		}

		// Token: 0x040019FB RID: 6651
		public string string_0;

		// Token: 0x040019FC RID: 6652
		public string string_1;
	}

	// Token: 0x02000606 RID: 1542
	private sealed class Class736
	{
		// Token: 0x06002761 RID: 10081 RVA: 0x0001A215 File Offset: 0x00018415
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name.Equals(this.string_0, StringComparison.InvariantCultureIgnoreCase);
		}

		// Token: 0x040019FD RID: 6653
		public string string_0;
	}

	// Token: 0x02000607 RID: 1543
	private sealed class Class737
	{
		// Token: 0x06002763 RID: 10083 RVA: 0x0001A229 File Offset: 0x00018429
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName == this.string_0 + "_" + this.string_1;
		}

		// Token: 0x040019FE RID: 6654
		public string string_0;

		// Token: 0x040019FF RID: 6655
		public string string_1;
	}

	// Token: 0x02000608 RID: 1544
	private sealed class Class738
	{
		// Token: 0x06002765 RID: 10085 RVA: 0x0001A24D File Offset: 0x0001844D
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName.Equals(this.string_0, StringComparison.InvariantCultureIgnoreCase);
		}

		// Token: 0x04001A00 RID: 6656
		public string string_0;
	}

	// Token: 0x02000609 RID: 1545
	private sealed class Class739
	{
		// Token: 0x06002767 RID: 10087 RVA: 0x0001A261 File Offset: 0x00018461
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name.Equals(this.string_0, StringComparison.InvariantCultureIgnoreCase);
		}

		// Token: 0x04001A01 RID: 6657
		public string string_0;
	}

	// Token: 0x0200060A RID: 1546
	private sealed class Class740
	{
		// Token: 0x06002769 RID: 10089 RVA: 0x0001A275 File Offset: 0x00018475
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName.Equals(this.string_0, StringComparison.InvariantCultureIgnoreCase);
		}

		// Token: 0x04001A02 RID: 6658
		public string string_0;
	}

	// Token: 0x0200060B RID: 1547
	private sealed class Class741
	{
		// Token: 0x0600276B RID: 10091 RVA: 0x0001A289 File Offset: 0x00018489
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName == this.string_0 + "_" + this.string_1;
		}

		// Token: 0x04001A03 RID: 6659
		public string string_0;

		// Token: 0x04001A04 RID: 6660
		public string string_1;
	}

	// Token: 0x0200060C RID: 1548
	[Serializable]
	private sealed class Class742
	{
		// Token: 0x0600276E RID: 10094 RVA: 0x0001A2B9 File Offset: 0x000184B9
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.Status == ServiceControllerStatus.Running;
		}

		// Token: 0x04001A05 RID: 6661
		public static readonly Class734.Class742 class742_0 = new Class734.Class742();

		// Token: 0x04001A06 RID: 6662
		public static Func<ServiceController, bool> func_0;
	}
}
