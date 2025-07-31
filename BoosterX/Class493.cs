using System;
using System.Collections.Generic;

// Token: 0x0200018D RID: 397
internal sealed class Class493 : GClass162
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00008C5B File Offset: 0x00006E5B
	// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00008C63 File Offset: 0x00006E63
	public List<GClass77> ServicesViewGroupModels
	{
		get
		{
			return this.list_0;
		}
		set
		{
			if (object.Equals(value, this.list_0))
			{
				return;
			}
			this.list_0 = value;
			base.method_0("ServicesViewGroupModels");
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00008C87 File Offset: 0x00006E87
	// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00008C8F File Offset: 0x00006E8F
	public string HeaderText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			if (value == this.string_0)
			{
				return;
			}
			this.string_0 = value;
			base.method_0("HeaderText");
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00008CB3 File Offset: 0x00006EB3
	// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00008CBB File Offset: 0x00006EBB
	public string DescText
	{
		get
		{
			return this.string_1;
		}
		set
		{
			if (value == this.string_1)
			{
				return;
			}
			this.string_1 = value;
			base.method_0("DescText");
		}
	}

	// Token: 0x0400073A RID: 1850
	private string string_0;

	// Token: 0x0400073B RID: 1851
	private string string_1;

	// Token: 0x0400073C RID: 1852
	private List<GClass77> list_0;
}
