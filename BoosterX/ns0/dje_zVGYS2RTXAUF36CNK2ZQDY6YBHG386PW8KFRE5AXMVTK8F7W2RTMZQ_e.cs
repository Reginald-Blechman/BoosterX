using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020008A3 RID: 2211
	public sealed class dje_zVGYS2RTXAUF36CNK2ZQDY6YBHG386PW8KFRE5AXMVTK8F7W2RTMZQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600343D RID: 13373 RVA: 0x00020921 File Offset: 0x0001EB21
		public dje_zVGYS2RTXAUF36CNK2ZQDY6YBHG386PW8KFRE5AXMVTK8F7W2RTMZQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000CCA08 File Offset: 0x000CAC08
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicesgroupcontroller/servicegrouplistview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x0002092F File Offset: 0x0001EB2F
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.textBlock_0 = (TextBlock)target;
				return;
			}
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.checkBox_0 = (CheckBox)target;
		}

		// Token: 0x0400259B RID: 9627
		internal TextBlock textBlock_0;

		// Token: 0x0400259C RID: 9628
		internal CheckBox checkBox_0;

		// Token: 0x0400259D RID: 9629
		private bool bool_0;
	}
}
