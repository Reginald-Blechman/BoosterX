using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200046D RID: 1133
public sealed class GClass204
{
	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06001D7E RID: 7550 RVA: 0x0001386E File Offset: 0x00011A6E
	// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00013876 File Offset: 0x00011A76
	[JsonProperty("AllowedPlatforms")]
	public List<GClass262> List_0
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

	// Token: 0x0400139E RID: 5022
	private List<GClass262> list_0;
}
