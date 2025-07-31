using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000881 RID: 2177
	public sealed class dje_zSGDGZJWJKC6URDA79MXPW9LENEGXXAKKKNX5H9GHVKLL7B9VTSRAXCJFKBKF3MHR9Z_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060033AC RID: 13228 RVA: 0x0002054F File Offset: 0x0001E74F
		public dje_zSGDGZJWJKC6URDA79MXPW9LENEGXXAKKKNX5H9GHVKLL7B9VTSRAXCJFKBKF3MHR9Z_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x000C9534 File Offset: 0x000C7734
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgolaunchoptsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x0002055D File Offset: 0x0001E75D
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.checkBox_0 = (CheckBox)target;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.checkBox_1 = (CheckBox)target;
		}

		// Token: 0x040024D3 RID: 9427
		internal CheckBox checkBox_0;

		// Token: 0x040024D4 RID: 9428
		internal CheckBox checkBox_1;

		// Token: 0x040024D5 RID: 9429
		private bool bool_0;
	}
}
