using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using Microsoft.WindowsAPICodePack.Dialogs;
using WinCopies.Util;

namespace ns0
{
	// Token: 0x02000891 RID: 2193
	public sealed class dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd : dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd, IComponentConnector
	{
		// Token: 0x060033E1 RID: 13281 RVA: 0x000206F3 File Offset: 0x0001E8F3
		public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd()
		{
			this.InitializeComponent();
			this.method_1();
			this.method_0();
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x000CA144 File Offset: 0x000C8344
		private void method_0()
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct681 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct681>(ref @struct);
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x000CA17C File Offset: 0x000C837C
		private void method_1()
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct682 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct682>(ref @struct);
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x000CA1B4 File Offset: 0x000C83B4
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686>(ref @struct);
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000CA1EC File Offset: 0x000C83EC
		private void method_2()
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct689 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct689>(ref @struct);
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x000CA224 File Offset: 0x000C8424
		private void method_3(object sender, RoutedEventArgs e)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
			{
				InitialDirectory = "C:\\",
				IsFolderPicker = true
			};
			if (commonOpenFileDialog.ShowDialog() == 1)
			{
				this.textBox_0.Text = Path.Combine(commonOpenFileDialog.FileName, "GameModeX");
			}
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x000CA270 File Offset: 0x000C8470
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			if (this.textBox_1.Text == Class298.smethod_2("ClickOnKeys"))
			{
				this.textBox_1.Text = this.string_2;
			}
			this.string_2 = this.textBox_1.Text;
			this.bool_1 = true;
			this.textBox_1.Text = Class298.smethod_2("ClickOnKeys");
			this.int_0 = 0;
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x000CA2E0 File Offset: 0x000C84E0
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			if (this.textBox_2.Text == Class298.smethod_2("ClickOnKeys"))
			{
				this.textBox_2.Text = this.string_2;
			}
			this.string_2 = this.textBox_2.Text;
			this.textBox_2.Text = Class298.smethod_2("ClickOnKeys");
			this.int_0 = 1;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x0002072E File Offset: 0x0001E92E
		public void method_4()
		{
			this.bool_1 = true;
			this.int_0 = 2;
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x000CA34C File Offset: 0x000C854C
		private void button_4_Click(object sender, RoutedEventArgs e)
		{
			if (this.class487_0.STPairs.Count >= 5)
			{
				return;
			}
			this.class494_0 = new Class494(this.class487_0);
			this.class487_0.STPairs.Add(this.class494_0);
			this.class494_0.Keys = Class298.smethod_2("Click2Keys");
			this.class494_0.bool_0 = true;
			this.bool_1 = true;
			this.int_0 = 2;
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x000CA3C4 File Offset: 0x000C85C4
		private void grid_0_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			string text = e.Key.ToString();
			string[] source = this.string_0.Split(new char[]
			{
				'+'
			}, StringSplitOptions.RemoveEmptyEntries);
			if (this.bool_1)
			{
				if (text == "OemQuotes" && !this.string_0.Contains("OEM7"))
				{
					this.string_0 += "OEM7+";
					this.int_1++;
				}
				else if (text == "System" && !this.string_0.Contains("MENU"))
				{
					this.string_0 += "MENU+";
					this.int_1++;
				}
				else if ((text == "LeftShift" || text == "RightShift") && !this.string_0.Contains("SHIFT"))
				{
					this.string_0 += "SHIFT+";
					this.int_1++;
				}
				else if ((text == "LeftCtrl" || text == "RightCtrl") && !this.string_0.Contains("CTRL"))
				{
					this.string_0 += "CTRL+";
					this.int_1++;
				}
				else if (text != "LeftCtrl" && text != "LeftShift" && text != "System" && text != "OemQuotes" && !source.Contains(text))
				{
					this.string_0 = this.string_0 + text + "+";
					this.int_1++;
				}
				switch (this.int_0)
				{
				case 0:
					this.class487_0.OnOffShortcut = this.string_0;
					return;
				case 1:
					this.class487_0.CleanCacheShortcut = this.string_0;
					return;
				case 2:
					this.class494_0.Keys = this.string_0;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x000CA604 File Offset: 0x000C8804
		private void grid_0_PreviewKeyUp(object sender, KeyEventArgs e)
		{
			if (this.bool_1)
			{
				if (this.string_0.EndsWith("+"))
				{
					this.string_0 = this.string_0.TrimEnd(new char[]
					{
						'+'
					});
				}
				if (this.int_1 == this.string_0.Split(new char[]
				{
					'+'
				}).Length)
				{
					this.string_1 = this.string_0;
					this.string_0 = string.Empty;
					this.int_1 = 0;
				}
				switch (this.int_0)
				{
				case 0:
					this.class487_0.OnOffShortcut = this.string_1;
					break;
				case 1:
					this.class487_0.CleanCacheShortcut = this.string_1;
					break;
				case 2:
				{
					string[] array = this.string_1.Split(new char[]
					{
						'+'
					});
					if (!array.Any(new Func<string, bool>(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Class945.class945_0.method_0)))
					{
						if (array.Length == 2)
						{
							this.class494_0.Keys = this.string_1;
							break;
						}
					}
					this.class494_0.Keys = Class298.smethod_2("Only2Keys");
					return;
				}
				}
				this.grid_0.IsEnabled = true;
				this.bool_1 = false;
			}
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000CA750 File Offset: 0x000C8950
		private void button_12_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Exe Files (*.exe)|*.exe|All Files (*.*)|*.*",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
				Title = Class298.smethod_2("GMXChooseExe")
			};
			if (openFileDialog.ShowDialog().GetValueOrDefault())
			{
				string fileName = openFileDialog.FileName;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
				GClass181 gclass = new GClass181
				{
					Name = fileNameWithoutExtension,
					ExeName = fileNameWithoutExtension,
					ExeDir = fileName,
					IsAdded = true
				};
				Class657.smethod_3(gclass);
				this.itemsControl_3.Items.Add(gclass);
				Class657.smethod_2();
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000CA7EC File Offset: 0x000C89EC
		private void button_9_Click(object sender, RoutedEventArgs e)
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct688 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct688>(ref @struct);
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000CA824 File Offset: 0x000C8A24
		private void button_13_Click(object sender, RoutedEventArgs e)
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct687 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct687>(ref @struct);
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000CA85C File Offset: 0x000C8A5C
		private void method_5()
		{
			this.itemsControl_1.Items.Clear();
			IList items = this.itemsControl_1.Items;
			IEnumerable enumerable = this.class487_0.GMXStoredSettingsGamesVMs;
			Extensions.AddRange(items, ref enumerable);
			this.itemsControl_2.Items.Clear();
			IList items2 = this.itemsControl_2.Items;
			enumerable = this.class487_0.GMXStoredSettingsAppsVMs;
			Extensions.AddRange(items2, ref enumerable);
			if (this.class487_0.GMXStoredSettingsGamesVMs.Count == 0)
			{
				this.button_8.Visibility = Visibility.Collapsed;
				this.button_9.Visibility = Visibility.Visible;
			}
			else
			{
				this.button_8.Visibility = Visibility.Visible;
				this.button_9.Visibility = Visibility.Collapsed;
			}
			if (this.class487_0.GMXStoredSettingsAppsVMs.Count == 0)
			{
				this.button_10.Visibility = Visibility.Collapsed;
				this.button_11.Visibility = Visibility.Visible;
				return;
			}
			this.button_10.Visibility = Visibility.Visible;
			this.button_11.Visibility = Visibility.Collapsed;
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000CA94C File Offset: 0x000C8B4C
		private void dje_z9PYSWYMRKGMGGYRA4YYGGSSZE3LA_ejd(object sender, RoutedEventArgs e)
		{
			this.grid_5.IsEnabled = true;
			this.grid_5.DataContext = null;
			RadioButton radioButton = sender as RadioButton;
			if (radioButton != null)
			{
				Class499 @class = radioButton.DataContext as Class499;
				if (@class != null)
				{
					this.grid_5.DataContext = @class;
					this.itemsControl_0.ItemsSource = @class.list_0;
					this.itemsControl_0.Items.Refresh();
				}
			}
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000CA9B8 File Offset: 0x000C8BB8
		private void dje_zPQHDGQQAGZ5GB2WL43QG8Z7UDYXA_ejd(object sender, RoutedEventArgs e)
		{
			if ((base.DataContext as Class487).GMXStoredSettingsGamesVMs.All(new Func<Class499, bool>(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Class945.class945_0.method_1)))
			{
				this.grid_5.IsEnabled = false;
				this.grid_5.DataContext = null;
			}
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000CAA14 File Offset: 0x000C8C14
		private void button_7_Click(object sender, RoutedEventArgs e)
		{
			foreach (Class499 @class in (base.DataContext as Class487).GMXStoredSettingsGamesVMs)
			{
				@class.IsChecked = false;
			}
			this.grid_5.IsEnabled = false;
			Button button = sender as Button;
			if (button != null)
			{
				Class499 class2 = button.DataContext as Class499;
				if (class2 != null)
				{
					Class657.smethod_4(class2);
					this.method_5();
				}
			}
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000CAA9C File Offset: 0x000C8C9C
		private void button_11_Click(object sender, RoutedEventArgs e)
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct685 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct685>(ref @struct);
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000CAAD4 File Offset: 0x000C8CD4
		private void button_15_Click(object sender, RoutedEventArgs e)
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct684 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct684>(ref @struct);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000CAB0C File Offset: 0x000C8D0C
		private void button_14_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Exe Files (*.exe)|*.exe|All Files (*.*)|*.*",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
				Title = Class298.smethod_2("GMXChooseAppExe")
			};
			if (openFileDialog.ShowDialog().GetValueOrDefault())
			{
				string fileName = openFileDialog.FileName;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
				GClass167 gclass = new GClass167
				{
					Name = fileNameWithoutExtension,
					ExeName = Path.GetFileName(fileName),
					ExeDir = fileName,
					IsAdded = true
				};
				Class657.smethod_5(gclass);
				this.itemsControl_3.Items.Add(gclass);
				Class657.smethod_2();
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000CABAC File Offset: 0x000C8DAC
		private void button_5_Click(object sender, RoutedEventArgs e)
		{
			this.button_5.IsEnabled = false;
			Process[] processesByName = Process.GetProcessesByName("GameModeX");
			if (Class746.smethod_4<Process>(processesByName))
			{
				processesByName.First<Process>().Kill();
			}
			Class808.smethod_10(Path.Combine(Class551.class753_0.method_0(), "GameModeX.exe"));
			this.button_5.IsEnabled = true;
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x000CAC0C File Offset: 0x000C8E0C
		private void button_6_Click(object sender, RoutedEventArgs e)
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct683 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct683>(ref @struct);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x000CAC44 File Offset: 0x000C8E44
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct690 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct690>(ref @struct);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0002073E File Offset: 0x0001E93E
		private void textBox_3_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			if (!this.method_6(e.Text) && this.textBox_3.Text.Length >= 3)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000CAC7C File Offset: 0x000C8E7C
		private bool method_6(string string_3)
		{
			int num;
			return int.TryParse(string_3, out num);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x000CAC94 File Offset: 0x000C8E94
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/gamemodex.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_7(Type type_0, string string_3)
		{
			return Delegate.CreateDelegate(type_0, this, string_3);
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x000CACC8 File Offset: 0x000C8EC8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0 = (dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd)target;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				this.grid_0.PreviewKeyDown += this.grid_0_PreviewKeyDown;
				this.grid_0.PreviewKeyUp += this.grid_0_PreviewKeyUp;
				return;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 4:
				this.grid_1 = (Grid)target;
				return;
			case 5:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 6:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 7:
				this.progressBar_0 = (ProgressBar)target;
				return;
			case 8:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 9:
				this.textBox_0 = (TextBox)target;
				return;
			case 10:
				((Button)target).Click += this.method_3;
				return;
			case 11:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 12:
				this.grid_2 = (Grid)target;
				return;
			case 13:
				this.grid_3 = (Grid)target;
				return;
			case 14:
				this.grid_4 = (Grid)target;
				return;
			case 15:
				this.textBox_1 = (TextBox)target;
				return;
			case 16:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 17:
				this.textBox_2 = (TextBox)target;
				return;
			case 18:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 19:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			case 20:
				this.button_5 = (Button)target;
				this.button_5.Click += this.button_5_Click;
				return;
			case 21:
				this.button_6 = (Button)target;
				this.button_6.Click += this.button_6_Click;
				return;
			case 22:
				this.grid_5 = (Grid)target;
				return;
			case 23:
				this.button_7 = (Button)target;
				this.button_7.Click += this.button_7_Click;
				return;
			case 24:
				this.textBox_3 = (TextBox)target;
				this.textBox_3.PreviewTextInput += this.textBox_3_PreviewTextInput;
				return;
			case 25:
				this.stackPanel_2 = (StackPanel)target;
				return;
			case 26:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 27:
				this.grid_6 = (Grid)target;
				return;
			case 28:
				this.grid_7 = (Grid)target;
				return;
			case 29:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 30:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 31:
				this.button_8 = (Button)target;
				this.button_8.Click += this.button_9_Click;
				return;
			case 32:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			case 33:
				this.button_9 = (Button)target;
				this.button_9.Click += this.button_9_Click;
				return;
			case 34:
				this.button_10 = (Button)target;
				this.button_10.Click += this.button_11_Click;
				return;
			case 35:
				this.itemsControl_2 = (ItemsControl)target;
				return;
			case 36:
				this.button_11 = (Button)target;
				this.button_11.Click += this.button_11_Click;
				return;
			case 37:
				this.grid_8 = (Grid)target;
				return;
			case 38:
				this.itemsControl_3 = (ItemsControl)target;
				return;
			case 39:
				this.button_12 = (Button)target;
				this.button_12.Click += this.button_12_Click;
				return;
			case 40:
				this.stackPanel_3 = (StackPanel)target;
				return;
			case 41:
				this.button_13 = (Button)target;
				this.button_13.Click += this.button_13_Click;
				return;
			case 42:
				this.grid_9 = (Grid)target;
				return;
			case 43:
				this.itemsControl_4 = (ItemsControl)target;
				return;
			case 44:
				this.button_14 = (Button)target;
				this.button_14.Click += this.button_14_Click;
				return;
			case 45:
				this.stackPanel_4 = (StackPanel)target;
				return;
			case 46:
				this.button_15 = (Button)target;
				this.button_15.Click += this.button_15_Click;
				return;
			default:
				this.bool_2 = true;
				return;
			}
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000CB1B4 File Offset: 0x000C93B4
		private void method_8()
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				Duration = TimeSpan.FromSeconds(2.0),
				To = new double?((double)100f),
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5
			};
			Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
			this.progressBar_0.BeginAnimation(RangeBase.ValueProperty, doubleAnimation);
		}

		// Token: 0x04002516 RID: 9494
		private Class487 class487_0;

		// Token: 0x04002517 RID: 9495
		private bool bool_0;

		// Token: 0x04002518 RID: 9496
		public bool bool_1;

		// Token: 0x04002519 RID: 9497
		public int int_0;

		// Token: 0x0400251A RID: 9498
		private int int_1;

		// Token: 0x0400251B RID: 9499
		private string string_0 = string.Empty;

		// Token: 0x0400251C RID: 9500
		private string string_1 = string.Empty;

		// Token: 0x0400251D RID: 9501
		private string string_2 = string.Empty;

		// Token: 0x0400251E RID: 9502
		internal Class494 class494_0;

		// Token: 0x0400251F RID: 9503
		internal dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

		// Token: 0x04002520 RID: 9504
		internal Grid grid_0;

		// Token: 0x04002521 RID: 9505
		internal Button button_0;

		// Token: 0x04002522 RID: 9506
		internal Grid grid_1;

		// Token: 0x04002523 RID: 9507
		internal StackPanel stackPanel_0;

		// Token: 0x04002524 RID: 9508
		internal TextBlock textBlock_0;

		// Token: 0x04002525 RID: 9509
		internal ProgressBar progressBar_0;

		// Token: 0x04002526 RID: 9510
		internal StackPanel stackPanel_1;

		// Token: 0x04002527 RID: 9511
		internal TextBox textBox_0;

		// Token: 0x04002528 RID: 9512
		internal Button button_1;

		// Token: 0x04002529 RID: 9513
		internal Grid grid_2;

		// Token: 0x0400252A RID: 9514
		internal Grid grid_3;

		// Token: 0x0400252B RID: 9515
		internal Grid grid_4;

		// Token: 0x0400252C RID: 9516
		internal TextBox textBox_1;

		// Token: 0x0400252D RID: 9517
		internal Button button_2;

		// Token: 0x0400252E RID: 9518
		internal TextBox textBox_2;

		// Token: 0x0400252F RID: 9519
		internal Button button_3;

		// Token: 0x04002530 RID: 9520
		internal Button button_4;

		// Token: 0x04002531 RID: 9521
		internal Button button_5;

		// Token: 0x04002532 RID: 9522
		internal Button button_6;

		// Token: 0x04002533 RID: 9523
		internal Grid grid_5;

		// Token: 0x04002534 RID: 9524
		internal Button button_7;

		// Token: 0x04002535 RID: 9525
		internal TextBox textBox_3;

		// Token: 0x04002536 RID: 9526
		internal StackPanel stackPanel_2;

		// Token: 0x04002537 RID: 9527
		internal TextBlock textBlock_1;

		// Token: 0x04002538 RID: 9528
		internal Grid grid_6;

		// Token: 0x04002539 RID: 9529
		internal Grid grid_7;

		// Token: 0x0400253A RID: 9530
		internal ItemsControl itemsControl_0;

		// Token: 0x0400253B RID: 9531
		internal ScrollViewer scrollViewer_0;

		// Token: 0x0400253C RID: 9532
		internal Button button_8;

		// Token: 0x0400253D RID: 9533
		internal ItemsControl itemsControl_1;

		// Token: 0x0400253E RID: 9534
		internal Button button_9;

		// Token: 0x0400253F RID: 9535
		internal Button button_10;

		// Token: 0x04002540 RID: 9536
		internal ItemsControl itemsControl_2;

		// Token: 0x04002541 RID: 9537
		internal Button button_11;

		// Token: 0x04002542 RID: 9538
		internal Grid grid_8;

		// Token: 0x04002543 RID: 9539
		internal ItemsControl itemsControl_3;

		// Token: 0x04002544 RID: 9540
		internal Button button_12;

		// Token: 0x04002545 RID: 9541
		internal StackPanel stackPanel_3;

		// Token: 0x04002546 RID: 9542
		internal Button button_13;

		// Token: 0x04002547 RID: 9543
		internal Grid grid_9;

		// Token: 0x04002548 RID: 9544
		internal ItemsControl itemsControl_4;

		// Token: 0x04002549 RID: 9545
		internal Button button_14;

		// Token: 0x0400254A RID: 9546
		internal StackPanel stackPanel_4;

		// Token: 0x0400254B RID: 9547
		internal Button button_15;

		// Token: 0x0400254C RID: 9548
		private bool bool_2;

		// Token: 0x02000892 RID: 2194
		[StructLayout(LayoutKind.Auto)]
		private struct Struct681 : IAsyncStateMachine
		{
			// Token: 0x06003400 RID: 13312 RVA: 0x000CB22C File Offset: 0x000C942C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_4F;
					}
					IL_2F:
					if (Class781.bool_1)
					{
						dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.DataContext = (dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.class487_0 = new Class487(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd));
						if (!Class781.bool_0)
						{
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_6.Visibility = Visibility.Collapsed;
						}
						if (Class781.int_3 == 0)
						{
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_7.Visibility = Visibility.Collapsed;
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.stackPanel_2.Visibility = Visibility.Collapsed;
						}
						else
						{
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBlock_1.Text = Class298.smethod_2("CompatibilityWith") + Class781.string_0;
						}
						Class657.smethod_0(new Class657.Delegate31(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.method_5));
						Class657.smethod_2();
						goto IL_112;
					}
					awaiter = Task.Delay(20).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct681>(ref awaiter, ref this);
						return;
					}
					IL_4F:
					awaiter.GetResult();
					goto IL_2F;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_112:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003401 RID: 13313 RVA: 0x00020768 File Offset: 0x0001E968
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400254D RID: 9549
			public int int_0;

			// Token: 0x0400254E RID: 9550
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400254F RID: 9551
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002550 RID: 9552
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000893 RID: 2195
		[StructLayout(LayoutKind.Auto)]
		private struct Struct682 : IAsyncStateMachine
		{
			// Token: 0x06003402 RID: 13314 RVA: 0x000CB370 File Offset: 0x000C9570
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_1.Visibility = Visibility.Collapsed;
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_1.Opacity = 0.0;
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2.Visibility = Visibility.Collapsed;
							dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2.Opacity = 0.0;
							if (!Class551.class753_0.method_0().smethod_9() && Class551.class753_0.method_0() != "NotInstalled")
							{
								if (Process.GetProcessesByName("GameModeX").Length != 0)
								{
									dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_5.Content = Class298.smethod_2("Restart");
								}
								dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2);
								awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2, 100).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 0;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct682>(ref awaiter, ref this);
									return;
								}
								goto IL_19D;
							}
							else
							{
								dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_1);
								awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_1, 100).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 1;
									this.taskAwaiter_0 = awaiter;
									this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct682>(ref awaiter, ref this);
									return;
								}
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
						}
						awaiter.GetResult();
						dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBox_0.Text = Path.Combine(Class169.string_2, "GameModeX");
						goto IL_1A4;
					}
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_19D:
					awaiter.GetResult();
					IL_1A4:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003403 RID: 13315 RVA: 0x00020776 File Offset: 0x0001E976
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002551 RID: 9553
			public int int_0;

			// Token: 0x04002552 RID: 9554
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002553 RID: 9555
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002554 RID: 9556
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000894 RID: 2196
		[StructLayout(LayoutKind.Auto)]
		private struct Struct683 : IAsyncStateMachine
		{
			// Token: 0x06003404 RID: 13316 RVA: 0x000CB56C File Offset: 0x000C976C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_207;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_269;
					default:
					{
						dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_6.Content = Class298.smethod_2("Deleting");
						dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_6.IsEnabled = false;
						Process[] processesByName = Process.GetProcessesByName("GameModeX");
						if (Class746.smethod_4<Process>(processesByName))
						{
							processesByName.First<Process>().Kill();
						}
						awaiter = Task.Delay(500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct683>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					string path = Path.Combine(Class551.class753_0.method_0(), "GameModeX.exe");
					if (File.Exists(path))
					{
						File.Delete(path);
					}
					Class551.class753_0.method_1("NotInstalled");
					string path2 = Path.Combine(new string[]
					{
						GClass267.smethod_2(),
						"Microsoft",
						"Windows",
						"Start Menu",
						"Programs",
						"Startup",
						"GameModeX.lnk"
					});
					if (File.Exists(path2))
					{
						File.Delete(path2);
					}
					Class808.smethod_27("reg delete \"HKCU\\SOFTWARE\\GameModeX\" /f");
					Class808.smethod_27("reg delete \"HKCU\\SOFTWARE\\BoosterX\" /v \"GMXInstallLocation\" /f");
					Class808.smethod_27("schtasks /Delete /TN \"GameModeX\" /F");
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_6.Content = Class298.smethod_2("Delete");
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_6.IsEnabled = true;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBlock_0, Class298.smethod_2("InstallLocation"), null);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.stackPanel_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct683>(ref awaiter, ref this);
						return;
					}
					IL_207:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.stackPanel_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct683>(ref awaiter, ref this);
						return;
					}
					IL_269:
					awaiter.GetResult();
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.bool_0 = false;
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_1.IsEnabled = true;
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_1.Content = Class298.smethod_2("install");
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.progressBar_0.Value = 0.0;
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.DataContext = (dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.class487_0 = new Class487(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd));
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.method_1();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003405 RID: 13317 RVA: 0x00020784 File Offset: 0x0001E984
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002555 RID: 9557
			public int int_0;

			// Token: 0x04002556 RID: 9558
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002557 RID: 9559
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002558 RID: 9560
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000895 RID: 2197
		[StructLayout(LayoutKind.Auto)]
		private struct Struct684 : IAsyncStateMachine
		{
			// Token: 0x06003406 RID: 13318 RVA: 0x000CB890 File Offset: 0x000C9A90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_E7;
						}
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_9, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct684>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_9);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct684>(ref awaiter, ref this);
						return;
					}
					IL_E7:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003407 RID: 13319 RVA: 0x00020792 File Offset: 0x0001E992
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002559 RID: 9561
			public int int_0;

			// Token: 0x0400255A RID: 9562
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400255B RID: 9563
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x0400255C RID: 9564
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000896 RID: 2198
		[StructLayout(LayoutKind.Auto)]
		private struct Struct685 : IAsyncStateMachine
		{
			// Token: 0x06003408 RID: 13320 RVA: 0x000CB9C8 File Offset: 0x000C9BC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_E7;
						}
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct685>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_9);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_9, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct685>(ref awaiter, ref this);
						return;
					}
					IL_E7:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003409 RID: 13321 RVA: 0x000207A0 File Offset: 0x0001E9A0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400255D RID: 9565
			public int int_0;

