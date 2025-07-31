using System;
using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using PIManagerX;

// Token: 0x02000655 RID: 1621
public sealed class GClass275
{
	// Token: 0x06002906 RID: 10502 RVA: 0x0009F948 File Offset: 0x0009DB48
	public static BitmapSource smethod_0(string string_0)
	{
		GClass275.Class772 @class = new GClass275.Class772();
		Guid.TryParse(string_0, out @class.guid_0);
		GClass275.lazy_0 = new Lazy<BitmapSource>(new Func<BitmapSource>(@class.method_0), false);
		return GClass275.lazy_0.Value;
	}

	// Token: 0x06002907 RID: 10503 RVA: 0x0009F98C File Offset: 0x0009DB8C
	internal static int smethod_1(string string_0, out string string_1)
	{
		string_1 = new string(string_0.ToCharArray());
		int result = PManagerX.PathParseIconLocation(string_1);
		int num = string_1.LastIndexOf('\0');
		if (num >= 0)
		{
			string_1 = string_1.Substring(0, num);
		}
		return result;
	}

	// Token: 0x06002908 RID: 10504 RVA: 0x0001AE9A File Offset: 0x0001909A
	internal static string smethod_2(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return string_0;
		}
		if (string_0.Contains("%"))
		{
			return Environment.ExpandEnvironmentVariables(string_0);
		}
		return string_0;
	}

	// Token: 0x04001AE4 RID: 6884
	private static Lazy<BitmapSource> lazy_0;

	// Token: 0x02000656 RID: 1622
	private sealed class Class772
	{
		// Token: 0x0600290A RID: 10506 RVA: 0x0009F9C8 File Offset: 0x0009DBC8
		internal BitmapSource method_0()
		{
			IntPtr intPtr;
			if (!PManagerX.SetupDiLoadClassIcon(this.guid_0, ref intPtr, IntPtr.Zero))
			{
				return null;
			}
			BitmapSource result;
			using (Icon icon = Icon.FromHandle(intPtr))
			{
				BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
				PManagerX.DestroyIcon(intPtr);
				result = bitmapSource;
			}
			return result;
		}

		// Token: 0x04001AE5 RID: 6885
		public Guid guid_0;
	}
}
