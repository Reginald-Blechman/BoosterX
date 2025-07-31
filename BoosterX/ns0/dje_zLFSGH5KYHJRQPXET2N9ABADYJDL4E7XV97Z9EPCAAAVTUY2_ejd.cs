using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200084A RID: 2122
	public sealed class dje_zLFSGH5KYHJRQPXET2N9ABADYJDL4E7XV97Z9EPCAAAVTUY2_ejd : Page, IComponentConnector
	{
		// Token: 0x060032E6 RID: 13030 RVA: 0x0001FF44 File Offset: 0x0001E144
		public dje_zLFSGH5KYHJRQPXET2N9ABADYJDL4E7XV97Z9EPCAAAVTUY2_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x000C5554 File Offset: 0x000C3754
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/aboutpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x0001FF52 File Offset: 0x0001E152
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			}
			this.bool_0 = true;
		}

		// Token: 0x040023E3 RID: 9187
		internal Button button_0;

		// Token: 0x040023E4 RID: 9188
		private bool bool_0;
	}
}
