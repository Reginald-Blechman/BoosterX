using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using LiveChartsCore.SkiaSharpView.WPF;

namespace ns0
{
	// Token: 0x0200070F RID: 1807
	public sealed class dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002D15 RID: 11541 RVA: 0x0001D03B File Offset: 0x0001B23B
		public dje_z2JEDD4ZHM49WVF4K249YHVGWWAMG45W5UFFU4QNSHQ3JDVHD5GL7A54H3P9Q_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000ABF9C File Offset: 0x000AA19C
		private void method_0()
		{
			if (Class551.class753_0.method_64().GetValueOrDefault())
			{
				this.checkBox_0.IsChecked = new bool?(true);
				return;
			}
			this.checkBox_0.IsChecked = new bool?(false);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0001D04F File Offset: 0x0001B24F
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null)
			{
				return;
			}
			textBox.SelectAll();
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000ABFE0 File Offset: 0x000AA1E0
		private void textBox_0_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null && textBox.Text.Length < 20)
			{
				return;
			}
			if (!Class765.smethod_0(e.Text))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x0001D061 File Offset: 0x0001B261
		private void checkBox_0_Checked(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_65(new bool?(true));
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x0001D073 File Offset: 0x0001B273
		private void checkBox_0_Unchecked(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_65(new bool?(false));
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x0000311B File Offset: 0x0000131B
		private void method_1(object sender, MouseButtonEventArgs e)
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000AC01C File Offset: 0x000AA21C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/internettest/usercontrols/internettestuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_2(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000AC050 File Offset: 0x000AA250
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.PreviewTextInput += this.textBox_0_PreviewTextInput;
				return;
			case 2:
				this.button_0 = (Button)target;
				return;
			case 3:
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			case 4:
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			case 5:
				this.grid_0 = (Grid)target;
				return;
			case 6:
				this.grid_1 = (Grid)target;
				return;
			case 7:
				this.dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQBRKD79BLREV3XRP3MB6V9MPXHVLGS44QKTA_ejd_0 = (dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQBRKD79BLREV3XRP3MB6V9MPXHVLGS44QKTA_ejd)target;
				return;
			case 8:
				this.button_1 = (Button)target;
				return;
			case 9:
				this.button_2 = (Button)target;
				return;
			case 10:
				this.grid_2 = (Grid)target;
				return;
			case 11:
				this.button_3 = (Button)target;
				return;
			case 12:
				this.checkBox_0 = (CheckBox)target;
				this.checkBox_0.Checked += this.checkBox_0_Checked;
				this.checkBox_0.Unchecked += this.checkBox_0_Unchecked;
				return;
			case 13:
				this.cartesianChart_0 = (CartesianChart)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001D63 RID: 7523
		internal TextBox textBox_0;

		// Token: 0x04001D64 RID: 7524
		internal Button button_0;

		// Token: 0x04001D65 RID: 7525
		internal Grid grid_0;

		// Token: 0x04001D66 RID: 7526
		internal Grid grid_1;

		// Token: 0x04001D67 RID: 7527
		internal dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQBRKD79BLREV3XRP3MB6V9MPXHVLGS44QKTA_ejd dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQBRKD79BLREV3XRP3MB6V9MPXHVLGS44QKTA_ejd_0;

		// Token: 0x04001D68 RID: 7528
		internal Button button_1;

		// Token: 0x04001D69 RID: 7529
		internal Button button_2;

		// Token: 0x04001D6A RID: 7530
		internal Grid grid_2;

		// Token: 0x04001D6B RID: 7531
		internal Button button_3;

		// Token: 0x04001D6C RID: 7532
		internal CheckBox checkBox_0;

		// Token: 0x04001D6D RID: 7533
		internal CartesianChart cartesianChart_0;

		// Token: 0x04001D6E RID: 7534
		private bool bool_0;
	}
}
