using System;
using Newtonsoft.Json;

// Token: 0x0200040B RID: 1035
public sealed class GClass140
{
	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06001A90 RID: 6800 RVA: 0x00011D8C File Offset: 0x0000FF8C
	// (set) Token: 0x06001A91 RID: 6801 RVA: 0x00011D94 File Offset: 0x0000FF94
	[JsonProperty("OriginalReleaseDate")]
	public DateTime? Nullable_0
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

	// Token: 0x040011D4 RID: 4564
	private DateTime? nullable_0;
}
