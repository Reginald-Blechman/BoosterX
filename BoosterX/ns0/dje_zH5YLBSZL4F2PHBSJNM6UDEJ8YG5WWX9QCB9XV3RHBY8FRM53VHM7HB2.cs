using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ns0
{
	// Token: 0x0200081C RID: 2076
	public sealed class dje_zH5YLBSZL4F2PHBSJNM6UDEJ8YG5WWX9QCB9XV3RHBY8FRM53VHM7HB27QDH2R48KNA_ejd : Page, IComponentConnector
	{
		// Token: 0x060031E7 RID: 12775 RVA: 0x0001F62B File Offset: 0x0001D82B
		public dje_zH5YLBSZL4F2PHBSJNM6UDEJ8YG5WWX9QCB9XV3RHBY8FRM53VHM7HB27QDH2R48KNA_ejd()
		{
			this.InitializeComponent();
			base.Loaded += this.dje_zH5YLBSZL4F2PHBSJNM6UDEJ8YG5WWX9QCB9XV3RHBY8FRM53VHM7HB27QDH2R48KNA_ejd_Loaded;
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x0001F656 File Offset: 0x0001D856
		private void dje_zH5YLBSZL4F2PHBSJNM6UDEJ8YG5WWX9QCB9XV3RHBY8FRM53VHM7HB27QDH2R48KNA_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			base.DataContext = this.gclass190_0;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x0001F664 File Offset: 0x0001D864
		private void method_0(object sender, SelectionChangedEventArgs e)
		{
			this.textBox_0.DataContext = this.gclass190_0.SelectedProfile;
			this.itemsControl_0.ItemsSource = null;
			this.itemsControl_0.ItemsSource = this.gclass190_0.SelectedProfile.CSGOLaunchOptionsVMs;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000C1988 File Offset: 0x000BFB88
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/appspages/cs2/views/cs2launchoptions.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000C19BC File Offset: 0x000BFBBC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((ComboBox)target).SelectionChanged += this.method_0;
				return;
			case 2:
				this.textBox_0 = (TextBox)target;
				return;
			case 3:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 4:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x040022EF RID: 8943
		private GClass190 gclass190_0 = new GClass190();

		// Token: 0x040022F0 RID: 8944
		internal TextBox textBox_0;

		// Token: 0x040022F1 RID: 8945
		internal ScrollViewer scrollViewer_0;

		// Token: 0x040022F2 RID: 8946
		internal ItemsControl itemsControl_0;

		// Token: 0x040022F3 RID: 8947
		private bool bool_0;
	}
}
