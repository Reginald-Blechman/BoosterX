using System;

// Token: 0x020006F5 RID: 1781
public static class GClass299
{
	// Token: 0x06002CA1 RID: 11425 RVA: 0x000AA7E0 File Offset: 0x000A89E0
	public static Uri smethod_0(GEnum7 genum7_0)
	{
		switch (genum7_0)
		{
		case (GEnum7)0:
			return GClass85.uri_8;
		case (GEnum7)1:
			return GClass85.uri_9;
		case (GEnum7)2:
			return GClass85.uri_10;
		case (GEnum7)3:
			return GClass85.uri_11;
		case (GEnum7)4:
			return GClass85.uri_12;
		case (GEnum7)5:
			return GClass85.uri_13;
		case (GEnum7)6:
			return GClass85.uri_14;
		default:
			return GClass85.uri_8;
		}
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x0001CB48 File Offset: 0x0001AD48
	public static Uri smethod_1(GEnum7 genum7_0)
	{
		if (genum7_0 == (GEnum7)0)
		{
			return GClass85.uri_15;
		}
		if (genum7_0 != (GEnum7)1)
		{
			return GClass85.uri_15;
		}
		return GClass85.uri_16;
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x000AA840 File Offset: 0x000A8A40
	public static string smethod_2(GEnum14 genum14_0)
	{
		switch (genum14_0)
		{
		case GEnum14.Desktop:
			return "Windows.Desktop";
		case GEnum14.Mobile:
			return "Windows.Mobile";
		case GEnum14.Xbox:
			return "Windows.Xbox";
		case GEnum14.ServerCore:
			return "Windows.Server";
		case GEnum14.IotCore:
			return "Windows.Iot";
		case GEnum14.HoloLens:
			return "Windows.Holographic";
		case GEnum14.Andromeda:
			return "Windows.8828080";
		case GEnum14.Universal:
			return "Windows.Universal";
		case GEnum14.WCOS:
			return "Windows.Core";
		default:
			throw new GException2("Undefined DeviceFamily " + genum14_0.ToString());
		}
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x0001CB62 File Offset: 0x0001AD62
	public static GEnum2 smethod_3(string string_0)
	{
		if (string_0 == "XAP")
		{
			return (GEnum2)1;
		}
		if (string_0 == "AppX")
		{
			return (GEnum2)2;
		}
		if (!(string_0 == "UAP"))
		{
			return (GEnum2)3;
		}
		return (GEnum2)0;
	}
}
