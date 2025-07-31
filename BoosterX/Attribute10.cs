using System;

// Token: 0x020001C8 RID: 456
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
[Attribute9]
internal sealed class Attribute10 : Attribute
{
	// Token: 0x06000CB5 RID: 3253 RVA: 0x00009B84 File Offset: 0x00007D84
	public Attribute10(byte byte_1)
	{
		this.byte_0 = new byte[]
		{
			byte_1
		};
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00009B9C File Offset: 0x00007D9C
	public Attribute10(byte[] byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x04000829 RID: 2089
	public readonly byte[] byte_0;
}
