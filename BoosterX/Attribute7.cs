using System;

// Token: 0x02000085 RID: 133
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
[Attribute3]
internal sealed class Attribute7 : Attribute
{
	// Token: 0x06000458 RID: 1112 RVA: 0x00005069 File Offset: 0x00003269
	public Attribute7(byte byte_1)
	{
		this.byte_0 = new byte[]
		{
			byte_1
		};
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00005081 File Offset: 0x00003281
	public Attribute7(byte[] byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x040002B5 RID: 693
	public readonly byte[] byte_0;
}
