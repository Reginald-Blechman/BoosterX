using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x02000189 RID: 393
public sealed class GClass28
{
	// Token: 0x06000AFF RID: 2815 RVA: 0x00008B84 File Offset: 0x00006D84
	public static GClass180 smethod_0(bool bool_1)
	{
		if (!GClass28.bool_0 || bool_1)
		{
			GClass28.bool_0 = true;
			if (GClass28.gclass180_0 == null)
			{
				GClass28.gclass180_0 = new GClass180();
			}
			GClass28.gclass180_0.method_2();
		}
		return GClass28.gclass180_0;
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x000498AC File Offset: 0x00047AAC
	public static Task smethod_1()
	{
		GClass28.Struct80 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass28.Struct80>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400072D RID: 1837
	private static GClass180 gclass180_0;

	// Token: 0x0400072E RID: 1838
	private static bool bool_0;

	// Token: 0x0200018A RID: 394
	[StructLayout(LayoutKind.Auto)]
	private struct Struct80 : IAsyncStateMachine
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x000498E8 File Offset: 0x00047AE8
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
					goto IL_63;
				}
				this.int_1 = 0;
				IL_41:
				if (GClass28.gclass180_0.bool_0)
				{
					goto IL_B2;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass28.Struct80>(ref awaiter, ref this);
					return;
				}
				IL_63:
				awaiter.GetResult();
				if (this.int_1 <= 500)
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_41;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_B2:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00008BB8 File Offset: 0x00006DB8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400072F RID: 1839
		public int int_0;

		// Token: 0x04000730 RID: 1840
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000731 RID: 1841
		private int int_1;

		// Token: 0x04000732 RID: 1842
		private TaskAwaiter taskAwaiter_0;
	}
}
