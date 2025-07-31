using System;

// Token: 0x02000047 RID: 71
internal sealed class Class83 : Class82
{
	// Token: 0x060001BF RID: 447 RVA: 0x00003FBC File Offset: 0x000021BC
	public Class83() : base(24)
	{
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00003FC6 File Offset: 0x000021C6
	public Array method_5()
	{
		return this.array_0;
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00003FCE File Offset: 0x000021CE
	public void method_6(Array array_1)
	{
		this.array_0 = array_1;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00003FD7 File Offset: 0x000021D7
	public long method_7()
	{
		return this.long_0;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00003FDF File Offset: 0x000021DF
	public void method_8(long long_1)
	{
		this.long_0 = long_1;
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00003FE8 File Offset: 0x000021E8
	public override object vmethod_4()
	{
		return this.array_0.GetValue(this.long_0);
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00003FFB File Offset: 0x000021FB
	public override void vmethod_5(object object_0)
	{
		this.array_0.SetValue(object_0, this.long_0);
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00027050 File Offset: 0x00025250
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		if (class58_0.method_0() == 24)
		{
			Class83 @class = (Class83)class58_0;
			this.method_6(@class.method_5());
			this.method_8(@class.method_7());
			base.method_4(@class.method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0000400F File Offset: 0x0000220F
	public override Class58 vmethod_3()
	{
		Class83 @class = new Class83();
		@class.method_6(this.array_0);
		@class.method_8(this.long_0);
		@class.method_4(base.method_3());
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x000270A8 File Offset: 0x000252A8
	public override bool vmethod_6(Class82 class82_0)
	{
		Class83 @class = (Class83)class82_0;
		return this.method_7() == @class.method_7() && this.method_5() == @class.method_5();
	}

	// Token: 0x0400009B RID: 155
	private Array array_0;

	// Token: 0x0400009C RID: 156
	private long long_0;
}
