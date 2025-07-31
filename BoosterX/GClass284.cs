using System;

// Token: 0x02000259 RID: 601
public abstract class GClass284 : GClass282<bool>
{
	// Token: 0x0600103C RID: 4156 RVA: 0x0000BE51 File Offset: 0x0000A051
	protected GClass284()
	{
		base.method_0(new Action<GInterface7<bool>, bool>(this.method_6));
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x0000BE6B File Offset: 0x0000A06B
	protected string method_2()
	{
		return base.imethod_0();
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0000A844 File Offset: 0x00008A44
	protected void method_3(string string_1)
	{
		base.method_1(string_1);
	}

	// Token: 0x0600103F RID: 4159
	protected abstract void vmethod_0();

	// Token: 0x06001040 RID: 4160
	protected abstract void vmethod_1();

	// Token: 0x06001041 RID: 4161 RVA: 0x0000BE73 File Offset: 0x0000A073
	public void method_4()
	{
		base.imethod_3(true);
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x0000BE7C File Offset: 0x0000A07C
	public void method_5()
	{
		base.imethod_3(false);
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x0000BE85 File Offset: 0x0000A085
	private void method_6(GInterface7<bool> ginterface7_0, bool bool_0)
	{
		if (bool_0)
		{
			this.vmethod_0();
			return;
		}
		this.vmethod_1();
	}
}
