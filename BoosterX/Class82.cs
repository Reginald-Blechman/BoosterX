using System;

// Token: 0x0200002B RID: 43
internal abstract class Class82 : Class79
{
	// Token: 0x060000F7 RID: 247 RVA: 0x0000391A File Offset: 0x00001B1A
	public Class82(int int_1) : base(int_1)
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00003923 File Offset: 0x00001B23
	public Type method_3()
	{
		return this.type_1;
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0000392B File Offset: 0x00001B2B
	public void method_4(Type type_2)
	{
		this.type_1 = type_2;
	}

	// Token: 0x060000FA RID: 250
	public abstract object vmethod_4();

	// Token: 0x060000FB RID: 251
	public abstract void vmethod_5(object object_0);

	// Token: 0x060000FC RID: 252
	public abstract bool vmethod_6(Class82 class82_0);

	// Token: 0x04000053 RID: 83
	private Type type_1;
}
