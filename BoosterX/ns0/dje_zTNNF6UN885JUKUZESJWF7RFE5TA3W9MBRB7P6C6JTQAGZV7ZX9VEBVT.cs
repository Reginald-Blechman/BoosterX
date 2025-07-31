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
	// Token: 0x02000883 RID: 2179
	public sealed class dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060033B6 RID: 13238 RVA: 0x000205D1 File Offset: 0x0001E7D1
		public dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x0001D04F File Offset: 0x0001B24F
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox == null)
			{
				return;
			}
			textBox.SelectAll();
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x000ABFE0 File Offset: 0x000AA1E0
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

		// Token: 0x060033B9 RID: 13241 RVA: 0x000C979C File Offset: 0x000C799C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/usercontrols/iltestuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x000C97D0 File Offset: 0x000C79D0
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
				this.grid_0 = (Grid)target;
				return;
			case 4:
				this.grid_1 = (Grid)target;
				return;
			case 5:
				this.grid_2 = (Grid)target;
				return;
			case 6:
				this.grid_3 = (Grid)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040024DB RID: 9435
		internal TextBox textBox_0;

		// Token: 0x040024DC RID: 9436
		internal Button button_0;

		// Token: 0x040024DD RID: 9437
		internal Grid grid_0;

		// Token: 0x040024DE RID: 9438
		internal Grid grid_1;

		// Token: 0x040024DF RID: 9439
		internal Grid grid_2;

		// Token: 0x040024E0 RID: 9440
		internal Grid grid_3;

		// Token: 0x040024E1 RID: 9441
		private bool bool_0;
	}
}
