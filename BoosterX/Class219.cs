using System;

// Token: 0x020001C9 RID: 457
internal static class Class219
{
	// Token: 0x06000CB7 RID: 3255 RVA: 0x0004C9F4 File Offset: 0x0004ABF4
	public static bool? smethod_0(this string string_0)
	{
		if (string_0.smethod_9())
		{
			return null;
		}
		if (string_0 == "1")
		{
			return new bool?(true);
		}
		if (string_0 == "0")
		{
			return new bool?(false);
		}
		return new bool?(bool.Parse(string_0));
	}
}
