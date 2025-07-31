using System;

// Token: 0x0200057D RID: 1405
public abstract class GClass286 : GClass282<string>
{
	// Token: 0x06002358 RID: 9048 RVA: 0x0001748A File Offset: 0x0001568A
	protected GClass286()
	{
		base.method_0(new Action<GInterface7<string>, string>(this.method_5));
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x000174A4 File Offset: 0x000156A4
	protected string method_2()
	{
		return base.imethod_0();
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x000174AC File Offset: 0x000156AC
	protected void method_3(string string_1)
	{
		base.method_1(string_1);
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x000174B5 File Offset: 0x000156B5
	public void method_4(Action<string, GEnum15> action_2)
	{
		base.imethod_2(action_2);
	}

	// Token: 0x0600235C RID: 9052
	protected abstract void vmethod_0(string string_1);

	// Token: 0x0600235D RID: 9053 RVA: 0x000174BE File Offset: 0x000156BE
	private void method_5(GInterface7<string> ginterface7_0, string string_1)
	{
		this.vmethod_0(string_1);
	}
}
