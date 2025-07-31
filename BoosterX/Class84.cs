using System;

// Token: 0x02000091 RID: 145
internal sealed class Class84 : Class82
{
	// Token: 0x06000493 RID: 1171 RVA: 0x00005272 File Offset: 0x00003472
	public Class84() : base(11)
	{
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0000527C File Offset: 0x0000347C
	public Array method_5()
	{
		return this.array_0;
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00005284 File Offset: 0x00003484
	public void method_6(Array array_1)
	{
		this.array_0 = array_1;
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x0000528D File Offset: 0x0000348D
	public int[] method_7()
	{
		return this.int_1;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00005295 File Offset: 0x00003495
	public void method_8(int[] int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0000529E File Offset: 0x0000349E
	public override object vmethod_4()
	{
		return this.method_5().GetValue(this.method_7());
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x000052B1 File Offset: 0x000034B1
	public override void vmethod_5(object object_0)
	{
		this.method_5().SetValue(object_0, this.method_7());
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x000052C5 File Offset: 0x000034C5
	public override Class58 vmethod_3()
	{
		Class84 @class = new Class84();
		@class.method_6(this.method_5());
		@class.method_8(this.method_7());
		@class.method_4(base.method_3());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00036F88 File Offset: 0x00035188
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		if (class58_0.method_0() == 11)
		{
			Class84 @class = (Class84)class58_0;
			this.method_6(@class.method_5());
			this.method_8(@class.method_7());
			base.method_4(@class.method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00036FE0 File Offset: 0x000351E0
	public override bool vmethod_6(Class82 class82_0)
	{
		Class84 @class = (Class84)class82_0;
		return this.method_5() == @class.method_5() && Class45.smethod_0(this.method_7(), @class.method_7());
	}

	// Token: 0x040002C2 RID: 706
	private Array array_0;

	// Token: 0x040002C3 RID: 707
	private int[] int_1;
}
