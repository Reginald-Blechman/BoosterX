using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x02000213 RID: 531
internal static class Class249
{
	// Token: 0x06000E5B RID: 3675 RVA: 0x0005151C File Offset: 0x0004F71C
	public static Dictionary<string, string> smethod_0(string string_1)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		if (string.IsNullOrWhiteSpace(string_1))
		{
			return dictionary;
		}
		Match match = Regex.Match(string_1, "^\\s*\"?(?<path>.*?\\.exe)\"?\\s*(?<args>.*)$", RegexOptions.IgnoreCase);
		if (match.Success)
		{
			string value = match.Groups["path"].Value;
			string value2 = match.Groups["args"].Value.Trim();
			dictionary[value] = value2;
		}
		else
		{
			dictionary[string_1.Trim()] = string.Empty;
		}
		return dictionary;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x000515A4 File Offset: 0x0004F7A4
	public static string smethod_1(this string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return string_1;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		for (int i = string_1.Length - 1; i >= 0; i--)
		{
			num++;
			stringBuilder.Insert(0, string_1[i]);
			if (num % 3 == 0 && i != 0)
			{
				stringBuilder.Insert(0, " ");
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00051608 File Offset: 0x0004F808
	public static bool smethod_2(this string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		char c = string_1[0];
		for (int i = 1; i < string_1.Length; i++)
		{
			if (string_1[i] != c)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00051648 File Offset: 0x0004F848
	public static string smethod_3(this string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return string_1;
		}
		string_1 = string_1.Trim();
		if (string_1.StartsWith("\"") && string_1.EndsWith("\""))
		{
			string_1 = string_1.Substring(1, string_1.Length - 2);
		}
		int num = string_1.IndexOf(" --");
		if (num == -1)
		{
			num = string_1.IndexOf(" -");
		}
		if (num != -1)
		{
			string_1 = string_1.Substring(0, num);
		}
		return string_1;
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x000516C8 File Offset: 0x0004F8C8
	public static bool smethod_4(this string string_1)
	{
		string source = "0123456789";
		if (string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		for (int i = 1; i < string_1.Length; i++)
		{
			if (!source.Contains(string_1[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x0005170C File Offset: 0x0004F90C
	public static bool smethod_5(this string string_1)
	{
		string source = "0123456789 ";
		if (string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		for (int i = 1; i < string_1.Length; i++)
		{
			if (!source.Contains(string_1[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00051750 File Offset: 0x0004F950
	public static bool smethod_6(this string string_1)
	{
		string source = "0123456789abcdefABCDEF";
		if (string.IsNullOrEmpty(string_1))
		{
			return true;
		}
		for (int i = 1; i < string_1.Length; i++)
		{
			if (!source.Contains(string_1[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00051794 File Offset: 0x0004F994
	public static string smethod_7(this string string_1)
	{
		if (string_1.smethod_3(Class243.smethod_5()))
		{
			return string_1.Replace(Class243.smethod_5(), string.Empty);
		}
		string pattern = "_[0-9A-Fa-f]{32}";
		string_1 = Regex.Replace(string_1, "\\{\\b[A-Fa-f0-9]{8}(?:-[A-Fa-f0-9]{4}){3}-[A-Fa-f0-9]{12}\\b\\}", string.Empty);
		string_1 = Regex.Replace(string_1, pattern, string.Empty);
		return string_1;
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x000517EC File Offset: 0x0004F9EC
	public static bool smethod_8(this string string_1)
	{
		object[] object_ = new object[]
		{
			string_1
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "L:=RtZa-i%", object_);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0000AB84 File Offset: 0x00008D84
	public static bool smethod_9(this string string_1)
	{
		return string_1 == null || !string_1.Any<char>() || string_1 == "null";
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00051824 File Offset: 0x0004FA24
	public static bool smethod_10(this string string_1, string string_2)
	{
		List<string> list = string_1.ToLower().Split(new char[]
		{
			' '
		}).ToList<string>();
		for (int i = 0; i < list.Count; i++)
		{
			List<int> list2 = new List<int>();
			for (int j = i; j < list.Count; j++)
			{
				list2.Add(j);
				List<string> list3 = new List<string>();
				foreach (int index in list2)
				{
					list3.Add(list[index]);
				}
				string string_3 = string.Join(" ", list3);
				if (string_2.smethod_11(string_3) <= 2)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x0000AB9F File Offset: 0x00008D9F
	public static int smethod_11(this string string_1, string string_2)
	{
		return Class249.smethod_12(string_1, string_2);
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x000518F4 File Offset: 0x0004FAF4
	public static int smethod_12(string string_1, string string_2)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			if (!string.IsNullOrEmpty(string_2))
			{
				return string_2.Length;
			}
			return 0;
		}
		else
		{
			if (!string.IsNullOrEmpty(string_2))
			{
				int length = string_1.Length;
				int length2 = string_2.Length;
				int[,] array = new int[length + 1, length2 + 1];
				for (int i = 0; i <= array.GetUpperBound(0); i++)
				{
					array[i, 0] = i;
				}
				for (int j = 0; j <= array.GetUpperBound(1); j++)
				{
					array[0, j] = j;
				}
				for (int k = 1; k <= array.GetUpperBound(0); k++)
				{
					for (int l = 1; l <= array.GetUpperBound(1); l++)
					{
						int num;
						if (string_1[k - 1] == string_2[l - 1])
						{
							num = 0;
						}
						else
						{
							num = 1;
						}
						int val = array[k - 1, l] + 1;
						int val2 = array[k, l - 1] + 1;
						int val3 = array[k - 1, l - 1] + num;
						array[k, l] = Math.Min(val, Math.Min(val2, val3));
						if (k > 1 && l > 1 && string_1[k - 1] == string_2[l - 2] && string_1[k - 2] == string_2[l - 1])
						{
							array[k, l] = Math.Min(array[k, l], array[k - 2, l - 2] + num);
						}
					}
				}
				return array[array.GetUpperBound(0), array.GetUpperBound(1)];
			}
			if (!string.IsNullOrEmpty(string_1))
			{
				return string_1.Length;
			}
			return 0;
		}
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00051A84 File Offset: 0x0004FC84
	public static string[] smethod_13(this object object_0, string[] string_1)
	{
		List<string> list = new List<string>();
		foreach (string text in object_0 as string[])
		{
			for (int j = 0; j < string_1.Length; j++)
			{
				if (string_1[j] != text)
				{
					list.Add(text);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x0000ABA8 File Offset: 0x00008DA8
	public static string smethod_14(this object object_0)
	{
		return object_0.ToString().Split(new char[]
		{
			','
		})[0];
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00051AE0 File Offset: 0x0004FCE0
	public static string smethod_15(string string_1, int int_0, char char_0)
	{
		if (string_1.Length >= int_0)
		{
			return string_1;
		}
		string text = string_1;
		for (int i = 0; i < int_0 - string_1.Length; i++)
		{
			text += char_0.ToString();
		}
		return text;
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00051B1C File Offset: 0x0004FD1C
	public static string smethod_16(string string_1, int int_0)
	{
		string text = string_1.Replace('.', ',');
		if (!text.Contains(","))
		{
			return text;
		}
		char[] array = text.Split(new char[]
		{
			','
		})[1].ToCharArray();
		if (array.Length == 0)
		{
			return text.Replace(",", string.Empty);
		}
		if (array.Length > 1)
		{
			string text2 = text.Split(new char[]
			{
				','
			})[0] + ",";
			for (int i = 0; i < int_0; i++)
			{
				text2 += array[i].ToString();
			}
			return text2;
		}
		return text;
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00051B1C File Offset: 0x0004FD1C
	public static string smethod_17(this string string_1, int int_0)
	{
		string text = string_1.Replace('.', ',');
		if (!text.Contains(","))
		{
			return text;
		}
		char[] array = text.Split(new char[]
		{
			','
		})[1].ToCharArray();
		if (array.Length == 0)
		{
			return text.Replace(",", string.Empty);
		}
		if (array.Length > 1)
		{
			string text2 = text.Split(new char[]
			{
				','
			})[0] + ",";
			for (int i = 0; i < int_0; i++)
			{
				text2 += array[i].ToString();
			}
			return text2;
		}
		return text;
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00051BBC File Offset: 0x0004FDBC
	public static string smethod_18(string string_1)
	{
		string[] array = string_1.Split(new char[]
		{
			' ',
			',',
			';',
			'.',
			'\n',
			'\r',
			'\t'
		}, StringSplitOptions.RemoveEmptyEntries);
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			string text = array2[i].ToLowerInvariant();
			if (!Class249.string_0.Contains(text) && text.Length > 2)
			{
				if (dictionary.ContainsKey(text))
				{
					Dictionary<string, int> dictionary2 = dictionary;
					string key = text;
					int num = dictionary2[key];
					dictionary2[key] = num + 1;
				}
				else
				{
					dictionary.Add(text, 1);
				}
			}
		}
		return dictionary.OrderByDescending(new Func<KeyValuePair<string, int>, int>(Class249.Class250.class250_0.method_0)).FirstOrDefault<KeyValuePair<string, int>>().Key;
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x0000ABC2 File Offset: 0x00008DC2
	public static bool smethod_19(this string string_1)
	{
		return string_1.Split(new char[]
		{
			' ',
			'\n',
			'\r',
			'\t'
		}, StringSplitOptions.RemoveEmptyEntries).Length == 1;
	}

	// Token: 0x04000940 RID: 2368
	private static string[] string_0 = new string[]
	{
		"a",
		"an",
		"the",
		"in",
		"on",
		"is",
		"are",
		"and",
		"or",
		"not"
	};

	// Token: 0x02000214 RID: 532
	[Serializable]
	private sealed class Class250
	{
		// Token: 0x06000E71 RID: 3697 RVA: 0x0000ABED File Offset: 0x00008DED
		internal int method_0(KeyValuePair<string, int> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x04000941 RID: 2369
		public static readonly Class249.Class250 class250_0 = new Class249.Class250();

		// Token: 0x04000942 RID: 2370
		public static Func<KeyValuePair<string, int>, int> func_0;
	}
}
