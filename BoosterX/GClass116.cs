using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000367 RID: 871
public sealed class GClass116
{
	// Token: 0x17000375 RID: 885
	// (get) Token: 0x0600167F RID: 5759 RVA: 0x0000F592 File Offset: 0x0000D792
	// (set) Token: 0x06001680 RID: 5760 RVA: 0x0000F59A File Offset: 0x0000D79A
	[JsonProperty("ExclusionProperties")]
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

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06001681 RID: 5761 RVA: 0x0000F5A3 File Offset: 0x0000D7A3
	// (set) Token: 0x06001682 RID: 5762 RVA: 0x0000F5AB File Offset: 0x0000D7AB
	[JsonProperty("InclusionProperties")]
	public List<object> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x04000EE1 RID: 3809
	private List<object> list_0;

	// Token: 0x04000EE2 RID: 3810
	private List<object> list_1;
}
