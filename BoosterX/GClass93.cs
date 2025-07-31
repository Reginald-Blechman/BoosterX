using System;
using Newtonsoft.Json;

// Token: 0x020002D6 RID: 726
public sealed class GClass93
{
	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x06001342 RID: 4930 RVA: 0x0000DAAA File Offset: 0x0000BCAA
	// (set) Token: 0x06001343 RID: 4931 RVA: 0x0000DAB2 File Offset: 0x0000BCB2
	[JsonProperty("Uri")]
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

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x06001344 RID: 4932 RVA: 0x0000DABB File Offset: 0x0000BCBB
	// (set) Token: 0x06001345 RID: 4933 RVA: 0x0000DAC3 File Offset: 0x0000BCC3
	[JsonProperty("Rank")]
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

	// Token: 0x04000C09 RID: 3081
	private string string_0;

	// Token: 0x04000C0A RID: 3082
	private long long_0;
}
