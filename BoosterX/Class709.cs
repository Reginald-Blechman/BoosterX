using System;
using System.IO;
using System.Text.RegularExpressions;

// Token: 0x020005C8 RID: 1480
internal sealed class Class709
{
	// Token: 0x0600260A RID: 9738 RVA: 0x000924BC File Offset: 0x000906BC
	public static void smethod_0(string string_0)
	{
		string contents = Regex.Replace(File.ReadAllText(string_0), "\"([^\"]+)\"\\s+\\{\\s+\\}", "\"$1\"\n{\n\t\"\"\n", RegexOptions.Multiline);
		File.WriteAllText(string_0, contents);
	}
}
