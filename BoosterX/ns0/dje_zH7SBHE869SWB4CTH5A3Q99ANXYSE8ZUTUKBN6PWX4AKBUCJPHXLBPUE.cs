using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200081E RID: 2078
	public sealed class dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd : UserControl, IComponentConnector, GInterface0
	{
		// Token: 0x060031F8 RID: 12792 RVA: 0x0001F726 File Offset: 0x0001D926
		public dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd_Loaded;
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x0001F746 File Offset: 0x0001D946
		[CompilerGenerated]
		public bool imethod_0()
		{
			return this.bool_0;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x0001F74E File Offset: 0x0001D94E
		public void method_0(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x0001F757 File Offset: 0x0001D957
		private void method_1()
		{
			base.DataContext = null;
			base.DataContext = new GClass174(this);
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x000C1E8C File Offset: 0x000C008C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/gamereadyx/usercontrols/pagefilechecker/pagefilecheckeruc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x000C1EC0 File Offset: 0x000C00C0
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
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 3:
				this.checkBox_1 = (CheckBox)target;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x0001F76C File Offset: 0x0001D96C
		private void dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			this.method_1();
		}

		// Token: 0x040022FE RID: 8958
		private bool bool_0;

		// Token: 0x040022FF RID: 8959
		internal CheckBox checkBox_0;

		// Token: 0x04002300 RID: 8960
		internal StackPanel stackPanel_0;

		// Token: 0x04002301 RID: 8961
		internal CheckBox checkBox_1;

		// Token: 0x04002302 RID: 8962
		private bool bool_1;
	}
}
