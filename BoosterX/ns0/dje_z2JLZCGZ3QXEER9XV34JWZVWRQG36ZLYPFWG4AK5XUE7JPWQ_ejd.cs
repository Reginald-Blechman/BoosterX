using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Win32.TaskScheduler;
using XamlAnimatedGif;

namespace ns0
{
	// Token: 0x02000710 RID: 1808
	public sealed class dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd : Page, IComponentConnector
	{
		// Token: 0x06002D1F RID: 11551 RVA: 0x000AC1BC File Offset: 0x000AA3BC
		public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd()
		{
			this.InitializeComponent();
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_11(new dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.GDelegate6(this.method_0));
			base.Loaded += this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_Loaded;
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_16(new dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.GDelegate4(this.method_3));
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_14(new dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.GDelegate5(this.method_4));
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0001D09B File Offset: 0x0001B29B
		private void method_0()
		{
			this.scrollViewer_0.ScrollToEnd();
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x000AC254 File Offset: 0x000AA454
		private void method_1()
		{
			dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.list_2.Clear();
			this.itemsControl_0.Items.Clear();
			this.list_0.Clear();
			this.list_1.Clear();
			this.bool_0 = false;
			this.long_0 = 0L;
			this.int_0 = 0;
			this.grid_0.Opacity = 0.0;
			this.grid_0.Visibility = Visibility.Collapsed;
			this.grid_1.Opacity = 0.0;
			this.grid_1.Visibility = Visibility.Collapsed;
			this.grid_3.Opacity = 0.0;
			this.grid_3.Visibility = Visibility.Collapsed;
			this.grid_4.Opacity = 0.0;
			this.grid_4.Visibility = Visibility.Collapsed;
			this.border_1.Visibility = Visibility.Collapsed;
			this.border_2.Visibility = Visibility.Collapsed;
			this.border_0.Visibility = Visibility.Collapsed;
			this.int_1 = 0;
			this.string_0 = "0";
			this.string_1 = "0";
			this.string_2 = "0";
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_3 = 0;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000AC384 File Offset: 0x000AA584
		private void dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_Loaded(object sender, RoutedEventArgs e)
		{
			dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref @struct);
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000AC3BC File Offset: 0x000AA5BC
		private void method_2()
		{
			dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491>(ref @struct);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		private void method_3()
		{
			dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(this.grid_4);
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x000AC3F4 File Offset: 0x000AA5F4
		private void method_4()
		{
			dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct489 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct489>(ref @struct);
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000AC42C File Offset: 0x000AA62C
		private Task method_5()
		{
			dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct490 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct490>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000AC470 File Offset: 0x000AA670
		private void method_6(Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary_0)
		{
			Dictionary<string, GClass279.GStruct2> dictionary;
			if (dictionary_0.TryGetValue(typeof(Class799), out dictionary))
			{
				foreach (KeyValuePair<string, GClass279.GStruct2> keyValuePair in dictionary)
				{
					if (keyValuePair.Key != null)
					{
						Class799 @class = keyValuePair.Value.method_0() as Class799;
						if (@class != null)
						{
							Class799 class2 = @class;
							object obj = keyValuePair.Value.method_2();
							class2.method_6((obj != null) ? obj.ToString() : null);
							if (@class.NewStartMode.GetValueOrDefault() == ServiceStartMode.Disabled)
							{
								this.list_1.Add(@class.ServiceName);
								this.int_0++;
							}
						}
					}
				}
			}
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000AC548 File Offset: 0x000AA748
		private void method_7(Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary_0)
		{
			Dictionary<string, GClass279.GStruct2> dictionary;
			if (dictionary_0.TryGetValue(typeof(Class803), out dictionary))
			{
				foreach (KeyValuePair<string, GClass279.GStruct2> keyValuePair in dictionary)
				{
					if (keyValuePair.Key != null)
					{
						GClass67 gclass = keyValuePair.Value.method_2() as GClass67;
						Class803 @class = keyValuePair.Value.method_0() as Class803;
						if (gclass != null && @class != null && gclass.method_0() == "BEST")
						{
							Class466 class2 = @class.method_6();
							bool flag;
							if (class2 == null)
							{
								flag = false;
							}
							else
							{
								List<string> list = class2.List_0;
								flag = ((list != null) ? new bool?(Class746.smethod_3<string>(list)) : null).GetValueOrDefault();
							}
							if (flag)
							{
								foreach (string string_ in @class.method_6().List_0)
								{
									GClass170 gclass2 = this.method_10(string_);
									if (!gclass2.TweaksNames.Contains(@class.method_6().String_0))
									{
										gclass2.TweaksNames.Add(@class.method_6().String_0);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000AC6D4 File Offset: 0x000AA8D4
		private void method_8(Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary_0)
		{
			Dictionary<string, GClass279.GStruct2> dictionary;
			if (dictionary_0.TryGetValue(typeof(Class798), out dictionary))
			{
				foreach (KeyValuePair<string, GClass279.GStruct2> keyValuePair in dictionary)
				{
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class872 @class = new dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class872();
					if (keyValuePair.Key != null)
					{
						@class.class798_0 = (keyValuePair.Value.method_0() as Class798);
						if (@class.class798_0 != null && !@class.class798_0.method_6().IsEnabled)
						{
							string text = string.Empty;
							if (@class.class798_0.method_6().ClassName == "Bluetooth")
							{
								text = "WBBluetooth";
							}
							else if (@class.class798_0.method_6().ClassName == "PrintQueue")
							{
								text = "WBPrinter";
							}
							else if (@class.class798_0.method_6().ClassName == "WAN Miniport")
							{
								text = "WBADSL";
							}
							else if (@class.class798_0.method_6().Id.ToLower().StartsWith("root\\umbus"))
							{
								text = "WBRDPWrapper";
							}
							else if (@class.class798_0.method_6().Id.ToLower().StartsWith("root\\vdrvroot"))
							{
								text = "WBISOMounting";
							}
							else if (GClass157.list_1.Any(new Func<string, bool>(@class.method_0)))
							{
								text = "WBWSL2";
							}
							if (!string.IsNullOrEmpty(text))
							{
								GClass170 gclass = this.method_10(text);
								if (!gclass.DevicesNames.Contains(@class.class798_0.method_6().Id))
								{
									gclass.DevicesNames.Add(@class.class798_0.method_6().Id);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000AC8D4 File Offset: 0x000AAAD4
		private void method_9()
		{
			ObservableCollection<GClass184> allServices = Class589.smethod_1(false).AllServices;
			foreach (string text in this.list_1)
			{
				foreach (GClass184 gclass in allServices)
				{
					if (!string.IsNullOrEmpty(gclass.ServiceName) && gclass.ServiceName.Equals(text, StringComparison.OrdinalIgnoreCase))
					{
						foreach (string text2 in gclass.WinServiceViewModel.WillBrake)
						{
							if (!string.IsNullOrEmpty(text2))
							{
								GClass170 gclass2 = this.method_10(text2);
								if (!gclass2.ServicesNames.Contains(text))
								{
									gclass2.ServicesNames.Add(text);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000AC9F8 File Offset: 0x000AABF8
		private GClass170 method_10(string string_3)
		{
			dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class874 @class = new dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class874();
			@class.string_0 = Class298.smethod_2(string_3);
			GClass170 gclass = this.list_0.FirstOrDefault(new Func<GClass170, bool>(@class.method_0));
			if (gclass == null)
			{
				gclass = new GClass170(this)
				{
					WhatWillBrakeEng = string_3,
					WhatWillBrake = @class.string_0,
					TweaksNames = new List<string>(),
					ServicesNames = new List<string>(),
					DevicesNames = new List<string>()
				};
				this.list_0.Add(gclass);
			}
			return gclass;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000ACA7C File Offset: 0x000AAC7C
		private void button_3_Click(object sender, RoutedEventArgs e)
		{
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = (dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)Window.GetWindow(this);
			if (dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.radioButton_1.IsChecked.GetValueOrDefault())
			{
				Class406.smethod_0().method_4(typeof(dje_z2SW9K68CZJT7BJDWKSPPNMQ44RNJ2KLKFHD9DFWKM3TQCW5SKPUBPRE6E4DQ_ejd), Class406.smethod_0().frame_0);
				return;
			}
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.radioButton_1.IsChecked = new bool?(true);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000ACADC File Offset: 0x000AACDC
		private void button_2_Click(object sender, RoutedEventArgs e)
		{
			dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct492 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct492>(ref @struct);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x0001D0B5 File Offset: 0x0001B2B5
		private void button_0_Click(object sender, RoutedEventArgs e)
		{
			Class808.smethod_30("explorer windowsdefender://ThreatSettings");
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000ACB14 File Offset: 0x000AAD14
		private void button_1_Click(object sender, RoutedEventArgs e)
		{
			if (Class787.bool_0)
			{
				Class787.bool_0 = false;
				Class406.smethod_0().method_4(typeof(dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd), Class406.smethod_0().frame_0);
				return;
			}
			if (Class144.bool_0)
			{
				Class406.smethod_0().method_4(typeof(dje_zA5BNJPL4VBRMZ98SXEHDTW8Z9JSKUBFZ94CWGACXGRJRUCM3F6ERD9JWT2MVQWJ7HX_ejd), Class406.smethod_0().frame_0);
				return;
			}
			Class406.smethod_0().method_4(typeof(dje_z2SW9K68CZJT7BJDWKSPPNMQ44RNJ2KLKFHD9DFWKM3TQCW5SKPUBPRE6E4DQ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x0001D0C2 File Offset: 0x0001B2C2
		private void button_4_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("shutdown.exe", "-r -t 0");
			Application.Current.Shutdown();
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000ACB94 File Offset: 0x000AAD94
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_1 = true;
			Uri resourceLocator = new Uri("/BoosterX;component/mpvm/pages/mainpages/expapplyingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x0001D085 File Offset: 0x0001B285
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate method_11(Type type_0, string string_3)
		{
			return Delegate.CreateDelegate(type_0, this, string_3);
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000ACBC8 File Offset: 0x000AADC8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Button)target).Click += this.button_1_Click;
				return;
			case 2:
				this.grid_0 = (Grid)target;
				return;
			case 3:
				this.image_0 = (Image)target;
				return;
			case 4:
				this.grid_1 = (Grid)target;
				return;
			case 5:
				this.grid_2 = (Grid)target;
				return;
			case 6:
				this.button_0 = (Button)target;
				this.button_0.Click += this.button_0_Click;
				return;
			case 7:
				this.image_1 = (Image)target;
				return;
			case 8:
				this.stackPanel_0 = (StackPanel)target;
				return;
			case 9:
				this.itemsControl_0 = (ItemsControl)target;
				return;
			case 10:
				this.button_1 = (Button)target;
				this.button_1.Click += this.button_1_Click;
				return;
			case 11:
				this.button_2 = (Button)target;
				this.button_2.Click += this.button_2_Click;
				return;
			case 12:
				this.grid_3 = (Grid)target;
				return;
			case 13:
				this.image_2 = (Image)target;
				return;
			case 14:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 15:
				this.scrollViewer_0 = (ScrollViewer)target;
				return;
			case 16:
				this.itemsControl_1 = (ItemsControl)target;
				return;
			case 17:
				this.grid_4 = (Grid)target;
				return;
			case 18:
				this.textBlock_1 = (TextBlock)target;
				return;
			case 19:
				this.textBlock_2 = (TextBlock)target;
				return;
			case 20:
				this.textBlock_3 = (TextBlock)target;
				return;
			case 21:
				this.textBlock_4 = (TextBlock)target;
				return;
			case 22:
				this.textBlock_5 = (TextBlock)target;
				return;
			case 23:
				this.textBlock_6 = (TextBlock)target;
				return;
			case 24:
				this.textBlock_7 = (TextBlock)target;
				return;
			case 25:
				this.textBlock_8 = (TextBlock)target;
				return;
			case 26:
				this.border_0 = (Border)target;
				return;
			case 27:
				this.border_1 = (Border)target;
				return;
			case 28:
				this.border_2 = (Border)target;
				return;
			case 29:
				this.button_3 = (Button)target;
				this.button_3.Click += this.button_3_Click;
				return;
			case 30:
				this.button_4 = (Button)target;
				this.button_4.Click += this.button_4_Click;
				return;
			default:
				this.bool_1 = true;
				return;
			}
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		private void method_12()
		{
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.observableCollection_0.Clear();
			this.itemsControl_1.ItemsSource = null;
			this.itemsControl_1.ItemsSource = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.observableCollection_0;
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x000ACE60 File Offset: 0x000AB060
		private void method_13()
		{
			if (Class277.bool_1)
			{
				this.border_0.Visibility = Visibility.Visible;
			}
			if (Class551.class753_0.method_40().GetValueOrDefault() && Class551.class753_0.method_44().GetValueOrDefault())
			{
				Class551.class753_0.method_41(null);
				Class551.class753_0.method_45(null);
				this.border_2.Visibility = Visibility.Visible;
			}
			else if (Class551.class753_0.method_40().GetValueOrDefault())
			{
				bool? flag = Class551.class753_0.method_44();
				if (!flag.GetValueOrDefault() & flag != null)
				{
					TaskService taskService = new TaskService();
					try
					{
						string text = "BoosterXStartupTask";
						TaskDefinition taskDefinition = taskService.NewTask();
						taskDefinition.RegistrationInfo.Description = "Runs BoosterX.exe at system startup with admin rights for av disable";
						taskDefinition.Principal.RunLevel = 1;
						taskDefinition.Triggers.Add<LogonTrigger>(new LogonTrigger());
						taskDefinition.Actions.Add<ExecAction>(new ExecAction(Class551.class753_0.method_6(), "-DisableAV", null));
						taskService.RootFolder.RegisterTaskDefinition(text, taskDefinition);
					}
					finally
					{
						taskService.Dispose();
					}
					this.border_1.Visibility = Visibility.Visible;
				}
			}
			this.textBlock_4.Text = this.int_0.ToString();
			this.textBlock_5.Text = this.string_1;
			this.textBlock_7.Text = this.string_2;
			this.textBlock_6.Text = this.string_0;
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x000ACFF8 File Offset: 0x000AB1F8
		private void method_14()
		{
			try
			{
				Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary = GClass279.smethod_0().method_19();
				if (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_10)))
				{
					this.method_6(dictionary);
					this.method_7(dictionary);
					this.method_8(dictionary);
					this.method_9();
					this.list_0 = this.list_0.OrderBy(new Func<GClass170, int>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_11)).ToList<GClass170>();
					base.Dispatcher.Invoke(new Action(this.method_15));
				}
			}
			catch
			{
			}
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x000AD0B8 File Offset: 0x000AB2B8
		private void method_15()
		{
			foreach (GClass170 newItem in this.list_0)
			{
				this.itemsControl_0.Items.Add(newItem);
			}
		}

		// Token: 0x04001D6F RID: 7535
		public List<GClass170> list_0 = new List<GClass170>();

		// Token: 0x04001D70 RID: 7536
		public List<string> list_1 = new List<string>();

		// Token: 0x04001D71 RID: 7537
		internal static List<Class757> list_2 = new List<Class757>();

		// Token: 0x04001D72 RID: 7538
		public int int_0;

		// Token: 0x04001D73 RID: 7539
		public long long_0;

		// Token: 0x04001D74 RID: 7540
		public int int_1;

		// Token: 0x04001D75 RID: 7541
		public string string_0 = string.Empty;

		// Token: 0x04001D76 RID: 7542
		public string string_1 = string.Empty;

		// Token: 0x04001D77 RID: 7543
		public string string_2 = string.Empty;

		// Token: 0x04001D78 RID: 7544
		private bool bool_0;

		// Token: 0x04001D79 RID: 7545
		internal Grid grid_0;

		// Token: 0x04001D7A RID: 7546
		internal Image image_0;

		// Token: 0x04001D7B RID: 7547
		internal Grid grid_1;

		// Token: 0x04001D7C RID: 7548
		internal Grid grid_2;

		// Token: 0x04001D7D RID: 7549
		internal Button button_0;

		// Token: 0x04001D7E RID: 7550
		internal Image image_1;

		// Token: 0x04001D7F RID: 7551
		internal StackPanel stackPanel_0;

		// Token: 0x04001D80 RID: 7552
		internal ItemsControl itemsControl_0;

		// Token: 0x04001D81 RID: 7553
		internal Button button_1;

		// Token: 0x04001D82 RID: 7554
		internal Button button_2;

		// Token: 0x04001D83 RID: 7555
		internal Grid grid_3;

		// Token: 0x04001D84 RID: 7556
		internal Image image_2;

		// Token: 0x04001D85 RID: 7557
		internal TextBlock textBlock_0;

		// Token: 0x04001D86 RID: 7558
		internal ScrollViewer scrollViewer_0;

		// Token: 0x04001D87 RID: 7559
		internal ItemsControl itemsControl_1;

		// Token: 0x04001D88 RID: 7560
		internal Grid grid_4;

		// Token: 0x04001D89 RID: 7561
		internal TextBlock textBlock_1;

		// Token: 0x04001D8A RID: 7562
		internal TextBlock textBlock_2;

		// Token: 0x04001D8B RID: 7563
		internal TextBlock textBlock_3;

		// Token: 0x04001D8C RID: 7564
		internal TextBlock textBlock_4;

		// Token: 0x04001D8D RID: 7565
		internal TextBlock textBlock_5;

		// Token: 0x04001D8E RID: 7566
		internal TextBlock textBlock_6;

		// Token: 0x04001D8F RID: 7567
		internal TextBlock textBlock_7;

		// Token: 0x04001D90 RID: 7568
		internal TextBlock textBlock_8;

		// Token: 0x04001D91 RID: 7569
		internal Border border_0;

		// Token: 0x04001D92 RID: 7570
		internal Border border_1;

		// Token: 0x04001D93 RID: 7571
		internal Border border_2;

		// Token: 0x04001D94 RID: 7572
		internal Button button_3;

		// Token: 0x04001D95 RID: 7573
		internal Button button_4;

		// Token: 0x04001D96 RID: 7574
		private bool bool_1;

		// Token: 0x02000711 RID: 1809
		private sealed class Class870
		{
			// Token: 0x06002D3A RID: 11578 RVA: 0x0001D108 File Offset: 0x0001B308
			internal long method_0()
			{
				return Class765.smethod_13(this.class757_0.List_0, this.class757_0.String_3, this.class757_0.Boolean_1);
			}

			// Token: 0x04001D97 RID: 7575
			public Class757 class757_0;
		}

		// Token: 0x02000712 RID: 1810
		[StructLayout(LayoutKind.Auto)]
		private struct Struct488 : IAsyncStateMachine
		{
			// Token: 0x06002D3B RID: 11579 RVA: 0x000AD118 File Offset: 0x000AB318
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_175;
					}
					case 2:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
						goto IL_1D6;
					}
					case 3:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
						goto IL_2B9;
					}
					case 4:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num6 = -1;
						num = -1;
						this.int_0 = num6;
						goto IL_382;
					}
					case 5:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num7 = -1;
						num = -1;
						this.int_0 = num7;
						goto IL_736;
					}
					case 6:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num8 = -1;
						num = -1;
						this.int_0 = num8;
						goto IL_79B;
					}
					case 7:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num9 = -1;
						num = -1;
						this.int_0 = num9;
						goto IL_83B;
					}
					default:
						this.class871_0 = new dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class871();
						this.class871_0.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;
						dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.method_1();
						if (Class551.class753_0.method_40().GetValueOrDefault() && Class551.class753_0.method_44().GetValueOrDefault())
						{
							dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_3++;
							awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(this.class871_0.method_0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num10 = 0;
								num = 0;
								this.int_0 = num10;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(this.class871_0.method_1)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num11 = 1;
								num = 1;
								this.int_0 = num11;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
								return;
							}
							goto IL_175;
						}
						break;
					}
					awaiter.GetResult();
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.method_2();
					goto IL_886;
					IL_175:
					awaiter.GetResult();
					if (!Class144.bool_0)
					{
						goto IL_1DD;
					}
					awaiter = Class144.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num12 = 2;
						num = 2;
						this.int_0 = num12;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
						return;
					}
					IL_1D6:
					awaiter.GetResult();
					IL_1DD:
					this.dictionary_0 = GClass279.smethod_0().method_19();
					Dictionary<Type, Dictionary<string, GClass279.GStruct2>>.Enumerator enumerator = this.dictionary_0.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair = enumerator.Current;
							Dictionary<string, GClass279.GStruct2>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									KeyValuePair<string, GClass279.GStruct2> keyValuePair2 = enumerator2.Current;
									dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_3++;
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.method_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 3;
						num = 3;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
						return;
					}
					IL_2B9:
					awaiter.GetResult();
					if (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_0)))
					{
						dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.bool_0 = true;
						this.dictionary_0[typeof(Class802)].ToList<KeyValuePair<string, GClass279.GStruct2>>().ForEach(new Action<KeyValuePair<string, GClass279.GStruct2>>(this.class871_0.method_2));
					}
					this.int_1 = 0;
					IL_34A:
					if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_21)
					{
						int num14 = this.int_1;
						this.int_1 = num14 + 1;
						if (num14 <= 1000)
						{
							awaiter = Task.Delay(20).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_382;
							}
							int num15 = 4;
							num = 4;
							this.int_0 = num15;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
							return;
						}
					}
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.int_1 = (int)dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.double_0;
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.string_0 = (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_1)) ? this.dictionary_0[typeof(Class797)].Count<KeyValuePair<string, GClass279.GStruct2>>().ToString() : "0");
					int num16 = 0 + (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_2)) ? this.dictionary_0[typeof(Class803)].Count<KeyValuePair<string, GClass279.GStruct2>>() : 0);
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.string_1 = (num16 + (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_3)) ? this.dictionary_0[typeof(Class801)].Count<KeyValuePair<string, GClass279.GStruct2>>() : 0)).ToString();
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd2 = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd;
					string string_;
					if (!this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_4)))
					{
						string_ = "0";
					}
					else
					{
						string_ = this.dictionary_0[typeof(Class804)].Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_5)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd2.string_2 = string_;
					this.class871_0.bool_0 = false;
					if (this.dictionary_0.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_6)))
					{
						this.class871_0.bool_0 = this.dictionary_0[typeof(Class803)].Any(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_7));
						if (this.dictionary_0[typeof(Class803)].Any(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_8)))
						{
							if (((GClass67)this.dictionary_0[typeof(Class803)].First(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875.class875_0.method_9)).Value.method_2()).method_0() == "BEST" && Class551.class753_0.method_40() == null && Class551.class753_0.method_44() == null && Class673.smethod_5("DEFENDER") != "BEST")
							{
								this.class871_0.bool_0 = true;
								Class551.class753_0.method_41(new bool?(true));
								Class551.class753_0.method_45(new bool?(false));
							}
						}
					}
					awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(this.class871_0.method_3)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num17 = 5;
						num = 5;
						this.int_0 = num17;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
						return;
					}
					goto IL_736;
					IL_382:
					awaiter.GetResult();
					goto IL_34A;
					IL_736:
					awaiter.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_0, 300).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num18 = 6;
						num = 6;
						this.int_0 = num18;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
						return;
					}
					IL_79B:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_0);
					if (!(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.list_0.Count > 0 | this.class871_0.bool_0))
					{
						dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.method_2();
						goto IL_85D;
					}
					awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(this.class871_0.method_4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num19 = 7;
						num = 7;
						this.int_0 = num19;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct488>(ref awaiter, ref this);
						return;
					}
					IL_83B:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_1);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_1, 300);
					IL_85D:;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class871_0 = null;
					this.dictionary_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_886:
				this.int_0 = -2;
				this.class871_0 = null;
				this.dictionary_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002D3C RID: 11580 RVA: 0x0001D130 File Offset: 0x0001B330
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D98 RID: 7576
			public int int_0;

			// Token: 0x04001D99 RID: 7577
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001D9A RID: 7578
			public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

			// Token: 0x04001D9B RID: 7579
			private dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class871 class871_0;

			// Token: 0x04001D9C RID: 7580
			private Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary_0;

			// Token: 0x04001D9D RID: 7581
			private int int_1;

			// Token: 0x04001D9E RID: 7582
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000713 RID: 1811
		[StructLayout(LayoutKind.Auto)]
		private struct Struct489 : IAsyncStateMachine
		{
			// Token: 0x06002D3D RID: 11581 RVA: 0x000ADA18 File Offset: 0x000ABC18
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;
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
						goto IL_148;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_20A;
					default:
						this.class873_0 = new dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class873();
						this.class873_0.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;
						this.class873_0.bool_0 = false;
						awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(this.class873_0.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct489>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (!this.class873_0.bool_0)
					{
						goto IL_231;
					}
					this.class873_0.int_0 = Class379.smethod_3(1, 26);
					awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(this.class873_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct489>(ref awaiter, ref this);
						return;
					}
					IL_148:
					awaiter.GetResult();
					this.class873_0.int_1 = (int)dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.double_0 - dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.int_1;
					this.class873_0.string_0 = ((this.class873_0.int_1 > 0) ? "+" : ((this.class873_0.int_1 < 0) ? "—" : string.Empty));
					awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(this.class873_0.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct489>(ref awaiter, ref this);
						return;
					}
					IL_20A:
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class873_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				IL_231:
				this.int_0 = -2;
				this.class873_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002D3E RID: 11582 RVA: 0x0001D13E File Offset: 0x0001B33E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001D9F RID: 7583
			public int int_0;

			// Token: 0x04001DA0 RID: 7584
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001DA1 RID: 7585
			public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

			// Token: 0x04001DA2 RID: 7586
			private dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class873 class873_0;

			// Token: 0x04001DA3 RID: 7587
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000714 RID: 1812
		private sealed class Class871
		{
			// Token: 0x06002D40 RID: 11584 RVA: 0x0001D14C File Offset: 0x0001B34C
			internal void method_0()
			{
				this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.textBlock_8.Text = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_3.ToString();
			}

			// Token: 0x06002D41 RID: 11585 RVA: 0x0001D168 File Offset: 0x0001B368
			internal void method_1()
			{
				this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.grid_0.Visibility = Visibility.Visible;
				this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.grid_0.Opacity = 1.0;
			}

			// Token: 0x06002D42 RID: 11586 RVA: 0x000ADC8C File Offset: 0x000ABE8C
			internal void method_2(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
			{
				if (keyValuePair_0.Value.method_2().GetType() == typeof(Class527))
				{
					Class527 @class = keyValuePair_0.Value.method_2() as Class527;
					this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.long_0 = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.long_0 + (long)@class.Size * 1024L * 1024L;
				}
				if (keyValuePair_0.Value.method_2().GetType() == typeof(Class757))
				{
					Class757 class2 = (Class757)keyValuePair_0.Value.method_2();
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.list_2.Add(class2);
					this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.long_0 = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.long_0 + Class765.smethod_13(class2.List_0, class2.String_3, class2.Boolean_1);
				}
			}

			// Token: 0x06002D43 RID: 11587 RVA: 0x0001D14C File Offset: 0x0001B34C
			internal void method_3()
			{
				this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.textBlock_8.Text = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_3.ToString();
			}

			// Token: 0x06002D44 RID: 11588 RVA: 0x000ADD78 File Offset: 0x000ABF78
			internal void method_4()
			{
				if (this.bool_0)
				{
					AnimationBehavior.SetSourceUri(this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.image_1, new Uri("pack://application:,,,/BoosterX;component/Resources/Images/Apply/DisableTamper" + Class298.smethod_2("CurrentLocalization") + ".gif"));
					this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.grid_2.Visibility = Visibility.Visible;
				}
				else
				{
					this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.grid_2.Visibility = Visibility.Collapsed;
				}
				this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.stackPanel_0.Visibility = ((this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.list_0.Count > 0) ? Visibility.Visible : Visibility.Collapsed);
			}

			// Token: 0x04001DA4 RID: 7588
			public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

			// Token: 0x04001DA5 RID: 7589
			public bool bool_0;
		}

		// Token: 0x02000715 RID: 1813
		private sealed class Class872
		{
			// Token: 0x06002D46 RID: 11590 RVA: 0x0001D194 File Offset: 0x0001B394
			internal bool method_0(string string_0)
			{
				return this.class798_0.method_6().Id.StartsWith(string_0, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04001DA6 RID: 7590
			public Class798 class798_0;
		}

		// Token: 0x02000716 RID: 1814
		[StructLayout(LayoutKind.Auto)]
		private struct Struct490 : IAsyncStateMachine
		{
			// Token: 0x06002D47 RID: 11591 RVA: 0x000ADE0C File Offset: 0x000AC00C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd @object = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Run(new Action(@object.method_14)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct490>(ref awaiter, ref this);
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
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06002D48 RID: 11592 RVA: 0x0001D1AD File Offset: 0x0001B3AD
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DA7 RID: 7591
			public int int_0;

			// Token: 0x04001DA8 RID: 7592
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001DA9 RID: 7593
			public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

			// Token: 0x04001DAA RID: 7594
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x02000717 RID: 1815
		private sealed class Class873
		{
			// Token: 0x06002D4A RID: 11594 RVA: 0x0001D1BB File Offset: 0x0001B3BB
			internal void method_0()
			{
				this.bool_0 = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.IsVisible;
			}

			// Token: 0x06002D4B RID: 11595 RVA: 0x0001D1CE File Offset: 0x0001B3CE
			internal void method_1()
			{
				this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.textBlock_2.Text = Class298.smethod_2(string.Format("GLHFNEW{0}", this.int_0));
			}

			// Token: 0x06002D4C RID: 11596 RVA: 0x000ADECC File Offset: 0x000AC0CC
			internal void method_2()
			{
				this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.textBlock_1.Text = this.string_0 + Math.Abs(this.int_1).ToString() + "%";
			}

			// Token: 0x04001DAB RID: 7595
			public bool bool_0;

			// Token: 0x04001DAC RID: 7596
			public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

			// Token: 0x04001DAD RID: 7597
			public int int_0;

			// Token: 0x04001DAE RID: 7598
			public string string_0;

			// Token: 0x04001DAF RID: 7599
			public int int_1;
		}

		// Token: 0x02000718 RID: 1816
		[StructLayout(LayoutKind.Auto)]
		private struct Struct491 : IAsyncStateMachine
		{
			// Token: 0x06002D4D RID: 11597 RVA: 0x000ADF10 File Offset: 0x000AC110
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<Task> awaiter3;
					switch (num)
					{
					case 0:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						break;
					}
					case 1:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
						goto IL_130;
					}
					case 2:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
						goto IL_1E3;
					}
					case 3:
						IL_214:
						try
						{
							if (num != 3)
							{
								goto IL_2CA;
							}
							IL_21E:
							dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class870 @class;
							try
							{
								TaskAwaiter<long> awaiter2;
								if (num != 3)
								{
									this.long_1 = this.long_0;
									awaiter2 = Task.Run<long>(new Func<long>(@class.method_0)).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										int num5 = 3;
										num = 3;
										this.int_0 = num5;
										this.taskAwaiter_1 = awaiter2;
										this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<long>, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491>(ref awaiter2, ref this);
										return;
									}
								}
								else
								{
									awaiter2 = this.taskAwaiter_1;
									this.taskAwaiter_1 = default(TaskAwaiter<long>);
									int num6 = -1;
									num = -1;
									this.int_0 = num6;
								}
								long result = awaiter2.GetResult();
								this.long_0 = this.long_1 + result;
								goto IL_2CA;
							}
							catch
							{
								goto IL_2CA;
							}
							IL_2AE:
							@class = new dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class870();
							@class.class757_0 = this.enumerator_0.Current;
							goto IL_21E;
							IL_2CA:
							if (this.enumerator_0.MoveNext())
							{
								goto IL_2AE;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.enumerator_0).Dispose();
							}
						}
						this.enumerator_0 = default(List<Class757>.Enumerator);
						goto IL_2FB;
					case 4:
					{
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter<Task>);
						int num7 = -1;
						num = -1;
						this.int_0 = num7;
						goto IL_3D1;
					}
					case 5:
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num8 = -1;
						num = -1;
						this.int_0 = num8;
						goto IL_434;
					}
					default:
						awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.method_12)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num9 = 0;
							num = 0;
							this.int_0 = num9;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					Class144.bool_0 = false;
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_26(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_3);
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_20(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_3, 300);
					this.stopwatch_0 = new Stopwatch();
					this.stopwatch_0.Start();
					this.timeSpan_0 = TimeSpan.FromMinutes(10.0);
					dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_19();
					IL_108:
					if (!(dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.string_0 != "FINISHED"))
					{
						goto IL_174;
					}
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num10 = 1;
						num = 1;
						this.int_0 = num10;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491>(ref awaiter, ref this);
						return;
					}
					IL_130:
					awaiter.GetResult();
					if (!(this.stopwatch_0.Elapsed > this.timeSpan_0))
					{
						goto IL_108;
					}
					IL_174:
					dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.string_0 = string.Empty;
					awaiter = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Dispatcher.InvokeAsync(new Action(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.method_13)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num11 = 2;
						num = 2;
						this.int_0 = num11;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491>(ref awaiter, ref this);
						return;
					}
					IL_1E3:
					awaiter.GetResult();
					this.long_0 = 0L;
					if (dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.bool_0)
					{
						this.enumerator_0 = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.list_2.GetEnumerator();
						goto IL_214;
					}
					IL_2FB:
					try
					{
						dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.textBlock_3.Text = string.Format("{0:0.## MB}", (double)(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.long_0 - this.long_0) / 1024.0 / 1024.0);
					}
					catch
					{
						dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.textBlock_3.Text = "0 MB";
					}
					Task task = Class144.smethod_0();
					Task task2 = Task.Delay(TimeSpan.FromSeconds(10.0));
					awaiter3 = Task.WhenAny(new Task[]
					{
						task,
						task2
					}).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						int num12 = 4;
						num = 4;
						this.int_0 = num12;
						this.taskAwaiter_2 = awaiter3;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491>(ref awaiter3, ref this);
						return;
					}
					IL_3D1:
					awaiter3.GetResult();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_3, 300).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 5;
						num = 5;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct491>(ref awaiter, ref this);
						return;
					}
					IL_434:
					awaiter.GetResult();
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_3);
					dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_18();
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.stopwatch_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.stopwatch_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x06002D4E RID: 11598 RVA: 0x0001D1FB File Offset: 0x0001B3FB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DB0 RID: 7600
			public int int_0;

