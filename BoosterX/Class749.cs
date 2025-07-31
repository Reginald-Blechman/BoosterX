using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

// Token: 0x0200061C RID: 1564
internal abstract class Class749
{
	// Token: 0x060027D6 RID: 10198 RVA: 0x0009BEF8 File Offset: 0x0009A0F8
	public static string smethod_0(string string_0, string string_1)
	{
		Class749.Class755 @class = new Class749.Class755();
		@class.string_0 = string_1;
		string key = @class.string_0 + ":" + string_0;
		object obj = Class749.object_0;
		lock (obj)
		{
			string result;
			if (Class749.dictionary_0.TryGetValue(key, out result))
			{
				return result;
			}
		}
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true))
		{
			if (!registryKey.GetSubKeyNames().Any(new Func<string, bool>(@class.method_0)))
			{
				registryKey.CreateSubKey(@class.string_0);
			}
		}
		string result2;
		using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + @class.string_0, true))
		{
			try
			{
				object value = registryKey2.GetValue(string_0);
				string text = (value == null) ? null : value.ToString();
				obj = Class749.object_0;
				lock (obj)
				{
					Class749.dictionary_0[key] = text;
				}
				result2 = text;
			}
			catch
			{
				obj = Class749.object_0;
				lock (obj)
				{
					Class749.dictionary_0[key] = null;
				}
				result2 = null;
			}
		}
		return result2;
	}

	// Token: 0x060027D7 RID: 10199 RVA: 0x0009C090 File Offset: 0x0009A290
	public static void smethod_1(string string_0, string string_1, string string_2)
	{
		Class749.Class754 @class = new Class749.Class754();
		@class.string_0 = string_2;
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true))
		{
			if (!registryKey.GetSubKeyNames().Any(new Func<string, bool>(@class.method_0)))
			{
				registryKey.CreateSubKey(@class.string_0);
			}
		}
		using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + @class.string_0, true))
		{
			try
			{
				string key = @class.string_0 + ":" + string_0;
				if (string_1.smethod_9())
				{
					registryKey2.DeleteValue(string_0);
					Class749.dictionary_0.Remove(key);
				}
				else
				{
					registryKey2.SetValue(string_0, string_1, RegistryValueKind.String);
					object obj = Class749.object_0;
					lock (obj)
					{
						Class749.dictionary_0[key] = string_1;
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x060027D8 RID: 10200 RVA: 0x0009C1B4 File Offset: 0x0009A3B4
	public static List<string> smethod_2(string string_0, string string_1)
	{
		Class749.Class756 @class = new Class749.Class756();
		@class.string_0 = string_1;
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true))
		{
			if (!registryKey.GetSubKeyNames().Any(new Func<string, bool>(@class.method_0)))
			{
				registryKey.CreateSubKey(@class.string_0);
			}
		}
		List<string> result;
		using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + @class.string_0 + "\\" + string_0, true))
		{
			try
			{
				result = registryKey2.GetSubKeyNames().ToList<string>();
			}
			catch
			{
				result = null;
			}
		}
		return result;
	}

	// Token: 0x04001A24 RID: 6692
	private static readonly object object_0 = new object();

	// Token: 0x04001A25 RID: 6693
	private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x0200061D RID: 1565
	private sealed class Class754
	{
		// Token: 0x060027DA RID: 10202 RVA: 0x0001A6EC File Offset: 0x000188EC
		internal bool method_0(string string_1)
		{
			return string_1 == this.string_0;
		}

		// Token: 0x04001A26 RID: 6694
		public string string_0;
	}

	// Token: 0x0200061E RID: 1566
	private sealed class Class755
	{
		// Token: 0x060027DC RID: 10204 RVA: 0x0001A6FA File Offset: 0x000188FA
		internal bool method_0(string string_1)
		{
			return string_1 == this.string_0;
		}

		// Token: 0x04001A27 RID: 6695
		public string string_0;
	}

	// Token: 0x0200061F RID: 1567
	private sealed class Class756
	{
		// Token: 0x060027DE RID: 10206 RVA: 0x0001A708 File Offset: 0x00018908
		internal bool method_0(string string_1)
		{
			return string_1 == this.string_0;
		}

		// Token: 0x04001A28 RID: 6696
		public string string_0;
	}
}
