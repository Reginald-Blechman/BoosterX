using System;
using System.Collections.Generic;
using ns0;

// Token: 0x020003DF RID: 991
public sealed class GClass287 : GClass286
{
	// Token: 0x060019D6 RID: 6614 RVA: 0x00011634 File Offset: 0x0000F834
	public GClass287()
	{
		base.method_3("GetType");
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x00011660 File Offset: 0x0000F860
	protected override void vmethod_0(string string_3)
	{
		if (string_3 == GClass287.string_2)
		{
			this.method_6(dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.string_1, dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_2);
		}
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0007140C File Offset: 0x0006F60C
	private void method_6(string string_3, List<string> list_0)
	{
		if (string_3 != string.Empty)
		{
			base.imethod_1(Class298.smethod_2("SetActivePowerScheme"), (GEnum15)1);
			Class808.smethod_27("powercfg -setactive " + string_3);
		}
		if (list_0.Count > 0)
		{
			list_0.ForEach(new Action<string>(this.method_7));
		}
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x0001167F File Offset: 0x0000F87F
	private void method_7(string string_3)
	{
		base.imethod_1(Class298.smethod_2("DeletingPowerScheme"), (GEnum15)1);
		Class808.smethod_27("powercfg -delete " + string_3);
	}

	// Token: 0x04001101 RID: 4353
	public static readonly string string_1 = "IMPORTPOWER";

	// Token: 0x04001102 RID: 4354
	public static readonly string string_2 = "ADDORDELETEPOWERSCHEME";
}
