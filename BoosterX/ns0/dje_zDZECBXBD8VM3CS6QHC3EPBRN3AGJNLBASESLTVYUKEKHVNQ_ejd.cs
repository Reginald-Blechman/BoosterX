using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007D5 RID: 2005
	public sealed class dje_zDZECBXBD8VM3CS6QHC3EPBRN3AGJNLBASESLTVYUKEKHVNQ_ejd : Page, IComponentConnector
	{
		// Token: 0x060030C5 RID: 12485 RVA: 0x0001EED6 File Offset: 0x0001D0D6
		public dje_zDZECBXBD8VM3CS6QHC3EPBRN3AGJNLBASESLTVYUKEKHVNQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x000BB458 File Offset: 0x000B9658
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/loginpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002167 RID: 8551
		private bool bool_0;
	}
}
