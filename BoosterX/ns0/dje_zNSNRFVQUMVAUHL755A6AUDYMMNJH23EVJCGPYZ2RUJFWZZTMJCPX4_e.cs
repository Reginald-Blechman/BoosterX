using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000858 RID: 2136
	public sealed class dje_zNSNRFVQUMVAUHL755A6AUDYMMNJH23EVJCGPYZ2RUJFWZZTMJCPX4_ejd : Page, IComponentConnector
	{
		// Token: 0x06003311 RID: 13073 RVA: 0x000200F0 File Offset: 0x0001E2F0
		public dje_zNSNRFVQUMVAUHL755A6AUDYMMNJH23EVJCGPYZ2RUJFWZZTMJCPX4_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class495();
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000C5C24 File Offset: 0x000C3E24
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/bupage/backuppage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x000C5C58 File Offset: 0x000C3E58
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 2:
				this.image_0 = (Image)target;
				return;
			case 3:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002407 RID: 9223
		internal ItemsControl itemsControl_0;

		// Token: 0x04002408 RID: 9224
		internal Image image_0;

		// Token: 0x04002409 RID: 9225
		internal ItemsControl itemsControl_1;

		// Token: 0x0400240A RID: 9226
		private bool bool_0;
	}
}
