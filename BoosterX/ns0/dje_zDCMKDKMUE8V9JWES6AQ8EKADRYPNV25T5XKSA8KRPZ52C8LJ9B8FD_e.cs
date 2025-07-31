using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;
using PIManagerX;

namespace ns0
{
	// Token: 0x020007C1 RID: 1985
	public sealed class dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003054 RID: 12372 RVA: 0x0001EC14 File Offset: 0x0001CE14
		public dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd()
		{
			this.InitializeComponent();
			Class226.smethod_0(new Class226.Delegate24(this.method_3));
			this.method_0();
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x000B98C8 File Offset: 0x000B7AC8
		private void method_0()
		{
			dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct574 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct574>(ref @struct);
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x000B9900 File Offset: 0x000B7B00
		private void method_1(object sender, EventArgs e)
		{
			this.method_2(null, default(DependencyPropertyChangedEventArgs));
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x000B9920 File Offset: 0x000B7B20
		private void method_2(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (!Class551.class753_0.method_68().GetValueOrDefault())
			{
				this.blurEffect_0.Radius = 15.0;
				this.stackPanel_0.Opacity = 0.3;
				this.textBlock_6.Opacity = 1.0;
				this.stackPanel_0.IsEnabled = false;
				this.textBlock_6.Visibility = Visibility.Visible;
				return;
			}
			this.blurEffect_0.Radius = 0.0;
			this.stackPanel_0.Opacity = 1.0;
			this.textBlock_6.Opacity = 0.0;
			this.stackPanel_0.IsEnabled = true;
			this.textBlock_6.Visibility = Visibility.Collapsed;
			if (base.IsVisible && Class551.class753_0.method_68().GetValueOrDefault() && Application.Current.MainWindow.WindowState != WindowState.Minimized)
			{
				Class226.smethod_3();
				return;
			}
			Class226.smethod_4();
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x000B9A28 File Offset: 0x000B7C28
		private void method_3()
		{
			dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct576 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct576>(ref @struct);
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x000B9A60 File Offset: 0x000B7C60
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct577 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct577>(ref @struct);
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x000B9A98 File Offset: 0x000B7C98
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct578 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct578>(ref @struct);
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000B9AD0 File Offset: 0x000B7CD0
		private void method_4(object sender, SizeChangedEventArgs e)
		{
			dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct575 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct575>(ref @struct);
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x000B9B08 File Offset: 0x000B7D08
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/memoryreviewuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x000B9B3C File Offset: 0x000B7D3C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd)target).IsVisibleChanged += this.method_2;
				((dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd)target).SizeChanged += this.method_4;
				return;
			case 2:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.rectangleGeometry_0 = (RectangleGeometry)target;
				return;
			case 5:
				this.border_1 = (Border)target;
				return;
			case 6:
				this.border_2 = (Border)target;
				return;
			case 7:
				this.grid_0 = (Grid)target;
				return;
			case 8:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 9:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 10:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 11:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 12:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 13:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 14:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 15:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 16:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 17:
				this.blurEffect_0 = (BlurEffect)target;
				return;
			case 18:
				this.textBlock_6 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000B9CDC File Offset: 0x000B7EDC
		private void method_5()
		{
			this.textBlock_0.Text = Class226.float_4.smethod_14() + " MB";
			this.textBlock_1.Text = Class226.float_0.smethod_14() + " MB";
			this.textBlock_2.Text = Class226.float_1.smethod_14() + " MB";
			this.textBlock_3.Text = Class226.float_2.smethod_14() + " MB";
			this.textBlock_4.Text = Class226.float_3.smethod_14() + " MB";
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.border_2, TimeSpan.FromSeconds(0.5), FrameworkElement.WidthProperty, (double)(Class226.float_0 / Class226.float_4) * this.border_0.ActualWidth);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.border_1, TimeSpan.FromSeconds(0.5), FrameworkElement.WidthProperty, (double)((Class226.float_0 + Class226.float_1) / Class226.float_4) * this.border_0.ActualWidth);
		}

		// Token: 0x040020E5 RID: 8421
		public static float float_0;

		// Token: 0x040020E6 RID: 8422
		public static float float_1;

		// Token: 0x040020E7 RID: 8423
		public static float float_2;

		// Token: 0x040020E8 RID: 8424
		public static float float_3;

		// Token: 0x040020E9 RID: 8425
		public static float float_4;

		// Token: 0x040020EA RID: 8426
		internal StackPanel stackPanel_0;

		// Token: 0x040020EB RID: 8427
		internal Border border_0;

		// Token: 0x040020EC RID: 8428
		internal RectangleGeometry rectangleGeometry_0;

		// Token: 0x040020ED RID: 8429
		internal Border border_1;

		// Token: 0x040020EE RID: 8430
		internal Border border_2;

		// Token: 0x040020EF RID: 8431
		internal Grid grid_0;

		// Token: 0x040020F0 RID: 8432
		internal TextBlock textBlock_0;

		// Token: 0x040020F1 RID: 8433
		internal TextBlock textBlock_1;

		// Token: 0x040020F2 RID: 8434
		internal TextBlock textBlock_2;

		// Token: 0x040020F3 RID: 8435
		internal TextBlock textBlock_3;

		// Token: 0x040020F4 RID: 8436
		internal TextBlock textBlock_4;

		// Token: 0x040020F5 RID: 8437
		internal StackPanel stackPanel_1;

		// Token: 0x040020F6 RID: 8438
		internal Button button_0;

		// Token: 0x040020F7 RID: 8439
		internal Button button_1;

		// Token: 0x040020F8 RID: 8440
		internal TextBlock textBlock_5;

		// Token: 0x040020F9 RID: 8441
		internal BlurEffect blurEffect_0;

		// Token: 0x040020FA RID: 8442
		internal TextBlock textBlock_6;

		// Token: 0x040020FB RID: 8443
		private bool bool_0;

		// Token: 0x020007C2 RID: 1986
		[StructLayout(LayoutKind.Auto)]
		private struct Struct574 : IAsyncStateMachine
		{
			// Token: 0x0600305F RID: 12383 RVA: 0x000B9E20 File Offset: 0x000B8020
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd = this.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						try
						{
							Application.Current.MainWindow.StateChanged += dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.method_1;
						}
						catch
						{
						}
						awaiter = Task.Delay(2000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct574>(ref awaiter, ref this);
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
					dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.method_3();
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

			// Token: 0x06003060 RID: 12384 RVA: 0x0001EC39 File Offset: 0x0001CE39
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040020FC RID: 8444
			public int int_0;

			// Token: 0x040020FD RID: 8445
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040020FE RID: 8446
			public dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;

			// Token: 0x040020FF RID: 8447
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007C3 RID: 1987
		[StructLayout(LayoutKind.Auto)]
		private struct Struct575 : IAsyncStateMachine
		{
			// Token: 0x06003061 RID: 12385 RVA: 0x000B9F08 File Offset: 0x000B8108
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd = this.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.ActualWidth < 41.0)
						{
							goto IL_136;
						}
						dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.border_0.Width = dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.ActualWidth - 40.0;
						dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.rectangleGeometry_0.Rect = new Rect(0.0, 0.0, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.ActualWidth - 40.0, 10.0);
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct575>(ref awaiter, ref this);
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
					if (dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.ActualWidth < 200.0)
					{
						dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.stackPanel_1.HorizontalAlignment = HorizontalAlignment.Center;
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_17(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.grid_0);
					}
					else
					{
						dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.stackPanel_1.HorizontalAlignment = HorizontalAlignment.Right;
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.grid_0);
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_136:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003062 RID: 12386 RVA: 0x0001EC47 File Offset: 0x0001CE47
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002100 RID: 8448
			public int int_0;

			// Token: 0x04002101 RID: 8449
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002102 RID: 8450
			public dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;

			// Token: 0x04002103 RID: 8451
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007C4 RID: 1988
		[StructLayout(LayoutKind.Auto)]
		private struct Struct576 : IAsyncStateMachine
		{
			// Token: 0x06003063 RID: 12387 RVA: 0x000BA07C File Offset: 0x000B827C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd = this.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Dispatcher.InvokeAsync(new Action(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.method_5)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct576>(ref awaiter, ref this);
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

			// Token: 0x06003064 RID: 12388 RVA: 0x0001EC55 File Offset: 0x0001CE55
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002104 RID: 8452
			public int int_0;

			// Token: 0x04002105 RID: 8453
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002106 RID: 8454
			public dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;

			// Token: 0x04002107 RID: 8455
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007C5 RID: 1989
		[StructLayout(LayoutKind.Auto)]
		private struct Struct577 : IAsyncStateMachine
		{
			// Token: 0x06003065 RID: 12389 RVA: 0x000BA140 File Offset: 0x000B8340
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd = this.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;
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
						goto IL_114;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_193;
					default:
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.textBlock_5, Class298.smethod_2("Cleaning"), null);
						dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.button_0.IsEnabled = false;
						awaiter = Task.Run(new Action(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Class907.class907_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct577>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct577>(ref awaiter, ref this);
						return;
					}
					IL_114:
					awaiter.GetResult();
					dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.button_0.IsEnabled = true;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.textBlock_5, Class298.smethod_2("Finished"), null);
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct577>(ref awaiter, ref this);
						return;
					}
					IL_193:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.textBlock_5, string.Empty, null);
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

			// Token: 0x06003066 RID: 12390 RVA: 0x0001EC63 File Offset: 0x0001CE63
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002108 RID: 8456
			public int int_0;

			// Token: 0x04002109 RID: 8457
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400210A RID: 8458
			public dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;

			// Token: 0x0400210B RID: 8459
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007C6 RID: 1990
		[StructLayout(LayoutKind.Auto)]
		private struct Struct578 : IAsyncStateMachine
		{
			// Token: 0x06003067 RID: 12391 RVA: 0x000BA340 File Offset: 0x000B8540
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd = this.dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;
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
						goto IL_114;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_193;
					default:
						dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.textBlock_5, Class298.smethod_2("Cleaning"), null);
						dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.button_1.IsEnabled = false;
						awaiter = Task.Run(new Action(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Class907.class907_0.method_1)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct578>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = Task.Delay(2000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct578>(ref awaiter, ref this);
						return;
					}
					IL_114:
					awaiter.GetResult();
					dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.button_1.IsEnabled = true;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.textBlock_5, Class298.smethod_2("Finished"), null);
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Struct578>(ref awaiter, ref this);
						return;
					}
					IL_193:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.textBlock_5, string.Empty, null);
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

			// Token: 0x06003068 RID: 12392 RVA: 0x0001EC71 File Offset: 0x0001CE71
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400210C RID: 8460
			public int int_0;

			// Token: 0x0400210D RID: 8461
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400210E RID: 8462
			public dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd_0;

			// Token: 0x0400210F RID: 8463
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007C7 RID: 1991
		[Serializable]
		private sealed class Class907
		{
			// Token: 0x0600306B RID: 12395 RVA: 0x0001EC8B File Offset: 0x0001CE8B
			internal void method_0()
			{
				Class605.smethod_1();
			}

			// Token: 0x0600306C RID: 12396 RVA: 0x000BA540 File Offset: 0x000B8740
			internal void method_1()
			{
				foreach (Process process in Process.GetProcesses().Where(new Func<Process, bool>(dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Class907.class907_0.method_2)))
				{
					try
					{
						using (process)
						{
							if (!process.HasExited && PManagerX.EmptyWorkingSet(process.Handle) == 0)
							{
								throw new Win32Exception(Marshal.GetLastWin32Error());
							}
						}
					}
					catch
					{
					}
				}
			}

			// Token: 0x0600306D RID: 12397 RVA: 0x0001EC92 File Offset: 0x0001CE92
			internal bool method_2(Process process_0)
			{
				return process_0 != null;
			}

			// Token: 0x04002110 RID: 8464
			public static readonly dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Class907 class907_0 = new dje_zDCMKDKMUE8V9JWES6AQ8EKADRYPNV25T5XKSA8KRPZ52C8LJ9B8FD_ejd.Class907();

			// Token: 0x04002111 RID: 8465
			public static Action action_0;

			// Token: 0x04002112 RID: 8466
			public static Func<Process, bool> func_0;

			// Token: 0x04002113 RID: 8467
			public static Action action_1;
		}
	}
}
