using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using PIManagerX;

namespace ns0
{
	// Token: 0x0200071C RID: 1820
	public sealed class dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd : UserControl, IComponentConnector, GInterface0
	{
		// Token: 0x06002D61 RID: 11617 RVA: 0x0001D270 File Offset: 0x0001B470
		public dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd_Loaded;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x0001D290 File Offset: 0x0001B490
		[CompilerGenerated]
		public bool imethod_0()
		{
			return this.bool_0;
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x0001D298 File Offset: 0x0001B498
		public void method_0(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x000AE55C File Offset: 0x000AC75C
		public void method_1()
		{
			List<GClass187> list = PManagerX.GetMonitors().Select(new Func<PManagerX.MonitorModel, int, GClass187>(this.method_2)).ToList<GClass187>();
			this.itemsControl_0.ItemsSource = list;
			this.method_0(list.Any(new Func<GClass187, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd.Class876.class876_0.method_0)));
			this.stackPanel_1.Visibility = (this.imethod_0() ? Visibility.Collapsed : Visibility.Visible);
			this.stackPanel_0.Visibility = (this.imethod_0() ? Visibility.Visible : Visibility.Collapsed);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000AE5EC File Offset: 0x000AC7EC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/gamereadyx/usercontrols/monitorchecker/monitorcheckeruc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000AE620 File Offset: 0x000AC820
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 3:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 4:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x0001D2A1 File Offset: 0x0001B4A1
		private void dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x0001D2A9 File Offset: 0x0001B4A9
		private GClass187 method_2(PManagerX.MonitorModel monitorModel_0, int int_0)
		{
			return new GClass187(monitorModel_0, int_0 + 1, this);
		}

		// Token: 0x04001DCD RID: 7629
		private bool bool_0;

		// Token: 0x04001DCE RID: 7630
		internal CheckBox checkBox_0;

		// Token: 0x04001DCF RID: 7631
		internal StackPanel stackPanel_0;

		// Token: 0x04001DD0 RID: 7632
		internal StackPanel stackPanel_1;

		// Token: 0x04001DD1 RID: 7633
		internal ItemsControl itemsControl_0;

		// Token: 0x04001DD2 RID: 7634
		private bool bool_1;

		// Token: 0x0200071D RID: 1821
		[Serializable]
		private sealed class Class876
		{
			// Token: 0x06002D6B RID: 11627 RVA: 0x0001D2C1 File Offset: 0x0001B4C1
			internal bool method_0(GClass187 gclass187_0)
			{
				return gclass187_0.HasProblem;
			}

			// Token: 0x04001DD3 RID: 7635
			public static readonly dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd.Class876 class876_0 = new dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd.Class876();

			// Token: 0x04001DD4 RID: 7636
			public static Func<GClass187, bool> func_0;
		}
	}
}
