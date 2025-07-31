using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020001C7 RID: 455
public sealed class GClass45
{
	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00009B51 File Offset: 0x00007D51
	// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00009B59 File Offset: 0x00007D59
	[JsonProperty("ApplicationId")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x00009B62 File Offset: 0x00007D62
	// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00009B6A File Offset: 0x00007D6A
	[JsonProperty("DeclarationOrder")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00009B73 File Offset: 0x00007D73
	// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00009B7B File Offset: 0x00007D7B
	[JsonProperty("Extensions")]
	public List<string> List_0
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

	// Token: 0x04000826 RID: 2086
	private string string_0;

	// Token: 0x04000827 RID: 2087
	private long long_0;

	// Token: 0x04000828 RID: 2088
	private List<string> list_0;
}
