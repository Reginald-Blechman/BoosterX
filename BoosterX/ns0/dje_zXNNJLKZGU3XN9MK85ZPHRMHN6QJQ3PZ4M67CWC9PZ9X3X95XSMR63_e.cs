using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Effects;

namespace ns0
{
	// Token: 0x020008D0 RID: 2256
	public sealed class dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd : UserControl, IComponentConnector
	{
		// Token: 0x0600351C RID: 13596 RVA: 0x00021153 File Offset: 0x0001F353
		public dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00021161 File Offset: 0x0001F361
		private void method_0(object sender, RoutedEventArgs e)
		{
			if (this.checkBox_0.Foreground == dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd && !this.bool_0)
			{
				return;
			}
			this.checkBox_1.IsChecked = new bool?(true);
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0002118F File Offset: 0x0001F38F
		private void method_1(object sender, RoutedEventArgs e)
		{
			this.checkBox_1.IsChecked = new bool?(false);
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x000211A2 File Offset: 0x0001F3A2
		private void method_2(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x000211BF File Offset: 0x0001F3BF
		private void method_3(object sender, KeyEventArgs e)
		{
			this.bool_0 = false;
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x000CF714 File Offset: 0x000CD914
		private void method_4(object sender, RoutedEventArgs e)
		{
			this.checkBox_1.IsChecked = !this.checkBox_1.IsChecked;
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x000CF75C File Offset: 0x000CD95C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicesgroupcontroller/threestatecheckbox.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x000CF790 File Offset: 0x000CD990
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd)target).KeyDown += this.method_2;
				((dje_zXNNJLKZGU3XN9MK85ZPHRMHN6QJQ3PZ4M67CWC9PZ9X3X95XSMR63_ejd)target).KeyUp += this.method_3;
				return;
			case 2:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 3:
				this.dropShadowEffect_0 = (DropShadowEffect)target;
				return;
			case 4:
				this.dropShadowEffect_1 = (DropShadowEffect)target;
				return;
			case 5:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 6:
				((Button)target).Click += this.method_0;
				return;
			case 7:
				((Button)target).Click += this.method_1;
				return;
			case 8:
				((Button)target).Click += this.method_4;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x04002681 RID: 9857
		private bool bool_0;

		// Token: 0x04002682 RID: 9858
		internal CheckBox checkBox_0;

		// Token: 0x04002683 RID: 9859
		internal DropShadowEffect dropShadowEffect_0;

		// Token: 0x04002684 RID: 9860
		internal DropShadowEffect dropShadowEffect_1;

		// Token: 0x04002685 RID: 9861
		internal CheckBox checkBox_1;

		// Token: 0x04002686 RID: 9862
		private bool bool_1;
	}
}
