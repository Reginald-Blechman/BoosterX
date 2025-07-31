using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x0200063D RID: 1597
internal sealed class Class528 : GClass162
{
	// Token: 0x0600287A RID: 10362 RVA: 0x0001AB62 File Offset: 0x00018D62
	public Class528(GClass8 gclass8_1)
	{
		Class528.smethod_0(ref this.cancellationTokenSource_0);
		base..ctor();
		this.method_17(gclass8_1);
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x0600287B RID: 10363 RVA: 0x0001AB7C File Offset: 0x00018D7C
	public string Name
	{
		get
		{
			return this.gclass8_0.Name;
		}
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x0600287C RID: 10364 RVA: 0x0001AB89 File Offset: 0x00018D89
	public string Id
	{
		get
		{
			return this.gclass8_0.method_0();
		}
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x0600287D RID: 10365 RVA: 0x0001AB96 File Offset: 0x00018D96
	public BitmapSource Icon
	{
		get
		{
			return GClass275.smethod_0(this.gclass8_0.method_4());
		}
	}

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x0600287E RID: 10366 RVA: 0x0009E410 File Offset: 0x0009C610
	public string Description
	{
		get
		{
			return string.Concat(new string[]
			{
				Class298.smethod_2("RemoveDisconnectedDevices"),
				"\r\n\r\nID: ",
				this.gclass8_0.method_0(),
				"\r\n",
				Class298.smethod_2("Name"),
				": ",
				this.gclass8_0.Name,
				"\r\n",
				Class298.smethod_2("Driver"),
				": ",
				this.gclass8_0.method_8(),
				"\r\n",
				Class298.smethod_2("Status"),
				": ",
				this.gclass8_0.Status
			});
		}
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x0001ABA8 File Offset: 0x00018DA8
	private bool method_2()
	{
		return this.bool_0;
	}

	// Token: 0x06002880 RID: 10368 RVA: 0x0001ABB0 File Offset: 0x00018DB0
	private void method_3(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x06002881 RID: 10369 RVA: 0x0001ABB9 File Offset: 0x00018DB9
	// (set) Token: 0x06002882 RID: 10370 RVA: 0x0001ABC1 File Offset: 0x00018DC1
	public bool ToDelete
	{
		get
		{
			return this.method_2();
		}
		set
		{
			if (this.bool_1)
			{
				return;
			}
			this.method_3(value);
			this.method_4();
			base.method_0("ToDelete");
		}
	}

	// Token: 0x06002883 RID: 10371 RVA: 0x0009E4E0 File Offset: 0x0009C6E0
	private void method_4()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "'>Cl]Za-jh", object_);
	}

	// Token: 0x06002884 RID: 10372 RVA: 0x0009E510 File Offset: 0x0009C710
	public Task method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "TY@h@Za-jO", object_);
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x0001ABE5 File Offset: 0x00018DE5
	private SolidColorBrush method_6()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x06002886 RID: 10374 RVA: 0x0001ABED File Offset: 0x00018DED
	private void method_7(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06002887 RID: 10375 RVA: 0x0001ABF6 File Offset: 0x00018DF6
	// (set) Token: 0x06002888 RID: 10376 RVA: 0x0001ABFE File Offset: 0x00018DFE
	public SolidColorBrush StatusForeground
	{
		get
		{
			return this.method_6();
		}
		set
		{
			this.method_7(value);
			base.method_0("StatusForeground");
		}
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x0001AC13 File Offset: 0x00018E13
	private double method_8()
	{
		return this.double_0;
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x0001AC1B File Offset: 0x00018E1B
	private void method_9(double double_1)
	{
		this.double_0 = double_1;
	}

	// Token: 0x170006C9 RID: 1737
	// (get) Token: 0x0600288B RID: 10379 RVA: 0x0001AC24 File Offset: 0x00018E24
	// (set) Token: 0x0600288C RID: 10380 RVA: 0x0001AC2C File Offset: 0x00018E2C
	public double StatusOpacity
	{
		get
		{
			return this.method_8();
		}
		set
		{
			this.method_9(value);
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x0001AC41 File Offset: 0x00018E41
	private string method_10()
	{
		return this.string_0;
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x0001AC49 File Offset: 0x00018E49
	private void method_11(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x170006CA RID: 1738
	// (get) Token: 0x0600288F RID: 10383 RVA: 0x0001AC52 File Offset: 0x00018E52
	// (set) Token: 0x06002890 RID: 10384 RVA: 0x0001AC5A File Offset: 0x00018E5A
	public string Status
	{
		get
		{
			return this.method_10();
		}
		set
		{
			this.method_11(value);
			base.method_0("Status");
		}
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x0009E544 File Offset: 0x0009C744
	public Task method_12(string string_1, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_1,
			solidColorBrush_1
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "rP#\\HZa-j\\", object_);
	}

	// Token: 0x06002892 RID: 10386 RVA: 0x0009E580 File Offset: 0x0009C780
	private Task method_13()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "beCKlZa-jS", object_);
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x0009E5B4 File Offset: 0x0009C7B4
	private void method_14()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "4he>2Za-jl", object_);
	}

	// Token: 0x06002894 RID: 10388 RVA: 0x0009E5E4 File Offset: 0x0009C7E4
	private Class802 method_15()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class802)Class392.smethod_3().method_105(Class392.smethod_1(), "T>%_?Za-hj", object_);
	}

	// Token: 0x06002895 RID: 10389 RVA: 0x0009E618 File Offset: 0x0009C818
	private void method_16()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), ";80HFZa-jl", object_);
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x0009E648 File Offset: 0x0009C848
	private static void smethod_0(ref CancellationTokenSource cancellationTokenSource_1)
	{
		object[] array = new object[]
		{
			cancellationTokenSource_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "d_<,rZa-je", array);
		}
		finally
		{
			cancellationTokenSource_1 = (CancellationTokenSource)array[0];
		}
	}

	// Token: 0x06002897 RID: 10391 RVA: 0x0009E6A4 File Offset: 0x0009C8A4
	private void method_17(GClass8 gclass8_1)
	{
		object[] object_ = new object[]
		{
			this,
			gclass8_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "-,-doZa-jf", object_);
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x0001AC6F File Offset: 0x00018E6F
	private static void smethod_1(ref Class528.Struct432 struct432_0)
	{
		struct432_0.asyncVoidMethodBuilder_0.Start<Class528.Struct432>(ref struct432_0);
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x0001AC7D File Offset: 0x00018E7D
	private static void smethod_2(ref Class528.Struct430 struct430_0)
	{
		struct430_0.asyncTaskMethodBuilder_0.Start<Class528.Struct430>(ref struct430_0);
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x0001AC8B File Offset: 0x00018E8B
	private static void smethod_3(ref Class528.Struct433 struct433_0)
	{
		struct433_0.asyncTaskMethodBuilder_0.Start<Class528.Struct433>(ref struct433_0);
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x0001AC99 File Offset: 0x00018E99
	private static void smethod_4(ref Class528.Struct434 struct434_0)
	{
		struct434_0.asyncTaskMethodBuilder_0.Start<Class528.Struct434>(ref struct434_0);
	}

	// Token: 0x04001A9F RID: 6815
	private GClass8 gclass8_0;

	// Token: 0x04001AA0 RID: 6816
	private Class802 class802_0;

	// Token: 0x04001AA1 RID: 6817
	private bool bool_0;

	// Token: 0x04001AA2 RID: 6818
	private bool bool_1;

	// Token: 0x04001AA3 RID: 6819
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04001AA4 RID: 6820
	private double double_0;

	// Token: 0x04001AA5 RID: 6821
	private string string_0;

	// Token: 0x04001AA6 RID: 6822
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0200063E RID: 1598
	[StructLayout(LayoutKind.Auto)]
	private struct Struct430 : IAsyncStateMachine
	{
		// Token: 0x0600289C RID: 10396 RVA: 0x0009E6D8 File Offset: 0x0009C8D8
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
				@class.method_64(stream_, "OM8-0Za-jP", array);
			}
			finally
			{
				this = (Class528.Struct430)array[0];
			}
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0001ACA7 File Offset: 0x00018EA7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0001ACB5 File Offset: 0x00018EB5
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class528.Struct430 struct430_0)
		{
			struct430_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Struct430>(ref taskAwaiter_1, ref struct430_0);
		}

		// Token: 0x04001AA7 RID: 6823
		public int int_0;

		// Token: 0x04001AA8 RID: 6824
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001AA9 RID: 6825
		public Class528 class528_0;

		// Token: 0x04001AAA RID: 6826
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200063F RID: 1599
	private sealed class Class764
	{
		// Token: 0x060028A0 RID: 10400 RVA: 0x0009E740 File Offset: 0x0009C940
		internal Task method_0()
		{
			Class528.Class764.Struct431 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class764_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class528.Class764.Struct431>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001AAB RID: 6827
		public Class528 class528_0;

		// Token: 0x04001AAC RID: 6828
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001AAD RID: 6829
		public string string_0;

		// Token: 0x02000640 RID: 1600
		[StructLayout(LayoutKind.Auto)]
		private struct Struct431 : IAsyncStateMachine
		{
			// Token: 0x060028A1 RID: 10401 RVA: 0x0009E784 File Offset: 0x0009C984
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class528.Class764 @class = this.class764_0;
				try
				{
					if (num > 1)
					{
						if (!Class406.smethod_0().method_2(typeof(dje_zY8TJ7HVSSL9J9VQH6V7EV8TJKMJV32VYYNUD95ZXTD6G6DK4JKGTBNA9KKRA_ejd)))
						{
							@class.class528_0.method_9(1.0);
							@class.class528_0.method_7(@class.solidColorBrush_0);
							@class.class528_0.method_11(@class.string_0);
							goto IL_272;
						}
						try
						{
							@class.class528_0.cancellationTokenSource_0.Cancel();
							@class.class528_0.cancellationTokenSource_0.Dispose();
						}
						catch
						{
						}
						@class.class528_0.cancellationTokenSource_0 = new CancellationTokenSource();
						this.cancellationToken_0 = @class.class528_0.cancellationTokenSource_0.Token;
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
						if (@class.class528_0.StatusOpacity <= 0.0)
						{
							@class.class528_0.StatusForeground = @class.solidColorBrush_0;
							@class.class528_0.Status = @class.string_0;
							goto IL_1F2;
						}
						this.cancellationToken_0.ThrowIfCancellationRequested();
						@class.class528_0.StatusOpacity = Math.Max(0.0, @class.class528_0.StatusOpacity - 0.1);
						awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							num = 0;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Class764.Struct431>(ref awaiter, ref this);
							return;
						}
						IL_169:
						awaiter.GetResult();
						goto IL_FB;
						IL_1EB:
						awaiter.GetResult();
						IL_1F2:
						if (@class.class528_0.StatusOpacity < 1.0)
						{
							this.cancellationToken_0.ThrowIfCancellationRequested();
							@class.class528_0.StatusOpacity = Math.Min(1.0, @class.class528_0.StatusOpacity + 0.13333333333333333);
							awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_1EB;
							}
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Class764.Struct431>(ref awaiter, ref this);
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

			// Token: 0x060028A2 RID: 10402 RVA: 0x0001ACC4 File Offset: 0x00018EC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001AAE RID: 6830
			public int int_0;

			// Token: 0x04001AAF RID: 6831
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001AB0 RID: 6832
			public Class528.Class764 class764_0;

			// Token: 0x04001AB1 RID: 6833
			private CancellationToken cancellationToken_0;

			// Token: 0x04001AB2 RID: 6834
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x02000641 RID: 1601
	[StructLayout(LayoutKind.Auto)]
	private struct Struct432 : IAsyncStateMachine
	{
		// Token: 0x060028A3 RID: 10403 RVA: 0x0009EA70 File Offset: 0x0009CC70
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
				@class.method_64(stream_, "4MJ51Za-ji", array);
			}
			finally
			{
				this = (Class528.Struct432)array[0];
			}
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0001ACD2 File Offset: 0x00018ED2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0001ACE0 File Offset: 0x00018EE0
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class528.Struct432 struct432_0)
		{
			struct432_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Struct432>(ref taskAwaiter_1, ref struct432_0);
		}

		// Token: 0x04001AB3 RID: 6835
		public int int_0;

		// Token: 0x04001AB4 RID: 6836
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001AB5 RID: 6837
		public Class528 class528_0;

		// Token: 0x04001AB6 RID: 6838
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000642 RID: 1602
	[StructLayout(LayoutKind.Auto)]
	private struct Struct433 : IAsyncStateMachine
	{
		// Token: 0x060028A6 RID: 10406 RVA: 0x0009EAD8 File Offset: 0x0009CCD8
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
				@class.method_64(stream_, "f\"SQ!Za-jU", array);
			}
			finally
			{
				this = (Class528.Struct433)array[0];
			}
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0001ACEF File Offset: 0x00018EEF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x0001ACFD File Offset: 0x00018EFD
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class528.Struct433 struct433_0)
		{
			struct433_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Struct433>(ref taskAwaiter_1, ref struct433_0);
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0001ACFD File Offset: 0x00018EFD
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class528.Struct433 struct433_0)
		{
			struct433_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Struct433>(ref taskAwaiter_1, ref struct433_0);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0001ACFD File Offset: 0x00018EFD
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_1, ref Class528.Struct433 struct433_0)
		{
			struct433_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Struct433>(ref taskAwaiter_1, ref struct433_0);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0001ACFD File Offset: 0x00018EFD
		private static void MoveNext_3(ref TaskAwaiter taskAwaiter_1, ref Class528.Struct433 struct433_0)
		{
			struct433_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Struct433>(ref taskAwaiter_1, ref struct433_0);
		}

		// Token: 0x04001AB7 RID: 6839
		public int int_0;

		// Token: 0x04001AB8 RID: 6840
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001AB9 RID: 6841
		public Class528 class528_0;

		// Token: 0x04001ABA RID: 6842
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000643 RID: 1603
	[StructLayout(LayoutKind.Auto)]
	private struct Struct434 : IAsyncStateMachine
	{
		// Token: 0x060028AC RID: 10412 RVA: 0x0009EB40 File Offset: 0x0009CD40
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
				@class.method_64(stream_, "k.\\71Za-j^", array);
			}
			finally
			{
				this = (Class528.Struct434)array[0];
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0001AD0C File Offset: 0x00018F0C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0001AD1A File Offset: 0x00018F1A
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class528.Struct434 struct434_0)
		{
			struct434_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class528.Struct434>(ref taskAwaiter_1, ref struct434_0);
		}

		// Token: 0x04001ABB RID: 6843
		public int int_0;

		// Token: 0x04001ABC RID: 6844
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001ABD RID: 6845
		public Class528 class528_0;

		// Token: 0x04001ABE RID: 6846
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001ABF RID: 6847
		public string string_0;

		// Token: 0x04001AC0 RID: 6848
		private TaskAwaiter taskAwaiter_0;
	}
}
