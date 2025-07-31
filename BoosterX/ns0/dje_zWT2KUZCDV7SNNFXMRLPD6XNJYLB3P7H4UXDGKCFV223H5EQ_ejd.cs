using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008B5 RID: 2229
	public sealed class dje_zWT2KUZCDV7SNNFXMRLPD6XNJYLB3P7H4UXDGKCFV223H5EQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06003490 RID: 13456 RVA: 0x00020D21 File Offset: 0x0001EF21
		public dje_zWT2KUZCDV7SNNFXMRLPD6XNJYLB3P7H4UXDGKCFV223H5EQ_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new GClass163();
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x000CE0D4 File Offset: 0x000CC2D4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/settingspage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00020D3A File Offset: 0x0001EF3A
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002604 RID: 9732
		private bool bool_0;
	}
}
