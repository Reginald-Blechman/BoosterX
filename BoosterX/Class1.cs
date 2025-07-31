using System;

// Token: 0x02000005 RID: 5
internal sealed class Class1 : Interface3
{
	// Token: 0x06000025 RID: 37 RVA: 0x00021B24 File Offset: 0x0001FD24
	public Class1(Interface3 interface3_1)
	{
		this.interface3_0 = interface3_1;
		this.int_0 = interface3_1.imethod_2();
		this.byte_0 = new byte[this.int_0];
		this.byte_1 = new byte[this.int_0];
		this.byte_2 = new byte[this.int_0];
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00003036 File Offset: 0x00001236
	public Interface3 method_0()
	{
		return this.interface3_0;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00021B80 File Offset: 0x0001FD80
	public void imethod_1(bool bool_1, Interface2 interface2_0)
	{
		this.bool_0 = bool_1;
		if (interface2_0 is Class20)
		{
			Class20 @class = (Class20)interface2_0;
			byte[] array = @class.method_0();
			if (array.Length != this.int_0)
			{
				throw new ArgumentException("initialisation vector must be the same length as block size");
			}
			Array.Copy(array, 0, this.byte_0, 0, array.Length);
			interface2_0 = @class.method_1();
		}
		this.imethod_5();
		this.interface3_0.imethod_1(this.bool_0, interface2_0);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000303E File Offset: 0x0000123E
	public string imethod_0()
	{
		return this.interface3_0.imethod_0() + "/CBC";
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00003056 File Offset: 0x00001256
	public bool imethod_3()
	{
		return false;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00003059 File Offset: 0x00001259
	public int imethod_2()
	{
		return this.interface3_0.imethod_2();
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00003066 File Offset: 0x00001266
	public int imethod_4(byte[] byte_3, int int_1, byte[] byte_4, int int_2)
	{
		if (!this.bool_0)
		{
			return this.method_2(byte_3, int_1, byte_4, int_2);
		}
		return this.method_1(byte_3, int_1, byte_4, int_2);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00003087 File Offset: 0x00001287
	public void imethod_5()
	{
		Array.Copy(this.byte_0, 0, this.byte_1, 0, this.byte_0.Length);
		Array.Clear(this.byte_2, 0, this.byte_2.Length);
		this.interface3_0.imethod_5();
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00021BF4 File Offset: 0x0001FDF4
	private int method_1(byte[] byte_3, int int_1, byte[] byte_4, int int_2)
	{
		if (int_1 + this.int_0 > byte_3.Length)
		{
			throw new Exception1("input buffer too short");
		}
		for (int i = 0; i < this.int_0; i++)
		{
			byte[] array = this.byte_1;
			int num = i;
			array[num] ^= byte_3[int_1 + i];
		}
		int result = this.interface3_0.imethod_4(this.byte_1, 0, byte_4, int_2);
		Array.Copy(byte_4, int_2, this.byte_1, 0, this.byte_1.Length);
		return result;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00021C70 File Offset: 0x0001FE70
	private int method_2(byte[] byte_3, int int_1, byte[] byte_4, int int_2)
	{
		if (int_1 + this.int_0 > byte_3.Length)
		{
			throw new Exception1("input buffer too short");
		}
		Array.Copy(byte_3, int_1, this.byte_2, 0, this.int_0);
		int result = this.interface3_0.imethod_4(byte_3, int_1, byte_4, int_2);
		for (int i = 0; i < this.int_0; i++)
		{
			int num = int_2 + i;
			byte_4[num] ^= this.byte_1[i];
		}
		byte[] array = this.byte_1;
		this.byte_1 = this.byte_2;
		this.byte_2 = array;
		return result;
	}

	// Token: 0x04000009 RID: 9
	private byte[] byte_0;

	// Token: 0x0400000A RID: 10
	private byte[] byte_1;

	// Token: 0x0400000B RID: 11
	private byte[] byte_2;

	// Token: 0x0400000C RID: 12
	private int int_0;

	// Token: 0x0400000D RID: 13
	private Interface3 interface3_0;

	// Token: 0x0400000E RID: 14
	private bool bool_0;
}
