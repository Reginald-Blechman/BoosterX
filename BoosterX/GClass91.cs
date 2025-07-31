using System;
using System.Text;

// Token: 0x020002BB RID: 699
public sealed class GClass91
{
	// Token: 0x060012A9 RID: 4777 RVA: 0x0005C728 File Offset: 0x0005A928
	static GClass91()
	{
		GClass91.gclass121_0 = new GClass121(GClass91.gclass50_0, GClass91.gclass120_0);
		GClass91.gclass123_0 = new GClass123(GClass91.gclass50_0, GClass91.gclass120_0);
		GClass91.gclass122_0 = new GClass122(GClass91.gclass50_0, GClass91.gclass123_0, GClass91.gclass121_0, GClass91.gclass120_0);
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0000D572 File Offset: 0x0000B772
	private static GClass130 smethod_0()
	{
		return GClass130.smethod_0(Encoding.Default.GetString(Class201.smethod_3()));
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x000039D3 File Offset: 0x00001BD3
	private static GClass130 smethod_1()
	{
		return null;
	}

	// Token: 0x04000BA9 RID: 2985
	private static readonly GClass130 gclass130_0 = GClass91.smethod_0();

	// Token: 0x04000BAA RID: 2986
	public static readonly GClass130 gclass130_1 = GClass91.smethod_1();

	// Token: 0x04000BAB RID: 2987
	public static readonly GClass50 gclass50_0 = new GClass50(GClass91.gclass130_0, GClass91.gclass130_1);

	// Token: 0x04000BAC RID: 2988
	public static readonly GClass123 gclass123_0;

	// Token: 0x04000BAD RID: 2989
	public static readonly GClass122 gclass122_0;

	// Token: 0x04000BAE RID: 2990
	public static readonly GClass121 gclass121_0;

	// Token: 0x04000BAF RID: 2991
	public static readonly GClass120 gclass120_0 = new GClass120(GClass91.gclass50_0);
}
