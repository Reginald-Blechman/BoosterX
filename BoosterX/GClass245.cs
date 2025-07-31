using System;

// Token: 0x0200058C RID: 1420
public sealed class GClass245
{
	// Token: 0x060023A9 RID: 9129 RVA: 0x0008C29C File Offset: 0x0008A49C
	public GClass245(string string_1, int[] int_0)
	{
		this.method_1(string_1);
		GClass14 gclass = new GClass14();
		gclass.method_3((byte)int_0[5]);
		gclass.method_5((byte)int_0[6]);
		gclass.method_7((byte)int_0[7]);
		gclass.method_1((byte)int_0[8]);
		this.method_33(gclass);
		this.method_9((float)(int_0[11] & 7));
		this.method_23((int_0[14] >> 4 & 4) != 0);
		this.method_13((float)int_0[4] / 2f);
		this.method_25((int_0[11] & 8) != 0);
		this.method_19((float)(int_0[11] >> 4) / 10f);
		this.method_17((float)(int_0[12] >> 4) / 10f);
		this.method_21((float)(int_0[12] & 15) / 10f);
		this.method_15((float)int_0[9]);
		this.method_3((float)int_0[15] / 10f);
		this.method_5((float)int_0[13] / 10f);
		this.method_29((int_0[14] >> 4 & 8) != 0);
		this.method_27((int_0[14] >> 4 & 1) != 0);
		this.method_35((GEnum1)((int_0[14] & 15) >> 1));
		this.method_7((float)(int_0[3] << 24 >> 24) / 10f);
		this.method_11((float)(int_0[10] << 24 >> 24) / 10f);
		this.method_31((int_0[14] >> 4 & 2) == 2);
	}

	// Token: 0x060023AA RID: 9130 RVA: 0x00017705 File Offset: 0x00015905
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x060023AB RID: 9131 RVA: 0x0001770D File Offset: 0x0001590D
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060023AC RID: 9132 RVA: 0x00017716 File Offset: 0x00015916
	public float method_2()
	{
		return this.float_0;
	}

	// Token: 0x060023AD RID: 9133 RVA: 0x0001771E File Offset: 0x0001591E
	private void method_3(float float_10)
	{
		this.float_0 = float_10;
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x00017727 File Offset: 0x00015927
	public float method_4()
	{
		return this.float_1;
	}

	// Token: 0x060023AF RID: 9135 RVA: 0x0001772F File Offset: 0x0001592F
	private void method_5(float float_10)
	{
		this.float_1 = float_10;
	}

	// Token: 0x060023B0 RID: 9136 RVA: 0x00017738 File Offset: 0x00015938
	public float method_6()
	{
		return this.float_2;
	}

	// Token: 0x060023B1 RID: 9137 RVA: 0x00017740 File Offset: 0x00015940
	private void method_7(float float_10)
	{
		this.float_2 = float_10;
	}

	// Token: 0x060023B2 RID: 9138 RVA: 0x00017749 File Offset: 0x00015949
	public float method_8()
	{
		return this.float_3;
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x00017751 File Offset: 0x00015951
	private void method_9(float float_10)
	{
		this.float_3 = float_10;
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x0001775A File Offset: 0x0001595A
	public float method_10()
	{
		return this.float_4;
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x00017762 File Offset: 0x00015962
	private void method_11(float float_10)
	{
		this.float_4 = float_10;
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x0001776B File Offset: 0x0001596B
	public float method_12()
	{
		return this.float_5;
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x00017773 File Offset: 0x00015973
	private void method_13(float float_10)
	{
		this.float_5 = float_10;
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x0001777C File Offset: 0x0001597C
	public float method_14()
	{
		return this.float_6;
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x00017784 File Offset: 0x00015984
	private void method_15(float float_10)
	{
		this.float_6 = float_10;
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x0001778D File Offset: 0x0001598D
	public float method_16()
	{
		return this.float_7;
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x00017795 File Offset: 0x00015995
	private void method_17(float float_10)
	{
		this.float_7 = float_10;
	}

	// Token: 0x060023BC RID: 9148 RVA: 0x0001779E File Offset: 0x0001599E
	public float method_18()
	{
		return this.float_8;
	}

	// Token: 0x060023BD RID: 9149 RVA: 0x000177A6 File Offset: 0x000159A6
	private void method_19(float float_10)
	{
		this.float_8 = float_10;
	}

	// Token: 0x060023BE RID: 9150 RVA: 0x000177AF File Offset: 0x000159AF
	public float method_20()
	{
		return this.float_9;
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x000177B7 File Offset: 0x000159B7
	private void method_21(float float_10)
	{
		this.float_9 = float_10;
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x000177C0 File Offset: 0x000159C0
	public bool method_22()
	{
		return this.bool_0;
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x000177C8 File Offset: 0x000159C8
	private void method_23(bool bool_5)
	{
		this.bool_0 = bool_5;
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x000177D1 File Offset: 0x000159D1
	public bool method_24()
	{
		return this.bool_1;
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x000177D9 File Offset: 0x000159D9
	private void method_25(bool bool_5)
	{
		this.bool_1 = bool_5;
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x000177E2 File Offset: 0x000159E2
	public bool method_26()
	{
		return this.bool_2;
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x000177EA File Offset: 0x000159EA
	private void method_27(bool bool_5)
	{
		this.bool_2 = bool_5;
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x000177F3 File Offset: 0x000159F3
	public bool method_28()
	{
		return this.bool_3;
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x000177FB File Offset: 0x000159FB
	private void method_29(bool bool_5)
	{
		this.bool_3 = bool_5;
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x00017804 File Offset: 0x00015A04
	public bool method_30()
	{
		return this.bool_4;
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x0001780C File Offset: 0x00015A0C
	private void method_31(bool bool_5)
	{
		this.bool_4 = bool_5;
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x00017815 File Offset: 0x00015A15
	public GClass14 method_32()
	{
		return this.gclass14_0;
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x0001781D File Offset: 0x00015A1D
	private void method_33(GClass14 gclass14_1)
	{
		this.gclass14_0 = gclass14_1;
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x00017826 File Offset: 0x00015A26
	public GEnum1 method_34()
	{
		return this.genum1_0;
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x0001782E File Offset: 0x00015A2E
	private void method_35(GEnum1 genum1_1)
	{
		this.genum1_0 = genum1_1;
	}

	// Token: 0x0400178E RID: 6030
	private string string_0;

	// Token: 0x0400178F RID: 6031
	private float float_0;

	// Token: 0x04001790 RID: 6032
	private float float_1;

	// Token: 0x04001791 RID: 6033
	private float float_2;

	// Token: 0x04001792 RID: 6034
	private float float_3;

	// Token: 0x04001793 RID: 6035
	private float float_4;

	// Token: 0x04001794 RID: 6036
	private float float_5;

	// Token: 0x04001795 RID: 6037
	private float float_6;

	// Token: 0x04001796 RID: 6038
	private float float_7;

	// Token: 0x04001797 RID: 6039
	private float float_8;

	// Token: 0x04001798 RID: 6040
	private float float_9;

	// Token: 0x04001799 RID: 6041
	private bool bool_0;

	// Token: 0x0400179A RID: 6042
	private bool bool_1;

	// Token: 0x0400179B RID: 6043
	private bool bool_2;

	// Token: 0x0400179C RID: 6044
	private bool bool_3;

	// Token: 0x0400179D RID: 6045
	private bool bool_4;

	// Token: 0x0400179E RID: 6046
	private GClass14 gclass14_0;

	// Token: 0x0400179F RID: 6047
	private GEnum1 genum1_0;
}
