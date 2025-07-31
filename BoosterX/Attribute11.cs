using System;

// Token: 0x02000233 RID: 563
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[Attribute9]
internal sealed class Attribute11 : Attribute
{
	// Token: 0x06000F4D RID: 3917 RVA: 0x0000B3AD File Offset: 0x000095AD
	public Attribute11(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x040009C4 RID: 2500
	public readonly byte byte_0;
}
