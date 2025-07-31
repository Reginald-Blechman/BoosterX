using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Media;

// Token: 0x02000317 RID: 791
internal sealed class Class374
{
	// Token: 0x06001464 RID: 5220 RVA: 0x00003332 File Offset: 0x00001532
	private Class374()
	{
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00064070 File Offset: 0x00062270
	public void method_0(Class374.Delegate27 delegate27_1)
	{
		Class374.Delegate27 @delegate = this.delegate27_0;
		Class374.Delegate27 delegate2;
		do
		{
			delegate2 = @delegate;
			Class374.Delegate27 value = (Class374.Delegate27)Delegate.Combine(delegate2, delegate27_1);
			@delegate = Interlocked.CompareExchange<Class374.Delegate27>(ref this.delegate27_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x000640A8 File Offset: 0x000622A8
	public void method_1(Class374.Delegate27 delegate27_1)
	{
		Class374.Delegate27 @delegate = this.delegate27_0;
		Class374.Delegate27 delegate2;
		do
		{
			delegate2 = @delegate;
			Class374.Delegate27 value = (Class374.Delegate27)Delegate.Remove(delegate2, delegate27_1);
			@delegate = Interlocked.CompareExchange<Class374.Delegate27>(ref this.delegate27_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x0000E3EA File Offset: 0x0000C5EA
	public static Class374 smethod_0()
	{
		if (Class374.class374_0 == null)
		{
			Class374.class374_0 = new Class374();
		}
		return Class374.class374_0;
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x000640E0 File Offset: 0x000622E0
	public FlowDirection method_2()
	{
		string a = Class298.smethod_2("CurrentLocalization");
		if (!(a == "ar-SA") && !(a == "he-IL") && !(a == "ur-PK"))
		{
			return FlowDirection.LeftToRight;
		}
		return FlowDirection.RightToLeft;
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00064128 File Offset: 0x00062328
	public void method_3()
	{
		if (Class551.class753_0.method_96() != null && !(Class551.class753_0.method_96() == string.Empty))
		{
			this.method_6(Class551.class753_0.method_96());
			return;
		}
		this.method_6(CultureInfo.CurrentCulture.Name);
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00064178 File Offset: 0x00062378
	public void method_4(CultureInfo cultureInfo_0)
	{
		string text = cultureInfo_0.Name;
		List<string> list = Class286.smethod_0().Select(new Func<Class286.Class503, string>(Class374.Class376.class376_0.method_0)).ToList<string>();
		if (!list.Contains(text))
		{
			try
			{
				Class374.Class375 @class = new Class374.Class375();
				@class.string_0 = cultureInfo_0.TwoLetterISOLanguageName;
				List<string> list2 = list.Where(new Func<string, bool>(@class.method_0)).ToList<string>();
				string text2;
				if (Class746.smethod_3<string>(list2))
				{
					text = list2.First<string>();
				}
				else if (Class374.dictionary_0.TryGetValue(@class.string_0, out text2))
				{
					text = text2;
				}
				else
				{
					text = "en-US";
				}
			}
			catch
			{
				text = "en-US";
			}
		}
		this.method_5(text);
		try
		{
			Class551.class753_0.method_97(text);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(text);
			this.method_7(new CultureInfo(text));
		}
		catch
		{
			text = "en-US";
			Class551.class753_0.method_97(text);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(text);
			this.method_7(new CultureInfo(text));
		}
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x000642AC File Offset: 0x000624AC
	private void method_5(string string_0)
	{
		List<string> list = new InstalledFontCollection().Families.Select(new Func<System.Drawing.FontFamily, string>(Class374.Class376.class376_0.method_1)).ToList<string>();
		System.Windows.Media.FontFamily fontFamily = new System.Windows.Media.FontFamily(new Uri("pack://application:,,,/BoosterX;component/"), "./Resources/Fonts/#Jost");
		System.Windows.Media.FontFamily fontFamily2 = new System.Windows.Media.FontFamily("Segoe UI");
		System.Windows.Media.FontFamily value;
		if (string_0 != null)
		{
			int length = string_0.Length;
			if (length == 5)
			{
				char c = string_0[4];
				if (c <= 'D')
				{
					if (c != 'A')
					{
						if (c == 'D')
						{
							if (string_0 == "bn-BD")
							{
								value = (list.Contains("Vrinda") ? new System.Windows.Media.FontFamily("Vrinda") : fontFamily2);
								goto IL_2BB;
							}
						}
					}
					else if (string_0 == "ar-SA")
					{
						value = (list.Contains("Segoe UI") ? new System.Windows.Media.FontFamily("Segoe UI") : fontFamily2);
						goto IL_2BB;
					}
				}
				else
				{
					switch (c)
					{
					case 'H':
						if (string_0 == "th-TH")
						{
							value = (list.Contains("Leelawadee UI") ? new System.Windows.Media.FontFamily("Leelawadee UI") : fontFamily2);
							goto IL_2BB;
						}
						break;
					case 'I':
					case 'J':
					case 'M':
					case 'O':
					case 'Q':
						break;
					case 'K':
						if (string_0 == "ur-PK")
						{
							value = (list.Contains("Segoe UI") ? new System.Windows.Media.FontFamily("Segoe UI") : fontFamily2);
							goto IL_2BB;
						}
						break;
					case 'L':
						if (string_0 == "he-IL")
						{
							value = (list.Contains("Segoe UI") ? new System.Windows.Media.FontFamily("Segoe UI") : fontFamily2);
							goto IL_2BB;
						}
						break;
					case 'N':
						if (string_0 == "zh-CN")
						{
							value = (list.Contains("Microsoft YaHei UI") ? new System.Windows.Media.FontFamily("Microsoft YaHei UI") : fontFamily2);
							goto IL_2BB;
						}
						if (string_0 == "hi-IN")
						{
							value = (list.Contains("Nirmala UI") ? new System.Windows.Media.FontFamily("Nirmala UI") : fontFamily2);
							goto IL_2BB;
						}
						break;
					case 'P':
						if (string_0 == "ja-JP")
						{
							value = (list.Contains("Meiryo UI") ? new System.Windows.Media.FontFamily("Meiryo UI") : fontFamily2);
							goto IL_2BB;
						}
						break;
					case 'R':
						if (string_0 == "ko-KR")
						{
							value = (list.Contains("Malgun Gothic") ? new System.Windows.Media.FontFamily("Malgun Gothic") : fontFamily2);
							goto IL_2BB;
						}
						break;
					default:
						if (c == 'W')
						{
							if (string_0 == "zh-TW")
							{
								value = (list.Contains("Microsoft JhengHei") ? new System.Windows.Media.FontFamily("Microsoft JhengHei") : fontFamily2);
								goto IL_2BB;
							}
						}
						break;
					}
				}
			}
		}
		value = fontFamily;
		IL_2BB:
		Application.Current.Resources["GlobalFontFamily"] = value;
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x0000E402 File Offset: 0x0000C602
	public void method_6(string string_0)
	{
		this.method_4(new CultureInfo(string_0));
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x0006458C File Offset: 0x0006278C
	private void method_7(CultureInfo cultureInfo_0)
	{
		ResourceDictionary item = new ResourceDictionary
		{
			Source = new Uri(string.Format("pack://application:,,,/BoosterX;component/Resources/Localization/{0}.xaml", cultureInfo_0.Name))
		};
		ResourceDictionary resourceDictionary = Application.Current.Resources.MergedDictionaries.FirstOrDefault(new Func<ResourceDictionary, bool>(Class374.Class376.class376_0.method_2));
		if (resourceDictionary != null)
		{
			Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
		}
		Application.Current.Resources.MergedDictionaries.Add(item);
		Class298.smethod_0();
		Class374.Delegate27 @delegate = this.delegate27_0;
		if (@delegate == null)
		{
			return;
		}
		@delegate(cultureInfo_0);
	}

	// Token: 0x04000DB4 RID: 3508
	private Class374.Delegate27 delegate27_0;

	// Token: 0x04000DB5 RID: 3509
	private static Class374 class374_0;

	// Token: 0x04000DB6 RID: 3510
	private static readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>
	{
		{
			"kk",
			"ru-RU"
		},
		{
			"be",
			"ru-RU"
		},
		{
			"uz",
			"ru-RU"
		},
		{
			"ky",
			"ru-RU"
		},
		{
			"tg",
			"ru-RU"
		},
		{
			"et",
			"ru-RU"
		},
		{
			"lv",
			"ru-RU"
		},
		{
			"lt",
			"ru-RU"
		},
		{
			"te",
			"hi-IN"
		},
		{
			"ta",
			"hi-IN"
		},
		{
			"mr",
			"hi-IN"
		},
		{
			"kn",
			"hi-IN"
		},
		{
			"gu",
			"hi-IN"
		},
		{
			"pa",
			"hi-IN"
		},
		{
			"ml",
			"hi-IN"
		},
		{
			"or",
			"hi-IN"
		},
		{
			"as",
			"hi-IN"
		},
		{
			"no",
			"sv-SE"
		},
		{
			"da",
			"sv-SE"
		},
		{
			"fi",
			"sv-SE"
		},
		{
			"fa",
			"ar-SA"
		},
		{
			"ar",
			"ar-SA"
		}
	};

	// Token: 0x02000318 RID: 792
	// (Invoke) Token: 0x06001470 RID: 5232
	public delegate void Delegate27(CultureInfo cultureInfo_0);

	// Token: 0x02000319 RID: 793
	private sealed class Class375
	{
		// Token: 0x06001474 RID: 5236 RVA: 0x0000E410 File Offset: 0x0000C610
		internal bool method_0(string string_1)
		{
			return string_1.StartsWith(this.string_0 + "-");
		}

		// Token: 0x04000DB7 RID: 3511
		public string string_0;
	}

	// Token: 0x0200031A RID: 794
	[Serializable]
	private sealed class Class376
	{
		// Token: 0x06001477 RID: 5239 RVA: 0x0000E435 File Offset: 0x0000C635
		internal string method_0(Class286.Class503 class503_0)
		{
			return class503_0.Code;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0000E43D File Offset: 0x0000C63D
		internal string method_1(System.Drawing.FontFamily fontFamily_0)
		{
			return fontFamily_0.Name;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000E445 File Offset: 0x0000C645
		internal bool method_2(ResourceDictionary resourceDictionary_0)
		{
			return resourceDictionary_0.Source.OriginalString.StartsWith("pack://application:,,,/BoosterX;component/Resources/Localization/");
		}

		// Token: 0x04000DB8 RID: 3512
		public static readonly Class374.Class376 class376_0 = new Class374.Class376();

		// Token: 0x04000DB9 RID: 3513
		public static Func<Class286.Class503, string> func_0;

		// Token: 0x04000DBA RID: 3514
		public static Func<System.Drawing.FontFamily, string> func_1;

		// Token: 0x04000DBB RID: 3515
		public static Func<ResourceDictionary, bool> func_2;
	}
}
