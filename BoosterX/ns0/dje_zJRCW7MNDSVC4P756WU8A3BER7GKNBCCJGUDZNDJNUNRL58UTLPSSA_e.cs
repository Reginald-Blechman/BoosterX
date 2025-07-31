using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200082B RID: 2091
	public sealed class dje_zJRCW7MNDSVC4P756WU8A3BER7GKNBCCJGUDZNDJNUNRL58UTLPSSA_ejd : CheckBox, IComponentConnector
	{
		// Token: 0x0600322A RID: 12842 RVA: 0x0001F8E7 File Offset: 0x0001DAE7
		public dje_zJRCW7MNDSVC4P756WU8A3BER7GKNBCCJGUDZNDJNUNRL58UTLPSSA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000C2850 File Offset: 0x000C0A50
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/interrupts/usercontrols/threaduc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x0001F8F5 File Offset: 0x0001DAF5
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this.bool_0 = true;
		}

		// Token: 0x04002331 RID: 9009
		private bool bool_0;
	}
}
