using System;

// Token: 0x02000025 RID: 37
internal sealed class Class20 : Interface2
{
	// Token: 0x060000CD RID: 205 RVA: 0x0000373D File Offset: 0x0000193D
	public Class20(Interface2 interface2_1, byte[] byte_1) : this(interface2_1, byte_1, 0, byte_1.Length)
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x000236B8 File Offset: 0x000218B8
	public Class20(Interface2 interface2_1, byte[] byte_1, int int_0, int int_1)
	{
		if (interface2_1 == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("iv");
		}
		this.interface2_0 = interface2_1;
		this.byte_0 = new byte[int_1];
		Array.Copy(byte_1, int_0, this.byte_0, 0, int_1);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000374B File Offset: 0x0000194B
	public byte[] method_0()
	{
		return (byte[])this.byte_0.Clone();
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000375D File Offset: 0x0000195D
	public Interface2 method_1()
	{
		return this.interface2_0;
	}

	// Token: 0x0400003F RID: 63
	private readonly Interface2 interface2_0;

	// Token: 0x04000040 RID: 64
	private readonly byte[] byte_0;
}
