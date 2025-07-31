using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x020003CE RID: 974
public sealed class GClass147 : GClass143, GInterface10
{
	// Token: 0x06001992 RID: 6546 RVA: 0x000083B1 File Offset: 0x000065B1
	internal GClass147(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x000114F1 File Offset: 0x0000F6F1
	protected override string vmethod_0()
	{
		return "models";
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00070AB8 File Offset: 0x0006ECB8
	public Task<GClass27> imethod_0(string string_0)
	{
		GClass147.Struct234 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass27>.Create();
		@struct.gclass147_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass147.Struct234>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x00070B04 File Offset: 0x0006ED04
	public Task<List<GClass27>> imethod_2()
	{
		GClass147.Struct235 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<GClass27>>.Create();
		@struct.gclass147_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass147.Struct235>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x00070B48 File Offset: 0x0006ED48
	[Obsolete("Use the overload without the APIAuthentication parameter instead, as custom auth is no longer used.", false)]
	public Task<GClass27> imethod_1(string string_0, GClass30 gclass30_0 = null)
	{
		GClass147.Struct236 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass27>.Create();
		@struct.gclass147_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass147.Struct236>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x020003CF RID: 975
	[StructLayout(LayoutKind.Auto)]
	private struct Struct234 : IAsyncStateMachine
	{
		// Token: 0x06001997 RID: 6551 RVA: 0x00070B94 File Offset: 0x0006ED94
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass147 gclass = this.gclass147_0;
			GClass27 result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_4(gclass.method_0() + "/" + this.string_0, null, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass147.Struct234>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				result = JsonConvert.DeserializeObject<GClass27>(awaiter.GetResult());
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

		// Token: 0x06001998 RID: 6552 RVA: 0x000114F9 File Offset: 0x0000F6F9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010D7 RID: 4311
		public int int_0;

		// Token: 0x040010D8 RID: 4312
		public AsyncTaskMethodBuilder<GClass27> asyncTaskMethodBuilder_0;

		// Token: 0x040010D9 RID: 4313
		public GClass147 gclass147_0;

		// Token: 0x040010DA RID: 4314
		public string string_0;

		// Token: 0x040010DB RID: 4315
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020003D0 RID: 976
	[StructLayout(LayoutKind.Auto)]
	private struct Struct235 : IAsyncStateMachine
	{
		// Token: 0x06001999 RID: 6553 RVA: 0x00070C68 File Offset: 0x0006EE68
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass147 gclass = this.gclass147_0;
			List<GClass27> list_;
			try
			{
				TaskAwaiter<GClass147.Class205> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_7<GClass147.Class205>(null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass147.Class205>, GClass147.Struct235>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass147.Class205>);
					this.int_0 = -1;
				}
				list_ = awaiter.GetResult().List_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00011507 File Offset: 0x0000F707
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010DC RID: 4316
		public int int_0;

		// Token: 0x040010DD RID: 4317
		public AsyncTaskMethodBuilder<List<GClass27>> asyncTaskMethodBuilder_0;

		// Token: 0x040010DE RID: 4318
		public GClass147 gclass147_0;

		// Token: 0x040010DF RID: 4319
		private TaskAwaiter<GClass147.Class205> taskAwaiter_0;
	}

	// Token: 0x020003D1 RID: 977
	[StructLayout(LayoutKind.Auto)]
	private struct Struct236 : IAsyncStateMachine
	{
		// Token: 0x0600199B RID: 6555 RVA: 0x00070D24 File Offset: 0x0006EF24
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass147 gclass = this.gclass147_0;
			GClass27 result;
			try
			{
				TaskAwaiter<GClass27> awaiter;
				if (num != 0)
				{
					awaiter = gclass.imethod_0(this.string_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass27>, GClass147.Struct236>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass27>);
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

		// Token: 0x0600199C RID: 6556 RVA: 0x00011515 File Offset: 0x0000F715
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040010E0 RID: 4320
		public int int_0;

		// Token: 0x040010E1 RID: 4321
		public AsyncTaskMethodBuilder<GClass27> asyncTaskMethodBuilder_0;

		// Token: 0x040010E2 RID: 4322
		public GClass147 gclass147_0;

		// Token: 0x040010E3 RID: 4323
		public string string_0;

		// Token: 0x040010E4 RID: 4324
		private TaskAwaiter<GClass27> taskAwaiter_0;
	}

	// Token: 0x020003D2 RID: 978
	private sealed class Class205 : GClass33
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00011523 File Offset: 0x0000F723
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x0001152B File Offset: 0x0000F72B
		[JsonProperty("data")]
		public List<GClass27> List_0
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00011534 File Offset: 0x0000F734
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0001153C File Offset: 0x0000F73C
		[JsonProperty("object")]
		public string String_4
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		// Token: 0x040010E5 RID: 4325
		private List<GClass27> list_0;

		// Token: 0x040010E6 RID: 4326
		private string string_4;
	}
}
