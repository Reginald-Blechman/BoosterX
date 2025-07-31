using System;
using System.Windows;
using System.Windows.Controls;

namespace ns0
{
	// Token: 0x02000737 RID: 1847
	public class dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd : Page
	{
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x0001D7B1 File Offset: 0x0001B9B1
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x0001D7C3 File Offset: 0x0001B9C3
		public bool OnlyPCores
		{
			get
			{
				return (bool)base.GetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_0);
			}
			set
			{
				base.SetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_0, value);
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x0001D7D6 File Offset: 0x0001B9D6
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x0001D7E8 File Offset: 0x0001B9E8
		public bool DisableCore0
		{
			get
			{
				return (bool)base.GetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_1);
			}
			set
			{
				base.SetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_1, value);
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x0001D7FB File Offset: 0x0001B9FB
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x0001D80D File Offset: 0x0001BA0D
		public bool DisableHyperThreading
		{
			get
			{
				return (bool)base.GetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_2);
			}
			set
			{
				base.SetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_2, value);
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x0001D820 File Offset: 0x0001BA20
		// (set) Token: 0x06002E17 RID: 11799 RVA: 0x0001D832 File Offset: 0x0001BA32
		public bool CustomChoose
		{
			get
			{
				return (bool)base.GetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_3);
			}
			set
			{
				base.SetValue(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd.dependencyProperty_3, value);
			}
		}

		// Token: 0x04001E6F RID: 7791
		public static readonly DependencyProperty dependencyProperty_0 = DependencyProperty.Register("OnlyPCores", typeof(bool), typeof(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd), new UIPropertyMetadata(false));

		// Token: 0x04001E70 RID: 7792
		public static readonly DependencyProperty dependencyProperty_1 = DependencyProperty.Register("DisableCore0", typeof(bool), typeof(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd), new UIPropertyMetadata(false));

		// Token: 0x04001E71 RID: 7793
		public static readonly DependencyProperty dependencyProperty_2 = DependencyProperty.Register("DisableHyperThreading", typeof(bool), typeof(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd), new UIPropertyMetadata(false));

		// Token: 0x04001E72 RID: 7794
		public static readonly DependencyProperty dependencyProperty_3 = DependencyProperty.Register("CustomChoose", typeof(bool), typeof(dje_z2VV9SX855TTC38PL5F2XNUVTSA5WTHAHNLFTD5ZNGMDE87Z_ejd), new UIPropertyMetadata(false));
	}
}
