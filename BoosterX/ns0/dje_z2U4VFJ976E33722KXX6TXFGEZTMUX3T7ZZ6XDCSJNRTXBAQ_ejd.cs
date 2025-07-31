using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace ns0
{
	// Token: 0x02000735 RID: 1845
	public sealed class dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002DFF RID: 11775 RVA: 0x0001D682 File Offset: 0x0001B882
		public dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x0001D6A4 File Offset: 0x0001B8A4
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Dispatcher.Invoke(new Action(dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd.Class879.class879_0.method_0));
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x000AF7A4 File Offset: 0x000AD9A4
		private void button_1_MouseEnter(object sender, MouseEventArgs e)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.textBlock_0, this.timeSpan_0, Page.FontSizeProperty, 45.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_2, this.timeSpan_0, FrameworkElement.HeightProperty, 250.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_19(this.border_0, this.timeSpan_0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_0, this.timeSpan_0, UIElement.OpacityProperty, 0.8);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_1, this.timeSpan_0, UIElement.OpacityProperty, 0.8);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_30(this.rotateTransform_0, this.timeSpan_0, 15.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_30(this.rotateTransform_1, this.timeSpan_0, -15.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_0, this.timeSpan_0, new Thickness(170.0, 110.0, 0.0, 0.0));
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_1, this.timeSpan_0, new Thickness(0.0, 110.0, 170.0, 0.0));
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_2, this.timeSpan_0, new Thickness(0.0, 0.0, 0.0, 0.0));
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x000AF950 File Offset: 0x000ADB50
		private void button_1_MouseLeave(object sender, MouseEventArgs e)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.textBlock_0, this.timeSpan_0, Page.FontSizeProperty, 30.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_2, this.timeSpan_0, FrameworkElement.HeightProperty, 200.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_13(this.border_0, this.timeSpan_0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_0, this.timeSpan_0, UIElement.OpacityProperty, 0.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_1, this.timeSpan_0, UIElement.OpacityProperty, 0.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_30(this.rotateTransform_0, this.timeSpan_0, 0.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_30(this.rotateTransform_1, this.timeSpan_0, 0.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_0, this.timeSpan_0, new Thickness(170.0, 50.0, 0.0, 0.0));
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_1, this.timeSpan_0, new Thickness(0.0, 50.0, 170.0, 0.0));
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_2, this.timeSpan_0, new Thickness(0.0, 0.0, 0.0, 20.0));
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000AFAFC File Offset: 0x000ADCFC
		private void button_2_MouseEnter(object sender, MouseEventArgs e)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.textBlock_1, this.timeSpan_0, Page.FontSizeProperty, 40.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_19(this.border_1, this.timeSpan_0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_19(this.image_3, this.timeSpan_0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_3, this.timeSpan_0, UIElement.OpacityProperty, 0.8);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_4, this.timeSpan_0, FrameworkElement.HeightProperty, 230.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_3, this.timeSpan_0, new Thickness(0.0, 0.0, 37.0, 12.0));
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000AFBD8 File Offset: 0x000ADDD8
		private void button_2_MouseLeave(object sender, MouseEventArgs e)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.textBlock_1, this.timeSpan_0, Page.FontSizeProperty, 30.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_13(this.border_1, this.timeSpan_0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_13(this.image_3, this.timeSpan_0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_3, this.timeSpan_0, UIElement.OpacityProperty, 0.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.image_4, this.timeSpan_0, FrameworkElement.HeightProperty, 200.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_31(this.image_3, this.timeSpan_0, new Thickness(0.0, 0.0, 70.0, 45.0));
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x0001D6D4 File Offset: 0x0001B8D4
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_0));
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x0001D6F1 File Offset: 0x0001B8F1
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Dispatcher.Invoke(new Action(dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd.Class879.class879_0.method_1));
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000AFCB4 File Offset: 0x000ADEB4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/beginoptimization.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000AFCE8 File Offset: 0x000ADEE8
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
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				this.button_1.MouseEnter += this.button_1_MouseEnter;
				this.button_1.MouseLeave += this.button_1_MouseLeave;
				return;
			case 3:
				this.border_0 = (Border)target;
				return;
			case 4:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 5:
				this.image_0 = (Image)target;
				return;
			case 6:
				this.rotateTransform_0 = (RotateTransform)target;
				return;
			case 7:
				this.image_1 = (Image)target;
				return;
			case 8:
				this.rotateTransform_1 = (RotateTransform)target;
				return;
			case 9:
				this.image_2 = (Image)target;
				return;
			case 10:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				this.button_2.MouseEnter += this.button_2_MouseEnter;
				this.button_2.MouseLeave += this.button_2_MouseLeave;
				return;
			case 11:
				this.border_1 = (Border)target;
				return;
			case 12:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 13:
				this.image_3 = (Image)target;
				return;
			case 14:
				this.image_4 = (Image)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x0001D721 File Offset: 0x0001B921
		private void method_0()
		{
			GClass279.smethod_0().method_20();
			Class406.smethod_0().list_2.Clear();
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_19 = true;
			((dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)Window.GetWindow(this)).radioButton_1.IsChecked = new bool?(true);
		}

		// Token: 0x04001E5C RID: 7772
		private TimeSpan timeSpan_0 = TimeSpan.FromMilliseconds(300.0);

		// Token: 0x04001E5D RID: 7773
		internal Button button_0;

		// Token: 0x04001E5E RID: 7774
		internal Button button_1;

		// Token: 0x04001E5F RID: 7775
		internal Border border_0;

		// Token: 0x04001E60 RID: 7776
		internal TextBlock textBlock_0;

		// Token: 0x04001E61 RID: 7777
		internal Image image_0;

		// Token: 0x04001E62 RID: 7778
		internal RotateTransform rotateTransform_0;

		// Token: 0x04001E63 RID: 7779
		internal Image image_1;

		// Token: 0x04001E64 RID: 7780
		internal RotateTransform rotateTransform_1;

		// Token: 0x04001E65 RID: 7781
		internal Image image_2;

		// Token: 0x04001E66 RID: 7782
		internal Button button_2;

		// Token: 0x04001E67 RID: 7783
		internal Border border_1;

		// Token: 0x04001E68 RID: 7784
		internal TextBlock textBlock_1;

		// Token: 0x04001E69 RID: 7785
		internal Image image_3;

		// Token: 0x04001E6A RID: 7786
		internal Image image_4;

		// Token: 0x04001E6B RID: 7787
		private bool bool_0;

		// Token: 0x02000736 RID: 1846
		[Serializable]
		private sealed class Class879
		{
			// Token: 0x06002E0C RID: 11788 RVA: 0x0001D769 File Offset: 0x0001B969
			internal void method_0()
			{
				Class406.smethod_0().method_4(typeof(dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd), Class406.smethod_0().frame_0);
			}

			// Token: 0x06002E0D RID: 11789 RVA: 0x0001D789 File Offset: 0x0001B989
			internal void method_1()
			{
				Class406.smethod_0().method_4(typeof(dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd), Class406.smethod_0().frame_0);
			}

			// Token: 0x04001E6C RID: 7788
			public static readonly dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd.Class879 class879_0 = new dje_z2U4VFJ976E33722KXX6TXFGEZTMUX3T7ZZ6XDCSJNRTXBAQ_ejd.Class879();

			// Token: 0x04001E6D RID: 7789
			public static Action action_0;

			// Token: 0x04001E6E RID: 7790
			public static Action action_1;
		}
	}
}
