using System;
using System.IO;

// Token: 0x020000BA RID: 186
internal static class Class118
{
	// Token: 0x06000587 RID: 1415 RVA: 0x000387E0 File Offset: 0x000369E0
	public static Stream smethod_0(Stream stream_0, byte[] byte_0, string string_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		byte[] array2 = new byte[byte_0.Length + array.Length];
		Buffer.BlockCopy(byte_0, 0, array2, 0, byte_0.Length);
		Buffer.BlockCopy(array, 0, array2, byte_0.Length, array.Length);
		Class128 class128_ = new Class128(1, array2);
		Class100 class100_ = new Class100(false, class128_, Class118.class128_0);
		Class92 @class = new Class92(new Class133(false, class100_, false));
		Class130 class2 = new Class130();
		class2.method_1(@class.imethod_1());
		Class130 class130_ = class2;
		return new Stream2(new Stream1(stream_0, @class), class130_, Class118.class87_0, false);
	}

	// Token: 0x0400030B RID: 779
	private static readonly Class128 class128_0 = Class128.smethod_18(65537UL);

	// Token: 0x0400030C RID: 780
	private static readonly Class87 class87_0 = new Class87();
}
