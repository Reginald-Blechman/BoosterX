using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

// Token: 0x020001EB RID: 491
public sealed class GClass37 : GClass33
{
	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0000A0B2 File Offset: 0x000082B2
	// (set) Token: 0x06000D67 RID: 3431 RVA: 0x0000A0BA File Offset: 0x000082BA
	[JsonProperty("results")]
	public List<GClass118> List_0
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

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0000A0C3 File Offset: 0x000082C3
	// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0000A0CB File Offset: 0x000082CB
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

	// Token: 0x06000D6A RID: 3434 RVA: 0x0000A0D4 File Offset: 0x000082D4
	public override string ToString()
	{
		List<GClass118> list = this.List_0;
		if (list == null)
		{
			return null;
		}
		GClass118 gclass = list.First<GClass118>();
		if (gclass == null)
		{
			return null;
		}
		return gclass.MainContentFlag;
	}

	// Token: 0x04000893 RID: 2195
	private List<GClass118> list_0;

	// Token: 0x04000894 RID: 2196
	private string string_4;
}
