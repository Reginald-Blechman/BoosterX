using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ns0;

// Token: 0x02000200 RID: 512
internal sealed class Class242
{
	// Token: 0x06000DEC RID: 3564 RVA: 0x00050368 File Offset: 0x0004E568
	public static Task<Class534> smethod_0(bool bool_0)
	{
		Class242.Struct118 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Class534>.Create();
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class242.Struct118>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x000503AC File Offset: 0x0004E5AC
	public static Task smethod_1()
	{
		Class242.Struct122 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class242.Struct122>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x0000A611 File Offset: 0x00008811
	public static Task smethod_2()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "OMA31Za-j/", null);
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x0000A62D File Offset: 0x0000882D
	public static Task smethod_3()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "Q+s`6Za-j8", null);
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x000503E8 File Offset: 0x0004E5E8
	public static Task smethod_4()
	{
		Class242.Struct119 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class242.Struct119>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00050424 File Offset: 0x0004E624
	internal static List<string> smethod_5()
	{
		List<string> list = new List<string>();
		if (Class242.class534_0 != null)
		{
			foreach (Class512 @class in Class242.class534_0.Tweaks)
			{
				list.Add(@class.method_7());
			}
		}
		return list;
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x0005048C File Offset: 0x0004E68C
	public static Task<List<Class265>> smethod_6()
	{
		Class242.Struct123 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class265>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class242.Struct123>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x0000A649 File Offset: 0x00008849
	private static void smethod_7(ref Class242.Struct121 struct121_0)
	{
		struct121_0.asyncTaskMethodBuilder_0.Start<Class242.Struct121>(ref struct121_0);
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x0000A657 File Offset: 0x00008857
	private static void smethod_8(ref Class242.Struct120 struct120_0)
	{
		struct120_0.asyncTaskMethodBuilder_0.Start<Class242.Struct120>(ref struct120_0);
	}

	// Token: 0x040008F4 RID: 2292
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x040008F5 RID: 2293
	public static Class534 class534_0;

	// Token: 0x02000201 RID: 513
	[StructLayout(LayoutKind.Auto)]
	private struct Struct118 : IAsyncStateMachine
	{
		// Token: 0x06000DF5 RID: 3573 RVA: 0x000504C8 File Offset: 0x0004E6C8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class534 result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_4F;
					}
					awaiter = Class242.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						goto IL_FE;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
				}
				awaiter.GetResult();
				IL_4F:
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
					if (num != 1)
					{
						if (Class242.class534_0 == null)
						{
							Class242.class534_0 = new Class534();
							result = Class242.class534_0;
							goto IL_137;
						}
						if (!this.bool_0)
						{
							goto IL_E1;
						}
						awaiter2 = Class242.class534_0.method_2().ConfigureAwait(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num3 = 1;
							num = 1;
							this.int_0 = num3;
							this.configuredTaskAwaiter_0 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Class242.Struct118>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.configuredTaskAwaiter_0;
						this.configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
					}
					awaiter2.GetResult();
					IL_E1:
					result = Class242.class534_0;
					goto IL_137;
				}
				catch
				{
					result = null;
					goto IL_137;
				}
				finally
				{
					if (num < 0)
					{
						Class242.semaphoreSlim_0.Release();
					}
				}
				IL_FE:
				int num5 = 0;
				num = 0;
				this.int_0 = num5;
				this.taskAwaiter_0 = awaiter;
				this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct118>(ref awaiter, ref this);
				return;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_137:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0000A665 File Offset: 0x00008865
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008F6 RID: 2294
		public int int_0;

		// Token: 0x040008F7 RID: 2295
		public AsyncTaskMethodBuilder<Class534> asyncTaskMethodBuilder_0;

		// Token: 0x040008F8 RID: 2296
		public bool bool_0;

		// Token: 0x040008F9 RID: 2297
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040008FA RID: 2298
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;
	}

	// Token: 0x02000202 RID: 514
	[StructLayout(LayoutKind.Auto)]
	private struct Struct119 : IAsyncStateMachine
	{
		// Token: 0x06000DF7 RID: 3575 RVA: 0x0005066C File Offset: 0x0004E86C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_6D;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_10E;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1A3;
				default:
					this.int_1 = 0;
					break;
				}
				IL_50:
				if (Class242.class534_0 == null)
				{
					awaiter = Task.Delay(20).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct119>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					if (Class242.class534_0 == null)
					{
						goto IL_1F2;
					}
					this.int_1 = 0;
					goto IL_EC;
				}
				IL_6D:
				awaiter.GetResult();
				if (this.int_1 > 500)
				{
					goto IL_1F2;
				}
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
				goto IL_50;
				IL_EC:
				if (Class242.class534_0.FeaturesLoaded)
				{
					this.int_1 = 0;
					goto IL_181;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct119>(ref awaiter, ref this);
					return;
				}
				IL_10E:
				awaiter.GetResult();
				if (this.int_1 > 500)
				{
					goto IL_1F2;
				}
				num2 = this.int_1;
				this.int_1 = num2 + 1;
				goto IL_EC;
				IL_181:
				if (Class242.class534_0.Tweaks != null)
				{
					goto IL_1F2;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct119>(ref awaiter, ref this);
					return;
				}
				IL_1A3:
				awaiter.GetResult();
				if (this.int_1 <= 500)
				{
					num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_181;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1F2:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0000A673 File Offset: 0x00008873
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008FB RID: 2299
		public int int_0;

		// Token: 0x040008FC RID: 2300
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040008FD RID: 2301
		private int int_1;

		// Token: 0x040008FE RID: 2302
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000203 RID: 515
	[StructLayout(LayoutKind.Auto)]
	private struct Struct120 : IAsyncStateMachine
	{
		// Token: 0x06000DF9 RID: 3577 RVA: 0x0005089C File Offset: 0x0004EA9C
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
				@class.method_64(stream_, "&APW[Za-j9", array);
			}
			finally
			{
				this = (Class242.Struct120)array[0];
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0000A681 File Offset: 0x00008881
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0000A68F File Offset: 0x0000888F
		private static void MoveNext(ref TaskAwaiter<Class534> taskAwaiter_2, ref Class242.Struct120 struct120_0)
		{
			struct120_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class534>, Class242.Struct120>(ref taskAwaiter_2, ref struct120_0);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0000A69E File Offset: 0x0000889E
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_2, ref Class242.Struct120 struct120_0)
		{
			struct120_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct120>(ref taskAwaiter_2, ref struct120_0);
		}

		// Token: 0x040008FF RID: 2303
		public int int_0;

		// Token: 0x04000900 RID: 2304
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000901 RID: 2305
		private TaskAwaiter<Class534> taskAwaiter_0;

		// Token: 0x04000902 RID: 2306
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000204 RID: 516
	[StructLayout(LayoutKind.Auto)]
	private struct Struct121 : IAsyncStateMachine
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00050904 File Offset: 0x0004EB04
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
				@class.method_64(stream_, "`4r^eZa-j3", array);
			}
			finally
			{
				this = (Class242.Struct121)array[0];
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0000A6AD File Offset: 0x000088AD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0000A6BB File Offset: 0x000088BB
		private static void MoveNext(ref TaskAwaiter<Class534> taskAwaiter_2, ref Class242.Struct121 struct121_0)
		{
			struct121_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class534>, Class242.Struct121>(ref taskAwaiter_2, ref struct121_0);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0000A6CA File Offset: 0x000088CA
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_2, ref Class242.Struct121 struct121_0)
		{
			struct121_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct121>(ref taskAwaiter_2, ref struct121_0);
		}

		// Token: 0x04000903 RID: 2307
		public int int_0;

		// Token: 0x04000904 RID: 2308
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000905 RID: 2309
		private TaskAwaiter<Class534> taskAwaiter_0;

		// Token: 0x04000906 RID: 2310
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000205 RID: 517
	[StructLayout(LayoutKind.Auto)]
	private struct Struct122 : IAsyncStateMachine
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x0005096C File Offset: 0x0004EB6C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<Class534> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_C9;
					}
					if (Class242.class534_0 != null)
					{
						goto IL_90;
					}
					awaiter2 = Class242.smethod_0(false).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class534>, Class242.Struct122>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class534>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
				}
				awaiter2.GetResult();
				IL_90:
				awaiter = Class242.smethod_4().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct122>(ref awaiter, ref this);
					return;
				}
				IL_C9:
				awaiter.GetResult();
				IEnumerator<Class512> enumerator = Class242.class534_0.Tweaks.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 @class = enumerator.Current;
						string empty = string.Empty;
						if (Class195.dictionary_1.TryGetValue(@class.method_21(), out empty))
						{
							if (empty == "BEST")
							{
								@class.method_34();
							}
							else
							{
								@class.method_36();
							}
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
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

		// Token: 0x06000E02 RID: 3586 RVA: 0x0000A6D9 File Offset: 0x000088D9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000907 RID: 2311
		public int int_0;

		// Token: 0x04000908 RID: 2312
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000909 RID: 2313
		private TaskAwaiter<Class534> taskAwaiter_0;

		// Token: 0x0400090A RID: 2314
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x02000206 RID: 518
	[StructLayout(LayoutKind.Auto)]
	private struct Struct123 : IAsyncStateMachine
	{
		// Token: 0x06000E03 RID: 3587 RVA: 0x00050B18 File Offset: 0x0004ED18
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class265> result;
			try
			{
				if (num > 1)
				{
					this.list_0 = new List<Class265>();
				}
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<Class534> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
							goto IL_D6;
						}
						if (Class242.class534_0 != null)
						{
							goto IL_9F;
						}
						awaiter2 = Class242.smethod_0(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num3 = 0;
							num = 0;
							this.int_0 = num3;
							this.taskAwaiter_0 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class534>, Class242.Struct123>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class534>);
						int num4 = -1;
						num = -1;
						this.int_0 = num4;
					}
					awaiter2.GetResult();
					IL_9F:
					awaiter = Class242.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 1;
						num = 1;
						this.int_0 = num5;
						this.taskAwaiter_1 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class242.Struct123>(ref awaiter, ref this);
						return;
					}
					IL_D6:
					awaiter.GetResult();
					IEnumerator<Class512> enumerator = Class242.class534_0.Tweaks.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class512 @class = enumerator.Current;
							this.list_0.Add(new Class265
							{
								Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.Features,
								Name = @class.method_21(),
								State = @class.CurrentValueType
							});
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				catch
				{
				}
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0000A6E7 File Offset: 0x000088E7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400090B RID: 2315
		public int int_0;

		// Token: 0x0400090C RID: 2316
		public AsyncTaskMethodBuilder<List<Class265>> asyncTaskMethodBuilder_0;

		// Token: 0x0400090D RID: 2317
		private List<Class265> list_0;

		// Token: 0x0400090E RID: 2318
		private TaskAwaiter<Class534> taskAwaiter_0;

		// Token: 0x0400090F RID: 2319
		private TaskAwaiter taskAwaiter_1;
	}
}
