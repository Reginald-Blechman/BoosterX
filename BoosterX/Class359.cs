using System;

// Token: 0x020002EF RID: 751
internal sealed class Class359
{
	// Token: 0x060013A4 RID: 5028 RVA: 0x0000DE04 File Offset: 0x0000C004
	public static void smethod_0(string string_0)
	{
		Class808.smethod_27("dism /online /disable-feature /featurename:" + string_0 + " /NoRestart");
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x0000DE1D File Offset: 0x0000C01D
	public static void smethod_1(string string_0)
	{
		Class808.smethod_27("dism /online /enable-feature /featurename:" + string_0 + " /NoRestart");
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x0000DE36 File Offset: 0x0000C036
	public static void smethod_2(string string_0)
	{
		Class808.smethod_27("dism /online /Remove-Package /PackageName:" + string_0 + " /NoRestart");
	}
}
