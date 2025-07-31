using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200073D RID: 1853
	public sealed class dje_z3WP2HW8PSZP86YNKWKFVYFTNVZ7QN4XXLNK5RUJYR3TNLMUFK33XJG29KMSABCQPSZ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002E2D RID: 11821 RVA: 0x0001D91B File Offset: 0x0001BB1B
		public dje_z3WP2HW8PSZP86YNKWKFVYFTNVZ7QN4XXLNK5RUJYR3TNLMUFK33XJG29KMSABCQPSZ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x000B0578 File Offset: 0x000AE778
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/usercontrols/cloudbackupsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0001D929 File Offset: 0x0001BB29
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04001E87 RID: 7815
		private bool bool_0;
	}
}
