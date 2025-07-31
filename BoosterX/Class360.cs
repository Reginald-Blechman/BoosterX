using System;

// Token: 0x020002F0 RID: 752
internal static class Class360
{
	// Token: 0x060013A7 RID: 5031 RVA: 0x00062020 File Offset: 0x00060220
	public static long smethod_0(this DateTime dateTime_0)
	{
		DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
		return (long)(dateTime_0.ToLocalTime() - d).TotalSeconds;
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x00062058 File Offset: 0x00060258
	public static DateTime smethod_1(this long long_0)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
		return dateTime.AddSeconds((double)long_0);
	}
}
