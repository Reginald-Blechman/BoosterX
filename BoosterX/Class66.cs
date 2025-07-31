using System;

// Token: 0x02000039 RID: 57
internal sealed class Class66 : Class58
{
	// Token: 0x06000153 RID: 339 RVA: 0x00003BE7 File Offset: 0x00001DE7
	public Class66() : base(16)
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00003BF1 File Offset: 0x00001DF1
	public ushort method_3()
	{
		return this.ushort_0;
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00003BF9 File Offset: 0x00001DF9
	public void method_4(ushort ushort_1)
	{
		this.ushort_0 = ushort_1;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00003C02 File Offset: 0x00001E02
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000255A0 File Offset: 0x000237A0
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((ushort)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((ushort)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((ushort)((long)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((ushort)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((ushort)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((ushort)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((ushort)((double)object_0));
			return;
		}
		this.method_4(Convert.ToUInt16(object_0));
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00003C0F File Offset: 0x00001E0F
	public override Class58 vmethod_3()
	{
		Class66 @class = new Class66();
		@class.method_4(this.ushort_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00025654 File Offset: 0x00023854
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((ushort)((int)((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4((ushort)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4((ushort)((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4(Convert.ToUInt16(((Class61)class58_0).method_3()));
			return this;
		case 8:
			this.method_4((ushort)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((ushort)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((ushort)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((ushort)((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4((ushort)Convert.ToByte(((Class72)class58_0).method_3()));
			return this;
		case 16:
			this.method_4(((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((ushort)((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToUInt16(((Class73)class58_0).method_3()));
			return this;
		case 20:
			this.method_4((ushort)((uint)((Class60)class58_0).method_3()));
			return this;
		case 22:
			this.method_4((ushort)((Class67)class58_0).method_3());
			return this;
		case 26:
			this.method_4((ushort)((Class76)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x04000078 RID: 120
	private ushort ushort_0;
}
