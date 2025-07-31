using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020001CF RID: 463
public struct GStruct1
{
	// Token: 0x06000CC3 RID: 3267 RVA: 0x00009BDD File Offset: 0x00007DDD
	public GStruct1(List<GClass32> list_1, GClass32 gclass32_1)
	{
		this.list_0 = list_1;
		this.gclass32_0 = gclass32_1;
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00009BED File Offset: 0x00007DED
	public readonly List<GClass32> Profiles
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00009BF5 File Offset: 0x00007DF5
	public readonly GClass32 method_0()
	{
		return this.gclass32_0;
	}

	// Token: 0x04000830 RID: 2096
	private readonly List<GClass32> list_0;

	// Token: 0x04000831 RID: 2097
	private readonly GClass32 gclass32_0;
}
