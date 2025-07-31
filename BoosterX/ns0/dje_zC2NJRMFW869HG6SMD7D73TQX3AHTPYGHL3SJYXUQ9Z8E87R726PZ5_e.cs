using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x020007B1 RID: 1969
	public sealed class dje_zC2NJRMFW869HG6SMD7D73TQX3AHTPYGHL3SJYXUQ9Z8E87R726PZ5_ejd : Page, IComponentConnector
	{
		// Token: 0x06002FF8 RID: 12280 RVA: 0x0001E85D File Offset: 0x0001CA5D
		public dje_zC2NJRMFW869HG6SMD7D73TQX3AHTPYGHL3SJYXUQ9Z8E87R726PZ5_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x0001E86B File Offset: 0x0001CA6B
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Dispatcher.Invoke(new Action(dje_zC2NJRMFW869HG6SMD7D73TQX3AHTPYGHL3SJYXUQ9Z8E87R726PZ5_ejd.Class905.class905_0.method_0));
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x000B89F0 File Offset: 0x000B6BF0
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "All files (*.*)|*.*",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
				Title = Class298.smethod_2("ChooseFile")
			};
			if (openFileDialog.ShowDialog().GetValueOrDefault())
			{
				Class196.smethod_0(openFileDialog.FileName);
			}
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x0001E89B File Offset: 0x0001CA9B
		private void method_0(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				Class196.smethod_0(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
			}
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x0001E8CB File Offset: 0x0001CACB
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == Class298.smethod_2("TrustedCmdText"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0001E8FA File Offset: 0x0001CAFA
		private void textBox_0_LostFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text.smethod_9())
			{
				this.textBox_0.Text = Class298.smethod_2("TrustedCmdText");
			}
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0001E924 File Offset: 0x0001CB24
		private void textBox_0_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Return && !this.textBox_0.Text.smethod_9())
			{
				Class196.smethod_0(this.textBox_0.Text);
			}
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0001E951 File Offset: 0x0001CB51
		private void method_1(object sender, RoutedEventArgs e)
		{
			if (!this.textBox_0.Text.smethod_9())
			{
				Class196.smethod_0(this.textBox_0.Text);
			}
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x000B8A48 File Offset: 0x000B6C48
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/godmodepage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x000B8A7C File Offset: 0x000B6C7C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				((Grid)target).Drop += this.method_0;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 5:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				return;
			case 6:
				((Button)target).Click += this.method_1;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040020A0 RID: 8352
		internal Button button_0;

		// Token: 0x040020A1 RID: 8353
		internal Border border_0;

		// Token: 0x040020A2 RID: 8354
		internal Button button_1;

		// Token: 0x040020A3 RID: 8355
		internal TextBox textBox_0;

		// Token: 0x040020A4 RID: 8356
		private bool bool_0;

		// Token: 0x020007B2 RID: 1970
		[Serializable]
		private sealed class Class905
		{
			// Token: 0x06003004 RID: 12292 RVA: 0x00007C85 File Offset: 0x00005E85
			internal void method_0()
			{
				Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
			}

			// Token: 0x040020A5 RID: 8357
			public static readonly dje_zC2NJRMFW869HG6SMD7D73TQX3AHTPYGHL3SJYXUQ9Z8E87R726PZ5_ejd.Class905 class905_0 = new dje_zC2NJRMFW869HG6SMD7D73TQX3AHTPYGHL3SJYXUQ9Z8E87R726PZ5_ejd.Class905();

			// Token: 0x040020A6 RID: 8358
			public static Action action_0;
		}
	}
}
