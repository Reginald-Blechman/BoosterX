using System;

// Token: 0x02000090 RID: 144
internal sealed class Class76 : Class58
{
	// Token: 0x0600048C RID: 1164 RVA: 0x0000522B File Offset: 0x0000342B
	public Class76() : base(26)
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00005235 File Offset: 0x00003435
	public short method_3()
	{
		return this.short_0;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x0000523D File Offset: 0x0000343D
	public void method_4(short short_1)
	{
		this.short_0 = short_1;
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00005246 File Offset: 0x00003446
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00036CF8 File Offset: 0x00034EF8
	public override void vmethod_1(object object_0)
	{
		if (object_0 is int)
		{
			this.method_4((short)((int)object_0));
			return;
		}
		if (object_0 is long)
		{
			this.method_4((short)((long)object_0));
			return;
		}
		if (object_0 is ushort)
		{
			this.method_4((short)((ushort)object_0));
			return;
		}
		if (object_0 is uint)
		{
			this.method_4((short)((uint)object_0));
			return;
		}
		if (object_0 is ulong)
		{
			this.method_4((short)((ulong)object_0));
			return;
		}
		if (object_0 is float)
		{
			this.method_4((short)((float)object_0));
			return;
		}
		if (object_0 is double)
		{
			this.method_4((short)((double)object_0));
			return;
		}
		this.method_4(Convert.ToInt16(object_0));
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00005253 File Offset: 0x00003453
	public override Class58 vmethod_3()
	{
		Class76 @class = new Class76();
		@class.method_4(this.short_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00036DAC File Offset: 0x00034FAC
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((short)((int)((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4((short)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4((short)((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4(Convert.ToInt16(((Class61)class58_0).method_3()));
			return this;
		case 8:
			this.method_4((short)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((short)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((short)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((short)((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4((short)Convert.ToByte(((Class72)class58_0).method_3()));
			return this;
		case 16:
			this.method_4((short)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((short)((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToInt16(((Class73)class58_0).method_3()));
			return this;
		case 22:
			this.method_4((short)((Class67)class58_0).method_3());
			return this;
		case 26:
			this.method_4(((Class76)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040002C1 RID: 705
	private short short_0;
}
