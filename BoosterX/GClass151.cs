using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x02000508 RID: 1288
public sealed class GClass151 : GClass143, GInterface2
{
	// Token: 0x060020AC RID: 8364 RVA: 0x000083B1 File Offset: 0x000065B1
	internal GClass151(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x0001598B File Offset: 0x00013B8B
	protected override string vmethod_0()
	{
		return "images/generations";
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x000832F0 File Offset: 0x000814F0
	public Task<GClass40> imethod_1(string string_0, GClass27 gclass27_0 = null)
	{
		GClass151.Struct337 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass40>.Create();
		@struct.gclass151_0 = this;
		@struct.string_0 = string_0;
		@struct.gclass27_0 = gclass27_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass151.Struct337>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x00083344 File Offset: 0x00081544
	public Task<GClass40> imethod_0(GClass239 gclass239_0)
	{
		GClass151.Struct338 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass40>.Create();
		@struct.gclass151_0 = this;
		@struct.gclass239_0 = gclass239_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass151.Struct338>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x02000509 RID: 1289
	[StructLayout(LayoutKind.Auto)]
	private struct Struct337 : IAsyncStateMachine
	{
		// Token: 0x060020B0 RID: 8368 RVA: 0x00083390 File Offset: 0x00081590
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass151 gclass = this.gclass151_0;
			GClass40 result;
			try
			{
				TaskAwaiter<GClass40> awaiter;
				if (num != 0)
				{
					GClass239 gclass239_ = new GClass239(this.string_0, this.gclass27_0, null, "standard", null, null);
					awaiter = gclass.imethod_0(gclass239_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass40>, GClass151.Struct337>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass40>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00015993 File Offset: 0x00013B93
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400159F RID: 5535
		public int int_0;

		// Token: 0x040015A0 RID: 5536
		public AsyncTaskMethodBuilder<GClass40> asyncTaskMethodBuilder_0;

		// Token: 0x040015A1 RID: 5537
		public string string_0;

		// Token: 0x040015A2 RID: 5538
		public GClass27 gclass27_0;

		// Token: 0x040015A3 RID: 5539
		public GClass151 gclass151_0;

		// Token: 0x040015A4 RID: 5540
		private TaskAwaiter<GClass40> taskAwaiter_0;
	}

	// Token: 0x0200050A RID: 1290
	[StructLayout(LayoutKind.Auto)]
	private struct Struct338 : IAsyncStateMachine
	{
		// Token: 0x060020B2 RID: 8370 RVA: 0x00083464 File Offset: 0x00081664
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass151 gclass = this.gclass151_0;
			GClass40 result;
			try
			{
				TaskAwaiter<GClass40> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass40>(null, this.gclass239_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass40>, GClass151.Struct338>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass40>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x000159A1 File Offset: 0x00013BA1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015A5 RID: 5541
		public int int_0;

		// Token: 0x040015A6 RID: 5542
		public AsyncTaskMethodBuilder<GClass40> asyncTaskMethodBuilder_0;

		// Token: 0x040015A7 RID: 5543
		public GClass151 gclass151_0;

		// Token: 0x040015A8 RID: 5544
		public GClass239 gclass239_0;

		// Token: 0x040015A9 RID: 5545
		private TaskAwaiter<GClass40> taskAwaiter_0;
	}
}
