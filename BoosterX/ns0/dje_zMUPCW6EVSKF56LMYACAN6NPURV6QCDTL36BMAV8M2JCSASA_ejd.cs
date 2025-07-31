using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ns0
{
	// Token: 0x02000856 RID: 2134
	public sealed class dje_zMUPCW6EVSKF56LMYACAN6NPURV6QCDTL36BMAV8M2JCSASA_ejd : IValueConverter
	{
		// Token: 0x0600330C RID: 13068 RVA: 0x000C5BBC File Offset: 0x000C3DBC
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is double)
			{
				double num = (double)value;
				return num / 2.0;
			}
			return DependencyProperty.UnsetValue;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000039D3 File Offset: 0x00001BD3
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}
