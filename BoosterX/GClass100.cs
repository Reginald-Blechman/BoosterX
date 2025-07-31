using System;
using Newtonsoft.Json;

// Token: 0x020002F9 RID: 761
public sealed class GClass100
{
	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x060013CF RID: 5071 RVA: 0x0000DF40 File Offset: 0x0000C140
	// (set) Token: 0x060013D0 RID: 5072 RVA: 0x0000DF48 File Offset: 0x0000C148
	[JsonProperty("hate")]
	public bool Boolean_0
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

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0000DF51 File Offset: 0x0000C151
	// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0000DF59 File Offset: 0x0000C159
	[JsonProperty("hate/threatening")]
	public bool Boolean_1
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

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0000DF62 File Offset: 0x0000C162
	// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0000DF6A File Offset: 0x0000C16A
	[JsonProperty("self-harm")]
	public bool Boolean_2
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
		}
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0000DF73 File Offset: 0x0000C173
	// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0000DF7B File Offset: 0x0000C17B
	[JsonProperty("sexual")]
	public bool Boolean_3
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
		}
	}

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0000DF84 File Offset: 0x0000C184
	// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0000DF8C File Offset: 0x0000C18C
	[JsonProperty("sexual/minors")]
	public bool Boolean_4
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
		}
	}

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0000DF95 File Offset: 0x0000C195
	// (set) Token: 0x060013DA RID: 5082 RVA: 0x0000DF9D File Offset: 0x0000C19D
	[JsonProperty("violence")]
	public bool Boolean_5
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
		}
	}

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x060013DB RID: 5083 RVA: 0x0000DFA6 File Offset: 0x0000C1A6
	// (set) Token: 0x060013DC RID: 5084 RVA: 0x0000DFAE File Offset: 0x0000C1AE
	[JsonProperty("violence/graphic")]
	public bool Boolean_6
	{
		get
		{
			return this.bool_6;
		}
		set
		{
			this.bool_6 = value;
		}
	}

	// Token: 0x04000D45 RID: 3397
	private bool bool_0;

	// Token: 0x04000D46 RID: 3398
	private bool bool_1;

	// Token: 0x04000D47 RID: 3399
	private bool bool_2;

	// Token: 0x04000D48 RID: 3400
	private bool bool_3;

	// Token: 0x04000D49 RID: 3401
	private bool bool_4;

	// Token: 0x04000D4A RID: 3402
	private bool bool_5;

	// Token: 0x04000D4B RID: 3403
	private bool bool_6;
}
