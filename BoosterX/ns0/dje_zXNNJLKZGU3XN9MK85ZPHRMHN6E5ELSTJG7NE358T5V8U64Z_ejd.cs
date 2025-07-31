using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008CF RID: 2255
	public sealed class dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003518 RID: 13592 RVA: 0x00021125 File Offset: 0x0001F325
		public dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x000CF6B0 File Offset: 0x000CD8B0
		private void method_0()
		{
			for (int i = 0; i <= 10; i++)
			{
				this.itemsControl_0.Items.Add(new object());
			}
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000CF6E0 File Offset: 0x000CD8E0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/loading/loadingelements.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x00021139 File Offset: 0x0001F339
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.itemsControl_0 = (ItemsControl)target;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x0400267F RID: 9855
		internal ItemsControl itemsControl_0;

		// Token: 0x04002680 RID: 9856
		private bool bool_0;
	}
}
