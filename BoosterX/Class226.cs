using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PIManagerX;

// Token: 0x020001D6 RID: 470
internal sealed class Class226
{
	// Token: 0x06000CF5 RID: 3317 RVA: 0x0004CFAC File Offset: 0x0004B1AC
	public static void smethod_0(Class226.Delegate24 delegate24_1)
	{
		Class226.Delegate24 @delegate = Class226.delegate24_0;
		Class226.Delegate24 delegate2;
		do
		{
			delegate2 = @delegate;
			Class226.Delegate24 value = (Class226.Delegate24)Delegate.Combine(delegate2, delegate24_1);
			@delegate = Interlocked.CompareExchange<Class226.Delegate24>(ref Class226.delegate24_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x0004CFE0 File Offset: 0x0004B1E0
	public static void smethod_1(Class226.Delegate24 delegate24_1)
	{
		Class226.Delegate24 @delegate = Class226.delegate24_0;
		Class226.Delegate24 delegate2;
		do
		{
			delegate2 = @delegate;
			Class226.Delegate24 value = (Class226.Delegate24)Delegate.Remove(delegate2, delegate24_1);
			@delegate = Interlocked.CompareExchange<Class226.Delegate24>(ref Class226.delegate24_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00009DC7 File Offset: 0x00007FC7
	public static void smethod_2()
	{
		Class226.float_0 = 0f;
		Class226.float_1 = 0f;
		Class226.float_2 = 0f;
		Class226.float_3 = 0f;
		Class226.float_4 = 0f;
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x0004D014 File Offset: 0x0004B214
	public static void smethod_3()
	{
		Class226.Struct103 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class226.Struct103>(ref @struct);
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x0004D044 File Offset: 0x0004B244
	public static void smethod_4()
	{
		Class226.Struct104 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class226.Struct104>(ref @struct);
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x0004D074 File Offset: 0x0004B274
	public static void smethod_5()
	{
		Class226.Struct105 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class226.Struct105>(ref @struct);
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
	public static long smethod_6()
	{
		PManagerX.PerformanceInformation structure = default(PManagerX.PerformanceInformation);
		if (PManagerX.GetPerformanceInfo(ref structure, Marshal.SizeOf<PManagerX.PerformanceInformation>(structure)))
		{
			return Convert.ToInt64(structure.PhysicalAvailable.ToInt64() * structure.PageSize.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x0003DB38 File Offset: 0x0003BD38
	public static long smethod_7()
	{
		PManagerX.PerformanceInformation structure = default(PManagerX.PerformanceInformation);
		if (PManagerX.GetPerformanceInfo(ref structure, Marshal.SizeOf<PManagerX.PerformanceInformation>(structure)))
		{
			return Convert.ToInt64(structure.PhysicalTotal.ToInt64() * structure.PageSize.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0004D0A4 File Offset: 0x0004B2A4
	public static long smethod_8()
	{
		PManagerX.PerformanceInformation structure = default(PManagerX.PerformanceInformation);
		if (PManagerX.GetPerformanceInfo(ref structure, Marshal.SizeOf<PManagerX.PerformanceInformation>(structure)))
		{
			return Convert.ToInt64(structure.SystemCache.ToInt64() * structure.PageSize.ToInt64() / 1048576L);
		}
		return -1L;
	}

	// Token: 0x04000842 RID: 2114
	public static float float_0;

	// Token: 0x04000843 RID: 2115
	public static float float_1;

	// Token: 0x04000844 RID: 2116
	public static float float_2;

	// Token: 0x04000845 RID: 2117
	public static float float_3;

	// Token: 0x04000846 RID: 2118
	public static float float_4;

	// Token: 0x04000847 RID: 2119
	private static Class226.Delegate24 delegate24_0;

	// Token: 0x04000848 RID: 2120
	private static bool bool_0;

	// Token: 0x020001D7 RID: 471
	// (Invoke) Token: 0x06000CFF RID: 3327
	public delegate void Delegate24();

	// Token: 0x020001D8 RID: 472
	[StructLayout(LayoutKind.Auto)]
	private struct Struct103 : IAsyncStateMachine
	{
		// Token: 0x06000D02 RID: 3330 RVA: 0x0004D0FC File Offset: 0x0004B2FC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class226.Class227.class227_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class226.Struct103>(ref awaiter, ref this);
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

		// Token: 0x06000D03 RID: 3331 RVA: 0x00009DFB File Offset: 0x00007FFB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000849 RID: 2121
		public int int_0;

		// Token: 0x0400084A RID: 2122
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400084B RID: 2123
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001D9 RID: 473
	[StructLayout(LayoutKind.Auto)]
	private struct Struct104 : IAsyncStateMachine
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x0004D1C8 File Offset: 0x0004B3C8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class226.Class227.class227_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class226.Struct104>(ref awaiter, ref this);
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

		// Token: 0x06000D05 RID: 3333 RVA: 0x00009E09 File Offset: 0x00008009
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400084C RID: 2124
		public int int_0;

		// Token: 0x0400084D RID: 2125
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400084E RID: 2126
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001DA RID: 474
	[StructLayout(LayoutKind.Auto)]
	private struct Struct105 : IAsyncStateMachine
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x0004D294 File Offset: 0x0004B494
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class226.Class227.class227_0.method_2)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class226.Struct105>(ref awaiter, ref this);
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

		// Token: 0x06000D07 RID: 3335 RVA: 0x00009E17 File Offset: 0x00008017
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400084F RID: 2127
		public int int_0;

		// Token: 0x04000850 RID: 2128
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000851 RID: 2129
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001DB RID: 475
	[Serializable]
	private sealed class Class227
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x00009E31 File Offset: 0x00008031
		internal void method_0()
		{
			Class226.bool_0 = true;
			Class226.smethod_5();
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00009E3E File Offset: 0x0000803E
		internal void method_1()
		{
			Class226.bool_0 = false;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0004D360 File Offset: 0x0004B560
		internal Task method_2()
		{
			Class226.Class227.Struct106 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class226.Class227.Struct106>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000852 RID: 2130
		public static readonly Class226.Class227 class227_0 = new Class226.Class227();

		// Token: 0x04000853 RID: 2131
		public static Action action_0;

		// Token: 0x04000854 RID: 2132
		public static Action action_1;

		// Token: 0x04000855 RID: 2133
		public static Func<Task> func_0;

		// Token: 0x020001DC RID: 476
		[StructLayout(LayoutKind.Auto)]
		private struct Struct106 : IAsyncStateMachine
		{
			// Token: 0x06000D0D RID: 3341 RVA: 0x0004D39C File Offset: 0x0004B59C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_B6;
					}
					IL_2B:
					if (!Class226.bool_0)
					{
						goto IL_FB;
					}
					Class226.float_4 = (float)Class226.smethod_7();
					Class226.float_2 = (float)Class226.smethod_6();
					Class226.float_0 = Class226.float_4 - Class226.float_2;
					Class226.float_1 = (float)Class226.smethod_8();
					float num2 = Class226.float_4 - Class226.float_0 - Class226.float_1;
					Class226.float_3 = ((num2 < 0f) ? 0f : num2);
					Class226.Delegate24 delegate24_ = Class226.delegate24_0;
					if (delegate24_ != null)
					{
						delegate24_();
					}
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class226.Class227.Struct106>(ref awaiter, ref this);
						return;
					}
					IL_B6:
					awaiter.GetResult();
					goto IL_2B;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_FB:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x00009E46 File Offset: 0x00008046
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000856 RID: 2134
			public int int_0;

			// Token: 0x04000857 RID: 2135
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000858 RID: 2136
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
