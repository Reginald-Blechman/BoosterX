using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200082D RID: 2093
	public sealed class dje_zJUUFNV7ZNQCF29T6KEV6HFT6FEA8CF7J84L4HL8GTCNF7CDYTPQJE_ejd : Page, IComponentConnector
	{
		// Token: 0x06003233 RID: 12851 RVA: 0x000C28B8 File Offset: 0x000C0AB8
		public dje_zJUUFNV7ZNQCF29T6KEV6HFT6FEA8CF7J84L4HL8GTCNF7CDYTPQJE_ejd()
		{
			this.InitializeComponent();
			Class406.smethod_0().frame_2 = this.frame_0;
			if (Class551.class753_0.method_62().GetValueOrDefault())
			{
				Class406.smethod_0().method_4(typeof(dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd), Class406.smethod_0().frame_2);
				return;
			}
			Class406.smethod_0().method_4(typeof(dje_z8SBJ7XC3ZRBR43ETLZM9UMMU986HDLT5C2BHNB4YSKY4W7SJ6NRNBRSP5PPQ_ejd), Class406.smethod_0().frame_2);
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x000C2934 File Offset: 0x000C0B34
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			if (this.frame_0.Content.GetType() == typeof(dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd) && !Class551.class753_0.method_62().GetValueOrDefault())
			{
				Class406.smethod_0().method_4(typeof(dje_z8SBJ7XC3ZRBR43ETLZM9UMMU986HDLT5C2BHNB4YSKY4W7SJ6NRNBRSP5PPQ_ejd), Class406.smethod_0().frame_2);
				return;
			}
			if (this.frame_0.Content.GetType() == typeof(dje_zML4GW6XPSFBUBB9JC6TQQLWJTXTV7SW2JZZVLNQP8CMWQ75QAJAUFDWGK3LA_ejd))
			{
				Class406.smethod_0().method_4(typeof(dje_z8SBJ7XC3ZRBR43ETLZM9UMMU986HDLT5C2BHNB4YSKY4W7SJ6NRNBRSP5PPQ_ejd), Class406.smethod_0().frame_2);
				return;
			}
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x000C29F4 File Offset: 0x000C0BF4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/internettest/internettestpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x000C2A28 File Offset: 0x000C0C28
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
			if (connectionId != 2)
			{
				this.bool_0 = true;
				return;
			}
			this.frame_0 = (Frame)target;
		}

		// Token: 0x04002334 RID: 9012
		internal Button button_0;

		// Token: 0x04002335 RID: 9013
		internal Frame frame_0;

		// Token: 0x04002336 RID: 9014
		private bool bool_0;
	}
}
