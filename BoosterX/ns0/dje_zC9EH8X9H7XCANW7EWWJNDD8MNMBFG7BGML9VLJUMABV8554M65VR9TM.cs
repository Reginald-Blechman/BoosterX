using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007B6 RID: 1974
	public sealed class dje_zC9EH8X9H7XCANW7EWWJNDD8MNMBFG7BGML9VLJUMABV8554M65VR9TM8TEDQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003029 RID: 12329 RVA: 0x0001EAE3 File Offset: 0x0001CCE3
		public dje_zC9EH8X9H7XCANW7EWWJNDD8MNMBFG7BGML9VLJUMABV8554M65VR9TM8TEDQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x000B8D68 File Offset: 0x000B6F68
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/cleanupucs/deleteduwpcleanuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x0001EAF1 File Offset: 0x0001CCF1
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
			this.textBlock_0 = (TextBlock)target;
		}

		// Token: 0x040020B5 RID: 8373
		internal CheckBox checkBox_0;

		// Token: 0x040020B6 RID: 8374
		internal TextBlock textBlock_0;

		// Token: 0x040020B7 RID: 8375
		private bool bool_0;
	}
}
