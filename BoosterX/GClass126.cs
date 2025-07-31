using System;

// Token: 0x02000393 RID: 915
public static class GClass126
{
	// Token: 0x060017C0 RID: 6080 RVA: 0x0006C380 File Offset: 0x0006A580
	public static Uri smethod_0(GEnum7 genum7_0, string string_0, GEnum9 genum9_0, GClass233 gclass233_0)
	{
		switch (genum9_0)
		{
		case (GEnum9)0:
			return new Uri(string.Format("{0}{1}?{2}", GClass299.smethod_0(genum7_0), string_0, gclass233_0.method_8()));
		case (GEnum9)1:
			return new Uri(string.Format("{0}lookup?alternateId=XboxTitleID&Value={1}&{2}&fieldsTemplate=Details", GClass299.smethod_0(genum7_0), string_0, gclass233_0.method_8()));
		case (GEnum9)2:
			return new Uri(string.Format("{0}lookup?alternateId=PackageFamilyName&Value={1}&{2}&fieldsTemplate=Details", GClass299.smethod_0(genum7_0), string_0, gclass233_0.method_8()));
		case (GEnum9)3:
			return new Uri(string.Format("{0}lookup?alternateId=CONTENTID&Value={1}&{2}&fieldsTemplate=Details", GClass299.smethod_0(genum7_0), string_0, gclass233_0.method_8()));
		case (GEnum9)4:
			return new Uri(string.Format("{0}lookup?alternateId=LegacyWindowsPhoneProductID&Value={1}&{2}&fieldsTemplate=Details", GClass299.smethod_0(genum7_0), string_0, gclass233_0.method_8()));
		case (GEnum9)5:
			return new Uri(string.Format("{0}lookup?alternateId=LegacyWindowsStoreProductID&Value={1}&{2}&fieldsTemplate=Details", GClass299.smethod_0(genum7_0), string_0, gclass233_0.method_8()));
		case (GEnum9)6:
			return new Uri(string.Format("{0}lookup?alternateId=LegacyXboxProductID&Value={1}&{2}&fieldsTemplate=Details", GClass299.smethod_0(genum7_0), string_0, gclass233_0.method_8()));
		default:
			throw new Exception("CreateAlternateDCatUri: Unknown IdentifierType was passed, an update is likely required, please report this issue.");
		}
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x0006C48C File Offset: 0x0006A68C
	public static Uri smethod_1(GEnum7 genum7_0, GEnum14 genum14_0, GClass233 gclass233_0, string string_0)
	{
		return new Uri(string.Format("{0}{1}&productFamilyNames=apps,games&market={2}&languages={3}&platformDependencyName={4}", new object[]
		{
			GClass299.smethod_1(genum7_0),
			string_0,
			gclass233_0.method_0(),
			gclass233_0.method_2(),
			GClass299.smethod_2(genum14_0)
		}));
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x000103ED File Offset: 0x0000E5ED
	public static Uri smethod_2(GClass233 gclass233_0, string string_0)
	{
		return new Uri(string.Format("{0}?hl={1}&gl={2}&mediaType=all&age=all&price=all&category=all&subscription=all&cursor=&query={3}", new object[]
		{
			GClass85.uri_18,
			gclass233_0.method_2(),
			gclass233_0.method_0(),
			string_0
		}));
	}
}
