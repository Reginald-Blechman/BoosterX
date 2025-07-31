using System;

// Token: 0x02000044 RID: 68
internal sealed class Class68 : Class58
{
	// Token: 0x060001A9 RID: 425 RVA: 0x00003ECB File Offset: 0x000020CB
	public Class68() : base(17)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00003ED5 File Offset: 0x000020D5
	public sbyte method_3()
	{
		return this.sbyte_0;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00003EDD File Offset: 0x000020DD
	public void method_4(sbyte sbyte_1)
	{
		this.sbyte_0 = sbyte_1;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00003EE6 File Offset: 0x000020E6
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060001AD RID: 429 RVA: 0x000269D0 File Offset: 0x00024BD0
	public override void vmethod_1(object object_0)
	{
		if (object_0 is byte)
		{
			this.method_4((sbyte)((byte)object_0));
			return;
		}
		if (object_0 is short)
		{
			this.method_4((sbyte)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((sbyte)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((sbyte)((long)object_0));
			return;
		}
		if (object_0 is ushort)
		{
			this.method_4((sbyte)((ushort)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((sbyte)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((sbyte)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((sbyte)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((sbyte)((double)object_0));
			return;
		}
		this.method_4(Convert.ToSByte(object_0));
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00003EF3 File Offset: 0x000020F3
	public override Class58 vmethod_3()
	{
		Class68 @class = new Class68();
		@class.method_4(this.sbyte_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00026AB0 File Offset: 0x00024CB0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((sbyte)((int)((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4((sbyte)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4((sbyte)((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4(Convert.ToSByte(((Class61)class58_0).method_3()));
			return this;
		case 8:
			this.method_4((sbyte)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((sbyte)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((sbyte)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((sbyte)((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4(Convert.ToSByte(((Class72)class58_0).method_3()));
			return this;
		case 16:
			this.method_4((sbyte)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4(((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToSByte(((Class73)class58_0).method_3()));
			return this;
		case 22:
			this.method_4((sbyte)((Class67)class58_0).method_3());
			return this;
		case 26:
			this.method_4((sbyte)((Class76)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x04000098 RID: 152
	private sbyte sbyte_0;
}
