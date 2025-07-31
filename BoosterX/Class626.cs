using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using ns0;

// Token: 0x02000527 RID: 1319
internal sealed class Class626
{
	// Token: 0x060021B0 RID: 8624 RVA: 0x0008616C File Offset: 0x0008436C
	// Note: this type is marked as 'beforefieldinit'.
	static Class626()
	{
		GClass246 gclass = new GClass246();
		gclass.method_1(string.Empty);
		gclass.method_3((Thread.CurrentThread.CurrentUICulture.ToString() == "ru-RU") ? GEnum0.RU : GEnum0.US);
		gclass.method_5((Thread.CurrentThread.CurrentUICulture.ToString() == "ru-RU") ? GEnum6.ru : GEnum6.en);
		gclass.method_7((GEnum7)0);
		gclass.method_9((GEnum9)0);
		gclass.method_11(GEnum14.Desktop);
		Class626.gclass246_0 = gclass;
		GClass246 gclass2 = new GClass246();
		gclass2.method_1(string.Empty);
		gclass2.method_3(GEnum0.US);
		gclass2.method_5(GEnum6.en);
		gclass2.method_7((GEnum7)0);
		gclass2.method_9((GEnum9)0);
		gclass2.method_11(GEnum14.Desktop);
		Class626.gclass246_1 = gclass2;
		Class626.list_0 = new List<Class518>();
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x000162D3 File Offset: 0x000144D3
	public static GClass225 smethod_0()
	{
		if (Class626.gclass225_0 == null)
		{
			Class626.gclass225_0 = new GClass225(Class626.gclass246_0.method_6(), new GClass233(Class626.gclass246_0.method_2(), Class626.gclass246_0.method_4(), true));
		}
		return Class626.gclass225_0;
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x00086238 File Offset: 0x00084438
	public static Task<List<Class518>> smethod_1(string string_0, Class491 class491_0)
	{
		Class626.Struct347 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class518>>.Create();
		@struct.string_0 = string_0;
		@struct.class491_0 = class491_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class626.Struct347>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x00086284 File Offset: 0x00084484
	private static Task<List<Class518>> smethod_2(string string_0, GClass225 gclass225_1, Class491 class491_0)
	{
		Class626.Struct349 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class518>>.Create();
		@struct.string_0 = string_0;
		@struct.gclass225_0 = gclass225_1;
		@struct.class491_0 = class491_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class626.Struct349>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x000862D8 File Offset: 0x000844D8
	private static Task<List<Class518>> smethod_3(string string_0, GClass225 gclass225_1, Class491 class491_0)
	{
		Class626.Struct351 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class518>>.Create();
		@struct.string_0 = string_0;
		@struct.gclass225_0 = gclass225_1;
		@struct.class491_0 = class491_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class626.Struct351>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x0008632C File Offset: 0x0008452C
	private static Task<List<Class518>> smethod_4(string string_0, GClass225 gclass225_1, Class491 class491_0)
	{
		Class626.Struct348 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class518>>.Create();
		@struct.string_0 = string_0;
		@struct.gclass225_0 = gclass225_1;
		@struct.class491_0 = class491_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class626.Struct348>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x00086380 File Offset: 0x00084580
	public static Task smethod_5(Class518 class518_0, Class491 class491_0, CancellationToken cancellationToken_0)
	{
		Class626.Struct346 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class518_0 = class518_0;
		@struct.class491_0 = class491_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class626.Struct346>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x0001630F File Offset: 0x0001450F
	private static void smethod_6(GClass255 gclass255_0, Class491 class491_0, CancellationToken cancellationToken_0)
	{
		new Thread(new ThreadStart(new Class626.Class634
		{
			gclass255_0 = gclass255_0,
			class491_0 = class491_0,
			cancellationToken_0 = cancellationToken_0
		}.method_0)).Start();
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x000863D4 File Offset: 0x000845D4
	private static void smethod_7(GClass255 gclass255_0, Class491 class491_0)
	{
		Class626.Class635 @class = new Class626.Class635();
		@class.class491_0 = class491_0;
		Class808.smethod_27("taskkill /f /im textinputhost.exe");
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("Add-AppxPackage -ForceApplicationShutdown \"" + gclass255_0.method_4() + "\"");
			powerShell.Streams.Progress.DataAdded += @class.method_0;
			powerShell.Invoke();
		}
	}

	// Token: 0x04001646 RID: 5702
	public static GClass225 gclass225_0;

	// Token: 0x04001647 RID: 5703
	public static GClass246 gclass246_0;

	// Token: 0x04001648 RID: 5704
	public static GClass246 gclass246_1;

	// Token: 0x04001649 RID: 5705
	public static List<Class518> list_0;

	// Token: 0x02000528 RID: 1320
	private sealed class Class627
	{
		// Token: 0x060021BA RID: 8634 RVA: 0x00016340 File Offset: 0x00014540
		internal void method_0()
		{
			this.list_0 = new List<Class518>();
		}

		// Token: 0x0400164A RID: 5706
		public List<Class518> list_0;

		// Token: 0x0400164B RID: 5707
		public Class491 class491_0;
	}

	// Token: 0x02000529 RID: 1321
	private sealed class Class628
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x0001634D File Offset: 0x0001454D
		internal void method_0()
		{
			if (this.class491_0 != null)
			{
				this.class491_0.ProgressValue = 0.0;
			}
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0008645C File Offset: 0x0008465C
		internal void method_1()
		{
			if (this.class491_0 != null)
			{
				this.class491_0.ProgressValue = 0.0;
				this.class491_0.ProgressText = "0%";
				Class491 @class = this.class491_0;
				string str = Class298.smethod_2("storexins5");
				string format = " ({0}/{1})";
				int num = this.int_0;
				this.int_0 = num + 1;
				@class.InstallStatusText = str + string.Format(format, num, this.dictionary_0.Count);
			}
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0008645C File Offset: 0x0008465C
		internal void method_2()
		{
			if (this.class491_0 != null)
			{
				this.class491_0.ProgressValue = 0.0;
				this.class491_0.ProgressText = "0%";
				Class491 @class = this.class491_0;
				string str = Class298.smethod_2("storexins5");
				string format = " ({0}/{1})";
				int num = this.int_0;
				this.int_0 = num + 1;
				@class.InstallStatusText = str + string.Format(format, num, this.dictionary_0.Count);
			}
		}

		// Token: 0x0400164C RID: 5708
		public Class491 class491_0;

		// Token: 0x0400164D RID: 5709
		public int int_0;

		// Token: 0x0400164E RID: 5710
		public Dictionary<string, GClass255> dictionary_0;

		// Token: 0x0400164F RID: 5711
		public Action action_0;

		// Token: 0x04001650 RID: 5712
		public Action action_1;

		// Token: 0x04001651 RID: 5713
		public Action action_2;
	}

	// Token: 0x0200052A RID: 1322
	[StructLayout(LayoutKind.Auto)]
	private struct Struct346 : IAsyncStateMachine
	{
		// Token: 0x060021BF RID: 8639 RVA: 0x000864E4 File Offset: 0x000846E4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<GClass42> awaiter;
				TaskAwaiter<IList<GClass298>> awaiter2;
				TaskAwaiter awaiter3;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass42>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<IList<GClass298>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_1D1;
				}
				case 2:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					goto IL_549;
				}
				case 3:
				{
					IL_572:
					try
					{
						if (num == 3)
						{
							awaiter3 = this.taskAwaiter_2;
							this.taskAwaiter_2 = default(TaskAwaiter);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
							goto IL_6CA;
						}
						IL_5E0:
						if (!this.enumerator_0.MoveNext())
						{
							goto IL_729;
						}
						KeyValuePair<string, GClass255> keyValuePair = this.enumerator_0.Current;
						this.gclass255_0 = keyValuePair.Value;
						Class491 @class = this.class628_0.class491_0;
						if (@class != null)
						{
							string str = Class298.smethod_2("storexins3");
							string format = " ({0}/{1})";
							int num6 = this.class628_0.int_0;
							this.class628_0.int_0 = num6 + 1;
							@class.method_6(str + string.Format(format, num6, this.class628_0.dictionary_0.Count), Brushes.White);
						}
						Class626.smethod_6(this.gclass255_0, this.class628_0.class491_0, this.cancellationToken_0);
						IL_694:
						if (this.gclass255_0.method_4() != null)
						{
							Dispatcher dispatcher = Application.Current.Dispatcher;
							Action callback;
							if ((callback = this.class628_0.action_0) == null)
							{
								callback = (this.class628_0.action_0 = new Action(this.class628_0.method_0));
							}
							dispatcher.Invoke(callback);
							this.gclass255_0 = null;
							goto IL_5E0;
						}
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							Class491 class2 = this.class628_0.class491_0;
							if (class2 != null)
							{
								class2.method_3();
							}
							goto IL_CF9;
						}
						awaiter3 = Task.Delay(200).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							int num7 = 3;
							num = 3;
							this.int_0 = num7;
							this.taskAwaiter_2 = awaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class626.Struct346>(ref awaiter3, ref this);
							return;
						}
						IL_6CA:
						awaiter3.GetResult();
						goto IL_694;
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.enumerator_0).Dispose();
						}
					}
					IL_729:
					this.enumerator_0 = default(Dictionary<string, GClass255>.Enumerator);
					if (this.cancellationToken_0.IsCancellationRequested)
					{
						Class491 class3 = this.class628_0.class491_0;
						if (class3 != null)
						{
							class3.method_3();
						}
						goto IL_CF9;
					}
					if (this.class628_0.class491_0 == null)
					{
						goto IL_7D6;
					}
					Class491 class4 = this.class628_0.class491_0;
					awaiter3 = ((class4 != null) ? class4.method_5() : null).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						int num8 = 4;
						num = 4;
						this.int_0 = num8;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class626.Struct346>(ref awaiter3, ref this);
						return;
					}
					goto IL_7CF;
				}
				case 4:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num9 = -1;
					num = -1;
					this.int_0 = num9;
					goto IL_7CF;
				}
				case 5:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num10 = -1;
					num = -1;
					this.int_0 = num10;
					goto IL_97E;
				}
				case 6:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num11 = -1;
					num = -1;
					this.int_0 = num11;
					goto IL_B59;
				}
				case 7:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter);
					int num12 = -1;
					num = -1;
					this.int_0 = num12;
					goto IL_BEA;
				}
				default:
				{
					this.class628_0 = new Class626.Class628();
					this.class628_0.class491_0 = this.class491_0;
					Class518 class5 = this.class518_0;
					if (class5 != null)
					{
						class5.method_5(Class298.smethod_2("storexins5"), Brushes.White);
					}
					Class491 class6 = this.class628_0.class491_0;
					if (class6 != null)
					{
						class6.method_6(Class298.smethod_2("storexins2"), Brushes.White);
					}
					this.class518_0.bool_0 = true;
					if (Class626.gclass225_0 == null)
					{
						Class626.gclass225_0 = new GClass225(Class626.gclass246_1.method_6(), new GClass233(Class626.gclass246_1.method_2(), Class626.gclass246_1.method_4(), true));
					}
					awaiter = Class626.gclass225_0.method_1(this.class518_0.AppXProductID, (GEnum9)0, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num13 = 0;
						num = 0;
						this.int_0 = num13;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass42>, Class626.Struct346>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				GClass42 result = awaiter.GetResult();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class491 class7 = this.class628_0.class491_0;
					if (class7 != null)
					{
						class7.method_3();
					}
					goto IL_CF9;
				}
				GClass197 gclass197_ = result.GClass197_0;
				awaiter2 = Class626.gclass225_0.method_0(gclass197_, null).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					int num14 = 1;
					num = 1;
					this.int_0 = num14;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass298>>, Class626.Struct346>(ref awaiter2, ref this);
					return;
				}
				IL_1D1:
				IEnumerable<GClass298> result2 = awaiter2.GetResult();
				List<GClass255> list = new List<GClass255>();
				IEnumerator<GClass298> enumerator = result2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass298 gclass = enumerator.Current;
						List<GClass255> list2 = list;
						GClass255 gclass2 = new GClass255();
						gclass2.method_1(gclass.string_0);
						gclass2.method_3(gclass.uri_0.ToString());
						gclass2.method_7(gclass.gclass103_0.GClass263_0.String_0);
						gclass2.method_9(gclass.gclass103_0.GClass263_0.String_1);
						gclass2.method_11(gclass.gclass103_0.GClass263_0.String_2);
						gclass2.method_13(Class746.smethod_0<GClass21>(gclass.gclass103_0.List_0).Int32_0);
						gclass2.method_15(Class746.smethod_0<GClass21>(gclass.gclass103_0.List_0).Int64_1);
						gclass2.method_17(Class746.smethod_0<GClass21>(gclass.gclass103_0.List_0).Int64_0);
						list2.Add(gclass2);
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class491 class8 = this.class628_0.class491_0;
					if (class8 != null)
					{
						class8.method_3();
					}
					goto IL_CF9;
				}
				this.class628_0.dictionary_0 = new Dictionary<string, GClass255>();
				Class620.smethod_0().method_0();
				bool flag = false;
				bool flag2 = false;
				List<GClass255>.Enumerator enumerator2 = list.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass255 gclass3 = enumerator2.Current;
						if (!gclass3.method_30())
						{
							if (gclass3.method_28())
							{
								flag = true;
							}
							if (gclass3.method_26())
							{
								flag2 = true;
							}
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				enumerator2 = list.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass255 gclass4 = enumerator2.Current;
						if (gclass4.method_18() && !gclass4.method_25() && (!gclass4.method_19() || !gclass4.method_30()))
						{
							string key;
							if (gclass4.method_30())
							{
								if (!gclass4.method_26() && !gclass4.method_27())
								{
									continue;
								}
								key = gclass4.method_23();
							}
							else
							{
								if (!gclass4.method_26() && !gclass4.method_28() && (flag2 || flag))
								{
									continue;
								}
								key = gclass4.method_20();
							}
							if (!this.class628_0.dictionary_0.ContainsKey(key))
							{
								this.class628_0.dictionary_0[key] = gclass4;
							}
							else if (gclass4.method_29(this.class628_0.dictionary_0[key]) > 0)
							{
								this.class628_0.dictionary_0[key] = gclass4;
							}
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class491 class9 = this.class628_0.class491_0;
					if (class9 != null)
					{
						class9.method_3();
					}
					goto IL_CF9;
				}
				Class491 class10 = this.class628_0.class491_0;
				if (class10 != null)
				{
					class10.method_6(Class298.smethod_2("storexins3") + string.Format(" (0/{0})", this.class628_0.dictionary_0.Count), Brushes.White);
				}
				if (this.class628_0.class491_0 == null)
				{
					goto IL_550;
				}
				Class491 class11 = this.class628_0.class491_0;
				awaiter3 = ((class11 != null) ? class11.method_4() : null).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num15 = 2;
					num = 2;
					this.int_0 = num15;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class626.Struct346>(ref awaiter3, ref this);
					return;
				}
				IL_549:
				awaiter3.GetResult();
				IL_550:
				this.class628_0.int_0 = 1;
				this.enumerator_0 = this.class628_0.dictionary_0.GetEnumerator();
				goto IL_572;
				IL_7CF:
				awaiter3.GetResult();
				IL_7D6:
				Class808.smethod_27("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppModelUnlock\" /v \"AllowDevelopmentWithoutDevLicense\" /t REG_DWORD /d \"1\" /f");
				this.list_0 = new List<GClass255>();
				this.list_1 = new List<GClass255>();
				this.string_0 = "C:\\Program Files\\WindowsApps\\";
				Dictionary<string, GClass255>.Enumerator enumerator3 = this.class628_0.dictionary_0.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						KeyValuePair<string, GClass255> keyValuePair2 = enumerator3.Current;
						GClass255 value = keyValuePair2.Value;
						if (value.method_30())
						{
							this.list_0.Add(value);
						}
						else
						{
							this.list_1.Add(value);
							this.string_0 += value.method_4().Split(new char[]
							{
								'\\'
							}).Last<string>();
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class491 class12 = this.class628_0.class491_0;
					if (class12 != null)
					{
						class12.method_3();
					}
					goto IL_CF9;
				}
				Class491 class13 = this.class628_0.class491_0;
				if (class13 != null)
				{
					class13.method_6(Class298.smethod_2("storexins5") + string.Format(" (0/{0})", this.class628_0.dictionary_0.Count), Brushes.White);
				}
				if (this.class628_0.class491_0 == null)
				{
					goto IL_985;
				}
				Class491 class14 = this.class628_0.class491_0;
				awaiter3 = ((class14 != null) ? class14.method_4() : null).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num16 = 5;
					num = 5;
					this.int_0 = num16;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class626.Struct346>(ref awaiter3, ref this);
					return;
				}
				IL_97E:
				awaiter3.GetResult();
				IL_985:
				this.class628_0.int_0 = 1;
				enumerator2 = this.list_0.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass255 gclass5 = enumerator2.Current;
						Dispatcher dispatcher2 = Application.Current.Dispatcher;
						Action callback2;
						if ((callback2 = this.class628_0.action_1) == null)
						{
							callback2 = (this.class628_0.action_1 = new Action(this.class628_0.method_1));
						}
						dispatcher2.Invoke(callback2);
						Class626.smethod_7(gclass5, this.class628_0.class491_0);
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							Class491 class15 = this.class628_0.class491_0;
							if (class15 != null)
							{
								class15.method_3();
							}
							goto IL_CF9;
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				enumerator2 = this.list_1.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass255 gclass6 = enumerator2.Current;
						Dispatcher dispatcher3 = Application.Current.Dispatcher;
						Action callback3;
						if ((callback3 = this.class628_0.action_2) == null)
						{
							callback3 = (this.class628_0.action_2 = new Action(this.class628_0.method_2));
						}
						dispatcher3.Invoke(callback3);
						Class626.smethod_7(gclass6, this.class628_0.class491_0);
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							Class491 class16 = this.class628_0.class491_0;
							if (class16 != null)
							{
								class16.method_3();
							}
							goto IL_CF9;
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (this.class628_0.class491_0 == null)
				{
					goto IL_B60;
				}
				Class491 class17 = this.class628_0.class491_0;
				awaiter3 = ((class17 != null) ? class17.method_5() : null).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num17 = 6;
					num = 6;
					this.int_0 = num17;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class626.Struct346>(ref awaiter3, ref this);
					return;
				}
				IL_B59:
				awaiter3.GetResult();
				IL_B60:
				Class491 class18 = this.class628_0.class491_0;
				if (class18 != null)
				{
					class18.method_6(Class298.smethod_2("storexins8"), Brushes.White);
				}
				Class808.smethod_11(this.string_0);
				awaiter3 = Task.Delay(2000).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num18 = 7;
					num = 7;
					this.int_0 = num18;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class626.Struct346>(ref awaiter3, ref this);
					return;
				}
				IL_BEA:
				awaiter3.GetResult();
				if (this.cancellationToken_0.IsCancellationRequested)
				{
					Class491 class19 = this.class628_0.class491_0;
					if (class19 != null)
					{
						class19.method_3();
					}
				}
				else
				{
					enumerator2 = this.list_1.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							GClass255 gclass7 = enumerator2.Current;
							File.Delete(gclass7.method_4());
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator2).Dispose();
						}
					}
					enumerator2 = this.list_0.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							GClass255 gclass8 = enumerator2.Current;
							File.Delete(gclass8.method_4());
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator2).Dispose();
						}
					}
					Class518 class20 = this.class518_0;
					if (class20 != null)
					{
						class20.method_5(Class298.smethod_2("Installed"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
					}
					this.class518_0.bool_0 = false;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class628_0 = null;
				this.list_0 = null;
				this.list_1 = null;
				this.string_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_CF9:
			this.int_0 = -2;
			this.class628_0 = null;
			this.list_0 = null;
			this.list_1 = null;
			this.string_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0001636B File Offset: 0x0001456B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001652 RID: 5714
		public int int_0;

		// Token: 0x04001653 RID: 5715
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001654 RID: 5716
		public Class491 class491_0;

		// Token: 0x04001655 RID: 5717
		public Class518 class518_0;

		// Token: 0x04001656 RID: 5718
		public CancellationToken cancellationToken_0;

		// Token: 0x04001657 RID: 5719
		private Class626.Class628 class628_0;

		// Token: 0x04001658 RID: 5720
		private List<GClass255> list_0;

		// Token: 0x04001659 RID: 5721
		private List<GClass255> list_1;

		// Token: 0x0400165A RID: 5722
		private string string_0;

		// Token: 0x0400165B RID: 5723
		private TaskAwaiter<GClass42> taskAwaiter_0;

		// Token: 0x0400165C RID: 5724
		private TaskAwaiter<IList<GClass298>> taskAwaiter_1;

		// Token: 0x0400165D RID: 5725
		private TaskAwaiter taskAwaiter_2;

		// Token: 0x0400165E RID: 5726
		private Dictionary<string, GClass255>.Enumerator enumerator_0;

		// Token: 0x0400165F RID: 5727
		private GClass255 gclass255_0;
	}

	// Token: 0x0200052B RID: 1323
	private sealed class Class629
	{
		// Token: 0x060021C2 RID: 8642 RVA: 0x00087310 File Offset: 0x00085510
		internal void method_0()
		{
			if (this.class634_0.class491_0 != null)
			{
				this.class634_0.class491_0.ProgressText = string.Format("{0:F2}/{1:F2} MB", (double)this.long_0 / 1048576.0, this.nullable_0.GetValueOrDefault() / 1048576L);
				this.class634_0.class491_0.ProgressValue = Math.Round((double)this.long_0 / (double)this.nullable_0.Value * 100.0, 2);
			}
		}

		// Token: 0x04001660 RID: 5728
		public long long_0;

		// Token: 0x04001661 RID: 5729
		public long? nullable_0;

		// Token: 0x04001662 RID: 5730
		public Class626.Class634 class634_0;
	}

	// Token: 0x0200052C RID: 1324
	private sealed class Class630
	{
		// Token: 0x060021C4 RID: 8644 RVA: 0x000873AC File Offset: 0x000855AC
		internal void method_0()
		{
			if (this.class635_0.class491_0 != null)
			{
				this.class635_0.class491_0.ProgressText = this.psdataCollection_0[this.dataAddedEventArgs_0.Index].PercentComplete.ToString() + "%";
				this.class635_0.class491_0.ProgressValue = (double)this.psdataCollection_0[this.dataAddedEventArgs_0.Index].PercentComplete;
			}
		}

		// Token: 0x04001663 RID: 5731
		public PSDataCollection<ProgressRecord> psdataCollection_0;

		// Token: 0x04001664 RID: 5732
		public DataAddedEventArgs dataAddedEventArgs_0;

		// Token: 0x04001665 RID: 5733
		public Class626.Class635 class635_0;
	}

	// Token: 0x0200052D RID: 1325
	[StructLayout(LayoutKind.Auto)]
	private struct Struct347 : IAsyncStateMachine
	{
		// Token: 0x060021C5 RID: 8645 RVA: 0x00087430 File Offset: 0x00085630
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class518> result;
			try
			{
				TaskAwaiter<List<Class518>> awaiter;
				if (num != 0)
				{
					awaiter = Task.Run<List<Class518>>(new Func<Task<List<Class518>>>(new Class626.Class638
					{
						string_0 = this.string_0,
						class491_0 = this.class491_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class518>>, Class626.Struct347>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class518>>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00016379 File Offset: 0x00014579
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001666 RID: 5734
		public int int_0;

		// Token: 0x04001667 RID: 5735
		public AsyncTaskMethodBuilder<List<Class518>> asyncTaskMethodBuilder_0;

		// Token: 0x04001668 RID: 5736
		public string string_0;

		// Token: 0x04001669 RID: 5737
		public Class491 class491_0;

		// Token: 0x0400166A RID: 5738
		private TaskAwaiter<List<Class518>> taskAwaiter_0;
	}

	// Token: 0x0200052E RID: 1326
	private sealed class Class631
	{
		// Token: 0x060021C8 RID: 8648 RVA: 0x00016387 File Offset: 0x00014587
		internal void method_0()
		{
			this.list_0 = new List<Class518>();
		}

		// Token: 0x0400166B RID: 5739
		public List<Class518> list_0;

		// Token: 0x0400166C RID: 5740
		public Class491 class491_0;
	}

	// Token: 0x0200052F RID: 1327
	[StructLayout(LayoutKind.Auto)]
	private struct Struct348 : IAsyncStateMachine
	{
		// Token: 0x060021C9 RID: 8649 RVA: 0x00087504 File Offset: 0x00085704
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class518> list_;
			try
			{
				if (num != 0)
				{
					this.class639_0 = new Class626.Class639();
					this.class639_0.class491_0 = this.class491_0;
					this.class639_0.list_0 = new List<Class518>();
				}
				GClass161 result;
				try
				{
					TaskAwaiter<GClass161> awaiter;
					if (num != 0)
					{
						awaiter = this.gclass225_0.method_4(this.string_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass161>, Class626.Struct348>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass161>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				catch (GException0 value)
				{
					Console.WriteLine("Failed to search DisplayCatalog");
					Console.WriteLine(value);
					list_ = this.class639_0.list_0;
					goto IL_16A;
				}
				List<GClass0>.Enumerator enumerator = new List<GClass0>().Concat(result.List_0).ToList<GClass0>().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class626.Class633 @class = new Class626.Class633();
						@class.class639_0 = this.class639_0;
						@class.gclass0_0 = enumerator.Current;
						Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				list_ = this.class639_0.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class639_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_16A:
			this.int_0 = -2;
			this.class639_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00016394 File Offset: 0x00014594
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400166D RID: 5741
		public int int_0;

		// Token: 0x0400166E RID: 5742
		public AsyncTaskMethodBuilder<List<Class518>> asyncTaskMethodBuilder_0;

		// Token: 0x0400166F RID: 5743
		public Class491 class491_0;

		// Token: 0x04001670 RID: 5744
		public GClass225 gclass225_0;

		// Token: 0x04001671 RID: 5745
		public string string_0;

		// Token: 0x04001672 RID: 5746
		private Class626.Class639 class639_0;

		// Token: 0x04001673 RID: 5747
		private TaskAwaiter<GClass161> taskAwaiter_0;
	}

	// Token: 0x02000530 RID: 1328
	private sealed class Class632
	{
		// Token: 0x060021CC RID: 8652 RVA: 0x000163A2 File Offset: 0x000145A2
		internal void method_0()
		{
			this.list_0 = new List<Class518>();
		}

		// Token: 0x04001674 RID: 5748
		public List<Class518> list_0;
	}

	// Token: 0x02000531 RID: 1329
	private sealed class Class633
	{
		// Token: 0x060021CE RID: 8654 RVA: 0x000876E4 File Offset: 0x000858E4
		internal void method_0()
		{
			Class518 item = new Class518(this.class639_0.class491_0, null)
			{
				AppXPrice = (double)this.gclass0_0.Int64_0,
				AppXProductID = this.gclass0_0.String_0,
				AppXName = this.gclass0_0.String_1,
				AppXIconUrl = this.gclass0_0.String_41,
				AppXAverageRating = this.gclass0_0.String_10
			};
			this.class639_0.list_0.Add(item);
		}

		// Token: 0x04001675 RID: 5749
		public GClass0 gclass0_0;

		// Token: 0x04001676 RID: 5750
		public Class626.Class639 class639_0;
	}

	// Token: 0x02000532 RID: 1330
	[StructLayout(LayoutKind.Auto)]
	private struct Struct349 : IAsyncStateMachine
	{
		// Token: 0x060021CF RID: 8655 RVA: 0x0008776C File Offset: 0x0008596C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class518> list_;
			try
			{
				if (num != 0)
				{
					this.class627_0 = new Class626.Class627();
					this.class627_0.class491_0 = this.class491_0;
					this.class627_0.list_0 = null;
					Application.Current.Dispatcher.Invoke(new Action(this.class627_0.method_0));
				}
				try
				{
					TaskAwaiter<GClass42> awaiter;
					if (num != 0)
					{
						this.class636_0 = new Class626.Class636();
						this.class636_0.class627_0 = this.class627_0;
						awaiter = this.gclass225_0.method_1(this.string_0, (GEnum9)0, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass42>, Class626.Struct349>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass42>);
						this.int_0 = -1;
					}
					GClass42 result = awaiter.GetResult();
					this.class636_0.gclass42_0 = result;
					if (this.class636_0.gclass42_0.GClass197_0 != null)
					{
						Application.Current.Dispatcher.Invoke(new Action(this.class636_0.method_0));
					}
					this.class636_0 = null;
				}
				catch
				{
				}
				list_ = this.class627_0.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class627_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class627_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x000163AF File Offset: 0x000145AF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001677 RID: 5751
		public int int_0;

		// Token: 0x04001678 RID: 5752
		public AsyncTaskMethodBuilder<List<Class518>> asyncTaskMethodBuilder_0;

		// Token: 0x04001679 RID: 5753
		public Class491 class491_0;

		// Token: 0x0400167A RID: 5754
		public GClass225 gclass225_0;

		// Token: 0x0400167B RID: 5755
		public string string_0;

		// Token: 0x0400167C RID: 5756
		private Class626.Class636 class636_0;

		// Token: 0x0400167D RID: 5757
		private Class626.Class627 class627_0;

		// Token: 0x0400167E RID: 5758
		private TaskAwaiter<GClass42> taskAwaiter_0;
	}

	// Token: 0x02000533 RID: 1331
	private sealed class Class634
	{
		// Token: 0x060021D2 RID: 8658 RVA: 0x0008791C File Offset: 0x00085B1C
		internal void method_0()
		{
			Class626.Class634.Struct350 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class634_0 = this;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class626.Class634.Struct350>(ref @struct);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00087954 File Offset: 0x00085B54
		internal bool method_1(long? nullable_0, long long_0)
		{
			Class626.Class629 @class = new Class626.Class629();
			@class.class634_0 = this;
			@class.long_0 = long_0;
			@class.nullable_0 = nullable_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			return this.cancellationToken_0.IsCancellationRequested;
		}

		// Token: 0x0400167F RID: 5759
		public GClass255 gclass255_0;

		// Token: 0x04001680 RID: 5760
		public Class491 class491_0;

		// Token: 0x04001681 RID: 5761
		public CancellationToken cancellationToken_0;

		// Token: 0x04001682 RID: 5762
		public GClass101.GDelegate0 gdelegate0_0;

		// Token: 0x02000534 RID: 1332
		[StructLayout(LayoutKind.Auto)]
		private struct Struct350 : IAsyncStateMachine
		{
			// Token: 0x060021D4 RID: 8660 RVA: 0x000879A4 File Offset: 0x00085BA4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class626.Class634 @class = this.class634_0;
				try
				{
					if (num != 0)
					{
						this.string_0 = Path.Combine(Class169.string_11, @class.gclass255_0.method_0());
						this.gclass101_0 = new GClass101(@class.gclass255_0.method_2(), this.string_0);
					}
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							GClass101 gclass = this.gclass101_0;
							GClass101.GDelegate0 gdelegate0_;
							if ((gdelegate0_ = @class.gdelegate0_0) == null)
							{
								gdelegate0_ = (@class.gdelegate0_0 = new GClass101.GDelegate0(@class.method_1));
							}
							gclass.method_2(gdelegate0_);
							awaiter = this.gclass101_0.method_4().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num2 = 0;
								num = 0;
								this.int_0 = num2;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class626.Class634.Struct350>(ref awaiter, ref this);
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
					}
					finally
					{
						if (num < 0 && this.gclass101_0 != null)
						{
							((IDisposable)this.gclass101_0).Dispose();
						}
					}
					this.gclass101_0 = null;
					@class.gclass255_0.method_5(this.string_0);
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.string_0 = null;
					this.asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.string_0 = null;
				this.asyncVoidMethodBuilder_0.SetResult();
			}

			// Token: 0x060021D5 RID: 8661 RVA: 0x000163BD File Offset: 0x000145BD
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001683 RID: 5763
			public int int_0;

			// Token: 0x04001684 RID: 5764
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001685 RID: 5765
			public Class626.Class634 class634_0;

			// Token: 0x04001686 RID: 5766
			private string string_0;

			// Token: 0x04001687 RID: 5767
			private GClass101 gclass101_0;

			// Token: 0x04001688 RID: 5768
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x02000535 RID: 1333
	private sealed class Class635
	{
		// Token: 0x060021D7 RID: 8663 RVA: 0x00087B14 File Offset: 0x00085D14
		internal void method_0(object sender, DataAddedEventArgs e)
		{
			Class626.Class630 @class = new Class626.Class630();
			@class.class635_0 = this;
			@class.dataAddedEventArgs_0 = e;
			@class.psdataCollection_0 = (PSDataCollection<ProgressRecord>)sender;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x04001689 RID: 5769
		public Class491 class491_0;
	}

	// Token: 0x02000536 RID: 1334
	[StructLayout(LayoutKind.Auto)]
	private struct Struct351 : IAsyncStateMachine
	{
		// Token: 0x060021D8 RID: 8664 RVA: 0x00087B5C File Offset: 0x00085D5C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class518> list_;
			try
			{
				if (num != 0)
				{
					this.class631_0 = new Class626.Class631();
					this.class631_0.class491_0 = this.class491_0;
					this.class631_0.list_0 = null;
					Application.Current.Dispatcher.Invoke(new Action(this.class631_0.method_0));
				}
				try
				{
					TaskAwaiter<GClass42> awaiter;
					if (num != 0)
					{
						if (!this.string_0.StartsWith("https://apps.microsoft.com/store/detail"))
						{
							goto IL_14C;
						}
						this.class637_0 = new Class626.Class637();
						this.class637_0.class631_0 = this.class631_0;
						string text = new Uri(this.string_0).Segments.Last<string>();
						awaiter = this.gclass225_0.method_1(text, (GEnum9)0, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass42>, Class626.Struct351>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass42>);
						this.int_0 = -1;
					}
					GClass42 result = awaiter.GetResult();
					this.class637_0.gclass42_0 = result;
					if (this.class637_0.gclass42_0.GClass197_0 != null)
					{
						Application.Current.Dispatcher.Invoke(new Action(this.class637_0.method_0));
					}
					this.class637_0 = null;
					IL_14C:;
				}
				catch (Exception exception_)
				{
					GClass268.smethod_1(exception_);
				}
				list_ = this.class631_0.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class631_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class631_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000163CB File Offset: 0x000145CB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400168A RID: 5770
		public int int_0;

		// Token: 0x0400168B RID: 5771
		public AsyncTaskMethodBuilder<List<Class518>> asyncTaskMethodBuilder_0;

		// Token: 0x0400168C RID: 5772
		public Class491 class491_0;

		// Token: 0x0400168D RID: 5773
		public string string_0;

		// Token: 0x0400168E RID: 5774
		public GClass225 gclass225_0;

		// Token: 0x0400168F RID: 5775
		private Class626.Class637 class637_0;

		// Token: 0x04001690 RID: 5776
		private Class626.Class631 class631_0;

		// Token: 0x04001691 RID: 5777
		private TaskAwaiter<GClass42> taskAwaiter_0;
	}

	// Token: 0x02000537 RID: 1335
	private sealed class Class636
	{
		// Token: 0x060021DB RID: 8667 RVA: 0x00087D3C File Offset: 0x00085F3C
		internal void method_0()
		{
			Class518 @class = new Class518(this.class627_0.class491_0, null);
			@class.AppXProductID = this.gclass42_0.GClass197_0.String_12;
			List<GClass108> list_ = this.gclass42_0.GClass197_0.List_0;
			string appXName;
			if (list_ == null)
			{
				appXName = null;
			}
			else
			{
				GClass108 gclass = list_[0];
				appXName = ((gclass != null) ? gclass.String_5 : null);
			}
			@class.AppXName = appXName;
			string str = "https:";
			List<GClass108> list_2 = this.gclass42_0.GClass197_0.List_0;
			string str2;
			if (list_2 == null)
			{
				str2 = null;
			}
			else
			{
				GClass108 gclass2 = list_2[0];
				if (gclass2 == null)
				{
					str2 = null;
				}
				else
				{
					List<GClass294> list_3 = gclass2.List_1;
					if (list_3 == null)
					{
						str2 = null;
					}
					else
					{
						GClass294 gclass3 = list_3[0];
						str2 = ((gclass3 != null) ? gclass3.String_6 : null);
					}
				}
			}
			@class.AppXIconUrl = str + str2;
			Class518 item = @class;
			this.class627_0.list_0.Add(item);
		}

		// Token: 0x04001692 RID: 5778
		public GClass42 gclass42_0;

		// Token: 0x04001693 RID: 5779
		public Class626.Class627 class627_0;
	}

	// Token: 0x02000538 RID: 1336
	private sealed class Class637
	{
		// Token: 0x060021DD RID: 8669 RVA: 0x00087E04 File Offset: 0x00086004
		internal void method_0()
		{
			Class518 @class = new Class518(this.class631_0.class491_0, null);
			@class.AppXProductID = this.gclass42_0.GClass197_0.String_12;
			List<GClass108> list_ = this.gclass42_0.GClass197_0.List_0;
			string appXName;
			if (list_ == null)
			{
				appXName = null;
			}
			else
			{
				GClass108 gclass = list_[0];
				appXName = ((gclass != null) ? gclass.String_5 : null);
			}
			@class.AppXName = appXName;
			List<GClass108> list_2 = this.gclass42_0.GClass197_0.List_0;
			string appXIconUrl;
			if (list_2 == null)
			{
				appXIconUrl = null;
			}
			else
			{
				GClass108 gclass2 = list_2[0];
				if (gclass2 == null)
				{
					appXIconUrl = null;
				}
				else
				{
					List<GClass294> list_3 = gclass2.List_1;
					if (list_3 == null)
					{
						appXIconUrl = null;
					}
					else
					{
						GClass294 gclass3 = list_3[0];
						appXIconUrl = ((gclass3 != null) ? gclass3.String_6 : null);
					}
				}
			}
			@class.AppXIconUrl = appXIconUrl;
			Class518 item = @class;
			this.class631_0.list_0.Add(item);
		}

		// Token: 0x04001694 RID: 5780
		public GClass42 gclass42_0;

		// Token: 0x04001695 RID: 5781
		public Class626.Class631 class631_0;
	}

	// Token: 0x02000539 RID: 1337
	private sealed class Class638
	{
		// Token: 0x060021DF RID: 8671 RVA: 0x00087EC4 File Offset: 0x000860C4
		internal Task<List<Class518>> method_0()
		{
			Class626.Class638.Struct352 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class518>>.Create();
			@struct.class638_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class626.Class638.Struct352>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001696 RID: 5782
		public string string_0;

		// Token: 0x04001697 RID: 5783
		public Class491 class491_0;

		// Token: 0x0200053A RID: 1338
		[StructLayout(LayoutKind.Auto)]
		private struct Struct352 : IAsyncStateMachine
		{
			// Token: 0x060021E0 RID: 8672 RVA: 0x00087F08 File Offset: 0x00086108
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class626.Class638 @class = this.class638_0;
				List<Class518> result2;
				try
				{
					TaskAwaiter<List<Class518>> awaiter;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class518>>);
						this.int_0 = -1;
						break;
					case 1:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class518>>);
						this.int_0 = -1;
						goto IL_1E1;
					case 2:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<List<Class518>>);
						this.int_0 = -1;
						goto IL_287;
					default:
						this.class632_0 = new Class626.Class632();
						Class626.smethod_0();
						if (!string.IsNullOrEmpty(Class626.gclass246_0.method_0()) && !Class626.gclass246_0.method_0().StartsWith("Token") && !Class626.gclass246_0.method_0().StartsWith("Bearer") && !Class626.gclass246_0.method_0().StartsWith("XBL3.0="))
						{
							Console.WriteLine("Invalid token format, ignoring...");
						}
						else if (!string.IsNullOrEmpty(Class626.gclass246_0.method_0()))
						{
							Console.WriteLine("Setting token...");
						}
						this.class632_0.list_0 = null;
						Application.Current.Dispatcher.Invoke(new Action(this.class632_0.method_0));
						this.list_0 = this.class632_0.list_0;
						awaiter = Class626.smethod_4(@class.string_0, Class626.gclass225_0, @class.class491_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class518>>, Class626.Class638.Struct352>(ref awaiter, ref this);
							return;
						}
						break;
					}
					List<Class518> result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
					this.list_0 = this.class632_0.list_0;
					awaiter = Class626.smethod_2(@class.string_0, Class626.gclass225_0, @class.class491_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class518>>, Class626.Class638.Struct352>(ref awaiter, ref this);
						return;
					}
					IL_1E1:
					result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
					if (!@class.string_0.StartsWith("https://apps.microsoft.com/store/detail"))
					{
						goto IL_2A2;
					}
					this.list_0 = this.class632_0.list_0;
					awaiter = Class626.smethod_3(@class.string_0, Class626.gclass225_0, @class.class491_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class518>>, Class626.Class638.Struct352>(ref awaiter, ref this);
						return;
					}
					IL_287:
					result = awaiter.GetResult();
					this.list_0.AddRange(result);
					this.list_0 = null;
					IL_2A2:
					result2 = this.class632_0.list_0;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class632_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class632_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult(result2);
			}

			// Token: 0x060021E1 RID: 8673 RVA: 0x000163D9 File Offset: 0x000145D9
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001698 RID: 5784
			public int int_0;

			// Token: 0x04001699 RID: 5785
			public AsyncTaskMethodBuilder<List<Class518>> asyncTaskMethodBuilder_0;

			// Token: 0x0400169A RID: 5786
			public Class626.Class638 class638_0;

			// Token: 0x0400169B RID: 5787
			private Class626.Class632 class632_0;

			// Token: 0x0400169C RID: 5788
			private List<Class518> list_0;

			// Token: 0x0400169D RID: 5789
			private TaskAwaiter<List<Class518>> taskAwaiter_0;
		}
	}

	// Token: 0x0200053B RID: 1339
	private sealed class Class639
	{
		// Token: 0x0400169E RID: 5790
		public Class491 class491_0;

		// Token: 0x0400169F RID: 5791
		public List<Class518> list_0;
	}
}
