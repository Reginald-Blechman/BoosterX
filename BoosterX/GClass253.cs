using System;
using System.Collections.Generic;
using System.Text;
using RAMSPDToolkit.SPD;

// Token: 0x020005C5 RID: 1477
public sealed class GClass253
{
	// Token: 0x060025C3 RID: 9667 RVA: 0x00019238 File Offset: 0x00017438
	public GClass253(DDR4Accessor ddr4Accessor_1)
	{
		if (ddr4Accessor_1 == null)
		{
			throw new ArgumentNullException("#=z0dJfuSA=");
		}
		this.ddr4Accessor_0 = ddr4Accessor_1;
		this.method_13(new List<int>());
		this.method_44();
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x00019268 File Offset: 0x00017468
	public double method_0()
	{
		return this.double_0;
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x00019270 File Offset: 0x00017470
	private void method_1(double double_14)
	{
		this.double_0 = double_14;
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x00019279 File Offset: 0x00017479
	public double method_2()
	{
		return this.double_1;
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x00019281 File Offset: 0x00017481
	private void method_3(double double_14)
	{
		this.double_1 = double_14;
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x0001928A File Offset: 0x0001748A
	public double method_4()
	{
		return this.method_0() / 1000.0;
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x0001929C File Offset: 0x0001749C
	public double method_5()
	{
		return this.method_2() / 1000.0;
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x000192AE File Offset: 0x000174AE
	public double method_6()
	{
		return this.double_2;
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x000192B6 File Offset: 0x000174B6
	private void method_7(double double_14)
	{
		this.double_2 = double_14;
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x000192BF File Offset: 0x000174BF
	public double method_8()
	{
		return this.method_6() / 1000.0;
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x000192D1 File Offset: 0x000174D1
	public double method_9()
	{
		return this.double_3;
	}

	// Token: 0x060025CE RID: 9678 RVA: 0x000192D9 File Offset: 0x000174D9
	private void method_10(double double_14)
	{
		this.double_3 = double_14;
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x000192E2 File Offset: 0x000174E2
	public double method_11()
	{
		return this.method_9() / 1000.0;
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x000192F4 File Offset: 0x000174F4
	public List<int> method_12()
	{
		return this.list_0;
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x000192FC File Offset: 0x000174FC
	private void method_13(List<int> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x00019305 File Offset: 0x00017505
	public double method_14()
	{
		return this.double_4;
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x0001930D File Offset: 0x0001750D
	private void method_15(double double_14)
	{
		this.double_4 = double_14;
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x00019316 File Offset: 0x00017516
	public double method_16()
	{
		return this.method_14() / 1000.0;
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x00019328 File Offset: 0x00017528
	public double method_17()
	{
		return this.double_5;
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x00019330 File Offset: 0x00017530
	private void method_18(double double_14)
	{
		this.double_5 = double_14;
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x00019339 File Offset: 0x00017539
	public double method_19()
	{
		return this.method_17() / 1000.0;
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x0001934B File Offset: 0x0001754B
	public double method_20()
	{
		return this.double_6;
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x00019353 File Offset: 0x00017553
	private void method_21(double double_14)
	{
		this.double_6 = double_14;
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x0001935C File Offset: 0x0001755C
	public double method_22()
	{
		return this.method_20() / 1000.0;
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x0001936E File Offset: 0x0001756E
	public double method_23()
	{
		return this.double_7;
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x00019376 File Offset: 0x00017576
	private void method_24(double double_14)
	{
		this.double_7 = double_14;
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x0001937F File Offset: 0x0001757F
	public double method_25()
	{
		return this.method_23() / 1000.0;
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x00019391 File Offset: 0x00017591
	public double method_26()
	{
		return this.double_8;
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x00019399 File Offset: 0x00017599
	private void method_27(double double_14)
	{
		this.double_8 = double_14;
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x000193A2 File Offset: 0x000175A2
	public double method_28()
	{
		return this.method_26() / 1000.0;
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x000193B4 File Offset: 0x000175B4
	public double method_29()
	{
		return this.double_9;
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x000193BC File Offset: 0x000175BC
	private void method_30(double double_14)
	{
		this.double_9 = double_14;
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x000193C5 File Offset: 0x000175C5
	public double method_31()
	{
		return this.method_29() / 1000.0;
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x000193D7 File Offset: 0x000175D7
	public double method_32()
	{
		return this.double_10;
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x000193DF File Offset: 0x000175DF
	private void method_33(double double_14)
	{
		this.double_10 = double_14;
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x000193E8 File Offset: 0x000175E8
	public double method_34()
	{
		return this.method_32() / 1000.0;
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x000193FA File Offset: 0x000175FA
	public double method_35()
	{
		return this.double_11;
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x00019402 File Offset: 0x00017602
	private void method_36(double double_14)
	{
		this.double_11 = double_14;
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x0001940B File Offset: 0x0001760B
	public double method_37()
	{
		return this.method_35() / 1000.0;
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x0001941D File Offset: 0x0001761D
	public double method_38()
	{
		return this.double_12;
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x00019425 File Offset: 0x00017625
	private void method_39(double double_14)
	{
		this.double_12 = double_14;
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x0001942E File Offset: 0x0001762E
	public double method_40()
	{
		return this.method_38() / 1000.0;
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x00019440 File Offset: 0x00017640
	public double method_41()
	{
		return this.double_13;
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x00019448 File Offset: 0x00017648
	private void method_42(double double_14)
	{
		this.double_13 = double_14;
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x00019451 File Offset: 0x00017651
	public double method_43()
	{
		return this.method_41() / 1000.0;
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x00091E18 File Offset: 0x00090018
	private void method_44()
	{
		byte b = this.ddr4Accessor_0.At(17);
		if ((b & 7) == 0)
		{
			this.method_1(125.0);
		}
		else
		{
			this.method_1(125.0);
		}
		switch (b >> 3 & 3)
		{
		case 0:
			this.method_3(1.0);
			break;
		case 1:
			this.method_3(2.0);
			break;
		case 2:
			this.method_3(4.0);
			break;
		case 3:
			this.method_3(8.0);
			break;
		default:
			this.method_3(1.0);
			break;
		}
		byte b2 = this.ddr4Accessor_0.At(18);
		sbyte b3 = (sbyte)this.ddr4Accessor_0.At(125);
		this.method_7((double)b2 * this.method_0() + (double)b3 * this.method_2());
		byte b4 = this.ddr4Accessor_0.At(19);
		sbyte b5 = (sbyte)this.ddr4Accessor_0.At(124);
		this.method_10((double)b4 * this.method_0() + (double)b5 * this.method_2());
		byte b6 = this.ddr4Accessor_0.At(20);
		byte b7 = this.ddr4Accessor_0.At(21);
		byte b8 = this.ddr4Accessor_0.At(22);
		byte b9 = this.ddr4Accessor_0.At(23);
		for (int i = 0; i < 8; i++)
		{
			if ((b6 >> i & 1) == 1)
			{
				this.method_12().Add(9 + i);
			}
		}
		for (int j = 0; j < 8; j++)
		{
			if ((b7 >> j & 1) == 1)
			{
				this.method_12().Add(17 + j);
			}
		}
		for (int k = 0; k < 8; k++)
		{
			if ((b8 >> k & 1) == 1)
			{
				this.method_12().Add(25 + k);
			}
		}
		for (int l = 0; l < 8; l++)
		{
			if ((b9 >> l & 1) == 1)
			{
				this.method_12().Add(33 + l);
			}
		}
		this.method_12().Sort();
		byte b10 = this.ddr4Accessor_0.At(24);
		sbyte b11 = (sbyte)this.ddr4Accessor_0.At(123);
		this.method_15((double)b10 * this.method_0() + (double)b11 * this.method_2());
		byte b12 = this.ddr4Accessor_0.At(25);
		sbyte b13 = (sbyte)this.ddr4Accessor_0.At(122);
		this.method_18((double)b12 * this.method_0() + (double)b13 * this.method_2());
		byte b14 = this.ddr4Accessor_0.At(26);
		sbyte b15 = (sbyte)this.ddr4Accessor_0.At(121);
		this.method_21((double)b14 * this.method_0() + (double)b15 * this.method_2());
		byte b16 = this.ddr4Accessor_0.At(28);
		byte b17 = this.ddr4Accessor_0.At(27);
		int num = (int)(b17 & 15) << 8 | (int)b16;
		this.method_24((double)num * this.method_0());
		byte b18 = this.ddr4Accessor_0.At(29);
		int num2 = b17 >> 4 & 15;
		sbyte b19 = (sbyte)this.ddr4Accessor_0.At(120);
		int num3 = num2 << 8 | (int)b18;
		this.method_27((double)num3 * this.method_0() + (double)b19 * this.method_2());
		byte b20 = this.ddr4Accessor_0.At(19);
		sbyte b21 = (sbyte)this.ddr4Accessor_0.At(119);
		this.method_30((double)b20 * this.method_0() + (double)b21 * this.method_2());
		sbyte b22 = (sbyte)this.ddr4Accessor_0.At(118);
		this.method_33((double)b20 * this.method_0() + (double)b22 * this.method_2());
		byte b23 = this.ddr4Accessor_0.At(42);
		int num4 = (int)(this.ddr4Accessor_0.At(41) & 15) << 8 | (int)b23;
		this.method_36((double)num4 * this.method_0());
		byte b24 = this.ddr4Accessor_0.At(27);
		this.method_39((double)b24 * this.method_0());
		int num5 = (int)this.ddr4Accessor_0.At(36);
		byte b25 = this.ddr4Accessor_0.At(37);
		int num6 = (num5 & 15) << 8 | (int)b25;
		this.method_42((double)num6 * this.method_0());
	}

	// Token: 0x060025F1 RID: 9713 RVA: 0x0009223C File Offset: 0x0009043C
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(string.Format("DDR4 Timings (MTB: {0}ps, FTB: {1}ps):", this.method_0(), this.method_2()));
		stringBuilder.AppendLine(string.Format("  tCKAVGmin: {0:F3} ns ({1} ps)", this.method_8(), this.method_6()));
		stringBuilder.AppendLine(string.Format("  tCKAVGmax: {0:F3} ns ({1} ps)", this.method_11(), this.method_9()));
		stringBuilder.AppendLine("  Supported CLs: " + string.Join<int>(", ", this.method_12()));
		stringBuilder.AppendLine(string.Format("  tAAmin (CAS Latency): {0:F3} ns ({1} ps)", this.method_16(), this.method_14()));
		stringBuilder.AppendLine(string.Format("  tRCDmin: {0:F3} ns ({1} ps)", this.method_19(), this.method_17()));
		stringBuilder.AppendLine(string.Format("  tRPmin: {0:F3} ns ({1} ps)", this.method_22(), this.method_20()));
		stringBuilder.AppendLine(string.Format("  tRASmin: {0:F3} ns ({1} ps)", this.method_25(), this.method_23()));
		stringBuilder.AppendLine(string.Format("  tRCmin: {0:F3} ns ({1} ps)", this.method_28(), this.method_26()));
		stringBuilder.AppendLine(string.Format("  tRRD_Smin: {0:F3} ns ({1} ps)", this.method_31(), this.method_29()));
		stringBuilder.AppendLine(string.Format("  tRRD_Lmin: {0:F3} ns ({1} ps)", this.method_34(), this.method_32()));
		stringBuilder.AppendLine(string.Format("  tWRmin: {0:F3} ns ({1} ps)", this.method_37(), this.method_35()));
		stringBuilder.AppendLine(string.Format("  tRTPmin: {0:F3} ns ({1} ps)", this.method_40(), this.method_38()));
		stringBuilder.AppendLine(string.Format("  tFAWmin: {0:F3} ns ({1} ps)", this.method_43(), this.method_41()));
		return stringBuilder.ToString();
	}

	// Token: 0x040018D9 RID: 6361
	private DDR4Accessor ddr4Accessor_0;

	// Token: 0x040018DA RID: 6362
	private double double_0;

	// Token: 0x040018DB RID: 6363
	private double double_1;

	// Token: 0x040018DC RID: 6364
	private double double_2;

	// Token: 0x040018DD RID: 6365
	private double double_3;

	// Token: 0x040018DE RID: 6366
	private List<int> list_0;

	// Token: 0x040018DF RID: 6367
	private double double_4;

	// Token: 0x040018E0 RID: 6368
	private double double_5;

	// Token: 0x040018E1 RID: 6369
	private double double_6;

	// Token: 0x040018E2 RID: 6370
	private double double_7;

	// Token: 0x040018E3 RID: 6371
	private double double_8;

	// Token: 0x040018E4 RID: 6372
	private double double_9;

	// Token: 0x040018E5 RID: 6373
	private double double_10;

	// Token: 0x040018E6 RID: 6374
	private double double_11;

	// Token: 0x040018E7 RID: 6375
	private double double_12;

	// Token: 0x040018E8 RID: 6376
	private double double_13;
}
