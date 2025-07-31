using System;
using Newtonsoft.Json;

// Token: 0x020001E4 RID: 484
public sealed class GClass51
{
	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00009FDD File Offset: 0x000081DD
	// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00009FE5 File Offset: 0x000081E5
	[JsonProperty("SearchTitleString")]
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

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00009FEE File Offset: 0x000081EE
	// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00009FF6 File Offset: 0x000081F6
	[JsonProperty("SearchTitleType")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x0400087F RID: 2175
	private string string_0;

	// Token: 0x04000880 RID: 2176
	private string string_1;
}
