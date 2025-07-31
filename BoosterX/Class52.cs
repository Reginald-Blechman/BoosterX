using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x0200007E RID: 126
internal sealed class Class52 : Interface1
{
	// Token: 0x0600042A RID: 1066 RVA: 0x0003574C File Offset: 0x0003394C
	public Class52(bool bool_0, Class100 class100_0)
	{
		this.class10_0 = new Class10();
		this.class10_0.method_0(bool_0, class100_0);
		this.int_0 = this.class10_0.method_1();
		this.int_1 = this.class10_0.method_3();
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00004F27 File Offset: 0x00003127
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_0;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00004F2F File Offset: 0x0000312F
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_1;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x0003579C File Offset: 0x0003399C
	public int imethod_2(byte[] byte_0, int int_2, int int_3, byte[] byte_1, int int_4, RandomNumberGenerator randomNumberGenerator_0)
	{
		Class128 class128_ = this.class10_0.method_5(byte_0, int_2, int_3);
		Class128 class128_2 = this.class10_0.method_7(class128_);
		return this.class10_0.method_6(class128_2, byte_1, int_4);
	}

	// Token: 0x040002AA RID: 682
	private Class10 class10_0;

	// Token: 0x040002AB RID: 683
	private readonly int int_0;

	// Token: 0x040002AC RID: 684
	private readonly int int_1;
}
