using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200028B RID: 651
public sealed class GClass80
{
	// Token: 0x17000262 RID: 610
	// (get) Token: 0x06001169 RID: 4457 RVA: 0x0000CB38 File Offset: 0x0000AD38
	// (set) Token: 0x0600116A RID: 4458 RVA: 0x0000CB40 File Offset: 0x0000AD40
	[JsonProperty("Sku")]
	public GClass232 GClass232_0
	{
		get
		{
			return this.gclass232_0;
		}
		set
		{
			this.gclass232_0 = value;
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x0600116B RID: 4459 RVA: 0x0000CB49 File Offset: 0x0000AD49
	// (set) Token: 0x0600116C RID: 4460 RVA: 0x0000CB51 File Offset: 0x0000AD51
	[JsonProperty("Availabilities")]
	public List<GClass205> List_0
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

	// Token: 0x04000AD5 RID: 2773
	private GClass232 gclass232_0;

	// Token: 0x04000AD6 RID: 2774
	private List<GClass205> list_0;
}
