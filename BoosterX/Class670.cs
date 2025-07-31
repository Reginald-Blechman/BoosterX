using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x0200056E RID: 1390
internal sealed class Class670
{
	// Token: 0x060022E1 RID: 8929 RVA: 0x0008A270 File Offset: 0x00088470
	public static Task<List<Class707>> smethod_0()
	{
		Class670.Struct359 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class707>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class670.Struct359>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0200056F RID: 1391
	[StructLayout(LayoutKind.Auto)]
	private struct Struct359 : IAsyncStateMachine
	{
		// Token: 0x060022E2 RID: 8930 RVA: 0x0008A2AC File Offset: 0x000884AC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class707> result;
			try
			{
				TaskAwaiter<List<Class512>> awaiter;
				if (num != 0)
				{
					List<Class707> list = new List<Class707>();
					Class707 @class = new Class707();
					@class.Name = "WBISOMounting";
					@class.method_1(new Action(Class670.Class671.class671_0.method_0));
					list.Add(@class);
					Class707 class2 = new Class707();
					class2.Name = "WBInternetShortCut";
					class2.method_1(new Action(Class670.Class671.class671_0.method_1));
					list.Add(class2);
					Class707 class3 = new Class707();
					class3.Name = "Vanguard requires CFG enabled (Valorant)";
					class3.method_1(new Action(Class670.Class671.class671_0.method_2));
					list.Add(class3);
					Class707 class4 = new Class707();
					class4.Name = "WBPatchedWindowsLoaderEAC";
					class4.method_1(new Action(Class670.Class671.class671_0.method_3));
					list.Add(class4);
					Class707 class5 = new Class707();
					class5.Name = "WBBlueStacks";
					class5.method_1(new Action(Class670.Class671.class671_0.method_4));
					class5.method_3(new Task<bool>(new Func<bool>(Class670.Class671.class671_0.method_5)));
					list.Add(class5);
					Class707 class6 = new Class707();
					class6.Name = "WBAppxIncorrect";
					class6.method_1(new Action(Class670.Class671.class671_0.method_6));
					list.Add(class6);
					Class707 class7 = new Class707();
					class7.Name = "WBDefenderFix";
					class7.method_1(new Action(Class670.Class671.class671_0.method_7));
					list.Add(class7);
					Class707 class8 = new Class707();
					class8.Name = "WBNightLightFix";
					class8.method_1(new Action(Class670.Class671.class671_0.method_8));
					list.Add(class8);
					Class707 class9 = new Class707();
					class9.Name = "WBNvidia3DAccessError";
					class9.method_1(new Action(Class670.Class671.class671_0.method_9));
					list.Add(class9);
					Class707 class10 = new Class707();
					class10.Name = "WBNightLightFix2";
					class10.method_1(new Action(Class670.Class671.class671_0.method_10));
					list.Add(class10);
					Class707 class11 = new Class707();
					class11.Name = "WBUpdatesFull";
					class11.method_1(new Action(Class670.Class671.class671_0.method_11));
					class11.method_3(new Task<bool>(new Func<bool>(Class670.Class671.class671_0.method_12)));
					list.Add(class11);
					Class707 class12 = new Class707();
					class12.Name = "WBDefender";
					class12.method_1(new Action(Class670.Class671.class671_0.method_13));
					list.Add(class12);
					this.list_0 = list;
					awaiter = Class148.smethod_8().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class512>>, Class670.Struct359>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class512>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				List<Class512>.Enumerator enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class670.Class672 class13 = new Class670.Class672();
						class13.class512_0 = enumerator.Current;
						if (class13.class512_0.WillBrake.Count<string>() != 0)
						{
							bool bool_ = !class13.class512_0.method_18();
							List<string>.Enumerator enumerator2 = class13.class512_0.WillBrake.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									string name = enumerator2.Current;
									List<Class707> list2 = this.list_0;
									Class707 class14 = new Class707();
									class14.Name = name;
									Action action_;
									if ((action_ = class13.action_0) == null)
									{
										action_ = (class13.action_0 = new Action(class13.method_0));
									}
									class14.method_1(action_);
									class14.method_5(bool_);
									list2.Add(class14);
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00016EB9 File Offset: 0x000150B9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400170E RID: 5902
		public int int_0;

		// Token: 0x0400170F RID: 5903
		public AsyncTaskMethodBuilder<List<Class707>> asyncTaskMethodBuilder_0;

		// Token: 0x04001710 RID: 5904
		private List<Class707> list_0;

		// Token: 0x04001711 RID: 5905
		private TaskAwaiter<List<Class512>> taskAwaiter_0;
	}

	// Token: 0x02000570 RID: 1392
	[Serializable]
	private sealed class Class671
	{
		// Token: 0x060022E6 RID: 8934 RVA: 0x0008A7C8 File Offset: 0x000889C8
		internal void method_0()
		{
			Class808.smethod_27("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\ShellHWDetection\" /v \"Start\" /t REG_DWORD /d \"2\" /f");
			try
			{
				Class304.smethod_9("ROOT\\vdrvroot\\0000");
			}
			catch
			{
			}
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00016ED3 File Offset: 0x000150D3
		internal void method_1()
		{
			Class808.smethod_27("assoc .URL=InternetShortcut");
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00016EE0 File Offset: 0x000150E0
		internal void method_2()
		{
			Class808.smethod_27("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\vgc.exe\" /v \"MitigationOptions\" /t REG_BINARY /d \"000000000001000000000000000000000000000000000000\" /f");
			Class808.smethod_27("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\vgc.exe\" /v \"MitigationAuditOptions\" /t REG_BINARY /d \"000000000000000000000000000000000000000000000000\" /f");
			Class808.smethod_27("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\vgc.exe\" /v \"EAFModules\" /t REG_SZ /d \"\" /f");
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00016F03 File Offset: 0x00015103
		internal void method_3()
		{
			GClass290.smethod_0("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /v \"EnableVirtualizationBasedSecurity\" /t REG_DWORD /d 1 /f", false);
			GClass290.smethod_0("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\HypervisorEnforcedCodeIntegrity\" /v \"Enabled\" /t REG_DWORD /d 1 /f", false);
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00016F1F File Offset: 0x0001511F
		internal void method_4()
		{
			Class808.smethod_27("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\Disabled\" /v \"electron.app.BlueStacks Services\" /f");
			Class808.smethod_27("reg add \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"electron.app.BlueStacks Services\" /t REG_SZ /d \"C:\\Users\\ios1ph\\AppData\\Local\\Programs\\bluestacks-services\\BlueStacksServices.exe --hidden\" /f");
			Class808.smethod_27("schtasks /change /TN \"BlueStacksHelper_nxt\" /Enable");
			Class808.smethod_27("schtasks /change /TN \"\\BlueStacksHelper_nxt\" /Enable");
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00016F4D File Offset: 0x0001514D
		internal bool method_5()
		{
			return Class681.smethod_2("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\Disabled", "electron.app.BlueStacks Services") || !Class662.smethod_3("BlueStacksHelper_nxt");
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0008A800 File Offset: 0x00088A00
		internal void method_6()
		{
			Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Fixes", "appxfixer.ps1", false);
			GClass290.smethod_0("cmd.exe /c powershell " + Path.Combine(Class169.string_4, "appxfixer.ps1"), false);
			File.Delete(Path.Combine(Class169.string_4, "appxfixer.ps1"));
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0008A864 File Offset: 0x00088A64
		internal void method_7()
		{
			Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Fixes", "FixDefenderUI.bat", false);
			GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "FixDefenderUI.bat"), false);
			File.Delete(Path.Combine(Class169.string_4, "FixDefenderUI.bat"));
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0008A8C8 File Offset: 0x00088AC8
		internal void method_8()
		{
			Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Fixes", "NightLightFix.bat", false);
			GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "NightLightFix.bat"), false);
			File.Delete(Path.Combine(Class169.string_4, "NightLightFix.bat"));
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00016F74 File Offset: 0x00015174
		internal void method_9()
		{
			Class808.smethod_27("rmdir /s /q \"C:\\ProgramData\\Nvidia Corporation\\Drs\"");
			Class808.smethod_27("mkdir \"C:\\ProgramData\\Nvidia Corporation\\Drs\"");
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0008A92C File Offset: 0x00088B2C
		internal void method_10()
		{
			Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Fixes", "BlueLightDefault.bat", false);
			GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "BlueLightDefault.bat"), false);
			File.Delete(Path.Combine(Class169.string_4, "BlueLightDefault.bat"));
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0008A990 File Offset: 0x00088B90
		internal void method_11()
		{
			Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Updates", "enable.bat", false);
			GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "enable.bat"), false);
			File.Delete(Path.Combine(Class169.string_4, "enable.bat"));
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00016F8C File Offset: 0x0001518C
		internal bool method_12()
		{
			return Class673.smethod_24("wuauserv") == "BEST";
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00016FA9 File Offset: 0x000151A9
		internal void method_13()
		{
			Class747.smethod_12("DEFAULT");
		}

		// Token: 0x04001712 RID: 5906
		public static readonly Class670.Class671 class671_0 = new Class670.Class671();

		// Token: 0x04001713 RID: 5907
		public static Action action_0;

		// Token: 0x04001714 RID: 5908
		public static Action action_1;

		// Token: 0x04001715 RID: 5909
		public static Action action_2;

		// Token: 0x04001716 RID: 5910
		public static Action action_3;

		// Token: 0x04001717 RID: 5911
		public static Action action_4;

		// Token: 0x04001718 RID: 5912
		public static Func<bool> func_0;

		// Token: 0x04001719 RID: 5913
		public static Action action_5;

		// Token: 0x0400171A RID: 5914
		public static Action action_6;

		// Token: 0x0400171B RID: 5915
		public static Action action_7;

		// Token: 0x0400171C RID: 5916
		public static Action action_8;

		// Token: 0x0400171D RID: 5917
		public static Action action_9;

		// Token: 0x0400171E RID: 5918
		public static Action action_10;

		// Token: 0x0400171F RID: 5919
		public static Func<bool> func_1;

		// Token: 0x04001720 RID: 5920
		public static Action action_11;
	}

	// Token: 0x02000571 RID: 1393
	private sealed class Class672
	{
		// Token: 0x060022F5 RID: 8949 RVA: 0x0008A9F4 File Offset: 0x00088BF4
		internal void method_0()
		{
			Class670.Class672.Struct360 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class672_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class670.Class672.Struct360>(ref @struct);
		}

		// Token: 0x04001721 RID: 5921
		public Class512 class512_0;

		// Token: 0x04001722 RID: 5922
		public Action action_0;

		// Token: 0x02000572 RID: 1394
		[StructLayout(LayoutKind.Auto)]
		private struct Struct360 : IAsyncStateMachine
		{
			// Token: 0x060022F6 RID: 8950 RVA: 0x0008AA2C File Offset: 0x00088C2C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class670.Class672 @class = this.class672_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = @class.class512_0.method_32("DEFAULT").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class670.Class672.Struct360>(ref awaiter, ref this);
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

			// Token: 0x060022F7 RID: 8951 RVA: 0x00016FB6 File Offset: 0x000151B6
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001723 RID: 5923
			public int int_0;

			// Token: 0x04001724 RID: 5924
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001725 RID: 5925
			public Class670.Class672 class672_0;

			// Token: 0x04001726 RID: 5926
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
