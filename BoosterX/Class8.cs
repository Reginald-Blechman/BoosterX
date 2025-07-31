using System;
using System.IO;
using System.Text;

// Token: 0x02000013 RID: 19
internal sealed class Class8 : IDisposable
{
	// Token: 0x0600005F RID: 95 RVA: 0x0000333A File Offset: 0x0000153A
	public Class8(Class97 class97_1) : this(class97_1, new UTF8Encoding())
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00022510 File Offset: 0x00020710
	private Class8(Class97 class97_1, Encoding encoding_0)
	{
		if (class97_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (encoding_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (!class97_1.vmethod_0())
		{
			throw new ArgumentException();
		}
		this.class97_0 = class97_1;
		this.decoder_0 = encoding_0.GetDecoder();
		this.int_0 = encoding_0.GetMaxCharCount(128);
		int num = encoding_0.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		this.byte_0 = new byte[num];
		this.char_1 = null;
		this.byte_1 = null;
		this.bool_0 = (encoding_0 is UnicodeEncoding);
		this.bool_1 = (this.class97_0 is Class98);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00003348 File Offset: 0x00001548
	public Class97 method_0()
	{
		return this.class97_0;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003350 File Offset: 0x00001550
	public void method_1()
	{
		this.method_2(true);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000225B4 File Offset: 0x000207B4
	private void method_2(bool bool_2)
	{
		if (bool_2)
		{
			Class97 @class = this.class97_0;
			this.class97_0 = null;
			if (@class != null)
			{
				@class.vmethod_6();
			}
		}
		this.class97_0 = null;
		this.byte_0 = null;
		this.decoder_0 = null;
		this.byte_1 = null;
		this.char_0 = null;
		this.char_1 = null;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003350 File Offset: 0x00001550
	void IDisposable.Dispose()
	{
		this.method_2(true);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00022608 File Offset: 0x00020808
	public int method_3()
	{
		this.method_15();
		if (!this.class97_0.vmethod_2())
		{
			return -1;
		}
		long long_ = this.class97_0.vmethod_4();
		int result = this.method_4();
		this.class97_0.vmethod_5(long_);
		return result;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00003359 File Offset: 0x00001559
	public int method_4()
	{
		this.method_15();
		return this.method_12();
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003367 File Offset: 0x00001567
	public bool method_5()
	{
		this.method_17(1);
		return this.byte_0[0] > 0;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x0000337B File Offset: 0x0000157B
	public byte method_6()
	{
		this.method_15();
		int num = this.class97_0.vmethod_12();
		if (num == -1)
		{
			throw new Exception();
		}
		return (byte)num;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003399 File Offset: 0x00001599
	public sbyte method_7()
	{
		this.method_17(1);
		return (sbyte)this.byte_0[0];
	}

	// Token: 0x0600006A RID: 106 RVA: 0x000033AB File Offset: 0x000015AB
	public char method_8()
	{
		int num = this.method_4();
		if (num == -1)
		{
			throw new Exception();
		}
		return (char)num;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00022648 File Offset: 0x00020848
	private static decimal smethod_0(int int_1, int int_2, int int_3, int int_4)
	{
		bool isNegative = (int_4 & int.MinValue) != 0;
		byte scale = (byte)(int_4 >> 16);
		return new decimal(int_1, int_2, int_3, isNegative, scale);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00022670 File Offset: 0x00020870
	internal static decimal smethod_1(byte[] byte_3)
	{
		int int_ = (int)byte_3[0] | (int)byte_3[1] << 8 | (int)byte_3[2] << 16 | (int)byte_3[3] << 24;
		int int_2 = (int)byte_3[4] | (int)byte_3[5] << 8 | (int)byte_3[6] << 16 | (int)byte_3[7] << 24;
		int int_3 = (int)byte_3[8] | (int)byte_3[9] << 8 | (int)byte_3[10] << 16 | (int)byte_3[11] << 24;
		int int_4 = (int)byte_3[12] | (int)byte_3[13] << 8 | (int)byte_3[14] << 16 | (int)byte_3[15] << 24;
		return Class8.smethod_0(int_, int_2, int_3, int_4);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000226EC File Offset: 0x000208EC
	public string method_9()
	{
		int num = 0;
		this.method_15();
		int num2 = this.method_18();
		if (num2 < 0)
		{
			throw new IOException();
		}
		if (num2 == 0)
		{
			return string.Empty;
		}
		if (this.byte_1 == null)
		{
			this.byte_1 = new byte[128];
		}
		if (this.char_1 == null)
		{
			this.char_1 = new char[this.int_0];
		}
		StringBuilder stringBuilder = null;
		int chars;
		for (;;)
		{
			int int_ = (num2 - num > 128) ? 128 : (num2 - num);
			int num3 = this.class97_0.vmethod_11(this.byte_1, 0, int_);
			if (num3 == 0)
			{
				goto IL_D0;
			}
			chars = this.decoder_0.GetChars(this.byte_1, 0, num3, this.char_1, 0);
			if (num == 0 && num3 == num2)
			{
				break;
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(num2);
			}
			stringBuilder.Append(this.char_1, 0, chars);
			num += num3;
			if (num >= num2)
			{
				goto Block_9;
			}
		}
		return new string(this.char_1, 0, chars);
		Block_9:
		return stringBuilder.ToString();
		IL_D0:
		throw new Exception();
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000227E4 File Offset: 0x000209E4
	public int method_10(char[] char_2, int int_1, int int_2)
	{
		if (char_2 == null)
		{
			throw new ArgumentNullException("#=zPWibic8=", "ArgumentNull_Buffer");
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (char_2.Length - int_1 < int_2)
		{
			throw new ArgumentException();
		}
		this.method_15();
		return this.method_11(char_2, int_1, int_2);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00022838 File Offset: 0x00020A38
	private int method_11(char[] char_2, int int_1, int int_2)
	{
		int i = int_2;
		if (this.byte_1 == null)
		{
			this.byte_1 = new byte[128];
		}
		while (i > 0)
		{
			int num = i;
			if (this.bool_0)
			{
				num <<= 1;
			}
			if (num > 128)
			{
				num = 128;
			}
			int chars;
			if (this.bool_1)
			{
				Class98 @class = (Class98)this.class97_0;
				int byteIndex = @class.method_3();
				num = @class.method_4(num);
				if (num == 0)
				{
					return int_2 - i;
				}
				chars = this.decoder_0.GetChars(@class.method_1(), byteIndex, num, char_2, int_1);
			}
			else
			{
				num = this.class97_0.vmethod_11(this.byte_1, 0, num);
				if (num == 0)
				{
					return int_2 - i;
				}
				chars = this.decoder_0.GetChars(this.byte_1, 0, num, char_2, int_1);
			}
			i -= chars;
			int_1 += chars;
		}
		return int_2;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00022910 File Offset: 0x00020B10
	private int method_12()
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		num3 = num2;
		if (this.class97_0.vmethod_2())
		{
			num3 = this.class97_0.vmethod_4();
		}
		if (this.byte_1 == null)
		{
			this.byte_1 = new byte[128];
		}
		if (this.char_0 == null)
		{
			this.char_0 = new char[1];
		}
		while (num == 0)
		{
			int num4 = this.bool_0 ? 2 : 1;
			int num5 = this.class97_0.vmethod_12();
			this.byte_1[0] = (byte)num5;
			if (num5 == -1)
			{
				num4 = 0;
			}
			if (num4 == 2)
			{
				num5 = this.class97_0.vmethod_12();
				this.byte_1[1] = (byte)num5;
				if (num5 == -1)
				{
					num4 = 1;
				}
			}
			if (num4 == 0)
			{
				return -1;
			}
			try
			{
				num = this.decoder_0.GetChars(this.byte_1, 0, num4, this.char_0, 0);
			}
			catch
			{
				if (this.class97_0.vmethod_2())
				{
					this.class97_0.vmethod_9(num3 - this.class97_0.vmethod_4(), 1);
				}
				throw;
			}
		}
		if (num == 0)
		{
			return -1;
		}
		return (int)this.char_0[0];
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00022A3C File Offset: 0x00020C3C
	public char[] method_13(int int_1)
	{
		this.method_15();
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		char[] array = new char[int_1];
		int num = this.method_11(array, 0, int_1);
		if (num != int_1)
		{
			char[] array2 = new char[num];
			Buffer.BlockCopy(array, 0, array2, 0, 2 * num);
			array = array2;
		}
		return array;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00022A84 File Offset: 0x00020C84
	public int method_14(byte[] byte_3, int int_1, int int_2)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_3.Length - int_1 < int_2)
		{
			throw new ArgumentException();
		}
		this.method_15();
		return this.class97_0.vmethod_11(byte_3, int_1, int_2);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x000033BE File Offset: 0x000015BE
	private void method_15()
	{
		if (this.class97_0 == null)
		{
			throw new Exception();
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00022AD0 File Offset: 0x00020CD0
	public byte[] method_16(int int_1)
	{
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.method_15();
		byte[] array = new byte[int_1];
		int num = 0;
		do
		{
			int num2 = this.class97_0.vmethod_11(array, num, int_1);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			int_1 -= num2;
		}
		while (int_1 > 0);
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00022B34 File Offset: 0x00020D34
	private void method_17(int int_1)
	{
		this.method_15();
		int num = 0;
		int num2;
		if (int_1 != 1)
		{
			for (;;)
			{
				num2 = this.class97_0.vmethod_11(this.byte_0, num, int_1 - num);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				if (num >= int_1)
				{
					return;
				}
			}
			throw new Exception();
		}
		num2 = this.class97_0.vmethod_12();
		if (num2 == -1)
		{
			throw new Exception();
		}
		this.byte_0[0] = (byte)num2;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00022B98 File Offset: 0x00020D98
	internal int method_18()
	{
		int num = 0;
		int num2 = 0;
		while (num2 != 35)
		{
			byte b = this.method_6();
			num |= (int)(b & 127) << num2;
			num2 += 7;
			if ((b & 128) == 0)
			{
				return num;
			}
		}
		throw new FormatException();
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00022BD8 File Offset: 0x00020DD8
	public int method_19()
	{
		if (this.bool_1)
		{
			return ((Class98)this.class97_0).method_9();
		}
		this.method_17(4);
		return (int)this.byte_0[0] | (int)this.byte_0[3] << 24 | (int)this.byte_0[1] << 16 | (int)this.byte_0[2] << 8;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000033CE File Offset: 0x000015CE
	public uint method_20()
	{
		this.method_17(4);
		return (uint)((int)this.byte_0[3] << 16 | (int)this.byte_0[1] | (int)this.byte_0[0] << 8 | (int)this.byte_0[2] << 24);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00022C30 File Offset: 0x00020E30
	public long method_21()
	{
		this.method_17(8);
		byte[] array = this.byte_0;
		return (long)((ulong)((int)array[7] << 8 | (int)array[2] << 24 | (int)array[0] | (int)array[1] << 16) | (ulong)((ulong)((long)((int)array[5] << 24 | (int)array[6] << 16 | (int)array[4] | (int)array[3] << 8)) << 32));
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00022C80 File Offset: 0x00020E80
	public ulong method_22()
	{
		this.method_17(8);
		byte[] array = this.byte_0;
		return (ulong)((int)array[2] << 16 | (int)array[5] << 24 | (int)array[4] << 8 | (int)array[6]) | (ulong)((ulong)((long)((int)array[1] << 16 | (int)array[0] | (int)array[7] << 24 | (int)array[3] << 8)) << 32);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00022CD0 File Offset: 0x00020ED0
	public short method_23()
	{
		this.method_17(2);
		byte[] array = this.byte_0;
		return (short)((int)array[0] << 8 | (int)array[1]);
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00022CF8 File Offset: 0x00020EF8
	public ushort method_24()
	{
		this.method_17(2);
		byte[] array = this.byte_0;
		return (ushort)((int)array[1] | (int)array[0] << 8);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00022D20 File Offset: 0x00020F20
	private byte[] method_25()
	{
		byte[] array = this.byte_2;
		if (array == null)
		{
			array = (this.byte_2 = new byte[16]);
		}
		return array;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00022D48 File Offset: 0x00020F48
	public float method_26()
	{
		this.method_17(4);
		byte[] array = this.byte_0;
		byte[] array2 = this.method_25();
		array2[1] = array[1];
		array2[3] = array[0];
		array2[2] = array[2];
		array2[0] = array[3];
		return this.method_29(array2).ReadSingle();
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00022D90 File Offset: 0x00020F90
	public double method_27()
	{
		this.method_17(8);
		byte[] array = this.byte_0;
		byte[] array2 = this.method_25();
		array2[5] = array[1];
		array2[2] = array[4];
		array2[0] = array[2];
		array2[3] = array[3];
		array2[7] = array[0];
		array2[4] = array[6];
		array2[1] = array[5];
		array2[6] = array[7];
		return this.method_29(array2).ReadDouble();
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00022DF0 File Offset: 0x00020FF0
	public decimal method_28()
	{
		this.method_17(16);
		byte[] array = this.byte_0;
		byte[] array2 = this.method_25();
		array2[14] = array[11];
		array2[5] = array[12];
		array2[7] = array[9];
		array2[6] = array[1];
		array2[10] = array[8];
		array2[11] = array[10];
		array2[8] = array[3];
		array2[0] = array[14];
		array2[4] = array[15];
		array2[3] = array[13];
		array2[1] = array[2];
		array2[2] = array[6];
		array2[15] = array[7];
		array2[9] = array[4];
		array2[12] = array[0];
		array2[13] = array[5];
		return Class8.smethod_1(array2);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00022E88 File Offset: 0x00021088
	private BinaryReader method_29(byte[] byte_3)
	{
		MemoryStream memoryStream = this.memoryStream_0;
		BinaryReader binaryReader = this.binaryReader_0;
		if (memoryStream == null)
		{
			memoryStream = (this.memoryStream_0 = new MemoryStream(8));
			binaryReader = (this.binaryReader_0 = new BinaryReader(memoryStream));
		}
		else
		{
			binaryReader.BaseStream.Position = 0L;
		}
		memoryStream.Write(byte_3, 0, byte_3.Length);
		memoryStream.Position = 0L;
		return binaryReader;
	}

	// Token: 0x04000028 RID: 40
	private Class97 class97_0;

	// Token: 0x04000029 RID: 41
	private byte[] byte_0;

	// Token: 0x0400002A RID: 42
	private Decoder decoder_0;

	// Token: 0x0400002B RID: 43
	private byte[] byte_1;

	// Token: 0x0400002C RID: 44
	private char[] char_0;

	// Token: 0x0400002D RID: 45
	private char[] char_1;

	// Token: 0x0400002E RID: 46
	private int int_0;

	// Token: 0x0400002F RID: 47
	private bool bool_0;

	// Token: 0x04000030 RID: 48
	private bool bool_1;

	// Token: 0x04000031 RID: 49
	private byte[] byte_2;

	// Token: 0x04000032 RID: 50
	private MemoryStream memoryStream_0;

	// Token: 0x04000033 RID: 51
	private BinaryReader binaryReader_0;
}
