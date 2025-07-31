using System;
using System.Runtime.CompilerServices;

// Token: 0x02000676 RID: 1654
public sealed class GClass277<T> : GInterface11
{
	// Token: 0x060029A3 RID: 10659 RVA: 0x0001B432 File Offset: 0x00019632
	public GClass277(GEnum4 genum4_1)
	{
		this.genum4_0 = genum4_1;
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x0001B441 File Offset: 0x00019641
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x0001B449 File Offset: 0x00019649
	public void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x0001B452 File Offset: 0x00019652
	[CompilerGenerated]
	public string imethod_1()
	{
		return this.string_0;
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x0001B45A File Offset: 0x0001965A
	[CompilerGenerated]
	public void imethod_2(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x170006EE RID: 1774
	// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0001B463 File Offset: 0x00019663
	public string ValueNameLoc
	{
		get
		{
			return Class298.smethod_2(this.imethod_1());
		}
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x0001B470 File Offset: 0x00019670
	public T method_2()
	{
		return this.gparam_0;
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x0001B478 File Offset: 0x00019678
	public void method_3(T gparam_1)
	{
		this.gparam_0 = gparam_1;
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x0001B481 File Offset: 0x00019681
	public object imethod_0()
	{
		return this.method_2();
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x000A2B10 File Offset: 0x000A0D10
	public override string ToString()
	{
		if (typeof(T) == typeof(uint))
		{
			return string.Format("Value=0x{0:X8}; ValueName={1}; Source={2};", this.method_2(), this.imethod_1(), this.genum4_0);
		}
		return string.Format("Value={0}; ValueName={1};", this.method_2(), this.imethod_1());
	}

	// Token: 0x04001B62 RID: 7010
	public GEnum4 genum4_0;

	// Token: 0x04001B63 RID: 7011
	private int int_0;

	// Token: 0x04001B64 RID: 7012
	private string string_0;

	// Token: 0x04001B65 RID: 7013
	private T gparam_0;
}
