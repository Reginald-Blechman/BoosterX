using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Navigation;

namespace ns0
{
	// Token: 0x0200074D RID: 1869
	public sealed class dje_z79XZ9PJSA33Q6P6UM56MPW6ZC28DZ8FQ9UXMN9SRPJYJBPP3NDF8CQXGQGAQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002E74 RID: 11892 RVA: 0x0001DBEB File Offset: 0x0001BDEB
		public dje_z79XZ9PJSA33Q6P6UM56MPW6ZC28DZ8FQ9UXMN9SRPJYJBPP3NDF8CQXGQGAQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0001D789 File Offset: 0x0001B989
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x0001DBF9 File Offset: 0x0001BDF9
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_37(new bool?(true));
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x0001DC0B File Offset: 0x0001BE0B
		private void method_0(object sender, RequestNavigateEventArgs e)
		{
			Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri)
			{
				UseShellExecute = true
			});
			e.Handled = true;
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000B207C File Offset: 0x000B027C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/firstanalyze/pages/faacceptpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000B20B0 File Offset: 0x000B02B0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Hyperlink)target).RequestNavigate += this.method_0;
				return;
			case 2:
				((Hyperlink)target).RequestNavigate += this.method_0;
				return;
			case 3:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 4:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001EDE RID: 7902
		internal Button button_0;

		// Token: 0x04001EDF RID: 7903
		internal Button button_1;

		// Token: 0x04001EE0 RID: 7904
		private bool bool_0;
	}
}
