using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using ns0;
using PIManagerX;

// Token: 0x020002F3 RID: 755
public static class GClass97
{
	// Token: 0x060013AE RID: 5038 RVA: 0x00062194 File Offset: 0x00060394
	public static void smethod_0()
	{
		GClass97.Struct163 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass97.Struct163>(ref @struct);
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x000621C4 File Offset: 0x000603C4
	public static void smethod_1(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		if (GClass97.smethod_2(string_0))
		{
			return;
		}
		string text = GClass97.smethod_4(string_0);
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				Class808.smethod_27("netsh interface set interface name=\"" + text + "\" admin=DISABLED");
				Thread.Sleep(1200);
				Class808.smethod_27("netsh interface set interface name=\"" + text + "\" admin=ENABLED");
				return;
			}
			catch
			{
			}
		}
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE PNPDeviceID = \"" + string_0.Replace("\\", "\\\\") + "\"");
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						managementObject.InvokeMethod("Disable", null);
						Thread.Sleep(1200);
						managementObject.InvokeMethod("Enable", null);
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x000622F0 File Offset: 0x000604F0
	private static bool smethod_2(string string_0)
	{
		IntPtr intPtr = NetAdapManager.SetupDiGetClassDevs(ref NetAdapManager.GUID_DEVCLASS_NET, IntPtr.Zero, IntPtr.Zero, 10U);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == (IntPtr)(-1)))
		{
			try
			{
				NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA = default(NetAdapManager.SP_DEVINFO_DATA);
				sp_DEVINFO_DATA.cbSize = (uint)Marshal.SizeOf(typeof(NetAdapManager.SP_DEVINFO_DATA));
				NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA2 = sp_DEVINFO_DATA;
				uint num = 0U;
				while (NetAdapManager.SetupDiEnumDeviceInfo(intPtr, num, ref sp_DEVINFO_DATA2))
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					int num2;
					if (NetAdapManager.SetupDiGetDeviceInstanceId(intPtr, ref sp_DEVINFO_DATA2, stringBuilder, stringBuilder.Capacity, ref num2) && string_0.Equals(stringBuilder.ToString(), StringComparison.OrdinalIgnoreCase))
					{
						return GClass97.smethod_3(intPtr, ref sp_DEVINFO_DATA2, 2U) && GClass97.smethod_3(intPtr, ref sp_DEVINFO_DATA2, 1U);
					}
					num += 1U;
				}
			}
			finally
			{
				NetAdapManager.SetupDiDestroyDeviceInfoList(intPtr);
			}
			return false;
		}
		return false;
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x000623D4 File Offset: 0x000605D4
	private static bool smethod_3(IntPtr intptr_0, ref NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA_0, uint uint_0)
	{
		NetAdapManager.SP_PROPCHANGE_PARAMS sp_PROPCHANGE_PARAMS = default(NetAdapManager.SP_PROPCHANGE_PARAMS);
		NetAdapManager.SP_CLASSINSTALL_HEADER classInstallHeader = default(NetAdapManager.SP_CLASSINSTALL_HEADER);
		classInstallHeader.cbSize = (uint)Marshal.SizeOf(typeof(NetAdapManager.SP_CLASSINSTALL_HEADER));
		classInstallHeader.InstallFunction = 18U;
		sp_PROPCHANGE_PARAMS.ClassInstallHeader = classInstallHeader;
		sp_PROPCHANGE_PARAMS.StateChange = uint_0;
		sp_PROPCHANGE_PARAMS.Scope = 1U;
		sp_PROPCHANGE_PARAMS.HwProfile = 0U;
		NetAdapManager.SP_PROPCHANGE_PARAMS structure = sp_PROPCHANGE_PARAMS;
		return NetAdapManager.SetupDiSetClassInstallParams(intptr_0, ref sp_DEVINFO_DATA_0, ref structure, Marshal.SizeOf<NetAdapManager.SP_PROPCHANGE_PARAMS>(structure)) && NetAdapManager.SetupDiCallClassInstaller(18U, intptr_0, ref sp_DEVINFO_DATA_0);
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x00062450 File Offset: 0x00060650
	private static string smethod_4(string string_0)
	{
		IntPtr intPtr = NetAdapManager.SetupDiGetClassDevs(ref NetAdapManager.GUID_DEVCLASS_NET, IntPtr.Zero, IntPtr.Zero, 10U);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == (IntPtr)(-1)))
		{
			byte[] array = new byte[1024];
			try
			{
				NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA = default(NetAdapManager.SP_DEVINFO_DATA);
				sp_DEVINFO_DATA.cbSize = (uint)Marshal.SizeOf(typeof(NetAdapManager.SP_DEVINFO_DATA));
				NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA2 = sp_DEVINFO_DATA;
				uint num = 0U;
				while (NetAdapManager.SetupDiEnumDeviceInfo(intPtr, num, ref sp_DEVINFO_DATA2))
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					int num2;
					uint num3;
					uint num4;
					if (NetAdapManager.SetupDiGetDeviceInstanceId(intPtr, ref sp_DEVINFO_DATA2, stringBuilder, stringBuilder.Capacity, ref num2) && string_0.Equals(stringBuilder.ToString(), StringComparison.OrdinalIgnoreCase) && NetAdapManager.SetupDiGetDeviceRegistryProperty(intPtr, ref sp_DEVINFO_DATA2, 10U, ref num3, array, (uint)array.Length, ref num4))
					{
						string str = Encoding.Unicode.GetString(array).TrimEnd(new char[1]);
						using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\\\CurrentControlSet\\\\Control\\\\Network\\\\{4d36e972-e325-11ce-bfc1-08002be10318}\\\\" + str + "\\\\Connection"))
						{
							string result;
							if (registryKey != null)
							{
								object value = registryKey.GetValue("Name");
								if (value != null)
								{
									if ((result = value.ToString()) != null)
									{
										goto IL_11C;
									}
								}
							}
							result = string.Empty;
							IL_11C:
							return result;
						}
						break;
					}
					num += 1U;
				}
			}
			catch
			{
			}
			finally
			{
				NetAdapManager.SetupDiDestroyDeviceInfoList(intPtr);
			}
			return string.Empty;
		}
		return string.Empty;
	}

	// Token: 0x020002F4 RID: 756
	[StructLayout(LayoutKind.Auto)]
	private struct Struct163 : IAsyncStateMachine
	{
		// Token: 0x060013B3 RID: 5043 RVA: 0x000625CC File Offset: 0x000607CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(GClass97.Class361.class361_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass97.Struct163>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0000DE68 File Offset: 0x0000C068
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D35 RID: 3381
		public int int_0;

		// Token: 0x04000D36 RID: 3382
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000D37 RID: 3383
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002F5 RID: 757
	[Serializable]
	private sealed class Class361
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x00062698 File Offset: 0x00060898
		internal void method_0()
		{
			object object_ = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.object_0;
			lock (object_)
			{
				try
				{
					if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_3.Count<string>() != 0)
					{
						dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_13("RestartingNetworkAdapters", (GEnum15)1);
						foreach (string string_ in dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_3)
						{
							GClass97.smethod_1(string_);
						}
					}
				}
				catch
				{
				}
				finally
				{
					dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_3.Clear();
				}
			}
		}

		// Token: 0x04000D38 RID: 3384
		public static readonly GClass97.Class361 class361_0 = new GClass97.Class361();

		// Token: 0x04000D39 RID: 3385
		public static Action action_0;
	}
}
