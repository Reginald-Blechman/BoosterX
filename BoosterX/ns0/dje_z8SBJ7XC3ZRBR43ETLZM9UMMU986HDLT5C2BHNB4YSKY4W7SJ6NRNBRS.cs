using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x02000771 RID: 1905
	public sealed class dje_z8SBJ7XC3ZRBR43ETLZM9UMMU986HDLT5C2BHNB4YSKY4W7SJ6NRNBRSP5PPQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002EF6 RID: 12022 RVA: 0x0001DF2B File Offset: 0x0001C12B
		public dje_z8SBJ7XC3ZRBR43ETLZM9UMMU986HDLT5C2BHNB4YSKY4W7SJ6NRNBRSP5PPQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x0001DF39 File Offset: 0x0001C139
		private void method_0(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zD7ZTNGBPA37Y7K94YCW8Z4Q2QMGWV7WHRL8P346K4BVMQBSLQM3WDFMC8BYA_ejd), Class406.smethod_0().frame_2);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x0001DF59 File Offset: 0x0001C159
		private void method_1(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_63(new bool?(true));
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x0001DF6B File Offset: 0x0001C16B
		private void method_2(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_63(new bool?(false));
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x0001DF7D File Offset: 0x0001C17D
		private void method_3(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zML4GW6XPSFBUBB9JC6TQQLWJTXTV7SW2JZZVLNQP8CMWQ75QAJAUFDWGK3LA_ejd), Class406.smethod_0().frame_2);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000B46EC File Offset: 0x000B28EC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/internettest/pages/internetfirstpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x000B4720 File Offset: 0x000B2920
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.rectangleGeometry_0 = (RectangleGeometry)target;
				return;
			case 2:
				((Button)target).Click += this.method_0;
				return;
			case 3:
				((CheckBox)target).Checked += this.method_1;
				((CheckBox)target).Unchecked += this.method_2;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001F88 RID: 8072
		internal RectangleGeometry rectangleGeometry_0;

		// Token: 0x04001F89 RID: 8073
		private bool bool_0;
	}
}
