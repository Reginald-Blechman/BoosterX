using System;

// Token: 0x0200007C RID: 124
internal sealed class Class50
{
	// Token: 0x06000407 RID: 1031 RVA: 0x00004DB2 File Offset: 0x00002FB2
	public Class86[] method_0()
	{
		return this.class86_0;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00004DBA File Offset: 0x00002FBA
	public void method_1(Class86[] class86_1)
	{
		this.class86_0 = class86_1;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00004DC3 File Offset: 0x00002FC3
	public Class49[] method_2()
	{
		return this.class49_0;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00004DCB File Offset: 0x00002FCB
	public void method_3(Class49[] class49_1)
	{
		this.class49_0 = class49_1;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00004DD4 File Offset: 0x00002FD4
	public string method_4()
	{
		return this.string_0;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00004DDC File Offset: 0x00002FDC
	public void method_5(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00004DE5 File Offset: 0x00002FE5
	public int method_6()
	{
		return this.int_1;
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00004DED File Offset: 0x00002FED
	public void method_7(int int_2)
	{
		this.int_1 = int_2;
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00004DF6 File Offset: 0x00002FF6
	public int method_8()
	{
		return this.int_0;
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00004DFE File Offset: 0x00002FFE
	public void method_9(int int_2)
	{
		this.int_0 = int_2;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00004E07 File Offset: 0x00003007
	public byte method_10()
	{
		return this.byte_0;
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00004E0F File Offset: 0x0000300F
	public void method_11(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00004E18 File Offset: 0x00003018
	public bool method_12()
	{
		return (this.method_10() & 2) > 0;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00004E25 File Offset: 0x00003025
	public bool method_13()
	{
		return (this.method_10() & 1) > 0;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00004E32 File Offset: 0x00003032
	public bool method_14()
	{
		return (this.method_10() & 4) > 0;
	}

	// Token: 0x0400029A RID: 666
	private int int_0;

	// Token: 0x0400029B RID: 667
	private byte byte_0;

	// Token: 0x0400029C RID: 668
	private int int_1;

	// Token: 0x0400029D RID: 669
	private string string_0;

	// Token: 0x0400029E RID: 670
	private Class86[] class86_0;

	// Token: 0x0400029F RID: 671
	private Class49[] class49_0;
}
