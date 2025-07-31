using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x020007AD RID: 1965
	public sealed class dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002FEA RID: 12266 RVA: 0x0001E7F2 File Offset: 0x0001C9F2
		public dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd()
		{
			this.InitializeComponent();
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_16(new dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.GDelegate4(this.method_1));
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_14(new dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.GDelegate5(this.method_2));
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x0001E822 File Offset: 0x0001CA22
		private void method_0(object sender, RoutedEventArgs e)
		{
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_18();
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x000B844C File Offset: 0x000B664C
		private void method_1()
		{
			dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct567 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct567>(ref @struct);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x000B8484 File Offset: 0x000B6684
		private void method_2()
		{
			dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct568 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct568>(ref @struct);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x000B84BC File Offset: 0x000B66BC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/optlevelmainpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000B84F0 File Offset: 0x000B66F0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd)target).Loaded += this.method_0;
				return;
			case 2:
				this.arc_0 = (Arc)target;
				return;
			case 3:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 4:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 5:
				this.textBlock_2 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000B856C File Offset: 0x000B676C
		private void method_3()
		{
			this.textBlock_0.Text = "0";
			this.textBlock_0.Foreground = Brushes.White;
			this.textBlock_1.Foreground = Brushes.White;
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_34(this.arc_0, 0f);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.arc_0, TimeSpan.FromSeconds(0.1), Arc.EndAngleProperty, 0.0);
			this.textBlock_2.Text = Class298.smethod_2("Checkingtext");
		}

		// Token: 0x0400208F RID: 8335
		internal Arc arc_0;

		// Token: 0x04002090 RID: 8336
		internal TextBlock textBlock_0;

		// Token: 0x04002091 RID: 8337
		internal TextBlock textBlock_1;

		// Token: 0x04002092 RID: 8338
		internal TextBlock textBlock_2;

		// Token: 0x04002093 RID: 8339
		private bool bool_0;

		// Token: 0x020007AE RID: 1966
		[StructLayout(LayoutKind.Auto)]
		private struct Struct567 : IAsyncStateMachine
		{
			// Token: 0x06002FF1 RID: 12273 RVA: 0x000B85FC File Offset: 0x000B67FC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd = this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (!dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.IsVisible)
						{
							goto IL_A0;
						}
						awaiter = dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Dispatcher.InvokeAsync(new Action(dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.method_3)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct567>(ref awaiter, ref this);
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
				IL_A0:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002FF2 RID: 12274 RVA: 0x0001E829 File Offset: 0x0001CA29
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002094 RID: 8340
			public int int_0;

			// Token: 0x04002095 RID: 8341
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002096 RID: 8342
			public dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0;

			// Token: 0x04002097 RID: 8343
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007AF RID: 1967
		[StructLayout(LayoutKind.Auto)]
		private struct Struct568 : IAsyncStateMachine
		{
			// Token: 0x06002FF3 RID: 12275 RVA: 0x000B86CC File Offset: 0x000B68CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd = this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0;
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
						goto IL_143;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1A2;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_210;
					default:
						this.class904_0 = new dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Class904();
						this.class904_0.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0 = this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0;
						if (!dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.IsVisible)
						{
							goto IL_247;
						}
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct568>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					this.class904_0.double_0 = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.double_0;
					this.class904_0.double_1 = this.class904_0.double_0 * 3.6;
					awaiter = dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Dispatcher.InvokeAsync(new Action(this.class904_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct568>(ref awaiter, ref this);
						return;
					}
					IL_143:
					awaiter.GetResult();
					awaiter = Task.Delay(3000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct568>(ref awaiter, ref this);
						return;
					}
					IL_1A2:
					awaiter.GetResult();
					awaiter = dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Dispatcher.InvokeAsync(new Action(this.class904_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Struct568>(ref awaiter, ref this);
						return;
					}
					IL_210:
					awaiter.GetResult();
					dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.string_3 = dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.textBlock_0.Text;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class904_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_247:
				this.int_0 = -2;
				this.class904_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002FF4 RID: 12276 RVA: 0x0001E837 File Offset: 0x0001CA37
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002098 RID: 8344
			public int int_0;

			// Token: 0x04002099 RID: 8345
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400209A RID: 8346
			public dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0;

			// Token: 0x0400209B RID: 8347
			private dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd.Class904 class904_0;

			// Token: 0x0400209C RID: 8348
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007B0 RID: 1968
		private sealed class Class904
		{
			// Token: 0x06002FF6 RID: 12278 RVA: 0x000B8958 File Offset: 0x000B6B58
			internal void method_0()
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_37(this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0.textBlock_0, this.double_0);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_35(this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0.textBlock_0, (float)this.double_0);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_35(this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0.textBlock_1, (float)this.double_0);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0.arc_0, TimeSpan.FromSeconds(3.0), Arc.EndAngleProperty, this.double_1);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_34(this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0.arc_0, (float)this.double_0);
			}

			// Token: 0x06002FF7 RID: 12279 RVA: 0x0001E845 File Offset: 0x0001CA45
			internal void method_1()
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_36(this.dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0.textBlock_2, this.double_0);
			}

			// Token: 0x0400209D RID: 8349
			public dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd dje_zBU3CS7GN6NFVKVZP4BJBKHDGQWSLME77KSQR4MZ5U9E4HPLFJPTX2V2BZ3UA_ejd_0;

			// Token: 0x0400209E RID: 8350
			public double double_0;

			// Token: 0x0400209F RID: 8351
			public double double_1;
		}
	}
}
