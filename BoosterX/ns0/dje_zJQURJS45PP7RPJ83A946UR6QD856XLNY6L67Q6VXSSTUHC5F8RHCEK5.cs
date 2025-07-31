using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200082A RID: 2090
	public sealed class dje_zJQURJS45PP7RPJ83A946UR6QD856XLNY6L67Q6VXSSTUHC5F8RHCEK5TTFXV2U3XA3_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003227 RID: 12839 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		public dje_zJQURJS45PP7RPJ83A946UR6QD856XLNY6L67Q6VXSSTUHC5F8RHCEK5TTFXV2U3XA3_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000C281C File Offset: 0x000C0A1C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgoruncommandsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x0001F8DE File Offset: 0x0001DADE
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002330 RID: 9008
		private bool bool_0;
	}
}
