using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200016B RID: 363
public sealed class GClass36 : GClass33
{
	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00008256 File Offset: 0x00006456
	// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0000825E File Offset: 0x0000645E
	[JsonProperty("id")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00008267 File Offset: 0x00006467
	// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0000826F File Offset: 0x0000646F
	[JsonProperty("choices")]
	public IReadOnlyList<GClass53> IReadOnlyList_0
	{
		get
		{
			return this.ireadOnlyList_0;
		}
		set
		{
			this.ireadOnlyList_0 = value;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00008278 File Offset: 0x00006478
	// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00008280 File Offset: 0x00006480
	[JsonProperty("usage")]
	public GClass65 GClass65_0
	{
		get
		{
			return this.gclass65_0;
		}
		set
		{
			this.gclass65_0 = value;
		}
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00008289 File Offset: 0x00006489
	public override string ToString()
	{
		if (this.IReadOnlyList_0 != null && this.IReadOnlyList_0.Count > 0)
		{
			return this.IReadOnlyList_0[0].ToString();
		}
		return null;
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000082B4 File Offset: 0x000064B4
	// (set) Token: 0x06000A32 RID: 2610 RVA: 0x000082BC File Offset: 0x000064BC
	[JsonProperty("system_fingerprint")]
	public string String_5
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x040006C7 RID: 1735
	private string string_4;

	// Token: 0x040006C8 RID: 1736
	private IReadOnlyList<GClass53> ireadOnlyList_0;

	// Token: 0x040006C9 RID: 1737
	private GClass65 gclass65_0;

	// Token: 0x040006CA RID: 1738
	private string string_5;
}
