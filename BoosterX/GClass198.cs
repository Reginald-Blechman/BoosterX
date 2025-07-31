using System;
using System.Windows;
using System.Windows.Input;

// Token: 0x02000458 RID: 1112
public sealed class GClass198
{
	// Token: 0x06001D17 RID: 7447 RVA: 0x00013379 File Offset: 0x00011579
	public GClass198(UIElement uielement_1, MouseEventArgs mouseEventArgs_1)
	{
		this.uielement_0 = uielement_1;
		this.mouseEventArgs_0 = mouseEventArgs_1;
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x0001338F File Offset: 0x0001158F
	public UIElement method_0()
	{
		return this.uielement_0;
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x00013397 File Offset: 0x00011597
	public MouseEventArgs method_1()
	{
		return this.mouseEventArgs_0;
	}

	// Token: 0x04001348 RID: 4936
	private readonly UIElement uielement_0;

	// Token: 0x04001349 RID: 4937
	private readonly MouseEventArgs mouseEventArgs_0;
}
