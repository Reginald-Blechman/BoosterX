using System;
using System.Runtime.CompilerServices;

// Token: 0x0200034B RID: 843
internal sealed class Class400
{
	// Token: 0x1700035E RID: 862
	// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0000F066 File Offset: 0x0000D266
	// (set) Token: 0x060015E3 RID: 5603 RVA: 0x0000F06E File Offset: 0x0000D26E
	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			return this.guid_0;
		}
		[CompilerGenerated]
		set
		{
			this.guid_0 = value;
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0000F077 File Offset: 0x0000D277
	// (set) Token: 0x060015E5 RID: 5605 RVA: 0x0000F07F File Offset: 0x0000D27F
	public string Json
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

	// Token: 0x04000E7F RID: 3711
	private Guid guid_0;

	// Token: 0x04000E80 RID: 3712
	private string string_0 = string.Empty;
}
