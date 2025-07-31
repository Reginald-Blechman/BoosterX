using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x020003BF RID: 959
internal sealed class Class513 : GClass162
{
	// Token: 0x0600193F RID: 6463 RVA: 0x0006F534 File Offset: 0x0006D734
	public Class513(Class757 class757_1, bool bool_3)
	{
		this.GetFull = bool_3;
		this.StatusOpacity = 0.0;
		this.class757_0 = class757_1;
		this.ToDelete = false;
		this.class802_0 = new Class802();
		this.method_4();
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00011297 File Offset: 0x0000F497
	private MaterialIconKind method_2()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x0001129F File Offset: 0x0000F49F
	private void method_3(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06001942 RID: 6466 RVA: 0x000112A8 File Offset: 0x0000F4A8
	// (set) Token: 0x06001943 RID: 6467 RVA: 0x000112B0 File Offset: 0x0000F4B0
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_2();
		}
		set
		{
			this.method_3(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x0006F588 File Offset: 0x0006D788
	private void method_4()
	{
		Class513.Struct230 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class513_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class513.Struct230>(ref @struct);
	}

	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x06001945 RID: 6469 RVA: 0x000112C5 File Offset: 0x0000F4C5
	// (set) Token: 0x06001946 RID: 6470 RVA: 0x000112CD File Offset: 0x0000F4CD
	public bool GetFull
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06001947 RID: 6471 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public string Name
	{
		get
		{
			return Class298.smethod_2(this.class757_0.String_0);
		}
	}

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x06001948 RID: 6472 RVA: 0x000112E8 File Offset: 0x0000F4E8
	public string Description
	{
		get
		{
			return Class298.smethod_2(this.class757_0.String_1);
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06001949 RID: 6473 RVA: 0x0006F5C0 File Offset: 0x0006D7C0
	internal bool Boolean_0
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "4Ku6#Za-iu", object_);
		}
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x000112FA File Offset: 0x0000F4FA
	internal bool method_5()
	{
		return this.class757_0.Boolean_0;
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x00011307 File Offset: 0x0000F507
	private double method_6()
	{
		return this.double_0;
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x0001130F File Offset: 0x0000F50F
	private void method_7(double double_2)
	{
		this.double_0 = double_2;
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x0600194D RID: 6477 RVA: 0x00011318 File Offset: 0x0000F518
	// (set) Token: 0x0600194E RID: 6478 RVA: 0x00011320 File Offset: 0x0000F520
	public bool ToDelete
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_2 = value;
			this.method_8();
			base.method_0("ToDelete");
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x0600194F RID: 6479 RVA: 0x00011344 File Offset: 0x0000F544
	public Visibility ProVisibility
	{
		get
		{
			if (!this.method_5())
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x0006F5F8 File Offset: 0x0006D7F8
	private void method_8()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Ts1r3Za-j=", object_);
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x0006F628 File Offset: 0x0006D828
	public Task method_9()
	{
		Class513.Struct232 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class513_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class513.Struct232>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00011351 File Offset: 0x0000F551
	private SolidColorBrush method_10()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x00011359 File Offset: 0x0000F559
	private void method_11(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06001954 RID: 6484 RVA: 0x00011362 File Offset: 0x0000F562
	// (set) Token: 0x06001955 RID: 6485 RVA: 0x0001136A File Offset: 0x0000F56A
	public SolidColorBrush StatusForeground
	{
		get
		{
			return this.method_10();
		}
		set
		{
			this.method_11(value);
			base.method_0("StatusForeground");
		}
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x0001137F File Offset: 0x0000F57F
	private double method_12()
	{
		return this.double_1;
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x00011387 File Offset: 0x0000F587
	private void method_13(double double_2)
	{
		this.double_1 = double_2;
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06001958 RID: 6488 RVA: 0x00011390 File Offset: 0x0000F590
	// (set) Token: 0x06001959 RID: 6489 RVA: 0x00011398 File Offset: 0x0000F598
	public double StatusOpacity
	{
		get
		{
			return this.method_12();
		}
		set
		{
			this.method_13(value);
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x000113AD File Offset: 0x0000F5AD
	private string method_14()
	{
		return this.string_0;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x000113B5 File Offset: 0x0000F5B5
	private void method_15(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x0600195C RID: 6492 RVA: 0x000113BE File Offset: 0x0000F5BE
	// (set) Token: 0x0600195D RID: 6493 RVA: 0x000113C6 File Offset: 0x0000F5C6
	public string Status
	{
		get
		{
			return this.method_14();
		}
		set
		{
			this.method_15(value);
			base.method_0("Status");
		}
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x0006F66C File Offset: 0x0006D86C
	public Task method_16(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class513.Struct233 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class513_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class513.Struct233>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x0006F6C0 File Offset: 0x0006D8C0
	private void method_17()
	{
		if (this.class757_0.String_2 != null && this.class757_0.String_2 != string.Empty)
		{
			Class513.Class439 @class = new Class513.Class439();
			@class.string_0 = string.Empty;
			this.class757_0.String_2.Split(new char[]
			{
				'-'
			}).ToList<string>().ForEach(new Action<string>(@class.method_0));
			MaterialIconKind icon;
			if (Enum.TryParse<MaterialIconKind>(@class.string_0, out icon))
			{
				this.Icon = icon;
			}
		}
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x0006F74C File Offset: 0x0006D94C
	private Task method_18()
	{
		Class513.Struct229 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class513_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class513.Struct229>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x000113DB File Offset: 0x0000F5DB
	private Class802 method_19()
	{
		return this.class802_0;
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x000113E3 File Offset: 0x0000F5E3
	private void method_20()
	{
		Class802 @class = this.class802_0;
		if (@class == null)
		{
			return;
		}
		@class.imethod_3(this.class757_0);
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x000113FB File Offset: 0x0000F5FB
	private static void smethod_0(ref Class513.Struct231 struct231_0)
	{
		struct231_0.asyncVoidMethodBuilder_0.Start<Class513.Struct231>(ref struct231_0);
	}

	// Token: 0x040010A2 RID: 4258
	private Class802 class802_0;

	// Token: 0x040010A3 RID: 4259
	private Class757 class757_0;

	// Token: 0x040010A4 RID: 4260
	private MaterialIconKind materialIconKind_0;

	// Token: 0x040010A5 RID: 4261
	private bool bool_0;

	// Token: 0x040010A6 RID: 4262
	private double double_0;

	// Token: 0x040010A7 RID: 4263
	private bool bool_1;

	// Token: 0x040010A8 RID: 4264
	private bool bool_2;

	// Token: 0x040010A9 RID: 4265
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x040010AA RID: 4266
	private double double_1;

	// Token: 0x040010AB RID: 4267
	private string string_0;

	// Token: 0x040010AC RID: 4268
	private CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	// Token: 0x020003C0 RID: 960
	private sealed class Class438
	{
		// Token: 0x06001965 RID: 6501 RVA: 0x0006F790 File Offset: 0x0006D990
		internal Task method_0()
		{
			Class513.Class438.Struct228 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class438_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class513.Class438.Struct228>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040010AD RID: 4269
		public Class513 class513_0;

		// Token: 0x040010AE RID: 4270
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040010AF RID: 4271
		public string string_0;

		// Token: 0x020003C1 RID: 961
		[StructLayout(LayoutKind.Auto)]
		private struct Struct228 : IAsyncStateMachine
		{
			// Token: 0x06001966 RID: 6502 RVA: 0x0006F7D4 File Offset: 0x0006D9D4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class513.Class438 @class = this.class438_0;
				try
				{
					if (num > 1)
					{
						if (!Class406.smethod_0().method_2(typeof(dje_zY8TJ7HVSSL9J9VQH6V7EV8TJKMJV32VYYNUD95ZXTD6G6DK4JKGTBNA9KKRA_ejd)))
						{
							@class.class513_0.method_13(1.0);
							@class.class513_0.method_11(@class.solidColorBrush_0);
							@class.class513_0.method_15(@class.string_0);
							goto IL_272;
						}
						try
						{
							@class.class513_0.cancellationTokenSource_0.Cancel();
							@class.class513_0.cancellationTokenSource_0.Dispose();
						}
						catch
						{
						}
						@class.class513_0.cancellationTokenSource_0 = new CancellationTokenSource();
						this.cancellationToken_0 = @class.class513_0.cancellationTokenSource_0.Token;
					}
					try
					{
						TaskAwaiter awaiter;
						if (num == 0)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
							goto IL_169;
						}
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.int_0 = num3;
							goto IL_1EB;
						}
						IL_FB:
						if (@class.class513_0.StatusOpacity <= 0.0)
						{
							@class.class513_0.StatusForeground = @class.solidColorBrush_0;
							@class.class513_0.Status = @class.string_0;
							goto IL_1F2;
						}
						this.cancellationToken_0.ThrowIfCancellationRequested();
						@class.class513_0.StatusOpacity = Math.Max(0.0, @class.class513_0.StatusOpacity - 0.1);
						awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							num = 0;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Class438.Struct228>(ref awaiter, ref this);
							return;
						}
						IL_169:
						awaiter.GetResult();
						goto IL_FB;
						IL_1EB:
						awaiter.GetResult();
						IL_1F2:
						if (@class.class513_0.StatusOpacity < 1.0)
						{
							this.cancellationToken_0.ThrowIfCancellationRequested();
							@class.class513_0.StatusOpacity = Math.Min(1.0, @class.class513_0.StatusOpacity + 0.13333333333333333);
							awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_1EB;
							}
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Class438.Struct228>(ref awaiter, ref this);
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
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_272:
				this.int_0 = -2;
				this.cancellationToken_0 = default(CancellationToken);
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001967 RID: 6503 RVA: 0x00011409 File Offset: 0x0000F609
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040010B0 RID: 4272
			public int int_0;

			// Token: 0x040010B1 RID: 4273
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040010B2 RID: 4274
			public Class513.Class438 class438_0;

			// Token: 0x040010B3 RID: 4275
			private CancellationToken cancellationToken_0;

			// Token: 0x040010B4 RID: 4276
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020003C2 RID: 962
	[StructLayout(LayoutKind.Auto)]
	private struct Struct229 : IAsyncStateMachine
	{
		// Token: 0x06001968 RID: 6504 RVA: 0x0006FAC0 File Offset: 0x0006DCC0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class513 @class = this.class513_0;
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
					goto IL_2DB;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_300;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_343;
				case 4:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_39E;
				case 5:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_3D4;
				case 6:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_41C;
				default:
					if (!@class.bool_2)
					{
						awaiter = @class.method_16(Class298.smethod_2("Calculating"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct229>(ref awaiter, ref this);
							return;
						}
					}
					else if (@class.Boolean_0)
					{
						if (Class551.class753_0.method_38().GetValueOrDefault() && Class733.smethod_0())
						{
							@class.bool_1 = true;
							awaiter = @class.method_16(Class298.smethod_2("Cleaning"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 3;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct229>(ref awaiter, ref this);
								return;
							}
							goto IL_343;
						}
						else
						{
							awaiter = @class.method_16(Class298.smethod_2("willbecleaned"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 5;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct229>(ref awaiter, ref this);
								return;
							}
							goto IL_3D4;
						}
					}
					else
					{
						awaiter = @class.method_16(Class298.smethod_2("prorequired"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 6;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct229>(ref awaiter, ref this);
							return;
						}
						goto IL_41C;
					}
					break;
				}
				awaiter.GetResult();
				@class.method_7((double)Class765.smethod_13(@class.class757_0.List_0, @class.class757_0.String_3, @class.class757_0.Boolean_1));
				if (@class.method_6() != 0.0)
				{
					awaiter = @class.method_16(Math.Round(Convert.ToDouble(@class.method_6()) / 1024.0 / 1024.0, 2).ToString() + " MB", Brushes.Gray).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct229>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = @class.method_16("0".ToString() + " MB", Brushes.Gray).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct229>(ref awaiter, ref this);
						return;
					}
					goto IL_300;
				}
				IL_2DB:
				awaiter.GetResult();
				goto IL_307;
				IL_300:
				awaiter.GetResult();
				IL_307:
				GClass279.smethod_0().method_15(typeof(Class802), @class.Name);
				goto IL_423;
				IL_343:
				awaiter.GetResult();
				awaiter = @class.method_9().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 4;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct229>(ref awaiter, ref this);
					return;
				}
				IL_39E:
				awaiter.GetResult();
				@class.bool_1 = false;
				@class.ToDelete = false;
				goto IL_43C;
				IL_3D4:
				awaiter.GetResult();
				GClass279.smethod_0().method_9<Class802>(@class.Name, new Func<Class802>(@class.method_19), @class.class757_0);
				goto IL_423;
				IL_41C:
				awaiter.GetResult();
				IL_423:;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_43C:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00011417 File Offset: 0x0000F617
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010B5 RID: 4277
		public int int_0;

		// Token: 0x040010B6 RID: 4278
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040010B7 RID: 4279
		public Class513 class513_0;

		// Token: 0x040010B8 RID: 4280
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003C3 RID: 963
	[StructLayout(LayoutKind.Auto)]
	private struct Struct230 : IAsyncStateMachine
	{
		// Token: 0x0600196A RID: 6506 RVA: 0x0006FF38 File Offset: 0x0006E138
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class513 @object = this.class513_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_17)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct230>(ref awaiter, ref this);
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

		// Token: 0x0600196B RID: 6507 RVA: 0x00011425 File Offset: 0x0000F625
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010B9 RID: 4281
		public int int_0;

		// Token: 0x040010BA RID: 4282
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040010BB RID: 4283
		public Class513 class513_0;

		// Token: 0x040010BC RID: 4284
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003C4 RID: 964
	[StructLayout(LayoutKind.Auto)]
	private struct Struct231 : IAsyncStateMachine
	{
		// Token: 0x0600196C RID: 6508 RVA: 0x0006FFF8 File Offset: 0x0006E1F8
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "Ts1r3Za-j>", array);
			}
			finally
			{
				this = (Class513.Struct231)array[0];
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00011433 File Offset: 0x0000F633
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00011441 File Offset: 0x0000F641
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class513.Struct231 struct231_0)
		{
			struct231_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct231>(ref taskAwaiter_1, ref struct231_0);
		}

		// Token: 0x040010BD RID: 4285
		public int int_0;

		// Token: 0x040010BE RID: 4286
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040010BF RID: 4287
		public Class513 class513_0;

		// Token: 0x040010C0 RID: 4288
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003C5 RID: 965
	[StructLayout(LayoutKind.Auto)]
	private struct Struct232 : IAsyncStateMachine
	{
		// Token: 0x0600196F RID: 6511 RVA: 0x00070060 File Offset: 0x0006E260
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class513 @object = this.class513_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_CD;
					}
					awaiter = Task.Run(new Action(@object.method_20)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct232>(ref awaiter, ref this);
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
				awaiter = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_21().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct232>(ref awaiter, ref this);
					return;
				}
				IL_CD:
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

		// Token: 0x06001970 RID: 6512 RVA: 0x00011450 File Offset: 0x0000F650
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010C1 RID: 4289
		public int int_0;

		// Token: 0x040010C2 RID: 4290
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040010C3 RID: 4291
		public Class513 class513_0;

		// Token: 0x040010C4 RID: 4292
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003C6 RID: 966
	private sealed class Class439
	{
		// Token: 0x06001972 RID: 6514 RVA: 0x0001145E File Offset: 0x0000F65E
		internal void method_0(string string_1)
		{
			this.string_0 += string_1.smethod_4();
		}

		// Token: 0x040010C5 RID: 4293
		public string string_0;
	}

	// Token: 0x020003C7 RID: 967
	[StructLayout(LayoutKind.Auto)]
	private struct Struct233 : IAsyncStateMachine
	{
		// Token: 0x06001973 RID: 6515 RVA: 0x00070180 File Offset: 0x0006E380
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(new Class513.Class438
					{
						class513_0 = this.class513_0,
						solidColorBrush_0 = this.solidColorBrush_0,
						string_0 = this.string_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class513.Struct233>(ref awaiter, ref this);
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

		// Token: 0x06001974 RID: 6516 RVA: 0x00011477 File Offset: 0x0000F677
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010C6 RID: 4294
		public int int_0;

		// Token: 0x040010C7 RID: 4295
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040010C8 RID: 4296
		public Class513 class513_0;

		// Token: 0x040010C9 RID: 4297
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040010CA RID: 4298
		public string string_0;

		// Token: 0x040010CB RID: 4299
		private TaskAwaiter taskAwaiter_0;
	}
}
