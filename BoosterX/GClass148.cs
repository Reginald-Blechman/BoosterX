using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020003FC RID: 1020
public sealed class GClass148 : GClass143, GInterface5
{
	// Token: 0x06001A3E RID: 6718 RVA: 0x00011AB6 File Offset: 0x0000FCB6
	internal GClass148(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x00011ADA File Offset: 0x0000FCDA
	[CompilerGenerated]
	public GClass113 imethod_0()
	{
		return this.gclass113_0;
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x00011AE2 File Offset: 0x0000FCE2
	[CompilerGenerated]
	public void imethod_1(GClass113 gclass113_1)
	{
		this.gclass113_0 = gclass113_1;
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x00011AEB File Offset: 0x0000FCEB
	protected override string vmethod_0()
	{
		return "moderations";
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x00073B38 File Offset: 0x00071D38
	public Task<GClass37> imethod_3(string string_0)
	{
		GClass148.Struct252 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass37>.Create();
		@struct.gclass148_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass148.Struct252>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x00073B84 File Offset: 0x00071D84
	public Task<GClass37> imethod_2(GClass113 gclass113_1)
	{
		GClass148.Struct253 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass37>.Create();
		@struct.gclass148_0 = this;
		@struct.gclass113_0 = gclass113_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass148.Struct253>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001186 RID: 4486
	private GClass113 gclass113_0 = new GClass113
	{
		String_0 = GClass27.smethod_31()
	};

	// Token: 0x020003FD RID: 1021
	[StructLayout(LayoutKind.Auto)]
	private struct Struct252 : IAsyncStateMachine
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x00073BD0 File Offset: 0x00071DD0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass148 gclass = this.gclass148_0;
			GClass37 result;
			try
			{
				TaskAwaiter<GClass37> awaiter;
				if (num != 0)
				{
					GClass113 gclass113_ = new GClass113(new string[]
					{
						this.string_0,
						gclass.imethod_0().String_0
					});
					awaiter = gclass.imethod_2(gclass113_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass37>, GClass148.Struct252>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass37>);
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

		// Token: 0x06001A45 RID: 6725 RVA: 0x00011AF3 File Offset: 0x0000FCF3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001187 RID: 4487
		public int int_0;

		// Token: 0x04001188 RID: 4488
		public AsyncTaskMethodBuilder<GClass37> asyncTaskMethodBuilder_0;

		// Token: 0x04001189 RID: 4489
		public string string_0;

		// Token: 0x0400118A RID: 4490
		public GClass148 gclass148_0;

		// Token: 0x0400118B RID: 4491
		private TaskAwaiter<GClass37> taskAwaiter_0;
	}

	// Token: 0x020003FE RID: 1022
	[StructLayout(LayoutKind.Auto)]
	private struct Struct253 : IAsyncStateMachine
	{
		// Token: 0x06001A46 RID: 6726 RVA: 0x00073CAC File Offset: 0x00071EAC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass148 gclass = this.gclass148_0;
			GClass37 result;
			try
			{
				TaskAwaiter<GClass37> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass37>(null, this.gclass113_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass37>, GClass148.Struct253>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass37>);
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

		// Token: 0x06001A47 RID: 6727 RVA: 0x00011B01 File Offset: 0x0000FD01
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400118C RID: 4492
		public int int_0;

		// Token: 0x0400118D RID: 4493
		public AsyncTaskMethodBuilder<GClass37> asyncTaskMethodBuilder_0;

		// Token: 0x0400118E RID: 4494
		public GClass148 gclass148_0;

		// Token: 0x0400118F RID: 4495
		public GClass113 gclass113_0;

		// Token: 0x04001190 RID: 4496
		private TaskAwaiter<GClass37> taskAwaiter_0;
	}
}
