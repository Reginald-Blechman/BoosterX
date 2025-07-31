using System;

// Token: 0x0200008C RID: 140
internal sealed class Class44 : Class43
{
	// Token: 0x06000473 RID: 1139 RVA: 0x0000510C File Offset: 0x0000330C
	public Class44(byte[] byte_0, long long_0) : base(byte_0, long_0)
	{
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00036840 File Offset: 0x00034A40
	public byte[] method_1(Class97 class97_0, Interface6 interface6_0)
	{
		byte[] array = new byte[4];
		Class44.smethod_6(class97_0, array, 0, new int?(array.Length));
		int num = Class43.smethod_4(base.method_0(array, false), 0);
		int num2 = Class43.smethod_1(num);
		int value = num2 - 4;
		byte[] array2 = new byte[num2];
		Class44.smethod_6(class97_0, array2, 4, new int?(value));
		Buffer.BlockCopy(array, 0, array2, 0, 4);
		Array src = base.method_0(array2, false);
		byte[] array3 = new byte[num];
		Buffer.BlockCopy(src, 4, array3, 0, num);
		return array3;
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000368B8 File Offset: 0x00034AB8
	public byte[] method_2(byte[] byte_0)
	{
		byte[] array = base.method_0(byte_0, false);
		int num = Class43.smethod_4(array, 0);
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(array, 4, array2, 0, num);
		return array2;
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x000368E8 File Offset: 0x00034AE8
	private static void smethod_6(Class97 class97_0, byte[] byte_0, int int_0, int? nullable_0)
	{
		int num = nullable_0 ?? (byte_0.Length - int_0);
		int num2;
		while ((num2 = class97_0.vmethod_11(byte_0, int_0, num)) > 0)
		{
			int_0 += num2;
			num -= num2;
		}
	}
}
