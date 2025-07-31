using System;
using System.Runtime.CompilerServices;
using ns0;

// Token: 0x02000485 RID: 1157
public sealed class GClass208
{
	// Token: 0x06001E05 RID: 7685 RVA: 0x00013D2E File Offset: 0x00011F2E
	public uint method_0()
	{
		return this.uint_0;
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x00013D36 File Offset: 0x00011F36
	public void method_1(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x00013D3F File Offset: 0x00011F3F
	public string method_2()
	{
		return this.string_0;
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x00013D47 File Offset: 0x00011F47
	public void method_3(string string_4)
	{
		this.string_0 = string_4;
	}

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00013D50 File Offset: 0x00011F50
	public string SettingTextLoc
	{
		get
		{
			return Class298.smethod_2(this.method_2());
		}
	}

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00013D5D File Offset: 0x00011F5D
	public string SettingTextDescLoc
	{
		get
		{
			return Class298.smethod_2(this.method_2() + "Desc");
		}
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x00013D75 File Offset: 0x00011F75
	public string method_4()
	{
		return this.string_1;
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x00013D7D File Offset: 0x00011F7D
	public void method_5(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x00013D86 File Offset: 0x00011F86
	public string method_6()
	{
		return this.string_2;
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x00013D8E File Offset: 0x00011F8E
	public void method_7(string string_4)
	{
		this.string_2 = string_4;
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x00013D97 File Offset: 0x00011F97
	public object method_8()
	{
		return this.object_0;
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x00013D9F File Offset: 0x00011F9F
	public void method_9(object object_1)
	{
		this.object_0 = object_1;
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x00013DA8 File Offset: 0x00011FA8
	public string method_10()
	{
		return this.string_3;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x00013DB0 File Offset: 0x00011FB0
	public void method_11(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00013DB9 File Offset: 0x00011FB9
	// (set) Token: 0x06001E14 RID: 7700 RVA: 0x00013DC1 File Offset: 0x00011FC1
	public dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd State
	{
		[CompilerGenerated]
		get
		{
			return this.dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd_0;
		}
		[CompilerGenerated]
		set
		{
			this.dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd_0 = value;
		}
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x00013DCA File Offset: 0x00011FCA
	public bool method_12()
	{
		return this.bool_0;
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x00013DD2 File Offset: 0x00011FD2
	public void method_13(bool bool_3)
	{
		this.bool_0 = bool_3;
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x00013DDB File Offset: 0x00011FDB
	public bool method_14()
	{
		return this.bool_1;
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x00013DE3 File Offset: 0x00011FE3
	public void method_15(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x00013DEC File Offset: 0x00011FEC
	public bool method_16()
	{
		return this.bool_2;
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x00013DF4 File Offset: 0x00011FF4
	public void method_17(bool bool_3)
	{
		this.bool_2 = bool_3;
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x0007BF70 File Offset: 0x0007A170
	public override string ToString()
	{
		return string.Format("{0}; 0x{1:X8}; {2}; {3}; {4};", new object[]
		{
			this.State,
			this.method_0(),
			this.method_2(),
			this.method_4(),
			this.method_6()
		});
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x00013DFD File Offset: 0x00011FFD
	public string method_18()
	{
		return string.Format("(ID: {0}) {1} = {2}", this.method_0(), this.method_2(), this.method_4());
	}

	// Token: 0x040013FE RID: 5118
	private uint uint_0;

	// Token: 0x040013FF RID: 5119
	private string string_0;

	// Token: 0x04001400 RID: 5120
	private string string_1;

	// Token: 0x04001401 RID: 5121
	private string string_2;

	// Token: 0x04001402 RID: 5122
	private object object_0;

	// Token: 0x04001403 RID: 5123
	private string string_3;

	// Token: 0x04001404 RID: 5124
	private dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd_0;

	// Token: 0x04001405 RID: 5125
	private bool bool_0;

	// Token: 0x04001406 RID: 5126
	private bool bool_1;

	// Token: 0x04001407 RID: 5127
	private bool bool_2;
}
