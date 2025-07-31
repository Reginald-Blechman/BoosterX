using System;

// Token: 0x0200009E RID: 158
internal sealed class Class100
{
	// Token: 0x06000504 RID: 1284 RVA: 0x00005578 File Offset: 0x00003778
	public Class100(bool bool_1, Class128 class128_2, Class128 class128_3)
	{
		if (class128_2 == null)
		{
			throw new ArgumentNullException("modulus");
		}
		if (class128_3 == null)
		{
			throw new ArgumentNullException("exponent");
		}
		this.bool_0 = bool_1;
		this.class128_0 = class128_2;
		this.class128_1 = class128_3;
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x000055B3 File Offset: 0x000037B3
	public bool method_0()
	{
		return this.bool_0;
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x000055BB File Offset: 0x000037BB
	public Class128 method_1()
	{
		return this.class128_0;
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x000055C3 File Offset: 0x000037C3
	public Class128 method_2()
	{
		return this.class128_1;
	}

	// Token: 0x040002DB RID: 731
	private readonly bool bool_0;

	// Token: 0x040002DC RID: 732
	private readonly Class128 class128_0;

	// Token: 0x040002DD RID: 733
	private readonly Class128 class128_1;
}
