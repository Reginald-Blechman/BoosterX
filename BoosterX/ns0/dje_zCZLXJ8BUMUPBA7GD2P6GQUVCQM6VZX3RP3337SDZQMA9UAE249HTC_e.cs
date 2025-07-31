using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007BD RID: 1981
	public sealed class dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQM6VZX3RP3337SDZQMA9UAE249HTC_ejd : Page, IComponentConnector
	{
		// Token: 0x06003041 RID: 12353 RVA: 0x0001EBB3 File Offset: 0x0001CDB3
		public dje_zCZLXJ8BUMUPBA7GD2P6GQUVCQM6VZX3RP3337SDZQMA9UAE249HTC_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class526(this.frame_0);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000B93AC File Offset: 0x000B75AC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/cs2/cs2page.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000B93E0 File Offset: 0x000B75E0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				return;
			case 3:
				this.grid_1 = (Grid)target;
				return;
			case 4:
				this.radioButton_0 = (RadioButton)target;
				return;
			case 5:
				this.radioButton_1 = (RadioButton)target;
				return;
			case 6:
				this.frame_0 = (Frame)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040020D1 RID: 8401
		internal Grid grid_0;

		// Token: 0x040020D2 RID: 8402
		internal Button button_0;

		// Token: 0x040020D3 RID: 8403
		internal Grid grid_1;

		// Token: 0x040020D4 RID: 8404
		internal RadioButton radioButton_0;

		// Token: 0x040020D5 RID: 8405
		internal RadioButton radioButton_1;

		// Token: 0x040020D6 RID: 8406
		internal Frame frame_0;

		// Token: 0x040020D7 RID: 8407
		private bool bool_0;
	}
}
