using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Navigation;

namespace ns0
{
	// Token: 0x0200083D RID: 2109
	public sealed class dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd : Window, IComponentConnector
	{
		// Token: 0x0600328D RID: 12941 RVA: 0x000C36E4 File Offset: 0x000C18E4
		public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd(Type type_0 = null)
		{
			if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule.FileName)).Count<Process>() > 1)
			{
				Process.GetCurrentProcess().Kill();
			}
			this.InitializeComponent();
			Class374.smethod_0().method_0(new Class374.Delegate27(this.method_0));
			Class406.smethod_0().frame_0 = this.frame_0;
			base.DataContext = new Class483();
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_16(new dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.GDelegate4(this.method_1));
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_14(new dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.GDelegate5(this.method_2));
			if (!Class551.class753_0.method_90().GetValueOrDefault())
			{
				this.grid_2.Opacity = 0.0;
				this.grid_2.Visibility = Visibility.Collapsed;
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(this.grid_3);
				return;
			}
			if (type_0 == null)
			{
				this.radioButton_0.IsChecked = new bool?(true);
				return;
			}
			if (type_0 == typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd))
			{
				Class406.smethod_0().method_4(typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd), this.frame_0);
				return;
			}
			if (type_0 == typeof(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd))
			{
				Class406.smethod_0().method_4(typeof(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd), this.frame_0);
			}
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000C3830 File Offset: 0x000C1A30
		private void method_0(CultureInfo cultureInfo_0)
		{
			FlowDirection flowDirection = Class374.smethod_0().method_2();
			base.FlowDirection = flowDirection;
			Page page = this.frame_0.Content as Page;
			if (page != null)
			{
				page.FlowDirection = flowDirection;
			}
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000C386C File Offset: 0x000C1A6C
		private void method_1()
		{
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct642 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct642>(ref @struct);
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000C38A4 File Offset: 0x000C1AA4
		private void method_2()
		{
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct643 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct643>(ref @struct);
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000C38DC File Offset: 0x000C1ADC
		public void method_3()
		{
			double primaryScreenWidth = SystemParameters.PrimaryScreenWidth;
			double primaryScreenHeight = SystemParameters.PrimaryScreenHeight;
			double width = base.Width;
			double height = base.Height;
			base.Left = primaryScreenWidth / 2.0 - width / 2.0;
			base.Top = primaryScreenHeight / 2.0 - height / 2.0;
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000C3940 File Offset: 0x000C1B40
		private void method_4(object sender, RoutedEventArgs e)
		{
			if (!Class551.class753_0.method_24().smethod_5() && !Class551.class753_0.method_26().smethod_5() && !Class551.class753_0.Height.smethod_5() && !Class551.class753_0.Width.smethod_5())
			{
				base.Top = Class551.class753_0.method_24().Value;
				base.Left = Class551.class753_0.method_26().Value;
				base.Height = Class551.class753_0.Height.Value;
				base.Width = Class551.class753_0.Width.Value;
			}
			this.bool_1 = true;
			if (Class551.class753_0.method_28().GetValueOrDefault())
			{
				this.button_3_Click(sender, e);
			}
			if (base.WindowState == WindowState.Minimized)
			{
				base.WindowState = WindowState.Normal;
			}
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000C3A30 File Offset: 0x000C1C30
		public void button_4_Click(object sender, RoutedEventArgs e)
		{
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct644 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct644>(ref @struct);
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000C3A68 File Offset: 0x000C1C68
		private void method_5()
		{
			try
			{
				Class480.smethod_3();
			}
			catch
			{
			}
			try
			{
				Class323.smethod_1();
			}
			catch
			{
			}
			Class834.smethod_0();
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x0001FBD1 File Offset: 0x0001DDD1
		private void method_6(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x0001FBD1 File Offset: 0x0001DDD1
		private void method_7(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0001FBE2 File Offset: 0x0001DDE2
		private void method_8(object sender, EventArgs e)
		{
			this.button_4_Click(null, null);
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x0001FBEC File Offset: 0x0001DDEC
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000C3AAC File Offset: 0x000C1CAC
		private void method_9(object sender, SizeChangedEventArgs e)
		{
			if (base.Width == 1072.0 && this.bool_0)
			{
				this.bool_0 = false;
			}
			this.method_16();
			this.rectangleGeometry_0.Rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
			if (this.bool_0)
			{
				this.rectangleGeometry_0.RadiusX = 0.0;
				this.rectangleGeometry_0.RadiusY = 0.0;
			}
			else
			{
				this.rectangleGeometry_0.RadiusX = 20.0;
				this.rectangleGeometry_0.RadiusY = 20.0;
			}
			if (this.bool_1)
			{
				Class551.class753_0.Height = new double?(base.ActualHeight);
				Class551.class753_0.Width = new double?(base.ActualWidth);
			}
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x0001FBF5 File Offset: 0x0001DDF5
		private void method_10(object sender, EventArgs e)
		{
			if (this.bool_1)
			{
				Class551.class753_0.method_25(new double?(base.Top));
				Class551.class753_0.method_27(new double?(base.Left));
			}
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000C3B9C File Offset: 0x000C1D9C
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			if (this.bool_0)
			{
				base.IsEnabled = false;
				base.WindowState = WindowState.Normal;
				base.IsEnabled = true;
				base.Width = 1072.0;
				base.Height = 754.0;
				this.bool_0 = false;
			}
			else
			{
				base.WindowState = WindowState.Maximized;
				this.bool_0 = true;
			}
			if (this.bool_1)
			{
				Class551.class753_0.method_29(new bool?(base.WindowState == WindowState.Maximized));
			}
			this.method_16();
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x0001FC29 File Offset: 0x0001DE29
		private void grid_2_MouseEnter(object sender, MouseEventArgs e)
		{
			if (base.ActualWidth <= 1500.0)
			{
				this.method_14();
				this.method_11();
				this.method_17();
			}
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0001FC4E File Offset: 0x0001DE4E
		private void grid_2_MouseLeave(object sender, MouseEventArgs e)
		{
			if (base.ActualWidth <= 1500.0)
			{
				this.method_13();
				this.method_12();
				this.method_18();
			}
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000C3C24 File Offset: 0x000C1E24
		private void method_11()
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				Duration = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0,
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5,
				To = new double?(0.5)
			};
			Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
			this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
			DoubleAnimation doubleAnimation2 = new DoubleAnimation
			{
				Duration = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0,
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5,
				To = new double?((double)1f)
			};
			Timeline.SetDesiredFrameRate(doubleAnimation2, new int?(60));
			this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_1.BeginAnimation(UIElement.OpacityProperty, doubleAnimation2);
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000C3CFC File Offset: 0x000C1EFC
		private void method_12()
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				Duration = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0,
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5,
				To = new double?(0.0)
			};
			Timeline.SetDesiredFrameRate(doubleAnimation, new int?(60));
			this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
			this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_1.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000C3D80 File Offset: 0x000C1F80
		private void method_13()
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.grid_2, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 100.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.border_1, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 100.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 100.0);
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000C3DF8 File Offset: 0x000C1FF8
		private void method_14()
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.grid_2, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 230.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.border_1, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 230.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 310.0);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000C3E70 File Offset: 0x000C2070
		private void method_15()
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.grid_2, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 230.0);
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.border_1, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 230.0);
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000C3EC4 File Offset: 0x000C20C4
		private void method_16()
		{
			if (base.ActualWidth <= 1500.0)
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.border_0, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 140.0);
				this.method_13();
				this.method_18();
				return;
			}
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_38(this.border_0, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.timeSpan_0, FrameworkElement.WidthProperty, 270.0);
			this.method_15();
			this.method_17();
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x0001FC73 File Offset: 0x0001DE73
		private void method_17()
		{
			if (this.storyboard_0 == null)
			{
				this.storyboard_0 = (Storyboard)base.FindResource("GoVisibleWithVisibility");
			}
			base.Dispatcher.Invoke(new Action(this.method_26));
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x0001FCAB File Offset: 0x0001DEAB
		private void method_18()
		{
			if (this.storyboard_1 == null)
			{
				this.storyboard_1 = (Storyboard)base.FindResource("GoDarkWithVisibility");
			}
			base.Dispatcher.Invoke(new Action(this.method_27));
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x0001FCE3 File Offset: 0x0001DEE3
		private void radioButton_0_Checked(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd), this.frame_0);
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x0001FCFF File Offset: 0x0001DEFF
		private void radioButton_1_Checked(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_z2SW9K68CZJT7BJDWKSPPNMQ44RNJ2KLKFHD9DFWKM3TQCW5SKPUBPRE6E4DQ_ejd), this.frame_0);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x0000311B File Offset: 0x0000131B
		private void radioButton_4_Checked(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x0001FD1B File Offset: 0x0001DF1B
		private void radioButton_3_Checked(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd), this.frame_0);
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x0001FD37 File Offset: 0x0001DF37
		private void radioButton_6_Checked(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zJ9NUKRLGXC7JDT9ZUAF84NEVZ6WFZLVPU4EHJ856D2FJFNCVR2P34_ejd), this.frame_0);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x0001FD53 File Offset: 0x0001DF53
		private void radioButton_7_Checked(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zWT2KUZCDV7SNNFXMRLPD6XNJYLB3P7H4UXDGKCFV223H5EQ_ejd), this.frame_0);
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x0001FD6F File Offset: 0x0001DF6F
		private void radioButton_2_Checked(object sender, RoutedEventArgs e)
		{
			if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_22)
			{
				return;
			}
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), this.frame_0);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x0001FD93 File Offset: 0x0001DF93
		private void radioButton_5_Checked(object sender, RoutedEventArgs e)
		{
			Class406.smethod_0().method_4(typeof(dje_zNSNRFVQUMVAUHL755A6AUDYMMNJH23EVJCGPYZ2RUJFWZZTMJCPX4_ejd), this.frame_0);
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0000311B File Offset: 0x0000131B
		private void method_19(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000C3F44 File Offset: 0x000C2144
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct645 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct645>(ref @struct);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0001FDAF File Offset: 0x0001DFAF
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://boosterx.org/useragreement");
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000C3F7C File Offset: 0x000C217C
		public void method_20()
		{
			BlurEffect effect = new BlurEffect
			{
				KernelType = KernelType.Gaussian,
				RenderingBias = RenderingBias.Quality,
				Radius = 0.0
			};
			this.grid_0.Effect = effect;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x0001FDBD File Offset: 0x0001DFBD
		public void method_21()
		{
			this.grid_0.Effect = null;
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0001FDCB File Offset: 0x0001DFCB
		private void method_22(object sender, NavigatingCancelEventArgs e)
		{
			if (e.Uri != null)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0001FDE2 File Offset: 0x0001DFE2
		private void method_23(object sender, RoutedEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0001FDEB File Offset: 0x0001DFEB
		public void method_24(bool bool_3)
		{
			this.bool_0 = bool_3;
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x000C3FB8 File Offset: 0x000C21B8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_25(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x000C3FEC File Offset: 0x000C21EC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)target).Closed += this.method_8;
				((dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)target).Loaded += this.method_4;
				((dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)target).LocationChanged += this.method_10;
				((dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)target).SizeChanged += this.method_9;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				return;
			case 3:
				this.rectangleGeometry_0 = (RectangleGeometry)target;
				return;
			case 4:
				this.grid_1 = (Grid)target;
				return;
			case 5:
				this.border_0 = (Border)target;
				return;
			case 6:
				this.frame_0 = (Frame)target;
				this.frame_0.AddHandler(Hyperlink.ClickEvent, new RoutedEventHandler(this.method_23));
				return;
			case 7:
				this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0 = (dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd)target;
				return;
			case 8:
				this.grid_2 = (Grid)target;
				this.grid_2.MouseEnter += this.grid_2_MouseEnter;
				this.grid_2.MouseLeave += this.grid_2_MouseLeave;
				return;
			case 9:
				this.dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_1 = (dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd)target;
				return;
			case 10:
				this.border_1 = (Border)target;
				return;
			case 11:
				this.radioButton_0 = (RadioButton)target;
				this.radioButton_0.Checked += this.radioButton_0_Checked;
				return;
			case 12:
				this.geometryDrawing_0 = (GeometryDrawing)target;
				return;
			case 13:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 14:
				this.radioButton_1 = (RadioButton)target;
				this.radioButton_1.Checked += this.radioButton_1_Checked;
				return;
			case 15:
				this.geometryDrawing_1 = (GeometryDrawing)target;
				return;
			case 16:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 17:
				this.radioButton_2 = (RadioButton)target;
				this.radioButton_2.Checked += this.radioButton_2_Checked;
				return;
			case 18:
				this.geometryDrawing_2 = (GeometryDrawing)target;
				return;
			case 19:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 20:
				this.radioButton_3 = (RadioButton)target;
				this.radioButton_3.Checked += this.radioButton_3_Checked;
				return;
			case 21:
				this.geometryDrawing_3 = (GeometryDrawing)target;
				return;
			case 22:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 23:
				this.radioButton_4 = (RadioButton)target;
				this.radioButton_4.Checked += this.radioButton_4_Checked;
				return;
			case 24:
				this.geometryDrawing_4 = (GeometryDrawing)target;
				return;
			case 25:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 26:
				this.radioButton_5 = (RadioButton)target;
				this.radioButton_5.Checked += this.radioButton_5_Checked;
				return;
			case 27:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 28:
				this.radioButton_6 = (RadioButton)target;
				this.radioButton_6.Checked += this.radioButton_6_Checked;
				return;
			case 29:
				this.geometryDrawing_5 = (GeometryDrawing)target;
				return;
			case 30:
				this.textBlock_6 = (TextBlock)target;
				return;
			case 31:
				this.radioButton_7 = (RadioButton)target;
				this.radioButton_7.Checked += this.radioButton_7_Checked;
				return;
			case 32:
				this.geometryDrawing_6 = (GeometryDrawing)target;
				return;
			case 33:
				this.textBlock_7 = (TextBlock)target;
				return;
			case 34:
				this.textBlock_8 = (TextBlock)target;
				return;
			case 35:
				this.grid_3 = (Grid)target;
				return;
			case 36:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 37:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 38:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 39:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 40:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 41:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			default:
				this.bool_2 = true;
				return;
			}
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000C4488 File Offset: 0x000C2688
		private void method_26()
		{
			this.storyboard_0.Begin(this.textBlock_0);
			this.storyboard_0.Begin(this.textBlock_1);
			this.storyboard_0.Begin(this.textBlock_4);
			this.storyboard_0.Begin(this.textBlock_6);
			this.storyboard_0.Begin(this.textBlock_7);
			this.storyboard_0.Begin(this.textBlock_2);
			this.storyboard_0.Begin(this.textBlock_3);
			this.storyboard_0.Begin(this.textBlock_5);
			this.storyboard_0.Begin(this.textBlock_8);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x000C4530 File Offset: 0x000C2730
		private void method_27()
		{
			this.storyboard_1.Begin(this.textBlock_0);
			this.storyboard_1.Begin(this.textBlock_1);
			this.storyboard_1.Begin(this.textBlock_4);
			this.storyboard_1.Begin(this.textBlock_6);
			this.storyboard_1.Begin(this.textBlock_7);
			this.storyboard_1.Begin(this.textBlock_2);
			this.storyboard_1.Begin(this.textBlock_3);
			this.storyboard_1.Begin(this.textBlock_5);
			this.storyboard_1.Begin(this.textBlock_8);
		}

		// Token: 0x04002380 RID: 9088
		private bool bool_0;

		// Token: 0x04002381 RID: 9089
		private bool bool_1;

		// Token: 0x04002382 RID: 9090
		private Storyboard storyboard_0;

		// Token: 0x04002383 RID: 9091
		private Storyboard storyboard_1;

		// Token: 0x04002384 RID: 9092
		internal Grid grid_0;

		// Token: 0x04002385 RID: 9093
		internal RectangleGeometry rectangleGeometry_0;

		// Token: 0x04002386 RID: 9094
		internal Grid grid_1;

		// Token: 0x04002387 RID: 9095
		internal Border border_0;

		// Token: 0x04002388 RID: 9096
		internal Frame frame_0;

		// Token: 0x04002389 RID: 9097
		internal dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_0;

		// Token: 0x0400238A RID: 9098
		internal Grid grid_2;

		// Token: 0x0400238B RID: 9099
		internal dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd dje_zXHSBQ299M77JP3K675LVNUVH6M8RJ49TEWJHTYLWVDM9MAQ_ejd_1;

		// Token: 0x0400238C RID: 9100
		internal Border border_1;

		// Token: 0x0400238D RID: 9101
		internal RadioButton radioButton_0;

		// Token: 0x0400238E RID: 9102
		internal GeometryDrawing geometryDrawing_0;

		// Token: 0x0400238F RID: 9103
		internal TextBlock textBlock_0;

		// Token: 0x04002390 RID: 9104
		internal RadioButton radioButton_1;

		// Token: 0x04002391 RID: 9105
		internal GeometryDrawing geometryDrawing_1;

		// Token: 0x04002392 RID: 9106
		internal TextBlock textBlock_1;

		// Token: 0x04002393 RID: 9107
		internal RadioButton radioButton_2;

		// Token: 0x04002394 RID: 9108
		internal GeometryDrawing geometryDrawing_2;

		// Token: 0x04002395 RID: 9109
		internal TextBlock textBlock_2;

		// Token: 0x04002396 RID: 9110
		internal RadioButton radioButton_3;

		// Token: 0x04002397 RID: 9111
		internal GeometryDrawing geometryDrawing_3;

		// Token: 0x04002398 RID: 9112
		internal TextBlock textBlock_3;

		// Token: 0x04002399 RID: 9113
		internal RadioButton radioButton_4;

		// Token: 0x0400239A RID: 9114
		internal GeometryDrawing geometryDrawing_4;

		// Token: 0x0400239B RID: 9115
		internal TextBlock textBlock_4;

		// Token: 0x0400239C RID: 9116
		internal RadioButton radioButton_5;

		// Token: 0x0400239D RID: 9117
		internal TextBlock textBlock_5;

		// Token: 0x0400239E RID: 9118
		internal RadioButton radioButton_6;

		// Token: 0x0400239F RID: 9119
		internal GeometryDrawing geometryDrawing_5;

		// Token: 0x040023A0 RID: 9120
		internal TextBlock textBlock_6;

		// Token: 0x040023A1 RID: 9121
		internal RadioButton radioButton_7;

		// Token: 0x040023A2 RID: 9122
		internal GeometryDrawing geometryDrawing_6;

		// Token: 0x040023A3 RID: 9123
		internal TextBlock textBlock_7;

		// Token: 0x040023A4 RID: 9124
		internal TextBlock textBlock_8;

		// Token: 0x040023A5 RID: 9125
		internal Grid grid_3;

		// Token: 0x040023A6 RID: 9126
		internal Button button_0;

		// Token: 0x040023A7 RID: 9127
		internal Button button_1;

		// Token: 0x040023A8 RID: 9128
		public StackPanel stackPanel_0;

		// Token: 0x040023A9 RID: 9129
		internal Button button_2;

		// Token: 0x040023AA RID: 9130
		internal Button button_3;

		// Token: 0x040023AB RID: 9131
		internal Button button_4;

		// Token: 0x040023AC RID: 9132
		private bool bool_2;

		// Token: 0x0200083E RID: 2110
		[StructLayout(LayoutKind.Auto)]
		private struct Struct642 : IAsyncStateMachine
		{
			// Token: 0x060032BB RID: 12987 RVA: 0x000C45D8 File Offset: 0x000C27D8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Class935 @class = new dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Class935();
						@class.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 = this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
						@class.string_0 = Class298.smethod_2("Checkingtext");
						awaiter = dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Dispatcher.InvokeAsync(new Action(@class.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct642>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060032BC RID: 12988 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023AD RID: 9133
			public int int_0;

			// Token: 0x040023AE RID: 9134
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023AF RID: 9135
			public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;

			// Token: 0x040023B0 RID: 9136
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200083F RID: 2111
		private sealed class Class935
		{
			// Token: 0x060032BE RID: 12990 RVA: 0x0001FE02 File Offset: 0x0001E002
			internal void method_0()
			{
				this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0.textBlock_8.Text = this.string_0;
			}

			// Token: 0x040023B1 RID: 9137
			public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;

			// Token: 0x040023B2 RID: 9138
			public string string_0;
		}

		// Token: 0x02000840 RID: 2112
		[StructLayout(LayoutKind.Auto)]
		private struct Struct643 : IAsyncStateMachine
		{
			// Token: 0x060032BF RID: 12991 RVA: 0x000C46C0 File Offset: 0x000C28C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_130;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_19E;
					default:
						this.class936_0 = new dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Class936();
						this.class936_0.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 = this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
						this.class936_0.double_0 = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.double_0;
						if (this.class936_0.double_0 < 0.0)
						{
							awaiter = dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Dispatcher.InvokeAsync(new Action(this.class936_0.method_0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct643>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = Task.Delay(3000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct643>(ref awaiter, ref this);
								return;
							}
							goto IL_130;
						}
						break;
					}
					awaiter.GetResult();
					goto IL_1A5;
					IL_130:
					awaiter.GetResult();
					awaiter = dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Dispatcher.InvokeAsync(new Action(this.class936_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct643>(ref awaiter, ref this);
						return;
					}
					IL_19E:
					awaiter.GetResult();
					IL_1A5:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class936_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class936_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060032C0 RID: 12992 RVA: 0x0001FE1A File Offset: 0x0001E01A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023B3 RID: 9139
			public int int_0;

			// Token: 0x040023B4 RID: 9140
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023B5 RID: 9141
			public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;

			// Token: 0x040023B6 RID: 9142
			private dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Class936 class936_0;

			// Token: 0x040023B7 RID: 9143
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000841 RID: 2113
		[StructLayout(LayoutKind.Auto)]
		private struct Struct644 : IAsyncStateMachine
		{
			// Token: 0x060032C1 RID: 12993 RVA: 0x000C48C8 File Offset: 0x000C2AC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.method_5();
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd, 300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct644>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					Application.Current.Shutdown();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060032C2 RID: 12994 RVA: 0x0001FE28 File Offset: 0x0001E028
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023B8 RID: 9144
			public int int_0;

			// Token: 0x040023B9 RID: 9145
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023BA RID: 9146
			public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;

			// Token: 0x040023BB RID: 9147
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000842 RID: 2114
		private sealed class Class936
		{
			// Token: 0x060032C4 RID: 12996 RVA: 0x0001FE36 File Offset: 0x0001E036
			internal void method_0()
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0.textBlock_8, Class298.smethod_2("unknowserror"), null);
			}

			// Token: 0x060032C5 RID: 12997 RVA: 0x0001FE54 File Offset: 0x0001E054
			internal void method_1()
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_36(this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0.textBlock_8, this.double_0);
			}

			// Token: 0x040023BC RID: 9148
			public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;

			// Token: 0x040023BD RID: 9149
			public double double_0;
		}

		// Token: 0x02000843 RID: 2115
		[StructLayout(LayoutKind.Auto)]
		private struct Struct645 : IAsyncStateMachine
		{
			// Token: 0x060032C6 RID: 12998 RVA: 0x000C4990 File Offset: 0x000C2B90
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_EF;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_151;
					default:
						Class551.class753_0.method_91(new bool?(true));
						dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_4();
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.grid_3, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct645>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct645>(ref awaiter, ref this);
						return;
					}
					IL_EF:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.grid_2, 200).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Struct645>(ref awaiter, ref this);
						return;
					}
					IL_151:
					awaiter.GetResult();
					dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.radioButton_0.IsChecked = new bool?(true);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060032C7 RID: 12999 RVA: 0x0001FE6C File Offset: 0x0001E06C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040023BE RID: 9150
			public int int_0;

			// Token: 0x040023BF RID: 9151
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040023C0 RID: 9152
			public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;

			// Token: 0x040023C1 RID: 9153
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
