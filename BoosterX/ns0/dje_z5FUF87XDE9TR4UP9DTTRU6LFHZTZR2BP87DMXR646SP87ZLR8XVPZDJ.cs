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
	// Token: 0x02000745 RID: 1861
	public sealed class dje_z5FUF87XDE9TR4UP9DTTRU6LFHZTZR2BP87DMXR646SP87ZLR8XVPZDJGFBLXEUVXE5N444A6_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002E54 RID: 11860 RVA: 0x0001DA58 File Offset: 0x0001BC58
		public dje_z5FUF87XDE9TR4UP9DTTRU6LFHZTZR2BP87DMXR646SP87ZLR8XVPZDJGFBLXEUVXE5N444A6_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000B1C24 File Offset: 0x000AFE24
		private void method_0(object sender, MouseButtonEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && !textBox.IsKeyboardFocusWithin)
			{
				e.Handled = true;
				textBox.Focus();
				textBox.SelectAll();
			}
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000B1C58 File Offset: 0x000AFE58
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/maintweakucs/maintweakvaluesuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000B1C8C File Offset: 0x000AFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((TextBox)target).PreviewMouseDown += this.method_0;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			((TextBox)target).PreviewMouseDown += this.method_0;
		}

		// Token: 0x04001EC7 RID: 7879
		private bool bool_0;
	}
}
