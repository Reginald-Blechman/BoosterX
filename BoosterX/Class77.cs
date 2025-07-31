using System;

// Token: 0x0200009F RID: 159
internal sealed class Class77 : Class58
{
	// Token: 0x06000508 RID: 1288 RVA: 0x000055CB File Offset: 0x000037CB
	public Class77() : base(12)
	{
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x000055D5 File Offset: 0x000037D5
	public byte method_3()
	{
		return this.byte_0;
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x000055DD File Offset: 0x000037DD
	public void method_4(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x000055E6 File Offset: 0x000037E6
	public override Class58 vmethod_3()
	{
		Class77 @class = new Class77();
		@class.method_4(this.byte_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00005605 File Offset: 0x00003805
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x000378D4 File Offset: 0x00035AD4
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			this.method_4((byte)((short)object_0));
			return;
		}
		if (object_0 is int)
		{
			this.method_4((byte)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((byte)((long)object_0));
			return;
		}
		if (object_0 is ushort)
		{
			this.method_4((byte)((ushort)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((byte)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((byte)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((byte)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((byte)((double)object_0));
			return;
		}
		this.method_4(Convert.ToByte(object_0));
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x000379A0 File Offset: 0x00035BA0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((byte)((int)((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4((byte)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4((byte)((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4(Convert.ToByte(((Class61)class58_0).method_3()));
			return this;
		case 8:
			this.method_4((byte)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4(((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((byte)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((byte)((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4(Convert.ToByte(((Class72)class58_0).method_3()));
			return this;
		case 16:
			this.method_4((byte)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((byte)((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToByte(((Class73)class58_0).method_3()));
			return this;
		case 20:
			this.method_4((byte)((uint)((Class60)class58_0).method_3()));
			return this;
		case 22:
			this.method_4((byte)((Class67)class58_0).method_3());
			return this;
		case 26:
			this.method_4((byte)((Class76)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040002DE RID: 734
	private byte byte_0;
}
