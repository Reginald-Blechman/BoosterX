using System;

// Token: 0x02000045 RID: 69
internal sealed class Class69 : Class58
{
	// Token: 0x060001B0 RID: 432 RVA: 0x00003F12 File Offset: 0x00002112
	public Class69() : base(13)
	{
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00003F1C File Offset: 0x0000211C
	public Class69(long long_1) : this()
	{
		this.long_0 = long_1;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00003F2B File Offset: 0x0000212B
	public long method_3()
	{
		return this.long_0;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00003F33 File Offset: 0x00002133
	public void method_4(long long_1)
	{
		this.long_0 = long_1;
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00003F3C File Offset: 0x0000213C
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00026C8C File Offset: 0x00024E8C
	public override void vmethod_1(object object_0)
	{
		if (object_0 is ulong)
		{
			this.method_4((long)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((long)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((long)((double)object_0));
			return;
		}
		this.method_4(Convert.ToInt64(object_0));
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00003F49 File Offset: 0x00002149
	public override Class58 vmethod_3()
	{
		Class69 @class = new Class69();
		@class.method_4(this.long_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00026CE8 File Offset: 0x00024EE8
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((long)((Class75)class58_0).method_3());
			return this;
		case 1:
			this.method_4((long)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4((long)((ulong)((Class65)class58_0).method_3()));
			return this;
		case 7:
			this.method_4(Convert.ToInt64(((Class61)class58_0).method_3()));
			return this;
		case 8:
			this.method_4((long)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((long)((ulong)((Class77)class58_0).method_3()));
			return this;
		case 13:
			this.method_4(((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((long)((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4((long)((ulong)Convert.ToByte(((Class72)class58_0).method_3())));
			return this;
		case 16:
			this.method_4((long)((ulong)((Class66)class58_0).method_3()));
			return this;
		case 17:
			this.method_4((long)((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToInt64(((Class73)class58_0).method_3()));
			return this;
		case 20:
			this.method_4((long)((ulong)((Class60)class58_0).method_3()));
			return this;
		case 22:
			this.method_4((long)((Class67)class58_0).method_3());
			return this;
		case 26:
			this.method_4((long)((Class76)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x04000099 RID: 153
	private long long_0;
}
