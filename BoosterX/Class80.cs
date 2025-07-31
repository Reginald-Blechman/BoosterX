using System;

// Token: 0x0200000A RID: 10
internal sealed class Class80 : Class79
{
	// Token: 0x06000057 RID: 87 RVA: 0x000032C6 File Offset: 0x000014C6
	public Class80() : base(23)
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000032D0 File Offset: 0x000014D0
	public int method_3()
	{
		return this.int_1;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000032D8 File Offset: 0x000014D8
	public void method_4(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000032E1 File Offset: 0x000014E1
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		if (class58_0.method_0() == 23)
		{
			this.method_4(((Class80)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003313 File Offset: 0x00001513
	public override Class58 vmethod_3()
	{
		Class80 @class = new Class80();
		@class.method_4(this.int_1);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0400001E RID: 30
	private int int_1;
}
