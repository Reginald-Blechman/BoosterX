using System;

// Token: 0x020000B3 RID: 179
internal sealed class Class85 : Class79
{
	// Token: 0x0600056C RID: 1388 RVA: 0x0000588E File Offset: 0x00003A8E
	public Class85() : base(2)
	{
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00005897 File Offset: 0x00003A97
	public Class58 method_3()
	{
		return this.class58_0;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0000589F File Offset: 0x00003A9F
	public void method_4(Class58 class58_1)
	{
		this.class58_0 = class58_1;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x000058A8 File Offset: 0x00003AA8
	public override Class58 vmethod_2(Class58 class58_1)
	{
		base.method_2(class58_1.method_1());
		if (class58_1.method_0() == 2)
		{
			this.method_4(((Class85)class58_1).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x000058D9 File Offset: 0x00003AD9
	public override Class58 vmethod_3()
	{
		Class85 @class = new Class85();
		@class.method_4(this.method_3());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000304 RID: 772
	private Class58 class58_0;
}
