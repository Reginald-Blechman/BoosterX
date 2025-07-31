using System;
using System.Collections.Generic;

// Token: 0x0200023B RID: 571
public sealed class GClass60
{
	// Token: 0x06000F8E RID: 3982 RVA: 0x00054630 File Offset: 0x00052830
	// Note: this type is marked as 'beforefieldinit'.
	static GClass60()
	{
		GClass209.GClass210 gclass = new GClass209.GClass210();
		gclass.method_1(new List<GClass209.GClass211>
		{
			GClass260.gclass211_9,
			GClass260.gclass211_1,
			GClass260.gclass211_4,
			GClass260.gclass211_11,
			GClass260.gclass211_13,
			GClass260.gclass211_14,
			GClass260.gclass211_15,
			GClass260.gclass211_2,
			GClass260.gclass211_20,
			GClass260.gclass211_12,
			GClass260.gclass211_22,
			GClass260.gclass211_23,
			GClass260.gclass211_28,
			GClass260.gclass211_27,
			GClass260.gclass211_25,
			GClass260.gclass211_33,
			GClass260.gclass211_36,
			GClass260.gclass211_37,
			GClass260.gclass211_30,
			GClass260.gclass211_24
		});
		GClass60.gclass210_0 = gclass;
		GClass209.GClass210 gclass2 = new GClass209.GClass210();
		gclass2.method_1(new List<GClass209.GClass211>
		{
			GClass260.gclass211_10,
			GClass260.gclass211_6,
			GClass260.gclass211_7,
			GClass260.gclass211_3,
			GClass260.gclass211_8,
			GClass260.gclass211_18,
			GClass260.gclass211_16,
			GClass260.gclass211_5,
			GClass260.gclass211_19,
			GClass260.gclass211_29,
			GClass260.gclass211_32,
			GClass260.gclass211_21,
			GClass260.gclass211_34,
			GClass260.gclass211_35,
			GClass260.gclass211_26,
			GClass260.gclass211_31
		});
		GClass60.gclass210_1 = gclass2;
		GClass209.GClass210 gclass3 = new GClass209.GClass210();
		gclass3.method_1(new List<GClass209.GClass211>
		{
			GClass260.gclass211_9,
			GClass260.gclass211_13,
			GClass260.gclass211_14,
			GClass260.gclass211_15,
			GClass260.gclass211_2,
			GClass260.gclass211_20,
			GClass260.gclass211_12,
			GClass260.gclass211_23,
			GClass260.gclass211_28,
			GClass260.gclass211_27,
			GClass260.gclass211_33,
			GClass260.gclass211_36,
			GClass260.gclass211_37,
			GClass260.gclass211_30,
			GClass260.gclass211_24
		});
		GClass60.gclass210_2 = gclass3;
		GClass209.GClass210 gclass4 = new GClass209.GClass210();
		gclass4.method_1(new List<GClass209.GClass211>
		{
			GClass260.gclass211_6,
			GClass260.gclass211_10,
			GClass260.gclass211_9,
			GClass260.gclass211_1,
			GClass260.gclass211_4,
			GClass260.gclass211_11,
			GClass260.gclass211_13,
			GClass260.gclass211_14,
			GClass260.gclass211_15,
			GClass260.gclass211_2,
			GClass260.gclass211_20,
			GClass260.gclass211_12,
			GClass260.gclass211_22,
			GClass260.gclass211_23,
			GClass260.gclass211_28,
			GClass260.gclass211_27,
			GClass260.gclass211_25,
			GClass260.gclass211_33,
			GClass260.gclass211_36,
			GClass260.gclass211_37,
			GClass260.gclass211_30,
			GClass260.gclass211_24,
			GClass260.gclass211_7,
			GClass260.gclass211_8,
			GClass260.gclass211_16,
			GClass260.gclass211_5,
			GClass260.gclass211_19,
			GClass260.gclass211_29,
			GClass260.gclass211_32,
			GClass260.gclass211_21,
			GClass260.gclass211_34,
			GClass260.gclass211_35,
			GClass260.gclass211_26,
			GClass260.gclass211_31
		});
		GClass60.gclass210_3 = gclass4;
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00054A38 File Offset: 0x00052C38
	public static List<string> smethod_0()
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		List<string> list = new List<string>();
		GClass209.GClass210 gclass = GClass60.gclass210_3;
		if (((gclass != null) ? gclass.method_0() : null) == null)
		{
			return list;
		}
		foreach (GClass209.GClass211 gclass2 in GClass60.gclass210_3.method_0())
		{
			if (((gclass2 != null) ? gclass2.Services : null) != null)
			{
				foreach (string text in gclass2.Services)
				{
					if (text != null && hashSet.Add(text))
					{
						list.Add(text);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x040009FC RID: 2556
	public static readonly GClass209.GClass210 gclass210_0;

	// Token: 0x040009FD RID: 2557
	public static readonly GClass209.GClass210 gclass210_1;

	// Token: 0x040009FE RID: 2558
	public static readonly GClass209.GClass210 gclass210_2;

	// Token: 0x040009FF RID: 2559
	public static readonly GClass209.GClass210 gclass210_3;
}
