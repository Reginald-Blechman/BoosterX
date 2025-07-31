using System;
using System.IO;

// Token: 0x0200008D RID: 141
internal sealed class Class89
{
	// Token: 0x06000478 RID: 1144 RVA: 0x00005116 File Offset: 0x00003316
	private static Stream smethod_0()
	{
		return (Stream)Class392.smethod_3().method_105(Class392.smethod_1(), "VR3b<Za-h\\", null);
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00005132 File Offset: 0x00003332
	private static int smethod_1()
	{
		return (int)Class392.smethod_3().method_105(Class392.smethod_1(), "41)E&Za-h\\", null);
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00005153 File Offset: 0x00003353
	private static byte[] smethod_2()
	{
		return (byte[])Class392.smethod_3().method_105(Class392.smethod_1(), "A@/bOZa-h\\", null);
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x0000516F File Offset: 0x0000336F
	private static byte[] smethod_3()
	{
		return (byte[])Class392.smethod_3().method_105(Class392.smethod_1(), "bd=dbZa-h_", null);
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x0000518B File Offset: 0x0000338B
	public static void smethod_4(string string_0, byte[] byte_0, int int_0, int int_1)
	{
		if (Class89.stream_0 == null)
		{
			Class89.stream_0 = Class89.smethod_0();
		}
		Class89.smethod_9(Class89.smethod_11(string_0), byte_0, int_0, int_1);
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x0003692C File Offset: 0x00034B2C
	public static byte[] smethod_5(string string_0)
	{
		if (Class89.stream_0 == null)
		{
			Class89.stream_0 = Class89.smethod_0();
		}
		long num = Class89.smethod_11(string_0);
		byte[] array = new byte[4];
		Class89.smethod_9(num, array, 0, 4);
		int num2 = Class11.smethod_4(array, 0);
		Array.Clear(array, 0, array.Length);
		byte[] array2 = new byte[num2];
		Class89.smethod_9(num + 4L, array2, 0, num2);
		return array2;
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0003698C File Offset: 0x00034B8C
	private static Class114 smethod_6(out bool bool_0)
	{
		bool_0 = true;
		if (Class89.class114_0 != null)
		{
			return Class89.class114_0;
		}
		if (Class89.class90_0 != null)
		{
			bool_0 = false;
			return Class89.class90_0.method_8();
		}
		Class90 @class = Class89.smethod_8();
		Class114 class2 = @class.method_8();
		if (class2.vmethod_0())
		{
			Class89.class114_0 = class2;
			@class.Dispose();
		}
		else
		{
			Class89.class90_0 = @class;
			bool_0 = false;
		}
		return class2;
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000369EC File Offset: 0x00034BEC
	private static int smethod_7()
	{
		if (Class89.nullable_0 != null)
		{
			return Class89.nullable_0.Value;
		}
		bool flag;
		Class114 @class = Class89.smethod_6(out flag);
		Class89.nullable_0 = new int?(@class.vmethod_1());
		if (!flag)
		{
			@class.Dispose();
		}
		return Class89.nullable_0.Value;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000051AC File Offset: 0x000033AC
	private static Class90 smethod_8()
	{
		return (Class90)Class392.smethod_3().method_105(Class392.smethod_1(), "la4(,Za-hc", null);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00036A3C File Offset: 0x00034C3C
	private static void smethod_9(long long_0, byte[] byte_0, int int_0, int int_1)
	{
		object[] object_ = new object[]
		{
			long_0,
			byte_0,
			int_0,
			int_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "CUCLVZa-hd", object_);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00036A84 File Offset: 0x00034C84
	private static void smethod_10(long long_0, byte[] byte_0)
	{
		object[] object_ = new object[]
		{
			long_0,
			byte_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "5d[r+Za-hh", object_);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00036ABC File Offset: 0x00034CBC
	private static long smethod_11(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (long)Class392.smethod_3().method_105(Class392.smethod_1(), "<j]9AZa-hL", object_);
	}

	// Token: 0x040002BB RID: 699
	[ThreadStatic]
	private static Stream stream_0;

	// Token: 0x040002BC RID: 700
	[ThreadStatic]
	private static Class90 class90_0;

	// Token: 0x040002BD RID: 701
	[ThreadStatic]
	private static Class114 class114_0;

	// Token: 0x040002BE RID: 702
	private static int? nullable_0;
}
