using System;
using Newtonsoft.Json;

// Token: 0x02000162 RID: 354
public sealed class GClass21
{
	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000081B8 File Offset: 0x000063B8
	// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000081C0 File Offset: 0x000063C0
	[JsonProperty("platform.maxVersionTested")]
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

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000081C9 File Offset: 0x000063C9
	// (set) Token: 0x06000A1F RID: 2591 RVA: 0x000081D1 File Offset: 0x000063D1
	[JsonProperty("platform.minVersion")]
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

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000081DA File Offset: 0x000063DA
	// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000081E2 File Offset: 0x000063E2
	[JsonProperty("platform.target")]
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

	// Token: 0x040006B9 RID: 1721
	private long long_0;

	// Token: 0x040006BA RID: 1722
	private long long_1;

	// Token: 0x040006BB RID: 1723
	private int int_0;
}
