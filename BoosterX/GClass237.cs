using System;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x02000543 RID: 1347
public sealed class GClass237
{
	// Token: 0x06002201 RID: 8705 RVA: 0x000164C8 File Offset: 0x000146C8
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000164D0 File Offset: 0x000146D0
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x06002203 RID: 8707 RVA: 0x000164D9 File Offset: 0x000146D9
	// (set) Token: 0x06002204 RID: 8708 RVA: 0x000164E1 File Offset: 0x000146E1
	public string Description
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

	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x06002205 RID: 8709 RVA: 0x000164EA File Offset: 0x000146EA
	// (set) Token: 0x06002206 RID: 8710 RVA: 0x000164F2 File Offset: 0x000146F2
	public MaterialIconKind Icon
	{
		[CompilerGenerated]
		get
		{
			return this.materialIconKind_0;
		}
		[CompilerGenerated]
		set
		{
			this.materialIconKind_0 = value;
		}
	}

	// Token: 0x040016AE RID: 5806
	private string string_0;

	// Token: 0x040016AF RID: 5807
	private string string_1;

	// Token: 0x040016B0 RID: 5808
	private MaterialIconKind materialIconKind_0;
}
