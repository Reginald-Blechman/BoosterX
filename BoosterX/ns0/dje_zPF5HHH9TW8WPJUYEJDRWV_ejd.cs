using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ns0
{
	// Token: 0x0200085D RID: 2141
	public sealed class dje_zPF5HHH9TW8WPJUYEJDRWV_ejd : Application
	{
		// Token: 0x06003323 RID: 13091 RVA: 0x00020125 File Offset: 0x0001E325
		public dje_zPF5HHH9TW8WPJUYEJDRWV_ejd()
		{
			AppDomain.CurrentDomain.ProcessExit += this.method_1;
			AppDomain.CurrentDomain.UnhandledException += this.method_0;
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00020159 File Offset: 0x0001E359
		private void method_0(object sender, UnhandledExceptionEventArgs e)
		{
			if (e.IsTerminating)
			{
				return;
			}
			MessageBox.Show("Please send this error to developers. Thank you.\n" + e.ExceptionObject.ToString(), "UNHANDLED ERROR", MessageBoxButton.OK);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00020187 File Offset: 0x0001E387
		private void dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			GClass268.smethod_1(e.Exception);
			e.Handled = true;
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x000C6164 File Offset: 0x000C4364
		private void dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_Startup(object sender, StartupEventArgs e)
		{
			dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.Struct654 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_0 = this;
			@struct.startupEventArgs_0 = e;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.Struct654>(ref @struct);
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0002019B File Offset: 0x0001E39B
		private void dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_SessionEnding(object sender, SessionEndingCancelEventArgs e)
		{
			if (this.window_0 != null)
			{
				dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = this.window_0 as dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd;
				if (dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd == null)
				{
					return;
				}
				dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.button_4_Click(null, null);
			}
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x000201BC File Offset: 0x0001E3BC
		private void dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_Exit(object sender, ExitEventArgs e)
		{
			this.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_SessionEnding(null, null);
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x000201BC File Offset: 0x0001E3BC
		private void method_1(object sender, EventArgs e)
		{
			this.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_SessionEnding(null, null);
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x000C61A4 File Offset: 0x000C43A4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void method_2()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			base.DispatcherUnhandledException += this.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_DispatcherUnhandledException;
			base.Exit += this.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_Exit;
			base.SessionEnding += this.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_SessionEnding;
			base.Startup += this.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_Startup;
			Uri resourceLocator = new Uri("/BoosterX;component/app.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x000201C6 File Offset: 0x0001E3C6
		[STAThread]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public static void smethod_0()
		{
			dje_zPF5HHH9TW8WPJUYEJDRWV_ejd dje_zPF5HHH9TW8WPJUYEJDRWV_ejd = new dje_zPF5HHH9TW8WPJUYEJDRWV_ejd();
			dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.method_2();
			dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.Run();
		}

		// Token: 0x0400241D RID: 9245
		private Window window_0;

		// Token: 0x0400241E RID: 9246
		private bool bool_0;

		// Token: 0x0200085E RID: 2142
		[StructLayout(LayoutKind.Auto)]
		private struct Struct654 : IAsyncStateMachine
		{
			// Token: 0x0600332C RID: 13100 RVA: 0x000C6220 File Offset: 0x000C4420
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zPF5HHH9TW8WPJUYEJDRWV_ejd dje_zPF5HHH9TW8WPJUYEJDRWV_ejd = this.dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						Class374.smethod_0().method_3();
						string fileName = Process.GetCurrentProcess().MainModule.FileName;
						if (!Class272.smethod_1(fileName) && !Class272.smethod_2(fileName))
						{
							Application.Current.Shutdown();
							Environment.Exit(0);
							Process.GetCurrentProcess().Kill();
							goto IL_1EA;
						}
						if (!Class551.class753_0.method_90().GetValueOrDefault())
						{
							dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.window_0 = new dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd(null);
							dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.window_0.Show();
							goto IL_1EA;
						}
						dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_4();
						if (this.startupEventArgs_0.Args.Length == 0)
						{
							new dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd(null).Show();
							goto IL_1EA;
						}
						if (string.Equals(this.startupEventArgs_0.Args[0], "-gamemodex", StringComparison.OrdinalIgnoreCase))
						{
							dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.window_0 = new dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd(typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd));
							dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.window_0.Show();
							goto IL_1EA;
						}
						if (!string.Equals(this.startupEventArgs_0.Args[0], "-disableav", StringComparison.OrdinalIgnoreCase))
						{
							Class196.smethod_0(this.startupEventArgs_0.Args[0]);
							Application.Current.Shutdown();
							goto IL_1EA;
						}
						awaiter = Task.Delay(2000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.Struct654>(ref awaiter, ref this);
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
					Class808.smethod_27("schtasks /Delete /TN \"BoosterXStartupTask\" /F");
					Class747.smethod_13();
					Class551.class753_0.method_45(new bool?(true));
					dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.window_0 = new dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd(typeof(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd));
					dje_zPF5HHH9TW8WPJUYEJDRWV_ejd.window_0.Show();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1EA:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600332D RID: 13101 RVA: 0x000201D9 File Offset: 0x0001E3D9
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400241F RID: 9247
			public int int_0;

			// Token: 0x04002420 RID: 9248
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002421 RID: 9249
			public dje_zPF5HHH9TW8WPJUYEJDRWV_ejd dje_zPF5HHH9TW8WPJUYEJDRWV_ejd_0;

			// Token: 0x04002422 RID: 9250
			public StartupEventArgs startupEventArgs_0;

			// Token: 0x04002423 RID: 9251
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
