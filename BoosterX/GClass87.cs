using System;
using System.Text.Json.Serialization;

// Token: 0x020002AD RID: 685
public sealed class GClass87
{
	// Token: 0x17000285 RID: 645
	// (get) Token: 0x0600121A RID: 4634 RVA: 0x0000D0A9 File Offset: 0x0000B2A9
	// (set) Token: 0x0600121B RID: 4635 RVA: 0x0000D0B1 File Offset: 0x0000B2B1
	[JsonPropertyName("completion_tokens")]
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

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x0600121C RID: 4636 RVA: 0x0000D0BA File Offset: 0x0000B2BA
	// (set) Token: 0x0600121D RID: 4637 RVA: 0x0000D0C2 File Offset: 0x0000B2C2
	[JsonPropertyName("prompt_tokens")]
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

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x0600121E RID: 4638 RVA: 0x0000D0CB File Offset: 0x0000B2CB
	// (set) Token: 0x0600121F RID: 4639 RVA: 0x0000D0D3 File Offset: 0x0000B2D3
	[JsonPropertyName("prompt_cache_hit_tokens")]
	public int Int32_2
	{
		get
		{
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x06001220 RID: 4640 RVA: 0x0000D0DC File Offset: 0x0000B2DC
	// (set) Token: 0x06001221 RID: 4641 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
	[JsonPropertyName("prompt_cache_miss_tokens")]
	public int Int32_3
	{
		get
		{
			return this.int_3;
		}
		set
		{
			this.int_3 = value;
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x06001222 RID: 4642 RVA: 0x0000D0ED File Offset: 0x0000B2ED
	// (set) Token: 0x06001223 RID: 4643 RVA: 0x0000D0F5 File Offset: 0x0000B2F5
	[JsonPropertyName("total_tokens")]
	public int Int32_4
	{
		get
		{
			return this.int_4;
		}
		set
		{
			this.int_4 = value;
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x06001224 RID: 4644 RVA: 0x0000D0FE File Offset: 0x0000B2FE
	// (set) Token: 0x06001225 RID: 4645 RVA: 0x0000D106 File Offset: 0x0000B306
	[JsonPropertyName("prompt_tokens_details")]
	public GClass87.GClass88 GClass88_0
	{
		get
		{
			return this.gclass88_0;
		}
		set
		{
			this.gclass88_0 = value;
		}
	}

	// Token: 0x04000B6B RID: 2923
	private int int_0;

	// Token: 0x04000B6C RID: 2924
	private int int_1;

	// Token: 0x04000B6D RID: 2925
	private int int_2;

	// Token: 0x04000B6E RID: 2926
	private int int_3;

	// Token: 0x04000B6F RID: 2927
	private int int_4;

	// Token: 0x04000B70 RID: 2928
	private GClass87.GClass88 gclass88_0;

	// Token: 0x020002AE RID: 686
	public sealed class GClass88
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x0000D10F File Offset: 0x0000B30F
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x0000D117 File Offset: 0x0000B317
		[JsonPropertyName("reasoning_tokens")]
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0000D120 File Offset: 0x0000B320
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x0000D128 File Offset: 0x0000B328
		[JsonPropertyName("cached_tokens")]
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

		// Token: 0x04000B71 RID: 2929
		private int int_0;

		// Token: 0x04000B72 RID: 2930
		private int int_1;
	}
}
