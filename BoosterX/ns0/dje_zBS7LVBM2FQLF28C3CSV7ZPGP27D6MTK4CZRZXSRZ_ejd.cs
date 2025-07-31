using System;
using System.Windows;
using System.Windows.Input;

namespace ns0
{
	// Token: 0x020007AB RID: 1963
	internal static class dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd
	{
		// Token: 0x06002FE6 RID: 12262 RVA: 0x0001E7D2 File Offset: 0x0001C9D2
		public static ICommand GetMouseMoveCommand(UIElement uielement_0)
		{
			return (ICommand)uielement_0.GetValue(dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.dependencyProperty_0);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		public static void SetMouseMoveCommand(UIElement uielement_0, ICommand icommand_0)
		{
			uielement_0.SetValue(dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.dependencyProperty_0, icommand_0);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x000B83AC File Offset: 0x000B65AC
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			UIElement uielement = dependencyObject_0 as UIElement;
			if (uielement != null)
			{
				if (dependencyPropertyChangedEventArgs_0.OldValue != null)
				{
					UIElement uielement2 = uielement;
					MouseEventHandler value;
					if ((value = dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.Class903.mouseEventHandler_0) == null)
					{
						value = (dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.Class903.mouseEventHandler_0 = new MouseEventHandler(dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.smethod_1));
					}
					uielement2.MouseMove -= value;
				}
				if (dependencyPropertyChangedEventArgs_0.NewValue != null)
				{
					UIElement uielement3 = uielement;
					MouseEventHandler value2;
					if ((value2 = dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.Class903.mouseEventHandler_0) == null)
					{
						value2 = (dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.Class903.mouseEventHandler_0 = new MouseEventHandler(dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.smethod_1));
					}
					uielement3.MouseMove += value2;
				}
			}
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000B8418 File Offset: 0x000B6618
		private static void smethod_1(object sender, MouseEventArgs e)
		{
			UIElement uielement = sender as UIElement;
			ICommand mouseMoveCommand = dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.GetMouseMoveCommand(uielement);
			if (mouseMoveCommand != null && mouseMoveCommand.CanExecute(e))
			{
				mouseMoveCommand.Execute(new GClass198(uielement, e));
			}
		}

		// Token: 0x0400208D RID: 8333
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.RegisterAttached("MouseMoveCommand", typeof(ICommand), typeof(dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd), new PropertyMetadata(null, new PropertyChangedCallback(dje_zBS7LVBM2FQLF28C3CSV7ZPGP27D6MTK4CZRZXSRZ_ejd.smethod_0)));

		// Token: 0x020007AC RID: 1964
		private static class Class903
		{
			// Token: 0x0400208E RID: 8334
			public static MouseEventHandler mouseEventHandler_0;
		}
	}
}
