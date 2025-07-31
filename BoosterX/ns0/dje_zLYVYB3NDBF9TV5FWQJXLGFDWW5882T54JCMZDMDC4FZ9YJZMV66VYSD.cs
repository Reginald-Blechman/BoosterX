using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200084C RID: 2124
	public sealed class dje_zLYVYB3NDBF9TV5FWQJXLGFDWW5882T54JCMZDMDC4FZ9YJZMV66VYSDW2P6A_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060032ED RID: 13037 RVA: 0x0001FF91 File Offset: 0x0001E191
		public dje_zLYVYB3NDBF9TV5FWQJXLGFDWW5882T54JCMZDMDC4FZ9YJZMV66VYSDW2P6A_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x000C560C File Offset: 0x000C380C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/usercontrols/appxuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x0001FF9F File Offset: 0x0001E19F
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x040023E9 RID: 9193
		private bool bool_0;
	}
}
