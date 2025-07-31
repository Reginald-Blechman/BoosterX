using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000884 RID: 2180
	public sealed class dje_zTXQ5AHTH6TXHYLF7X8NC3783YSNN9SRAEAENSCT6ECWJUN8PZ2MGBWFTLSGCHK5NRUGTHBGN_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060033BB RID: 13243 RVA: 0x000205DF File Offset: 0x0001E7DF
		public dje_zTXQ5AHTH6TXHYLF7X8NC3783YSNN9SRAEAENSCT6ECWJUN8PZ2MGBWFTLSGCHK5NRUGTHBGN_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000C9880 File Offset: 0x000C7A80
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/usefulcmds/usefulcmduc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x000205ED File Offset: 0x0001E7ED
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

		// Token: 0x040024E2 RID: 9442
		internal CheckBox checkBox_0;

		// Token: 0x040024E3 RID: 9443
		private bool bool_0;
	}
}
