using System;
using System.Runtime.CompilerServices;

// Token: 0x02000251 RID: 593
public sealed class GClass67
{
	// Token: 0x06001008 RID: 4104 RVA: 0x0000BB94 File Offset: 0x00009D94
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x0000BB9C File Offset: 0x00009D9C
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x0600100A RID: 4106 RVA: 0x0000BBA5 File Offset: 0x00009DA5
	// (set) Token: 0x0600100B RID: 4107 RVA: 0x0000BBAD File Offset: 0x00009DAD
	public string CustomValue
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

	// Token: 0x04000A2D RID: 2605
	private string string_0;

	// Token: 0x04000A2E RID: 2606
	private string string_1;
}
