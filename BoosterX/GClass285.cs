using System;

// Token: 0x0200020A RID: 522
public sealed class GClass285 : GClass284
{
	// Token: 0x06000E1B RID: 3611 RVA: 0x0000A829 File Offset: 0x00008A29
	public void method_7(Action<GClass285> action_4)
	{
		this.action_2 = action_4;
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x0000A832 File Offset: 0x00008A32
	public void method_8(Action<GClass285> action_4)
	{
		this.action_3 = action_4;
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x0000A83B File Offset: 0x00008A3B
	public void method_9(Action<string, GEnum15> action_4)
	{
		base.imethod_2(action_4);
	}

	// Token: 0x1700018F RID: 399
	// (set) Token: 0x06000E1E RID: 3614 RVA: 0x0000A844 File Offset: 0x00008A44
	public string Name
	{
		set
		{
			base.method_1(value);
		}
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x00050F98 File Offset: 0x0004F198
	protected override void vmethod_0()
	{
		this.action_2(this);
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00050F98 File Offset: 0x0004F198
	protected override void vmethod_1()
	{
		this.action_2(this);
	}

	// Token: 0x04000919 RID: 2329
	private Action<GClass285> action_2;

	// Token: 0x0400091A RID: 2330
	private Action<GClass285> action_3;
}