			// Token: 0x0400255E RID: 9566
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400255F RID: 9567
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002560 RID: 9568
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000897 RID: 2199
		[StructLayout(LayoutKind.Auto)]
		private struct Struct686 : IAsyncStateMachine
		{
			// Token: 0x0600340A RID: 13322 RVA: 0x000CBB00 File Offset: 0x000C9D00
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_143;
					}
					case 2:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
						goto IL_2D7;
					}
					case 3:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
						goto IL_35C;
					}
					case 4:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						this.int_0 = num6;
						goto IL_38B;
					}
					case 5:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num7 = -1;
						num = -1;
						this.int_0 = num7;
						goto IL_400;
					}
					default:
						if (!dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.bool_0)
						{
							dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_14(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_1, 100);
							awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.stackPanel_1, 100).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num8 = 0;
								num = 0;
								this.int_0 = num8;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_1, 100).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num9 = 4;
								num = 4;
								this.int_0 = num9;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686>(ref awaiter, ref this);
								return;
							}
							goto IL_38B;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.stackPanel_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num10 = 1;
						num = 1;
						this.int_0 = num10;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686>(ref awaiter, ref this);
						return;
					}
					IL_143:
					awaiter.GetResult();
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.method_2();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBlock_0, Class298.smethod_2("Installing"), null);
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_1.IsEnabled = false;
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_1.Content = Class298.smethod_2("continue");
					if (!Directory.Exists(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBox_0.Text))
					{
						Directory.CreateDirectory(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBox_0.Text);
					}
					Class551.class753_0.method_1(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBox_0.Text);
					Class765.smethod_4("BoosterX", dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBox_0.Text, "Resources.EmbedRes.Exes", "GameModeX.exe", false);
					string text = Path.Combine(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBox_0.Text, "GameModeX.exe");
					TaskService taskService = new TaskService();
					try
					{
						string text2 = "GameModeX";
						TaskDefinition taskDefinition = taskService.NewTask();
						taskDefinition.RegistrationInfo.Description = "Runs GameModeX at system start.";
						taskDefinition.Principal.RunLevel = 1;
						taskDefinition.Triggers.Add<LogonTrigger>(new LogonTrigger());
						taskDefinition.Actions.Add<ExecAction>(new ExecAction(text, null, null));
						taskService.RootFolder.RegisterTaskDefinition(text2, taskDefinition);
					}
					finally
					{
						if (num < 0 && taskService != null)
						{
							taskService.Dispose();
						}
					}
					Class808.smethod_10(text);
					awaiter = Task.Delay(1500).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num11 = 2;
						num = 2;
						this.int_0 = num11;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686>(ref awaiter, ref this);
						return;
					}
					IL_2D7:
					awaiter.GetResult();
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_1.IsEnabled = true;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.textBlock_0, Class298.smethod_2("Installed"), null);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.button_1, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num12 = 3;
						num = 3;
						this.int_0 = num12;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686>(ref awaiter, ref this);
						return;
					}
					IL_35C:
					awaiter.GetResult();
					dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.bool_0 = true;
					goto IL_407;
					IL_38B:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_1);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 5;
						num = 5;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct686>(ref awaiter, ref this);
						return;
					}
					IL_400:
					awaiter.GetResult();
					IL_407:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600340B RID: 13323 RVA: 0x000207AE File Offset: 0x0001E9AE
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002561 RID: 9569
			public int int_0;

			// Token: 0x04002562 RID: 9570
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002563 RID: 9571
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002564 RID: 9572
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000898 RID: 2200
		[StructLayout(LayoutKind.Auto)]
		private struct Struct687 : IAsyncStateMachine
		{
			// Token: 0x0600340C RID: 13324 RVA: 0x000CBF78 File Offset: 0x000CA178
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_E7;
						}
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_8, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct687>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_8);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct687>(ref awaiter, ref this);
						return;
					}
					IL_E7:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600340D RID: 13325 RVA: 0x000207BC File Offset: 0x0001E9BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002565 RID: 9573
			public int int_0;

			// Token: 0x04002566 RID: 9574
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002567 RID: 9575
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002568 RID: 9576
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000899 RID: 2201
		[StructLayout(LayoutKind.Auto)]
		private struct Struct688 : IAsyncStateMachine
		{
			// Token: 0x0600340E RID: 13326 RVA: 0x000CC0B0 File Offset: 0x000CA2B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_E7;
						}
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct688>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_8);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_8, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct688>(ref awaiter, ref this);
						return;
					}
					IL_E7:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600340F RID: 13327 RVA: 0x000207CA File Offset: 0x0001E9CA
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002569 RID: 9577
			public int int_0;

			// Token: 0x0400256A RID: 9578
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400256B RID: 9579
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x0400256C RID: 9580
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200089A RID: 2202
		[StructLayout(LayoutKind.Auto)]
		private struct Struct689 : IAsyncStateMachine
		{
			// Token: 0x06003410 RID: 13328 RVA: 0x000CC1E8 File Offset: 0x000CA3E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd @object = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@object.method_8)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct689>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003411 RID: 13329 RVA: 0x000207D8 File Offset: 0x0001E9D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400256D RID: 9581
			public int int_0;

			// Token: 0x0400256E RID: 9582
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400256F RID: 9583
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002570 RID: 9584
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200089B RID: 2203
		[StructLayout(LayoutKind.Auto)]
		private struct Struct690 : IAsyncStateMachine
		{
			// Token: 0x06003412 RID: 13330 RVA: 0x000CC2B0 File Offset: 0x000CA4B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd = this.dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_125;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_19A;
					default:
						if (dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_8.Visibility != Visibility.Visible && dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_9.Visibility != Visibility.Visible)
						{
							Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
							goto IL_1BA;
						}
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_8, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct690>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_8);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_9, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct690>(ref awaiter, ref this);
						return;
					}
					IL_125:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_9);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Struct690>(ref awaiter, ref this);
						return;
					}
					IL_19A:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1BA:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003413 RID: 13331 RVA: 0x000207E6 File Offset: 0x0001E9E6
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002571 RID: 9585
			public int int_0;

			// Token: 0x04002572 RID: 9586
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002573 RID: 9587
			public dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd_0;

			// Token: 0x04002574 RID: 9588
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200089C RID: 2204
		[Serializable]
		private sealed class Class945
		{
			// Token: 0x06003416 RID: 13334 RVA: 0x00020800 File Offset: 0x0001EA00
			internal bool method_0(string string_0)
			{
				return string.IsNullOrWhiteSpace(string_0);
			}

			// Token: 0x06003417 RID: 13335 RVA: 0x00020808 File Offset: 0x0001EA08
			internal bool method_1(Class499 class499_0)
			{
				return !class499_0.IsChecked;
			}

			// Token: 0x04002575 RID: 9589
			public static readonly dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Class945 class945_0 = new dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd.Class945();

			// Token: 0x04002576 RID: 9590
			public static Func<string, bool> func_0;

			// Token: 0x04002577 RID: 9591
			public static Func<Class499, bool> func_1;
		}
	}
}
