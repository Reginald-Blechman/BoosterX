using System;
using System.IO;

// Token: 0x0200015E RID: 350
public static class GClass19
{
	// Token: 0x06000A0A RID: 2570 RVA: 0x00045CAC File Offset: 0x00043EAC
	public static bool smethod_0()
	{
		bool result;
		try
		{
			if (GClass19.nullable_0 != null)
			{
				result = GClass19.nullable_0.Value;
			}
			else
			{
				Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Checkers", "pincode.bat", false);
				GClass290.smethod_0("cmd.exe /c " + Path.Combine(Class169.string_4, "pincode.bat"), false);
				File.Delete(Path.Combine(Class169.string_4, "pincode.bat"));
				if (Class551.class753_0.method_30().GetValueOrDefault())
				{
					GClass19.nullable_0 = new bool?(true);
					result = true;
				}
				else
				{
					string a = Class681.smethod_0("HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI", "LastLoggedOnProvider");
					if (a != "Null" && a != "{60B78E88-EAD8-445C-9CFD-0B87F74EA6CD}")
					{
						GClass19.nullable_0 = new bool?(true);
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x040006AD RID: 1709
	private static bool? nullable_0;
}
