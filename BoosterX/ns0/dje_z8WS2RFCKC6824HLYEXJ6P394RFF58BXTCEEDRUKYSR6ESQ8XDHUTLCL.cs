using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000773 RID: 1907
	public sealed class dje_z8WS2RFCKC6824HLYEXJ6P394RFF58BXTCEEDRUKYSR6ESQ8XDHUTLCLNV7SA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002F01 RID: 12033 RVA: 0x0001DFC5 File Offset: 0x0001C1C5
		public dje_z8WS2RFCKC6824HLYEXJ6P394RFF58BXTCEEDRUKYSR6ESQ8XDHUTLCLNV7SA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000B47D0 File Offset: 0x000B29D0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/fixes/usercontrols/problemuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x0001DFD3 File Offset: 0x0001C1D3
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
			this.bool_0 = true;
		}

		// Token: 0x04001F8C RID: 8076
		internal CheckBox checkBox_0;

		// Token: 0x04001F8D RID: 8077
		private bool bool_0;
	}
}
