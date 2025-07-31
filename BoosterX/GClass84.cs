using System;
using Newtonsoft.Json;

// Token: 0x020002A9 RID: 681
public sealed class GClass84
{
	// Token: 0x1700027A RID: 634
	// (get) Token: 0x060011EB RID: 4587 RVA: 0x0000CF3C File Offset: 0x0000B13C
	// (set) Token: 0x060011EC RID: 4588 RVA: 0x0000CF44 File Offset: 0x0000B144
	[JsonProperty("AverageRating")]
	public double Double_0
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x060011ED RID: 4589 RVA: 0x0000CF4D File Offset: 0x0000B14D
	// (set) Token: 0x060011EE RID: 4590 RVA: 0x0000CF55 File Offset: 0x0000B155
	[JsonProperty("AggregateTimeSpan")]
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

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x060011EF RID: 4591 RVA: 0x0000CF5E File Offset: 0x0000B15E
	// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0000CF66 File Offset: 0x0000B166
	[JsonProperty("RatingCount")]
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

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0000CF6F File Offset: 0x0000B16F
	// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0000CF77 File Offset: 0x0000B177
	[JsonProperty("PurchaseCount")]
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

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0000CF80 File Offset: 0x0000B180
	// (set) Token: 0x060011F4 RID: 4596 RVA: 0x0000CF88 File Offset: 0x0000B188
	[JsonProperty("TrialCount")]
	public long? Nullable_0
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0000CF91 File Offset: 0x0000B191
	// (set) Token: 0x060011F6 RID: 4598 RVA: 0x0000CF99 File Offset: 0x0000B199
	[JsonProperty("RentalCount")]
	public long Int64_2
	{
		get
		{
			return this.long_2;
		}
		set
		{
			this.long_2 = value;
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0000CFA2 File Offset: 0x0000B1A2
	// (set) Token: 0x060011F8 RID: 4600 RVA: 0x0000CFAA File Offset: 0x0000B1AA
	[JsonProperty("PlayCount")]
	public long Int64_3
	{
		get
		{
			return this.long_3;
		}
		set
		{
			this.long_3 = value;
		}
	}

	// Token: 0x04000B36 RID: 2870
	private double double_0;

	// Token: 0x04000B37 RID: 2871
	private string string_0;

	// Token: 0x04000B38 RID: 2872
	private long long_0;

	// Token: 0x04000B39 RID: 2873
	private long long_1;

	// Token: 0x04000B3A RID: 2874
	private long? nullable_0;

	// Token: 0x04000B3B RID: 2875
	private long long_2;

	// Token: 0x04000B3C RID: 2876
	private long long_3;
}
