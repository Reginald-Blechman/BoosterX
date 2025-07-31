using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x0200070E RID: 1806
	public sealed class dje_z2F52GSNWMMSE83WAZXX4EHXNTLRZ4F4L23229LUWEKWU6UZ_ejd : UserControl, IComponentConnector
	{
		// Token: 0x06002D06 RID: 11526 RVA: 0x0001CF2C File Offset: 0x0001B12C
		public dje_z2F52GSNWMMSE83WAZXX4EHXNTLRZ4F4L23229LUWEKWU6UZ_ejd()
		{
			base.DataContextChanged += this.dje_z2F52GSNWMMSE83WAZXX4EHXNTLRZ4F4L23229LUWEKWU6UZ_ejd_DataContextChanged;
			this.InitializeComponent();
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x0001CF4C File Offset: 0x0001B14C
		public GClass184 method_0()
		{
			return this.gclass184_0;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0001CF54 File Offset: 0x0001B154
		public void method_1(GClass184 gclass184_1)
		{
			this.gclass184_0 = gclass184_1;
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x0001CF5D File Offset: 0x0001B15D
		private void method_2(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "ShowChildList")
			{
				this.method_4();
			}
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000ABCE4 File Offset: 0x000A9EE4
		private void dje_z2F52GSNWMMSE83WAZXX4EHXNTLRZ4F4L23229LUWEKWU6UZ_ejd_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			GClass184 gclass = e.OldValue as GClass184;
			if (gclass != null)
			{
				gclass.PropertyChanged -= this.method_2;
			}
			GClass184 gclass2 = e.NewValue as GClass184;
			if (gclass2 != null)
			{
				this.method_1(gclass2);
				this.method_0().PropertyChanged += this.method_2;
				this.method_3();
				this.method_4();
			}
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0001CF78 File Offset: 0x0001B178
		private void method_3()
		{
			this.grid_1.Visibility = (this.method_0().ShowDescription ? Visibility.Visible : Visibility.Collapsed);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000ABD50 File Offset: 0x000A9F50
		private void method_4()
		{
			if (this.method_0().ShowChildList)
			{
				this.listView_0.ItemsSource = (base.DataContext as GClass184).DependenciesTree;
				this.border_1.Visibility = Visibility.Visible;
				return;
			}
			this.listView_0.ItemsSource = null;
			this.border_1.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x0001CF96 File Offset: 0x0001B196
		private void method_5(object sender, RoutedEventArgs e)
		{
			this.method_0().ShowChildList = !this.method_0().ShowChildList;
			e.Handled = true;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		private void method_6(object sender, RoutedEventArgs e)
		{
			Class808.smethod_27("taskkill /F /IM regedit.exe");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\" + this.method_0().ServiceName);
			Class808.smethod_30("regedit");
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x0001CFF7 File Offset: 0x0001B1F7
		private void method_7(object sender, RoutedEventArgs e)
		{
			this.method_0().IsUserChecked = false;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x0001D005 File Offset: 0x0001B205
		private void method_8(object sender, MouseButtonEventArgs e)
		{
			this.method_0().IsUserChecked = true;
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000ABDAC File Offset: 0x000A9FAC
		private void grid_0_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			if (this.grid_0.ActualWidth >= 900.0)
			{
				Grid.SetColumn(this.stackPanel_0, 1);
				Grid.SetColumnSpan(this.stackPanel_0, 1);
				Grid.SetRow(this.stackPanel_0, 0);
				return;
			}
			Grid.SetColumn(this.stackPanel_0, 0);
			Grid.SetColumnSpan(this.stackPanel_0, 3);
			Grid.SetRow(this.stackPanel_0, 1);
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0001D013 File Offset: 0x0001B213
		private void checkBox_0_Checked(object sender, RoutedEventArgs e)
		{
			this.method_0().ShowDescription = !this.method_0().ShowDescription;
			this.method_3();
			e.Handled = true;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x000ABE18 File Offset: 0x000AA018
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/usercontrols/servicescontroller/servicecontroller.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x000ABE4C File Offset: 0x000AA04C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.grid_0 = (Grid)target;
				this.grid_0.SizeChanged += this.grid_0_SizeChanged;
				return;
			case 2:
				((Button)target).Click += this.method_5;
				return;
			case 3:
				this.checkBox_0 = (CheckBox)target;
				this.checkBox_0.Checked += this.checkBox_0_Checked;
				return;
			case 4:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 5:
				this.stackPanel_1 = (StackPanel)target;
				return;
			case 6:
				this.stackPanel_2 = (StackPanel)target;
				return;
			case 7:
				((CheckBox)target).Click += this.method_7;
				((CheckBox)target).PreviewMouseDown += this.method_8;
				return;
			case 8:
				this.grid_1 = (Grid)target;
				return;
			case 9:
				((Button)target).Click += this.method_6;
				return;
			case 10:
				this.border_0 = (Border)target;
				return;
			case 11:
				this.border_1 = (Border)target;
				return;
			case 12:
				this.listView_0 = (ListView)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x04001D58 RID: 7512
		private GClass184 gclass184_0;

		// Token: 0x04001D59 RID: 7513
		internal Grid grid_0;

		// Token: 0x04001D5A RID: 7514
		internal CheckBox checkBox_0;

		// Token: 0x04001D5B RID: 7515
		internal StackPanel stackPanel_0;

		// Token: 0x04001D5C RID: 7516
		internal StackPanel stackPanel_1;

		// Token: 0x04001D5D RID: 7517
		internal StackPanel stackPanel_2;

		// Token: 0x04001D5E RID: 7518
		internal Grid grid_1;

		// Token: 0x04001D5F RID: 7519
		internal Border border_0;

		// Token: 0x04001D60 RID: 7520
		internal Border border_1;

		// Token: 0x04001D61 RID: 7521
		internal ListView listView_0;

		// Token: 0x04001D62 RID: 7522
		private bool bool_0;
	}
}
