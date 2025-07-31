using System;

// Token: 0x02000027 RID: 39
internal sealed class Class64 : Class58
{
	// Token: 0x060000E2 RID: 226 RVA: 0x00003815 File Offset: 0x00001A15
	public Class64() : base(1)
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000381E File Offset: 0x00001A1E
	public Class64(int int_2) : this()
	{
		this.int_1 = int_2;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000382D File Offset: 0x00001A2D
	public int method_3()
	{
		return this.int_1;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00003835 File Offset: 0x00001A35
	public void method_4(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x0000383E File Offset: 0x00001A3E
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0002488C File Offset: 0x00022A8C
	public override void vmethod_1(object object_0)
	{
		int int_;
		if (object_0 is ushort)
		{
			ushort num = (ushort)object_0;
			int_ = (int)num;
		}
		else if (object_0 is uint)
		{
			uint num2 = (uint)object_0;
			int_ = (int)num2;
		}
		else if (object_0 is long)
		{
			long num3 = (long)object_0;
			int_ = (int)num3;
		}
		else if (object_0 is ulong)
		{
			ulong num4 = (ulong)object_0;
			int_ = (int)num4;
		}
		else if (object_0 is float)
		{
			float num5 = (float)object_0;
			int_ = (int)num5;
		}
		else if (object_0 is double)
		{
			double num6 = (double)object_0;
			int_ = (int)num6;
		}
		else
		{
			int_ = Convert.ToInt32(object_0);
		}
		this.method_4(int_);
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0000384B File Offset: 0x00001A4B
	public override Class58 vmethod_3()
	{
		Class64 @class = new Class64();
		@class.method_4(this.int_1);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00024924 File Offset: 0x00022B24
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int int_;
		switch (class58_0.method_0())
		{
		case 0:
			int_ = (int)((Class75)class58_0).method_3();
			goto IL_196;
		case 1:
			int_ = ((Class64)class58_0).method_3();
			goto IL_196;
		case 3:
			int_ = (int)((Class65)class58_0).method_3();
			goto IL_196;
		case 7:
			int_ = Convert.ToInt32(((Class61)class58_0).method_3());
			goto IL_196;
		case 8:
			int_ = (int)((Class70)class58_0).method_3();
			goto IL_196;
		case 12:
			int_ = (int)((Class77)class58_0).method_3();
			goto IL_196;
		case 13:
			int_ = Convert.ToInt32(((Class69)class58_0).method_3());
			goto IL_196;
		case 14:
			int_ = (int)((Class74)class58_0).method_3();
			goto IL_196;
		case 15:
			int_ = (int)Convert.ToByte(((Class72)class58_0).method_3());
			goto IL_196;
		case 16:
			int_ = (int)((Class66)class58_0).method_3();
			goto IL_196;
		case 17:
			int_ = (int)((Class68)class58_0).method_3();
			goto IL_196;
		case 19:
			int_ = Convert.ToInt32(((Class73)class58_0).method_3());
			goto IL_196;
		case 20:
			int_ = (int)((uint)((Class60)class58_0).method_3());
			goto IL_196;
		case 22:
			int_ = (int)((Class67)class58_0).method_3();
			goto IL_196;
		case 26:
			int_ = (int)((Class76)class58_0).method_3();
			goto IL_196;
		}
		throw new ArgumentOutOfRangeException();
		IL_196:
		this.method_4(int_);
		return this;
	}

	// Token: 0x0400004D RID: 77
	private int int_1;
}
