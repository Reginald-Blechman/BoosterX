using System;
using System.Collections.Generic;

// Token: 0x020003D6 RID: 982
internal sealed class Class445
{
	// Token: 0x060019AC RID: 6572 RVA: 0x00070F88 File Offset: 0x0006F188
	public static GClass57 smethod_0(GClass131 gclass131_0)
	{
		GClass57 gclass = new GClass57();
		GClass57 result;
		try
		{
			List<GClass247.GClass248> list_ = GClass247.smethod_2(GClass82.string_0);
			List<GClass247.GClass248> list_2 = GClass247.smethod_2(GClass82.string_1);
			ValueTuple<GClass247.GClass248, double> valueTuple = GClass247.smethod_6(gclass131_0.method_0(), list_);
			GClass247.GClass248 item = valueTuple.Item1;
			double item2 = valueTuple.Item2;
			ValueTuple<GClass247.GClass248, double> valueTuple2 = GClass247.smethod_6(gclass131_0.method_2(), list_2);
			GClass247.GClass248 item3 = valueTuple2.Item1;
			double item4 = valueTuple2.Item2;
			ValueTuple<int, int> valueTuple3 = GClass247.smethod_7(item2, item4, gclass131_0.method_4());
			int item5 = valueTuple3.Item1;
			int item6 = valueTuple3.Item2;
			gclass.method_7(item5);
			gclass.method_9(item6);
			gclass.method_3(item3.Name);
			gclass.method_1(item.Name);
			gclass.method_5(gclass131_0.method_4());
			return gclass;
		}
		catch (Exception exception_)
		{
			GClass268.smethod_1(exception_);
			result = null;
		}
		return result;
	}
}
