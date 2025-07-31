using System;

// Token: 0x020000B2 RID: 178
internal static class Class113
{
	// Token: 0x06000566 RID: 1382 RVA: 0x00005820 File Offset: 0x00003A20
	public static void smethod_0(ref byte byte_0)
	{
		byte_0 = (byte)Class113.int_0;
		Class113.int_1 = (int)byte_0;
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00005835 File Offset: 0x00003A35
	public static void smethod_1(ref int int_2)
	{
		int_2 = Class113.int_0;
		Class113.int_1 = int_2;
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00005849 File Offset: 0x00003A49
	public static void smethod_2(ref long long_0)
	{
		long_0 = (long)Class113.int_0;
		Class113.int_1 = (int)long_0;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x0000585F File Offset: 0x00003A5F
	public static void smethod_3(ref char char_0)
	{
		char_0 = (char)Class113.int_0;
		Class113.int_1 = (int)char_0;
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00005874 File Offset: 0x00003A74
	public static void smethod_4(Array array_0, int int_2, int int_3)
	{
		Array.Clear(array_0, int_2, int_3);
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0000587E File Offset: 0x00003A7E
	public static void smethod_5(Array array_0)
	{
		Class113.smethod_4(array_0, 0, array_0.GetLength(0));
	}

	// Token: 0x04000302 RID: 770
	private static volatile int int_0;

	// Token: 0x04000303 RID: 771
	private static volatile int int_1;
}
