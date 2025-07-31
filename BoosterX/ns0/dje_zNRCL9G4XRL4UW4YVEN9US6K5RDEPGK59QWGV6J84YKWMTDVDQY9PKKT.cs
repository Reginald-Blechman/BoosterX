using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000857 RID: 2135
	public sealed class dje_zNRCL9G4XRL4UW4YVEN9US6K5RDEPGK59QWGV6J84YKWMTDVDQY9PKKTRHCFPYAXKMFY55QN2_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600330E RID: 13070 RVA: 0x000200B7 File Offset: 0x0001E2B7
		public dje_zNRCL9G4XRL4UW4YVEN9US6K5RDEPGK59QWGV6J84YKWMTDVDQY9PKKTRHCFPYAXKMFY55QN2_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000C5BF0 File Offset: 0x000C3DF0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/networkadapter/usercontrols/nasettinguc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x000200C5 File Offset: 0x0001E2C5
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
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.checkBox_1 = (CheckBox)target;
		}

		// Token: 0x04002404 RID: 9220
		internal CheckBox checkBox_0;

		// Token: 0x04002405 RID: 9221
		internal CheckBox checkBox_1;

		// Token: 0x04002406 RID: 9222
		private bool bool_0;
	}
}
