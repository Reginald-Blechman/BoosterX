using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x02000137 RID: 311
internal sealed class Class491 : GClass162
{
	// Token: 0x06000915 RID: 2325 RVA: 0x000439F0 File Offset: 0x00041BF0
	public Class491(dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_1)
	{
		this.dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0 = dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_1;
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		this.InstallButtonContent = Class298.smethod_2("install");
		this.PopularCommand.Execute(null);
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x000078FD File Offset: 0x00005AFD
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000918 RID: 2328 RVA: 0x0000790B File Offset: 0x00005B0B
	// (set) Token: 0x06000919 RID: 2329 RVA: 0x00007913 File Offset: 0x00005B13
	public bool AppXListIsEnabled
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("AppXListIsEnabled");
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x0600091A RID: 2330 RVA: 0x00007928 File Offset: 0x00005B28
	// (set) Token: 0x0600091B RID: 2331 RVA: 0x00007930 File Offset: 0x00005B30
	public ObservableCollection<Class518> AppXVMs
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("AppXVMs");
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600091C RID: 2332 RVA: 0x00007945 File Offset: 0x00005B45
	// (set) Token: 0x0600091D RID: 2333 RVA: 0x0000794D File Offset: 0x00005B4D
	public ObservableCollection<Class518> AppXsInstallVMs
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("AppXsInstallVMs");
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600091E RID: 2334 RVA: 0x00007962 File Offset: 0x00005B62
	// (set) Token: 0x0600091F RID: 2335 RVA: 0x0000796A File Offset: 0x00005B6A
	public string SearchText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("SearchText");
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000920 RID: 2336 RVA: 0x00043AB0 File Offset: 0x00041CB0
	public GClass280 SearchCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_8), null));
			}
			return result;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000921 RID: 2337 RVA: 0x00043AE4 File Offset: 0x00041CE4
	public GClass280 GoBackCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(Class491.Class183.class183_0.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000922 RID: 2338 RVA: 0x0000797F File Offset: 0x00005B7F
	// (set) Token: 0x06000923 RID: 2339 RVA: 0x00007987 File Offset: 0x00005B87
	public string InstallButtonContent
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("InstallButtonContent");
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000924 RID: 2340 RVA: 0x0000799C File Offset: 0x00005B9C
	// (set) Token: 0x06000925 RID: 2341 RVA: 0x000079A4 File Offset: 0x00005BA4
	public bool InstallButtonIsChecked
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
			base.method_0("InstallButtonIsChecked");
			this.method_2(value);
		}
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00043B2C File Offset: 0x00041D2C
	private void method_2(bool bool_9)
	{
		Class491.Struct53 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.bool_0 = bool_9;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class491.Struct53>(ref @struct);
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00043B6C File Offset: 0x00041D6C
	public void method_3()
	{
		this.bool_1 = true;
		try
		{
			List<string> list = Directory.GetFiles(Class169.string_11).ToList<string>();
			Action<string> action;
			if ((action = Class491.Class180.action_0) == null)
			{
				action = (Class491.Class180.action_0 = new Action<string>(File.Delete));
			}
			list.ForEach(action);
		}
		catch (Exception exception_)
		{
			GClass268.smethod_1(exception_);
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000928 RID: 2344 RVA: 0x000079C0 File Offset: 0x00005BC0
	// (set) Token: 0x06000929 RID: 2345 RVA: 0x000079C8 File Offset: 0x00005BC8
	public bool PopularButtonIsEnabled
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
			base.method_0("PopularButtonIsEnabled");
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x0600092A RID: 2346 RVA: 0x000079DD File Offset: 0x00005BDD
	// (set) Token: 0x0600092B RID: 2347 RVA: 0x000079E5 File Offset: 0x00005BE5
	public bool DefaultButtonIsEnabled
	{
		get
		{
			return this.bool_6;
		}
		set
		{
			this.bool_6 = value;
			base.method_0("DefaultButtonIsEnabled");
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600092C RID: 2348 RVA: 0x00043BC8 File Offset: 0x00041DC8
	public GClass280 PopularCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(this.method_14), null));
			}
			return result;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x0600092D RID: 2349 RVA: 0x00043BFC File Offset: 0x00041DFC
	public GClass280 DefaultCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_3) == null)
			{
				result = (this.gclass280_3 = new GClass280(new Action<object>(this.method_16), null));
			}
			return result;
		}
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00043C30 File Offset: 0x00041E30
	public Task method_4()
	{
		Class491.Struct60 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class491.Struct60>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00043C74 File Offset: 0x00041E74
	public Task method_5()
	{
		Class491.Struct59 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class491.Struct59>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000930 RID: 2352 RVA: 0x000079FA File Offset: 0x00005BFA
	// (set) Token: 0x06000931 RID: 2353 RVA: 0x00007A02 File Offset: 0x00005C02
	public double ProgressOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("ProgressOpacity");
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000932 RID: 2354 RVA: 0x00007A17 File Offset: 0x00005C17
	// (set) Token: 0x06000933 RID: 2355 RVA: 0x00007A1F File Offset: 0x00005C1F
	public Visibility ProgressVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("ProgressVisibility");
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000934 RID: 2356 RVA: 0x00007A34 File Offset: 0x00005C34
	// (set) Token: 0x06000935 RID: 2357 RVA: 0x00007A3C File Offset: 0x00005C3C
	public double ProgressValue
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("ProgressValue");
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000936 RID: 2358 RVA: 0x00007A51 File Offset: 0x00005C51
	// (set) Token: 0x06000937 RID: 2359 RVA: 0x00007A59 File Offset: 0x00005C59
	public string ProgressText
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("ProgressText");
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000938 RID: 2360 RVA: 0x00007A6E File Offset: 0x00005C6E
	// (set) Token: 0x06000939 RID: 2361 RVA: 0x00007A76 File Offset: 0x00005C76
	public string InstallStatusText
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("InstallStatusText");
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x0600093A RID: 2362 RVA: 0x00007A8B File Offset: 0x00005C8B
	// (set) Token: 0x0600093B RID: 2363 RVA: 0x00007A93 File Offset: 0x00005C93
	public SolidColorBrush InstallStatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("InstallStatusColor");
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x0600093C RID: 2364 RVA: 0x00007AA8 File Offset: 0x00005CA8
	// (set) Token: 0x0600093D RID: 2365 RVA: 0x00007AB0 File Offset: 0x00005CB0
	public double InstallStatusOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("InstallStatusOpacity");
		}
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00043CB8 File Offset: 0x00041EB8
	public void method_6(string string_5, SolidColorBrush solidColorBrush_2)
	{
		Class491.Struct57 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.string_0 = string_5;
		@struct.solidColorBrush_0 = solidColorBrush_2;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class491.Struct57>(ref @struct);
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x0600093F RID: 2367 RVA: 0x00007AC5 File Offset: 0x00005CC5
	// (set) Token: 0x06000940 RID: 2368 RVA: 0x00007ACD File Offset: 0x00005CCD
	public string StatusText
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000941 RID: 2369 RVA: 0x00007AE2 File Offset: 0x00005CE2
	// (set) Token: 0x06000942 RID: 2370 RVA: 0x00007AEA File Offset: 0x00005CEA
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_1;
		}
		set
		{
			this.solidColorBrush_1 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000943 RID: 2371 RVA: 0x00007AFF File Offset: 0x00005CFF
	// (set) Token: 0x06000944 RID: 2372 RVA: 0x00007B07 File Offset: 0x00005D07
	public double StatusOpacity
	{
		get
		{
			return this.double_3;
		}
		set
		{
			this.double_3 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00043D00 File Offset: 0x00041F00
	private void method_7(string string_5, SolidColorBrush solidColorBrush_2)
	{
		Class491.Struct55 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.string_0 = string_5;
		@struct.solidColorBrush_0 = solidColorBrush_2;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class491.Struct55>(ref @struct);
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00043D48 File Offset: 0x00041F48
	private void method_8(object object_0)
	{
		if (!this.bool_3 && !(this.SearchText == Class298.smethod_2("SearchAllStore")) && !(this.SearchText == string.Empty))
		{
			Application.Current.Dispatcher.Invoke(new Action(this.method_9));
			Task.Run(new Func<Task>(this.method_10));
			return;
		}
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00007B1C File Offset: 0x00005D1C
	private void method_9()
	{
		this.dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0.button_0.Style = Class298.smethod_3("SuperRoundedButtonGray");
		this.dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0.button_1.Style = Class298.smethod_3("SuperRoundedButtonGray");
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00043DB8 File Offset: 0x00041FB8
	private Task method_10()
	{
		Class491.Struct58 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class491.Struct58>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00007B54 File Offset: 0x00005D54
	private void method_11(Class518 class518_0)
	{
		this.AppXVMs.Add(class518_0);
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00043DFC File Offset: 0x00041FFC
	private Task method_12()
	{
		Class491.Struct61 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class491.Struct61>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00007B62 File Offset: 0x00005D62
	private void method_13()
	{
		this.AppXVMs.smethod_0(new Action<Class518>(Class491.Class183.class183_0.method_1));
		this.AppXsInstallVMs.Clear();
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00043E40 File Offset: 0x00042040
	private void method_14(object object_0)
	{
		if (this.bool_7)
		{
			return;
		}
		this.bool_7 = true;
		this.method_7(Class298.smethod_2("popular"), Brushes.White);
		this.PopularButtonIsEnabled = false;
		this.DefaultButtonIsEnabled = true;
		Application.Current.Dispatcher.Invoke(new Action(this.method_15));
		this.bool_7 = false;
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00043EA4 File Offset: 0x000420A4
	private void method_15()
	{
		this.dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0.button_0.Style = Class298.smethod_3("SuperRoundedButtonBlue");
		this.dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0.button_1.Style = Class298.smethod_3("SuperRoundedButtonGray");
		this.AppXVMs.Clear();
		using (List<string>.Enumerator enumerator = Class442.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class491.Class179 @class = new Class491.Class179();
				@class.string_0 = enumerator.Current;
				if (Class626.list_0.Any(new Func<Class518, bool>(@class.method_0)))
				{
					Class518 class2 = Class626.list_0.First(new Func<Class518, bool>(@class.method_1));
					this.AppXVMs.Add(class2);
					class2.Check();
				}
				else
				{
					this.AppXVMs.Add(new Class518(this, @class.string_0));
				}
			}
		}
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00043F98 File Offset: 0x00042198
	private void method_16(object object_0)
	{
		if (this.bool_8)
		{
			return;
		}
		this.bool_8 = true;
		this.method_7(Class298.smethod_2("FromMicrosoft"), Brushes.White);
		this.PopularButtonIsEnabled = true;
		this.DefaultButtonIsEnabled = false;
		Application.Current.Dispatcher.Invoke(new Action(this.method_17));
		this.bool_8 = false;
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00043FFC File Offset: 0x000421FC
	private void method_17()
	{
		this.dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0.button_1.Style = Class298.smethod_3("SuperRoundedButtonBlue");
		this.dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0.button_0.Style = Class298.smethod_3("SuperRoundedButtonGray");
		this.AppXVMs.Clear();
		using (List<string>.Enumerator enumerator = Class442.list_1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class491.Class182 @class = new Class491.Class182();
				@class.string_0 = enumerator.Current;
				if (Class626.list_0.Any(new Func<Class518, bool>(@class.method_0)))
				{
					Class518 class2 = Class626.list_0.First(new Func<Class518, bool>(@class.method_1));
					this.AppXVMs.Add(class2);
					class2.Check();
				}
				else
				{
					this.AppXVMs.Add(new Class518(this, @class.string_0));
				}
			}
		}
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x000440F0 File Offset: 0x000422F0
	private Task method_18()
	{
		Class491.Struct56 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class491.Struct56>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00044134 File Offset: 0x00042334
	private Task method_19()
	{
		Class491.Struct54 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class491_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class491.Struct54>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000613 RID: 1555
	private dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd_0;

	// Token: 0x04000614 RID: 1556
	private bool bool_0 = true;

	// Token: 0x04000615 RID: 1557
	private ObservableCollection<Class518> observableCollection_0 = new ObservableCollection<Class518>();

	// Token: 0x04000616 RID: 1558
	private ObservableCollection<Class518> observableCollection_1 = new ObservableCollection<Class518>();

	// Token: 0x04000617 RID: 1559
	public bool bool_1;

	// Token: 0x04000618 RID: 1560
	private bool bool_2;

	// Token: 0x04000619 RID: 1561
	private string string_0 = Class298.smethod_2("SearchAllStore");

	// Token: 0x0400061A RID: 1562
	private bool bool_3;

	// Token: 0x0400061B RID: 1563
	private GClass280 gclass280_0;

	// Token: 0x0400061C RID: 1564
	private GClass280 gclass280_1;

	// Token: 0x0400061D RID: 1565
	private string string_1;

	// Token: 0x0400061E RID: 1566
	private bool bool_4;

	// Token: 0x0400061F RID: 1567
	private static CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	// Token: 0x04000620 RID: 1568
	private static CancellationToken cancellationToken_0 = Class491.cancellationTokenSource_0.Token;

	// Token: 0x04000621 RID: 1569
	private bool bool_5 = true;

	// Token: 0x04000622 RID: 1570
	private bool bool_6 = true;

	// Token: 0x04000623 RID: 1571
	private bool bool_7;

	// Token: 0x04000624 RID: 1572
	private GClass280 gclass280_2;

	// Token: 0x04000625 RID: 1573
	private bool bool_8;

	// Token: 0x04000626 RID: 1574
	private GClass280 gclass280_3;

	// Token: 0x04000627 RID: 1575
	private double double_0;

	// Token: 0x04000628 RID: 1576
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x04000629 RID: 1577
	private double double_1;

	// Token: 0x0400062A RID: 1578
	private string string_2;

	// Token: 0x0400062B RID: 1579
	private string string_3 = string.Empty;

	// Token: 0x0400062C RID: 1580
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x0400062D RID: 1581
	private double double_2;

	// Token: 0x0400062E RID: 1582
	private string string_4 = string.Empty;

	// Token: 0x0400062F RID: 1583
	private SolidColorBrush solidColorBrush_1 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04000630 RID: 1584
	private double double_3;

	// Token: 0x02000138 RID: 312
	private sealed class Class178
	{
		// Token: 0x06000953 RID: 2387 RVA: 0x00044178 File Offset: 0x00042378
		internal Task method_0()
		{
			Class491.Class178.Struct52 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class178_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class491.Class178.Struct52>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000631 RID: 1585
		public Class491 class491_0;

		// Token: 0x04000632 RID: 1586
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000633 RID: 1587
		public string string_0;

		// Token: 0x02000139 RID: 313
		[StructLayout(LayoutKind.Auto)]
		private struct Struct52 : IAsyncStateMachine
		{
			// Token: 0x06000954 RID: 2388 RVA: 0x000441BC File Offset: 0x000423BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class491.Class178 @class = this.class178_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_D1;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_161;
					}
					IL_56:
					if (@class.class491_0.InstallStatusOpacity == 0.0)
					{
						@class.class491_0.InstallStatusColor = @class.solidColorBrush_0;
						@class.class491_0.InstallStatusText = @class.string_0;
						goto IL_168;
					}
					@class.class491_0.InstallStatusOpacity = @class.class491_0.InstallStatusOpacity - 0.1;
					if (@class.class491_0.InstallStatusOpacity < 0.05)
					{
						@class.class491_0.InstallStatusOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Class178.Struct52>(ref awaiter, ref this);
						return;
					}
					IL_D1:
					awaiter.GetResult();
					goto IL_56;
					IL_161:
					awaiter.GetResult();
					IL_168:
					if (@class.class491_0.InstallStatusOpacity != 1.0)
					{
						@class.class491_0.InstallStatusOpacity = @class.class491_0.InstallStatusOpacity + 0.13333333333333333;
						if (@class.class491_0.InstallStatusOpacity > 0.95)
						{
							@class.class491_0.InstallStatusOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_161;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Class178.Struct52>(ref awaiter, ref this);
						return;
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

			// Token: 0x06000955 RID: 2389 RVA: 0x00007B99 File Offset: 0x00005D99
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000634 RID: 1588
			public int int_0;

			// Token: 0x04000635 RID: 1589
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000636 RID: 1590
			public Class491.Class178 class178_0;

			// Token: 0x04000637 RID: 1591
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x0200013A RID: 314
	private sealed class Class179
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x00007BA7 File Offset: 0x00005DA7
		internal bool method_0(Class518 class518_0)
		{
			return class518_0.AppXProductID == this.string_0;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00007BA7 File Offset: 0x00005DA7
		internal bool method_1(Class518 class518_0)
		{
			return class518_0.AppXProductID == this.string_0;
		}

		// Token: 0x04000638 RID: 1592
		public string string_0;
	}

	// Token: 0x0200013B RID: 315
	private static class Class180
	{
		// Token: 0x04000639 RID: 1593
		public static Action<string> action_0;
	}

	// Token: 0x0200013C RID: 316
	[StructLayout(LayoutKind.Auto)]
	private struct Struct53 : IAsyncStateMachine
	{
		// Token: 0x06000959 RID: 2393 RVA: 0x000443D0 File Offset: 0x000425D0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @class = this.class491_0;
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
					goto IL_18D;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_20D;
				default:
					if (!this.bool_0)
					{
						if (!@class.bool_2)
						{
							goto IL_137;
						}
						@class.bool_2 = false;
						Class491.cancellationTokenSource_0.Cancel();
						@class.method_6(Class298.smethod_2("cancelappxinstall"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
						awaiter = Task.Delay(1500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct53>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						@class.InstallButtonContent = Class298.smethod_2("cancel");
						@class.method_6(Class298.smethod_2("storexins1"), Brushes.White);
						@class.bool_2 = true;
						@class.AppXListIsEnabled = false;
						awaiter = Task.Run(new Func<Task>(@class.method_12)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct53>(ref awaiter, ref this);
							return;
						}
						goto IL_18D;
					}
					break;
				}
				awaiter.GetResult();
				IL_137:
				@class.AppXListIsEnabled = true;
				@class.InstallButtonContent = Class298.smethod_2("install");
				@class.method_6(string.Empty, Brushes.White);
				@class.AppXListIsEnabled = true;
				@class.method_3();
				goto IL_23D;
				IL_18D:
				awaiter.GetResult();
				@class.method_6(Class298.smethod_2("finished"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				@class.bool_2 = false;
				@class.InstallButtonIsChecked = false;
				awaiter = Task.Delay(2000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct53>(ref awaiter, ref this);
					return;
				}
				IL_20D:
				awaiter.GetResult();
				@class.method_6(string.Empty, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_23D:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00007BBA File Offset: 0x00005DBA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400063A RID: 1594
		public int int_0;

		// Token: 0x0400063B RID: 1595
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400063C RID: 1596
		public bool bool_0;

		// Token: 0x0400063D RID: 1597
		public Class491 class491_0;

		// Token: 0x0400063E RID: 1598
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200013D RID: 317
	[StructLayout(LayoutKind.Auto)]
	private struct Struct54 : IAsyncStateMachine
	{
		// Token: 0x0600095B RID: 2395 RVA: 0x0004464C File Offset: 0x0004284C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @class = this.class491_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_8E;
				}
				IL_2F:
				if (@class.ProgressOpacity == 0.0)
				{
					@class.ProgressVisibility = Visibility.Collapsed;
					goto IL_D7;
				}
				@class.ProgressOpacity -= 0.1;
				if (@class.ProgressOpacity < 0.05)
				{
					@class.ProgressOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct54>(ref awaiter, ref this);
					return;
				}
				IL_8E:
				awaiter.GetResult();
				goto IL_2F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D7:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00007BC8 File Offset: 0x00005DC8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400063F RID: 1599
		public int int_0;

		// Token: 0x04000640 RID: 1600
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000641 RID: 1601
		public Class491 class491_0;

		// Token: 0x04000642 RID: 1602
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200013E RID: 318
	[StructLayout(LayoutKind.Auto)]
	private struct Struct55 : IAsyncStateMachine
	{
		// Token: 0x0600095D RID: 2397 RVA: 0x00044754 File Offset: 0x00042954
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @class = this.class491_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B8;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_127;
				}
				IL_56:
				if (@class.StatusOpacity == 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_12E;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct55>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_127:
				awaiter.GetResult();
				IL_12E:
				if (@class.StatusOpacity != 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_127;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct55>(ref awaiter, ref this);
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

		// Token: 0x0600095E RID: 2398 RVA: 0x00007BD6 File Offset: 0x00005DD6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000643 RID: 1603
		public int int_0;

		// Token: 0x04000644 RID: 1604
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000645 RID: 1605
		public Class491 class491_0;

		// Token: 0x04000646 RID: 1606
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000647 RID: 1607
		public string string_0;

		// Token: 0x04000648 RID: 1608
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200013F RID: 319
	private sealed class Class181
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x00007BE4 File Offset: 0x00005DE4
		internal void method_0()
		{
			this.class491_0.AppXVMs.Clear();
			this.list_0.ForEach(new Action<Class518>(this.class491_0.method_11));
		}

		// Token: 0x04000649 RID: 1609
		public List<Class518> list_0;

		// Token: 0x0400064A RID: 1610
		public Class491 class491_0;
	}

	// Token: 0x02000140 RID: 320
	[StructLayout(LayoutKind.Auto)]
	private struct Struct56 : IAsyncStateMachine
	{
		// Token: 0x06000961 RID: 2401 RVA: 0x00044928 File Offset: 0x00042B28
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @class = this.class491_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_97;
				}
				@class.ProgressVisibility = Visibility.Visible;
				IL_38:
				if (@class.ProgressOpacity == 1.0)
				{
					goto IL_D9;
				}
				@class.ProgressOpacity += 0.13333333333333333;
				if (@class.ProgressOpacity > 0.95)
				{
					@class.ProgressOpacity = 1.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct56>(ref awaiter, ref this);
					return;
				}
				IL_97:
				awaiter.GetResult();
				goto IL_38;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D9:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00007C12 File Offset: 0x00005E12
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400064B RID: 1611
		public int int_0;

		// Token: 0x0400064C RID: 1612
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400064D RID: 1613
		public Class491 class491_0;

		// Token: 0x0400064E RID: 1614
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000141 RID: 321
	[StructLayout(LayoutKind.Auto)]
	private struct Struct57 : IAsyncStateMachine
	{
		// Token: 0x06000963 RID: 2403 RVA: 0x00044A34 File Offset: 0x00042C34
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					Class491.Class178 @class = new Class491.Class178();
					@class.class491_0 = this.class491_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					@class.string_0 = this.string_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class491.Struct57>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

		// Token: 0x06000964 RID: 2404 RVA: 0x00007C20 File Offset: 0x00005E20
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400064F RID: 1615
		public int int_0;

		// Token: 0x04000650 RID: 1616
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000651 RID: 1617
		public Class491 class491_0;

		// Token: 0x04000652 RID: 1618
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000653 RID: 1619
		public string string_0;

		// Token: 0x04000654 RID: 1620
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x02000142 RID: 322
	[StructLayout(LayoutKind.Auto)]
	private struct Struct58 : IAsyncStateMachine
	{
		// Token: 0x06000965 RID: 2405 RVA: 0x00044B20 File Offset: 0x00042D20
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @class = this.class491_0;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<List<Class518>> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_152;
					}
					this.class181_0 = new Class491.Class181();
					this.class181_0.class491_0 = @class;
					@class.bool_3 = true;
					@class.PopularButtonIsEnabled = false;
					@class.DefaultButtonIsEnabled = false;
					@class.method_7(Class298.smethod_2("Searching"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
					awaiter2 = Class626.smethod_1(@class.SearchText, @class).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class518>>, Class491.Struct58>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class518>>);
					this.int_0 = -1;
				}
				List<Class518> result = awaiter2.GetResult();
				this.class181_0.list_0 = result;
				if (this.class181_0.list_0.Count != 0)
				{
					Application.Current.Dispatcher.Invoke(new Action(this.class181_0.method_0));
					@class.method_7(Class298.smethod_2("FoundFromQuery"), Brushes.White);
					@class.PopularButtonIsEnabled = true;
					@class.DefaultButtonIsEnabled = true;
					@class.bool_3 = false;
					goto IL_1DB;
				}
				@class.method_7(Class298.smethod_2("notfoundapp"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				awaiter = Task.Delay(1500).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct58>(ref awaiter, ref this);
					return;
				}
				IL_152:
				awaiter.GetResult();
				@class.PopularCommand.Execute(null);
				@class.bool_3 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class181_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1DB:
			this.int_0 = -2;
			this.class181_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00007C2E File Offset: 0x00005E2E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000655 RID: 1621
		public int int_0;

		// Token: 0x04000656 RID: 1622
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000657 RID: 1623
		public Class491 class491_0;

		// Token: 0x04000658 RID: 1624
		private Class491.Class181 class181_0;

		// Token: 0x04000659 RID: 1625
		private TaskAwaiter<List<Class518>> taskAwaiter_0;

		// Token: 0x0400065A RID: 1626
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000143 RID: 323
	[StructLayout(LayoutKind.Auto)]
	private struct Struct59 : IAsyncStateMachine
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x00044D40 File Offset: 0x00042F40
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @object = this.class491_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@object.method_19)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class491.Struct59>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

		// Token: 0x06000968 RID: 2408 RVA: 0x00007C3C File Offset: 0x00005E3C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400065B RID: 1627
		public int int_0;

		// Token: 0x0400065C RID: 1628
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400065D RID: 1629
		public Class491 class491_0;

		// Token: 0x0400065E RID: 1630
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x02000144 RID: 324
	[StructLayout(LayoutKind.Auto)]
	private struct Struct60 : IAsyncStateMachine
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x00044E08 File Offset: 0x00043008
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @object = this.class491_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@object.method_18)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class491.Struct60>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Task>);
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

		// Token: 0x0600096A RID: 2410 RVA: 0x00007C4A File Offset: 0x00005E4A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400065F RID: 1631
		public int int_0;

		// Token: 0x04000660 RID: 1632
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000661 RID: 1633
		public Class491 class491_0;

		// Token: 0x04000662 RID: 1634
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x02000145 RID: 325
	[StructLayout(LayoutKind.Auto)]
	private struct Struct61 : IAsyncStateMachine
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x00044ED0 File Offset: 0x000430D0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class491 @class = this.class491_0;
			try
			{
				if (num > 1)
				{
					Class546.smethod_0().method_2();
					Class546.smethod_0().method_13();
					this.ienumerator_0 = @class.AppXsInstallVMs.GetEnumerator();
				}
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_16B;
						}
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_110;
					}
					IL_65:
					try
					{
						if (num != 0)
						{
							awaiter = Class626.smethod_5(this.class518_0, @class, Class491.cancellationToken_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.int_0 = num3;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct61>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
						}
						awaiter.GetResult();
						goto IL_195;
					}
					catch (Exception ex)
					{
						this.object_0 = ex;
						this.int_1 = 1;
						goto IL_195;
					}
					IL_E8:
					GClass268.smethod_1((Exception)this.object_0);
					awaiter = @class.method_5().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_110;
					}
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class491.Struct61>(ref awaiter, ref this);
					return;
					IL_195:
					int num6 = this.int_1;
					if (num6 == 1)
					{
						goto IL_E8;
					}
					goto IL_15D;
					IL_110:
					awaiter.GetResult();
					this.class518_0.method_5(Class298.smethod_2("storexerror2"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
					@class.InstallButtonContent = Class298.smethod_2("install");
					@class.bool_2 = false;
					this.class518_0.bool_0 = false;
					@class.AppXListIsEnabled = true;
					IL_15D:
					this.object_0 = null;
					this.class518_0 = null;
					IL_16B:
					if (this.ienumerator_0.MoveNext())
					{
						this.class518_0 = this.ienumerator_0.Current;
						this.int_1 = 0;
						goto IL_65;
					}
				}
				finally
				{
					if (num < 0 && this.ienumerator_0 != null)
					{
						this.ienumerator_0.Dispose();
					}
				}
				this.ienumerator_0 = null;
				@class.method_6(Class298.smethod_2("storexins6"), Brushes.White);
				Application.Current.Dispatcher.Invoke(new Action(@class.method_13));
				Class546.smethod_0().method_14();
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

		// Token: 0x0600096C RID: 2412 RVA: 0x00007C58 File Offset: 0x00005E58
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000663 RID: 1635
		public int int_0;

		// Token: 0x04000664 RID: 1636
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000665 RID: 1637
		public Class491 class491_0;

		// Token: 0x04000666 RID: 1638
		private IEnumerator<Class518> ienumerator_0;

		// Token: 0x04000667 RID: 1639
		private Class518 class518_0;

		// Token: 0x04000668 RID: 1640
		private object object_0;

		// Token: 0x04000669 RID: 1641
		private int int_1;

		// Token: 0x0400066A RID: 1642
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000146 RID: 326
	private sealed class Class182
	{
		// Token: 0x0600096E RID: 2414 RVA: 0x00007C66 File Offset: 0x00005E66
		internal bool method_0(Class518 class518_0)
		{
			return class518_0.AppXProductID == this.string_0;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00007C66 File Offset: 0x00005E66
		internal bool method_1(Class518 class518_0)
		{
			return class518_0.AppXProductID == this.string_0;
		}

		// Token: 0x0400066B RID: 1643
		public string string_0;
	}

	// Token: 0x02000147 RID: 327
	[Serializable]
	private sealed class Class183
	{
		// Token: 0x06000972 RID: 2418 RVA: 0x00007C85 File Offset: 0x00005E85
		internal void method_0(object object_0)
		{
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00007CA5 File Offset: 0x00005EA5
		internal void method_1(Class518 class518_0)
		{
			class518_0.AppXIsChecked = false;
		}

		// Token: 0x0400066C RID: 1644
		public static readonly Class491.Class183 class183_0 = new Class491.Class183();

		// Token: 0x0400066D RID: 1645
		public static Action<object> action_0;

		// Token: 0x0400066E RID: 1646
		public static Action<Class518> action_1;
	}
}
