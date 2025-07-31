using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x02000097 RID: 151
internal sealed class Class92 : IDisposable, Interface1
{
	// Token: 0x060004CF RID: 1231 RVA: 0x00037354 File Offset: 0x00035554
	public Class92(Class133 class133_1)
	{
		if (class133_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (class133_1.method_0())
		{
			throw new NotSupportedException();
		}
		this.class133_0 = class133_1;
		this.byte_0 = new byte[class133_1.imethod_1()];
		this.int_0 = this.method_0();
		this.int_1 = this.method_1();
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0000545D File Offset: 0x0000365D
	private int method_0()
	{
		return this.class133_0.imethod_0();
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x0000546A File Offset: 0x0000366A
	private int method_1()
	{
		return this.class133_0.imethod_1() - 10;
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x0000547A File Offset: 0x0000367A
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_0;
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00005482 File Offset: 0x00003682
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_1;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x0000548A File Offset: 0x0000368A
	public int imethod_2(byte[] byte_1, int int_2, int int_3, byte[] byte_2, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		return this.method_2(byte_1, int_2, int_3, byte_2, int_4, randomNumberGenerator_0);
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x000373B0 File Offset: 0x000355B0
	private int method_2(byte[] byte_1, int int_2, int int_3, byte[] byte_2, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		int num = this.class133_0.imethod_1();
		byte[] array = this.byte_0;
		this.class133_0.imethod_2(byte_1, int_2, int_3, array, 0, randomNumberGenerator_0);
		byte b = array[0];
		bool flag = b != 2;
		int num2 = Class92.smethod_0(b, array, 0, num);
		num2++;
		if (flag | num2 < 10)
		{
			throw new InvalidOperationException("Invalid block.");
		}
		int num3 = num - num2;
		Buffer.BlockCopy(array, num2, byte_2, int_4, num3);
		return num3;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00037424 File Offset: 0x00035624
	private static int smethod_0(byte byte_1, byte[] byte_2, int int_2, int int_3)
	{
		for (int num = int_2 + 1; num != int_2 + int_3; num++)
		{
			if (byte_2[num] == 0)
			{
				return num;
			}
		}
		return -1;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0000549B File Offset: 0x0000369B
	public void Dispose()
	{
		if (this.class133_0 != null)
		{
			this.class133_0.Dispose();
			this.class133_0 = null;
		}
	}

	// Token: 0x040002CE RID: 718
	private Class133 class133_0;

	// Token: 0x040002CF RID: 719
	private byte[] byte_0;

	// Token: 0x040002D0 RID: 720
	private readonly int int_0;

	// Token: 0x040002D1 RID: 721
	private readonly int int_1;
}
