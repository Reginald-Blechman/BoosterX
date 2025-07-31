using System;

// Token: 0x02000082 RID: 130
internal sealed class Class73 : Class58
{
	// Token: 0x06000447 RID: 1095 RVA: 0x00004FC0 File Offset: 0x000031C0
	public Class73() : base(19)
	{
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00004FCA File Offset: 0x000031CA
	public Class73(Enum enum_1) : this()
	{
		this.enum_0 = (enum_1 ?? Class73.Enum1.Value);
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00004FE3 File Offset: 0x000031E3
	public Enum method_3()
	{
		return this.enum_0;
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00004FEB File Offset: 0x000031EB
	public void method_4(Enum enum_1)
	{
		if (enum_1 == null)
		{
			throw new ArgumentException();
		}
		this.enum_0 = enum_1;
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00004FFD File Offset: 0x000031FD
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00005005 File Offset: 0x00003205
	public override void vmethod_1(object object_0)
	{
		this.method_4((Enum)Enum.Parse(this.method_3().GetType(), object_0.ToString()));
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00035FF4 File Offset: 0x000341F4
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		int num = class58_0.method_0();
		if (num <= 3)
		{
			if (num == 1)
			{
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class64)class58_0).method_3()));
				return this;
			}
			if (num == 3)
			{
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class65)class58_0).method_3()));
				return this;
			}
		}
		else
		{
			switch (num)
			{
			case 7:
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class61)class58_0).method_3()));
				return this;
			case 8:
			case 9:
			case 10:
			case 11:
			case 15:
			case 18:
				break;
			case 12:
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class77)class58_0).method_3()));
				return this;
			case 13:
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class69)class58_0).method_3()));
				return this;
			case 14:
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class74)class58_0).method_3()));
				return this;
			case 16:
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class66)class58_0).method_3()));
				return this;
			case 17:
				this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class68)class58_0).method_3()));
				return this;
			case 19:
			{
				Type type = this.enum_0.GetType();
				Enum @enum = ((Class73)class58_0).method_3();
				if (@enum.GetType() == type)
				{
					this.method_4(@enum);
					return this;
				}
				this.method_4((Enum)Enum.ToObject(type, @enum));
				return this;
			}
			default:
				if (num == 26)
				{
					this.method_4((Enum)Enum.ToObject(this.enum_0.GetType(), ((Class76)class58_0).method_3()));
					return this;
				}
				break;
			}
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00005028 File Offset: 0x00003228
	public override Class58 vmethod_3()
	{
		Class73 @class = new Class73(this.enum_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x040002B0 RID: 688
	private Enum enum_0;

	// Token: 0x02000083 RID: 131
	private enum Enum1
	{
		// Token: 0x040002B2 RID: 690
		Value
	}
}
