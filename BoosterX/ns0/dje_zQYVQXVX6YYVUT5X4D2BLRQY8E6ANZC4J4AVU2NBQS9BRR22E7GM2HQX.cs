using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000868 RID: 2152
	public sealed class dje_zQYVQXVX6YYVUT5X4D2BLRQY8E6ANZC4J4AVU2NBQS9BRR22E7GM2HQX72SYC57TC2W_ejd : RadioButton, IComponentConnector
	{
		// Token: 0x0600334D RID: 13133 RVA: 0x000202CC File Offset: 0x0001E4CC
		public dje_zQYVQXVX6YYVUT5X4D2BLRQY8E6ANZC4J4AVU2NBQS9BRR22E7GM2HQX72SYC57TC2W_ejd()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000C72B8 File Offset: 0x000C54B8
		private void method_0(object sender, RoutedEventArgs e)
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				e.Handled = true;
				return;
			}
			if (base.IsChecked.GetValueOrDefault())
			{
				base.IsChecked = new bool?(false);
			}
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000202DA File Offset: 0x0001E4DA
		private void method_1(object sender, RoutedEventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x000C72F8 File Offset: 0x000C54F8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/gamemodexucs/gmxgamesuc.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x000202E3 File Offset: 0x0001E4E3
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((dje_zQYVQXVX6YYVUT5X4D2BLRQY8E6ANZC4J4AVU2NBQS9BRR22E7GM2HQX72SYC57TC2W_ejd)target).Checked += this.method_1;
				((dje_zQYVQXVX6YYVUT5X4D2BLRQY8E6ANZC4J4AVU2NBQS9BRR22E7GM2HQX72SYC57TC2W_ejd)target).Click += this.method_0;
				return;
			}
			this.bool_1 = true;
		}

		// Token: 0x04002453 RID: 9299
		private bool bool_0;

		// Token: 0x04002454 RID: 9300
		private bool bool_1;
	}
}
