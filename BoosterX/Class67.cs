using System;

// Token: 0x02000042 RID: 66
internal sealed class Class67 : Class58
{
	// Token: 0x06000191 RID: 401 RVA: 0x00003E31 File Offset: 0x00002031
	public Class67() : base(22)
	{
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00003E3B File Offset: 0x0000203B
	public float method_3()
	{
		return this.float_0;
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00003E43 File Offset: 0x00002043
	public void method_4(float float_1)
	{
		this.float_0 = float_1;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00003E4C File Offset: 0x0000204C
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00003E59 File Offset: 0x00002059
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToSingle(object_0));
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00003E67 File Offset: 0x00002067
	public override Class58 vmethod_3()
	{
		Class67 @class = new Class67();
		@class.method_4(this.float_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x000262C0 File Offset: 0x000244C0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		switch (num)
		{
		case 1:
			this.method_4((float)((Class64)class58_0).method_3());
			return this;
		case 2:
		case 4:
		case 5:
		case 6:
		case 9:
		case 10:
		case 11:
		case 15:
		case 18:
			break;
		case 3:
			this.method_4(((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4((float)((Class61)class58_0).method_3());
			return this;
		case 8:
			this.method_4((float)((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((float)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((float)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4(((Class74)class58_0).method_3());
			return this;
		case 16:
			this.method_4((float)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((float)((Class68)class58_0).method_3());
			return this;
		case 19:
			this.method_4(Convert.ToSingle(((Class73)class58_0).method_3()));
			return this;
		default:
			if (num == 22)
			{
				this.method_4(((Class67)class58_0).method_3());
				return this;
			}
			if (num == 26)
			{
				this.method_4((float)((Class76)class58_0).method_3());
				return this;
			}
			break;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x0400008D RID: 141
	private float float_0;
}
