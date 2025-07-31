using System;

// Token: 0x02000084 RID: 132
internal abstract class Class58
{
	// Token: 0x0600044F RID: 1103 RVA: 0x00005041 File Offset: 0x00003241
	protected Class58(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06000450 RID: 1104
	public abstract object vmethod_0();

	// Token: 0x06000451 RID: 1105
	public abstract void vmethod_1(object object_0);

	// Token: 0x06000452 RID: 1106 RVA: 0x00005050 File Offset: 0x00003250
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06000453 RID: 1107
	public abstract Class58 vmethod_2(Class58 class58_0);

	// Token: 0x06000454 RID: 1108
	public abstract Class58 vmethod_3();

	// Token: 0x06000455 RID: 1109 RVA: 0x00005058 File Offset: 0x00003258
	public Type method_1()
	{
		return this.type_0;
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00005060 File Offset: 0x00003260
	public void method_2(Type type_1)
	{
		this.type_0 = type_1;
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00036230 File Offset: 0x00034430
	public static Class58 smethod_0(object object_0, Type type_1)
	{
		Class58 @class = object_0 as Class58;
		if (@class != null)
		{
			return @class;
		}
		if (type_1 == null)
		{
			if (object_0 == null)
			{
				return new Class61();
			}
			type_1 = object_0.GetType();
		}
		type_1 = Class29.smethod_2(type_1);
		switch (Class29.smethod_6(type_1))
		{
		case 0:
			@class = new Class75();
			goto IL_236;
		case 1:
			@class = new Class64();
			goto IL_236;
		case 3:
			@class = new Class65();
			goto IL_236;
		case 5:
		{
			Class61 class2 = new Class61();
			class2.method_2(type_1);
			@class = class2;
			goto IL_236;
		}
		case 6:
			@class = new Class62();
			goto IL_236;
		case 7:
			@class = new Class61();
			if (object_0 != null && object_0.GetType() != Class29.type_0)
			{
				@class.method_2(object_0.GetType());
				goto IL_236;
			}
			goto IL_236;
		case 8:
			@class = new Class70();
			goto IL_236;
		case 9:
			@class = new Class78();
			goto IL_236;
		case 10:
			@class = new Class71();
			goto IL_236;
		case 12:
			@class = new Class77();
			goto IL_236;
		case 13:
			@class = new Class69();
			goto IL_236;
		case 14:
			@class = new Class74();
			goto IL_236;
		case 15:
			@class = new Class72();
			goto IL_236;
		case 16:
			@class = new Class66();
			goto IL_236;
		case 17:
			@class = new Class68();
			goto IL_236;
		case 19:
		{
			Enum enum_;
			if (object_0 == null)
			{
				if (type_1.IsNested && type_1.DeclaringType.ContainsGenericParameters)
				{
					enum_ = (Enum)Enum.Parse(type_1, "0");
				}
				else
				{
					enum_ = (Enum)Activator.CreateInstance(type_1);
				}
			}
			else
			{
				enum_ = (Enum)Enum.ToObject(type_1, object_0);
			}
			return new Class73(enum_);
		}
		case 20:
			@class = new Class60();
			goto IL_236;
		case 22:
			@class = new Class67();
			goto IL_236;
		case 25:
			if (object_0 == null)
			{
				if (type_1 != Class29.type_4)
				{
					object_0 = Activator.CreateInstance(type_1);
				}
			}
			else if (object_0.GetType() != type_1)
			{
				try
				{
					object_0 = Convert.ChangeType(object_0, type_1);
				}
				catch
				{
				}
			}
			return new Class63(object_0);
		case 26:
			@class = new Class76();
			goto IL_236;
		}
		@class = new Class61();
		IL_236:
		if (object_0 != null)
		{
			@class.vmethod_1(object_0);
		}
		return @class;
	}

	// Token: 0x040002B3 RID: 691
	private readonly int int_0;

	// Token: 0x040002B4 RID: 692
	private Type type_0;
}
