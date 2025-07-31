using System;

// Token: 0x02000034 RID: 52
internal sealed class Class26
{
	// Token: 0x06000134 RID: 308 RVA: 0x00003332 File Offset: 0x00001532
	private Class26()
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00003B04 File Offset: 0x00001D04
	internal static void smethod_0(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)uint_0;
		byte_0[++int_0] = (byte)(uint_0 >> 8);
		byte_0[++int_0] = (byte)(uint_0 >> 16);
		byte_0[++int_0] = (byte)(uint_0 >> 24);
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00003B37 File Offset: 0x00001D37
	internal static uint smethod_1(byte[] byte_0, int int_0)
	{
		return (uint)((int)byte_0[int_0] | (int)byte_0[++int_0] << 8 | (int)byte_0[++int_0] << 16 | (int)byte_0[++int_0] << 24);
	}
}
