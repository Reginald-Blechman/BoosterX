using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using TsudaKageyu;

namespace ns0
{
	// Token: 0x02000866 RID: 2150
	public sealed class dje_zQB54HQCJ26ASRT6GBACQNFDHKQ5FAVCLQ7LSNYLC6ZETJ9SF8FN63_ejd : Page, IComponentConnector
	{
		// Token: 0x06003343 RID: 13123 RVA: 0x00020288 File Offset: 0x0001E488
		public dje_zQB54HQCJ26ASRT6GBACQNFDHKQ5FAVCLQ7LSNYLC6ZETJ9SF8FN63_ejd()
		{
			this.InitializeComponent();
			this.string_0 = "-dev -console -nofriendsui -no-dwrite -nointro -nobigpicture -nofasthtml -nocrashmonitor -noshaders -no-shared-textures -disablehighdpi -cef-single-process -cef-in-process-gpu -single_core -cef-disable-d3d11 -cef-disable-sandbox -disable-winh264 -no-cef-sandbox -vrdisable -cef-disable-breakpad";
			this.string_1 = "-cef-single-process -cef-disable-gpu -no-dwrite -skipinitialbootstrap -quicklogin -oldtraymenu -silent -vgui";
			this.string_2 = GClass22.smethod_0().method_12();
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x000C6DA0 File Offset: 0x000C4FA0
		private void method_0(object sender, RoutedEventArgs e)
		{
			if (this.string_2 != null && !(this.string_2 == string.Empty))
			{
				try
				{
					File.Delete(Class169.string_1 + "\\StrippedSteam.lnk");
					File.Delete(this.string_2 + "\\StrippedSteam.bat");
					File.Delete(this.string_2 + "\\resource\\steamIcon.icon");
				}
				catch
				{
				}
				using (StreamWriter streamWriter = File.AppendText(this.string_2 + "\\StrippedSteam.bat"))
				{
					streamWriter.WriteLine("@echo off");
					streamWriter.WriteLine("taskkill /f /im steam.exe");
					streamWriter.WriteLine("start \"\" \"" + this.string_2 + "\\steam.exe\" " + this.string_0);
				}
				Class765.Interface15 @interface = (Class765.Interface15)new Class765.Class769();
				@interface.imethod_4("Created by BoosterX");
				@interface.imethod_17(this.string_2 + "\\StrippedSteam.bat");
				IconExtractor iconExtractor = new IconExtractor(this.string_2 + "\\steam.exe");
				using (FileStream fileStream = File.OpenWrite(this.string_2 + "\\resource\\steamIcon.icon"))
				{
					iconExtractor.Save(0, fileStream);
				}
				@interface.imethod_14(this.string_2 + "\\resource\\steamIcon.icon", 0);
				((Class765.Interface16)@interface).imethod_4(Path.Combine(Class169.string_1, "StrippedSteam.lnk"), false);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(this.textBlock_0, 100);
				return;
			}
			this.textBlock_0.Text = Class298.smethod_2("SteamNotFound");
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(this.textBlock_0, 100);
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x000C6F70 File Offset: 0x000C5170
		private void method_1(object sender, RoutedEventArgs e)
		{
			if (this.string_2 != null && !(this.string_2 == string.Empty))
			{
				try
				{
					File.Delete(Class169.string_1 + "\\StrippedSteam2.lnk");
					File.Delete(this.string_2 + "\\StrippedSteam2.bat");
					File.Delete(this.string_2 + "\\resource\\steamIcon.icon");
				}
				catch
				{
				}
				using (StreamWriter streamWriter = File.AppendText(this.string_2 + "\\StrippedSteam2.bat"))
				{
					streamWriter.WriteLine("@echo off");
					streamWriter.WriteLine("taskkill /f /im steam.exe");
					streamWriter.WriteLine("start \"\" \"" + this.string_2 + "\\steam.exe\" " + this.string_1);
				}
				Class765.Interface15 @interface = (Class765.Interface15)new Class765.Class769();
				@interface.imethod_4("Created by BoosterX");
				@interface.imethod_17(this.string_2 + "\\StrippedSteam2.bat");
				IconExtractor iconExtractor = new IconExtractor(this.string_2 + "\\steam.exe");
				using (FileStream fileStream = File.OpenWrite(this.string_2 + "\\resource\\steamIcon.icon"))
				{
					iconExtractor.Save(0, fileStream);
				}
				@interface.imethod_14(this.string_2 + "\\resource\\steamIcon.icon", 0);
				((Class765.Interface16)@interface).imethod_4(Path.Combine(Class169.string_1, "StrippedSteam2.lnk"), false);
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(this.textBlock_1, 100);
				return;
			}
			this.textBlock_1.Text = Class298.smethod_2("SteamNotFound");
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(this.textBlock_1, 100);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00007C85 File Offset: 0x00005E85
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000C7140 File Offset: 0x000C5340
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/steampage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000C7174 File Offset: 0x000C5374
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				((Button)target).Click += this.method_0;
				return;
			case 6:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 7:
				((Button)target).Click += this.method_1;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002446 RID: 9286
		private string string_0;

		// Token: 0x04002447 RID: 9287
		private string string_1;

		// Token: 0x04002448 RID: 9288
		private string string_2;

		// Token: 0x04002449 RID: 9289
		internal Grid grid_0;

		// Token: 0x0400244A RID: 9290
		internal Button button_0;

		// Token: 0x0400244B RID: 9291
		internal ScrollViewer scrollViewer_0;

		// Token: 0x0400244C RID: 9292
		internal TextBlock textBlock_0;

		// Token: 0x0400244D RID: 9293
		internal TextBlock textBlock_1;

		// Token: 0x0400244E RID: 9294
		private bool bool_0;
	}
}
