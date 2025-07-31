using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200088F RID: 2191
	public sealed class dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060033DB RID: 13275 RVA: 0x000206C5 File Offset: 0x0001E8C5
		public dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FN7ECKDQF6R5QK2ZHQKXRTQUZ4YNEL7QRMP9TZ5DFX_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x000CA0DC File Offset: 0x000C82DC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/usercontrols/ilcompare.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x000206D3 File Offset: 0x0001E8D3
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002514 RID: 9492
		private bool bool_0;
	}
}
