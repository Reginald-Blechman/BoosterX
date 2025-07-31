using System;
using System.Collections.Generic;
using System.Text;
using RAMSPDToolkit.SPD;

// Token: 0x02000520 RID: 1312
public sealed class GClass228
{
	// Token: 0x0600210D RID: 8461 RVA: 0x00085678 File Offset: 0x00083878
	public GClass228(DDR5Accessor ddr5Accessor_1)
	{
		if (ddr5Accessor_1 == null)
		{
			throw new ArgumentNullException("#=z0dJfuSA=");
		}
		this.ddr5Accessor_0 = ddr5Accessor_1;
		this.method_27(new List<int>());
		this.method_59(new byte[4]);
		this.method_67(new byte[12]);
		this.method_117();
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x00015C5F File Offset: 0x00013E5F
	public byte method_0()
	{
		return this.byte_0;
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x00015C67 File Offset: 0x00013E67
	private void method_1(byte byte_23)
	{
		this.byte_0 = byte_23;
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x00015C70 File Offset: 0x00013E70
	public byte method_2()
	{
		return this.byte_1;
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x00015C78 File Offset: 0x00013E78
	private void method_3(byte byte_23)
	{
		this.byte_1 = byte_23;
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x00015C81 File Offset: 0x00013E81
	public byte method_4()
	{
		return this.byte_2;
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x00015C89 File Offset: 0x00013E89
	private void method_5(byte byte_23)
	{
		this.byte_2 = byte_23;
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x00015C92 File Offset: 0x00013E92
	public byte method_6()
	{
		return this.byte_3;
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x00015C9A File Offset: 0x00013E9A
	private void method_7(byte byte_23)
	{
		this.byte_3 = byte_23;
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x00015CA3 File Offset: 0x00013EA3
	public byte method_8()
	{
		return this.byte_4;
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x00015CAB File Offset: 0x00013EAB
	private void method_9(byte byte_23)
	{
		this.byte_4 = byte_23;
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x00015CB4 File Offset: 0x00013EB4
	public byte method_10()
	{
		return this.byte_5;
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x00015CBC File Offset: 0x00013EBC
	private void method_11(byte byte_23)
	{
		this.byte_5 = byte_23;
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x00015CC5 File Offset: 0x00013EC5
	public byte method_12()
	{
		return this.byte_6;
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x00015CCD File Offset: 0x00013ECD
	private void method_13(byte byte_23)
	{
		this.byte_6 = byte_23;
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x00015CD6 File Offset: 0x00013ED6
	public byte method_14()
	{
		return this.byte_7;
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x00015CDE File Offset: 0x00013EDE
	private void method_15(byte byte_23)
	{
		this.byte_7 = byte_23;
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x00015CE7 File Offset: 0x00013EE7
	public byte method_16()
	{
		return this.byte_8;
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x00015CEF File Offset: 0x00013EEF
	private void method_17(byte byte_23)
	{
		this.byte_8 = byte_23;
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x00015CF8 File Offset: 0x00013EF8
	public byte method_18()
	{
		return this.byte_9;
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x00015D00 File Offset: 0x00013F00
	private void method_19(byte byte_23)
	{
		this.byte_9 = byte_23;
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x00015D09 File Offset: 0x00013F09
	public ushort method_20()
	{
		return this.ushort_0;
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x00015D11 File Offset: 0x00013F11
	private void method_21(ushort ushort_25)
	{
		this.ushort_0 = ushort_25;
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x00015D1A File Offset: 0x00013F1A
	public double method_22()
	{
		return (double)this.method_20() / 1000.0;
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x00015D2D File Offset: 0x00013F2D
	public ushort method_23()
	{
		return this.ushort_1;
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x00015D35 File Offset: 0x00013F35
	private void method_24(ushort ushort_25)
	{
		this.ushort_1 = ushort_25;
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x00015D3E File Offset: 0x00013F3E
	public double method_25()
	{
		return (double)this.method_23() / 1000.0;
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x00015D51 File Offset: 0x00013F51
	public List<int> method_26()
	{
		return this.list_0;
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x00015D59 File Offset: 0x00013F59
	private void method_27(List<int> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x00015D62 File Offset: 0x00013F62
	public ushort method_28()
	{
		return this.ushort_2;
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x00015D6A File Offset: 0x00013F6A
	private void method_29(ushort ushort_25)
	{
		this.ushort_2 = ushort_25;
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x00015D73 File Offset: 0x00013F73
	public double method_30()
	{
		return (double)this.method_28() / 1000.0;
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x00015D86 File Offset: 0x00013F86
	public ushort method_31()
	{
		return this.ushort_3;
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x00015D8E File Offset: 0x00013F8E
	private void method_32(ushort ushort_25)
	{
		this.ushort_3 = ushort_25;
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x00015D97 File Offset: 0x00013F97
	public double method_33()
	{
		return (double)this.method_31() / 1000.0;
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x00015DAA File Offset: 0x00013FAA
	public ushort method_34()
	{
		return this.ushort_4;
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x00015DB2 File Offset: 0x00013FB2
	private void method_35(ushort ushort_25)
	{
		this.ushort_4 = ushort_25;
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x00015DBB File Offset: 0x00013FBB
	public double method_36()
	{
		return (double)this.method_34() / 1000.0;
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x00015DCE File Offset: 0x00013FCE
	public ushort method_37()
	{
		return this.ushort_5;
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x00015DD6 File Offset: 0x00013FD6
	private void method_38(ushort ushort_25)
	{
		this.ushort_5 = ushort_25;
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x00015DDF File Offset: 0x00013FDF
	public double method_39()
	{
		return (double)this.method_37() / 1000.0;
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x00015DF2 File Offset: 0x00013FF2
	public ushort method_40()
	{
		return this.ushort_6;
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x00015DFA File Offset: 0x00013FFA
	private void method_41(ushort ushort_25)
	{
		this.ushort_6 = ushort_25;
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x00015E03 File Offset: 0x00014003
	public double method_42()
	{
		return (double)this.method_40() / 1000.0;
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x00015E16 File Offset: 0x00014016
	public ushort method_43()
	{
		return this.ushort_7;
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x00015E1E File Offset: 0x0001401E
	private void method_44(ushort ushort_25)
	{
		this.ushort_7 = ushort_25;
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x00015E27 File Offset: 0x00014027
	public double method_45()
	{
		return (double)this.method_43() / 1000.0;
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x00015E3A File Offset: 0x0001403A
	public ushort method_46()
	{
		return this.ushort_8;
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x00015E42 File Offset: 0x00014042
	private void method_47(ushort ushort_25)
	{
		this.ushort_8 = ushort_25;
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x00015E4B File Offset: 0x0001404B
	public ushort method_48()
	{
		return this.ushort_9;
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x00015E53 File Offset: 0x00014053
	private void method_49(ushort ushort_25)
	{
		this.ushort_9 = ushort_25;
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x00015E5C File Offset: 0x0001405C
	public ushort method_50()
	{
		return this.ushort_10;
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x00015E64 File Offset: 0x00014064
	private void method_51(ushort ushort_25)
	{
		this.ushort_10 = ushort_25;
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x00015E6D File Offset: 0x0001406D
	public ushort method_52()
	{
		return this.ushort_11;
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x00015E75 File Offset: 0x00014075
	private void method_53(ushort ushort_25)
	{
		this.ushort_11 = ushort_25;
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x00015E7E File Offset: 0x0001407E
	public ushort method_54()
	{
		return this.ushort_12;
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x00015E86 File Offset: 0x00014086
	private void method_55(ushort ushort_25)
	{
		this.ushort_12 = ushort_25;
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x00015E8F File Offset: 0x0001408F
	public ushort method_56()
	{
		return this.ushort_13;
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x00015E97 File Offset: 0x00014097
	private void method_57(ushort ushort_25)
	{
		this.ushort_13 = ushort_25;
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x00015EA0 File Offset: 0x000140A0
	public byte[] method_58()
	{
		return this.byte_10;
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x00015EA8 File Offset: 0x000140A8
	private void method_59(byte[] byte_23)
	{
		this.byte_10 = byte_23;
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x00015EB1 File Offset: 0x000140B1
	public bool method_60()
	{
		return this.bool_0;
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x00015EB9 File Offset: 0x000140B9
	private void method_61(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x00015EC2 File Offset: 0x000140C2
	public bool method_62()
	{
		return this.bool_1;
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x00015ECA File Offset: 0x000140CA
	private void method_63(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x00015ED3 File Offset: 0x000140D3
	public int method_64()
	{
		return this.int_0;
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x00015EDB File Offset: 0x000140DB
	private void method_65(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x00015EE4 File Offset: 0x000140E4
	public byte[] method_66()
	{
		return this.byte_11;
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x00015EEC File Offset: 0x000140EC
	private void method_67(byte[] byte_23)
	{
		this.byte_11 = byte_23;
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x00015EF5 File Offset: 0x000140F5
	public ushort method_68()
	{
		return this.ushort_14;
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x00015EFD File Offset: 0x000140FD
	private void method_69(ushort ushort_25)
	{
		this.ushort_14 = ushort_25;
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00015F06 File Offset: 0x00014106
	public byte method_70()
	{
		return this.byte_12;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x00015F0E File Offset: 0x0001410E
	private void method_71(byte byte_23)
	{
		this.byte_12 = byte_23;
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x00015F17 File Offset: 0x00014117
	public ushort method_72()
	{
		return this.ushort_15;
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x00015F1F File Offset: 0x0001411F
	private void method_73(ushort ushort_25)
	{
		this.ushort_15 = ushort_25;
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x00015F28 File Offset: 0x00014128
	public byte method_74()
	{
		return this.byte_13;
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x00015F30 File Offset: 0x00014130
	private void method_75(byte byte_23)
	{
		this.byte_13 = byte_23;
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x00015F39 File Offset: 0x00014139
	public ushort method_76()
	{
		return this.ushort_16;
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x00015F41 File Offset: 0x00014141
	private void method_77(ushort ushort_25)
	{
		this.ushort_16 = ushort_25;
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x00015F4A File Offset: 0x0001414A
	public byte method_78()
	{
		return this.byte_14;
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x00015F52 File Offset: 0x00014152
	private void method_79(byte byte_23)
	{
		this.byte_14 = byte_23;
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x00015F5B File Offset: 0x0001415B
	public ushort method_80()
	{
		return this.ushort_17;
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x00015F63 File Offset: 0x00014163
	private void method_81(ushort ushort_25)
	{
		this.ushort_17 = ushort_25;
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x00015F6C File Offset: 0x0001416C
	public byte method_82()
	{
		return this.byte_15;
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x00015F74 File Offset: 0x00014174
	private void method_83(byte byte_23)
	{
		this.byte_15 = byte_23;
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x00015F7D File Offset: 0x0001417D
	public ushort method_84()
	{
		return this.ushort_18;
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x00015F85 File Offset: 0x00014185
	private void method_85(ushort ushort_25)
	{
		this.ushort_18 = ushort_25;
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x00015F8E File Offset: 0x0001418E
	public byte method_86()
	{
		return this.byte_16;
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x00015F96 File Offset: 0x00014196
	private void method_87(byte byte_23)
	{
		this.byte_16 = byte_23;
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x00015F9F File Offset: 0x0001419F
	public ushort method_88()
	{
		return this.ushort_19;
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x00015FA7 File Offset: 0x000141A7
	private void method_89(ushort ushort_25)
	{
		this.ushort_19 = ushort_25;
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x00015FB0 File Offset: 0x000141B0
	public byte method_90()
	{
		return this.byte_17;
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x00015FB8 File Offset: 0x000141B8
	private void method_91(byte byte_23)
	{
		this.byte_17 = byte_23;
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x00015FC1 File Offset: 0x000141C1
	public ushort method_92()
	{
		return this.ushort_20;
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x00015FC9 File Offset: 0x000141C9
	private void method_93(ushort ushort_25)
	{
		this.ushort_20 = ushort_25;
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x00015FD2 File Offset: 0x000141D2
	public byte method_94()
	{
		return this.byte_18;
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x00015FDA File Offset: 0x000141DA
	private void method_95(byte byte_23)
	{
		this.byte_18 = byte_23;
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x00015FE3 File Offset: 0x000141E3
	public ushort method_96()
	{
		return this.ushort_21;
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x00015FEB File Offset: 0x000141EB
	private void method_97(ushort ushort_25)
	{
		this.ushort_21 = ushort_25;
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x00015FF4 File Offset: 0x000141F4
	public byte method_98()
	{
		return this.byte_19;
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x00015FFC File Offset: 0x000141FC
	private void method_99(byte byte_23)
	{
		this.byte_19 = byte_23;
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x00016005 File Offset: 0x00014205
	public ushort method_100()
	{
		return this.ushort_22;
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x0001600D File Offset: 0x0001420D
	private void method_101(ushort ushort_25)
	{
		this.ushort_22 = ushort_25;
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x00016016 File Offset: 0x00014216
	public byte method_102()
	{
		return this.byte_20;
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x0001601E File Offset: 0x0001421E
	private void method_103(byte byte_23)
	{
		this.byte_20 = byte_23;
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x00016027 File Offset: 0x00014227
	public ushort method_104()
	{
		return this.ushort_23;
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x0001602F File Offset: 0x0001422F
	private void method_105(ushort ushort_25)
	{
		this.ushort_23 = ushort_25;
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x00016038 File Offset: 0x00014238
	public byte method_106()
	{
		return this.byte_21;
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x00016040 File Offset: 0x00014240
	private void method_107(byte byte_23)
	{
		this.byte_21 = byte_23;
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x00016049 File Offset: 0x00014249
	public ushort method_108()
	{
		return this.ushort_24;
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x00016051 File Offset: 0x00014251
	private void method_109(ushort ushort_25)
	{
		this.ushort_24 = ushort_25;
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x0001605A File Offset: 0x0001425A
	public byte method_110()
	{
		return this.byte_22;
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x00016062 File Offset: 0x00014262
	private void method_111(byte byte_23)
	{
		this.byte_22 = byte_23;
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x0001606B File Offset: 0x0001426B
	public double method_112()
	{
		return this.double_0;
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x00016073 File Offset: 0x00014273
	private void method_113(double double_2)
	{
		this.double_0 = double_2;
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x0001607C File Offset: 0x0001427C
	public double method_114()
	{
		return this.double_1;
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x00016084 File Offset: 0x00014284
	private void method_115(double double_2)
	{
		this.double_1 = double_2;
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x0001608D File Offset: 0x0001428D
	private ushort method_116(ushort ushort_25)
	{
		return (ushort)((int)this.ddr5Accessor_0.At(ushort_25 + 1) << 8 | (int)this.ddr5Accessor_0.At(ushort_25));
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x000856CC File Offset: 0x000838CC
	private void method_117()
	{
		byte b = this.ddr5Accessor_0.At(0);
		this.method_1((byte)(b >> 4 & 7));
		this.method_3((byte)((b >> 7 & 1) << 4 | (int)(b & 15)));
		byte b2 = this.ddr5Accessor_0.At(1);
		this.method_5((byte)(b2 >> 4));
		this.method_7(b2 & 15);
		this.method_9(this.ddr5Accessor_0.At(2));
		byte b3 = this.ddr5Accessor_0.At(3);
		this.method_11(b3 & 15);
		this.method_13((byte)(b3 >> 4 & 7));
		this.method_15(this.ddr5Accessor_0.At(16));
		this.method_17(this.ddr5Accessor_0.At(17));
		this.method_19(this.ddr5Accessor_0.At(18));
		this.method_21(this.method_116(20));
		this.method_24(this.method_116(22));
		int num = 20;
		int i = 0;
		while (i < 5)
		{
			byte b4 = this.ddr5Accessor_0.At((ushort)(24 + i));
			for (int j = 0; j < 8; j++)
			{
				if ((b4 >> j & 1) == 1)
				{
					this.method_26().Add(num + j * 2);
				}
			}
			i++;
			num += 16;
		}
		this.method_26().Sort();
		this.method_29(this.method_116(30));
		this.method_32(this.method_116(32));
		this.method_35(this.method_116(34));
		this.method_38(this.method_116(36));
		this.method_41(this.method_116(38));
		this.method_44(this.method_116(40));
		this.method_47(this.method_116(42));
		this.method_49(this.method_116(44));
		this.method_51(this.method_116(46));
		this.method_53(this.method_116(48));
		this.method_55(this.method_116(50));
		this.method_57(this.method_116(52));
		for (int k = 0; k < 4; k++)
		{
			this.method_58()[k] = this.ddr5Accessor_0.At((ushort)(54 + k));
		}
		byte b5 = this.method_58()[1];
		this.method_63((b5 >> 5 & 1) == 1);
		this.method_65((int)(b5 & 7));
		this.method_61((this.method_58()[0] >> 1 & 1) == 1);
		for (int l = 0; l < 12; l++)
		{
			this.method_66()[l] = this.ddr5Accessor_0.At((ushort)(58 + l));
		}
		this.method_69(this.method_116(70));
		this.method_71(this.ddr5Accessor_0.At(72));
		this.method_73(this.method_116(73));
		this.method_75(this.ddr5Accessor_0.At(75));
		this.method_77(this.method_116(76));
		this.method_79(this.ddr5Accessor_0.At(78));
		this.method_81(this.method_116(79));
		this.method_83(this.ddr5Accessor_0.At(81));
		this.method_85(this.method_116(82));
		this.method_87(this.ddr5Accessor_0.At(84));
		this.method_89(this.method_116(85));
		this.method_91(this.ddr5Accessor_0.At(87));
		this.method_93(this.method_116(88));
		this.method_95(this.ddr5Accessor_0.At(90));
		this.method_97(this.method_116(91));
		this.method_99(this.ddr5Accessor_0.At(93));
		this.method_101(this.method_116(94));
		this.method_103(this.ddr5Accessor_0.At(96));
		this.method_105(this.method_116(97));
		this.method_107(this.ddr5Accessor_0.At(99));
		this.method_109(this.method_116(100));
		this.method_111(this.ddr5Accessor_0.At(102));
		this.method_113(1000000.0 / ((double)this.method_20() / 1000.0));
		if (!this.method_62())
		{
			if (this.method_64() != 1)
			{
				if (this.method_64() != 2)
				{
					if (this.method_64() != 3 && this.method_64() != 4)
					{
						if (this.method_64() != 5)
						{
							this.method_115(1.0);
							return;
						}
					}
					this.method_115(0.5);
					return;
				}
			}
			this.method_115(1.0);
			return;
		}
		if (this.method_64() != 0 && this.method_64() != 1)
		{
			if (this.method_64() != 2)
			{
				if (this.method_64() != 3 && this.method_64() != 4 && this.method_64() != 5)
				{
					if (this.method_64() != 6)
					{
						this.method_115(1.0);
						return;
					}
				}
				this.method_115(0.5);
				return;
			}
		}
		this.method_115(1.0);
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x000160AE File Offset: 0x000142AE
	public double method_118(double double_2)
	{
		return double_2 * this.method_114();
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x000160B8 File Offset: 0x000142B8
	public double method_119()
	{
		return 1000.0 / ((double)this.method_20() / 1000.0);
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x00085BA8 File Offset: 0x00083DA8
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("DDR5 Timings (JESD400-5C):");
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(string.Format("  SPD Revision (Base): {0}.{1}", this.method_4(), this.method_6()));
		stringBuilder.AppendLine(string.Format("  Module Type: 0x{0:X2}, Host Protocol: 0x{1:X2}", this.method_10(), this.method_8()));
		stringBuilder.AppendLine(string.Format("  Nominal Voltages: VDD = 0x{0:X2}, VDDQ = 0x{1:X2}, VPP = 0x{2:X2}", this.method_14(), this.method_16(), this.method_18()));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(string.Format("  tCKAVGmin: {0:F3} ns ({1} ps) → DRAM Freq ≈ {2:F1} MHz", this.method_22(), this.method_20(), this.method_119()));
		stringBuilder.AppendLine(string.Format("  tCKAVGmax: {0:F3} ns ({1} ps)", this.method_25(), this.method_23()));
		stringBuilder.AppendLine("  Supported CLs: " + string.Join<int>(", ", this.method_26()));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(string.Format("  tAAmin: {0:F3} ns ({1} ps)", this.method_30(), this.method_28()));
		stringBuilder.AppendLine(string.Format("  tRCDmin: {0:F3} ns ({1} ps)", this.method_33(), this.method_31()));
		stringBuilder.AppendLine(string.Format("  tRPmin: {0:F3} ns ({1} ps)", this.method_36(), this.method_34()));
		stringBuilder.AppendLine(string.Format("  tRASmin: {0:F3} ns ({1} ps)", this.method_39(), this.method_37()));
		stringBuilder.AppendLine(string.Format("  tRCmin: {0:F3} ns ({1} ps)", this.method_42(), this.method_40()));
		stringBuilder.AppendLine(string.Format("  tWRmin: {0:F3} ns ({1} ps)", this.method_45(), this.method_43()));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(string.Format("  tRFC1: {0} ns    tRFC2: {1} ns    tRFCsb: {2} ns", this.method_46(), this.method_48(), this.method_50()));
		stringBuilder.AppendLine(string.Format("  tRFC1_dlr (3DS): {0} ns    tRFC2_dlr (3DS): {1} ns    tRFCsb_dlr (3DS): {2} ns", this.method_52(), this.method_54(), this.method_56()));
		stringBuilder.AppendLine(string.Format("  Refresh Required: {0}, WideRange: {1}, RateIndicator: {2}", this.method_60(), this.method_62(), this.method_64()));
		stringBuilder.AppendLine(string.Format("  tREFI (calc): {0:F0} ns (factor = {1})", this.method_118(7800.0), this.method_114()));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(string.Format("  tRRD_L: {0} ps / {1} nCK", this.method_68(), this.method_70()));
		stringBuilder.AppendLine(string.Format("  tCCD_L: {0} ps / {1} nCK", this.method_72(), this.method_74()));
		stringBuilder.AppendLine(string.Format("  tCCD_L_WR: {0} ps / {1} nCK", this.method_76(), this.method_78()));
		stringBuilder.AppendLine(string.Format("  tCCD_L_WR2: {0} ps / {1} nCK", this.method_80(), this.method_82()));
		stringBuilder.AppendLine(string.Format("  tFAW: {0} ps / {1} nCK", this.method_84(), this.method_86()));
		stringBuilder.AppendLine(string.Format("  tCCD_L_WTR: {0} ps / {1} nCK", this.method_88(), this.method_90()));
		stringBuilder.AppendLine(string.Format("  tCCD_S_WTR: {0} ps / {1} nCK", this.method_92(), this.method_94()));
		stringBuilder.AppendLine(string.Format("  tRTP: {0} ps / {1} nCK", this.method_96(), this.method_98()));
		stringBuilder.AppendLine(string.Format("  tCCD_M: {0} ps / {1} nCK", this.method_100(), this.method_102()));
		stringBuilder.AppendLine(string.Format("  tCCD_M_WR: {0} ps / {1} nCK", this.method_104(), this.method_106()));
		stringBuilder.AppendLine(string.Format("  tCCD_M_WTR: {0} ps / {1} nCK", this.method_108(), this.method_110()));
		stringBuilder.AppendLine();
		return stringBuilder.ToString();
	}

	// Token: 0x040015FA RID: 5626
	private readonly DDR5Accessor ddr5Accessor_0;

	// Token: 0x040015FB RID: 5627
	private byte byte_0;

	// Token: 0x040015FC RID: 5628
	private byte byte_1;

	// Token: 0x040015FD RID: 5629
	private byte byte_2;

	// Token: 0x040015FE RID: 5630
	private byte byte_3;

	// Token: 0x040015FF RID: 5631
	private byte byte_4;

	// Token: 0x04001600 RID: 5632
	private byte byte_5;

	// Token: 0x04001601 RID: 5633
	private byte byte_6;

	// Token: 0x04001602 RID: 5634
	private byte byte_7;

	// Token: 0x04001603 RID: 5635
	private byte byte_8;

	// Token: 0x04001604 RID: 5636
	private byte byte_9;

	// Token: 0x04001605 RID: 5637
	private ushort ushort_0;

	// Token: 0x04001606 RID: 5638
	private ushort ushort_1;

	// Token: 0x04001607 RID: 5639
	private List<int> list_0;

	// Token: 0x04001608 RID: 5640
	private ushort ushort_2;

	// Token: 0x04001609 RID: 5641
	private ushort ushort_3;

	// Token: 0x0400160A RID: 5642
	private ushort ushort_4;

	// Token: 0x0400160B RID: 5643
	private ushort ushort_5;

	// Token: 0x0400160C RID: 5644
	private ushort ushort_6;

	// Token: 0x0400160D RID: 5645
	private ushort ushort_7;

	// Token: 0x0400160E RID: 5646
	private ushort ushort_8;

	// Token: 0x0400160F RID: 5647
	private ushort ushort_9;

	// Token: 0x04001610 RID: 5648
	private ushort ushort_10;

	// Token: 0x04001611 RID: 5649
	private ushort ushort_11;

	// Token: 0x04001612 RID: 5650
	private ushort ushort_12;

	// Token: 0x04001613 RID: 5651
	private ushort ushort_13;

	// Token: 0x04001614 RID: 5652
	private byte[] byte_10;

	// Token: 0x04001615 RID: 5653
	private bool bool_0;

	// Token: 0x04001616 RID: 5654
	private bool bool_1;

	// Token: 0x04001617 RID: 5655
	private int int_0;

	// Token: 0x04001618 RID: 5656
	private byte[] byte_11;

	// Token: 0x04001619 RID: 5657
	private ushort ushort_14;

	// Token: 0x0400161A RID: 5658
	private byte byte_12;

	// Token: 0x0400161B RID: 5659
	private ushort ushort_15;

	// Token: 0x0400161C RID: 5660
	private byte byte_13;

	// Token: 0x0400161D RID: 5661
	private ushort ushort_16;

	// Token: 0x0400161E RID: 5662
	private byte byte_14;

	// Token: 0x0400161F RID: 5663
	private ushort ushort_17;

	// Token: 0x04001620 RID: 5664
	private byte byte_15;

	// Token: 0x04001621 RID: 5665
	private ushort ushort_18;

	// Token: 0x04001622 RID: 5666
	private byte byte_16;

	// Token: 0x04001623 RID: 5667
	private ushort ushort_19;

	// Token: 0x04001624 RID: 5668
	private byte byte_17;

	// Token: 0x04001625 RID: 5669
	private ushort ushort_20;

	// Token: 0x04001626 RID: 5670
	private byte byte_18;

	// Token: 0x04001627 RID: 5671
	private ushort ushort_21;

	// Token: 0x04001628 RID: 5672
	private byte byte_19;

	// Token: 0x04001629 RID: 5673
	private ushort ushort_22;

	// Token: 0x0400162A RID: 5674
	private byte byte_20;

	// Token: 0x0400162B RID: 5675
	private ushort ushort_23;

	// Token: 0x0400162C RID: 5676
	private byte byte_21;

	// Token: 0x0400162D RID: 5677
	private ushort ushort_24;

	// Token: 0x0400162E RID: 5678
	private byte byte_22;

	// Token: 0x0400162F RID: 5679
	private double double_0;

	// Token: 0x04001630 RID: 5680
	private double double_1;
}
