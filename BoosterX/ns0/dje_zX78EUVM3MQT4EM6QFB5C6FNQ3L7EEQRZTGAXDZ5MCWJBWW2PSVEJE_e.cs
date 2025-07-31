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
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace ns0
{
	// Token: 0x020008C6 RID: 2246
	public sealed class dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060034F0 RID: 13552 RVA: 0x00020FCA File Offset: 0x0001F1CA
		public dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000CEB38 File Offset: 0x000CCD38
		private void button_0_MouseMove(object sender, MouseEventArgs e)
		{
			dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.Struct711 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd_0 = this;
			@struct.mouseEventArgs_0 = e;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.Struct711>(ref @struct);
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000CEB78 File Offset: 0x000CCD78
		private void button_0_MouseLeave(object sender, MouseEventArgs e)
		{
			dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.Struct710 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.Struct710>(ref @struct);
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x0001D769 File Offset: 0x0001B969
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000CEBB0 File Offset: 0x000CCDB0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/buttonsucs/coolbutton.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000CEBE4 File Offset: 0x000CCDE4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.border_0 = (Border)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				this.button_0.MouseLeave += this.button_0_MouseLeave;
				this.button_0.MouseMove += this.button_0_MouseMove;
				return;
			case 3:
				this.dropShadowEffect_0 = (DropShadowEffect)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002661 RID: 9825
		private readonly object object_0 = new object();

		// Token: 0x04002662 RID: 9826
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x04002663 RID: 9827
		private readonly object object_1 = new object();

		// Token: 0x04002664 RID: 9828
		private DateTime dateTime_1 = DateTime.MinValue;

		// Token: 0x04002665 RID: 9829
		internal Border border_0;

		// Token: 0x04002666 RID: 9830
		internal Button button_0;

		// Token: 0x04002667 RID: 9831
		internal DropShadowEffect dropShadowEffect_0;

		// Token: 0x04002668 RID: 9832
		private bool bool_0;

		// Token: 0x020008C7 RID: 2247
		[StructLayout(LayoutKind.Auto)]
		private struct Struct710 : IAsyncStateMachine
		{
			// Token: 0x060034F6 RID: 13558 RVA: 0x000CEC78 File Offset: 0x000CCE78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd = this.dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						object object_ = dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.object_1;
						bool flag = false;
						try
						{
							Monitor.Enter(object_, ref flag);
							DateTime now = DateTime.Now;
							if ((now - dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.dateTime_1).TotalMilliseconds < 16.0)
							{
								goto IL_14B;
							}
							dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.dateTime_1 = now;
						}
						finally
						{
							if (num < 0 && flag)
							{
								Monitor.Exit(object_);
							}
						}
						RadialGradientBrush radialGradientBrush = dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.border_0.BorderBrush as RadialGradientBrush;
						if (radialGradientBrush != null)
						{
							if (radialGradientBrush.IsFrozen)
							{
								radialGradientBrush = radialGradientBrush.CloneCurrentValue();
								dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.border_0.BorderBrush = radialGradientBrush;
							}
							radialGradientBrush.GradientOrigin = new Point(0.5, 0.5);
							radialGradientBrush.Center = new Point(0.5, 0.5);
						}
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.Struct710>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_14B:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060034F7 RID: 13559 RVA: 0x00021004 File Offset: 0x0001F204
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002669 RID: 9833
			public int int_0;

			// Token: 0x0400266A RID: 9834
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400266B RID: 9835
			public dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd_0;

			// Token: 0x0400266C RID: 9836
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020008C8 RID: 2248
		[StructLayout(LayoutKind.Auto)]
		private struct Struct711 : IAsyncStateMachine
		{
			// Token: 0x060034F8 RID: 13560 RVA: 0x000CEE18 File Offset: 0x000CD018
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd = this.dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						object object_ = dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.object_0;
						bool flag = false;
						try
						{
							Monitor.Enter(object_, ref flag);
							DateTime now = DateTime.Now;
							if ((now - dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.dateTime_0).TotalMilliseconds < 16.0)
							{
								goto IL_16C;
							}
							dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.dateTime_0 = now;
						}
						finally
						{
							if (num < 0 && flag)
							{
								Monitor.Exit(object_);
							}
						}
						RadialGradientBrush radialGradientBrush = dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.border_0.BorderBrush as RadialGradientBrush;
						if (radialGradientBrush != null)
						{
							if (radialGradientBrush.IsFrozen)
							{
								radialGradientBrush = radialGradientBrush.CloneCurrentValue();
								dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.border_0.BorderBrush = radialGradientBrush;
							}
							Point position = this.mouseEventArgs_0.GetPosition(dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.border_0);
							double x = position.X / dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.border_0.ActualWidth;
							double y = position.Y / dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.border_0.ActualHeight;
							radialGradientBrush.GradientOrigin = new Point(x, y);
							radialGradientBrush.Center = new Point(x, y);
						}
						awaiter = Task.Delay(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd.Struct711>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_16C:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060034F9 RID: 13561 RVA: 0x00021012 File Offset: 0x0001F212
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400266D RID: 9837
			public int int_0;

			// Token: 0x0400266E RID: 9838
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400266F RID: 9839
			public dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd dje_zX78EUVM3MQT4EM6QFB5C6FNQ3L7EEQRZTGAXDZ5MCWJBWW2PSVEJE_ejd_0;

			// Token: 0x04002670 RID: 9840
			public MouseEventArgs mouseEventArgs_0;

			// Token: 0x04002671 RID: 9841
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
