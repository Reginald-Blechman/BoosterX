using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using ns0;

// Token: 0x02000621 RID: 1569
internal sealed class Class527 : GClass162
{
	// Token: 0x060027EE RID: 10222 RVA: 0x0001A78D File Offset: 0x0001898D
	public Class527()
	{
		Class527.smethod_0(ref this.cancellationTokenSource_0);
		base..ctor();
		this.method_19();
	}

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x060027EF RID: 10223 RVA: 0x0001A7A6 File Offset: 0x000189A6
	// (set) Token: 0x060027F0 RID: 10224 RVA: 0x0001A7AE File Offset: 0x000189AE
	public string Name
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

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x060027F1 RID: 10225 RVA: 0x0001A7B7 File Offset: 0x000189B7
	public string Description
	{
		get
		{
			return Class298.smethod_2("DeletedUWPAppsLeftOvers") + " \"" + this.Name + "\"";
		}
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x060027F2 RID: 10226 RVA: 0x0001A7DB File Offset: 0x000189DB
	// (set) Token: 0x060027F3 RID: 10227 RVA: 0x0001A7E3 File Offset: 0x000189E3
	public double Size
	{
		[CompilerGenerated]
		get
		{
			return this.double_0;
		}
		[CompilerGenerated]
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x0001A7EC File Offset: 0x000189EC
	private bool method_2()
	{
		return this.bool_1;
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x0001A7F4 File Offset: 0x000189F4
	private void method_3(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x060027F6 RID: 10230 RVA: 0x0001A7FD File Offset: 0x000189FD
	// (set) Token: 0x060027F7 RID: 10231 RVA: 0x0001A805 File Offset: 0x00018A05
	public bool ToDelete
	{
		get
		{
			return this.method_2();
		}
		set
		{
			if (this.bool_0)
			{
				return;
			}
			this.method_3(value);
			this.method_4();
			base.method_0("ToDelete");
		}
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x0009C27C File Offset: 0x0009A47C
	private void method_4()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "HEafaZa-j$", object_);
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x0009C2AC File Offset: 0x0009A4AC
	public Task method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "^Tb,QZa-j-", object_);
	}

	// Token: 0x060027FA RID: 10234 RVA: 0x0001A829 File Offset: 0x00018A29
	private SolidColorBrush method_6()
	{
		return this.solidColorBrush_0;
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x0001A831 File Offset: 0x00018A31
	private void method_7(SolidColorBrush solidColorBrush_1)
	{
		this.solidColorBrush_0 = solidColorBrush_1;
	}

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x060027FC RID: 10236 RVA: 0x0001A83A File Offset: 0x00018A3A
	// (set) Token: 0x060027FD RID: 10237 RVA: 0x0001A842 File Offset: 0x00018A42
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

	// Token: 0x060027FE RID: 10238 RVA: 0x0001A857 File Offset: 0x00018A57
	private double method_8()
	{
		return this.double_1;
	}

	// Token: 0x060027FF RID: 10239 RVA: 0x0001A85F File Offset: 0x00018A5F
	private void method_9(double double_2)
	{
		this.double_1 = double_2;
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x06002800 RID: 10240 RVA: 0x0001A868 File Offset: 0x00018A68
	// (set) Token: 0x06002801 RID: 10241 RVA: 0x0001A870 File Offset: 0x00018A70
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

	// Token: 0x06002802 RID: 10242 RVA: 0x0001A885 File Offset: 0x00018A85
	private string method_10()
	{
		return this.string_1;
	}

	// Token: 0x06002803 RID: 10243 RVA: 0x0001A88D File Offset: 0x00018A8D
	private void method_11(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x06002804 RID: 10244 RVA: 0x0001A896 File Offset: 0x00018A96
	// (set) Token: 0x06002805 RID: 10245 RVA: 0x0001A89E File Offset: 0x00018A9E
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

	// Token: 0x06002806 RID: 10246 RVA: 0x0009C2E0 File Offset: 0x0009A4E0
	public Task method_12(string string_2, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_2,
			solidColorBrush_1
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "40Z-\"Za-k*", object_);
	}

	// Token: 0x06002807 RID: 10247 RVA: 0x0009C31C File Offset: 0x0009A51C
	private Task method_13()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "poq05Za-ig", object_);
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x0009C350 File Offset: 0x0009A550
	private bool method_14(string string_2)
	{
		object[] object_ = new object[]
		{
			this,
			string_2
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "0sJ'mZa-k.", object_);
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x0009C38C File Offset: 0x0009A58C
	private void method_15(string string_2)
	{
		object[] object_ = new object[]
		{
			this,
			string_2
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Bs>\"PZa-j*", object_);
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x0009C3C0 File Offset: 0x0009A5C0
	private void method_16()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Cp:=SZa-j)", object_);
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x0009C3F0 File Offset: 0x0009A5F0
	private Class802 method_17()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class802)Class392.smethod_3().method_105(Class392.smethod_1(), "]<J]MZa-k/", object_);
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x0009C424 File Offset: 0x0009A624
	private void method_18()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "J?ZGgZa-j*", object_);
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x0009C454 File Offset: 0x0009A654
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
			@class.method_64(stream_, "f!)QhZa-j!", array);
		}
		finally
		{
			cancellationTokenSource_1 = (CancellationTokenSource)array[0];
		}
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x0009C4B0 File Offset: 0x0009A6B0
	private void method_19()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "&$WIKZa-j\"", object_);
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x0001A8B3 File Offset: 0x00018AB3
	private static void smethod_1(ref Class527.Struct414 struct414_0)
	{
		struct414_0.asyncVoidMethodBuilder_0.Start<Class527.Struct414>(ref struct414_0);
	}

