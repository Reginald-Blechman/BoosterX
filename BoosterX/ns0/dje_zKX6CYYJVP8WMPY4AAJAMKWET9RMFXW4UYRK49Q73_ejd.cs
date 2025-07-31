using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ns0
{
	// Token: 0x02000844 RID: 2116
	public sealed class dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd : Window, IComponentConnector, IStyleConnector
	{
		// Token: 0x060032C8 RID: 13000 RVA: 0x0001FE7A File Offset: 0x0001E07A
		public dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd(Type type_1)
		{
			this.InitializeComponent();
			this.type_0 = type_1;
			Class406.smethod_0().method_4(type_1, this.frame_0);
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x0001FBD1 File Offset: 0x0001DDD1
		private void method_0(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000C4B50 File Offset: 0x000C2D50
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Struct646 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Struct646>(ref @struct);
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x0001FBEC File Offset: 0x0001DDEC
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
		private void method_1(object sender, SizeChangedEventArgs e)
		{
			this.rectangleGeometry_0.Rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000C4B88 File Offset: 0x000C2D88
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			if (this.bool_0)
			{
				this.border_0.CornerRadius = new CornerRadius(20.0);
				this.rectangleGeometry_0.RadiusX = 20.0;
				this.rectangleGeometry_0.RadiusY = 20.0;
				base.WindowState = WindowState.Normal;
				base.Width = 1050.0;
				base.Height = 750.0;
				this.bool_0 = false;
				return;
			}
			this.border_0.CornerRadius = new CornerRadius(0.0);
			this.rectangleGeometry_0.RadiusX = 0.0;
			this.rectangleGeometry_0.RadiusY = 0.0;
			base.WindowState = WindowState.Maximized;
			this.bool_0 = true;
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x000C4C5C File Offset: 0x000C2E5C
		private void method_2(object sender, MouseButtonEventArgs e)
		{
			Rectangle rectangle = sender as Rectangle;
			if (rectangle != null)
			{
				this.bool_1 = true;
				rectangle.CaptureMouse();
			}
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x000C4C84 File Offset: 0x000C2E84
		private void method_3(object sender, MouseButtonEventArgs e)
		{
			Rectangle rectangle = sender as Rectangle;
			if (rectangle != null)
			{
				this.bool_1 = false;
				rectangle.ReleaseMouseCapture();
			}
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000C4CA8 File Offset: 0x000C2EA8
		private void method_4(object sender, MouseEventArgs e)
		{
			if (this.bool_1 & (base.Width >= 900.0 & base.Height >= 700.0) & !this.bool_0)
			{
				Rectangle rectangle = sender as Rectangle;
				Window window = rectangle.Tag as Window;
				if (rectangle != null)
				{
					double num = e.GetPosition(window).X;
					double num2 = e.GetPosition(window).Y;
					rectangle.CaptureMouse();
					if (rectangle.Name.ToLower().Contains("right"))
					{
						num += 5.0;
						if (num > 0.0)
						{
							window.Width = num;
						}
					}
					if (rectangle.Name.ToLower().Contains("left"))
					{
						num -= 5.0;
						window.Left += num;
						num = window.Width - num;
						if (num > 0.0)
						{
							window.Width = num;
						}
					}
					if (rectangle.Name.ToLower().Contains("bottom"))
					{
						num2 += 5.0;
						if (num2 > 0.0)
						{
							window.Height = num2;
						}
					}
					if (rectangle.Name.ToLower().Contains("top"))
					{
						num2 -= 5.0;
						window.Top += num2;
						num2 = window.Height - num2;
						if (num2 > 0.0)
						{
							window.Height = num2;
						}
					}
				}
			}
			if (base.Width < 900.0)
			{
				base.Width = 900.0;
			}
			if (base.Height < 700.0)
			{
				base.Height = 700.0;
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000C4E80 File Offset: 0x000C3080
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/windows/customwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000C4EB4 File Offset: 0x000C30B4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd)target).SizeChanged += this.method_1;
				return;
			case 3:
				this.rectangleGeometry_0 = (RectangleGeometry)target;
				return;
			case 4:
				this.border_0 = (Border)target;
				return;
			case 5:
				this.rectangle_0 = (Rectangle)target;
				return;
			case 6:
				this.rectangle_1 = (Rectangle)target;
				return;
			case 7:
				this.rectangle_2 = (Rectangle)target;
				return;
			case 8:
				this.grid_0 = (Grid)target;
				return;
			case 9:
				this.frame_0 = (Frame)target;
				return;
			case 10:
				((Border)target).MouseDown += this.method_0;
				return;
			case 11:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 12:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 13:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 14:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			}
			this.bool_2 = true;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000C5010 File Offset: 0x000C3210
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 2)
			{
				EventSetter eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseLeftButtonDownEvent;
				eventSetter.Handler = new MouseButtonEventHandler(this.method_2);
				((Style)target).Setters.Add(eventSetter);
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseLeftButtonUpEvent;
				eventSetter.Handler = new MouseButtonEventHandler(this.method_3);
				((Style)target).Setters.Add(eventSetter);
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseMoveEvent;
				eventSetter.Handler = new MouseEventHandler(this.method_4);
				((Style)target).Setters.Add(eventSetter);
			}
		}

		// Token: 0x040023C2 RID: 9154
		public Type type_0;

		// Token: 0x040023C3 RID: 9155
		private bool bool_0;

		// Token: 0x040023C4 RID: 9156
		private bool bool_1;

		// Token: 0x040023C5 RID: 9157
		internal RectangleGeometry rectangleGeometry_0;

		// Token: 0x040023C6 RID: 9158
		internal Border border_0;

		// Token: 0x040023C7 RID: 9159
		internal Rectangle rectangle_0;

		// Token: 0x040023C8 RID: 9160
		internal Rectangle rectangle_1;

		// Token: 0x040023C9 RID: 9161
		internal Rectangle rectangle_2;

		// Token: 0x040023CA RID: 9162
		internal Grid grid_0;

		// Token: 0x040023CB RID: 9163
		internal Frame frame_0;

		// Token: 0x040023CC RID: 9164
		public StackPanel stackPanel_0;

		// Token: 0x040023CD RID: 9165
		internal Button button_0;

		// Token: 0x040023CE RID: 9166
		internal Button button_1;

		// Token: 0x040023CF RID: 9167
		internal Button button_2;

		// Token: 0x040023D0 RID: 9168
		private bool bool_2;

		// Token: 0x02000845 RID: 2117
		[StructLayout(LayoutKind.Auto)]
		private struct Struct646 : IAsyncStateMachine
		{
			// Token: 0x060032D4 RID: 13012 RVA: 0x000C50C0 File Offset: 0x000C32C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd = this.dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.frame_0.Content.GetType() == typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd))
						{
							if (Class406.smethod_0().list_2.Any(new Func<Page, bool>(dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Class937.class937_0.method_0)))
							{
								((dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd)Class406.smethod_0().list_2.First(new Func<Page, bool>(dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Class937.class937_0.method_1))).bool_0 = false;
							}
						}
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Struct646>(ref awaiter, ref this);
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
					dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Close();
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

			// Token: 0x060032D5 RID: 13013 RVA: 0x0001FED0 File Offset: 0x0001E0D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023D1 RID: 9169
			public int int_0;

			// Token: 0x040023D2 RID: 9170
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023D3 RID: 9171
			public dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd_0;

			// Token: 0x040023D4 RID: 9172
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000846 RID: 2118
		[Serializable]
		private sealed class Class937
		{
			// Token: 0x060032D8 RID: 13016 RVA: 0x0001FEEA File Offset: 0x0001E0EA
			internal bool method_0(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd);
			}

			// Token: 0x060032D9 RID: 13017 RVA: 0x0001FEEA File Offset: 0x0001E0EA
			internal bool method_1(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd);
			}

			// Token: 0x040023D5 RID: 9173
			public static readonly dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Class937 class937_0 = new dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd.Class937();

			// Token: 0x040023D6 RID: 9174
			public static Func<Page, bool> func_0;

			// Token: 0x040023D7 RID: 9175
			public static Func<Page, bool> func_1;
		}
	}
}
