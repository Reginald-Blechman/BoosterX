using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x02000430 RID: 1072
public sealed class GClass149 : GClass143, GInterface13
{
	// Token: 0x06001BDD RID: 7133 RVA: 0x00012A84 File Offset: 0x00010C84
	internal GClass149(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x00012AA8 File Offset: 0x00010CA8
	[CompilerGenerated]
	public GClass271 imethod_0()
	{
		return this.gclass271_0;
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00012AB0 File Offset: 0x00010CB0
	[CompilerGenerated]
	public void imethod_1(GClass271 gclass271_1)
	{
		this.gclass271_0 = gclass271_1;
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x00012AB9 File Offset: 0x00010CB9
	protected override string vmethod_0()
	{
		return "embeddings";
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00077044 File Offset: 0x00075244
	public Task<GClass39> imethod_2(string string_0)
	{
		GClass149.Struct270 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass39>.Create();
		@struct.gclass149_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass149.Struct270>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x00077090 File Offset: 0x00075290
	public Task<GClass39> imethod_3(GClass271 gclass271_1)
	{
		GClass149.Struct271 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass39>.Create();
		@struct.gclass149_0 = this;
		@struct.gclass271_0 = gclass271_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass149.Struct271>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x000770DC File Offset: 0x000752DC
	public Task<float[]> imethod_4(string string_0)
	{
		GClass149.Struct269 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<float[]>.Create();
		@struct.gclass149_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass149.Struct269>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001295 RID: 4757
	private GClass271 gclass271_0 = new GClass271
	{
		String_0 = GClass27.smethod_29()
	};

	// Token: 0x02000431 RID: 1073
	[StructLayout(LayoutKind.Auto)]
	private struct Struct269 : IAsyncStateMachine
	{
		// Token: 0x06001BE4 RID: 7140 RVA: 0x00077128 File Offset: 0x00075328
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass149 gclass = this.gclass149_0;
			float[] result2;
			try
			{
				TaskAwaiter<GClass39> awaiter;
				if (num != 0)
				{
					GClass271 gclass271_ = new GClass271(gclass.imethod_0().String_0, this.string_0);
					awaiter = gclass.imethod_3(gclass271_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass39>, GClass149.Struct269>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass39>);
					this.int_0 = -1;
				}
				GClass39 result = awaiter.GetResult();
				float[] array;
				if (result == null)
				{
					array = null;
				}
				else
				{
					List<GClass241> list_ = result.List_0;
					if (list_ == null)
					{
						array = null;
					}
					else
					{
						GClass241 gclass2 = list_[0];
						array = ((gclass2 != null) ? gclass2.Single_0 : null);
					}
				}
				result2 = array;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00012AC1 File Offset: 0x00010CC1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001296 RID: 4758
		public int int_0;

		// Token: 0x04001297 RID: 4759
		public AsyncTaskMethodBuilder<float[]> asyncTaskMethodBuilder_0;

		// Token: 0x04001298 RID: 4760
		public GClass149 gclass149_0;

		// Token: 0x04001299 RID: 4761
		public string string_0;

		// Token: 0x0400129A RID: 4762
		private TaskAwaiter<GClass39> taskAwaiter_0;
	}

	// Token: 0x02000432 RID: 1074
	[StructLayout(LayoutKind.Auto)]
	private struct Struct270 : IAsyncStateMachine
	{
		// Token: 0x06001BE6 RID: 7142 RVA: 0x00077224 File Offset: 0x00075424
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass149 gclass = this.gclass149_0;
			GClass39 result;
			try
			{
				TaskAwaiter<GClass39> awaiter;
				if (num != 0)
				{
					GClass271 gclass271_ = new GClass271(gclass.imethod_0().String_0, this.string_0);
					awaiter = gclass.imethod_3(gclass271_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass39>, GClass149.Struct270>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass39>);
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

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00012ACF File Offset: 0x00010CCF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400129B RID: 4763
		public int int_0;

		// Token: 0x0400129C RID: 4764
		public AsyncTaskMethodBuilder<GClass39> asyncTaskMethodBuilder_0;

		// Token: 0x0400129D RID: 4765
		public GClass149 gclass149_0;

		// Token: 0x0400129E RID: 4766
		public string string_0;

		// Token: 0x0400129F RID: 4767
		private TaskAwaiter<GClass39> taskAwaiter_0;
	}

	// Token: 0x02000433 RID: 1075
	[StructLayout(LayoutKind.Auto)]
	private struct Struct271 : IAsyncStateMachine
	{
		// Token: 0x06001BE8 RID: 7144 RVA: 0x000772FC File Offset: 0x000754FC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass149 gclass = this.gclass149_0;
			GClass39 result;
			try
			{
				TaskAwaiter<GClass39> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass39>(null, this.gclass271_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass39>, GClass149.Struct271>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass39>);
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

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00012ADD File Offset: 0x00010CDD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040012A0 RID: 4768
		public int int_0;

		// Token: 0x040012A1 RID: 4769
		public AsyncTaskMethodBuilder<GClass39> asyncTaskMethodBuilder_0;

		// Token: 0x040012A2 RID: 4770
		public GClass149 gclass149_0;

		// Token: 0x040012A3 RID: 4771
		public GClass271 gclass271_0;

		// Token: 0x040012A4 RID: 4772
		private TaskAwaiter<GClass39> taskAwaiter_0;
	}
}
