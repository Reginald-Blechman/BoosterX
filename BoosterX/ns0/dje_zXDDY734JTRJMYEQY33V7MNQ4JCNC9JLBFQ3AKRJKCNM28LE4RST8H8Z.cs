using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008CC RID: 2252
	public sealed class dje_zXDDY734JTRJMYEQY33V7MNQ4JCNC9JLBFQ3AKRJKCNM28LE4RST8H8ZG6FL5VRB7AQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x0002106D File Offset: 0x0001F26D
		public dje_zXDDY734JTRJMYEQY33V7MNQ4JCNC9JLBFQ3AKRJKCNM28LE4RST8H8ZG6FL5VRB7AQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x000CF2E0 File Offset: 0x000CD4E0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/gamemodexucs/gmxaddappsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x0002107B File Offset: 0x0001F27B
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002677 RID: 9847
		private bool bool_0;
	}
}
