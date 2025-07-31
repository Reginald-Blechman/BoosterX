using System;

// Token: 0x020000C8 RID: 200
internal static class Class131
{
	// Token: 0x060005F5 RID: 1525 RVA: 0x0003A194 File Offset: 0x00038394
	static Class131()
	{
		try
		{
			Class131.bool_0 = (Type.GetType("Mono.Runtime") != null);
		}
		catch
		{
			Class131.bool_0 = false;
		}
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00005C9A File Offset: 0x00003E9A
	public static bool smethod_0()
	{
		return Class131.bool_0;
	}

	// Token: 0x0400032D RID: 813
	private static readonly bool bool_0;
}
