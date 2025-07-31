using System;
using Newtonsoft.Json;

// Token: 0x02000185 RID: 389
public sealed class GClass26
{
	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00008760 File Offset: 0x00006960
	// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00008768 File Offset: 0x00006968
	[JsonProperty("level")]
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

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00008771 File Offset: 0x00006971
	// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00008779 File Offset: 0x00006979
	[JsonProperty("systemId")]
	public int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x0400071B RID: 1819
	private int int_0;

	// Token: 0x0400071C RID: 1820
	private int int_1;
}
