using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000746 RID: 1862
	public sealed class dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002E58 RID: 11864 RVA: 0x0001DA66 File Offset: 0x0001BC66
		public dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x0001DA7A File Offset: 0x0001BC7A
		private void method_0()
		{
			base.DataContext = GClass292.smethod_0();
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000B1CD8 File Offset: 0x000AFED8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/appspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x0001DA87 File Offset: 0x0001BC87
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.grid_0 = (Grid)target;
		}

		// Token: 0x04001EC8 RID: 7880
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001EC9 RID: 7881
		internal Grid grid_0;

		// Token: 0x04001ECA RID: 7882
		private bool bool_0;
	}
}
