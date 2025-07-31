using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007EA RID: 2026
	public sealed class dje_zEM7H9XLQWZJCJMMKYUGFQJP6PSQ5M2G4UXBVWR7QUU8Z3YK8KEH36D3WENTSMGUH9MTS3YSN_ejd : Page, IComponentConnector
	{
		// Token: 0x06003141 RID: 12609 RVA: 0x0001F190 File Offset: 0x0001D390
		public dje_zEM7H9XLQWZJCJMMKYUGFQJP6PSQ5M2G4UXBVWR7QUU8Z3YK8KEH36D3WENTSMGUH9MTS3YSN_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x000BD84C File Offset: 0x000BBA4C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/firstanalyze/pages/famain/famainpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x0001F19E File Offset: 0x0001D39E
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040021EC RID: 8684
		private bool bool_0;
	}
}
