using System;
using System.Security.Cryptography;

// Token: 0x0200007A RID: 122
internal sealed class Class48 : DeriveBytes
{
	// Token: 0x060003FD RID: 1021 RVA: 0x00034CB8 File Offset: 0x00032EB8
	public Class48(byte[] byte_3, byte[] byte_4, int int_1)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException("#=zPWibic8=");
		}
		if (byte_4 == null)
		{
			throw new ArgumentNullException("#=z2_sBKLs=");
		}
		if (int_1 < 1)
		{
			throw new ArgumentException("iterationCount");
		}
		this.byte_0 = (byte[])byte_3.Clone();
		this.byte_1 = (byte[])byte_4.Clone();
		this.int_0 = int_1;
		this.byte_2 = new byte[this.class93_0.method_1()];
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00034D44 File Offset: 0x00032F44
	private void method_0(byte[] byte_3, int int_1, byte[] byte_4, byte[] byte_5, int int_2)
	{
		if (byte_3 != null)
		{
			this.class93_0.method_2(byte_3, 0, byte_3.Length);
		}
		this.class93_0.method_2(byte_4, 0, byte_4.Length);
		this.class93_0.method_3(this.byte_2, 0);
		Buffer.BlockCopy(this.byte_2, 0, byte_5, int_2, this.byte_2.Length);
		for (int i = 1; i < int_1; i++)
		{
			this.class93_0.method_2(this.byte_2, 0, this.byte_2.Length);
			this.class93_0.method_3(this.byte_2, 0);
			for (int j = 0; j < this.byte_2.Length; j++)
			{
				int num = int_2 + j;
				byte_5[num] ^= this.byte_2[j];
			}
		}
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00034E04 File Offset: 0x00033004
	public override byte[] GetBytes(int cb)
	{
		int num = this.class93_0.method_1();
		int num2 = (cb + num - 1) / num;
		byte[] array = new byte[4];
		byte[] array2 = new byte[num2 * num];
		int num3 = 0;
		this.class93_0.method_0(this.byte_0);
		for (int i = 1; i <= num2; i++)
		{
			int num4 = 3;
			for (;;)
			{
				byte[] array3 = array;
				int num5 = num4;
				byte b = array3[num5] + 1;
				array3[num5] = b;
				if (b != 0)
				{
					break;
				}
				num4--;
			}
			this.method_0(this.byte_1, this.int_0, array, array2, num3);
			num3 += num;
		}
		if (cb < array2.Length)
		{
			byte[] array4 = new byte[cb];
			Buffer.BlockCopy(array2, 0, array4, 0, cb);
			array2 = array4;
		}
		return array2;
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x000031EC File Offset: 0x000013EC
	public override void Reset()
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000293 RID: 659
	private byte[] byte_0;

	// Token: 0x04000294 RID: 660
	private byte[] byte_1;

	// Token: 0x04000295 RID: 661
	private int int_0;

	// Token: 0x04000296 RID: 662
	private readonly Class93 class93_0 = new Class93();

	// Token: 0x04000297 RID: 663
	private readonly byte[] byte_2;
}
