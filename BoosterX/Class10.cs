using System;

// Token: 0x02000016 RID: 22
internal sealed class Class10
{
	// Token: 0x0600008C RID: 140 RVA: 0x00022F14 File Offset: 0x00021114
	public void method_0(bool bool_0, Class100 class100_1)
	{
		this.class100_0 = class100_1;
		this.int_0 = this.class100_0.method_1().method_1();
		this.method_2(Class10.smethod_0(this.int_0, bool_0));
		this.method_4(Class10.smethod_1(this.int_0, bool_0));
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000348D File Offset: 0x0000168D
	public int method_1()
	{
		return this.int_1;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00003495 File Offset: 0x00001695
	private void method_2(int int_3)
	{
		this.int_1 = int_3;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000349E File Offset: 0x0000169E
	public int method_3()
	{
		return this.int_2;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000034A6 File Offset: 0x000016A6
	private void method_4(int int_3)
	{
		this.int_2 = int_3;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000034AF File Offset: 0x000016AF
	private static int smethod_0(int int_3, bool bool_0)
	{
		if (!bool_0)
		{
			return (int_3 + 7) / 8;
		}
		return (int_3 - 1) / 8;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x000034BF File Offset: 0x000016BF
	private static int smethod_1(int int_3, bool bool_0)
	{
		if (!bool_0)
		{
			return (int_3 - 1) / 8;
		}
		return (int_3 + 7) / 8;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000034CF File Offset: 0x000016CF
	public Class128 method_5(byte[] byte_0, int int_3, int int_4)
	{
		return new Class128(1, byte_0, int_3, int_4);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00022F64 File Offset: 0x00021164
	public int method_6(Class128 class128_0, byte[] byte_0, int int_3)
	{
		int num = this.method_3() - class128_0.method_10();
		Array.Clear(byte_0, int_3, num);
		int_3 += num;
		class128_0.method_11(byte_0, int_3);
		return this.method_3();
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000034DA File Offset: 0x000016DA
	public Class128 method_7(Class128 class128_0)
	{
		return class128_0.method_5(this.class100_0.method_2(), this.class100_0.method_1());
	}

	// Token: 0x04000035 RID: 53
	private Class100 class100_0;

	// Token: 0x04000036 RID: 54
	private int int_0;

	// Token: 0x04000037 RID: 55
	private int int_1;

	// Token: 0x04000038 RID: 56
	private int int_2;
}
