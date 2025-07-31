using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x020008A8 RID: 2216
	public sealed class dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd : Page, IComponentConnector
	{
		// Token: 0x0600344E RID: 13390 RVA: 0x000CCF68 File Offset: 0x000CB168
		public dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd()
		{
			this.InitializeComponent();
			this.listView_0.Opacity = 0.0;
			base.DataContext = this.gclass191_0;
			this.dispatcherTimer_0 = new DispatcherTimer
			{
				Interval = TimeSpan.FromMilliseconds(500.0)
			};
			this.dispatcherTimer_0.Tick += this.dispatcherTimer_0_Tick;
			this.method_2(false);
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x000209B4 File Offset: 0x0001EBB4
		private void dispatcherTimer_0_Tick(object sender, EventArgs e)
		{
			this.dispatcherTimer_0.Stop();
			this.string_0 = this.string_1;
			this.method_3();
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000209D3 File Offset: 0x0001EBD3
		private bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x000209DB File Offset: 0x0001EBDB
		private void method_1(bool bool_4)
		{
			this.bool_0 = bool_4;
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x000CD028 File Offset: 0x000CB228
		public void method_2(bool bool_4)
		{
			dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct697 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0 = this;
			@struct.bool_0 = bool_4;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct697>(ref @struct);
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x000CD068 File Offset: 0x000CB268
		public void method_3()
		{
			dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct699 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct699>(ref @struct);
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x000CD0A0 File Offset: 0x000CB2A0
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct698 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct698>(ref @struct);
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x000CD0D8 File Offset: 0x000CB2D8
		private void method_4(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23 enum23_1, bool bool_4)
		{
			Func<GClass184, string> keySelector = new Func<GClass184, string>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949.class949_0.method_0);
			if (enum23_1 == (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)1)
			{
				keySelector = new Func<GClass184, string>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949.class949_0.method_1);
			}
			else if (enum23_1 == (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)0)
			{
				keySelector = new Func<GClass184, string>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949.class949_0.method_2);
			}
			else if (enum23_1 == (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)2)
			{
				keySelector = new Func<GClass184, string>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949.class949_0.method_3);
			}
			else if (enum23_1 == (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)3)
			{
				keySelector = new Func<GClass184, string>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949.class949_0.method_4);
			}
			if (bool_4)
			{
				this.list_0 = this.list_0.OrderBy(keySelector).ToList<GClass184>();
			}
			else
			{
				this.list_0 = this.list_0.OrderByDescending(keySelector).ToList<GClass184>();
			}
			this.method_3();
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x000CD1D4 File Offset: 0x000CB3D4
		private void comboBox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string name = ((ComboBoxItem)((ComboBox)sender).SelectedItem).Name;
			if (name == "SortingComboItemName")
			{
				this.enum23_0 = (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)0;
			}
			if (name == "SortingComboItemDisplayName")
			{
				this.enum23_0 = (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)1;
			}
			if (name == "SortingComboItemStartUp")
			{
				this.enum23_0 = (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)2;
			}
			if (name == "SortingComboItemStatus")
			{
				this.enum23_0 = (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)3;
			}
			this.method_5();
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x000CD250 File Offset: 0x000CB450
		private void comboBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string name = ((ComboBoxItem)((ComboBox)sender).SelectedItem).Name;
			this.bool_2 = (name == "SortingComboAscending");
			this.method_5();
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x000CD28C File Offset: 0x000CB48C
		private void method_5()
		{
			if (this.bool_1)
			{
				return;
			}
			if (this.enum23_0 == (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)0 && this.gclass191_0.ShowDisplayName)
			{
				this.gclass191_0.ShowDisplayName = false;
			}
			if (this.enum23_0 == (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)1 && !this.gclass191_0.ShowDisplayName)
			{
				this.gclass191_0.ShowDisplayName = true;
			}
			this.method_4(this.enum23_0, this.bool_2);
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x000CD2F8 File Offset: 0x000CB4F8
		public void method_6(PropertyChangedEventHandler propertyChangedEventHandler_1)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, propertyChangedEventHandler_1);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000CD330 File Offset: 0x000CB530
		public void method_7(PropertyChangedEventHandler propertyChangedEventHandler_1)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, propertyChangedEventHandler_1);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x000209E4 File Offset: 0x0001EBE4
		protected void vmethod_0([CallerMemberName] string string_2)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_2));
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x000209FD File Offset: 0x0001EBFD
		protected bool method_8<T>(ref T gparam_0, T gparam_1, [CallerMemberName] string string_2)
		{
			if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
			{
				return false;
			}
			gparam_0 = gparam_1;
			this.vmethod_0(string_2);
			return true;
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00020A23 File Offset: 0x0001EC23
		private void textBox_0_GotFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == Class298.smethod_2("Search"))
			{
				this.textBox_0.Text = string.Empty;
			}
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00020A52 File Offset: 0x0001EC52
		private void textBox_0_LostFocus(object sender, RoutedEventArgs e)
		{
			if (this.textBox_0.Text == string.Empty)
			{
				this.textBox_0.Text = Class298.smethod_2("Search");
			}
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000CD368 File Offset: 0x000CB568
		private void textBox_0_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Escape)
			{
				this.textBox_0.Text = string.Empty;
				this.string_0 = string.Empty;
				this.string_1 = string.Empty;
				this.dispatcherTimer_0.Stop();
				this.method_3();
				return;
			}
			this.string_1 = this.textBox_0.Text;
			this.dispatcherTimer_0.Stop();
			this.dispatcherTimer_0.Start();
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00020A81 File Offset: 0x0001EC81
		private void method_9(object sender, RoutedEventArgs e)
		{
			this.method_10();
			this.method_3();
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x000CD3E0 File Offset: 0x000CB5E0
		private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24 @enum;
			if (Enum.TryParse<dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24>(((ComboBoxItem)((ComboBox)sender).SelectedItem).Name, out @enum))
			{
				this.enum24_0 = @enum;
				if (this.bool_1)
				{
					return;
				}
				this.method_3();
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00020A8F File Offset: 0x0001EC8F
		private void method_10()
		{
			this.textBox_0.Text = Class298.smethod_2("Search");
			this.string_0 = string.Empty;
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00020AB2 File Offset: 0x0001ECB2
		private void checkBox_0_Checked(object sender, RoutedEventArgs e)
		{
			if (this.method_0())
			{
				this.method_1(false);
				this.method_10();
				if (this.bool_1)
				{
					return;
				}
				this.method_3();
			}
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		private void checkBox_0_Unchecked(object sender, RoutedEventArgs e)
		{
			if (!this.method_0())
			{
				this.method_1(true);
				this.method_10();
				if (this.bool_1)
				{
					return;
				}
				this.method_3();
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00020AFE File Offset: 0x0001ECFE
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			this.list_0.ForEach(new Action<GClass184>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949.class949_0.method_5));
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00020B2A File Offset: 0x0001ED2A
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			this.list_0.ForEach(new Action<GClass184>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949.class949_0.method_6));
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x000CD424 File Offset: 0x000CB624
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "All files (*.*)|*.*",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
				Title = Class298.smethod_2("ChooseFile")
			};
			if (openFileDialog.ShowDialog().GetValueOrDefault())
			{
				dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class947 @class = new dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class947();
				@class.list_0 = new List<GClass102>();
				if (openFileDialog.FileName.EndsWith(".reg"))
				{
					@class.list_0 = GClass219.smethod_20(openFileDialog.FileName);
				}
				else
				{
					openFileDialog.FileName.EndsWith(".bat");
				}
				if (@class.list_0.Count > 0)
				{
					this.list_0.ForEach(new Action<GClass184>(@class.method_0));
				}
			}
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x000CD4E0 File Offset: 0x000CB6E0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_3)
			{
				return;
			}
			this.bool_3 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/tweakingpages/winservicesmanagerpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_11(Type type_0, string string_2)
		{
			return Delegate.CreateDelegate(type_0, this, string_2);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x000CD514 File Offset: 0x000CB714
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0 = (dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd)target;
				return;
			case 2:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 3:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 4:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 5:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.GotFocus += this.textBox_0_GotFocus;
				this.textBox_0.KeyUp += this.textBox_0_KeyUp;
				this.textBox_0.LostFocus += this.textBox_0_LostFocus;
				return;
			case 6:
				((Button)target).Click += this.method_9;
				return;
			case 7:
				this.checkBox_0 = (CheckBox)target;
				this.checkBox_0.Checked += this.checkBox_0_Checked;
				this.checkBox_0.Unchecked += this.checkBox_0_Unchecked;
				return;
			case 8:
				this.comboBox_0 = (ComboBox)target;
				this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
				return;
			case 9:
				this.comboBoxItem_0 = (ComboBoxItem)target;
				return;
			case 10:
				this.comboBoxItem_1 = (ComboBoxItem)target;
				return;
			case 11:
				this.comboBoxItem_2 = (ComboBoxItem)target;
				return;
			case 12:
				this.comboBoxItem_3 = (ComboBoxItem)target;
				return;
			case 13:
				this.comboBoxItem_4 = (ComboBoxItem)target;
				return;
			case 14:
				this.comboBoxItem_5 = (ComboBoxItem)target;
				return;
			case 15:
				this.comboBoxItem_6 = (ComboBoxItem)target;
				return;
			case 16:
				this.dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0 = (dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd)target;
				return;
			case 17:
				this.comboBox_1 = (ComboBox)target;
				this.comboBox_1.SelectionChanged += this.comboBox_1_SelectionChanged;
				return;
			case 18:
				this.comboBoxItem_7 = (ComboBoxItem)target;
				return;
			case 19:
				this.comboBoxItem_8 = (ComboBoxItem)target;
				return;
			case 20:
				this.comboBoxItem_9 = (ComboBoxItem)target;
				return;
			case 21:
				this.comboBoxItem_10 = (ComboBoxItem)target;
				return;
			case 22:
				this.comboBox_2 = (ComboBox)target;
				this.comboBox_2.SelectionChanged += this.comboBox_2_SelectionChanged;
				return;
			case 23:
				this.comboBoxItem_11 = (ComboBoxItem)target;
				return;
			case 24:
				this.comboBoxItem_12 = (ComboBoxItem)target;
				return;
			case 25:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 26:
				this.listView_0 = (ListView)target;
				return;
			default:
				this.bool_3 = true;
				return;
			}
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x000CD80C File Offset: 0x000CBA0C
		private Task method_12()
		{
			dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct700 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct700>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x000CD850 File Offset: 0x000CBA50
		private bool method_13(GClass184 gclass184_0)
		{
			return gclass184_0.Service.ServiceName.ToLower().Contains(this.string_0.ToLower()) || gclass184_0.Service.method_5(this.string_0.ToLower()) || gclass184_0.DisplayName.ToLower().Contains(this.string_0.ToLower()) || gclass184_0.WillBrake.ToLower().Contains(this.string_0.ToLower()) || (gclass184_0.Description != null && gclass184_0.Description.ToLower().Contains(this.string_0.ToLower()));
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00020B56 File Offset: 0x0001ED56
		private bool method_14(GClass184 gclass184_0)
		{
			return !this.method_0() || GClass279.smethod_0().method_12<Class799>(gclass184_0.Service.ServiceName) != null;
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x000CD8F8 File Offset: 0x000CBAF8
		private bool method_15(GClass184 gclass184_0)
		{
			bool result;
			switch (this.enum24_0)
			{
			case dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24.AllServices:
				result = gclass184_0.Service.method_3();
				break;
			case dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24.WindowsServices:
				result = (gclass184_0.Service.method_3() && GClass209.smethod_0(gclass184_0.Service));
				break;
			case dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24.OtherServices:
				result = (gclass184_0.Service.method_3() && !GClass209.smethod_0(gclass184_0.Service));
				break;
			case dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24.AllDrivers:
				result = gclass184_0.Service.method_4();
				break;
			case dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24.WindowsDrivers:
				result = (gclass184_0.Service.method_4() && GClass209.smethod_0(gclass184_0.Service));
				break;
			case dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24.OtherDrivers:
				result = (gclass184_0.Service.method_4() && !GClass209.smethod_0(gclass184_0.Service));
				break;
			case dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24.All:
				result = true;
				break;
			default:
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00020B7A File Offset: 0x0001ED7A
		private void method_16(GClass184 gclass184_0)
		{
			gclass184_0.ShowDisplayName = this.gclass191_0.ShowDisplayName;
		}

		// Token: 0x040025AF RID: 9647
		private string string_0 = string.Empty;

		// Token: 0x040025B0 RID: 9648
		private dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum24 enum24_0;

		// Token: 0x040025B1 RID: 9649
		private readonly GClass191 gclass191_0 = new GClass191
		{
			ShowDisplayName = true
		};

		// Token: 0x040025B2 RID: 9650
		private DispatcherTimer dispatcherTimer_0;

		// Token: 0x040025B3 RID: 9651
		private string string_1;

		// Token: 0x040025B4 RID: 9652
		private List<GClass184> list_0 = new List<GClass184>();

		// Token: 0x040025B5 RID: 9653
		private bool bool_0 = true;

		// Token: 0x040025B6 RID: 9654
		private bool bool_1 = true;

		// Token: 0x040025B7 RID: 9655
		private SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

		// Token: 0x040025B8 RID: 9656
		private bool bool_2 = true;

		// Token: 0x040025B9 RID: 9657
		private dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23 enum23_0;

		// Token: 0x040025BA RID: 9658
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x040025BB RID: 9659
		internal dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;

		// Token: 0x040025BC RID: 9660
		internal Button button_0;

		// Token: 0x040025BD RID: 9661
		internal Button button_1;

		// Token: 0x040025BE RID: 9662
		internal Button button_2;

		// Token: 0x040025BF RID: 9663
		internal TextBox textBox_0;

		// Token: 0x040025C0 RID: 9664
		internal CheckBox checkBox_0;

		// Token: 0x040025C1 RID: 9665
		internal ComboBox comboBox_0;

		// Token: 0x040025C2 RID: 9666
		internal ComboBoxItem comboBoxItem_0;

		// Token: 0x040025C3 RID: 9667
		internal ComboBoxItem comboBoxItem_1;

		// Token: 0x040025C4 RID: 9668
		internal ComboBoxItem comboBoxItem_2;

		// Token: 0x040025C5 RID: 9669
		internal ComboBoxItem comboBoxItem_3;

		// Token: 0x040025C6 RID: 9670
		internal ComboBoxItem comboBoxItem_4;

		// Token: 0x040025C7 RID: 9671
		internal ComboBoxItem comboBoxItem_5;

		// Token: 0x040025C8 RID: 9672
		internal ComboBoxItem comboBoxItem_6;

		// Token: 0x040025C9 RID: 9673
		internal dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0;

		// Token: 0x040025CA RID: 9674
		internal ComboBox comboBox_1;

		// Token: 0x040025CB RID: 9675
		internal ComboBoxItem comboBoxItem_7;

		// Token: 0x040025CC RID: 9676
		internal ComboBoxItem comboBoxItem_8;

		// Token: 0x040025CD RID: 9677
		internal ComboBoxItem comboBoxItem_9;

		// Token: 0x040025CE RID: 9678
		internal ComboBoxItem comboBoxItem_10;

		// Token: 0x040025CF RID: 9679
		internal ComboBox comboBox_2;

		// Token: 0x040025D0 RID: 9680
		internal ComboBoxItem comboBoxItem_11;

		// Token: 0x040025D1 RID: 9681
		internal ComboBoxItem comboBoxItem_12;

		// Token: 0x040025D2 RID: 9682
		internal Button button_3;

		// Token: 0x040025D3 RID: 9683
		internal ListView listView_0;

		// Token: 0x040025D4 RID: 9684
		private bool bool_3;

		// Token: 0x020008A9 RID: 2217
		[StructLayout(LayoutKind.Auto)]
		private struct Struct697 : IAsyncStateMachine
		{
			// Token: 0x06003470 RID: 13424 RVA: 0x000CD9D8 File Offset: 0x000CBBD8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd = this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_109;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_18C;
					default:
						dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.bool_1 = true;
						dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.button_2.IsEnabled = false;
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.listView_0, 100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct697>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0);
					this.observableCollection_0 = Class589.smethod_1(this.bool_0).AllServices;
					awaiter = Class589.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct697>(ref awaiter, ref this);
						return;
					}
					IL_109:
					awaiter.GetResult();
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.list_0.Clear();
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.list_0.AddRange(this.observableCollection_0);
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.method_4((dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Enum23)1, true);
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.dje_zXNNJLKZGU3XN9MK85ZPHRMHN6E5ELSTJG7NE358T5V8U64Z_ejd_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct697>(ref awaiter, ref this);
						return;
					}
					IL_18C:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.listView_0);
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.button_2.IsEnabled = true;
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.bool_1 = false;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.observableCollection_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.observableCollection_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003471 RID: 13425 RVA: 0x00020B8D File Offset: 0x0001ED8D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040025D5 RID: 9685
			public int int_0;

			// Token: 0x040025D6 RID: 9686
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040025D7 RID: 9687
			public dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;

			// Token: 0x040025D8 RID: 9688
			public bool bool_0;

			// Token: 0x040025D9 RID: 9689
			private ObservableCollection<GClass184> observableCollection_0;

			// Token: 0x040025DA RID: 9690
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020008AA RID: 2218
		[StructLayout(LayoutKind.Auto)]
		private struct Struct698 : IAsyncStateMachine
		{
			// Token: 0x06003472 RID: 13426 RVA: 0x000CDBEC File Offset: 0x000CBDEC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd = this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.button_2.IsEnabled = false;
						dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.checkBox_0.IsChecked = new bool?(true);
						dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.method_2(true);
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct698>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.button_2.IsEnabled = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003473 RID: 13427 RVA: 0x00020B9B File Offset: 0x0001ED9B
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040025DB RID: 9691
			public int int_0;

			// Token: 0x040025DC RID: 9692
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040025DD RID: 9693
			public dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;

			// Token: 0x040025DE RID: 9694
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020008AB RID: 2219
		private sealed class Class946
		{
			// Token: 0x06003475 RID: 13429 RVA: 0x00020BA9 File Offset: 0x0001EDA9
			internal void method_0()
			{
				this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0.gclass191_0.SingleServiceInfoViews = new ObservableCollection<GClass184>(this.list_0);
				this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0.list_0.ForEach(new Action<GClass184>(this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0.method_16));
			}

			// Token: 0x040025DF RID: 9695
			public List<GClass184> list_0;

			// Token: 0x040025E0 RID: 9696
			public dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;
		}

		// Token: 0x020008AC RID: 2220
		private sealed class Class947
		{
			// Token: 0x06003477 RID: 13431 RVA: 0x000CDCD4 File Offset: 0x000CBED4
			internal void method_0(GClass184 gclass184_0)
			{
				dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class948 @class = new dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class948();
				@class.gclass184_0 = gclass184_0;
				this.list_0.ForEach(new Action<GClass102>(@class.method_0));
			}

			// Token: 0x040025E1 RID: 9697
			public List<GClass102> list_0;
		}

		// Token: 0x020008AD RID: 2221
		private enum Enum23
		{

		}

		// Token: 0x020008AE RID: 2222
		[StructLayout(LayoutKind.Auto)]
		private struct Struct699 : IAsyncStateMachine
		{
			// Token: 0x06003478 RID: 13432 RVA: 0x000CDD08 File Offset: 0x000CBF08
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd @object = this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Func<Task>(@object.method_12)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct699>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06003479 RID: 13433 RVA: 0x00020BE7 File Offset: 0x0001EDE7
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040025E3 RID: 9699
			public int int_0;

			// Token: 0x040025E4 RID: 9700
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x040025E5 RID: 9701
			public dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;

			// Token: 0x040025E6 RID: 9702
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020008AF RID: 2223
		[StructLayout(LayoutKind.Auto)]
		private struct Struct700 : IAsyncStateMachine
		{
			// Token: 0x0600347A RID: 13434 RVA: 0x000CDDC8 File Offset: 0x000CBFC8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd = this.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class946_0 = new dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class946();
						this.class946_0.dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0 = dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd;
						awaiter = dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.semaphoreSlim_0.WaitAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Struct700>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					this.class946_0.list_0 = dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.list_0.Where(new Func<GClass184, bool>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.method_13)).Where(new Func<GClass184, bool>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.method_14)).Where(new Func<GClass184, bool>(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.method_15)).ToList<GClass184>();
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Dispatcher.Invoke(new Action(this.class946_0.method_0));
					dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.semaphoreSlim_0.Release();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class946_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class946_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600347B RID: 13435 RVA: 0x00020BF5 File Offset: 0x0001EDF5
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040025E7 RID: 9703
			public int int_0;

			// Token: 0x040025E8 RID: 9704
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040025E9 RID: 9705
			public dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd_0;

			// Token: 0x040025EA RID: 9706
			private dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class946 class946_0;

			// Token: 0x040025EB RID: 9707
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020008B0 RID: 2224
		private sealed class Class948
		{
			// Token: 0x0600347D RID: 13437 RVA: 0x00020C03 File Offset: 0x0001EE03
			internal void method_0(GClass102 gclass102_0)
			{
				if (this.gclass184_0.ServiceName.ToLower() == gclass102_0.Name.ToLower())
				{
					this.gclass184_0.WinServiceViewModel.NewStartMode = gclass102_0.Status;
				}
			}

			// Token: 0x040025EC RID: 9708
			public GClass184 gclass184_0;
		}

		// Token: 0x020008B1 RID: 2225
		private enum Enum24
		{
			// Token: 0x040025EE RID: 9710
			AllServices,
			// Token: 0x040025EF RID: 9711
			WindowsServices,
			// Token: 0x040025F0 RID: 9712
			OtherServices,
			// Token: 0x040025F1 RID: 9713
			AllDrivers,
			// Token: 0x040025F2 RID: 9714
			WindowsDrivers,
			// Token: 0x040025F3 RID: 9715
			OtherDrivers,
			// Token: 0x040025F4 RID: 9716
			All
		}

		// Token: 0x020008B2 RID: 2226
		[Serializable]
		private sealed class Class949
		{
			// Token: 0x06003480 RID: 13440 RVA: 0x00020C49 File Offset: 0x0001EE49
			internal string method_0(GClass184 gclass184_0)
			{
				return gclass184_0.DisplayName;
			}

			// Token: 0x06003481 RID: 13441 RVA: 0x00020C49 File Offset: 0x0001EE49
			internal string method_1(GClass184 gclass184_0)
			{
				return gclass184_0.DisplayName;
			}

			// Token: 0x06003482 RID: 13442 RVA: 0x00020C51 File Offset: 0x0001EE51
			internal string method_2(GClass184 gclass184_0)
			{
				return gclass184_0.Service.ServiceName;
			}

			// Token: 0x06003483 RID: 13443 RVA: 0x000CDF18 File Offset: 0x000CC118
			internal string method_3(GClass184 gclass184_0)
			{
				return gclass184_0.Service.CurrentStartMode.ToString();
			}

			// Token: 0x06003484 RID: 13444 RVA: 0x000CDF40 File Offset: 0x000CC140
			internal string method_4(GClass184 gclass184_0)
			{
				return gclass184_0.Service.Status.ToString();
			}

			// Token: 0x06003485 RID: 13445 RVA: 0x00020C5E File Offset: 0x0001EE5E
			internal void method_5(GClass184 gclass184_0)
			{
				if (gclass184_0.WinServiceViewModel.IsService)
				{
					gclass184_0.WinServiceViewModel.method_8();
				}
			}

			// Token: 0x06003486 RID: 13446 RVA: 0x00020C78 File Offset: 0x0001EE78
			internal void method_6(GClass184 gclass184_0)
			{
				if (!gclass184_0.WinServiceViewModel.IsService)
				{
					gclass184_0.WinServiceViewModel.method_8();
				}
			}

			// Token: 0x040025F5 RID: 9717
			public static readonly dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949 class949_0 = new dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd.Class949();

			// Token: 0x040025F6 RID: 9718
			public static Func<GClass184, string> func_0;

			// Token: 0x040025F7 RID: 9719
			public static Func<GClass184, string> func_1;

			// Token: 0x040025F8 RID: 9720
			public static Func<GClass184, string> func_2;

			// Token: 0x040025F9 RID: 9721
			public static Func<GClass184, string> func_3;

			// Token: 0x040025FA RID: 9722
			public static Func<GClass184, string> func_4;

			// Token: 0x040025FB RID: 9723
			public static Action<GClass184> action_0;

			// Token: 0x040025FC RID: 9724
			public static Action<GClass184> action_1;
		}
	}
}
