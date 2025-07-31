using System;

// Token: 0x02000020 RID: 32
internal sealed class Class62 : Class58
{
	// Token: 0x060000BD RID: 189 RVA: 0x0000367B File Offset: 0x0000187B
	public Class62() : base(6)
	{
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00003684 File Offset: 0x00001884
	public char method_3()
	{
		return this.char_0;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0000368C File Offset: 0x0000188C
	public void method_4(char char_1)
	{
		this.char_0 = char_1;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003695 File Offset: 0x00001895
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x000036A2 File Offset: 0x000018A2
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToChar(object_0));
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x000233B0 File Offset: 0x000215B0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		switch (class58_0.method_0())
		{
		case 0:
			this.method_4((char)((int)((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4((char)((Class64)class58_0).method_3());
			return this;
		case 3:
			this.method_4((char)((Class65)class58_0).method_3());
			return this;
		case 6:
			this.method_4(((Class62)class58_0).method_3());
			return this;
		case 7:
			this.method_4(Convert.ToChar(((Class61)class58_0).method_3()));
			return this;
		case 12:
			this.method_4((char)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((char)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4((char)((Class74)class58_0).method_3());
			return this;
		case 15:
			this.method_4(Convert.ToChar(((Class72)class58_0).method_3()));
			return this;
		case 16:
			this.method_4((char)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((char)((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToChar(((Class73)class58_0).method_3()));
			return this;
		case 20:
			this.method_4((char)((uint)((Class60)class58_0).method_3()));
			return this;
		case 26:
			this.method_4((char)((Class76)class58_0).method_3());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x000036B0 File Offset: 0x000018B0
	public override Class58 vmethod_3()
	{
		Class62 @class = new Class62();
		@class.method_4(this.char_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0400003C RID: 60
	private char char_0;
}
