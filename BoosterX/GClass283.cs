using System;

// Token: 0x020001EC RID: 492
public abstract class GClass283 : GClass282<object>
{
	// Token: 0x06000D6B RID: 3435 RVA: 0x0000A0F2 File Offset: 0x000082F2
	protected GClass283()
	{
		base.method_0(new Action<GInterface7<object>, object>(this.method_5));
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x0000A10C File Offset: 0x0000830C
	protected string method_2()
	{
		return base.imethod_0();
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x0000A114 File Offset: 0x00008314
	protected void method_3(string string_1)
	{
		base.method_1(string_1);
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x0000A11D File Offset: 0x0000831D
	public void method_4(Action<string, GEnum15> action_2)
	{
		base.imethod_2(action_2);
	}

	// Token: 0x06000D6F RID: 3439
	protected abstract void vmethod_0(object object_0);

	// Token: 0x06000D70 RID: 3440 RVA: 0x0000A126 File Offset: 0x00008326
	private void method_5(GInterface7<object> ginterface7_0, object object_0)
	{
		this.vmethod_0(object_0);
	}
}