			// Token: 0x04001DB1 RID: 7601
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001DB2 RID: 7602
			public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

			// Token: 0x04001DB3 RID: 7603
			private Stopwatch stopwatch_0;

			// Token: 0x04001DB4 RID: 7604
			private TimeSpan timeSpan_0;

			// Token: 0x04001DB5 RID: 7605
			private long long_0;

			// Token: 0x04001DB6 RID: 7606
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x04001DB7 RID: 7607
			private List<Class757>.Enumerator enumerator_0;

			// Token: 0x04001DB8 RID: 7608
			private long long_1;

			// Token: 0x04001DB9 RID: 7609
			private TaskAwaiter<long> taskAwaiter_1;

			// Token: 0x04001DBA RID: 7610
			private TaskAwaiter<Task> taskAwaiter_2;
		}

		// Token: 0x02000719 RID: 1817
		[StructLayout(LayoutKind.Auto)]
		private struct Struct492 : IAsyncStateMachine
		{
			// Token: 0x06002D4F RID: 11599 RVA: 0x000AE408 File Offset: 0x000AC608
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd = this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_1, 300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Struct492>(ref awaiter, ref this);
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
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_27(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.grid_1);
					dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.method_2();
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

			// Token: 0x06002D50 RID: 11600 RVA: 0x0001D209 File Offset: 0x0001B409
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001DBB RID: 7611
			public int int_0;

			// Token: 0x04001DBC RID: 7612
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001DBD RID: 7613
			public dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

			// Token: 0x04001DBE RID: 7614
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x0200071A RID: 1818
		private sealed class Class874
		{
			// Token: 0x06002D52 RID: 11602 RVA: 0x0001D217 File Offset: 0x0001B417
			internal bool method_0(GClass170 gclass170_0)
			{
				return gclass170_0.WhatWillBrake == this.string_0;
			}

			// Token: 0x04001DBF RID: 7615
			public string string_0;
		}

		// Token: 0x0200071B RID: 1819
		[Serializable]
		private sealed class Class875
		{
			// Token: 0x06002D55 RID: 11605 RVA: 0x0000DD22 File Offset: 0x0000BF22
			internal bool method_0(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class802);
			}

			// Token: 0x06002D56 RID: 11606 RVA: 0x0000DCDA File Offset: 0x0000BEDA
			internal bool method_1(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class797);
			}

			// Token: 0x06002D57 RID: 11607 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
			internal bool method_2(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class803);
			}

			// Token: 0x06002D58 RID: 11608 RVA: 0x0000DCF2 File Offset: 0x0000BEF2
			internal bool method_3(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class801);
			}

			// Token: 0x06002D59 RID: 11609 RVA: 0x0000DC92 File Offset: 0x0000BE92
			internal bool method_4(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class804);
			}

			// Token: 0x06002D5A RID: 11610 RVA: 0x000AE4D8 File Offset: 0x000AC6D8
			internal bool method_5(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
			{
				return keyValuePair_0.Value.method_2().ToString() != "Enable";
			}

			// Token: 0x06002D5B RID: 11611 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
			internal bool method_6(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class803);
			}

			// Token: 0x06002D5C RID: 11612 RVA: 0x0001D236 File Offset: 0x0001B436
			internal bool method_7(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
			{
				return keyValuePair_0.Key == Class298.smethod_2("DefenderAndSmartScreenDebloat");
			}

			// Token: 0x06002D5D RID: 11613 RVA: 0x0001D24F File Offset: 0x0001B44F
			internal bool method_8(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
			{
				return keyValuePair_0.Key == Class298.smethod_2("DefenderName");
			}

			// Token: 0x06002D5E RID: 11614 RVA: 0x0001D24F File Offset: 0x0001B44F
			internal bool method_9(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
			{
				return keyValuePair_0.Key == Class298.smethod_2("DefenderName");
			}

			// Token: 0x06002D5F RID: 11615 RVA: 0x000AE504 File Offset: 0x000AC704
			internal bool method_10(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
			{
				return keyValuePair_0.Key == typeof(Class799) || keyValuePair_0.Key == typeof(Class803) || keyValuePair_0.Key == typeof(Class798);
			}

			// Token: 0x06002D60 RID: 11616 RVA: 0x0001D268 File Offset: 0x0001B468
			internal int method_11(GClass170 gclass170_0)
			{
				return gclass170_0.Sort;
			}

			// Token: 0x04001DC0 RID: 7616
			public static readonly dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875 class875_0 = new dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd.Class875();

			// Token: 0x04001DC1 RID: 7617
			public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_0;

			// Token: 0x04001DC2 RID: 7618
			public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_1;

			// Token: 0x04001DC3 RID: 7619
			public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_2;

			// Token: 0x04001DC4 RID: 7620
			public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_3;

			// Token: 0x04001DC5 RID: 7621
			public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_4;

			// Token: 0x04001DC6 RID: 7622
			public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_5;

			// Token: 0x04001DC7 RID: 7623
			public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_6;

			// Token: 0x04001DC8 RID: 7624
			public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_7;

			// Token: 0x04001DC9 RID: 7625
			public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_8;

			// Token: 0x04001DCA RID: 7626
			public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_9;

			// Token: 0x04001DCB RID: 7627
			public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_10;

			// Token: 0x04001DCC RID: 7628
			public static Func<GClass170, int> func_11;
		}
	}
}
