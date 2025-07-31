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

namespace ns0
{
	// Token: 0x02000859 RID: 2137
	public sealed class dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd : Page, IComponentConnector
	{
		// Token: 0x06003314 RID: 13076 RVA: 0x000C5CA8 File Offset: 0x000C3EA8
		public dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd()
		{
			this.InitializeComponent();
			Class406.smethod_0().frame_4 = this.frame_0;
			base.DataContext = Class344.class510_0;
			GClass279 gclass = GClass279.smethod_0();
			GClass279.GDelegate3 gdelegate3_;
			if ((gdelegate3_ = dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Class940.gdelegate3_0) == null)
			{
				gdelegate3_ = (dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Class940.gdelegate3_0 = new GClass279.GDelegate3(Class344.smethod_0));
			}
			gclass.method_2(gdelegate3_);
			base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_3));
			GClass279.smethod_0().method_2(new GClass279.GDelegate3(this.method_0));
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000C5D30 File Offset: 0x000C3F30
		private void method_0()
		{
			dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Struct653 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Struct653>(ref @struct);
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000C5D68 File Offset: 0x000C3F68
		private void method_1(object sender, SizeChangedEventArgs e)
		{
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Visible)
			{
				this.stackPanel_0.Margin = new Thickness(10.0, 0.0, 0.0, 10.0);
			}
			if (this.scrollViewer_0.ComputedVerticalScrollBarVisibility == Visibility.Collapsed)
			{
				this.stackPanel_0.Margin = new Thickness(10.0, 0.0, 10.0, 10.0);
			}
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000C5DF8 File Offset: 0x000C3FF8
		public void method_2(object sender, RoutedEventArgs e)
		{
			dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Struct652 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Struct652>(ref @struct);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000139E3 File Offset: 0x00011BE3
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000C5E28 File Offset: 0x000C4028
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/customizationmainpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000C5E5C File Offset: 0x000C405C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd)target).SizeChanged += this.method_1;
				return;
			case 2:
				this.button_0 = (Button)target;
				return;
			case 3:
				((Button)target).Click += this.method_2;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.image_0 = (Image)target;
				return;
			case 6:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 7:
				this.radioButton_0 = (RadioButton)target;
				return;
			case 8:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 9:
				this.grid_0 = (Grid)target;
				return;
			case 10:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 11:
				this.frame_0 = (Frame)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000C5F60 File Offset: 0x000C4160
		private bool method_3()
		{
			this.button_1.IsEnabled = false;
			return false;
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000C5F7C File Offset: 0x000C417C
		private void method_4()
		{
			if (GClass279.smethod_0().method_19().Count <= 0 && dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_5.Count <= 0)
			{
				base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_6));
				return;
			}
			base.Dispatcher.Invoke<bool>(new Func<bool>(this.method_5));
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000C5FDC File Offset: 0x000C41DC
		private bool method_5()
		{
			this.button_1.IsEnabled = true;
			return true;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000C5F60 File Offset: 0x000C4160
		private bool method_6()
		{
			this.button_1.IsEnabled = false;
			return false;
		}

		// Token: 0x0400240B RID: 9227
		internal Button button_0;

		// Token: 0x0400240C RID: 9228
		internal TextBlock textBlock_0;

		// Token: 0x0400240D RID: 9229
		internal Image image_0;

		// Token: 0x0400240E RID: 9230
		internal ScrollViewer scrollViewer_0;

		// Token: 0x0400240F RID: 9231
		internal RadioButton radioButton_0;

		// Token: 0x04002410 RID: 9232
		internal StackPanel stackPanel_0;

		// Token: 0x04002411 RID: 9233
		internal Grid grid_0;

		// Token: 0x04002412 RID: 9234
		internal Button button_1;

		// Token: 0x04002413 RID: 9235
		internal Frame frame_0;

		// Token: 0x04002414 RID: 9236
		private bool bool_0;

		// Token: 0x0200085A RID: 2138
		private static class Class940
		{
			// Token: 0x04002415 RID: 9237
			public static GClass279.GDelegate3 gdelegate3_0;
		}

		// Token: 0x0200085B RID: 2139
		[StructLayout(LayoutKind.Auto)]
		private struct Struct652 : IAsyncStateMachine
		{
			// Token: 0x0600331F RID: 13087 RVA: 0x000C5FF8 File Offset: 0x000C41F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Class144.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Struct652>(ref awaiter, ref this);
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

			// Token: 0x06003320 RID: 13088 RVA: 0x00020109 File Offset: 0x0001E309
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002416 RID: 9238
			public int int_0;

			// Token: 0x04002417 RID: 9239
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002418 RID: 9240
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200085C RID: 2140
		[StructLayout(LayoutKind.Auto)]
		private struct Struct653 : IAsyncStateMachine
		{
			// Token: 0x06003321 RID: 13089 RVA: 0x000C60A4 File Offset: 0x000C42A4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd @object = this.dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_4)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd.Struct653>(ref awaiter, ref this);
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

			// Token: 0x06003322 RID: 13090 RVA: 0x00020117 File Offset: 0x0001E317
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002419 RID: 9241
			public int int_0;

			// Token: 0x0400241A RID: 9242
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400241B RID: 9243
			public dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd dje_zNSNRFVQUMVAUHL755A6AUDYMMVMZMCDHDE3DWVBSGNN9KGA_ejd_0;

			// Token: 0x0400241C RID: 9244
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
