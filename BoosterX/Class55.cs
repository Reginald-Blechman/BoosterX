using System;

// Token: 0x0200003E RID: 62
internal class Class55 : Class54
{
	// Token: 0x0600017A RID: 378 RVA: 0x00003D32 File Offset: 0x00001F32
	protected Class55()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00003D3A File Offset: 0x00001F3A
	public Class55(Interface3 interface3_1)
	{
		if (interface3_1 == null)
		{
			throw new ArgumentNullException("cipher");
		}
		this.interface3_0 = interface3_1;
		this.byte_1 = new byte[interface3_1.imethod_2()];
		this.int_0 = 0;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00003D70 File Offset: 0x00001F70
	public override string imethod_0()
	{
		return this.interface3_0.imethod_0();
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00003D7D File Offset: 0x00001F7D
	public override void imethod_1(bool bool_1, Interface2 interface2_0)
	{
		this.bool_0 = bool_1;
		this.imethod_15();
		this.interface3_0.imethod_1(bool_1, interface2_0);
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00003D99 File Offset: 0x00001F99
	public override int imethod_2()
	{
		return this.interface3_0.imethod_2();
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00025B0C File Offset: 0x00023D0C
	public override int imethod_4(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		return num - num2;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00003DA6 File Offset: 0x00001FA6
	public override int imethod_3(int int_1)
	{
		return int_1 + this.int_0;
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00025B30 File Offset: 0x00023D30
	public override byte[] imethod_6(byte[] byte_2, int int_1, int int_2)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException("#=zPWibic8=");
		}
		if (int_2 < 1)
		{
			return null;
		}
		int num = this.imethod_4(int_2);
		byte[] array = (num > 0) ? new byte[num] : null;
		int num2 = this.imethod_8(byte_2, int_1, int_2, array, 0);
		if (num > 0 && num2 < num)
		{
			byte[] array2 = new byte[num2];
			Array.Copy(array, 0, array2, 0, num2);
			array = array2;
		}
		return array;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00025B90 File Offset: 0x00023D90
	public override int imethod_8(byte[] byte_2, int int_1, int int_2, byte[] byte_3, int int_3)
	{
		if (int_2 < 1)
		{
			if (int_2 < 0)
			{
				throw new ArgumentException("Can't have a negative input length!");
			}
			return 0;
		}
		else
		{
			int num = this.imethod_2();
			int num2 = this.imethod_4(int_2);
			if (num2 > 0 && int_3 + num2 > byte_3.Length)
			{
				throw new Exception1("output buffer too short");
			}
			int num3 = 0;
			int num4 = this.byte_1.Length - this.int_0;
			if (int_2 > num4)
			{
				Array.Copy(byte_2, int_1, this.byte_1, this.int_0, num4);
				num3 += this.interface3_0.imethod_4(this.byte_1, 0, byte_3, int_3);
				this.int_0 = 0;
				int_2 -= num4;
				int_1 += num4;
				while (int_2 > this.byte_1.Length)
				{
					num3 += this.interface3_0.imethod_4(byte_2, int_1, byte_3, int_3 + num3);
					int_2 -= num;
					int_1 += num;
				}
			}
			Array.Copy(byte_2, int_1, this.byte_1, this.int_0, int_2);
			this.int_0 += int_2;
			if (this.int_0 == this.byte_1.Length)
			{
				num3 += this.interface3_0.imethod_4(this.byte_1, 0, byte_3, int_3 + num3);
				this.int_0 = 0;
			}
			return num3;
		}
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00025CBC File Offset: 0x00023EBC
	public override byte[] imethod_9()
	{
		byte[] array = Class54.byte_0;
		int num = this.imethod_3(0);
		if (num > 0)
		{
			array = new byte[num];
			int num2 = this.imethod_12(array, 0);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			this.imethod_15();
		}
		return array;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00025D10 File Offset: 0x00023F10
	public override byte[] imethod_11(byte[] byte_2, int int_1, int int_2)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException("#=zPWibic8=");
		}
		int num = this.imethod_3(int_2);
		byte[] array = Class54.byte_0;
		if (num > 0)
		{
			array = new byte[num];
			int num2 = (int_2 > 0) ? this.imethod_8(byte_2, int_1, int_2, array, 0) : 0;
			num2 += this.imethod_12(array, num2);
			if (num2 < array.Length)
			{
				byte[] array2 = new byte[num2];
				Array.Copy(array, 0, array2, 0, num2);
				array = array2;
			}
		}
		else
		{
			this.imethod_15();
		}
		return array;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00025D88 File Offset: 0x00023F88
	public override int imethod_12(byte[] byte_2, int int_1)
	{
		int result;
		try
		{
			if (this.int_0 != 0)
			{
				if (!this.interface3_0.imethod_3())
				{
					throw new Exception1("data not block size aligned");
				}
				if (int_1 + this.int_0 > byte_2.Length)
				{
					throw new Exception1("output buffer too short for DoFinal()");
				}
				this.interface3_0.imethod_4(this.byte_1, 0, this.byte_1, 0);
				Array.Copy(this.byte_1, 0, byte_2, int_1, this.int_0);
			}
			result = this.int_0;
		}
		finally
		{
			this.imethod_15();
		}
		return result;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00003DB0 File Offset: 0x00001FB0
	public override void imethod_15()
	{
		Array.Clear(this.byte_1, 0, this.byte_1.Length);
		this.int_0 = 0;
		this.interface3_0.imethod_5();
	}

	// Token: 0x0400007F RID: 127
	internal byte[] byte_1;

	// Token: 0x04000080 RID: 128
	internal int int_0;

	// Token: 0x04000081 RID: 129
	internal bool bool_0;

	// Token: 0x04000082 RID: 130
	internal Interface3 interface3_0;
}
