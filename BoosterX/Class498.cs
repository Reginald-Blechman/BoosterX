using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;
using WinCopies.Util;

// Token: 0x020001F4 RID: 500
internal sealed class Class498 : GClass162
{
	// Token: 0x06000DB0 RID: 3504 RVA: 0x0004F2F0 File Offset: 0x0004D4F0
	public Class498()
	{
		this.AnimationVisibility = Visibility.Visible;
		this.AnimationOpacity = 1.0;
		this.method_2();
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0004F374 File Offset: 0x0004D574
	public GClass280 UpdateCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_9), null));
			}
			return result;
		}
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x0004F3A8 File Offset: 0x0004D5A8
	private void method_2()
	{
		Class498.Struct113 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class498_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class498.Struct113>(ref @struct);
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0000A401 File Offset: 0x00008601
	// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x0000A409 File Offset: 0x00008609
	public string StatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0000A41E File Offset: 0x0000861E
	// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x0000A426 File Offset: 0x00008626
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0000A43B File Offset: 0x0000863B
	// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x0000A443 File Offset: 0x00008643
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x0004F3E0 File Offset: 0x0004D5E0
	private void method_3(string string_2, SolidColorBrush solidColorBrush_1)
	{
		Class498.Struct114 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class498_0 = this;
		@struct.string_0 = string_2;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class498.Struct114>(ref @struct);
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0000A458 File Offset: 0x00008658
	// (set) Token: 0x06000DBB RID: 3515 RVA: 0x0000A460 File Offset: 0x00008660
	public double AnimationOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("AnimationOpacity");
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0000A475 File Offset: 0x00008675
	// (set) Token: 0x06000DBD RID: 3517 RVA: 0x0000A47D File Offset: 0x0000867D
	public Visibility AnimationVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("AnimationVisibility");
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0000A492 File Offset: 0x00008692
	// (set) Token: 0x06000DBF RID: 3519 RVA: 0x0000A49A File Offset: 0x0000869A
	public double MainOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("MainOpacity");
		}
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x0004F428 File Offset: 0x0004D628
	private void method_4()
	{
		Class498.Struct117 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class498_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class498.Struct117>(ref @struct);
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x000078FD File Offset: 0x00005AFD
	private void method_5(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0000A4AF File Offset: 0x000086AF
	// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0000A4B7 File Offset: 0x000086B7
	public ObservableCollection<Interface8> ProblemsAll
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("ProblemsAll");
		}
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x0004F460 File Offset: 0x0004D660
	private Task method_6()
	{
		Class498.Struct115 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class498_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class498.Struct115>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x0004F4A4 File Offset: 0x0004D6A4
	private Task method_7()
	{
		Class498.Struct116 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class498_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class498.Struct116>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0000A4CC File Offset: 0x000086CC
	// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0000A4D4 File Offset: 0x000086D4
	public string Search
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			this.IsPossible = false;
			base.method_0("Search");
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0000A4F0 File Offset: 0x000086F0
	// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0000A4FB File Offset: 0x000086FB
	public bool IsAll
	{
		get
		{
			return !this.bool_1;
		}
		set
		{
			this.bool_1 = !value;
			base.method_0("IsAll");
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0000A513 File Offset: 0x00008713
	// (set) Token: 0x06000DCB RID: 3531 RVA: 0x0000A51B File Offset: 0x0000871B
	public bool IsPossible
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.method_0("IsPossible");
			base.method_0("IsAll");
			this.method_8(this.string_1);
		}
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
	private void method_8(string string_2)
	{
		Class498.Struct112 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class498_0 = this;
		@struct.string_0 = string_2;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class498.Struct112>(ref @struct);
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x0004F528 File Offset: 0x0004D728
	private void method_9(object object_0)
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		foreach (Class537 @class in this.observableCollection_1)
		{
			@class.method_2();
			this.method_3(" ", dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
		}
		foreach (Class514 class2 in this.observableCollection_2)
		{
			class2.method_2();
			this.method_3(" ", dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
		}
		this.bool_0 = false;
	}

	// Token: 0x040008B9 RID: 2233
	private bool bool_0;

	// Token: 0x040008BA RID: 2234
	private GClass280 gclass280_0;

	// Token: 0x040008BB RID: 2235
	private string string_0 = string.Empty;

	// Token: 0x040008BC RID: 2236
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x040008BD RID: 2237
	private double double_0;

	// Token: 0x040008BE RID: 2238
	private double double_1;

	// Token: 0x040008BF RID: 2239
	private Visibility visibility_0;

	// Token: 0x040008C0 RID: 2240
	private double double_2;

	// Token: 0x040008C1 RID: 2241
	private ObservableCollection<Interface8> observableCollection_0 = new ObservableCollection<Interface8>();

	// Token: 0x040008C2 RID: 2242
	private ObservableCollection<Class537> observableCollection_1 = new ObservableCollection<Class537>();

	// Token: 0x040008C3 RID: 2243
	private ObservableCollection<Class514> observableCollection_2 = new ObservableCollection<Class514>();

	// Token: 0x040008C4 RID: 2244
	private ObservableCollection<GClass184> observableCollection_3 = new ObservableCollection<GClass184>();

	// Token: 0x040008C5 RID: 2245
	private string string_1 = Class298.smethod_2("Search");

	// Token: 0x040008C6 RID: 2246
	private bool bool_1;

	// Token: 0x020001F5 RID: 501
	[StructLayout(LayoutKind.Auto)]
	private struct Struct112 : IAsyncStateMachine
	{
		// Token: 0x06000DCE RID: 3534 RVA: 0x0004F5E8 File Offset: 0x0004D7E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class498.Class238 @class = new Class498.Class238();
					@class.class498_0 = this.class498_0;
					@class.string_0 = this.string_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct112>(ref awaiter, ref this);
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

		// Token: 0x06000DCF RID: 3535 RVA: 0x0000A548 File Offset: 0x00008748
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008C7 RID: 2247
		public int int_0;

		// Token: 0x040008C8 RID: 2248
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008C9 RID: 2249
		public Class498 class498_0;

		// Token: 0x040008CA RID: 2250
		public string string_0;

		// Token: 0x040008CB RID: 2251
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001F6 RID: 502
	private sealed class Class237
	{
		// Token: 0x06000DD1 RID: 3537 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		internal void method_0()
		{
			List<Class707> list = this.list_0;
			Action<Class707> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class707>(this.method_1));
			}
			list.ForEach(action);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0000A556 File Offset: 0x00008756
		internal void method_1(Class707 class707_0)
		{
			this.class498_0.observableCollection_2.Add(new Class514(class707_0));
		}

		// Token: 0x040008CC RID: 2252
		public List<Class707> list_0;

		// Token: 0x040008CD RID: 2253
		public Class498 class498_0;

		// Token: 0x040008CE RID: 2254
		public Action<Class707> action_0;
	}

	// Token: 0x020001F7 RID: 503
	[StructLayout(LayoutKind.Auto)]
	private struct Struct113 : IAsyncStateMachine
	{
		// Token: 0x06000DD3 RID: 3539 RVA: 0x0004F700 File Offset: 0x0004D900
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class498 @class = this.class498_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.WhenAll(new List<Task>
					{
						@class.method_7(),
						@class.method_6()
					}).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct113>(ref awaiter, ref this);
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
				ICollection<Interface8> problemsAll = @class.ProblemsAll;
				IEnumerable<Interface8> enumerable = @class.observableCollection_1;
				Extensions.AddRange<Interface8>(problemsAll, ref enumerable);
				ICollection<Interface8> problemsAll2 = @class.ProblemsAll;
				enumerable = @class.observableCollection_2;
				Extensions.AddRange<Interface8>(problemsAll2, ref enumerable);
				@class.IsPossible = @class.ProblemsAll.Any(new Func<Interface8, bool>(Class498.Class241.class241_0.method_0));
				@class.method_4();
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

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0000A56E File Offset: 0x0000876E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008CF RID: 2255
		public int int_0;

		// Token: 0x040008D0 RID: 2256
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008D1 RID: 2257
		public Class498 class498_0;

		// Token: 0x040008D2 RID: 2258
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001F8 RID: 504
	[StructLayout(LayoutKind.Auto)]
	private struct Struct114 : IAsyncStateMachine
	{
		// Token: 0x06000DD5 RID: 3541 RVA: 0x0004F834 File Offset: 0x0004DA34
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class498 @class = this.class498_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct114>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct114>(ref awaiter, ref this);
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

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0000A57C File Offset: 0x0000877C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008D3 RID: 2259
		public int int_0;

		// Token: 0x040008D4 RID: 2260
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008D5 RID: 2261
		public Class498 class498_0;

		// Token: 0x040008D6 RID: 2262
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040008D7 RID: 2263
		public string string_0;

		// Token: 0x040008D8 RID: 2264
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001F9 RID: 505
	private sealed class Class238
	{
		// Token: 0x06000DD8 RID: 3544 RVA: 0x0004FA08 File Offset: 0x0004DC08
		internal void method_0()
		{
			if (this.class498_0.bool_1)
			{
				using (IEnumerator<Interface8> enumerator = this.class498_0.ProblemsAll.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Interface8 @interface = enumerator.Current;
						@interface.Visibility = (@interface.Possible ? Visibility.Visible : Visibility.Collapsed);
					}
					goto IL_80;
				}
			}
			foreach (Interface8 interface2 in this.class498_0.ProblemsAll)
			{
				interface2.Visibility = Visibility.Visible;
			}
			IL_80:
			if (!this.string_0.smethod_9() && this.string_0 != Class298.smethod_2("Search"))
			{
				foreach (Interface8 interface3 in this.class498_0.ProblemsAll)
				{
					if (!interface3.Name.smethod_3(this.string_0) && !interface3.NameEng.smethod_3(this.string_0) && !interface3.SearchInfo.smethod_3(this.string_0))
					{
						interface3.Visibility = Visibility.Collapsed;
					}
					else
					{
						interface3.Visibility = Visibility.Visible;
					}
				}
			}
		}

		// Token: 0x040008D9 RID: 2265
		public Class498 class498_0;

		// Token: 0x040008DA RID: 2266
		public string string_0;
	}

	// Token: 0x020001FA RID: 506
	private sealed class Class239
	{
		// Token: 0x06000DDA RID: 3546 RVA: 0x0000A58A File Offset: 0x0000878A
		internal bool method_0(Class303 class303_0)
		{
			return class303_0.Name == this.string_0;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0000A58A File Offset: 0x0000878A
		internal bool method_1(Class303 class303_0)
		{
			return class303_0.Name == this.string_0;
		}

		// Token: 0x040008DB RID: 2267
		public string string_0;
	}

	// Token: 0x020001FB RID: 507
	[StructLayout(LayoutKind.Auto)]
	private struct Struct115 : IAsyncStateMachine
	{
		// Token: 0x06000DDC RID: 3548 RVA: 0x0004FB60 File Offset: 0x0004DD60
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<List<Class707>> awaiter;
				TaskAwaiter awaiter2;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class707>>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_177;
				}
				case 2:
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					goto IL_20E;
				}
				default:
					this.class237_0 = new Class498.Class237();
					this.class237_0.class498_0 = this.class498_0;
					awaiter = Class670.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 0;
						num = 0;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class707>>, Class498.Struct115>(ref awaiter, ref this);
						return;
					}
					break;
				}
				List<Class707> result = awaiter.GetResult();
				this.class237_0.list_0 = result;
				this.list_0 = new List<Class514>();
				List<Class707>.Enumerator enumerator = this.class237_0.list_0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class707 class707_ = enumerator.Current;
						this.list_0.Add(new Class514(class707_));
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				this.int_1 = 0;
				IL_11D:
				if (this.list_0.All(new Func<Class514, bool>(Class498.Class241.class241_0.method_1)))
				{
					int num6 = this.int_1;
					this.int_1 = num6 + 1;
					if (num6 <= 1000)
					{
						awaiter2 = Task.Delay(20).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_177;
						}
						int num7 = 1;
						num = 1;
						this.int_0 = num7;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct115>(ref awaiter2, ref this);
						return;
					}
				}
				awaiter2 = Application.Current.Dispatcher.InvokeAsync(new Action(this.class237_0.method_0)).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					int num8 = 2;
					num = 2;
					this.int_0 = num8;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct115>(ref awaiter2, ref this);
					return;
				}
				goto IL_20E;
				IL_177:
				awaiter2.GetResult();
				goto IL_11D;
				IL_20E:
				awaiter2.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class237_0 = null;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class237_0 = null;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0000A59D File Offset: 0x0000879D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008DC RID: 2268
		public int int_0;

		// Token: 0x040008DD RID: 2269
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040008DE RID: 2270
		public Class498 class498_0;

		// Token: 0x040008DF RID: 2271
		private Class498.Class237 class237_0;

		// Token: 0x040008E0 RID: 2272
		private List<Class514> list_0;

		// Token: 0x040008E1 RID: 2273
		private int int_1;

		// Token: 0x040008E2 RID: 2274
		private TaskAwaiter<List<Class707>> taskAwaiter_0;

		// Token: 0x040008E3 RID: 2275
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020001FC RID: 508
	private sealed class Class240
	{
		// Token: 0x06000DDF RID: 3551 RVA: 0x0004FE00 File Offset: 0x0004E000
		internal void method_0()
		{
			this.class498_0.observableCollection_1.Clear();
			List<Class303> list = this.list_0;
			Action<Class303> action;
			if ((action = this.action_0) == null)
			{
				action = (this.action_0 = new Action<Class303>(this.method_1));
			}
			list.ForEach(action);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0000A5AB File Offset: 0x000087AB
		internal void method_1(Class303 class303_0)
		{
			this.class498_0.observableCollection_1.Add(new Class537(class303_0));
		}

		// Token: 0x040008E4 RID: 2276
		public Class498 class498_0;

		// Token: 0x040008E5 RID: 2277
		public List<Class303> list_0;

		// Token: 0x040008E6 RID: 2278
		public Action<Class303> action_0;
	}

	// Token: 0x020001FD RID: 509
	[StructLayout(LayoutKind.Auto)]
	private struct Struct116 : IAsyncStateMachine
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x0004FE48 File Offset: 0x0004E048
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class498 @class = this.class498_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_2BE;
					}
					this.class240_0 = new Class498.Class240();
					this.class240_0.class498_0 = this.class498_0;
					@class.observableCollection_3 = Class589.smethod_1(true).AllServices;
					awaiter = Class589.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct116>(ref awaiter, ref this);
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
				Dictionary<string, GClass222> dictionary = GClass207.smethod_0().method_0();
				this.class240_0.list_0 = new List<Class303>();
				Dictionary<string, GClass222>.Enumerator enumerator = dictionary.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, GClass222> keyValuePair = enumerator.Current;
						if (keyValuePair.Value.List_0.Count<string>() != 0 && !keyValuePair.Value.List_0[0].smethod_9())
						{
							for (int i = 0; i < keyValuePair.Value.List_0.Count; i++)
							{
								try
								{
									Class498.Class239 class2 = new Class498.Class239();
									class2.string_0 = Class298.smethod_2(keyValuePair.Value.List_0[i]);
									if (this.class240_0.list_0.Any(new Func<Class303, bool>(class2.method_0)))
									{
										this.class240_0.list_0.Find(new Predicate<Class303>(class2.method_1)).Services.Add(keyValuePair.Key);
									}
									else
									{
										List<Class303> list_ = this.class240_0.list_0;
										Class303 class3 = new Class303();
										class3.Name = class2.string_0;
										class3.method_1(keyValuePair.Value.List_0[i]);
										class3.Services = new List<string>
										{
											keyValuePair.Key
										};
										class3.method_3(@class.observableCollection_3);
										list_.Add(class3);
									}
								}
								catch (Exception exception_)
								{
									GClass268.smethod_1(exception_);
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
				this.class240_0.list_0 = this.class240_0.list_0.OrderBy(new Func<Class303, string>(Class498.Class241.class241_0.method_2)).ToList<Class303>();
				awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(this.class240_0.method_0)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct116>(ref awaiter, ref this);
					return;
				}
				IL_2BE:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class240_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class240_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0000A5C3 File Offset: 0x000087C3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008E7 RID: 2279
		public int int_0;

		// Token: 0x040008E8 RID: 2280
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040008E9 RID: 2281
		public Class498 class498_0;

		// Token: 0x040008EA RID: 2282
		private Class498.Class240 class240_0;

		// Token: 0x040008EB RID: 2283
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001FE RID: 510
	[StructLayout(LayoutKind.Auto)]
	private struct Struct117 : IAsyncStateMachine
	{
		// Token: 0x06000DE3 RID: 3555 RVA: 0x000501A4 File Offset: 0x0004E3A4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class498 @class = this.class498_0;
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
					goto IL_116;
				}
				IL_56:
				if (@class.AnimationOpacity == 0.0)
				{
					@class.AnimationVisibility = Visibility.Collapsed;
					goto IL_11D;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct117>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_116:
				awaiter.GetResult();
				IL_11D:
				if (@class.MainOpacity != 1.0)
				{
					@class.MainOpacity += 0.13333333333333333;
					if (@class.MainOpacity > 0.95)
					{
						@class.MainOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_116;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class498.Struct117>(ref awaiter, ref this);
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

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0000A5D1 File Offset: 0x000087D1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008EC RID: 2284
		public int int_0;

		// Token: 0x040008ED RID: 2285
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008EE RID: 2286
		public Class498 class498_0;

		// Token: 0x040008EF RID: 2287
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001FF RID: 511
	[Serializable]
	private sealed class Class241
	{
		// Token: 0x06000DE7 RID: 3559 RVA: 0x0000A5EB File Offset: 0x000087EB
		internal bool method_0(Interface8 interface8_0)
		{
			return interface8_0.Possible;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0000A5F3 File Offset: 0x000087F3
		internal bool method_1(Class514 class514_0)
		{
			return class514_0.bool_0;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0000A5FB File Offset: 0x000087FB
		internal string method_2(Class303 class303_0)
		{
			return class303_0.Name;
		}

		// Token: 0x040008F0 RID: 2288
		public static readonly Class498.Class241 class241_0 = new Class498.Class241();

		// Token: 0x040008F1 RID: 2289
		public static Func<Interface8, bool> func_0;

		// Token: 0x040008F2 RID: 2290
		public static Func<Class514, bool> func_1;

		// Token: 0x040008F3 RID: 2291
		public static Func<Class303, string> func_2;
	}
}
