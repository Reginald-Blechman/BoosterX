using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200014C RID: 332
public sealed class GClass35 : GClass33
{
	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600097C RID: 2428 RVA: 0x00007CBC File Offset: 0x00005EBC
	// (set) Token: 0x0600097D RID: 2429 RVA: 0x00007CC4 File Offset: 0x00005EC4
	[JsonProperty("id")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600097E RID: 2430 RVA: 0x00007CCD File Offset: 0x00005ECD
	// (set) Token: 0x0600097F RID: 2431 RVA: 0x00007CD5 File Offset: 0x00005ED5
	[JsonProperty("choices")]
	public List<GClass242> List_0
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

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06000980 RID: 2432 RVA: 0x00007CDE File Offset: 0x00005EDE
	// (set) Token: 0x06000981 RID: 2433 RVA: 0x00007CE6 File Offset: 0x00005EE6
	[JsonProperty("usage")]
	public GClass64 GClass64_0
	{
		get
		{
			return this.gclass64_0;
		}
		set
		{
			this.gclass64_0 = value;
		}
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x000453F4 File Offset: 0x000435F4
	public override string ToString()
	{
		if (this.List_0 != null && this.List_0.Count > 0)
		{
			return this.List_0[0].ToString();
		}
		return "CompletionResult " + this.String_4 + " has no valid output";
	}

	// Token: 0x04000672 RID: 1650
	private string string_4;

	// Token: 0x04000673 RID: 1651
	private List<GClass242> list_0;

	// Token: 0x04000674 RID: 1652
	private GClass64 gclass64_0;
}
