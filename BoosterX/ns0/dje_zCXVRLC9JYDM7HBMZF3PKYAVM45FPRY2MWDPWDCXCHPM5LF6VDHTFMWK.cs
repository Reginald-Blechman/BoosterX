using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007B7 RID: 1975
	public sealed class dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd : Page, IComponentConnector
	{
		// Token: 0x0600302C RID: 12332 RVA: 0x0001EB1C File Offset: 0x0001CD1C
		public dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x000B8D9C File Offset: 0x000B6F9C
		public void method_0(bool bool_1)
		{
			dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct570 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd_0 = this;
			@struct.bool_0 = bool_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct570>(ref @struct);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0001EB31 File Offset: 0x0001CD31
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(true);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x000B8DDC File Offset: 0x000B6FDC
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct569 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct569>(ref @struct);
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x000B8E0C File Offset: 0x000B700C
		public void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct572 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct572>(ref @struct);
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x000B8E3C File Offset: 0x000B703C
		public void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct571 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.routedEventArgs_0 = e;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct571>(ref @struct);
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x000B8E74 File Offset: 0x000B7074
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/winservices.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_1(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x000B8EA8 File Offset: 0x000B70A8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 3:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 4:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 5:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 6:
				this.dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0 = (dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd)target;
				return;
			case 7:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040020B8 RID: 8376
		internal Button button_0;

		// Token: 0x040020B9 RID: 8377
		internal Button button_1;

		// Token: 0x040020BA RID: 8378
		internal Button button_2;

		// Token: 0x040020BB RID: 8379
		internal Button button_3;

		// Token: 0x040020BC RID: 8380
		internal CheckBox checkBox_0;

		// Token: 0x040020BD RID: 8381
		internal dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0;

		// Token: 0x040020BE RID: 8382
		internal ItemsControl itemsControl_0;

		// Token: 0x040020BF RID: 8383
		private bool bool_0;

		// Token: 0x020007B8 RID: 1976
		[StructLayout(LayoutKind.Auto)]
		private struct Struct569 : IAsyncStateMachine
		{
			// Token: 0x06003035 RID: 12341 RVA: 0x000B8F98 File Offset: 0x000B7198
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class589.smethod_6().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct569>(ref awaiter, ref this);
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

			// Token: 0x06003036 RID: 12342 RVA: 0x0001EB3A File Offset: 0x0001CD3A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020C0 RID: 8384
			public int int_0;

			// Token: 0x040020C1 RID: 8385
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020C2 RID: 8386
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007B9 RID: 1977
		[StructLayout(LayoutKind.Auto)]
		private struct Struct570 : IAsyncStateMachine
		{
			// Token: 0x06003037 RID: 12343 RVA: 0x000B9044 File Offset: 0x000B7244
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd = this.dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_104;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_163;
					default:
						dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.button_3.IsEnabled = false;
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.itemsControl_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct570>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0);
					dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.DataContext = null;
					dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.DataContext = Class589.smethod_1(this.bool_0);
					awaiter = Class589.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct570>(ref awaiter, ref this);
						return;
					}
					IL_104:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct570>(ref awaiter, ref this);
						return;
					}
					IL_163:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.itemsControl_0);
					dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.button_3.IsEnabled = true;
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

			// Token: 0x06003038 RID: 12344 RVA: 0x0001EB48 File Offset: 0x0001CD48
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020C3 RID: 8387
			public int int_0;

			// Token: 0x040020C4 RID: 8388
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020C5 RID: 8389
			public dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd_0;

			// Token: 0x040020C6 RID: 8390
			public bool bool_0;

			// Token: 0x040020C7 RID: 8391
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007BA RID: 1978
		[StructLayout(LayoutKind.Auto)]
		private struct Struct571 : IAsyncStateMachine
		{
			// Token: 0x06003039 RID: 12345 RVA: 0x000B921C File Offset: 0x000B741C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class589.smethod_5(this.routedEventArgs_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct571>(ref awaiter, ref this);
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

			// Token: 0x0600303A RID: 12346 RVA: 0x0001EB56 File Offset: 0x0001CD56
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020C8 RID: 8392
			public int int_0;

			// Token: 0x040020C9 RID: 8393
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020CA RID: 8394
			public RoutedEventArgs routedEventArgs_0;

			// Token: 0x040020CB RID: 8395
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007BB RID: 1979
		[StructLayout(LayoutKind.Auto)]
		private struct Struct572 : IAsyncStateMachine
		{
			// Token: 0x0600303B RID: 12347 RVA: 0x000B92CC File Offset: 0x000B74CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class589.smethod_4().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd.Struct572>(ref awaiter, ref this);
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

			// Token: 0x0600303C RID: 12348 RVA: 0x0001EB64 File Offset: 0x0001CD64
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020CC RID: 8396
			public int int_0;

			// Token: 0x040020CD RID: 8397
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020CE RID: 8398
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
