using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x0200003F RID: 63
internal static class Class29
{
	// Token: 0x06000188 RID: 392 RVA: 0x00003DD8 File Offset: 0x00001FD8
	public static bool smethod_0(Type type_5)
	{
		return type_5.IsGenericType && !type_5.IsGenericTypeDefinition && type_5.GetGenericTypeDefinition() == Class29.type_3;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00003DFC File Offset: 0x00001FFC
	public static Type smethod_1(Type type_5)
	{
		while (type_5.HasElementType)
		{
			type_5 = type_5.GetElementType();
		}
		return type_5;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00003E14 File Offset: 0x00002014
	public static Type smethod_2(Type type_5)
	{
		if (type_5.HasElementType && !type_5.IsArray)
		{
			type_5 = type_5.GetElementType();
		}
		return type_5;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00025E8C File Offset: 0x0002408C
	public static Stack<Struct5> smethod_3(Type type_5)
	{
		Stack<Struct5> stack = new Stack<Struct5>();
		Type type = type_5;
		for (;;)
		{
			if (type.IsArray)
			{
				stack.Push(new Struct5
				{
					int_0 = 2,
					int_1 = type.GetArrayRank()
				});
			}
			else if (type.IsByRef)
			{
				stack.Push(new Struct5
				{
					int_0 = 1
				});
			}
			else
			{
				if (!type.IsPointer)
				{
					break;
				}
				stack.Push(new Struct5
				{
					int_0 = 0
				});
			}
			type = type.GetElementType();
		}
		return stack;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00025F20 File Offset: 0x00024120
	public static Stack<Struct5> smethod_4(string string_0)
	{
		string text = string_0;
		Stack<Struct5> stack = new Stack<Struct5>();
		for (;;)
		{
			if (text.EndsWith("&", StringComparison.Ordinal))
			{
				stack.Push(new Struct5
				{
					int_0 = 1
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith("*", StringComparison.Ordinal))
			{
				stack.Push(new Struct5
				{
					int_0 = 0
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith("[]", StringComparison.Ordinal))
			{
				stack.Push(new Struct5
				{
					int_0 = 2,
					int_1 = 1
				});
				text = text.Substring(0, text.Length - 2);
			}
			else
			{
				if (!text.EndsWith(",]", StringComparison.Ordinal))
				{
					return stack;
				}
				int num = 1;
				int num2 = -1;
				for (int i = text.Length - 2; i >= 0; i--)
				{
					char c = text[i];
					if (c != ',')
					{
						if (c != '[')
						{
							goto Block_5;
						}
						num2 = i;
						i = -1;
					}
					else
					{
						num++;
					}
				}
				if (num2 < 0)
				{
					goto IL_149;
				}
				text = text.Substring(0, num2);
				stack.Push(new Struct5
				{
					int_0 = 2,
					int_1 = num
				});
			}
		}
		Block_5:
		throw new InvalidOperationException("VM-3012");
		IL_149:
		throw new InvalidOperationException("VM-3014");
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00026090 File Offset: 0x00024290
	public static Type smethod_5(Type type_5, Stack<Struct5> stack_0)
	{
		Type type = type_5;
		while (stack_0.Count > 0)
		{
			Struct5 @struct = stack_0.Pop();
			switch (@struct.int_0)
			{
			case 0:
				type = type.MakePointerType();
				break;
			case 1:
				type = type.MakeByRefType();
				break;
			case 2:
				if (@struct.int_1 == 1)
				{
					type = type.MakeArrayType();
				}
				else
				{
					type = type.MakeArrayType(@struct.int_1);
				}
				break;
			}
		}
		return type;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00026100 File Offset: 0x00024300
	public static int smethod_6(Type type_5)
	{
		int result;
		if (Class29.Class30.dictionary_0.TryGetValue(type_5, out result))
		{
			return result;
		}
		if (type_5.IsArray)
		{
			return 9;
		}
		if (!type_5.IsValueType)
		{
			return 4;
		}
		if (type_5.IsSubclassOf(Class29.type_2))
		{
			return 19;
		}
		if (Class29.smethod_0(type_5))
		{
			return 5;
		}
		return 25;
	}

	// Token: 0x04000083 RID: 131
	public static readonly Type type_0 = typeof(object);

	// Token: 0x04000084 RID: 132
	public static readonly Type type_1 = typeof(ValueType);

	// Token: 0x04000085 RID: 133
	public static readonly Type type_2 = typeof(Enum);

	// Token: 0x04000086 RID: 134
	public static readonly Type type_3 = typeof(Nullable<>);

	// Token: 0x04000087 RID: 135
	public static readonly Type type_4 = typeof(void);

	// Token: 0x04000088 RID: 136
	public static readonly Assembly assembly_0 = typeof(Class29).Assembly;

	// Token: 0x02000040 RID: 64
	private static class Class30
	{
		// Token: 0x04000089 RID: 137
		public static readonly Dictionary<Type, int> dictionary_0 = new Dictionary<Type, int>
		{
			{
				typeof(object),
				7
			},
			{
				typeof(byte),
				12
			},
			{
				typeof(sbyte),
				17
			},
			{
				typeof(short),
				26
			},
			{
				typeof(int),
				1
			},
			{
				typeof(long),
				13
			},
			{
				typeof(ushort),
				16
			},
			{
				typeof(uint),
				3
			},
			{
				typeof(ulong),
				14
			},
			{
				typeof(IntPtr),
				0
			},
			{
				typeof(UIntPtr),
				20
			},
			{
				typeof(float),
				22
			},
			{
				typeof(double),
				8
			},
			{
				typeof(bool),
				15
			},
			{
				typeof(char),
				6
			},
			{
				typeof(string),
				10
			}
		};
	}
}
