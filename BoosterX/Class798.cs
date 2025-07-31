using System;

// Token: 0x02000129 RID: 297
internal sealed class Class798 : GClass283
{
	// Token: 0x06000891 RID: 2193 RVA: 0x000074DD File Offset: 0x000056DD
	public Class798(GClass186 gclass186_1)
	{
		this.gclass186_0 = gclass186_1;
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x000074EC File Offset: 0x000056EC
	public GClass186 method_6()
	{
		return this.gclass186_0;
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00042EC0 File Offset: 0x000410C0
	protected override void vmethod_0(object object_0)
	{
		GClass186 gclass = object_0 as GClass186;
		string a = string.Empty;
		try
		{
			if (gclass.HasChangesMSI)
			{
				base.imethod_1("ChangingMsi", (GEnum15)1);
				a = (gclass.MsiStatus ? "DisableMsi" : "EnableMsi");
			}
		}
		catch
		{
		}
		try
		{
			if (gclass.HasChangesEnabled)
			{
				base.imethod_1("ChangingDeviceStatus", (GEnum15)1);
				a = (gclass.IsEnabled ? "EnableDevice" : "DisableDevice");
			}
		}
		catch
		{
		}
		if (a == "DisableMsi")
		{
			Class808.smethod_27("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + gclass.Id + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties\" /v \"MSISupported\" /t REG_DWORD /d \"0\" /f");
		}
		if (a == "EnableMsi")
		{
			Class808.smethod_27("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Enum\\" + gclass.Id + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties\" /v \"MSISupported\" /t REG_DWORD /d \"1\" /f");
		}
		if (a == "DisableDevice")
		{
			Class304.smethod_8(gclass.Id);
		}
		if (a == "EnableDevice")
		{
			Class304.smethod_9(gclass.Id);
		}
	}

	// Token: 0x040004DD RID: 1245
	private GClass186 gclass186_0;
}
