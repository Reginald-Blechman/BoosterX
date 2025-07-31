using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

// Token: 0x0200043F RID: 1087
internal sealed class Class483
{
	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00077F64 File Offset: 0x00076164
	public GClass280 MouseMoveCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00077F98 File Offset: 0x00076198
	public GClass280 MouseDownCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_1), null));
			}
			return result;
		}
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x00077FCC File Offset: 0x000761CC
	public void method_0(object object_0)
	{
		GClass198 gclass = object_0 as GClass198;
		Border border = gclass.method_0() as Border;
		if (gclass.method_1().LeftButton != MouseButtonState.Pressed)
		{
			return;
		}
		Window window = Window.GetWindow(border);
		if (window.WindowState == WindowState.Maximized)
		{
			window.WindowStyle = WindowStyle.None;
			Point point = Class807.smethod_0(window, gclass.method_1().MouseDevice.GetPosition(border));
			window.Left = point.X - window.RestoreBounds.Width * 0.5;
			window.Top = point.Y;
			window.WindowState = WindowState.Normal;
			window.WindowStyle = WindowStyle.SingleBorderWindow;
		}
		window.DragMove();
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x00078074 File Offset: 0x00076274
	public void method_1(object object_0)
	{
		GClass13 gclass = object_0 as GClass13;
		Border dependencyObject = gclass.method_0() as Border;
		MouseButtonEventArgs mouseButtonEventArgs = gclass.method_1();
		Window window = Window.GetWindow(dependencyObject);
		if (mouseButtonEventArgs.ClickCount > 1)
		{
			window.WindowState = ((window.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized);
		}
	}

	// Token: 0x040012DA RID: 4826
	private GClass280 gclass280_0;

	// Token: 0x040012DB RID: 4827
	private GClass280 gclass280_1;
}
