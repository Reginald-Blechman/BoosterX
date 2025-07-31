using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Microsoft.Expression.Shapes;
using OxyPlot;

namespace ns0
{
	// Token: 0x020007F0 RID: 2032
	internal sealed class dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd
	{
		// Token: 0x0600315F RID: 12639 RVA: 0x000BE78C File Offset: 0x000BC98C
		public static FontFamily smethod_0()
		{
			FontFamily result;
			try
			{
				result = (Application.Current.Resources["GlobalFontFamily"] as FontFamily);
			}
			catch
			{
				result = new FontFamily("Segoe UI");
			}
			return result;
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000BE7D8 File Offset: 0x000BC9D8
		public static Color smethod_1(Color color_9, int int_0)
		{
			if (int_0 < 0)
			{
				int_0 = 0;
			}
			if (int_0 > 255)
			{
				int_0 = 255;
			}
			int num = (int)color_9.R - int_0;
			int num2 = (int)color_9.G - int_0;
			int num3 = (int)color_9.B - int_0;
			num = Math.Max(num, 0);
			num2 = Math.Max(num2, 0);
			num3 = Math.Max(num3, 0);
			return Color.FromArgb(byte.MaxValue, (byte)num, (byte)num2, (byte)num3);
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x000BE848 File Offset: 0x000BCA48
		public static SolidColorBrush smethod_2(BitmapSource bitmapSource_0)
		{
			int pixelWidth = bitmapSource_0.PixelWidth;
			int pixelHeight = bitmapSource_0.PixelHeight;
			Dictionary<Color, int> dictionary = new Dictionary<Color, int>();
			byte[] array = new byte[pixelWidth * pixelHeight * 4];
			bitmapSource_0.CopyPixels(array, pixelWidth * 4, 0);
			for (int i = 0; i < pixelHeight; i++)
			{
				for (int j = 0; j < pixelWidth; j++)
				{
					int num = (i * pixelWidth + j) * 4;
					byte b = array[num];
					byte g = array[num + 1];
					byte r = array[num + 2];
					byte b2 = array[num + 3];
					if (b2 != 0)
					{
						Color color = Color.FromArgb(b2, r, g, b);
						if (!dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_3(color))
						{
							if (dictionary.ContainsKey(color))
							{
								Dictionary<Color, int> dictionary2 = dictionary;
								Color key = color;
								int num2 = dictionary2[key];
								dictionary2[key] = num2 + 1;
							}
							else
							{
								dictionary[color] = 1;
							}
						}
					}
				}
			}
			if (dictionary.Count == 0)
			{
				return new SolidColorBrush(Colors.Gray);
			}
			List<KeyValuePair<Color, int>> list = dictionary.OrderByDescending(new Func<KeyValuePair<Color, int>, int>(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class928.class928_0.method_0)).ToList<KeyValuePair<Color, int>>();
			if (list.Count > 1000)
			{
				return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;
			}
			return new SolidColorBrush(list.First<KeyValuePair<Color, int>>().Key);
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000BE980 File Offset: 0x000BCB80
		public static bool smethod_3(Color color_9)
		{
			return (dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_39(color_9.R) && dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_39(color_9.G) && dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_39(color_9.B)) || dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_40(color_9.R, color_9.G, color_9.B);
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0001F328 File Offset: 0x0001D528
		public static SolidColorBrush smethod_4(SolidColorBrush solidColorBrush_5, double double_0)
		{
			return new SolidColorBrush(solidColorBrush_5.Color)
			{
				Opacity = double_0
			};
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000BE9D4 File Offset: 0x000BCBD4
		public static Color smethod_5(Color color_9, float float_0)
		{
			if (float_0 < 0f)
			{
				float_0 = 0f;
			}
			if (float_0 > 1f)
			{
				float_0 = 1f;
			}
			return Color.FromArgb((byte)(float_0 * 255f), color_9.R, color_9.G, color_9.B);
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x0001F33C File Offset: 0x0001D53C
		public static OxyColor smethod_6(Color color_9)
		{
			return OxyColor.FromRgb(color_9.R, color_9.G, color_9.B);
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000BEA28 File Offset: 0x000BCC28
		public static Task smethod_7(double double_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct603 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.double_0 = double_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct603>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x000BEA6C File Offset: 0x000BCC6C
		public static void smethod_8(double double_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct610 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.double_0 = double_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct610>(ref @struct);
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000BEAA4 File Offset: 0x000BCCA4
		public static Task smethod_9(TextBlock textBlock_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct609 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.textBlock_0 = textBlock_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct609>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x000BEAE8 File Offset: 0x000BCCE8
		public static void smethod_10(TextBlock textBlock_0, string string_0, string string_1)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct607 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.textBlock_0 = textBlock_0;
			@struct.string_0 = string_0;
			@struct.string_1 = string_1;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct607>(ref @struct);
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x000BEB30 File Offset: 0x000BCD30
		public static void smethod_11(TextBlock textBlock_0, string string_0, SolidColorBrush solidColorBrush_5)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct613 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.textBlock_0 = textBlock_0;
			@struct.string_0 = string_0;
			@struct.solidColorBrush_0 = solidColorBrush_5;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct613>(ref @struct);
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000BEB78 File Offset: 0x000BCD78
		public static void smethod_12(TextBlock textBlock_0, string string_0, TimeSpan timeSpan_2)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct615 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.textBlock_0 = textBlock_0;
			@struct.string_0 = string_0;
			@struct.timeSpan_0 = timeSpan_2;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct615>(ref @struct);
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x000BEBC0 File Offset: 0x000BCDC0
		public static void smethod_13(UIElement uielement_0, TimeSpan timeSpan_2)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct614 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.timeSpan_0 = timeSpan_2;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct614>(ref @struct);
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000BEC00 File Offset: 0x000BCE00
		public static void smethod_14(UIElement uielement_0, int int_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct616 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct616>(ref @struct);
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x000BEC40 File Offset: 0x000BCE40
		public static Task smethod_15(UIElement uielement_0, TimeSpan timeSpan_2)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct617 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.timeSpan_0 = timeSpan_2;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct617>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x000BEC8C File Offset: 0x000BCE8C
		public static Task smethod_16(UIElement uielement_0, int int_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct618 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct618>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x000BECD8 File Offset: 0x000BCED8
		public static void smethod_17(UIElement uielement_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct621 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct621>(ref @struct);
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x000BED10 File Offset: 0x000BCF10
		public static Task smethod_18(UIElement uielement_0, int int_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct608 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct608>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x000BED54 File Offset: 0x000BCF54
		public static void smethod_19(UIElement uielement_0, TimeSpan timeSpan_2)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct604 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.timeSpan_0 = timeSpan_2;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct604>(ref @struct);
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x000BED94 File Offset: 0x000BCF94
		public static void smethod_20(UIElement uielement_0, int int_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct612 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct612>(ref @struct);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x000BEDD4 File Offset: 0x000BCFD4
		public static Task smethod_21(UIElement uielement_0, int int_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct606 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct606>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x000BEE20 File Offset: 0x000BD020
		public static Task smethod_22(UIElement uielement_0, TimeSpan timeSpan_2)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct619 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.timeSpan_0 = timeSpan_2;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct619>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x000BEE6C File Offset: 0x000BD06C
		public static void smethod_23(UIElement uielement_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct620 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct620>(ref @struct);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x000BEEA4 File Offset: 0x000BD0A4
		public static void smethod_24(UIElement uielement_0, int int_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct625 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct625>(ref @struct);
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x000BEEE4 File Offset: 0x000BD0E4
		public static Task smethod_25(UIElement uielement_0, int int_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct626 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.int_1 = int_0;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct626>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000BEF30 File Offset: 0x000BD130
		public static void smethod_26(UIElement uielement_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class919 @class = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class919();
			@class.uielement_0 = uielement_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000BEF68 File Offset: 0x000BD168
		public static void smethod_27(UIElement uielement_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class918 @class = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class918();
			@class.uielement_0 = uielement_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000BEFA0 File Offset: 0x000BD1A0
		public static void smethod_28(UIElement uielement_0, TimeSpan timeSpan_2)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct623 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.timeSpan_0 = timeSpan_2;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct623>(ref @struct);
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000BEFE0 File Offset: 0x000BD1E0
		public static void smethod_29(UIElement uielement_0, TimeSpan timeSpan_2)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct605 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.uielement_0 = uielement_0;
			@struct.timeSpan_0 = timeSpan_2;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct605>(ref @struct);
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000BF020 File Offset: 0x000BD220
		public static void smethod_30(Transform transform_0, Duration duration_0, double double_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class923 @class = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class923();
			@class.double_0 = double_0;
			@class.transform_0 = transform_0;
			if (!double.IsNaN(@class.double_0))
			{
				@class.duration_0 = duration_0;
				if (Class551.class753_0.method_52().GetValueOrDefault())
				{
					@class.duration_0 = TimeSpan.Zero;
				}
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x000BF094 File Offset: 0x000BD294
		public static void smethod_31(UIElement uielement_0, Duration duration_0, Thickness thickness_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class926 @class = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class926();
			@class.uielement_0 = uielement_0;
			Duration duration = duration_0;
			if (Class551.class753_0.method_52().GetValueOrDefault())
			{
				duration = TimeSpan.Zero;
			}
			@class.thicknessAnimation_0 = new ThicknessAnimation
			{
				To = new Thickness?(thickness_0),
				Duration = duration,
				AccelerationRatio = 0.5,
				DecelerationRatio = 0.5,
				EasingFunction = new QuadraticEase
				{
					EasingMode = EasingMode.EaseOut
				}
			};
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x000BF138 File Offset: 0x000BD338
		public static void smethod_32(UIElement uielement_0, Duration duration_0, Thickness thickness_0, Thickness thickness_1)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class916 @class = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class916();
			@class.thickness_0 = thickness_0;
			@class.thickness_1 = thickness_1;
			@class.uielement_0 = uielement_0;
			@class.duration_0 = duration_0;
			if (Class551.class753_0.method_52().GetValueOrDefault())
			{
				@class.duration_0 = TimeSpan.Zero;
			}
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x000BF1A8 File Offset: 0x000BD3A8
		public static void smethod_33(dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0, float float_0)
		{
			try
			{
				if (float_0 <= 35f)
				{
					((Storyboard)dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0.Resources["ColorChangeToRed"]).Begin();
				}
				else if (float_0 <= 50f)
				{
					((Storyboard)dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0.Resources["ColorChangeToYellow"]).Begin();
				}
				else if (float_0 <= 75f)
				{
					((Storyboard)dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0.Resources["ColorChangeToGreen"]).Begin();
				}
				else if (float_0 <= 90f)
				{
					((Storyboard)dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0.Resources["ColorChangeToMainColor"]).Begin();
				}
				else if (float_0 <= 100f)
				{
					((Storyboard)dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd_0.Resources["ColorChangeToViloe"]).Begin();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000BF284 File Offset: 0x000BD484
		public static void smethod_34(Arc arc_0, float float_0)
		{
			try
			{
				dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_ = Class406.smethod_0().dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_0;
				if (dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_ != null)
				{
					if (float_0 <= 35f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("ColorChangeToRed")).Begin(arc_0);
					}
					else if (float_0 <= 50f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("ColorChangeToYellow")).Begin(arc_0);
					}
					else if (float_0 <= 75f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("ColorChangeToGreen")).Begin(arc_0);
					}
					else if (float_0 <= 90f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("ColorChangeToMainColor")).Begin(arc_0);
					}
					else if (float_0 <= 100f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("ColorChangeToViloe")).Begin(arc_0);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000BF360 File Offset: 0x000BD560
		public static void smethod_35(TextBlock textBlock_0, float float_0)
		{
			try
			{
				dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_ = Class406.smethod_0().dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_0;
				if (dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_ != null)
				{
					if (float_0 <= 35f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("TextColorChangeToRed")).Begin(textBlock_0);
					}
					else if (float_0 <= 50f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("TextColorChangeToYellow")).Begin(textBlock_0);
					}
					else if (float_0 <= 75f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("TextColorChangeToGreen")).Begin(textBlock_0);
					}
					else if (float_0 <= 90f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("TextColorChangeToMainColor")).Begin(textBlock_0);
					}
					else if (float_0 <= 100f)
					{
						((Storyboard)dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_.FindResource("TextColorChangeToViloe")).Begin(textBlock_0);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x000BF43C File Offset: 0x000BD63C
		public static void smethod_36(TextBlock textBlock_0, double double_0)
		{
			if (double_0 <= 35.0)
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(textBlock_0, Class298.smethod_2("badlevel"), null);
				return;
			}
			if (double_0 <= 50.0)
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(textBlock_0, Class298.smethod_2("basiclevel"), null);
				return;
			}
			if (double_0 <= 75.0)
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(textBlock_0, Class298.smethod_2("goodlevel"), null);
				return;
			}
			if (double_0 <= 90.0)
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(textBlock_0, Class298.smethod_2("greatlevel"), null);
				return;
			}
			if (double_0 <= 100.0)
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_11(textBlock_0, Class298.smethod_2("godlike"), null);
			}
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000BF4E4 File Offset: 0x000BD6E4
		public static void smethod_37(TextBlock textBlock_0, double double_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct622 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.textBlock_0 = textBlock_0;
			@struct.double_0 = double_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct622>(ref @struct);
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000BF524 File Offset: 0x000BD724
		public static void smethod_38(UIElement uielement_0, Duration duration_0, DependencyProperty dependencyProperty_0, double double_0)
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class924 @class = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class924();
			@class.double_0 = double_0;
			@class.uielement_0 = uielement_0;
			@class.dependencyProperty_0 = dependencyProperty_0;
			if (!double.IsNaN(@class.double_0))
			{
				@class.duration_0 = (Class551.class753_0.method_52().GetValueOrDefault() ? TimeSpan.Zero : duration_0);
				Application.Current.Dispatcher.InvokeAsync(new Action(@class.method_0));
			}
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x0001F358 File Offset: 0x0001D558
		internal static bool smethod_39(byte byte_0)
		{
			return byte_0 <= 15 || byte_0 >= 240;
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x0001F36C File Offset: 0x0001D56C
		internal static bool smethod_40(byte byte_0, byte byte_1, byte byte_2)
		{
			return Math.Abs((int)(byte_0 - byte_1)) <= 10 && Math.Abs((int)(byte_0 - byte_2)) <= 10 && Math.Abs((int)(byte_1 - byte_2)) <= 10;
		}

		// Token: 0x0400220D RID: 8717
		public static Color dje_zRFTDSNNMSNMN6WA_ejd = (Color)ColorConverter.ConvertFromString("#2E5CFF");

		// Token: 0x0400220E RID: 8718
		public static Color dje_zD9GRSSAL8RCY2D2_ejd = (Color)ColorConverter.ConvertFromString("#508BFF");

		// Token: 0x0400220F RID: 8719
		public static Color dje_zZ58MUFQZBETC5R2_ejd = (Color)ColorConverter.ConvertFromString("#93B7FF");

		// Token: 0x04002210 RID: 8720
		public static Color color_0 = (Color)ColorConverter.ConvertFromString("#05070F");

		// Token: 0x04002211 RID: 8721
		public static Color dje_z9MZATB4TWME8U7MP7WHN2_ejd = (Color)ColorConverter.ConvertFromString("#6A6A6A");

		// Token: 0x04002212 RID: 8722
		public static Color dje_zKUGX8VZG8GQJ6GA_ejd = (Color)ColorConverter.ConvertFromString("#D93B3B");

		// Token: 0x04002213 RID: 8723
		public static Color dje_zWR2LREVSSWGCG3NS35V6R_ejd = (Color)ColorConverter.ConvertFromString("#31FF83");

		// Token: 0x04002214 RID: 8724
		public static Color dje_zXB2DAXC99XZ65RJTVNH3E_ejd = (Color)ColorConverter.ConvertFromString("#3DDB60");

		// Token: 0x04002215 RID: 8725
		public static Color dje_z4B4MF4E2S86TX7RGPTDHZ_ejd = (Color)ColorConverter.ConvertFromString("#15DB96");

		// Token: 0x04002216 RID: 8726
		public static Color color_1 = (Color)ColorConverter.ConvertFromString("#F25E09");

		// Token: 0x04002217 RID: 8727
		public static Color color_2 = (Color)ColorConverter.ConvertFromString("#A9A9A9");

		// Token: 0x04002218 RID: 8728
		public static Color color_3 = (Color)ColorConverter.ConvertFromString("#808080");

		// Token: 0x04002219 RID: 8729
		public static Color dje_zH2C6P3HHD4TV29CYHNS73_ejd = (Color)ColorConverter.ConvertFromString("#FFC93F");

		// Token: 0x0400221A RID: 8730
		public static Color dje_zRWJ5BJR8VJCZDTQTQFEZV_ejd = (Color)ColorConverter.ConvertFromString("#20263B");

		// Token: 0x0400221B RID: 8731
		public static Color dje_z6TEMKZM53PAWUV7UDDRVD_ejd = (Color)ColorConverter.ConvertFromString("#222E57");

		// Token: 0x0400221C RID: 8732
		public static Color color_4 = (Color)ColorConverter.ConvertFromString("#FFFFFF");

		// Token: 0x0400221D RID: 8733
		public static Color dje_z829GEF55NB9EHH292LDLD_ejd = (Color)ColorConverter.ConvertFromString("#7D2EFF");

		// Token: 0x0400221E RID: 8734
		public static Color color_5 = (Color)ColorConverter.ConvertFromString("#1E1E1E");

		// Token: 0x0400221F RID: 8735
		public static Color dje_zSM85V9F8UX4VG5BQNPS2F_ejd = (Color)ColorConverter.ConvertFromString("#3A36E0");

		// Token: 0x04002220 RID: 8736
		public static Color color_6 = (Color)ColorConverter.ConvertFromString("#DDDDDD");

		// Token: 0x04002221 RID: 8737
		public static Color color_7 = (Color)ColorConverter.ConvertFromString("#0D101F");

		// Token: 0x04002222 RID: 8738
		public static Color dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd = (Color)ColorConverter.ConvertFromString("#607296");

		// Token: 0x04002223 RID: 8739
		public static Color color_8 = (Color)ColorConverter.ConvertFromString("#2C3750");

		// Token: 0x04002224 RID: 8740
		public static Color dje_zJKFAUYR2VH4E73A68QQ3PJASZCRA_ejd = (Color)ColorConverter.ConvertFromString("#4D608D");

		// Token: 0x04002225 RID: 8741
		public static SolidColorBrush dje_z82W2KBY2W2H2UZX34LHGR_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_8);

		// Token: 0x04002226 RID: 8742
		public static SolidColorBrush dje_z7Y3AEKDZ_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRFTDSNNMSNMN6WA_ejd);

		// Token: 0x04002227 RID: 8743
		public static SolidColorBrush dje_zRGR5QHU2M7DAPA2_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zD9GRSSAL8RCY2D2_ejd);

		// Token: 0x04002228 RID: 8744
		public static SolidColorBrush dje_zBHWQM3TLFWTMTC2_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zZ58MUFQZBETC5R2_ejd);

		// Token: 0x04002229 RID: 8745
		public static SolidColorBrush dje_zD9QMZWCV58NG45A_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_0);

		// Token: 0x0400222A RID: 8746
		public static SolidColorBrush dje_z9KD2T3QNVQ26P9Q_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z9MZATB4TWME8U7MP7WHN2_ejd);

		// Token: 0x0400222B RID: 8747
		public static SolidColorBrush dje_zUA9MYQN4ZPV2ETZ_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zKUGX8VZG8GQJ6GA_ejd);

		// Token: 0x0400222C RID: 8748
		public static SolidColorBrush dje_z52HQ7LJ6MG7CVYQ_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zWR2LREVSSWGCG3NS35V6R_ejd);

		// Token: 0x0400222D RID: 8749
		public static SolidColorBrush dje_zRGEEN2XWKB2ZUBQ_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zXB2DAXC99XZ65RJTVNH3E_ejd);

		// Token: 0x0400222E RID: 8750
		public static SolidColorBrush dje_zCFLBYXMGSL7H8BQ_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z4B4MF4E2S86TX7RGPTDHZ_ejd);

		// Token: 0x0400222F RID: 8751
		public static SolidColorBrush solidColorBrush_0 = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_1);

		// Token: 0x04002230 RID: 8752
		public static SolidColorBrush solidColorBrush_1 = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_2);

		// Token: 0x04002231 RID: 8753
		public static SolidColorBrush dje_z7FRVJVZAVZQYE4Q_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_3);

		// Token: 0x04002232 RID: 8754
		public static SolidColorBrush dje_zSYYZ9DTVXRCFXBZ_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zH2C6P3HHD4TV29CYHNS73_ejd);

		// Token: 0x04002233 RID: 8755
		public static SolidColorBrush dje_z2B5DBTEJ9B4VE9Z_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRWJ5BJR8VJCZDTQTQFEZV_ejd);

		// Token: 0x04002234 RID: 8756
		public static SolidColorBrush dje_zUMNCHPVU5DUVRTWHMPV4Z_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z6TEMKZM53PAWUV7UDDRVD_ejd);

		// Token: 0x04002235 RID: 8757
		public static SolidColorBrush solidColorBrush_2 = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_4);

		// Token: 0x04002236 RID: 8758
		public static SolidColorBrush dje_zUQZKBFFY5A4QNKC2YZ2EV_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_5);

		// Token: 0x04002237 RID: 8759
		public static SolidColorBrush dje_zY99EWG67ABS6GW2_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSM85V9F8UX4VG5BQNPS2F_ejd);

		// Token: 0x04002238 RID: 8760
		public static SolidColorBrush solidColorBrush_3 = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_6);

		// Token: 0x04002239 RID: 8761
		public static SolidColorBrush dje_zS3TM7NE87TBQM2XGVUULQ_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.color_7);

		// Token: 0x0400223A RID: 8762
		public static SolidColorBrush dje_zTKGJVHY5RMNHNSLGQ7MRD_ejd = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zNLD3PDKVYNPW2WLQGFE5ZWL7P2UA_ejd);

		// Token: 0x0400223B RID: 8763
		public static SolidColorBrush solidColorBrush_4 = new SolidColorBrush(dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zJKFAUYR2VH4E73A68QQ3PJASZCRA_ejd);

		// Token: 0x0400223C RID: 8764
		public static TimeSpan timeSpan_0 = TimeSpan.FromSeconds(0.2);

		// Token: 0x0400223D RID: 8765
		public static TimeSpan timeSpan_1 = TimeSpan.FromSeconds(0.3);

		// Token: 0x0400223E RID: 8766
		public static FontFamily fontFamily_0 = new FontFamily(new Uri("pack://application:,,,/BoosterX;component/Resources/Fonts/"), "./#Flow Circular");

		// Token: 0x020007F1 RID: 2033
		private sealed class Class913
		{
			// Token: 0x06003189 RID: 12681 RVA: 0x0001F397 File Offset: 0x0001D597
			internal void method_0()
			{
				this.textBlock_0.Text = this.int_0.ToString();
			}

			// Token: 0x0600318A RID: 12682 RVA: 0x0001F3AF File Offset: 0x0001D5AF
			internal void method_1()
			{
				this.textBlock_0.Text = this.int_1.ToString();
			}

			// Token: 0x0400223F RID: 8767
			public TextBlock textBlock_0;

			// Token: 0x04002240 RID: 8768
			public int int_0;

			// Token: 0x04002241 RID: 8769
			public int int_1;
		}

		// Token: 0x020007F2 RID: 2034
		[StructLayout(LayoutKind.Auto)]
		private struct Struct603 : IAsyncStateMachine
		{
			// Token: 0x0600318B RID: 12683 RVA: 0x000BF59C File Offset: 0x000BD79C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_A0;
					}
					if (Class551.class753_0.method_52().GetValueOrDefault())
					{
						goto IL_E2;
					}
					IL_41:
					if (this.double_0 == 0.0)
					{
						goto IL_E2;
					}
					this.double_0 -= 0.1;
					if (this.double_0 < 0.05)
					{
						this.double_0 = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct603>(ref awaiter, ref this);
						return;
					}
					IL_A0:
					awaiter.GetResult();
					goto IL_41;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_E2:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600318C RID: 12684 RVA: 0x0001F3C7 File Offset: 0x0001D5C7
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002242 RID: 8770
			public int int_0;

			// Token: 0x04002243 RID: 8771
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04002244 RID: 8772
			public double double_0;

			// Token: 0x04002245 RID: 8773
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007F3 RID: 2035
		[StructLayout(LayoutKind.Auto)]
		private struct Struct604 : IAsyncStateMachine
		{
			// Token: 0x0600318D RID: 12685 RVA: 0x000BF6B0 File Offset: 0x000BD8B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.uielement_0, (int)this.timeSpan_0.TotalMilliseconds).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct604>(ref awaiter, ref this);
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

			// Token: 0x0600318E RID: 12686 RVA: 0x0001F3D5 File Offset: 0x0001D5D5
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002246 RID: 8774
			public int int_0;

			// Token: 0x04002247 RID: 8775
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002248 RID: 8776
			public UIElement uielement_0;

			// Token: 0x04002249 RID: 8777
			public TimeSpan timeSpan_0;

			// Token: 0x0400224A RID: 8778
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007F4 RID: 2036
		private sealed class Class914
		{
			// Token: 0x06003190 RID: 12688 RVA: 0x0001F3E3 File Offset: 0x0001D5E3
			internal void method_0()
			{
				this.uielement_0.Visibility = Visibility.Visible;
			}

			// Token: 0x0400224B RID: 8779
			public UIElement uielement_0;
		}

		// Token: 0x020007F5 RID: 2037
		private sealed class Class915
		{
			// Token: 0x06003192 RID: 12690 RVA: 0x000BF76C File Offset: 0x000BD96C
			internal double method_0()
			{
				UIElement uielement = this.uielement_0;
				double opacity = 1.0;
				double result = (double)1f;
				uielement.Opacity = opacity;
				return result;
			}

			// Token: 0x06003193 RID: 12691 RVA: 0x000BF794 File Offset: 0x000BD994
			internal void method_1()
			{
				DoubleAnimation animation = new DoubleAnimation
				{
					To = new double?((double)1f),
					Duration = TimeSpan.FromMilliseconds((double)this.int_0),
					EasingFunction = new CubicEase
					{
						EasingMode = EasingMode.EaseIn
					}
				};
				this.uielement_0.BeginAnimation(UIElement.OpacityProperty, animation);
			}

			// Token: 0x0400224C RID: 8780
			public UIElement uielement_0;

			// Token: 0x0400224D RID: 8781
			public int int_0;
		}

		// Token: 0x020007F6 RID: 2038
		private sealed class Class916
		{
			// Token: 0x06003195 RID: 12693 RVA: 0x000BF7F4 File Offset: 0x000BD9F4
			internal void method_0()
			{
				ThicknessAnimation thicknessAnimation = new ThicknessAnimation
				{
					From = new Thickness?(this.thickness_0),
					To = new Thickness?(this.thickness_1),
					Duration = this.duration_0,
					AccelerationRatio = 0.5,
					DecelerationRatio = 0.5,
					EasingFunction = new QuadraticEase
					{
						EasingMode = EasingMode.EaseOut
					}
				};
				Storyboard.SetTarget(thicknessAnimation, this.uielement_0);
				Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin", Array.Empty<object>()));
				new Storyboard
				{
					Children = 
					{
						thicknessAnimation
					}
				}.Begin();
			}

			// Token: 0x0400224E RID: 8782
			public Thickness thickness_0;

			// Token: 0x0400224F RID: 8783
			public Thickness thickness_1;

			// Token: 0x04002250 RID: 8784
			public Duration duration_0;

			// Token: 0x04002251 RID: 8785
			public UIElement uielement_0;
		}

		// Token: 0x020007F7 RID: 2039
		[StructLayout(LayoutKind.Auto)]
		private struct Struct605 : IAsyncStateMachine
		{
			// Token: 0x06003196 RID: 12694 RVA: 0x000BF8A0 File Offset: 0x000BDAA0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Func<Task>(new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class921
						{
							timeSpan_0 = this.timeSpan_0,
							uielement_0 = this.uielement_0
						}.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct605>(ref awaiter, ref this);
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

			// Token: 0x06003197 RID: 12695 RVA: 0x0001F3F1 File Offset: 0x0001D5F1
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002252 RID: 8786
			public int int_0;

			// Token: 0x04002253 RID: 8787
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002254 RID: 8788
			public TimeSpan timeSpan_0;

			// Token: 0x04002255 RID: 8789
			public UIElement uielement_0;

			// Token: 0x04002256 RID: 8790
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007F8 RID: 2040
		[StructLayout(LayoutKind.Auto)]
		private struct Struct606 : IAsyncStateMachine
		{
			// Token: 0x06003198 RID: 12696 RVA: 0x000BF974 File Offset: 0x000BDB74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<double> awaiter;
					TaskAwaiter awaiter2;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<double>);
						this.int_0 = -1;
						break;
					case 1:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_159;
					case 2:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1BB;
					default:
						this.class915_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class915();
						this.class915_0.uielement_0 = this.uielement_0;
						this.class915_0.int_0 = this.int_1;
						if (Class551.class753_0.method_52().GetValueOrDefault())
						{
							awaiter = Application.Current.Dispatcher.InvokeAsync<double>(new Func<double>(this.class915_0.method_0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<double>, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct606>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							TimeSpan.FromMilliseconds((double)this.class915_0.int_0);
							awaiter2 = Application.Current.Dispatcher.InvokeAsync(new Action(this.class915_0.method_1)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct606>(ref awaiter2, ref this);
								return;
							}
							goto IL_159;
						}
						break;
					}
					awaiter.GetResult();
					goto IL_1E2;
					IL_159:
					awaiter2.GetResult();
					awaiter2 = Task.Delay(this.class915_0.int_0).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct606>(ref awaiter2, ref this);
						return;
					}
					IL_1BB:
					awaiter2.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class915_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1E2:
				this.int_0 = -2;
				this.class915_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06003199 RID: 12697 RVA: 0x0001F3FF File Offset: 0x0001D5FF
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002257 RID: 8791
			public int int_0;

			// Token: 0x04002258 RID: 8792
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04002259 RID: 8793
			public UIElement uielement_0;

			// Token: 0x0400225A RID: 8794
			public int int_1;

			// Token: 0x0400225B RID: 8795
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class915 class915_0;

			// Token: 0x0400225C RID: 8796
			private TaskAwaiter<double> taskAwaiter_0;

			// Token: 0x0400225D RID: 8797
			private TaskAwaiter taskAwaiter_1;
		}

		// Token: 0x020007F9 RID: 2041
		[StructLayout(LayoutKind.Auto)]
		private struct Struct607 : IAsyncStateMachine
		{
			// Token: 0x0600319A RID: 12698 RVA: 0x000BFB9C File Offset: 0x000BDD9C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
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
						goto IL_13B;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_19F;
					default:
						this.class929_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class929();
						this.class929_0.textBlock_0 = this.textBlock_0;
						this.class929_0.string_0 = this.string_0;
						this.class929_0.solidColorBrush_0 = new SolidColorBrush((Color)ColorConverter.ConvertFromString(this.string_1));
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.class929_0.textBlock_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct607>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class929_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct607>(ref awaiter, ref this);
						return;
					}
					IL_13B:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.class929_0.textBlock_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct607>(ref awaiter, ref this);
						return;
					}
					IL_19F:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class929_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class929_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x0600319B RID: 12699 RVA: 0x0001F40D File Offset: 0x0001D60D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400225E RID: 8798
			public int int_0;

			// Token: 0x0400225F RID: 8799
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002260 RID: 8800
			public TextBlock textBlock_0;

			// Token: 0x04002261 RID: 8801
			public string string_0;

			// Token: 0x04002262 RID: 8802
			public string string_1;

			// Token: 0x04002263 RID: 8803
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class929 class929_0;

			// Token: 0x04002264 RID: 8804
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007FA RID: 2042
		private sealed class Class917
		{
			// Token: 0x0600319D RID: 12701 RVA: 0x0001F41B File Offset: 0x0001D61B
			internal void method_0()
			{
				this.textBlock_0.Text = this.string_0;
				if (this.solidColorBrush_0 != null)
				{
					this.textBlock_0.Foreground = this.solidColorBrush_0;
				}
			}

			// Token: 0x04002265 RID: 8805
			public TextBlock textBlock_0;

			// Token: 0x04002266 RID: 8806
			public string string_0;

			// Token: 0x04002267 RID: 8807
			public SolidColorBrush solidColorBrush_0;
		}

		// Token: 0x020007FB RID: 2043
		[StructLayout(LayoutKind.Auto)]
		private struct Struct608 : IAsyncStateMachine
		{
			// Token: 0x0600319E RID: 12702 RVA: 0x000BFDA8 File Offset: 0x000BDFA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_101;
						}
						this.class925_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class925();
						this.class925_0.uielement_0 = this.uielement_0;
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.class925_0.uielement_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct608>(ref awaiter, ref this);
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
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class925_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct608>(ref awaiter, ref this);
						return;
					}
					IL_101:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class925_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class925_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600319F RID: 12703 RVA: 0x0001F447 File Offset: 0x0001D647
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002268 RID: 8808
			public int int_0;

			// Token: 0x04002269 RID: 8809
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400226A RID: 8810
			public UIElement uielement_0;

			// Token: 0x0400226B RID: 8811
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class925 class925_0;

			// Token: 0x0400226C RID: 8812
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007FC RID: 2044
		[StructLayout(LayoutKind.Auto)]
		private struct Struct609 : IAsyncStateMachine
		{
			// Token: 0x060031A0 RID: 12704 RVA: 0x000BFF14 File Offset: 0x000BE114
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							if (this.textBlock_0.Opacity == 0.0)
							{
								awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.textBlock_0, 100).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 0;
									this.taskAwaiter_0 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct609>(ref awaiter, ref this);
									return;
								}
								goto IL_E9;
							}
							else
							{
								awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.textBlock_0, 100).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 1;
									this.taskAwaiter_0 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct609>(ref awaiter, ref this);
									return;
								}
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
						}
						awaiter.GetResult();
						goto IL_F0;
					}
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					IL_E9:
					awaiter.GetResult();
					IL_F0:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060031A1 RID: 12705 RVA: 0x0001F455 File Offset: 0x0001D655
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400226D RID: 8813
			public int int_0;

			// Token: 0x0400226E RID: 8814
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400226F RID: 8815
			public TextBlock textBlock_0;

			// Token: 0x04002270 RID: 8816
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020007FD RID: 2045
		private sealed class Class918
		{
			// Token: 0x060031A3 RID: 12707 RVA: 0x0001F463 File Offset: 0x0001D663
			internal void method_0()
			{
				this.uielement_0.Visibility = Visibility.Collapsed;
			}

			// Token: 0x04002271 RID: 8817
			public UIElement uielement_0;
		}

		// Token: 0x020007FE RID: 2046
		private sealed class Class919
		{
			// Token: 0x060031A5 RID: 12709 RVA: 0x0001F471 File Offset: 0x0001D671
			internal void method_0()
			{
				this.uielement_0.Visibility = Visibility.Visible;
			}

			// Token: 0x04002272 RID: 8818
			public UIElement uielement_0;
		}

		// Token: 0x020007FF RID: 2047
		[StructLayout(LayoutKind.Auto)]
		private struct Struct610 : IAsyncStateMachine
		{
			// Token: 0x060031A6 RID: 12710 RVA: 0x000C0050 File Offset: 0x000BE250
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_A0;
					}
					if (Class551.class753_0.method_52().GetValueOrDefault())
					{
						goto IL_E2;
					}
					IL_41:
					if (this.double_0 == 1.0)
					{
						goto IL_E2;
					}
					this.double_0 += 0.13333333333333333;
					if (this.double_0 > 0.95)
					{
						this.double_0 = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct610>(ref awaiter, ref this);
						return;
					}
					IL_A0:
					awaiter.GetResult();
					goto IL_41;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_E2:
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060031A7 RID: 12711 RVA: 0x0001F47F File Offset: 0x0001D67F
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002273 RID: 8819
			public int int_0;

			// Token: 0x04002274 RID: 8820
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002275 RID: 8821
			public double double_0;

			// Token: 0x04002276 RID: 8822
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000800 RID: 2048
		private sealed class Class920
		{
			// Token: 0x060031A9 RID: 12713 RVA: 0x0001F48D File Offset: 0x0001D68D
			internal void method_0()
			{
				this.uielement_0.Opacity = 0.0;
			}

			// Token: 0x060031AA RID: 12714 RVA: 0x000C0164 File Offset: 0x000BE364
			internal void method_1()
			{
				DoubleAnimation animation = new DoubleAnimation
				{
					To = new double?(0.0),
					Duration = TimeSpan.FromMilliseconds((double)this.int_0),
					EasingFunction = new CubicEase
					{
						EasingMode = EasingMode.EaseOut
					}
				};
				this.uielement_0.BeginAnimation(UIElement.OpacityProperty, animation);
			}

			// Token: 0x04002277 RID: 8823
			public UIElement uielement_0;

			// Token: 0x04002278 RID: 8824
			public int int_0;
		}

		// Token: 0x02000801 RID: 2049
		private sealed class Class921
		{
			// Token: 0x060031AC RID: 12716 RVA: 0x000C01C8 File Offset: 0x000BE3C8
			internal Task method_0()
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class921.Struct611 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class921_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class921.Struct611>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x060031AD RID: 12717 RVA: 0x0001F4A3 File Offset: 0x0001D6A3
			internal void method_1()
			{
				this.uielement_0.Visibility = Visibility.Collapsed;
			}

			// Token: 0x04002279 RID: 8825
			public TimeSpan timeSpan_0;

			// Token: 0x0400227A RID: 8826
			public UIElement uielement_0;

			// Token: 0x0400227B RID: 8827
			public Action action_0;

			// Token: 0x02000802 RID: 2050
			[StructLayout(LayoutKind.Auto)]
			private struct Struct611 : IAsyncStateMachine
			{
				// Token: 0x060031AE RID: 12718 RVA: 0x000C020C File Offset: 0x000BE40C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class921 @class = this.class921_0;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter);
								this.int_0 = -1;
								goto IL_106;
							}
							awaiter = Task.Delay(@class.timeSpan_0 + TimeSpan.FromMilliseconds(1.0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class921.Struct611>(ref awaiter, ref this);
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
						Dispatcher dispatcher = Application.Current.Dispatcher;
						Action callback;
						if ((callback = @class.action_0) == null)
						{
							callback = (@class.action_0 = new Action(@class.method_1));
						}
						awaiter = dispatcher.InvokeAsync(callback).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class921.Struct611>(ref awaiter, ref this);
							return;
						}
						IL_106:
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x060031AF RID: 12719 RVA: 0x0001F4B1 File Offset: 0x0001D6B1
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x0400227C RID: 8828
				public int int_0;

				// Token: 0x0400227D RID: 8829
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400227E RID: 8830
				public dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class921 class921_0;

				// Token: 0x0400227F RID: 8831
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x02000803 RID: 2051
		[StructLayout(LayoutKind.Auto)]
		private struct Struct612 : IAsyncStateMachine
		{
			// Token: 0x060031B0 RID: 12720 RVA: 0x000C0370 File Offset: 0x000BE570
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.uielement_0, this.int_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct612>(ref awaiter, ref this);
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

			// Token: 0x060031B1 RID: 12721 RVA: 0x0001F4BF File Offset: 0x0001D6BF
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002280 RID: 8832
			public int int_0;

			// Token: 0x04002281 RID: 8833
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002282 RID: 8834
			public UIElement uielement_0;

			// Token: 0x04002283 RID: 8835
			public int int_1;

			// Token: 0x04002284 RID: 8836
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000804 RID: 2052
		private sealed class Class922
		{
			// Token: 0x060031B3 RID: 12723 RVA: 0x0001F4CD File Offset: 0x0001D6CD
			internal void method_0()
			{
				this.textBlock_0.Text = this.string_0;
			}

			// Token: 0x04002285 RID: 8837
			public TextBlock textBlock_0;

			// Token: 0x04002286 RID: 8838
			public string string_0;
		}

		// Token: 0x02000805 RID: 2053
		[StructLayout(LayoutKind.Auto)]
		private struct Struct613 : IAsyncStateMachine
		{
			// Token: 0x060031B4 RID: 12724 RVA: 0x000C0428 File Offset: 0x000BE628
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
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
						goto IL_12C;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_190;
					default:
						this.class917_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class917();
						this.class917_0.textBlock_0 = this.textBlock_0;
						this.class917_0.string_0 = this.string_0;
						this.class917_0.solidColorBrush_0 = this.solidColorBrush_0;
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.class917_0.textBlock_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct613>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class917_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct613>(ref awaiter, ref this);
						return;
					}
					IL_12C:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.class917_0.textBlock_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct613>(ref awaiter, ref this);
						return;
					}
					IL_190:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class917_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class917_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060031B5 RID: 12725 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002287 RID: 8839
			public int int_0;

			// Token: 0x04002288 RID: 8840
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002289 RID: 8841
			public TextBlock textBlock_0;

			// Token: 0x0400228A RID: 8842
			public string string_0;

			// Token: 0x0400228B RID: 8843
			public SolidColorBrush solidColorBrush_0;

			// Token: 0x0400228C RID: 8844
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class917 class917_0;

			// Token: 0x0400228D RID: 8845
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000806 RID: 2054
		[StructLayout(LayoutKind.Auto)]
		private struct Struct614 : IAsyncStateMachine
		{
			// Token: 0x060031B6 RID: 12726 RVA: 0x000C0624 File Offset: 0x000BE824
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.uielement_0, this.timeSpan_0.Milliseconds).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct614>(ref awaiter, ref this);
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

			// Token: 0x060031B7 RID: 12727 RVA: 0x0001F4EE File Offset: 0x0001D6EE
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400228E RID: 8846
			public int int_0;

			// Token: 0x0400228F RID: 8847
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002290 RID: 8848
			public UIElement uielement_0;

			// Token: 0x04002291 RID: 8849
			public TimeSpan timeSpan_0;

			// Token: 0x04002292 RID: 8850
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000807 RID: 2055
		[StructLayout(LayoutKind.Auto)]
		private struct Struct615 : IAsyncStateMachine
		{
			// Token: 0x060031B8 RID: 12728 RVA: 0x000C06E0 File Offset: 0x000BE8E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
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
						goto IL_11F;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_187;
					default:
						this.class922_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class922();
						this.class922_0.textBlock_0 = this.textBlock_0;
						this.class922_0.string_0 = this.string_0;
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_15(this.class922_0.textBlock_0, this.timeSpan_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct615>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class922_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct615>(ref awaiter, ref this);
						return;
					}
					IL_11F:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_22(this.class922_0.textBlock_0, this.timeSpan_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct615>(ref awaiter, ref this);
						return;
					}
					IL_187:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class922_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class922_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060031B9 RID: 12729 RVA: 0x0001F4FC File Offset: 0x0001D6FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04002293 RID: 8851
			public int int_0;

			// Token: 0x04002294 RID: 8852
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04002295 RID: 8853
			public TextBlock textBlock_0;

			// Token: 0x04002296 RID: 8854
			public string string_0;

			// Token: 0x04002297 RID: 8855
			public TimeSpan timeSpan_0;

			// Token: 0x04002298 RID: 8856
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class922 class922_0;

			// Token: 0x04002299 RID: 8857
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000808 RID: 2056
		private sealed class Class923
		{
			// Token: 0x060031BB RID: 12731 RVA: 0x000C08D4 File Offset: 0x000BEAD4
			internal void method_0()
			{
				DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
				{
					Duration = this.duration_0
				};
				doubleAnimationUsingKeyFrames.KeyFrames.Add(new SplineDoubleKeyFrame(this.double_0, KeyTime.FromTimeSpan(this.duration_0.TimeSpan), new KeySpline(0.25, 0.1, 0.25, 1.0)));
				this.transform_0.BeginAnimation(RotateTransform.AngleProperty, doubleAnimationUsingKeyFrames);
			}

			// Token: 0x0400229A RID: 8858
			public double double_0;

			// Token: 0x0400229B RID: 8859
			public Transform transform_0;

			// Token: 0x0400229C RID: 8860
			public Duration duration_0;
		}

		// Token: 0x02000809 RID: 2057
		[StructLayout(LayoutKind.Auto)]
		private struct Struct616 : IAsyncStateMachine
		{
			// Token: 0x060031BC RID: 12732 RVA: 0x000C0954 File Offset: 0x000BEB54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.uielement_0, this.int_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct616>(ref awaiter, ref this);
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

			// Token: 0x060031BD RID: 12733 RVA: 0x0001F50A File Offset: 0x0001D70A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400229D RID: 8861
			public int int_0;

			// Token: 0x0400229E RID: 8862
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x0400229F RID: 8863
			public UIElement uielement_0;

			// Token: 0x040022A0 RID: 8864
			public int int_1;

			// Token: 0x040022A1 RID: 8865
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200080A RID: 2058
		[StructLayout(LayoutKind.Auto)]
		private struct Struct617 : IAsyncStateMachine
		{
			// Token: 0x060031BE RID: 12734 RVA: 0x000C0A0C File Offset: 0x000BEC0C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.uielement_0, this.timeSpan_0.Milliseconds).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct617>(ref awaiter, ref this);
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
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060031BF RID: 12735 RVA: 0x0001F518 File Offset: 0x0001D718
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022A2 RID: 8866
			public int int_0;

			// Token: 0x040022A3 RID: 8867
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040022A4 RID: 8868
			public UIElement uielement_0;

			// Token: 0x040022A5 RID: 8869
			public TimeSpan timeSpan_0;

			// Token: 0x040022A6 RID: 8870
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200080B RID: 2059
		[StructLayout(LayoutKind.Auto)]
		private struct Struct618 : IAsyncStateMachine
		{
			// Token: 0x060031C0 RID: 12736 RVA: 0x000C0AC8 File Offset: 0x000BECC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
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
						goto IL_157;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1B9;
					default:
						this.class920_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class920();
						this.class920_0.uielement_0 = this.uielement_0;
						this.class920_0.int_0 = this.int_1;
						if (this.class920_0.uielement_0 == null)
						{
							goto IL_1E0;
						}
						if (Class551.class753_0.method_52().GetValueOrDefault())
						{
							awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class920_0.method_0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct618>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class920_0.method_1)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct618>(ref awaiter, ref this);
								return;
							}
							goto IL_157;
						}
						break;
					}
					awaiter.GetResult();
					goto IL_1E0;
					IL_157:
					awaiter.GetResult();
					awaiter = Task.Delay(this.class920_0.int_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct618>(ref awaiter, ref this);
						return;
					}
					IL_1B9:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class920_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1E0:
				this.int_0 = -2;
				this.class920_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060031C1 RID: 12737 RVA: 0x0001F526 File Offset: 0x0001D726
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022A7 RID: 8871
			public int int_0;

			// Token: 0x040022A8 RID: 8872
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040022A9 RID: 8873
			public UIElement uielement_0;

			// Token: 0x040022AA RID: 8874
			public int int_1;

			// Token: 0x040022AB RID: 8875
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class920 class920_0;

			// Token: 0x040022AC RID: 8876
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200080C RID: 2060
		[StructLayout(LayoutKind.Auto)]
		private struct Struct619 : IAsyncStateMachine
		{
			// Token: 0x060031C2 RID: 12738 RVA: 0x000C0CEC File Offset: 0x000BEEEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.uielement_0, (int)this.timeSpan_0.TotalMilliseconds).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct619>(ref awaiter, ref this);
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
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060031C3 RID: 12739 RVA: 0x0001F534 File Offset: 0x0001D734
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022AD RID: 8877
			public int int_0;

			// Token: 0x040022AE RID: 8878
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040022AF RID: 8879
			public UIElement uielement_0;

			// Token: 0x040022B0 RID: 8880
			public TimeSpan timeSpan_0;

			// Token: 0x040022B1 RID: 8881
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200080D RID: 2061
		private sealed class Class924
		{
			// Token: 0x060031C5 RID: 12741 RVA: 0x000C0DA8 File Offset: 0x000BEFA8
			internal void method_0()
			{
				DoubleAnimation animation = new DoubleAnimation
				{
					Duration = this.duration_0,
					To = new double?(this.double_0),
					EasingFunction = new QuadraticEase
					{
						EasingMode = EasingMode.EaseOut
					}
				};
				this.uielement_0.BeginAnimation(this.dependencyProperty_0, animation);
			}

			// Token: 0x040022B2 RID: 8882
			public double double_0;

			// Token: 0x040022B3 RID: 8883
			public UIElement uielement_0;

			// Token: 0x040022B4 RID: 8884
			public DependencyProperty dependencyProperty_0;

			// Token: 0x040022B5 RID: 8885
			public Duration duration_0;
		}

		// Token: 0x0200080E RID: 2062
		private sealed class Class925
		{
			// Token: 0x060031C7 RID: 12743 RVA: 0x0001F542 File Offset: 0x0001D742
			internal void method_0()
			{
				this.uielement_0.Visibility = Visibility.Collapsed;
			}

			// Token: 0x040022B6 RID: 8886
			public UIElement uielement_0;
		}

		// Token: 0x0200080F RID: 2063
		[StructLayout(LayoutKind.Auto)]
		private struct Struct620 : IAsyncStateMachine
		{
			// Token: 0x060031C8 RID: 12744 RVA: 0x000C0DFC File Offset: 0x000BEFFC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(this.uielement_0, 200).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct620>(ref awaiter, ref this);
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

			// Token: 0x060031C9 RID: 12745 RVA: 0x0001F550 File Offset: 0x0001D750
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022B7 RID: 8887
			public int int_0;

			// Token: 0x040022B8 RID: 8888
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040022B9 RID: 8889
			public UIElement uielement_0;

			// Token: 0x040022BA RID: 8890
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000810 RID: 2064
		[StructLayout(LayoutKind.Auto)]
		private struct Struct621 : IAsyncStateMachine
		{
			// Token: 0x060031CA RID: 12746 RVA: 0x000C0EB4 File Offset: 0x000BF0B4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(this.uielement_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct621>(ref awaiter, ref this);
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

			// Token: 0x060031CB RID: 12747 RVA: 0x0001F55E File Offset: 0x0001D75E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022BB RID: 8891
			public int int_0;

			// Token: 0x040022BC RID: 8892
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040022BD RID: 8893
			public UIElement uielement_0;

			// Token: 0x040022BE RID: 8894
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000811 RID: 2065
		[StructLayout(LayoutKind.Auto)]
		private struct Struct622 : IAsyncStateMachine
		{
			// Token: 0x060031CC RID: 12748 RVA: 0x000C0F68 File Offset: 0x000BF168
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
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
						goto IL_192;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_1CD;
					default:
						this.class913_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class913();
						this.class913_0.textBlock_0 = this.textBlock_0;
						this.class913_0.int_0 = (int)this.double_0;
						if (!Class551.class753_0.method_52().GetValueOrDefault())
						{
							this.int_1 = 2500 / ((this.class913_0.int_0 > 0) ? this.class913_0.int_0 : 1);
							this.class913_0.int_1 = 0;
							goto IL_14B;
						}
						awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class913_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct622>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					goto IL_239;
					IL_14B:
					if (this.class913_0.int_1 > this.class913_0.int_0)
					{
						goto IL_239;
					}
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class913_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct622>(ref awaiter, ref this);
						return;
					}
					IL_192:
					awaiter.GetResult();
					int num2 = this.class913_0.int_1;
					this.class913_0.int_1 = num2 + 1;
					awaiter = Task.Delay(this.int_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct622>(ref awaiter, ref this);
						return;
					}
					IL_1CD:
					awaiter.GetResult();
					goto IL_14B;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class913_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_239:
				this.int_0 = -2;
				this.class913_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060031CD RID: 12749 RVA: 0x0001F56C File Offset: 0x0001D76C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022BF RID: 8895
			public int int_0;

			// Token: 0x040022C0 RID: 8896
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040022C1 RID: 8897
			public TextBlock textBlock_0;

			// Token: 0x040022C2 RID: 8898
			public double double_0;

			// Token: 0x040022C3 RID: 8899
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class913 class913_0;

			// Token: 0x040022C4 RID: 8900
			private int int_1;

			// Token: 0x040022C5 RID: 8901
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000812 RID: 2066
		private sealed class Class926
		{
			// Token: 0x060031CF RID: 12751 RVA: 0x000C11E4 File Offset: 0x000BF3E4
			internal void method_0()
			{
				Storyboard.SetTarget(this.thicknessAnimation_0, this.uielement_0);
				Storyboard.SetTargetProperty(this.thicknessAnimation_0, new PropertyPath("Margin", Array.Empty<object>()));
				new Storyboard
				{
					Children = 
					{
						this.thicknessAnimation_0
					}
				}.Begin();
			}

			// Token: 0x040022C6 RID: 8902
			public ThicknessAnimation thicknessAnimation_0;

			// Token: 0x040022C7 RID: 8903
			public UIElement uielement_0;
		}

		// Token: 0x02000813 RID: 2067
		[StructLayout(LayoutKind.Auto)]
		private struct Struct623 : IAsyncStateMachine
		{
			// Token: 0x060031D0 RID: 12752 RVA: 0x000C1238 File Offset: 0x000BF438
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Func<Task>(new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class927
						{
							timeSpan_0 = this.timeSpan_0,
							uielement_0 = this.uielement_0
						}.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct623>(ref awaiter, ref this);
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

			// Token: 0x060031D1 RID: 12753 RVA: 0x0001F57A File Offset: 0x0001D77A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022C8 RID: 8904
			public int int_0;

			// Token: 0x040022C9 RID: 8905
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040022CA RID: 8906
			public TimeSpan timeSpan_0;

			// Token: 0x040022CB RID: 8907
			public UIElement uielement_0;

			// Token: 0x040022CC RID: 8908
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000814 RID: 2068
		private sealed class Class927
		{
			// Token: 0x060031D3 RID: 12755 RVA: 0x000C130C File Offset: 0x000BF50C
			internal Task method_0()
			{
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class927.Struct624 @struct;
				@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
				@struct.class927_0 = this;
				@struct.int_0 = -1;
				@struct.asyncTaskMethodBuilder_0.Start<dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class927.Struct624>(ref @struct);
				return @struct.asyncTaskMethodBuilder_0.Task;
			}

			// Token: 0x060031D4 RID: 12756 RVA: 0x0001F588 File Offset: 0x0001D788
			internal void method_1()
			{
				this.uielement_0.Visibility = Visibility.Visible;
			}

			// Token: 0x040022CD RID: 8909
			public TimeSpan timeSpan_0;

			// Token: 0x040022CE RID: 8910
			public UIElement uielement_0;

			// Token: 0x040022CF RID: 8911
			public Action action_0;

			// Token: 0x02000815 RID: 2069
			[StructLayout(LayoutKind.Auto)]
			private struct Struct624 : IAsyncStateMachine
			{
				// Token: 0x060031D5 RID: 12757 RVA: 0x000C1350 File Offset: 0x000BF550
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class927 @class = this.class927_0;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = this.taskAwaiter_0;
								this.taskAwaiter_0 = default(TaskAwaiter);
								this.int_0 = -1;
								goto IL_F3;
							}
							awaiter = Task.Delay(@class.timeSpan_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class927.Struct624>(ref awaiter, ref this);
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
						Dispatcher dispatcher = Application.Current.Dispatcher;
						Action callback;
						if ((callback = @class.action_0) == null)
						{
							callback = (@class.action_0 = new Action(@class.method_1));
						}
						awaiter = dispatcher.InvokeAsync(callback).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class927.Struct624>(ref awaiter, ref this);
							return;
						}
						IL_F3:
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncTaskMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetResult();
				}

				// Token: 0x060031D6 RID: 12758 RVA: 0x0001F596 File Offset: 0x0001D796
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
				}

				// Token: 0x040022D0 RID: 8912
				public int int_0;

				// Token: 0x040022D1 RID: 8913
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040022D2 RID: 8914
				public dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class927 class927_0;

				// Token: 0x040022D3 RID: 8915
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x02000816 RID: 2070
		[StructLayout(LayoutKind.Auto)]
		private struct Struct625 : IAsyncStateMachine
		{
			// Token: 0x060031D7 RID: 12759 RVA: 0x000C1498 File Offset: 0x000BF698
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_25(this.uielement_0, this.int_1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct625>(ref awaiter, ref this);
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

			// Token: 0x060031D8 RID: 12760 RVA: 0x0001F5A4 File Offset: 0x0001D7A4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022D4 RID: 8916
			public int int_0;

			// Token: 0x040022D5 RID: 8917
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040022D6 RID: 8918
			public UIElement uielement_0;

			// Token: 0x040022D7 RID: 8919
			public int int_1;

			// Token: 0x040022D8 RID: 8920
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000817 RID: 2071
		[Serializable]
		private sealed class Class928
		{
			// Token: 0x060031DB RID: 12763 RVA: 0x0001F5BE File Offset: 0x0001D7BE
			internal int method_0(KeyValuePair<Color, int> keyValuePair_0)
			{
				return keyValuePair_0.Value;
			}

			// Token: 0x040022D9 RID: 8921
			public static readonly dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class928 class928_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class928();

			// Token: 0x040022DA RID: 8922
			public static Func<KeyValuePair<Color, int>, int> func_0;
		}

		// Token: 0x02000818 RID: 2072
		[StructLayout(LayoutKind.Auto)]
		private struct Struct626 : IAsyncStateMachine
		{
			// Token: 0x060031DC RID: 12764 RVA: 0x000C1550 File Offset: 0x000BF750
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_105;
						}
						this.class914_0 = new dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class914();
						this.class914_0.uielement_0 = this.uielement_0;
						awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class914_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct626>(ref awaiter, ref this);
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
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.class914_0.uielement_0, this.int_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Struct626>(ref awaiter, ref this);
						return;
					}
					IL_105:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class914_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class914_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060031DD RID: 12765 RVA: 0x0001F5C7 File Offset: 0x0001D7C7
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040022DB RID: 8923
			public int int_0;

			// Token: 0x040022DC RID: 8924
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040022DD RID: 8925
			public UIElement uielement_0;

			// Token: 0x040022DE RID: 8926
			private dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.Class914 class914_0;

			// Token: 0x040022DF RID: 8927
			public int int_1;

			// Token: 0x040022E0 RID: 8928
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000819 RID: 2073
		private sealed class Class929
		{
			// Token: 0x060031DF RID: 12767 RVA: 0x0001F5D5 File Offset: 0x0001D7D5
			internal void method_0()
			{
				this.textBlock_0.Text = this.string_0;
				this.textBlock_0.Foreground = this.solidColorBrush_0;
			}

			// Token: 0x040022E1 RID: 8929
			public TextBlock textBlock_0;

			// Token: 0x040022E2 RID: 8930
			public string string_0;

			// Token: 0x040022E3 RID: 8931
			public SolidColorBrush solidColorBrush_0;
		}
	}
}
