using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020003B8 RID: 952
public sealed class GClass127
{
	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x06001908 RID: 6408 RVA: 0x00010EEA File Offset: 0x0000F0EA
	// (set) Token: 0x06001909 RID: 6409 RVA: 0x00010EF2 File Offset: 0x0000F0F2
	[JsonProperty("mediaType")]
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

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x0600190A RID: 6410 RVA: 0x00010EFB File Offset: 0x0000F0FB
	// (set) Token: 0x0600190B RID: 6411 RVA: 0x00010F03 File Offset: 0x0000F103
	[JsonProperty("Category")]
	public List<string> List_1
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

	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x0600190C RID: 6412 RVA: 0x00010F0C File Offset: 0x0000F10C
	// (set) Token: 0x0600190D RID: 6413 RVA: 0x00010F14 File Offset: 0x0000F114
	[JsonProperty("UserAge")]
	public List<string> List_2
	{
		get
		{
			return this.list_2;
		}
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x0600190E RID: 6414 RVA: 0x00010F1D File Offset: 0x0000F11D
	// (set) Token: 0x0600190F RID: 6415 RVA: 0x00010F25 File Offset: 0x0000F125
	[JsonProperty("PriceType")]
	public List<string> List_3
	{
		get
		{
			return this.list_3;
		}
		set
		{
			this.list_3 = value;
		}
	}

	// Token: 0x0400107F RID: 4223
	private List<string> list_0;

	// Token: 0x04001080 RID: 4224
	private List<string> list_1;

	// Token: 0x04001081 RID: 4225
	private List<string> list_2;

	// Token: 0x04001082 RID: 4226
	private List<string> list_3;
}
