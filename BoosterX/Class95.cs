using System;
using System.Reflection;
using System.Security;

// Token: 0x0200009A RID: 154
internal static class Class95
{
	// Token: 0x060004E3 RID: 1251 RVA: 0x00037750 File Offset: 0x00035950
	private static bool smethod_0()
	{
		bool result;
		try
		{
			if (Environment.Version.Major < 4)
			{
				result = false;
			}
			else
			{
				Assembly assembly = typeof(Class31).Assembly;
				Assembly assembly2 = typeof(SecurityCriticalAttribute).Assembly;
				bool flag = false;
				foreach (object obj in assembly.GetCustomAttributes(false))
				{
					if (obj is AllowPartiallyTrustedCallersAttribute)
					{
						flag = true;
					}
					else
					{
						Type type = obj.GetType();
						if (type.Assembly == assembly2 && "System.Security.SecurityRulesAttribute".Equals(type.FullName, StringComparison.Ordinal) && (byte)type.GetProperty("RuleSet").GetValue(obj, null) != 2)
						{
							return false;
						}
					}
				}
				result = flag;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00005500 File Offset: 0x00003700
	public static bool smethod_1()
	{
		return Class95.bool_0;
	}

	// Token: 0x040002D9 RID: 729
	private static readonly bool bool_0 = Class95.smethod_0();
}
