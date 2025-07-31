using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200074E RID: 1870
	public sealed class dje_z7GQ8CY5Z2XS4Y64HBD4P8B5PHSDDDFUF6BZCQG89LBTBJZUD4P5V5B2PR8ESF49VB2_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002E7A RID: 11898 RVA: 0x0001DC31 File Offset: 0x0001BE31
		public dje_z7GQ8CY5Z2XS4Y64HBD4P8B5PHSDDDFUF6BZCQG89LBTBJZUD4P5V5B2PR8ESF49VB2_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x0001D04F File Offset: 0x0001B24F
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null)
			{
				return;
			}
			textBox.SelectAll();
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x0001DC3F File Offset: 0x0001BE3F
		private void textBox_0_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			if (sender is TextBox && !Class765.smethod_0(e.Text))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000B2154 File Offset: 0x000B0354
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/usercontrols/backupsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000B2188 File Offset: 0x000B0388
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.PreviewTextInput += this.textBox_0_PreviewTextInput;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.button_0 = (Button)target;
		}

		// Token: 0x04001EE1 RID: 7905
		internal TextBox textBox_0;

		// Token: 0x04001EE2 RID: 7906
		internal Button button_0;

		// Token: 0x04001EE3 RID: 7907
		private bool bool_0;
	}
}
