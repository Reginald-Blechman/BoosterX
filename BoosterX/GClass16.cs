using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000159 RID: 345
public sealed class GClass16
{
	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00008082 File Offset: 0x00006282
	// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0000808A File Offset: 0x0000628A
	[JsonProperty("Results")]
	public List<GClass295> List_0
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

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060009EA RID: 2538 RVA: 0x00008093 File Offset: 0x00006293
	// (set) Token: 0x060009EB RID: 2539 RVA: 0x0000809B File Offset: 0x0000629B
	[JsonProperty("TotalResultCount")]
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

	// Token: 0x060009EC RID: 2540 RVA: 0x000080A4 File Offset: 0x000062A4
	public static GClass16 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<GClass16>(string_0, Class273.jsonSerializerSettings_0);
	}

	// Token: 0x040006A0 RID: 1696
	private List<GClass295> list_0;

	// Token: 0x040006A1 RID: 1697
	private long long_0;
}
