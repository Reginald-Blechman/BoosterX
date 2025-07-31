using System;
using System.Windows;

// Token: 0x020005E3 RID: 1507
internal static class Class724
{
	// Token: 0x0600269B RID: 9883 RVA: 0x00019AF4 File Offset: 0x00017CF4
	public static Size smethod_0(this Thickness thickness_0)
	{
		return new Size(thickness_0.Left + thickness_0.Right, thickness_0.Top + thickness_0.Bottom);
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x00093F04 File Offset: 0x00092104
	public static Rect smethod_1(this Rect rect_0, Thickness thickness_0)
	{
		return new Rect(rect_0.Left + thickness_0.Left, rect_0.Top + thickness_0.Top, Math.Max(0.0, rect_0.Width - thickness_0.Left - thickness_0.Right), Math.Max(0.0, rect_0.Height - thickness_0.Top - thickness_0.Bottom));
	}
}
