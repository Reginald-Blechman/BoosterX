using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008F7 RID: 2295
	public sealed class dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd : Page, IComponentConnector
	{
		// Token: 0x060035C5 RID: 13765 RVA: 0x00021647 File Offset: 0x0001F847
		public dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x000D1E10 File Offset: 0x000D0010
		private void method_0()
		{
			base.DataContext = (this.gclass182_0 = Class221.smethod_0(false));
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0002165B File Offset: 0x0001F85B
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			this.textBox_0.Text = string.Empty;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x0002166D File Offset: 0x0001F86D
		private void textBox_0_LostFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = (Application.Current.FindResource("SearchGameForSetup") as string);
			}
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x000B1DD8 File Offset: 0x000AFFD8
		private void textBox_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				textBox.SelectAll();
			}
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x000D1E34 File Offset: 0x000D0034
		private void textBox_0_TextChanged(object sender, TextChangedEventArgs e)
		{
			dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd.Class961 @class = new dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd.Class961();
			@class.dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd_0 = this;
			if (this.gclass182_0 == null)
			{
				return;
			}
			if (!(this.textBox_0.Text == Class298.smethod_2("SearchGameForSetup")) && !(this.textBox_0.Text == string.Empty) && this.textBox_0.Text.Length >= 3)
			{
				@class.string_0 = this.textBox_0.Text;
				if (!this.comboBox_0.IsDropDownOpen)
				{
					this.comboBox_0.IsDropDownOpen = true;
				}
				this.comboBox_0.ItemsSource = ((!string.IsNullOrEmpty(@class.string_0)) ? new ObservableCollection<GClass32>(this.gclass182_0.Profiles.Where(new Func<GClass32, bool>(@class.method_0))) : this.gclass182_0.Profiles);
				return;
			}
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x0000311B File Offset: 0x0000131B
		private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000D1F18 File Offset: 0x000D0118
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/nvidiapage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_1(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x000D1F4C File Offset: 0x000D014C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				return;
			case 2:
				this.button_1 = (Button)target;
				return;
			case 3:
				this.button_2 = (Button)target;
				return;
			case 4:
				this.button_3 = (Button)target;
				return;
			case 5:
				this.button_4 = (Button)target;
				return;
			case 6:
				this.comboBox_0 = (ComboBox)target;
				this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
				return;
			case 7:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseLeftButtonUp += this.textBox_0_MouseLeftButtonUp;
				this.textBox_0.TextChanged += this.textBox_0_TextChanged;
				return;
			case 8:
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002747 RID: 10055
		public GClass182 gclass182_0;

		// Token: 0x04002748 RID: 10056
		internal Button button_0;

		// Token: 0x04002749 RID: 10057
		internal Button button_1;

		// Token: 0x0400274A RID: 10058
		internal Button button_2;

		// Token: 0x0400274B RID: 10059
		internal Button button_3;

		// Token: 0x0400274C RID: 10060
		internal Button button_4;

		// Token: 0x0400274D RID: 10061
		internal ComboBox comboBox_0;

		// Token: 0x0400274E RID: 10062
		internal TextBox textBox_0;

		// Token: 0x0400274F RID: 10063
		internal CheckBox checkBox_0;

		// Token: 0x04002750 RID: 10064
		private bool bool_0;

		// Token: 0x020008F8 RID: 2296
		private sealed class Class961
		{
			// Token: 0x060035D0 RID: 13776 RVA: 0x000216A6 File Offset: 0x0001F8A6
			internal bool method_0(GClass32 gclass32_0)
			{
				return gclass32_0.ProfileName.smethod_3(this.string_0) || gclass32_0 == this.dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd_0.gclass182_0.BaseProfile;
			}

			// Token: 0x04002751 RID: 10065
			public string string_0;

			// Token: 0x04002752 RID: 10066
			public dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd_0;
		}
	}
}
