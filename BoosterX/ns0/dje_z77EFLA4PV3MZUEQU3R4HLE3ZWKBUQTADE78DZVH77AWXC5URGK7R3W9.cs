using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000748 RID: 1864
	public sealed class dje_z77EFLA4PV3MZUEQU3R4HLE3ZWKBUQTADE78DZVH77AWXC5URGK7R3W9RK8TA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002E60 RID: 11872 RVA: 0x0001DAFC File Offset: 0x0001BCFC
		public dje_z77EFLA4PV3MZUEQU3R4HLE3ZWKBUQTADE78DZVH77AWXC5URGK7R3W9RK8TA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000B1D40 File Offset: 0x000AFF40
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/expapplying/usercontrols/wbuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x0001DB0A File Offset: 0x0001BD0A
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04001ECD RID: 7885
		private bool bool_0;
	}
}
