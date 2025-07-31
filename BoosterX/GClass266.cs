using System;
using System.Security.Principal;

// Token: 0x02000612 RID: 1554
public sealed class GClass266
{
	// Token: 0x06002784 RID: 10116 RVA: 0x0001A388 File Offset: 0x00018588
	public static bool smethod_0()
	{
		return GClass266.bool_0;
	}

	// Token: 0x04001A10 RID: 6672
	private static bool bool_0 = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
}
