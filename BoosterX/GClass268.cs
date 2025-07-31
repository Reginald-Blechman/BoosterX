using System;
using System.Windows;

// Token: 0x02000618 RID: 1560
public sealed class GClass268
{
	// Token: 0x060027BE RID: 10174 RVA: 0x00003332 File Offset: 0x00001532
	private GClass268()
	{
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x0001A5CF File Offset: 0x000187CF
	public static void smethod_0(string string_0)
	{
		GClass268.smethod_2(null, string_0);
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x0001A5D8 File Offset: 0x000187D8
	public static void smethod_1(Exception exception_0)
	{
		GClass268.smethod_2(exception_0, "ERROR");
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x0009BE58 File Offset: 0x0009A058
	public static void smethod_2(Exception exception_0, string string_0)
	{
		if (Class551.class753_0.method_80().GetValueOrDefault())
		{
			if (exception_0 == null)
			{
				MessageBox.Show(string_0, "ERROR", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				return;
			}
			MessageBox.Show(string.Concat(new string[]
			{
				string_0,
				"\n",
				exception_0.Message,
				"\n",
				exception_0.StackTrace
			}), "ERROR", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}
}
