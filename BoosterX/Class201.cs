using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

// Token: 0x02000198 RID: 408
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class201
{
	// Token: 0x06000B92 RID: 2962 RVA: 0x00003332 File Offset: 0x00001532
	internal Class201()
	{
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x000090DF File Offset: 0x000072DF
	internal static ResourceManager smethod_0()
	{
		if (Class201.resourceManager_0 == null)
		{
			Class201.resourceManager_0 = new ResourceManager("BoosterX.Properties.Resources", typeof(Class201).Assembly);
		}
		return Class201.resourceManager_0;
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0000910C File Offset: 0x0000730C
	internal static CultureInfo smethod_1()
	{
		return Class201.cultureInfo_0;
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00009113 File Offset: 0x00007313
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		Class201.cultureInfo_0 = cultureInfo_1;
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0000911B File Offset: 0x0000731B
	internal static byte[] smethod_3()
	{
		return (byte[])Class201.smethod_0().GetObject("CustomSettingNames", Class201.cultureInfo_0);
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x00009137 File Offset: 0x00007337
	internal static string smethod_4()
	{
		return Class201.smethod_0().GetString("String1", Class201.cultureInfo_0);
	}

	// Token: 0x04000777 RID: 1911
	private static ResourceManager resourceManager_0;

	// Token: 0x04000778 RID: 1912
	private static CultureInfo cultureInfo_0;
}
