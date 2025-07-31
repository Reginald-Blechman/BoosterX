using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x02000442 RID: 1090
internal sealed class Class514 : GClass162, Interface8
{
	// Token: 0x06001C46 RID: 7238 RVA: 0x00012D58 File Offset: 0x00010F58
	public Class514(Class707 class707_1)
	{
		this.class707_0 = class707_1;
		this.method_2();
	}

	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00012D8E File Offset: 0x00010F8E
	public bool Possible
	{
		get
		{
			if (this.nullable_0 == null && !this.bool_0)
			{
				this.method_2();
			}
			return this.nullable_0.GetValueOrDefault();
		}
	}

	// Token: 0x06001C48 RID: 7240 RVA: 0x000780BC File Offset: 0x000762BC
	public void method_2()
	{
		Class514.Struct277 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class514_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class514.Struct277>(ref @struct);
	}

	// Token: 0x170004AA RID: 1194
	// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00012DB6 File Offset: 0x00010FB6
	// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00012DBE File Offset: 0x00010FBE
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

	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00012DD3 File Offset: 0x00010FD3
	// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00012DDB File Offset: 0x00010FDB
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

	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00012DF0 File Offset: 0x00010FF0
	// (set) Token: 0x06001C4E RID: 7246 RVA: 0x00012DF8 File Offset: 0x00010FF8
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

	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00012E0D File Offset: 0x0001100D
	// (set) Token: 0x06001C50 RID: 7248 RVA: 0x00012E15 File Offset: 0x00011015
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

