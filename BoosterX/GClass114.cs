using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x02000347 RID: 839
public sealed class GClass114
{
	// Token: 0x17000355 RID: 853
	// (get) Token: 0x060015C5 RID: 5573 RVA: 0x0000EF49 File Offset: 0x0000D149
	// (set) Token: 0x060015C6 RID: 5574 RVA: 0x0000EF51 File Offset: 0x0000D151
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0000EF5A File Offset: 0x0000D15A
	// (set) Token: 0x060015C8 RID: 5576 RVA: 0x0000EF62 File Offset: 0x0000D162
	public List<GClass109> Choices
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x060015C9 RID: 5577 RVA: 0x0000EF6B File Offset: 0x0000D16B
	// (set) Token: 0x060015CA RID: 5578 RVA: 0x0000EF73 File Offset: 0x0000D173
	public long Created
	{
		[CompilerGenerated]
		get
		{
			return this.long_0;
		}
		[CompilerGenerated]
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x060015CB RID: 5579 RVA: 0x0000EF7C File Offset: 0x0000D17C
	// (set) Token: 0x060015CC RID: 5580 RVA: 0x0000EF84 File Offset: 0x0000D184
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x060015CD RID: 5581 RVA: 0x0000EF8D File Offset: 0x0000D18D
	// (set) Token: 0x060015CE RID: 5582 RVA: 0x0000EF95 File Offset: 0x0000D195
	[JsonPropertyName("system_fingerprint")]
	public string String_0
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

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x060015CF RID: 5583 RVA: 0x0000EF9E File Offset: 0x0000D19E
	// (set) Token: 0x060015D0 RID: 5584 RVA: 0x0000EFA6 File Offset: 0x0000D1A6
	public string Object
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
		[CompilerGenerated]
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0000EFAF File Offset: 0x0000D1AF
	// (set) Token: 0x060015D2 RID: 5586 RVA: 0x0000EFB7 File Offset: 0x0000D1B7
	public GClass87 Usage
	{
		[CompilerGenerated]
		get
		{
			return this.gclass87_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass87_0 = value;
		}
	}

	// Token: 0x04000E72 RID: 3698
	private string string_0;

	// Token: 0x04000E73 RID: 3699
	private List<GClass109> list_0 = new List<GClass109>();

	// Token: 0x04000E74 RID: 3700
	private long long_0;

	// Token: 0x04000E75 RID: 3701
	private string string_1;

	// Token: 0x04000E76 RID: 3702
	private string string_2;

	// Token: 0x04000E77 RID: 3703
	private string string_3;

	// Token: 0x04000E78 RID: 3704
	private GClass87 gclass87_0;
}
