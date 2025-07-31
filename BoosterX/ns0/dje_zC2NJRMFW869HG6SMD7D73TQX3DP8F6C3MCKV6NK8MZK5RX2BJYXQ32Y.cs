using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007B3 RID: 1971
	public sealed class dje_zC2NJRMFW869HG6SMD7D73TQX3DP8F6C3MCKV6NK8MZK5RX2BJYXQ32YU734AFE7UPD7ZFLRU_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003005 RID: 12293 RVA: 0x0001E981 File Offset: 0x0001CB81
		public dje_zC2NJRMFW869HG6SMD7D73TQX3DP8F6C3MCKV6NK8MZK5RX2BJYXQ32YU734AFE7UPD7ZFLRU_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x000B8B88 File Offset: 0x000B6D88
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/usercontrols/choosenthings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0001E98F File Offset: 0x0001CB8F
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040020A7 RID: 8359
		private bool bool_0;
	}
}
