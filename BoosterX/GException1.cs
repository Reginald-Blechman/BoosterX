using System;

// Token: 0x02000316 RID: 790
public class GException1 : GException0
{
	// Token: 0x06001459 RID: 5209 RVA: 0x0000E34D File Offset: 0x0000C54D
	public GException1()
	{
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x0000E355 File Offset: 0x0000C555
	public GException1(string string_2) : base(string_2)
	{
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x0000E35E File Offset: 0x0000C55E
	public GException1(string string_2, string string_3, int int_1, string string_4) : base(string_2)
	{
		this.method_1(string_3);
		this.method_3(int_1);
		this.method_5(string_4);
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x0000E37D File Offset: 0x0000C57D
	public GException1(string string_2, int int_1, string string_3) : base(string.Format("Endpoint: {0}. Status code: {1}. Response: {2}", string_2, int_1, string_3))
	{
		this.method_1(string_2);
		this.method_3(int_1);
		this.method_5(string_3);
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x0000E3AD File Offset: 0x0000C5AD
	public GException1(string string_2, Exception exception_0) : base(string_2, exception_0)
	{
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x0000E3B7 File Offset: 0x0000C5B7
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x0000E3BF File Offset: 0x0000C5BF
	private void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
	private int method_2()
	{
		return this.int_0;
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
	private void method_3(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x0000E3D9 File Offset: 0x0000C5D9
	private string method_4()
	{
		return this.string_1;
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x0000E3E1 File Offset: 0x0000C5E1
	private void method_5(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x04000DB1 RID: 3505
	private string string_0;

	// Token: 0x04000DB2 RID: 3506
	private int int_0;

	// Token: 0x04000DB3 RID: 3507
	private string string_1;
}
