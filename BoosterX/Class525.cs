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

// Token: 0x020005EA RID: 1514
internal sealed class Class525 : GClass162
{
	// Token: 0x060026C9 RID: 9929 RVA: 0x00019D96 File Offset: 0x00017F96
	public Class525()
	{
		Class525.smethod_0(ref this.cancellationTokenSource_0);
		base..ctor();
		this.method_18();
	}

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x060026CA RID: 9930 RVA: 0x00019DAF File Offset: 0x00017FAF
	// (set) Token: 0x060026CB RID: 9931 RVA: 0x00019DB7 File Offset: 0x00017FB7
	public Class797 _appxDebloatTweak
	{
		[CompilerGenerated]
		get
		{
			return this.class797_0;
		}
		[CompilerGenerated]
		set
		{
			this.class797_0 = value;
		}
	}

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x060026CC RID: 9932 RVA: 0x00019DC0 File Offset: 0x00017FC0
	// (set) Token: 0x060026CD RID: 9933 RVA: 0x00019DC8 File Offset: 0x00017FC8
	public string AppxFriendlyName
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x060026CE RID: 9934 RVA: 0x00019DD1 File Offset: 0x00017FD1
	// (set) Token: 0x060026CF RID: 9935 RVA: 0x00019DD9 File Offset: 0x00017FD9
	public string AppxLocation
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			this.method_2();
			base.method_0("AppxLocation");
		}
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x0009856C File Offset: 0x0009676C
	private void method_2()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "l`mk)Za-h=", object_);
	}

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x060026D1 RID: 9937 RVA: 0x00019DF4 File Offset: 0x00017FF4
	// (set) Token: 0x060026D2 RID: 9938 RVA: 0x00019DFC File Offset: 0x00017FFC
	public string AppxFullName
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x060026D3 RID: 9939 RVA: 0x00019E05 File Offset: 0x00018005
	// (set) Token: 0x060026D4 RID: 9940 RVA: 0x00019E0D File Offset: 0x0001800D
	public BitmapSource AppxIcon
	{
		get
		{
			return this.bitmapSource_0;
		}
		set
		{
			this.bitmapSource_0 = value;
			base.method_0("AppxIcon");
		}
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x00019E22 File Offset: 0x00018022
	private bool method_3()
	{
		return this.bool_1;
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x00019E2A File Offset: 0x0001802A
	private void method_4(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x060026D7 RID: 9943 RVA: 0x00019E33 File Offset: 0x00018033
	// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00019E3B File Offset: 0x0001803B
	public bool ToDelete
	{
		get
		{
			return this.method_3();
		}
		set
		{
			if (this.bool_0)
			{
				return;
			}
			this.method_4(value);
			base.method_0("ToDelete");
			this.method_5();
		}
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x0009859C File Offset: 0x0009679C
	private void method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "^p1;SZa-hA", object_);
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x000985CC File Offset: 0x000967CC
	public Task method_6()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), ".^?CgZa-hF", object_);
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x00019E5F File Offset: 0x0001805F
	private SolidColorBrush method_7()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x00019E67 File Offset: 0x00018067
	private void method_8(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x060026DD RID: 9949 RVA: 0x00019E70 File Offset: 0x00018070
	// (set) Token: 0x060026DE RID: 9950 RVA: 0x00019E78 File Offset: 0x00018078
	public SolidColorBrush StatusForeground
	{
		get
		{
			return this.method_7();
		}
		set
		{
			this.method_8(value);
			base.method_0("StatusForeground");
		}
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x00019E8D File Offset: 0x0001808D
	private double method_9()
	{
		return this.double_0;
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x00019E95 File Offset: 0x00018095
	private void method_10(double double_1)
	{
		this.double_0 = double_1;
	}

	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x060026E1 RID: 9953 RVA: 0x00019E9E File Offset: 0x0001809E
	// (set) Token: 0x060026E2 RID: 9954 RVA: 0x00019EA6 File Offset: 0x000180A6
	public double StatusOpacity
	{
		get
		{
			return this.method_9();
		}
		set
		{
			this.method_10(value);
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x060026E3 RID: 9955 RVA: 0x00019EBB File Offset: 0x000180BB
	private string method_11()
	{
		return this.string_3;
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x00019EC3 File Offset: 0x000180C3
	private void method_12(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x060026E5 RID: 9957 RVA: 0x00019ECC File Offset: 0x000180CC
	// (set) Token: 0x060026E6 RID: 9958 RVA: 0x00019ED4 File Offset: 0x000180D4
	public string Status
	{
		get
		{
			return this.method_11();
		}
		set
		{
			this.method_12(value);
			base.method_0("Status");
		}
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x00098600 File Offset: 0x00096800
	public Task method_13(string string_4, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_4,
			solidColorBrush_1
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "X0K(>Za-iM", object_);
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x0009863C File Offset: 0x0009683C
	private Task method_14()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "6F!r*Za-iU", object_);
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x00098670 File Offset: 0x00096870
	private Task method_15()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "CpCCTZa-i_", object_);
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x000986A4 File Offset: 0x000968A4
	private Class797 method_16()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class797)Class392.smethod_3().method_105(Class392.smethod_1(), ",I+Y`Za-hD", object_);
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x000986D8 File Offset: 0x000968D8
	private void method_17()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Qa*s*Za-hD", object_);
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x00098708 File Offset: 0x00096908
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
			@class.method_64(stream_, "26jQrZa-h:", array);
		}
		finally
		{
			cancellationTokenSource_1 = (CancellationTokenSource)array[0];
		}
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x00098764 File Offset: 0x00096964
	private void method_18()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "33fluZa-h;", object_);
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x00019EE9 File Offset: 0x000180E9
	private static void smethod_1(ref Class525.Struct399 struct399_0)
	{
		struct399_0.asyncVoidMethodBuilder_0.Start<Class525.Struct399>(ref struct399_0);
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x00019EF7 File Offset: 0x000180F7
	private static void smethod_2(ref Class525.Struct397 struct397_0)
	{
		struct397_0.asyncVoidMethodBuilder_0.Start<Class525.Struct397>(ref struct397_0);
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x00019F05 File Offset: 0x00018105
	private static void smethod_3(ref Class525.Struct398 struct398_0)
	{
		struct398_0.asyncTaskMethodBuilder_0.Start<Class525.Struct398>(ref struct398_0);
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x00019F13 File Offset: 0x00018113
	private static void smethod_4(ref Class525.Struct396 struct396_0)
	{
		struct396_0.asyncTaskMethodBuilder_0.Start<Class525.Struct396>(ref struct396_0);
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x00019F21 File Offset: 0x00018121
	private static void smethod_5(ref Class525.Struct401 struct401_0)
	{
		struct401_0.asyncTaskMethodBuilder_0.Start<Class525.Struct401>(ref struct401_0);
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x00019F2F File Offset: 0x0001812F
	private static void smethod_6(ref Class525.Struct402 struct402_0)
	{
		struct402_0.asyncTaskMethodBuilder_0.Start<Class525.Struct402>(ref struct402_0);
	}

	// Token: 0x04001990 RID: 6544
	private Class797 class797_0;

	// Token: 0x04001991 RID: 6545
	private string string_0;

	// Token: 0x04001992 RID: 6546
	private string string_1;

	// Token: 0x04001993 RID: 6547
	private string string_2;

	// Token: 0x04001994 RID: 6548
	private BitmapSource bitmapSource_0;

	// Token: 0x04001995 RID: 6549
	private bool bool_0;

	// Token: 0x04001996 RID: 6550
	private bool bool_1;

	// Token: 0x04001997 RID: 6551
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04001998 RID: 6552
	private double double_0;

	// Token: 0x04001999 RID: 6553
	private string string_3;

	// Token: 0x0400199A RID: 6554
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x020005EB RID: 1515
	[StructLayout(LayoutKind.Auto)]
	private struct Struct396 : IAsyncStateMachine
	{
		// Token: 0x060026F4 RID: 9972 RVA: 0x00098794 File Offset: 0x00096994
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
				@class.method_64(stream_, "(U:BTZa-iZ", array);
			}
			finally
			{
				this = (Class525.Struct396)array[0];
			}
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00019F3D File Offset: 0x0001813D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00019F4B File Offset: 0x0001814B
		private static void MoveNext(ref TaskAwaiter<BitmapImage> taskAwaiter_1, ref Class525.Struct396 struct396_0)
		{
			struct396_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapImage>, Class525.Struct396>(ref taskAwaiter_1, ref struct396_0);
		}

		// Token: 0x0400199B RID: 6555
		public int int_0;

		// Token: 0x0400199C RID: 6556
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400199D RID: 6557
		public Class525 class525_0;

		// Token: 0x0400199E RID: 6558
		private TaskAwaiter<BitmapImage> taskAwaiter_0;
	}

	// Token: 0x020005EC RID: 1516
	[StructLayout(LayoutKind.Auto)]
	private struct Struct397 : IAsyncStateMachine
	{
		// Token: 0x060026F7 RID: 9975 RVA: 0x000987FC File Offset: 0x000969FC
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
				@class.method_64(stream_, "l*7Y'Za-hB", array);
			}
			finally
			{
				this = (Class525.Struct397)array[0];
			}
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00019F5A File Offset: 0x0001815A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00019F68 File Offset: 0x00018168
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct397 struct397_0)
		{
			struct397_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct397>(ref taskAwaiter_1, ref struct397_0);
		}

		// Token: 0x0400199F RID: 6559
		public int int_0;

		// Token: 0x040019A0 RID: 6560
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040019A1 RID: 6561
		public Class525 class525_0;

		// Token: 0x040019A2 RID: 6562
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005ED RID: 1517
	[StructLayout(LayoutKind.Auto)]
	private struct Struct398 : IAsyncStateMachine
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x00098864 File Offset: 0x00096A64
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
				@class.method_64(stream_, ")R6]WZa-hG", array);
			}
			finally
			{
				this = (Class525.Struct398)array[0];
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00019F77 File Offset: 0x00018177
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00019F85 File Offset: 0x00018185
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct398 struct398_0)
		{
			struct398_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct398>(ref taskAwaiter_1, ref struct398_0);
		}

		// Token: 0x040019A3 RID: 6563
		public int int_0;

		// Token: 0x040019A4 RID: 6564
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040019A5 RID: 6565
		public Class525 class525_0;

		// Token: 0x040019A6 RID: 6566
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005EE RID: 1518
	[StructLayout(LayoutKind.Auto)]
	private struct Struct399 : IAsyncStateMachine
	{
		// Token: 0x060026FD RID: 9981 RVA: 0x000988CC File Offset: 0x00096ACC
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
				@class.method_64(stream_, "N3TdtZa-h>", array);
			}
			finally
			{
				this = (Class525.Struct399)array[0];
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00019F94 File Offset: 0x00018194
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00019FA2 File Offset: 0x000181A2
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct399 struct399_0)
		{
			struct399_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct399>(ref taskAwaiter_1, ref struct399_0);
		}

		// Token: 0x040019A7 RID: 6567
		public int int_0;

		// Token: 0x040019A8 RID: 6568
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040019A9 RID: 6569
		public Class525 class525_0;

		// Token: 0x040019AA RID: 6570
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005EF RID: 1519
	private sealed class Class728
	{
		// Token: 0x06002701 RID: 9985 RVA: 0x00098934 File Offset: 0x00096B34
		internal Task method_0()
		{
			Class525.Class728.Struct400 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class728_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class525.Class728.Struct400>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040019AB RID: 6571
		public Class525 class525_0;

		// Token: 0x040019AC RID: 6572
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040019AD RID: 6573
		public string string_0;

		// Token: 0x020005F0 RID: 1520
		[StructLayout(LayoutKind.Auto)]
		private struct Struct400 : IAsyncStateMachine
		{
			// Token: 0x06002702 RID: 9986 RVA: 0x00098978 File Offset: 0x00096B78
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class525.Class728 @class = this.class728_0;
				try
				{
					if (num > 1)
					{
						if (!Class406.smethod_0().method_2(typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P8GKSQ477YXNFFJYAV9GYM8S278FJ3VXSLSUGWV2W_ejd)))
						{
							@class.class525_0.method_10(1.0);
							@class.class525_0.method_8(@class.solidColorBrush_0);
							@class.class525_0.method_12(@class.string_0);
							goto IL_272;
						}
						try
						{
							@class.class525_0.cancellationTokenSource_0.Cancel();
							@class.class525_0.cancellationTokenSource_0.Dispose();
						}
						catch
						{
						}
						@class.class525_0.cancellationTokenSource_0 = new CancellationTokenSource();
						this.cancellationToken_0 = @class.class525_0.cancellationTokenSource_0.Token;
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
						if (@class.class525_0.StatusOpacity <= 0.0)
						{
							@class.class525_0.StatusForeground = @class.solidColorBrush_0;
							@class.class525_0.Status = @class.string_0;
							goto IL_1F2;
						}
						this.cancellationToken_0.ThrowIfCancellationRequested();
						@class.class525_0.StatusOpacity = Math.Max(0.0, @class.class525_0.StatusOpacity - 0.1);
						awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							num = 0;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Class728.Struct400>(ref awaiter, ref this);
							return;
						}
						IL_169:
						awaiter.GetResult();
						goto IL_FB;
						IL_1EB:
						awaiter.GetResult();
						IL_1F2:
						if (@class.class525_0.StatusOpacity < 1.0)
						{
							this.cancellationToken_0.ThrowIfCancellationRequested();
							@class.class525_0.StatusOpacity = Math.Min(1.0, @class.class525_0.StatusOpacity + 0.13333333333333333);
							awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_1EB;
							}
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Class728.Struct400>(ref awaiter, ref this);
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

			// Token: 0x06002703 RID: 9987 RVA: 0x00019FB1 File Offset: 0x000181B1
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040019AE RID: 6574
			public int int_0;

			// Token: 0x040019AF RID: 6575
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040019B0 RID: 6576
			public Class525.Class728 class728_0;

			// Token: 0x040019B1 RID: 6577
			private CancellationToken cancellationToken_0;

			// Token: 0x040019B2 RID: 6578
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020005F1 RID: 1521
	[StructLayout(LayoutKind.Auto)]
	private struct Struct401 : IAsyncStateMachine
	{
		// Token: 0x06002704 RID: 9988 RVA: 0x00098C64 File Offset: 0x00096E64
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
				@class.method_64(stream_, "]!8ZMZa-iD", array);
			}
			finally
			{
				this = (Class525.Struct401)array[0];
			}
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00019FBF File Offset: 0x000181BF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00019FCD File Offset: 0x000181CD
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct401 struct401_0)
		{
			struct401_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct401>(ref taskAwaiter_1, ref struct401_0);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00019FCD File Offset: 0x000181CD
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct401 struct401_0)
		{
			struct401_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct401>(ref taskAwaiter_1, ref struct401_0);
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00019FCD File Offset: 0x000181CD
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct401 struct401_0)
		{
			struct401_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct401>(ref taskAwaiter_1, ref struct401_0);
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00019FCD File Offset: 0x000181CD
		private static void MoveNext_3(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct401 struct401_0)
		{
			struct401_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct401>(ref taskAwaiter_1, ref struct401_0);
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00019FCD File Offset: 0x000181CD
		private static void MoveNext_4(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct401 struct401_0)
		{
			struct401_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct401>(ref taskAwaiter_1, ref struct401_0);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00019FCD File Offset: 0x000181CD
		private static void MoveNext_5(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct401 struct401_0)
		{
			struct401_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct401>(ref taskAwaiter_1, ref struct401_0);
		}

		// Token: 0x040019B3 RID: 6579
		public int int_0;

		// Token: 0x040019B4 RID: 6580
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040019B5 RID: 6581
		public Class525 class525_0;

		// Token: 0x040019B6 RID: 6582
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020005F2 RID: 1522
	[StructLayout(LayoutKind.Auto)]
	private struct Struct402 : IAsyncStateMachine
	{
		// Token: 0x0600270C RID: 9996 RVA: 0x00098CCC File Offset: 0x00096ECC
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
				@class.method_64(stream_, "Pd.X'Za-iO", array);
			}
			finally
			{
				this = (Class525.Struct402)array[0];
			}
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00019FDC File Offset: 0x000181DC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00019FEA File Offset: 0x000181EA
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class525.Struct402 struct402_0)
		{
			struct402_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class525.Struct402>(ref taskAwaiter_1, ref struct402_0);
		}

		// Token: 0x040019B7 RID: 6583
		public int int_0;

		// Token: 0x040019B8 RID: 6584
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040019B9 RID: 6585
		public Class525 class525_0;

		// Token: 0x040019BA RID: 6586
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040019BB RID: 6587
		public string string_0;

		// Token: 0x040019BC RID: 6588
		private TaskAwaiter taskAwaiter_0;
	}
}
