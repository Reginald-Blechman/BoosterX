using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x020003DA RID: 986
public interface GInterface14
{
	// Token: 0x060019C2 RID: 6594
	GClass78 imethod_0();

	// Token: 0x060019C3 RID: 6595
	void imethod_1(GClass78 gclass78_0);

	// Token: 0x060019C4 RID: 6596
	GClass56 imethod_2(GClass78 gclass78_0);

	// Token: 0x060019C5 RID: 6597
	Task<GClass36> imethod_3(GClass78 gclass78_0);

	// Token: 0x060019C6 RID: 6598
	Task<GClass36> imethod_4(GClass78 gclass78_0, int int_0);

	// Token: 0x060019C7 RID: 6599
	Task<GClass36> imethod_5(IList<GClass258> ilist_0, GClass27 gclass27_0, double? nullable_0, double? nullable_1, int? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0, string[] string_0);

	// Token: 0x060019C8 RID: 6600
	Task<GClass36> imethod_6(GClass258[] gclass258_0);

	// Token: 0x060019C9 RID: 6601
	Task<GClass36> imethod_7(string[] string_0);

	// Token: 0x060019CA RID: 6602
	Task<GClass36> imethod_8(string string_0, GClass258.GClass259[] gclass259_0);

	// Token: 0x060019CB RID: 6603
	Task imethod_9(GClass78 gclass78_0, Action<GClass36> action_0);

	// Token: 0x060019CC RID: 6604
	IAsyncEnumerable<GClass36> imethod_10(GClass78 gclass78_0);

	// Token: 0x060019CD RID: 6605
	IAsyncEnumerable<GClass36> imethod_11(IList<GClass258> ilist_0, GClass27 gclass27_0, double? nullable_0, double? nullable_1, int? nullable_2, int? nullable_3, double? nullable_4, double? nullable_5, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0, string[] string_0);

	// Token: 0x060019CE RID: 6606
	Task imethod_12(GClass78 gclass78_0, Action<int, GClass36> action_0);
}
