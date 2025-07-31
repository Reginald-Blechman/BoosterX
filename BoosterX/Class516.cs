using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Newtonsoft.Json;
using ns0;

// Token: 0x0200049D RID: 1181
internal sealed class Class516 : GClass162
{
	// Token: 0x06001EA0 RID: 7840 RVA: 0x0007D234 File Offset: 0x0007B434
	public Class516()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		Page page = Class406.smethod_0().list_2.FirstOrDefault(new Func<Page, bool>(Class516.Class577.class577_0.method_0));
		Class495 @class = ((page != null) ? page.DataContext : null) as Class495;
		this.class532_0 = ((@class != null) ? @class.ChoosenForImport : null);
		Class532 class2 = this.class532_0;
		string profileName;
		if (class2 != null)
		{
			if ((profileName = class2.Name) != null)
			{
				goto IL_C2;
			}
		}
		profileName = "Unknown";
		IL_C2:
		this.ProfileName = profileName;
		this.method_15();
		this.method_3();
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x00014373 File Offset: 0x00012573
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		if (this.MainVisibility == Visibility.Collapsed)
		{
			this.method_16();
		}
		base.method_0("Pages");
	}

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00014390 File Offset: 0x00012590
	// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00014398 File Offset: 0x00012598
	public ObservableCollection<Class502> Pages
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			base.method_1<ObservableCollection<Class502>>(ref this.observableCollection_0, value, "Pages", null);
		}
	}

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x000143AF File Offset: 0x000125AF
	// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x000143B7 File Offset: 0x000125B7
	public string ProfileName
	{
		get
		{
			return this.string_0;
		}
		set
		{
			base.method_1<string>(ref this.string_0, value, "ProfileName", null);
		}
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x000143CE File Offset: 0x000125CE
	// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x000143D6 File Offset: 0x000125D6
	public Visibility ButtonsVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			base.method_1<Visibility>(ref this.visibility_0, value, "ButtonsVisibility", null);
		}
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x0007D314 File Offset: 0x0007B514
	private void method_2()
	{
		foreach (Class502 @class in this.Pages)
		{
			if (@class.type_0 != null && !@class.ToApply)
			{
				@class.class762_0.method_2()();
			}
			if (@class.Name == Class298.smethod_2("import") && !@class.ToApply)
			{
				Class784.dictionary_0.Remove(Class298.smethod_2("import") + " " + @class.Desc);
			}
			if (@class.bool_0 && !@class.ToApply)
			{
				Class784.dictionary_0.Remove(Class298.smethod_2("storexins5") + " " + @class.Name);
			}
		}
	}

	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x0007D408 File Offset: 0x0007B608
	public GClass280 ApplyCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_17), null));
			}
			return result;
		}
	}

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x06001EAA RID: 7850 RVA: 0x0007D43C File Offset: 0x0007B63C
	public GClass280 MoveToOptimizationPage
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_18), null));
			}
			return result;
		}
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x0007D470 File Offset: 0x0007B670
	private void method_3()
	{
		Class516.Struct314 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class516.Struct314>(ref @struct);
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x0007D4A8 File Offset: 0x0007B6A8
	private Task method_4()
	{
		Class516.Struct302 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct302>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x0007D4EC File Offset: 0x0007B6EC
	private void method_5()
	{
		Class516.Class569 @class = new Class516.Class569();
		@class.class516_0 = this;
		try
		{
			if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18 && this.class532_0.byte_0 != null && Class746.smethod_4<byte>(this.class532_0.byte_0))
			{
				@class.gclass182_0 = Class221.smethod_0(false);
				@class.string_0 = Path.Combine(Class169.string_4, "NvidiaBackUp.nvx");
				File.WriteAllBytes(@class.string_0, this.class532_0.byte_0);
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}
		catch (Exception exception_)
		{
			GClass268.smethod_1(exception_);
		}
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x0007D59C File Offset: 0x0007B79C
	private Task method_6()
	{
		Class516.Struct305 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct305>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x0007D5E0 File Offset: 0x0007B7E0
	private Task method_7()
	{
		Class516.Struct313 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct313>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x0007D624 File Offset: 0x0007B824
	private Task method_8()
	{
		Class516.Struct312 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct312>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x0007D668 File Offset: 0x0007B868
	private Task method_9()
	{
		Class516.Struct306 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct306>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x0007D6AC File Offset: 0x0007B8AC
	private Task method_10()
	{
		Class516.Struct311 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct311>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x0007D6F0 File Offset: 0x0007B8F0
	private Task method_11(Type type_0, List<Class265> list_0)
	{
		Class516.Struct310 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.type_0 = type_0;
		@struct.list_0 = list_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct310>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x0007D744 File Offset: 0x0007B944
	private void method_12(Class512 class512_0, string string_2)
	{
		if (string_2 == "DEFAULT")
		{
			class512_0.method_36();
			return;
		}
		if (string_2 == "BEST")
		{
			class512_0.method_34();
			return;
		}
		if (!(string_2 == "OPTIMAL"))
		{
			class512_0.method_37(string_2);
			return;
		}
		class512_0.method_35();
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x0007D798 File Offset: 0x0007B998
	private void method_13(string string_2)
	{
		Class516.Class567 @class = new Class516.Class567();
		@class.class516_0 = this;
		try
		{
			@class.class293_0 = JsonConvert.DeserializeObject<Class293>(string_2);
			if (!(@class.class293_0.Name == GClass250.smethod_7()) && !(@class.class293_0.Guid == GClass250.smethod_6()))
			{
				@class.string_0 = Path.Combine(Class169.string_4, "PowerPlan.pow");
				File.WriteAllBytes(@class.string_0, @class.class293_0.Data.smethod_1());
				string key = Class298.smethod_2("import") + " " + @class.class293_0.Name;
				if (Class784.dictionary_0.ContainsKey(key))
				{
					Class784.dictionary_0.Remove(key);
				}
				Class784.dictionary_0.Add(key, new Action(@class.method_0));
				Application.Current.Dispatcher.Invoke(new Action(@class.method_1));
			}
		}
		catch (Exception exception_)
		{
			GClass268.smethod_1(exception_);
		}
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x000143ED File Offset: 0x000125ED
	// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x000143F5 File Offset: 0x000125F5
	public string StatusText
	{
		get
		{
			return this.string_1;
		}
		set
		{
			base.method_1<string>(ref this.string_1, value, "StatusText", null);
		}
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0001440C File Offset: 0x0001260C
	// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00014414 File Offset: 0x00012614
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			base.method_1<SolidColorBrush>(ref this.solidColorBrush_0, value, "StatusColor", null);
		}
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x06001EBA RID: 7866 RVA: 0x0001442B File Offset: 0x0001262B
	// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00014433 File Offset: 0x00012633
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			base.method_1<double>(ref this.double_0, value, "StatusOpacity", null);
		}
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x0007D8AC File Offset: 0x0007BAAC
	private void method_14(string string_2, SolidColorBrush solidColorBrush_1)
	{
		Class516.Struct307 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.string_0 = string_2;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class516.Struct307>(ref @struct);
	}

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06001EBD RID: 7869 RVA: 0x0001444A File Offset: 0x0001264A
	// (set) Token: 0x06001EBE RID: 7870 RVA: 0x00014452 File Offset: 0x00012652
	public double AnimationOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			base.method_1<double>(ref this.double_1, value, "AnimationOpacity", null);
		}
	}

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x06001EBF RID: 7871 RVA: 0x00014469 File Offset: 0x00012669
	// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x00014471 File Offset: 0x00012671
	public Visibility AnimationVisibility
	{
		get
		{
			return this.visibility_1;
		}
		set
		{
			base.method_1<Visibility>(ref this.visibility_1, value, "AnimationVisibility", null);
		}
	}

	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00014488 File Offset: 0x00012688
	// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x00014490 File Offset: 0x00012690
	public Visibility MainVisibility
	{
		get
		{
			return this.visibility_2;
		}
		set
		{
			base.method_1<Visibility>(ref this.visibility_2, value, "MainVisibility", null);
		}
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x0007D8F4 File Offset: 0x0007BAF4
	private void method_15()
	{
		Class516.Struct304 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class516.Struct304>(ref @struct);
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x0007D92C File Offset: 0x0007BB2C
	private void method_16()
	{
		Class516.Struct303 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class516.Struct303>(ref @struct);
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x000144A7 File Offset: 0x000126A7
	private void method_17(object object_0)
	{
		this.method_2();
		Class406.smethod_0().method_4(typeof(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd), Class406.smethod_0().frame_0);
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x0007D964 File Offset: 0x0007BB64
	private void method_18(object object_0)
	{
		this.method_2();
		Class787.bool_0 = true;
		((dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)Window.GetWindow(Class406.smethod_0().list_2.First(new Func<Page, bool>(Class516.Class577.class577_0.method_1)))).radioButton_1.IsChecked = new bool?(true);
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x0007D9C8 File Offset: 0x0007BBC8
	private Task method_19()
	{
		Class516.Struct315 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct315>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000144CD File Offset: 0x000126CD
	private void method_20()
	{
		this.Pages.Add(new Class502(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TJT6P4HVXCZBEX5BLD2JKUFM4PCTXZ75CCLQQGATQ_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x000144F5 File Offset: 0x000126F5
	private void method_21()
	{
		this.Pages.Add(new Class502(typeof(dje_zW8UT86PFFUV9Z45HQGEPNW84PP2V6MAW9N8553UZZTTYSB3KQJFJHF65C6UQ_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x0001451D File Offset: 0x0001271D
	private void method_22()
	{
		this.Pages.Add(new Class502(typeof(dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x00014545 File Offset: 0x00012745
	private void method_23()
	{
		this.Pages.Add(new Class502(typeof(dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x0007DA0C File Offset: 0x0007BC0C
	internal static void smethod_0(ObservableCollection<Class490> observableCollection_1, ref Class516.Struct316 struct316_0)
	{
		using (IEnumerator<Class490> enumerator = observableCollection_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class516.Class575 @class = new Class516.Class575();
				@class.class490_0 = enumerator.Current;
				Class265 class2 = struct316_0.list_0.FirstOrDefault(new Func<Class265, bool>(@class.method_0));
				if (class2 != null)
				{
					Class516.Class563 class3 = new Class516.Class563();
					class3.class575_0 = @class;
					class3.bool_0 = Convert.ToBoolean(class2.State);
					Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
				}
			}
		}
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x0001456D File Offset: 0x0001276D
	private void method_24()
	{
		this.Pages.Add(new Class502(typeof(dje_zRLTJAE4HM9QEZA4XCZRB8CQJP23F3H6N7P96KCK67U3FNVEKLZBJJQB3ZPVQ_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x00014595 File Offset: 0x00012795
	private void method_25()
	{
		this.Pages.Add(new Class502(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TW4LTJ4MDTW787U8ZU6EPEUUSCU2XC89GWA_ejd), null, string.Empty, string.Empty, false));
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x0007DAB0 File Offset: 0x0007BCB0
	private Task method_26()
	{
		Class516.Struct309 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct309>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x0007DAF4 File Offset: 0x0007BCF4
	private Task method_27()
	{
		Class516.Struct308 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class516_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class516.Struct308>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001439 RID: 5177
	private readonly Class532 class532_0;

	// Token: 0x0400143A RID: 5178
	private ObservableCollection<Class502> observableCollection_0 = new ObservableCollection<Class502>();

	// Token: 0x0400143B RID: 5179
	private string string_0;

	// Token: 0x0400143C RID: 5180
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x0400143D RID: 5181
	private GClass280 gclass280_0;

	// Token: 0x0400143E RID: 5182
	private GClass280 gclass280_1;

	// Token: 0x0400143F RID: 5183
	private string string_1 = string.Empty;

	// Token: 0x04001440 RID: 5184
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04001441 RID: 5185
	private double double_0;

	// Token: 0x04001442 RID: 5186
	private double double_1;

	// Token: 0x04001443 RID: 5187
	private Visibility visibility_1 = Visibility.Collapsed;

	// Token: 0x04001444 RID: 5188
	private Visibility visibility_2 = Visibility.Collapsed;

	// Token: 0x0200049E RID: 1182
	private sealed class Class558
	{
		// Token: 0x06001ED2 RID: 7890 RVA: 0x000145BD File Offset: 0x000127BD
		internal void method_0()
		{
			this.class559_0.class516_0.method_12(this.class559_0.class512_0, this.class265_0.State);
		}

		// Token: 0x04001445 RID: 5189
		public Class265 class265_0;

		// Token: 0x04001446 RID: 5190
		public Class516.Class559 class559_0;
	}

	// Token: 0x0200049F RID: 1183
	[StructLayout(LayoutKind.Auto)]
	private struct Struct302 : IAsyncStateMachine
	{
		// Token: 0x06001ED3 RID: 7891 RVA: 0x0007DB38 File Offset: 0x0007BD38
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.list_0 = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.NetworkAdapter);
						this.gclass180_0 = GClass28.smethod_0(false);
						awaiter = GClass28.smethod_1().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct302>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					List<Class265>.Enumerator enumerator = this.list_0.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class265 class2 = enumerator.Current;
							Class516.Class574 class3 = new Class516.Class574();
							string[] array = class2.Name.Split(new char[]
							{
								'|'
							});
							class3.string_0 = array[0];
							class3.string_1 = array[1];
							if (this.gclass180_0.NetworkAdapters.Any(new Func<GClass179, bool>(class3.method_0)))
							{
								GClass179 gclass = this.gclass180_0.NetworkAdapters.First(new Func<GClass179, bool>(class3.method_1));
								if (gclass.Settings.Any(new Func<GClass171, bool>(class3.method_2)))
								{
									GClass171 gclass2 = gclass.Settings.First(new Func<GClass171, bool>(class3.method_3));
									if (gclass2.Values != null)
									{
										string selectedLabel;
										if (gclass2.gclass86_0.method_5().TryGetValue(class2.State, out selectedLabel))
										{
											gclass2.SelectedLabel = selectedLabel;
										}
									}
									else
									{
										gclass2.CustomValue = class2.State;
									}
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
					Application.Current.Dispatcher.Invoke(new Action(@class.method_20));
					this.list_0 = null;
					this.gclass180_0 = null;
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
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

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000145E5 File Offset: 0x000127E5
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001447 RID: 5191
		public int int_0;

		// Token: 0x04001448 RID: 5192
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001449 RID: 5193
		public Class516 class516_0;

		// Token: 0x0400144A RID: 5194
		private List<Class265> list_0;

		// Token: 0x0400144B RID: 5195
		private GClass180 gclass180_0;

		// Token: 0x0400144C RID: 5196
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A0 RID: 1184
	[StructLayout(LayoutKind.Auto)]
	private struct Struct303 : IAsyncStateMachine
	{
		// Token: 0x06001ED5 RID: 7893 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @object = this.class516_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_27)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct303>(ref awaiter, ref this);
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

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000145F3 File Offset: 0x000127F3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400144D RID: 5197
		public int int_0;

		// Token: 0x0400144E RID: 5198
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400144F RID: 5199
		public Class516 class516_0;

		// Token: 0x04001450 RID: 5200
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A1 RID: 1185
	private sealed class Class559
	{
		// Token: 0x06001ED8 RID: 7896 RVA: 0x00014601 File Offset: 0x00012801
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name == this.class512_0.method_21();
		}

		// Token: 0x04001451 RID: 5201
		public Class512 class512_0;

		// Token: 0x04001452 RID: 5202
		public Class516 class516_0;
	}

	// Token: 0x020004A2 RID: 1186
	[StructLayout(LayoutKind.Auto)]
	private struct Struct304 : IAsyncStateMachine
	{
		// Token: 0x06001ED9 RID: 7897 RVA: 0x0007DE60 File Offset: 0x0007C060
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @object = this.class516_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_26)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct304>(ref awaiter, ref this);
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

		// Token: 0x06001EDA RID: 7898 RVA: 0x00014619 File Offset: 0x00012819
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001453 RID: 5203
		public int int_0;

		// Token: 0x04001454 RID: 5204
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001455 RID: 5205
		public Class516 class516_0;

		// Token: 0x04001456 RID: 5206
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A3 RID: 1187
	[StructLayout(LayoutKind.Auto)]
	private struct Struct305 : IAsyncStateMachine
	{
		// Token: 0x06001EDB RID: 7899 RVA: 0x0007DF20 File Offset: 0x0007C120
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						Class265 class2 = @class.class532_0.class261_0.method_0(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Affinity, "ThreadsCount");
						string a = (class2 != null) ? class2.State : null;
						string text = Class551.class753_0.method_94();
						if (a != ((text != null) ? text.ToString() : null))
						{
							goto IL_207;
						}
						this.class520_0 = Class589.smethod_1(false);
						awaiter = Class589.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct305>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					List<Class265> list = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Service);
					if (list != null)
					{
						List<Class265> source = list.Select(new Func<Class265, Class265>(Class516.Class577.class577_0.method_2)).ToList<Class265>();
						IEnumerator<GClass184> enumerator = this.class520_0.AllServices.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Class516.Class568 class3 = new Class516.Class568();
								class3.gclass184_0 = enumerator.Current;
								class3.string_0 = Class734.smethod_2(class3.gclass184_0.ServiceName).ToLower();
								Class265 class4 = source.FirstOrDefault(new Func<Class265, bool>(class3.method_0));
								if (class4 != null)
								{
									Class516.Class566 class5 = new Class516.Class566();
									class5.class568_0 = class3;
									class5.serviceStartMode_0 = GClass219.smethod_2(class4.State);
									Application.Current.Dispatcher.Invoke(new Action(class5.method_0));
								}
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						Application.Current.Dispatcher.Invoke(new Action(@class.method_21));
						this.class520_0 = null;
					}
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_207:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00014627 File Offset: 0x00012827
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001457 RID: 5207
		public int int_0;

		// Token: 0x04001458 RID: 5208
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001459 RID: 5209
		public Class516 class516_0;

		// Token: 0x0400145A RID: 5210
		private Class520 class520_0;

		// Token: 0x0400145B RID: 5211
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A4 RID: 1188
	[StructLayout(LayoutKind.Auto)]
	private struct Struct306 : IAsyncStateMachine
	{
		// Token: 0x06001EDD RID: 7901 RVA: 0x0007E194 File Offset: 0x0007C394
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.class652_0 = Class646.smethod_1(false);
						awaiter = Class646.smethod_6().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct306>(ref awaiter, ref this);
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
					Class516.Struct316 @struct;
					@struct.list_0 = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Autoruns);
					if (@struct.list_0 != null)
					{
						Class516.smethod_0(this.class652_0.RegARModels, ref @struct);
						Class516.smethod_0(this.class652_0.FileARModels, ref @struct);
						Class516.smethod_0(this.class652_0.TaskARModels, ref @struct);
						Class516.smethod_0(this.class652_0.ServiceARModels, ref @struct);
						Application.Current.Dispatcher.Invoke(new Action(@class.method_24));
						this.class652_0 = null;
					}
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
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

		// Token: 0x06001EDE RID: 7902 RVA: 0x00014635 File Offset: 0x00012835
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400145C RID: 5212
		public int int_0;

		// Token: 0x0400145D RID: 5213
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400145E RID: 5214
		public Class516 class516_0;

		// Token: 0x0400145F RID: 5215
		private Class646.Class652 class652_0;

		// Token: 0x04001460 RID: 5216
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A5 RID: 1189
	private sealed class Class560
	{
		// Token: 0x06001EE0 RID: 7904 RVA: 0x00014643 File Offset: 0x00012843
		internal void method_0()
		{
			this.class565_0.gclass186_0.MsiStatus = Convert.ToBoolean(this.class265_0.State);
		}

		// Token: 0x04001461 RID: 5217
		public Class265 class265_0;

		// Token: 0x04001462 RID: 5218
		public Class516.Class565 class565_0;
	}

	// Token: 0x020004A6 RID: 1190
	private sealed class Class561
	{
		// Token: 0x06001EE2 RID: 7906 RVA: 0x00014665 File Offset: 0x00012865
		internal void method_0()
		{
			this.class572_0.gclass186_0.IsEnabled = Convert.ToBoolean(this.class265_0.State);
		}

		// Token: 0x04001463 RID: 5219
		public Class265 class265_0;

		// Token: 0x04001464 RID: 5220
		public Class516.Class572 class572_0;
	}

	// Token: 0x020004A7 RID: 1191
	[StructLayout(LayoutKind.Auto)]
	private struct Struct307 : IAsyncStateMachine
	{
		// Token: 0x06001EE3 RID: 7907 RVA: 0x0007E314 File Offset: 0x0007C514
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B6;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_125;
				}
				IL_56:
				if (@class.StatusOpacity <= 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_12C;
				}
				@class.StatusOpacity -= 0.1;
				if (@class.StatusOpacity < 0.05)
				{
					@class.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct307>(ref awaiter, ref this);
					return;
				}
				IL_B6:
				awaiter.GetResult();
				goto IL_56;
				IL_125:
				awaiter.GetResult();
				IL_12C:
				if (@class.StatusOpacity < 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_125;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct307>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00014687 File Offset: 0x00012887
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001465 RID: 5221
		public int int_0;

		// Token: 0x04001466 RID: 5222
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001467 RID: 5223
		public Class516 class516_0;

		// Token: 0x04001468 RID: 5224
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001469 RID: 5225
		public string string_0;

		// Token: 0x0400146A RID: 5226
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004A8 RID: 1192
	private sealed class Class562
	{
		// Token: 0x06001EE6 RID: 7910 RVA: 0x00014695 File Offset: 0x00012895
		internal void method_0()
		{
			this.class571_0.class505_0.NewAffinity = this.class265_0.State;
		}

		// Token: 0x0400146B RID: 5227
		public Class265 class265_0;

		// Token: 0x0400146C RID: 5228
		public Class516.Class571 class571_0;
	}

	// Token: 0x020004A9 RID: 1193
	[StructLayout(LayoutKind.Auto)]
	private struct Struct308 : IAsyncStateMachine
	{
		// Token: 0x06001EE7 RID: 7911 RVA: 0x0007E4E8 File Offset: 0x0007C6E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_8C;
				}
				IL_2F:
				if (@class.AnimationOpacity <= 0.0)
				{
					@class.AnimationVisibility = Visibility.Collapsed;
					@class.MainVisibility = Visibility.Visible;
					goto IL_DC;
				}
				@class.AnimationOpacity -= 0.1;
				if (@class.AnimationOpacity < 0.05)
				{
					@class.AnimationOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct308>(ref awaiter, ref this);
					return;
				}
				IL_8C:
				awaiter.GetResult();
				goto IL_2F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_DC:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000146B2 File Offset: 0x000128B2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400146D RID: 5229
		public int int_0;

		// Token: 0x0400146E RID: 5230
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400146F RID: 5231
		public Class516 class516_0;

		// Token: 0x04001470 RID: 5232
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004AA RID: 1194
	private sealed class Class563
	{
		// Token: 0x06001EEA RID: 7914 RVA: 0x0007E5F4 File Offset: 0x0007C7F4
		internal void method_0()
		{
			bool? status = this.class575_0.class490_0.Status;
			bool flag = this.bool_0;
			if (!(status.GetValueOrDefault() == flag & status != null))
			{
				this.class575_0.class490_0.NewStatus = new bool?(this.bool_0);
			}
		}

		// Token: 0x04001471 RID: 5233
		public bool bool_0;

		// Token: 0x04001472 RID: 5234
		public Class516.Class575 class575_0;
	}

	// Token: 0x020004AB RID: 1195
	[StructLayout(LayoutKind.Auto)]
	private struct Struct309 : IAsyncStateMachine
	{
		// Token: 0x06001EEB RID: 7915 RVA: 0x0007E648 File Offset: 0x0007C848
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_9C;
				}
				@class.MainVisibility = Visibility.Collapsed;
				@class.AnimationVisibility = Visibility.Visible;
				IL_3F:
				if (@class.AnimationOpacity >= 1.0)
				{
					goto IL_DE;
				}
				@class.AnimationOpacity += 0.13333333333333333;
				if (@class.AnimationOpacity > 0.95)
				{
					@class.AnimationOpacity = 1.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct309>(ref awaiter, ref this);
					return;
				}
				IL_9C:
				awaiter.GetResult();
				goto IL_3F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_DE:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000146C0 File Offset: 0x000128C0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001473 RID: 5235
		public int int_0;

		// Token: 0x04001474 RID: 5236
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001475 RID: 5237
		public Class516 class516_0;

		// Token: 0x04001476 RID: 5238
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004AC RID: 1196
	private sealed class Class564
	{
		// Token: 0x06001EEE RID: 7918 RVA: 0x000146CE File Offset: 0x000128CE
		internal void method_0()
		{
			this.class570_0.gclass188_0.IsDisabled = new bool?(Convert.ToBoolean(this.class265_0.State));
		}

		// Token: 0x04001477 RID: 5239
		public Class265 class265_0;

		// Token: 0x04001478 RID: 5240
		public Class516.Class570 class570_0;
	}

	// Token: 0x020004AD RID: 1197
	private sealed class Class565
	{
		// Token: 0x06001EF0 RID: 7920 RVA: 0x000146F5 File Offset: 0x000128F5
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name == this.gclass186_0.Name;
		}

		// Token: 0x04001479 RID: 5241
		public GClass186 gclass186_0;
	}

	// Token: 0x020004AE RID: 1198
	private sealed class Class566
	{
		// Token: 0x06001EF2 RID: 7922 RVA: 0x0001470D File Offset: 0x0001290D
		internal void method_0()
		{
			this.class568_0.gclass184_0.WinServiceViewModel.NewStartMode = this.serviceStartMode_0;
		}

		// Token: 0x0400147A RID: 5242
		public ServiceStartMode serviceStartMode_0;

		// Token: 0x0400147B RID: 5243
		public Class516.Class568 class568_0;
	}

	// Token: 0x020004AF RID: 1199
	private sealed class Class567
	{
		// Token: 0x06001EF4 RID: 7924 RVA: 0x0007E758 File Offset: 0x0007C958
		internal void method_0()
		{
			Class808.smethod_27("powercfg -import \"" + this.string_0 + "\" " + this.class293_0.Guid);
			Class808.smethod_27("powercfg -setactive " + this.class293_0.Guid);
			File.Delete(this.string_0);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0001472A File Offset: 0x0001292A
		internal void method_1()
		{
			this.class516_0.Pages.Add(new Class502(null, Class298.smethod_4("PowerSvg"), Class298.smethod_2("import"), this.class293_0.Name, false));
		}

		// Token: 0x0400147C RID: 5244
		public Class516 class516_0;

		// Token: 0x0400147D RID: 5245
		public string string_0;

		// Token: 0x0400147E RID: 5246
		public Class293 class293_0;
	}

	// Token: 0x020004B0 RID: 1200
	private sealed class Class568
	{
		// Token: 0x06001EF7 RID: 7927 RVA: 0x00014764 File Offset: 0x00012964
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name == this.string_0;
		}

		// Token: 0x0400147F RID: 5247
		public GClass184 gclass184_0;

		// Token: 0x04001480 RID: 5248
		public string string_0;
	}

	// Token: 0x020004B1 RID: 1201
	[StructLayout(LayoutKind.Auto)]
	private struct Struct310 : IAsyncStateMachine
	{
		// Token: 0x06001EF8 RID: 7928 RVA: 0x0007E7B4 File Offset: 0x0007C9B4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<ObservableCollection<Class512>> awaiter;
				if (num != 0)
				{
					this.class576_0 = new Class516.Class576();
					this.class576_0.class516_0 = this.class516_0;
					this.class576_0.type_0 = this.type_0;
					awaiter = Class148.smethod_2(this.class576_0.type_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class516.Struct310>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				IEnumerator<Class512> enumerator = awaiter.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class516.Class573 @class = new Class516.Class573();
						@class.class576_0 = this.class576_0;
						@class.class512_0 = enumerator.Current;
						Class516.Class578 class2 = new Class516.Class578();
						class2.class573_0 = @class;
						class2.class265_0 = this.list_0.FirstOrDefault(new Func<Class265, bool>(class2.class573_0.method_0));
						if (class2.class265_0 != null)
						{
							Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Application.Current.Dispatcher.Invoke(new Action(this.class576_0.method_0));
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class576_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class576_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00014777 File Offset: 0x00012977
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001481 RID: 5249
		public int int_0;

		// Token: 0x04001482 RID: 5250
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001483 RID: 5251
		public Class516 class516_0;

		// Token: 0x04001484 RID: 5252
		public Type type_0;

		// Token: 0x04001485 RID: 5253
		private Class516.Class576 class576_0;

		// Token: 0x04001486 RID: 5254
		public List<Class265> list_0;

		// Token: 0x04001487 RID: 5255
		private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
	}

	// Token: 0x020004B2 RID: 1202
	private sealed class Class569
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x00014785 File Offset: 0x00012985
		internal void method_0()
		{
			this.gclass182_0.method_7(this.string_0);
			this.class516_0.Pages.Add(new Class502(typeof(dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd), null, string.Empty, string.Empty, false));
		}

		// Token: 0x04001488 RID: 5256
		public Class516 class516_0;

		// Token: 0x04001489 RID: 5257
		public GClass182 gclass182_0;

		// Token: 0x0400148A RID: 5258
		public string string_0;
	}

	// Token: 0x020004B3 RID: 1203
	[StructLayout(LayoutKind.Auto)]
	private struct Struct311 : IAsyncStateMachine
	{
		// Token: 0x06001EFC RID: 7932 RVA: 0x0007E984 File Offset: 0x0007CB84
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				try
				{
					TaskAwaiter<Class534> awaiter;
					if (num != 0)
					{
						this.list_0 = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Features);
						if (this.list_0 == null || this.list_0.Count == 0)
						{
							goto IL_17B;
						}
						awaiter = Class242.smethod_0(false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class534>, Class516.Struct311>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class534>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					IEnumerator<Class512> enumerator = awaiter.GetResult().Tweaks.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class516.Class559 class2 = new Class516.Class559();
							class2.class516_0 = @class;
							class2.class512_0 = enumerator.Current;
							Class516.Class558 class3 = new Class516.Class558();
							class3.class559_0 = class2;
							class3.class265_0 = this.list_0.FirstOrDefault(new Func<Class265, bool>(class3.class559_0.method_0));
							if (class3.class265_0 != null)
							{
								Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					Application.Current.Dispatcher.Invoke(new Action(@class.method_25));
					this.list_0 = null;
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_17B:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000147C3 File Offset: 0x000129C3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400148B RID: 5259
		public int int_0;

		// Token: 0x0400148C RID: 5260
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400148D RID: 5261
		public Class516 class516_0;

		// Token: 0x0400148E RID: 5262
		private List<Class265> list_0;

		// Token: 0x0400148F RID: 5263
		private TaskAwaiter<Class534> taskAwaiter_0;
	}

	// Token: 0x020004B4 RID: 1204
	private sealed class Class570
	{
		// Token: 0x06001EFF RID: 7935 RVA: 0x000147D1 File Offset: 0x000129D1
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name == this.gclass188_0.Name;
		}

		// Token: 0x04001490 RID: 5264
		public GClass188 gclass188_0;
	}

	// Token: 0x020004B5 RID: 1205
	private sealed class Class571
	{
		// Token: 0x06001F01 RID: 7937 RVA: 0x000147E9 File Offset: 0x000129E9
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name == this.class505_0.Name;
		}

		// Token: 0x04001491 RID: 5265
		public Class505 class505_0;
	}

	// Token: 0x020004B6 RID: 1206
	private sealed class Class572
	{
		// Token: 0x06001F03 RID: 7939 RVA: 0x00014801 File Offset: 0x00012A01
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name == this.gclass186_0.Name;
		}

		// Token: 0x04001492 RID: 5266
		public GClass186 gclass186_0;
	}

	// Token: 0x020004B7 RID: 1207
	[StructLayout(LayoutKind.Auto)]
	private struct Struct312 : IAsyncStateMachine
	{
		// Token: 0x06001F04 RID: 7940 RVA: 0x0007EB6C File Offset: 0x0007CD6C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.list_0 = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Affinity);
						if (this.list_0 == null || !Class746.smethod_3<Class265>(this.list_0))
						{
							goto IL_1D9;
						}
						Class265 class2 = @class.class532_0.class261_0.method_0(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Affinity, "ThreadsCount");
						string a = (class2 != null) ? class2.State : null;
						string text = Class551.class753_0.method_94();
						if (a != ((text != null) ? text.ToString() : null))
						{
							goto IL_1D9;
						}
						this.class515_0 = Class362.smethod_0(false);
						awaiter = Class362.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct312>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					IEnumerator<Class505> enumerator = this.class515_0.DeviceViewModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class516.Class571 class3 = new Class516.Class571();
							class3.class505_0 = enumerator.Current;
							Class516.Class562 class4 = new Class516.Class562();
							class4.class571_0 = class3;
							class4.class265_0 = this.list_0.FirstOrDefault(new Func<Class265, bool>(class4.class571_0.method_0));
							if (class4.class265_0 != null)
							{
								Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					Application.Current.Dispatcher.Invoke(new Action(@class.method_23));
					this.list_0 = null;
					this.class515_0 = null;
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1D9:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00014819 File Offset: 0x00012A19
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001493 RID: 5267
		public int int_0;

		// Token: 0x04001494 RID: 5268
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001495 RID: 5269
		public Class516 class516_0;

		// Token: 0x04001496 RID: 5270
		private List<Class265> list_0;

		// Token: 0x04001497 RID: 5271
		private Class515 class515_0;

		// Token: 0x04001498 RID: 5272
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004B8 RID: 1208
	private sealed class Class573
	{
		// Token: 0x06001F07 RID: 7943 RVA: 0x00014827 File Offset: 0x00012A27
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name == this.class512_0.method_21();
		}

		// Token: 0x04001499 RID: 5273
		public Class512 class512_0;

		// Token: 0x0400149A RID: 5274
		public Class516.Class576 class576_0;
	}

	// Token: 0x020004B9 RID: 1209
	[StructLayout(LayoutKind.Auto)]
	private struct Struct313 : IAsyncStateMachine
	{
		// Token: 0x06001F08 RID: 7944 RVA: 0x0007EDB4 File Offset: 0x0007CFB4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						this.gclass183_0 = GClass134.smethod_0(false);
						awaiter = GClass134.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct313>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					List<Class265> source = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.DevicesMSI) ?? new List<Class265>();
					List<Class265> source2 = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.DevicesDisabled) ?? new List<Class265>();
					List<Class265> source3 = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.DevicesGroupDisabled) ?? new List<Class265>();
					IEnumerator<GClass186> enumerator = this.gclass183_0.MsiSupportedDevices.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class516.Class565 class2 = new Class516.Class565();
							class2.gclass186_0 = enumerator.Current;
							Class516.Class560 class3 = new Class516.Class560();
							class3.class565_0 = class2;
							class3.class265_0 = source.FirstOrDefault(new Func<Class265, bool>(class3.class565_0.method_0));
							if (class3.class265_0 != null)
							{
								Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					enumerator = this.gclass183_0.CanBeDisabled.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class516.Class572 class4 = new Class516.Class572();
							class4.gclass186_0 = enumerator.Current;
							Class516.Class561 class5 = new Class516.Class561();
							class5.class572_0 = class4;
							class5.class265_0 = source2.FirstOrDefault(new Func<Class265, bool>(class5.class572_0.method_0));
							if (class5.class265_0 != null)
							{
								Application.Current.Dispatcher.Invoke(new Action(class5.method_0));
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					IEnumerator<GClass188> enumerator2 = this.gclass183_0.CustomDisableDevices.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							Class516.Class570 class6 = new Class516.Class570();
							class6.gclass188_0 = enumerator2.Current;
							Class516.Class564 class7 = new Class516.Class564();
							class7.class570_0 = class6;
							class7.class265_0 = source3.FirstOrDefault(new Func<Class265, bool>(class7.class570_0.method_0));
							if (class7.class265_0 != null)
							{
								Application.Current.Dispatcher.Invoke(new Action(class7.method_0));
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					Application.Current.Dispatcher.Invoke(new Action(@class.method_22));
					this.gclass183_0 = null;
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
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

		// Token: 0x06001F09 RID: 7945 RVA: 0x0001483F File Offset: 0x00012A3F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400149B RID: 5275
		public int int_0;

		// Token: 0x0400149C RID: 5276
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400149D RID: 5277
		public Class516 class516_0;

		// Token: 0x0400149E RID: 5278
		private GClass134.GClass183 gclass183_0;

		// Token: 0x0400149F RID: 5279
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004BA RID: 1210
	[StructLayout(LayoutKind.Auto)]
	private struct Struct314 : IAsyncStateMachine
	{
		// Token: 0x06001F0A RID: 7946 RVA: 0x0007F124 File Offset: 0x0007D324
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.ButtonsVisibility = Visibility.Collapsed;
					@class.method_14(Class298.smethod_2("ReadingProfile"), Brushes.White);
					awaiter = Task.Run(new Func<Task>(@class.method_19)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct314>(ref awaiter, ref this);
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
				@class.method_14(Class298.smethod_2("BUChoose"), Brushes.White);
				@class.ButtonsVisibility = Visibility.Visible;
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

		// Token: 0x06001F0B RID: 7947 RVA: 0x0001484D File Offset: 0x00012A4D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014A0 RID: 5280
		public int int_0;

		// Token: 0x040014A1 RID: 5281
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014A2 RID: 5282
		public Class516 class516_0;

		// Token: 0x040014A3 RID: 5283
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004BB RID: 1211
	private sealed class Class574
	{
		// Token: 0x06001F0D RID: 7949 RVA: 0x0001485B File Offset: 0x00012A5B
		internal bool method_0(GClass179 gclass179_0)
		{
			return gclass179_0.Name == this.string_0;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x0001485B File Offset: 0x00012A5B
		internal bool method_1(GClass179 gclass179_0)
		{
			return gclass179_0.Name == this.string_0;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0001486E File Offset: 0x00012A6E
		internal bool method_2(GClass171 gclass171_0)
		{
			return gclass171_0.NameClean == this.string_1;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0001486E File Offset: 0x00012A6E
		internal bool method_3(GClass171 gclass171_0)
		{
			return gclass171_0.NameClean == this.string_1;
		}

		// Token: 0x040014A4 RID: 5284
		public string string_0;

		// Token: 0x040014A5 RID: 5285
		public string string_1;
	}

	// Token: 0x020004BC RID: 1212
	private sealed class Class575
	{
		// Token: 0x06001F12 RID: 7954 RVA: 0x00014881 File Offset: 0x00012A81
		internal bool method_0(Class265 class265_0)
		{
			return class265_0.Name.smethod_7() == this.class490_0.NameClean;
		}

		// Token: 0x040014A6 RID: 5286
		public Class490 class490_0;
	}

	// Token: 0x020004BD RID: 1213
	[StructLayout(LayoutKind.Auto)]
	private struct Struct315 : IAsyncStateMachine
	{
		// Token: 0x06001F13 RID: 7955 RVA: 0x0007F21C File Offset: 0x0007D41C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class516 @class = this.class516_0;
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
					goto IL_203;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_26E;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_2C9;
				default:
					awaiter = Class144.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct315>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				if (!@class.class532_0.class261_0.method_2(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Json))
				{
					goto IL_313;
				}
				this.list_0 = @class.class532_0.class261_0.method_1(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Json);
				awaiter = Task.WhenAll(new List<Task>
				{
					@class.method_11(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd), this.list_0),
					@class.method_11(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd), this.list_0),
					@class.method_11(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd), this.list_0),
					@class.method_11(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd), this.list_0),
					@class.method_11(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd), this.list_0),
					@class.method_11(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd), this.list_0),
					@class.method_11(typeof(dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd), this.list_0),
					@class.method_9(),
					@class.method_8(),
					@class.method_7(),
					@class.method_6(),
					@class.method_4()
				}).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct315>(ref awaiter, ref this);
					return;
				}
				IL_203:
				awaiter.GetResult();
				awaiter = @class.method_11(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd), this.list_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct315>(ref awaiter, ref this);
					return;
				}
				IL_26E:
				awaiter.GetResult();
				awaiter = @class.method_10().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class516.Struct315>(ref awaiter, ref this);
					return;
				}
				IL_2C9:
				awaiter.GetResult();
				try
				{
					Class265 class2 = @class.class532_0.class261_0.method_0(dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Power, "CurrentProfile");
					string text = (class2 != null) ? class2.State : null;
					if (!string.IsNullOrEmpty(text))
					{
						@class.method_13(text);
					}
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
				this.list_0 = null;
				IL_313:
				@class.method_5();
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

		// Token: 0x06001F14 RID: 7956 RVA: 0x0001489E File Offset: 0x00012A9E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014A7 RID: 5287
		public int int_0;

		// Token: 0x040014A8 RID: 5288
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040014A9 RID: 5289
		public Class516 class516_0;

		// Token: 0x040014AA RID: 5290
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040014AB RID: 5291
		private List<Class265> list_0;
	}

	// Token: 0x020004BE RID: 1214
	[StructLayout(LayoutKind.Auto)]
	private struct Struct316
	{
		// Token: 0x040014AC RID: 5292
		public List<Class265> list_0;
	}

	// Token: 0x020004BF RID: 1215
	private sealed class Class576
	{
		// Token: 0x06001F16 RID: 7958 RVA: 0x000148AC File Offset: 0x00012AAC
		internal void method_0()
		{
			this.class516_0.Pages.Add(new Class502(this.type_0, null, string.Empty, string.Empty, false));
		}

		// Token: 0x040014AD RID: 5293
		public Class516 class516_0;

		// Token: 0x040014AE RID: 5294
		public Type type_0;
	}

	// Token: 0x020004C0 RID: 1216
	[Serializable]
	private sealed class Class577
	{
		// Token: 0x06001F19 RID: 7961 RVA: 0x000148E1 File Offset: 0x00012AE1
		internal bool method_0(Page page_0)
		{
			return page_0.GetType() == typeof(dje_zNSNRFVQUMVAUHL755A6AUDYMMNJH23EVJCGPYZ2RUJFWZZTMJCPX4_ejd);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x000148F8 File Offset: 0x00012AF8
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == typeof(dje_zHJ2BYBCDVPA3PKSXWQJ4SPET45JG6PDLVEGHS842LAUAMUQ2APCL2AYVUVMA_ejd);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0001490F File Offset: 0x00012B0F
		internal Class265 method_2(Class265 class265_0)
		{
			return new Class265
			{
				Name = Class734.smethod_2(class265_0.Name).ToLower(),
				State = class265_0.State,
				Type = class265_0.Type
			};
		}

		// Token: 0x040014AF RID: 5295
		public static readonly Class516.Class577 class577_0 = new Class516.Class577();

		// Token: 0x040014B0 RID: 5296
		public static Func<Page, bool> func_0;

		// Token: 0x040014B1 RID: 5297
		public static Func<Page, bool> func_1;

		// Token: 0x040014B2 RID: 5298
		public static Func<Class265, Class265> func_2;
	}

	// Token: 0x020004C1 RID: 1217
	private sealed class Class578
	{
		// Token: 0x06001F1D RID: 7965 RVA: 0x00014944 File Offset: 0x00012B44
		internal void method_0()
		{
			this.class573_0.class576_0.class516_0.method_12(this.class573_0.class512_0, this.class265_0.State);
		}

		// Token: 0x040014B3 RID: 5299
		public Class265 class265_0;

		// Token: 0x040014B4 RID: 5300
		public Class516.Class573 class573_0;
	}
}
