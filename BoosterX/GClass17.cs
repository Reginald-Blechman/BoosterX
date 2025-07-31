using System;
using Newtonsoft.Json;

// Token: 0x0200015A RID: 346
public sealed class GClass17
{
	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060009EE RID: 2542 RVA: 0x000080B1 File Offset: 0x000062B1
	// (set) Token: 0x060009EF RID: 2543 RVA: 0x000080B9 File Offset: 0x000062B9
	[JsonProperty("MaxTested")]
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

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000080C2 File Offset: 0x000062C2
	// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000080CA File Offset: 0x000062CA
	[JsonProperty("MinVersion")]
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

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000080D3 File Offset: 0x000062D3
	// (set) Token: 0x060009F3 RID: 2547 RVA: 0x000080DB File Offset: 0x000062DB
	[JsonProperty("PlatformName")]
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

	// Token: 0x040006A2 RID: 1698
	private long long_0;

	// Token: 0x040006A3 RID: 1699
	private long long_1;

	// Token: 0x040006A4 RID: 1700
	private string string_0;
}
