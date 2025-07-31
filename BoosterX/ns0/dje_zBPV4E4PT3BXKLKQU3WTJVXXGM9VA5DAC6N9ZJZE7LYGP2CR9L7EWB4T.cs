using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007A6 RID: 1958
	public sealed class dje_zBPV4E4PT3BXKLKQU3WTJVXXGM9VA5DAC6N9ZJZE7LYGP2CR9L7EWB4TNPCZA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002FCA RID: 12234 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
		public dje_zBPV4E4PT3BXKLKQU3WTJVXXGM9VA5DAC6N9ZJZE7LYGP2CR9L7EWB4TNPCZA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x000B7778 File Offset: 0x000B5978
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/csgoucs/csgosettingsuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x0001E6B2 File Offset: 0x0001C8B2
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
			this.checkBox_1 = (CheckBox)target;
		}

		// Token: 0x04002071 RID: 8305
		internal CheckBox checkBox_0;

		// Token: 0x04002072 RID: 8306
		internal CheckBox checkBox_1;

		// Token: 0x04002073 RID: 8307
		private bool bool_0;
	}
}
