using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x020003DB RID: 987
internal static class Class447
{
	// Token: 0x060019CF RID: 6607 RVA: 0x0007114C File Offset: 0x0006F34C
	public static void smethod_0(int int_0, CancellationToken cancellationToken_0)
	{
		Class447.Struct237 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_1 = int_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class447.Struct237>(ref @struct);
	}

	// Token: 0x020003DC RID: 988
	[StructLayout(LayoutKind.Auto)]
	private struct Struct237 : IAsyncStateMachine
	{
		// Token: 0x060019D0 RID: 6608 RVA: 0x0007118C File Offset: 0x0006F38C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new Class447.Class449
					{
						int_0 = this.int_1,
						cancellationToken_0 = this.cancellationToken_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class447.Struct237>(ref awaiter, ref this);
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

		// Token: 0x060019D1 RID: 6609 RVA: 0x00011626 File Offset: 0x0000F826
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010F6 RID: 4342
		public int int_0;

		// Token: 0x040010F7 RID: 4343
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040010F8 RID: 4344
		public int int_1;

		// Token: 0x040010F9 RID: 4345
		public CancellationToken cancellationToken_0;

		// Token: 0x040010FA RID: 4346
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003DD RID: 989
	private sealed class Class448
	{
		// Token: 0x060019D3 RID: 6611 RVA: 0x00071260 File Offset: 0x0006F460
		internal void method_0()
		{
			while (!this.cancellationToken_0.IsCancellationRequested)
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				while (stopwatch.ElapsedMilliseconds < (long)this.int_0 && !this.cancellationToken_0.IsCancellationRequested)
				{
					Math.Sin((double)stopwatch.ElapsedTicks);
				}
				if (this.double_0 > 0.0 && !this.cancellationToken_0.IsCancellationRequested)
				{
					Thread.Sleep((int)this.double_0);
				}
			}
		}

		// Token: 0x040010FB RID: 4347
		public int int_0;

		// Token: 0x040010FC RID: 4348
		public CancellationToken cancellationToken_0;

		// Token: 0x040010FD RID: 4349
		public double double_0;

		// Token: 0x040010FE RID: 4350
		public Action action_0;
	}

	// Token: 0x020003DE RID: 990
	private sealed class Class449
	{
		// Token: 0x060019D5 RID: 6613 RVA: 0x000712D8 File Offset: 0x0006F4D8
		internal void method_0()
		{
			Class447.Class448 @class = new Class447.Class448();
			if (this.int_0 < 1)
			{
				this.int_0 = 1;
			}
			if (this.int_0 > 10)
			{
				this.int_0 = 10;
			}
			using (CancellationTokenSource cancellationTokenSource = new CancellationTokenSource())
			{
				cancellationTokenSource.CancelAfter(TimeSpan.FromMinutes(2.0));
				using (CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(this.cancellationToken_0, cancellationTokenSource.Token))
				{
					@class.cancellationToken_0 = cancellationTokenSource2.Token;
					int processorCount = Environment.ProcessorCount;
					double num = (double)this.int_0 * 10.0;
					@class.int_0 = 20;
					@class.double_0 = (double)@class.int_0 * (100.0 / num - 1.0);
					Task[] array = new Task[processorCount];
					for (int i = 0; i < processorCount; i++)
					{
						Task[] array2 = array;
						int num2 = i;
						Action action;
						if ((action = @class.action_0) == null)
						{
							action = (@class.action_0 = new Action(@class.method_0));
						}
						array2[num2] = Task.Run(action, @class.cancellationToken_0);
					}
					Task.WaitAll(array);
				}
			}
		}

		// Token: 0x040010FF RID: 4351
		public int int_0;

		// Token: 0x04001100 RID: 4352
		public CancellationToken cancellationToken_0;
	}
}
