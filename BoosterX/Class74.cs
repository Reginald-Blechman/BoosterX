using System;

// Token: 0x02000086 RID: 134
internal sealed class Class74 : Class58
{
	// Token: 0x0600045A RID: 1114 RVA: 0x00005090 File Offset: 0x00003290
	public Class74() : base(14)
	{
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x0000509A File Offset: 0x0000329A
	public ulong method_3()
	{
		return this.ulong_0;
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x000050A2 File Offset: 0x000032A2
	public void method_4(ulong ulong_1)
	{
		this.ulong_0 = ulong_1;
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x000050AB File Offset: 0x000032AB
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00036490 File Offset: 0x00034690
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((ulong)((long)((short)object_0)));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((ulong)((long)((int)object_0)));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((ulong)((long)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((ulong)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((ulong)((double)object_0));
			return;
		}
		this.method_4(Convert.ToUInt64(object_0));
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x000050B8 File Offset: 0x000032B8
	public override Class58 vmethod_3()
	{
		Class74 @class = new Class74();
		@class.method_4(this.ulong_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00036518 File Offset: 0x00034718
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((ulong)((long)((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4((ulong)((long)((Class64)class58_0).method_3()));
			return this;
		case 3:
			this.method_4((ulong)((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4(Convert.ToUInt64(((Class61)class58_0).method_3()));
			return this;
		case 8:
			this.method_4((ulong)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((ulong)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((ulong)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4(((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4((ulong)Convert.ToByte(((Class72)class58_0).method_3()));
			return this;
		case 16:
			this.method_4((ulong)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((ulong)((long)((Class68)class58_0).method_3()));
			return this;
		case 19:
			this.method_4(Convert.ToUInt64(((Class73)class58_0).method_3()));
			return this;
		case 20:
			this.method_4((ulong)((Class60)class58_0).method_3());
			return this;
		case 22:
			this.method_4((ulong)((Class67)class58_0).method_3());
			return this;
		case 26:
			this.method_4((ulong)((long)((Class76)class58_0).method_3()));
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040002B6 RID: 694
	private ulong ulong_0;
}
