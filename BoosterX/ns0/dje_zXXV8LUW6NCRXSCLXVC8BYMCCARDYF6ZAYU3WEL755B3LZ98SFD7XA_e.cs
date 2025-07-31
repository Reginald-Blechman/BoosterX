using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008D8 RID: 2264
	public sealed class dje_zXXV8LUW6NCRXSCLXVC8BYMCCARDYF6ZAYU3WEL755B3LZ98SFD7XA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600353E RID: 13630 RVA: 0x00021298 File Offset: 0x0001F498
		public dje_zXXV8LUW6NCRXSCLXVC8BYMCCARDYF6ZAYU3WEL755B3LZ98SFD7XA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x000D0430 File Offset: 0x000CE630
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/devicepageucs/disabledeviceuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000D0464 File Offset: 0x000CE664
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

		// Token: 0x040026B2 RID: 9906
		internal CheckBox checkBox_0;

		// Token: 0x040026B3 RID: 9907
		internal CheckBox checkBox_1;

		// Token: 0x040026B4 RID: 9908
		internal TextBlock textBlock_0;

		// Token: 0x040026B5 RID: 9909
		private bool bool_0;
	}
}
