using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

// Token: 0x0200068E RID: 1678
[Attribute11(1)]
[Attribute10(0)]
public sealed class GClass289 : Border
{
	// Token: 0x06002A64 RID: 10852 RVA: 0x000A3824 File Offset: 0x000A1A24
	protected override Geometry GetLayoutClip(Size layoutSlotSize)
	{
		if (this.ClipContent && layoutSlotSize.Width > 0.0 && layoutSlotSize.Height > 0.0)
		{
			Rect rect_ = new Rect(0.0, 0.0, layoutSlotSize.Width, layoutSlotSize.Height);
			Geometry geometry = this.vmethod_0(rect_, base.CornerRadius, this.CornerSmoothing);
			if (geometry.CanFreeze)
			{
				geometry.Freeze();
			}
			return geometry;
		}
		return base.GetLayoutClip(layoutSlotSize);
	}

	// Token: 0x170006F9 RID: 1785
	// (get) Token: 0x06002A65 RID: 10853 RVA: 0x0001B960 File Offset: 0x00019B60
	// (set) Token: 0x06002A66 RID: 10854 RVA: 0x0001B972 File Offset: 0x00019B72
	[TypeConverter(typeof(DoubleConverter))]
	public double CornerSmoothing
	{
		get
		{
			return (double)base.GetValue(GClass289.dependencyProperty_0);
		}
		set
		{
			base.SetValue(GClass289.dependencyProperty_0, value);
		}
	}

	// Token: 0x170006FA RID: 1786
	// (get) Token: 0x06002A67 RID: 10855 RVA: 0x0001B985 File Offset: 0x00019B85
	// (set) Token: 0x06002A68 RID: 10856 RVA: 0x0001B997 File Offset: 0x00019B97
	public bool ClipContent
	{
		get
		{
			return (bool)base.GetValue(GClass289.dependencyProperty_1);
		}
		set
		{
			base.SetValue(GClass289.dependencyProperty_1, value);
		}
	}

	// Token: 0x06002A69 RID: 10857 RVA: 0x000A38B0 File Offset: 0x000A1AB0
	protected override Size MeasureOverride(Size constraint)
	{
		double width = double.IsNaN(base.Width) ? constraint.Width : base.Width;
		double height = double.IsNaN(base.Height) ? constraint.Height : base.Height;
		Size size = new Size(width, height);
		if (this.Child == null)
		{
			return new Size(double.IsNaN(base.Width) ? 0.0 : base.Width, double.IsNaN(base.Height) ? 0.0 : base.Height);
		}
		Size size2 = base.Padding.smethod_0();
		Size size3 = base.BorderThickness.smethod_0();
		Size availableSize = new Size(Math.Max(0.0, size.Width - size2.Width - size3.Width), Math.Max(0.0, size.Height - size2.Height - size3.Height));
		this.Child.Measure(availableSize);
		Size desiredSize = this.Child.DesiredSize;
		Size size4 = new Size(desiredSize.Width + size2.Width + size3.Width, desiredSize.Height + size2.Height + size3.Height);
		return new Size(double.IsNaN(base.Width) ? size4.Width : base.Width, double.IsNaN(base.Height) ? size4.Height : base.Height);
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x000A3A40 File Offset: 0x000A1C40
	protected override Size ArrangeOverride(Size arrangeSize)
	{
		if (this.Child != null)
		{
			Rect finalRect = new Rect(arrangeSize).smethod_1(base.Padding).smethod_1(base.BorderThickness);
			this.Child.Arrange(finalRect);
		}
		if (arrangeSize.Width > 0.0 && arrangeSize.Height > 0.0)
		{
			Rect rect_ = new Rect(arrangeSize);
			this.geometry_0 = this.vmethod_0(rect_, base.CornerRadius, this.CornerSmoothing);
			if (this.geometry_0.CanFreeze)
			{
				this.geometry_0.Freeze();
			}
		}
		else
		{
			this.geometry_0 = null;
		}
		return arrangeSize;
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x0001B9AA File Offset: 0x00019BAA
	protected Geometry vmethod_0(Rect rect_0, CornerRadius cornerRadius_0, double double_0)
	{
		Geometry geometry = GClass212.smethod_0(rect_0.Width, rect_0.Height, cornerRadius_0.TopLeft, double_0);
		geometry.Freeze();
		return geometry;
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x000A3AE8 File Offset: 0x000A1CE8
	protected override void OnRender(DrawingContext dc)
	{
		if (this.geometry_0 == null)
		{
			return;
		}
		if (base.Background != null)
		{
			dc.DrawGeometry(base.Background, null, this.geometry_0);
		}
		if (base.BorderBrush != null && base.BorderThickness.Top > 0.0)
		{
			Pen pen = new Pen(base.BorderBrush, base.BorderThickness.Top)
			{
				LineJoin = PenLineJoin.Round
			};
			if (pen.CanFreeze)
			{
				pen.Freeze();
			}
			dc.DrawGeometry(null, pen, this.geometry_0);
		}
	}

	// Token: 0x04001BAD RID: 7085
	[Attribute10(2)]
	private Geometry geometry_0;

	// Token: 0x04001BAE RID: 7086
	public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("CornerSmoothing", typeof(double), typeof(GClass289), new FrameworkPropertyMetadata(0.2, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender), new ValidateValueCallback(GClass289.Class806.class806_0.method_0));

	// Token: 0x04001BAF RID: 7087
	public static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.Register("ClipContent", typeof(bool), typeof(GClass289), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

	// Token: 0x0200068F RID: 1679
	[Serializable]
	private sealed class Class806
	{
		// Token: 0x06002A6F RID: 10863 RVA: 0x0001B9D9 File Offset: 0x00019BD9
		[Attribute11(0)]
		internal bool method_0(object object_0)
		{
			return (double)object_0 >= 0.0 && (double)object_0 <= 1.0;
		}

		// Token: 0x04001BB0 RID: 7088
		[Attribute10(0)]
		public static readonly GClass289.Class806 class806_0 = new GClass289.Class806();
	}
}
