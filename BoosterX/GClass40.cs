using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020006F7 RID: 1783
public sealed class GClass40 : GClass33
{
	// Token: 0x1700076B RID: 1899
	// (get) Token: 0x06002CBB RID: 11451 RVA: 0x0001CCC4 File Offset: 0x0001AEC4
	// (set) Token: 0x06002CBC RID: 11452 RVA: 0x0001CCCC File Offset: 0x0001AECC
	[JsonProperty("data")]
	public List<GClass234> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x000AA998 File Offset: 0x000A8B98
	public override string ToString()
	{
		List<GClass234> list = this.List_0;
		if (list != null && list.Count > 0)
		{
			return this.List_0[0].String_0 ?? this.List_0[0].String_1;
		}
		return null;
	}

	// Token: 0x04001D02 RID: 7426
	private List<GClass234> list_0;
}
