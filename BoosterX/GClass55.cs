using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000209 RID: 521
public sealed class GClass55
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0000A7EE File Offset: 0x000089EE
	// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0000A7F6 File Offset: 0x000089F6
	[JsonProperty("GrantedEntitlementKeys")]
	public List<object> List_0
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

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0000A7FF File Offset: 0x000089FF
	// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0000A807 File Offset: 0x00008A07
	[JsonProperty("PIFilter")]
	public GClass116 GClass116_0
	{
		get
		{
			return this.gclass116_0;
		}
		set
		{
			this.gclass116_0 = value;
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0000A810 File Offset: 0x00008A10
	// (set) Token: 0x06000E19 RID: 3609 RVA: 0x0000A818 File Offset: 0x00008A18
	[JsonProperty("Price")]
	public GClass29 GClass29_0
	{
		get
		{
			return this.gclass29_0;
		}
		set
		{
			this.gclass29_0 = value;
		}
	}

	// Token: 0x04000916 RID: 2326
	private List<object> list_0;

	// Token: 0x04000917 RID: 2327
	private GClass116 gclass116_0;

	// Token: 0x04000918 RID: 2328
	private GClass29 gclass29_0;
}
