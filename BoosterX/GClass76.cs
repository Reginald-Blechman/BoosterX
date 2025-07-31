using System;
using System.IO;
using System.Reflection;

// Token: 0x0200027E RID: 638
public sealed class GClass76
{
	// Token: 0x060010FD RID: 4349 RVA: 0x0005925C File Offset: 0x0005745C
	public static string smethod_0(string string_0)
	{
		string result;
		using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0))
		{
			if (manifestResourceStream != null)
			{
				StreamReader streamReader = new StreamReader(manifestResourceStream);
				try
				{
					return streamReader.ReadToEnd();
				}
				finally
				{
					((IDisposable)streamReader).Dispose();
				}
			}
			result = null;
		}
		return result;
	}
}
