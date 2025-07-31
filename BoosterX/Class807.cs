using System;
using System.Windows;
using System.Windows.Media;

// Token: 0x02000690 RID: 1680
internal sealed class Class807
{
	// Token: 0x06002A71 RID: 10865 RVA: 0x000A3B78 File Offset: 0x000A1D78
	public static Point smethod_0(UIElement uielement_0, Point point_0)
	{
		if (uielement_0 != null)
		{
			Visual visual = Class807.smethod_1(uielement_0);
			if (visual != null)
			{
				return visual.PointToScreen(point_0);
			}
		}
		return default(Point);
	}

	// Token: 0x06002A72 RID: 10866 RVA: 0x000A3BA4 File Offset: 0x000A1DA4
	private static Visual smethod_1(UIElement uielement_0)
	{
		DependencyObject parent = VisualTreeHelper.GetParent(uielement_0);
		Visual visual = uielement_0;
		while (parent != null && visual == null)
		{
			visual = (parent as Visual);
			parent = VisualTreeHelper.GetParent(parent);
		}
		return visual;
	}
}
