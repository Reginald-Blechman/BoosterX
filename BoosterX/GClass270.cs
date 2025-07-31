using System;

// Token: 0x0200061A RID: 1562
public sealed class GClass270
{
	// Token: 0x060027CB RID: 10187 RVA: 0x0001A65F File Offset: 0x0001885F
	public GClass270(bool bool_2 = true, bool bool_3 = false)
	{
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x0009BED0 File Offset: 0x0009A0D0
	internal uint method_0()
	{
		uint num = 0U;
		if (this.bool_0)
		{
			num |= 1U;
		}
		if (this.bool_1)
		{
			num |= 2U;
		}
		return num;
	}

	// Token: 0x04001A20 RID: 6688
	public readonly bool bool_0;

	// Token: 0x04001A21 RID: 6689
	public readonly bool bool_1;
}
