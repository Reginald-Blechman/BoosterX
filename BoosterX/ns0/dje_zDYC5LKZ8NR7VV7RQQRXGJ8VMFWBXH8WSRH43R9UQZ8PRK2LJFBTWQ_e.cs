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
	// Token: 0x020007D1 RID: 2001
	public sealed class dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd : Page, IComponentConnector
	{
		// Token: 0x060030B7 RID: 12471 RVA: 0x0001EE61 File Offset: 0x0001D061
		public dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0001EE76 File Offset: 0x0001D076
		private void method_0(bool bool_1)
		{
			this.button_3.IsEnabled = false;
			base.DataContext = null;
			base.DataContext = GClass134.smethod_0(bool_1);
			this.button_3.IsEnabled = true;
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0001EEA3 File Offset: 0x0001D0A3
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			this.method_0(true);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000BB0A0 File Offset: 0x000B92A0
		public void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct582 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct582>(ref @struct);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000BB0D0 File Offset: 0x000B92D0
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct584 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct584>(ref @struct);
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x000BB100 File Offset: 0x000B9300
		public void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct583 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct583>(ref @struct);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x000BB130 File Offset: 0x000B9330
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/devicespage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x000BB164 File Offset: 0x000B9364
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
				this.checkBox_1 = (CheckBox)target;
				return;
			case 7:
				this.checkBox_2 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002156 RID: 8534
		internal Button button_0;

		// Token: 0x04002157 RID: 8535
		internal Button button_1;

		// Token: 0x04002158 RID: 8536
		internal Button button_2;

		// Token: 0x04002159 RID: 8537
		internal Button button_3;

		// Token: 0x0400215A RID: 8538
		internal CheckBox checkBox_0;

		// Token: 0x0400215B RID: 8539
		internal CheckBox checkBox_1;

		// Token: 0x0400215C RID: 8540
		internal CheckBox checkBox_2;

		// Token: 0x0400215D RID: 8541
		private bool bool_0;

		// Token: 0x020007D2 RID: 2002
		[StructLayout(LayoutKind.Auto)]
		private struct Struct582 : IAsyncStateMachine
		{
			// Token: 0x060030BF RID: 12479 RVA: 0x000BB254 File Offset: 0x000B9454
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = GClass134.smethod_2().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct582>(ref awaiter, ref this);
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

			// Token: 0x060030C0 RID: 12480 RVA: 0x0001EEAC File Offset: 0x0001D0AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400215E RID: 8542
			public int int_0;

			// Token: 0x0400215F RID: 8543
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002160 RID: 8544
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007D3 RID: 2003
		[StructLayout(LayoutKind.Auto)]
		private struct Struct583 : IAsyncStateMachine
		{
			// Token: 0x060030C1 RID: 12481 RVA: 0x000BB300 File Offset: 0x000B9500
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = GClass134.smethod_3().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct583>(ref awaiter, ref this);
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

			// Token: 0x060030C2 RID: 12482 RVA: 0x0001EEBA File Offset: 0x0001D0BA
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002161 RID: 8545
			public int int_0;

			// Token: 0x04002162 RID: 8546
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002163 RID: 8547
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007D4 RID: 2004
		[StructLayout(LayoutKind.Auto)]
		private struct Struct584 : IAsyncStateMachine
		{
			// Token: 0x060030C3 RID: 12483 RVA: 0x000BB3AC File Offset: 0x000B95AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = GClass134.smethod_4().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd.Struct584>(ref awaiter, ref this);
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

			// Token: 0x060030C4 RID: 12484 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002164 RID: 8548
			public int int_0;

			// Token: 0x04002165 RID: 8549
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002166 RID: 8550
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
