using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using Markdig.Wpf;

namespace ns0
{
	// Token: 0x02000847 RID: 2119
	public sealed class dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060032DA RID: 13018 RVA: 0x0001FF01 File Offset: 0x0001E101
		public dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x0001FDE2 File Offset: 0x0001DFE2
		private void method_0(object sender, RoutedEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x000C5208 File Offset: 0x000C3408
		private void method_1(object sender, ExecutedRoutedEventArgs e)
		{
			string text = e.Parameter as string;
			Uri uri;
			if (text != null && Uri.TryCreate(text, UriKind.Absolute, out uri))
			{
				Process.Start(e.Parameter.ToString());
				e.Handled = true;
			}
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x0001FF0F File Offset: 0x0001E10F
		private void method_2(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show(string.Format("URL: {0}", e.Parameter));
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x000C5248 File Offset: 0x000C3448
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd.Struct648 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd.Struct648>(ref @struct);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x000C5280 File Offset: 0x000C3480
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd.Struct647 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd.Struct647>(ref @struct);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000C52B0 File Offset: 0x000C34B0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/tweax/usercontrols/chatuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000C52E4 File Offset: 0x000C34E4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((CommandBinding)target).Executed += this.method_1;
				return;
			case 2:
				((CommandBinding)target).Executed += this.method_2;
				return;
			case 3:
				this.markdownViewer_0 = (MarkdownViewer)target;
				this.markdownViewer_0.AddHandler(Hyperlink.ClickEvent, new RoutedEventHandler(this.method_0));
				return;
			case 4:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 5:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040023D8 RID: 9176
		internal MarkdownViewer markdownViewer_0;

		// Token: 0x040023D9 RID: 9177
		internal Button button_0;

		// Token: 0x040023DA RID: 9178
		internal Button button_1;

		// Token: 0x040023DB RID: 9179
		private bool bool_0;

		// Token: 0x02000848 RID: 2120
		[StructLayout(LayoutKind.Auto)]
		private struct Struct647 : IAsyncStateMachine
		{
			// Token: 0x060032E2 RID: 13026 RVA: 0x000C53B8 File Offset: 0x000C35B8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<object> awaiter;
					if (num != 0)
					{
						awaiter = Class406.smethod_0().method_1(typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<object>, dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd.Struct647>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<object>);
						this.int_0 = -1;
					}
					((dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd)awaiter.GetResult()).method_14();
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

			// Token: 0x060032E3 RID: 13027 RVA: 0x0001FF28 File Offset: 0x0001E128
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023DC RID: 9180
			public int int_0;

			// Token: 0x040023DD RID: 9181
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023DE RID: 9182
			private TaskAwaiter<object> taskAwaiter_0;
		}

		// Token: 0x02000849 RID: 2121
		[StructLayout(LayoutKind.Auto)]
		private struct Struct648 : IAsyncStateMachine
		{
			// Token: 0x060032E4 RID: 13028 RVA: 0x000C547C File Offset: 0x000C367C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd = this.dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd_0;
				try
				{
					TaskAwaiter<object> awaiter;
					if (num != 0)
					{
						awaiter = Class406.smethod_0().method_1(typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<object>, dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd.Struct648>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<object>);
						this.int_0 = -1;
					}
					((dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd)awaiter.GetResult()).method_13(dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd.DataContext as Class524);
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

			// Token: 0x060032E5 RID: 13029 RVA: 0x0001FF36 File Offset: 0x0001E136
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023DF RID: 9183
			public int int_0;

			// Token: 0x040023E0 RID: 9184
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023E1 RID: 9185
			public dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd dje_zL59VMWHZK2CDBEB93NW9M59LKX6CBK357V9ZE3FFMG7QK8D2BCZ685LZ42359USE72_ejd_0;

			// Token: 0x040023E2 RID: 9186
			private TaskAwaiter<object> taskAwaiter_0;
		}
	}
}
