using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000749 RID: 1865
	public sealed class dje_z77EFLA4PV3MZUEQU3R4HLE3ZWRW73JFLBZS8R4MEGVNSXUMY5GRCN87RDFUK3NSG6Z4TEGDG_ejd : Page, IComponentConnector
	{
		// Token: 0x06002E63 RID: 11875 RVA: 0x0001DB13 File Offset: 0x0001BD13
		public dje_z77EFLA4PV3MZUEQU3R4HLE3ZWRW73JFLBZS8R4MEGVNSXUMY5GRCN87RDFUK3NSG6Z4TEGDG_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class507();
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000B1D74 File Offset: 0x000AFF74
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/gamereadyx/sapage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x0001DB2C File Offset: 0x0001BD2C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.button_0 = (Button)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04001ECE RID: 7886
		internal Button button_0;

		// Token: 0x04001ECF RID: 7887
		private bool bool_0;
	}
}
