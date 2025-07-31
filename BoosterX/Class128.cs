using System;

// Token: 0x020000C5 RID: 197
internal sealed class Class128
{
	// Token: 0x060005B3 RID: 1459 RVA: 0x00039058 File Offset: 0x00037258
	static Class128()
	{
		Class128.class128_0 = new Class128(0, Class128.int_0, false);
		Class128.class128_0.int_3 = 0;
		Class128.class128_1 = Class128.smethod_17(1UL);
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x000390BC File Offset: 0x000372BC
	public Class128(int int_5, int[] int_6, bool bool_0)
	{
		if (!bool_0)
		{
			this.int_2 = int_5;
			this.int_1 = int_6;
			return;
		}
		int num = 0;
		while (num < int_6.Length && int_6[num] == 0)
		{
			num++;
		}
		if (num == int_6.Length)
		{
			this.int_2 = 0;
			this.int_1 = Class128.int_0;
			return;
		}
		this.int_2 = int_5;
		if (num == 0)
		{
			this.int_1 = int_6;
			return;
		}
		this.int_1 = new int[int_6.Length - num];
		Array.Copy(int_6, num, this.int_1, 0, this.int_1.Length);
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00005AF4 File Offset: 0x00003CF4
	public Class128(int int_5, byte[] byte_1) : this(int_5, byte_1, 0, byte_1.Length)
	{
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0003914C File Offset: 0x0003734C
	public Class128(int int_5, byte[] byte_1, int int_6, int int_7)
	{
		if (int_5 == 0)
		{
			this.int_2 = 0;
			this.int_1 = Class128.int_0;
			return;
		}
		this.int_1 = Class128.smethod_1(byte_1, int_6, int_7);
		this.int_2 = ((this.int_1.Length < 1) ? 0 : int_5);
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00005B02 File Offset: 0x00003D02
	public int[] method_0()
	{
		return this.int_1;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00005B0A File Offset: 0x00003D0A
	private static int smethod_0(int int_5)
	{
		return (int_5 + 8 - 1) / 8;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x000391A0 File Offset: 0x000373A0
	private static int[] smethod_1(byte[] byte_1, int int_5, int int_6)
	{
		int num = int_5 + int_6;
		int num2 = int_5;
		while (num2 < num && byte_1[num2] == 0)
		{
			num2++;
		}
		if (num2 >= num)
		{
			return Class128.int_0;
		}
		int num3 = (num - num2 + 3) / 4;
		int num4 = (num - num2) % 4;
		if (num4 == 0)
		{
			num4 = 4;
		}
		if (num3 < 1)
		{
			return Class128.int_0;
		}
		int[] array = new int[num3];
		int num5 = 0;
		int num6 = 0;
		for (int i = num2; i < num; i++)
		{
			num5 <<= 8;
			num5 |= (int)(byte_1[i] & byte.MaxValue);
			num4--;
			if (num4 <= 0)
			{
				array[num6] = num5;
				num6++;
				num4 = 4;
				num5 = 0;
			}
		}
		if (num6 < array.Length)
		{
			array[num6] = num5;
		}
		return array;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00039244 File Offset: 0x00037444
	private static int smethod_2(int int_5, int int_6, int[] int_7)
	{
		while (int_6 < int_7.Length)
		{
			if (int_7[int_6] != 0)
			{
				int num = 32 * (int_7.Length - int_6 - 1);
				int int_8 = int_7[int_6];
				return num + Class128.smethod_3(int_8);
			}
			int_6++;
		}
		return 0;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00005B13 File Offset: 0x00003D13
	public int method_1()
	{
		if (this.int_3 == -1)
		{
			this.int_3 = ((this.int_2 == 0) ? 0 : Class128.smethod_2(this.int_2, 0, this.int_1));
		}
		return this.int_3;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0003927C File Offset: 0x0003747C
	private static int smethod_3(int int_5)
	{
		uint num = (uint)int_5 >> 24;
		if (num != 0U)
		{
			return (int)(24 + Class128.byte_0[(int)num]);
		}
		num = (uint)int_5 >> 16;
		if (num != 0U)
		{
			return (int)(16 + Class128.byte_0[(int)num]);
		}
		num = (uint)int_5 >> 8;
		if (num != 0U)
		{
			return (int)(8 + Class128.byte_0[(int)num]);
		}
		return (int)Class128.byte_0[int_5];
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00005B47 File Offset: 0x00003D47
	public int method_2(object object_0)
	{
		return this.method_3((Class128)object_0);
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x00005B55 File Offset: 0x00003D55
	private static int smethod_4(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		while (int_5 != int_6.Length && int_6[int_5] == 0)
		{
			int_5++;
		}
		while (int_7 != int_8.Length && int_8[int_7] == 0)
		{
			int_7++;
		}
		return Class128.smethod_5(int_5, int_6, int_7, int_8);
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x000392CC File Offset: 0x000374CC
	private static int smethod_5(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		int num = int_6.Length - int_8.Length - (int_5 - int_7);
		if (num == 0)
		{
			while (int_5 < int_6.Length)
			{
				uint num2 = (uint)int_6[int_5++];
				uint num3 = (uint)int_8[int_7++];
				if (num2 != num3)
				{
					if (num2 >= num3)
					{
						return 1;
					}
					return -1;
				}
			}
			return 0;
		}
		if (num >= 0)
		{
			return 1;
		}
		return -1;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0003931C File Offset: 0x0003751C
	public int method_3(Class128 class128_2)
	{
		if (this.int_2 < class128_2.int_2)
		{
			return -1;
		}
		if (this.int_2 > class128_2.int_2)
		{
			return 1;
		}
		if (this.int_2 != 0)
		{
			return this.int_2 * Class128.smethod_5(0, this.int_1, 0, class128_2.int_1);
		}
		return 0;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00039370 File Offset: 0x00037570
	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		Class128 @class = obj as Class128;
		return @class != null && this.int_2 == @class.int_2 && this.method_4(@class);
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x000393A8 File Offset: 0x000375A8
	public override int GetHashCode()
	{
		int num = this.int_1.Length;
		if (this.int_1.Length != 0)
		{
			num ^= this.int_1[0];
			if (this.int_1.Length > 1)
			{
				num ^= this.int_1[this.int_1.Length - 1];
			}
		}
		return num;
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x000393F4 File Offset: 0x000375F4
	private bool method_4(Class128 class128_2)
	{
		if (this.int_1.Length != class128_2.int_1.Length)
		{
			return false;
		}
		for (int i = 0; i < this.int_1.Length; i++)
		{
			if (this.int_1[i] != class128_2.int_1[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x00039440 File Offset: 0x00037640
	public Class128 method_5(Class128 class128_2, Class128 class128_3)
	{
		if (class128_3.Equals(Class128.class128_1))
		{
			return Class128.class128_0;
		}
		if (class128_2.int_2 == 0)
		{
			return Class128.class128_1;
		}
		if (this.int_2 == 0)
		{
			return Class128.class128_0;
		}
		Class128 @class = this;
		if (!class128_2.Equals(Class128.class128_1))
		{
			@class = Class128.smethod_6(@class, class128_2.int_1[0], class128_3);
		}
		return @class;
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x0003949C File Offset: 0x0003769C
	private static Class128 smethod_6(Class128 class128_2, int int_5, Class128 class128_3)
	{
		int num = class128_3.int_1.Length;
		int num2 = 32 * num;
		bool bool_ = class128_3.method_1() + 2 <= num2;
		uint uint_ = (uint)class128_3.method_6();
		class128_2 = class128_2.method_7(num2).method_12(class128_3);
		int[] int_6 = new int[num + 1];
		int[] array = class128_2.int_1;
		if (array.Length < num)
		{
			int[] array2 = new int[num];
			Buffer.BlockCopy(array, 0, array2, num - array.Length, array.Length * 4);
			array = array2;
		}
		int[] array3 = Class128.smethod_20(array);
		Class128.smethod_10(int_6, array3, class128_3.int_1, uint_, bool_);
		int[] array4 = Class128.smethod_12(int_5);
		int num3 = array4[0];
		int num4 = num3 >> 8;
		num4--;
		int num5 = 1;
		while ((num3 = array4[num5++]) != -1)
		{
			int num6 = num4 + 1;
			for (int i = 0; i < num6; i++)
			{
				Class128.smethod_10(int_6, array3, class128_3.int_1, uint_, bool_);
			}
			Class128.smethod_9(int_6, array3, array, class128_3.int_1, uint_, bool_);
			num4 = num3 >> 8;
		}
		for (int j = 0; j < num4; j++)
		{
			Class128.smethod_10(int_6, array3, class128_3.int_1, uint_, bool_);
		}
		Class128.smethod_8(array3, class128_3.int_1, uint_);
		return new Class128(1, array3, true);
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x000395D8 File Offset: 0x000377D8
	private static int smethod_7(int int_5)
	{
		int num = int_5 + ((int_5 + 1 & 4) << 1);
		num *= 2 - int_5 * num;
		num *= 2 - int_5 * num;
		return num * (2 - int_5 * num);
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00039608 File Offset: 0x00037808
	private int method_6()
	{
		if (this.int_4 != 0)
		{
			return this.int_4;
		}
		int int_ = -this.int_1[this.int_1.Length - 1];
		return this.int_4 = Class128.smethod_7(int_);
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00039648 File Offset: 0x00037848
	private static void smethod_8(int[] int_5, int[] int_6, uint uint_0)
	{
		int num = int_6.Length;
		for (int i = num - 1; i >= 0; i--)
		{
			uint num2 = (uint)int_5[num - 1];
			ulong num3 = (ulong)(num2 * uint_0);
			ulong num4 = num3 * (ulong)int_6[num - 1] + (ulong)num2;
			num4 >>= 32;
			for (int j = num - 2; j >= 0; j--)
			{
				num4 += num3 * (ulong)int_6[j] + (ulong)int_5[j];
				int_5[j + 1] = (int)num4;
				num4 >>= 32;
			}
			int_5[0] = (int)num4;
		}
		if (Class128.smethod_4(0, int_5, 0, int_6) >= 0)
		{
			Class128.smethod_16(0, int_5, 0, int_6);
		}
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x000396CC File Offset: 0x000378CC
	private static void smethod_9(int[] int_5, int[] int_6, int[] int_7, int[] int_8, uint uint_0, bool bool_0)
	{
		int num = int_8.Length;
		if (num == 1)
		{
			int_6[0] = (int)Class128.smethod_11((uint)int_6[0], (uint)int_7[0], (uint)int_8[0], uint_0);
			return;
		}
		uint num2 = (uint)int_7[num - 1];
		ulong num3 = (ulong)int_6[num - 1];
		ulong num4 = num3 * (ulong)num2;
		ulong num5 = (ulong)((uint)num4 * uint_0);
		ulong num6 = num5 * (ulong)int_8[num - 1];
		num4 += (ulong)((uint)num6);
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int i = num - 2; i >= 0; i--)
		{
			ulong num7 = num3 * (ulong)int_7[i];
			num6 = num5 * (ulong)int_8[i];
			num4 += (num7 & 4294967295UL) + (ulong)((uint)num6);
			int_5[i + 2] = (int)num4;
			num4 = (num4 >> 32) + (num7 >> 32) + (num6 >> 32);
		}
		int_5[1] = (int)num4;
		int num8 = (int)(num4 >> 32);
		for (int j = num - 2; j >= 0; j--)
		{
			uint num9 = (uint)int_5[num];
			ulong num10 = (ulong)int_6[j];
			ulong num11 = num10 * (ulong)num2;
			ulong num12 = (num11 & 4294967295UL) + (ulong)num9;
			ulong num13 = (ulong)((uint)num12 * uint_0);
			ulong num14 = num13 * (ulong)int_8[num - 1];
			num12 += (ulong)((uint)num14);
			num12 = (num12 >> 32) + (num11 >> 32) + (num14 >> 32);
			for (int k = num - 2; k >= 0; k--)
			{
				num11 = num10 * (ulong)int_7[k];
				num14 = num13 * (ulong)int_8[k];
				num12 += (num11 & 4294967295UL) + (ulong)((uint)num14) + (ulong)int_5[k + 1];
				int_5[k + 2] = (int)num12;
				num12 = (num12 >> 32) + (num11 >> 32) + (num14 >> 32);
			}
			num12 += (ulong)num8;
			int_5[1] = (int)num12;
			num8 = (int)(num12 >> 32);
		}
		int_5[0] = num8;
		if (!bool_0 && Class128.smethod_4(0, int_5, 0, int_8) >= 0)
		{
			Class128.smethod_16(0, int_5, 0, int_8);
		}
		Array.Copy(int_5, 1, int_6, 0, num);
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00039888 File Offset: 0x00037A88
	private static void smethod_10(int[] int_5, int[] int_6, int[] int_7, uint uint_0, bool bool_0)
	{
		int num = int_7.Length;
		if (num == 1)
		{
			uint num2 = (uint)int_6[0];
			int_6[0] = (int)Class128.smethod_11(num2, num2, (uint)int_7[0], uint_0);
			return;
		}
		ulong num3 = (ulong)int_6[num - 1];
		ulong num4 = num3 * num3;
		ulong num5 = (ulong)((uint)num4 * uint_0);
		ulong num6 = num5 * (ulong)int_7[num - 1];
		num4 += (ulong)((uint)num6);
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int i = num - 2; i >= 0; i--)
		{
			ulong num7 = num3 * (ulong)int_6[i];
			num6 = num5 * (ulong)int_7[i];
			num4 += (num6 & 4294967295UL) + (ulong)((ulong)((uint)num7) << 1);
			int_5[i + 2] = (int)num4;
			num4 = (num4 >> 32) + (num7 >> 31) + (num6 >> 32);
		}
		int_5[1] = (int)num4;
		int num8 = (int)(num4 >> 32);
		for (int j = num - 2; j >= 0; j--)
		{
			uint num9 = (uint)int_5[num];
			ulong num10 = (ulong)(num9 * uint_0);
			ulong num11 = num10 * (ulong)int_7[num - 1] + (ulong)num9;
			num11 >>= 32;
			for (int k = num - 2; k > j; k--)
			{
				num11 += num10 * (ulong)int_7[k] + (ulong)int_5[k + 1];
				int_5[k + 2] = (int)num11;
				num11 >>= 32;
			}
			ulong num12 = (ulong)int_6[j];
			ulong num13 = num12 * num12;
			ulong num14 = num10 * (ulong)int_7[j];
			num11 += (num13 & 4294967295UL) + (ulong)((uint)num14) + (ulong)int_5[j + 1];
			int_5[j + 2] = (int)num11;
			num11 = (num11 >> 32) + (num13 >> 32) + (num14 >> 32);
			for (int l = j - 1; l >= 0; l--)
			{
				ulong num15 = num12 * (ulong)int_6[l];
				ulong num16 = num10 * (ulong)int_7[l];
				num11 += (num16 & 4294967295UL) + (ulong)((ulong)((uint)num15) << 1) + (ulong)int_5[l + 1];
				int_5[l + 2] = (int)num11;
				num11 = (num11 >> 32) + (num15 >> 31) + (num16 >> 32);
			}
			num11 += (ulong)num8;
			int_5[1] = (int)num11;
			num8 = (int)(num11 >> 32);
		}
		int_5[0] = num8;
		if (!bool_0 && Class128.smethod_4(0, int_5, 0, int_7) >= 0)
		{
			Class128.smethod_16(0, int_5, 0, int_7);
		}
		Array.Copy(int_5, 1, int_6, 0, num);
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00039A8C File Offset: 0x00037C8C
	private static uint smethod_11(uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		ulong num = (ulong)uint_0 * (ulong)uint_1;
		uint num2 = (uint)num * uint_3;
		ulong num3 = (ulong)uint_2;
		ulong num4 = num3 * (ulong)num2;
		num += (ulong)((uint)num4);
		num = (num >> 32) + (num4 >> 32);
		if (num > num3)
		{
			num -= num3;
		}
		return (uint)num;
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00039AC8 File Offset: 0x00037CC8
	private static int[] smethod_12(int int_5)
	{
		int num = Class128.smethod_3(int_5);
		int[] array = new int[num + 2];
		int num2 = 0;
		int i = 33 - num;
		int_5 <<= i;
		int num3 = 0;
		while (i < 32)
		{
			if (int_5 < 0)
			{
				array[num2++] = (1 | num3 << 8);
				num3 = 0;
			}
			else
			{
				num3++;
			}
			int_5 <<= 1;
			i++;
		}
		array[num2++] = (1 | num3 << 8);
		array[num2] = -1;
		return array;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00039B38 File Offset: 0x00037D38
	private static int[] smethod_13(int[] int_5, int int_6)
	{
		int num = (int)((uint)int_6 >> 5);
		int num2 = int_6 & 31;
		int num3 = int_5.Length;
		int[] array;
		if (num2 == 0)
		{
			array = new int[num3 + num];
			int_5.CopyTo(array, 0);
		}
		else
		{
			int num4 = 0;
			int num5 = 32 - num2;
			int num6 = (int)((uint)int_5[0] >> num5);
			if (num6 != 0)
			{
				array = new int[num3 + num + 1];
				array[num4++] = num6;
			}
			else
			{
				array = new int[num3 + num];
			}
			int num7 = int_5[0];
			for (int i = 0; i < num3 - 1; i++)
			{
				int num8 = int_5[i + 1];
				array[num4++] = (num7 << num2 | (int)((uint)num8 >> num5));
				num7 = num8;
			}
			array[num4] = int_5[num3 - 1] << num2;
		}
		return array;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00039BEC File Offset: 0x00037DEC
	private Class128 method_7(int int_5)
	{
		if (this.int_2 == 0 || this.int_1.Length == 0)
		{
			return Class128.class128_0;
		}
		if (int_5 == 0)
		{
			return this;
		}
		Class128 @class = new Class128(this.int_2, Class128.smethod_13(this.int_1, int_5), true);
		if (this.int_3 != -1)
		{
			@class.int_3 = this.int_3 + int_5;
		}
		return @class;
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00039C48 File Offset: 0x00037E48
	private static void smethod_14(int int_5, int[] int_6, int int_7)
	{
		int num = (int)(((uint)int_7 >> 5) + (uint)int_5);
		int num2 = int_7 & 31;
		int num3 = int_6.Length - 1;
		if (num != int_5)
		{
			int num4 = num - int_5;
			for (int i = num3; i >= num; i--)
			{
				int_6[i] = int_6[i - num4];
			}
			for (int j = num - 1; j >= int_5; j--)
			{
				int_6[j] = 0;
			}
		}
		if (num2 != 0)
		{
			int num5 = 32 - num2;
			int num6 = int_6[num3];
			for (int k = num3; k > num; k--)
			{
				int num7 = int_6[k - 1];
				int_6[k] = (int)((uint)num6 >> num2 | (uint)((uint)num7 << num5));
				num6 = num7;
			}
			int_6[num] = (int)((uint)int_6[num] >> num2);
		}
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00039CE4 File Offset: 0x00037EE4
	private static void smethod_15(int int_5, int[] int_6)
	{
		int num = int_6.Length;
		int num2 = int_6[num - 1];
		while (--num > int_5)
		{
			int num3 = int_6[num - 1];
			int_6[num] = (int)((uint)num2 >> 1 | (uint)((uint)num3 << 31));
			num2 = num3;
		}
		int_6[int_5] = (int)((uint)int_6[int_5] >> 1);
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00005B8B File Offset: 0x00003D8B
	public int method_8()
	{
		return this.int_2;
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00039D20 File Offset: 0x00037F20
	private static int[] smethod_16(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		int num = int_6.Length;
		int num2 = int_8.Length;
		int num3 = 0;
		do
		{
			long num4 = ((long)int_6[--num] & 4294967295L) - ((long)int_8[--num2] & 4294967295L) + (long)num3;
			int_6[num] = (int)num4;
			num3 = (int)(num4 >> 63);
		}
		while (num2 > int_7);
		if (num3 != 0)
		{
			int num6;
			do
			{
				int num5 = --num;
				num6 = int_6[num5] - 1;
				int_6[num5] = num6;
			}
			while (num6 == -1);
		}
		return int_6;
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00039D8C File Offset: 0x00037F8C
	public byte[] method_9()
	{
		if (this.int_2 == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[Class128.smethod_0(this.method_1())];
		this.method_11(array, 0);
		return array;
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00005B93 File Offset: 0x00003D93
	public int method_10()
	{
		return this.method_11(null, 0);
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00039DC4 File Offset: 0x00037FC4
	public int method_11(byte[] byte_1, int int_5)
	{
		if (this.int_2 == 0)
		{
			return 0;
		}
		int num = Class128.smethod_0(this.method_1());
		if (byte_1 == null)
		{
			return num;
		}
		int i = this.int_1.Length;
		int num2 = int_5 + num;
		if (num2 > byte_1.Length)
		{
			throw new IndexOutOfRangeException();
		}
		while (i > 1)
		{
			uint num3 = (uint)this.int_1[--i];
			byte_1[--num2] = (byte)num3;
			byte_1[--num2] = (byte)(num3 >> 8);
			byte_1[--num2] = (byte)(num3 >> 16);
			byte_1[--num2] = (byte)(num3 >> 24);
		}
		uint num4;
		for (num4 = (uint)this.int_1[0]; num4 > 255U; num4 >>= 8)
		{
			byte_1[--num2] = (byte)num4;
		}
		byte_1[num2 - 1] = (byte)num4;
		return num;
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00039E70 File Offset: 0x00038070
	private static Class128 smethod_17(ulong ulong_0)
	{
		int num = (int)(ulong_0 >> 32);
		int num2 = (int)ulong_0;
		if (num != 0)
		{
			return new Class128(1, new int[]
			{
				num,
				num2
			}, false);
		}
		if (num2 != 0)
		{
			return new Class128(1, new int[]
			{
				num2
			}, false);
		}
		return Class128.class128_0;
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00005B9D File Offset: 0x00003D9D
	public static Class128 smethod_18(ulong ulong_0)
	{
		return Class128.smethod_17(ulong_0);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00039EBC File Offset: 0x000380BC
	private static int[] smethod_19(int[] int_5, int[] int_6)
	{
		int num = 0;
		while (num < int_5.Length && int_5[num] == 0)
		{
			num++;
		}
		int num2 = 0;
		while (num2 < int_6.Length && int_6[num2] == 0)
		{
			num2++;
		}
		int num3 = Class128.smethod_5(num, int_5, num2, int_6);
		if (num3 > 0)
		{
			int num4 = Class128.smethod_2(1, num2, int_6);
			int num5 = Class128.smethod_2(1, num, int_5);
			int num6 = num5 - num4;
			int num7 = 0;
			int num8 = num4;
			int[] array;
			if (num6 > 0)
			{
				array = Class128.smethod_13(int_6, num6);
				num8 += num6;
			}
			else
			{
				int num9 = int_6.Length - num2;
				array = new int[num9];
				Array.Copy(int_6, num2, array, 0, num9);
			}
			for (;;)
			{
				if (num8 < num5)
				{
					goto IL_92;
				}
				if (Class128.smethod_5(num, int_5, num7, array) >= 0)
				{
					goto IL_92;
				}
				IL_E4:
				num6 = num8 - num5;
				if (num6 == 1)
				{
					uint num10 = (uint)array[num7] >> 1;
					uint num11 = (uint)int_5[num];
					if (num10 > num11)
					{
						num6++;
					}
				}
				if (num6 < 2)
				{
					Class128.smethod_15(num7, array);
					num8--;
				}
				else
				{
					Class128.smethod_14(num7, array, num6);
					num8 -= num6;
				}
				while (array[num7] == 0)
				{
					num7++;
				}
				continue;
				IL_92:
				Class128.smethod_16(num, int_5, num7, array);
				while (int_5[num] == 0)
				{
					if (++num == int_5.Length)
					{
						return int_5;
					}
				}
				num5 = 32 * (int_5.Length - num - 1) + Class128.smethod_3(int_5[num]);
				if (num5 > num4)
				{
					goto IL_E4;
				}
				if (num5 < num4)
				{
					return int_5;
				}
				num3 = Class128.smethod_5(num, int_5, num2, int_6);
				if (num3 > 0)
				{
					goto IL_E4;
				}
				goto IL_153;
			}
			return int_5;
		}
		IL_153:
		if (num3 == 0)
		{
			Array.Clear(int_5, num, int_5.Length - num);
		}
		return int_5;
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0003A030 File Offset: 0x00038230
	private Class128 method_12(Class128 class128_2)
	{
		if (this.int_2 == 0)
		{
			return Class128.class128_0;
		}
		if (Class128.smethod_5(0, this.int_1, 0, class128_2.int_1) < 0)
		{
			return this;
		}
		int[] array = (int[])this.int_1.Clone();
		array = Class128.smethod_19(array, class128_2.int_1);
		return new Class128(this.int_2, array, true);
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0003A090 File Offset: 0x00038290
	private static int[] smethod_20(int[] int_5)
	{
		int[] array = new int[int_5.Length];
		Buffer.BlockCopy(int_5, 0, array, 0, int_5.Length * 4);
		return array;
	}

	// Token: 0x0400031B RID: 795
	private static readonly int[] int_0 = new int[0];

	// Token: 0x0400031C RID: 796
	public static readonly Class128 class128_0;

	// Token: 0x0400031D RID: 797
	public static readonly Class128 class128_1;

	// Token: 0x0400031E RID: 798
	private static readonly byte[] byte_0 = new byte[]
	{
		0,
		1,
		2,
		2,
		3,
		3,
		3,
		3,
		4,
		4,
		4,
		4,
		4,
		4,
		4,
		4,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8
	};

	// Token: 0x0400031F RID: 799
	private int[] int_1;

	// Token: 0x04000320 RID: 800
	private int int_2;

	// Token: 0x04000321 RID: 801
	private int int_3 = -1;

	// Token: 0x04000322 RID: 802
	private int int_4;
}
