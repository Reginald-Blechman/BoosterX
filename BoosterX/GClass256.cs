using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020005D5 RID: 1493
public static class GClass256
{
	// Token: 0x0600266F RID: 9839 RVA: 0x00093018 File Offset: 0x00091218
	public static string smethod_0(this string string_0)
	{
		IEnumerable<char> values = string_0.ToCharArray().Reverse<char>();
		return string.Join<char>(string.Empty, values);
	}
}
