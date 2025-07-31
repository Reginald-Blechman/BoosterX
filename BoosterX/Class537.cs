using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x020006EA RID: 1770
internal sealed class Class537 : GClass162, Interface8
{
	// Token: 0x06002C5A RID: 11354 RVA: 0x0001C873 File Offset: 0x0001AA73
	public Class537(Class303 class303_1)
	{
		this.class303_0 = class303_1;
	}

	// Token: 0x17000749 RID: 1865
	// (get) Token: 0x06002C5B RID: 11355 RVA: 0x0001C8A3 File Offset: 0x0001AAA3
	public bool Possible
	{
		get
		{
			if (this.nullable_0 == null)
			{
				this.method_2();
			}
			return this.nullable_0.GetValueOrDefault();
		}
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x000AA0F0 File Offset: 0x000A82F0
	public void method_2()
	{
		Class537.Struct473 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class537_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class537.Struct473>(ref @struct);
	}

	// Token: 0x1700074A RID: 1866
	// (get) Token: 0x06002C5D RID: 11357 RVA: 0x0001C8C3 File Offset: 0x0001AAC3
	// (set) Token: 0x06002C5E RID: 11358 RVA: 0x0001C8CB File Offset: 0x0001AACB
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

	// Token: 0x1700074B RID: 1867
	// (get) Token: 0x06002C5F RID: 11359 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
	// (set) Token: 0x06002C60 RID: 11360 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
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

	// Token: 0x1700074C RID: 1868
	// (get) Token: 0x06002C61 RID: 11361 RVA: 0x0001C8FD File Offset: 0x0001AAFD
	// (set) Token: 0x06002C62 RID: 11362 RVA: 0x0001C905 File Offset: 0x0001AB05
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

	// Token: 0x06002C63 RID: 11363 RVA: 0x000AA128 File Offset: 0x000A8328
	public void method_3(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class537.Struct474 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class537_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class537.Struct474>(ref @struct);
	}

	// Token: 0x1700074D RID: 1869
	// (get) Token: 0x06002C64 RID: 11364 RVA: 0x0001C91A File Offset: 0x0001AB1A
	public string Name
	{
		get
		{
			return this.class303_0.Name;
		}
	}

	// Token: 0x1700074E RID: 1870
	// (get) Token: 0x06002C65 RID: 11365 RVA: 0x0001C927 File Offset: 0x0001AB27
	public string NameEng
	{
		get
		{
			return this.class303_0.method_0();
		}
	}

	// Token: 0x1700074F RID: 1871
	// (get) Token: 0x06002C66 RID: 11366 RVA: 0x0001C934 File Offset: 0x0001AB34
	public string SearchInfo
	{
		get
		{
			return string.Join(", ", this.class303_0.Services);
		}
	}

	// Token: 0x17000750 RID: 1872
	// (get) Token: 0x06002C67 RID: 11367 RVA: 0x0001C94C File Offset: 0x0001AB4C
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_4();
		}
	}

	// Token: 0x17000751 RID: 1873
	// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0001C954 File Offset: 0x0001AB54
	// (set) Token: 0x06002C69 RID: 11369 RVA: 0x0001C95C File Offset: 0x0001AB5C
	public Visibility Visibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("Visibility");
		}
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x000AA170 File Offset: 0x000A8370
	private MaterialIconKind method_4()
	{
		MaterialIconKind materialIconKind = Class330.smethod_3(this.class303_0.method_0());
		if (materialIconKind == null)
		{
			return 2015;
		}
		return materialIconKind;
	}

	// Token: 0x17000752 RID: 1874
	// (get) Token: 0x06002C6B RID: 11371 RVA: 0x0001C971 File Offset: 0x0001AB71
	public string Description
	{
		get
		{
			return Class298.smethod_2("NextServicesWillBeSetToDefault") + "\n" + string.Join(", ", this.class303_0.Services);
		}
	}

	// Token: 0x17000753 RID: 1875
	// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000AA198 File Offset: 0x000A8398
	public GClass280 RunFix
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_7), null));
			}
			return result;
		}
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
	private void method_5()
	{
		this.class303_0.Services.ForEach(new Action<string>(this.method_6));
		base.method_0("Possible");
	}

	// Token: 0x06002C6E RID: 11374 RVA: 0x000AA1CC File Offset: 0x000A83CC
	private void method_6(string string_1)
	{
		Class537.Class862 @class = new Class537.Class862();
		@class.class537_0 = this;
		@class.string_0 = string_1;
		this.class303_0.method_2().smethod_0(new Action<GClass184>(@class.method_0));
	}

	// Token: 0x06002C6F RID: 11375 RVA: 0x000AA20C File Offset: 0x000A840C
	private void method_7(object object_0)
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		this.method_3(Class298.smethod_2("Fixing"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
		this.class303_0.Services.ForEach(new Action<string>(this.method_8));
		this.method_3(Class298.smethod_2("FixedRestartPlease"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
		this.bool_0 = false;
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x000AA278 File Offset: 0x000A8478
	private void method_8(string string_1)
	{
		Class537.Class860 @class = new Class537.Class860();
		@class.string_0 = string_1;
		this.class303_0.method_2().smethod_0(new Action<GClass184>(@class.method_0));
	}

	// Token: 0x04001CCA RID: 7370
	private Class303 class303_0;

	// Token: 0x04001CCB RID: 7371
	private bool? nullable_0;

	// Token: 0x04001CCC RID: 7372
	private string string_0 = string.Empty;

	// Token: 0x04001CCD RID: 7373
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04001CCE RID: 7374
	private double double_0;

	// Token: 0x04001CCF RID: 7375
	private CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	// Token: 0x04001CD0 RID: 7376
	private Visibility visibility_0;

	// Token: 0x04001CD1 RID: 7377
	public bool bool_0;

	// Token: 0x04001CD2 RID: 7378
	private GClass280 gclass280_0;

	// Token: 0x020006EB RID: 1771
	[StructLayout(LayoutKind.Auto)]
	private struct Struct473 : IAsyncStateMachine
	{
		// Token: 0x06002C71 RID: 11377 RVA: 0x000AA2B0 File Offset: 0x000A84B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class537 @object = this.class537_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class537.Struct473>(ref awaiter, ref this);
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

		// Token: 0x06002C72 RID: 11378 RVA: 0x0001C9CE File Offset: 0x0001ABCE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CD3 RID: 7379
		public int int_0;

		// Token: 0x04001CD4 RID: 7380
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001CD5 RID: 7381
		public Class537 class537_0;

		// Token: 0x04001CD6 RID: 7382
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006EC RID: 1772
	[StructLayout(LayoutKind.Auto)]
	private struct Struct474 : IAsyncStateMachine
	{
		// Token: 0x06002C73 RID: 11379 RVA: 0x000AA370 File Offset: 0x000A8570
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class537 @class = this.class537_0;
			try
			{
				if (num > 1)
				{
					@class.cancellationTokenSource_0.Cancel();
					@class.cancellationTokenSource_0.Dispose();
					@class.cancellationTokenSource_0 = new CancellationTokenSource();
					this.cancellationToken_0 = @class.cancellationTokenSource_0.Token;
				}
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_EC;
					}
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_15A;
					}
					IL_8D:
					if (@class.StatusOpacity <= 0.0)
					{
						@class.StatusColor = this.solidColorBrush_0;
						@class.StatusText = this.string_0;
						goto IL_161;
					}
					this.cancellationToken_0.ThrowIfCancellationRequested();
					@class.StatusOpacity = Math.Max(0.0, @class.StatusOpacity - 0.1);
					awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class537.Struct474>(ref awaiter, ref this);
						return;
					}
					IL_EC:
					awaiter.GetResult();
					goto IL_8D;
					IL_15A:
					awaiter.GetResult();
					IL_161:
					if (@class.StatusOpacity < 1.0)
					{
						this.cancellationToken_0.ThrowIfCancellationRequested();
						@class.StatusOpacity = Math.Min(1.0, @class.StatusOpacity + 0.13333333333333333);
						awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_15A;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class537.Struct474>(ref awaiter, ref this);
						return;
					}
				}
				catch
				{
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.cancellationToken_0 = default(CancellationToken);
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.cancellationToken_0 = default(CancellationToken);
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x0001C9DC File Offset: 0x0001ABDC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CD7 RID: 7383
		public int int_0;

		// Token: 0x04001CD8 RID: 7384
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001CD9 RID: 7385
		public Class537 class537_0;

		// Token: 0x04001CDA RID: 7386
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001CDB RID: 7387
		public string string_0;

		// Token: 0x04001CDC RID: 7388
		private CancellationToken cancellationToken_0;

		// Token: 0x04001CDD RID: 7389
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006ED RID: 1773
	private sealed class Class860
	{
		// Token: 0x06002C76 RID: 11382 RVA: 0x000AA5AC File Offset: 0x000A87AC
		internal void method_0(GClass184 gclass184_0)
		{
			Class537.Class860.Struct475 @struct;
			@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@struct.class860_0 = this;
			@struct.gclass184_0 = gclass184_0;
			@struct.int_0 = -1;
			@struct.asyncVoidMethodBuilder_0.Start<Class537.Class860.Struct475>(ref @struct);
		}

		// Token: 0x04001CDE RID: 7390
		public string string_0;

		// Token: 0x020006EE RID: 1774
		[StructLayout(LayoutKind.Auto)]
		private struct Struct475 : IAsyncStateMachine
		{
			// Token: 0x06002C77 RID: 11383 RVA: 0x000AA5EC File Offset: 0x000A87EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class537.Class860 @class = this.class860_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						Class537.Class861 class2 = new Class537.Class861();
						class2.gclass184_0 = this.gclass184_0;
						if (!(GClass219.smethod_18(class2.gclass184_0.WinServiceViewModel.Service.ServiceName).ToLower() == @class.string_0.ToLower()))
						{
							goto IL_BA;
						}
						awaiter = Task.Run(new Action(class2.method_0)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class537.Class860.Struct475>(ref awaiter, ref this);
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
					IL_BA:;
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

			// Token: 0x06002C78 RID: 11384 RVA: 0x0001C9EA File Offset: 0x0001ABEA
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001CDF RID: 7391
			public int int_0;

			// Token: 0x04001CE0 RID: 7392
			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			// Token: 0x04001CE1 RID: 7393
			public GClass184 gclass184_0;

			// Token: 0x04001CE2 RID: 7394
			public Class537.Class860 class860_0;

			// Token: 0x04001CE3 RID: 7395
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020006EF RID: 1775
	private sealed class Class861
	{
		// Token: 0x06002C7A RID: 11386 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		internal void method_0()
		{
			GClass219.smethod_21(this.gclass184_0.WinServiceViewModel);
		}

		// Token: 0x04001CE4 RID: 7396
		public GClass184 gclass184_0;
	}

	// Token: 0x020006F0 RID: 1776
	private sealed class Class862
	{
		// Token: 0x06002C7C RID: 11388 RVA: 0x000AA6F4 File Offset: 0x000A88F4
		internal void method_0(GClass184 gclass184_0)
		{
			if (GClass219.smethod_18(gclass184_0.WinServiceViewModel.Service.ServiceName).ToLower() == this.string_0.ToLower())
			{
				this.class537_0.nullable_0 = new bool?(gclass184_0.WinServiceViewModel.Service.CurrentStartMode == ServiceStartMode.Disabled);
			}
		}

		// Token: 0x04001CE5 RID: 7397
		public string string_0;

		// Token: 0x04001CE6 RID: 7398
		public Class537 class537_0;
	}
}
