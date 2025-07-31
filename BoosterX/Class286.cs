using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using FamFamFam.Flags.Wpf;

// Token: 0x0200026C RID: 620
internal sealed class Class286
{
	// Token: 0x060010B9 RID: 4281 RVA: 0x0005883C File Offset: 0x00056A3C
	public static ObservableCollection<Class286.Class503> smethod_0()
	{
		if (Class286.observableCollection_0 != null)
		{
			return Class286.observableCollection_0;
		}
		Class286.observableCollection_0 = new ObservableCollection<Class286.Class503>
		{
			new Class286.Class503("English", "en-US"),
			new Class286.Class503("Русский", "ru-RU"),
			new Class286.Class503("Українська", "uk-UA"),
			new Class286.Class503("Deutsch", "de-DE"),
			new Class286.Class503("Español", "es-ES"),
			new Class286.Class503("Français", "fr-FR"),
			new Class286.Class503("日本語", "ja-JP"),
			new Class286.Class503("한국어", "ko-KR"),
			new Class286.Class503("हिन्दी", "hi-IN"),
			new Class286.Class503("Türkçe", "tr-TR"),
			new Class286.Class503("العربية", "ar-SA"),
			new Class286.Class503("中文 (简体)", "zh-CN"),
			new Class286.Class503("繁體中文", "zh-TW"),
			new Class286.Class503("Português (Brasil)", "pt-BR"),
			new Class286.Class503("Português (Portugal)", "pt-PT"),
			new Class286.Class503("Polski", "pl-PL"),
			new Class286.Class503("Latviešu", "lv-LV"),
			new Class286.Class503("Svenska", "sv-SE"),
			new Class286.Class503("Italiano", "it-IT"),
			new Class286.Class503("Nederlands", "nl-NL"),
			new Class286.Class503("Čeština", "cs-CZ"),
			new Class286.Class503("ไทย", "th-TH"),
			new Class286.Class503("Tiếng Việt", "vi-VN"),
			new Class286.Class503("Bahasa Indonesia", "id-ID"),
			new Class286.Class503("עברית", "he-IL"),
			new Class286.Class503("বাংলা", "bn-BD"),
			new Class286.Class503("Kiswahili", "sw-KE"),
			new Class286.Class503("اردو", "ur-PK")
		};
		return Class286.observableCollection_0;
	}

	// Token: 0x04000A8F RID: 2703
	private static ObservableCollection<Class286.Class503> observableCollection_0;

	// Token: 0x0200026D RID: 621
	public sealed class Class503 : GClass162
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x0000C285 File Offset: 0x0000A485
		public Class503(string string_2, string string_3)
		{
			this.Name = string_2;
			this.Code = string_3;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0000C29B File Offset: 0x0000A49B
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x00058AEC File Offset: 0x00056CEC
		public string Code
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
				base.method_0("Code");
				if (this.bitmapSource_0 == null)
				{
					if (this.bitmapSource_0 == null)
					{
						this.bitmapSource_0 = (new CountryIdToFlagImageSourceConverter().Convert(value.Split(new char[]
						{
							'-'
						}).Last<string>().ToLower(), null, null, null) as BitmapImage);
					}
					base.method_0("Icon");
				}
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0000C2A3 File Offset: 0x0000A4A3
		public BitmapSource Icon
		{
			get
			{
				return this.bitmapSource_0;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x0000C2AB File Offset: 0x0000A4AB
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x0000C2B3 File Offset: 0x0000A4B3
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x04000A90 RID: 2704
		private string string_0;

		// Token: 0x04000A91 RID: 2705
		private BitmapSource bitmapSource_0;

		// Token: 0x04000A92 RID: 2706
		private string string_1;
	}
}
