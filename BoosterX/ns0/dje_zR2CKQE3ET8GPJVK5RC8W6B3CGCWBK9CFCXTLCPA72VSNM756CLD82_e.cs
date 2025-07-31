using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000869 RID: 2153
	public sealed class dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003352 RID: 13138 RVA: 0x0002031F File Offset: 0x0001E51F
		public dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd()
		{
			this.InitializeComponent();
			Class374.smethod_0().method_0(new Class374.Delegate27(this.method_0));
			this.method_1();
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00020349 File Offset: 0x0001E549
		private void method_0(CultureInfo cultureInfo_0)
		{
			this.method_1();
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000C732C File Offset: 0x000C552C
		private void method_1()
		{
			dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct658 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct658>(ref @struct);
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000C7364 File Offset: 0x000C5564
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct659 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd_0 = this;
			@struct.object_0 = sender;
			@struct.routedEventArgs_0 = e;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct659>(ref @struct);
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000C73AC File Offset: 0x000C55AC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/tipsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000C73E0 File Offset: 0x000C55E0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 2:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00020351 File Offset: 0x0001E551
		private void method_2(string string_0)
		{
			TextBlock textBlock = this.textBlock_0;
			textBlock.Text += string_0;
		}

		// Token: 0x04002455 RID: 9301
		private GClass56 gclass56_0;

		// Token: 0x04002456 RID: 9302
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04002457 RID: 9303
		internal TextBlock textBlock_0;

		// Token: 0x04002458 RID: 9304
		internal Button button_0;

		// Token: 0x04002459 RID: 9305
		private bool bool_0;

		// Token: 0x0200086A RID: 2154
		private static class Class943
		{
			// Token: 0x0400245A RID: 9306
			public static Func<Task<List<string>>> func_0;
		}

		// Token: 0x0200086B RID: 2155
		[StructLayout(LayoutKind.Auto)]
		private struct Struct658 : IAsyncStateMachine
		{
			// Token: 0x06003359 RID: 13145 RVA: 0x000C7448 File Offset: 0x000C5648
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd = this.dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd_0;
				try
				{
					TaskAwaiter<GClass56> awaiter;
					if (num != 0)
					{
						int num2 = new Random().Next(1, 5);
						try
						{
							dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.textBlock_0.Text = Class298.smethod_2(string.Format("Tip{0}", num2));
						}
						catch
						{
							dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.textBlock_0.Text = "ERROR";
						}
						dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0 = null;
						awaiter = Class598.smethod_1().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass56>, dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct658>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass56>);
						this.int_0 = -1;
					}
					GClass56 result = awaiter.GetResult();
					dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0 = result;
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

			// Token: 0x0600335A RID: 13146 RVA: 0x0002036A File Offset: 0x0001E56A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400245B RID: 9307
			public int int_0;

			// Token: 0x0400245C RID: 9308
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400245D RID: 9309
			public dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd_0;

			// Token: 0x0400245E RID: 9310
			private TaskAwaiter<GClass56> taskAwaiter_0;
		}

		// Token: 0x0200086C RID: 2156
		[StructLayout(LayoutKind.Auto)]
		private struct Struct659 : IAsyncStateMachine
		{
			// Token: 0x0600335B RID: 13147 RVA: 0x000C7560 File Offset: 0x000C5760
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd = this.dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd_0;
				try
				{
					TaskAwaiter<List<string>> awaiter;
					TaskAwaiter<GClass56> awaiter3;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<string>>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					{
						IL_151:
						try
						{
							TaskAwaiter awaiter2;
							if (num != 1)
							{
								awaiter2 = dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0.method_19(new Action<string>(dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.method_2)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									this.int_0 = 1;
									this.taskAwaiter_1 = awaiter2;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct659>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = this.taskAwaiter_1;
								this.taskAwaiter_1 = default(TaskAwaiter);
								this.int_0 = -1;
							}
							awaiter2.GetResult();
						}
						catch
						{
							this.int_1 = 1;
						}
						int num3 = this.int_1;
						if (num3 != 1)
						{
							dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.button_0.IsEnabled = true;
							goto IL_271;
						}
						awaiter3 = Class598.smethod_1().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_2 = awaiter3;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass56>, dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct659>(ref awaiter3, ref this);
							return;
						}
						goto IL_23C;
					}
					case 2:
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter<GClass56>);
						this.int_0 = -1;
						goto IL_23C;
					default:
					{
						dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.textBlock_0.Text = string.Empty;
						dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.button_0.IsEnabled = false;
						dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0.method_11(Class298.smethod_2("ToolTipGPTBase"));
						dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0.method_9(Class298.smethod_2("ToolTipGPTInput"), Array.Empty<GClass258.GClass259>());
						dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0.method_12(Class298.smethod_2("ToolTipGPTOutput"));
						dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0.method_9(Class298.smethod_2("ToolTipGPTInput"), Array.Empty<GClass258.GClass259>());
						if (Class777.list_0.Count != 0)
						{
							goto IL_120;
						}
						Func<Task<List<string>>> function;
						if ((function = dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Class943.func_0) == null)
						{
							function = (dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Class943.func_0 = new Func<Task<List<string>>>(Class777.smethod_1));
						}
						awaiter = Task.Run<List<string>>(function).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.Struct659>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					IL_120:
					int index = new Random().Next(84);
					dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.gclass56_0.method_9(Class777.list_0[index], Array.Empty<GClass258.GClass259>());
					this.int_1 = 0;
					goto IL_151;
					IL_23C:
					awaiter3.GetResult();
					dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd.button_0_Click(this.object_0, this.routedEventArgs_0);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_271:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600335C RID: 13148 RVA: 0x00020378 File Offset: 0x0001E578
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400245F RID: 9311
			public int int_0;

			// Token: 0x04002460 RID: 9312
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002461 RID: 9313
			public dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd dje_zR2CKQE3ET8GPJVK5RC8W6B3CGCWBK9CFCXTLCPA72VSNM756CLD82_ejd_0;

			// Token: 0x04002462 RID: 9314
			public object object_0;

			// Token: 0x04002463 RID: 9315
			public RoutedEventArgs routedEventArgs_0;

			// Token: 0x04002464 RID: 9316
			private TaskAwaiter<List<string>> taskAwaiter_0;

			// Token: 0x04002465 RID: 9317
			private int int_1;

			// Token: 0x04002466 RID: 9318
			private TaskAwaiter taskAwaiter_1;

			// Token: 0x04002467 RID: 9319
			private TaskAwaiter<GClass56> taskAwaiter_2;
		}
	}
}
