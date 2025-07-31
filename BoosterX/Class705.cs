using System;

// Token: 0x020005BA RID: 1466
internal static class Class705
{
	// Token: 0x060025A0 RID: 9632 RVA: 0x0001912D File Offset: 0x0001732D
	public static string smethod_0(this ushort[] ushort_0)
	{
		Converter<ushort, char> converter;
		if ((converter = Class705.Class706.converter_0) == null)
		{
			converter = (Class705.Class706.converter_0 = new Converter<ushort, char>(Convert.ToChar));
		}
		return new string(Array.ConvertAll<ushort, char>(ushort_0, converter));
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x00091238 File Offset: 0x0008F438
	public static string smethod_1(this byte[] byte_0)
	{
		char[] array = new char[byte_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)byte_0[i];
		}
		return new string(array);
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x00091268 File Offset: 0x0008F468
	public static byte[] smethod_2(this byte[] byte_0, int int_0)
	{
		byte[] array = new byte[byte_0.Length];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array[i] = (byte)((int)byte_0[i] ^ int_0);
		}
		return array;
	}

	// Token: 0x020005BB RID: 1467
	private static class Class706
	{
		// Token: 0x0400189A RID: 6298
		public static Converter<ushort, char> converter_0;
	}
}
