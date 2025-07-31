using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200073C RID: 1852
	public sealed class dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002E26 RID: 11814 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
		public dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new GClass169(this);
			base.Loaded += this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_Loaded;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00013A03 File Offset: 0x00011C03
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000B04C4 File Offset: 0x000AE6C4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/firstanalyze/firstanalyzepage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000B04F8 File Offset: 0x000AE6F8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 2:
				this.border_0 = (Border)target;
				return;
			case 3:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x0001D904 File Offset: 0x0001BB04
		private void dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			GClass169 gclass = base.DataContext as GClass169;
			if (gclass == null)
			{
				return;
			}
			gclass.method_2();
		}

		// Token: 0x04001E83 RID: 7811
		internal Button button_0;

		// Token: 0x04001E84 RID: 7812
		internal Border border_0;

		// Token: 0x04001E85 RID: 7813
		internal Button button_1;

		// Token: 0x04001E86 RID: 7814
		private bool bool_0;
	}
}
