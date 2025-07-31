using System;
using System.Windows;
using System.Windows.Input;

namespace ns0
{
	// Token: 0x0200084E RID: 2126
	internal static class dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd
	{
		// Token: 0x060032F5 RID: 13045 RVA: 0x00020038 File Offset: 0x0001E238
		public static ICommand GetMouseButtonCommand(UIElement uielement_0)
		{
			return (ICommand)uielement_0.GetValue(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.dependencyProperty_0);
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x0002004A File Offset: 0x0001E24A
		public static void SetMouseButtonCommand(UIElement uielement_0, ICommand icommand_0)
		{
			uielement_0.SetValue(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.dependencyProperty_0, icommand_0);
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x000C5674 File Offset: 0x000C3874
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			UIElement uielement = dependencyObject_0 as UIElement;
			if (uielement != null)
			{
				if (dependencyPropertyChangedEventArgs_0.OldValue != null)
				{
					UIElement uielement2 = uielement;
					MouseButtonEventHandler value;
					if ((value = dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_0) == null)
					{
						value = (dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_0 = new MouseButtonEventHandler(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.smethod_1));
					}
					uielement2.MouseDown -= value;
					UIElement uielement3 = uielement;
					MouseButtonEventHandler value2;
					if ((value2 = dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_1) == null)
					{
						value2 = (dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_1 = new MouseButtonEventHandler(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.smethod_2));
					}
					uielement3.MouseUp -= value2;
				}
				if (dependencyPropertyChangedEventArgs_0.NewValue != null)
				{
					UIElement uielement4 = uielement;
					MouseButtonEventHandler value3;
					if ((value3 = dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_0) == null)
					{
						value3 = (dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_0 = new MouseButtonEventHandler(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.smethod_1));
					}
					uielement4.MouseDown += value3;
					UIElement uielement5 = uielement;
					MouseButtonEventHandler value4;
					if ((value4 = dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_1) == null)
					{
						value4 = (dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.Class938.mouseButtonEventHandler_1 = new MouseButtonEventHandler(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.smethod_2));
					}
					uielement5.MouseUp += value4;
				}
			}
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000C5724 File Offset: 0x000C3924
		private static void smethod_1(object sender, MouseButtonEventArgs e)
		{
			UIElement uielement = sender as UIElement;
			ICommand mouseButtonCommand = dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.GetMouseButtonCommand(uielement);
			if (mouseButtonCommand != null && mouseButtonCommand.CanExecute(e))
			{
				mouseButtonCommand.Execute(new GClass13(uielement, e));
			}
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000C5724 File Offset: 0x000C3924
		private static void smethod_2(object sender, MouseButtonEventArgs e)
		{
			UIElement uielement = sender as UIElement;
			ICommand mouseButtonCommand = dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.GetMouseButtonCommand(uielement);
			if (mouseButtonCommand != null && mouseButtonCommand.CanExecute(e))
			{
				mouseButtonCommand.Execute(new GClass13(uielement, e));
			}
		}

		// Token: 0x040023EB RID: 9195
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.RegisterAttached("MouseButtonCommand", typeof(ICommand), typeof(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd), new PropertyMetadata(null, new PropertyChangedCallback(dje_zMA3WS7SQJRVWUHQGP9RJP4J8HNFS5XJQX7N7PAFU_ejd.smethod_0)));

		// Token: 0x0200084F RID: 2127
		private static class Class938
		{
			// Token: 0x040023EC RID: 9196
			public static MouseButtonEventHandler mouseButtonEventHandler_0;

			// Token: 0x040023ED RID: 9197
			public static MouseButtonEventHandler mouseButtonEventHandler_1;
		}
	}
}
