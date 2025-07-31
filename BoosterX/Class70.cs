using System;

// Token: 0x02000046 RID: 70
internal sealed class Class70 : Class58
{
	// Token: 0x060001B8 RID: 440 RVA: 0x00003F68 File Offset: 0x00002168
	public Class70() : base(8)
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00003F71 File Offset: 0x00002171
	public double method_3()
	{
		return this.double_0;
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00003F79 File Offset: 0x00002179
	public void method_4(double double_1)
	{
		this.double_0 = double_1;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00003F82 File Offset: 0x00002182
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00003F8F File Offset: 0x0000218F
	public override void vmethod_1(object object_0)
	{
		this.method_4(Convert.ToDouble(object_0));
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00003F9D File Offset: 0x0000219D
	public override Class58 vmethod_3()
	{
		Class70 @class = new Class70();
		@class.method_4(this.double_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00026EE0 File Offset: 0x000250E0
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		switch (num)
		{
		case 1:
			this.method_4((double)((Class64)class58_0).method_3());
			return this;
		case 2:
		case 4:
		case 5:
		case 6:
		case 9:
		case 10:
		case 11:
		case 15:
			break;
		case 3:
			this.method_4(((Class65)class58_0).method_3());
			return this;
		case 7:
			this.method_4((double)((Class61)class58_0).method_3());
			return this;
		case 8:
			this.method_4(((Class70)class58_0).method_3());
			return this;
		case 12:
			this.method_4((double)((Class77)class58_0).method_3());
			return this;
		case 13:
			this.method_4((double)((Class69)class58_0).method_3());
			return this;
		case 14:
			this.method_4(((Class74)class58_0).method_3());
			return this;
		case 16:
			this.method_4((double)((Class66)class58_0).method_3());
			return this;
		case 17:
			this.method_4((double)((Class68)class58_0).method_3());
			return this;
		default:
			if (num == 22)
			{
				this.method_4((double)((Class67)class58_0).method_3());
				return this;
			}
			if (num == 26)
			{
				this.method_4((double)((Class76)class58_0).method_3());
				return this;
			}
			break;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x0400009A RID: 154
	private double double_0;
}
