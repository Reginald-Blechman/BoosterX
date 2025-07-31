using System;

// Token: 0x02000098 RID: 152
internal sealed class Class93
{
	// Token: 0x060004D8 RID: 1240 RVA: 0x0003744C File Offset: 0x0003564C
	public Class93()
	{
		this.int_0 = this.class51_0.method_5();
		this.int_1 = this.class51_0.method_3();
		this.byte_0 = new byte[this.int_1];
		this.byte_1 = new byte[this.int_1 + this.int_0];
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x000374B8 File Offset: 0x000356B8
	public void method_0(byte[] byte_2)
	{
		this.class51_0.method_9();
		int num = byte_2.Length;
		if (num > this.int_1)
		{
			this.class51_0.method_1(byte_2, 0, num);
			this.class51_0.method_8(this.byte_0, 0);
			num = this.int_0;
		}
		else
		{
			Array.Copy(byte_2, 0, this.byte_0, 0, num);
		}
		Array.Clear(this.byte_0, num, this.int_1 - num);
		Array.Copy(this.byte_0, 0, this.byte_1, 0, this.int_1);
		Class93.smethod_0(this.byte_0, this.int_1, 54);
		Class93.smethod_0(this.byte_1, this.int_1, 92);
		this.class51_2 = this.class51_0.method_11();
		this.class51_2.method_1(this.byte_1, 0, this.int_1);
		this.class51_0.method_1(this.byte_0, 0, this.byte_0.Length);
		this.class51_1 = this.class51_0.method_11();
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x000054B7 File Offset: 0x000036B7
	public int method_1()
	{
		return this.int_0;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x000054BF File Offset: 0x000036BF
	public void method_2(byte[] byte_2, int int_2, int int_3)
	{
		this.class51_0.method_1(byte_2, int_2, int_3);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x000375C0 File Offset: 0x000357C0
	public int method_3(byte[] byte_2, int int_2)
	{
		this.class51_0.method_8(this.byte_1, this.int_1);
		this.class51_0.method_12(this.class51_2);
		this.class51_0.method_1(this.byte_1, this.int_1, this.class51_0.method_5());
		int result = this.class51_0.method_8(byte_2, int_2);
		Array.Clear(this.byte_1, this.int_1, this.int_0);
		this.class51_0.method_12(this.class51_1);
		return result;
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00037650 File Offset: 0x00035850
	private static void smethod_0(byte[] byte_2, int int_2, byte byte_3)
	{
		for (int i = 0; i < int_2; i++)
		{
			int num = i;
			byte_2[num] ^= byte_3;
		}
	}

	// Token: 0x040002D2 RID: 722
	private readonly Class51 class51_0 = new Class51();

	// Token: 0x040002D3 RID: 723
	private readonly int int_0;

	// Token: 0x040002D4 RID: 724
	private readonly int int_1;

	// Token: 0x040002D5 RID: 725
	private Class51 class51_1;

	// Token: 0x040002D6 RID: 726
	private Class51 class51_2;

	// Token: 0x040002D7 RID: 727
	private readonly byte[] byte_0;

	// Token: 0x040002D8 RID: 728
	private readonly byte[] byte_1;
}
