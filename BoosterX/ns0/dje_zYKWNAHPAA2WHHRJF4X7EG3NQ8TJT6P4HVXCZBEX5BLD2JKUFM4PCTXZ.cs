using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008E9 RID: 2281
	public sealed class dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TJT6P4HVXCZBEX5BLD2JKUFM4PCTXZ75CCLQQGATQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06003599 RID: 13721 RVA: 0x00021540 File Offset: 0x0001F740
		public dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TJT6P4HVXCZBEX5BLD2JKUFM4PCTXZ75CCLQQGATQ_ejd()
		{
			this.InitializeComponent();
			base.DataContext = GClass28.smethod_0(true);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x000D0F00 File Offset: 0x000CF100
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/networkadapter/networkadapterpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x000D0F34 File Offset: 0x000CF134
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				return;
			case 2:
				this.button_1 = (Button)target;
				return;
			case 3:
				this.button_2 = (Button)target;
				return;
			case 4:
				this.button_3 = (Button)target;
				return;
			case 5:
				this.checkBox_0 = (CheckBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002704 RID: 9988
		internal Button button_0;

		// Token: 0x04002705 RID: 9989
		internal Button button_1;

		// Token: 0x04002706 RID: 9990
		internal Button button_2;

		// Token: 0x04002707 RID: 9991
		internal Button button_3;

		// Token: 0x04002708 RID: 9992
		internal CheckBox checkBox_0;

		// Token: 0x04002709 RID: 9993
		private bool bool_0;
	}
}
