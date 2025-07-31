using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000855 RID: 2133
	public sealed class dje_zML4GW6XPSFBUBB9JC6TQQLWJTXTV7SW2JZZVLNQP8CMWQ75QAJAUFDWGK3LA_ejd : Page, IComponentConnector
	{
		// Token: 0x06003308 RID: 13064 RVA: 0x000200A0 File Offset: 0x0001E2A0
		public dje_zML4GW6XPSFBUBB9JC6TQQLWJTXTV7SW2JZZVLNQP8CMWQ75QAJAUFDWGK3LA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000C5B88 File Offset: 0x000C3D88
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/internettest/pages/internettestmethods.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000200AE File Offset: 0x0001E2AE
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002403 RID: 9219
		private bool bool_0;
	}
}
