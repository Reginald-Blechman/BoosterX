using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ns0
{
	// Token: 0x0200081D RID: 2077
	public sealed class dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd : UserControl, IComponentConnector
	{
		// Token: 0x060031EC RID: 12780 RVA: 0x0001F6A3 File Offset: 0x0001D8A3
		public dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd_Loaded;
			this.grid_0.SizeChanged += this.grid_0_SizeChanged;
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x0001F6DA File Offset: 0x0001D8DA
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x0001F6EC File Offset: 0x0001D8EC
		public double BatteryLevel
		{
			get
			{
				return (double)base.GetValue(dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd.dependencyProperty_0);
			}
			set
			{
				base.SetValue(dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd.dependencyProperty_0, value);
			}
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x000C1A78 File Offset: 0x000BFC78
		private void method_0(object sender, EventArgs e)
		{
			if (this.window_0 == null)
			{
				return;
			}
			double num = this.window_0.Left - this.double_0;
			this.double_0 = this.window_0.Left;
			if (Math.Abs(num) < 0.5)
			{
				return;
			}
			double val = num;
			double double_ = Math.Max(-10.0, Math.Min(10.0, val));
			this.method_2(double_);
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0001F6FF File Offset: 0x0001D8FF
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			((dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd)dependencyObject_0).method_1((double)dependencyPropertyChangedEventArgs_0.NewValue);
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x000C1AEC File Offset: 0x000BFCEC
		private void method_1(double double_1)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_37(this.textBlock_0, double_1);
			double num = Math.Max(0.0, this.grid_0.ActualHeight - 24.0) * Math.Min(Math.Max(double_1, 0.0), 100.0) / 100.0;
			num = ((num < 20.0) ? 20.0 : num);
			DoubleAnimation animation = new DoubleAnimation
			{
				To = new double?(num),
				Duration = TimeSpan.FromMilliseconds(2500.0),
				EasingFunction = new QuadraticEase
				{
					EasingMode = EasingMode.EaseOut
				}
			};
			this.border_2.BeginAnimation(FrameworkElement.HeightProperty, animation);
			if (double_1 < 6.0)
			{
				((Storyboard)base.FindResource("AnimateLevelStrokeGreen2")).Begin(this.border_0);
				((Storyboard)base.FindResource("AnimateLevelBackgroundGreen2")).Begin(this.border_1);
				((Storyboard)base.FindResource("AnimateLevelBackgroundGreen")).Begin(this.border_2);
				return;
			}
			if (double_1 < 15.0)
			{
				((Storyboard)base.FindResource("AnimateLevelStrokeYellow")).Begin(this.border_0);
				((Storyboard)base.FindResource("AnimateLevelBackgroundYellow")).Begin(this.border_1);
				((Storyboard)base.FindResource("AnimateLevelBackgroundYellow")).Begin(this.border_2);
				return;
			}
			((Storyboard)base.FindResource("AnimateLevelStrokeRed")).Begin(this.border_0);
			((Storyboard)base.FindResource("AnimateLevelBackgroundRed")).Begin(this.border_1);
			((Storyboard)base.FindResource("AnimateLevelBackgroundRed")).Begin(this.border_2);
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000C1CD0 File Offset: 0x000BFED0
		private void method_2(double double_1)
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation
			{
				To = new double?(double_1),
				Duration = TimeSpan.FromMilliseconds(200.0),
				EasingFunction = new QuadraticEase
				{
					EasingMode = EasingMode.EaseOut
				}
			};
			DoubleAnimation doubleAnimation2 = new DoubleAnimation
			{
				To = new double?(0.0),
				BeginTime = new TimeSpan?(TimeSpan.FromMilliseconds(201.0)),
				Duration = TimeSpan.FromMilliseconds(800.0),
				EasingFunction = new ExponentialEase
				{
					EasingMode = EasingMode.EaseOut
				}
			};
			Storyboard storyboard = new Storyboard();
			storyboard.Children.Add(doubleAnimation);
			storyboard.Children.Add(doubleAnimation2);
			Storyboard.SetTarget(doubleAnimation, this.skewTransform_0);
			Storyboard.SetTarget(doubleAnimation2, this.skewTransform_0);
			Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(SkewTransform.AngleYProperty));
			Storyboard.SetTargetProperty(doubleAnimation2, new PropertyPath(SkewTransform.AngleYProperty));
			storyboard.Begin();
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000C1DD4 File Offset: 0x000BFFD4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/firstanalyze/pages/famain/usercontrols/batteryuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x000C1E08 File Offset: 0x000C0008
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
				this.border_0 = (Border)target;
				return;
			case 3:
				this.border_1 = (Border)target;
				return;
			case 4:
				this.border_2 = (Border)target;
				return;
			case 5:
				this.skewTransform_0 = (SkewTransform)target;
				return;
			case 6:
				this.textBlock_0 = (TextBlock)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0001F718 File Offset: 0x0001D918
		private void dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			this.method_1(this.BatteryLevel);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0001F718 File Offset: 0x0001D918
		private void grid_0_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			this.method_1(this.BatteryLevel);
		}

		// Token: 0x040022F4 RID: 8948
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("BatteryLevel", typeof(double), typeof(dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd), new PropertyMetadata(0.0, new PropertyChangedCallback(dje_zH7SBHE869SWB4CTH5A3Q99ANXY3X7WCCU63XWP78ZCSCE5E2URD3YZ4FJETTBPND5PKZQJUQACVJ4XWYBWRTV_ejd.smethod_0)));

		// Token: 0x040022F5 RID: 8949
		private double double_0;

		// Token: 0x040022F6 RID: 8950
		private Window window_0;

		// Token: 0x040022F7 RID: 8951
		internal Grid grid_0;

		// Token: 0x040022F8 RID: 8952
		internal Border border_0;

		// Token: 0x040022F9 RID: 8953
		internal Border border_1;

		// Token: 0x040022FA RID: 8954
		internal Border border_2;

		// Token: 0x040022FB RID: 8955
		internal SkewTransform skewTransform_0;

		// Token: 0x040022FC RID: 8956
		internal TextBlock textBlock_0;

		// Token: 0x040022FD RID: 8957
		private bool bool_0;
	}
}
