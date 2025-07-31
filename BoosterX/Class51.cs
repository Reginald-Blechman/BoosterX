using System;

// Token: 0x0200007D RID: 125
internal sealed class Class51
{
	// Token: 0x06000416 RID: 1046 RVA: 0x00004E3F File Offset: 0x0000303F
	public Class51()
	{
		this.byte_0 = new byte[4];
		this.method_9();
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00004E66 File Offset: 0x00003066
	public Class51(Class51 class51_0)
	{
		this.method_4(class51_0);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00034EB4 File Offset: 0x000330B4
	public void method_0(byte byte_1)
	{
		byte[] array = this.byte_0;
		int num = this.int_0;
		this.int_0 = num + 1;
		array[num] = byte_1;
		if (this.int_0 == this.byte_0.Length)
		{
			this.method_6(this.byte_0, 0);
			this.int_0 = 0;
		}
		this.long_0 += 1L;
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00034F14 File Offset: 0x00033114
	public void method_1(byte[] byte_1, int int_2, int int_3)
	{
		int_3 = Math.Max(0, int_3);
		int i = 0;
		if (this.int_0 != 0)
		{
			while (i < int_3)
			{
				byte[] array = this.byte_0;
				int num = this.int_0;
				this.int_0 = num + 1;
				array[num] = byte_1[int_2 + i++];
				if (this.int_0 == 4)
				{
					this.method_6(this.byte_0, 0);
					this.int_0 = 0;
					break;
				}
			}
		}
		int num2 = (int_3 - i & -4) + i;
		while (i < num2)
		{
			this.method_6(byte_1, int_2 + i);
			i += 4;
		}
		while (i < int_3)
		{
			byte[] array2 = this.byte_0;
			int num = this.int_0;
			this.int_0 = num + 1;
			array2[num] = byte_1[int_2 + i++];
		}
		this.long_0 += (long)int_3;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00034FD4 File Offset: 0x000331D4
	public void method_2()
	{
		long long_ = this.long_0 << 3;
		this.method_0(128);
		while (this.int_0 != 0)
		{
			this.method_0(0);
		}
		this.method_7(long_);
		this.method_10();
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00004E82 File Offset: 0x00003082
	public int method_3()
	{
		return 64;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00035014 File Offset: 0x00033214
	private void method_4(Class51 class51_0)
	{
		this.byte_0 = new byte[class51_0.byte_0.Length];
		Buffer.BlockCopy(class51_0.byte_0, 0, this.byte_0, 0, class51_0.byte_0.Length);
		this.int_0 = class51_0.int_0;
		this.long_0 = class51_0.long_0;
		this.uint_0 = class51_0.uint_0;
		this.uint_1 = class51_0.uint_1;
		this.uint_2 = class51_0.uint_2;
		this.uint_3 = class51_0.uint_3;
		this.uint_4 = class51_0.uint_4;
		Array.Copy(class51_0.uint_5, 0, this.uint_5, 0, class51_0.uint_5.Length);
		this.int_1 = class51_0.int_1;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00004E86 File Offset: 0x00003086
	public int method_5()
	{
		return 20;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x000350CC File Offset: 0x000332CC
	public void method_6(byte[] byte_1, int int_2)
	{
		this.uint_5[this.int_1] = Class51.smethod_4(byte_1, int_2);
		int num = this.int_1 + 1;
		this.int_1 = num;
		if (num == 16)
		{
			this.method_10();
		}
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00004E8A File Offset: 0x0000308A
	public void method_7(long long_1)
	{
		if (this.int_1 > 14)
		{
			this.method_10();
		}
		this.uint_5[14] = (uint)((ulong)long_1 >> 32);
		this.uint_5[15] = (uint)long_1;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00035108 File Offset: 0x00033308
	public int method_8(byte[] byte_1, int int_2)
	{
		this.method_2();
		Class51.smethod_3(this.uint_0, byte_1, int_2);
		Class51.smethod_3(this.uint_1, byte_1, int_2 + 4);
		Class51.smethod_3(this.uint_2, byte_1, int_2 + 8);
		Class51.smethod_3(this.uint_3, byte_1, int_2 + 12);
		Class51.smethod_3(this.uint_4, byte_1, int_2 + 16);
		this.method_9();
		return 20;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00035170 File Offset: 0x00033370
	public void method_9()
	{
		this.long_0 = 0L;
		this.int_0 = 0;
		Array.Clear(this.byte_0, 0, this.byte_0.Length);
		this.uint_0 = 1732584193U;
		this.uint_1 = 4023233417U;
		this.uint_2 = 2562383102U;
		this.uint_3 = 271733878U;
		this.uint_4 = 3285377520U;
		this.int_1 = 0;
		Array.Clear(this.uint_5, 0, this.uint_5.Length);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00004EB5 File Offset: 0x000030B5
	private static uint smethod_0(uint uint_6, uint uint_7, uint uint_8)
	{
		return (uint_6 & uint_7) | (~uint_6 & uint_8);
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00004EBF File Offset: 0x000030BF
	private static uint smethod_1(uint uint_6, uint uint_7, uint uint_8)
	{
		return uint_6 ^ uint_7 ^ uint_8;
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00004EC6 File Offset: 0x000030C6
	private static uint smethod_2(uint uint_6, uint uint_7, uint uint_8)
	{
		return (uint_6 & uint_7) | (uint_6 & uint_8) | (uint_7 & uint_8);
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x000351FC File Offset: 0x000333FC
	private void method_10()
	{
		for (int i = 16; i < 80; i++)
		{
			uint num = this.uint_5[i - 3] ^ this.uint_5[i - 8] ^ this.uint_5[i - 14] ^ this.uint_5[i - 16];
			this.uint_5[i] = (num << 1 | num >> 31);
		}
		uint num2 = this.uint_0;
		uint num3 = this.uint_1;
		uint num4 = this.uint_2;
		uint num5 = this.uint_3;
		uint num6 = this.uint_4;
		int num7 = 0;
		for (int j = 0; j < 4; j++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class51.smethod_0(num3, num4, num5) + this.uint_5[num7++] + 1518500249U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class51.smethod_0(num2, num3, num4) + this.uint_5[num7++] + 1518500249U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class51.smethod_0(num6, num2, num3) + this.uint_5[num7++] + 1518500249U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class51.smethod_0(num5, num6, num2) + this.uint_5[num7++] + 1518500249U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class51.smethod_0(num4, num5, num6) + this.uint_5[num7++] + 1518500249U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		for (int k = 0; k < 4; k++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class51.smethod_1(num3, num4, num5) + this.uint_5[num7++] + 1859775393U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class51.smethod_1(num2, num3, num4) + this.uint_5[num7++] + 1859775393U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class51.smethod_1(num6, num2, num3) + this.uint_5[num7++] + 1859775393U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class51.smethod_1(num5, num6, num2) + this.uint_5[num7++] + 1859775393U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class51.smethod_1(num4, num5, num6) + this.uint_5[num7++] + 1859775393U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		for (int l = 0; l < 4; l++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class51.smethod_2(num3, num4, num5) + this.uint_5[num7++] + 2400959708U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class51.smethod_2(num2, num3, num4) + this.uint_5[num7++] + 2400959708U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class51.smethod_2(num6, num2, num3) + this.uint_5[num7++] + 2400959708U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class51.smethod_2(num5, num6, num2) + this.uint_5[num7++] + 2400959708U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class51.smethod_2(num4, num5, num6) + this.uint_5[num7++] + 2400959708U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		for (int m = 0; m < 4; m++)
		{
			num6 += (num2 << 5 | num2 >> 27) + Class51.smethod_1(num3, num4, num5) + this.uint_5[num7++] + 3395469782U;
			num3 = (num3 << 30 | num3 >> 2);
			num5 += (num6 << 5 | num6 >> 27) + Class51.smethod_1(num2, num3, num4) + this.uint_5[num7++] + 3395469782U;
			num2 = (num2 << 30 | num2 >> 2);
			num4 += (num5 << 5 | num5 >> 27) + Class51.smethod_1(num6, num2, num3) + this.uint_5[num7++] + 3395469782U;
			num6 = (num6 << 30 | num6 >> 2);
			num3 += (num4 << 5 | num4 >> 27) + Class51.smethod_1(num5, num6, num2) + this.uint_5[num7++] + 3395469782U;
			num5 = (num5 << 30 | num5 >> 2);
			num2 += (num3 << 5 | num3 >> 27) + Class51.smethod_1(num4, num5, num6) + this.uint_5[num7++] + 3395469782U;
			num4 = (num4 << 30 | num4 >> 2);
		}
		this.uint_0 += num2;
		this.uint_1 += num3;
		this.uint_2 += num4;
		this.uint_3 += num5;
		this.uint_4 += num6;
		this.int_1 = 0;
		Array.Clear(this.uint_5, 0, 16);
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00004ED3 File Offset: 0x000030D3
	private static void smethod_3(uint uint_6, byte[] byte_1, int int_2)
	{
		byte_1[int_2] = (byte)(uint_6 >> 24);
		byte_1[int_2 + 1] = (byte)(uint_6 >> 16);
		byte_1[int_2 + 2] = (byte)(uint_6 >> 8);
		byte_1[int_2 + 3] = (byte)uint_6;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00004EF7 File Offset: 0x000030F7
	private static uint smethod_4(byte[] byte_1, int int_2)
	{
		return (uint)((int)byte_1[int_2] << 24 | (int)byte_1[int_2 + 1] << 16 | (int)byte_1[int_2 + 2] << 8 | (int)byte_1[int_2 + 3]);
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00004F16 File Offset: 0x00003116
	public Class51 method_11()
	{
		return new Class51(this);
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00004F1E File Offset: 0x0000311E
	public void method_12(Class51 class51_0)
	{
		this.method_4(class51_0);
	}

	// Token: 0x040002A0 RID: 672
	private byte[] byte_0;

	// Token: 0x040002A1 RID: 673
	private int int_0;

	// Token: 0x040002A2 RID: 674
	private long long_0;

	// Token: 0x040002A3 RID: 675
	private uint uint_0;

	// Token: 0x040002A4 RID: 676
	private uint uint_1;

	// Token: 0x040002A5 RID: 677
	private uint uint_2;

	// Token: 0x040002A6 RID: 678
	private uint uint_3;

	// Token: 0x040002A7 RID: 679
	private uint uint_4;

	// Token: 0x040002A8 RID: 680
	private uint[] uint_5 = new uint[80];

	// Token: 0x040002A9 RID: 681
	private int int_1;
}
