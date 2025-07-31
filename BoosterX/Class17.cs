using System;

// Token: 0x02000048 RID: 72
internal sealed class Class17 : Class13
{
	// Token: 0x060001CA RID: 458 RVA: 0x00004066 File Offset: 0x00002266
	public byte method_0()
	{
		return this.byte_0;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0000406E File Offset: 0x0000226E
	public void method_1(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00004077 File Offset: 0x00002277
	public bool method_2()
	{
		return (this.method_0() & 1) > 0;
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00004084 File Offset: 0x00002284
	public bool method_3()
	{
		return (this.method_0() & 2) > 0;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00004091 File Offset: 0x00002291
	public Class103 method_4()
	{
		return this.class103_0;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00004099 File Offset: 0x00002299
	public void method_5(Class103 class103_4)
	{
		this.class103_0 = class103_4;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x000040A2 File Offset: 0x000022A2
	public string method_6()
	{
		return this.string_0;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x000040AA File Offset: 0x000022AA
	public void method_7(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x000040B3 File Offset: 0x000022B3
	public Class103[] method_8()
	{
		return this.class103_1;
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000040BB File Offset: 0x000022BB
	public void method_9(Class103[] class103_4)
	{
		this.class103_1 = class103_4;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x000040C4 File Offset: 0x000022C4
	public Class103[] method_10()
	{
		return this.class103_2;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000040CC File Offset: 0x000022CC
	public void method_11(Class103[] class103_4)
	{
		this.class103_2 = class103_4;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x000040D5 File Offset: 0x000022D5
	public Class103 method_12()
	{
		return this.class103_3;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000040DD File Offset: 0x000022DD
	public void method_13(Class103 class103_4)
	{
		this.class103_3 = class103_4;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00003056 File Offset: 0x00001256
	public override byte vmethod_0()
	{
		return 0;
	}

	// Token: 0x0400009D RID: 157
	private byte byte_0;

	// Token: 0x0400009E RID: 158
	private Class103 class103_0;

	// Token: 0x0400009F RID: 159
	private string string_0;

	// Token: 0x040000A0 RID: 160
	private Class103[] class103_1 = new Class103[0];

	// Token: 0x040000A1 RID: 161
	private Class103[] class103_2 = new Class103[0];

	// Token: 0x040000A2 RID: 162
	private Class103 class103_3;
}
