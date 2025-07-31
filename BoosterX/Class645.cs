using System;
using System.Globalization;
using Material.Icons;

// Token: 0x02000548 RID: 1352
internal sealed class Class645
{
	// Token: 0x0600221F RID: 8735 RVA: 0x00088970 File Offset: 0x00086B70
	public object method_0(object object_0, Type type_0, object object_1, CultureInfo cultureInfo_0)
	{
		string a = object_0 as string;
		MaterialIconKind materialIconKind = 3119;
		if (!(a == "Group1"))
		{
			if (a == "Group2")
			{
				materialIconKind = 174;
			}
		}
		else
		{
			materialIconKind = 45;
		}
		return materialIconKind;
	}
}
