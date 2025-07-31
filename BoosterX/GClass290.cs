using System;
using System.Diagnostics;
using ElevRightsX;

// Token: 0x02000695 RID: 1685
public static class GClass290
{
	// Token: 0x06002AA4 RID: 10916 RVA: 0x000A4F54 File Offset: 0x000A3154
	public static bool smethod_0(string string_0, bool bool_0)
	{
		string text = GClass290.smethod_1(string_0, bool_0);
		if (text == string.Empty)
		{
			return false;
		}
		bool result;
		try
		{
			Process processById = Process.GetProcessById((int)Convert.ToInt16(text));
			if (processById != null)
			{
				processById.WaitForExit();
			}
			result = true;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06002AA5 RID: 10917 RVA: 0x000A4FAC File Offset: 0x000A31AC
	public static string smethod_1(string string_0, bool bool_0)
	{
		string result;
		try
		{
			result = TrustedBypass.TrustedCrack(string_0, bool_0);
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}
}
