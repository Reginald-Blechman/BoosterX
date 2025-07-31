using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200075B RID: 1883
	public sealed class dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd : Page, IComponentConnector
	{
		// Token: 0x06002E9F RID: 11935 RVA: 0x0001DD06 File Offset: 0x0001BF06
		public dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd()
		{
			this.InitializeComponent();
			this.method_0(false);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x0001DD1B File Offset: 0x0001BF1B
		private void method_0(bool bool_2)
		{
			this.button_2.IsEnabled = false;
			base.DataContext = null;
			base.DataContext = Class362.smethod_0(bool_2);
			this.method_1();
			this.button_2.IsEnabled = true;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000B3198 File Offset: 0x000B1398
		private void method_1()
		{
			dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct531 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct531>(ref @struct);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000B31D0 File Offset: 0x000B13D0
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct530 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct530>(ref @struct);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000B3208 File Offset: 0x000B1408
		private void method_2(object sender, MouseWheelEventArgs e)
		{
			ScrollViewer scrollViewer = (ScrollViewer)sender;
			if (e.Delta < 0)
			{
				scrollViewer.LineRight();
			}
			else
			{
				scrollViewer.LineLeft();
			}
			e.Handled = true;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000B323C File Offset: 0x000B143C
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct528 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct528>(ref @struct);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000B326C File Offset: 0x000B146C
		public void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct529 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct529>(ref @struct);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000B329C File Offset: 0x000B149C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/interrupts/interruptspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000B32D0 File Offset: 0x000B14D0
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
				this.checkBox_0 = (CheckBox)target;
				return;
			case 5:
				this.border_0 = (Border)target;
				return;
			case 6:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x04001F21 RID: 7969
		private bool bool_0;

		// Token: 0x04001F22 RID: 7970
		internal Button button_0;

		// Token: 0x04001F23 RID: 7971
		internal Button button_1;

		// Token: 0x04001F24 RID: 7972
		internal Button button_2;

		// Token: 0x04001F25 RID: 7973
		internal CheckBox checkBox_0;

		// Token: 0x04001F26 RID: 7974
		internal Border border_0;

		// Token: 0x04001F27 RID: 7975
		internal ItemsControl itemsControl_0;

		// Token: 0x04001F28 RID: 7976
		private bool bool_1;

		// Token: 0x0200075C RID: 1884
		[StructLayout(LayoutKind.Auto)]
		private struct Struct528 : IAsyncStateMachine
		{
			// Token: 0x06002EA8 RID: 11944 RVA: 0x000B3398 File Offset: 0x000B1598
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class362.smethod_4().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct528>(ref awaiter, ref this);
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

			// Token: 0x06002EA9 RID: 11945 RVA: 0x0001DD4E File Offset: 0x0001BF4E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F29 RID: 7977
			public int int_0;

			// Token: 0x04001F2A RID: 7978
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F2B RID: 7979
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200075D RID: 1885
		[StructLayout(LayoutKind.Auto)]
		private struct Struct529 : IAsyncStateMachine
		{
			// Token: 0x06002EAA RID: 11946 RVA: 0x000B3444 File Offset: 0x000B1644
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class362.smethod_3().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct529>(ref awaiter, ref this);
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

			// Token: 0x06002EAB RID: 11947 RVA: 0x0001DD5C File Offset: 0x0001BF5C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F2C RID: 7980
			public int int_0;

			// Token: 0x04001F2D RID: 7981
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F2E RID: 7982
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200075E RID: 1886
		[StructLayout(LayoutKind.Auto)]
		private struct Struct530 : IAsyncStateMachine
		{
			// Token: 0x06002EAC RID: 11948 RVA: 0x000B34F0 File Offset: 0x000B16F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd = this.dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.bool_0)
						{
							goto IL_A8;
						}
						dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.bool_0 = true;
						dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.method_0(true);
						awaiter = Task.Delay(2000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct530>(ref awaiter, ref this);
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
					dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.bool_0 = false;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_A8:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002EAD RID: 11949 RVA: 0x0001DD6A File Offset: 0x0001BF6A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F2F RID: 7983
			public int int_0;

			// Token: 0x04001F30 RID: 7984
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F31 RID: 7985
			public dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd_0;

			// Token: 0x04001F32 RID: 7986
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200075F RID: 1887
		[StructLayout(LayoutKind.Auto)]
		private struct Struct531 : IAsyncStateMachine
		{
			// Token: 0x06002EAE RID: 11950 RVA: 0x000B35C8 File Offset: 0x000B17C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd = this.dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class362.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.Struct531>(ref awaiter, ref this);
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
					try
					{
						(dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd.DataContext as Class515).DeviceViewModels[0].IsChecked = true;
					}
					catch
					{
					}
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

			// Token: 0x06002EAF RID: 11951 RVA: 0x0001DD78 File Offset: 0x0001BF78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001F33 RID: 7987
			public int int_0;

			// Token: 0x04001F34 RID: 7988
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001F35 RID: 7989
			public dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd_0;

			// Token: 0x04001F36 RID: 7990
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
