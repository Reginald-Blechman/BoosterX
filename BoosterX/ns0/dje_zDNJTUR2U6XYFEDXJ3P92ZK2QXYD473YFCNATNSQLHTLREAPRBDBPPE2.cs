using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007C8 RID: 1992
	public sealed class dje_zDNJTUR2U6XYFEDXJ3P92ZK2QXYD473YFCNATNSQLHTLREAPRBDBPPE2XCZACBDEZHS_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600306E RID: 12398 RVA: 0x0001EC98 File Offset: 0x0001CE98
		public dje_zDNJTUR2U6XYFEDXJ3P92ZK2QXYD473YFCNATNSQLHTLREAPRBDBPPE2XCZACBDEZHS_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zDNJTUR2U6XYFEDXJ3P92ZK2QXYD473YFCNATNSQLHTLREAPRBDBPPE2XCZACBDEZHS_ejd_Loaded;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000BA5F8 File Offset: 0x000B87F8
		private void dje_zDNJTUR2U6XYFEDXJ3P92ZK2QXYD473YFCNATNSQLHTLREAPRBDBPPE2XCZACBDEZHS_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			if (this.class497_0 == null)
			{
				base.DataContext = (this.class497_0 = new Class497());
			}
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000BA624 File Offset: 0x000B8824
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/news/newsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.grid_0 = (Grid)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x04002114 RID: 8468
		private Class497 class497_0;

		// Token: 0x04002115 RID: 8469
		internal Grid grid_0;

		// Token: 0x04002116 RID: 8470
		private bool bool_0;
	}
}
