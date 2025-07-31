using System;
using System.Security.Cryptography;

// Token: 0x020000B9 RID: 185
internal sealed class Class116 : Class114
{
	// Token: 0x06000580 RID: 1408 RVA: 0x0000592C File Offset: 0x00003B2C
	public Class116(ICryptoTransform icryptoTransform_1)
	{
		this.icryptoTransform_0 = icryptoTransform_1;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0000593B File Offset: 0x00003B3B
	public override void Dispose()
	{
		this.icryptoTransform_0.Dispose();
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00005948 File Offset: 0x00003B48
	public override bool vmethod_0()
	{
		return this.icryptoTransform_0.CanReuseTransform;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00005955 File Offset: 0x00003B55
	public override int vmethod_1()
	{
		return this.icryptoTransform_0.InputBlockSize;
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00005962 File Offset: 0x00003B62
	public override int vmethod_2(byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return this.icryptoTransform_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00005976 File Offset: 0x00003B76
	public override byte[] vmethod_3(byte[] byte_0, int int_0, int int_1)
	{
		return this.icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	// Token: 0x0400030A RID: 778
	private ICryptoTransform icryptoTransform_0;
}
