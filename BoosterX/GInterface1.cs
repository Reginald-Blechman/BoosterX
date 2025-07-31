using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x02000151 RID: 337
public interface GInterface1
{
	// Token: 0x0600099B RID: 2459
	GClass142 imethod_0();

	// Token: 0x0600099C RID: 2460
	void imethod_1(GClass142 gclass142_0);

	// Token: 0x0600099D RID: 2461
	Task<GClass35> imethod_2(GClass142 gclass142_0);

	// Token: 0x0600099E RID: 2462
	Task<GClass35> imethod_3(string string_0, GClass27 gclass27_0, int? nullable_0, double? nullable_1, double? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, int? nullable_6, bool? nullable_7, string[] string_1);

	// Token: 0x0600099F RID: 2463
	Task<GClass35> imethod_4(string[] string_0);

	// Token: 0x060009A0 RID: 2464
	Task<GClass35> imethod_5(GClass142 gclass142_0, int int_0);

	// Token: 0x060009A1 RID: 2465
	Task imethod_6(GClass142 gclass142_0, Action<int, GClass35> action_0);

	// Token: 0x060009A2 RID: 2466
	Task imethod_7(GClass142 gclass142_0, Action<GClass35> action_0);

	// Token: 0x060009A3 RID: 2467
	IAsyncEnumerable<GClass35> imethod_8(GClass142 gclass142_0);

	// Token: 0x060009A4 RID: 2468
	IAsyncEnumerable<GClass35> imethod_9(string string_0, GClass27 gclass27_0, int? nullable_0, double? nullable_1, double? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, int? nullable_6, bool? nullable_7, string[] string_1);

	// Token: 0x060009A5 RID: 2469
	Task<string> imethod_10(GClass142 gclass142_0);

	// Token: 0x060009A6 RID: 2470
	Task<string> imethod_11(string string_0);
}
