using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;

// Token: 0x02000369 RID: 873
internal sealed class Class413 : UIElement, IScrollInfo
{
	// Token: 0x06001686 RID: 5766 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
	public Class413(IScrollInfo iscrollInfo_1)
	{
		this.iscrollInfo_0 = iscrollInfo_1;
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06001688 RID: 5768 RVA: 0x0000F5C3 File Offset: 0x0000D7C3
	// (set) Token: 0x06001689 RID: 5769 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
	public bool CanVerticallyScroll
	{
		get
		{
			return this.iscrollInfo_0.CanVerticallyScroll;
		}
		set
		{
			this.iscrollInfo_0.CanVerticallyScroll = value;
		}
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x0600168A RID: 5770 RVA: 0x0000F5DE File Offset: 0x0000D7DE
	// (set) Token: 0x0600168B RID: 5771 RVA: 0x0000F5EB File Offset: 0x0000D7EB
	public bool CanHorizontallyScroll
	{
		get
		{
			return this.iscrollInfo_0.CanHorizontallyScroll;
		}
		set
		{
			this.iscrollInfo_0.CanHorizontallyScroll = value;
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x0600168C RID: 5772 RVA: 0x0000F5F9 File Offset: 0x0000D7F9
	public double ExtentWidth
	{
		get
		{
			return this.iscrollInfo_0.ExtentWidth;
		}
	}

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x0600168D RID: 5773 RVA: 0x0000F606 File Offset: 0x0000D806
	public double ExtentHeight
	{
		get
		{
			return this.iscrollInfo_0.ExtentHeight;
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x0600168E RID: 5774 RVA: 0x0000F613 File Offset: 0x0000D813
	public double ViewportWidth
	{
		get
		{
			return this.iscrollInfo_0.ViewportWidth;
		}
	}

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x0600168F RID: 5775 RVA: 0x0000F620 File Offset: 0x0000D820
	public double ViewportHeight
	{
		get
		{
			return this.iscrollInfo_0.ViewportHeight;
		}
	}

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06001690 RID: 5776 RVA: 0x0000F62D File Offset: 0x0000D82D
	public double HorizontalOffset
	{
		get
		{
			return this.iscrollInfo_0.HorizontalOffset;
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06001691 RID: 5777 RVA: 0x0000F63A File Offset: 0x0000D83A
	public double VerticalOffset
	{
		get
		{
			return this.iscrollInfo_0.VerticalOffset;
		}
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x06001692 RID: 5778 RVA: 0x0000F647 File Offset: 0x0000D847
	// (set) Token: 0x06001693 RID: 5779 RVA: 0x0000F654 File Offset: 0x0000D854
	public ScrollViewer ScrollOwner
	{
		get
		{
			return this.iscrollInfo_0.ScrollOwner;
		}
		set
		{
			this.iscrollInfo_0.ScrollOwner = value;
		}
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x0000F662 File Offset: 0x0000D862
	public Rect MakeVisible(Visual visual, Rect rectangle)
	{
		return this.iscrollInfo_0.MakeVisible(visual, rectangle);
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0000F671 File Offset: 0x0000D871
	public void LineUp()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.LineUp();
			return;
		}
		this.method_1(this.double_0 - 16.0);
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x0000F6A7 File Offset: 0x0000D8A7
	public void LineDown()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.LineDown();
			return;
		}
		this.method_1(this.double_0 + 16.0);
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0000F6DD File Offset: 0x0000D8DD
	public void LineLeft()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.LineLeft();
			return;
		}
		this.method_2(this.double_1 - 16.0);
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0000F713 File Offset: 0x0000D913
	public void LineRight()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.LineRight();
			return;
		}
		this.method_2(this.double_1 + 16.0);
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x0000F749 File Offset: 0x0000D949
	public void MouseWheelUp()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.MouseWheelUp();
			return;
		}
		this.method_1(this.double_0 - 100.0);
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x0000F77F File Offset: 0x0000D97F
	public void MouseWheelDown()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.MouseWheelDown();
			return;
		}
		this.method_1(this.double_0 + 100.0);
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x0000F7B5 File Offset: 0x0000D9B5
	public void MouseWheelLeft()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.MouseWheelLeft();
			return;
		}
		this.method_2(this.double_1 - 100.0);
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x0000F7EB File Offset: 0x0000D9EB
	public void MouseWheelRight()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.MouseWheelRight();
			return;
		}
		this.method_2(this.double_1 + 100.0);
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x0000F821 File Offset: 0x0000DA21
	public void PageUp()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.PageUp();
			return;
		}
		this.method_1(this.double_0 - this.ViewportHeight);
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x0000F854 File Offset: 0x0000DA54
	public void PageDown()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.PageDown();
			return;
		}
		this.method_1(this.double_0 + this.ViewportHeight);
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x0000F887 File Offset: 0x0000DA87
	public void PageLeft()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.PageLeft();
			return;
		}
		this.method_2(this.double_1 - this.ViewportWidth);
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x0000F8BA File Offset: 0x0000DABA
	public void PageRight()
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.PageRight();
			return;
		}
		this.method_2(this.double_1 + this.ViewportWidth);
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x0000F8ED File Offset: 0x0000DAED
	public void SetHorizontalOffset(double offset)
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.SetHorizontalOffset(offset);
			return;
		}
		this.double_1 = offset;
		this.method_0(Class413.dependencyProperty_1, offset, 0);
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x0000F922 File Offset: 0x0000DB22
	public void SetVerticalOffset(double offset)
	{
		if (this.iscrollInfo_0.ScrollOwner.CanContentScroll)
		{
			this.iscrollInfo_0.SetVerticalOffset(offset);
			return;
		}
		this.double_0 = offset;
		this.method_0(Class413.dependencyProperty_0, offset, 0);
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x00067194 File Offset: 0x00065394
	private void method_0(DependencyProperty dependencyProperty_2, double double_2, int int_0)
	{
		if (Class551.class753_0.method_52().GetValueOrDefault())
		{
			int_0 = 0;
		}
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
		{
			Duration = TimeSpan.FromMilliseconds((double)int_0)
		};
		doubleAnimationUsingKeyFrames.KeyFrames.Add(new SplineDoubleKeyFrame(double_2, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds((double)int_0)), new KeySpline(0.25, 0.1, 0.25, 1.0)));
		base.BeginAnimation(dependencyProperty_2, doubleAnimationUsingKeyFrames);
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x00067224 File Offset: 0x00065424
	private void method_1(double double_2)
	{
		if (Math.Abs(this.double_0 - this.method_3(double_2)) > 0.1)
		{
			this.double_0 = this.method_3(double_2);
			this.method_0(Class413.dependencyProperty_0, this.double_0, 300);
		}
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x00067274 File Offset: 0x00065474
	private void method_2(double double_2)
	{
		if (Math.Abs(this.double_1 - this.method_4(double_2)) > 0.1)
		{
			this.double_1 = this.method_4(double_2);
			this.method_0(Class413.dependencyProperty_1, this.double_1, 300);
		}
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x0000F957 File Offset: 0x0000DB57
	private double method_3(double double_2)
	{
		if (double_2 < 0.0)
		{
			return 0.0;
		}
		if (double_2 > this.iscrollInfo_0.ScrollOwner.ScrollableHeight)
		{
			return this.iscrollInfo_0.ScrollOwner.ScrollableHeight;
		}
		return double_2;
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x0000F994 File Offset: 0x0000DB94
	private double method_4(double double_2)
	{
		if (double_2 < 0.0)
		{
			return 0.0;
		}
		if (double_2 > this.iscrollInfo_0.ScrollOwner.ScrollableWidth)
		{
			return this.iscrollInfo_0.ScrollOwner.ScrollableWidth;
		}
		return double_2;
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x060016A8 RID: 5800 RVA: 0x0000F9D1 File Offset: 0x0000DBD1
	// (set) Token: 0x060016A9 RID: 5801 RVA: 0x0000F9E3 File Offset: 0x0000DBE3
	internal double VerticalScrollOffset
	{
		get
		{
			return (double)base.GetValue(Class413.dependencyProperty_0);
		}
		set
		{
			base.SetValue(Class413.dependencyProperty_0, value);
		}
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x0000F9F6 File Offset: 0x0000DBF6
	private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		((Class413)dependencyObject_0).iscrollInfo_0.SetVerticalOffset((double)dependencyPropertyChangedEventArgs_0.NewValue);
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x060016AB RID: 5803 RVA: 0x0000FA14 File Offset: 0x0000DC14
	// (set) Token: 0x060016AC RID: 5804 RVA: 0x0000FA26 File Offset: 0x0000DC26
	internal double HorizontalScrollOffset
	{
		get
		{
			return (double)base.GetValue(Class413.dependencyProperty_1);
		}
		set
		{
			base.SetValue(Class413.dependencyProperty_1, value);
		}
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x0000FA39 File Offset: 0x0000DC39
	private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		((Class413)dependencyObject_0).iscrollInfo_0.SetHorizontalOffset((double)dependencyPropertyChangedEventArgs_0.NewValue);
	}

	// Token: 0x04000EE3 RID: 3811
	private IScrollInfo iscrollInfo_0;

	// Token: 0x04000EE4 RID: 3812
	private double double_0;

	// Token: 0x04000EE5 RID: 3813
	private double double_1;

	// Token: 0x04000EE6 RID: 3814
	internal static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("VerticalScrollOffset", typeof(double), typeof(Class413), new PropertyMetadata(0.0, new PropertyChangedCallback(Class413.smethod_0)));

	// Token: 0x04000EE7 RID: 3815
	internal static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.Register("HorizontalScrollOffset", typeof(double), typeof(Class413), new PropertyMetadata(0.0, new PropertyChangedCallback(Class413.smethod_1)));
}
