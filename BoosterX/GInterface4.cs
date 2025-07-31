using System;
using System.IO;
using System.Threading.Tasks;

// Token: 0x0200019E RID: 414
public interface GInterface4
{
	// Token: 0x06000BB7 RID: 2999
	GClass106 imethod_0();

	// Token: 0x06000BB8 RID: 3000
	void imethod_1(GClass106 gclass106_0);

	// Token: 0x06000BB9 RID: 3001
	Task<string> imethod_2(Stream stream_0, string string_0, string string_1, string string_2, string string_3, double? nullable_0);

	// Token: 0x06000BBA RID: 3002
	Task<string> imethod_3(string string_0, string string_1, string string_2, string string_3, double? nullable_0);

	// Token: 0x06000BBB RID: 3003
	Task<GClass38> imethod_4(Stream stream_0, string string_0, string string_1, string string_2, double? nullable_0);

	// Token: 0x06000BBC RID: 3004
	Task<GClass38> imethod_5(string string_0, string string_1, string string_2, double? nullable_0);

	// Token: 0x06000BBD RID: 3005
	Task<string> imethod_6(Stream stream_0, string string_0, string string_1, string string_2, double? nullable_0);

	// Token: 0x06000BBE RID: 3006
	Task<string> imethod_7(string string_0, string string_1, string string_2, double? nullable_0);
}
