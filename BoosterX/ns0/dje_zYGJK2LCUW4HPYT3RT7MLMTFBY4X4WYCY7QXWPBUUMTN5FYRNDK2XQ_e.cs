using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008E8 RID: 2280
	public sealed class dje_zYGJK2LCUW4HPYT3RT7MLMTFBY4X4WYCY7QXWPBUUMTN5FYRNDK2XQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003596 RID: 13718 RVA: 0x00021518 File Offset: 0x0001F718
		public dje_zYGJK2LCUW4HPYT3RT7MLMTFBY4X4WYCY7QXWPBUUMTN5FYRNDK2XQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x000D0ECC File Offset: 0x000CF0CC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/settingsucs/settingsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00021526 File Offset: 0x0001F726
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.checkBox_0 = (CheckBox)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04002702 RID: 9986
		internal CheckBox checkBox_0;

		// Token: 0x04002703 RID: 9987
		private bool bool_0;
	}
}
