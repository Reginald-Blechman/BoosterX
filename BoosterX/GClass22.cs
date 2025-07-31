using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Win32;

// Token: 0x0200016C RID: 364
public sealed class GClass22
{
	// Token: 0x06000A34 RID: 2612 RVA: 0x000082E3 File Offset: 0x000064E3
	public static GClass22 smethod_0()
	{
		if (GClass22.gclass22_0 == null)
		{
			GClass22.gclass22_0 = new GClass22();
		}
		return GClass22.gclass22_0;
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x000469CC File Offset: 0x00044BCC
	public Dictionary<string, string> method_0()
	{
		if (this.dictionary_0.Count == 0)
		{
			foreach (string text in this.method_9())
			{
				try
				{
					Class192 @class = new Class192(this.method_5() + "\\userdata\\" + text + "\\config\\localconfig.vdf").method_1();
					this.dictionary_0.Add(@class.method_3(new List<string>
					{
						"friends"
					}, "PersonaName"), text.ToString());
				}
				catch
				{
				}
			}
		}
		return this.dictionary_0;
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x000082FB File Offset: 0x000064FB
	public string method_1()
	{
		return this.string_0;
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00008303 File Offset: 0x00006503
	public void method_2(string string_4)
	{
		this.string_0 = string_4;
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x0000830C File Offset: 0x0000650C
	public string method_3()
	{
		return this.string_1;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00008314 File Offset: 0x00006514
	public void method_4(string string_4)
	{
		this.string_1 = string_4;
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x0000831D File Offset: 0x0000651D
	public string method_5()
	{
		return this.string_2;
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00008325 File Offset: 0x00006525
	public void method_6(string string_4)
	{
		this.string_2 = string_4;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x0000832E File Offset: 0x0000652E
	public string method_7()
	{
		return this.string_3;
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00008336 File Offset: 0x00006536
	public void method_8(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x0000833F File Offset: 0x0000653F
	public List<string> method_9()
	{
		return this.list_0;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00008347 File Offset: 0x00006547
	public void method_10(List<string> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00046A94 File Offset: 0x00044C94
	public string method_11()
	{
		string text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", string.Empty);
		string path = Path.Combine(text, "steamapps", "libraryfolders.vdf");
		if (!File.Exists(path))
		{
			return null;
		}
		List<string> list = new List<string>
		{
			Path.Combine(new string[]
			{
				text
			})
		};
		string[] array = File.ReadAllLines(path);
		Regex regex = new Regex("\\\"(([^\\\"]*):\\\\([^\\\"]*))\\\"");
		foreach (string input in array)
		{
			if (regex.IsMatch(input))
			{
				string value = regex.Matches(input)[0].Groups[1].Value;
				list.Add(value.Replace("\\\\", "\\"));
			}
		}
		foreach (string path2 in list)
		{
			string text2 = Path.Combine(path2, "steamapps\\common\\Counter-Strike Global Offensive");
			if (Directory.Exists(text2))
			{
				return text2.ToString();
			}
		}
		return null;
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x00008350 File Offset: 0x00006550
	public string method_12()
	{
		return (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", string.Empty);
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00046BCC File Offset: 0x00044DCC
	public List<string> method_13()
	{
		List<string> list = new List<string>();
		foreach (string text in Directory.GetDirectories(this.method_12() + "\\userdata"))
		{
			list.Add(text.Split(new char[]
			{
				'\\'
			}).Last<string>());
		}
		return list;
	}

	// Token: 0x040006CB RID: 1739
	private static GClass22 gclass22_0;

	// Token: 0x040006CC RID: 1740
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x040006CD RID: 1741
	private string string_0 = string.Empty;

	// Token: 0x040006CE RID: 1742
	private string string_1;

	// Token: 0x040006CF RID: 1743
	private string string_2;

	// Token: 0x040006D0 RID: 1744
	private string string_3;

	// Token: 0x040006D1 RID: 1745
	private List<string> list_0;
}
