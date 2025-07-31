using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

// Token: 0x020003F1 RID: 1009
public sealed class GClass135
{
	// Token: 0x06001A1F RID: 6687 RVA: 0x00072358 File Offset: 0x00070558
	public GClass135(HttpClient httpClient_1, string string_7)
	{
		this.httpClient_0 = httpClient_1;
		if (httpClient_1.BaseAddress == null)
		{
			httpClient_1.BaseAddress = new Uri(this.string_0);
		}
		if (this.httpClient_0.DefaultRequestHeaders.Authorization == null)
		{
			this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + string_7);
		}
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x00072444 File Offset: 0x00070644
	public GClass135(string string_7)
	{
		this.httpClient_0 = new HttpClient
		{
			BaseAddress = new Uri(this.string_0),
			Timeout = TimeSpan.FromSeconds(120.0)
		};
		this.httpClient_0.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + string_7);
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x00011A21 File Offset: 0x0000FC21
	public string method_0()
	{
		return this.string_6;
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x00011A29 File Offset: 0x0000FC29
	public void method_1(string string_7)
	{
		this.string_6 = string_7;
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x00011A32 File Offset: 0x0000FC32
	public void method_2(int int_0)
	{
		this.httpClient_0.Timeout = TimeSpan.FromSeconds((double)int_0);
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x00072530 File Offset: 0x00070730
	public Task<GClass274> method_3(CancellationToken cancellationToken_0)
	{
		GClass135.Struct250 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass274>.Create();
		@struct.gclass135_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass135.Struct250>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x0007257C File Offset: 0x0007077C
	public Task<GClass114> method_4(GClass58 gclass58_0, CancellationToken cancellationToken_0)
	{
		GClass135.Struct251 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass114>.Create();
		@struct.gclass135_0 = this;
		@struct.gclass58_0 = gclass58_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass135.Struct251>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x000725D0 File Offset: 0x000707D0
	public Task<IAsyncEnumerable<GClass109>> method_5(GClass58 gclass58_0, CancellationToken cancellationToken_0)
	{
		GClass135.Struct249 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IAsyncEnumerable<GClass109>>.Create();
		@struct.gclass135_0 = this;
		@struct.gclass58_0 = gclass58_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass135.Struct249>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x00072624 File Offset: 0x00070824
	public Task<GClass114> method_6(GClass297 gclass297_0, CancellationToken cancellationToken_0)
	{
		GClass135.Struct244 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass114>.Create();
		@struct.gclass135_0 = this;
		@struct.gclass297_0 = gclass297_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass135.Struct244>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x00072678 File Offset: 0x00070878
	public Task<IAsyncEnumerable<GClass109>> method_7(GClass297 gclass297_0, CancellationToken cancellationToken_0)
	{
		GClass135.Struct246 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IAsyncEnumerable<GClass109>>.Create();
		@struct.gclass135_0 = this;
		@struct.gclass297_0 = gclass297_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass135.Struct246>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x000726CC File Offset: 0x000708CC
	public Task<GClass249> method_8(CancellationToken cancellationToken_0)
	{
		GClass135.Struct245 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass249>.Create();
		@struct.gclass135_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass135.Struct245>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001138 RID: 4408
	public readonly string string_0 = "https://api.deepseek.com";

	// Token: 0x04001139 RID: 4409
	public readonly string string_1 = "https://api.deepseek.com/beta";

	// Token: 0x0400113A RID: 4410
	public readonly string string_2 = "/chat/completions";

	// Token: 0x0400113B RID: 4411
	public readonly string string_3 = "/completions";

	// Token: 0x0400113C RID: 4412
	public readonly string string_4 = "/user/balance";

	// Token: 0x0400113D RID: 4413
	public readonly string string_5 = "/models";

	// Token: 0x0400113E RID: 4414
	protected readonly HttpClient httpClient_0;

	// Token: 0x0400113F RID: 4415
	public JsonSerializerOptions jsonSerializerOptions_0 = new JsonSerializerOptions
	{
		ReferenceHandler = ReferenceHandler.IgnoreCycles,
		PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
		Encoder = JavaScriptEncoder.Create(new UnicodeRange[]
		{
			UnicodeRanges.All
		})
	};

	// Token: 0x04001140 RID: 4416
	private string string_6;

	// Token: 0x020003F2 RID: 1010
	[StructLayout(LayoutKind.Auto)]
	private struct Struct244 : IAsyncStateMachine
	{
		// Token: 0x06001A2A RID: 6698 RVA: 0x00072718 File Offset: 0x00070918
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass135 gclass = this.gclass135_0;
			GClass114 result3;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				TaskAwaiter<string> awaiter3;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					goto IL_16B;
				case 2:
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_22F;
				case 3:
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_27F;
				default:
				{
					this.gclass297_0.Stream = false;
					this.stringContent_0 = new StringContent(JsonSerializer.Serialize<GClass297>(this.gclass297_0, gclass.jsonSerializerOptions_0), Encoding.UTF8, "application/json");
					this.string_0 = gclass.string_3;
					Uri baseAddress = gclass.httpClient_0.BaseAddress;
					if (((baseAddress != null) ? baseAddress.OriginalString : null) == gclass.string_0)
					{
						this.string_0 = "/beta" + gclass.string_3;
					}
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass135.Struct244>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				awaiter.GetResult();
				awaiter2 = gclass.httpClient_0.PostAsync(this.string_0, this.stringContent_0, this.cancellationToken_0).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass135.Struct244>(ref awaiter2, ref this);
					return;
				}
				IL_16B:
				HttpResponseMessage result = awaiter2.GetResult();
				this.httpResponseMessage_0 = result;
				if (!this.httpResponseMessage_0.IsSuccessStatusCode)
				{
					awaiter3 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct244>(ref awaiter3, ref this);
						return;
					}
				}
				else
				{
					awaiter3 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.int_0 = 3;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct244>(ref awaiter3, ref this);
						return;
					}
					goto IL_27F;
				}
				IL_22F:
				string result2 = awaiter3.GetResult();
				gclass.method_1(this.httpResponseMessage_0.StatusCode.ToString() + result2);
				result3 = null;
				goto IL_2C2;
				IL_27F:
				result3 = JsonSerializer.Deserialize<GClass114>(awaiter3.GetResult(), gclass.jsonSerializerOptions_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.stringContent_0 = null;
				this.string_0 = null;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2C2:
			this.int_0 = -2;
			this.stringContent_0 = null;
			this.string_0 = null;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00011A46 File Offset: 0x0000FC46
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001141 RID: 4417
		public int int_0;

		// Token: 0x04001142 RID: 4418
		public AsyncTaskMethodBuilder<GClass114> asyncTaskMethodBuilder_0;

		// Token: 0x04001143 RID: 4419
		public GClass297 gclass297_0;

		// Token: 0x04001144 RID: 4420
		public GClass135 gclass135_0;

		// Token: 0x04001145 RID: 4421
		public CancellationToken cancellationToken_0;

		// Token: 0x04001146 RID: 4422
		private StringContent stringContent_0;

		// Token: 0x04001147 RID: 4423
		private string string_0;

		// Token: 0x04001148 RID: 4424
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001149 RID: 4425
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x0400114A RID: 4426
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;

		// Token: 0x0400114B RID: 4427
		private TaskAwaiter<string> taskAwaiter_2;
	}

	// Token: 0x020003F3 RID: 1011
	[StructLayout(LayoutKind.Auto)]
	private struct Struct245 : IAsyncStateMachine
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x00072A2C File Offset: 0x00070C2C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass135 gclass = this.gclass135_0;
			GClass249 result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				TaskAwaiter<string> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_150;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_1A3;
				case 3:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_206;
				default:
					awaiter = gclass.httpClient_0.GetAsync(gclass.string_4, this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass135.Struct245>(ref awaiter, ref this);
						return;
					}
					break;
				}
				HttpResponseMessage result = awaiter.GetResult();
				this.httpResponseMessage_0 = result;
				if (!this.httpResponseMessage_0.IsSuccessStatusCode)
				{
					awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct245>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct245>(ref awaiter2, ref this);
						return;
					}
					goto IL_1A3;
				}
				IL_150:
				string result2 = awaiter2.GetResult();
				gclass.method_1(this.httpResponseMessage_0.StatusCode.ToString() + result2);
				result3 = null;
				goto IL_23B;
				IL_1A3:
				awaiter2.GetResult();
				awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct245>(ref awaiter2, ref this);
					return;
				}
				IL_206:
				result3 = JsonSerializer.Deserialize<GClass249>(awaiter2.GetResult(), gclass.jsonSerializerOptions_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_23B:
			this.int_0 = -2;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00011A54 File Offset: 0x0000FC54
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400114C RID: 4428
		public int int_0;

		// Token: 0x0400114D RID: 4429
		public AsyncTaskMethodBuilder<GClass249> asyncTaskMethodBuilder_0;

		// Token: 0x0400114E RID: 4430
		public GClass135 gclass135_0;

		// Token: 0x0400114F RID: 4431
		public CancellationToken cancellationToken_0;

		// Token: 0x04001150 RID: 4432
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001151 RID: 4433
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001152 RID: 4434
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x020003F4 RID: 1012
	[StructLayout(LayoutKind.Auto)]
	private struct Struct246 : IAsyncStateMachine
	{
		// Token: 0x06001A2E RID: 6702 RVA: 0x00072CAC File Offset: 0x00070EAC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass135 gclass = this.gclass135_0;
			IAsyncEnumerable<GClass109> result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				TaskAwaiter<Stream> awaiter2;
				TaskAwaiter<string> awaiter3;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<Stream>);
					this.int_0 = -1;
					goto IL_1D6;
				case 2:
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_257;
				default:
				{
					this.class459_0 = new GClass135.Class459();
					this.class459_0.gclass135_0 = this.gclass135_0;
					this.gclass297_0.Stream = true;
					StringContent content = new StringContent(JsonSerializer.Serialize<GClass297>(this.gclass297_0, gclass.jsonSerializerOptions_0), Encoding.UTF8, "application/json");
					string requestUri = gclass.string_3;
					Uri baseAddress = gclass.httpClient_0.BaseAddress;
					if (((baseAddress != null) ? baseAddress.OriginalString : null) == gclass.string_0)
					{
						requestUri = "/beta" + gclass.string_3;
					}
					HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUri)
					{
						Content = content
					};
					awaiter = gclass.httpClient_0.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass135.Struct246>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				HttpResponseMessage result = awaiter.GetResult();
				if (result.IsSuccessStatusCode)
				{
					awaiter2 = result.Content.ReadAsStreamAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass135.Struct246>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter3 = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct246>(ref awaiter3, ref this);
						return;
					}
					goto IL_257;
				}
				IL_1D6:
				Stream result2 = awaiter2.GetResult();
				this.class459_0.streamReader_0 = new StreamReader(result2);
				this.class459_0.channel_0 = Channel.CreateUnbounded<GClass109>();
				Task.Run(new Func<Task>(this.class459_0.method_0));
				result3 = this.class459_0.channel_0.Reader.ReadAllAsync(default(CancellationToken));
				goto IL_28C;
				IL_257:
				string result4 = awaiter3.GetResult();
				gclass.method_1(result4);
				result3 = null;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class459_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_28C:
			this.int_0 = -2;
			this.class459_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00011A62 File Offset: 0x0000FC62
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001153 RID: 4435
		public int int_0;

		// Token: 0x04001154 RID: 4436
		public AsyncTaskMethodBuilder<IAsyncEnumerable<GClass109>> asyncTaskMethodBuilder_0;

		// Token: 0x04001155 RID: 4437
		public GClass135 gclass135_0;

		// Token: 0x04001156 RID: 4438
		public GClass297 gclass297_0;

		// Token: 0x04001157 RID: 4439
		public CancellationToken cancellationToken_0;

		// Token: 0x04001158 RID: 4440
		private GClass135.Class459 class459_0;

		// Token: 0x04001159 RID: 4441
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400115A RID: 4442
		private TaskAwaiter<Stream> taskAwaiter_1;

		// Token: 0x0400115B RID: 4443
		private TaskAwaiter<string> taskAwaiter_2;
	}

	// Token: 0x020003F5 RID: 1013
	private sealed class Class459
	{
		// Token: 0x06001A31 RID: 6705 RVA: 0x00072F7C File Offset: 0x0007117C
		internal Task method_0()
		{
			GClass135.Class459.Struct247 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class459_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass135.Class459.Struct247>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x0400115C RID: 4444
		public GClass135 gclass135_0;

		// Token: 0x0400115D RID: 4445
		public StreamReader streamReader_0;

		// Token: 0x0400115E RID: 4446
		public Channel<GClass109> channel_0;

		// Token: 0x020003F6 RID: 1014
		[StructLayout(LayoutKind.Auto)]
		private struct Struct247 : IAsyncStateMachine
		{
			// Token: 0x06001A32 RID: 6706 RVA: 0x00072FC0 File Offset: 0x000711C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass135.Class459 @class = this.class459_0;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						goto IL_FF;
					}
					if (num != 1)
					{
						goto IL_D7;
					}
					ValueTaskAwaiter awaiter2 = this.valueTaskAwaiter_0;
					this.valueTaskAwaiter_0 = default(ValueTaskAwaiter);
					this.int_0 = -1;
					IL_D0:
					awaiter2.GetResult();
					IL_D7:
					if (@class.streamReader_0.EndOfStream)
					{
						goto IL_15C;
					}
					awaiter = @class.streamReader_0.ReadLineAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Class459.Struct247>(ref awaiter, ref this);
						return;
					}
					IL_FF:
					string result = awaiter.GetResult();
					if (!(result == "data: [DONE]"))
					{
						if (string.IsNullOrWhiteSpace(result))
						{
							goto IL_D7;
						}
						GClass114 gclass = JsonSerializer.Deserialize<GClass114>(result.Replace("data:", string.Empty).Trim(), @class.gclass135_0.jsonSerializerOptions_0);
						GClass109 gclass2 = (gclass != null) ? gclass.Choices.First<GClass109>() : null;
						if (gclass2 == null)
						{
							goto IL_D7;
						}
						awaiter2 = @class.channel_0.Writer.WriteAsync(gclass2, default(CancellationToken)).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_D0;
						}
						this.int_0 = 1;
						this.valueTaskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass135.Class459.Struct247>(ref awaiter2, ref this);
						return;
					}
					IL_15C:
					@class.channel_0.Writer.Complete(null);
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

			// Token: 0x06001A33 RID: 6707 RVA: 0x00011A70 File Offset: 0x0000FC70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400115F RID: 4447
			public int int_0;

			// Token: 0x04001160 RID: 4448
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001161 RID: 4449
			public GClass135.Class459 class459_0;

			// Token: 0x04001162 RID: 4450
			private TaskAwaiter<string> taskAwaiter_0;

			// Token: 0x04001163 RID: 4451
			private ValueTaskAwaiter valueTaskAwaiter_0;
		}
	}

	// Token: 0x020003F7 RID: 1015
	private sealed class Class460
	{
		// Token: 0x06001A35 RID: 6709 RVA: 0x00073184 File Offset: 0x00071384
		internal Task method_0()
		{
			GClass135.Class460.Struct248 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class460_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass135.Class460.Struct248>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001164 RID: 4452
		public CancellationToken cancellationToken_0;

		// Token: 0x04001165 RID: 4453
		public GClass135 gclass135_0;

		// Token: 0x04001166 RID: 4454
		public StreamReader streamReader_0;

		// Token: 0x04001167 RID: 4455
		public Channel<GClass109> channel_0;

		// Token: 0x020003F8 RID: 1016
		[StructLayout(LayoutKind.Auto)]
		private struct Struct248 : IAsyncStateMachine
		{
			// Token: 0x06001A36 RID: 6710 RVA: 0x000731C8 File Offset: 0x000713C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass135.Class460 @class = this.class460_0;
				try
				{
					TaskAwaiter<string> awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						goto IL_10D;
					}
					if (num != 1)
					{
						goto IL_D7;
					}
					ValueTaskAwaiter awaiter2 = this.valueTaskAwaiter_0;
					this.valueTaskAwaiter_0 = default(ValueTaskAwaiter);
					this.int_0 = -1;
					IL_D0:
					awaiter2.GetResult();
					IL_D7:
					if (@class.streamReader_0.EndOfStream)
					{
						goto IL_16A;
					}
					@class.cancellationToken_0.ThrowIfCancellationRequested();
					awaiter = @class.streamReader_0.ReadLineAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Class460.Struct248>(ref awaiter, ref this);
						return;
					}
					IL_10D:
					string result = awaiter.GetResult();
					if (!(result == "data: [DONE]"))
					{
						if (string.IsNullOrWhiteSpace(result))
						{
							goto IL_D7;
						}
						GClass114 gclass = JsonSerializer.Deserialize<GClass114>(result.Replace("data:", string.Empty).Trim(), @class.gclass135_0.jsonSerializerOptions_0);
						GClass109 gclass2 = (gclass != null) ? Class746.smethod_0<GClass109>(gclass.Choices) : null;
						if (gclass2 == null)
						{
							goto IL_D7;
						}
						awaiter2 = @class.channel_0.Writer.WriteAsync(gclass2, default(CancellationToken)).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_D0;
						}
						this.int_0 = 1;
						this.valueTaskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass135.Class460.Struct248>(ref awaiter2, ref this);
						return;
					}
					IL_16A:
					@class.channel_0.Writer.Complete(null);
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

			// Token: 0x06001A37 RID: 6711 RVA: 0x00011A7E File Offset: 0x0000FC7E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001168 RID: 4456
			public int int_0;

			// Token: 0x04001169 RID: 4457
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400116A RID: 4458
			public GClass135.Class460 class460_0;

			// Token: 0x0400116B RID: 4459
			private TaskAwaiter<string> taskAwaiter_0;

			// Token: 0x0400116C RID: 4460
			private ValueTaskAwaiter valueTaskAwaiter_0;
		}
	}

	// Token: 0x020003F9 RID: 1017
	[StructLayout(LayoutKind.Auto)]
	private struct Struct249 : IAsyncStateMachine
	{
		// Token: 0x06001A38 RID: 6712 RVA: 0x0007339C File Offset: 0x0007159C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass135 gclass = this.gclass135_0;
			IAsyncEnumerable<GClass109> result3;
			try
			{
				HttpRequestMessage request;
				if (num > 2)
				{
					this.class460_0 = new GClass135.Class460();
					this.class460_0.cancellationToken_0 = this.cancellationToken_0;
					this.class460_0.gclass135_0 = this.gclass135_0;
					this.gclass58_0.Stream = true;
					StringContent content = new StringContent(JsonSerializer.Serialize<GClass58>(this.gclass58_0, gclass.jsonSerializerOptions_0), Encoding.UTF8, "application/json");
					request = new HttpRequestMessage(HttpMethod.Post, gclass.string_2)
					{
						Content = content
					};
				}
				try
				{
					TaskAwaiter<HttpResponseMessage> awaiter;
					TaskAwaiter<Stream> awaiter2;
					TaskAwaiter<string> awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						this.int_0 = -1;
						break;
					case 1:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<Stream>);
						this.int_0 = -1;
						goto IL_1CB;
					case 2:
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						goto IL_25A;
					default:
						awaiter = gclass.httpClient_0.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, this.class460_0.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass135.Struct249>(ref awaiter, ref this);
							return;
						}
						break;
					}
					HttpResponseMessage result = awaiter.GetResult();
					this.httpResponseMessage_0 = result;
					if (this.httpResponseMessage_0.IsSuccessStatusCode)
					{
						awaiter2 = this.httpResponseMessage_0.Content.ReadAsStreamAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass135.Struct249>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter3 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_2 = awaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct249>(ref awaiter3, ref this);
							return;
						}
						goto IL_25A;
					}
					IL_1CB:
					Stream result2 = awaiter2.GetResult();
					this.class460_0.streamReader_0 = new StreamReader(result2);
					this.class460_0.channel_0 = Channel.CreateUnbounded<GClass109>();
					Task.Run(new Func<Task>(this.class460_0.method_0), this.class460_0.cancellationToken_0);
					result3 = this.class460_0.channel_0.Reader.ReadAllAsync(default(CancellationToken));
					goto IL_2DF;
					IL_25A:
					string result4 = awaiter3.GetResult();
					gclass.method_1(this.httpResponseMessage_0.StatusCode.ToString() + result4);
					result3 = null;
				}
				catch (OperationCanceledException)
				{
					if (this.class460_0.cancellationToken_0.IsCancellationRequested)
					{
						gclass.method_1("The request timed out after 10 seconds.");
					}
					else
					{
						gclass.method_1("The request was cancelled.");
					}
					result3 = null;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class460_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2DF:
			this.int_0 = -2;
			this.class460_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00011A8C File Offset: 0x0000FC8C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400116D RID: 4461
		public int int_0;

		// Token: 0x0400116E RID: 4462
		public AsyncTaskMethodBuilder<IAsyncEnumerable<GClass109>> asyncTaskMethodBuilder_0;

		// Token: 0x0400116F RID: 4463
		public CancellationToken cancellationToken_0;

		// Token: 0x04001170 RID: 4464
		public GClass135 gclass135_0;

		// Token: 0x04001171 RID: 4465
		public GClass58 gclass58_0;

		// Token: 0x04001172 RID: 4466
		private GClass135.Class460 class460_0;

		// Token: 0x04001173 RID: 4467
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001174 RID: 4468
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001175 RID: 4469
		private TaskAwaiter<Stream> taskAwaiter_1;

		// Token: 0x04001176 RID: 4470
		private TaskAwaiter<string> taskAwaiter_2;
	}

	// Token: 0x020003FA RID: 1018
	[StructLayout(LayoutKind.Auto)]
	private struct Struct250 : IAsyncStateMachine
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x000736D8 File Offset: 0x000718D8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass135 gclass = this.gclass135_0;
			GClass274 result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				TaskAwaiter<string> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_14C;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_19C;
				default:
					awaiter = gclass.httpClient_0.GetAsync(gclass.string_5, this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass135.Struct250>(ref awaiter, ref this);
						return;
					}
					break;
				}
				HttpResponseMessage result = awaiter.GetResult();
				this.httpResponseMessage_0 = result;
				if (!this.httpResponseMessage_0.IsSuccessStatusCode)
				{
					awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct250>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct250>(ref awaiter2, ref this);
						return;
					}
					goto IL_19C;
				}
				IL_14C:
				string result2 = awaiter2.GetResult();
				gclass.method_1(this.httpResponseMessage_0.StatusCode.ToString() + result2);
				result3 = null;
				goto IL_1D1;
				IL_19C:
				result3 = JsonSerializer.Deserialize<GClass274>(awaiter2.GetResult(), gclass.jsonSerializerOptions_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1D1:
			this.int_0 = -2;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00011A9A File Offset: 0x0000FC9A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001177 RID: 4471
		public int int_0;

		// Token: 0x04001178 RID: 4472
		public AsyncTaskMethodBuilder<GClass274> asyncTaskMethodBuilder_0;

		// Token: 0x04001179 RID: 4473
		public GClass135 gclass135_0;

		// Token: 0x0400117A RID: 4474
		public CancellationToken cancellationToken_0;

		// Token: 0x0400117B RID: 4475
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x0400117C RID: 4476
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400117D RID: 4477
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x020003FB RID: 1019
	[StructLayout(LayoutKind.Auto)]
	private struct Struct251 : IAsyncStateMachine
	{
		// Token: 0x06001A3C RID: 6716 RVA: 0x000738F0 File Offset: 0x00071AF0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass135 gclass = this.gclass135_0;
			GClass114 result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				TaskAwaiter<string> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_17D;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_1CD;
				default:
				{
					this.gclass58_0.Stream = false;
					StringContent content = new StringContent(JsonSerializer.Serialize<GClass58>(this.gclass58_0, gclass.jsonSerializerOptions_0), Encoding.UTF8, "application/json");
					awaiter = gclass.httpClient_0.PostAsync(gclass.string_2, content, this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass135.Struct251>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				HttpResponseMessage result = awaiter.GetResult();
				this.httpResponseMessage_0 = result;
				if (!this.httpResponseMessage_0.IsSuccessStatusCode)
				{
					awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct251>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass135.Struct251>(ref awaiter2, ref this);
						return;
					}
					goto IL_1CD;
				}
				IL_17D:
				string result2 = awaiter2.GetResult();
				gclass.method_1(this.httpResponseMessage_0.StatusCode.ToString() + result2);
				result3 = null;
				goto IL_202;
				IL_1CD:
				result3 = JsonSerializer.Deserialize<GClass114>(awaiter2.GetResult(), gclass.jsonSerializerOptions_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_202:
			this.int_0 = -2;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result3);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400117E RID: 4478
		public int int_0;

		// Token: 0x0400117F RID: 4479
		public AsyncTaskMethodBuilder<GClass114> asyncTaskMethodBuilder_0;

		// Token: 0x04001180 RID: 4480
		public GClass58 gclass58_0;

		// Token: 0x04001181 RID: 4481
		public GClass135 gclass135_0;

		// Token: 0x04001182 RID: 4482
		public CancellationToken cancellationToken_0;

		// Token: 0x04001183 RID: 4483
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001184 RID: 4484
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001185 RID: 4485
		private TaskAwaiter<string> taskAwaiter_1;
	}
}
