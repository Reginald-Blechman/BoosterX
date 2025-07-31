using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020001C5 RID: 453
public sealed class GClass44
{
	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00009B1E File Offset: 0x00007D1E
	// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00009B26 File Offset: 0x00007D26
	[JsonProperty("ageRating")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00009B2F File Offset: 0x00007D2F
	// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00009B37 File Offset: 0x00007D37
	[JsonProperty("optOut.DVR")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00009B40 File Offset: 0x00007D40
	// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00009B48 File Offset: 0x00007D48
	[JsonProperty("thirdPartyAppRatings")]
	public List<GClass26> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x04000823 RID: 2083
	private int int_0;

	// Token: 0x04000824 RID: 2084
	private bool bool_0;

	// Token: 0x04000825 RID: 2085
	private List<GClass26> list_0;
}
