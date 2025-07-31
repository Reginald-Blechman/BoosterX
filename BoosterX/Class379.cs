using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000322 RID: 802
internal static class Class379
{
	// Token: 0x060014D6 RID: 5334 RVA: 0x00064960 File Offset: 0x00062B60
	public static double smethod_0(List<double> list_0)
	{
		Class379.Class382 @class = new Class379.Class382();
		@class.double_0 = 0.0;
		list_0.ForEach(new Action<double>(@class.method_0));
		return @class.double_0 / (double)list_0.Count;
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x000649A4 File Offset: 0x00062BA4
	public static double smethod_1(List<double> list_0)
	{
		Class379.Class380 @class = new Class379.Class380();
		@class.list_0 = new List<double>();
		list_0.ForEach(new Action<double>(@class.method_0));
		@class.list_0.Sort();
		int count = @class.list_0.Count;
		int num = count / 2;
		if (count % 2 == 0)
		{
			return (@class.list_0[num] + @class.list_0[num - 1]) / 2.0;
		}
		return @class.list_0[num];
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x00064A24 File Offset: 0x00062C24
	public static double smethod_2(List<double> list_0)
	{
		double num = 0.0;
		for (int i = 0; i < list_0.Count - 1; i++)
		{
			num += Math.Abs(list_0[i + 1] - list_0[i]);
		}
		return num / (double)(list_0.Count - 1);
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x00064A74 File Offset: 0x00062C74
	public static int smethod_3(int int_0, int int_1)
	{
		Random obj = Class379.random_0;
		int result;
		lock (obj)
		{
			result = Class379.random_0.Next(int_0, int_1);
		}
		return result;
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x00064ABC File Offset: 0x00062CBC
	public static bool smethod_4(this double? nullable_0)
	{
		if (nullable_0 != null)
		{
			double? num = nullable_0;
			if (!(num.GetValueOrDefault() == 0.0 & num != null))
			{
				double num2 = Convert.ToDouble(nullable_0);
				if (num2 != double.NaN && !double.IsInfinity(num2) && num2 != double.NegativeInfinity)
				{
					if (num2 != double.PositiveInfinity)
					{
						return false;
					}
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x00064B30 File Offset: 0x00062D30
	public static bool smethod_5(this double? nullable_0)
	{
		if (nullable_0 != null)
		{
			double? num = nullable_0;
			if (!(num.GetValueOrDefault() <= 0.0 & num != null))
			{
				double num2 = Convert.ToDouble(nullable_0);
				if (num2 != double.NaN && !double.IsInfinity(num2) && num2 != double.NegativeInfinity)
				{
					if (num2 != double.PositiveInfinity)
					{
						return false;
					}
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x00064BA8 File Offset: 0x00062DA8
	internal static int smethod_6(string string_0)
	{
		int result;
		try
		{
			result = Convert.ToInt32(string_0);
		}
		catch
		{
			result = -1;
		}
		return result;
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x0000E7A9 File Offset: 0x0000C9A9
	public static double smethod_7(List<double> list_0)
	{
		if (list_0 == null || list_0.Count == 0)
		{
			throw new ArgumentException("The list of numbers cannot be null or empty.");
		}
		return list_0.Sum() / (double)list_0.Count;
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x00064BD4 File Offset: 0x00062DD4
	public static double smethod_8(List<double> list_0)
	{
		if (list_0 == null || list_0.Count == 0)
		{
			throw new ArgumentException("The list of numbers cannot be null or empty.");
		}
		List<double> list = new List<double>(list_0);
		list.Sort();
		int count = list.Count;
		int num = count / 2;
		if (count % 2 == 0)
		{
			return (list[num] + list[num - 1]) / 2.0;
		}
		return list[num];
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x00064C38 File Offset: 0x00062E38
	public static double smethod_9(List<double> list_0)
	{
		if (list_0 != null && list_0.Count != 0)
		{
			return list_0.GroupBy(new Func<double, double>(Class379.Class381.class381_0.method_0)).OrderByDescending(new Func<IGrouping<double, double>, int>(Class379.Class381.class381_0.method_1)).ThenBy(new Func<IGrouping<double, double>, double>(Class379.Class381.class381_0.method_2)).Select(new Func<IGrouping<double, double>, double>(Class379.Class381.class381_0.method_3)).FirstOrDefault<double>();
		}
		throw new ArgumentException("The list of numbers cannot be null or empty.");
	}

	// Token: 0x04000DE8 RID: 3560
	private static readonly Random random_0 = new Random();

	// Token: 0x02000323 RID: 803
	private sealed class Class380
	{
		// Token: 0x060014E1 RID: 5345 RVA: 0x0000E7D0 File Offset: 0x0000C9D0
		internal void method_0(double double_0)
		{
			if (double_0 != 0.0)
			{
				this.list_0.Add(double_0);
			}
		}

		// Token: 0x04000DE9 RID: 3561
		public List<double> list_0;
	}

	// Token: 0x02000324 RID: 804
	[Serializable]
	private sealed class Class381
	{
		// Token: 0x060014E4 RID: 5348 RVA: 0x0000E7F6 File Offset: 0x0000C9F6
		internal double method_0(double double_0)
		{
			return double_0;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0000E7F9 File Offset: 0x0000C9F9
		internal int method_1(IGrouping<double, double> igrouping_0)
		{
			return igrouping_0.Count<double>();
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0000E801 File Offset: 0x0000CA01
		internal double method_2(IGrouping<double, double> igrouping_0)
		{
			return igrouping_0.Key;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0000E801 File Offset: 0x0000CA01
		internal double method_3(IGrouping<double, double> igrouping_0)
		{
			return igrouping_0.Key;
		}

		// Token: 0x04000DEA RID: 3562
		public static readonly Class379.Class381 class381_0 = new Class379.Class381();

		// Token: 0x04000DEB RID: 3563
		public static Func<double, double> func_0;

		// Token: 0x04000DEC RID: 3564
		public static Func<IGrouping<double, double>, int> func_1;

		// Token: 0x04000DED RID: 3565
		public static Func<IGrouping<double, double>, double> func_2;

		// Token: 0x04000DEE RID: 3566
		public static Func<IGrouping<double, double>, double> func_3;
	}

	// Token: 0x02000325 RID: 805
	private sealed class Class382
	{
		// Token: 0x060014E9 RID: 5353 RVA: 0x0000E809 File Offset: 0x0000CA09
		internal void method_0(double double_1)
		{
			if (double_1 != 0.0)
			{
				this.double_0 += double_1;
			}
		}

		// Token: 0x04000DEF RID: 3567
		public double double_0;
	}
}
