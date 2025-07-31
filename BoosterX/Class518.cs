using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x020004C6 RID: 1222
internal sealed class Class518 : GClass162
{
	// Token: 0x06001F47 RID: 8007 RVA: 0x0007F95C File Offset: 0x0007DB5C
	public Class518(Class491 class491_1, string string_6 = null)
	{
		this.class491_0 = class491_1;
		if (!string_6.smethod_9())
		{
			this.AppXProductID = string_6;
			this.method_2();
		}
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x0007F9D4 File Offset: 0x0007DBD4
	private void method_2()
	{
		Class518.Struct319 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class518_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class518.Struct319>(ref @struct);
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x0007FA0C File Offset: 0x0007DC0C
	public void Check()
	{
		Class518.Struct324 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class518_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class518.Struct324>(ref @struct);
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00014BC8 File Offset: 0x00012DC8
	// (set) Token: 0x06001F4B RID: 8011 RVA: 0x00014BD0 File Offset: 0x00012DD0
	public Color DynamicLight
	{
		get
		{
			return this.color_0;
		}
		set
		{
			this.color_0 = value;
			base.method_0("DynamicLight");
		}
	}

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00014BE5 File Offset: 0x00012DE5
	// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00014BED File Offset: 0x00012DED
	public string AppXName
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			this.Check();
			base.method_0("AppXName");
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00014C08 File Offset: 0x00012E08
	// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00014C10 File Offset: 0x00012E10
	public bool IsInstalled
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.method_0("IsInstalled");
		}
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00014C25 File Offset: 0x00012E25
	// (set) Token: 0x06001F51 RID: 8017 RVA: 0x00014C2D File Offset: 0x00012E2D
	public string AppXAverageRating
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("AppXAverageRating");
		}
	}

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00014C42 File Offset: 0x00012E42
	// (set) Token: 0x06001F53 RID: 8019 RVA: 0x00014C4A File Offset: 0x00012E4A
	public string AppXProductID
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("AppXProductID");
		}
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00014C5F File Offset: 0x00012E5F
	// (set) Token: 0x06001F55 RID: 8021 RVA: 0x00014C67 File Offset: 0x00012E67
	public bool AppXIsChecked
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			base.method_0("AppXIsChecked");
			this.method_4(value);
		}
	}

	// Token: 0x17000551 RID: 1361
	// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00014C83 File Offset: 0x00012E83
	public string AppXIconUrl
	{
		set
		{
			this.string_3 = value;
			this.method_3();
		}
	}

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00014C92 File Offset: 0x00012E92
	// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00014C9A File Offset: 0x00012E9A
	public string Information
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("Information");
		}
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x0007FA44 File Offset: 0x0007DC44
	private void method_3()
	{
		Class518.Struct321 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class518_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class518.Struct321>(ref @struct);
	}

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x06001F5A RID: 8026 RVA: 0x00014CAF File Offset: 0x00012EAF
	// (set) Token: 0x06001F5B RID: 8027 RVA: 0x00014CB7 File Offset: 0x00012EB7
	public BitmapSource AppXIcon
	{
		get
		{
			return this.bitmapSource_0;
		}
		set
		{
			this.bitmapSource_0 = value;
			base.method_0("AppXIcon");
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00014CCC File Offset: 0x00012ECC
	// (set) Token: 0x06001F5D RID: 8029 RVA: 0x00014CD4 File Offset: 0x00012ED4
	public BitmapSource AppXIconBlur
	{
		get
		{
			return this.bitmapSource_1;
		}
		set
		{
			this.bitmapSource_1 = value;
			base.method_0("AppXIconBlur");
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06001F5E RID: 8030 RVA: 0x00014CE9 File Offset: 0x00012EE9
	// (set) Token: 0x06001F5F RID: 8031 RVA: 0x00014CF1 File Offset: 0x00012EF1
	public double AppXSize
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("AppXSize");
		}
	}

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00014D06 File Offset: 0x00012F06
	// (set) Token: 0x06001F61 RID: 8033 RVA: 0x00014D0E File Offset: 0x00012F0E
	public double AppXPrice
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("AppXPrice");
		}
	}

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00014D23 File Offset: 0x00012F23
	// (set) Token: 0x06001F63 RID: 8035 RVA: 0x00014D2B File Offset: 0x00012F2B
	public bool IsPaid
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
			base.method_0("IsPaid");
		}
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x0007FA7C File Offset: 0x0007DC7C
	private void method_4(bool bool_4)
	{
		if (!bool_4)
		{
			this.class491_0.AppXsInstallVMs.Remove(this);
			return;
		}
		if (this.class491_0 != null && !this.IsPaid && this.AppXProductID != null)
		{
			this.StatusText = Class298.smethod_2("OnQueue");
			this.StatusColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd;
			this.StatusOpacity = 0.8;
			this.class491_0.AppXsInstallVMs.Add(this);
			return;
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00014D40 File Offset: 0x00012F40
	// (set) Token: 0x06001F66 RID: 8038 RVA: 0x00014D48 File Offset: 0x00012F48
	public string StatusText
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00014D5D File Offset: 0x00012F5D
	// (set) Token: 0x06001F68 RID: 8040 RVA: 0x00014D65 File Offset: 0x00012F65
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

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00014D7A File Offset: 0x00012F7A
	// (set) Token: 0x06001F6A RID: 8042 RVA: 0x00014D82 File Offset: 0x00012F82
	public double StatusOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x0007FAF4 File Offset: 0x0007DCF4
	public void method_5(string string_6, SolidColorBrush solidColorBrush_1)
	{
		Class518.Struct322 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class518_0 = this;
		@struct.string_0 = string_6;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class518.Struct322>(ref @struct);
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x0007FB3C File Offset: 0x0007DD3C
	private Task method_6()
	{
		Class518.Struct320 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class518_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class518.Struct320>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x0007FB80 File Offset: 0x0007DD80
	private Task method_7()
	{
		Class518.Struct317 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class518_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class518.Struct317>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x0007FBC4 File Offset: 0x0007DDC4
	private void method_8()
	{
		this.IsInstalled = Class620.smethod_0().method_1(this.AppXName, true);
		if (this.IsInstalled)
		{
			this.Information = Class298.smethod_2("Installed");
		}
		this.IsPaid = (this.AppXPrice > 0.0);
		if (this.IsPaid)
		{
			this.Information = Class298.smethod_2("Unavailable");
			return;
		}
		if (this.AppXSize > 0.0 && this.Information.smethod_9())
		{
			this.Information = Math.Round(this.AppXSize / 1024.0 / 1024.0, 2).ToString() + " MB";
		}
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x0007FC8C File Offset: 0x0007DE8C
	private Task method_9()
	{
		Class518.Struct323 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class518_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class518.Struct323>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x040014CB RID: 5323
	private GClass225 gclass225_0;

	// Token: 0x040014CC RID: 5324
	private Class491 class491_0;

	// Token: 0x040014CD RID: 5325
	public bool bool_0;

	// Token: 0x040014CE RID: 5326
	private Color color_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z9MZATB4TWME8U7MP7WHN2_ejd;

	// Token: 0x040014CF RID: 5327
	private string string_0 = Class298.smethod_2("Loading");

	// Token: 0x040014D0 RID: 5328
	private bool bool_1;

	// Token: 0x040014D1 RID: 5329
	private string string_1;

	// Token: 0x040014D2 RID: 5330
	private string string_2;

	// Token: 0x040014D3 RID: 5331
	private bool bool_2;

	// Token: 0x040014D4 RID: 5332
	private string string_3;

	// Token: 0x040014D5 RID: 5333
	public string string_4;

	// Token: 0x040014D6 RID: 5334
	private BitmapSource bitmapSource_0;

	// Token: 0x040014D7 RID: 5335
	private BitmapSource bitmapSource_1;

	// Token: 0x040014D8 RID: 5336
	private double double_0;

	// Token: 0x040014D9 RID: 5337
	private double double_1;

	// Token: 0x040014DA RID: 5338
	private bool bool_3;

	// Token: 0x040014DB RID: 5339
	private string string_5 = Class298.smethod_2("OnQueue");

	// Token: 0x040014DC RID: 5340
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd;

	// Token: 0x040014DD RID: 5341
	private double double_2 = 0.8;

	// Token: 0x020004C7 RID: 1223
	[StructLayout(LayoutKind.Auto)]
	private struct Struct317 : IAsyncStateMachine
	{
		// Token: 0x06001F70 RID: 8048 RVA: 0x0007FCD0 File Offset: 0x0007DED0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class518 @class = this.class518_0;
			try
			{
				if (num != 0)
				{
				}
				try
				{
					TaskAwaiter<GClass92> awaiter;
					if (num != 0)
					{
						awaiter = @class.gclass225_0.method_2(@class.AppXProductID).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass92>, Class518.Struct317>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass92>);
						this.int_0 = -1;
					}
					GClass92 result = awaiter.GetResult();
					@class.AppXSize = (double)result.Int64_0;
					@class.AppXPrice = (double)result.Int64_1;
				}
				catch
				{
				}
				Application.Current.Dispatcher.Invoke(new Action(@class.method_8));
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

		// Token: 0x06001F71 RID: 8049 RVA: 0x00014D97 File Offset: 0x00012F97
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014DE RID: 5342
		public int int_0;

		// Token: 0x040014DF RID: 5343
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040014E0 RID: 5344
		public Class518 class518_0;

		// Token: 0x040014E1 RID: 5345
		private TaskAwaiter<GClass92> taskAwaiter_0;
	}

	// Token: 0x020004C8 RID: 1224
	private sealed class Class581
	{
		// Token: 0x06001F73 RID: 8051 RVA: 0x0007FDE0 File Offset: 0x0007DFE0
		internal Task method_0()
		{
			Class518.Class581.Struct318 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class581_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class518.Class581.Struct318>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040014E2 RID: 5346
		public Class518 class518_0;

		// Token: 0x040014E3 RID: 5347
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040014E4 RID: 5348
		public string string_0;

		// Token: 0x020004C9 RID: 1225
		[StructLayout(LayoutKind.Auto)]
		private struct Struct318 : IAsyncStateMachine
		{
			// Token: 0x06001F74 RID: 8052 RVA: 0x0007FE24 File Offset: 0x0007E024
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class518.Class581 @class = this.class581_0;
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
					if (@class.class518_0.StatusOpacity == 0.0)
					{
						@class.class518_0.StatusColor = @class.solidColorBrush_0;
						@class.class518_0.StatusText = @class.string_0;
						goto IL_168;
					}
					@class.class518_0.StatusOpacity = @class.class518_0.StatusOpacity - 0.1;
					if (@class.class518_0.StatusOpacity < 0.05)
					{
						@class.class518_0.StatusOpacity = 0.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class518.Class581.Struct318>(ref awaiter, ref this);
						return;
					}
					IL_D1:
					awaiter.GetResult();
					goto IL_56;
					IL_161:
					awaiter.GetResult();
					IL_168:
					if (@class.class518_0.StatusOpacity != 1.0)
					{
						@class.class518_0.StatusOpacity = @class.class518_0.StatusOpacity + 0.13333333333333333;
						if (@class.class518_0.StatusOpacity > 0.95)
						{
							@class.class518_0.StatusOpacity = 1.0;
						}
						awaiter = Task.Delay(10).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_161;
						}
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class518.Class581.Struct318>(ref awaiter, ref this);
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

			// Token: 0x06001F75 RID: 8053 RVA: 0x00014DA5 File Offset: 0x00012FA5
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040014E5 RID: 5349
			public int int_0;

			// Token: 0x040014E6 RID: 5350
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040014E7 RID: 5351
			public Class518.Class581 class581_0;

			// Token: 0x040014E8 RID: 5352
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020004CA RID: 1226
	[StructLayout(LayoutKind.Auto)]
	private struct Struct319 : IAsyncStateMachine
	{
		// Token: 0x06001F76 RID: 8054 RVA: 0x00080038 File Offset: 0x0007E238
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class518 @object = this.class518_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_6)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class518.Struct319>(ref awaiter, ref this);
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

		// Token: 0x06001F77 RID: 8055 RVA: 0x00014DB3 File Offset: 0x00012FB3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014E9 RID: 5353
		public int int_0;

		// Token: 0x040014EA RID: 5354
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014EB RID: 5355
		public Class518 class518_0;

		// Token: 0x040014EC RID: 5356
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004CB RID: 1227
	private sealed class Class582
	{
		// Token: 0x06001F79 RID: 8057 RVA: 0x00014DC1 File Offset: 0x00012FC1
		internal void method_0()
		{
			this.class518_0.AppXIcon = this.bitmapImage_0;
			this.class518_0.AppXIconBlur = this.bitmapImage_1;
		}

		// Token: 0x040014ED RID: 5357
		public BitmapImage bitmapImage_0;

		// Token: 0x040014EE RID: 5358
		public BitmapImage bitmapImage_1;

		// Token: 0x040014EF RID: 5359
		public Class518 class518_0;
	}

	// Token: 0x020004CC RID: 1228
	[StructLayout(LayoutKind.Auto)]
	private struct Struct320 : IAsyncStateMachine
	{
		// Token: 0x06001F7A RID: 8058 RVA: 0x000800F8 File Offset: 0x0007E2F8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class518 @class = this.class518_0;
			try
			{
				try
				{
					TaskAwaiter<GClass42> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<GClass42>);
							this.int_0 = -1;
							goto IL_12F;
						}
						this.class583_0 = new Class518.Class583();
						this.class583_0.class518_0 = @class;
						if (@class.gclass225_0 == null)
						{
							@class.gclass225_0 = Class626.smethod_0();
						}
						awaiter = @class.gclass225_0.method_1(@class.AppXProductID, (GEnum9)0, null).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass42>, Class518.Struct320>(ref awaiter, ref this);
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
					this.class583_0.gclass42_0 = result;
					if (this.class583_0.gclass42_0.Int32_0 != 0)
					{
						goto IL_143;
					}
					awaiter = @class.gclass225_0.method_1(@class.AppXProductID, (GEnum9)0, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass42>, Class518.Struct320>(ref awaiter, ref this);
						return;
					}
					IL_12F:
					result = awaiter.GetResult();
					this.class583_0.gclass42_0 = result;
					IL_143:
					Class518 class2 = @class;
					List<GClass108> list_ = this.class583_0.gclass42_0.GClass197_0.List_0;
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
					class2.AppXName = appXName;
					Application.Current.Dispatcher.Invoke(new Action(this.class583_0.method_0));
					this.class583_0 = null;
				}
				catch
				{
					@class.AppXAverageRating = "-";
				}
				Class626.list_0.Add(@class);
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

		// Token: 0x06001F7B RID: 8059 RVA: 0x00014DE5 File Offset: 0x00012FE5
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014F0 RID: 5360
		public int int_0;

		// Token: 0x040014F1 RID: 5361
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040014F2 RID: 5362
		public Class518 class518_0;

		// Token: 0x040014F3 RID: 5363
		private Class518.Class583 class583_0;

		// Token: 0x040014F4 RID: 5364
		private TaskAwaiter<GClass42> taskAwaiter_0;
	}

	// Token: 0x020004CD RID: 1229
	[StructLayout(LayoutKind.Auto)]
	private struct Struct321 : IAsyncStateMachine
	{
		// Token: 0x06001F7C RID: 8060 RVA: 0x00080324 File Offset: 0x0007E524
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class518 @object = this.class518_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_9)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class518.Struct321>(ref awaiter, ref this);
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

		// Token: 0x06001F7D RID: 8061 RVA: 0x00014DF3 File Offset: 0x00012FF3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014F5 RID: 5365
		public int int_0;

		// Token: 0x040014F6 RID: 5366
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014F7 RID: 5367
		public Class518 class518_0;

		// Token: 0x040014F8 RID: 5368
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004CE RID: 1230
	private sealed class Class583
	{
		// Token: 0x06001F7F RID: 8063 RVA: 0x000803E4 File Offset: 0x0007E5E4
		internal void method_0()
		{
			string appXIconUrl = string.Empty;
			List<GClass108> list_ = this.gclass42_0.GClass197_0.List_0;
			bool flag;
			if (list_ == null)
			{
				flag = false;
			}
			else
			{
				flag = !list_[0].List_1.Any(new Func<GClass294, bool>(Class518.Class584.class584_0.method_0));
			}
			if (flag)
			{
				string str = "https:";
				List<GClass108> list_2 = this.gclass42_0.GClass197_0.List_0;
				string str2;
				if (list_2 == null)
				{
					str2 = null;
				}
				else
				{
					GClass108 gclass = list_2[0];
					if (gclass == null)
					{
						str2 = null;
					}
					else
					{
						List<GClass294> list_3 = gclass.List_1;
						if (list_3 == null)
						{
							str2 = null;
						}
						else
						{
							GClass294 gclass2 = list_3[0];
							str2 = ((gclass2 != null) ? gclass2.String_6 : null);
						}
					}
				}
				appXIconUrl = str + str2;
			}
			else
			{
				List<GClass108> list_4 = this.gclass42_0.GClass197_0.List_0;
				List<GClass294> list;
				if (list_4 == null)
				{
					list = null;
				}
				else
				{
					GClass108 gclass3 = list_4[0];
					list = ((gclass3 != null) ? gclass3.List_1 : null);
				}
				foreach (GClass294 gclass4 in list)
				{
					long num = 0L;
					if (gclass4.String_4 == "Logo" && gclass4.Width > num)
					{
						num = gclass4.Width;
						appXIconUrl = "https:" + gclass4.String_6;
					}
				}
			}
			this.class518_0.AppXIconUrl = appXIconUrl;
			this.class518_0.AppXAverageRating = this.gclass42_0.GClass197_0.List_1[0].List_2[2].Double_0.ToString();
		}

		// Token: 0x040014F9 RID: 5369
		public GClass42 gclass42_0;

		// Token: 0x040014FA RID: 5370
		public Class518 class518_0;
	}

	// Token: 0x020004CF RID: 1231
	[StructLayout(LayoutKind.Auto)]
	private struct Struct322 : IAsyncStateMachine
	{
		// Token: 0x06001F80 RID: 8064 RVA: 0x00080580 File Offset: 0x0007E780
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter<Task> awaiter;
				if (num != 0)
				{
					Class518.Class581 @class = new Class518.Class581();
					@class.class518_0 = this.class518_0;
					@class.solidColorBrush_0 = this.solidColorBrush_0;
					@class.string_0 = this.string_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<Task>(new Func<Task>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class518.Struct322>(ref awaiter, ref this);
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

		// Token: 0x06001F81 RID: 8065 RVA: 0x00014E01 File Offset: 0x00013001
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040014FB RID: 5371
		public int int_0;

		// Token: 0x040014FC RID: 5372
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040014FD RID: 5373
		public Class518 class518_0;

		// Token: 0x040014FE RID: 5374
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040014FF RID: 5375
		public string string_0;

		// Token: 0x04001500 RID: 5376
		private TaskAwaiter<Task> taskAwaiter_0;
	}

	// Token: 0x020004D0 RID: 1232
	[StructLayout(LayoutKind.Auto)]
	private struct Struct323 : IAsyncStateMachine
	{
		// Token: 0x06001F82 RID: 8066 RVA: 0x0008066C File Offset: 0x0007E86C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class518 @class = this.class518_0;
			try
			{
				TaskAwaiter<BitmapImage> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<BitmapImage>);
						this.int_0 = -1;
						goto IL_FB;
					}
					this.class582_0 = new Class518.Class582();
					this.class582_0.class518_0 = @class;
					awaiter = Class330.smethod_2(@class.string_3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapImage>, Class518.Struct323>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<BitmapImage>);
					this.int_0 = -1;
				}
				BitmapImage result = awaiter.GetResult();
				this.class582_0.bitmapImage_0 = result;
				awaiter = Class371.smethod_4(this.class582_0.bitmapImage_0, 40, 100, 0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapImage>, Class518.Struct323>(ref awaiter, ref this);
					return;
				}
				IL_FB:
				result = awaiter.GetResult();
				this.class582_0.bitmapImage_1 = result;
				Application.Current.Dispatcher.Invoke(new Action(this.class582_0.method_0));
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class582_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class582_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00014E0F File Offset: 0x0001300F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001501 RID: 5377
		public int int_0;

		// Token: 0x04001502 RID: 5378
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001503 RID: 5379
		public Class518 class518_0;

		// Token: 0x04001504 RID: 5380
		private Class518.Class582 class582_0;

		// Token: 0x04001505 RID: 5381
		private TaskAwaiter<BitmapImage> taskAwaiter_0;
	}

	// Token: 0x020004D1 RID: 1233
	[StructLayout(LayoutKind.Auto)]
	private struct Struct324 : IAsyncStateMachine
	{
		// Token: 0x06001F84 RID: 8068 RVA: 0x00080800 File Offset: 0x0007EA00
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class518 @object = this.class518_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_7)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class518.Struct324>(ref awaiter, ref this);
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

		// Token: 0x06001F85 RID: 8069 RVA: 0x00014E1D File Offset: 0x0001301D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001506 RID: 5382
		public int int_0;

		// Token: 0x04001507 RID: 5383
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001508 RID: 5384
		public Class518 class518_0;

		// Token: 0x04001509 RID: 5385
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004D2 RID: 1234
	[Serializable]
	private sealed class Class584
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x00014E37 File Offset: 0x00013037
		internal bool method_0(GClass294 gclass294_0)
		{
			return gclass294_0.String_4 == "Logo";
		}

		// Token: 0x0400150A RID: 5386
		public static readonly Class518.Class584 class584_0 = new Class518.Class584();

		// Token: 0x0400150B RID: 5387
		public static Func<GClass294, bool> func_0;
	}
}
