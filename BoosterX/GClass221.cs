using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

// Token: 0x020004FB RID: 1275
public sealed class GClass221 : IValueConverter
{
	// Token: 0x06002051 RID: 8273 RVA: 0x00082F1C File Offset: 0x0008111C
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is double)
		{
			double num = (double)value;
			return Math.Max(0.0, num - 35.0);
		}
		return DependencyProperty.UnsetValue;
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x000031EC File Offset: 0x000013EC
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}
}
