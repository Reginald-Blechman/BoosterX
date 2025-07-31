using System;
using Newtonsoft.Json;

// Token: 0x0200018C RID: 396
public sealed class GClass29
{
	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00008BF5 File Offset: 0x00006DF5
	// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00008BFD File Offset: 0x00006DFD
	[JsonProperty("CurrencyCode")]
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

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00008C06 File Offset: 0x00006E06
	// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00008C0E File Offset: 0x00006E0E
	[JsonProperty("IsPIRequired")]
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

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00008C17 File Offset: 0x00006E17
	// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00008C1F File Offset: 0x00006E1F
	[JsonProperty("ListPrice")]
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

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00008C28 File Offset: 0x00006E28
	// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00008C30 File Offset: 0x00006E30
	[JsonProperty("MSRP")]
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

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00008C39 File Offset: 0x00006E39
	// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00008C41 File Offset: 0x00006E41
	[JsonProperty("TaxType")]
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

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00008C4A File Offset: 0x00006E4A
	// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00008C52 File Offset: 0x00006E52
	[JsonProperty("WholesaleCurrencyCode")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x04000734 RID: 1844
	private string string_0;

	// Token: 0x04000735 RID: 1845
	private bool bool_0;

	// Token: 0x04000736 RID: 1846
	private long long_0;

	// Token: 0x04000737 RID: 1847
	private long long_1;

	// Token: 0x04000738 RID: 1848
	private string string_1;

	// Token: 0x04000739 RID: 1849
	private string string_2;
}
