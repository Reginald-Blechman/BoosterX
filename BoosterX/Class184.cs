using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x02000148 RID: 328
internal sealed class Class184
{
	// Token: 0x06000975 RID: 2421 RVA: 0x00045180 File Offset: 0x00043380
	public static Task<List<Class533>> smethod_0()
	{
		Class184.Struct62 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class533>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class184.Struct62>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x02000149 RID: 329
	[StructLayout(LayoutKind.Auto)]
	private struct Struct62 : IAsyncStateMachine
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x000451BC File Offset: 0x000433BC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class533> result2;
			try
			{
				TaskAwaiter<Class723> awaiter;
				if (num != 0)
				{
					awaiter = Class215.smethod_1("GetServers", null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class184.Struct62>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
					this.int_0 = -1;
				}
				Class723 result = awaiter.GetResult();
				if (!result.Success)
				{
					result2 = new List<Class533>
					{
						new Class533
						{
							City = "Frankfurt",
							Country = "de",
							IP = "172.104.129.111",
							Port = 27015
						},
						new Class533
						{
							City = "Hong Kong",
							Country = "hk",
							IP = "193.233.193.246",
							Port = 27015
						},
						new Class533
						{
							City = "Tokyo",
							Country = "jp",
							IP = "139.162.122.236",
							Port = 27015
						},
						new Class533
						{
							City = "California",
							Country = "us",
							IP = "185.219.7.79",
							Port = 27015
						}
					};
				}
				else
				{
					result2 = JsonConvert.DeserializeObject<List<Class533>>(result.Message);
				}
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

		// Token: 0x06000977 RID: 2423 RVA: 0x00007CAE File Offset: 0x00005EAE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400066F RID: 1647
		public int int_0;

		// Token: 0x04000670 RID: 1648
		public AsyncTaskMethodBuilder<List<Class533>> asyncTaskMethodBuilder_0;

		// Token: 0x04000671 RID: 1649
		private TaskAwaiter<Class723> taskAwaiter_0;
	}
}
