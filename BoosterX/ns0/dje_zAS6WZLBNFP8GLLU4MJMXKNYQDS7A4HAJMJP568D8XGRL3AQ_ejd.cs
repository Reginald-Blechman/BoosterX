using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200079D RID: 1949
	public sealed class dje_zAS6WZLBNFP8GLLU4MJMXKNYQDS7A4HAJMJP568D8XGRL3AQ_ejd : ListView, IComponentConnector
	{
		// Token: 0x06002FB0 RID: 12208 RVA: 0x0001E612 File Offset: 0x0001C812
		public dje_zAS6WZLBNFP8GLLU4MJMXKNYQDS7A4HAJMJP568D8XGRL3AQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x000B70B0 File Offset: 0x000B52B0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/services/nvidiax/mvvm/views/usercontrols/nvlistview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x0001E620 File Offset: 0x0001C820
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002050 RID: 8272
		private bool bool_0;
	}
}
