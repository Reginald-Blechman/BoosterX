using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000342 RID: 834
public sealed class GClass112
{
	// Token: 0x06001596 RID: 5526 RVA: 0x0000ED95 File Offset: 0x0000CF95
	public NVDRS_SETTING_TYPE? method_0()
	{
		return this.nullable_0;
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x0000ED9D File Offset: 0x0000CF9D
	public void method_1(NVDRS_SETTING_TYPE? nullable_1)
	{
		this.nullable_0 = nullable_1;
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x0000EDA6 File Offset: 0x0000CFA6
	public string method_2()
	{
		return this.string_0;
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x0000EDAE File Offset: 0x0000CFAE
	public void method_3(string string_4)
	{
		this.string_0 = string_4;
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x0000EDB7 File Offset: 0x0000CFB7
	public string method_4()
	{
		return this.string_1;
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x0000EDBF File Offset: 0x0000CFBF
	public void method_5(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
	public string method_6()
	{
		return this.string_2;
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
	public void method_7(string string_4)
	{
		this.string_2 = string_4;
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x0000EDD9 File Offset: 0x0000CFD9
	public uint method_8()
	{
		return this.uint_0;
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x0000EDE1 File Offset: 0x0000CFE1
	public void method_9(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x0000EDEA File Offset: 0x0000CFEA
	public byte[] method_10()
	{
		return this.byte_0;
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x0000EDF2 File Offset: 0x0000CFF2
	public void method_11(byte[] byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x0000EDFB File Offset: 0x0000CFFB
	public bool method_12()
	{
		return this.bool_0;
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x0000EE03 File Offset: 0x0000D003
	public void method_13(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x0000EE0C File Offset: 0x0000D00C
	public bool method_14()
	{
		return this.bool_1;
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x0000EE14 File Offset: 0x0000D014
	public void method_15(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0000EE1D File Offset: 0x0000D01D
	// (set) Token: 0x060015A7 RID: 5543 RVA: 0x0000EE25 File Offset: 0x0000D025
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
		[CompilerGenerated]
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x0000EE2E File Offset: 0x0000D02E
	public List<GClass277<string>> method_16()
	{
		return this.list_0;
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x0000EE36 File Offset: 0x0000D036
	public void method_17(List<GClass277<string>> list_3)
	{
		this.list_0 = list_3;
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x0000EE3F File Offset: 0x0000D03F
	public List<GClass277<uint>> method_18()
	{
		return this.list_1;
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x0000EE47 File Offset: 0x0000D047
	public void method_19(List<GClass277<uint>> list_3)
	{
		this.list_1 = list_3;
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x0000EE50 File Offset: 0x0000D050
	public List<GClass277<byte[]>> method_20()
	{
		return this.list_2;
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x0000EE58 File Offset: 0x0000D058
	public void method_21(List<GClass277<byte[]>> list_3)
	{
		this.list_2 = list_3;
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x060015AE RID: 5550 RVA: 0x00065B28 File Offset: 0x00063D28
	public IEnumerable<GInterface11> Values
	{
		get
		{
			NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = this.method_0();
			if (nvdrs_SETTING_TYPE != null)
			{
				switch (nvdrs_SETTING_TYPE.GetValueOrDefault())
				{
				case 0:
					return this.method_18();
				case 1:
					return this.method_20();
				case 2:
					return this.method_16();
				case 3:
					return this.method_16();
				}
			}
			return null;
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x060015AF RID: 5551 RVA: 0x00065B8C File Offset: 0x00063D8C
	public GInterface11 DefaultValue
	{
		get
		{
			GClass112.Class397 @class = new GClass112.Class397();
			NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = this.method_0();
			object object_;
			if (nvdrs_SETTING_TYPE != null)
			{
				switch (nvdrs_SETTING_TYPE.GetValueOrDefault())
				{
				case 0:
					object_ = this.method_8();
					goto IL_61;
				case 1:
					object_ = this.method_10();
					goto IL_61;
				case 2:
					object_ = this.method_6();
					goto IL_61;
				case 3:
					object_ = this.method_6();
					goto IL_61;
				}
			}
			object_ = null;
			IL_61:
			@class.object_0 = object_;
			return this.Values.FirstOrDefault(new Func<GInterface11, bool>(@class.method_0));
		}
	}

	// Token: 0x04000E61 RID: 3681
	private NVDRS_SETTING_TYPE? nullable_0;

	// Token: 0x04000E62 RID: 3682
	private string string_0;

	// Token: 0x04000E63 RID: 3683
	private string string_1;

	// Token: 0x04000E64 RID: 3684
	private string string_2;

	// Token: 0x04000E65 RID: 3685
	private uint uint_0;

	// Token: 0x04000E66 RID: 3686
	private byte[] byte_0;

	// Token: 0x04000E67 RID: 3687
	private bool bool_0;

	// Token: 0x04000E68 RID: 3688
	private bool bool_1;

	// Token: 0x04000E69 RID: 3689
	private string string_3;

	// Token: 0x04000E6A RID: 3690
	private List<GClass277<string>> list_0;

	// Token: 0x04000E6B RID: 3691
	private List<GClass277<uint>> list_1;

	// Token: 0x04000E6C RID: 3692
	private List<GClass277<byte[]>> list_2;

	// Token: 0x02000343 RID: 835
	private sealed class Class397
	{
		// Token: 0x060015B1 RID: 5553 RVA: 0x0000EE61 File Offset: 0x0000D061
		internal bool method_0(GInterface11 ginterface11_0)
		{
			return ginterface11_0.imethod_0().Equals(this.object_0);
		}

		// Token: 0x04000E6D RID: 3693
		public object object_0;
	}
}
