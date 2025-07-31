using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace ns0
{
	// Token: 0x020008C9 RID: 2249
	internal static class dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd
	{
		// Token: 0x060034FB RID: 13563 RVA: 0x00021020 File Offset: 0x0001F220
		public static bool GetShowToolTipWhenTrimmed(DependencyObject dependencyObject_0)
		{
			return (bool)dependencyObject_0.GetValue(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.dependencyProperty_0);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00021032 File Offset: 0x0001F232
		public static void SetShowToolTipWhenTrimmed(DependencyObject dependencyObject_0, bool bool_0)
		{
			dependencyObject_0.SetValue(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.dependencyProperty_0, bool_0);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00021045 File Offset: 0x0001F245
		private static object GetOriginalToolTip(DependencyObject dependencyObject_0)
		{
			return dependencyObject_0.GetValue(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.dependencyProperty_1);
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00021052 File Offset: 0x0001F252
		private static void SetOriginalToolTip(DependencyObject dependencyObject_0, object object_0)
		{
			dependencyObject_0.SetValue(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.dependencyProperty_1, object_0);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x000CF04C File Offset: 0x000CD24C
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			try
			{
				TextBlock textBlock = dependencyObject_0 as TextBlock;
				if (textBlock != null)
				{
					if ((bool)dependencyPropertyChangedEventArgs_0.NewValue)
					{
						if (dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.GetOriginalToolTip(textBlock) == null)
						{
							dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.SetOriginalToolTip(textBlock, textBlock.ReadLocalValue(ToolTipService.ToolTipProperty));
						}
						FrameworkElement frameworkElement = textBlock;
						SizeChangedEventHandler value;
						if ((value = dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.sizeChangedEventHandler_0) == null)
						{
							value = (dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.sizeChangedEventHandler_0 = new SizeChangedEventHandler(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_1));
						}
						frameworkElement.SizeChanged += value;
						UIElement uielement = textBlock;
						EventHandler value2;
						if ((value2 = dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.eventHandler_0) == null)
						{
							value2 = (dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.eventHandler_0 = new EventHandler(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_1));
						}
						uielement.LayoutUpdated += value2;
						dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_2(textBlock);
					}
					else
					{
						FrameworkElement frameworkElement2 = textBlock;
						SizeChangedEventHandler value3;
						if ((value3 = dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.sizeChangedEventHandler_0) == null)
						{
							value3 = (dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.sizeChangedEventHandler_0 = new SizeChangedEventHandler(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_1));
						}
						frameworkElement2.SizeChanged -= value3;
						UIElement uielement2 = textBlock;
						EventHandler value4;
						if ((value4 = dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.eventHandler_0) == null)
						{
							value4 = (dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class957.eventHandler_0 = new EventHandler(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_1));
						}
						uielement2.LayoutUpdated -= value4;
						ToolTipService.SetToolTip(textBlock, dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.GetOriginalToolTip(textBlock));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000CF13C File Offset: 0x000CD33C
		private static void smethod_1(object sender, EventArgs e)
		{
			dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class958 @class = new dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.Class958();
			@class.textBlock_0 = (sender as TextBlock);
			if (@class.textBlock_0 != null)
			{
				@class.textBlock_0.Dispatcher.BeginInvoke(new Action(@class.method_0), DispatcherPriority.Background, Array.Empty<object>());
			}
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000CF188 File Offset: 0x000CD388
		private static void smethod_2(TextBlock textBlock_0)
		{
			if (string.IsNullOrWhiteSpace(textBlock_0.Text))
			{
				return;
			}
			bool flag = dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_3(textBlock_0);
			object originalToolTip = dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.GetOriginalToolTip(textBlock_0);
			if (flag)
			{
				if (originalToolTip != null)
				{
					if (originalToolTip != DependencyProperty.UnsetValue)
					{
						ToolTipService.SetToolTip(textBlock_0, originalToolTip);
						return;
					}
				}
				ToolTipService.SetToolTip(textBlock_0, textBlock_0.Text);
				return;
			}
			ToolTipService.SetToolTip(textBlock_0, originalToolTip);
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000CF1DC File Offset: 0x000CD3DC
		private static bool smethod_3(TextBlock textBlock_0)
		{
			double actualWidth = textBlock_0.ActualWidth;
			double actualHeight = textBlock_0.ActualHeight;
			if (double.IsNaN(actualWidth) || double.IsInfinity(actualWidth) || actualWidth <= 0.0 || double.IsNaN(actualHeight) || double.IsInfinity(actualHeight) || actualHeight <= 0.0)
			{
				return false;
			}
			Typeface typeface = new Typeface(textBlock_0.FontFamily, textBlock_0.FontStyle, textBlock_0.FontWeight, textBlock_0.FontStretch);
			FormattedText formattedText = new FormattedText(textBlock_0.Text ?? string.Empty, CultureInfo.CurrentCulture, textBlock_0.FlowDirection, typeface, textBlock_0.FontSize, textBlock_0.Foreground, VisualTreeHelper.GetDpi(textBlock_0).PixelsPerDip);
			if (textBlock_0.TextWrapping != TextWrapping.NoWrap)
			{
				formattedText.MaxTextWidth = actualWidth;
			}
			if (textBlock_0.TextWrapping != TextWrapping.NoWrap)
			{
				return formattedText.Height > actualHeight + 1.0;
			}
			return formattedText.WidthIncludingTrailingWhitespace > actualWidth + 1.0;
		}

		// Token: 0x04002672 RID: 9842
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.RegisterAttached("ShowToolTipWhenTrimmed", typeof(bool), typeof(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd), new PropertyMetadata(false, new PropertyChangedCallback(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_0)));

		// Token: 0x04002673 RID: 9843
		private static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.RegisterAttached("OriginalToolTip", typeof(object), typeof(dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd), new PropertyMetadata(null));

		// Token: 0x020008CA RID: 2250
		private static class Class957
		{
			// Token: 0x04002674 RID: 9844
			public static SizeChangedEventHandler sizeChangedEventHandler_0;

			// Token: 0x04002675 RID: 9845
			public static EventHandler eventHandler_0;
		}

		// Token: 0x020008CB RID: 2251
		private sealed class Class958
		{
			// Token: 0x06003504 RID: 13572 RVA: 0x00021060 File Offset: 0x0001F260
			internal void method_0()
			{
				dje_zX8HE2XRLBR936RZZK9CQQV67MTUUF9JQ63_ejd.smethod_2(this.textBlock_0);
			}

			// Token: 0x04002676 RID: 9846
			public TextBlock textBlock_0;
		}
	}
}
