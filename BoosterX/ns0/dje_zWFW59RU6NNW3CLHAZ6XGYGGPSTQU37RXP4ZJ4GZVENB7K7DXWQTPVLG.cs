using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008B3 RID: 2227
	public sealed class dje_zWFW59RU6NNW3CLHAZ6XGYGGPSTQU37RXP4ZJ4GZVENB7K7DXWQTPVLGU7NTPYHS48A_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003487 RID: 13447 RVA: 0x00020C92 File Offset: 0x0001EE92
		public dje_zWFW59RU6NNW3CLHAZ6XGYGGPSTQU37RXP4ZJ4GZVENB7K7DXWQTPVLGU7NTPYHS48A_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == Class298.smethod_2("EnterOwnValue"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00020CCF File Offset: 0x0001EECF
		private void textBox_0_LostFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = Class298.smethod_2("EnterOwnValue");
			}
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x000CDF68 File Offset: 0x000CC168
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			((GClass190)Class406.smethod_0().list_2.Find(new Predicate<Page>(dje_zWFW59RU6NNW3CLHAZ6XGYGGPSTQU37RXP4ZJ4GZVENB7K7DXWQTPVLGU7NTPYHS48A_ejd.Class950.class950_0.method_0)).DataContext).SelectedProfile.Autoexec.method_3(new GClass137(this.checkBox_0.Content.ToString(), this.textBox_0.Text));
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.textBlock_0, Class298.smethod_2("added"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x000CDFF8 File Offset: 0x000CC1F8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgosettingscommandsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000CE02C File Offset: 0x000CC22C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 3:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				return;
			case 4:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040025FD RID: 9725
		internal CheckBox checkBox_0;

		// Token: 0x040025FE RID: 9726
		internal TextBlock textBlock_0;

		// Token: 0x040025FF RID: 9727
		internal TextBox textBox_0;

		// Token: 0x04002600 RID: 9728
		internal Button button_0;

		// Token: 0x04002601 RID: 9729
		private bool bool_0;

		// Token: 0x020008B4 RID: 2228
		[Serializable]
		private sealed class Class950
		{
			// Token: 0x0600348F RID: 13455 RVA: 0x00020D0A File Offset: 0x0001EF0A
			internal bool method_0(Page page_0)
			{
				return page_0.GetType() == typeof(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd);
			}

			// Token: 0x04002602 RID: 9730
			public static readonly dje_zWFW59RU6NNW3CLHAZ6XGYGGPSTQU37RXP4ZJ4GZVENB7K7DXWQTPVLGU7NTPYHS48A_ejd.Class950 class950_0 = new dje_zWFW59RU6NNW3CLHAZ6XGYGGPSTQU37RXP4ZJ4GZVENB7K7DXWQTPVLGU7NTPYHS48A_ejd.Class950();

			// Token: 0x04002603 RID: 9731
			public static Predicate<Page> predicate_0;
		}
	}
}
