using System;
using System.IO;

// Token: 0x0200060F RID: 1551
public sealed class GClass264
{
	// Token: 0x0600277A RID: 10106 RVA: 0x0009AA1C File Offset: 0x00098C1C
	public static string smethod_0()
	{
		string text;
		do
		{
			text = GClass264.smethod_1();
		}
		while (File.Exists(text));
		return text;
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x0009AA38 File Offset: 0x00098C38
	private static string smethod_1()
	{
		return Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString().Replace("-", string.Empty));
	}
}
