using System;

// Token: 0x0200001F RID: 31
internal sealed class Class61 : Class58
{
	// Token: 0x060000B6 RID: 182 RVA: 0x00003616 File Offset: 0x00001816
	public Class61() : base(7)
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000361F File Offset: 0x0000181F
	public object method_3()
	{
		return this.object_0;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00003627 File Offset: 0x00001827
	public void method_4(object object_1)
	{
		this.object_0 = object_1;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00003630 File Offset: 0x00001830
	public override object vmethod_0()
	{
		return this.method_3();
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00003638 File Offset: 0x00001838
	public override void vmethod_1(object object_1)
	{
		this.method_4(object_1);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00003641 File Offset: 0x00001841
	public override Class58 vmethod_2(Class58 class58_0)
	{
		base.method_2(class58_0.method_1());
		this.method_4(class58_0.vmethod_0());
		return this;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000365C File Offset: 0x0000185C
	public override Class58 vmethod_3()
	{
		Class61 @class = new Class61();
		@class.method_4(this.object_0);
		@class.method_2(base.method_1());
		return @class;
	}

	// Token: 0x0400003B RID: 59
	private object object_0;
}
