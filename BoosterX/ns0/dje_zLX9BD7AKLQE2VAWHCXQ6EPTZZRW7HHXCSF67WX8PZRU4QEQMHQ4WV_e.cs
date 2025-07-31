using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200084B RID: 2123
	public sealed class dje_zLX9BD7AKLQE2VAWHCXQ6EPTZZRW7HHXCSF67WX8PZRU4QEQMHQ4WV_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060032EA RID: 13034 RVA: 0x0001FF83 File Offset: 0x0001E183
		public dje_zLX9BD7AKLQE2VAWHCXQ6EPTZZRW7HHXCSF67WX8PZRU4QEQMHQ4WV_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x000C5588 File Offset: 0x000C3788
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/devicepageucs/msideviceuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x000C55BC File Offset: 0x000C37BC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 3:
				this.textBlock_0 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040023E5 RID: 9189
		internal CheckBox checkBox_0;

		// Token: 0x040023E6 RID: 9190
		internal CheckBox checkBox_1;

		// Token: 0x040023E7 RID: 9191
		internal TextBlock textBlock_0;

		// Token: 0x040023E8 RID: 9192
		private bool bool_0;
	}
}
