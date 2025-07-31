using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020001AA RID: 426
public sealed class GClass42
{
	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000093D0 File Offset: 0x000075D0
	// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x000093D8 File Offset: 0x000075D8
	[JsonProperty("Product")]
	public GClass197 GClass197_0
	{
		get
		{
			return this.gclass197_0;
		}
		set
		{
			this.gclass197_0 = value;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000093E1 File Offset: 0x000075E1
	// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x000093E9 File Offset: 0x000075E9
	[JsonProperty("BigIds")]
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

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000093F2 File Offset: 0x000075F2
	// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x000093FA File Offset: 0x000075FA
	[JsonProperty("HasMorePages")]
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

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00009403 File Offset: 0x00007603
	// (set) Token: 0x06000BFA RID: 3066 RVA: 0x0000940B File Offset: 0x0000760B
	[JsonProperty("Products")]
	public List<GClass197> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00009414 File Offset: 0x00007614
	// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0000941C File Offset: 0x0000761C
	[JsonProperty("TotalResultCount")]
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

	// Token: 0x06000BFD RID: 3069 RVA: 0x00009425 File Offset: 0x00007625
	public static GClass42 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<GClass42>(string_0, GClass229.jsonSerializerSettings_0);
	}

	// Token: 0x040007B0 RID: 1968
	private GClass197 gclass197_0;

	// Token: 0x040007B1 RID: 1969
	private List<string> list_0;

	// Token: 0x040007B2 RID: 1970
	private bool bool_0;

	// Token: 0x040007B3 RID: 1971
	private List<GClass197> list_1;

	// Token: 0x040007B4 RID: 1972
	private int int_0;
}
