using System;

// Token: 0x020000BB RID: 187
internal static class Class119
{
	// Token: 0x06000588 RID: 1416 RVA: 0x00038868 File Offset: 0x00036A68
	public static void smethod_0(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < 4; i++)
		{
			int num = int_0++;
			byte_0[num] ^= (byte)(int_1 >> i * 8);
		}
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x000388A0 File Offset: 0x00036AA0
	public static void smethod_1(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < 4; i++)
		{
			if (int_0 >= byte_0.Length)
			{
				return;
			}
			int num = int_0++;
			byte_0[num] ^= (byte)(int_1 >> i * 8);
		}
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x000388DC File Offset: 0x00036ADC
	public static void smethod_2(byte[] byte_0, int int_0, long long_0)
	{
		for (int i = 0; i < 8; i++)
		{
			int num = int_0++;
			byte_0[num] ^= (byte)(long_0 >> i * 8);
		}
	}
}
