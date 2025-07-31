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
	// Token: 0x02000882 RID: 2178
	public sealed class dje_zSPXA4U6TGH4EZLZWYBNZPUGYYH3MKEQHQH67V3XKHRQQWCNCZ3VY3S6DGVGGQKSQHSCA2JLT2PLZCZA_ejd : UserControl, IComponentConnector, IStyleConnector
	{
		// Token: 0x060033AF RID: 13231 RVA: 0x00020588 File Offset: 0x0001E788
		public dje_zSPXA4U6TGH4EZLZWYBNZPUGYYH3MKEQHQH67V3XKHRQQWCNCZ3VY3S6DGVGGQKSQHSCA2JLT2PLZCZA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000C9568 File Offset: 0x000C7768
		private void method_0(object sender, RoutedEventArgs e)
		{
			Class659 @class = (Class659)base.DataContext;
			if (!@class.bool_0)
			{
				return;
			}
			Class245 class245_ = @class.class245_0;
			if (class245_.String_0 == "REG" || class245_.String_0 == "REG_SZ" || class245_.String_0 == "REG_BINARY" || class245_.String_0 == "REG_EXPAND_SZ")
			{
				Class808.smethod_27("taskkill /F /IM regedit.exe");
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", class245_.String_1);
				Class808.smethod_30("regedit");
				return;
			}
			if (class245_.String_0 == "BAT")
			{
				Class808.smethod_30("cmd");
				return;
			}
			if (class245_.String_0 == "TASK")
			{
				Class808.smethod_30("control schedtasks");
				return;
			}
			if (class245_.String_0 == "DEVICE")
			{
				Class808.smethod_30("devmgmt.msc");
				return;
			}
			if (class245_.String_0 == "WEVTUTIL")
			{
				Class808.smethod_30("eventvwr.msc");
			}
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000B1C24 File Offset: 0x000AFE24
		private void method_1(object sender, MouseButtonEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && !textBox.IsKeyboardFocusWithin)
			{
				e.Handled = true;
				textBox.Focus();
				textBox.SelectAll();
			}
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x000B1C24 File Offset: 0x000AFE24
		private void textBox_1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && !textBox.IsKeyboardFocusWithin)
			{
				e.Handled = true;
				textBox.Focus();
				textBox.SelectAll();
			}
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x000C9694 File Offset: 0x000C7894
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/maintweakucs/maintweakshowtweaksuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000C96C8 File Offset: 0x000C78C8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Button)target).Click += this.method_0;
				return;
			case 2:
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			case 3:
				this.textBox_0 = (TextBox)target;
				return;
			case 4:
				this.textBox_1 = (TextBox)target;
				this.textBox_1.PreviewMouseDown += this.textBox_1_PreviewMouseDown;
				return;
			case 6:
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			case 7:
				this.textBox_2 = (TextBox)target;
				return;
			case 8:
				this.comboBox_0 = (ComboBox)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00020596 File Offset: 0x0001E796
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 5)
			{
				((TextBox)target).PreviewMouseDown += this.method_1;
				return;
			}
			if (connectionId != 9)
			{
				return;
			}
			((TextBox)target).PreviewMouseDown += this.method_1;
		}

		// Token: 0x040024D6 RID: 9430
		internal TextBox textBox_0;

		// Token: 0x040024D7 RID: 9431
		internal TextBox textBox_1;

		// Token: 0x040024D8 RID: 9432
		internal TextBox textBox_2;

		// Token: 0x040024D9 RID: 9433
		internal ComboBox comboBox_0;

		// Token: 0x040024DA RID: 9434
		private bool bool_0;
	}
}
