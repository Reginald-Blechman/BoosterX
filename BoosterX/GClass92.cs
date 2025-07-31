using System;
using Newtonsoft.Json;

// Token: 0x020002D5 RID: 725
public sealed class GClass92
{
	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x0600133D RID: 4925 RVA: 0x0000DA88 File Offset: 0x0000BC88
	// (set) Token: 0x0600133E RID: 4926 RVA: 0x0000DA90 File Offset: 0x0000BC90
	[JsonProperty("approximateSizeInBytes")]
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

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600133F RID: 4927 RVA: 0x0000DA99 File Offset: 0x0000BC99
	// (set) Token: 0x06001340 RID: 4928 RVA: 0x0000DAA1 File Offset: 0x0000BCA1
	[JsonProperty("price")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x04000C07 RID: 3079
	private long long_0;

	// Token: 0x04000C08 RID: 3080
	private long long_1;
}
