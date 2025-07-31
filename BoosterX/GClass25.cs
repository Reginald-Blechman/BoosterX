using System;

// Token: 0x02000184 RID: 388
public static class GClass25
{
	// Token: 0x06000AB8 RID: 2744 RVA: 0x0000872E File Offset: 0x0000692E
	public static void smethod_0(string string_0)
	{
		GClass4.smethod_3("Get-AppxPackage -Name \"*" + string_0 + "*\" | Remove-AppxPackage");
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00008747 File Offset: 0x00006947
	public static void smethod_1(string string_0)
	{
		GClass4.smethod_2("Get-AppxPackage -Name \"*" + string_0 + "*\" | Foreach {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}");
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x00049658 File Offset: 0x00047858
	public static ValueTuple<int, int, int> smethod_2(long long_0)
	{
		int item = (int)(long_0 >> 48);
		int item2 = (int)(long_0 >> 32) & 65535;
		int item3 = (int)(long_0 & 4294967295L);
		return new ValueTuple<int, int, int>(item, item2, item3);
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0004968C File Offset: 0x0004788C
	public static bool smethod_3(long long_0, long long_1)
	{
		Version version = Environment.OSVersion.Version;
		ValueTuple<int, int, int> valueTuple = GClass25.smethod_2(long_0);
		int item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		int item3 = valueTuple.Item3;
		ValueTuple<int, int, int> valueTuple2 = GClass25.smethod_2(long_1);
		int item4 = valueTuple2.Item1;
		int item5 = valueTuple2.Item2;
		int item6 = valueTuple2.Item3;
		return version.Major >= item && (version.Major != item || version.Minor >= item2) && (version.Major != item || version.Minor != item2 || version.Build >= item3) && (version.Major <= item4 && (version.Major != item4 || version.Minor <= item5) && (version.Major != item4 || version.Minor != item5 || version.Build <= item6));
	}
}
