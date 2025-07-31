using System;

// Token: 0x02000220 RID: 544
public sealed class GClass59 : GInterface12
{
	// Token: 0x06000EDE RID: 3806 RVA: 0x0000AF8C File Offset: 0x0000918C
	public GClass59(GInterface8 ginterface8_1, Action<string, GEnum15> action_1)
	{
		this.ginterface8_0 = ginterface8_1;
		this.action_0 = action_1;
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00052D44 File Offset: 0x00050F44
	public void imethod_0<T>(Action<string, GEnum15> action_1) where T : GClass284, new()
	{
		T t = this.ginterface8_0.imethod_4<T>();
		if (action_1 != null)
		{
			t.imethod_2(action_1);
		}
		if (this.ginterface8_0.imethod_0<T>())
		{
			t.method_4();
		}
		if (this.ginterface8_0.imethod_1<T>())
		{
			t.method_5();
		}
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x0000AFA2 File Offset: 0x000091A2
	public void imethod_1<T>() where T : GClass284, new()
	{
		this.imethod_0<T>(this.action_0);
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00052D9C File Offset: 0x00050F9C
	public void imethod_2<T>(string string_0, Action<string, GEnum15> action_1) where T : GClass286, new()
	{
		T t = this.ginterface8_0.imethod_4<T>();
		t.imethod_2(action_1);
		if (this.ginterface8_0.imethod_2<T>(string_0))
		{
			t.imethod_3(string_0);
		}
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0000AFB0 File Offset: 0x000091B0
	public void imethod_3<T>(string string_0) where T : GClass286, new()
	{
		this.imethod_2<T>(string_0, this.action_0);
	}

	// Token: 0x04000990 RID: 2448
	private readonly GInterface8 ginterface8_0;

	// Token: 0x04000991 RID: 2449
	private readonly Action<string, GEnum15> action_0;
}
