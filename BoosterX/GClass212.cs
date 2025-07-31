using System;
using System.Globalization;
using System.Windows.Media;

// Token: 0x0200048A RID: 1162
public static class GClass212
{
	// Token: 0x06001E2B RID: 7723 RVA: 0x00013E90 File Offset: 0x00012090
	public static Geometry smethod_0(double double_0, double double_1, double double_2, double double_3)
	{
		return GClass212.smethod_1(double_0, double_1, double_2, double_3);
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x0007BFC8 File Offset: 0x0007A1C8
	private static Geometry smethod_1(double double_0, double double_1, double double_2, double double_3)
	{
		if (double_2 < 0.0)
		{
			double_2 = 0.0;
		}
		double num = Math.Min(double_0, double_1) / 2.0;
		double_2 = Math.Min(double_2, num);
		double num2;
		if (double_3 >= 0.0)
		{
			if (double_3 <= 1.0)
			{
				num2 = double_3;
			}
			else
			{
				num2 = 1.0;
			}
		}
		else
		{
			num2 = 0.0;
		}
		double_3 = num2;
		double num3 = GClass212.smethod_3(double_3, double_2, num);
		double num4 = GClass212.smethod_4(num3);
		return Geometry.Parse(GClass212.smethod_5(double_0, double_1, double_2 * num3, double_2 * num4));
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x0007C064 File Offset: 0x0007A264
	private static double smethod_2(double double_0, double double_1)
	{
		if (double_0 <= 0.0)
		{
			return 0.0;
		}
		double num = double_1 / double_0;
		if (num > 2.341)
		{
			return 0.0;
		}
		return (2.341 - num) / 3.0;
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x0007C0B8 File Offset: 0x0007A2B8
	private static double smethod_3(double double_0, double double_1, double double_2)
	{
		double num = GClass212.smethod_2(double_1, double_2);
		double num2 = 0.447 - num;
		return 0.447 * (1.0 - double_0 * num2);
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00013E9B File Offset: 0x0001209B
	private static double smethod_4(double double_0)
	{
		return 2.341 - double_0 * 3.0;
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x0007C0F0 File Offset: 0x0007A2F0
	private static string smethod_5(double double_0, double double_1, double double_2, double double_3)
	{
		double_2 = Math.Min(double_2, double_3);
		return string.Format(CultureInfo.InvariantCulture, "M 0,{0}\r\nC 0,{1} {1},0 {0},0\r\nL {2},0\r\nC {3},0 {4},{1} {4},{0}\r\nL {4},{5}\r\nC {4},{6} {3},{7} {2},{7}\r\nL {0},{7}\r\nC {1},{7} 0,{6} 0,{5}\r\nL 0,{0}", new object[]
		{
			double_3,
			double_2,
			double_0 - double_3,
			double_0 - double_2,
			double_0,
			double_1 - double_3,
			double_1 - double_2,
			double_1
		}).Trim().Replace('\n', ' ');
	}
}
