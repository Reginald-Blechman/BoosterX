using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200082C RID: 2092
	public sealed class dje_zJRX6PD6DM6UZ4PU26LQ2SY7Y6V38GWNWMRR4VDD9JWB8WCT6GF4MQYK65NHJTQJH8S_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x0001F8FE File Offset: 0x0001DAFE
		public dje_zJRX6PD6DM6UZ4PU26LQ2SY7Y6V38GWNWMRR4VDD9JWB8WCT6GF4MQYK65NHJTQJH8S_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x0001F90C File Offset: 0x0001DB0C
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://discord.gg/boosterx");
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x0001F91A File Offset: 0x0001DB1A
		private void method_0(object sender, RoutedEventArgs e)
		{
			Process.Start("www.youtube.com/iosiph");
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0001F928 File Offset: 0x0001DB28
		private void method_1(object sender, RoutedEventArgs e)
		{
			Process.Start("www.vk.com/ios1phvk");
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x000C2884 File Offset: 0x000C0A84
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/mainpageucs/socialuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x0001F936 File Offset: 0x0001DB36
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

		// Token: 0x04002332 RID: 9010
		internal Button button_0;

		// Token: 0x04002333 RID: 9011
		private bool bool_0;
	}
}
