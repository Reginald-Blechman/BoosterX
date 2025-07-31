using System;
using System.Runtime.CompilerServices;

// Token: 0x0200067D RID: 1661
internal sealed class Class785
{
	// Token: 0x06002A11 RID: 10769 RVA: 0x0001B703 File Offset: 0x00019903
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x0001B70B File Offset: 0x0001990B
	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x170006EF RID: 1775
	// (get) Token: 0x06002A13 RID: 10771 RVA: 0x0001B714 File Offset: 0x00019914
	// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0001B71C File Offset: 0x0001991C
	public string State
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

	// Token: 0x04001B8B RID: 7051
	private string string_0;

	// Token: 0x04001B8C RID: 7052
	private string string_1;
}
