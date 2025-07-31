using System;

// Token: 0x0200003C RID: 60
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[Attribute3]
internal sealed class Attribute5 : Attribute
{
	// Token: 0x0600016B RID: 363 RVA: 0x00003C95 File Offset: 0x00001E95
	public Attribute5(byte byte_1)
	{
		this.byte_0 = byte_1;
	}

	// Token: 0x0400007C RID: 124
	public readonly byte byte_0;
}
