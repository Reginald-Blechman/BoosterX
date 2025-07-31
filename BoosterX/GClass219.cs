using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using ns0;

// Token: 0x02000495 RID: 1173
public static class GClass219
{
	// Token: 0x06001E6C RID: 7788 RVA: 0x0007C75C File Offset: 0x0007A95C
	public static string smethod_0(string string_0)
	{
		GClass219.Class557 @class = new GClass219.Class557();
		@class.string_0 = string_0;
		string result = @class.string_0;
		try
		{
			result = ServiceController.GetServices().First(new Func<ServiceController, bool>(@class.method_0)).DisplayName;
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x0007C7B0 File Offset: 0x0007A9B0
	public static ServiceStartMode smethod_1(string string_0)
	{
		ServiceStartMode result;
		try
		{
			result = GClass219.smethod_2(Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + string_0).GetValue("Start").ToString());
		}
		catch
		{
			result = ServiceStartMode.Disabled;
		}
		return result;
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x0007C804 File Offset: 0x0007AA04
	public static ServiceStartMode smethod_2(string string_0)
	{
		ServiceStartMode result;
		if (!(string_0 == "0"))
		{
			if (!(string_0 == "1"))
			{
				if (!(string_0 == "2"))
				{
					if (!(string_0 == "3"))
					{
						if (!(string_0 == "4"))
						{
							result = ServiceStartMode.Disabled;
						}
						else
						{
							result = ServiceStartMode.Disabled;
						}
					}
					else
					{
						result = ServiceStartMode.Manual;
					}
				}
				else
				{
					result = ServiceStartMode.Automatic;
				}
			}
			else
			{
				result = ServiceStartMode.System;
			}
		}
		else
		{
			result = ServiceStartMode.Boot;
		}
		return result;
	}

	// Token: 0x06001E6F RID: 7791 RVA: 0x0007C870 File Offset: 0x0007AA70
	public static string smethod_3(ServiceStartMode? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceStartMode.Boot:
				return "0";
			case ServiceStartMode.System:
				return "1";
			case ServiceStartMode.Automatic:
				return "2";
			case ServiceStartMode.Manual:
				return "3";
			case ServiceStartMode.Disabled:
				return "4";
			}
		}
		return "4";
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x0007C8E0 File Offset: 0x0007AAE0
	public static string smethod_4(ServiceStartMode? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceStartMode.Boot:
				return Class298.smethod_2("Boot");
			case ServiceStartMode.System:
				return Class298.smethod_2("System");
			case ServiceStartMode.Automatic:
				return Class298.smethod_2("Automatic");
			case ServiceStartMode.Manual:
				return Class298.smethod_2("Manual");
			case ServiceStartMode.Disabled:
				return Class298.smethod_2("Disabled");
			}
		}
		return Class298.smethod_2("Unknown");
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x0007C970 File Offset: 0x0007AB70
	public static string smethod_5(ServiceStartMode? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceStartMode.Boot:
				return "boot";
			case ServiceStartMode.System:
				return "system";
			case ServiceStartMode.Automatic:
				return "auto";
			case ServiceStartMode.Manual:
				return "demand";
			case ServiceStartMode.Disabled:
				return "disabled";
			}
		}
		return "unknown";
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x0007C9E0 File Offset: 0x0007ABE0
	public static string smethod_6(ServiceControllerStatus? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceControllerStatus.Stopped:
				return "stop";
			case ServiceControllerStatus.Running:
				return "start";
			case ServiceControllerStatus.ContinuePending:
				return "continue";
			case ServiceControllerStatus.Paused:
				return "pause";
			}
		}
		return "unknown";
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x0007CA48 File Offset: 0x0007AC48
	public static GClass219.GClass220 smethod_7(ServiceControllerStatus? nullable_0)
	{
		GClass219.GClass220 gclass = new GClass219.GClass220
		{
			State = GClass219.smethod_8(nullable_0)
		};
		if (nullable_0.GetValueOrDefault() == ServiceControllerStatus.Running)
		{
			gclass.method_1("-ErrorAction Stop -Confirm:$false");
		}
		else if (nullable_0.GetValueOrDefault() == ServiceControllerStatus.Stopped)
		{
			gclass.method_1("-Force -ErrorAction Stop -Confirm:$false");
		}
		return gclass;
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x0007CA98 File Offset: 0x0007AC98
	public static string smethod_8(ServiceControllerStatus? nullable_0)
	{
		if (nullable_0 != null)
		{
			switch (nullable_0.GetValueOrDefault())
			{
			case ServiceControllerStatus.Stopped:
				return "Stop-Service";
			case ServiceControllerStatus.Running:
				return "Start-Service";
			case ServiceControllerStatus.ContinuePending:
				return "Restart-Service";
			case ServiceControllerStatus.Paused:
				return "Suspend-Service";
			}
		}
		return "unknown";
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x0007CB00 File Offset: 0x0007AD00
	public static string smethod_9(ServiceControllerStatus serviceControllerStatus_0)
	{
		switch (serviceControllerStatus_0)
		{
		case ServiceControllerStatus.Stopped:
			return Class298.smethod_2("Stopped");
		case ServiceControllerStatus.StartPending:
			return Class298.smethod_2("StartPending");
		case ServiceControllerStatus.StopPending:
			return Class298.smethod_2("StopPending");
		case ServiceControllerStatus.Running:
			return Class298.smethod_2("Running");
		case ServiceControllerStatus.ContinuePending:
			return Class298.smethod_2("ContinuePending");
		case ServiceControllerStatus.PausePending:
			return Class298.smethod_2("PausePending");
		case ServiceControllerStatus.Paused:
			return Class298.smethod_2("Paused");
		default:
			return Class298.smethod_2("Unknown");
		}
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x000140FC File Offset: 0x000122FC
	public static List<string> smethod_10(string string_0)
	{
		string_0 = GClass219.smethod_18(string_0);
		GClass222 gclass = GClass207.smethod_0().get_Item(string_0);
		if (gclass == null)
		{
			return null;
		}
		return gclass.List_0;
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x0001411E File Offset: 0x0001231E
	public static bool smethod_11(string string_0)
	{
		string_0 = GClass219.smethod_18(string_0);
		if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_3)
		{
			GClass222 gclass = GClass207.smethod_0().get_Item(string_0);
			return gclass != null && gclass.Boolean_0;
		}
		GClass222 gclass2 = GClass207.smethod_0().get_Item(string_0);
		return gclass2 != null && gclass2.IsBlocked;
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x0007CB90 File Offset: 0x0007AD90
	public static ServiceStartMode? smethod_12(string string_0)
	{
		string_0 = GClass219.smethod_18(string_0);
		GClass222 gclass = GClass207.smethod_0().get_Item(string_0);
		if (gclass == null)
		{
			return null;
		}
		return gclass.DefaultStartMode;
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x0007CBC8 File Offset: 0x0007ADC8
	public static bool smethod_13(ServiceController serviceController_0)
	{
		bool result;
		try
		{
			result = (serviceController_0.ServiceName != null);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x0001415E File Offset: 0x0001235E
	public static string smethod_14(ServiceController[] serviceController_0)
	{
		return GClass219.smethod_15(serviceController_0.ToList<ServiceController>());
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x0001416B File Offset: 0x0001236B
	public static string smethod_15(List<ServiceController> list_1)
	{
		return GClass219.smethod_17(list_1.First(new Func<ServiceController, bool>(GClass219.Class556.class556_0.method_0)));
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x00014197 File Offset: 0x00012397
	public static string smethod_16(ServiceController serviceController_0)
	{
		return serviceController_0.ServiceName.Split(new char[]
		{
			'_'
		}).First<string>();
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x000141B4 File Offset: 0x000123B4
	public static string smethod_17(ServiceController serviceController_0)
	{
		if (!serviceController_0.ServiceName.Contains('_'))
		{
			return null;
		}
		return serviceController_0.ServiceName.Split(new char[]
		{
			'_'
		}).Last<string>();
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000141E2 File Offset: 0x000123E2
	public static string smethod_18(string string_0)
	{
		if (string_0.Contains("_") && string_0.Contains(Class546.smethod_0().method_0()))
		{
			return string_0.Split(new char[]
			{
				'_'
			}).First<string>();
		}
		return string_0;
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x0007CBF8 File Offset: 0x0007ADF8
	public static Dictionary<string, string> smethod_19()
	{
		string[] array = new string[]
		{
			"Win32_Service",
			"Win32_SystemDriver"
		};
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new SelectQuery(array2[i])).Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object value = managementObject.Properties["Description"].Value;
					string text = (value != null) ? value.ToString() : null;
					object value2 = managementObject.Properties["Name"].Value;
					string text2 = (value2 != null) ? value2.ToString() : null;
					if (text2 != null && text != null)
					{
						dictionary.Add(text2, text);
					}
				}
			}
		}
		catch
		{
		}
		return dictionary;
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x0007CCF4 File Offset: 0x0007AEF4
	public static List<GClass102> smethod_20(string string_0)
	{
		string[] array = File.ReadAllLines(string_0);
		List<GClass102> list = new List<GClass102>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].StartsWith("[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services"))
			{
				GClass219.Class555 @class = new GClass219.Class555();
				@class.string_0 = array[i].Split(new char[]
				{
					'\\'
				}).Last<string>().Replace("]", string.Empty).ToLower();
				GClass219.list_0.ForEach(new Action<string>(@class.method_0));
				try
				{
					list.Add(new GClass102
					{
						Name = @class.string_0,
						Status = GClass219.smethod_2(array[i + 1].ToCharArray().Last<char>().ToString())
					});
				}
				catch
				{
				}
			}
		}
		return new List<GClass102>();
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x0007CDD8 File Offset: 0x0007AFD8
	public static void smethod_21(GClass189 gclass189_0)
	{
		gclass189_0.DependOn.ForEach(new Action<GClass189>(GClass219.Class556.class556_0.method_1));
		GClass219.smethod_22(gclass189_0.Service.ServiceName, GClass219.smethod_3(gclass189_0.Service.DefaultStartMode));
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x0007CE30 File Offset: 0x0007B030
	public static void smethod_22(string string_0, string string_1)
	{
		GClass290.smethod_1(string.Concat(new string[]
		{
			"Reg.exe add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\",
			string_0,
			"\" /v \"Start\" /t REG_DWORD /d \"",
			string_1,
			"\" /f"
		}), false);
		GClass290.smethod_1(string.Concat(new string[]
		{
			"Reg.exe add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\",
			GClass219.smethod_18(string_0),
			"\" /v \"Start\" /t REG_DWORD /d \"",
			string_1,
			"\" /f"
		}), false);
		if (string_1 == "2")
		{
			GClass290.smethod_1("sc start " + string_0, false);
		}
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x0007CED0 File Offset: 0x0007B0D0
	public static Task<BitmapSource> smethod_23(string string_0)
	{
		GClass219.Struct301 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<BitmapSource>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass219.Struct301>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x0007CF14 File Offset: 0x0007B114
	public static void smethod_24(string string_0, string string_1)
	{
		if (string_0.ToLower() == "rdyboost" && string_1 == "4")
		{
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_4.Add("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{71a27cdd-812a-11d0-bec7-08002be2092f}\" /v \"LowerFilters\" /t REG_MULTI_SZ /d \"fvevol\\0iorate\" /f");
		}
		if (string_0.ToLower() == "rdyboost" && string_1 != "4")
		{
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_4.Add("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Class\\{71a27cdd-812a-11d0-bec7-08002be2092f}\" /v \"LowerFilters\" /t REG_MULTI_SZ /d \"fvevol\\0iorate\\0rdyboost\" /f");
		}
		if (string_0.ToLower() == "keyiso" && string_1 == "4")
		{
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_4.Add("net accounts /maxpwage:unlimited");
		}
		if (string_0.ToLower() == "sppsvc" && string_1 == "4")
		{
			Class662.smethod_1("Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask");
			Class662.smethod_1("Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTaskLogon");
			Class662.smethod_1("Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTaskNetwork");
		}
		if (string_0.ToLower() == "sppsvc" && string_1 != "4")
		{
			Class662.smethod_0("Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTask");
			Class662.smethod_0("Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTaskLogon");
			Class662.smethod_0("Microsoft\\Windows\\SoftwareProtectionPlatform\\SvcRestartTaskNetwork");
		}
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x0007D038 File Offset: 0x0007B238
	internal static bool smethod_25(string string_0, string string_1)
	{
		GClass219.Class554 @class = new GClass219.Class554();
		@class.string_0 = string_0;
		return !(string_1 != "4") && (GClass260.gclass211_17.Services.Any(new Func<string, bool>(@class.method_0)) && GClass19.smethod_0());
	}

	// Token: 0x04001429 RID: 5161
	private static List<string> list_0 = new List<string>
	{
		"aarsvc",
		"bcastdvruserservice",
		"bluetoothuserservice",
		"captureservice",
		"cbdhsvc",
		"cdpusersvc",
		"consentuxusersvc",
		"credentialenrollmentmanagerusersvc",
		"deviceassociationbrokersvc",
		"devicepickerusersvc",
		"devicesflowusersvc",
		"messagingservice",
		"onesyncsvc",
		"pimindexmaintenancesvc",
		"printworkflowusersvc",
		"udkusersvc",
		"unistoresvc",
		"userdatasvc",
		"wpnuserservice"
	};

	// Token: 0x02000496 RID: 1174
	private sealed class Class554
	{
		// Token: 0x06001E87 RID: 7815 RVA: 0x0001421C File Offset: 0x0001241C
		internal bool method_0(string string_1)
		{
			return string_1.Equals(this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0400142A RID: 5162
		public string string_0;
	}

	// Token: 0x02000497 RID: 1175
	public sealed class GClass220
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x0001422B File Offset: 0x0001242B
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x00014233 File Offset: 0x00012433
		public string State
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0001423C File Offset: 0x0001243C
		public string method_0()
		{
			return this.string_1;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00014244 File Offset: 0x00012444
		public void method_1(string string_2)
		{
			this.string_1 = string_2;
		}

		// Token: 0x0400142B RID: 5163
		private string string_0;

		// Token: 0x0400142C RID: 5164
		private string string_1;
	}

	// Token: 0x02000498 RID: 1176
	private sealed class Class555
	{
		// Token: 0x06001E8E RID: 7822 RVA: 0x0001424D File Offset: 0x0001244D
		internal void method_0(string string_1)
		{
			if (this.string_0.StartsWith(string_1))
			{
				this.string_0 = string_1;
			}
		}

		// Token: 0x0400142D RID: 5165
		public string string_0;
	}

	// Token: 0x02000499 RID: 1177
	[StructLayout(LayoutKind.Auto)]
	private struct Struct301 : IAsyncStateMachine
	{
		// Token: 0x06001E8F RID: 7823 RVA: 0x0007D08C File Offset: 0x0007B28C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			BitmapSource result;
			try
			{
				try
				{
					TaskAwaiter<BitmapSource> awaiter;
					if (num != 0)
					{
						string text = Class681.smethod_0("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\" + this.string_0, "ImagePath");
						text = text.Replace("\"", string.Empty);
						if (text.ToLower().Contains("system32"))
						{
							result = Class330.smethod_4(Class298.smethod_4("ServicesSvg"));
							goto IL_ED;
						}
						awaiter = Class765.smethod_6(text).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapSource>, GClass219.Struct301>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<BitmapSource>);
						this.int_0 = -1;
					}
					result = awaiter.GetResult();
				}
				catch
				{
					result = Class330.smethod_4(Class298.smethod_4("ServicesSvg"));
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_ED:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00014264 File Offset: 0x00012464
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400142E RID: 5166
		public int int_0;

		// Token: 0x0400142F RID: 5167
		public AsyncTaskMethodBuilder<BitmapSource> asyncTaskMethodBuilder_0;

		// Token: 0x04001430 RID: 5168
		public string string_0;

		// Token: 0x04001431 RID: 5169
		private TaskAwaiter<BitmapSource> taskAwaiter_0;
	}

	// Token: 0x0200049A RID: 1178
	[Serializable]
	private sealed class Class556
	{
		// Token: 0x06001E93 RID: 7827 RVA: 0x0001427E File Offset: 0x0001247E
		internal bool method_0(ServiceController serviceController_0)
		{
			return GClass219.list_0.Contains(GClass219.smethod_16(serviceController_0).ToLower()) && GClass219.smethod_17(serviceController_0) != null;
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000142A2 File Offset: 0x000124A2
		internal void method_1(GClass189 gclass189_0)
		{
			if (gclass189_0.Service.CurrentStartMode == ServiceStartMode.Disabled)
			{
				GClass219.smethod_22(gclass189_0.Service.ServiceName, GClass219.smethod_3(gclass189_0.Service.DefaultStartMode));
			}
		}

		// Token: 0x04001432 RID: 5170
		public static readonly GClass219.Class556 class556_0 = new GClass219.Class556();

		// Token: 0x04001433 RID: 5171
		public static Func<ServiceController, bool> func_0;

		// Token: 0x04001434 RID: 5172
		public static Action<GClass189> action_0;
	}

	// Token: 0x0200049B RID: 1179
	private sealed class Class557
	{
		// Token: 0x06001E96 RID: 7830 RVA: 0x000142D2 File Offset: 0x000124D2
		internal bool method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName.ToLower() == this.string_0.ToLower();
		}

		// Token: 0x04001435 RID: 5173
		public string string_0;
	}
}
