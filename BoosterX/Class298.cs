using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

// Token: 0x02000285 RID: 645
internal sealed class Class298
{
	// Token: 0x0600114B RID: 4427 RVA: 0x000595E0 File Offset: 0x000577E0
	public static void smethod_0()
	{
		Class298.dictionary_0 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		Application application = Application.Current;
		if (((application != null) ? application.Resources : null) != null)
		{
			foreach (object obj in Application.Current.Resources)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				string text = dictionaryEntry.Key as string;
				if (text != null)
				{
					string text2 = dictionaryEntry.Value as string;
					if (text2 != null)
					{
						Class298.dictionary_0[text] = text2;
					}
				}
			}
		}
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00059688 File Offset: 0x00057888
	public static void smethod_1(TextBlock textBlock_0, string string_0)
	{
		Class298.Class300 @class = new Class298.Class300();
		@class.string_0 = string_0;
		@class.textBlock_0 = textBlock_0;
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x000596C4 File Offset: 0x000578C4
	public static string smethod_2(string string_0)
	{
		string result;
		if (Class298.dictionary_0.TryGetValue(string_0, out result))
		{
			return result;
		}
		string text = Application.Current.TryFindResource(string_0) as string;
		if (!string.IsNullOrEmpty(text))
		{
			Class298.dictionary_0[string_0] = text;
			return text;
		}
		Class298.dictionary_0[string_0] = string_0;
		if (string_0.smethod_9())
		{
			return string.Empty;
		}
		return string_0;
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00059724 File Offset: 0x00057924
	public static Style smethod_3(string string_0)
	{
		Class298.Class301 @class = new Class298.Class301();
		@class.string_0 = string_0;
		@class.style_0 = new Style();
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		return @class.style_0;
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x0005976C File Offset: 0x0005796C
	public static DrawingImage smethod_4(string string_0)
	{
		Class298.Class302 @class = new Class298.Class302();
		@class.string_0 = string_0;
		@class.drawingImage_0 = new DrawingImage();
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		return @class.drawingImage_0;
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x000597B4 File Offset: 0x000579B4
	public static object smethod_5(string string_0)
	{
		Class298.Class299 @class = new Class298.Class299();
		@class.string_0 = string_0;
		@class.object_0 = new object();
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		return @class.object_0;
	}

	// Token: 0x04000ACA RID: 2762
	private static Dictionary<string, string> dictionary_0;

	// Token: 0x02000286 RID: 646
	private sealed class Class299
	{
		// Token: 0x06001152 RID: 4434 RVA: 0x0000C9CB File Offset: 0x0000ABCB
		internal void method_0()
		{
			this.object_0 = Application.Current.FindResource(this.string_0);
		}

		// Token: 0x04000ACB RID: 2763
		public object object_0;

		// Token: 0x04000ACC RID: 2764
		public string string_0;
	}

	// Token: 0x02000287 RID: 647
	private sealed class Class300
	{
		// Token: 0x06001154 RID: 4436 RVA: 0x000597FC File Offset: 0x000579FC
		internal void method_0()
		{
			try
			{
				if (this.string_0.smethod_9())
				{
					this.textBlock_0.Text = string.Empty;
				}
				else
				{
					this.textBlock_0.SetResourceReference(TextBlock.TextProperty, this.string_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000ACD RID: 2765
		public string string_0;

		// Token: 0x04000ACE RID: 2766
		public TextBlock textBlock_0;
	}

	// Token: 0x02000288 RID: 648
	private sealed class Class301
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x0000C9E3 File Offset: 0x0000ABE3
		internal void method_0()
		{
			this.style_0 = (Application.Current.FindResource(this.string_0) as Style);
		}

		// Token: 0x04000ACF RID: 2767
		public Style style_0;

		// Token: 0x04000AD0 RID: 2768
		public string string_0;
	}

	// Token: 0x02000289 RID: 649
	private sealed class Class302
	{
		// Token: 0x06001158 RID: 4440 RVA: 0x0000CA00 File Offset: 0x0000AC00
		internal void method_0()
		{
			this.drawingImage_0 = (Application.Current.FindResource(this.string_0) as DrawingImage);
		}

		// Token: 0x04000AD1 RID: 2769
		public DrawingImage drawingImage_0;

		// Token: 0x04000AD2 RID: 2770
		public string string_0;
	}
}
