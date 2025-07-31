using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000630 RID: 1584
public sealed class GClass273
{
	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x0600283F RID: 10303 RVA: 0x0001A9CA File Offset: 0x00018BCA
	// (set) Token: 0x06002840 RID: 10304 RVA: 0x0001A9D2 File Offset: 0x00018BD2
	[JsonProperty("ClientConditions")]
	public GClass204 GClass204_0
	{
		get
		{
			return this.gclass204_0;
		}
		set
		{
			this.gclass204_0 = value;
		}
	}

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x06002841 RID: 10305 RVA: 0x0001A9DB File Offset: 0x00018BDB
	// (set) Token: 0x06002842 RID: 10306 RVA: 0x0001A9E3 File Offset: 0x00018BE3
	[JsonProperty("EndDate")]
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x06002843 RID: 10307 RVA: 0x0001A9EC File Offset: 0x00018BEC
	// (set) Token: 0x06002844 RID: 10308 RVA: 0x0001A9F4 File Offset: 0x00018BF4
	[JsonProperty("ResourceSetIds")]
	public List<string> List_0
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

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x06002845 RID: 10309 RVA: 0x0001A9FD File Offset: 0x00018BFD
	// (set) Token: 0x06002846 RID: 10310 RVA: 0x0001AA05 File Offset: 0x00018C05
	[JsonProperty("StartDate")]
	public DateTime DateTime_1
	{
		get
		{
			return this.dateTime_1;
		}
		set
		{
			this.dateTime_1 = value;
		}
	}

	// Token: 0x04001A7A RID: 6778
	private GClass204 gclass204_0;

	// Token: 0x04001A7B RID: 6779
	private DateTime dateTime_0;

	// Token: 0x04001A7C RID: 6780
	private List<string> list_0;

	// Token: 0x04001A7D RID: 6781
	private DateTime dateTime_1;
}
