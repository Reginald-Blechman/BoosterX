using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02000484 RID: 1156
[DefaultMember("#=zC$ZHQIQ=")]
public sealed class GClass207
{
	// Token: 0x06001DFE RID: 7678 RVA: 0x00013CA3 File Offset: 0x00011EA3
	private GClass207()
	{
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x00013CB6 File Offset: 0x00011EB6
	public static GClass207 smethod_0()
	{
		if (GClass207.gclass207_0 == null)
		{
			GClass207.gclass207_0 = new GClass207();
		}
		return GClass207.gclass207_0;
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x00013CCE File Offset: 0x00011ECE
	public Dictionary<string, GClass222> method_0()
	{
		if (this.dictionary_0 == null)
		{
			this.dictionary_0 = new Dictionary<string, GClass222>();
			this.gclass46_0.method_2<List<GClass222>>("BoosterX.Resources.Json.allServices.json").ForEach(new Action<GClass222>(this.method_1));
		}
		return this.dictionary_0;
	}

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0007BF48 File Offset: 0x0007A148
	// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00013D0B File Offset: 0x00011F0B
	public GClass222 Item
	{
		get
		{
			GClass222 result;
			if (!this.method_0().TryGetValue(string_0.ToLower(), out result))
			{
				return null;
			}
			return result;
		}
		set
		{
			this.method_0()[string_0.ToLower()] = value;
		}
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x00013D1F File Offset: 0x00011F1F
	private void method_1(GClass222 gclass222_0)
	{
		this.set_Item(gclass222_0.ServiceName, gclass222_0);
	}

	// Token: 0x040013FB RID: 5115
	private static GClass207 gclass207_0;

	// Token: 0x040013FC RID: 5116
	private GClass46 gclass46_0 = new GClass46();

	// Token: 0x040013FD RID: 5117
	private Dictionary<string, GClass222> dictionary_0;
}
