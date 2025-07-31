using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using IGDB;
using IGDB.Models;

// Token: 0x020004EB RID: 1259
internal sealed class Class602
{
	// Token: 0x06001FEA RID: 8170 RVA: 0x00081ED8 File Offset: 0x000800D8
	public static Task<string> smethod_0(string string_0)
	{
		Class602.Struct333 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class602.Struct333>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x00081F1C File Offset: 0x0008011C
	public static Task<string> smethod_1(string string_0)
	{
		Class602.Class603 @class = new Class602.Class603();
		@class.string_0 = string_0;
		return Task.Factory.StartNew<Task<string>>(new Func<Task<string>>(@class.method_0), TaskCreationOptions.LongRunning).Unwrap<string>();
	}

	// Token: 0x04001547 RID: 5447
	private static IGDBClient igdbclient_0 = new IGDBClient("6pcw6lgoq8xu5keworn22b8ndrwfik", "q5iwgob781l9xo3z4szjy2zq02l66q");

	// Token: 0x020004EC RID: 1260
	private sealed class Class603
	{
		// Token: 0x06001FED RID: 8173 RVA: 0x00081F54 File Offset: 0x00080154
		internal Task<string> method_0()
		{
			Class602.Class603.Struct332 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
			@struct.class603_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class602.Class603.Struct332>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001548 RID: 5448
		public string string_0;

		// Token: 0x020004ED RID: 1261
		[StructLayout(LayoutKind.Auto)]
		private struct Struct332 : IAsyncStateMachine
		{
			// Token: 0x06001FEE RID: 8174 RVA: 0x00081F98 File Offset: 0x00080198
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class602.Class603 @class = this.class603_0;
				string result2;
				try
				{
					TaskAwaiter<Game[]> awaiter;
					if (num != 0)
					{
						awaiter = Class602.igdbclient_0.QueryAsync<Game>("games", "search \"" + @class.string_0 + "\"; fields cover.*;").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Game[]>, Class602.Class603.Struct332>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Game[]>);
						this.int_0 = -1;
					}
					Game[] result = awaiter.GetResult();
					if (result != null && result.Count<Game>() != 0)
					{
						string imageId = result[0].Cover.Value.ImageId;
						result2 = "https://images.igdb.com/igdb/image/upload/t_cover_big/" + imageId + ".png";
					}
					else
					{
						result2 = string.Empty;
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

			// Token: 0x06001FEF RID: 8175 RVA: 0x000151EB File Offset: 0x000133EB
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001549 RID: 5449
			public int int_0;

			// Token: 0x0400154A RID: 5450
			public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

			// Token: 0x0400154B RID: 5451
			public Class602.Class603 class603_0;

			// Token: 0x0400154C RID: 5452
			private TaskAwaiter<Game[]> taskAwaiter_0;
		}
	}

	// Token: 0x020004EE RID: 1262
	[StructLayout(LayoutKind.Auto)]
	private struct Struct333 : IAsyncStateMachine
	{
		// Token: 0x06001FF0 RID: 8176 RVA: 0x000820B0 File Offset: 0x000802B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				if (num > 1)
				{
					if (this.string_0 == "cs2")
					{
						this.string_0 = "Counter-Strike 2";
					}
					this.string_1 = Class169.string_0 + "\\" + this.string_0 + ".png";
					if (!Directory.Exists(Class169.string_0))
					{
						Directory.CreateDirectory(Class169.string_0);
					}
					if (File.Exists(this.string_1))
					{
						goto IL_1D7;
					}
				}
				try
				{
					TaskAwaiter<Game[]> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_12D;
						}
						awaiter = Class602.igdbclient_0.QueryAsync<Game>("games", "search \"" + this.string_0 + "\"; fields cover.*;").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Game[]>, Class602.Struct333>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Game[]>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					string imageId = awaiter.GetResult()[0].Cover.Value.ImageId;
					string requestUri = "https://images.igdb.com/igdb/image/upload/t_cover_big/" + imageId + ".png";
					this.httpClient_0 = new HttpClient();
					IL_12D:
					try
					{
						TaskAwaiter<byte[]> awaiter2;
						if (num != 1)
						{
							awaiter2 = this.httpClient_0.GetByteArrayAsync(requestUri).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, Class602.Struct333>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<byte[]>);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						byte[] result = awaiter2.GetResult();
						File.WriteAllBytes(this.string_1, result);
					}
					catch
					{
					}
					finally
					{
						if (num < 0 && this.httpClient_0 != null)
						{
							((IDisposable)this.httpClient_0).Dispose();
						}
					}
					this.httpClient_0 = null;
					result2 = this.string_1;
					goto IL_200;
				}
				catch
				{
					result2 = null;
					goto IL_200;
				}
				IL_1D7:
				result2 = this.string_1;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_1 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_200:
			this.int_0 = -2;
			this.string_1 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000151F9 File Offset: 0x000133F9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400154D RID: 5453
		public int int_0;

		// Token: 0x0400154E RID: 5454
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x0400154F RID: 5455
		public string string_0;

		// Token: 0x04001550 RID: 5456
		private string string_1;

		// Token: 0x04001551 RID: 5457
		private TaskAwaiter<Game[]> taskAwaiter_0;

		// Token: 0x04001552 RID: 5458
		private HttpClient httpClient_0;

		// Token: 0x04001553 RID: 5459
		private TaskAwaiter<byte[]> taskAwaiter_1;
	}
}
