using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000886 RID: 2182
	public sealed class dje_zUDE23GUASL6NYX8CQDMSLA4C6R2XKAXD7HMGF9HUTVVRXLH4DFAC5J9ZTWGQ_ejd : Page, IComponentConnector
	{
		// Token: 0x060033BE RID: 13246 RVA: 0x00020607 File Offset: 0x0001E807
		public dje_zUDE23GUASL6NYX8CQDMSLA4C6R2XKAXD7HMGF9HUTVVRXLH4DFAC5J9ZTWGQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00020615 File Offset: 0x0001E815
		private void method_0(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00020635 File Offset: 0x0001E835
		private void method_1(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_67(new bool?(true));
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00020647 File Offset: 0x0001E847
		private void method_2(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_67(new bool?(false));
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00007C85 File Offset: 0x00005E85
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x000C98B4 File Offset: 0x000C7AB4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/storex/storexwelcomepage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x000C98E8 File Offset: 0x000C7AE8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				((CheckBox)target).Checked += this.method_1;
				((CheckBox)target).Unchecked += this.method_2;
				return;
			case 4:
				((Button)target).Click += this.method_0;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040024F1 RID: 9457
		internal Grid grid_0;

		// Token: 0x040024F2 RID: 9458
		internal Button button_0;

		// Token: 0x040024F3 RID: 9459
		private bool bool_0;
	}
}
