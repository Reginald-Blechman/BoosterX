using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008D1 RID: 2257
	public sealed class dje_zXNNJLKZGU3XN9MK85ZPHRMHN6TLT9JSR6D4D7NR9PZJCSNHLEEUA4V5W85KFULPDMQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003524 RID: 13604 RVA: 0x000211C8 File Offset: 0x0001F3C8
		public dje_zXNNJLKZGU3XN9MK85ZPHRMHN6TLT9JSR6D4D7NR9PZJCSNHLEEUA4V5W85KFULPDMQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x000CF878 File Offset: 0x000CDA78
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/gamemodexucs/gmxappsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x000211D6 File Offset: 0x0001F3D6
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002687 RID: 9863
		private bool bool_0;
	}
}
