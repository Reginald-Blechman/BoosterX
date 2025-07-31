using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007D0 RID: 2000
	public sealed class dje_zDURZHFG762BDG9N5VGPAF7FW2RFFR3JHVEDTBLC6N7XA2TTHKWQSQLKM7LYQ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060030B4 RID: 12468 RVA: 0x0001EE28 File Offset: 0x0001D028
		public dje_zDURZHFG762BDG9N5VGPAF7FW2RFFR3JHVEDTBLC6N7XA2TTHKWQSQLKM7LYQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x000BB06C File Offset: 0x000B926C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/cleanupucs/deviceremoveucs.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0001EE36 File Offset: 0x0001D036
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

		// Token: 0x04002153 RID: 8531
		internal CheckBox checkBox_0;

		// Token: 0x04002154 RID: 8532
		internal TextBlock textBlock_0;

		// Token: 0x04002155 RID: 8533
		private bool bool_0;
	}
}
