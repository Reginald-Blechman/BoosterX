using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020005A1 RID: 1441
public static class GClass252
{
	// Token: 0x060024BE RID: 9406 RVA: 0x0008D448 File Offset: 0x0008B648
	public static Task<byte[]> smethod_0(Uri uri_0, string string_0, bool bool_0)
	{
		GClass252.Struct368 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<byte[]>.Create();
		@struct.uri_0 = uri_0;
		@struct.string_0 = string_0;
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass252.Struct368>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x020005A2 RID: 1442
	[StructLayout(LayoutKind.Auto)]
	private struct Struct368 : IAsyncStateMachine
	{
		// Token: 0x060024BF RID: 9407 RVA: 0x0008D49C File Offset: 0x0008B69C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			byte[] result2;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				TaskAwaiter<int> awaiter4;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				case 2:
					IL_14C:
					try
					{
						TaskAwaiter awaiter2;
						TaskAwaiter<byte[]> awaiter3;
						if (num != 1)
						{
							if (num == 2)
							{
								awaiter2 = this.taskAwaiter_2;
								this.taskAwaiter_2 = default(TaskAwaiter);
								int num3 = -1;
								num = -1;
								this.int_0 = num3;
								goto IL_257;
							}
							this.httpResponseMessage_0.EnsureSuccessStatusCode();
							awaiter3 = this.httpResponseMessage_0.Content.ReadAsByteArrayAsync().GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter3;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, GClass252.Struct368>(ref awaiter3, ref this);
								return;
							}
						}
						else
						{
							awaiter3 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<byte[]>);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						byte[] result = awaiter3.GetResult();
						this.byte_0 = result;
						awaiter2 = new FileStream(this.string_0 + "\\" + this.string_1, FileMode.Create).WriteAsync(this.byte_0, 0, this.byte_0.Length).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num6 = 2;
							num = 2;
							this.int_0 = num6;
							this.taskAwaiter_2 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass252.Struct368>(ref awaiter2, ref this);
							return;
						}
						IL_257:
						awaiter2.GetResult();
						result2 = this.byte_0;
						goto IL_2CD;
					}
					finally
					{
						if (num < 0 && this.httpResponseMessage_0 != null)
						{
							((IDisposable)this.httpResponseMessage_0).Dispose();
						}
					}
					goto IL_27F;
				case 3:
					goto IL_27F;
				default:
					this.string_1 = Class143.smethod_1(this.uri_0.ToString());
					if (this.bool_0 | !File.Exists(this.string_0 + "\\" + this.string_1))
					{
						awaiter = new HttpClient().GetAsync(this.uri_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num7 = 0;
							num = 0;
							this.int_0 = num7;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass252.Struct368>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						FileStream fileStream = new FileStream(this.string_0 + "\\" + this.string_1, FileMode.Open);
						this.byte_0 = new byte[fileStream.Length];
						awaiter4 = fileStream.ReadAsync(this.byte_0, 0, this.byte_0.Length).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							int num8 = 3;
							num = 3;
							this.int_0 = num8;
							this.taskAwaiter_3 = awaiter4;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, GClass252.Struct368>(ref awaiter4, ref this);
							return;
						}
						goto IL_29C;
					}
					break;
				}
				HttpResponseMessage result3 = awaiter.GetResult();
				this.httpResponseMessage_0 = result3;
				goto IL_14C;
				IL_27F:
				awaiter4 = this.taskAwaiter_3;
				this.taskAwaiter_3 = default(TaskAwaiter<int>);
				int num9 = -1;
				num = -1;
				this.int_0 = num9;
				IL_29C:
				awaiter4.GetResult();
				result2 = this.byte_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_1 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2CD:
			this.int_0 = -2;
			this.string_1 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x0001889A File Offset: 0x00016A9A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040017DE RID: 6110
		public int int_0;

		// Token: 0x040017DF RID: 6111
		public AsyncTaskMethodBuilder<byte[]> asyncTaskMethodBuilder_0;

		// Token: 0x040017E0 RID: 6112
		public Uri uri_0;

		// Token: 0x040017E1 RID: 6113
		public bool bool_0;

		// Token: 0x040017E2 RID: 6114
		public string string_0;

		// Token: 0x040017E3 RID: 6115
		private string string_1;

		// Token: 0x040017E4 RID: 6116
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x040017E5 RID: 6117
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040017E6 RID: 6118
		private byte[] byte_0;

		// Token: 0x040017E7 RID: 6119
		private TaskAwaiter<byte[]> taskAwaiter_1;

		// Token: 0x040017E8 RID: 6120
		private TaskAwaiter taskAwaiter_2;

		// Token: 0x040017E9 RID: 6121
		private TaskAwaiter<int> taskAwaiter_3;
	}
}
