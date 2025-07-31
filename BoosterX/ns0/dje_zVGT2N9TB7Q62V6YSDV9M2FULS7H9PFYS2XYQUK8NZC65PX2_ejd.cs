using System;
using System.Windows;
using System.Windows.Controls;

namespace ns0
{
	// Token: 0x020008A2 RID: 2210
	public class dje_zVGT2N9TB7Q62V6YSDV9M2FULS7H9PFYS2XYQUK8NZC65PX2_ejd : UserControl
	{
		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x000208FC File Offset: 0x0001EAFC
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x0002090E File Offset: 0x0001EB0E
		public double ArcThick
		{
			get
			{
				return (double)base.GetValue(dje_zVGT2N9TB7Q62V6YSDV9M2FULS7H9PFYS2XYQUK8NZC65PX2_ejd.dependencyProperty_0);
			}
			set
			{
				base.SetValue(dje_zVGT2N9TB7Q62V6YSDV9M2FULS7H9PFYS2XYQUK8NZC65PX2_ejd.dependencyProperty_0, value);
			}
		}

		// Token: 0x0400259A RID: 9626
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("ArcThick", typeof(double), typeof(dje_zQQ3JN9ADCGYR5H5PW6QNZTKYDE65KB9X3TDB2DTZ4QH5TK5SPE7YE_ejd), new UIPropertyMetadata(double.NaN));
	}
}
