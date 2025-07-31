using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;

namespace ns0
{
	// Token: 0x0200078F RID: 1935
	public sealed class dje_z9DL9HRJ5NJS2KUNGS9G5P7PUH4NWFDYGS7DJ2RQ8TR4A3V748LWUYZQ38EGP4HKRK3_ejd : Page, IComponentConnector
	{
		// Token: 0x06002F78 RID: 12152 RVA: 0x0001E430 File Offset: 0x0001C630
		public dje_z9DL9HRJ5NJS2KUNGS9G5P7PUH4NWFDYGS7DJ2RQ8TR4A3V748LWUYZQ38EGP4HKRK3_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_z9DL9HRJ5NJS2KUNGS9G5P7PUH4NWFDYGS7DJ2RQ8TR4A3V748LWUYZQ38EGP4HKRK3_ejd_Loaded;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000B6604 File Offset: 0x000B4804
		private void dje_z9DL9HRJ5NJS2KUNGS9G5P7PUH4NWFDYGS7DJ2RQ8TR4A3V748LWUYZQ38EGP4HKRK3_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			try
			{
				this.image_0.Source = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component/Resources/Images/InputLag/Input" + Class298.smethod_2("CurrentLocalization") + ".png"));
			}
			catch
			{
				this.image_0.Source = new BitmapImage(new Uri("pack://application:,,,/BoosterX;component/Resources/Images/InputLag/Inputen-US.png"));
			}
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x0001E450 File Offset: 0x0001C650
		private void method_0(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zDZECBXBD8VM3CS6QHC3EPBRN3G5PD3E8RCRUK6BQH7M9TBWRUQZEBD5PC6TQ_ejd), Class406.smethod_0().frame_1);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x0001E470 File Offset: 0x0001C670
		private void method_1(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_61(new bool?(true));
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x0001E482 File Offset: 0x0001C682
		private void method_2(object sender, RoutedEventArgs e)
		{
			Class551.class753_0.method_61(new bool?(false));
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x0001E494 File Offset: 0x0001C694
		private void method_3(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zUZZX3JW5QK5ZY7D9QWJXC9J4FXAPG9NMXDBFG2XK73CRK7V37GKQKABJZ549PMDY4X_ejd), Class406.smethod_0().frame_1);
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x000B6674 File Offset: 0x000B4874
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/inputlagtest/pages/ilfirst.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x000B66A8 File Offset: 0x000B48A8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.image_0 = (Image)target;
				return;
			case 2:
				((Button)target).Click += this.method_0;
				return;
			case 3:
				((CheckBox)target).Checked += this.method_1;
				((CheckBox)target).Unchecked += this.method_2;
				return;
			case 4:
				((Button)target).Click += this.method_3;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04002012 RID: 8210
		internal Image image_0;

		// Token: 0x04002013 RID: 8211
		private bool bool_0;
	}
}
