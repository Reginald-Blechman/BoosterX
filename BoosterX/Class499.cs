using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

// Token: 0x02000223 RID: 547
internal sealed class Class499 : GClass162
{
	// Token: 0x06000EE8 RID: 3816 RVA: 0x0000AFBF File Offset: 0x000091BF
	public Class499(string string_0)
	{
		this.class751_0 = new Class751(string_0);
		this.method_5();
		this.method_2();
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00052DDC File Offset: 0x00050FDC
	private void method_2()
	{
		this.list_0.Clear();
		bool flag = false;
		List<string> source = new List<string>();
		if (this.Affinity != null && this.Affinity != string.Empty)
		{
			source = this.Affinity.Split(new char[]
			{
				','
			}).ToList<string>();
		}
		else
		{
			flag = true;
		}
		bool showCoreType = Class781.list_0.Any(new Func<Class552, bool>(Class499.Class260.class260_0.method_0));
		using (List<Class552>.Enumerator enumerator = Class781.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class499.Class256 @class = new Class499.Class256();
				@class.class552_0 = enumerator.Current;
				this.list_0.Add(new Class517(null)
				{
					Core = @class.class552_0.Core,
					IsChosen = (flag || source.Any(new Func<string, bool>(@class.method_0))),
					Thread = @class.class552_0.Thread,
					IsECore = @class.class552_0.IsECore,
					ShowCoreType = showCoreType
				});
			}
		}
		this.method_3();
		this.list_0.ForEach(new Action<Class517>(this.method_6));
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00052F34 File Offset: 0x00051134
	private void method_3()
	{
		bool disableHyperThreading;
		if (Class781.bool_0)
		{
			disableHyperThreading = this.list_0.FindAll(new Predicate<Class517>(Class499.Class260.class260_0.method_1)).All(new Func<Class517, bool>(Class499.Class260.class260_0.method_2));
		}
		else
		{
			disableHyperThreading = false;
		}
		this.DisableHyperThreading = disableHyperThreading;
		this.DisableCore0 = this.list_0.FindAll(new Predicate<Class517>(Class499.Class260.class260_0.method_3)).All(new Func<Class517, bool>(Class499.Class260.class260_0.method_4));
		bool onlyPCores;
		if (Class781.int_3 != 0)
		{
			onlyPCores = this.list_0.FindAll(new Predicate<Class517>(Class499.Class260.class260_0.method_5)).All(new Func<Class517, bool>(Class499.Class260.class260_0.method_6));
		}
		else
		{
			onlyPCores = false;
		}
		this.OnlyPCores = onlyPCores;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00053054 File Offset: 0x00051254
	private void method_4(object sender, PropertyChangedEventArgs e)
	{
		Class499.Class259 @class = new Class499.Class259();
		@class.list_0 = new List<string>();
		this.list_0.FindAll(new Predicate<Class517>(Class499.Class260.class260_0.method_7)).ForEach(new Action<Class517>(@class.method_0));
		this.Affinity = string.Join(",", @class.list_0);
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0000AFEA File Offset: 0x000091EA
	// (set) Token: 0x06000EED RID: 3821 RVA: 0x000530C4 File Offset: 0x000512C4
	public bool DisableCore0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			Class499.Class255 @class = new Class499.Class255();
			@class.bool_0 = value;
			this.bool_0 = @class.bool_0;
			this.list_0.FindAll(new Predicate<Class517>(Class499.Class260.class260_0.method_8)).ForEach(new Action<Class517>(@class.method_0));
			base.method_0("DisableCore0");
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0000AFF2 File Offset: 0x000091F2
	// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00053134 File Offset: 0x00051334
	public bool DisableHyperThreading
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			Class499.Class258 @class = new Class499.Class258();
			@class.bool_0 = value;
			this.bool_1 = @class.bool_0;
			this.list_0.FindAll(new Predicate<Class517>(Class499.Class260.class260_0.method_9)).ForEach(new Action<Class517>(@class.method_0));
			base.method_0("DisableHyperThreading");
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0000AFFA File Offset: 0x000091FA
	// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x000531A4 File Offset: 0x000513A4
	public bool OnlyPCores
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			Class499.Class257 @class = new Class499.Class257();
			@class.bool_0 = value;
			this.bool_2 = @class.bool_0;
			this.list_0.FindAll(new Predicate<Class517>(Class499.Class260.class260_0.method_10)).ForEach(new Action<Class517>(@class.method_0));
			base.method_0("OnlyPCores");
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0000B002 File Offset: 0x00009202
	// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x0000B00A File Offset: 0x0000920A
	public bool IsChecked
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
			base.method_0("IsChecked");
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0000B01F File Offset: 0x0000921F
	public string Name
	{
		get
		{
			return this.class751_0.method_1();
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0000B02C File Offset: 0x0000922C
	// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x0000B039 File Offset: 0x00009239
	public string FoundIn
	{
		get
		{
			return this.class751_0.FoundIn;
		}
		set
		{
			this.class751_0.FoundIn = value;
			base.method_0("FoundIn");
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x0000B053 File Offset: 0x00009253
	// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x0000B060 File Offset: 0x00009260
	public string ExeName
	{
		get
		{
			return this.class751_0.method_3();
		}
		set
		{
			this.class751_0.method_4(value);
			base.method_0("ExeName");
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0000B07A File Offset: 0x0000927A
	// (set) Token: 0x06000EFA RID: 3834 RVA: 0x0000B087 File Offset: 0x00009287
	public string GamePath
	{
		get
		{
			return this.class751_0.method_5();
		}
		set
		{
			this.class751_0.method_6(value);
			base.method_0("GamePath");
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0000B0A1 File Offset: 0x000092A1
	// (set) Token: 0x06000EFC RID: 3836 RVA: 0x0000B0AE File Offset: 0x000092AE
	public string LaunchDelay
	{
		get
		{
			return this.class751_0.LaunchDelay;
		}
		set
		{
			this.class751_0.LaunchDelay = value;
			base.method_0("LaunchDelay");
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0000B0C8 File Offset: 0x000092C8
	// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0000B0D0 File Offset: 0x000092D0
	public BitmapSource Icon
	{
		get
		{
			return this.bitmapSource_0;
		}
		set
		{
			this.bitmapSource_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00053214 File Offset: 0x00051414
	public void method_5()
	{
		Class499.Struct130 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class499_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class499.Struct130>(ref @struct);
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0000B0E5 File Offset: 0x000092E5
	// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000B0F2 File Offset: 0x000092F2
	public string Affinity
	{
		get
		{
			return this.class751_0.Affinity;
		}
		set
		{
			this.class751_0.Affinity = value;
			base.method_0("Affinity");
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0000B10C File Offset: 0x0000930C
	// (set) Token: 0x06000F03 RID: 3843 RVA: 0x0005324C File Offset: 0x0005144C
	public bool? DisableDWM
	{
		get
		{
			return this.class751_0.DisableDWM;
		}
		set
		{
			if (this.UseGlobalProfile.GetValueOrDefault())
			{
				return;
			}
			if (value.GetValueOrDefault())
			{
				this.DisableExplorer = new bool?(true);
			}
			this.class751_0.DisableDWM = value;
			base.method_0("DisableDWM");
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0000B119 File Offset: 0x00009319
	// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00053298 File Offset: 0x00051498
	public bool? ThreadCompatibility
	{
		get
		{
			return this.class751_0.ThreadCompatibility;
		}
		set
		{
			if (value.Value)
			{
				this.DisableHyperThreading = false;
				this.DisableCore0 = false;
				this.list_0.ForEach(new Action<Class517>(Class499.Class260.class260_0.method_11));
				this.OnlyPCores = true;
			}
			this.class751_0.ThreadCompatibility = value;
			base.method_0("ThreadCompatibility");
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0000B126 File Offset: 0x00009326
	// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00053308 File Offset: 0x00051508
	public bool? DisableExplorer
	{
		get
		{
			return this.class751_0.DisableExplorer;
		}
		set
		{
			if (this.UseGlobalProfile.GetValueOrDefault())
			{
				return;
			}
			this.class751_0.DisableExplorer = value;
			base.method_0("DisableExplorer");
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0000B133 File Offset: 0x00009333
	// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00053340 File Offset: 0x00051540
	public bool? UseGlobalProfile
	{
		get
		{
			return this.class751_0.UseGlobalProfile;
		}
		set
		{
			if (value.GetValueOrDefault())
			{
				this.DisableExplorer = null;
				this.DisableDWM = null;
			}
			this.class751_0.UseGlobalProfile = value;
			bool? flag = value;
			if ((!flag.GetValueOrDefault() & flag != null) && (this.DisableExplorer == null || this.DisableDWM == null))
			{
				this.DisableExplorer = new bool?(true);
				this.DisableDWM = new bool?(false);
			}
			base.method_0("DisableExplorer");
			base.method_0("DisableDWM");
			base.method_0("UseGlobalProfile");
		}
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x0000B140 File Offset: 0x00009340
	private void method_6(Class517 class517_0)
	{
		class517_0.PropertyChanged += this.method_4;
	}

	// Token: 0x04000993 RID: 2451
	private Class751 class751_0;

	// Token: 0x04000994 RID: 2452
	public List<Class517> list_0 = new List<Class517>();

	// Token: 0x04000995 RID: 2453
	private bool bool_0;

	// Token: 0x04000996 RID: 2454
	private bool bool_1;

	// Token: 0x04000997 RID: 2455
	private bool bool_2;

	// Token: 0x04000998 RID: 2456
	private bool bool_3;

	// Token: 0x04000999 RID: 2457
	private BitmapSource bitmapSource_0;

	// Token: 0x02000224 RID: 548
	private sealed class Class255
	{
		// Token: 0x06000F0C RID: 3852 RVA: 0x0000B154 File Offset: 0x00009354
		internal void method_0(Class517 class517_0)
		{
			class517_0.IsChosen = !this.bool_0;
		}

		// Token: 0x0400099A RID: 2458
		public bool bool_0;
	}

	// Token: 0x02000225 RID: 549
	private sealed class Class256
	{
		// Token: 0x06000F0E RID: 3854 RVA: 0x000533F4 File Offset: 0x000515F4
		internal bool method_0(string string_0)
		{
			return string_0 == this.class552_0.Thread.ToString();
		}

		// Token: 0x0400099B RID: 2459
		public Class552 class552_0;
	}

	// Token: 0x02000226 RID: 550
	[StructLayout(LayoutKind.Auto)]
	private struct Struct130 : IAsyncStateMachine
	{
		// Token: 0x06000F0F RID: 3855 RVA: 0x0005341C File Offset: 0x0005161C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class499 @class = this.class499_0;
			try
			{
				TaskAwaiter<BitmapSource> awaiter;
				TaskAwaiter<string> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<BitmapSource>);
						this.int_0 = -1;
						goto IL_11D;
					}
					awaiter2 = Class602.smethod_0(@class.Name.EndsWith(".exe") ? @class.Name.Replace(".exe", string.Empty) : @class.Name).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class499.Struct130>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				string result = awaiter2.GetResult();
				if (result != null && !(result == string.Empty))
				{
					@class.Icon = Class765.smethod_5(result);
					goto IL_149;
				}
				awaiter = Class765.smethod_6(@class.GamePath).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapSource>, Class499.Struct130>(ref awaiter, ref this);
					return;
				}
				IL_11D:
				BitmapSource result2 = awaiter.GetResult();
				@class.Icon = result2;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_149:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0000B165 File Offset: 0x00009365
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400099C RID: 2460
		public int int_0;

		// Token: 0x0400099D RID: 2461
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400099E RID: 2462
		public Class499 class499_0;

		// Token: 0x0400099F RID: 2463
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x040009A0 RID: 2464
		private TaskAwaiter<BitmapSource> taskAwaiter_1;
	}

	// Token: 0x02000227 RID: 551
	private sealed class Class257
	{
		// Token: 0x06000F12 RID: 3858 RVA: 0x0000B173 File Offset: 0x00009373
		internal void method_0(Class517 class517_0)
		{
			class517_0.IsChosen = !this.bool_0;
		}

		// Token: 0x040009A1 RID: 2465
		public bool bool_0;
	}

	// Token: 0x02000228 RID: 552
	private sealed class Class258
	{
		// Token: 0x06000F14 RID: 3860 RVA: 0x0000B184 File Offset: 0x00009384
		internal void method_0(Class517 class517_0)
		{
			class517_0.IsChosen = !this.bool_0;
		}

		// Token: 0x040009A2 RID: 2466
		public bool bool_0;
	}

	// Token: 0x02000229 RID: 553
	private sealed class Class259
	{
		// Token: 0x06000F16 RID: 3862 RVA: 0x000535A4 File Offset: 0x000517A4
		internal void method_0(Class517 class517_0)
		{
			this.list_0.Add(class517_0.Thread.ToString());
		}

		// Token: 0x040009A3 RID: 2467
		public List<string> list_0;
	}

	// Token: 0x0200022A RID: 554
	[Serializable]
	private sealed class Class260
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x0000B1A1 File Offset: 0x000093A1
		internal bool method_0(Class552 class552_0)
		{
			return class552_0.IsECore;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0000B1A9 File Offset: 0x000093A9
		internal bool method_1(Class517 class517_0)
		{
			return !class517_0.IsECore && class517_0.Thread % 2 == 1;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0000B1C0 File Offset: 0x000093C0
		internal bool method_2(Class517 class517_0)
		{
			return !class517_0.IsChosen;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0000B1CB File Offset: 0x000093CB
		internal bool method_3(Class517 class517_0)
		{
			return class517_0.Core == 0;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0000B1C0 File Offset: 0x000093C0
		internal bool method_4(Class517 class517_0)
		{
			return !class517_0.IsChosen;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0000B1D6 File Offset: 0x000093D6
		internal bool method_5(Class517 class517_0)
		{
			return class517_0.IsECore;
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0000B1C0 File Offset: 0x000093C0
		internal bool method_6(Class517 class517_0)
		{
			return !class517_0.IsChosen;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0000B1DE File Offset: 0x000093DE
		internal bool method_7(Class517 class517_0)
		{
			return class517_0.IsChosen;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0000B1CB File Offset: 0x000093CB
		internal bool method_8(Class517 class517_0)
		{
			return class517_0.Core == 0;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0000B1A9 File Offset: 0x000093A9
		internal bool method_9(Class517 class517_0)
		{
			return !class517_0.IsECore && class517_0.Thread % 2 == 1;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0000B1D6 File Offset: 0x000093D6
		internal bool method_10(Class517 class517_0)
		{
			return class517_0.IsECore;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0000B1E6 File Offset: 0x000093E6
		internal void method_11(Class517 class517_0)
		{
			class517_0.IsChosen = true;
		}

		// Token: 0x040009A4 RID: 2468
		public static readonly Class499.Class260 class260_0 = new Class499.Class260();

		// Token: 0x040009A5 RID: 2469
		public static Func<Class552, bool> func_0;

		// Token: 0x040009A6 RID: 2470
		public static Predicate<Class517> predicate_0;

		// Token: 0x040009A7 RID: 2471
		public static Func<Class517, bool> func_1;

		// Token: 0x040009A8 RID: 2472
		public static Predicate<Class517> predicate_1;

		// Token: 0x040009A9 RID: 2473
		public static Func<Class517, bool> func_2;

		// Token: 0x040009AA RID: 2474
		public static Predicate<Class517> predicate_2;

		// Token: 0x040009AB RID: 2475
		public static Func<Class517, bool> func_3;

		// Token: 0x040009AC RID: 2476
		public static Predicate<Class517> predicate_3;

		// Token: 0x040009AD RID: 2477
		public static Predicate<Class517> predicate_4;

		// Token: 0x040009AE RID: 2478
		public static Predicate<Class517> predicate_5;

		// Token: 0x040009AF RID: 2479
		public static Predicate<Class517> predicate_6;

		// Token: 0x040009B0 RID: 2480
		public static Action<Class517> action_0;
	}
}
