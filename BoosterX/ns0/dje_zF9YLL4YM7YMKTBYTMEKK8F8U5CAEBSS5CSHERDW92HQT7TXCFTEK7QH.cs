using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007EB RID: 2027
	public sealed class dje_zF9YLL4YM7YMKTBYTMEKK8F8U5CAEBSS5CSHERDW92HQT7TXCFTEK7QHWPQGQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06003144 RID: 12612 RVA: 0x0001F1A7 File Offset: 0x0001D3A7
		public dje_zF9YLL4YM7YMKTBYTMEKK8F8U5CAEBSS5CSHERDW92HQT7TXCFTEK7QHWPQGQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x000BD880 File Offset: 0x000BBA80
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/cs2/views/cs2notfound.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0001F1B5 File Offset: 0x0001D3B5
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040021ED RID: 8685
		private bool bool_0;
	}
}
