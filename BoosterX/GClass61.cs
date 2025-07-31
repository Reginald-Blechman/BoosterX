using System;
using System.Windows;

// Token: 0x0200023E RID: 574
public static class GClass61
{
	// Token: 0x06000F9B RID: 3995 RVA: 0x00054B10 File Offset: 0x00052D10
	public static void smethod_0(Point[] point_0, out Point[] point_1, out Point[] point_2)
	{
		if (point_0 == null)
		{
			throw new ArgumentNullException("#=zjAkhkpwgVyB0");
		}
		int num = point_0.Length - 1;
		if (num < 1)
		{
			throw new ArgumentException("At least two knot points required", "#=zjAkhkpwgVyB0");
		}
		if (num == 1)
		{
			point_1 = new Point[1];
			point_1[0].X = (2.0 * point_0[0].X + point_0[1].X) / 3.0;
			point_1[0].Y = (2.0 * point_0[0].Y + point_0[1].Y) / 3.0;
			point_2 = new Point[1];
			point_2[0].X = 2.0 * point_1[0].X - point_0[0].X;
			point_2[0].Y = 2.0 * point_1[0].Y - point_0[0].Y;
			return;
		}
		double[] array = new double[num];
		for (int i = 1; i < num - 1; i++)
		{
			array[i] = 4.0 * point_0[i].X + 2.0 * point_0[i + 1].X;
		}
		array[0] = point_0[0].X + 2.0 * point_0[1].X;
		array[num - 1] = (8.0 * point_0[num - 1].X + point_0[num].X) / 2.0;
		double[] array2 = GClass61.smethod_1(array);
		for (int j = 1; j < num - 1; j++)
		{
			array[j] = 4.0 * point_0[j].Y + 2.0 * point_0[j + 1].Y;
		}
		array[0] = point_0[0].Y + 2.0 * point_0[1].Y;
		array[num - 1] = (8.0 * point_0[num - 1].Y + point_0[num].Y) / 2.0;
		double[] array3 = GClass61.smethod_1(array);
		point_1 = new Point[num];
		point_2 = new Point[num];
		for (int k = 0; k < num; k++)
		{
			point_1[k] = new Point(array2[k], array3[k]);
			if (k < num - 1)
			{
				point_2[k] = new Point(2.0 * point_0[k + 1].X - array2[k + 1], 2.0 * point_0[k + 1].Y - array3[k + 1]);
			}
			else
			{
				point_2[k] = new Point((point_0[num].X + array2[num - 1]) / 2.0, (point_0[num].Y + array3[num - 1]) / 2.0);
			}
		}
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00054E5C File Offset: 0x0005305C
	private static double[] smethod_1(double[] double_0)
	{
		int num = double_0.Length;
		double[] array = new double[num];
		double[] array2 = new double[num];
		double num2 = 2.0;
		array[0] = double_0[0] / num2;
		for (int i = 1; i < num; i++)
		{
			array2[i] = 1.0 / num2;
			num2 = ((i < num - 1) ? 4.0 : 3.5) - array2[i];
			array[i] = (double_0[i] - array[i - 1]) / num2;
		}
		for (int j = 1; j < num; j++)
		{
			array[num - j - 1] -= array2[num - j] * array[num - j];
		}
		return array;
	}
}
