using System;
using Newtonsoft.Json;

// Token: 0x020002F2 RID: 754
public sealed class GClass64 : GClass63
{
	// Token: 0x170002DC RID: 732
	// (get) Token: 0x060013AC RID: 5036 RVA: 0x0000DE57 File Offset: 0x0000C057
	// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000DE5F File Offset: 0x0000C05F
	[JsonProperty("completion_tokens")]
	public short Int16_0
	{
		get
		{
			return this.short_0;
		}
		set
		{
			this.short_0 = value;
		}
	}

	// Token: 0x04000D34 RID: 3380
	private short short_0;
}
