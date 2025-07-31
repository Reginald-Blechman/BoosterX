using System;

// Token: 0x02000032 RID: 50
internal sealed class Class65 : Class58
{
	// Token: 0x0600011E RID: 286 RVA: 0x00003A1E File Offset: 0x00001C1E
	public Class65() : base(3)
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00003A27 File Offset: 0x00001C27
	public uint method_3()
	{
		return this.uint_0;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00003A2F File Offset: 0x00001C2F
	public void method_4(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00003A38 File Offset: 0x00001C38
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00024DE8 File Offset: 0x00022FE8
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((uint)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((uint)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((uint)((long)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((uint)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((uint)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((uint)((double)object_0));
			return;
		}
		this.method_4(Convert.ToUInt32(object_0));
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00003A45 File Offset: 0x00001C45
	public override Class58 vmethod_3()
	{
		Class65 @class = new Class65();
		@class.method_4(this.uint_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00024E84 File Offset: 0x00023084
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((uint)((int)((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4((uint)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4(((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4(Convert.ToUInt32(((Class61)class58_0).method_3()));
			return this;
		case 8:
			this.method_4((uint)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((uint)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((uint)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((uint)((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4((uint)Convert.ToByte(((Class72)class58_0).method_3()));
			return this;
		case 16:
			this.method_4((uint)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((uint)((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToUInt32(((Class73)class58_0).method_3()));
			return this;
		case 20:
			this.method_4((uint)((Class60)class58_0).method_3());
			return this;
		case 22:
			this.method_4((uint)((Class67)class58_0).method_3());
			return this;
		case 26:
			this.method_4((uint)((Class76)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x04000063 RID: 99
	private uint uint_0;
}
