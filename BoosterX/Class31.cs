using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Threading;

// Token: 0x0200004A RID: 74
internal sealed class Class31
{
	// Token: 0x060001E2 RID: 482 RVA: 0x0000412F File Offset: 0x0000232F
	public Class31(Class41 class41_1, Module module_1)
	{
		this.stack_1 = new Stack<Class58>(16);
		base..ctor();
		this.class41_0 = class41_1;
		this.module_0 = module_1;
		this.method_21();
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00004163 File Offset: 0x00002363
	public Class31(Class41 class41_1) : this(class41_1, typeof(Class31).Module)
	{
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00027308 File Offset: 0x00025508
	// Note: this type is marked as 'beforefieldinit'.
	static Class31()
	{
		Class31.dictionary_3 = new Dictionary<int, object>();
		Class31.type_4 = typeof(Class31.Class40);
		Class31.type_8 = typeof(void);
		Class31.type_0 = typeof(object[]);
		Class31.type_2 = typeof(IntPtr);
		Class31.type_9 = typeof(Assembly);
		Class31.type_5 = typeof(MethodBase);
		Class31.type_3 = typeof(RuntimeHelpers);
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000417B File Offset: 0x0000237B
	private static void smethod_0(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(7);
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00004184 File Offset: 0x00002384
	private static void smethod_1(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_13((int)((Class66)class58_4).method_3());
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x000273BC File Offset: 0x000255BC
	[Attribute5(2)]
	private bool method_0([Attribute7(1)] MethodBase methodBase_0, object object_3, ref object object_4, [Attribute7(new byte[]
	{
		1,
		2
	})] object[] object_5)
	{
		if (!methodBase_0.IsStatic && object_3 != null && methodBase_0.Name.Equals("Address", StringComparison.Ordinal))
		{
			MethodInfo methodInfo = methodBase_0 as MethodInfo;
			if (methodInfo != null)
			{
				Type type = methodInfo.ReturnType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					int num = object_5.Length;
					if (num >= 1 && object_5[0] is int)
					{
						int[] array = new int[num];
						for (int i = 0; i < num; i++)
						{
							array[i] = (int)object_5[i];
						}
						Class84 @class = new Class84();
						@class.method_6((Array)object_3);
						@class.method_8(array);
						@class.method_4(type);
						object_4 = @class;
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00027468 File Offset: 0x00025668
	private static void smethod_2(Class31 class31_0, Class58 class58_4)
	{
		uint uint_ = ((Class65)class58_4).method_3();
		class31_0.method_89(null, uint_);
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0002748C File Offset: 0x0002568C
	private Class13 method_1(Class8 class8_2)
	{
		switch (class8_2.method_6())
		{
		case 0:
		{
			Class17 @class = new Class17();
			Class17 class2 = @class;
			Class103 class3 = new Class103();
			class3.method_1(1);
			class3.method_3(class8_2.method_19());
			class2.method_5(class3);
			@class.method_1(class8_2.method_6());
			@class.method_7(class8_2.method_9());
			Class17 class4 = @class;
			Class103 class5 = new Class103();
			class5.method_1(1);
			class5.method_3(class8_2.method_19());
			class4.method_13(class5);
			int num = class8_2.method_18();
			Class103[] array = new Class103[num];
			for (int i = 0; i < num; i++)
			{
				Class103[] array2 = array;
				int num2 = i;
				Class103 class6 = new Class103();
				class6.method_1(1);
				class6.method_3(class8_2.method_19());
				array2[num2] = class6;
			}
			@class.method_9(array);
			int num3 = class8_2.method_18();
			Class103[] array3 = new Class103[num3];
			for (int j = 0; j < num3; j++)
			{
				Class103[] array4 = array3;
				int num4 = j;
				Class103 class7 = new Class103();
				class7.method_1(1);
				class7.method_3(class8_2.method_19());
				array4[num4] = class7;
			}
			@class.method_11(array3);
			return @class;
		}
		case 1:
		{
			Class15 class8 = new Class15();
			Class103 class9 = new Class103();
			class9.method_1(1);
			class9.method_3(class8_2.method_19());
			class8.method_1(class9);
			class8.method_3(class8_2.method_9());
			class8.method_5(class8_2.method_5());
			return class8;
		}
		case 2:
		{
			Class14 class10 = new Class14();
			class10.method_1(class8_2.method_9());
			class10.method_5(class8_2.method_5());
			class10.method_3(class8_2.method_5());
			class10.method_11(class8_2.method_19());
			class10.method_9(class8_2.method_19());
			Class14 class11 = class10;
			int num5 = class8_2.method_18();
			Class103[] array5 = new Class103[num5];
			for (int k = 0; k < num5; k++)
			{
				Class103[] array6 = array5;
				int num6 = k;
				Class103 class12 = new Class103();
				class12.method_1(1);
				class12.method_3(class8_2.method_19());
				array6[num6] = class12;
			}
			class11.method_7(array5);
			return class11;
		}
		case 3:
		{
			Class16 class13 = new Class16();
			class13.method_1(class8_2.method_19());
			class13.method_3(class8_2.method_19());
			return class13;
		}
		case 4:
		{
			Class18 class14 = new Class18();
			class14.method_1(class8_2.method_9());
			return class14;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00027698 File Offset: 0x00025898
	private static void smethod_3(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (!Class31.smethod_21(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x060001EB RID: 491 RVA: 0x000276D0 File Offset: 0x000258D0
	private static void smethod_4(Class31 class31_0, Class58 class58_4)
	{
		MethodBase methodBase_ = ((Class59)class31_0.method_102()).method_3();
		class31_0.method_5(methodBase_, false);
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_5(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000419F File Offset: 0x0000239F
	private static void smethod_6(Class31 class31_0, Class58 class58_4)
	{
		Thread.MemoryBarrier();
	}

	// Token: 0x060001EE RID: 494 RVA: 0x000041A6 File Offset: 0x000023A6
	private static void smethod_7(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(6);
	}

	// Token: 0x060001EF RID: 495 RVA: 0x000276F8 File Offset: 0x000258F8
	private static void smethod_8(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		FieldInfo fieldInfo_ = class31_0.method_25(int_);
		class31_0.method_74(new Class81(fieldInfo_, null));
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00027728 File Offset: 0x00025928
	private static void smethod_9(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (!Class31.smethod_195(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x000041AF File Offset: 0x000023AF
	private void method_2()
	{
		this.method_44(false);
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00027760 File Offset: 0x00025960
	private static void smethod_10(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (Class31.smethod_64(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00027798 File Offset: 0x00025998
	private static void smethod_11(Class31 class31_0, Class58 class58_4)
	{
		Class77 @class = (Class77)class58_4;
		Class85 class2 = new Class85();
		class2.method_4(class31_0.class58_3[(int)@class.method_3()]);
		class31_0.method_74(class2);
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x000041B8 File Offset: 0x000023B8
	private void method_3()
	{
		this.class58_2 = null;
		this.class58_1 = null;
		this.stack_1.Clear();
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00003056 File Offset: 0x00001256
	private static bool smethod_12()
	{
		return false;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x000041D3 File Offset: 0x000023D3
	private static void smethod_13(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(-1);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x000277D0 File Offset: 0x000259D0
	private Class58 method_4(Class58 class58_4, Class58 class58_5)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				int num = ((Class64)class58_4).method_3();
				int num2 = ((Class64)class58_5).method_3();
				Class64 @class = new Class64();
				@class.method_4(num & num2);
				return @class;
			}
			if (class58_5.method_0() == 19)
			{
				int num3 = ((Class64)class58_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
				{
					int num4 = Convert.ToInt32(class58_5.vmethod_0());
					Class64 class2 = new Class64();
					class2.method_4(num3 & num4);
					return class2;
				}
				long num5 = Convert.ToInt64(class58_5.vmethod_0());
				return new Class69((long)num3 & num5);
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				long num6 = ((Class69)class58_4).method_3();
				long num7 = ((Class69)class58_5).method_3();
				Class69 class3 = new Class69();
				class3.method_4(num6 & num7);
				return class3;
			}
			if (class58_5.method_0() == 19)
			{
				long num8 = (long)((Class64)class58_4).method_3();
				long num9 = Convert.ToInt64(class58_5.vmethod_0());
				return new Class69(num8 & num9);
			}
		}
		if (class58_4.method_0() == 19)
		{
			if (class58_5.method_0() == 1)
			{
				int num10 = ((Class64)class58_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					int num11 = Convert.ToInt32(class58_4.vmethod_0());
					Class64 class4 = new Class64();
					class4.method_4(num11 & num10);
					return class4;
				}
				return new Class69(Convert.ToInt64(class58_5.vmethod_0()) & (long)num10);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					long num12 = Convert.ToInt64(class58_4.vmethod_0());
					long num13 = ((Class69)class58_5).method_3();
					Class69 class5 = new Class69();
					class5.method_4(num12 & num13);
					return class5;
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
					Type underlyingType4 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)) && !(underlyingType4 == typeof(long)) && !(underlyingType4 == typeof(ulong)))
					{
						int num14 = Convert.ToInt32(class58_4.vmethod_0());
						int num15 = Convert.ToInt32(class58_5.vmethod_0());
						return new Class64(num14 & num15);
					}
					long num16 = Convert.ToInt64(class58_4.vmethod_0());
					long num17 = Convert.ToInt64(class58_5.vmethod_0());
					return new Class69(num16 & num17);
				}
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x000041DC File Offset: 0x000023DC
	private static void smethod_14(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_39(false, false);
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x000041E6 File Offset: 0x000023E6
	private static void smethod_15(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(byte));
	}

	// Token: 0x060001FA RID: 506 RVA: 0x000041F8 File Offset: 0x000023F8
	private static void smethod_16(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_74(class58_4);
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00027A8C File Offset: 0x00025C8C
	private void method_5(MethodBase methodBase_0, bool bool_2)
	{
		bool flag;
		if ((flag = (!bool_2 && this.method_10(methodBase_0))) && Class31.Class34.bool_0)
		{
			methodBase_0 = Class31.Class39.smethod_0(this, this.class50_0, methodBase_0, bool_2);
		}
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		Class58[] array = new Class58[num];
		object[] array2 = new object[num];
		Class31.Struct11 @struct = default(Class31.Struct11);
		try
		{
			this.method_56(ref @struct, methodBase_0, bool_2);
			for (int i = num - 1; i >= 0; i--)
			{
				Class58 @class = this.method_102();
				array[i] = @class;
				Class79 class2 = @class as Class79;
				if (class2 != null)
				{
					@class = this.method_72(class2);
				}
				if (@class.method_1() != null)
				{
					@class = Class58.smethod_0(null, @class.method_1()).vmethod_2(@class);
				}
				Class58 class3 = Class58.smethod_0(null, parameters[i].ParameterType).vmethod_2(@class);
				array2[i] = class3.vmethod_0();
			}
			Class58 class4 = null;
			if (!methodBase_0.IsStatic)
			{
				class4 = this.method_102();
				if (class4 != null && class4.method_1() != null)
				{
					class4 = Class58.smethod_0(null, class4.method_1()).vmethod_2(class4);
				}
			}
			object obj = null;
			object obj2 = null;
			try
			{
				if (methodBase_0.IsConstructor)
				{
					obj = Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array2, null);
					if (!(class4 is Class79))
					{
						throw new InvalidOperationException();
					}
				}
				else
				{
					if (class4 != null)
					{
						Class58 class5 = class4;
						Class79 class6 = class4 as Class79;
						if (class6 != null)
						{
							class5 = this.method_72(class6);
						}
						obj2 = class5.vmethod_0();
					}
					try
					{
						if (!this.method_84(methodBase_0, obj2, ref obj, array2))
						{
							if (bool_2 && !methodBase_0.IsStatic && obj2 == null)
							{
								throw new NullReferenceException();
							}
							if (!this.method_20(methodBase_0, obj2, array, array2, bool_2, ref obj))
							{
								MethodBase methodBase_ = methodBase_0;
								object object_ = obj2;
								if (flag && !Class31.Class34.bool_0)
								{
									MethodInfo methodInfo;
									object_ = Class31.Class35.smethod_0(obj2, methodBase_0, out methodInfo);
									methodBase_ = methodInfo;
								}
								obj = Class31.smethod_81(methodBase_, object_, array2, bool_2);
							}
						}
						goto IL_26C;
					}
					catch (TargetInvocationException ex)
					{
						Exception object_2 = ex.InnerException ?? ex;
						this.method_101(object_2);
						goto IL_26C;
					}
				}
				obj2 = obj;
			}
			finally
			{
				for (int j = 0; j < array.Length; j++)
				{
					Class79 class7 = array[j] as Class79;
					if (class7 != null)
					{
						object obj3 = array2[j];
						this.method_27(class7, Class58.smethod_0(obj3, null));
					}
				}
				if (obj2 != null)
				{
					Class79 class8 = class4 as Class79;
					if (class8 != null)
					{
						bool flag2 = true;
						Class81 class9 = class8 as Class81;
						if (class9 != null)
						{
							flag2 = this.method_83(class9);
						}
						if (flag2)
						{
							this.method_27(class8, Class58.smethod_0(obj2, methodBase_0.DeclaringType));
						}
					}
				}
			}
			IL_26C:
			MethodInfo methodInfo2 = methodBase_0 as MethodInfo;
			if (methodInfo2 != null)
			{
				Type returnType = methodInfo2.ReturnType;
				if (returnType != Class31.type_8)
				{
					this.method_74(Class58.smethod_0(obj, returnType));
				}
			}
		}
		finally
		{
			this.method_77(ref @struct);
		}
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00027D94 File Offset: 0x00025F94
	private static void smethod_17(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		FieldInfo fieldInfo = class31_0.method_25(int_);
		Class58 @class = class31_0.method_102();
		Class79 class2 = @class as Class79;
		if (class2 != null)
		{
			@class = class31_0.method_72(class2);
		}
		object obj = @class.vmethod_0();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		class31_0.method_74(Class58.smethod_0(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00004201 File Offset: 0x00002401
	private static void smethod_18(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_30(2);
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00027DF8 File Offset: 0x00025FF8
	private static void smethod_19(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		float num2;
		if (num <= 8)
		{
			if (num == 1)
			{
				num2 = (float)((Class64)@class).method_3();
				goto IL_6C;
			}
			if (num == 8)
			{
				num2 = (float)((Class70)@class).method_3();
				goto IL_6C;
			}
		}
		else
		{
			if (num == 13)
			{
				num2 = (float)((Class69)@class).method_3();
				goto IL_6C;
			}
			if (num == 19)
			{
				num2 = Convert.ToUInt64(((Class73)@class).method_3());
				goto IL_6C;
			}
		}
		throw new InvalidOperationException();
		IL_6C:
		Class70 class2 = new Class70();
		class2.method_4((double)num2);
		class31_0.method_74(class2);
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00027E84 File Offset: 0x00026084
	private void method_6(bool bool_2, bool bool_3)
	{
		Class58 class58_ = this.method_102();
		Class58 class58_2 = this.method_102();
		this.method_74(Class31.smethod_233(class58_2, class58_, bool_2, bool_3));
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00027EB0 File Offset: 0x000260B0
	private static void smethod_20(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type_ = class31_0.method_70(int_, true);
		Class58 class58_5 = class31_0.method_102();
		if (class31_0.method_75(class58_5, type_))
		{
			class31_0.method_74(class58_5);
			return;
		}
		class31_0.method_74(new Class61());
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00027EF8 File Offset: 0x000260F8
	private static bool smethod_21(Class58 class58_4, Class58 class58_5)
	{
		bool result = false;
		int num = class58_4.method_0();
		if (num <= 8)
		{
			if (num != 1)
			{
				if (num == 8)
				{
					double num2 = ((Class70)class58_4).method_3();
					double num3 = ((Class70)class58_5).method_3();
					result = (num2 < num3 || double.IsNaN(num2) || double.IsNaN(num3));
				}
			}
			else
			{
				if (class58_5.method_0() == 19)
				{
					return Class31.smethod_21(class58_4, new Class64(Convert.ToInt32(((Class73)class58_5).method_3())));
				}
				result = (((Class64)class58_4).method_3() < ((Class64)class58_5).method_3());
			}
		}
		else if (num != 13)
		{
			if (num == 19)
			{
				return Class31.smethod_21(new Class69(Convert.ToInt64(((Class73)class58_4).method_3())), class58_5);
			}
		}
		else
		{
			if (class58_5.method_0() == 19)
			{
				return Class31.smethod_21(class58_4, new Class69(Convert.ToInt64(((Class73)class58_5).method_3())));
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_21(class58_4, new Class69((long)((Class64)class58_5).method_3()));
			}
			result = (((Class69)class58_4).method_3() < ((Class69)class58_5).method_3());
		}
		return result;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00028024 File Offset: 0x00026224
	private static bool smethod_22(Class58 class58_4, Class58 class58_5)
	{
		int num = class58_4.method_0();
		if (num <= 8)
		{
			if (num <= 1)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						return ((Class64)class58_4).method_3() > ((Class64)class58_5).method_3();
					}
				}
				else
				{
					if (class58_5.method_0() == 7 && class58_5.vmethod_0() == null)
					{
						return ((Class75)class58_4).method_3() != IntPtr.Zero;
					}
					return ((Class75)class58_4).method_3() != ((Class75)class58_5).method_3();
				}
			}
			else
			{
				if (num == 7)
				{
					return ((Class61)class58_4).method_3() != ((Class61)class58_5).method_3();
				}
				if (num == 8)
				{
					double num2 = ((Class70)class58_4).method_3();
					double num3 = ((Class70)class58_5).method_3();
					return num2 > num3 || double.IsNaN(num2) || double.IsNaN(num3);
				}
			}
		}
		else if (num <= 19)
		{
			if (num == 13)
			{
				return ((Class69)class58_4).method_3() > ((Class69)class58_5).method_3();
			}
			if (num == 19)
			{
				long num4 = Convert.ToInt64(((Class73)class58_4).method_3());
				long num5;
				if (class58_5.method_0() == 1)
				{
					num5 = (long)((Class64)class58_5).method_3();
				}
				else
				{
					num5 = Convert.ToInt64(((Class73)class58_5).method_3());
				}
				return num4 > num5;
			}
		}
		else if (num != 20)
		{
			if (num == 25)
			{
				return (class58_5.method_0() == 7 && class58_5.vmethod_0() == null) || ((Class63)class58_4).method_3() != ((Class63)class58_5).method_3();
			}
		}
		else
		{
			if (class58_5.method_0() == 7 && class58_5.vmethod_0() == null)
			{
				return ((Class60)class58_4).method_3() != UIntPtr.Zero;
			}
			return ((Class60)class58_4).method_3() != ((Class60)class58_5).method_3();
		}
		return class58_4.vmethod_0() != class58_5.vmethod_0();
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000420A File Offset: 0x0000240A
	private static void smethod_23(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_46(true);
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00004213 File Offset: 0x00002413
	private static void smethod_24(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_107(true);
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00028228 File Offset: 0x00026428
	private static void smethod_25(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type t = class31_0.method_70(int_, true);
		class31_0.method_74(new Class64(Marshal.SizeOf(t)));
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0002825C File Offset: 0x0002645C
	private void method_7(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		ushort int_;
		if (num <= 8)
		{
			if (num != 0)
			{
				if (num != 1)
				{
					if (num == 8)
					{
						if (bool_2)
						{
							int_ = checked((ushort)((Class70)@class).method_3());
							goto IL_1A3;
						}
						int_ = (ushort)((Class70)@class).method_3();
						goto IL_1A3;
					}
				}
				else
				{
					if (bool_2)
					{
						int_ = checked((ushort)((uint)((Class64)@class).method_3()));
						goto IL_1A3;
					}
					int_ = (ushort)((Class64)@class).method_3();
					goto IL_1A3;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((ushort)((int)((Class75)@class).method_3()));
					goto IL_1A3;
				}
				int_ = (ushort)((int)((Class75)@class).method_3());
				goto IL_1A3;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((ushort)((ulong)((long)((Class75)@class).method_3())));
					goto IL_1A3;
				}
				int_ = (ushort)((long)((Class75)@class).method_3());
				goto IL_1A3;
			}
		}
		else if (num != 13)
		{
			if (num != 19)
			{
				if (num == 20)
				{
					if (UIntPtr.Size == 4)
					{
						if (bool_2)
						{
							int_ = checked((ushort)((uint)((Class60)@class).method_3()));
							goto IL_1A3;
						}
						int_ = (ushort)((uint)((Class60)@class).method_3());
						goto IL_1A3;
					}
					else
					{
						if (bool_2)
						{
							int_ = checked((ushort)((ulong)((Class60)@class).method_3()));
							goto IL_1A3;
						}
						int_ = (ushort)((ulong)((Class60)@class).method_3());
						goto IL_1A3;
					}
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((ushort)Convert.ToUInt64(((Class73)@class).method_3()));
					goto IL_1A3;
				}
				int_ = (ushort)Convert.ToUInt64(((Class73)@class).method_3());
				goto IL_1A3;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((ushort)((ulong)((Class69)@class).method_3()));
				goto IL_1A3;
			}
			int_ = (ushort)((Class69)@class).method_3();
			goto IL_1A3;
		}
		throw new InvalidOperationException();
		IL_1A3:
		this.method_74(new Class64((int)int_));
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00028418 File Offset: 0x00026618
	private static void smethod_26(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		double double_;
		if (num <= 8)
		{
			if (num == 1)
			{
				double_ = (double)((Class64)@class).method_3();
				goto IL_6B;
			}
			if (num == 8)
			{
				double_ = ((Class70)@class).method_3();
				goto IL_6B;
			}
		}
		else
		{
			if (num == 13)
			{
				double_ = (double)((Class69)@class).method_3();
				goto IL_6B;
			}
			if (num == 19)
			{
				double_ = Convert.ToUInt64(((Class73)@class).method_3());
				goto IL_6B;
			}
		}
		throw new InvalidOperationException();
		IL_6B:
		Class70 class2 = new Class70();
		class2.method_4(double_);
		class31_0.method_74(class2);
	}

	// Token: 0x06000208 RID: 520 RVA: 0x000284A4 File Offset: 0x000266A4
	private Class58 method_8(Class58 class58_4, Class58 class58_5, bool bool_2)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				if (!bool_2)
				{
					int num = ((Class64)class58_4).method_3();
					int num2 = ((Class64)class58_5).method_3();
					return new Class64(num / num2);
				}
				int num3 = ((Class64)class58_4).method_3();
				uint num4 = (uint)((Class64)class58_5).method_3();
				return new Class64(num3 / (int)num4);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					return Class31.smethod_152(new Class69((long)((Class64)class58_4).method_3()), class58_5, bool_2);
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
					{
						return this.method_8(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2);
					}
					return Class31.smethod_152(new Class69((long)((Class64)class58_4).method_3()), new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2);
				}
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				return Class31.smethod_152(class58_4, class58_5, bool_2);
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_152(class58_4, new Class69((long)((Class64)class58_5).method_3()), bool_2);
			}
			if (class58_5.method_0() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					return Class31.smethod_152(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2);
				}
				return Class31.smethod_152(class58_4, new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2);
			}
		}
		if (class58_4.method_0() == 8 && class58_5.method_0() == 8)
		{
			Class70 @class = new Class70();
			@class.method_4(((Class70)class58_4).method_3() / ((Class70)class58_5).method_3());
			return @class;
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)))
		{
			return this.method_8(new Class64(Convert.ToInt32(class58_4.vmethod_0())), class58_5, bool_2);
		}
		return this.method_8(new Class69(Convert.ToInt64(class58_4.vmethod_0())), class58_5, bool_2);
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000421C File Offset: 0x0000241C
	private static void smethod_27(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(int));
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000422E File Offset: 0x0000242E
	private static void smethod_28(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(4);
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00028708 File Offset: 0x00026908
	private void method_9(Type type_10, object object_3, long long_1, Array array_0)
	{
		Class58 @class = Class58.smethod_0(object_3, type_10);
		array_0.SetValue(@class.vmethod_0(), long_1);
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0002872C File Offset: 0x0002692C
	private static void smethod_29(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type_ = class31_0.method_70(int_, true);
		Class58 class58_5 = class31_0.method_102();
		if (!class31_0.method_75(class58_5, type_))
		{
			throw new InvalidCastException();
		}
		class31_0.method_74(class58_5);
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00004237 File Offset: 0x00002437
	private static void smethod_30(ILGenerator ilgenerator_0, Type type_10)
	{
		if (type_10 == Class29.type_0)
		{
			return;
		}
		ilgenerator_0.Emit(OpCodes.Castclass, type_10);
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0002876C File Offset: 0x0002696C
	private static Class58 smethod_31(Class58 class58_4, Class58 class58_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class69)class58_4).method_3();
			long num2 = ((Class69)class58_5).method_3();
			long long_;
			if (bool_2)
			{
				long_ = checked(num * num2);
			}
			else
			{
				long_ = num * num2;
			}
			return new Class69(long_);
		}
		ulong num3 = (ulong)((Class69)class58_4).method_3();
		ulong num4 = (ulong)((Class69)class58_5).method_3();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 * num4);
		}
		else
		{
			long_2 = num3 * num4;
		}
		return new Class69((long)long_2);
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00004253 File Offset: 0x00002453
	private static void smethod_32(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(8);
	}

	// Token: 0x06000210 RID: 528 RVA: 0x000287DC File Offset: 0x000269DC
	private static void smethod_33(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 @class = class31_0.method_102();
		bool flag;
		if (@class.method_0() == 8)
		{
			flag = !Class31.smethod_119(@class, class58_5);
		}
		else
		{
			flag = !Class31.smethod_22(@class, class58_5);
		}
		if (flag)
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000425C File Offset: 0x0000245C
	private bool method_10(MethodBase methodBase_0)
	{
		return methodBase_0.IsVirtual && this.method_70(this.class50_0.method_6(), true).IsSubclassOf(methodBase_0.DeclaringType);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00028830 File Offset: 0x00026A30
	private static void smethod_34(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		class31_0.method_74(class31_0.method_93(class58_5));
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00028854 File Offset: 0x00026A54
	private static void smethod_35(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		checked
		{
			uint int_;
			if (num <= 1)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						int_ = (uint)((Class64)@class).method_3();
						goto IL_9E;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (uint)((int)((Class75)@class).method_3());
						goto IL_9E;
					}
					int_ = (uint)((ulong)((long)((Class75)@class).method_3()));
					goto IL_9E;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (uint)((Class70)@class).method_3();
					goto IL_9E;
				}
				if (num == 13)
				{
					int_ = (uint)((ulong)((Class69)@class).method_3());
					goto IL_9E;
				}
				if (num == 19)
				{
					int_ = (uint)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_9E;
				}
			}
			throw new InvalidOperationException();
			IL_9E:
			class31_0.method_74(new Class64((int)int_));
		}
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000428A File Offset: 0x0000248A
	private static void smethod_36(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(int));
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0002890C File Offset: 0x00026B0C
	private static void smethod_37(Class31 class31_0, Class58 class58_4)
	{
		Class66 @class = (Class66)class58_4;
		Class85 class2 = new Class85();
		class2.method_4(class31_0.class58_3[(int)@class.method_3()]);
		class31_0.method_74(class2);
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00028944 File Offset: 0x00026B44
	private void method_11(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		byte int_;
		if (num <= 8)
		{
			if (num != 0)
			{
				if (num != 1)
				{
					if (num == 8)
					{
						if (bool_2)
						{
							int_ = checked((byte)((Class70)@class).method_3());
							goto IL_1A3;
						}
						int_ = (byte)((Class70)@class).method_3();
						goto IL_1A3;
					}
				}
				else
				{
					if (bool_2)
					{
						int_ = checked((byte)((uint)((Class64)@class).method_3()));
						goto IL_1A3;
					}
					int_ = (byte)((Class64)@class).method_3();
					goto IL_1A3;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((byte)((int)((Class75)@class).method_3()));
					goto IL_1A3;
				}
				int_ = (byte)((int)((Class75)@class).method_3());
				goto IL_1A3;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((byte)((ulong)((long)((Class75)@class).method_3())));
					goto IL_1A3;
				}
				int_ = (byte)((long)((Class75)@class).method_3());
				goto IL_1A3;
			}
		}
		else if (num != 13)
		{
			if (num != 19)
			{
				if (num == 20)
				{
					if (UIntPtr.Size == 4)
					{
						if (bool_2)
						{
							int_ = checked((byte)((uint)((Class60)@class).method_3()));
							goto IL_1A3;
						}
						int_ = (byte)((uint)((Class60)@class).method_3());
						goto IL_1A3;
					}
					else
					{
						if (bool_2)
						{
							int_ = checked((byte)((ulong)((Class60)@class).method_3()));
							goto IL_1A3;
						}
						int_ = (byte)((ulong)((Class60)@class).method_3());
						goto IL_1A3;
					}
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((byte)Convert.ToUInt64(((Class73)@class).method_3()));
					goto IL_1A3;
				}
				int_ = (byte)Convert.ToUInt64(((Class73)@class).method_3());
				goto IL_1A3;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((byte)((ulong)((Class69)@class).method_3()));
				goto IL_1A3;
			}
			int_ = (byte)((Class69)@class).method_3();
			goto IL_1A3;
		}
		throw new InvalidOperationException();
		IL_1A3:
		this.method_74(new Class64((int)int_));
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000429C File Offset: 0x0000249C
	private static void smethod_38(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_66(true, false);
	}

	// Token: 0x06000218 RID: 536 RVA: 0x000042A6 File Offset: 0x000024A6
	private static void smethod_39(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Localloc not supported.");
	}

	// Token: 0x06000219 RID: 537 RVA: 0x000042B3 File Offset: 0x000024B3
	private static void smethod_40(object object_3)
	{
		throw object_3;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00028B00 File Offset: 0x00026D00
	private Class49[] method_12(Class8 class8_2)
	{
		Class49[] array = new Class49[(int)class8_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this.method_16(class8_2);
		}
		return array;
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00028B38 File Offset: 0x00026D38
	private static void smethod_41(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		ulong long_;
		if (num <= 1)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					long_ = (ulong)((Class64)@class).method_3();
					goto IL_9B;
				}
			}
			else
			{
				if (IntPtr.Size == 4)
				{
					long_ = (ulong)((int)((Class75)@class).method_3());
					goto IL_9B;
				}
				long_ = (ulong)((long)((Class75)@class).method_3());
				goto IL_9B;
			}
		}
		else
		{
			if (num == 8)
			{
				long_ = checked((ulong)((Class70)@class).method_3());
				goto IL_9B;
			}
			if (num == 13)
			{
				long_ = (ulong)((Class69)@class).method_3();
				goto IL_9B;
			}
			if (num == 19)
			{
				long_ = Convert.ToUInt64(((Class73)@class).method_3());
				goto IL_9B;
			}
		}
		throw new InvalidOperationException();
		IL_9B:
		class31_0.method_74(new Class69((long)long_));
	}

	// Token: 0x0600021C RID: 540 RVA: 0x000042B6 File Offset: 0x000024B6
	private static void smethod_42(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_65(3);
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00028BEC File Offset: 0x00026DEC
	private static void smethod_43(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		bool flag;
		if (num <= 7)
		{
			if (num == 0)
			{
				flag = (((Class75)@class).method_3() != IntPtr.Zero);
				goto IL_BB;
			}
			if (num == 1)
			{
				flag = (((Class64)@class).method_3() != 0);
				goto IL_BB;
			}
			if (num == 7)
			{
				flag = (((Class61)@class).method_3() != null);
				goto IL_BB;
			}
		}
		else
		{
			if (num == 13)
			{
				flag = (((Class69)@class).method_3() != 0L);
				goto IL_BB;
			}
			if (num == 19)
			{
				flag = Convert.ToBoolean(((Class73)@class).method_3());
				goto IL_BB;
			}
			if (num == 20)
			{
				flag = (((Class60)@class).method_3() != UIntPtr.Zero);
				goto IL_BB;
			}
		}
		flag = (@class.vmethod_0() != null);
		IL_BB:
		if (flag)
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00028CCC File Offset: 0x00026ECC
	private static void smethod_44(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		checked
		{
			sbyte int_;
			if (num <= 1)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						int_ = (sbyte)((uint)((Class64)@class).method_3());
						goto IL_A2;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (sbyte)((uint)((int)((Class75)@class).method_3()));
						goto IL_A2;
					}
					int_ = (sbyte)((ulong)((long)((Class75)@class).method_3()));
					goto IL_A2;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (sbyte)((Class70)@class).method_3();
					goto IL_A2;
				}
				if (num == 13)
				{
					int_ = (sbyte)((ulong)((Class69)@class).method_3());
					goto IL_A2;
				}
				if (num == 19)
				{
					int_ = (sbyte)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_A2;
				}
			}
			throw new InvalidOperationException();
			IL_A2:
			class31_0.method_74(new Class64((int)int_));
		}
	}

	// Token: 0x0600021F RID: 543 RVA: 0x000042BF File Offset: 0x000024BF
	private static void smethod_45(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_45(false);
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00028D88 File Offset: 0x00026F88
	private static void smethod_46(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type_ = class31_0.method_70(int_, true);
		class31_0.method_34(type_);
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00028DB4 File Offset: 0x00026FB4
	private static Class31.Delegate21 smethod_47(Class31.Struct10 struct10_0)
	{
		Dictionary<Class31.Struct10, Class31.Delegate21> obj = Class31.dictionary_1;
		Class31.Delegate21 result;
		lock (obj)
		{
			Class31.dictionary_1.TryGetValue(struct10_0, out result);
		}
		return result;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00028DFC File Offset: 0x00026FFC
	private static void smethod_48(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		Class64 @class = new Class64();
		@class.method_4((Class31.smethod_64(class58_6, class58_5) > false) ? 1 : 0);
		class31_0.method_74(@class);
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00028E34 File Offset: 0x00027034
	private static Class58 smethod_49(Class58 class58_4, Class58 class58_5, bool bool_2, bool bool_3)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				if (!bool_3)
				{
					int num = ((Class64)class58_4).method_3();
					int num2 = ((Class64)class58_5).method_3();
					int int_;
					if (bool_2)
					{
						int_ = checked(num - num2);
					}
					else
					{
						int_ = num - num2;
					}
					return new Class64(int_);
				}
				uint num3 = (uint)((Class64)class58_4).method_3();
				uint num4 = (uint)((Class64)class58_5).method_3();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 - num4);
				}
				else
				{
					int_2 = num3 - num4;
				}
				return new Class64((int)int_2);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					return Class31.smethod_243(new Class69((long)((Class64)class58_4).method_3()), class58_5, bool_2, bool_3);
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
					{
						return Class31.smethod_49(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2, bool_3);
					}
					return Class31.smethod_243(new Class69((long)((Class64)class58_4).method_3()), new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2, bool_3);
				}
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				return Class31.smethod_243(class58_4, class58_5, bool_2, bool_3);
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_243(class58_4, new Class69((long)((Class64)class58_5).method_3()), bool_2, bool_3);
			}
			if (class58_5.method_0() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					return Class31.smethod_243(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2, bool_3);
				}
				return Class31.smethod_243(class58_4, new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class58_4.method_0() == 8 && class58_5.method_0() == 8)
		{
			Class70 @class = new Class70();
			@class.method_4(((Class70)class58_4).method_3() - ((Class70)class58_5).method_3());
			return @class;
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)))
		{
			return Class31.smethod_49(new Class64(Convert.ToInt32(class58_4.vmethod_0())), class58_5, bool_2, bool_3);
		}
		return Class31.smethod_49(new Class69(Convert.ToInt64(class58_4.vmethod_0())), class58_5, bool_2, bool_3);
	}

	// Token: 0x06000224 RID: 548 RVA: 0x000042C8 File Offset: 0x000024C8
	private static void smethod_50(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_65((int)((Class77)class58_4).method_3());
	}

	// Token: 0x06000225 RID: 549 RVA: 0x000042DB File Offset: 0x000024DB
	private static void smethod_51(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_104((int)((Class77)class58_4).method_3());
	}

	// Token: 0x06000226 RID: 550 RVA: 0x000042EE File Offset: 0x000024EE
	private static void smethod_52(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Initblk not supported.");
	}

	// Token: 0x06000227 RID: 551 RVA: 0x000042FB File Offset: 0x000024FB
	private void method_13(int int_0)
	{
		Class80 @class = new Class80();
		@class.method_4(int_0);
		this.method_74(@class);
	}

	// Token: 0x06000228 RID: 552 RVA: 0x000290C8 File Offset: 0x000272C8
	private void method_14(Type type_10)
	{
		object object_ = this.method_102().vmethod_0();
		long long_ = this.method_22();
		Array array_ = (Array)this.method_102().vmethod_0();
		this.method_9(type_10, object_, long_, array_);
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000430F File Offset: 0x0000250F
	private static void smethod_53(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(sbyte));
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00004321 File Offset: 0x00002521
	private static void smethod_54(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Mkrefany is not supported.");
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_55(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000432E File Offset: 0x0000252E
	private static void smethod_56(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Refanytype is not supported.");
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000433B File Offset: 0x0000253B
	private static void smethod_57(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(long));
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000434D File Offset: 0x0000254D
	private static void smethod_58(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_30(1);
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00004356 File Offset: 0x00002556
	private static void smethod_59(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_14(Class31.type_2);
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00029104 File Offset: 0x00027304
	private void method_15(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		sbyte int_;
		if (num <= 1)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					if (bool_2)
					{
						int_ = checked((sbyte)((Class64)@class).method_3());
						goto IL_130;
					}
					int_ = (sbyte)((Class64)@class).method_3();
					goto IL_130;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((sbyte)((int)((Class75)@class).method_3()));
					goto IL_130;
				}
				int_ = (sbyte)((int)((Class75)@class).method_3());
				goto IL_130;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((sbyte)((long)((Class75)@class).method_3()));
					goto IL_130;
				}
				int_ = (sbyte)((long)((Class75)@class).method_3());
				goto IL_130;
			}
		}
		else if (num != 8)
		{
			if (num != 13)
			{
				if (num == 19)
				{
					if (bool_2)
					{
						int_ = checked((sbyte)Convert.ToUInt64(((Class73)@class).method_3()));
						goto IL_130;
					}
					int_ = (sbyte)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_130;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((sbyte)((Class69)@class).method_3());
					goto IL_130;
				}
				int_ = (sbyte)((Class69)@class).method_3();
				goto IL_130;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((sbyte)((Class70)@class).method_3());
				goto IL_130;
			}
			int_ = (sbyte)((Class70)@class).method_3();
			goto IL_130;
		}
		throw new InvalidOperationException();
		IL_130:
		Class64 class2 = new Class64();
		class2.method_4((int)int_);
		this.method_74(class2);
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00004363 File Offset: 0x00002563
	private Class49 method_16(Class8 class8_2)
	{
		Class49 @class = new Class49();
		@class.method_1(class8_2.method_19());
		@class.method_3(class8_2.method_5());
		return @class;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_60(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00029254 File Offset: 0x00027454
	private object method_17(object[] object_3, Type[] type_10, Type[] type_11, object[] object_4)
	{
		this.method_53();
		if (object_3 == null)
		{
			object_3 = Class4<object>.gparam_0;
		}
		this.object_2 = object_4;
		this.type_6 = type_10;
		this.type_7 = type_11;
		this.class58_3 = this.method_79(object_3);
		this.class58_0 = this.method_68();
		object result;
		try
		{
			Class98 @class = new Class98(this.byte_0);
			try
			{
				using (this.class8_0 = new Class8(@class))
				{
					this.uint_0 = (uint)@class.vmethod_3();
					this.bool_0 = false;
					this.nullable_0 = null;
					this.uint_2 = 0U;
					this.uint_1 = 0U;
					this.method_3();
					this.method_2();
				}
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			Type left = this.method_70(this.class50_0.method_8(), false);
			if (left != Class31.type_8 && this.method_41())
			{
				result = Class58.smethod_0(null, left).vmethod_2(this.method_102()).vmethod_0();
			}
			else
			{
				result = null;
			}
		}
		finally
		{
			for (int i = 0; i < this.class50_0.method_2().Length; i++)
			{
				Class49 class3 = this.class50_0.method_2()[i];
				if (class3.method_2())
				{
					Class85 class4 = (Class85)this.class58_3[i];
					Type type = this.method_70(class3.method_0(), false);
					object_3[i] = Class58.smethod_0(null, type.GetElementType()).vmethod_2(class4.method_3()).vmethod_0();
				}
			}
			this.object_2 = null;
			this.class58_3 = null;
			this.class58_0 = null;
		}
		return result;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00004382 File Offset: 0x00002582
	private static void smethod_61(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_92(class58_4);
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00029414 File Offset: 0x00027614
	private static void smethod_62(Class31 class31_0, Class58 class58_4)
	{
		Class64 @class = (Class64)class58_4;
		MethodBase methodBase_ = class31_0.method_58(@class.method_3());
		class31_0.method_5(methodBase_, false);
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00029440 File Offset: 0x00027640
	private Class58 method_18(Class58 class58_4)
	{
		if (class58_4.method_0() == 1)
		{
			int num = ((Class64)class58_4).method_3();
			Class64 @class = new Class64();
			@class.method_4(~num);
			return @class;
		}
		if (class58_4.method_0() == 13)
		{
			long num2 = ((Class69)class58_4).method_3();
			Class69 class2 = new Class69();
			class2.method_4(~num2);
			return class2;
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
		{
			return new Class64(~Convert.ToInt32(class58_4.vmethod_0()));
		}
		return new Class69(~Convert.ToInt64(class58_4.vmethod_0()));
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000438B File Offset: 0x0000258B
	private static void smethod_63(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_15(false);
	}

	// Token: 0x06000238 RID: 568 RVA: 0x000294FC File Offset: 0x000276FC
	private static bool smethod_64(Class58 class58_4, Class58 class58_5)
	{
		bool result = false;
		int num = class58_4.method_0();
		switch (num)
		{
		case 0:
			if (class58_5.method_0() == 7 && class58_5.vmethod_0() == null)
			{
				return ((Class75)class58_4).method_3() == IntPtr.Zero;
			}
			if (class58_5.method_0() == 1)
			{
				return ((Class75)class58_4).method_3() == new IntPtr(((Class64)class58_5).method_3());
			}
			if (class58_5.method_0() == 13)
			{
				return ((Class75)class58_4).method_3() == new IntPtr(((Class69)class58_5).method_3());
			}
			return ((Class75)class58_4).method_3() == ((Class75)class58_5).method_3();
		case 1:
			if (class58_5.method_0() == 19)
			{
				return (long)((Class64)class58_4).method_3() == Convert.ToInt64(((Class73)class58_5).method_3());
			}
			if (class58_5.method_0() == 7 && class58_5.vmethod_0() == null)
			{
				return ((Class64)class58_4).method_3() == 0;
			}
			return ((Class64)class58_4).method_3() == ((Class64)class58_5).method_3();
		case 2:
		{
			Class85 @class = (Class85)class58_4;
			Class85 class2 = (Class85)class58_5;
			return Class31.smethod_64(@class.method_3(), class2.method_3());
		}
		case 3:
		case 4:
		case 5:
		case 6:
			break;
		case 7:
			return class58_4.vmethod_0() == class58_5.vmethod_0();
		case 8:
		{
			double d = ((Class70)class58_4).method_3();
			double num2 = ((Class70)class58_5).method_3();
			return !double.IsNaN(d) && !double.IsNaN(num2) && d.Equals(num2);
		}
		default:
			switch (num)
			{
			case 11:
			case 24:
			{
				Class82 class3 = (Class82)class58_4;
				Class82 class82_ = (Class82)class58_5;
				return class3.vmethod_6(class82_);
			}
			case 13:
				if (class58_5.method_0() == 19)
				{
					return ((Class69)class58_4).method_3() == Convert.ToInt64(((Class73)class58_5).method_3());
				}
				if (class58_5.method_0() == 7 && class58_5.vmethod_0() == null)
				{
					return ((Class69)class58_4).method_3() == 0L;
				}
				return ((Class69)class58_4).method_3() == ((Class69)class58_5).method_3();
			case 18:
			{
				Class81 class4 = (Class81)class58_4;
				Class81 class5 = (Class81)class58_5;
				return class4.method_3() == class5.method_3() && class4.method_5() == class5.method_5();
			}
			case 19:
			{
				Class73 class6 = (Class73)class58_4;
				if (class58_5.method_0() == 19)
				{
					return Convert.ToInt64(class6.method_3()) == Convert.ToInt64(((Class73)class58_5).method_3());
				}
				if (class6.method_3() == null)
				{
					return class58_5.vmethod_0() == null;
				}
				if (class58_5.vmethod_0() != null)
				{
					return Convert.ToInt64(class6.method_3()) == Convert.ToInt64(class58_5.vmethod_0());
				}
				return result;
			}
			case 20:
				if (class58_5.method_0() == 7 && class58_5.vmethod_0() == null)
				{
					return ((Class60)class58_4).method_3() == UIntPtr.Zero;
				}
				if (class58_5.method_0() == 1)
				{
					return ((Class60)class58_4).method_3() == new UIntPtr((uint)((Class64)class58_5).method_3());
				}
				if (class58_5.method_0() == 13)
				{
					return ((Class60)class58_4).method_3() == new UIntPtr((ulong)((Class69)class58_5).method_3());
				}
				return ((Class60)class58_4).method_3() == ((Class60)class58_5).method_3();
			case 23:
			{
				Class80 class7 = (Class80)class58_4;
				Class80 class8 = (Class80)class58_5;
				return class7.method_3() == class8.method_3();
			}
			case 25:
				return (class58_5.method_0() != 7 || class58_5.vmethod_0() != null) && ((Class63)class58_4).method_3() == ((Class63)class58_5).method_3();
			}
			break;
		}
		result = (class58_4.vmethod_0() == class58_5.vmethod_0());
		return result;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00029964 File Offset: 0x00027B64
	private Class58 method_19(Class58 class58_4, Class58 class58_5)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				int num = ((Class64)class58_4).method_3();
				int num2 = ((Class64)class58_5).method_3();
				return new Class64(num | num2);
			}
			if (class58_5.method_0() == 19)
			{
				int num3 = ((Class64)class58_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
				{
					int num4 = Convert.ToInt32(class58_5.vmethod_0());
					return new Class64(num3 | num4);
				}
				long num5 = Convert.ToInt64(class58_5.vmethod_0());
				return new Class69((long)num3 | num5);
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				long num6 = ((Class69)class58_4).method_3();
				long num7 = ((Class69)class58_5).method_3();
				return new Class69(num6 | num7);
			}
			if (class58_5.method_0() == 19)
			{
				long num8 = (long)((Class64)class58_4).method_3();
				long num9 = Convert.ToInt64(class58_5.vmethod_0());
				return new Class69(num8 | num9);
			}
		}
		if (class58_4.method_0() == 19)
		{
			if (class58_5.method_0() == 1)
			{
				int num10 = ((Class64)class58_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					return new Class64(Convert.ToInt32(class58_4.vmethod_0()) | num10);
				}
				return new Class69(Convert.ToInt64(class58_5.vmethod_0()) | (long)num10);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					long num11 = Convert.ToInt64(class58_4.vmethod_0());
					long num12 = ((Class69)class58_5).method_3();
					return new Class69(num11 | num12);
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
					Type underlyingType4 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)) && !(underlyingType4 == typeof(long)) && !(underlyingType4 == typeof(ulong)))
					{
						int num13 = Convert.ToInt32(class58_4.vmethod_0());
						int num14 = Convert.ToInt32(class58_5.vmethod_0());
						return new Class64(num13 | num14);
					}
					long num15 = Convert.ToInt64(class58_4.vmethod_0());
					long num16 = Convert.ToInt64(class58_5.vmethod_0());
					return new Class69(num15 | num16);
				}
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00029BF0 File Offset: 0x00027DF0
	private bool method_20(MethodBase methodBase_0, object object_3, Class58[] class58_4, object[] object_4, bool bool_2, ref object object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (declaringType == Class31.type_3 && methodBase_0.Name == "InitializeArray" && object_4.Length == 2 && methodBase_0.ToString() == "Void InitializeArray(System.Array, System.RuntimeFieldHandle)")
		{
			Class117.smethod_0((Array)object_4[0], (RuntimeFieldHandle)object_4[1]);
			return true;
		}
		return false;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00004394 File Offset: 0x00002594
	private static void smethod_65(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(short));
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00029C64 File Offset: 0x00027E64
	private static void smethod_66(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		checked
		{
			ushort int_;
			if (num <= 1)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						int_ = (ushort)((uint)((Class64)@class).method_3());
						goto IL_A2;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (ushort)((uint)((int)((Class75)@class).method_3()));
						goto IL_A2;
					}
					int_ = (ushort)((ulong)((long)((Class75)@class).method_3()));
					goto IL_A2;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (ushort)((Class70)@class).method_3();
					goto IL_A2;
				}
				if (num == 13)
				{
					int_ = (ushort)((ulong)((Class69)@class).method_3());
					goto IL_A2;
				}
				if (num == 19)
				{
					int_ = (ushort)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_A2;
				}
			}
			throw new InvalidOperationException();
			IL_A2:
			class31_0.method_74(new Class64((int)int_));
		}
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00029D20 File Offset: 0x00027F20
	private void method_21()
	{
		if (!this.class41_0.method_0())
		{
			Class41 obj = this.class41_0;
			lock (obj)
			{
				if (!this.class41_0.method_0())
				{
					Class31.dictionary_0 = Class31.smethod_237(this.class41_0);
					this.method_78();
					this.class41_0.method_1(true);
				}
			}
		}
		if (Class31.dictionary_0 == null)
		{
			Class31.dictionary_0 = Class31.smethod_237(this.class41_0);
		}
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000311B File Offset: 0x0000131B
	[Conditional("DEBUG")]
	public static void smethod_67(string string_0)
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00029DB0 File Offset: 0x00027FB0
	private static void smethod_68(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(new Class64((Class31.smethod_119(class58_6, class58_5) > false) ? 1 : 0));
	}

	// Token: 0x06000240 RID: 576 RVA: 0x000043A6 File Offset: 0x000025A6
	private static void smethod_69(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_47(false);
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00029DE0 File Offset: 0x00027FE0
	private long method_22()
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		if (num <= 1)
		{
			if (num == 0)
			{
				return ((Class75)@class).method_3().ToInt64();
			}
			if (num == 1)
			{
				return (long)((Class64)@class).method_3();
			}
		}
		else
		{
			if (num == 19)
			{
				return Convert.ToInt64(((Class73)@class).method_3());
			}
			if (num == 20)
			{
				return (long)((Class60)@class).method_3().ToUInt64();
			}
		}
		throw new Exception("Unexpected value on the stack.");
	}

	// Token: 0x06000242 RID: 578 RVA: 0x000043AF File Offset: 0x000025AF
	private static void smethod_70(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(short));
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00029E6C File Offset: 0x0002806C
	private object method_23(int int_0)
	{
		int num = Class9.smethod_0(int_0);
		object result;
		if (num > 67108864)
		{
			if (num <= 167772160)
			{
				if (num == 100663296)
				{
					goto IL_C4;
				}
				if (num != 167772160)
				{
					goto IL_BE;
				}
				try
				{
					return this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
				}
				catch
				{
					try
					{
						result = this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
					}
					catch
					{
						throw new InvalidOperationException();
					}
					return result;
				}
			}
			if (num == 452984832)
			{
				goto IL_E0;
			}
			if (num != 721420288)
			{
				goto IL_BE;
			}
			IL_C4:
			return this.module_0.ModuleHandle.ResolveMethodHandle(int_0);
		}
		if (num == 16777216 || num == 33554432)
		{
			goto IL_E0;
		}
		if (num == 67108864)
		{
			return this.module_0.ModuleHandle.ResolveFieldHandle(int_0);
		}
		IL_BE:
		throw new InvalidOperationException();
		IL_E0:
		result = this.module_0.ModuleHandle.ResolveTypeHandle(int_0);
		return result;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00029F90 File Offset: 0x00028190
	private Class58 method_24(Class8 class8_2, byte byte_1)
	{
		switch (byte_1)
		{
		case 0:
		{
			this.uint_1 += 1U;
			Class68 @class = new Class68();
			@class.method_4(class8_2.method_7());
			return @class;
		}
		case 1:
		{
			this.uint_1 += 4U;
			Class65 class2 = new Class65();
			class2.method_4(class8_2.method_20());
			return class2;
		}
		case 2:
		case 6:
			this.uint_1 += 4U;
			return new Class64(class8_2.method_19());
		case 3:
		case 7:
		{
			this.uint_1 += 1U;
			Class77 class3 = new Class77();
			class3.method_4(class8_2.method_6());
			return class3;
		}
		case 4:
		{
			this.uint_1 += 4U;
			Class67 class4 = new Class67();
			class4.method_4(class8_2.method_26());
			return class4;
		}
		case 5:
		case 12:
		{
			this.uint_1 += 2U;
			Class66 class5 = new Class66();
			class5.method_4(class8_2.method_24());
			return class5;
		}
		case 8:
		{
			this.uint_1 += 8U;
			Class70 class6 = new Class70();
			class6.method_4(class8_2.method_27());
			return class6;
		}
		case 9:
		{
			int num = class8_2.method_19();
			Class64[] array = new Class64[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new Class64(class8_2.method_19());
			}
			this.uint_1 += (uint)((num + 1) * 4);
			Class78 class7 = new Class78();
			class7.method_4(array);
			return class7;
		}
		case 10:
			this.uint_1 += 8U;
			return new Class69(class8_2.method_21());
		case 11:
			return null;
		default:
			throw new Exception("Unknown operand type.");
		}
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0002A124 File Offset: 0x00028324
	private static void smethod_71(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type = class31_0.method_70(int_, true);
		long long_ = class31_0.method_22();
		Array array_ = (Array)class31_0.method_102().vmethod_0();
		Class83 @class = new Class83();
		@class.method_6(array_);
		@class.method_4(type);
		@class.method_8(long_);
		class31_0.method_74(@class);
	}

	// Token: 0x06000246 RID: 582 RVA: 0x000043C1 File Offset: 0x000025C1
	private static void smethod_72(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_74(new Class61());
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0002A180 File Offset: 0x00028380
	private FieldInfo method_25(int int_0)
	{
		Dictionary<int, object> obj = Class31.dictionary_3;
		FieldInfo result;
		lock (obj)
		{
			bool flag2 = true;
			object obj2;
			FieldInfo fieldInfo;
			if (Class31.dictionary_3.TryGetValue(int_0, out obj2))
			{
				fieldInfo = (FieldInfo)obj2;
			}
			else
			{
				Class103 class103_ = this.method_85(int_0);
				fieldInfo = this.method_95(int_0, class103_, ref flag2);
				if (flag2)
				{
					Class31.dictionary_3.Add(int_0, fieldInfo);
				}
			}
			this.method_94(fieldInfo);
			result = fieldInfo;
		}
		return result;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x000043CE File Offset: 0x000025CE
	private static void smethod_73(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Cpobj is not supported.");
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0002A204 File Offset: 0x00028404
	private void method_26(bool bool_2)
	{
		Class58 @class = this.method_102();
		bool flag = IntPtr.Size == 4;
		int num = @class.method_0();
		IntPtr intptr_;
		if (num <= 8)
		{
			if (num != 1)
			{
				if (num == 8)
				{
					double num2 = ((Class70)@class).method_3();
					if (flag)
					{
						if (bool_2)
						{
							intptr_ = new IntPtr(checked((int)num2));
							goto IL_12A;
						}
						intptr_ = new IntPtr((int)num2);
						goto IL_12A;
					}
					else
					{
						if (bool_2)
						{
							intptr_ = new IntPtr(checked((long)num2));
							goto IL_12A;
						}
						intptr_ = new IntPtr((long)num2);
						goto IL_12A;
					}
				}
			}
			else
			{
				int value = ((Class64)@class).method_3();
				if (bool_2)
				{
					intptr_ = new IntPtr(value);
					goto IL_12A;
				}
				intptr_ = new IntPtr(value);
				goto IL_12A;
			}
		}
		else if (num != 13)
		{
			if (num == 19)
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((long)Convert.ToUInt64(((Class73)@class).method_3())));
					goto IL_12A;
				}
				intptr_ = new IntPtr((long)Convert.ToUInt64(((Class73)@class).method_3()));
				goto IL_12A;
			}
		}
		else
		{
			long num3 = ((Class69)@class).method_3();
			if (flag)
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((int)num3));
					goto IL_12A;
				}
				intptr_ = new IntPtr((int)num3);
				goto IL_12A;
			}
			else
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(num3);
					goto IL_12A;
				}
				intptr_ = new IntPtr(num3);
				goto IL_12A;
			}
		}
		throw new InvalidOperationException();
		IL_12A:
		Class75 class2 = new Class75();
		class2.method_4(intptr_);
		this.method_74(class2);
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0002A350 File Offset: 0x00028550
	private static void smethod_74(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		checked
		{
			byte int_;
			if (num <= 1)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						int_ = (byte)((uint)((Class64)@class).method_3());
						goto IL_A2;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (byte)((uint)((int)((Class75)@class).method_3()));
						goto IL_A2;
					}
					int_ = (byte)((ulong)((long)((Class75)@class).method_3()));
					goto IL_A2;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (byte)((Class70)@class).method_3();
					goto IL_A2;
				}
				if (num == 13)
				{
					int_ = (byte)((ulong)((Class69)@class).method_3());
					goto IL_A2;
				}
				if (num == 19)
				{
					int_ = (byte)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_A2;
				}
			}
			throw new InvalidOperationException();
			IL_A2:
			class31_0.method_74(new Class64((int)int_));
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x000043DB File Offset: 0x000025DB
	private static void smethod_75(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_7(false);
	}

	// Token: 0x0600024C RID: 588 RVA: 0x0002A40C File Offset: 0x0002860C
	private static void smethod_76(Class31 class31_0, Class58 class58_4)
	{
		Class129 @class = Class31.smethod_106(class31_0);
		Class97 class97_ = class31_0.class8_0.method_0();
		long num = class31_0.method_42();
		byte[] array = new Class44(@class.imethod_1(), @class.imethod_2()).method_1(class97_, @class);
		Class31.Class33 class2 = new Class31.Class33
		{
			class129_0 = @class,
			long_0 = num
		};
		@class.method_4(Class43.smethod_1(array.Length) - array.Length);
		Class98 class3 = new Class98(array, 0, array.Length, false);
		class2.class97_0 = class3;
		class2.class8_0 = new Class8(class3);
		class31_0.method_40().Push(class2);
		class31_0.method_100(class2);
	}

	// Token: 0x0600024D RID: 589 RVA: 0x0002A4A8 File Offset: 0x000286A8
	private static void smethod_77(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		class31_0.type_1 = class31_0.method_70(int_, true);
	}

	// Token: 0x0600024E RID: 590 RVA: 0x000043E4 File Offset: 0x000025E4
	private static void smethod_78(Class31 class31_0, Class58 class58_4)
	{
		if (class31_0.object_1 == null)
		{
			throw new InvalidOperationException();
		}
		class31_0.method_101(class31_0.object_1);
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00004400 File Offset: 0x00002600
	private static void smethod_79(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_88(false);
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0002A4D0 File Offset: 0x000286D0
	private static void smethod_80(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type = class31_0.method_70(int_, true);
		Class58 @class = Class58.smethod_0(class31_0.method_102().vmethod_0(), type);
		@class.method_2(type);
		class31_0.method_74(@class);
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00004409 File Offset: 0x00002609
	private static object smethod_81(MethodBase methodBase_0, object object_3, object[] object_4, bool bool_2)
	{
		if (!Class31.Class34.bool_0)
		{
			return Class31.smethod_249(methodBase_0, object_3, object_4);
		}
		return Class31.smethod_165(methodBase_0, object_3, object_4, bool_2);
	}

	// Token: 0x06000252 RID: 594 RVA: 0x0002A514 File Offset: 0x00028714
	private void method_27(Class79 class79_0, Class58 class58_4)
	{
		int num = class79_0.method_0();
		if (num <= 11)
		{
			if (num == 2)
			{
				((Class85)class79_0).method_3().vmethod_2(class58_4);
				return;
			}
			if (num == 11)
			{
				goto IL_3F;
			}
		}
		else if (num != 18)
		{
			if (num == 23)
			{
				this.class58_0[((Class80)class79_0).method_3()].vmethod_2(class58_4);
				return;
			}
			if (num == 24)
			{
				goto IL_3F;
			}
		}
		else
		{
			Class81 @class = (Class81)class79_0;
			FieldInfo fieldInfo = @class.method_5();
			Class58 class2 = Class58.smethod_0(class58_4.vmethod_0(), fieldInfo.FieldType);
			fieldInfo.SetValue(@class.method_3(), class2.vmethod_0());
			Class79 class3 = @class.method_7();
			if (class3 != null && fieldInfo.DeclaringType.IsValueType)
			{
				this.method_27(class3, Class58.smethod_0(@class.method_3(), null));
				return;
			}
			return;
		}
		throw new ArgumentOutOfRangeException();
		IL_3F:
		Class82 class4 = (Class82)class79_0;
		Class58 class5 = Class58.smethod_0(class58_4.vmethod_0(), class4.method_3());
		class4.vmethod_5(class5.vmethod_0());
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000311B File Offset: 0x0000131B
	private void method_28(Class8 class8_2)
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0002A608 File Offset: 0x00028808
	private void method_29(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		uint int_;
		if (num <= 8)
		{
			if (num != 0)
			{
				if (num != 1)
				{
					if (num == 8)
					{
						if (bool_2)
						{
							int_ = checked((uint)((Class70)@class).method_3());
							goto IL_19E;
						}
						int_ = (uint)((Class70)@class).method_3();
						goto IL_19E;
					}
				}
				else
				{
					if (bool_2)
					{
						int_ = checked((uint)((Class64)@class).method_3());
						goto IL_19E;
					}
					int_ = (uint)((ushort)((Class64)@class).method_3());
					goto IL_19E;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((uint)((int)((Class75)@class).method_3()));
					goto IL_19E;
				}
				int_ = (uint)((int)((Class75)@class).method_3());
				goto IL_19E;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((uint)((ulong)((long)((Class75)@class).method_3())));
					goto IL_19E;
				}
				int_ = (uint)((long)((Class75)@class).method_3());
				goto IL_19E;
			}
		}
		else if (num != 13)
		{
			if (num != 19)
			{
				if (num == 20)
				{
					if (UIntPtr.Size == 4)
					{
						if (bool_2)
						{
							int_ = (uint)((Class60)@class).method_3();
							goto IL_19E;
						}
						int_ = (uint)((Class60)@class).method_3();
						goto IL_19E;
					}
					else
					{
						if (bool_2)
						{
							int_ = checked((uint)((ulong)((Class60)@class).method_3()));
							goto IL_19E;
						}
						int_ = (uint)((ulong)((Class60)@class).method_3());
						goto IL_19E;
					}
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((uint)Convert.ToUInt64(((Class73)@class).method_3()));
					goto IL_19E;
				}
				int_ = (uint)Convert.ToUInt64(((Class73)@class).method_3());
				goto IL_19E;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((uint)((Class69)@class).method_3());
				goto IL_19E;
			}
			int_ = (uint)((Class69)@class).method_3();
			goto IL_19E;
		}
		throw new InvalidOperationException();
		IL_19E:
		this.method_74(new Class64((int)int_));
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00004424 File Offset: 0x00002624
	private static void smethod_82(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_29(true);
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0000442D File Offset: 0x0000262D
	private static void smethod_83(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_104(2);
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0002A7C0 File Offset: 0x000289C0
	private static void smethod_84(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		FieldInfo fieldInfo = class31_0.method_25(int_);
		Class58 @class = class31_0.method_102();
		Class58 class2 = class31_0.method_102();
		Class79 class3 = class2 as Class79;
		object obj;
		if (class3 != null)
		{
			obj = class31_0.method_72(class3).vmethod_0();
		}
		else
		{
			obj = class2.vmethod_0();
		}
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		Class58 class4 = Class58.smethod_0(@class.vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(obj, class4.vmethod_0());
		if (class3 != null && obj != null && obj.GetType().IsValueType)
		{
			class31_0.method_27(class3, Class58.smethod_0(obj, null));
		}
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0002A85C File Offset: 0x00028A5C
	private static void smethod_85(Class31 class31_0, Class58 class58_4)
	{
		int num = ((Class64)class58_4).method_3();
		bool flag = (num & int.MinValue) != 0;
		bool bool_ = (num & 1073741824) != 0;
		num &= 1073741823;
		if (flag)
		{
			class31_0.method_103(num, null, null, bool_);
			return;
		}
		Class16 class16_ = (Class16)class31_0.method_85(num).method_4();
		class31_0.method_71(class16_);
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0002A8B8 File Offset: 0x00028AB8
	private void method_30(int int_0)
	{
		Class58 @class = this.method_102();
		if (@class is Class79)
		{
			this.class58_0[int_0] = @class;
			return;
		}
		this.class58_0[int_0].vmethod_2(@class);
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0002A8F8 File Offset: 0x00028AF8
	private static void smethod_86(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(class31_0.method_4(class58_6, class58_5));
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00004436 File Offset: 0x00002636
	private void method_31(uint uint_3)
	{
		this.nullable_0 = new uint?(uint_3);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0002A924 File Offset: 0x00028B24
	private bool method_32(MethodInfo methodInfo_0, Class17 class17_0, Type[] type_10, out int int_0)
	{
		int_0 = 0;
		if (!methodInfo_0.IsGenericMethodDefinition)
		{
			return false;
		}
		ParameterInfo[] parameters = methodInfo_0.GetParameters();
		if (parameters.Length != class17_0.method_8().Length)
		{
			return false;
		}
		if (methodInfo_0.GetGenericArguments().Length != class17_0.method_10().Length)
		{
			return false;
		}
		for (int i = -1; i < parameters.Length; i++)
		{
			Type type = (i == -1) ? methodInfo_0.ReturnType : parameters[i].ParameterType;
			if (type_10 != null && type.IsGenericParameter && type.DeclaringMethod != null)
			{
				type = (type_10[type.GenericParameterPosition] ?? type);
			}
			Class103 @class = (i == -1) ? class17_0.method_12() : class17_0.method_8()[i];
			if (@class != null)
			{
				int num;
				if (!this.method_69(type, @class, out num))
				{
					return false;
				}
				if (i >= 0)
				{
					int_0 += num;
				}
			}
		}
		return true;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00004444 File Offset: 0x00002644
	private Class86 method_33(Class8 class8_2)
	{
		Class86 @class = new Class86();
		@class.method_1(class8_2.method_19());
		return @class;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0002A9F8 File Offset: 0x00028BF8
	private static void smethod_87(ILGenerator ilgenerator_0, int int_0)
	{
		switch (int_0)
		{
		case -1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
			return;
		case 0:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
			return;
		default:
			if (int_0 > -129 && int_0 < 128)
			{
				ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_0);
				return;
			}
			ilgenerator_0.Emit(OpCodes.Ldc_I4, int_0);
			return;
		}
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00004457 File Offset: 0x00002657
	private static void smethod_88(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_55(true);
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0002AAD8 File Offset: 0x00028CD8
	private static void smethod_89(Class31 class31_0, Class58 class58_4)
	{
		Class64 @class = (Class64)class58_4;
		MethodBase methodBase = class31_0.method_58(@class.method_3());
		Type declaringType = methodBase.DeclaringType;
		Type type = class31_0.method_102().vmethod_0().GetType();
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		MethodBase methodBase2 = null;
		Type type2 = type;
		while (type2 != null && type2 != declaringType)
		{
			MethodInfo method = type2.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase2 = method;
				break;
			}
			type2 = type2.BaseType;
		}
		if (methodBase2 == null)
		{
			methodBase2 = methodBase;
		}
		Class59 class2 = new Class59();
		class2.method_4(methodBase2);
		class31_0.method_74(class2);
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00004460 File Offset: 0x00002660
	private static void smethod_90(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(1);
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0002ABC0 File Offset: 0x00028DC0
	private static string smethod_91(MethodBase methodBase_0)
	{
		Type declaringType = methodBase_0.DeclaringType;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		string[] array = new string[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			array[i] = string.Format("{0} {1}", parameterInfo.ParameterType, parameterInfo.Name);
		}
		string text = string.Join(", ", array);
		return string.Concat(new string[]
		{
			declaringType.FullName,
			".",
			methodBase_0.Name,
			"(",
			text,
			")"
		});
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0002AC68 File Offset: 0x00028E68
	private void method_34(Type type_10)
	{
		long index = this.method_22();
		Array array = (Array)this.method_102().vmethod_0();
		this.method_74(Class58.smethod_0(array.GetValue(index), type_10));
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00004469 File Offset: 0x00002669
	private static Exception smethod_92(string string_0, string string_1)
	{
		return new TypeLoadException(Class31.smethod_143("security transparent method '" + string_0 + "'", "security critical type '" + string_1 + "'"));
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00004499 File Offset: 0x00002699
	private static void smethod_93(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_106(false);
	}

	// Token: 0x06000266 RID: 614 RVA: 0x000044A2 File Offset: 0x000026A2
	private static void smethod_94(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_39(true, true);
	}

	// Token: 0x06000267 RID: 615 RVA: 0x000044AC File Offset: 0x000026AC
	private void method_35()
	{
		Class31.smethod_171<Class47>(this.class47_0, new Comparison<Class47>(Class31.Class32.class32_0.method_0));
	}

	// Token: 0x06000268 RID: 616 RVA: 0x0002ACA0 File Offset: 0x00028EA0
	private static void smethod_95(Class31 class31_0, Class58 class58_4)
	{
		object object_ = class31_0.method_102().vmethod_0();
		long num = class31_0.method_22();
		Array array = (Array)class31_0.method_102().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(long))
			{
				Class58 @class = Class58.smethod_0(object_, typeof(long));
				((long[])array)[(int)((IntPtr)num)] = (long)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(ulong))
			{
				Class58 class2 = Class58.smethod_0(object_, typeof(ulong));
				((ulong[])array)[(int)((IntPtr)num)] = (ulong)class2.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class31_0.method_9(elementType, object_, num, array);
				return;
			}
			class31_0.method_9(typeof(long), object_, num, array);
		}
	}

	// Token: 0x06000269 RID: 617 RVA: 0x000044D8 File Offset: 0x000026D8
	private static void smethod_96(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_99(class58_4);
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0002AD78 File Offset: 0x00028F78
	private static void smethod_97(Class31 class31_0, Class58 class58_4)
	{
		Array array = (Array)class31_0.method_102().vmethod_0();
		class31_0.method_74(new Class64(array.Length));
	}

	// Token: 0x0600026B RID: 619 RVA: 0x000041F8 File Offset: 0x000023F8
	private static void smethod_98(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_74(class58_4);
	}

	// Token: 0x0600026C RID: 620 RVA: 0x000044E1 File Offset: 0x000026E1
	private int method_36()
	{
		return 588382534;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x000044E8 File Offset: 0x000026E8
	private static Exception smethod_99(string string_0, string string_1)
	{
		return new FieldAccessException(Class31.smethod_143("security transparent method '" + string_0 + "'", "security critical field '" + string_1 + "'"));
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0002ADA8 File Offset: 0x00028FA8
	private static void smethod_100(Class31 class31_0, Class58 class58_4)
	{
		Class64 @class = (Class64)class58_4;
		MethodBase methodBase_ = class31_0.method_58(@class.method_3());
		Class59 class2 = new Class59();
		class2.method_4(methodBase_);
		class31_0.method_74(class2);
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00004518 File Offset: 0x00002718
	private static bool smethod_101(uint uint_3, uint uint_4, uint uint_5)
	{
		return uint_3 >= uint_4 && uint_3 <= uint_4 + uint_5;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0002ADDC File Offset: 0x00028FDC
	private static void smethod_102(Class31 class31_0, Class58 class58_4)
	{
		Class77 @class = (Class77)class58_4;
		class31_0.method_30((int)@class.method_3());
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0002ADFC File Offset: 0x00028FFC
	private static void smethod_103(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (Class31.smethod_21(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0002AE34 File Offset: 0x00029034
	private void method_37(Stream stream_1, long long_1, string string_0)
	{
		int int_ = this.method_36();
		Class99 class97_ = new Class99(stream_1, int_);
		this.class8_1 = new Class8(class97_);
		if (string_0 != null)
		{
			long_1 = this.method_61(string_0);
		}
		Class97 @class = this.class8_1.method_0();
		Class97 obj = @class;
		lock (obj)
		{
			@class.vmethod_9(long_1, 0);
			this.method_28(this.class8_1);
			this.class50_0 = this.method_73(this.class8_1);
			this.class47_0 = Class31.smethod_184(this.class8_1);
			this.byte_0 = Class31.smethod_156(this.class8_1);
		}
		this.method_35();
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0002AEF0 File Offset: 0x000290F0
	private static void smethod_104(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Class103 @class = class31_0.method_85(int_);
		object obj;
		if (@class.method_0() == 0)
		{
			obj = class31_0.method_23(@class.method_2());
		}
		else
		{
			switch (@class.method_4().vmethod_0())
			{
			case 0:
				obj = class31_0.method_58(int_).MethodHandle;
				break;
			case 1:
				obj = class31_0.method_25(int_).FieldHandle;
				break;
			case 2:
				obj = class31_0.method_70(int_, true).TypeHandle;
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		Class61 class2 = new Class61();
		class2.method_4(obj);
		class31_0.method_74(class2);
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00004529 File Offset: 0x00002729
	private static void smethod_105(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(uint));
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0002AF9C File Offset: 0x0002919C
	private static Class129 smethod_106(Class31 class31_0)
	{
		Class58 @class = class31_0.method_102();
		Class58 class2 = class31_0.method_102();
		Class58 class3 = class31_0.method_102();
		if (@class.method_0() != 13)
		{
			throw new InvalidOperationException();
		}
		long long_ = ((Class69)@class).method_3();
		int num = class2.method_0();
		if (num != 7 && num != 9)
		{
			throw new InvalidOperationException();
		}
		byte[] byte_ = Class0.smethod_3(class2.vmethod_0());
		if (class3.method_0() != 1)
		{
			throw new InvalidOperationException();
		}
		int int_ = ((Class64)class3).method_3();
		Class129 class4 = new Class129();
		class4.method_0(int_);
		class4.method_1(byte_);
		class4.method_2(long_);
		return class4;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0002B034 File Offset: 0x00029234
	private static void smethod_107(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		class31_0.method_74(class31_0.method_18(class58_5));
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0002B058 File Offset: 0x00029258
	private static void smethod_108(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		class31_0.method_101(@class.vmethod_0());
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0002B078 File Offset: 0x00029278
	private static void smethod_109(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(new Class64((Class31.smethod_22(class58_6, class58_5) > false) ? 1 : 0));
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0002B0A8 File Offset: 0x000292A8
	private string method_38(int int_0)
	{
		Dictionary<int, object> obj = Class31.dictionary_3;
		string result;
		lock (obj)
		{
			bool flag2 = true;
			object obj2;
			if (Class31.dictionary_3.TryGetValue(int_0, out obj2))
			{
				result = (string)obj2;
			}
			else
			{
				Class103 @class = this.method_85(int_0);
				if (@class.method_0() == 0)
				{
					result = this.module_0.ResolveString(@class.method_2());
				}
				else
				{
					string text = ((Class18)@class.method_4()).method_0();
					if (flag2)
					{
						Class31.dictionary_3.Add(int_0, text);
					}
					result = text;
				}
			}
		}
		return result;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0002B148 File Offset: 0x00029348
	private void method_39(bool bool_2, bool bool_3)
	{
		Class58 class58_ = this.method_102();
		Class58 class58_2 = this.method_102();
		this.method_74(Class31.smethod_49(class58_2, class58_, bool_2, bool_3));
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0002B174 File Offset: 0x00029374
	private Stack<Class31.Class33> method_40()
	{
		Stack<Class31.Class33> stack = this.stack_0;
		if (stack == null)
		{
			stack = (this.stack_0 = new Stack<Class31.Class33>());
			stack.Push(new Class31.Class33
			{
				class8_0 = this.class8_0,
				class97_0 = this.class8_0.method_0(),
				long_0 = this.long_0
			});
		}
		return stack;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0002B1D0 File Offset: 0x000293D0
	private static void smethod_110(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		UIntPtr uintptr_;
		if (num <= 8)
		{
			if (num == 1)
			{
				uintptr_ = new UIntPtr((uint)((Class64)@class).method_3());
				goto IL_80;
			}
			if (num == 8)
			{
				uintptr_ = new UIntPtr((ulong)((Class70)@class).method_3());
				goto IL_80;
			}
		}
		else
		{
			if (num == 13)
			{
				uintptr_ = new UIntPtr((ulong)((Class69)@class).method_3());
				goto IL_80;
			}
			if (num == 19)
			{
				uintptr_ = new UIntPtr(Convert.ToUInt64(((Class73)@class).method_3()));
				goto IL_80;
			}
		}
		throw new InvalidOperationException();
		IL_80:
		Class60 class2 = new Class60();
		class2.method_4(uintptr_);
		class31_0.method_74(class2);
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0000453B File Offset: 0x0000273B
	private static void smethod_111(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_66(true, true);
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00004545 File Offset: 0x00002745
	private static void smethod_112(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_91((int)((Class77)class58_4).method_3());
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00004558 File Offset: 0x00002758
	private static void smethod_113(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_14(typeof(float));
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0000456A File Offset: 0x0000276A
	private bool method_41()
	{
		return this.class58_2 != null || this.stack_1.Count != 0;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00004584 File Offset: 0x00002784
	private static void smethod_114(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(uint));
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00004596 File Offset: 0x00002796
	private static void smethod_115(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_104((int)((Class66)class58_4).method_3());
	}

	// Token: 0x06000283 RID: 643 RVA: 0x000045A9 File Offset: 0x000027A9
	private static void smethod_116(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_45(true);
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0002B270 File Offset: 0x00029470
	private static Class58 smethod_117(Class58 class58_4, Class58 class58_5, bool bool_2)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				if (!bool_2)
				{
					int num = ((Class64)class58_4).method_3();
					int num2 = ((Class64)class58_5).method_3();
					return new Class64(num % num2);
				}
				int num3 = ((Class64)class58_4).method_3();
				uint num4 = (uint)((Class64)class58_5).method_3();
				return new Class64(num3 % (int)num4);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					return Class31.smethod_181(new Class69((long)((Class64)class58_4).method_3()), class58_5, bool_2);
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
					{
						return Class31.smethod_117(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2);
					}
					return Class31.smethod_181(new Class69((long)((Class64)class58_4).method_3()), new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2);
				}
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				return Class31.smethod_181(class58_4, class58_5, bool_2);
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_181(class58_4, new Class69((long)((Class64)class58_5).method_3()), bool_2);
			}
			if (class58_5.method_0() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					return Class31.smethod_181(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2);
				}
				return Class31.smethod_181(class58_4, new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2);
			}
		}
		if (class58_4.method_0() == 8 && class58_5.method_0() == 8)
		{
			Class70 @class = new Class70();
			@class.method_4(((Class70)class58_4).method_3() % ((Class70)class58_5).method_3());
			return @class;
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)))
		{
			return Class31.smethod_117(new Class64(Convert.ToInt32(class58_4.vmethod_0())), class58_5, bool_2);
		}
		return Class31.smethod_117(new Class69(Convert.ToInt64(class58_4.vmethod_0())), class58_5, bool_2);
	}

	// Token: 0x06000285 RID: 645 RVA: 0x000045B2 File Offset: 0x000027B2
	private static void smethod_118(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_104(0);
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0002B4D4 File Offset: 0x000296D4
	private static bool smethod_119(Class58 class58_4, Class58 class58_5)
	{
		bool result = false;
		int num = class58_4.method_0();
		if (num <= 8)
		{
			if (num != 1)
			{
				if (num == 8)
				{
					double num2 = ((Class70)class58_4).method_3();
					double num3 = ((Class70)class58_5).method_3();
					result = (!double.IsNaN(num2) && !double.IsNaN(num3) && num2 > num3);
				}
			}
			else
			{
				if (class58_5.method_0() == 19)
				{
					return Class31.smethod_119(class58_4, new Class64(Convert.ToInt32(((Class73)class58_5).method_3())));
				}
				result = (((Class64)class58_4).method_3() > ((Class64)class58_5).method_3());
			}
		}
		else if (num != 13)
		{
			if (num == 19)
			{
				return Class31.smethod_119(new Class69(Convert.ToInt64(((Class73)class58_4).method_3())), class58_5);
			}
		}
		else
		{
			if (class58_5.method_0() == 19)
			{
				return Class31.smethod_119(class58_4, new Class69(Convert.ToInt64(((Class73)class58_5).method_3())));
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_119(class58_4, new Class69((long)((Class64)class58_5).method_3()));
			}
			result = (((Class69)class58_4).method_3() > ((Class69)class58_5).method_3());
		}
		return result;
	}

	// Token: 0x06000287 RID: 647 RVA: 0x000045BB File Offset: 0x000027BB
	private static void smethod_120(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(sbyte));
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0002B604 File Offset: 0x00029804
	private static Class58 smethod_121(Class58 class58_4, Class58 class58_5, bool bool_2)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				if (!bool_2)
				{
					int num = ((Class64)class58_4).method_3();
					int num2 = ((Class64)class58_5).method_3();
					return new Class64(num >> (num2 & 31));
				}
				int num3 = ((Class64)class58_4).method_3();
				int num4 = ((Class64)class58_5).method_3();
				return new Class64(num3 >> (num4 & 31));
			}
			else if (class58_5.method_0() == 19)
			{
				return Class31.smethod_121(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2);
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 1)
			{
				if (!bool_2)
				{
					long num5 = ((Class69)class58_4).method_3();
					int num6 = ((Class64)class58_5).method_3();
					return new Class69(num5 >> (num6 & 63));
				}
				long num7 = ((Class69)class58_4).method_3();
				int num8 = ((Class64)class58_5).method_3();
				return new Class69(num7 >> (num8 & 63));
			}
			else if (class58_5.method_0() == 19)
			{
				return Class31.smethod_121(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2);
			}
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
		{
			return Class31.smethod_121(new Class64(Convert.ToInt32(class58_4.vmethod_0())), class58_5, bool_2);
		}
		return Class31.smethod_121(new Class69(Convert.ToInt64(class58_4.vmethod_0())), class58_5, bool_2);
	}

	// Token: 0x06000289 RID: 649 RVA: 0x000045CD File Offset: 0x000027CD
	private long method_42()
	{
		return this.class8_0.method_0().vmethod_4() + this.long_0;
	}

	// Token: 0x0600028A RID: 650 RVA: 0x000045E6 File Offset: 0x000027E6
	private static void smethod_122(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(byte));
	}

	// Token: 0x0600028B RID: 651 RVA: 0x000045F8 File Offset: 0x000027F8
	private static void smethod_123(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_102();
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00004601 File Offset: 0x00002801
	private static void smethod_124(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(ushort));
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0002B780 File Offset: 0x00029980
	private static void smethod_125(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		checked
		{
			short int_;
			if (num <= 1)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						int_ = (short)((uint)((Class64)@class).method_3());
						goto IL_A2;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (short)((uint)((int)((Class75)@class).method_3()));
						goto IL_A2;
					}
					int_ = (short)((ulong)((long)((Class75)@class).method_3()));
					goto IL_A2;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (short)((Class70)@class).method_3();
					goto IL_A2;
				}
				if (num == 13)
				{
					int_ = (short)((ulong)((Class69)@class).method_3());
					goto IL_A2;
				}
				if (num == 19)
				{
					int_ = (short)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_A2;
				}
			}
			throw new InvalidOperationException();
			IL_A2:
			class31_0.method_74(new Class64((int)int_));
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00004613 File Offset: 0x00002813
	private static void smethod_126(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_65(2);
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0000461C File Offset: 0x0000281C
	private static void smethod_127(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_30(0);
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00004625 File Offset: 0x00002825
	private static void smethod_128(Class31 class31_0, Class58 class58_4)
	{
		Debugger.Break();
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000462C File Offset: 0x0000282C
	private Class58 method_43()
	{
		return this.class58_2 ?? this.stack_1.Peek();
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00004643 File Offset: 0x00002843
	private static void smethod_129(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_88(true);
	}

	// Token: 0x06000293 RID: 659 RVA: 0x0000464C File Offset: 0x0000284C
	private static void smethod_130(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_91((int)((Class66)class58_4).method_3());
	}

	// Token: 0x06000294 RID: 660 RVA: 0x0000465F File Offset: 0x0000285F
	private static void smethod_131(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_65(0);
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0002B83C File Offset: 0x00029A3C
	private void method_44(bool bool_2)
	{
		uint num = this.uint_0;
		for (;;)
		{
			try
			{
				while (!this.bool_0)
				{
					if (this.nullable_0 != null)
					{
						this.uint_1 = this.nullable_0.Value;
						this.method_50((long)((ulong)this.uint_1));
						this.nullable_0 = null;
					}
					else if (this.uint_1 >= num)
					{
						break;
					}
					this.method_52();
				}
				break;
			}
			catch (object object_)
			{
				this.method_89(object_, 0U);
				if (!bool_2)
				{
					this.method_44(true);
					break;
				}
			}
		}
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0002B8D4 File Offset: 0x00029AD4
	private void method_45(bool bool_2)
	{
		Class58 class58_ = this.method_102();
		Class58 class58_2 = this.method_102();
		this.method_74(Class31.smethod_117(class58_2, class58_, bool_2));
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00003056 File Offset: 0x00001256
	private static bool smethod_132()
	{
		return false;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0002B900 File Offset: 0x00029B00
	private void method_46(bool bool_2)
	{
		Class58 @class = this.method_102();
		bool flag = IntPtr.Size == 4;
		int num = @class.method_0();
		IntPtr intptr_;
		if (num <= 8)
		{
			if (num != 1)
			{
				if (num == 8)
				{
					double num2 = ((Class70)@class).method_3();
					if (flag)
					{
						if (bool_2)
						{
							intptr_ = new IntPtr(checked((int)((ulong)num2)));
							goto IL_157;
						}
						intptr_ = new IntPtr((int)((ulong)num2));
						goto IL_157;
					}
					else
					{
						if (bool_2)
						{
							intptr_ = new IntPtr(checked((long)((ulong)num2)));
							goto IL_157;
						}
						intptr_ = new IntPtr((long)num2);
						goto IL_157;
					}
				}
			}
			else
			{
				int num3 = ((Class64)@class).method_3();
				if (flag)
				{
					if (bool_2)
					{
						intptr_ = new IntPtr(checked((int)((uint)num3)));
						goto IL_157;
					}
					intptr_ = new IntPtr(num3);
					goto IL_157;
				}
				else
				{
					if (bool_2)
					{
						intptr_ = new IntPtr((long)((ulong)(checked((uint)num3))));
						goto IL_157;
					}
					intptr_ = new IntPtr((long)((ulong)num3));
					goto IL_157;
				}
			}
		}
		else if (num != 13)
		{
			if (num == 19)
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(Convert.ToInt64(((Class73)@class).method_3()));
					goto IL_157;
				}
				intptr_ = new IntPtr(Convert.ToInt64(((Class73)@class).method_3()));
				goto IL_157;
			}
		}
		else
		{
			long num4 = ((Class69)@class).method_3();
			if (flag)
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((int)((ulong)num4)));
					goto IL_157;
				}
				intptr_ = new IntPtr((int)num4);
				goto IL_157;
			}
			else
			{
				if (bool_2)
				{
					intptr_ = new IntPtr(checked((long)((ulong)num4)));
					goto IL_157;
				}
				intptr_ = new IntPtr(num4);
				goto IL_157;
			}
		}
		throw new InvalidOperationException();
		IL_157:
		Class75 class2 = new Class75();
		class2.method_4(intptr_);
		this.method_74(class2);
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0002BA78 File Offset: 0x00029C78
	private static void smethod_133(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(class31_0.method_80(class58_6, class58_5));
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00004668 File Offset: 0x00002868
	private static bool smethod_134(object object_3)
	{
		return RemotingServices.IsTransparentProxy(object_3);
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0002BAA4 File Offset: 0x00029CA4
	private static void smethod_135(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		string string_ = class31_0.method_38(int_);
		Class71 @class = new Class71();
		@class.method_4(string_);
		class31_0.method_74(@class);
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00004670 File Offset: 0x00002870
	private static void smethod_136(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_87(class58_4);
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0002BAD8 File Offset: 0x00029CD8
	private static Class58 smethod_137(Class58 class58_4, Class58 class58_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class69)class58_4).method_3();
			long num2 = ((Class69)class58_5).method_3();
			long long_;
			if (bool_2)
			{
				long_ = checked(num + num2);
			}
			else
			{
				long_ = num + num2;
			}
			return new Class69(long_);
		}
		ulong num3 = (ulong)((Class69)class58_4).method_3();
		ulong num4 = (ulong)((Class69)class58_5).method_3();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 + num4);
		}
		else
		{
			long_2 = num3 + num4;
		}
		return new Class69((long)long_2);
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00004679 File Offset: 0x00002879
	private static void smethod_138(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_6(true, false);
	}

	// Token: 0x0600029F RID: 671 RVA: 0x0002BB48 File Offset: 0x00029D48
	private void method_47(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		long long_;
		if (num <= 1)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					if (bool_2)
					{
						long_ = (long)((Class64)@class).method_3();
						goto IL_EA;
					}
					long_ = (long)((Class64)@class).method_3();
					goto IL_EA;
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = (long)((Class75)@class).method_3();
					goto IL_EA;
				}
				long_ = (long)((Class75)@class).method_3();
				goto IL_EA;
			}
		}
		else if (num != 8)
		{
			if (num != 13)
			{
				if (num == 19)
				{
					if (bool_2)
					{
						long_ = checked((long)Convert.ToUInt64(((Class73)@class).method_3()));
						goto IL_EA;
					}
					long_ = (long)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_EA;
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = ((Class69)@class).method_3();
					goto IL_EA;
				}
				long_ = ((Class69)@class).method_3();
				goto IL_EA;
			}
		}
		else
		{
			if (bool_2)
			{
				long_ = checked((long)((Class70)@class).method_3());
				goto IL_EA;
			}
			long_ = (long)((Class70)@class).method_3();
			goto IL_EA;
		}
		throw new InvalidOperationException();
		IL_EA:
		Class69 class2 = new Class69();
		class2.method_4(long_);
		this.method_74(class2);
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0002BC54 File Offset: 0x00029E54
	private static void smethod_139(Class31 class31_0, Class58 class58_4)
	{
		object object_ = class31_0.method_102().vmethod_0();
		long num = class31_0.method_22();
		Array array = (Array)class31_0.method_102().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(short))
			{
				Class58 @class = Class58.smethod_0(object_, typeof(short));
				((short[])array)[(int)((IntPtr)num)] = (short)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(ushort))
			{
				Class58 class2 = Class58.smethod_0(object_, typeof(ushort));
				((ushort[])array)[(int)((IntPtr)num)] = (ushort)class2.vmethod_0();
				return;
			}
			if (elementType == typeof(char))
			{
				Class58 class3 = Class58.smethod_0(object_, typeof(char));
				((char[])array)[(int)((IntPtr)num)] = (char)class3.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class31_0.method_9(elementType, object_, num, array);
				return;
			}
			class31_0.method_9(typeof(short), object_, num, array);
		}
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0002BD68 File Offset: 0x00029F68
	private static void smethod_140(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type elementType = class31_0.method_70(int_, true);
		Class58 @class = class31_0.method_102();
		Class64 class2 = @class as Class64;
		int length;
		if (class2 != null)
		{
			length = class2.method_3();
		}
		else
		{
			Class75 class3 = @class as Class75;
			if (class3 != null)
			{
				length = class3.method_3().ToInt32();
			}
			else
			{
				Class60 class4 = @class as Class60;
				if (class4 == null)
				{
					throw new Exception();
				}
				length = (int)class4.method_3().ToUInt32();
			}
		}
		Array array_ = Array.CreateInstance(elementType, length);
		Class78 class5 = new Class78();
		class5.method_4(array_);
		class31_0.method_74(class5);
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_141(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00004683 File Offset: 0x00002883
	private void method_48()
	{
		this.bool_0 = true;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000468C File Offset: 0x0000288C
	private static void smethod_142(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(double));
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0002BE04 File Offset: 0x0002A004
	private void method_49(Type type_10)
	{
		Class79 class79_ = (Class79)this.method_102();
		this.method_74(Class58.smethod_0(this.method_72(class79_).vmethod_0(), type_10));
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0002BE38 File Offset: 0x0002A038
	private static string smethod_143(string string_0, string string_1)
	{
		string fullName = typeof(Class31).Assembly.FullName;
		return string.Concat(new string[]
		{
			"Attempt by ",
			string_0,
			" to access ",
			string_1,
			" failed.",
			Environment.NewLine,
			Environment.NewLine,
			"Assembly '",
			fullName,
			"' is marked with the AllowPartiallyTrustedCallersAttribute, and uses the level 2 security transparency model. Level 2 transparency causes all methods in AllowPartiallyTrustedCallers assemblies to become security transparent by default, which may be the cause of this exception."
		});
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
	private static void smethod_144(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(new Class64((Class31.smethod_21(class58_6, class58_5) > false) ? 1 : 0));
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0002BEE0 File Offset: 0x0002A0E0
	private static bool smethod_145(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType.IsByRef)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000469E File Offset: 0x0000289E
	private void method_50(long long_1)
	{
		this.class8_0.method_0().vmethod_5(long_1 - this.long_0);
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0002BF18 File Offset: 0x0002A118
	private static void smethod_146(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 @class = class31_0.method_102();
		bool flag;
		if (@class.method_0() == 8)
		{
			flag = !Class31.smethod_22(@class, class58_5);
		}
		else
		{
			flag = !Class31.smethod_119(@class, class58_5);
		}
		if (flag)
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x060002AB RID: 683 RVA: 0x000046B8 File Offset: 0x000028B8
	private static void smethod_147(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_82(false);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0002BF6C File Offset: 0x0002A16C
	private static void smethod_148(Class31 class31_0, Class58 class58_4)
	{
		Class70 @class = (Class70)class31_0.method_102();
		if (double.IsNaN(@class.method_3()) || double.IsInfinity(@class.method_3()))
		{
			throw new OverflowException("The value is not finite real number.");
		}
		class31_0.method_74(@class);
	}

	// Token: 0x060002AD RID: 685 RVA: 0x000046C1 File Offset: 0x000028C1
	private static void smethod_149(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(2);
	}

	// Token: 0x060002AE RID: 686 RVA: 0x000041F8 File Offset: 0x000023F8
	private static void smethod_150(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_74(class58_4);
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0002BFB4 File Offset: 0x0002A1B4
	private static void smethod_151(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type_ = class31_0.method_70(int_, true);
		class31_0.method_49(type_);
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0002BFE0 File Offset: 0x0002A1E0
	private static Class58 smethod_152(Class58 class58_4, Class58 class58_5, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class69)class58_4).method_3();
			long num2 = ((Class69)class58_5).method_3();
			return new Class69(num / num2);
		}
		long num3 = ((Class69)class58_4).method_3();
		ulong num4 = (ulong)((Class69)class58_5).method_3();
		return new Class69(num3 / (long)num4);
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x000046CA File Offset: 0x000028CA
	private static void smethod_153(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_30(3);
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x000046D3 File Offset: 0x000028D3
	private static void smethod_154(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Refanyval is not supported.");
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0002C030 File Offset: 0x0002A230
	private Type method_51(int int_0, Class103 class103_0, ref bool bool_2, bool bool_3)
	{
		if (class103_0.method_0() == 0)
		{
			return this.module_0.ResolveType(class103_0.method_2());
		}
		Class14 @class = (Class14)class103_0.method_4();
		Type type = null;
		if (@class.method_2())
		{
			if (@class.method_10() != -1)
			{
				if (this.type_6 == null)
				{
					throw new InvalidOperationException("EF-VM-0521");
				}
				type = this.type_6[@class.method_10()];
			}
			else
			{
				if (@class.method_8() == -1)
				{
					throw new Exception();
				}
				if (this.type_7 == null)
				{
					throw new InvalidOperationException("EF-VM-0522");
				}
				type = this.type_7[@class.method_8()];
			}
			Stack<Struct5> stack = Class29.smethod_4(@class.method_0());
			type = Class29.smethod_5(type, stack);
			bool_2 = false;
			return type;
		}
		string text = @class.method_0();
		try
		{
			type = Type.GetType(text);
		}
		catch (BadImageFormatException)
		{
		}
		if (type == null)
		{
			int num = text.IndexOf(',');
			string text2 = text.Substring(0, num);
			string text3 = text.Substring(num + 1).Trim();
			Assembly assembly_ = Class29.assembly_0;
			if (text3.Equals(assembly_.FullName, StringComparison.OrdinalIgnoreCase))
			{
				if (text2.Equals("<Module>", StringComparison.Ordinal))
				{
					type = Class31.type_4;
				}
				else
				{
					type = assembly_.GetType(text2);
				}
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				int i = 0;
				while (i < assemblies.Length)
				{
					Assembly assembly = assemblies[i];
					string value = null;
					try
					{
						value = assembly.Location;
						goto IL_190;
					}
					catch (NotSupportedException)
					{
						goto IL_190;
					}
					goto IL_167;
					IL_18A:
					i++;
					continue;
					IL_167:
					if (!assembly.FullName.Equals(text3, StringComparison.OrdinalIgnoreCase))
					{
						goto IL_18A;
					}
					type = assembly.GetType(text2);
					if (!(type != null))
					{
						goto IL_18A;
					}
					break;
					IL_190:
					if (string.IsNullOrEmpty(value))
					{
						goto IL_167;
					}
					goto IL_18A;
				}
			}
			if (type == null && text2.StartsWith("<PrivateImplementationDetails><", StringComparison.Ordinal) && text2.Contains("."))
			{
				try
				{
					foreach (Type type2 in Assembly.Load(text3).GetTypes())
					{
						if (type2.FullName == text2)
						{
							type = type2;
							break;
						}
					}
				}
				catch
				{
				}
			}
		}
		if (type == null)
		{
			throw new TypeLoadException(string.Format("Cannot load type '{0}'.", text));
		}
		if (@class.method_4())
		{
			if (@class.method_6().Length != 0)
			{
				Type[] array = new Type[@class.method_6().Length];
				for (int j = 0; j < @class.method_6().Length; j++)
				{
					array[j] = this.method_70(@class.method_6()[j].method_2(), bool_3);
				}
				Type genericTypeDefinition = Class29.smethod_1(type).GetGenericTypeDefinition();
				Stack<Struct5> stack2 = Class29.smethod_3(type);
				type = genericTypeDefinition.MakeGenericType(array);
				type = Class29.smethod_5(type, stack2);
			}
			bool_2 = false;
		}
		return type;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x000046E0 File Offset: 0x000028E0
	private static void smethod_155(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_39(true, false);
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0002C308 File Offset: 0x0002A508
	private static byte[] smethod_156(Class8 class8_2)
	{
		int num = class8_2.method_19();
		byte[] array = new byte[num];
		class8_2.method_14(array, 0, num);
		return array;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0002C330 File Offset: 0x0002A530
	private static void smethod_157(Class31 class31_0, Class58 class58_4)
	{
		Class66 @class = (Class66)class58_4;
		class31_0.method_30((int)@class.method_3());
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x000046EA File Offset: 0x000028EA
	private static void smethod_158(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Arglist is not supported.");
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0002C350 File Offset: 0x0002A550
	private void method_52()
	{
		this.uint_2 = this.uint_1;
		int key = this.class8_0.method_19();
		this.uint_1 += 4U;
		Class31.Struct12 @struct;
		Class31.dictionary_0.TryGetValue(key, out @struct);
		@struct.delegate0_0(this, this.method_24(this.class8_0, @struct.byte_0));
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0002C3B0 File Offset: 0x0002A5B0
	private void method_53()
	{
		if (this.class50_0.method_12())
		{
			Type type = this.method_70(this.class50_0.method_6(), false);
			if (type != null)
			{
				RuntimeHelpers.RunClassConstructor(type.TypeHandle);
			}
		}
	}

	// Token: 0x060002BA RID: 698 RVA: 0x000041F8 File Offset: 0x000023F8
	private static void smethod_159(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_74(class58_4);
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0000311B File Offset: 0x0000131B
	private static void smethod_160(Class31 class31_0, Class58 class58_4)
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x000046F7 File Offset: 0x000028F7
	private static void smethod_161(ILGenerator ilgenerator_0, Type type_10)
	{
		if (type_10.IsValueType || Class29.smethod_1(type_10).IsGenericParameter)
		{
			ilgenerator_0.Emit(OpCodes.Box, type_10);
		}
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0000471A File Offset: 0x0000291A
	private void method_54(int int_0)
	{
		this.method_74(new Class64(int_0));
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00004728 File Offset: 0x00002928
	private static void smethod_162(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(Class31.type_2);
	}

	// Token: 0x060002BF RID: 703 RVA: 0x0002C3F4 File Offset: 0x0002A5F4
	private static void smethod_163(Class31 class31_0, Class58 class58_4)
	{
		Class64 @class = (Class64)class58_4;
		MethodBase methodBase_ = class31_0.method_58(@class.method_3());
		foreach (Class58 class58_5 in class31_0.class58_3)
		{
			class31_0.method_74(class58_5);
		}
		class31_0.method_5(methodBase_, false);
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00004735 File Offset: 0x00002935
	private static void smethod_164(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_29(false);
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0002C444 File Offset: 0x0002A644
	private static object smethod_165(MethodBase methodBase_0, object object_3, object[] object_4, bool bool_2)
	{
		Class31.Struct10 struct10_ = new Class31.Struct10(methodBase_0, bool_2);
		Class31.Delegate21 @delegate = Class31.smethod_47(struct10_);
		if (@delegate == null)
		{
			Dictionary<MethodBase, int> obj = Class31.dictionary_2;
			bool flag2;
			lock (obj)
			{
				int num;
				Class31.dictionary_2.TryGetValue(methodBase_0, out num);
				if (!(flag2 = (num >= 50)))
				{
					Class31.dictionary_2[methodBase_0] = num + 1;
				}
			}
			if (!(flag2 = (flag2 || (!bool_2 && object_3 == null && !methodBase_0.IsStatic && !methodBase_0.IsConstructor) || Class31.smethod_145(methodBase_0) || (methodBase_0.CallingConvention & CallingConventions.Any) == CallingConventions.VarArgs)))
			{
				return Class31.smethod_249(methodBase_0, object_3, object_4);
			}
			@delegate = Class31.smethod_229(struct10_);
			obj = Class31.dictionary_2;
			lock (obj)
			{
				Class31.dictionary_2.Remove(methodBase_0);
			}
		}
		return @delegate(object_3, object_4);
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0000473E File Offset: 0x0000293E
	private static void smethod_166(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_65(1);
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0002C540 File Offset: 0x0002A740
	private void method_55(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		int int_;
		if (num <= 1)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					if (bool_2)
					{
						int_ = ((Class64)@class).method_3();
						goto IL_12C;
					}
					int_ = ((Class64)@class).method_3();
					goto IL_12C;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = (int)((Class75)@class).method_3();
					goto IL_12C;
				}
				int_ = (int)((Class75)@class).method_3();
				goto IL_12C;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((int)((long)((Class75)@class).method_3()));
					goto IL_12C;
				}
				int_ = (int)((long)((Class75)@class).method_3());
				goto IL_12C;
			}
		}
		else if (num != 8)
		{
			if (num != 13)
			{
				if (num == 19)
				{
					if (bool_2)
					{
						int_ = checked((int)Convert.ToUInt64(((Class73)@class).method_3()));
						goto IL_12C;
					}
					int_ = (int)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_12C;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((int)((Class69)@class).method_3());
					goto IL_12C;
				}
				int_ = (int)((Class69)@class).method_3();
				goto IL_12C;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((int)((Class70)@class).method_3());
				goto IL_12C;
			}
			int_ = (int)((Class70)@class).method_3();
			goto IL_12C;
		}
		throw new InvalidOperationException();
		IL_12C:
		Class64 class2 = new Class64();
		class2.method_4(int_);
		this.method_74(class2);
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0000311B File Offset: 0x0000131B
	private static void smethod_167(Class31 class31_0, Class58 class58_4)
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0002C68C File Offset: 0x0002A88C
	private void method_56(ref Class31.Struct11 struct11_0, MethodBase methodBase_0, bool bool_2)
	{
		bool flag = false;
		if (methodBase_0.DeclaringType == typeof(Interlocked) && methodBase_0.IsStatic)
		{
			string name = methodBase_0.Name;
			if (name == "Add" || name == "CompareExchange" || name == "Decrement" || name == "Exchange" || name == "Increment" || name == "Read")
			{
				flag = true;
			}
		}
		if (flag)
		{
			try
			{
			}
			finally
			{
				Monitor.Enter(Class31.object_0);
				struct11_0.bool_0 = true;
			}
		}
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00004747 File Offset: 0x00002947
	private void method_57(Stream stream_1, string string_0)
	{
		this.method_37(stream_1, 0L, string_0);
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0000475A File Offset: 0x0000295A
	private static void smethod_168(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_48();
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0002C740 File Offset: 0x0002A940
	[DebuggerNonUserCode]
	private MethodBase method_58(int int_0)
	{
		Class103 class103_ = this.method_85(int_0);
		MethodBase methodBase = this.method_90(int_0, class103_);
		this.method_94(methodBase);
		return methodBase;
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00004762 File Offset: 0x00002962
	private static void smethod_169(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_82(true);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0002C768 File Offset: 0x0002A968
	private static void smethod_170(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		checked
		{
			int int_;
			if (num <= 1)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						int_ = (int)((uint)((Class64)@class).method_3());
						goto IL_A2;
					}
				}
				else
				{
					if (IntPtr.Size == 4)
					{
						int_ = (int)((uint)((int)((Class75)@class).method_3()));
						goto IL_A2;
					}
					int_ = (int)((ulong)((long)((Class75)@class).method_3()));
					goto IL_A2;
				}
			}
			else
			{
				if (num == 8)
				{
					int_ = (int)((Class70)@class).method_3();
					goto IL_A2;
				}
				if (num == 13)
				{
					int_ = (int)((ulong)((Class69)@class).method_3());
					goto IL_A2;
				}
				if (num == 19)
				{
					int_ = (int)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_A2;
				}
			}
			throw new InvalidOperationException();
			IL_A2:
			class31_0.method_74(new Class64(int_));
		}
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0000476B File Offset: 0x0000296B
	private int method_59()
	{
		return -421764358;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000311B File Offset: 0x0000131B
	[Conditional("DEBUG")]
	private void method_60(object object_3)
	{
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0002C824 File Offset: 0x0002AA24
	private long method_61(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream(Class46.smethod_0(string_0));
		long result = new Class8(new Class99(memoryStream, this.method_59())).method_21();
		memoryStream.Dispose();
		return result;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0002C85C File Offset: 0x0002AA5C
	public static void smethod_171<T>(T[] gparam_0, Comparison<T> comparison_0)
	{
		KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[gparam_0.Length];
		for (int i = 0; i < gparam_0.Length; i++)
		{
			array[i] = new KeyValuePair<int, T>(i, gparam_0[i]);
		}
		Array.Sort<KeyValuePair<int, T>, T>(array, gparam_0, new Class31.Class36<T>(comparison_0));
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_172(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
	private static void smethod_173(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		checked
		{
			IntPtr intptr_;
			if (num <= 8)
			{
				if (num == 1)
				{
					intptr_ = new IntPtr((long)(unchecked((ulong)(checked((uint)((Class64)@class).method_3())))));
					goto IL_85;
				}
				if (num == 8)
				{
					intptr_ = new IntPtr((long)((Class70)@class).method_3());
					goto IL_85;
				}
			}
			else
			{
				if (num == 13)
				{
					intptr_ = new IntPtr((long)((ulong)((Class69)@class).method_3()));
					goto IL_85;
				}
				if (num == 19)
				{
					intptr_ = new IntPtr((long)Convert.ToUInt64(((Class73)@class).method_3()));
					goto IL_85;
				}
			}
			throw new InvalidOperationException();
			IL_85:
			Class75 class2 = new Class75();
			class2.method_4(intptr_);
			class31_0.method_74(class2);
		}
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00004772 File Offset: 0x00002972
	private static void smethod_174(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_6(true, true);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000477C File Offset: 0x0000297C
	public object method_62(Stream stream_1, string string_0, object[] object_3, Type[] type_10, Type[] type_11, object[] object_4)
	{
		this.stream_0 = stream_1;
		this.method_57(stream_1, string_0);
		return this.method_17(object_3, type_10, type_11, object_4);
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0002C948 File Offset: 0x0002AB48
	private static void smethod_175(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type = class31_0.method_70(int_, true);
		Class58 class58_5 = Class58.smethod_0(class31_0.method_102().vmethod_0(), type);
		class31_0.method_74(class58_5);
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000479A File Offset: 0x0000299A
	private static void smethod_176(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_11(false);
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0002C984 File Offset: 0x0002AB84
	private string method_63(Class50 class50_1)
	{
		Type type = this.method_70(class50_1.method_6(), false);
		Class49[] array = class50_1.method_2();
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string[] array3 = array2;
			int num = i;
			Type type2 = this.method_70(array[i].method_0(), false);
			array3[num] = ((type2 != null) ? type2.FullName : null);
		}
		string text = string.Join(", ", array2);
		return string.Concat(new string[]
		{
			type.FullName,
			".",
			class50_1.method_4(),
			"(",
			text,
			")"
		});
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x000047A3 File Offset: 0x000029A3
	public void method_64(Stream stream_1, string string_0, object[] object_3)
	{
		this.method_105(stream_1, string_0, object_3);
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x000047AF File Offset: 0x000029AF
	private static Exception smethod_177(string string_0, string string_1)
	{
		return new MethodAccessException(Class31.smethod_143("security transparent method '" + string_0 + "'", "security critical method '" + string_1 + "'"));
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x000047DF File Offset: 0x000029DF
	public static object smethod_178(Type type_10)
	{
		if (type_10.IsValueType)
		{
			return Activator.CreateInstance(type_10);
		}
		return null;
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x000047F1 File Offset: 0x000029F1
	private static void smethod_179(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(long));
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00004803 File Offset: 0x00002A03
	private void method_65(int int_0)
	{
		this.method_74(this.class58_0[int_0].vmethod_3());
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000481C File Offset: 0x00002A1C
	private static void smethod_180(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_104(1);
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0002CA2C File Offset: 0x0002AC2C
	private static Class58 smethod_181(Class58 class58_4, Class58 class58_5, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class69)class58_4).method_3();
			long num2 = ((Class69)class58_5).method_3();
			return new Class69(num % num2);
		}
		long num3 = ((Class69)class58_4).method_3();
		ulong num4 = (ulong)((Class69)class58_5).method_3();
		return new Class69(num3 % (long)num4);
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0002CA7C File Offset: 0x0002AC7C
	private void method_66(bool bool_2, bool bool_3)
	{
		Class58 class58_ = this.method_102();
		Class58 class58_2 = this.method_102();
		this.method_74(Class31.smethod_224(class58_2, class58_, bool_2, bool_3));
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
	private static Class31.Delegate21 smethod_182(MethodBase methodBase_0, bool bool_2)
	{
		DynamicMethod dynamicMethod = null;
		if (dynamicMethod == null)
		{
			dynamicMethod = new DynamicMethod(string.Empty, Class29.type_0, new Type[]
			{
				Class29.type_0,
				Class31.type_0
			}, typeof(Class31).Module, true);
		}
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Type[] array = new Type[parameters.Length];
		bool flag = false;
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type.IsByRef)
			{
				flag = true;
				type = type.GetElementType();
			}
			array[i] = type;
		}
		LocalBuilder[] array2 = new LocalBuilder[array.Length];
		if (array2.Length != 0)
		{
			dynamicMethod.InitLocals = true;
		}
		for (int j = 0; j < array.Length; j++)
		{
			array2[j] = ilgenerator.DeclareLocal(array[j]);
		}
		for (int k = 0; k < array.Length; k++)
		{
			ilgenerator.Emit(OpCodes.Ldarg_1);
			Class31.smethod_87(ilgenerator, k);
			ilgenerator.Emit(OpCodes.Ldelem_Ref);
			Class31.smethod_210(ilgenerator, array[k]);
			ilgenerator.Emit(OpCodes.Stloc, array2[k]);
		}
		if (flag)
		{
			ilgenerator.BeginExceptionBlock();
		}
		if (!methodBase_0.IsStatic && !methodBase_0.IsConstructor)
		{
			ilgenerator.Emit(OpCodes.Ldarg_0);
			Type declaringType = methodBase_0.DeclaringType;
			if (declaringType.IsValueType)
			{
				ilgenerator.Emit(OpCodes.Unbox, declaringType);
				bool_2 = false;
			}
			else
			{
				Class31.smethod_30(ilgenerator, declaringType);
			}
		}
		for (int l = 0; l < array.Length; l++)
		{
			if (parameters[l].ParameterType.IsByRef)
			{
				ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
			}
			else
			{
				ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
			}
		}
		if (methodBase_0.IsConstructor)
		{
			ilgenerator.Emit(OpCodes.Newobj, (ConstructorInfo)methodBase_0);
			Class31.smethod_161(ilgenerator, methodBase_0.DeclaringType);
		}
		else
		{
			MethodInfo methodInfo = (MethodInfo)methodBase_0;
			if (bool_2 && !methodBase_0.IsStatic)
			{
				ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
			}
			else
			{
				ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
			}
			if (methodInfo.ReturnType == Class31.type_8)
			{
				ilgenerator.Emit(OpCodes.Ldnull);
			}
			else
			{
				Class31.smethod_161(ilgenerator, methodInfo.ReturnType);
			}
		}
		if (flag)
		{
			LocalBuilder local = ilgenerator.DeclareLocal(Class29.type_0);
			ilgenerator.Emit(OpCodes.Stloc, local);
			ilgenerator.BeginFinallyBlock();
			for (int m = 0; m < array.Length; m++)
			{
				if (parameters[m].ParameterType.IsByRef)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class31.smethod_87(ilgenerator, m);
					ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType || Class29.smethod_1(array2[m].LocalType).IsGenericParameter)
					{
						ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					ilgenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			ilgenerator.EndExceptionBlock();
			ilgenerator.Emit(OpCodes.Ldloc, local);
		}
		ilgenerator.Emit(OpCodes.Ret);
		return (Class31.Delegate21)dynamicMethod.CreateDelegate(typeof(Class31.Delegate21));
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0002CE04 File Offset: 0x0002B004
	private static void smethod_183(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(class31_0.method_19(class58_6, class58_5));
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0002CE30 File Offset: 0x0002B030
	private static Class47[] smethod_184(Class8 class8_2)
	{
		int num = (int)class8_2.method_23();
		Class47[] array = new Class47[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = Class31.smethod_250(class8_2);
		}
		return array;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0002CE68 File Offset: 0x0002B068
	private void method_67(Class50 class50_1)
	{
		if (Class31.smethod_132() && !this.class50_0.method_13() && class50_1.method_13() && !class50_1.method_14())
		{
			string string_ = this.method_63(class50_1);
			throw Class31.smethod_177(this.method_63(this.class50_0), string_);
		}
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00004825 File Offset: 0x00002A25
	private static void smethod_185(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_47(true);
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0000482E File Offset: 0x00002A2E
	private static void smethod_186(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_11(true);
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
	private Class58[] method_68()
	{
		Class86[] array = this.class50_0.method_0();
		int num = array.Length;
		Class58[] array2 = new Class58[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = Class58.smethod_0(null, this.method_70(array[i].method_0(), false));
		}
		return array2;
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0002CF08 File Offset: 0x0002B108
	private static void smethod_187(Class31 class31_0, Class58 class58_4)
	{
		uint uint_ = ((Class65)class58_4).method_3();
		class31_0.method_31(uint_);
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0002CF28 File Offset: 0x0002B128
	private bool method_69(Type type_10, Class103 class103_0, out int int_0)
	{
		int_0 = 0;
		Class14 @class = (Class14)class103_0.method_4();
		if (Class29.smethod_1(type_10).IsGenericParameter)
		{
			return @class == null || @class.method_2();
		}
		Type type = this.method_70(class103_0.method_2(), false);
		return Class101.smethod_0(type_10, type, out int_0);
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00004837 File Offset: 0x00002A37
	private static void smethod_188(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_46(false);
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0002CF7C File Offset: 0x0002B17C
	private Type method_70(int int_0, bool bool_2)
	{
		Dictionary<int, object> obj = Class31.dictionary_3;
		Type type;
		lock (obj)
		{
			bool flag2 = true;
			object obj2;
			if (Class31.dictionary_3.TryGetValue(int_0, out obj2))
			{
				type = (Type)obj2;
			}
			else
			{
				Class103 class103_ = this.method_85(int_0);
				type = this.method_51(int_0, class103_, ref flag2, bool_2);
				if (flag2)
				{
					Class31.dictionary_3.Add(int_0, type);
				}
			}
		}
		if (bool_2)
		{
			this.method_94(type);
		}
		return type;
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00004840 File Offset: 0x00002A40
	private static void smethod_189(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_13((int)((Class77)class58_4).method_3());
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0000311B File Offset: 0x0000131B
	private static void smethod_190(Class31 class31_0, Class58 class58_4)
	{
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00004853 File Offset: 0x00002A53
	private static void smethod_191(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_106(true);
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0000485C File Offset: 0x00002A5C
	private static void smethod_192(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_14(Class29.type_0);
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00004869 File Offset: 0x00002A69
	private static void smethod_193(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_55(false);
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00004872 File Offset: 0x00002A72
	private static void smethod_194(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_66(false, false);
	}

	// Token: 0x060002EF RID: 751 RVA: 0x0002D000 File Offset: 0x0002B200
	private void method_71(Class16 class16_0)
	{
		Class103 class103_ = this.method_85(class16_0.method_2());
		MethodBase methodBase = this.method_90(class16_0.method_2(), class103_);
		int num = class16_0.method_0();
		bool bool_ = (num & 1073741824) != 0;
		num &= -1073741825;
		Type[] array = this.type_6;
		Type[] array2 = this.type_7;
		try
		{
			this.type_6 = ((methodBase is ConstructorInfo) ? null : methodBase.GetGenericArguments());
			this.type_7 = methodBase.DeclaringType.GetGenericArguments();
			this.method_103(num, this.type_6, this.type_7, bool_);
		}
		finally
		{
			this.type_6 = array;
			this.type_7 = array2;
		}
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x0002D0B4 File Offset: 0x0002B2B4
	private static bool smethod_195(Class58 class58_4, Class58 class58_5)
	{
		bool result = false;
		int num = class58_4.method_0();
		if (num <= 8)
		{
			if (num != 1)
			{
				if (num == 8)
				{
					result = (((Class70)class58_4).method_3() < ((Class70)class58_5).method_3());
				}
			}
			else
			{
				if (class58_5.method_0() == 19)
				{
					return Class31.smethod_195(class58_4, new Class64(Convert.ToInt32(((Class73)class58_5).method_3())));
				}
				result = (((Class64)class58_4).method_3() < ((Class64)class58_5).method_3());
			}
		}
		else if (num != 13)
		{
			if (num == 19)
			{
				return Class31.smethod_195(new Class69(Convert.ToInt64(((Class73)class58_4).method_3())), class58_5);
			}
		}
		else
		{
			if (class58_5.method_0() == 19)
			{
				return Class31.smethod_195(class58_4, new Class69(Convert.ToInt64(((Class73)class58_5).method_3())));
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_195(class58_4, new Class69((long)((Class64)class58_5).method_3()));
			}
			result = (((Class69)class58_4).method_3() < ((Class69)class58_5).method_3());
		}
		return result;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
	private static void smethod_196(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		FieldInfo fieldInfo_ = class31_0.method_25(int_);
		Class58 @class = class31_0.method_102();
		Class79 class2 = @class as Class79;
		object obj;
		if (class2 != null)
		{
			obj = class31_0.method_72(class2).vmethod_0();
		}
		else
		{
			obj = @class.vmethod_0();
		}
		class31_0.method_74(new Class81(fieldInfo_, obj, class2));
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x0000487C File Offset: 0x00002A7C
	private static void smethod_197(Class31 class31_0, Class58 class58_4)
	{
		throw new NotSupportedException("Cpblk not supported.");
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00004889 File Offset: 0x00002A89
	private static void smethod_198(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(ushort));
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0000489B File Offset: 0x00002A9B
	private static void smethod_199(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_104(3);
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0002D220 File Offset: 0x0002B420
	private static void smethod_200(Class31 class31_0, Class58 class58_4)
	{
		object object_ = class31_0.method_102().vmethod_0();
		long num = class31_0.method_22();
		Array array = (Array)class31_0.method_102().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(int))
			{
				Class58 @class = Class58.smethod_0(object_, typeof(int));
				((int[])array)[(int)((IntPtr)num)] = (int)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(uint))
			{
				Class58 class2 = Class58.smethod_0(object_, typeof(uint));
				((uint[])array)[(int)((IntPtr)num)] = (uint)class2.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class31_0.method_9(elementType, object_, num, array);
				return;
			}
			class31_0.method_9(typeof(int), object_, num, array);
		}
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x000048A4 File Offset: 0x00002AA4
	private static void smethod_201(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(typeof(float));
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0002D2F8 File Offset: 0x0002B4F8
	private static void smethod_202(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type = class31_0.method_70(int_, true);
		Class79 @class = (Class79)class31_0.method_102();
		if (!type.IsValueType)
		{
			class31_0.method_27(@class, new Class61());
			return;
		}
		object obj = class31_0.method_72(@class).vmethod_0();
		if (Class29.smethod_0(type))
		{
			Class79 class79_ = @class;
			Class61 class2 = new Class61();
			class2.method_2(type);
			class31_0.method_27(class79_, class2);
			return;
		}
		foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
		{
			fieldInfo.SetValue(obj, Class31.smethod_178(fieldInfo.FieldType));
		}
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0002D39C File Offset: 0x0002B59C
	private Class58 method_72(Class79 class79_0)
	{
		int num = class79_0.method_0();
		if (num <= 11)
		{
			if (num == 2)
			{
				return ((Class85)class79_0).method_3();
			}
			if (num == 11)
			{
				goto IL_38;
			}
		}
		else
		{
			if (num == 18)
			{
				Class81 @class = (Class81)class79_0;
				return Class58.smethod_0(@class.method_5().GetValue(@class.method_3()), null);
			}
			if (num == 23)
			{
				return this.class58_0[((Class80)class79_0).method_3()];
			}
			if (num == 24)
			{
				goto IL_38;
			}
		}
		throw new ArgumentOutOfRangeException();
		IL_38:
		Class82 class2 = (Class82)class79_0;
		return Class58.smethod_0(class2.vmethod_4(), class2.method_3());
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x000048B6 File Offset: 0x00002AB6
	private static void smethod_203(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_34(Class29.type_0);
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0002D430 File Offset: 0x0002B630
	private Class50 method_73(Class8 class8_2)
	{
		Class50 @class = new Class50();
		@class.method_3(this.method_12(class8_2));
		@class.method_1(this.method_86(class8_2));
		@class.method_9(class8_2.method_19());
		@class.method_11(class8_2.method_6());
		@class.method_7(class8_2.method_19());
		@class.method_5(class8_2.method_9());
		return @class;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x000048C3 File Offset: 0x00002AC3
	private static void smethod_204(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_107(false);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0002D48C File Offset: 0x0002B68C
	private void method_74(Class58 class58_4)
	{
		if (class58_4 == null)
		{
			throw new ArgumentNullException("obj");
		}
		Class58 @class;
		if (class58_4.method_1() != null)
		{
			@class = class58_4;
		}
		else
		{
			int num = class58_4.method_0();
			switch (num)
			{
			case 3:
			{
				Class64 class2 = new Class64((int)((Class65)class58_4).method_3());
				class2.method_2(class58_4.method_1());
				@class = class2;
				goto IL_20C;
			}
			case 4:
			case 5:
			case 8:
			case 9:
			case 10:
			case 11:
			case 13:
				break;
			case 6:
			{
				Class64 class3 = new Class64((int)((Class62)class58_4).method_3());
				class3.method_2(class58_4.method_1());
				@class = class3;
				goto IL_20C;
			}
			case 7:
			{
				object obj = class58_4.vmethod_0();
				if (obj == null)
				{
					@class = class58_4;
					goto IL_20C;
				}
				Type type = obj.GetType();
				if (type.HasElementType && !type.IsArray)
				{
					type = type.GetElementType();
				}
				if (type != null && !type.IsValueType && !type.IsEnum)
				{
					@class = class58_4;
					goto IL_20C;
				}
				@class = Class58.smethod_0(obj, type);
				goto IL_20C;
			}
			case 12:
			{
				Class64 class4 = new Class64((int)((Class77)class58_4).method_3());
				class4.method_2(class58_4.method_1());
				@class = class4;
				goto IL_20C;
			}
			case 14:
			{
				Class69 class5 = new Class69((long)((Class74)class58_4).method_3());
				class5.method_2(class58_4.method_1());
				@class = class5;
				goto IL_20C;
			}
			case 15:
			{
				Class64 class6 = new Class64((((Class72)class58_4).method_3() > false) ? 1 : 0);
				class6.method_2(class58_4.method_1());
				@class = class6;
				goto IL_20C;
			}
			case 16:
			{
				Class64 class7 = new Class64((int)((Class66)class58_4).method_3());
				class7.method_2(class58_4.method_1());
				@class = class7;
				goto IL_20C;
			}
			case 17:
			{
				Class64 class8 = new Class64((int)((Class68)class58_4).method_3());
				class8.method_2(class58_4.method_1());
				@class = class8;
				goto IL_20C;
			}
			default:
				if (num == 22)
				{
					Class70 class9 = new Class70();
					class9.method_4((double)((Class67)class58_4).method_3());
					class9.method_2(class58_4.method_1());
					@class = class9;
					goto IL_20C;
				}
				if (num == 26)
				{
					Class64 class10 = new Class64((int)((Class76)class58_4).method_3());
					class10.method_2(class58_4.method_1());
					@class = class10;
					goto IL_20C;
				}
				break;
			}
			@class = class58_4;
		}
		IL_20C:
		if (this.class58_2 != null)
		{
			if (this.class58_1 != null)
			{
				this.stack_1.Push(this.class58_1);
			}
			this.class58_1 = this.class58_2;
		}
		this.class58_2 = @class;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0002D6DC File Offset: 0x0002B8DC
	private bool method_75(Class58 class58_4, Type type_10)
	{
		object obj = class58_4.vmethod_0();
		if (obj == null)
		{
			return true;
		}
		Type type = class58_4.method_1() ?? obj.GetType();
		if (!(type == type_10) && !type_10.IsAssignableFrom(type))
		{
			if (!type.IsValueType && !type_10.IsValueType)
			{
				if (Marshal.IsComObject(obj))
				{
					IntPtr intPtr = IntPtr.Zero;
					try
					{
						intPtr = Marshal.GetComInterfaceForObject(obj, type_10);
					}
					catch (ArgumentException)
					{
					}
					catch (InvalidCastException)
					{
					}
					if (intPtr != IntPtr.Zero)
					{
						try
						{
							Marshal.Release(intPtr);
						}
						catch
						{
						}
						return true;
					}
				}
				else if (Class31.smethod_134(obj))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x060002FE RID: 766 RVA: 0x000041F8 File Offset: 0x000023F8
	private static void smethod_205(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_74(class58_4);
	}

	// Token: 0x060002FF RID: 767 RVA: 0x000048CC File Offset: 0x00002ACC
	private object method_76(Stream stream_1, int int_0, object[] object_3, Type[] type_10, Type[] type_11, object[] object_4)
	{
		this.stream_0 = stream_1;
		this.method_37(stream_1, (long)int_0, null);
		return this.method_17(object_3, type_10, type_11, object_4);
	}

	// Token: 0x06000300 RID: 768 RVA: 0x000048EC File Offset: 0x00002AEC
	private void method_77(ref Class31.Struct11 struct11_0)
	{
		if (struct11_0.bool_0)
		{
			Monitor.Exit(Class31.object_0);
		}
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00004900 File Offset: 0x00002B00
	private static void smethod_206(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_14(typeof(double));
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00004912 File Offset: 0x00002B12
	private static void smethod_207(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_6(false, false);
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0000311B File Offset: 0x0000131B
	private void method_78()
	{
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0002D798 File Offset: 0x0002B998
	private static void smethod_208(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		if (@class.method_0() != 1)
		{
			throw new InvalidOperationException();
		}
		int num = ((Class64)@class).method_3();
		Stack<Class31.Class33> stack = class31_0.method_40();
		if (stack.Count < 2)
		{
			throw new InvalidOperationException();
		}
		using (Class31.Class33 class2 = stack.Pop())
		{
			if (class2 == null || class2.class129_0.imethod_0() != num)
			{
				throw new InvalidOperationException();
			}
			Class31.Class33 class33_ = stack.Peek();
			class31_0.method_100(class33_);
			class31_0.uint_1 += (uint)class2.class129_0.method_3();
			class31_0.method_50((long)((ulong)class31_0.uint_1));
		}
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0002D850 File Offset: 0x0002BA50
	private static void smethod_209(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (Class31.smethod_22(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0000491C File Offset: 0x00002B1C
	private static void smethod_210(ILGenerator ilgenerator_0, Type type_10)
	{
		if (!type_10.IsValueType && !Class29.smethod_1(type_10).IsGenericParameter)
		{
			Class31.smethod_30(ilgenerator_0, type_10);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Unbox_Any, type_10);
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0002D888 File Offset: 0x0002BA88
	private Class58[] method_79(object[] object_3)
	{
		Class49[] array = this.class50_0.method_2();
		int num = array.Length;
		Class58[] array2 = new Class58[num];
		for (int i = 0; i < num; i++)
		{
			object obj = object_3[i];
			Type type = this.method_70(array[i].method_0(), false);
			Type left = Class29.smethod_2(type);
			Type type2;
			if (!(left == Class29.type_0) && !Class29.smethod_0(left))
			{
				type2 = ((obj != null) ? obj.GetType() : type);
			}
			else
			{
				type2 = type;
			}
			if (obj != null && !type.IsAssignableFrom(type2) && type.IsByRef && !type.GetElementType().IsAssignableFrom(type2))
			{
				throw new ArgumentException(string.Format("Object of type {0} cannot be converted to type {1}.", type2, type));
			}
			array2[i] = Class58.smethod_0(obj, type2);
		}
		if (!this.class50_0.method_12() && this.method_70(this.class50_0.method_6(), false).IsValueType)
		{
			Class58[] array3 = array2;
			int num2 = 0;
			Class85 @class = new Class85();
			@class.method_4(array2[0]);
			array3[num2] = @class;
		}
		for (int j = 0; j < num; j++)
		{
			if (array[j].method_2())
			{
				Class58[] array4 = array2;
				int num3 = j;
				Class85 class2 = new Class85();
				class2.method_4(array2[j]);
				array4[num3] = class2;
			}
		}
		return array2;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00004947 File Offset: 0x00002B47
	private static void smethod_211(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_26(false);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x0002D9D0 File Offset: 0x0002BBD0
	private static void smethod_212(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		Type type_ = class31_0.method_70(int_, true);
		class31_0.method_14(type_);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00004950 File Offset: 0x00002B50
	private static void smethod_213(Exception exception_0)
	{
		ExceptionDispatchInfo.Capture(exception_0).Throw();
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0002D9FC File Offset: 0x0002BBFC
	private static void smethod_214(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (Class31.smethod_195(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0002DA34 File Offset: 0x0002BC34
	private static void smethod_215(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		double double_;
		if (num != 1)
		{
			if (num != 13)
			{
				if (num != 19)
				{
					throw new InvalidOperationException();
				}
				double_ = Convert.ToUInt64(((Class73)@class).method_3());
			}
			else
			{
				double_ = ((Class69)@class).method_3();
			}
		}
		else
		{
			double_ = ((Class64)@class).method_3();
		}
		Class70 class2 = new Class70();
		class2.method_4(double_);
		class31_0.method_74(class2);
	}

	// Token: 0x0600030D RID: 781 RVA: 0x0000495D File Offset: 0x00002B5D
	private static void smethod_216(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_65((int)((Class66)class58_4).method_3());
	}

	// Token: 0x0600030E RID: 782 RVA: 0x0002DAA8 File Offset: 0x0002BCA8
	private Class58 method_80(Class58 class58_4, Class58 class58_5)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				int num = ((Class64)class58_4).method_3();
				int num2 = ((Class64)class58_5).method_3();
				return new Class64(num << num2);
			}
			if (class58_5.method_0() == 19)
			{
				return this.method_80(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())));
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 1)
			{
				long num3 = ((Class69)class58_4).method_3();
				int num4 = ((Class64)class58_5).method_3();
				return new Class69(num3 << num4);
			}
			if (class58_5.method_0() == 19)
			{
				return this.method_80(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())));
			}
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
		{
			return this.method_80(new Class64(Convert.ToInt32(class58_4.vmethod_0())), class58_5);
		}
		return this.method_80(new Class69(Convert.ToInt64(class58_4.vmethod_0())), class58_5);
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0002DBD8 File Offset: 0x0002BDD8
	private void method_81()
	{
		if (this.stack_2.Count == 0)
		{
			if (this.bool_1)
			{
				this.method_101(this.object_1);
			}
			return;
		}
		Class31.Struct13 @struct = this.stack_2.Pop();
		if (@struct.method_1() != null)
		{
			Class61 @class = new Class61();
			@class.vmethod_1(@struct.method_1());
			this.method_74(@class);
		}
		else
		{
			this.method_3();
		}
		this.method_31(@struct.method_0());
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0002DC4C File Offset: 0x0002BE4C
	private void method_82(bool bool_2)
	{
		Class58 class58_ = this.method_102();
		Class58 class58_2 = this.method_102();
		this.method_74(this.method_8(class58_2, class58_, bool_2));
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0002DC78 File Offset: 0x0002BE78
	private bool method_83(Class81 class81_0)
	{
		if (!class81_0.method_5().IsInitOnly)
		{
			return true;
		}
		if (class81_0.method_5().IsStatic != this.class50_0.method_12())
		{
			return false;
		}
		if (this.class50_0.method_12() && this.class50_0.method_4() != ".cctor")
		{
			return false;
		}
		Type type = class81_0.method_5().DeclaringType;
		if (type.IsGenericType)
		{
			type = type.GetGenericTypeDefinition();
		}
		return this.method_70(this.class50_0.method_6(), true) == type;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0002DD08 File Offset: 0x0002BF08
	[Attribute5(2)]
	private bool method_84([Attribute7(1)] MethodBase methodBase_0, object object_3, ref object object_4, [Attribute7(new byte[]
	{
		1,
		2
	})] object[] object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (Class29.smethod_0(declaringType))
		{
			string name = methodBase_0.Name;
			if (name.Equals("get_HasValue", StringComparison.Ordinal))
			{
				object_4 = (object_3 != null);
			}
			else if (name.Equals("get_Value", StringComparison.Ordinal))
			{
				if (object_3 == null)
				{
					return ((bool?)null).Value;
				}
				object_4 = object_3;
			}
			else if (name.Equals("GetValueOrDefault", StringComparison.Ordinal))
			{
				int num = object_5.Length;
				if (num == 0)
				{
					object_4 = object_3;
				}
				else
				{
					if (num != 1)
					{
						return false;
					}
					if (object_3 != null)
					{
						object_4 = object_3;
					}
					else
					{
						object_4 = object_5[0];
					}
				}
			}
			else
			{
				if (object_3 != null || methodBase_0.IsStatic)
				{
					return false;
				}
				object_4 = null;
			}
			return true;
		}
		if (declaringType == Class31.type_9)
		{
			string name2 = methodBase_0.Name;
			if (name2.Equals("GetExecutingAssembly", StringComparison.Ordinal))
			{
				object_4 = Class29.assembly_0;
				return true;
			}
			if (this.object_2 != null && name2.Equals("GetCallingAssembly", StringComparison.Ordinal))
			{
				object[] array = this.object_2;
				for (int i = 0; i < array.Length; i++)
				{
					Assembly assembly = array[i] as Assembly;
					if (assembly != null)
					{
						object_4 = assembly;
						return true;
					}
				}
			}
		}
		else if (declaringType == Class31.type_5)
		{
			if (methodBase_0.Name.Equals("GetCurrentMethod", StringComparison.Ordinal))
			{
				if (this.object_2 != null)
				{
					object[] array = this.object_2;
					for (int i = 0; i < array.Length; i++)
					{
						MethodBase methodBase = array[i] as MethodBase;
						if (methodBase != null)
						{
							object_4 = methodBase;
							return true;
						}
					}
				}
				object_4 = MethodBase.GetCurrentMethod();
				return true;
			}
		}
		else if (declaringType.IsArray && declaringType.GetArrayRank() >= 2)
		{
			return this.method_0(methodBase_0, object_3, ref object_4, object_5);
		}
		return false;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_217(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
	private Class103 method_85(int int_0)
	{
		if (this.class8_1 == null)
		{
			throw new InvalidOperationException();
		}
		Class97 obj = this.class8_1.method_0();
		Class103 result;
		lock (obj)
		{
			this.class8_1.method_0().vmethod_9((long)int_0, 0);
			Class103 @class = new Class103();
			@class.method_1(this.class8_1.method_6());
			if (@class.method_0() == 0)
			{
				@class.method_3(this.class8_1.method_19());
			}
			else
			{
				@class.method_5(this.method_1(this.class8_1));
			}
			result = @class;
		}
		return result;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_218(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0002DF60 File Offset: 0x0002C160
	private static void smethod_219(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(class31_0.method_98(class58_6, class58_5));
	}

	// Token: 0x06000317 RID: 791 RVA: 0x00004970 File Offset: 0x00002B70
	private static void smethod_220(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(3);
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0002DF8C File Offset: 0x0002C18C
	private Class86[] method_86(Class8 class8_2)
	{
		Class86[] array = new Class86[(int)class8_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this.method_33(class8_2);
		}
		return array;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0002DFC4 File Offset: 0x0002C1C4
	private void method_87(Class58 class58_4)
	{
		Class64 @class = (Class64)class58_4;
		MethodBase methodBase = this.method_58(@class.method_3());
		if (this.type_1 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			foreach (ParameterInfo parameterInfo in parameters)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.type_1.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
			this.type_1 = null;
		}
		this.method_5(methodBase, true);
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0002E068 File Offset: 0x0002C268
	private static void smethod_221(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		Class58 class58_6 = class31_0.method_102();
		class31_0.method_74(new Class64((Class31.smethod_195(class58_6, class58_5) > false) ? 1 : 0));
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00004979 File Offset: 0x00002B79
	private static void smethod_222(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_81();
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0002E098 File Offset: 0x0002C298
	private static BindingFlags smethod_223(bool bool_2)
	{
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		if (bool_2)
		{
			bindingFlags |= BindingFlags.Static;
		}
		else
		{
			bindingFlags |= BindingFlags.Instance;
		}
		return bindingFlags;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
	private void method_88(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		ulong long_;
		if (num <= 8)
		{
			if (num != 0)
			{
				if (num != 1)
				{
					if (num == 8)
					{
						if (bool_2)
						{
							long_ = checked((ulong)((Class70)@class).method_3());
							goto IL_19C;
						}
						long_ = (ulong)((Class70)@class).method_3();
						goto IL_19C;
					}
				}
				else
				{
					if (bool_2)
					{
						long_ = (ulong)(checked((uint)((Class64)@class).method_3()));
						goto IL_19C;
					}
					long_ = (ulong)((Class64)@class).method_3();
					goto IL_19C;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					long_ = (ulong)(checked((uint)((int)((Class75)@class).method_3())));
					goto IL_19C;
				}
				long_ = (ulong)((int)((Class75)@class).method_3());
				goto IL_19C;
			}
			else
			{
				if (bool_2)
				{
					long_ = checked((ulong)((long)((Class75)@class).method_3()));
					goto IL_19C;
				}
				long_ = (ulong)((long)((Class75)@class).method_3());
				goto IL_19C;
			}
		}
		else if (num != 13)
		{
			if (num != 19)
			{
				if (num == 20)
				{
					if (UIntPtr.Size == 4)
					{
						if (bool_2)
						{
							long_ = (ulong)((uint)((Class60)@class).method_3());
							goto IL_19C;
						}
						long_ = (ulong)((uint)((Class60)@class).method_3());
						goto IL_19C;
					}
					else
					{
						if (bool_2)
						{
							long_ = (ulong)((Class60)@class).method_3();
							goto IL_19C;
						}
						long_ = (ulong)((Class60)@class).method_3();
						goto IL_19C;
					}
				}
			}
			else
			{
				if (bool_2)
				{
					long_ = Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_19C;
				}
				long_ = Convert.ToUInt64(((Class73)@class).method_3());
				goto IL_19C;
			}
		}
		else
		{
			if (bool_2)
			{
				long_ = checked((ulong)((Class69)@class).method_3());
				goto IL_19C;
			}
			long_ = (ulong)((Class69)@class).method_3();
			goto IL_19C;
		}
		throw new InvalidOperationException();
		IL_19C:
		this.method_74(new Class69((long)long_));
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0002E270 File Offset: 0x0002C470
	private void method_89(object object_3, uint uint_3)
	{
		bool flag = object_3 != null;
		this.object_1 = object_3;
		if (flag)
		{
			this.stack_2.Clear();
		}
		this.bool_1 = flag;
		if (!flag)
		{
			this.stack_2.Push(new Class31.Struct13(uint_3));
		}
		foreach (Class47 @class in this.class47_0)
		{
			if (Class31.smethod_101(this.uint_2, @class.method_6(), @class.method_8()))
			{
				switch (@class.method_2())
				{
				case 0:
					if (flag)
					{
						Type type = object_3.GetType();
						Type type2 = this.method_70(@class.method_0(), true);
						if (type == type2 || type.IsSubclassOf(type2))
						{
							this.stack_2.Push(new Class31.Struct13(@class.method_4(), object_3));
							this.bool_1 = false;
						}
					}
					break;
				case 1:
					if (flag)
					{
						this.stack_2.Push(new Class31.Struct13(@class.method_4()));
					}
					break;
				case 2:
					if (flag || !Class31.smethod_101(uint_3, @class.method_6(), @class.method_8()))
					{
						this.stack_2.Push(new Class31.Struct13(@class.method_4()));
					}
					break;
				case 4:
					if (flag)
					{
						this.stack_2.Push(new Class31.Struct13(@class.method_10(), object_3));
					}
					break;
				}
			}
		}
		this.method_81();
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0002E3DC File Offset: 0x0002C5DC
	[DebuggerNonUserCode]
	private MethodBase method_90(int int_0, Class103 class103_0)
	{
		Dictionary<int, object> obj = Class31.dictionary_3;
		MethodBase result;
		lock (obj)
		{
			bool flag2 = true;
			object obj2;
			if (Class31.dictionary_3.TryGetValue(int_0, out obj2))
			{
				result = (MethodBase)obj2;
			}
			else if (class103_0.method_0() == 0)
			{
				MethodBase methodBase = this.module_0.ResolveMethod(class103_0.method_2());
				if (flag2)
				{
					Class31.dictionary_3.Add(int_0, methodBase);
				}
				result = methodBase;
			}
			else
			{
				Class17 @class = (Class17)class103_0.method_4();
				if (@class.method_3())
				{
					result = this.method_97(@class);
				}
				else
				{
					Type type = this.method_70(@class.method_4().method_2(), false);
					Type right = this.method_70(@class.method_12().method_2(), true);
					Type[] array = new Type[@class.method_8().Length];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = this.method_70(@class.method_8()[i].method_2(), true);
					}
					if (type.IsGenericType)
					{
						flag2 = false;
					}
					if (@class.method_6() == ".ctor")
					{
						ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, array, null);
						if (constructor == null)
						{
							throw new Exception();
						}
						ConstructorInfo constructorInfo = constructor;
						if (flag2)
						{
							Class31.dictionary_3.Add(int_0, constructorInfo);
						}
						result = constructorInfo;
					}
					else
					{
						BindingFlags bindingAttr = Class31.smethod_223(@class.method_2());
						MethodBase methodBase2 = null;
						try
						{
							methodBase2 = type.GetMethod(@class.method_6(), bindingAttr, null, CallingConventions.Any, array, null);
						}
						catch (AmbiguousMatchException)
						{
							foreach (MethodInfo methodInfo in type.GetMethods(bindingAttr))
							{
								if (!(methodInfo.Name != @class.method_6()) && !(methodInfo.ReturnType != right))
								{
									ParameterInfo[] parameters = methodInfo.GetParameters();
									if (parameters.Length == array.Length)
									{
										bool flag3 = false;
										int k = 0;
										while (k < array.Length)
										{
											if (!(parameters[k].ParameterType != array[k]))
											{
												k++;
											}
											else
											{
												flag3 = true;
												IL_1F3:
												if (flag3)
												{
													goto IL_1F7;
												}
												methodBase2 = methodInfo;
												goto IL_20E;
											}
										}
										goto IL_1F3;
										IL_20E:
										break;
									}
								}
								IL_1F7:;
							}
						}
						if (methodBase2 == null)
						{
							throw new Exception(string.Format("Cannot bind method: {0}.{1}", type.Name, @class.method_6()));
						}
						if (flag2)
						{
							Class31.dictionary_3.Add(int_0, methodBase2);
						}
						result = methodBase2;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000320 RID: 800 RVA: 0x0002E678 File Offset: 0x0002C878
	private static Class58 smethod_224(Class58 class58_4, Class58 class58_5, bool bool_2, bool bool_3)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				if (!bool_3)
				{
					int num = ((Class64)class58_4).method_3();
					int num2 = ((Class64)class58_5).method_3();
					int int_;
					if (bool_2)
					{
						int_ = checked(num * num2);
					}
					else
					{
						int_ = num * num2;
					}
					return new Class64(int_);
				}
				uint num3 = (uint)((Class64)class58_4).method_3();
				uint num4 = (uint)((Class64)class58_5).method_3();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 * num4);
				}
				else
				{
					int_2 = num3 * num4;
				}
				return new Class64((int)int_2);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					return Class31.smethod_31(new Class69((long)((Class64)class58_4).method_3()), class58_5, bool_2, bool_3);
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
					{
						return Class31.smethod_224(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2, bool_3);
					}
					return Class31.smethod_31(new Class69((long)((Class64)class58_4).method_3()), new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2, bool_3);
				}
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				return Class31.smethod_31(class58_4, class58_5, bool_2, bool_3);
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_31(class58_4, new Class69((long)((Class64)class58_5).method_3()), bool_2, bool_3);
			}
			if (class58_5.method_0() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					return Class31.smethod_31(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2, bool_3);
				}
				return Class31.smethod_31(class58_4, new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class58_4.method_0() == 8 && class58_5.method_0() == 8)
		{
			Class70 @class = new Class70();
			@class.method_4(((Class70)class58_4).method_3() * ((Class70)class58_5).method_3());
			return @class;
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)))
		{
			return Class31.smethod_224(new Class64(Convert.ToInt32(class58_4.vmethod_0())), class58_5, bool_2, bool_3);
		}
		return Class31.smethod_224(new Class69(Convert.ToInt64(class58_4.vmethod_0())), class58_5, bool_2, bool_3);
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0002E90C File Offset: 0x0002CB0C
	private void method_91(int int_0)
	{
		Class58 @class = this.method_102();
		this.class58_3[int_0].vmethod_2(@class);
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_225(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00004981 File Offset: 0x00002B81
	private static void smethod_226(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(Class29.type_0);
	}

	// Token: 0x06000324 RID: 804 RVA: 0x0000498E File Offset: 0x00002B8E
	private static void smethod_227(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_15(true);
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00004997 File Offset: 0x00002B97
	private void method_92(Class58 class58_4)
	{
		if (((Class64)this.method_102()).method_3() != 0)
		{
			this.stack_2.Push(new Class31.Struct13(this.uint_1, this.object_1));
			this.bool_1 = false;
		}
		this.method_81();
	}

	// Token: 0x06000326 RID: 806 RVA: 0x0002E934 File Offset: 0x0002CB34
	private static void smethod_228(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		long long_;
		if (num <= 1)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					long_ = (long)((ulong)((Class64)@class).method_3());
					goto IL_A0;
				}
			}
			else
			{
				if (IntPtr.Size == 4)
				{
					long_ = (long)((ulong)((int)((Class75)@class).method_3()));
					goto IL_A0;
				}
				long_ = checked((long)((ulong)((long)((Class75)@class).method_3())));
				goto IL_A0;
			}
		}
		else
		{
			checked
			{
				if (num == 8)
				{
					long_ = (long)((Class70)@class).method_3();
					goto IL_A0;
				}
				if (num == 13)
				{
					long_ = (long)((ulong)((Class69)@class).method_3());
					goto IL_A0;
				}
				if (num == 19)
				{
					long_ = (long)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_A0;
				}
			}
		}
		throw new InvalidOperationException();
		IL_A0:
		class31_0.method_74(new Class69(long_));
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0002E9F0 File Offset: 0x0002CBF0
	private static Class31.Delegate21 smethod_229(Class31.Struct10 struct10_0)
	{
		Dictionary<Class31.Struct10, Class31.Delegate21> obj = Class31.dictionary_1;
		Class31.Delegate21 @delegate;
		lock (obj)
		{
			Class31.dictionary_1.TryGetValue(struct10_0, out @delegate);
		}
		if (@delegate != null)
		{
			return @delegate;
		}
		MethodBase methodBase = struct10_0.method_0();
		Dictionary<MethodBase, object> obj2 = Class31.dictionary_4;
		lock (obj2)
		{
			while (Class31.dictionary_4.ContainsKey(methodBase))
			{
				Monitor.Wait(Class31.dictionary_4);
			}
			Class31.dictionary_4[methodBase] = null;
		}
		Class31.Delegate21 result;
		try
		{
			obj = Class31.dictionary_1;
			lock (obj)
			{
				Class31.dictionary_1.TryGetValue(struct10_0, out @delegate);
			}
			if (@delegate == null)
			{
				@delegate = Class31.smethod_182(methodBase, struct10_0.method_1());
				obj = Class31.dictionary_1;
				lock (obj)
				{
					Class31.dictionary_1[struct10_0] = @delegate;
				}
			}
			result = @delegate;
		}
		finally
		{
			obj2 = Class31.dictionary_4;
			lock (obj2)
			{
				Class31.dictionary_4.Remove(methodBase);
				Monitor.PulseAll(Class31.dictionary_4);
			}
		}
		return result;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x000049D4 File Offset: 0x00002BD4
	private static void smethod_230(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(0);
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0002EB68 File Offset: 0x0002CD68
	private static void smethod_231(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		FieldInfo fieldInfo = class31_0.method_25(int_);
		class31_0.method_74(Class58.smethod_0(fieldInfo.GetValue(null), fieldInfo.FieldType));
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0002EBA4 File Offset: 0x0002CDA4
	private Class58 method_93(Class58 class58_4)
	{
		if (class58_4.method_0() == 1)
		{
			return new Class64(-((Class64)class58_4).method_3());
		}
		if (class58_4.method_0() == 13)
		{
			return new Class69(-((Class69)class58_4).method_3());
		}
		if (class58_4.method_0() == 8)
		{
			Class70 @class = new Class70();
			@class.method_4(-((Class70)class58_4).method_3());
			return @class;
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
		{
			return this.method_93(new Class64(Convert.ToInt32(class58_4.vmethod_0())));
		}
		return this.method_93(new Class69(Convert.ToInt64(class58_4.vmethod_0())));
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0002EC7C File Offset: 0x0002CE7C
	private void method_94(MemberInfo memberInfo_0)
	{
		if (Class31.smethod_132() && !this.class50_0.method_13())
		{
			bool flag = false;
			Assembly assembly = typeof(SecurityCriticalAttribute).Assembly;
			MemberInfo memberInfo = memberInfo_0;
			while (memberInfo != null)
			{
				object[] customAttributes = memberInfo.GetCustomAttributes(false);
				for (int i = 0; i < customAttributes.Length; i++)
				{
					Type type = customAttributes[i].GetType();
					if (type.Assembly == assembly)
					{
						string fullName = type.FullName;
						if ("System.Security.SecurityCriticalAttribute".Equals(fullName, StringComparison.Ordinal))
						{
							flag = true;
							goto IL_9E;
						}
						if ("System.Security.SecuritySafeCriticalAttribute".Equals(fullName, StringComparison.Ordinal))
						{
							goto IL_9E;
						}
					}
				}
				memberInfo = memberInfo.DeclaringType;
				continue;
				IL_9E:
				if (!flag)
				{
					return;
				}
				if (memberInfo_0 is MethodBase)
				{
					string string_ = Class31.smethod_91((MethodBase)memberInfo_0);
					throw Class31.smethod_177(this.method_63(this.class50_0), string_);
				}
				if (memberInfo_0 is FieldInfo)
				{
					string string_2 = memberInfo_0.DeclaringType.FullName + "." + memberInfo_0.Name;
					throw Class31.smethod_99(this.method_63(this.class50_0), string_2);
				}
				if (memberInfo_0 is Type)
				{
					string fullName2 = ((Type)memberInfo_0).FullName;
					throw Class31.smethod_92(this.method_63(this.class50_0), fullName2);
				}
				throw new SecurityException("A caller does not have the permissions required to access a resource.");
			}
			goto IL_9E;
		}
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0002EDC8 File Offset: 0x0002CFC8
	private FieldInfo method_95(int int_0, Class103 class103_0, ref bool bool_2)
	{
		if (class103_0.method_0() == 0)
		{
			bool_2 = false;
			return this.module_0.ResolveField(class103_0.method_2());
		}
		Class15 @class = (Class15)class103_0.method_4();
		Type type = this.method_70(@class.method_0().method_2(), false);
		if (type.IsGenericType)
		{
			bool_2 = false;
		}
		BindingFlags bindingAttr = Class31.smethod_223(@class.method_4());
		return type.GetField(@class.method_2(), bindingAttr);
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0002EE34 File Offset: 0x0002D034
	private static void smethod_232(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (!Class31.smethod_64(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0002EE6C File Offset: 0x0002D06C
	private static Class58 smethod_233(Class58 class58_4, Class58 class58_5, bool bool_2, bool bool_3)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				if (!bool_3)
				{
					int num = ((Class64)class58_4).method_3();
					int num2 = ((Class64)class58_5).method_3();
					int int_;
					if (bool_2)
					{
						int_ = checked(num + num2);
					}
					else
					{
						int_ = num + num2;
					}
					return new Class64(int_);
				}
				uint num3 = (uint)((Class64)class58_4).method_3();
				uint num4 = (uint)((Class64)class58_5).method_3();
				uint int_2;
				if (bool_2)
				{
					int_2 = checked(num3 + num4);
				}
				else
				{
					int_2 = num3 + num4;
				}
				return new Class64((int)int_2);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					return Class31.smethod_137(new Class69((long)((Class64)class58_4).method_3()), class58_5, bool_2, bool_3);
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
					{
						return Class31.smethod_233(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2, bool_3);
					}
					return Class31.smethod_137(new Class69((long)((Class64)class58_4).method_3()), new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2, bool_3);
				}
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				return Class31.smethod_137(class58_4, class58_5, bool_2, bool_3);
			}
			if (class58_5.method_0() == 1)
			{
				return Class31.smethod_137(class58_4, new Class69((long)((Class64)class58_5).method_3()), bool_2, bool_3);
			}
			if (class58_5.method_0() == 19)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					return Class31.smethod_137(class58_4, new Class64(Convert.ToInt32(class58_5.vmethod_0())), bool_2, bool_3);
				}
				return Class31.smethod_137(class58_4, new Class69(Convert.ToInt64(class58_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class58_4.method_0() == 8 && class58_5.method_0() == 8)
		{
			Class70 @class = new Class70();
			@class.method_4(((Class70)class58_4).method_3() + ((Class70)class58_5).method_3());
			return @class;
		}
		if (class58_4.method_0() != 19)
		{
			throw new InvalidOperationException();
		}
		Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
		if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)))
		{
			return Class31.smethod_233(new Class64(Convert.ToInt32(class58_4.vmethod_0())), class58_5, bool_2, bool_3);
		}
		return Class31.smethod_233(new Class69(Convert.ToInt64(class58_4.vmethod_0())), class58_5, bool_2, bool_3);
	}

	// Token: 0x0600032F RID: 815 RVA: 0x000049DD File Offset: 0x00002BDD
	private static void smethod_234(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_26(true);
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00004197 File Offset: 0x00002397
	private static void smethod_235(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_96();
	}

	// Token: 0x06000331 RID: 817 RVA: 0x000049E6 File Offset: 0x00002BE6
	private static void smethod_236(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(Class31.type_2);
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0002F100 File Offset: 0x0002D300
	private static Dictionary<int, Class31.Struct12> smethod_237(Class41 class41_1)
	{
		Dictionary<int, Class31.Struct12> dictionary = new Dictionary<int, Class31.Struct12>(256);
		int key = class41_1.struct0_141.method_0();
		Struct0 struct0_ = class41_1.struct0_141;
		Class31.Delegate0 delegate0_;
		if ((delegate0_ = Class31.Class37.delegate0_85) == null)
		{
			delegate0_ = (Class31.Class37.delegate0_85 = new Class31.Delegate0(Class31.smethod_10));
		}
		dictionary.Add(key, new Class31.Struct12(struct0_, delegate0_));
		int key2 = class41_1.struct0_212.method_0();
		Struct0 struct0_2 = class41_1.struct0_212;
		Class31.Delegate0 delegate0_2;
		if ((delegate0_2 = Class31.Class37.delegate0_47) == null)
		{
			delegate0_2 = (Class31.Class37.delegate0_47 = new Class31.Delegate0(Class31.smethod_94));
		}
		dictionary.Add(key2, new Class31.Struct12(struct0_2, delegate0_2));
		int key3 = class41_1.struct0_49.method_0();
		Struct0 struct0_3 = class41_1.struct0_49;
		Class31.Delegate0 delegate0_3;
		if ((delegate0_3 = Class31.Class37.delegate0_86) == null)
		{
			delegate0_3 = (Class31.Class37.delegate0_86 = new Class31.Delegate0(Class31.smethod_232));
		}
		dictionary.Add(key3, new Class31.Struct12(struct0_3, delegate0_3));
		int key4 = class41_1.struct0_66.method_0();
		Struct0 struct0_4 = class41_1.struct0_66;
		Class31.Delegate0 delegate0_4;
		if ((delegate0_4 = Class31.Class37.delegate0_155) == null)
		{
			delegate0_4 = (Class31.Class37.delegate0_155 = new Class31.Delegate0(Class31.smethod_162));
		}
		dictionary.Add(key4, new Class31.Struct12(struct0_4, delegate0_4));
		int key5 = class41_1.struct0_43.method_0();
		Struct0 struct0_5 = class41_1.struct0_43;
		Class31.Delegate0 delegate0_5;
		if ((delegate0_5 = Class31.Class37.delegate0_22) == null)
		{
			delegate0_5 = (Class31.Class37.delegate0_22 = new Class31.Delegate0(Class31.smethod_18));
		}
		dictionary.Add(key5, new Class31.Struct12(struct0_5, delegate0_5));
		int key6 = class41_1.struct0_123.method_0();
		Struct0 struct0_6 = class41_1.struct0_123;
		Class31.Delegate0 delegate0_6;
		if ((delegate0_6 = Class31.Class37.delegate0_25) == null)
		{
			delegate0_6 = (Class31.Class37.delegate0_25 = new Class31.Delegate0(Class31.smethod_136));
		}
		dictionary.Add(key6, new Class31.Struct12(struct0_6, delegate0_6));
		int key7 = class41_1.struct0_102.method_0();
		Struct0 struct0_7 = class41_1.struct0_102;
		Class31.Delegate0 delegate0_7;
		if ((delegate0_7 = Class31.Class37.delegate0_117) == null)
		{
			delegate0_7 = (Class31.Class37.delegate0_117 = new Class31.Delegate0(Class31.smethod_234));
		}
		dictionary.Add(key7, new Class31.Struct12(struct0_7, delegate0_7));
		int key8 = class41_1.struct0_63.method_0();
		Struct0 struct0_8 = class41_1.struct0_63;
		Class31.Delegate0 delegate0_8;
		if ((delegate0_8 = Class31.Class37.delegate0_103) == null)
		{
			delegate0_8 = (Class31.Class37.delegate0_103 = new Class31.Delegate0(Class31.smethod_75));
		}
		dictionary.Add(key8, new Class31.Struct12(struct0_8, delegate0_8));
		int key9 = class41_1.struct0_25.method_0();
		Struct0 struct0_9 = class41_1.struct0_25;
		Class31.Delegate0 delegate0_9;
		if ((delegate0_9 = Class31.Class37.delegate0_161) == null)
		{
			delegate0_9 = (Class31.Class37.delegate0_161 = new Class31.Delegate0(Class31.smethod_122));
		}
		dictionary.Add(key9, new Class31.Struct12(struct0_9, delegate0_9));
		int key10 = class41_1.struct0_19.method_0();
		Struct0 struct0_10 = class41_1.struct0_19;
		Class31.Delegate0 delegate0_10;
		if ((delegate0_10 = Class31.Class37.delegate0_100) == null)
		{
			delegate0_10 = (Class31.Class37.delegate0_100 = new Class31.Delegate0(Class31.smethod_19));
		}
		dictionary.Add(key10, new Class31.Struct12(struct0_10, delegate0_10));
		int key11 = class41_1.struct0_59.method_0();
		Struct0 struct0_11 = class41_1.struct0_59;
		Class31.Delegate0 delegate0_11;
		if ((delegate0_11 = Class31.Class37.delegate0_180) == null)
		{
			delegate0_11 = (Class31.Class37.delegate0_180 = new Class31.Delegate0(Class31.smethod_59));
		}
		dictionary.Add(key11, new Class31.Struct12(struct0_11, delegate0_11));
		int key12 = class41_1.struct0_126.method_0();
		Struct0 struct0_12 = class41_1.struct0_126;
		Class31.Delegate0 delegate0_12;
		if ((delegate0_12 = Class31.Class37.delegate0_31) == null)
		{
			delegate0_12 = (Class31.Class37.delegate0_31 = new Class31.Delegate0(Class31.smethod_5));
		}
		dictionary.Add(key12, new Class31.Struct12(struct0_12, delegate0_12));
		int key13 = class41_1.struct0_167.method_0();
		Struct0 struct0_13 = class41_1.struct0_167;
		Class31.Delegate0 delegate0_13;
		if ((delegate0_13 = Class31.Class37.delegate0_62) == null)
		{
			delegate0_13 = (Class31.Class37.delegate0_62 = new Class31.Delegate0(Class31.smethod_149));
		}
		dictionary.Add(key13, new Class31.Struct12(struct0_13, delegate0_13));
		int key14 = class41_1.struct0_185.method_0();
		Struct0 struct0_14 = class41_1.struct0_185;
		Class31.Delegate0 delegate0_14;
		if ((delegate0_14 = Class31.Class37.delegate0_53) == null)
		{
			delegate0_14 = (Class31.Class37.delegate0_53 = new Class31.Delegate0(Class31.smethod_45));
		}
		dictionary.Add(key14, new Class31.Struct12(struct0_14, delegate0_14));
		int key15 = class41_1.struct0_27.method_0();
		Struct0 struct0_15 = class41_1.struct0_27;
		Class31.Delegate0 delegate0_15;
		if ((delegate0_15 = Class31.Class37.delegate0_110) == null)
		{
			delegate0_15 = (Class31.Class37.delegate0_110 = new Class31.Delegate0(Class31.smethod_24));
		}
		dictionary.Add(key15, new Class31.Struct12(struct0_15, delegate0_15));
		int key16 = class41_1.struct0_10.method_0();
		Struct0 struct0_16 = class41_1.struct0_10;
		Class31.Delegate0 delegate0_16;
		if ((delegate0_16 = Class31.Class37.delegate0_190) == null)
		{
			delegate0_16 = (Class31.Class37.delegate0_190 = new Class31.Delegate0(Class31.smethod_202));
		}
		dictionary.Add(key16, new Class31.Struct12(struct0_16, delegate0_16));
		int key17 = class41_1.struct0_197.method_0();
		Struct0 struct0_17 = class41_1.struct0_197;
		Class31.Delegate0 delegate0_17;
		if ((delegate0_17 = Class31.Class37.delegate0_123) == null)
		{
			delegate0_17 = (Class31.Class37.delegate0_123 = new Class31.Delegate0(Class31.smethod_74));
		}
		dictionary.Add(key17, new Class31.Struct12(struct0_17, delegate0_17));
		int key18 = class41_1.struct0_38.method_0();
		Struct0 struct0_18 = class41_1.struct0_38;
		Class31.Delegate0 delegate0_18;
		if ((delegate0_18 = Class31.Class37.delegate0_193) == null)
		{
			delegate0_18 = (Class31.Class37.delegate0_193 = new Class31.Delegate0(Class31.smethod_197));
		}
		dictionary.Add(key18, new Class31.Struct12(struct0_18, delegate0_18));
		int key19 = class41_1.struct0_48.method_0();
		Struct0 struct0_19 = class41_1.struct0_48;
		Class31.Delegate0 delegate0_19;
		if ((delegate0_19 = Class31.Class37.delegate0_44) == null)
		{
			delegate0_19 = (Class31.Class37.delegate0_44 = new Class31.Delegate0(Class31.smethod_174));
		}
		dictionary.Add(key19, new Class31.Struct12(struct0_19, delegate0_19));
		int key20 = class41_1.struct0_177.method_0();
		Struct0 struct0_20 = class41_1.struct0_177;
		Class31.Delegate0 delegate0_20;
		if ((delegate0_20 = Class31.Class37.delegate0_78) == null)
		{
			delegate0_20 = (Class31.Class37.delegate0_78 = new Class31.Delegate0(Class31.smethod_86));
		}
		dictionary.Add(key20, new Class31.Struct12(struct0_20, delegate0_20));
		int key21 = class41_1.struct0_47.method_0();
		Struct0 struct0_21 = class41_1.struct0_47;
		Class31.Delegate0 delegate0_21;
		if ((delegate0_21 = Class31.Class37.delegate0_166) == null)
		{
			delegate0_21 = (Class31.Class37.delegate0_166 = new Class31.Delegate0(Class31.smethod_236));
		}
		dictionary.Add(key21, new Class31.Struct12(struct0_21, delegate0_21));
		int key22 = class41_1.struct0_105.method_0();
		Struct0 struct0_22 = class41_1.struct0_105;
		Class31.Delegate0 delegate0_22;
		if ((delegate0_22 = Class31.Class37.delegate0_7) == null)
		{
			delegate0_22 = (Class31.Class37.delegate0_7 = new Class31.Delegate0(Class31.smethod_199));
		}
		dictionary.Add(key22, new Class31.Struct12(struct0_22, delegate0_22));
		int key23 = class41_1.struct0_88.method_0();
		Struct0 struct0_23 = class41_1.struct0_88;
		Class31.Delegate0 delegate0_23;
		if ((delegate0_23 = Class31.Class37.delegate0_187) == null)
		{
			delegate0_23 = (Class31.Class37.delegate0_187 = new Class31.Delegate0(Class31.smethod_148));
		}
		dictionary.Add(key23, new Class31.Struct12(struct0_23, delegate0_23));
		int key24 = class41_1.struct0_135.method_0();
		Struct0 struct0_24 = class41_1.struct0_135;
		Class31.Delegate0 delegate0_24;
		if ((delegate0_24 = Class31.Class37.delegate0_203) == null)
		{
			delegate0_24 = (Class31.Class37.delegate0_203 = new Class31.Delegate0(Class31.smethod_76));
		}
		dictionary.Add(key24, new Class31.Struct12(struct0_24, delegate0_24));
		int key25 = class41_1.struct0_84.method_0();
		Struct0 struct0_25 = class41_1.struct0_84;
		Class31.Delegate0 delegate0_25;
		if ((delegate0_25 = Class31.Class37.delegate0_75) == null)
		{
			delegate0_25 = (Class31.Class37.delegate0_75 = new Class31.Delegate0(Class31.smethod_43));
		}
		dictionary.Add(key25, new Class31.Struct12(struct0_25, delegate0_25));
		int key26 = class41_1.struct0_73.method_0();
		Struct0 struct0_26 = class41_1.struct0_73;
		Class31.Delegate0 delegate0_26;
		if ((delegate0_26 = Class31.Class37.delegate0_96) == null)
		{
			delegate0_26 = (Class31.Class37.delegate0_96 = new Class31.Delegate0(Class31.smethod_63));
		}
		dictionary.Add(key26, new Class31.Struct12(struct0_26, delegate0_26));
		int key27 = class41_1.struct0_164.method_0();
		Struct0 struct0_27 = class41_1.struct0_164;
		Class31.Delegate0 delegate0_27;
		if ((delegate0_27 = Class31.Class37.delegate0_189) == null)
		{
			delegate0_27 = (Class31.Class37.delegate0_189 = new Class31.Delegate0(Class31.smethod_158));
		}
		dictionary.Add(key27, new Class31.Struct12(struct0_27, delegate0_27));
		int key28 = class41_1.struct0_148.method_0();
		Struct0 struct0_28 = class41_1.struct0_148;
		Class31.Delegate0 delegate0_28;
		if ((delegate0_28 = Class31.Class37.delegate0_36) == null)
		{
			delegate0_28 = (Class31.Class37.delegate0_36 = new Class31.Delegate0(Class31.smethod_172));
		}
		dictionary.Add(key28, new Class31.Struct12(struct0_28, delegate0_28));
		int key29 = class41_1.struct0_157.method_0();
		Struct0 struct0_29 = class41_1.struct0_157;
		Class31.Delegate0 delegate0_29;
		if ((delegate0_29 = Class31.Class37.delegate0_61) == null)
		{
			delegate0_29 = (Class31.Class37.delegate0_61 = new Class31.Delegate0(Class31.smethod_90));
		}
		dictionary.Add(key29, new Class31.Struct12(struct0_29, delegate0_29));
		int key30 = class41_1.struct0_35.method_0();
		Struct0 struct0_30 = class41_1.struct0_35;
		Class31.Delegate0 delegate0_30;
		if ((delegate0_30 = Class31.Class37.delegate0_71) == null)
		{
			delegate0_30 = (Class31.Class37.delegate0_71 = new Class31.Delegate0(Class31.smethod_144));
		}
		dictionary.Add(key30, new Class31.Struct12(struct0_30, delegate0_30));
		int key31 = class41_1.struct0_89.method_0();
		Struct0 struct0_31 = class41_1.struct0_89;
		Class31.Delegate0 delegate0_31;
		if ((delegate0_31 = Class31.Class37.delegate0_160) == null)
		{
			delegate0_31 = (Class31.Class37.delegate0_160 = new Class31.Delegate0(Class31.smethod_179));
		}
		dictionary.Add(key31, new Class31.Struct12(struct0_31, delegate0_31));
		int key32 = class41_1.struct0_77.method_0();
		Struct0 struct0_32 = class41_1.struct0_77;
		Class31.Delegate0 delegate0_32;
		if ((delegate0_32 = Class31.Class37.delegate0_79) == null)
		{
			delegate0_32 = (Class31.Class37.delegate0_79 = new Class31.Delegate0(Class31.smethod_183));
		}
		dictionary.Add(key32, new Class31.Struct12(struct0_32, delegate0_32));
		int key33 = class41_1.struct0_161.method_0();
		Struct0 struct0_33 = class41_1.struct0_161;
		Class31.Delegate0 delegate0_33;
		if ((delegate0_33 = Class31.Class37.delegate0_107) == null)
		{
			delegate0_33 = (Class31.Class37.delegate0_107 = new Class31.Delegate0(Class31.smethod_188));
		}
		dictionary.Add(key33, new Class31.Struct12(struct0_33, delegate0_33));
		int key34 = class41_1.struct0_184.method_0();
		Struct0 struct0_34 = class41_1.struct0_184;
		Class31.Delegate0 delegate0_34;
		if ((delegate0_34 = Class31.Class37.delegate0_184) == null)
		{
			delegate0_34 = (Class31.Class37.delegate0_184 = new Class31.Delegate0(Class31.smethod_89));
		}
		dictionary.Add(key34, new Class31.Struct12(struct0_34, delegate0_34));
		int key35 = class41_1.struct0_158.method_0();
		Struct0 struct0_35 = class41_1.struct0_158;
		Class31.Delegate0 delegate0_35;
		if ((delegate0_35 = Class31.Class37.delegate0_88) == null)
		{
			delegate0_35 = (Class31.Class37.delegate0_88 = new Class31.Delegate0(Class31.smethod_3));
		}
		dictionary.Add(key35, new Class31.Struct12(struct0_35, delegate0_35));
		int key36 = class41_1.struct0_80.method_0();
		Struct0 struct0_36 = class41_1.struct0_80;
		Class31.Delegate0 delegate0_36;
		if ((delegate0_36 = Class31.Class37.delegate0_9) == null)
		{
			delegate0_36 = (Class31.Class37.delegate0_9 = new Class31.Delegate0(Class31.smethod_112));
		}
		dictionary.Add(key36, new Class31.Struct12(struct0_36, delegate0_36));
		int key37 = class41_1.struct0_196.method_0();
		Struct0 struct0_37 = class41_1.struct0_196;
		Class31.Delegate0 delegate0_37;
		if ((delegate0_37 = Class31.Class37.delegate0_171) == null)
		{
			delegate0_37 = (Class31.Class37.delegate0_171 = new Class31.Delegate0(Class31.smethod_84));
		}
		dictionary.Add(key37, new Class31.Struct12(struct0_37, delegate0_37));
		int key38 = class41_1.struct0_104.method_0();
		Struct0 struct0_38 = class41_1.struct0_104;
		Class31.Delegate0 delegate0_38;
		if ((delegate0_38 = Class31.Class37.delegate0_42) == null)
		{
			delegate0_38 = (Class31.Class37.delegate0_42 = new Class31.Delegate0(Class31.smethod_207));
		}
		dictionary.Add(key38, new Class31.Struct12(struct0_38, delegate0_38));
		int key39 = class41_1.struct0_31.method_0();
		Struct0 struct0_39 = class41_1.struct0_31;
		Class31.Delegate0 delegate0_39;
		if ((delegate0_39 = Class31.Class37.delegate0_24) == null)
		{
			delegate0_39 = (Class31.Class37.delegate0_24 = new Class31.Delegate0(Class31.smethod_62));
		}
		dictionary.Add(key39, new Class31.Struct12(struct0_39, delegate0_39));
		int key40 = class41_1.struct0_145.method_0();
		Struct0 struct0_40 = class41_1.struct0_145;
		Class31.Delegate0 delegate0_40;
		if ((delegate0_40 = Class31.Class37.delegate0_158) == null)
		{
			delegate0_40 = (Class31.Class37.delegate0_158 = new Class31.Delegate0(Class31.smethod_65));
		}
		dictionary.Add(key40, new Class31.Struct12(struct0_40, delegate0_40));
		int key41 = class41_1.struct0_117.method_0();
		Struct0 struct0_41 = class41_1.struct0_117;
		Class31.Delegate0 delegate0_41;
		if ((delegate0_41 = Class31.Class37.delegate0_43) == null)
		{
			delegate0_41 = (Class31.Class37.delegate0_43 = new Class31.Delegate0(Class31.smethod_138));
		}
		dictionary.Add(key41, new Class31.Struct12(struct0_41, delegate0_41));
		int key42 = class41_1.struct0_180.method_0();
		Struct0 struct0_42 = class41_1.struct0_21;
		Class31.Delegate0 delegate0_42;
		if ((delegate0_42 = Class31.Class37.delegate0_202) == null)
		{
			delegate0_42 = (Class31.Class37.delegate0_202 = new Class31.Delegate0(Class31.smethod_6));
		}
		dictionary.Add(key42, new Class31.Struct12(struct0_42, delegate0_42));
		int key43 = class41_1.struct0_68.method_0();
		Struct0 struct0_43 = class41_1.struct0_68;
		Class31.Delegate0 delegate0_43;
		if ((delegate0_43 = Class31.Class37.delegate0_17) == null)
		{
			delegate0_43 = (Class31.Class37.delegate0_17 = new Class31.Delegate0(Class31.smethod_189));
		}
		dictionary.Add(key43, new Class31.Struct12(struct0_43, delegate0_43));
		int key44 = class41_1.struct0_205.method_0();
		Struct0 struct0_44 = class41_1.struct0_205;
		Class31.Delegate0 delegate0_44;
		if ((delegate0_44 = Class31.Class37.delegate0_134) == null)
		{
			delegate0_44 = (Class31.Class37.delegate0_134 = new Class31.Delegate0(Class31.smethod_78));
		}
		dictionary.Add(key44, new Class31.Struct12(struct0_44, delegate0_44));
		int key45 = class41_1.struct0_122.method_0();
		Struct0 struct0_45 = class41_1.struct0_122;
		Class31.Delegate0 delegate0_45;
		if ((delegate0_45 = Class31.Class37.delegate0_77) == null)
		{
			delegate0_45 = (Class31.Class37.delegate0_77 = new Class31.Delegate0(Class31.smethod_96));
		}
		dictionary.Add(key45, new Class31.Struct12(struct0_45, delegate0_45));
		int key46 = class41_1.struct0_29.method_0();
		Struct0 struct0_46 = class41_1.struct0_29;
		Class31.Delegate0 delegate0_46;
		if ((delegate0_46 = Class31.Class37.delegate0_143) == null)
		{
			delegate0_46 = (Class31.Class37.delegate0_143 = new Class31.Delegate0(Class31.smethod_8));
		}
		dictionary.Add(key46, new Class31.Struct12(struct0_46, delegate0_46));
		int key47 = class41_1.struct0_127.method_0();
		Struct0 struct0_47 = class41_1.struct0_127;
		Class31.Delegate0 delegate0_47;
		if ((delegate0_47 = Class31.Class37.delegate0_70) == null)
		{
			delegate0_47 = (Class31.Class37.delegate0_70 = new Class31.Delegate0(Class31.smethod_221));
		}
		dictionary.Add(key47, new Class31.Struct12(struct0_47, delegate0_47));
		int key48 = class41_1.struct0_155.method_0();
		Struct0 struct0_48 = class41_1.struct0_155;
		Class31.Delegate0 delegate0_48;
		if ((delegate0_48 = Class31.Class37.delegate0_50) == null)
		{
			delegate0_48 = (Class31.Class37.delegate0_50 = new Class31.Delegate0(Class31.smethod_111));
		}
		dictionary.Add(key48, new Class31.Struct12(struct0_48, delegate0_48));
		int key49 = class41_1.struct0_156.method_0();
		Struct0 struct0_49 = class41_1.struct0_156;
		Class31.Delegate0 delegate0_49;
		if ((delegate0_49 = Class31.Class37.delegate0_5) == null)
		{
			delegate0_49 = (Class31.Class37.delegate0_5 = new Class31.Delegate0(Class31.smethod_180));
		}
		dictionary.Add(key49, new Class31.Struct12(struct0_49, delegate0_49));
		int key50 = class41_1.struct0_83.method_0();
		Struct0 struct0_50 = class41_1.struct0_83;
		Class31.Delegate0 delegate0_50;
		if ((delegate0_50 = Class31.Class37.delegate0_204) == null)
		{
			delegate0_50 = (Class31.Class37.delegate0_204 = new Class31.Delegate0(Class31.smethod_208));
		}
		dictionary.Add(key50, new Class31.Struct12(struct0_50, delegate0_50));
		int key51 = class41_1.struct0_163.method_0();
		Struct0 struct0_51 = class41_1.struct0_163;
		Class31.Delegate0 delegate0_51;
		if ((delegate0_51 = Class31.Class37.delegate0_63) == null)
		{
			delegate0_51 = (Class31.Class37.delegate0_63 = new Class31.Delegate0(Class31.smethod_220));
		}
		dictionary.Add(key51, new Class31.Struct12(struct0_51, delegate0_51));
		int key52 = class41_1.struct0_121.method_0();
		Struct0 struct0_52 = class41_1.struct0_121;
		Class31.Delegate0 delegate0_52;
		if ((delegate0_52 = Class31.Class37.delegate0_138) == null)
		{
			delegate0_52 = (Class31.Class37.delegate0_138 = new Class31.Delegate0(Class31.smethod_37));
		}
		dictionary.Add(key52, new Class31.Struct12(struct0_52, delegate0_52));
		int key53 = class41_1.struct0_173.method_0();
		Struct0 struct0_53 = class41_1.struct0_173;
		Class31.Delegate0 delegate0_53;
		if ((delegate0_53 = Class31.Class37.delegate0_181) == null)
		{
			delegate0_53 = (Class31.Class37.delegate0_181 = new Class31.Delegate0(Class31.smethod_192));
		}
		dictionary.Add(key53, new Class31.Struct12(struct0_53, delegate0_53));
		int key54 = class41_1.struct0_113.method_0();
		Struct0 struct0_54 = class41_1.struct0_113;
		Class31.Delegate0 delegate0_54;
		if ((delegate0_54 = Class31.Class37.delegate0_21) == null)
		{
			delegate0_54 = (Class31.Class37.delegate0_21 = new Class31.Delegate0(Class31.smethod_58));
		}
		dictionary.Add(key54, new Class31.Struct12(struct0_54, delegate0_54));
		int key55 = class41_1.struct0_170.method_0();
		Struct0 struct0_55 = class41_1.struct0_170;
		Class31.Delegate0 delegate0_55;
		if ((delegate0_55 = Class31.Class37.delegate0_162) == null)
		{
			delegate0_55 = (Class31.Class37.delegate0_162 = new Class31.Delegate0(Class31.smethod_198));
		}
		dictionary.Add(key55, new Class31.Struct12(struct0_55, delegate0_55));
		int key56 = class41_1.struct0_92.method_0();
		Struct0 struct0_56 = class41_1.struct0_92;
		Class31.Delegate0 delegate0_56;
		if ((delegate0_56 = Class31.Class37.delegate0_105) == null)
		{
			delegate0_56 = (Class31.Class37.delegate0_105 = new Class31.Delegate0(Class31.smethod_79));
		}
		dictionary.Add(key56, new Class31.Struct12(struct0_56, delegate0_56));
		int key57 = class41_1.struct0_45.method_0();
		Struct0 struct0_57 = class41_1.struct0_45;
		Class31.Delegate0 delegate0_57;
		if ((delegate0_57 = Class31.Class37.delegate0_192) == null)
		{
			delegate0_57 = (Class31.Class37.delegate0_192 = new Class31.Delegate0(Class31.smethod_39));
		}
		dictionary.Add(key57, new Class31.Struct12(struct0_57, delegate0_57));
		int key58 = class41_1.struct0_136.method_0();
		Struct0 struct0_58 = class41_1.struct0_136;
		Class31.Delegate0 delegate0_58;
		if ((delegate0_58 = Class31.Class37.delegate0_122) == null)
		{
			delegate0_58 = (Class31.Class37.delegate0_122 = new Class31.Delegate0(Class31.smethod_228));
		}
		dictionary.Add(key58, new Class31.Struct12(struct0_58, delegate0_58));
		int key59 = class41_1.struct0_120.method_0();
		Struct0 struct0_59 = class41_1.struct0_120;
		Class31.Delegate0 delegate0_59;
		if ((delegate0_59 = Class31.Class37.delegate0_59) == null)
		{
			delegate0_59 = (Class31.Class37.delegate0_59 = new Class31.Delegate0(Class31.smethod_150));
		}
		dictionary.Add(key59, new Class31.Struct12(struct0_59, delegate0_59));
		int key60 = class41_1.struct0_69.method_0();
		Struct0 struct0_60 = class41_1.struct0_69;
		Class31.Delegate0 delegate0_60;
		if ((delegate0_60 = Class31.Class37.delegate0_135) == null)
		{
			delegate0_60 = (Class31.Class37.delegate0_135 = new Class31.Delegate0(Class31.smethod_222));
		}
		dictionary.Add(key60, new Class31.Struct12(struct0_60, delegate0_60));
		int key61 = class41_1.struct0_33.method_0();
		Struct0 struct0_61 = class41_1.struct0_33;
		Class31.Delegate0 delegate0_61;
		if ((delegate0_61 = Class31.Class37.delegate0_4) == null)
		{
			delegate0_61 = (Class31.Class37.delegate0_4 = new Class31.Delegate0(Class31.smethod_118));
		}
		dictionary.Add(key61, new Class31.Struct12(struct0_61, delegate0_61));
		int key62 = class41_1.struct0_182.method_0();
		Struct0 struct0_62 = class41_1.struct0_182;
		Class31.Delegate0 delegate0_62;
		if ((delegate0_62 = Class31.Class37.delegate0_99) == null)
		{
			delegate0_62 = (Class31.Class37.delegate0_99 = new Class31.Delegate0(Class31.smethod_69));
		}
		dictionary.Add(key62, new Class31.Struct12(struct0_62, delegate0_62));
		int key63 = class41_1.struct0_142.method_0();
		Struct0 struct0_63 = class41_1.struct0_142;
		Class31.Delegate0 delegate0_63;
		if ((delegate0_63 = Class31.Class37.delegate0_32) == null)
		{
			delegate0_63 = (Class31.Class37.delegate0_32 = new Class31.Delegate0(Class31.smethod_60));
		}
		dictionary.Add(key63, new Class31.Struct12(struct0_63, delegate0_63));
		int key64 = class41_1.struct0_210.method_0();
		Struct0 struct0_64 = class41_1.struct0_210;
		Class31.Delegate0 delegate0_64;
		if ((delegate0_64 = Class31.Class37.delegate0_168) == null)
		{
			delegate0_64 = (Class31.Class37.delegate0_168 = new Class31.Delegate0(Class31.smethod_71));
		}
		dictionary.Add(key64, new Class31.Struct12(struct0_64, delegate0_64));
		int key65 = class41_1.struct0_140.method_0();
		Struct0 struct0_65 = class41_1.struct0_140;
		Class31.Delegate0 delegate0_65;
		if ((delegate0_65 = Class31.Class37.delegate0_48) == null)
		{
			delegate0_65 = (Class31.Class37.delegate0_48 = new Class31.Delegate0(Class31.smethod_194));
		}
		dictionary.Add(key65, new Class31.Struct12(struct0_65, delegate0_65));
		int key66 = class41_1.struct0_149.method_0();
		Struct0 struct0_66 = class41_1.struct0_149;
		Class31.Delegate0 delegate0_66;
		if ((delegate0_66 = Class31.Class37.delegate0_58) == null)
		{
			delegate0_66 = (Class31.Class37.delegate0_58 = new Class31.Delegate0(Class31.smethod_159));
		}
		dictionary.Add(key66, new Class31.Struct12(struct0_66, delegate0_66));
		int key67 = class41_1.struct0_107.method_0();
		Struct0 struct0_67 = class41_1.struct0_107;
		Class31.Delegate0 delegate0_67;
		if ((delegate0_67 = Class31.Class37.delegate0_120) == null)
		{
			delegate0_67 = (Class31.Class37.delegate0_120 = new Class31.Delegate0(Class31.smethod_125));
		}
		dictionary.Add(key67, new Class31.Struct12(struct0_67, delegate0_67));
		int key68 = class41_1.struct0_70.method_0();
		Struct0 struct0_68 = class41_1.struct0_70;
		Class31.Delegate0 delegate0_68;
		if ((delegate0_68 = Class31.Class37.delegate0_114) == null)
		{
			delegate0_68 = (Class31.Class37.delegate0_114 = new Class31.Delegate0(Class31.smethod_248));
		}
		dictionary.Add(key68, new Class31.Struct12(struct0_68, delegate0_68));
		int key69 = class41_1.struct0_16.method_0();
		Struct0 struct0_69 = class41_1.struct0_16;
		Class31.Delegate0 delegate0_69;
		if ((delegate0_69 = Class31.Class37.delegate0_76) == null)
		{
			delegate0_69 = (Class31.Class37.delegate0_76 = new Class31.Delegate0(Class31.smethod_247));
		}
		dictionary.Add(key69, new Class31.Struct12(struct0_69, delegate0_69));
		int key70 = class41_1.struct0_41.method_0();
		Struct0 struct0_70 = class41_1.struct0_41;
		Class31.Delegate0 delegate0_70;
		if ((delegate0_70 = Class31.Class37.delegate0_173) == null)
		{
			delegate0_70 = (Class31.Class37.delegate0_173 = new Class31.Delegate0(Class31.smethod_212));
		}
		dictionary.Add(key70, new Class31.Struct12(struct0_70, delegate0_70));
		int key71 = class41_1.struct0_97.method_0();
		Struct0 struct0_71 = class41_1.struct0_97;
		Class31.Delegate0 delegate0_71;
		if ((delegate0_71 = Class31.Class37.delegate0_40) == null)
		{
			delegate0_71 = (Class31.Class37.delegate0_40 = new Class31.Delegate0(Class31.smethod_93));
		}
		dictionary.Add(key71, new Class31.Struct12(struct0_71, delegate0_71));
		int key72 = class41_1.struct0_179.method_0();
		Struct0 struct0_72 = class41_1.struct0_179;
		Class31.Delegate0 delegate0_72;
		if ((delegate0_72 = Class31.Class37.delegate0_147) == null)
		{
			delegate0_72 = (Class31.Class37.delegate0_147 = new Class31.Delegate0(Class31.smethod_70));
		}
		dictionary.Add(key72, new Class31.Struct12(struct0_72, delegate0_72));
		int key73 = class41_1.struct0_134.method_0();
		Struct0 struct0_73 = class41_1.struct0_134;
		Class31.Delegate0 delegate0_73;
		if ((delegate0_73 = Class31.Class37.delegate0_145) == null)
		{
			delegate0_73 = (Class31.Class37.delegate0_145 = new Class31.Delegate0(Class31.smethod_46));
		}
		dictionary.Add(key73, new Class31.Struct12(struct0_73, delegate0_73));
		int key74 = class41_1.struct0_125.method_0();
		Struct0 struct0_74 = class41_1.struct0_125;
		Class31.Delegate0 delegate0_74;
		if ((delegate0_74 = Class31.Class37.delegate0_72) == null)
		{
			delegate0_74 = (Class31.Class37.delegate0_72 = new Class31.Delegate0(Class31.smethod_68));
		}
		dictionary.Add(key74, new Class31.Struct12(struct0_74, delegate0_74));
		int key75 = class41_1.struct0_2.method_0();
		Struct0 struct0_75 = class41_1.struct0_2;
		Class31.Delegate0 delegate0_75;
		if ((delegate0_75 = Class31.Class37.delegate0_191) == null)
		{
			delegate0_75 = (Class31.Class37.delegate0_191 = new Class31.Delegate0(Class31.smethod_52));
		}
		dictionary.Add(key75, new Class31.Struct12(struct0_75, delegate0_75));
		int key76 = class41_1.struct0_124.method_0();
		Struct0 struct0_76 = class41_1.struct0_124;
		Class31.Delegate0 delegate0_76;
		if ((delegate0_76 = Class31.Class37.delegate0_1) == null)
		{
			delegate0_76 = (Class31.Class37.delegate0_1 = new Class31.Delegate0(Class31.smethod_168));
		}
		dictionary.Add(key76, new Class31.Struct12(struct0_76, delegate0_76));
		int key77 = class41_1.struct0_193.method_0();
		Struct0 struct0_77 = class41_1.struct0_193;
		Class31.Delegate0 delegate0_77;
		if ((delegate0_77 = Class31.Class37.delegate0_116) == null)
		{
			delegate0_77 = (Class31.Class37.delegate0_116 = new Class31.Delegate0(Class31.smethod_129));
		}
		dictionary.Add(key77, new Class31.Struct12(struct0_77, delegate0_77));
		int key78 = class41_1.struct0_194.method_0();
		Struct0 struct0_78 = class41_1.struct0_194;
		Class31.Delegate0 delegate0_78;
		if ((delegate0_78 = Class31.Class37.delegate0_12) == null)
		{
			delegate0_78 = (Class31.Class37.delegate0_12 = new Class31.Delegate0(Class31.smethod_131));
		}
		dictionary.Add(key78, new Class31.Struct12(struct0_78, delegate0_78));
		int key79 = class41_1.struct0_188.method_0();
		Struct0 struct0_79 = class41_1.struct0_188;
		Class31.Delegate0 delegate0_79;
		if ((delegate0_79 = Class31.Class37.delegate0_165) == null)
		{
			delegate0_79 = (Class31.Class37.delegate0_165 = new Class31.Delegate0(Class31.smethod_240));
		}
		dictionary.Add(key79, new Class31.Struct12(struct0_79, delegate0_79));
		int key80 = class41_1.struct0_151.method_0();
		Struct0 struct0_80 = class41_1.struct0_151;
		Class31.Delegate0 delegate0_80;
		if ((delegate0_80 = Class31.Class37.delegate0_150) == null)
		{
			delegate0_80 = (Class31.Class37.delegate0_150 = new Class31.Delegate0(Class31.smethod_15));
		}
		dictionary.Add(key80, new Class31.Struct12(struct0_80, delegate0_80));
		int key81 = class41_1.struct0_57.method_0();
		Struct0 struct0_81 = class41_1.struct0_57;
		Class31.Delegate0 delegate0_81;
		if ((delegate0_81 = Class31.Class37.delegate0_151) == null)
		{
			delegate0_81 = (Class31.Class37.delegate0_151 = new Class31.Delegate0(Class31.smethod_124));
		}
		dictionary.Add(key81, new Class31.Struct12(struct0_81, delegate0_81));
		int key82 = class41_1.struct0_18.method_0();
		Struct0 struct0_82 = class41_1.struct0_18;
		Class31.Delegate0 delegate0_82;
		if ((delegate0_82 = Class31.Class37.delegate0_74) == null)
		{
			delegate0_82 = (Class31.Class37.delegate0_74 = new Class31.Delegate0(Class31.smethod_48));
		}
		dictionary.Add(key82, new Class31.Struct12(struct0_82, delegate0_82));
		int key83 = class41_1.struct0_7.method_0();
		Struct0 struct0_83 = class41_1.struct0_7;
		Class31.Delegate0 delegate0_83;
		if ((delegate0_83 = Class31.Class37.delegate0_194) == null)
		{
			delegate0_83 = (Class31.Class37.delegate0_194 = new Class31.Delegate0(Class31.smethod_73));
		}
		dictionary.Add(key83, new Class31.Struct12(struct0_83, delegate0_83));
		int key84 = class41_1.struct0_131.method_0();
		Struct0 struct0_84 = class41_1.struct0_131;
		Class31.Delegate0 delegate0_84;
		if ((delegate0_84 = Class31.Class37.delegate0_159) == null)
		{
			delegate0_84 = (Class31.Class37.delegate0_159 = new Class31.Delegate0(Class31.smethod_36));
		}
		dictionary.Add(key84, new Class31.Struct12(struct0_84, delegate0_84));
		int key85 = class41_1.struct0_153.method_0();
		Struct0 struct0_85 = class41_1.struct0_153;
		Class31.Delegate0 delegate0_85;
		if ((delegate0_85 = Class31.Class37.delegate0_108) == null)
		{
			delegate0_85 = (Class31.Class37.delegate0_108 = new Class31.Delegate0(Class31.smethod_215));
		}
		dictionary.Add(key85, new Class31.Struct12(struct0_85, delegate0_85));
		int key86 = class41_1.struct0_56.method_0();
		Struct0 struct0_86 = class41_1.struct0_56;
		Class31.Delegate0 delegate0_86;
		if ((delegate0_86 = Class31.Class37.delegate0_84) == null)
		{
			delegate0_86 = (Class31.Class37.delegate0_84 = new Class31.Delegate0(Class31.smethod_175));
		}
		dictionary.Add(key86, new Class31.Struct12(struct0_86, delegate0_86));
		int key87 = class41_1.struct0_94.method_0();
		Struct0 struct0_87 = class41_1.struct0_94;
		Class31.Delegate0 delegate0_87;
		if ((delegate0_87 = Class31.Class37.delegate0_38) == null)
		{
			delegate0_87 = (Class31.Class37.delegate0_38 = new Class31.Delegate0(Class31.smethod_34));
		}
		dictionary.Add(key87, new Class31.Struct12(struct0_87, delegate0_87));
		int key88 = class41_1.struct0_146.method_0();
		Struct0 struct0_88 = class41_1.struct0_146;
		Class31.Delegate0 delegate0_88;
		if ((delegate0_88 = Class31.Class37.delegate0_169) == null)
		{
			delegate0_88 = (Class31.Class37.delegate0_169 = new Class31.Delegate0(Class31.smethod_97));
		}
		dictionary.Add(key88, new Class31.Struct12(struct0_88, delegate0_88));
		int key89 = class41_1.struct0_204.method_0();
		Struct0 struct0_89 = class41_1.struct0_204;
		Class31.Delegate0 delegate0_89;
		if ((delegate0_89 = Class31.Class37.delegate0_67) == null)
		{
			delegate0_89 = (Class31.Class37.delegate0_67 = new Class31.Delegate0(Class31.smethod_0));
		}
		dictionary.Add(key89, new Class31.Struct12(struct0_89, delegate0_89));
		int key90 = class41_1.struct0_54.method_0();
		Struct0 struct0_90 = class41_1.struct0_54;
		Class31.Delegate0 delegate0_90;
		if ((delegate0_90 = Class31.Class37.delegate0_29) == null)
		{
			delegate0_90 = (Class31.Class37.delegate0_29 = new Class31.Delegate0(Class31.smethod_55));
		}
		dictionary.Add(key90, new Class31.Struct12(struct0_90, delegate0_90));
		int key91 = class41_1.struct0_202.method_0();
		Struct0 struct0_91 = class41_1.struct0_202;
		Class31.Delegate0 delegate0_91;
		if ((delegate0_91 = Class31.Class37.delegate0_19) == null)
		{
			delegate0_91 = (Class31.Class37.delegate0_19 = new Class31.Delegate0(Class31.smethod_102));
		}
		dictionary.Add(key91, new Class31.Struct12(struct0_91, delegate0_91));
		int key92 = class41_1.struct0_200.method_0();
		Struct0 struct0_92 = class41_1.struct0_200;
		Class31.Delegate0 delegate0_92;
		if ((delegate0_92 = Class31.Class37.delegate0_118) == null)
		{
			delegate0_92 = (Class31.Class37.delegate0_118 = new Class31.Delegate0(Class31.smethod_23));
		}
		dictionary.Add(key92, new Class31.Struct12(struct0_92, delegate0_92));
		int key93 = class41_1.struct0_207.method_0();
		Struct0 struct0_93 = class41_1.struct0_207;
		Class31.Delegate0 delegate0_93;
		if ((delegate0_93 = Class31.Class37.delegate0_188) == null)
		{
			delegate0_93 = (Class31.Class37.delegate0_188 = new Class31.Delegate0(Class31.smethod_128));
		}
		dictionary.Add(key93, new Class31.Struct12(struct0_93, delegate0_93));
		int key94 = class41_1.struct0_119.method_0();
		Struct0 struct0_94 = class41_1.struct0_119;
		Class31.Delegate0 delegate0_94;
		if ((delegate0_94 = Class31.Class37.delegate0_65) == null)
		{
			delegate0_94 = (Class31.Class37.delegate0_65 = new Class31.Delegate0(Class31.smethod_242));
		}
		dictionary.Add(key94, new Class31.Struct12(struct0_94, delegate0_94));
		int key95 = class41_1.struct0_75.method_0();
		Struct0 struct0_95 = class41_1.struct0_75;
		Class31.Delegate0 delegate0_95;
		if ((delegate0_95 = Class31.Class37.delegate0_51) == null)
		{
			delegate0_95 = (Class31.Class37.delegate0_51 = new Class31.Delegate0(Class31.smethod_147));
		}
		dictionary.Add(key95, new Class31.Struct12(struct0_95, delegate0_95));
		int key96 = class41_1.struct0_115.method_0();
		Struct0 struct0_96 = class41_1.struct0_115;
		Class31.Delegate0 delegate0_96;
		if ((delegate0_96 = Class31.Class37.delegate0_179) == null)
		{
			delegate0_96 = (Class31.Class37.delegate0_179 = new Class31.Delegate0(Class31.smethod_206));
		}
		dictionary.Add(key96, new Class31.Struct12(struct0_96, delegate0_96));
		int key97 = class41_1.struct0_24.method_0();
		Struct0 struct0_97 = class41_1.struct0_24;
		Class31.Delegate0 delegate0_97;
		if ((delegate0_97 = Class31.Class37.delegate0_146) == null)
		{
			delegate0_97 = (Class31.Class37.delegate0_146 = new Class31.Delegate0(Class31.smethod_53));
		}
		dictionary.Add(key97, new Class31.Struct12(struct0_97, delegate0_97));
		int key98 = class41_1.struct0_79.method_0();
		Struct0 struct0_98 = class41_1.struct0_79;
		Class31.Delegate0 delegate0_98;
		if ((delegate0_98 = Class31.Class37.delegate0_14) == null)
		{
			delegate0_98 = (Class31.Class37.delegate0_14 = new Class31.Delegate0(Class31.smethod_126));
		}
		dictionary.Add(key98, new Class31.Struct12(struct0_98, delegate0_98));
		int key99 = class41_1.struct0_165.method_0();
		Struct0 struct0_99 = class41_1.struct0_165;
		Class31.Delegate0 delegate0_99;
		if ((delegate0_99 = Class31.Class37.delegate0_18) == null)
		{
			delegate0_99 = (Class31.Class37.delegate0_18 = new Class31.Delegate0(Class31.smethod_157));
		}
		dictionary.Add(key99, new Class31.Struct12(struct0_99, delegate0_99));
		int key100 = class41_1.struct0_96.method_0();
		Struct0 struct0_100 = class41_1.struct0_96;
		Class31.Delegate0 delegate0_100;
		if ((delegate0_100 = Class31.Class37.delegate0_83) == null)
		{
			delegate0_100 = (Class31.Class37.delegate0_83 = new Class31.Delegate0(Class31.smethod_190));
		}
		dictionary.Add(key100, new Class31.Struct12(struct0_100, delegate0_100));
		int key101 = class41_1.struct0_9.method_0();
		Struct0 struct0_101 = class41_1.struct0_9;
		Class31.Delegate0 delegate0_101;
		if ((delegate0_101 = Class31.Class37.delegate0_182) == null)
		{
			delegate0_101 = (Class31.Class37.delegate0_182 = new Class31.Delegate0(Class31.smethod_25));
		}
		dictionary.Add(key101, new Class31.Struct12(struct0_101, delegate0_101));
		int key102 = class41_1.struct0_78.method_0();
		Struct0 struct0_102 = class41_1.struct0_78;
		Class31.Delegate0 delegate0_102;
		if ((delegate0_102 = Class31.Class37.delegate0_95) == null)
		{
			delegate0_102 = (Class31.Class37.delegate0_95 = new Class31.Delegate0(Class31.smethod_238));
		}
		dictionary.Add(key102, new Class31.Struct12(struct0_102, delegate0_102));
		int key103 = class41_1.struct0_150.method_0();
		Struct0 struct0_103 = class41_1.struct0_150;
		Class31.Delegate0 delegate0_103;
		if ((delegate0_103 = Class31.Class37.delegate0_15) == null)
		{
			delegate0_103 = (Class31.Class37.delegate0_15 = new Class31.Delegate0(Class31.smethod_42));
		}
		dictionary.Add(key103, new Class31.Struct12(struct0_103, delegate0_103));
		int key104 = class41_1.struct0_114.method_0();
		Struct0 struct0_104 = class41_1.struct0_114;
		Class31.Delegate0 delegate0_104;
		if ((delegate0_104 = Class31.Class37.delegate0_195) == null)
		{
			delegate0_104 = (Class31.Class37.delegate0_195 = new Class31.Delegate0(Class31.smethod_151));
		}
		dictionary.Add(key104, new Class31.Struct12(struct0_104, delegate0_104));
		int key105 = class41_1.struct0_118.method_0();
		Struct0 struct0_105 = class41_1.struct0_118;
		Class31.Delegate0 delegate0_105;
		if ((delegate0_105 = Class31.Class37.delegate0_112) == null)
		{
			delegate0_105 = (Class31.Class37.delegate0_112 = new Class31.Delegate0(Class31.smethod_185));
		}
		dictionary.Add(key105, new Class31.Struct12(struct0_105, delegate0_105));
		int key106 = class41_1.struct0_168.method_0();
		Struct0 struct0_106 = class41_1.struct0_168;
		Class31.Delegate0 delegate0_106;
		if ((delegate0_106 = Class31.Class37.delegate0_23) == null)
		{
			delegate0_106 = (Class31.Class37.delegate0_23 = new Class31.Delegate0(Class31.smethod_153));
		}
		dictionary.Add(key106, new Class31.Struct12(struct0_106, delegate0_106));
		int key107 = class41_1.struct0_30.method_0();
		Struct0 struct0_107 = class41_1.struct0_30;
		Class31.Delegate0 delegate0_107;
		if ((delegate0_107 = Class31.Class37.delegate0_11) == null)
		{
			delegate0_107 = (Class31.Class37.delegate0_11 = new Class31.Delegate0(Class31.smethod_50));
		}
		dictionary.Add(key107, new Class31.Struct12(struct0_107, delegate0_107));
		int key108 = class41_1.struct0_26.method_0();
		Struct0 struct0_108 = class41_1.struct0_26;
		Class31.Delegate0 delegate0_108;
		if ((delegate0_108 = Class31.Class37.delegate0_152) == null)
		{
			delegate0_108 = (Class31.Class37.delegate0_152 = new Class31.Delegate0(Class31.smethod_105));
		}
		dictionary.Add(key108, new Class31.Struct12(struct0_108, delegate0_108));
		int key109 = class41_1.struct0_87.method_0();
		Struct0 struct0_109 = class41_1.struct0_87;
		Class31.Delegate0 delegate0_109;
		if ((delegate0_109 = Class31.Class37.delegate0_98) == null)
		{
			delegate0_109 = (Class31.Class37.delegate0_98 = new Class31.Delegate0(Class31.smethod_193));
		}
		dictionary.Add(key109, new Class31.Struct12(struct0_109, delegate0_109));
		int key110 = class41_1.struct0_53.method_0();
		Struct0 struct0_110 = class41_1.struct0_53;
		Class31.Delegate0 delegate0_110;
		if ((delegate0_110 = Class31.Class37.delegate0_97) == null)
		{
			delegate0_110 = (Class31.Class37.delegate0_97 = new Class31.Delegate0(Class31.smethod_204));
		}
		dictionary.Add(key110, new Class31.Struct12(struct0_110, delegate0_110));
		int key111 = class41_1.struct0_95.method_0();
		Struct0 struct0_111 = class41_1.struct0_95;
		Class31.Delegate0 delegate0_111;
		if ((delegate0_111 = Class31.Class37.delegate0_13) == null)
		{
			delegate0_111 = (Class31.Class37.delegate0_13 = new Class31.Delegate0(Class31.smethod_166));
		}
		dictionary.Add(key111, new Class31.Struct12(struct0_111, delegate0_111));
		int key112 = class41_1.struct0_195.method_0();
		Struct0 struct0_112 = class41_1.struct0_195;
		Class31.Delegate0 delegate0_112;
		if ((delegate0_112 = Class31.Class37.delegate0_115) == null)
		{
			delegate0_112 = (Class31.Class37.delegate0_115 = new Class31.Delegate0(Class31.smethod_82));
		}
		dictionary.Add(key112, new Class31.Struct12(struct0_112, delegate0_112));
		int key113 = class41_1.struct0_22.method_0();
		Struct0 struct0_113 = class41_1.struct0_22;
		Class31.Delegate0 delegate0_113;
		if ((delegate0_113 = Class31.Class37.delegate0_154) == null)
		{
			delegate0_113 = (Class31.Class37.delegate0_154 = new Class31.Delegate0(Class31.smethod_142));
		}
		dictionary.Add(key113, new Class31.Struct12(struct0_113, delegate0_113));
		int key114 = class41_1.struct0_101.method_0();
		Struct0 struct0_114 = class41_1.struct0_101;
		Class31.Delegate0 delegate0_114;
		if ((delegate0_114 = Class31.Class37.delegate0_102) == null)
		{
			delegate0_114 = (Class31.Class37.delegate0_102 = new Class31.Delegate0(Class31.smethod_176));
		}
		dictionary.Add(key114, new Class31.Struct12(struct0_114, delegate0_114));
		int key115 = class41_1.struct0_209.method_0();
		Struct0 struct0_115 = class41_1.struct0_209;
		Class31.Delegate0 delegate0_115;
		if ((delegate0_115 = Class31.Class37.delegate0_163) == null)
		{
			delegate0_115 = (Class31.Class37.delegate0_163 = new Class31.Delegate0(Class31.smethod_114));
		}
		dictionary.Add(key115, new Class31.Struct12(struct0_115, delegate0_115));
		int key116 = class41_1.struct0_208.method_0();
		Struct0 struct0_116 = class41_1.struct0_208;
		Class31.Delegate0 delegate0_116;
		if ((delegate0_116 = Class31.Class37.delegate0_130) == null)
		{
			delegate0_116 = (Class31.Class37.delegate0_130 = new Class31.Delegate0(Class31.smethod_20));
		}
		dictionary.Add(key116, new Class31.Struct12(struct0_116, delegate0_116));
		int key117 = class41_1.struct0_174.method_0();
		Struct0 struct0_117 = class41_1.struct0_174;
		Class31.Delegate0 delegate0_117;
		if ((delegate0_117 = Class31.Class37.delegate0_175) == null)
		{
			delegate0_117 = (Class31.Class37.delegate0_175 = new Class31.Delegate0(Class31.smethod_139));
		}
		dictionary.Add(key117, new Class31.Struct12(struct0_117, delegate0_117));
		int key118 = class41_1.struct0_90.method_0();
		Struct0 struct0_118 = class41_1.struct0_90;
		Class31.Delegate0 delegate0_118;
		if ((delegate0_118 = Class31.Class37.delegate0_186) == null)
		{
			delegate0_118 = (Class31.Class37.delegate0_186 = new Class31.Delegate0(Class31.smethod_163));
		}
		dictionary.Add(key118, new Class31.Struct12(struct0_118, delegate0_118));
		int key119 = class41_1.struct0_137.method_0();
		Struct0 struct0_119 = class41_1.struct0_137;
		Class31.Delegate0 delegate0_119;
		if ((delegate0_119 = Class31.Class37.delegate0_26) == null)
		{
			delegate0_119 = (Class31.Class37.delegate0_26 = new Class31.Delegate0(Class31.smethod_85));
		}
		dictionary.Add(key119, new Class31.Struct12(struct0_119, delegate0_119));
		int key120 = class41_1.struct0_192.method_0();
		Struct0 struct0_120 = class41_1.struct0_192;
		Class31.Delegate0 delegate0_120;
		if ((delegate0_120 = Class31.Class37.delegate0_10) == null)
		{
			delegate0_120 = (Class31.Class37.delegate0_10 = new Class31.Delegate0(Class31.smethod_216));
		}
		dictionary.Add(key120, new Class31.Struct12(struct0_120, delegate0_120));
		int key121 = class41_1.struct0_191.method_0();
		Struct0 struct0_121 = class41_1.struct0_191;
		Class31.Delegate0 delegate0_121;
		if ((delegate0_121 = Class31.Class37.delegate0_139) == null)
		{
			delegate0_121 = (Class31.Class37.delegate0_139 = new Class31.Delegate0(Class31.smethod_11));
		}
		dictionary.Add(key121, new Class31.Struct12(struct0_121, delegate0_121));
		int key122 = class41_1.struct0_211.method_0();
		Struct0 struct0_122 = class41_1.struct0_211;
		Class31.Delegate0 delegate0_122;
		if ((delegate0_122 = Class31.Class37.delegate0_82) == null)
		{
			delegate0_122 = (Class31.Class37.delegate0_82 = new Class31.Delegate0(Class31.smethod_80));
		}
		dictionary.Add(key122, new Class31.Struct12(struct0_122, delegate0_122));
		int key123 = class41_1.struct0_106.method_0();
		Struct0 struct0_123 = class41_1.struct0_106;
		Class31.Delegate0 delegate0_123;
		if ((delegate0_123 = Class31.Class37.delegate0_64) == null)
		{
			delegate0_123 = (Class31.Class37.delegate0_64 = new Class31.Delegate0(Class31.smethod_28));
		}
		dictionary.Add(key123, new Class31.Struct12(struct0_123, delegate0_123));
		int key124 = class41_1.struct0_36.method_0();
		Struct0 struct0_124 = class41_1.struct0_36;
		Class31.Delegate0 delegate0_124;
		if ((delegate0_124 = Class31.Class37.delegate0_8) == null)
		{
			delegate0_124 = (Class31.Class37.delegate0_8 = new Class31.Delegate0(Class31.smethod_130));
		}
		dictionary.Add(key124, new Class31.Struct12(struct0_124, delegate0_124));
		int key125 = class41_1.struct0_162.method_0();
		Struct0 struct0_125 = class41_1.struct0_162;
		Class31.Delegate0 delegate0_125;
		if ((delegate0_125 = Class31.Class37.delegate0_52) == null)
		{
			delegate0_125 = (Class31.Class37.delegate0_52 = new Class31.Delegate0(Class31.smethod_169));
		}
		dictionary.Add(key125, new Class31.Struct12(struct0_125, delegate0_125));
		int key126 = class41_1.struct0_74.method_0();
		Struct0 struct0_126 = class41_1.struct0_74;
		Class31.Delegate0 delegate0_126;
		if ((delegate0_126 = Class31.Class37.delegate0_196) == null)
		{
			delegate0_126 = (Class31.Class37.delegate0_196 = new Class31.Delegate0(Class31.smethod_225));
		}
		dictionary.Add(key126, new Class31.Struct12(struct0_126, delegate0_126));
		int key127 = class41_1.struct0_116.method_0();
		Struct0 struct0_127 = class41_1.struct0_116;
		Class31.Delegate0 delegate0_127;
		if ((delegate0_127 = Class31.Class37.delegate0_27) == null)
		{
			delegate0_127 = (Class31.Class37.delegate0_27 = new Class31.Delegate0(Class31.smethod_123));
		}
		dictionary.Add(key127, new Class31.Struct12(struct0_127, delegate0_127));
		int key128 = class41_1.struct0_183.method_0();
		Struct0 struct0_128 = class41_1.struct0_183;
		Class31.Delegate0 delegate0_128;
		if ((delegate0_128 = Class31.Class37.delegate0_128) == null)
		{
			delegate0_128 = (Class31.Class37.delegate0_128 = new Class31.Delegate0(Class31.smethod_110));
		}
		dictionary.Add(key128, new Class31.Struct12(struct0_128, delegate0_128));
		int key129 = class41_1.struct0_55.method_0();
		Struct0 struct0_129 = class41_1.struct0_55;
		Class31.Delegate0 delegate0_129;
		if ((delegate0_129 = Class31.Class37.delegate0_176) == null)
		{
			delegate0_129 = (Class31.Class37.delegate0_176 = new Class31.Delegate0(Class31.smethod_200));
		}
		dictionary.Add(key129, new Class31.Struct12(struct0_129, delegate0_129));
		int key130 = class41_1.struct0_5.method_0();
		Struct0 struct0_130 = class41_1.struct0_5;
		Class31.Delegate0 delegate0_130;
		if ((delegate0_130 = Class31.Class37.delegate0_89) == null)
		{
			delegate0_130 = (Class31.Class37.delegate0_89 = new Class31.Delegate0(Class31.smethod_239));
		}
		dictionary.Add(key130, new Class31.Struct12(struct0_130, delegate0_130));
		int key131 = class41_1.struct0_50.method_0();
		Struct0 struct0_131 = class41_1.struct0_50;
		Class31.Delegate0 delegate0_131;
		if ((delegate0_131 = Class31.Class37.delegate0_45) == null)
		{
			delegate0_131 = (Class31.Class37.delegate0_45 = new Class31.Delegate0(Class31.smethod_14));
		}
		dictionary.Add(key131, new Class31.Struct12(struct0_131, delegate0_131));
		int key132 = class41_1.struct0_15.method_0();
		Struct0 struct0_132 = class41_1.struct0_15;
		Class31.Delegate0 delegate0_132;
		if ((delegate0_132 = Class31.Class37.delegate0_164) == null)
		{
			delegate0_132 = (Class31.Class37.delegate0_164 = new Class31.Delegate0(Class31.smethod_246));
		}
		dictionary.Add(key132, new Class31.Struct12(struct0_132, delegate0_132));
		int key133 = class41_1.struct0_109.method_0();
		Struct0 struct0_133 = class41_1.struct0_109;
		Class31.Delegate0 delegate0_133;
		if ((delegate0_133 = Class31.Class37.delegate0_56) == null)
		{
			delegate0_133 = (Class31.Class37.delegate0_56 = new Class31.Delegate0(Class31.smethod_205));
		}
		dictionary.Add(key133, new Class31.Struct12(struct0_133, delegate0_133));
		int key134 = class41_1.struct0_159.method_0();
		Struct0 struct0_134 = class41_1.struct0_159;
		Class31.Delegate0 delegate0_134;
		if ((delegate0_134 = Class31.Class37.delegate0_57) == null)
		{
			delegate0_134 = (Class31.Class37.delegate0_57 = new Class31.Delegate0(Class31.smethod_98));
		}
		dictionary.Add(key134, new Class31.Struct12(struct0_134, delegate0_134));
		int key135 = class41_1.struct0_3.method_0();
		Struct0 struct0_135 = class41_1.struct0_3;
		Class31.Delegate0 delegate0_135;
		if ((delegate0_135 = Class31.Class37.delegate0_157) == null)
		{
			delegate0_135 = (Class31.Class37.delegate0_157 = new Class31.Delegate0(Class31.smethod_120));
		}
		dictionary.Add(key135, new Class31.Struct12(struct0_135, delegate0_135));
		int key136 = class41_1.struct0_6.method_0();
		Struct0 struct0_136 = class41_1.struct0_6;
		Class31.Delegate0 delegate0_136;
		if ((delegate0_136 = Class31.Class37.delegate0_81) == null)
		{
			delegate0_136 = (Class31.Class37.delegate0_81 = new Class31.Delegate0(Class31.smethod_107));
		}
		dictionary.Add(key136, new Class31.Struct12(struct0_136, delegate0_136));
		int key137 = class41_1.struct0_110.method_0();
		Struct0 struct0_137 = class41_1.struct0_110;
		Class31.Delegate0 delegate0_137;
		if ((delegate0_137 = Class31.Class37.delegate0_170) == null)
		{
			delegate0_137 = (Class31.Class37.delegate0_170 = new Class31.Delegate0(Class31.smethod_104));
		}
		dictionary.Add(key137, new Class31.Struct12(struct0_137, delegate0_137));
		int key138 = class41_1.struct0_76.method_0();
		Struct0 struct0_138 = class41_1.struct0_76;
		Class31.Delegate0 delegate0_138;
		if ((delegate0_138 = Class31.Class37.delegate0_167) == null)
		{
			delegate0_138 = (Class31.Class37.delegate0_167 = new Class31.Delegate0(Class31.smethod_226));
		}
		dictionary.Add(key138, new Class31.Struct12(struct0_138, delegate0_138));
		int key139 = class41_1.struct0_52.method_0();
		Struct0 struct0_139 = class41_1.struct0_52;
		Class31.Delegate0 delegate0_139;
		if ((delegate0_139 = Class31.Class37.delegate0_199) == null)
		{
			delegate0_139 = (Class31.Class37.delegate0_199 = new Class31.Delegate0(Class31.smethod_154));
		}
		dictionary.Add(key139, new Class31.Struct12(struct0_139, delegate0_139));
		int key140 = class41_1.struct0_214.method_0();
		Struct0 struct0_140 = class41_1.struct0_214;
		Class31.Delegate0 delegate0_140;
		if ((delegate0_140 = Class31.Class37.delegate0_127) == null)
		{
			delegate0_140 = (Class31.Class37.delegate0_127 = new Class31.Delegate0(Class31.smethod_173));
		}
		dictionary.Add(key140, new Class31.Struct12(struct0_140, delegate0_140));
		int key141 = class41_1.struct0_71.method_0();
		Struct0 struct0_141 = class41_1.struct0_71;
		Class31.Delegate0 delegate0_141;
		if ((delegate0_141 = Class31.Class37.delegate0_68) == null)
		{
			delegate0_141 = (Class31.Class37.delegate0_68 = new Class31.Delegate0(Class31.smethod_32));
		}
		dictionary.Add(key141, new Class31.Struct12(struct0_141, delegate0_141));
		int key142 = class41_1.struct0_40.method_0();
		Struct0 struct0_142 = class41_1.struct0_40;
		Class31.Delegate0 delegate0_142;
		if ((delegate0_142 = Class31.Class37.delegate0_200) == null)
		{
			delegate0_142 = (Class31.Class37.delegate0_200 = new Class31.Delegate0(Class31.smethod_77));
		}
		dictionary.Add(key142, new Class31.Struct12(struct0_142, delegate0_142));
		int key143 = class41_1.struct0_99.method_0();
		Struct0 struct0_143 = class41_1.struct0_99;
		Class31.Delegate0 delegate0_143;
		if ((delegate0_143 = Class31.Class37.delegate0_140) == null)
		{
			delegate0_143 = (Class31.Class37.delegate0_140 = new Class31.Delegate0(Class31.smethod_17));
		}
		dictionary.Add(key143, new Class31.Struct12(struct0_143, delegate0_143));
		int key144 = class41_1.struct0_65.method_0();
		Struct0 struct0_144 = class41_1.struct0_65;
		Class31.Delegate0 delegate0_144;
		if ((delegate0_144 = Class31.Class37.delegate0_137) == null)
		{
			delegate0_144 = (Class31.Class37.delegate0_137 = new Class31.Delegate0(Class31.smethod_245));
		}
		dictionary.Add(key144, new Class31.Struct12(struct0_144, delegate0_144));
		int key145 = class41_1.struct0_51.method_0();
		Struct0 struct0_145 = class41_1.struct0_51;
		Class31.Delegate0 delegate0_145;
		if ((delegate0_145 = Class31.Class37.delegate0_183) == null)
		{
			delegate0_145 = (Class31.Class37.delegate0_183 = new Class31.Delegate0(Class31.smethod_100));
		}
		dictionary.Add(key145, new Class31.Struct12(struct0_145, delegate0_145));
		int key146 = class41_1.struct0_58.method_0();
		Struct0 struct0_146 = class41_1.struct0_58;
		Class31.Delegate0 delegate0_146;
		if ((delegate0_146 = Class31.Class37.delegate0_55) == null)
		{
			delegate0_146 = (Class31.Class37.delegate0_55 = new Class31.Delegate0(Class31.smethod_16));
		}
		dictionary.Add(key146, new Class31.Struct12(struct0_146, delegate0_146));
		int key147 = class41_1.struct0_154.method_0();
		Struct0 struct0_147 = class41_1.struct0_154;
		Class31.Delegate0 delegate0_147;
		if ((delegate0_147 = Class31.Class37.delegate0_60) == null)
		{
			delegate0_147 = (Class31.Class37.delegate0_60 = new Class31.Delegate0(Class31.smethod_230));
		}
		dictionary.Add(key147, new Class31.Struct12(struct0_147, delegate0_147));
		int key148 = class41_1.struct0_13.method_0();
		Struct0 struct0_148 = class41_1.struct0_13;
		Class31.Delegate0 delegate0_148;
		if ((delegate0_148 = Class31.Class37.delegate0_119) == null)
		{
			delegate0_148 = (Class31.Class37.delegate0_119 = new Class31.Delegate0(Class31.smethod_44));
		}
		dictionary.Add(key148, new Class31.Struct12(struct0_148, delegate0_148));
		int key149 = class41_1.struct0_103.method_0();
		Struct0 struct0_149 = class41_1.struct0_103;
		Class31.Delegate0 delegate0_149;
		if ((delegate0_149 = Class31.Class37.delegate0_109) == null)
		{
			delegate0_149 = (Class31.Class37.delegate0_109 = new Class31.Delegate0(Class31.smethod_227));
		}
		dictionary.Add(key149, new Class31.Struct12(struct0_149, delegate0_149));
		int key150 = class41_1.struct0_139.method_0();
		Struct0 struct0_150 = class41_1.struct0_139;
		Class31.Delegate0 delegate0_150;
		if ((delegate0_150 = Class31.Class37.delegate0_148) == null)
		{
			delegate0_150 = (Class31.Class37.delegate0_148 = new Class31.Delegate0(Class31.smethod_27));
		}
		dictionary.Add(key150, new Class31.Struct12(struct0_150, delegate0_150));
		int key151 = class41_1.struct0_4.method_0();
		Struct0 struct0_151 = class41_1.struct0_4;
		Class31.Delegate0 delegate0_151;
		if ((delegate0_151 = Class31.Class37.delegate0_121) == null)
		{
			delegate0_151 = (Class31.Class37.delegate0_121 = new Class31.Delegate0(Class31.smethod_170));
		}
		dictionary.Add(key151, new Class31.Struct12(struct0_151, delegate0_151));
		int key152 = class41_1.struct0_108.method_0();
		Struct0 struct0_152 = class41_1.struct0_108;
		Class31.Delegate0 delegate0_152;
		if ((delegate0_152 = Class31.Class37.delegate0_144) == null)
		{
			delegate0_152 = (Class31.Class37.delegate0_144 = new Class31.Delegate0(Class31.smethod_140));
		}
		dictionary.Add(key152, new Class31.Struct12(struct0_152, delegate0_152));
		int key153 = class41_1.struct0_28.method_0();
		Struct0 struct0_153 = class41_1.struct0_28;
		Class31.Delegate0 delegate0_153;
		if ((delegate0_153 = Class31.Class37.delegate0_66) == null)
		{
			delegate0_153 = (Class31.Class37.delegate0_66 = new Class31.Delegate0(Class31.smethod_7));
		}
		dictionary.Add(key153, new Class31.Struct12(struct0_153, delegate0_153));
		int key154 = class41_1.struct0_62.method_0();
		Struct0 struct0_154 = class41_1.struct0_62;
		Class31.Delegate0 delegate0_154;
		if ((delegate0_154 = Class31.Class37.delegate0_185) == null)
		{
			delegate0_154 = (Class31.Class37.delegate0_185 = new Class31.Delegate0(Class31.smethod_4));
		}
		dictionary.Add(key154, new Class31.Struct12(struct0_154, delegate0_154));
		int key155 = class41_1.struct0_20.method_0();
		Struct0 struct0_155 = class41_1.struct0_20;
		Class31.Delegate0 delegate0_155;
		if ((delegate0_155 = Class31.Class37.delegate0_174) == null)
		{
			delegate0_155 = (Class31.Class37.delegate0_174 = new Class31.Delegate0(Class31.smethod_244));
		}
		dictionary.Add(key155, new Class31.Struct12(struct0_155, delegate0_155));
		int key156 = class41_1.struct0_171.method_0();
		Struct0 struct0_156 = class41_1.struct0_171;
		Class31.Delegate0 delegate0_156;
		if ((delegate0_156 = Class31.Class37.delegate0_197) == null)
		{
			delegate0_156 = (Class31.Class37.delegate0_197 = new Class31.Delegate0(Class31.smethod_54));
		}
		dictionary.Add(key156, new Class31.Struct12(struct0_156, delegate0_156));
		int key157 = class41_1.struct0_93.method_0();
		Struct0 struct0_157 = class41_1.struct0_93;
		Class31.Delegate0 delegate0_157;
		if ((delegate0_157 = Class31.Class37.delegate0_20) == null)
		{
			delegate0_157 = (Class31.Class37.delegate0_20 = new Class31.Delegate0(Class31.smethod_127));
		}
		dictionary.Add(key157, new Class31.Struct12(struct0_157, delegate0_157));
		int key158 = class41_1.struct0_178.method_0();
		Struct0 struct0_158 = class41_1.struct0_178;
		Class31.Delegate0 delegate0_158;
		if ((delegate0_158 = Class31.Class37.delegate0_37) == null)
		{
			delegate0_158 = (Class31.Class37.delegate0_37 = new Class31.Delegate0(Class31.smethod_187));
		}
		dictionary.Add(key158, new Class31.Struct12(struct0_158, delegate0_158));
		int key159 = class41_1.struct0_86.method_0();
		Struct0 struct0_159 = class41_1.struct0_86;
		Class31.Delegate0 delegate0_159;
		if ((delegate0_159 = Class31.Class37.delegate0_49) == null)
		{
			delegate0_159 = (Class31.Class37.delegate0_49 = new Class31.Delegate0(Class31.smethod_38));
		}
		dictionary.Add(key159, new Class31.Struct12(struct0_159, delegate0_159));
		int key160 = class41_1.struct0_143.method_0();
		Struct0 struct0_160 = class41_1.struct0_143;
		Class31.Delegate0 delegate0_160;
		if ((delegate0_160 = Class31.Class37.delegate0_28) == null)
		{
			delegate0_160 = (Class31.Class37.delegate0_28 = new Class31.Delegate0(Class31.smethod_135));
		}
		dictionary.Add(key160, new Class31.Struct12(struct0_160, delegate0_160));
		int key161 = class41_1.struct0_186.method_0();
		Struct0 struct0_161 = class41_1.struct0_186;
		Class31.Delegate0 delegate0_161;
		if ((delegate0_161 = Class31.Class37.delegate0_34) == null)
		{
			delegate0_161 = (Class31.Class37.delegate0_34 = new Class31.Delegate0(Class31.smethod_218));
		}
		dictionary.Add(key161, new Class31.Struct12(struct0_161, delegate0_161));
		int key162 = class41_1.struct0_111.method_0();
		Struct0 struct0_162 = class41_1.struct0_111;
		Class31.Delegate0 delegate0_162;
		if ((delegate0_162 = Class31.Class37.delegate0_69) == null)
		{
			delegate0_162 = (Class31.Class37.delegate0_69 = new Class31.Delegate0(Class31.smethod_13));
		}
		dictionary.Add(key162, new Class31.Struct12(struct0_162, delegate0_162));
		int key163 = class41_1.struct0_72.method_0();
		Struct0 struct0_163 = class41_1.struct0_72;
		Class31.Delegate0 delegate0_163;
		if ((delegate0_163 = Class31.Class37.delegate0_6) == null)
		{
			delegate0_163 = (Class31.Class37.delegate0_6 = new Class31.Delegate0(Class31.smethod_83));
		}
		dictionary.Add(key163, new Class31.Struct12(struct0_163, delegate0_163));
		int key164 = class41_1.struct0_138.method_0();
		Struct0 struct0_164 = class41_1.struct0_138;
		Class31.Delegate0 delegate0_164;
		if ((delegate0_164 = Class31.Class37.delegate0_129) == null)
		{
			delegate0_164 = (Class31.Class37.delegate0_129 = new Class31.Delegate0(Class31.smethod_29));
		}
		dictionary.Add(key164, new Class31.Struct12(struct0_164, delegate0_164));
		int key165 = class41_1.struct0_199.method_0();
		Struct0 struct0_165 = class41_1.struct0_199;
		Class31.Delegate0 delegate0_165;
		if ((delegate0_165 = Class31.Class37.delegate0_92) == null)
		{
			delegate0_165 = (Class31.Class37.delegate0_92 = new Class31.Delegate0(Class31.smethod_103));
		}
		dictionary.Add(key165, new Class31.Struct12(struct0_165, delegate0_165));
		int key166 = class41_1.struct0_189.method_0();
		Struct0 struct0_166 = class41_1.struct0_189;
		Class31.Delegate0 delegate0_166;
		if ((delegate0_166 = Class31.Class37.delegate0_177) == null)
		{
			delegate0_166 = (Class31.Class37.delegate0_177 = new Class31.Delegate0(Class31.smethod_95));
		}
		dictionary.Add(key166, new Class31.Struct12(struct0_166, delegate0_166));
		int key167 = class41_1.struct0_81.method_0();
		Struct0 struct0_167 = class41_1.struct0_81;
		Class31.Delegate0 delegate0_167;
		if ((delegate0_167 = Class31.Class37.delegate0_132) == null)
		{
			delegate0_167 = (Class31.Class37.delegate0_132 = new Class31.Delegate0(Class31.smethod_2));
		}
		dictionary.Add(key167, new Class31.Struct12(struct0_167, delegate0_167));
		int key168 = class41_1.struct0_61.method_0();
		Struct0 struct0_168 = class41_1.struct0_61;
		Class31.Delegate0 delegate0_168;
		if ((delegate0_168 = Class31.Class37.delegate0_104) == null)
		{
			delegate0_168 = (Class31.Class37.delegate0_104 = new Class31.Delegate0(Class31.smethod_164));
		}
		dictionary.Add(key168, new Class31.Struct12(struct0_168, delegate0_168));
		int key169 = class41_1.struct0_21.method_0();
		Struct0 struct0_169 = class41_1.struct0_21;
		Class31.Delegate0 delegate0_169;
		if ((delegate0_169 = Class31.Class37.delegate0_201) == null)
		{
			delegate0_169 = (Class31.Class37.delegate0_201 = new Class31.Delegate0(Class31.smethod_160));
		}
		dictionary.Add(key169, new Class31.Struct12(struct0_169, delegate0_169));
		int key170 = class41_1.struct0_128.method_0();
		Struct0 struct0_170 = class41_1.struct0_128;
		Class31.Delegate0 delegate0_170;
		if ((delegate0_170 = Class31.Class37.delegate0_39) == null)
		{
			delegate0_170 = (Class31.Class37.delegate0_39 = new Class31.Delegate0(Class31.smethod_133));
		}
		dictionary.Add(key170, new Class31.Struct12(struct0_170, delegate0_170));
		int key171 = class41_1.struct0_160.method_0();
		Struct0 struct0_171 = class41_1.struct0_160;
		Class31.Delegate0 delegate0_171;
		if ((delegate0_171 = Class31.Class37.delegate0_111) == null)
		{
			delegate0_171 = (Class31.Class37.delegate0_111 = new Class31.Delegate0(Class31.smethod_88));
		}
		dictionary.Add(key171, new Class31.Struct12(struct0_171, delegate0_171));
		int key172 = class41_1.struct0_133.method_0();
		Struct0 struct0_172 = class41_1.struct0_133;
		Class31.Delegate0 delegate0_172;
		if ((delegate0_172 = Class31.Class37.delegate0_124) == null)
		{
			delegate0_172 = (Class31.Class37.delegate0_124 = new Class31.Delegate0(Class31.smethod_66));
		}
		dictionary.Add(key172, new Class31.Struct12(struct0_172, delegate0_172));
		int key173 = class41_1.struct0_91.method_0();
		Struct0 struct0_173 = class41_1.struct0_91;
		Class31.Delegate0 delegate0_173;
		if ((delegate0_173 = Class31.Class37.delegate0_93) == null)
		{
			delegate0_173 = (Class31.Class37.delegate0_93 = new Class31.Delegate0(Class31.smethod_146));
		}
		dictionary.Add(key173, new Class31.Struct12(struct0_173, delegate0_173));
		int key174 = class41_1.struct0_201.method_0();
		Struct0 struct0_174 = class41_1.struct0_201;
		Class31.Delegate0 delegate0_174;
		if ((delegate0_174 = Class31.Class37.delegate0_33) == null)
		{
			delegate0_174 = (Class31.Class37.delegate0_33 = new Class31.Delegate0(Class31.smethod_217));
		}
		dictionary.Add(key174, new Class31.Struct12(struct0_174, delegate0_174));
		int key175 = class41_1.struct0_1.method_0();
		Struct0 struct0_175 = class41_1.struct0_1;
		Class31.Delegate0 delegate0_175;
		if ((delegate0_175 = Class31.Class37.delegate0_46) == null)
		{
			delegate0_175 = (Class31.Class37.delegate0_46 = new Class31.Delegate0(Class31.smethod_155));
		}
		dictionary.Add(key175, new Class31.Struct12(struct0_175, delegate0_175));
		int key176 = class41_1.struct0_187.method_0();
		Struct0 struct0_176 = class41_1.struct0_187;
		Class31.Delegate0 delegate0_176;
		if ((delegate0_176 = Class31.Class37.delegate0_178) == null)
		{
			delegate0_176 = (Class31.Class37.delegate0_178 = new Class31.Delegate0(Class31.smethod_113));
		}
		dictionary.Add(key176, new Class31.Struct12(struct0_176, delegate0_176));
		int key177 = class41_1.struct0_181.method_0();
		Struct0 struct0_177 = class41_1.struct0_181;
		Class31.Delegate0 delegate0_177;
		if ((delegate0_177 = Class31.Class37.delegate0_94) == null)
		{
			delegate0_177 = (Class31.Class37.delegate0_94 = new Class31.Delegate0(Class31.smethod_33));
		}
		dictionary.Add(key177, new Class31.Struct12(struct0_177, delegate0_177));
		int key178 = class41_1.struct0_213.method_0();
		Struct0 struct0_178 = class41_1.struct0_213;
		Class31.Delegate0 delegate0_178;
		if ((delegate0_178 = Class31.Class37.delegate0_133) == null)
		{
			delegate0_178 = (Class31.Class37.delegate0_133 = new Class31.Delegate0(Class31.smethod_108));
		}
		dictionary.Add(key178, new Class31.Struct12(struct0_178, delegate0_178));
		int key179 = class41_1.struct0_44.method_0();
		Struct0 struct0_179 = class41_1.struct0_44;
		Class31.Delegate0 delegate0_179;
		if ((delegate0_179 = Class31.Class37.delegate0_172) == null)
		{
			delegate0_179 = (Class31.Class37.delegate0_172 = new Class31.Delegate0(Class31.smethod_241));
		}
		dictionary.Add(key179, new Class31.Struct12(struct0_179, delegate0_179));
		int key180 = class41_1.struct0_166.method_0();
		Struct0 struct0_180 = class41_1.struct0_166;
		Class31.Delegate0 delegate0_180;
		if ((delegate0_180 = Class31.Class37.delegate0_54) == null)
		{
			delegate0_180 = (Class31.Class37.delegate0_54 = new Class31.Delegate0(Class31.smethod_116));
		}
		dictionary.Add(key180, new Class31.Struct12(struct0_180, delegate0_180));
		int key181 = class41_1.struct0_46.method_0();
		Struct0 struct0_181 = class41_1.struct0_46;
		Class31.Delegate0 delegate0_181;
		if ((delegate0_181 = Class31.Class37.delegate0_80) == null)
		{
			delegate0_181 = (Class31.Class37.delegate0_80 = new Class31.Delegate0(Class31.smethod_219));
		}
		dictionary.Add(key181, new Class31.Struct12(struct0_181, delegate0_181));
		int key182 = class41_1.struct0_132.method_0();
		Struct0 struct0_182 = class41_1.struct0_132;
		Class31.Delegate0 delegate0_182;
		if ((delegate0_182 = Class31.Class37.delegate0_90) == null)
		{
			delegate0_182 = (Class31.Class37.delegate0_90 = new Class31.Delegate0(Class31.smethod_209));
		}
		dictionary.Add(key182, new Class31.Struct12(struct0_182, delegate0_182));
		int key183 = class41_1.struct0_169.method_0();
		Struct0 struct0_183 = class41_1.struct0_169;
		Class31.Delegate0 delegate0_183;
		if ((delegate0_183 = Class31.Class37.delegate0_87) == null)
		{
			delegate0_183 = (Class31.Class37.delegate0_87 = new Class31.Delegate0(Class31.smethod_9));
		}
		dictionary.Add(key183, new Class31.Struct12(struct0_183, delegate0_183));
		int key184 = class41_1.struct0_23.method_0();
		Struct0 struct0_184 = class41_1.struct0_23;
		Class31.Delegate0 delegate0_184;
		if ((delegate0_184 = Class31.Class37.delegate0_198) == null)
		{
			delegate0_184 = (Class31.Class37.delegate0_198 = new Class31.Delegate0(Class31.smethod_56));
		}
		dictionary.Add(key184, new Class31.Struct12(struct0_184, delegate0_184));
		int key185 = class41_1.struct0_144.method_0();
		Struct0 struct0_185 = class41_1.struct0_144;
		Class31.Delegate0 delegate0_185;
		if ((delegate0_185 = Class31.Class37.delegate0_125) == null)
		{
			delegate0_185 = (Class31.Class37.delegate0_125 = new Class31.Delegate0(Class31.smethod_35));
		}
		dictionary.Add(key185, new Class31.Struct12(struct0_185, delegate0_185));
		int key186 = class41_1.struct0_14.method_0();
		Struct0 struct0_186 = class41_1.struct0_14;
		Class31.Delegate0 delegate0_186;
		if ((delegate0_186 = Class31.Class37.delegate0_113) == null)
		{
			delegate0_186 = (Class31.Class37.delegate0_113 = new Class31.Delegate0(Class31.smethod_186));
		}
		dictionary.Add(key186, new Class31.Struct12(struct0_186, delegate0_186));
		int key187 = class41_1.struct0_37.method_0();
		Struct0 struct0_187 = class41_1.struct0_37;
		Class31.Delegate0 delegate0_187;
		if ((delegate0_187 = Class31.Class37.delegate0_0) == null)
		{
			delegate0_187 = (Class31.Class37.delegate0_0 = new Class31.Delegate0(Class31.smethod_167));
		}
		dictionary.Add(key187, new Class31.Struct12(struct0_187, delegate0_187));
		int key188 = class41_1.struct0_60.method_0();
		Struct0 struct0_188 = class41_1.struct0_60;
		Class31.Delegate0 delegate0_188;
		if ((delegate0_188 = Class31.Class37.delegate0_149) == null)
		{
			delegate0_188 = (Class31.Class37.delegate0_149 = new Class31.Delegate0(Class31.smethod_57));
		}
		dictionary.Add(key188, new Class31.Struct12(struct0_188, delegate0_188));
		int key189 = class41_1.struct0_147.method_0();
		Struct0 struct0_189 = class41_1.struct0_147;
		Class31.Delegate0 delegate0_189;
		if ((delegate0_189 = Class31.Class37.delegate0_131) == null)
		{
			delegate0_189 = (Class31.Class37.delegate0_131 = new Class31.Delegate0(Class31.smethod_72));
		}
		dictionary.Add(key189, new Class31.Struct12(struct0_189, delegate0_189));
		int key190 = class41_1.struct0_206.method_0();
		Struct0 struct0_190 = class41_1.struct0_206;
		Class31.Delegate0 delegate0_190;
		if ((delegate0_190 = Class31.Class37.delegate0_126) == null)
		{
			delegate0_190 = (Class31.Class37.delegate0_126 = new Class31.Delegate0(Class31.smethod_41));
		}
		dictionary.Add(key190, new Class31.Struct12(struct0_190, delegate0_190));
		int key191 = class41_1.struct0_98.method_0();
		Struct0 struct0_191 = class41_1.struct0_98;
		Class31.Delegate0 delegate0_191;
		if ((delegate0_191 = Class31.Class37.delegate0_16) == null)
		{
			delegate0_191 = (Class31.Class37.delegate0_16 = new Class31.Delegate0(Class31.smethod_1));
		}
		dictionary.Add(key191, new Class31.Struct12(struct0_191, delegate0_191));
		int key192 = class41_1.struct0_17.method_0();
		Struct0 struct0_192 = class41_1.struct0_17;
		Class31.Delegate0 delegate0_192;
		if ((delegate0_192 = Class31.Class37.delegate0_3) == null)
		{
			delegate0_192 = (Class31.Class37.delegate0_3 = new Class31.Delegate0(Class31.smethod_51));
		}
		dictionary.Add(key192, new Class31.Struct12(struct0_192, delegate0_192));
		int key193 = class41_1.struct0_42.method_0();
		Struct0 struct0_193 = class41_1.struct0_42;
		Class31.Delegate0 delegate0_193;
		if ((delegate0_193 = Class31.Class37.delegate0_30) == null)
		{
			delegate0_193 = (Class31.Class37.delegate0_30 = new Class31.Delegate0(Class31.smethod_235));
		}
		dictionary.Add(key193, new Class31.Struct12(struct0_193, delegate0_193));
		int key194 = class41_1.struct0_12.method_0();
		Struct0 struct0_194 = class41_1.struct0_12;
		Class31.Delegate0 delegate0_194;
		if ((delegate0_194 = Class31.Class37.delegate0_156) == null)
		{
			delegate0_194 = (Class31.Class37.delegate0_156 = new Class31.Delegate0(Class31.smethod_203));
		}
		dictionary.Add(key194, new Class31.Struct12(struct0_194, delegate0_194));
		int key195 = class41_1.struct0_198.method_0();
		Struct0 struct0_195 = class41_1.struct0_198;
		Class31.Delegate0 delegate0_195;
		if ((delegate0_195 = Class31.Class37.delegate0_73) == null)
		{
			delegate0_195 = (Class31.Class37.delegate0_73 = new Class31.Delegate0(Class31.smethod_109));
		}
		dictionary.Add(key195, new Class31.Struct12(struct0_195, delegate0_195));
		int key196 = class41_1.struct0_67.method_0();
		Struct0 struct0_196 = class41_1.struct0_67;
		Class31.Delegate0 delegate0_196;
		if ((delegate0_196 = Class31.Class37.delegate0_141) == null)
		{
			delegate0_196 = (Class31.Class37.delegate0_141 = new Class31.Delegate0(Class31.smethod_196));
		}
		dictionary.Add(key196, new Class31.Struct12(struct0_196, delegate0_196));
		int key197 = class41_1.struct0_152.method_0();
		Struct0 struct0_197 = class41_1.struct0_152;
		Class31.Delegate0 delegate0_197;
		if ((delegate0_197 = Class31.Class37.delegate0_142) == null)
		{
			delegate0_197 = (Class31.Class37.delegate0_142 = new Class31.Delegate0(Class31.smethod_231));
		}
		dictionary.Add(key197, new Class31.Struct12(struct0_197, delegate0_197));
		int key198 = class41_1.struct0_11.method_0();
		Struct0 struct0_198 = class41_1.struct0_11;
		Class31.Delegate0 delegate0_198;
		if ((delegate0_198 = Class31.Class37.delegate0_101) == null)
		{
			delegate0_198 = (Class31.Class37.delegate0_101 = new Class31.Delegate0(Class31.smethod_26));
		}
		dictionary.Add(key198, new Class31.Struct12(struct0_198, delegate0_198));
		int key199 = class41_1.struct0_0.method_0();
		Struct0 struct0_199 = class41_1.struct0_0;
		Class31.Delegate0 delegate0_199;
		if ((delegate0_199 = Class31.Class37.delegate0_136) == null)
		{
			delegate0_199 = (Class31.Class37.delegate0_136 = new Class31.Delegate0(Class31.smethod_61));
		}
		dictionary.Add(key199, new Class31.Struct12(struct0_199, delegate0_199));
		int key200 = class41_1.struct0_100.method_0();
		Struct0 struct0_200 = class41_1.struct0_100;
		Class31.Delegate0 delegate0_200;
		if ((delegate0_200 = Class31.Class37.delegate0_91) == null)
		{
			delegate0_200 = (Class31.Class37.delegate0_91 = new Class31.Delegate0(Class31.smethod_214));
		}
		dictionary.Add(key200, new Class31.Struct12(struct0_200, delegate0_200));
		int key201 = class41_1.struct0_39.method_0();
		Struct0 struct0_201 = class41_1.struct0_39;
		Class31.Delegate0 delegate0_201;
		if ((delegate0_201 = Class31.Class37.delegate0_41) == null)
		{
			delegate0_201 = (Class31.Class37.delegate0_41 = new Class31.Delegate0(Class31.smethod_191));
		}
		dictionary.Add(key201, new Class31.Struct12(struct0_201, delegate0_201));
		int key202 = class41_1.struct0_34.method_0();
		Struct0 struct0_202 = class41_1.struct0_34;
		Class31.Delegate0 delegate0_202;
		if ((delegate0_202 = Class31.Class37.delegate0_153) == null)
		{
			delegate0_202 = (Class31.Class37.delegate0_153 = new Class31.Delegate0(Class31.smethod_201));
		}
		dictionary.Add(key202, new Class31.Struct12(struct0_202, delegate0_202));
		int key203 = class41_1.struct0_172.method_0();
		Struct0 struct0_203 = class41_1.struct0_172;
		Class31.Delegate0 delegate0_203;
		if ((delegate0_203 = Class31.Class37.delegate0_35) == null)
		{
			delegate0_203 = (Class31.Class37.delegate0_35 = new Class31.Delegate0(Class31.smethod_141));
		}
		dictionary.Add(key203, new Class31.Struct12(struct0_203, delegate0_203));
		int key204 = class41_1.struct0_203.method_0();
		Struct0 struct0_204 = class41_1.struct0_203;
		Class31.Delegate0 delegate0_204;
		if ((delegate0_204 = Class31.Class37.delegate0_106) == null)
		{
			delegate0_204 = (Class31.Class37.delegate0_106 = new Class31.Delegate0(Class31.smethod_211));
		}
		dictionary.Add(key204, new Class31.Struct12(struct0_204, delegate0_204));
		int key205 = class41_1.struct0_85.method_0();
		Struct0 struct0_205 = class41_1.struct0_85;
		Class31.Delegate0 delegate0_205;
		if ((delegate0_205 = Class31.Class37.delegate0_2) == null)
		{
			delegate0_205 = (Class31.Class37.delegate0_2 = new Class31.Delegate0(Class31.smethod_115));
		}
		dictionary.Add(key205, new Class31.Struct12(struct0_205, delegate0_205));
		return dictionary;
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00031F8C File Offset: 0x0003018C
	private void method_96()
	{
		Class58 class58_ = this.method_102();
		Class79 class79_ = (Class79)this.method_102();
		this.method_27(class79_, class58_);
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00031FB4 File Offset: 0x000301B4
	private MethodBase method_97(Class17 class17_0)
	{
		Type type = this.method_70(class17_0.method_4().method_2(), false);
		BindingFlags bindingAttr = Class31.smethod_223(class17_0.method_2());
		Type[] array = null;
		Class103[] array2 = class17_0.method_10();
		if (array2 != null)
		{
			array = new Type[array2.Length];
			for (int i = 0; i < array.Length; i++)
			{
				Class103 @class = array2[i];
				if (@class != null)
				{
					array[i] = this.method_70(@class.method_2(), true);
				}
			}
		}
		MemberInfo[] member = type.GetMember(class17_0.method_6(), MemberTypes.Method, bindingAttr);
		MethodInfo methodInfo = null;
		int num = -1;
		foreach (MethodInfo methodInfo2 in member)
		{
			int num2;
			if (this.method_32(methodInfo2, class17_0, array, out num2) && num2 > num)
			{
				methodInfo = methodInfo2;
				num = num2;
			}
		}
		if (methodInfo == null)
		{
			throw new Exception(string.Format("Cannot bind method: {0}.{1}", type.Name, class17_0.method_6()));
		}
		return methodInfo.MakeGenericMethod(array);
	}

	// Token: 0x06000335 RID: 821 RVA: 0x000320AC File Offset: 0x000302AC
	private static void smethod_238(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		uint num2;
		if (num != 1)
		{
			if (num != 13)
			{
				if (num != 19)
				{
					throw new InvalidOperationException();
				}
				num2 = (uint)Convert.ToInt64(@class.vmethod_0());
			}
			else
			{
				num2 = (uint)((Class69)@class).method_3();
			}
		}
		else
		{
			num2 = (uint)((Class64)@class).method_3();
		}
		Class64[] array = (Class64[])((Class78)class58_4).method_3();
		if ((ulong)num2 >= (ulong)((long)array.Length))
		{
			return;
		}
		uint uint_ = (uint)array[(int)num2].method_3();
		class31_0.method_31(uint_);
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00032138 File Offset: 0x00030338
	private static void smethod_239(Class31 class31_0, Class58 class58_4)
	{
		Class58 class58_5 = class31_0.method_102();
		if (Class31.smethod_119(class31_0.method_102(), class58_5))
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x06000337 RID: 823 RVA: 0x000049F3 File Offset: 0x00002BF3
	private static void smethod_240(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(double));
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00032170 File Offset: 0x00030370
	private static void smethod_241(Class31 class31_0, Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		FieldInfo fieldInfo = class31_0.method_25(int_);
		Class58 @class = Class58.smethod_0(class31_0.method_102().vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(null, @class.vmethod_0());
	}

	// Token: 0x06000339 RID: 825 RVA: 0x000321B8 File Offset: 0x000303B8
	private Class58 method_98(Class58 class58_4, Class58 class58_5)
	{
		if (class58_4.method_0() == 1)
		{
			if (class58_5.method_0() == 1)
			{
				int num = ((Class64)class58_4).method_3();
				int num2 = ((Class64)class58_5).method_3();
				return new Class64(num ^ num2);
			}
			if (class58_5.method_0() == 19)
			{
				int num3 = ((Class64)class58_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
				if (!(underlyingType == typeof(long)) && !(underlyingType == typeof(ulong)))
				{
					int num4 = Convert.ToInt32(class58_5.vmethod_0());
					return new Class64(num3 ^ num4);
				}
				long num5 = Convert.ToInt64(class58_5.vmethod_0());
				return new Class69((long)num3 ^ num5);
			}
		}
		if (class58_4.method_0() == 13)
		{
			if (class58_5.method_0() == 13)
			{
				long num6 = ((Class69)class58_4).method_3();
				long num7 = ((Class69)class58_5).method_3();
				return new Class69(num6 ^ num7);
			}
			if (class58_5.method_0() == 19)
			{
				long num8 = (long)((Class64)class58_4).method_3();
				long num9 = Convert.ToInt64(class58_5.vmethod_0());
				return new Class69(num8 ^ num9);
			}
		}
		if (class58_4.method_0() == 19)
		{
			if (class58_5.method_0() == 1)
			{
				int num10 = ((Class64)class58_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
				if (!(underlyingType2 == typeof(long)) && !(underlyingType2 == typeof(ulong)))
				{
					return new Class64(Convert.ToInt32(class58_4.vmethod_0()) ^ num10);
				}
				return new Class69(Convert.ToInt64(class58_5.vmethod_0()) ^ (long)num10);
			}
			else
			{
				if (class58_5.method_0() == 13)
				{
					long num11 = Convert.ToInt64(class58_4.vmethod_0());
					long num12 = ((Class69)class58_5).method_3();
					return new Class69(num11 ^ num12);
				}
				if (class58_5.method_0() == 19)
				{
					Type underlyingType3 = Enum.GetUnderlyingType(class58_4.vmethod_0().GetType());
					Type underlyingType4 = Enum.GetUnderlyingType(class58_5.vmethod_0().GetType());
					if (!(underlyingType3 == typeof(long)) && !(underlyingType3 == typeof(ulong)) && !(underlyingType4 == typeof(long)) && !(underlyingType4 == typeof(ulong)))
					{
						int num13 = Convert.ToInt32(class58_4.vmethod_0());
						int num14 = Convert.ToInt32(class58_5.vmethod_0());
						return new Class64(num13 ^ num14);
					}
					long num15 = Convert.ToInt64(class58_4.vmethod_0());
					long num16 = Convert.ToInt64(class58_5.vmethod_0());
					return new Class69(num15 ^ num16);
				}
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00004A05 File Offset: 0x00002C05
	private static void smethod_242(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_54(5);
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00032444 File Offset: 0x00030644
	private void method_99(Class58 class58_4)
	{
		int int_ = ((Class64)class58_4).method_3();
		MethodBase methodBase = this.method_58(int_);
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		int num = parameters.Length;
		object[] array = new object[num];
		Dictionary<int, Class79> dictionary = new Dictionary<int, Class79>();
		for (int i = num - 1; i >= 0; i--)
		{
			Class58 @class = this.method_102();
			Class79 class2 = @class as Class79;
			if (class2 != null)
			{
				dictionary.Add(i, class2);
				@class = this.method_72(class2);
			}
			if (@class.method_1() != null)
			{
				@class = Class58.smethod_0(null, @class.method_1()).vmethod_2(@class);
			}
			Class58 class3 = Class58.smethod_0(null, parameters[i].ParameterType).vmethod_2(@class);
			array[i] = class3.vmethod_0();
		}
		object obj;
		try
		{
			obj = Class31.smethod_81(methodBase, null, array, false);
		}
		catch (TargetInvocationException ex)
		{
			Exception object_ = ex.InnerException ?? ex;
			this.method_101(object_);
			return;
		}
		foreach (KeyValuePair<int, Class79> keyValuePair in dictionary)
		{
			this.method_27(keyValuePair.Value, Class58.smethod_0(array[keyValuePair.Key], null));
		}
		this.method_74(Class58.smethod_0(obj, declaringType));
	}

	// Token: 0x0600033C RID: 828 RVA: 0x000325A0 File Offset: 0x000307A0
	private static Class58 smethod_243(Class58 class58_4, Class58 class58_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class69)class58_4).method_3();
			long num2 = ((Class69)class58_5).method_3();
			long long_;
			if (bool_2)
			{
				long_ = checked(num - num2);
			}
			else
			{
				long_ = num - num2;
			}
			return new Class69(long_);
		}
		ulong num3 = (ulong)((Class69)class58_4).method_3();
		ulong num4 = (ulong)((Class69)class58_5).method_3();
		ulong long_2;
		if (bool_2)
		{
			long_2 = checked(num3 - num4);
		}
		else
		{
			long_2 = num3 - num4;
		}
		return new Class69((long)long_2);
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00032610 File Offset: 0x00030810
	private static void smethod_244(Class31 class31_0, Class58 class58_4)
	{
		object object_ = class31_0.method_102().vmethod_0();
		long num = class31_0.method_22();
		Array array = (Array)class31_0.method_102().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		checked
		{
			if (elementType == typeof(sbyte))
			{
				Class58 @class = Class58.smethod_0(object_, typeof(sbyte));
				((sbyte[])array)[(int)((IntPtr)num)] = (sbyte)@class.vmethod_0();
				return;
			}
			if (elementType == typeof(byte))
			{
				Class58 class2 = Class58.smethod_0(object_, typeof(byte));
				((byte[])array)[(int)((IntPtr)num)] = (byte)class2.vmethod_0();
				return;
			}
			if (elementType == typeof(bool))
			{
				Class58 class3 = Class58.smethod_0(object_, typeof(bool));
				((bool[])array)[(int)((IntPtr)num)] = (bool)class3.vmethod_0();
				return;
			}
			if (elementType.IsEnum)
			{
				class31_0.method_9(elementType, object_, num, array);
				return;
			}
			class31_0.method_9(typeof(sbyte), object_, num, array);
		}
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00004A0E File Offset: 0x00002C0E
	private void method_100(Class31.Class33 class33_0)
	{
		this.class8_0 = class33_0.class8_0;
		this.long_0 = class33_0.long_0;
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00032724 File Offset: 0x00030924
	private static void smethod_245(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_43();
		class31_0.method_74(@class.vmethod_3());
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00004A28 File Offset: 0x00002C28
	private static void smethod_246(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_49(typeof(float));
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00032744 File Offset: 0x00030944
	private void method_101(object object_3)
	{
		Exception ex = object_3 as Exception;
		if (ex != null)
		{
			Class31.smethod_213(ex);
		}
		Class31.smethod_40(object_3);
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00032768 File Offset: 0x00030968
	private static void smethod_247(Class31 class31_0, Class58 class58_4)
	{
		Class58 @class = class31_0.method_102();
		int num = @class.method_0();
		bool flag;
		if (num <= 7)
		{
			if (num == 0)
			{
				flag = (((Class75)@class).method_3() == IntPtr.Zero);
				goto IL_BE;
			}
			if (num == 1)
			{
				flag = (((Class64)@class).method_3() == 0);
				goto IL_BE;
			}
			if (num == 7)
			{
				flag = (((Class61)@class).method_3() == null);
				goto IL_BE;
			}
		}
		else
		{
			if (num == 13)
			{
				flag = (((Class69)@class).method_3() == 0L);
				goto IL_BE;
			}
			if (num == 19)
			{
				flag = !Convert.ToBoolean(((Class73)@class).method_3());
				goto IL_BE;
			}
			if (num == 20)
			{
				flag = (((Class60)@class).method_3() == UIntPtr.Zero);
				goto IL_BE;
			}
		}
		flag = (@class.vmethod_0() == null);
		IL_BE:
		if (flag)
		{
			uint uint_ = ((Class65)class58_4).method_3();
			class31_0.method_31(uint_);
		}
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00004A3A File Offset: 0x00002C3A
	private static void smethod_248(Class31 class31_0, Class58 class58_4)
	{
		class31_0.method_7(true);
	}

	// Token: 0x06000344 RID: 836 RVA: 0x0003284C File Offset: 0x00030A4C
	private Class58 method_102()
	{
		Class58 @class = this.class58_2;
		if (@class != null)
		{
			this.class58_2 = this.class58_1;
			this.class58_1 = null;
			return @class;
		}
		return this.stack_1.Pop();
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00032884 File Offset: 0x00030A84
	private void method_103(int int_0, Type[] type_10, Type[] type_11, bool bool_2)
	{
		this.class8_1.method_0().vmethod_9((long)int_0, 0);
		this.method_28(this.class8_1);
		Class50 @class = this.method_73(this.class8_1);
		this.method_67(@class);
		int num = @class.method_2().Length;
		object[] array = new object[num];
		Class58[] array2 = new Class58[num];
		if (this.type_1 != null && bool_2)
		{
			int num2 = (!@class.method_12()) ? 1 : 0;
			Type[] array3 = new Type[num - num2];
			for (int i = num - 1; i >= num2; i--)
			{
				array3[i] = this.method_70(@class.method_2()[i].method_0(), true);
			}
			MethodInfo method = this.type_1.GetMethod(@class.method_4(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array3, null);
			this.type_1 = null;
			if (method != null)
			{
				this.method_5(method, true);
				return;
			}
		}
		for (int j = num - 1; j >= 0; j--)
		{
			Class58 class2 = this.method_102();
			array2[j] = class2;
			Class79 class3 = class2 as Class79;
			if (class3 != null)
			{
				class2 = this.method_72(class3);
			}
			if (class2.method_1() != null)
			{
				class2 = Class58.smethod_0(null, class2.method_1()).vmethod_2(class2);
			}
			Class58 class4 = Class58.smethod_0(null, this.method_70(@class.method_2()[j].method_0(), true)).vmethod_2(class2);
			array[j] = class4.vmethod_0();
			if (j == 0 && bool_2 && !@class.method_12() && array[j] == null)
			{
				throw new NullReferenceException();
			}
		}
		Class31 class5 = new Class31(this.class41_0);
		object[] object_ = new object[]
		{
			this.module_0.Assembly
		};
		object obj;
		try
		{
			obj = class5.method_76(this.stream_0, int_0, array, type_10, type_11, object_);
		}
		finally
		{
			bool flag = !@class.method_12();
			for (int k = 0; k < num; k++)
			{
				int num3;
				if (flag)
				{
					num3 = k + 1;
					if (num3 == num)
					{
						num3 = 0;
					}
				}
				else
				{
					num3 = k;
				}
				Class79 class6 = array2[num3] as Class79;
				if (class6 != null)
				{
					this.method_27(class6, Class58.smethod_0(array[num3], null));
				}
			}
		}
		Type left = class5.method_70(class5.class50_0.method_8(), true);
		if (left != Class31.type_8)
		{
			this.method_74(Class58.smethod_0(obj, left));
		}
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00004A43 File Offset: 0x00002C43
	private void method_104(int int_0)
	{
		this.method_74(this.class58_3[int_0].vmethod_3());
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00004A5C File Offset: 0x00002C5C
	public object method_105(Stream stream_1, string string_0, object[] object_3)
	{
		return this.method_62(stream_1, string_0, object_3, null, null, null);
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00032AFC File Offset: 0x00030CFC
	private void method_106(bool bool_2)
	{
		Class58 class58_ = this.method_102();
		Class58 class58_2 = this.method_102();
		this.method_74(Class31.smethod_121(class58_2, class58_, bool_2));
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00032B28 File Offset: 0x00030D28
	private static object smethod_249(MethodBase methodBase_0, object object_3, object[] object_4)
	{
		if (methodBase_0.IsConstructor)
		{
			object result;
			try
			{
				result = Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, object_4, null);
			}
			catch (AmbiguousMatchException)
			{
				result = ((ConstructorInfo)methodBase_0).Invoke(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, object_4, null);
			}
			return result;
		}
		return methodBase_0.Invoke(object_3, object_4);
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00032B80 File Offset: 0x00030D80
	private static Class47 smethod_250(Class8 class8_2)
	{
		Class47 @class = new Class47();
		@class.method_3((int)class8_2.method_6());
		@class.method_1(class8_2.method_19());
		@class.method_5(class8_2.method_20());
		@class.method_7(class8_2.method_20());
		@class.method_9(class8_2.method_20());
		@class.method_11(class8_2.method_20());
		return @class;
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00032BDC File Offset: 0x00030DDC
	private void method_107(bool bool_2)
	{
		Class58 @class = this.method_102();
		int num = @class.method_0();
		short int_;
		if (num <= 1)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					if (bool_2)
					{
						int_ = checked((short)((Class64)@class).method_3());
						goto IL_130;
					}
					int_ = (short)((Class64)@class).method_3();
					goto IL_130;
				}
			}
			else if (IntPtr.Size == 4)
			{
				if (bool_2)
				{
					int_ = checked((short)((int)((Class75)@class).method_3()));
					goto IL_130;
				}
				int_ = (short)((int)((Class75)@class).method_3());
				goto IL_130;
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((short)((long)((Class75)@class).method_3()));
					goto IL_130;
				}
				int_ = (short)((long)((Class75)@class).method_3());
				goto IL_130;
			}
		}
		else if (num != 8)
		{
			if (num != 13)
			{
				if (num == 19)
				{
					if (bool_2)
					{
						int_ = checked((short)Convert.ToUInt64(((Class73)@class).method_3()));
						goto IL_130;
					}
					int_ = (short)Convert.ToUInt64(((Class73)@class).method_3());
					goto IL_130;
				}
			}
			else
			{
				if (bool_2)
				{
					int_ = checked((short)((Class69)@class).method_3());
					goto IL_130;
				}
				int_ = (short)((Class69)@class).method_3();
				goto IL_130;
			}
		}
		else
		{
			if (bool_2)
			{
				int_ = checked((short)((Class70)@class).method_3());
				goto IL_130;
			}
			int_ = (short)((Class70)@class).method_3();
			goto IL_130;
		}
		throw new InvalidOperationException();
		IL_130:
		Class64 class2 = new Class64();
		class2.method_4((int)int_);
		this.method_74(class2);
	}

	// Token: 0x040000A6 RID: 166
	private static Type type_0;

	// Token: 0x040000A7 RID: 167
	private Class47[] class47_0;

	// Token: 0x040000A8 RID: 168
	private Class50 class50_0;

	// Token: 0x040000A9 RID: 169
	private static Dictionary<int, Class31.Struct12> dictionary_0;

	// Token: 0x040000AA RID: 170
	private static object object_0 = new object();

	// Token: 0x040000AB RID: 171
	private readonly Module module_0;

	// Token: 0x040000AC RID: 172
	private readonly Class41 class41_0;

	// Token: 0x040000AD RID: 173
	private object object_1;

	// Token: 0x040000AE RID: 174
	private Type type_1;

	// Token: 0x040000AF RID: 175
	private Stack<Class31.Class33> stack_0;

	// Token: 0x040000B0 RID: 176
	private Stream stream_0;

	// Token: 0x040000B1 RID: 177
	private bool bool_0;

	// Token: 0x040000B2 RID: 178
	private Class8 class8_0;

	// Token: 0x040000B3 RID: 179
	private uint? nullable_0;

	// Token: 0x040000B4 RID: 180
	private uint uint_0;

	// Token: 0x040000B5 RID: 181
	private static Type type_2;

	// Token: 0x040000B6 RID: 182
	private static readonly Dictionary<Class31.Struct10, Class31.Delegate21> dictionary_1 = new Dictionary<Class31.Struct10, Class31.Delegate21>(256);

	// Token: 0x040000B7 RID: 183
	private static Type type_3;

	// Token: 0x040000B8 RID: 184
	private static Type type_4;

	// Token: 0x040000B9 RID: 185
	private static Type type_5;

	// Token: 0x040000BA RID: 186
	private uint uint_1;

	// Token: 0x040000BB RID: 187
	private Type[] type_6;

	// Token: 0x040000BC RID: 188
	private Class58[] class58_0;

	// Token: 0x040000BD RID: 189
	private Type[] type_7;

	// Token: 0x040000BE RID: 190
	private static Type type_8;

	// Token: 0x040000BF RID: 191
	private readonly Stack<Class58> stack_1;

	// Token: 0x040000C0 RID: 192
	private Class58 class58_1;

	// Token: 0x040000C1 RID: 193
	private readonly Stack<Class31.Struct13> stack_2 = new Stack<Class31.Struct13>();

	// Token: 0x040000C2 RID: 194
	private static readonly Dictionary<MethodBase, int> dictionary_2 = new Dictionary<MethodBase, int>(256);

	// Token: 0x040000C3 RID: 195
	private static Type type_9;

	// Token: 0x040000C4 RID: 196
	private long long_0;

	// Token: 0x040000C5 RID: 197
	private uint uint_2;

	// Token: 0x040000C6 RID: 198
	private static readonly Dictionary<int, object> dictionary_3;

	// Token: 0x040000C7 RID: 199
	private byte[] byte_0;

	// Token: 0x040000C8 RID: 200
	private static readonly Dictionary<MethodBase, object> dictionary_4 = new Dictionary<MethodBase, object>();

	// Token: 0x040000C9 RID: 201
	private Class58 class58_2;

	// Token: 0x040000CA RID: 202
	private bool bool_1;

	// Token: 0x040000CB RID: 203
	private Class8 class8_1;

	// Token: 0x040000CC RID: 204
	private Class58[] class58_3;

	// Token: 0x040000CD RID: 205
	private object[] object_2;

	// Token: 0x0200004B RID: 75
	// (Invoke) Token: 0x0600034D RID: 845
	private delegate void Delegate0(Class31 class31_0, Class58 class58_0);

	// Token: 0x0200004C RID: 76
	[Serializable]
	private sealed class Class32
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00032D2C File Offset: 0x00030F2C
		internal int method_0(Class47 class47_0, Class47 class47_1)
		{
			if (class47_0.method_6() == class47_1.method_6())
			{
				return class47_1.method_8().CompareTo(class47_0.method_8());
			}
			return class47_0.method_6().CompareTo(class47_1.method_6());
		}

		// Token: 0x040000CE RID: 206
		public static readonly Class31.Class32 class32_0 = new Class31.Class32();

		// Token: 0x040000CF RID: 207
		public static Comparison<Class47> comparison_0;
	}

	// Token: 0x0200004D RID: 77
	private struct Struct10 : IEquatable<Class31.Struct10>
	{
		// Token: 0x06000353 RID: 851 RVA: 0x00004A76 File Offset: 0x00002C76
		public Struct10(MethodBase methodBase_1, bool bool_1)
		{
			this.methodBase_0 = methodBase_1;
			this.bool_0 = bool_1;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00004A86 File Offset: 0x00002C86
		[Attribute2]
		public MethodBase method_0()
		{
			return this.methodBase_0;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00004A8E File Offset: 0x00002C8E
		[Attribute2]
		public bool method_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00032D70 File Offset: 0x00030F70
		public override int GetHashCode()
		{
			return this.method_0().GetHashCode() ^ this.method_1().GetHashCode();
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00032D98 File Offset: 0x00030F98
		public override bool Equals(object obj)
		{
			if (obj is Class31.Struct10)
			{
				Class31.Struct10 other = (Class31.Struct10)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00004A96 File Offset: 0x00002C96
		public bool Equals(Class31.Struct10 other)
		{
			return this.method_0() == other.method_0() && this.method_1() == other.method_1();
		}

		// Token: 0x040000D0 RID: 208
		private readonly MethodBase methodBase_0;

		// Token: 0x040000D1 RID: 209
		private readonly bool bool_0;
	}

	// Token: 0x0200004E RID: 78
	private struct Struct11
	{
		// Token: 0x040000D2 RID: 210
		public bool bool_0;
	}

	// Token: 0x0200004F RID: 79
	private sealed class Class33 : IDisposable
	{
		// Token: 0x0600035A RID: 858 RVA: 0x00032DC0 File Offset: 0x00030FC0
		public void Dispose()
		{
			IDisposable disposable = this.class8_0;
			if (disposable != null)
			{
				disposable.Dispose();
			}
			if (this.class97_0 != null)
			{
				this.class97_0.Dispose();
				this.class97_0 = null;
			}
		}

		// Token: 0x040000D3 RID: 211
		public Class129 class129_0;

		// Token: 0x040000D4 RID: 212
		public Class8 class8_0;

		// Token: 0x040000D5 RID: 213
		public Class97 class97_0;

		// Token: 0x040000D6 RID: 214
		public long long_0;
	}

	// Token: 0x02000050 RID: 80
	private static class Class34
	{
		// Token: 0x0600035B RID: 859 RVA: 0x00032DFC File Offset: 0x00030FFC
		static Class34()
		{
			try
			{
				Class31.Class34.bool_0 = Class31.Class34.smethod_0();
			}
			catch
			{
				Class31.Class34.bool_0 = false;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00032E30 File Offset: 0x00031030
		private static bool smethod_0()
		{
			if (typeof(DynamicMethod).IsAbstract)
			{
				return false;
			}
			bool result;
			try
			{
				new DynamicMethod(string.Empty, typeof(void), Type.EmptyTypes);
				return true;
			}
			catch (PlatformNotSupportedException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x040000D7 RID: 215
		public static readonly bool bool_0;
	}

	// Token: 0x02000051 RID: 81
	private static class Class35
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00032E88 File Offset: 0x00031088
		public static object smethod_0(object object_0, MethodBase methodBase_0, out MethodInfo methodInfo_0)
		{
			KeyValuePair<Type, MethodInfo> keyValuePair = Class31.Class35.smethod_1(methodBase_0);
			object result = (Delegate)Activator.CreateInstance(keyValuePair.Key, new object[]
			{
				object_0,
				methodBase_0.MethodHandle.GetFunctionPointer()
			});
			methodInfo_0 = keyValuePair.Value;
			return result;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00032ED8 File Offset: 0x000310D8
		private static KeyValuePair<Type, MethodInfo> smethod_1(MethodBase methodBase_0)
		{
			Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>> obj = Class31.Class35.dictionary_0;
			KeyValuePair<Type, MethodInfo> result;
			lock (obj)
			{
				KeyValuePair<Type, MethodInfo> keyValuePair;
				if (Class31.Class35.dictionary_0.TryGetValue(methodBase_0, out keyValuePair))
				{
					result = keyValuePair;
				}
				else
				{
					MethodInfo methodInfo = methodBase_0 as MethodInfo;
					Type type;
					if (methodInfo != null)
					{
						if ((type = methodInfo.ReturnType) != null)
						{
							goto IL_46;
						}
					}
					type = Class31.type_8;
					IL_46:
					Type type2 = type;
					bool flag2 = type2 != Class31.type_8;
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					if (parameters.Length > 9)
					{
						throw new Exception(string.Format("Cannot create delegate for a method. Unsupported number of parameters: {0}.", parameters.Length));
					}
					Type[] array = new Type[parameters.Length + ((flag2 > false) ? 1 : 0)];
					for (int i = 0; i < parameters.Length; i++)
					{
						Type parameterType = parameters[i].ParameterType;
						if (parameterType.IsByRef || parameterType.IsPointer)
						{
							throw new Exception("Cannot create delegate for a method with parameters passed by reference.");
						}
						array[i] = parameterType;
					}
					if (flag2)
					{
						array[array.Length - 1] = type2;
					}
					Type type3 = flag2 ? Class31.Class35.smethod_2(array) : Class31.Class35.smethod_3(array);
					MethodInfo method = type3.GetMethod("Invoke");
					keyValuePair = new KeyValuePair<Type, MethodInfo>(type3, method);
					Class31.Class35.dictionary_0.Add(methodBase_0, keyValuePair);
					result = keyValuePair;
				}
			}
			return result;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00033030 File Offset: 0x00031230
		private static Type smethod_2(Type[] type_0)
		{
			switch (type_0.Length)
			{
			case 1:
				return typeof(Class31.Class35.Delegate17<>).MakeGenericType(type_0);
			case 2:
				return typeof(Class31.Class35.Delegate18<, >).MakeGenericType(type_0);
			case 3:
				return typeof(Class31.Class35.Delegate6<, , >).MakeGenericType(type_0);
			case 4:
				return typeof(Class31.Class35.Delegate11<, , , >).MakeGenericType(type_0);
			case 5:
				return typeof(Class31.Class35.Delegate3<, , , , >).MakeGenericType(type_0);
			case 6:
				return typeof(Class31.Class35.Delegate10<, , , , , >).MakeGenericType(type_0);
			case 7:
				return typeof(Class31.Class35.Delegate19<, , , , , , >).MakeGenericType(type_0);
			case 8:
				return typeof(Class31.Class35.Delegate16<, , , , , , , >).MakeGenericType(type_0);
			case 9:
				return typeof(Class31.Class35.Delegate20<, , , , , , , , >).MakeGenericType(type_0);
			case 10:
				return typeof(Class31.Class35.Delegate4<, , , , , , , , , >).MakeGenericType(type_0);
			default:
				return null;
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0003311C File Offset: 0x0003131C
		private static Type smethod_3(Type[] type_0)
		{
			switch (type_0.Length)
			{
			case 0:
				return typeof(Class31.Class35.Delegate12);
			case 1:
				return typeof(Class31.Class35.Delegate2<>).MakeGenericType(type_0);
			case 2:
				return typeof(Class31.Class35.Delegate5<, >).MakeGenericType(type_0);
			case 3:
				return typeof(Class31.Class35.Delegate7<, , >).MakeGenericType(type_0);
			case 4:
				return typeof(Class31.Class35.Delegate14<, , , >).MakeGenericType(type_0);
			case 5:
				return typeof(Class31.Class35.Delegate13<, , , , >).MakeGenericType(type_0);
			case 6:
				return typeof(Class31.Class35.Delegate15<, , , , , >).MakeGenericType(type_0);
			case 7:
				return typeof(Class31.Class35.Delegate1<, , , , , , >).MakeGenericType(type_0);
			case 8:
				return typeof(Class31.Class35.Delegate9<, , , , , , , >).MakeGenericType(type_0);
			case 9:
				return typeof(Class31.Class35.Delegate8<, , , , , , , , >).MakeGenericType(type_0);
			default:
				return null;
			}
		}

		// Token: 0x040000D8 RID: 216
		private static readonly Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>> dictionary_0 = new Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>>();

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000363 RID: 867
		private delegate void Delegate1<in T, in U, in V, in W, in X, in Y, in Z>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000367 RID: 871
		private delegate void Delegate2<in T>(T gparam_0);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600036B RID: 875
		private delegate X Delegate3<in T, in U, in V, in W, out X>(T gparam_0, U gparam_1, V gparam_2, W gparam_3);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x0600036F RID: 879
		private delegate T9 Delegate4<in T, in U, in V, in W, in X, in Y, in Z, in T7, in T8, out T9>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7, T8 gparam_8);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000373 RID: 883
		private delegate void Delegate5<in T, in U>(T gparam_0, U gparam_1);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000377 RID: 887
		private delegate V Delegate6<in T, in U, out V>(T gparam_0, U gparam_1);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600037B RID: 891
		private delegate void Delegate7<in T, in U, in V>(T gparam_0, U gparam_1, V gparam_2);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600037F RID: 895
		private delegate void Delegate8<in T, in U, in V, in W, in X, in Y, in Z, in T7, in T8>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7, T8 gparam_8);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000383 RID: 899
		private delegate void Delegate9<in T, in U, in V, in W, in X, in Y, in Z, in T7>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000387 RID: 903
		private delegate Y Delegate10<in T, in U, in V, in W, in X, out Y>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x0600038B RID: 907
		private delegate W Delegate11<in T, in U, in V, out W>(T gparam_0, U gparam_1, V gparam_2);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x0600038F RID: 911
		private delegate void Delegate12();

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000393 RID: 915
		private delegate void Delegate13<in T, in U, in V, in W, in X>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000397 RID: 919
		private delegate void Delegate14<in T, in U, in V, in W>(T gparam_0, U gparam_1, V gparam_2, W gparam_3);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600039B RID: 923
		private delegate void Delegate15<in T, in U, in V, in W, in X, in Y>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600039F RID: 927
		private delegate T7 Delegate16<in T, in U, in V, in W, in X, in Y, in Z, out T7>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060003A3 RID: 931
		private delegate T Delegate17<out T>();

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060003A7 RID: 935
		private delegate U Delegate18<in T, out U>(T gparam_0);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060003AB RID: 939
		private delegate Z Delegate19<in T, in U, in V, in W, in X, in Y, out Z>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060003AF RID: 943
		private delegate T8 Delegate20<in T, in U, in V, in W, in X, in Y, in Z, in T7, out T8>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7);
	}

	// Token: 0x02000066 RID: 102
	private struct Struct12
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00004AC9 File Offset: 0x00002CC9
		public Struct12(Struct0 struct0_0, Class31.Delegate0 delegate0_1)
		{
			this.byte_0 = struct0_0.method_2();
			this.delegate0_0 = delegate0_1;
		}

		// Token: 0x040000D9 RID: 217
		public readonly byte byte_0;

		// Token: 0x040000DA RID: 218
		public readonly Class31.Delegate0 delegate0_0;
	}

	// Token: 0x02000067 RID: 103
	private sealed class Class36<T> : IComparer<KeyValuePair<int, T>>
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x00004ADF File Offset: 0x00002CDF
		public Class36(Comparison<T> comparison_1)
		{
			this.comparison_0 = comparison_1;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00033200 File Offset: 0x00031400
		public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
		{
			int num = this.comparison_0(x.Value, y.Value);
			if (num == 0)
			{
				return y.Key.CompareTo(x.Key);
			}
			return num;
		}

		// Token: 0x040000DB RID: 219
		private readonly Comparison<T> comparison_0;
	}

	// Token: 0x02000068 RID: 104
	private static class Class37
	{
		// Token: 0x040000DC RID: 220
		public static Class31.Delegate0 delegate0_0;

		// Token: 0x040000DD RID: 221
		public static Class31.Delegate0 delegate0_1;

		// Token: 0x040000DE RID: 222
		public static Class31.Delegate0 delegate0_2;

		// Token: 0x040000DF RID: 223
		public static Class31.Delegate0 delegate0_3;

		// Token: 0x040000E0 RID: 224
		public static Class31.Delegate0 delegate0_4;

		// Token: 0x040000E1 RID: 225
		public static Class31.Delegate0 delegate0_5;

		// Token: 0x040000E2 RID: 226
		public static Class31.Delegate0 delegate0_6;

		// Token: 0x040000E3 RID: 227
		public static Class31.Delegate0 delegate0_7;

		// Token: 0x040000E4 RID: 228
		public static Class31.Delegate0 delegate0_8;

		// Token: 0x040000E5 RID: 229
		public static Class31.Delegate0 delegate0_9;

		// Token: 0x040000E6 RID: 230
		public static Class31.Delegate0 delegate0_10;

		// Token: 0x040000E7 RID: 231
		public static Class31.Delegate0 delegate0_11;

		// Token: 0x040000E8 RID: 232
		public static Class31.Delegate0 delegate0_12;

		// Token: 0x040000E9 RID: 233
		public static Class31.Delegate0 delegate0_13;

		// Token: 0x040000EA RID: 234
		public static Class31.Delegate0 delegate0_14;

		// Token: 0x040000EB RID: 235
		public static Class31.Delegate0 delegate0_15;

		// Token: 0x040000EC RID: 236
		public static Class31.Delegate0 delegate0_16;

		// Token: 0x040000ED RID: 237
		public static Class31.Delegate0 delegate0_17;

		// Token: 0x040000EE RID: 238
		public static Class31.Delegate0 delegate0_18;

		// Token: 0x040000EF RID: 239
		public static Class31.Delegate0 delegate0_19;

		// Token: 0x040000F0 RID: 240
		public static Class31.Delegate0 delegate0_20;

		// Token: 0x040000F1 RID: 241
		public static Class31.Delegate0 delegate0_21;

		// Token: 0x040000F2 RID: 242
		public static Class31.Delegate0 delegate0_22;

		// Token: 0x040000F3 RID: 243
		public static Class31.Delegate0 delegate0_23;

		// Token: 0x040000F4 RID: 244
		public static Class31.Delegate0 delegate0_24;

		// Token: 0x040000F5 RID: 245
		public static Class31.Delegate0 delegate0_25;

		// Token: 0x040000F6 RID: 246
		public static Class31.Delegate0 delegate0_26;

		// Token: 0x040000F7 RID: 247
		public static Class31.Delegate0 delegate0_27;

		// Token: 0x040000F8 RID: 248
		public static Class31.Delegate0 delegate0_28;

		// Token: 0x040000F9 RID: 249
		public static Class31.Delegate0 delegate0_29;

		// Token: 0x040000FA RID: 250
		public static Class31.Delegate0 delegate0_30;

		// Token: 0x040000FB RID: 251
		public static Class31.Delegate0 delegate0_31;

		// Token: 0x040000FC RID: 252
		public static Class31.Delegate0 delegate0_32;

		// Token: 0x040000FD RID: 253
		public static Class31.Delegate0 delegate0_33;

		// Token: 0x040000FE RID: 254
		public static Class31.Delegate0 delegate0_34;

		// Token: 0x040000FF RID: 255
		public static Class31.Delegate0 delegate0_35;

		// Token: 0x04000100 RID: 256
		public static Class31.Delegate0 delegate0_36;

		// Token: 0x04000101 RID: 257
		public static Class31.Delegate0 delegate0_37;

		// Token: 0x04000102 RID: 258
		public static Class31.Delegate0 delegate0_38;

		// Token: 0x04000103 RID: 259
		public static Class31.Delegate0 delegate0_39;

		// Token: 0x04000104 RID: 260
		public static Class31.Delegate0 delegate0_40;

		// Token: 0x04000105 RID: 261
		public static Class31.Delegate0 delegate0_41;

		// Token: 0x04000106 RID: 262
		public static Class31.Delegate0 delegate0_42;

		// Token: 0x04000107 RID: 263
		public static Class31.Delegate0 delegate0_43;

		// Token: 0x04000108 RID: 264
		public static Class31.Delegate0 delegate0_44;

		// Token: 0x04000109 RID: 265
		public static Class31.Delegate0 delegate0_45;

		// Token: 0x0400010A RID: 266
		public static Class31.Delegate0 delegate0_46;

		// Token: 0x0400010B RID: 267
		public static Class31.Delegate0 delegate0_47;

		// Token: 0x0400010C RID: 268
		public static Class31.Delegate0 delegate0_48;

		// Token: 0x0400010D RID: 269
		public static Class31.Delegate0 delegate0_49;

		// Token: 0x0400010E RID: 270
		public static Class31.Delegate0 delegate0_50;

		// Token: 0x0400010F RID: 271
		public static Class31.Delegate0 delegate0_51;

		// Token: 0x04000110 RID: 272
		public static Class31.Delegate0 delegate0_52;

		// Token: 0x04000111 RID: 273
		public static Class31.Delegate0 delegate0_53;

		// Token: 0x04000112 RID: 274
		public static Class31.Delegate0 delegate0_54;

		// Token: 0x04000113 RID: 275
		public static Class31.Delegate0 delegate0_55;

		// Token: 0x04000114 RID: 276
		public static Class31.Delegate0 delegate0_56;

		// Token: 0x04000115 RID: 277
		public static Class31.Delegate0 delegate0_57;

		// Token: 0x04000116 RID: 278
		public static Class31.Delegate0 delegate0_58;

		// Token: 0x04000117 RID: 279
		public static Class31.Delegate0 delegate0_59;

		// Token: 0x04000118 RID: 280
		public static Class31.Delegate0 delegate0_60;

		// Token: 0x04000119 RID: 281
		public static Class31.Delegate0 delegate0_61;

		// Token: 0x0400011A RID: 282
		public static Class31.Delegate0 delegate0_62;

		// Token: 0x0400011B RID: 283
		public static Class31.Delegate0 delegate0_63;

		// Token: 0x0400011C RID: 284
		public static Class31.Delegate0 delegate0_64;

		// Token: 0x0400011D RID: 285
		public static Class31.Delegate0 delegate0_65;

		// Token: 0x0400011E RID: 286
		public static Class31.Delegate0 delegate0_66;

		// Token: 0x0400011F RID: 287
		public static Class31.Delegate0 delegate0_67;

		// Token: 0x04000120 RID: 288
		public static Class31.Delegate0 delegate0_68;

		// Token: 0x04000121 RID: 289
		public static Class31.Delegate0 delegate0_69;

		// Token: 0x04000122 RID: 290
		public static Class31.Delegate0 delegate0_70;

		// Token: 0x04000123 RID: 291
		public static Class31.Delegate0 delegate0_71;

		// Token: 0x04000124 RID: 292
		public static Class31.Delegate0 delegate0_72;

		// Token: 0x04000125 RID: 293
		public static Class31.Delegate0 delegate0_73;

		// Token: 0x04000126 RID: 294
		public static Class31.Delegate0 delegate0_74;

		// Token: 0x04000127 RID: 295
		public static Class31.Delegate0 delegate0_75;

		// Token: 0x04000128 RID: 296
		public static Class31.Delegate0 delegate0_76;

		// Token: 0x04000129 RID: 297
		public static Class31.Delegate0 delegate0_77;

		// Token: 0x0400012A RID: 298
		public static Class31.Delegate0 delegate0_78;

		// Token: 0x0400012B RID: 299
		public static Class31.Delegate0 delegate0_79;

		// Token: 0x0400012C RID: 300
		public static Class31.Delegate0 delegate0_80;

		// Token: 0x0400012D RID: 301
		public static Class31.Delegate0 delegate0_81;

		// Token: 0x0400012E RID: 302
		public static Class31.Delegate0 delegate0_82;

		// Token: 0x0400012F RID: 303
		public static Class31.Delegate0 delegate0_83;

		// Token: 0x04000130 RID: 304
		public static Class31.Delegate0 delegate0_84;

		// Token: 0x04000131 RID: 305
		public static Class31.Delegate0 delegate0_85;

		// Token: 0x04000132 RID: 306
		public static Class31.Delegate0 delegate0_86;

		// Token: 0x04000133 RID: 307
		public static Class31.Delegate0 delegate0_87;

		// Token: 0x04000134 RID: 308
		public static Class31.Delegate0 delegate0_88;

		// Token: 0x04000135 RID: 309
		public static Class31.Delegate0 delegate0_89;

		// Token: 0x04000136 RID: 310
		public static Class31.Delegate0 delegate0_90;

		// Token: 0x04000137 RID: 311
		public static Class31.Delegate0 delegate0_91;

		// Token: 0x04000138 RID: 312
		public static Class31.Delegate0 delegate0_92;

		// Token: 0x04000139 RID: 313
		public static Class31.Delegate0 delegate0_93;

		// Token: 0x0400013A RID: 314
		public static Class31.Delegate0 delegate0_94;

		// Token: 0x0400013B RID: 315
		public static Class31.Delegate0 delegate0_95;

		// Token: 0x0400013C RID: 316
		public static Class31.Delegate0 delegate0_96;

		// Token: 0x0400013D RID: 317
		public static Class31.Delegate0 delegate0_97;

		// Token: 0x0400013E RID: 318
		public static Class31.Delegate0 delegate0_98;

		// Token: 0x0400013F RID: 319
		public static Class31.Delegate0 delegate0_99;

		// Token: 0x04000140 RID: 320
		public static Class31.Delegate0 delegate0_100;

		// Token: 0x04000141 RID: 321
		public static Class31.Delegate0 delegate0_101;

		// Token: 0x04000142 RID: 322
		public static Class31.Delegate0 delegate0_102;

		// Token: 0x04000143 RID: 323
		public static Class31.Delegate0 delegate0_103;

		// Token: 0x04000144 RID: 324
		public static Class31.Delegate0 delegate0_104;

		// Token: 0x04000145 RID: 325
		public static Class31.Delegate0 delegate0_105;

		// Token: 0x04000146 RID: 326
		public static Class31.Delegate0 delegate0_106;

		// Token: 0x04000147 RID: 327
		public static Class31.Delegate0 delegate0_107;

		// Token: 0x04000148 RID: 328
		public static Class31.Delegate0 delegate0_108;

		// Token: 0x04000149 RID: 329
		public static Class31.Delegate0 delegate0_109;

		// Token: 0x0400014A RID: 330
		public static Class31.Delegate0 delegate0_110;

		// Token: 0x0400014B RID: 331
		public static Class31.Delegate0 delegate0_111;

		// Token: 0x0400014C RID: 332
		public static Class31.Delegate0 delegate0_112;

		// Token: 0x0400014D RID: 333
		public static Class31.Delegate0 delegate0_113;

		// Token: 0x0400014E RID: 334
		public static Class31.Delegate0 delegate0_114;

		// Token: 0x0400014F RID: 335
		public static Class31.Delegate0 delegate0_115;

		// Token: 0x04000150 RID: 336
		public static Class31.Delegate0 delegate0_116;

		// Token: 0x04000151 RID: 337
		public static Class31.Delegate0 delegate0_117;

		// Token: 0x04000152 RID: 338
		public static Class31.Delegate0 delegate0_118;

		// Token: 0x04000153 RID: 339
		public static Class31.Delegate0 delegate0_119;

		// Token: 0x04000154 RID: 340
		public static Class31.Delegate0 delegate0_120;

		// Token: 0x04000155 RID: 341
		public static Class31.Delegate0 delegate0_121;

		// Token: 0x04000156 RID: 342
		public static Class31.Delegate0 delegate0_122;

		// Token: 0x04000157 RID: 343
		public static Class31.Delegate0 delegate0_123;

		// Token: 0x04000158 RID: 344
		public static Class31.Delegate0 delegate0_124;

		// Token: 0x04000159 RID: 345
		public static Class31.Delegate0 delegate0_125;

		// Token: 0x0400015A RID: 346
		public static Class31.Delegate0 delegate0_126;

		// Token: 0x0400015B RID: 347
		public static Class31.Delegate0 delegate0_127;

		// Token: 0x0400015C RID: 348
		public static Class31.Delegate0 delegate0_128;

		// Token: 0x0400015D RID: 349
		public static Class31.Delegate0 delegate0_129;

		// Token: 0x0400015E RID: 350
		public static Class31.Delegate0 delegate0_130;

		// Token: 0x0400015F RID: 351
		public static Class31.Delegate0 delegate0_131;

		// Token: 0x04000160 RID: 352
		public static Class31.Delegate0 delegate0_132;

		// Token: 0x04000161 RID: 353
		public static Class31.Delegate0 delegate0_133;

		// Token: 0x04000162 RID: 354
		public static Class31.Delegate0 delegate0_134;

		// Token: 0x04000163 RID: 355
		public static Class31.Delegate0 delegate0_135;

		// Token: 0x04000164 RID: 356
		public static Class31.Delegate0 delegate0_136;

		// Token: 0x04000165 RID: 357
		public static Class31.Delegate0 delegate0_137;

		// Token: 0x04000166 RID: 358
		public static Class31.Delegate0 delegate0_138;

		// Token: 0x04000167 RID: 359
		public static Class31.Delegate0 delegate0_139;

		// Token: 0x04000168 RID: 360
		public static Class31.Delegate0 delegate0_140;

		// Token: 0x04000169 RID: 361
		public static Class31.Delegate0 delegate0_141;

		// Token: 0x0400016A RID: 362
		public static Class31.Delegate0 delegate0_142;

		// Token: 0x0400016B RID: 363
		public static Class31.Delegate0 delegate0_143;

		// Token: 0x0400016C RID: 364
		public static Class31.Delegate0 delegate0_144;

		// Token: 0x0400016D RID: 365
		public static Class31.Delegate0 delegate0_145;

		// Token: 0x0400016E RID: 366
		public static Class31.Delegate0 delegate0_146;

		// Token: 0x0400016F RID: 367
		public static Class31.Delegate0 delegate0_147;

		// Token: 0x04000170 RID: 368
		public static Class31.Delegate0 delegate0_148;

		// Token: 0x04000171 RID: 369
		public static Class31.Delegate0 delegate0_149;

		// Token: 0x04000172 RID: 370
		public static Class31.Delegate0 delegate0_150;

		// Token: 0x04000173 RID: 371
		public static Class31.Delegate0 delegate0_151;

		// Token: 0x04000174 RID: 372
		public static Class31.Delegate0 delegate0_152;

		// Token: 0x04000175 RID: 373
		public static Class31.Delegate0 delegate0_153;

		// Token: 0x04000176 RID: 374
		public static Class31.Delegate0 delegate0_154;

		// Token: 0x04000177 RID: 375
		public static Class31.Delegate0 delegate0_155;

		// Token: 0x04000178 RID: 376
		public static Class31.Delegate0 delegate0_156;

		// Token: 0x04000179 RID: 377
		public static Class31.Delegate0 delegate0_157;

		// Token: 0x0400017A RID: 378
		public static Class31.Delegate0 delegate0_158;

		// Token: 0x0400017B RID: 379
		public static Class31.Delegate0 delegate0_159;

		// Token: 0x0400017C RID: 380
		public static Class31.Delegate0 delegate0_160;

		// Token: 0x0400017D RID: 381
		public static Class31.Delegate0 delegate0_161;

		// Token: 0x0400017E RID: 382
		public static Class31.Delegate0 delegate0_162;

		// Token: 0x0400017F RID: 383
		public static Class31.Delegate0 delegate0_163;

		// Token: 0x04000180 RID: 384
		public static Class31.Delegate0 delegate0_164;

		// Token: 0x04000181 RID: 385
		public static Class31.Delegate0 delegate0_165;

		// Token: 0x04000182 RID: 386
		public static Class31.Delegate0 delegate0_166;

		// Token: 0x04000183 RID: 387
		public static Class31.Delegate0 delegate0_167;

		// Token: 0x04000184 RID: 388
		public static Class31.Delegate0 delegate0_168;

		// Token: 0x04000185 RID: 389
		public static Class31.Delegate0 delegate0_169;

		// Token: 0x04000186 RID: 390
		public static Class31.Delegate0 delegate0_170;

		// Token: 0x04000187 RID: 391
		public static Class31.Delegate0 delegate0_171;

		// Token: 0x04000188 RID: 392
		public static Class31.Delegate0 delegate0_172;

		// Token: 0x04000189 RID: 393
		public static Class31.Delegate0 delegate0_173;

		// Token: 0x0400018A RID: 394
		public static Class31.Delegate0 delegate0_174;

		// Token: 0x0400018B RID: 395
		public static Class31.Delegate0 delegate0_175;

		// Token: 0x0400018C RID: 396
		public static Class31.Delegate0 delegate0_176;

		// Token: 0x0400018D RID: 397
		public static Class31.Delegate0 delegate0_177;

		// Token: 0x0400018E RID: 398
		public static Class31.Delegate0 delegate0_178;

		// Token: 0x0400018F RID: 399
		public static Class31.Delegate0 delegate0_179;

		// Token: 0x04000190 RID: 400
		public static Class31.Delegate0 delegate0_180;

		// Token: 0x04000191 RID: 401
		public static Class31.Delegate0 delegate0_181;

		// Token: 0x04000192 RID: 402
		public static Class31.Delegate0 delegate0_182;

		// Token: 0x04000193 RID: 403
		public static Class31.Delegate0 delegate0_183;

		// Token: 0x04000194 RID: 404
		public static Class31.Delegate0 delegate0_184;

		// Token: 0x04000195 RID: 405
		public static Class31.Delegate0 delegate0_185;

		// Token: 0x04000196 RID: 406
		public static Class31.Delegate0 delegate0_186;

		// Token: 0x04000197 RID: 407
		public static Class31.Delegate0 delegate0_187;

		// Token: 0x04000198 RID: 408
		public static Class31.Delegate0 delegate0_188;

		// Token: 0x04000199 RID: 409
		public static Class31.Delegate0 delegate0_189;

		// Token: 0x0400019A RID: 410
		public static Class31.Delegate0 delegate0_190;

		// Token: 0x0400019B RID: 411
		public static Class31.Delegate0 delegate0_191;

		// Token: 0x0400019C RID: 412
		public static Class31.Delegate0 delegate0_192;

		// Token: 0x0400019D RID: 413
		public static Class31.Delegate0 delegate0_193;

		// Token: 0x0400019E RID: 414
		public static Class31.Delegate0 delegate0_194;

		// Token: 0x0400019F RID: 415
		public static Class31.Delegate0 delegate0_195;

		// Token: 0x040001A0 RID: 416
		public static Class31.Delegate0 delegate0_196;

		// Token: 0x040001A1 RID: 417
		public static Class31.Delegate0 delegate0_197;

		// Token: 0x040001A2 RID: 418
		public static Class31.Delegate0 delegate0_198;

		// Token: 0x040001A3 RID: 419
		public static Class31.Delegate0 delegate0_199;

		// Token: 0x040001A4 RID: 420
		public static Class31.Delegate0 delegate0_200;

		// Token: 0x040001A5 RID: 421
		public static Class31.Delegate0 delegate0_201;

		// Token: 0x040001A6 RID: 422
		public static Class31.Delegate0 delegate0_202;

		// Token: 0x040001A7 RID: 423
		public static Class31.Delegate0 delegate0_203;

		// Token: 0x040001A8 RID: 424
		public static Class31.Delegate0 delegate0_204;
	}

	// Token: 0x02000069 RID: 105
	// (Invoke) Token: 0x060003B6 RID: 950
	private delegate object Delegate21(object object_0, object[] object_1);

	// Token: 0x0200006A RID: 106
	private struct Struct13
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00004AEE File Offset: 0x00002CEE
		public Struct13(uint uint_1)
		{
			this.uint_0 = uint_1;
			this.object_0 = null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00004AFE File Offset: 0x00002CFE
		public Struct13(uint uint_1, object object_1)
		{
			this.uint_0 = uint_1;
			this.object_0 = object_1;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00004B0E File Offset: 0x00002D0E
		[Attribute2]
		public uint method_0()
		{
			return this.uint_0;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00004B16 File Offset: 0x00002D16
		[Attribute2]
		public object method_1()
		{
			return this.object_0;
		}

		// Token: 0x040001A9 RID: 425
		private readonly uint uint_0;

		// Token: 0x040001AA RID: 426
		private readonly object object_0;
	}

	// Token: 0x0200006B RID: 107
	private sealed class Class38
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00004B1E File Offset: 0x00002D1E
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00004B26 File Offset: 0x00002D26
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00004B2F File Offset: 0x00002D2F
		public Type method_2()
		{
			return this.type_0;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00004B37 File Offset: 0x00002D37
		public void method_3(Type type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x040001AB RID: 427
		private string string_0;

		// Token: 0x040001AC RID: 428
		private Type type_0;
	}

	// Token: 0x0200006C RID: 108
	private static class Class39
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00033244 File Offset: 0x00031444
		public static MethodBase smethod_0(Class31 class31_0, Class50 class50_0, MethodBase methodBase_0, bool bool_0)
		{
			Dictionary<MethodBase, MethodInfo> obj = Class31.Class39.dictionary_0;
			MethodBase result;
			lock (obj)
			{
				MethodInfo methodInfo;
				if (Class31.Class39.dictionary_0.TryGetValue(methodBase_0, out methodInfo))
				{
					result = methodInfo;
				}
				else
				{
					MethodInfo methodInfo2 = methodBase_0 as MethodInfo;
					Type returnType;
					if (methodInfo2 != null)
					{
						returnType = methodInfo2.ReturnType;
					}
					else
					{
						returnType = Class31.type_8;
					}
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					Type[] array;
					if (methodBase_0.IsStatic)
					{
						array = new Type[parameters.Length];
						for (int i = 0; i < parameters.Length; i++)
						{
							array[i] = parameters[i].ParameterType;
						}
					}
					else
					{
						array = new Type[parameters.Length + 1];
						Type type = methodBase_0.DeclaringType;
						if (type.IsValueType)
						{
							type = type.MakeByRefType();
							bool_0 = false;
						}
						array[0] = type;
						for (int j = 0; j < parameters.Length; j++)
						{
							array[j + 1] = parameters[j].ParameterType;
						}
					}
					string empty = string.Empty;
					if (methodInfo == null)
					{
						methodInfo = new DynamicMethod(empty, returnType, array, class31_0.method_70(class50_0.method_6(), true), true);
					}
					ILGenerator ilgenerator = ((DynamicMethod)methodInfo).GetILGenerator();
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg, k);
					}
					ConstructorInfo constructorInfo = methodBase_0 as ConstructorInfo;
					if (constructorInfo != null)
					{
						ilgenerator.Emit(bool_0 ? OpCodes.Callvirt : OpCodes.Call, constructorInfo);
					}
					else
					{
						ilgenerator.Emit(bool_0 ? OpCodes.Callvirt : OpCodes.Call, (MethodInfo)methodBase_0);
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class31.Class39.dictionary_0.Add(methodBase_0, methodInfo);
					result = methodInfo;
				}
			}
			return result;
		}

		// Token: 0x040001AD RID: 429
		private static readonly Dictionary<MethodBase, MethodInfo> dictionary_0 = new Dictionary<MethodBase, MethodInfo>();
	}

	// Token: 0x0200006D RID: 109
	private sealed class Class40
	{
	}
}
