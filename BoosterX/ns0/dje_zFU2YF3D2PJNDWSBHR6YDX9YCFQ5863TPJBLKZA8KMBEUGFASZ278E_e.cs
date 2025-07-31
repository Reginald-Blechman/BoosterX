using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Expression.Shapes;

namespace ns0
{
	// Token: 0x020007EC RID: 2028
	public sealed class dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003147 RID: 12615 RVA: 0x0001F1BE File Offset: 0x0001D3BE
		public dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd()
		{
			this.InitializeComponent();
			dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.gclass139_0.method_0(new EventHandler<double>(this.method_0));
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x0001F218 File Offset: 0x0001D418
		private void method_0(object object_0, double double_3)
		{
			dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2 = double_3;
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x0001F220 File Offset: 0x0001D420
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Task.Run(new Action(this.method_1));
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x000BD8B4 File Offset: 0x000BBAB4
		private void method_1()
		{
			dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref @struct);
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x000BD8EC File Offset: 0x000BBAEC
		private void method_2(CancellationToken cancellationToken_0, TimeSpan timeSpan_0)
		{
			dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct601 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.cancellationToken_0 = cancellationToken_0;
			@struct.timeSpan_0 = timeSpan_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct601>(ref @struct);
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000BD92C File Offset: 0x000BBB2C
		private void method_3(CancellationToken cancellationToken_0, TimeSpan timeSpan_0)
		{
			dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct600 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.cancellationToken_0 = cancellationToken_0;
			@struct.timeSpan_0 = timeSpan_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct600>(ref @struct);
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x000BD96C File Offset: 0x000BBB6C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/internetspeeduc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000BD9A0 File Offset: 0x000BBBA0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.arc_0 = (Arc)target;
				return;
			case 2:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 4:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 5:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 6:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 7:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 8:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_4 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x0001F234 File Offset: 0x0001D434
		private void method_4()
		{
			this.button_0.IsEnabled = false;
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x0001F242 File Offset: 0x0001D442
		private void method_5()
		{
			this.textBlock_1.Text = Class249.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2.ToString(), 2);
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0001F25F File Offset: 0x0001D45F
		private void method_6()
		{
			this.textBlock_1.Text = Class249.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_0.ToString(), 2);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.textBlock_3, this.textBlock_1.Text + " Mbps", null);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0001F29E File Offset: 0x0001D49E
		private void method_7()
		{
			this.textBlock_1.Text = "0";
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000BDA6C File Offset: 0x000BBC6C
		private void method_8()
		{
			this.textBlock_2.Text = Class249.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2.ToString(), 2);
			int num = ((int)dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2 > 100) ? 100 : ((int)dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.arc_0, TimeSpan.FromMilliseconds(1.0), Arc.EndAngleProperty, (double)num * 1.8);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x0001F2B1 File Offset: 0x0001D4B1
		private void method_9()
		{
			this.textBlock_2.Text = Class249.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_1.ToString(), 2);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.textBlock_4, this.textBlock_2.Text + " Mbps", null);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		private void method_10()
		{
			this.button_0.IsEnabled = true;
		}

		// Token: 0x040021EE RID: 8686
		private static GClass139 gclass139_0 = new GClass139();

		// Token: 0x040021EF RID: 8687
		private static double double_0 = 0.0;

		// Token: 0x040021F0 RID: 8688
		private static double double_1 = 0.0;

		// Token: 0x040021F1 RID: 8689
		public static double double_2 = 0.0;

		// Token: 0x040021F2 RID: 8690
		internal Arc arc_0;

		// Token: 0x040021F3 RID: 8691
		internal TextBlock textBlock_0;

		// Token: 0x040021F4 RID: 8692
		internal StackPanel stackPanel_0;

		// Token: 0x040021F5 RID: 8693
		internal TextBlock textBlock_1;

		// Token: 0x040021F6 RID: 8694
		internal StackPanel stackPanel_1;

		// Token: 0x040021F7 RID: 8695
		internal TextBlock textBlock_2;

		// Token: 0x040021F8 RID: 8696
		internal Button button_0;

		// Token: 0x040021F9 RID: 8697
		internal TextBlock textBlock_3;

		// Token: 0x040021FA RID: 8698
		internal TextBlock textBlock_4;

		// Token: 0x040021FB RID: 8699
		private bool bool_0;

		// Token: 0x020007ED RID: 2029
		[StructLayout(LayoutKind.Auto)]
		private struct Struct600 : IAsyncStateMachine
		{
			// Token: 0x06003157 RID: 12631 RVA: 0x000BDAD8 File Offset: 0x000BBCD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<double> awaiter;
					if (num != 0)
					{
						awaiter = dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.gclass139_0.method_3(this.cancellationToken_0, this.timeSpan_0, 5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct600>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<double>);
						this.int_0 = -1;
					}
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_1 = awaiter.GetResult();
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

			// Token: 0x06003158 RID: 12632 RVA: 0x0001F2FE File Offset: 0x0001D4FE
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040021FC RID: 8700
			public int int_0;

			// Token: 0x040021FD RID: 8701
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040021FE RID: 8702
			public CancellationToken cancellationToken_0;

			// Token: 0x040021FF RID: 8703
			public TimeSpan timeSpan_0;

			// Token: 0x04002200 RID: 8704
			private TaskAwaiter<double> taskAwaiter_0;
		}

		// Token: 0x020007EE RID: 2030
		[StructLayout(LayoutKind.Auto)]
		private struct Struct601 : IAsyncStateMachine
		{
			// Token: 0x06003159 RID: 12633 RVA: 0x000BDB9C File Offset: 0x000BBD9C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<double> awaiter;
					if (num != 0)
					{
						awaiter = dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.gclass139_0.method_2(this.cancellationToken_0, this.timeSpan_0, 5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct601>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<double>);
						this.int_0 = -1;
					}
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_0 = awaiter.GetResult();
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

			// Token: 0x0600315A RID: 12634 RVA: 0x0001F30C File Offset: 0x0001D50C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002201 RID: 8705
			public int int_0;

			// Token: 0x04002202 RID: 8706
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002203 RID: 8707
			public CancellationToken cancellationToken_0;

			// Token: 0x04002204 RID: 8708
			public TimeSpan timeSpan_0;

			// Token: 0x04002205 RID: 8709
			private TaskAwaiter<double> taskAwaiter_0;
		}

		// Token: 0x020007EF RID: 2031
		[StructLayout(LayoutKind.Auto)]
		private struct Struct602 : IAsyncStateMachine
		{
			// Token: 0x0600315B RID: 12635 RVA: 0x000BDC60 File Offset: 0x000BBE60
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd = this.dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd_0;
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
						goto IL_17B;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1DD;
					case 3:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_23F;
					case 4:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_2A1;
					case 5:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_383;
					case 6:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_468;
					case 7:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_4CA;
					case 8:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_588;
					case 9:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_66C;
					case 10:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_6D0;
					default:
					{
						dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Dispatcher.Invoke(new Action(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_4));
						CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
						this.cancellationToken_0 = cancellationTokenSource.Token;
						dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_0 = 0.0;
						dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_1 = 0.0;
						dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2 = 0.0;
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, 0.0);
						awaiter = Task.Delay(500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.button_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_17B:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.textBlock_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_1DD:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.textBlock_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_23F:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.stackPanel_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 4;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_2A1:
					awaiter.GetResult();
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_2(this.cancellationToken_0, TimeSpan.FromSeconds(10.0));
					this.int_1 = 0;
					IL_2EC:
					if (dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_0 != 0.0)
					{
						goto IL_3CA;
					}
					if (dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2 != 0.0)
					{
						dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Dispatcher.Invoke(new Action(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_5));
						int num2 = ((int)dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2 > 100) ? 100 : ((int)dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2);
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.arc_0, TimeSpan.FromMilliseconds(1.0), Arc.EndAngleProperty, (double)num2 * 1.8);
					}
					awaiter = Task.Delay(5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 5;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_383:
					awaiter.GetResult();
					int num3 = this.int_1;
					this.int_1 = num3 + 1;
					if (num3 <= 5000)
					{
						goto IL_2EC;
					}
					IL_3CA:
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Dispatcher.Invoke(new Action(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_6));
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.arc_0, TimeSpan.FromSeconds(0.1), Arc.EndAngleProperty, 0.0);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.stackPanel_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 6;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_468:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.stackPanel_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 7;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_4CA:
					awaiter.GetResult();
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2 = 0.0;
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Dispatcher.Invoke(new Action(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_7));
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_3(this.cancellationToken_0, TimeSpan.FromSeconds(10.0));
					this.int_2 = 0;
					IL_537:
					if (dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_1 != 0.0)
					{
						goto IL_5CC;
					}
					if (dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.double_2 != 0.0)
					{
						dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Dispatcher.Invoke(new Action(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_8));
					}
					awaiter = Task.Delay(5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 8;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_588:
					awaiter.GetResult();
					num3 = this.int_2;
					this.int_2 = num3 + 1;
					if (num3 <= 5000)
					{
						goto IL_537;
					}
					IL_5CC:
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Dispatcher.Invoke(new Action(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_9));
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, 0.0);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.stackPanel_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 9;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_66C:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.button_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 10;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Struct602>(ref awaiter, ref this);
						return;
					}
					IL_6D0:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.arc_0, TimeSpan.FromSeconds(0.5), Arc.EndAngleProperty, 180.0);
					dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.Dispatcher.Invoke(new Action(dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd.method_10));
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.cancellationToken_0 = default(CancellationToken);
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.cancellationToken_0 = default(CancellationToken);
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600315C RID: 12636 RVA: 0x0001F31A File Offset: 0x0001D51A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002206 RID: 8710
			public int int_0;

			// Token: 0x04002207 RID: 8711
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002208 RID: 8712
			public dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd dje_zFU2YF3D2PJNDWSBHR6YDX9YCFQ5863TPJBLKZA8KMBEUGFASZ278E_ejd_0;

			// Token: 0x04002209 RID: 8713
			private CancellationToken cancellationToken_0;

			// Token: 0x0400220A RID: 8714
			private int int_1;

			// Token: 0x0400220B RID: 8715
			private int int_2;

			// Token: 0x0400220C RID: 8716
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
