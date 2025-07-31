using System;

// Token: 0x020000C7 RID: 199
internal sealed class Class130 : IEquatable<Class130>
{
	// Token: 0x060005E6 RID: 1510 RVA: 0x00005C27 File Offset: 0x00003E27
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00005C2F File Offset: 0x00003E2F
	public void method_1(int int_5)
	{
		this.int_0 = int_5;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00005C38 File Offset: 0x00003E38
	public int method_2()
	{
		return this.int_1;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00005C40 File Offset: 0x00003E40
	public void method_3(int int_5)
	{
		this.int_1 = int_5;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00005C49 File Offset: 0x00003E49
	public int method_4()
	{
		return this.int_2;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00005C51 File Offset: 0x00003E51
	public void method_5(int int_5)
	{
		this.int_2 = int_5;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00005C5A File Offset: 0x00003E5A
	public int method_6()
	{
		return this.int_3;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00005C62 File Offset: 0x00003E62
	public void method_7(int int_5)
	{
		this.int_3 = int_5;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00005C6B File Offset: 0x00003E6B
	public int method_8()
	{
		return this.int_4;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00005C73 File Offset: 0x00003E73
	public void method_9(int int_5)
	{
		this.int_4 = int_5;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00005C7C File Offset: 0x00003E7C
	public static Class130 smethod_0()
	{
		return Class130.class130_0;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00005C83 File Offset: 0x00003E83
	public override bool Equals(object obj)
	{
		return Class130.smethod_1(this, obj as Class130);
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00005C91 File Offset: 0x00003E91
	public bool Equals(Class130 other)
	{
		return Class130.smethod_1(this, other);
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0003A0B8 File Offset: 0x000382B8
	public static bool smethod_1(Class130 class130_1, Class130 class130_2)
	{
		return class130_1 == class130_2 || (class130_1 != null && class130_2 != null && (class130_1.method_0() == class130_2.method_0() && class130_1.method_2() == class130_2.method_2() && class130_1.method_4() == class130_2.method_4() && class130_1.method_6() == class130_2.method_6()) && class130_1.method_8() == class130_2.method_8());
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0003A11C File Offset: 0x0003831C
	public override int GetHashCode()
	{
		return ((((-8832819 + this.method_0().GetHashCode()) * -1521134295 + this.method_2().GetHashCode()) * -1521134295 + this.method_4().GetHashCode()) * -1521134295 + this.method_6().GetHashCode()) * -1521134295 + this.method_8().GetHashCode();
	}

	// Token: 0x04000327 RID: 807
	private int int_0 = 255;

	// Token: 0x04000328 RID: 808
	private int int_1 = 12;

	// Token: 0x04000329 RID: 809
	private int int_2 = 96;

	// Token: 0x0400032A RID: 810
	private int int_3 = 10;

	// Token: 0x0400032B RID: 811
	private int int_4 = 4;

	// Token: 0x0400032C RID: 812
	private static readonly Class130 class130_0 = new Class130();
}
