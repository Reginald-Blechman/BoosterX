using System;

// Token: 0x02000073 RID: 115
internal sealed class Class72 : Class58
{
	// Token: 0x060003DD RID: 989 RVA: 0x00004C12 File Offset: 0x00002E12
	public Class72() : base(15)
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00004C1C File Offset: 0x00002E1C
	public bool method_3()
	{
		return this.bool_0;
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00004C24 File Offset: 0x00002E24
	public void method_4(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00004C2D File Offset: 0x00002E2D
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00004C3A File Offset: 0x00002E3A
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToBoolean(object_0));
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00034724 File Offset: 0x00032924
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		switch (num)
		{
		case 0:
			this.method_4(Convert.ToBoolean(((Class75)class58_0).method_3()));
			return this;
		case 1:
			this.method_4(Convert.ToBoolean(((Class64)class58_0).method_3()));
			return this;
		case 2:
		case 4:
		case 5:
		case 6:
		case 8:
		case 9:
		case 10:
		case 11:
		case 18:
			break;
		case 3:
			this.method_4(Convert.ToBoolean(((Class65)class58_0).method_3()));
			return this;
		case 7:
			this.method_4(Convert.ToBoolean(((Class61)class58_0).method_3()));
			return this;
		case 12:
			this.method_4(Convert.ToBoolean(((Class77)class58_0).method_3()));
			return this;
		case 13:
			this.method_4(Convert.ToBoolean(((Class69)class58_0).method_3()));
			return this;
		case 14:
			this.method_4(Convert.ToBoolean(((Class74)class58_0).method_3()));
			return this;
		case 15:
			this.method_4(((Class72)class58_0).method_3());
			return this;
		case 16:
			this.method_4(Convert.ToBoolean(((Class66)class58_0).method_3()));
			return this;
		case 17:
			this.method_4(Convert.ToBoolean(((Class68)class58_0).method_3()));
			return this;
		case 19:
			this.method_4(Convert.ToBoolean(((Class73)class58_0).method_3()));
			return this;
		case 20:
			this.method_4(Convert.ToBoolean(((Class60)class58_0).method_3()));
			return this;
		default:
			if (num == 26)
			{
				this.method_4(Convert.ToBoolean(((Class76)class58_0).method_3()));
				return this;
			}
			break;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00004C48 File Offset: 0x00002E48
	public override Class58 vmethod_3()
	{
		Class72 @class = new Class72();
		@class.method_4(this.bool_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x04000289 RID: 649
	private bool bool_0;
}
