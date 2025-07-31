using System;
using System.IO;
using System.Threading.Tasks;

// Token: 0x020004FA RID: 1274
public interface GInterface17
{
	// Token: 0x0600204A RID: 8266
	GClass73 imethod_0();

	// Token: 0x0600204B RID: 8267
	void imethod_1(GClass73 gclass73_0);

	// Token: 0x0600204C RID: 8268
	Task<Stream> imethod_2(GClass73 gclass73_0);

	// Token: 0x0600204D RID: 8269
	Task<Stream> imethod_3(string string_0, string string_1, double? nullable_0, string string_2, GClass27 gclass27_0);

	// Token: 0x0600204E RID: 8270
	Task<FileInfo> imethod_4(GClass73 gclass73_0, string string_0);

	// Token: 0x0600204F RID: 8271
	Task<FileInfo> imethod_5(string string_0, string string_1, string string_2, double? nullable_0, string string_3, GClass27 gclass27_0);
}
