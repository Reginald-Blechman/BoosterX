using System;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020000DB RID: 219
internal static class Class143
{
	// Token: 0x060006BE RID: 1726 RVA: 0x0000634D File Offset: 0x0000454D
	internal static byte[] smethod_0(string string_0)
	{
		return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(string_0));
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x0003B478 File Offset: 0x00039678
	internal static string smethod_1(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in Class143.smethod_0(string_0))
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
