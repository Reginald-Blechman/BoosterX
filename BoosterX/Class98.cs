using System;
using System.IO;

// Token: 0x02000006 RID: 6
internal sealed class Class98 : Class97, IDisposable
{
	// Token: 0x0600002F RID: 47 RVA: 0x000030C3 File Offset: 0x000012C3
	public Class98() : this(0)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00021D00 File Offset: 0x0001FF00
	public Class98(int int_4)
	{
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.byte_0 = new byte[int_4];
		this.int_3 = int_4;
		this.bool_0 = true;
		this.bool_1 = true;
		this.int_0 = 0;
		this.bool_2 = true;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000030CC File Offset: 0x000012CC
	public Class98(byte[] byte_1) : this(byte_1, true)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00021D4C File Offset: 0x0001FF4C
	public Class98(byte[] byte_1, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		this.byte_0 = byte_1;
		this.int_2 = (this.int_3 = byte_1.Length);
		this.bool_1 = bool_4;
		this.int_0 = 0;
		this.bool_2 = true;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000030D6 File Offset: 0x000012D6
	public Class98(byte[] byte_1, int int_4, int int_5) : this(byte_1, int_4, int_5, true)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00021D98 File Offset: 0x0001FF98
	public Class98(byte[] byte_1, int int_4, int int_5, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		this.byte_0 = byte_1;
		this.int_1 = int_4;
		this.int_0 = int_4;
		this.int_2 = (this.int_3 = int_4 + int_5);
		this.bool_1 = bool_4;
		this.bool_0 = false;
		this.bool_2 = true;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000030E2 File Offset: 0x000012E2
	public override bool vmethod_0()
	{
		return this.bool_2;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000030E2 File Offset: 0x000012E2
	public override bool vmethod_2()
	{
		return this.bool_2;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000030EA File Offset: 0x000012EA
	public override bool vmethod_1()
	{
		return this.bool_1;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000030F2 File Offset: 0x000012F2
	protected override void vmethod_7(bool bool_4)
	{
		if (!this.bool_3)
		{
			if (bool_4)
			{
				this.bool_2 = false;
				this.bool_1 = false;
				this.bool_0 = false;
			}
			this.bool_3 = true;
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00021E18 File Offset: 0x00020018
	private bool method_0(int int_4)
	{
		if (int_4 < 0)
		{
			throw new IOException();
		}
		if (int_4 > this.int_3)
		{
			int num = int_4;
			if (num < 256)
			{
				num = 256;
			}
			if (num < this.int_3 * 2)
			{
				num = this.int_3 * 2;
			}
			this.method_6(num);
			return true;
		}
		return false;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000311B File Offset: 0x0000131B
	public override void vmethod_8()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x0000311D File Offset: 0x0000131D
	internal byte[] method_1()
	{
		return this.byte_0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003125 File Offset: 0x00001325
	internal void method_2(out int int_4, out int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int_4 = this.int_0;
		int_5 = this.int_2;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00003145 File Offset: 0x00001345
	internal int method_3()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return this.int_1;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00021E68 File Offset: 0x00020068
	public int method_4(int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int num = this.int_2 - this.int_1;
		if (num > int_4)
		{
			num = int_4;
		}
		if (num < 0)
		{
			num = 0;
		}
		this.int_1 += num;
		return num;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000315B File Offset: 0x0000135B
	public int method_5()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return this.int_3 - this.int_0;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00021EAC File Offset: 0x000200AC
	public void method_6(int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (int_4 != this.int_3)
		{
			if (!this.bool_0)
			{
				throw new Exception();
			}
			if (int_4 < this.int_2)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (int_4 > 0)
			{
				byte[] dst = new byte[int_4];
				if (this.int_2 > 0)
				{
					Buffer.BlockCopy(this.byte_0, 0, dst, 0, this.int_2);
				}
				this.byte_0 = dst;
			}
			else
			{
				this.byte_0 = null;
			}
			this.int_3 = int_4;
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00003178 File Offset: 0x00001378
	public override long vmethod_3()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return (long)(this.int_2 - this.int_0);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003196 File Offset: 0x00001396
	public override long vmethod_4()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		return (long)(this.int_1 - this.int_0);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00021F2C File Offset: 0x0002012C
	public override void vmethod_5(long long_0)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (long_0 < 0L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.int_1 = this.int_0 + (int)long_0;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00021F7C File Offset: 0x0002017C
	public override int vmethod_11(byte[] byte_1, int int_4, int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = this.int_2 - this.int_1;
		if (num > int_5)
		{
			num = int_5;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				byte_1[int_4 + num2] = this.byte_0[this.int_1 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(this.byte_0, this.int_1, byte_1, int_4, num);
		}
		this.int_1 += num;
		return num;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00022028 File Offset: 0x00020228
	public override int vmethod_12()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (this.int_1 >= this.int_2)
		{
			return -1;
		}
		byte[] array = this.byte_0;
		int num = this.int_1;
		this.int_1 = num + 1;
		return array[num];
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0002206C File Offset: 0x0002026C
	public override long vmethod_9(long long_0, int int_4)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (int_4)
		{
		case 0:
			if (long_0 < 0L)
			{
				throw new IOException();
			}
			this.int_1 = this.int_0 + (int)long_0;
			break;
		case 1:
			if (long_0 + (long)this.int_1 < (long)this.int_0)
			{
				throw new IOException();
			}
			this.int_1 += (int)long_0;
			break;
		case 2:
			if ((long)this.int_2 + long_0 < (long)this.int_0)
			{
				throw new IOException();
			}
			this.int_1 = this.int_2 + (int)long_0;
			break;
		default:
			throw new ArgumentException();
		}
		return (long)this.int_1;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0002212C File Offset: 0x0002032C
	public override void vmethod_10(long long_0)
	{
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 >= 0L && long_0 <= (long)(2147483647 - this.int_0))
		{
			int num = this.int_0 + (int)long_0;
			if (!this.method_0(num) && num > this.int_2)
			{
				Array.Clear(this.byte_0, this.int_2, num - this.int_2);
			}
			this.int_2 = num;
			if (this.int_1 > num)
			{
				this.int_1 = num;
			}
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000221CC File Offset: 0x000203CC
	public byte[] method_7()
	{
		byte[] array = new byte[this.int_2 - this.int_0];
		Buffer.BlockCopy(this.byte_0, this.int_0, array, 0, this.int_2 - this.int_0);
		return array;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00022210 File Offset: 0x00020410
	public override void vmethod_13(byte[] byte_1, int int_4, int int_5)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = this.int_1 + int_5;
		if (num < 0)
		{
			throw new IOException();
		}
		if (num > this.int_2)
		{
			bool flag = this.int_1 > this.int_2;
			if (num > this.int_3 && this.method_0(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.byte_0, this.int_2, num - this.int_2);
			}
			this.int_2 = num;
		}
		if (int_5 <= 8)
		{
			int num2 = int_5;
			while (--num2 >= 0)
			{
				this.byte_0[this.int_1 + num2] = byte_1[int_4 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(byte_1, int_4, this.byte_0, this.int_1, int_5);
		}
		this.int_1 = num;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00022308 File Offset: 0x00020508
	public override void vmethod_14(byte byte_1)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (!this.bool_1)
		{
			throw new Exception();
		}
		if (this.int_1 >= this.int_2)
		{
			int num = this.int_1 + 1;
			bool flag = this.int_1 > this.int_2;
			if (num >= this.int_3 && this.method_0(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.byte_0, this.int_2, this.int_1 - this.int_2);
			}
			this.int_2 = num;
		}
		byte[] array = this.byte_0;
		int num2 = this.int_1;
		this.int_1 = num2 + 1;
		array[num2] = byte_1;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000031B4 File Offset: 0x000013B4
	public void method_8(Stream stream_0)
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		if (stream_0 == null)
		{
			throw new ArgumentNullException();
		}
		stream_0.Write(this.byte_0, this.int_0, this.int_2 - this.int_0);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000223AC File Offset: 0x000205AC
	internal int method_9()
	{
		if (!this.bool_2)
		{
			throw new Exception();
		}
		int num = this.int_1 += 4;
		if (num > this.int_2)
		{
			this.int_1 = this.int_2;
			throw new Exception();
		}
		return (int)this.byte_0[num - 1] << 24 | (int)this.byte_0[num - 2] << 8 | (int)this.byte_0[num - 3] << 16 | (int)this.byte_0[num - 4];
	}

	// Token: 0x0400000F RID: 15
	private byte[] byte_0;

	// Token: 0x04000010 RID: 16
	private int int_0;

	// Token: 0x04000011 RID: 17
	private int int_1;

	// Token: 0x04000012 RID: 18
	private int int_2;

	// Token: 0x04000013 RID: 19
	private int int_3;

	// Token: 0x04000014 RID: 20
	private bool bool_0;

	// Token: 0x04000015 RID: 21
	private bool bool_1;

	// Token: 0x04000016 RID: 22
	private bool bool_2;

	// Token: 0x04000017 RID: 23
	private bool bool_3;
}
