using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x020007B4 RID: 1972
	internal sealed class dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd : MarkupExtension
	{
		// Token: 0x06003008 RID: 12296 RVA: 0x0001E998 File Offset: 0x0001CB98
		public dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd()
		{
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x0001E9A0 File Offset: 0x0001CBA0
		public dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd(string string_2)
		{
			this.Path = new PropertyPath(string_2, Array.Empty<object>());
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x0001E9F1 File Offset: 0x0001CBF1
		public static object GetResourceBindingKeyHelper(DependencyObject dependencyObject_0)
		{
			return dependencyObject_0.GetValue(dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd.dependencyProperty_0);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x0001E9FE File Offset: 0x0001CBFE
		public static void SetResourceBindingKeyHelper(DependencyObject dependencyObject_0, object object_3)
		{
			dependencyObject_0.SetValue(dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd.dependencyProperty_0, object_3);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000B8BBC File Offset: 0x000B6DBC
		private static void smethod_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			FrameworkElement frameworkElement = dependencyObject_0 as FrameworkElement;
			Tuple<object, DependencyProperty> tuple = dependencyPropertyChangedEventArgs_0.NewValue as Tuple<object, DependencyProperty>;
			if (frameworkElement == null || tuple == null)
			{
				return;
			}
			DependencyProperty item = tuple.Item2;
			if (tuple.Item1 == null)
			{
				frameworkElement.SetValue(item, item.GetMetadata(frameworkElement).DefaultValue);
				return;
			}
			frameworkElement.SetResourceReference(item, tuple.Item1);
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x000B8C14 File Offset: 0x000B6E14
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			IProvideValueTarget provideValueTarget = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));
			if (provideValueTarget == null)
			{
				return null;
			}
			if (provideValueTarget.TargetObject != null && provideValueTarget.TargetObject.GetType().FullName == "System.Windows.SharedDp")
			{
				return this;
			}
			FrameworkElement frameworkElement = provideValueTarget.TargetObject as FrameworkElement;
			DependencyProperty dependencyProperty = provideValueTarget.TargetProperty as DependencyProperty;
			if (frameworkElement != null && dependencyProperty != null)
			{
				Binding binding = new Binding();
				binding.Path = this.Path;
				binding.XPath = this.String_0;
				binding.Mode = this.BindingMode_0;
				binding.UpdateSourceTrigger = this.UpdateSourceTrigger_0;
				binding.Converter = this.IValueConverter_0;
				binding.ConverterParameter = this.Object_0;
				binding.ConverterCulture = this.CultureInfo_0;
				if (this.RelativeSource_0 != null)
				{
					binding.RelativeSource = this.RelativeSource_0;
				}
				if (this.String_1 != null)
				{
					binding.ElementName = this.String_1;
				}
				if (this.method_0() != null)
				{
					binding.Source = this.method_0();
				}
				binding.FallbackValue = this.method_2();
				MultiBinding multiBinding = new MultiBinding
				{
					Converter = dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd.Class906.class906_0,
					ConverterParameter = dependencyProperty
				};
				multiBinding.Bindings.Add(binding);
				multiBinding.NotifyOnSourceUpdated = true;
				frameworkElement.SetBinding(dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd.dependencyProperty_0, multiBinding);
				return null;
			}
			return null;
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0001EA0C File Offset: 0x0001CC0C
		public object method_0()
		{
			return this.object_0;
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0001EA14 File Offset: 0x0001CC14
		public void method_1(object object_3)
		{
			this.object_0 = object_3;
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x0001EA1D File Offset: 0x0001CC1D
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x0001EA25 File Offset: 0x0001CC25
		public PropertyPath Path
		{
			[CompilerGenerated]
			get
			{
				return this.propertyPath_0;
			}
			[CompilerGenerated]
			set
			{
				this.propertyPath_0 = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x0001EA2E File Offset: 0x0001CC2E
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x0001EA36 File Offset: 0x0001CC36
		[DefaultValue(null)]
		public string String_0
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06003015 RID: 12309 RVA: 0x0001EA3F File Offset: 0x0001CC3F
		// (set) Token: 0x06003016 RID: 12310 RVA: 0x0001EA47 File Offset: 0x0001CC47
		[DefaultValue(BindingMode.Default)]
		public BindingMode BindingMode_0
		{
			get
			{
				return this.bindingMode_0;
			}
			set
			{
				this.bindingMode_0 = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x0001EA50 File Offset: 0x0001CC50
		// (set) Token: 0x06003018 RID: 12312 RVA: 0x0001EA58 File Offset: 0x0001CC58
		[DefaultValue(UpdateSourceTrigger.Default)]
		public UpdateSourceTrigger UpdateSourceTrigger_0
		{
			get
			{
				return this.updateSourceTrigger_0;
			}
			set
			{
				this.updateSourceTrigger_0 = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x0001EA61 File Offset: 0x0001CC61
		// (set) Token: 0x0600301A RID: 12314 RVA: 0x0001EA69 File Offset: 0x0001CC69
		[DefaultValue(null)]
		public IValueConverter IValueConverter_0
		{
			get
			{
				return this.ivalueConverter_0;
			}
			set
			{
				this.ivalueConverter_0 = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x0001EA72 File Offset: 0x0001CC72
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x0001EA7A File Offset: 0x0001CC7A
		[DefaultValue(null)]
		public object Object_0
		{
			get
			{
				return this.object_1;
			}
			set
			{
				this.object_1 = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x0001EA83 File Offset: 0x0001CC83
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x0001EA8B File Offset: 0x0001CC8B
		[DefaultValue(null)]
		[TypeConverter(typeof(CultureInfoIetfLanguageTagConverter))]
		public CultureInfo CultureInfo_0
		{
			get
			{
				return this.cultureInfo_0;
			}
			set
			{
				this.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x0001EA94 File Offset: 0x0001CC94
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x0001EA9C File Offset: 0x0001CC9C
		[DefaultValue(null)]
		public RelativeSource RelativeSource_0
		{
			get
			{
				return this.relativeSource_0;
			}
			set
			{
				this.relativeSource_0 = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x0001EAA5 File Offset: 0x0001CCA5
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x0001EAAD File Offset: 0x0001CCAD
		[DefaultValue(null)]
		public string String_1
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0001EAB6 File Offset: 0x0001CCB6
		public object method_2()
		{
			return this.object_2;
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x0001EABE File Offset: 0x0001CCBE
		public void method_3(object object_3)
		{
			this.object_2 = object_3;
		}

		// Token: 0x040020A8 RID: 8360
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.RegisterAttached("ResourceBindingKeyHelper", typeof(object), typeof(dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd), new PropertyMetadata(null, new PropertyChangedCallback(dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd.smethod_0)));

		// Token: 0x040020A9 RID: 8361
		private object object_0;

		// Token: 0x040020AA RID: 8362
		private PropertyPath propertyPath_0;

		// Token: 0x040020AB RID: 8363
		private string string_0;

		// Token: 0x040020AC RID: 8364
		private BindingMode bindingMode_0;

		// Token: 0x040020AD RID: 8365
		private UpdateSourceTrigger updateSourceTrigger_0;

		// Token: 0x040020AE RID: 8366
		private IValueConverter ivalueConverter_0;

		// Token: 0x040020AF RID: 8367
		private object object_1;

		// Token: 0x040020B0 RID: 8368
		private CultureInfo cultureInfo_0;

		// Token: 0x040020B1 RID: 8369
		private RelativeSource relativeSource_0;

		// Token: 0x040020B2 RID: 8370
		private string string_1;

		// Token: 0x040020B3 RID: 8371
		private object object_2;

		// Token: 0x020007B5 RID: 1973
		private sealed class Class906 : IMultiValueConverter
		{
			// Token: 0x06003027 RID: 12327 RVA: 0x0001EAD3 File Offset: 0x0001CCD3
			public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
			{
				return Tuple.Create<object, DependencyProperty>(values[0], (DependencyProperty)parameter);
			}

			// Token: 0x06003028 RID: 12328 RVA: 0x00003C75 File Offset: 0x00001E75
			public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
			{
				throw new NotImplementedException();
			}

			// Token: 0x040020B4 RID: 8372
			public static readonly dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd.Class906 class906_0 = new dje_zC6BH2BMHSD6HC3CUA7UN9Y8ZJ7SA_ejd.Class906();
		}
	}
}
