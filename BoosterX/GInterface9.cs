using System;
using System.Collections.Generic;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020002FA RID: 762
public interface GInterface9
{
	// Token: 0x060013DD RID: 5085
	GEnum4 imethod_0();

	// Token: 0x060013DE RID: 5086
	NVDRS_SETTING_TYPE? imethod_1(uint uint_0);

	// Token: 0x060013DF RID: 5087
	string imethod_2(uint uint_0);

	// Token: 0x060013E0 RID: 5088
	string imethod_3(uint uint_0);

	// Token: 0x060013E1 RID: 5089
	uint? imethod_4(uint uint_0);

	// Token: 0x060013E2 RID: 5090
	string imethod_5(uint uint_0);

	// Token: 0x060013E3 RID: 5091
	byte[] imethod_6(uint uint_0);

	// Token: 0x060013E4 RID: 5092
	List<GClass277<string>> imethod_7(uint uint_0);

	// Token: 0x060013E5 RID: 5093
	List<GClass277<uint>> imethod_8(uint uint_0);

	// Token: 0x060013E6 RID: 5094
	List<GClass277<byte[]>> imethod_9(uint uint_0);

	// Token: 0x060013E7 RID: 5095
	List<uint> imethod_10();
}