	// Token: 0x06002810 RID: 10256 RVA: 0x0001A8C1 File Offset: 0x00018AC1
	private static void smethod_2(ref Class527.Struct411 struct411_0)
	{
		struct411_0.asyncTaskMethodBuilder_0.Start<Class527.Struct411>(ref struct411_0);
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x0001A8CF File Offset: 0x00018ACF
	private static void smethod_3(ref Class527.Struct413 struct413_0)
	{
		struct413_0.asyncTaskMethodBuilder_0.Start<Class527.Struct413>(ref struct413_0);
	}

	// Token: 0x06002812 RID: 10258 RVA: 0x0001A8DD File Offset: 0x00018ADD
	private static void smethod_4(ref Class527.Struct412 struct412_0)
	{
		struct412_0.asyncTaskMethodBuilder_0.Start<Class527.Struct412>(ref struct412_0);
	}

	// Token: 0x04001A30 RID: 6704
	private Class802 class802_0;

	// Token: 0x04001A31 RID: 6705
	private string string_0;

	// Token: 0x04001A32 RID: 6706
	private double double_0;

	// Token: 0x04001A33 RID: 6707
	private bool bool_0;

	// Token: 0x04001A34 RID: 6708
	private bool bool_1;

	// Token: 0x04001A35 RID: 6709
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04001A36 RID: 6710
	private double double_1;

	// Token: 0x04001A37 RID: 6711
	private string string_1;

	// Token: 0x04001A38 RID: 6712
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x02000622 RID: 1570
	[StructLayout(LayoutKind.Auto)]
	private struct Struct411 : IAsyncStateMachine
	{
		// Token: 0x06002813 RID: 10259 RVA: 0x0009C4E0 File Offset: 0x0009A6E0
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
				@class.method_64(stream_, "O0H%!Za-j.", array);
			}
			finally
			{
				this = (Class527.Struct411)array[0];
			}
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0001A8EB File Offset: 0x00018AEB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0001A8F9 File Offset: 0x00018AF9
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct411 struct411_0)
		{
			struct411_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct411>(ref taskAwaiter_1, ref struct411_0);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x0001A8F9 File Offset: 0x00018AF9
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct411 struct411_0)
		{
			struct411_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct411>(ref taskAwaiter_1, ref struct411_0);
		}

		// Token: 0x04001A39 RID: 6713
		public int int_0;

		// Token: 0x04001A3A RID: 6714
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001A3B RID: 6715
		public Class527 class527_0;

