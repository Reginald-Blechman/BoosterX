using System;
using Newtonsoft.Json;

// Token: 0x0200040D RID: 1037
public sealed class GClass65 : GClass63
{
	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00011DE1 File Offset: 0x0000FFE1
	// (set) Token: 0x06001A9D RID: 6813 RVA: 0x00011DE9 File Offset: 0x0000FFE9
	[JsonProperty("completion_tokens")]
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

	// Token: 0x040011D9 RID: 4569
	private int int_2;
}
