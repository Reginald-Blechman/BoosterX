using System;
using System.Collections.Generic;

// Token: 0x02000447 RID: 1095
public static class GClass157
{
	// Token: 0x06001C65 RID: 7269 RVA: 0x0007876C File Offset: 0x0007696C
	// Note: this type is marked as 'beforefieldinit'.
	static GClass157()
	{
		List<GClass237> list = new List<GClass237>();
		GClass237 gclass = new GClass237();
		gclass.method_1("root\\umbus");
		gclass.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass);
		GClass237 gclass2 = new GClass237();
		gclass2.method_1("ROOT\\VID");
		gclass2.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass2);
		GClass237 gclass3 = new GClass237();
		gclass3.method_1("ROOT\\vdrvroot");
		gclass3.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass3);
		GClass237 gclass4 = new GClass237();
		gclass4.method_1("ROOT\\NdisVirtualBus");
		gclass4.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass4);
		GClass237 gclass5 = new GClass237();
		gclass5.method_1("ROOT\\CompositeBus");
		gclass5.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass5);
		GClass237 gclass6 = new GClass237();
		gclass6.method_1("ACPI\\VEN_PNP&DEV_0103");
		gclass6.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass6);
		GClass237 gclass7 = new GClass237();
		gclass7.method_1("ACPI\\VEN_PNP&DEV_0000");
		gclass7.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass7);
		GClass237 gclass8 = new GClass237();
		gclass8.method_1("ROOT\\RDPBUS");
		gclass8.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass8);
		GClass237 gclass9 = new GClass237();
		gclass9.method_1("ACPI\\VEN_PNP&DEV_0C04");
		gclass9.Description = Class298.smethod_2(string.Empty);
		list.Add(gclass9);
		GClass157.list_2 = list;
	}

	// Token: 0x040012FB RID: 4859
	public static List<string> list_0 = new List<string>
	{
		"ROOT\\umbus",
		"ROOT\\vdrvroot",
		"ROOT\\NdisVirtualBus",
		"ROOT\\CompositeBus"
	};

	// Token: 0x040012FC RID: 4860
	public static List<string> list_1 = new List<string>
	{
		"ROOT\\CompositeBus",
		"ROOT\\umbus",
		"ROOT\\vdrvroot",
		"ROOT\\NdisVirtualBus"
	};

	// Token: 0x040012FD RID: 4861
	public static List<GClass237> list_2;
}
