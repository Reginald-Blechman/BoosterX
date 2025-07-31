using System;

// Token: 0x0200024A RID: 586
internal sealed class Class801 : GClass283
{
	// Token: 0x06000FEA RID: 4074 RVA: 0x0000BA5D File Offset: 0x00009C5D
	public Class801(Class505 class505_1)
	{
		this.class505_0 = class505_1;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00055998 File Offset: 0x00053B98
	protected override void vmethod_0(object object_0)
	{
		base.imethod_1("ChangingAffinity", (GEnum15)1);
		if ((string)object_0 == "default")
		{
			base.imethod_1("DefaultAffinity", (GEnum15)1);
			Class808.smethod_27("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + this.class505_0.Path + "\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"DevicePolicy\" /f");
			Class808.smethod_27("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + this.class505_0.Path + "\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"AssignmentSetOverride\" /f");
			return;
		}
		base.imethod_1("ChangingAffinity", (GEnum15)1);
		string text = Class440.smethod_4(object_0.ToString());
		Class808.smethod_27("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + this.class505_0.Path + "\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"DevicePolicy\" /t REG_DWORD /d \"4\" /f");
		Class808.smethod_27(string.Concat(new string[]
		{
			"reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\",
			this.class505_0.Path,
			"\\Device Parameters\\Interrupt Management\\Affinity Policy\" /v \"AssignmentSetOverride\" /t REG_BINARY /d \"",
			text,
			"\" /f"
		}));
	}

	// Token: 0x04000A1B RID: 2587
	private Class505 class505_0;
}
