using System;

// Token: 0x02000037 RID: 55
internal sealed class Class115 : Class114
{
	// Token: 0x0600013B RID: 315 RVA: 0x00003B74 File Offset: 0x00001D74
	public Class115(Interface4 interface4_1)
	{
		this.interface4_0 = interface4_1;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00003B83 File Offset: 0x00001D83
	public override void Dispose()
	{
		this.interface4_0.imethod_15();
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00003982 File Offset: 0x00001B82
	public override bool vmethod_0()
	{
		return true;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00003B90 File Offset: 0x00001D90
	public override int vmethod_1()
	{
		return this.interface4_0.imethod_2();
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00003B9D File Offset: 0x00001D9D
	public override int vmethod_2(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return this.interface4_0.imethod_8(byte_0, int_0, int_1, byte_1, int_2);
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00003BB1 File Offset: 0x00001DB1
	public override byte[] vmethod_3(byte[] byte_0, int int_0, int int_1)
	{
		return this.interface4_0.imethod_11(byte_0, int_0, int_1);
	}

	// Token: 0x04000067 RID: 103
	private readonly Interface4 interface4_0;
}
