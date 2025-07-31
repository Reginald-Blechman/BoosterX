using System;
using System.Net.NetworkInformation;

// Token: 0x02000116 RID: 278
internal sealed class Class168
{
	// Token: 0x06000803 RID: 2051 RVA: 0x00006F59 File Offset: 0x00005159
	public static double smethod_0(string string_0)
	{
		return (double)new Ping().Send(string_0).RoundtripTime;
	}
}
