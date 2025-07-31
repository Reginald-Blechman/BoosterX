using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x02000829 RID: 2089
	public sealed class dje_zJ9NUKRLGXC7JDT9ZUAF84NEVZ6WFZLVPU4EHJ856D2FJFNCVR2P34_ejd : Page, IComponentConnector
	{
		// Token: 0x06003220 RID: 12832 RVA: 0x0001F86C File Offset: 0x0001DA6C
		public dje_zJ9NUKRLGXC7JDT9ZUAF84NEVZ6WFZLVPU4EHJ856D2FJFNCVR2P34_ejd()
		{
			this.InitializeComponent();
			base.DataContext = new Class498();
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0001F885 File Offset: 0x0001DA85
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			this.textBox_0.Text = string.Empty;
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x0001F897 File Offset: 0x0001DA97
		private void textBox_0_LostFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = (Application.Current.FindResource("Search") as string);
			}
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000B1DD8 File Offset: 0x000AFFD8
		private void textBox_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				textBox.SelectAll();
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000C2740 File Offset: 0x000C0940
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/fixes/fixespage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_0(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000C2774 File Offset: 0x000C0974
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				this.textBox_0.MouseLeftButtonUp += this.textBox_0_MouseLeftButtonUp;
				return;
			case 2:
				this.radioButton_0 = (RadioButton)target;
				return;
			case 3:
				this.radioButton_1 = (RadioButton)target;
				return;
			case 4:
				this.listView_0 = (ListView)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0400232B RID: 9003
		internal TextBox textBox_0;

		// Token: 0x0400232C RID: 9004
		internal RadioButton radioButton_0;

		// Token: 0x0400232D RID: 9005
		internal RadioButton radioButton_1;

		// Token: 0x0400232E RID: 9006
		internal ListView listView_0;

		// Token: 0x0400232F RID: 9007
		private bool bool_0;
	}
}
