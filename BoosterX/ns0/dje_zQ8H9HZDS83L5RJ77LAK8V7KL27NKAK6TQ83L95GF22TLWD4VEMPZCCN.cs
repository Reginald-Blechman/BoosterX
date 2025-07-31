using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000865 RID: 2149
	public sealed class dje_zQ8H9HZDS83L5RJ77LAK8V7KL27NKAK6TQ83L95GF22TLWD4VEMPZCCNQAEXA_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06003340 RID: 13120 RVA: 0x0002024F File Offset: 0x0001E44F
		public dje_zQ8H9HZDS83L5RJ77LAK8V7KL27NKAK6TQ83L95GF22TLWD4VEMPZCCNQAEXA_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000C6D6C File Offset: 0x000C4F6C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/cleanupucs/cleanupuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x0002025D File Offset: 0x0001E45D
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

		// Token: 0x04002443 RID: 9283
		internal CheckBox checkBox_0;

		// Token: 0x04002444 RID: 9284
		internal TextBlock textBlock_0;

		// Token: 0x04002445 RID: 9285
		private bool bool_0;
	}
}
