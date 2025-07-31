using System;
using System.Windows;
using System.Windows.Input;

// Token: 0x0200014D RID: 333
public sealed class GClass13
{
	// Token: 0x06000983 RID: 2435 RVA: 0x00007CEF File Offset: 0x00005EEF
	public GClass13(UIElement uielement_1, MouseButtonEventArgs mouseButtonEventArgs_1)
	{
		this.uielement_0 = uielement_1;
		this.mouseButtonEventArgs_0 = mouseButtonEventArgs_1;
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00007D05 File Offset: 0x00005F05
	public UIElement method_0()
	{
		return this.uielement_0;
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00007D0D File Offset: 0x00005F0D
	public MouseButtonEventArgs method_1()
	{
		return this.mouseButtonEventArgs_0;
	}

	// Token: 0x04000675 RID: 1653
	private readonly UIElement uielement_0;

	// Token: 0x04000676 RID: 1654
	private readonly MouseButtonEventArgs mouseButtonEventArgs_0;
}
