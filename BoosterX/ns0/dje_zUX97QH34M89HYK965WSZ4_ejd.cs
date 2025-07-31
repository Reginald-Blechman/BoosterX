using System;
using System.Windows;
using System.Windows.Controls;

namespace ns0
{
	// Token: 0x0200088E RID: 2190
	public sealed class dje_zUX97QH34M89HYK965WSZ4_ejd : Canvas
	{
		// Token: 0x060033DA RID: 13274 RVA: 0x000C9FFC File Offset: 0x000C81FC
		protected override Size MeasureOverride(Size constraint)
		{
			double num = 0.0;
			double num2 = 0.0;
			foreach (object obj in base.Children)
			{
				FrameworkElement frameworkElement = obj as FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement.Measure(constraint);
					double num3 = Canvas.GetTop(frameworkElement) + frameworkElement.DesiredSize.Height;
					if (!double.IsInfinity(num3) && !double.IsNaN(num3))
					{
						num = Math.Max(num, num3);
					}
					num3 = Canvas.GetLeft(frameworkElement) + frameworkElement.DesiredSize.Width;
					if (!double.IsInfinity(num3) && !double.IsNaN(num3))
					{
						num2 = Math.Max(num2, num3);
					}
				}
			}
			return new Size(num2, num);
		}
	}
}
