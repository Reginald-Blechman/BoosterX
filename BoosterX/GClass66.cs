using System;

// Token: 0x02000250 RID: 592
public sealed class GClass66 : GInterface18
{
	// Token: 0x06001006 RID: 4102 RVA: 0x0000BB8D File Offset: 0x00009D8D
	public T method_0<T>() where T : class, GInterface16, new()
	{
		return Activator.CreateInstance<T>();
	}
}
