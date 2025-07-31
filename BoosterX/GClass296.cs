using System;
using System.Text.RegularExpressions;

// Token: 0x020006F2 RID: 1778
public sealed class GClass296
{
	// Token: 0x06002C84 RID: 11396 RVA: 0x000AA750 File Offset: 0x000A8950
	public static GClass245 smethod_0(string string_0)
	{
		if (!GClass296.regex_0.IsMatch(string_0))
		{
			throw new GException5();
		}
		int[] int_ = GClass153.smethod_0(string_0.Substring(4).Replace("-", string.Empty));
		return new GClass245(string_0, int_);
	}

	// Token: 0x04001CE9 RID: 7401
	private static Regex regex_0 = new Regex("^CSGO(-?[\\w]{5}){5}$");
}
