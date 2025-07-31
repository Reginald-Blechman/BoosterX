using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000620 RID: 1568
internal sealed class Class757
{
	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x060027E0 RID: 10208 RVA: 0x0001A716 File Offset: 0x00018916
	// (set) Token: 0x060027E1 RID: 10209 RVA: 0x0001A71E File Offset: 0x0001891E
	[JsonProperty("name")]
	internal string String_0
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

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0001A727 File Offset: 0x00018927
	// (set) Token: 0x060027E3 RID: 10211 RVA: 0x0001A72F File Offset: 0x0001892F
	[JsonProperty("description")]
	internal string String_1
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

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0001A738 File Offset: 0x00018938
	// (set) Token: 0x060027E5 RID: 10213 RVA: 0x0001A740 File Offset: 0x00018940
	[JsonProperty("iconPath")]
	internal string String_2
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

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x060027E6 RID: 10214 RVA: 0x0001A749 File Offset: 0x00018949
	// (set) Token: 0x060027E7 RID: 10215 RVA: 0x0001A751 File Offset: 0x00018951
	[JsonProperty("isPRO")]
	internal bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x060027E8 RID: 10216 RVA: 0x0001A75A File Offset: 0x0001895A
	// (set) Token: 0x060027E9 RID: 10217 RVA: 0x0001A762 File Offset: 0x00018962
	[JsonProperty("paths")]
	internal List<string> List_0
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

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x060027EA RID: 10218 RVA: 0x0001A76B File Offset: 0x0001896B
	// (set) Token: 0x060027EB RID: 10219 RVA: 0x0001A773 File Offset: 0x00018973
	[JsonProperty("includeInsideFolders")]
	internal bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x060027EC RID: 10220 RVA: 0x0001A77C File Offset: 0x0001897C
	// (set) Token: 0x060027ED RID: 10221 RVA: 0x0001A784 File Offset: 0x00018984
	[JsonProperty("searchPattern")]
	internal string String_3
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

	// Token: 0x04001A29 RID: 6697
	private string string_0;

	// Token: 0x04001A2A RID: 6698
	private string string_1;

	// Token: 0x04001A2B RID: 6699
	private string string_2;

	// Token: 0x04001A2C RID: 6700
	private bool bool_0;

	// Token: 0x04001A2D RID: 6701
	private List<string> list_0;

	// Token: 0x04001A2E RID: 6702
	private bool bool_1;

	// Token: 0x04001A2F RID: 6703
	private string string_3;
}
