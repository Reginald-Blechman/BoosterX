using System;

// Token: 0x02000078 RID: 120
internal sealed class Class56 : Class55
{
	// Token: 0x060003E9 RID: 1001 RVA: 0x00004CC7 File Offset: 0x00002EC7
	public Class56(Interface3 interface3_1, Interface0 interface0_1)
	{
		this.interface3_0 = interface3_1;
		this.interface0_0 = interface0_1;
		this.byte_1 = new byte[interface3_1.imethod_2()];
		this.int_0 = 0;
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00004CF5 File Offset: 0x00002EF5
	public Class56(Interface3 interface3_1) : this(interface3_1, new Class104())
	{
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00004D03 File Offset: 0x00002F03
	public override void imethod_1(bool bool_1, Interface2 interface2_0)
	{
		this.bool_0 = bool_1;
		this.imethod_15();
		this.interface0_0.imethod_0();
		this.interface3_0.imethod_1(bool_1, interface2_0);
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00034A30 File Offset: 0x00032C30
	public override int imethod_3(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		if (num2 != 0)
		{
			return num - num2 + this.byte_1.Length;
		}
		if (this.bool_0)
		{
			return num + this.byte_1.Length;
		}
		return num;
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00034A78 File Offset: 0x00032C78
	public override int imethod_4(int int_1)
	{
		int num = int_1 + this.int_0;
		int num2 = num % this.byte_1.Length;
		if (num2 == 0)
		{
			return num - this.byte_1.Length;
		}
		return num - num2;
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00034AAC File Offset: 0x00032CAC
	public override int imethod_8(byte[] byte_2, int int_1, int int_2, byte[] byte_3, int int_3)
	{
		if (int_2 < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
		}
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
		return num3;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00034BA0 File Offset: 0x00032DA0
	public override int imethod_12(byte[] byte_2, int int_1)
	{
		int num = this.interface3_0.imethod_2();
		int num2 = 0;
		if (!this.bool_0)
		{
			if (this.int_0 == num)
			{
				num2 = this.interface3_0.imethod_4(this.byte_1, 0, this.byte_1, 0);
				this.int_0 = 0;
				try
				{
					num2 -= this.interface0_0.imethod_3(this.byte_1);
					Array.Copy(this.byte_1, 0, byte_2, int_1, num2);
					return num2;
				}
				finally
				{
					this.imethod_15();
				}
			}
			this.imethod_15();
			throw new Exception1("last block incomplete in decryption");
		}
		if (this.int_0 == num)
		{
			if (int_1 + 2 * num > byte_2.Length)
			{
				this.imethod_15();
				throw new Exception1("output buffer too short");
			}
			num2 = this.interface3_0.imethod_4(this.byte_1, 0, byte_2, int_1);
			this.int_0 = 0;
		}
		this.interface0_0.imethod_2(this.byte_1, this.int_0);
		num2 += this.interface3_0.imethod_4(this.byte_1, 0, byte_2, int_1 + num2);
		this.imethod_15();
		return num2;
	}

	// Token: 0x0400028C RID: 652
	private readonly Interface0 interface0_0;
}
