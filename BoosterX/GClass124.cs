using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000386 RID: 902
public sealed class GClass124
{
	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x0600177A RID: 6010 RVA: 0x00010135 File Offset: 0x0000E335
	// (set) Token: 0x0600177B RID: 6011 RVA: 0x0001013D File Offset: 0x0000E33D
	[JsonProperty("MinimumHardware")]
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

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x0600177C RID: 6012 RVA: 0x00010146 File Offset: 0x0000E346
	// (set) Token: 0x0600177D RID: 6013 RVA: 0x0001014E File Offset: 0x0000E34E
	[JsonProperty("RecommendedHardware")]
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

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x0600177E RID: 6014 RVA: 0x00010157 File Offset: 0x0000E357
	// (set) Token: 0x0600177F RID: 6015 RVA: 0x0001015F File Offset: 0x0000E35F
	[JsonProperty("MinimumProcessor")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06001780 RID: 6016 RVA: 0x00010168 File Offset: 0x0000E368
	// (set) Token: 0x06001781 RID: 6017 RVA: 0x00010170 File Offset: 0x0000E370
	[JsonProperty("RecommendedProcessor")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06001782 RID: 6018 RVA: 0x00010179 File Offset: 0x0000E379
	// (set) Token: 0x06001783 RID: 6019 RVA: 0x00010181 File Offset: 0x0000E381
	[JsonProperty("MinimumGraphics")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06001784 RID: 6020 RVA: 0x0001018A File Offset: 0x0000E38A
	// (set) Token: 0x06001785 RID: 6021 RVA: 0x00010192 File Offset: 0x0000E392
	[JsonProperty("RecommendedGraphics")]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x04000F7E RID: 3966
	private List<object> list_0;

	// Token: 0x04000F7F RID: 3967
	private List<string> list_1;

	// Token: 0x04000F80 RID: 3968
	private string string_0;

	// Token: 0x04000F81 RID: 3969
	private string string_1;

	// Token: 0x04000F82 RID: 3970
	private string string_2;

	// Token: 0x04000F83 RID: 3971
	private string string_3;
}
