using System;
using System.Diagnostics;

// Token: 0x02000081 RID: 129
internal static class Class57
{
	// Token: 0x06000443 RID: 1091 RVA: 0x00035F90 File Offset: 0x00034190
	static Class57()
	{
		OperatingSystem osversion = Environment.OSVersion;
		Class57.bool_0 = (osversion.Platform == PlatformID.Win32NT && osversion.Version >= new Version(6, 0));
		if (Class57.smethod_0())
		{
			try
			{
				Class57.bool_1 = Class57.smethod_2(osversion);
			}
			catch
			{
				Class57.bool_1 = false;
			}
		}
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00004F7C File Offset: 0x0000317C
	public static bool smethod_0()
	{
		return Class57.bool_0;
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00004F83 File Offset: 0x00003183
	public static bool smethod_1()
	{
		return Class57.bool_1;
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00004F8A File Offset: 0x0000318A
	private static bool smethod_2(OperatingSystem operatingSystem_0)
	{
		return operatingSystem_0.Platform != PlatformID.Win32NT || !(operatingSystem_0.Version < new Version(6, 2, 9200)) || Process.GetCurrentProcess().SessionId != 0;
	}

	// Token: 0x040002AE RID: 686
	private static readonly bool bool_0;

	// Token: 0x040002AF RID: 687
	private static readonly bool bool_1;
}
