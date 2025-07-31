using System;
using System.Drawing;

// Token: 0x02000153 RID: 339
public sealed class GClass14
{
	// Token: 0x060009A7 RID: 2471 RVA: 0x00003332 File Offset: 0x00001532
	public GClass14()
	{
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00007E4F File Offset: 0x0000604F
	public GClass14(byte byte_4, byte byte_5, byte byte_6, byte byte_7)
	{
		this.method_1(byte_4);
		this.method_3(byte_5);
		this.method_5(byte_6);
		this.method_7(byte_7);
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00007E74 File Offset: 0x00006074
	public byte method_0()
	{
		return this.byte_0;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00007E7C File Offset: 0x0000607C
	public void method_1(byte byte_4)
	{
		this.byte_0 = byte_4;
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00007E85 File Offset: 0x00006085
	public byte method_2()
	{
		return this.byte_1;
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00007E8D File Offset: 0x0000608D
	public void method_3(byte byte_4)
	{
		this.byte_1 = byte_4;
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00007E96 File Offset: 0x00006096
	public byte method_4()
	{
		return this.byte_2;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00007E9E File Offset: 0x0000609E
	public void method_5(byte byte_4)
	{
		this.byte_2 = byte_4;
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00007EA7 File Offset: 0x000060A7
	public byte method_6()
	{
		return this.byte_3;
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00007EAF File Offset: 0x000060AF
	public void method_7(byte byte_4)
	{
		this.byte_3 = byte_4;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x000454D4 File Offset: 0x000436D4
	public static string smethod_0(GClass14 gclass14_0)
	{
		return Color.FromArgb((int)gclass14_0.method_0(), (int)gclass14_0.method_2(), (int)gclass14_0.method_4(), (int)gclass14_0.method_6()).ToArgb().ToString("X8");
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00045514 File Offset: 0x00043714
	public static GClass14 smethod_1(string string_0)
	{
		Color color = ColorTranslator.FromHtml(string_0);
		GClass14 gclass = new GClass14();
		gclass.method_1(color.A);
		gclass.method_3(color.R);
		gclass.method_5(color.G);
		gclass.method_7(color.B);
		return gclass;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00007EB8 File Offset: 0x000060B8
	public string method_8()
	{
		return GClass14.smethod_0(this);
	}

	// Token: 0x04000680 RID: 1664
	private byte byte_0;

	// Token: 0x04000681 RID: 1665
	private byte byte_1;

	// Token: 0x04000682 RID: 1666
	private byte byte_2;

	// Token: 0x04000683 RID: 1667
	private byte byte_3;
}
