using System;
using System.Windows;
using System.Windows.Controls;

// Token: 0x0200048B RID: 1163
public sealed class GClass213 : ScrollViewer
{
	// Token: 0x06001E31 RID: 7729 RVA: 0x00013EB2 File Offset: 0x000120B2
	public GClass213()
	{
		base.Loaded += this.GClass213_Loaded;
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x00013ECC File Offset: 0x000120CC
	private void GClass213_Loaded(object sender, RoutedEventArgs e)
	{
		base.ScrollInfo = new Class413(base.ScrollInfo);
	}
}
