using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200023F RID: 575
public sealed class GClass62
{
	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0000B726 File Offset: 0x00009926
	// (set) Token: 0x06000F9F RID: 3999 RVA: 0x0000B72E File Offset: 0x0000992E
	[JsonProperty("RatingSystem")]
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

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x0000B737 File Offset: 0x00009937
	// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x0000B73F File Offset: 0x0000993F
	[JsonProperty("RatingId")]
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

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0000B748 File Offset: 0x00009948
	// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x0000B750 File Offset: 0x00009950
	[JsonProperty("RatingDescriptors")]
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

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0000B759 File Offset: 0x00009959
	// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0000B761 File Offset: 0x00009961
	[JsonProperty("RatingDisclaimers")]
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

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0000B76A File Offset: 0x0000996A
	// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x0000B772 File Offset: 0x00009972
	[JsonProperty("InteractiveElements")]
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

	// Token: 0x04000A01 RID: 2561
	private string string_0;

	// Token: 0x04000A02 RID: 2562
	private string string_1;

	// Token: 0x04000A03 RID: 2563
	private List<string> list_0;

	// Token: 0x04000A04 RID: 2564
	private List<object> list_1;

	// Token: 0x04000A05 RID: 2565
	private List<string> list_2;
}
