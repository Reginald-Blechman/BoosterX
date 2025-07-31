using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200084D RID: 2125
	public sealed class dje_zM8MTHJRQY2PJXKMKYVU5FPXV2AGQMSZ7BAK7RLZUBJ3NFAL2ANMQ49PNZEHHFBW5BQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060032F0 RID: 13040 RVA: 0x0001FFA8 File Offset: 0x0001E1A8
		public dje_zM8MTHJRQY2PJXKMKYVU5FPXV2AGQMSZ7BAK7RLZUBJ3NFAL2ANMQ49PNZEHHFBW5BQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x0001FFB6 File Offset: 0x0001E1B6
		private void method_0(object sender, RoutedEventArgs e)
		{
			if (!(base.DataContext as Class518).bool_0)
			{
				(base.DataContext as Class518).AppXIsChecked = false;
			}
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000C5640 File Offset: 0x000C3840
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/usercontrols/appxinstalluc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x0001FFDB File Offset: 0x0001E1DB
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((Button)target).Click += this.method_0;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x040023EA RID: 9194
		private bool bool_0;
	}
}
