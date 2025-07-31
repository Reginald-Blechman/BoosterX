using System;

// Token: 0x02000349 RID: 841
internal sealed class Class803 : GClass283
{
	// Token: 0x060015DA RID: 5594 RVA: 0x0000F015 File Offset: 0x0000D215
	public Class803(Class466 class466_1)
	{
		this.method_7(class466_1);
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x0000F024 File Offset: 0x0000D224
	public Class466 method_6()
	{
		return this.class466_0;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00065C70 File Offset: 0x00063E70
	protected override void vmethod_0(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "jL2J'Za-iD", object_);
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x00065CA4 File Offset: 0x00063EA4
	private void method_7(Class466 class466_1)
	{
		object[] object_ = new object[]
		{
			this,
			class466_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "fXA2pZa-iZ", object_);
	}

	// Token: 0x04000E7B RID: 3707
	private Class466 class466_0;

	// Token: 0x0200034A RID: 842
	private sealed class Class399
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x0000F02C File Offset: 0x0000D22C
		internal bool method_0(Class275 class275_0)
		{
			return this.gclass67_0.method_0() != null && class275_0.List_0.Contains(this.gclass67_0.method_0());
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0000F02C File Offset: 0x0000D22C
		internal bool method_1(Class275 class275_0)
		{
			return this.gclass67_0.method_0() != null && class275_0.List_0.Contains(this.gclass67_0.method_0());
		}

		// Token: 0x04000E7C RID: 3708
		public GClass67 gclass67_0;

		// Token: 0x04000E7D RID: 3709
		public Func<Class275, bool> func_0;

		// Token: 0x04000E7E RID: 3710
		public Func<Class275, bool> func_1;
	}
}
