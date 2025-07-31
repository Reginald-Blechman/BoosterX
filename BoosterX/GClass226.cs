using System;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using System.Windows.Media;

// Token: 0x0200051B RID: 1307
[MarkupExtensionReturnType(typeof(Geometry))]
public sealed class GClass226 : MarkupExtension
{
	// Token: 0x060020ED RID: 8429 RVA: 0x00015B81 File Offset: 0x00013D81
	public double method_0()
	{
		return this.double_0;
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x00015B89 File Offset: 0x00013D89
	public void method_1(double double_6)
	{
		this.double_0 = double_6;
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x00015B92 File Offset: 0x00013D92
	public double method_2()
	{
		return this.double_1;
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x00015B9A File Offset: 0x00013D9A
	public void method_3(double double_6)
	{
		this.double_1 = double_6;
	}

	// Token: 0x170005A7 RID: 1447
	// (get) Token: 0x060020F1 RID: 8433 RVA: 0x00015BA3 File Offset: 0x00013DA3
	// (set) Token: 0x060020F2 RID: 8434 RVA: 0x00015BAB File Offset: 0x00013DAB
	public double Width
	{
		[CompilerGenerated]
		get
		{
			return this.double_2;
		}
		[CompilerGenerated]
		set
		{
			this.double_2 = value;
		}
	}

	// Token: 0x170005A8 RID: 1448
	// (get) Token: 0x060020F3 RID: 8435 RVA: 0x00015BB4 File Offset: 0x00013DB4
	// (set) Token: 0x060020F4 RID: 8436 RVA: 0x00015BBC File Offset: 0x00013DBC
	public double Height
	{
		[CompilerGenerated]
		get
		{
			return this.double_3;
		}
		[CompilerGenerated]
		set
		{
			this.double_3 = value;
		}
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x00015BC5 File Offset: 0x00013DC5
	public double method_4()
	{
		return this.double_4;
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x00015BCD File Offset: 0x00013DCD
	public void method_5(double double_6)
	{
		this.double_4 = double_6;
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x00015BD6 File Offset: 0x00013DD6
	public double method_6()
	{
		return this.double_5;
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x00015BDE File Offset: 0x00013DDE
	public void method_7(double double_6)
	{
		this.double_5 = double_6;
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x00084798 File Offset: 0x00082998
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		Geometry geometry = GClass212.smethod_0(this.Width, this.Height, this.method_4(), this.method_6()).Clone();
		if (this.method_0() != 0.0 || this.method_2() != 0.0)
		{
			geometry.Transform = new TranslateTransform(this.method_0(), this.method_2());
		}
		if (geometry.CanFreeze)
		{
			geometry.Freeze();
		}
		return geometry;
	}

	// Token: 0x040015ED RID: 5613
	private double double_0;

	// Token: 0x040015EE RID: 5614
	private double double_1;

	// Token: 0x040015EF RID: 5615
	private double double_2;

	// Token: 0x040015F0 RID: 5616
	private double double_3;

	// Token: 0x040015F1 RID: 5617
	private double double_4;

	// Token: 0x040015F2 RID: 5618
	private double double_5 = 0.2;
}
