using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200030A RID: 778
public sealed class GClass101 : IDisposable
{
	// Token: 0x06001420 RID: 5152 RVA: 0x0000E1FF File Offset: 0x0000C3FF
	public GClass101(string string_2, string string_3)
	{
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x0000E215 File Offset: 0x0000C415
	private bool method_0()
	{
		return this.bool_0;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0000E21D File Offset: 0x0000C41D
	private void method_1(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x000631A8 File Offset: 0x000613A8
	public void method_2(GClass101.GDelegate0 gdelegate0_1)
	{
		GClass101.GDelegate0 gdelegate = this.gdelegate0_0;
		GClass101.GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass101.GDelegate0 value = (GClass101.GDelegate0)Delegate.Combine(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GClass101.GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x000631E0 File Offset: 0x000613E0
	public void method_3(GClass101.GDelegate0 gdelegate0_1)
	{
		GClass101.GDelegate0 gdelegate = this.gdelegate0_0;
		GClass101.GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass101.GDelegate0 value = (GClass101.GDelegate0)Delegate.Remove(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GClass101.GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x00063218 File Offset: 0x00061418
	public Task method_4()
	{
		GClass101.Struct170 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass101_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass101.Struct170>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x0006325C File Offset: 0x0006145C
	private Task method_5(HttpResponseMessage httpResponseMessage_0)
	{
		GClass101.Struct171 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass101_0 = this;
		@struct.httpResponseMessage_0 = httpResponseMessage_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass101.Struct171>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x000632A8 File Offset: 0x000614A8
	private Task method_6(long? nullable_0, Stream stream_0)
	{
		GClass101.Struct172 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass101_0 = this;
		@struct.nullable_0 = nullable_0;
		@struct.stream_0 = stream_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass101.Struct172>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x0000E226 File Offset: 0x0000C426
	public void Dispose()
	{
		HttpClient httpClient = this.httpClient_0;
		if (httpClient == null)
		{
			return;
		}
		httpClient.Dispose();
	}

	// Token: 0x04000D80 RID: 3456
	private readonly string string_0;

	// Token: 0x04000D81 RID: 3457
	private readonly string string_1;

	// Token: 0x04000D82 RID: 3458
	private bool bool_0;

	// Token: 0x04000D83 RID: 3459
	private HttpClient httpClient_0;

	// Token: 0x04000D84 RID: 3460
	private GClass101.GDelegate0 gdelegate0_0;

	// Token: 0x0200030B RID: 779
	[StructLayout(LayoutKind.Auto)]
	private struct Struct170 : IAsyncStateMachine
	{
		// Token: 0x06001429 RID: 5161 RVA: 0x000632FC File Offset: 0x000614FC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass101 gclass = this.gclass101_0;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_A8;
					}
					gclass.httpClient_0 = new HttpClient
					{
						Timeout = TimeSpan.FromDays(1.0)
					};
					awaiter = gclass.httpClient_0.GetAsync(gclass.string_0, HttpCompletionOption.ResponseHeadersRead).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass101.Struct170>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				HttpResponseMessage result = awaiter.GetResult();
				this.httpResponseMessage_0 = result;
				IL_A8:
				try
				{
					TaskAwaiter awaiter2;
					if (num != 1)
					{
						awaiter2 = gclass.method_5(this.httpResponseMessage_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num4 = 1;
							num = 1;
							this.int_0 = num4;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass101.Struct170>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
					}
					awaiter2.GetResult();
				}
				finally
				{
					if (num < 0 && this.httpResponseMessage_0 != null)
					{
						((IDisposable)this.httpResponseMessage_0).Dispose();
					}
				}
				this.httpResponseMessage_0 = null;
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

		// Token: 0x0600142A RID: 5162 RVA: 0x0000E238 File Offset: 0x0000C438
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D85 RID: 3461
		public int int_0;

		// Token: 0x04000D86 RID: 3462
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000D87 RID: 3463
		public GClass101 gclass101_0;

		// Token: 0x04000D88 RID: 3464
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04000D89 RID: 3465
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04000D8A RID: 3466
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200030C RID: 780
	// (Invoke) Token: 0x0600142C RID: 5164
	public delegate bool GDelegate0(long? nullable_0, long long_0);

	// Token: 0x0200030D RID: 781
	[StructLayout(LayoutKind.Auto)]
	private struct Struct171 : IAsyncStateMachine
	{
		// Token: 0x0600142F RID: 5167 RVA: 0x00063498 File Offset: 0x00061698
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass101 gclass = this.gclass101_0;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_AE;
					}
					this.httpResponseMessage_0.EnsureSuccessStatusCode();
					this.nullable_0 = this.httpResponseMessage_0.Content.Headers.ContentLength;
					awaiter = this.httpResponseMessage_0.Content.ReadAsStreamAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass101.Struct171>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Stream>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				Stream result = awaiter.GetResult();
				this.stream_0 = result;
				IL_AE:
				try
				{
					TaskAwaiter awaiter2;
					if (num != 1)
					{
						awaiter2 = gclass.method_6(this.nullable_0, this.stream_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num4 = 1;
							num = 1;
							this.int_0 = num4;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass101.Struct171>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
					}
					awaiter2.GetResult();
				}
				finally
				{
					if (num < 0 && this.stream_0 != null)
					{
						((IDisposable)this.stream_0).Dispose();
					}
				}
				this.stream_0 = null;
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

		// Token: 0x06001430 RID: 5168 RVA: 0x0000E246 File Offset: 0x0000C446
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D8B RID: 3467
		public int int_0;

		// Token: 0x04000D8C RID: 3468
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000D8D RID: 3469
		public HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04000D8E RID: 3470
		public GClass101 gclass101_0;

		// Token: 0x04000D8F RID: 3471
		private long? nullable_0;

		// Token: 0x04000D90 RID: 3472
		private Stream stream_0;

		// Token: 0x04000D91 RID: 3473
		private TaskAwaiter<Stream> taskAwaiter_0;

		// Token: 0x04000D92 RID: 3474
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200030E RID: 782
	[StructLayout(LayoutKind.Auto)]
	private struct Struct172 : IAsyncStateMachine
	{
		// Token: 0x06001431 RID: 5169 RVA: 0x00063640 File Offset: 0x00061840
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass101 gclass = this.gclass101_0;
			try
			{
				if (num > 1)
				{
					this.long_0 = 0L;
					this.long_1 = 0L;
					this.byte_0 = new byte[8192];
					this.bool_0 = true;
					this.fileStream_0 = new FileStream(gclass.string_1, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);
				}
				try
				{
					TaskAwaiter<int> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<int>);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_18E;
					}
					if (num != 1)
					{
						goto IL_141;
					}
					TaskAwaiter awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					IL_D7:
					awaiter2.GetResult();
					this.long_0 += (long)this.int_1;
					this.long_1 += 1L;
					if (this.long_1 % 100L == 0L && gclass.gdelegate0_0(this.nullable_0, this.long_0))
					{
						throw new OperationCanceledException();
					}
					IL_136:
					if (!this.bool_0)
					{
						goto IL_215;
					}
					IL_141:
					awaiter = this.stream_0.ReadAsync(this.byte_0, 0, this.byte_0.Length).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num4 = 0;
						num = 0;
						this.int_0 = num4;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, GClass101.Struct172>(ref awaiter, ref this);
						return;
					}
					IL_18E:
					int result = awaiter.GetResult();
					this.int_1 = result;
					if (this.int_1 == 0)
					{
						this.bool_0 = false;
						if (gclass.gdelegate0_0(this.nullable_0, this.long_0))
						{
							throw new OperationCanceledException();
						}
						goto IL_136;
					}
					else
					{
						awaiter2 = this.fileStream_0.WriteAsync(this.byte_0, 0, this.int_1).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_D7;
						}
						int num5 = 1;
						num = 1;
						this.int_0 = num5;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass101.Struct172>(ref awaiter2, ref this);
						return;
					}
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
					}
				}
				IL_215:
				this.fileStream_0 = null;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.byte_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.byte_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0000E254 File Offset: 0x0000C454
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000D93 RID: 3475
		public int int_0;

		// Token: 0x04000D94 RID: 3476
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000D95 RID: 3477
		public GClass101 gclass101_0;

		// Token: 0x04000D96 RID: 3478
		public Stream stream_0;

		// Token: 0x04000D97 RID: 3479
		public long? nullable_0;

		// Token: 0x04000D98 RID: 3480
		private long long_0;

		// Token: 0x04000D99 RID: 3481
		private long long_1;

		// Token: 0x04000D9A RID: 3482
		private byte[] byte_0;

		// Token: 0x04000D9B RID: 3483
		private bool bool_0;

		// Token: 0x04000D9C RID: 3484
		private FileStream fileStream_0;

		// Token: 0x04000D9D RID: 3485
		private int int_1;

		// Token: 0x04000D9E RID: 3486
		private TaskAwaiter<int> taskAwaiter_0;

		// Token: 0x04000D9F RID: 3487
		private TaskAwaiter taskAwaiter_1;
	}
}