		// Token: 0x04001A3C RID: 6716
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000623 RID: 1571
	[StructLayout(LayoutKind.Auto)]
	private struct Struct412 : IAsyncStateMachine
	{
		// Token: 0x06002817 RID: 10263 RVA: 0x0009C548 File Offset: 0x0009A748
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
				@class.method_64(stream_, ",d=\\`Za-k,", array);
			}
			finally
			{
				this = (Class527.Struct412)array[0];
			}
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x0001A908 File Offset: 0x00018B08
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0001A916 File Offset: 0x00018B16
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct412 struct412_0)
		{
			struct412_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct412>(ref taskAwaiter_1, ref struct412_0);
		}

		// Token: 0x04001A3D RID: 6717
		public int int_0;

		// Token: 0x04001A3E RID: 6718
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001A3F RID: 6719
		public Class527 class527_0;

		// Token: 0x04001A40 RID: 6720
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001A41 RID: 6721
		public string string_0;

		// Token: 0x04001A42 RID: 6722
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000624 RID: 1572
	[StructLayout(LayoutKind.Auto)]
	private struct Struct413 : IAsyncStateMachine
	{
		// Token: 0x0600281A RID: 10266 RVA: 0x0009C5B0 File Offset: 0x0009A7B0
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
				@class.method_64(stream_, "`3?YVZa-ik", array);
			}
			finally
			{
				this = (Class527.Struct413)array[0];
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x0001A925 File Offset: 0x00018B25
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0001A933 File Offset: 0x00018B33
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct413 struct413_0)
		{
			struct413_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct413>(ref taskAwaiter_1, ref struct413_0);
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0001A933 File Offset: 0x00018B33
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct413 struct413_0)
		{
			struct413_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct413>(ref taskAwaiter_1, ref struct413_0);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0001A933 File Offset: 0x00018B33
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct413 struct413_0)
		{
			struct413_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct413>(ref taskAwaiter_1, ref struct413_0);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x0001A933 File Offset: 0x00018B33
		private static void MoveNext_3(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct413 struct413_0)
		{
			struct413_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct413>(ref taskAwaiter_1, ref struct413_0);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0001A933 File Offset: 0x00018B33
		private static void MoveNext_4(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct413 struct413_0)
		{
			struct413_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct413>(ref taskAwaiter_1, ref struct413_0);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0001A933 File Offset: 0x00018B33
		private static void MoveNext_5(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct413 struct413_0)
		{
			struct413_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct413>(ref taskAwaiter_1, ref struct413_0);
		}

		// Token: 0x04001A43 RID: 6723
		public int int_0;

		// Token: 0x04001A44 RID: 6724
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001A45 RID: 6725
		public Class527 class527_0;

		// Token: 0x04001A46 RID: 6726
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000625 RID: 1573
	[StructLayout(LayoutKind.Auto)]
	private struct Struct414 : IAsyncStateMachine
	{
		// Token: 0x06002822 RID: 10274 RVA: 0x0009C618 File Offset: 0x0009A818
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
				@class.method_64(stream_, "\"0f2?Za-j%", array);
			}
			finally
			{
				this = (Class527.Struct414)array[0];
			}
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x0001A942 File Offset: 0x00018B42
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0001A950 File Offset: 0x00018B50
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class527.Struct414 struct414_0)
		{
			struct414_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Struct414>(ref taskAwaiter_1, ref struct414_0);
		}

		// Token: 0x04001A47 RID: 6727
		public int int_0;

		// Token: 0x04001A48 RID: 6728
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001A49 RID: 6729
		public Class527 class527_0;

		// Token: 0x04001A4A RID: 6730
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000626 RID: 1574
	private sealed class Class758
	{
		// Token: 0x06002826 RID: 10278 RVA: 0x0009C680 File Offset: 0x0009A880
		internal Task method_0()
		{
			Class527.Class758.Struct415 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class758_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class527.Class758.Struct415>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001A4B RID: 6731
		public Class527 class527_0;

		// Token: 0x04001A4C RID: 6732
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001A4D RID: 6733
		public string string_0;

		// Token: 0x02000627 RID: 1575
		[StructLayout(LayoutKind.Auto)]
		private struct Struct415 : IAsyncStateMachine
		{
			// Token: 0x06002827 RID: 10279 RVA: 0x0009C6C4 File Offset: 0x0009A8C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class527.Class758 @class = this.class758_0;
				try
				{
					if (num > 1)
					{
						if (!Class406.smethod_0().method_2(typeof(dje_zY8TJ7HVSSL9J9VQH6V7EV8TJKMJV32VYYNUD95ZXTD6G6DK4JKGTBNA9KKRA_ejd)))
						{
							@class.class527_0.method_9(1.0);
							@class.class527_0.method_7(@class.solidColorBrush_0);
							@class.class527_0.method_11(@class.string_0);
							goto IL_272;
						}
						try
						{
							@class.class527_0.cancellationTokenSource_0.Cancel();
							@class.class527_0.cancellationTokenSource_0.Dispose();
						}
						catch
						{
						}
						@class.class527_0.cancellationTokenSource_0 = new CancellationTokenSource();
						this.cancellationToken_0 = @class.class527_0.cancellationTokenSource_0.Token;
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
						if (@class.class527_0.StatusOpacity <= 0.0)
						{
							@class.class527_0.StatusForeground = @class.solidColorBrush_0;
							@class.class527_0.Status = @class.string_0;
							goto IL_1F2;
						}
						this.cancellationToken_0.ThrowIfCancellationRequested();
						@class.class527_0.StatusOpacity = Math.Max(0.0, @class.class527_0.StatusOpacity - 0.1);
						awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							num = 0;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Class758.Struct415>(ref awaiter, ref this);
							return;
						}
						IL_169:
						awaiter.GetResult();
						goto IL_FB;
						IL_1EB:
						awaiter.GetResult();
						IL_1F2:
						if (@class.class527_0.StatusOpacity < 1.0)
						{
							this.cancellationToken_0.ThrowIfCancellationRequested();
							@class.class527_0.StatusOpacity = Math.Min(1.0, @class.class527_0.StatusOpacity + 0.13333333333333333);
							awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_1EB;
							}
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class527.Class758.Struct415>(ref awaiter, ref this);
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

			// Token: 0x06002828 RID: 10280 RVA: 0x0001A95F File Offset: 0x00018B5F
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001A4E RID: 6734
			public int int_0;

			// Token: 0x04001A4F RID: 6735
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001A50 RID: 6736
			public Class527.Class758 class758_0;

			// Token: 0x04001A51 RID: 6737
			private CancellationToken cancellationToken_0;

			// Token: 0x04001A52 RID: 6738
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