	// Token: 0x06001C51 RID: 7249 RVA: 0x000780F4 File Offset: 0x000762F4
	public void method_3(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class514.Struct279 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class514_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class514.Struct279>(ref @struct);
	}

	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00012E2A File Offset: 0x0001102A
	public string Name
	{
		get
		{
			return Class298.smethod_2(this.class707_0.Name);
		}
	}

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00012E3C File Offset: 0x0001103C
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_4();
		}
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x0007813C File Offset: 0x0007633C
	private MaterialIconKind method_4()
	{
		MaterialIconKind materialIconKind = Class330.smethod_3(this.class707_0.Name);
		if (materialIconKind == null)
		{
			return 2015;
		}
		return materialIconKind;
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00078164 File Offset: 0x00076364
	public string Description
	{
		get
		{
			string text = Class298.smethod_2(this.class707_0.Name + "Desc");
			if (!(text == this.class707_0.Name + "Desc"))
			{
				return text;
			}
			return Class298.smethod_2("ThisFuncWillFix") + " " + Class298.smethod_2(this.class707_0.Name);
		}
	}

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00012E44 File Offset: 0x00011044
	public Action FixTask
	{
		get
		{
			return this.class707_0.method_0();
		}
	}

	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x06001C57 RID: 7255 RVA: 0x000781D4 File Offset: 0x000763D4
	public GClass280 RunFix
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_6), null));
			}
			return result;
		}
	}

	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00012E51 File Offset: 0x00011051
	public string NameEng
	{
		get
		{
			return string.Empty;
		}
	}

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x06001C59 RID: 7257 RVA: 0x00012E51 File Offset: 0x00011051
	public string SearchInfo
	{
		get
		{
			return string.Empty;
		}
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x00078208 File Offset: 0x00076408
	private Task method_5()
	{
		Class514.Struct278 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class514_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class514.Struct278>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x0007824C File Offset: 0x0007644C
	private void method_6(object object_0)
	{
		Class514.Struct280 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class514_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class514.Struct280>(ref @struct);
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x00012E58 File Offset: 0x00011058
	private void method_7()
	{
		this.FixTask();
	}

	// Token: 0x040012DE RID: 4830
	private Class707 class707_0;

	// Token: 0x040012DF RID: 4831
	private bool? nullable_0;

	// Token: 0x040012E0 RID: 4832
	public bool bool_0;

	// Token: 0x040012E1 RID: 4833
	private string string_0 = string.Empty;

	// Token: 0x040012E2 RID: 4834
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x040012E3 RID: 4835
	private double double_0;

	// Token: 0x040012E4 RID: 4836
	private Visibility visibility_0;

	// Token: 0x040012E5 RID: 4837
	private CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	// Token: 0x040012E6 RID: 4838
	public bool bool_1;

	// Token: 0x040012E7 RID: 4839
	private GClass280 gclass280_0;

	// Token: 0x02000443 RID: 1091
	[StructLayout(LayoutKind.Auto)]
	private struct Struct277 : IAsyncStateMachine
	{
		// Token: 0x06001C5D RID: 7261 RVA: 0x00078284 File Offset: 0x00076484
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class514 @object = this.class514_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class514.Struct277>(ref awaiter, ref this);
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

		// Token: 0x06001C5E RID: 7262 RVA: 0x00012E65 File Offset: 0x00011065
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012E8 RID: 4840
		public int int_0;

		// Token: 0x040012E9 RID: 4841
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012EA RID: 4842
		public Class514 class514_0;

		// Token: 0x040012EB RID: 4843
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000444 RID: 1092
	[StructLayout(LayoutKind.Auto)]
	private struct Struct278 : IAsyncStateMachine
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x00078344 File Offset: 0x00076544
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class514 @class = this.class514_0;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (@class.class707_0.method_2() == null)
					{
						@class.nullable_0 = new bool?(@class.class707_0.method_4());
						goto IL_A0;
					}
					awaiter = @class.class707_0.method_2().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class514.Struct278>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
				}
				bool result = awaiter.GetResult();
				@class.nullable_0 = new bool?(result);
				IL_A0:
				@class.bool_0 = true;
				@class.method_0("Possible");
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

		// Token: 0x06001C60 RID: 7264 RVA: 0x00012E73 File Offset: 0x00011073
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012EC RID: 4844
		public int int_0;

		// Token: 0x040012ED RID: 4845
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040012EE RID: 4846
		public Class514 class514_0;

		// Token: 0x040012EF RID: 4847
		private TaskAwaiter<bool> taskAwaiter_0;
	}

	// Token: 0x02000445 RID: 1093
	[StructLayout(LayoutKind.Auto)]
	private struct Struct279 : IAsyncStateMachine
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x00078444 File Offset: 0x00076644
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class514 @class = this.class514_0;
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
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class514.Struct279>(ref awaiter, ref this);
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
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class514.Struct279>(ref awaiter, ref this);
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

		// Token: 0x06001C62 RID: 7266 RVA: 0x00012E81 File Offset: 0x00011081
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012F0 RID: 4848
		public int int_0;

		// Token: 0x040012F1 RID: 4849
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012F2 RID: 4850
		public Class514 class514_0;

		// Token: 0x040012F3 RID: 4851
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040012F4 RID: 4852
		public string string_0;

		// Token: 0x040012F5 RID: 4853
		private CancellationToken cancellationToken_0;

		// Token: 0x040012F6 RID: 4854
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000446 RID: 1094
	[StructLayout(LayoutKind.Auto)]
	private struct Struct280 : IAsyncStateMachine
	{
		// Token: 0x06001C63 RID: 7267 RVA: 0x00078680 File Offset: 0x00076880
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class514 @class = this.class514_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.method_3(Class298.smethod_2("Fixing"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
					awaiter = Task.Run(new Action(@class.method_7)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class514.Struct280>(ref awaiter, ref this);
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
				@class.method_3(Class298.smethod_2("FixedRestartPlease"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
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

		// Token: 0x06001C64 RID: 7268 RVA: 0x00012E8F File Offset: 0x0001108F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012F7 RID: 4855
		public int int_0;

		// Token: 0x040012F8 RID: 4856
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040012F9 RID: 4857
		public Class514 class514_0;

		// Token: 0x040012FA RID: 4858
		private TaskAwaiter taskAwaiter_0;
	}
}
