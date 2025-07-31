using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Newtonsoft.Json;

// Token: 0x02000418 RID: 1048
public abstract class GClass143
{
	// Token: 0x06001B72 RID: 7026 RVA: 0x00012693 File Offset: 0x00010893
	internal GClass143(GClass11 gclass11_1)
	{
		this.gclass11_0 = gclass11_1;
	}

	// Token: 0x06001B73 RID: 7027
	protected abstract string vmethod_0();

	// Token: 0x06001B74 RID: 7028 RVA: 0x000126A2 File Offset: 0x000108A2
	protected string method_0()
	{
		return string.Format(this.gclass11_0.imethod_0(), this.gclass11_0.imethod_2(), this.vmethod_0());
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x000754A0 File Offset: 0x000736A0
	protected HttpClient method_1()
	{
		GClass30 gclass = this.gclass11_0.imethod_4();
		if (((gclass != null) ? gclass.method_0() : null) == null)
		{
			throw new AuthenticationException("You must provide API authentication.  Please refer to https://github.com/OkGoDoIt/OpenAI-API-dotnet#authentication for details.");
		}
		IHttpClientFactory httpClientFactory = this.gclass11_0.method_2();
		HttpClient httpClient;
		if (httpClientFactory != null)
		{
			httpClient = HttpClientFactoryExtensions.CreateClient(httpClientFactory);
		}
		else
		{
			httpClient = new HttpClient(new HttpClientHandler
			{
				UseProxy = true,
				Proxy = new WebProxy("http://147.45.114.104:3128")
				{
					Credentials = new NetworkCredential("boosterx", "boosterxx")
				}
			});
		}
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.gclass11_0.imethod_4().method_0());
		httpClient.DefaultRequestHeaders.Add("api-key", this.gclass11_0.imethod_4().method_0());
		httpClient.DefaultRequestHeaders.Add("User-Agent", "okgodoit/dotnet_openai_api");
		if (!string.IsNullOrEmpty(this.gclass11_0.imethod_4().method_2()))
		{
			httpClient.DefaultRequestHeaders.Add("OpenAI-Organization", this.gclass11_0.imethod_4().method_2());
		}
		return httpClient;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x000126C5 File Offset: 0x000108C5
	protected string method_2(string string_0, HttpResponseMessage httpResponseMessage_0, string string_1, string string_2)
	{
		return string.Format("Error at {0} ({1}) with HTTP status code: {2}. Content: {3}", new object[]
		{
			string_1,
			string_2,
			httpResponseMessage_0.StatusCode,
			string_0 ?? "<no content>"
		});
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x000755BC File Offset: 0x000737BC
	private Task<HttpResponseMessage> method_3(string string_0, HttpMethod httpMethod_0, object object_0, bool bool_0)
	{
		GClass143.Struct266 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct266>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x00075620 File Offset: 0x00073820
	internal Task<string> method_4(string string_0, HttpMethod httpMethod_0, object object_0)
	{
		GClass143.Struct265 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct265>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x0007567C File Offset: 0x0007387C
	internal Task<Stream> method_5(string string_0, HttpMethod httpMethod_0, object object_0)
	{
		GClass143.Struct263 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Stream>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct263>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x000756D8 File Offset: 0x000738D8
	private Task<T> method_6<T>(string string_0, HttpMethod httpMethod_0, object object_0) where T : GClass33
	{
		GClass143.Struct264<T> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<T>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct264<T>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x00075734 File Offset: 0x00073934
	internal Task<T> method_7<T>(string string_0) where T : GClass33
	{
		GClass143.Struct260<T> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<T>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct260<T>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x00075780 File Offset: 0x00073980
	internal Task<T> method_8<T>(string string_0, object object_0) where T : GClass33
	{
		GClass143.Struct261<T> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<T>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct261<T>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x000757D4 File Offset: 0x000739D4
	internal Task<T> method_9<T>(string string_0, object object_0) where T : GClass33
	{
		GClass143.Struct267<T> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<T>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct267<T>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x00075828 File Offset: 0x00073A28
	internal Task<T> method_10<T>(string string_0, object object_0) where T : GClass33
	{
		GClass143.Struct262<T> @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<T>.Create();
		@struct.gclass143_0 = this;
		@struct.string_0 = string_0;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass143.Struct262<T>>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x000126FD File Offset: 0x000108FD
	[AsyncIteratorStateMachine(typeof(GClass143.Class470<>))]
	protected IAsyncEnumerable<T> method_11<T>(string string_0, HttpMethod httpMethod_0, object object_0) where T : GClass33
	{
		return new GClass143.Class470<T>(-2)
		{
			gclass143_0 = this,
			string_1 = string_0,
			httpMethod_1 = httpMethod_0,
			object_1 = object_0
		};
	}

	// Token: 0x04001225 RID: 4645
	protected readonly GClass11 gclass11_0;

	// Token: 0x02000419 RID: 1049
	private sealed class Class470<T> : IValueTaskSource<bool>, IAsyncEnumerable<T>, IAsyncEnumerator<T>, IAsyncStateMachine, IAsyncDisposable, IValueTaskSource where T : GClass33
	{
		// Token: 0x06001B80 RID: 7040 RVA: 0x00012722 File Offset: 0x00010922
		[DebuggerHidden]
		public Class470(int int_2)
		{
			this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0007587C File Offset: 0x00073A7C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter2;
				TaskAwaiter<Stream> awaiter3;
				switch (num)
				{
				case -4:
				case 2:
					IL_218:
					try
					{
						if (num != -4 && num != 2)
						{
							this.streamReader_0 = new StreamReader(this.stream_0);
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num != -4)
							{
								if (num != 2)
								{
									goto IL_2E2;
								}
								awaiter = this.taskAwaiter_2;
								this.taskAwaiter_2 = default(TaskAwaiter<string>);
								int num2 = -1;
								num = -1;
								this.int_0 = num2;
							}
							else
							{
								int num3 = -1;
								num = -1;
								this.int_0 = num3;
								if (!this.bool_0)
								{
									goto IL_2E2;
								}
								goto IL_3CF;
							}
							IL_277:
							string text;
							if ((text = awaiter.GetResult()) == null)
							{
								goto IL_3CF;
							}
							this.string_6 = this.string_6 + text + Environment.NewLine;
							if (text.StartsWith("data:"))
							{
								text = text.Substring(5);
							}
							text = text.TrimStart(Array.Empty<char>());
							if (text == "[DONE]")
							{
								this.bool_0 = true;
								goto IL_3CF;
							}
							if (!text.StartsWith(":") && !string.IsNullOrWhiteSpace(text))
							{
								T t = JsonConvert.DeserializeObject<T>(text);
								t.String_1 = this.string_2;
								t.String_2 = this.string_3;
								t.TimeSpan_0 = this.timeSpan_0;
								t.String_3 = this.string_4;
								if (string.IsNullOrEmpty(t.GClass27_0))
								{
									t.GClass27_0 = this.string_5;
								}
								this.gparam_0 = t;
								int num4 = -4;
								num = -4;
								this.int_0 = num4;
								goto IL_486;
							}
							IL_2E2:
							this.gparam_0 = default(T);
							awaiter = this.streamReader_0.ReadLineAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num5 = 2;
								num = 2;
								this.int_0 = num5;
								this.taskAwaiter_2 = awaiter;
								GClass143.Class470<T> @class = this;
								this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass143.Class470<T>>(ref awaiter, ref @class);
								return;
							}
							goto IL_277;
							IL_3CF:;
						}
						finally
						{
							if (num == -1 && this.streamReader_0 != null)
							{
								((IDisposable)this.streamReader_0).Dispose();
							}
						}
						if (!this.bool_0)
						{
							this.streamReader_0 = null;
						}
					}
					finally
					{
						if (num == -1 && this.stream_0 != null)
						{
							((IDisposable)this.stream_0).Dispose();
						}
					}
					if (this.bool_0)
					{
						goto IL_493;
					}
					this.stream_0 = null;
					goto IL_493;
				default:
				{
					if (this.bool_0)
					{
						goto IL_493;
					}
					int num6 = -1;
					num = -1;
					this.int_0 = num6;
					this.gparam_0 = default(T);
					awaiter2 = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, true).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num7 = 0;
						num = 0;
						this.int_0 = num7;
						this.taskAwaiter_0 = awaiter2;
						GClass143.Class470<T> @class = this;
						this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass143.Class470<T>>(ref awaiter2, ref @class);
						return;
					}
					break;
				}
				case 0:
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					int num8 = -1;
					num = -1;
					this.int_0 = num8;
					break;
				}
				case 1:
				{
					awaiter3 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<Stream>);
					int num9 = -1;
					num = -1;
					this.int_0 = num9;
					goto IL_207;
				}
				}
				HttpResponseMessage result = awaiter2.GetResult();
				this.string_2 = null;
				this.string_3 = null;
				this.timeSpan_0 = TimeSpan.Zero;
				this.string_4 = null;
				this.string_5 = null;
				try
				{
					this.string_2 = result.Headers.GetValues("Openai-Organization").FirstOrDefault<string>();
					this.string_3 = result.Headers.GetValues("X-Request-ID").FirstOrDefault<string>();
					this.timeSpan_0 = TimeSpan.FromMilliseconds((double)int.Parse(result.Headers.GetValues("Openai-Processing-Ms").First<string>()));
					this.string_4 = result.Headers.GetValues("Openai-Version").FirstOrDefault<string>();
					this.string_5 = result.Headers.GetValues("Openai-Model").FirstOrDefault<string>();
				}
				catch (Exception)
				{
				}
				this.string_6 = string.Empty;
				this.gparam_0 = default(T);
				awaiter3 = result.Content.ReadAsStreamAsync().GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num10 = 1;
					num = 1;
					this.int_0 = num10;
					this.taskAwaiter_1 = awaiter3;
					GClass143.Class470<T> @class = this;
					this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass143.Class470<T>>(ref awaiter3, ref @class);
					return;
				}
				IL_207:
				Stream result2 = awaiter3.GetResult();
				this.stream_0 = result2;
				goto IL_218;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_2 = null;
				this.string_3 = null;
				this.string_4 = null;
				this.string_5 = null;
				this.string_6 = null;
				this.stream_0 = null;
				this.streamReader_0 = null;
				this.gparam_0 = default(T);
				this.asyncIteratorMethodBuilder_0.Complete();
				this.manualResetValueTaskSourceCore_0.SetException(exception);
				return;
			}
			IL_486:
			this.manualResetValueTaskSourceCore_0.SetResult(true);
			return;
			IL_493:
			this.int_0 = -2;
			this.string_2 = null;
			this.string_3 = null;
			this.string_4 = null;
			this.string_5 = null;
			this.string_6 = null;
			this.stream_0 = null;
			this.streamReader_0 = null;
			this.gparam_0 = default(T);
			this.asyncIteratorMethodBuilder_0.Complete();
			this.manualResetValueTaskSourceCore_0.SetResult(false);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0000311B File Offset: 0x0000131B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00075DDC File Offset: 0x00073FDC
		[DebuggerHidden]
		[return: Attribute10(new byte[]
		{
			1,
			0
		})]
		IAsyncEnumerator<T> IAsyncEnumerable<!0>.GetAsyncEnumerator(CancellationToken cancellationToken_0)
		{
			GClass143.Class470<T> @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = -3;
				this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
				this.bool_0 = false;
				@class = this;
			}
			else
			{
				@class = new GClass143.Class470<T>(-3);
				@class.gclass143_0 = this.gclass143_0;
			}
			@class.string_0 = this.string_1;
			@class.httpMethod_0 = this.httpMethod_1;
			@class.object_0 = this.object_1;
			return @class;
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00075E58 File Offset: 0x00074058
		[DebuggerHidden]
		ValueTask<bool> IAsyncEnumerator<!0>.MoveNextAsync()
		{
			if (this.int_0 == -2)
			{
				return default(ValueTask<bool>);
			}
			this.manualResetValueTaskSourceCore_0.Reset();
			GClass143.Class470<T> @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass143.Class470<T>>(ref @class);
			short version = this.manualResetValueTaskSourceCore_0.Version;
			if (this.manualResetValueTaskSourceCore_0.GetStatus(version) == 1)
			{
				return new ValueTask<bool>(this.manualResetValueTaskSourceCore_0.GetResult(version));
			}
			return new ValueTask<bool>(this, version);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00012747 File Offset: 0x00010947
		[DebuggerHidden]
		T IAsyncEnumerator<!0>.get_Current()
		{
			return this.gparam_0;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0001274F File Offset: 0x0001094F
		[DebuggerHidden]
		bool IValueTaskSource<bool>.GetResult(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0001275D File Offset: 0x0001095D
		[DebuggerHidden]
		ValueTaskSourceStatus IValueTaskSource<bool>.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0001276B File Offset: 0x0001096B
		[DebuggerHidden]
		void IValueTaskSource<bool>.OnCompleted(Action<object> action_0, object object_2, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_2, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0001277D File Offset: 0x0001097D
		[DebuggerHidden]
		void IValueTaskSource.GetResult(short short_0)
		{
			this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0001275D File Offset: 0x0001095D
		[DebuggerHidden]
		ValueTaskSourceStatus IValueTaskSource.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0001276B File Offset: 0x0001096B
		[DebuggerHidden]
		void IValueTaskSource.OnCompleted(Action<object> action_0, object object_2, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_2, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00075EC8 File Offset: 0x000740C8
		[DebuggerHidden]
		ValueTask IAsyncDisposable.DisposeAsync()
		{
			if (this.int_0 >= -1)
			{
				throw new NotSupportedException();
			}
			if (this.int_0 == -2)
			{
				return default(ValueTask);
			}
			this.bool_0 = true;
			this.manualResetValueTaskSourceCore_0.Reset();
			GClass143.Class470<T> @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass143.Class470<T>>(ref @class);
			return new ValueTask(this, this.manualResetValueTaskSourceCore_0.Version);
		}

		// Token: 0x04001226 RID: 4646
		public int int_0;

		// Token: 0x04001227 RID: 4647
		public AsyncIteratorMethodBuilder asyncIteratorMethodBuilder_0;

		// Token: 0x04001228 RID: 4648
		public ManualResetValueTaskSourceCore<bool> manualResetValueTaskSourceCore_0;

		// Token: 0x04001229 RID: 4649
		private T gparam_0;

		// Token: 0x0400122A RID: 4650
		private bool bool_0;

		// Token: 0x0400122B RID: 4651
		private int int_1;

		// Token: 0x0400122C RID: 4652
		public GClass143 gclass143_0;

		// Token: 0x0400122D RID: 4653
		private string string_0;

		// Token: 0x0400122E RID: 4654
		public string string_1;

		// Token: 0x0400122F RID: 4655
		private HttpMethod httpMethod_0;

		// Token: 0x04001230 RID: 4656
		public HttpMethod httpMethod_1;

		// Token: 0x04001231 RID: 4657
		private object object_0;

		// Token: 0x04001232 RID: 4658
		public object object_1;

		// Token: 0x04001233 RID: 4659
		private string string_2;

		// Token: 0x04001234 RID: 4660
		private string string_3;

		// Token: 0x04001235 RID: 4661
		private TimeSpan timeSpan_0;

		// Token: 0x04001236 RID: 4662
		private string string_4;

		// Token: 0x04001237 RID: 4663
		private string string_5;

		// Token: 0x04001238 RID: 4664
		private string string_6;

		// Token: 0x04001239 RID: 4665
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400123A RID: 4666
		private Stream stream_0;

		// Token: 0x0400123B RID: 4667
		private TaskAwaiter<Stream> taskAwaiter_1;

		// Token: 0x0400123C RID: 4668
		private StreamReader streamReader_0;

		// Token: 0x0400123D RID: 4669
		private TaskAwaiter<string> taskAwaiter_2;
	}

	// Token: 0x0200041A RID: 1050
	internal sealed class Class471
	{
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0001278C File Offset: 0x0001098C
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x00012794 File Offset: 0x00010994
		[JsonProperty("message")]
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0001279D File Offset: 0x0001099D
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x000127A5 File Offset: 0x000109A5
		[JsonProperty("type")]
		public string String_0
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x000127AE File Offset: 0x000109AE
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x000127B6 File Offset: 0x000109B6
		[JsonProperty("param")]
		public string String_1
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000127BF File Offset: 0x000109BF
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x000127C7 File Offset: 0x000109C7
		[JsonProperty("code")]
		public string String_2
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x0400123E RID: 4670
		private string string_0;

		// Token: 0x0400123F RID: 4671
		private string string_1;

		// Token: 0x04001240 RID: 4672
		private string string_2;

		// Token: 0x04001241 RID: 4673
		private string string_3;
	}

	// Token: 0x0200041B RID: 1051
	[StructLayout(LayoutKind.Auto)]
	private struct Struct260<T> : IAsyncStateMachine where T : GClass33
	{
		// Token: 0x06001B96 RID: 7062 RVA: 0x00075F2C File Offset: 0x0007412C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<T>(this.string_0, HttpMethod.Get, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<T>, GClass143.Struct260<T>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<T>);
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

		// Token: 0x06001B97 RID: 7063 RVA: 0x000127D0 File Offset: 0x000109D0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001242 RID: 4674
		public int int_0;

		// Token: 0x04001243 RID: 4675
		public AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder_0;

		// Token: 0x04001244 RID: 4676
		public GClass143 gclass143_0;

		// Token: 0x04001245 RID: 4677
		public string string_0;

		// Token: 0x04001246 RID: 4678
		private TaskAwaiter<T> taskAwaiter_0;
	}

	// Token: 0x0200041C RID: 1052
	[StructLayout(LayoutKind.Auto)]
	private struct Struct261<T> : IAsyncStateMachine where T : GClass33
	{
		// Token: 0x06001B98 RID: 7064 RVA: 0x00075FF0 File Offset: 0x000741F0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<T>(this.string_0, HttpMethod.Post, this.object_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<T>, GClass143.Struct261<T>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<T>);
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

		// Token: 0x06001B99 RID: 7065 RVA: 0x000127DE File Offset: 0x000109DE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001247 RID: 4679
		public int int_0;

		// Token: 0x04001248 RID: 4680
		public AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder_0;

		// Token: 0x04001249 RID: 4681
		public GClass143 gclass143_0;

		// Token: 0x0400124A RID: 4682
		public string string_0;

		// Token: 0x0400124B RID: 4683
		public object object_0;

		// Token: 0x0400124C RID: 4684
		private TaskAwaiter<T> taskAwaiter_0;
	}

	// Token: 0x0200041D RID: 1053
	[StructLayout(LayoutKind.Auto)]
	private struct Struct262<T> : IAsyncStateMachine where T : GClass33
	{
		// Token: 0x06001B9A RID: 7066 RVA: 0x000760B8 File Offset: 0x000742B8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<T>(this.string_0, HttpMethod.Put, this.object_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<T>, GClass143.Struct262<T>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<T>);
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

		// Token: 0x06001B9B RID: 7067 RVA: 0x000127EC File Offset: 0x000109EC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400124D RID: 4685
		public int int_0;

		// Token: 0x0400124E RID: 4686
		public AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder_0;

		// Token: 0x0400124F RID: 4687
		public GClass143 gclass143_0;

		// Token: 0x04001250 RID: 4688
		public string string_0;

		// Token: 0x04001251 RID: 4689
		public object object_0;

		// Token: 0x04001252 RID: 4690
		private TaskAwaiter<T> taskAwaiter_0;
	}

	// Token: 0x0200041E RID: 1054
	[StructLayout(LayoutKind.Auto)]
	private struct Struct263 : IAsyncStateMachine
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x00076180 File Offset: 0x00074380
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<Stream>);
						this.int_0 = -1;
						goto IL_DA;
					}
					awaiter2 = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, false).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass143.Struct263>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
				}
				awaiter = awaiter2.GetResult().Content.ReadAsStreamAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass143.Struct263>(ref awaiter, ref this);
					return;
				}
				IL_DA:
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

		// Token: 0x06001B9D RID: 7069 RVA: 0x000127FA File Offset: 0x000109FA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001253 RID: 4691
		public int int_0;

		// Token: 0x04001254 RID: 4692
		public AsyncTaskMethodBuilder<Stream> asyncTaskMethodBuilder_0;

		// Token: 0x04001255 RID: 4693
		public GClass143 gclass143_0;

		// Token: 0x04001256 RID: 4694
		public string string_0;

		// Token: 0x04001257 RID: 4695
		public HttpMethod httpMethod_0;

		// Token: 0x04001258 RID: 4696
		public object object_0;

		// Token: 0x04001259 RID: 4697
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400125A RID: 4698
		private TaskAwaiter<Stream> taskAwaiter_1;
	}

	// Token: 0x0200041F RID: 1055
	[StructLayout(LayoutKind.Auto)]
	private struct Struct264<T> : IAsyncStateMachine where T : GClass33
	{
		// Token: 0x06001B9E RID: 7070 RVA: 0x000762B0 File Offset: 0x000744B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			T result2;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						goto IL_EF;
					}
					awaiter2 = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, false).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass143.Struct264<T>>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
				}
				HttpResponseMessage result = awaiter2.GetResult();
				this.httpResponseMessage_0 = result;
				awaiter = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass143.Struct264<T>>(ref awaiter, ref this);
					return;
				}
				IL_EF:
				T t = JsonConvert.DeserializeObject<T>(awaiter.GetResult());
				try
				{
					t.String_1 = this.httpResponseMessage_0.Headers.GetValues("Openai-Organization").FirstOrDefault<string>();
					t.String_2 = this.httpResponseMessage_0.Headers.GetValues("X-Request-ID").FirstOrDefault<string>();
					t.TimeSpan_0 = TimeSpan.FromMilliseconds((double)int.Parse(this.httpResponseMessage_0.Headers.GetValues("Openai-Processing-Ms").First<string>()));
					t.String_3 = this.httpResponseMessage_0.Headers.GetValues("Openai-Version").FirstOrDefault<string>();
					if (string.IsNullOrEmpty(t.GClass27_0))
					{
						t.GClass27_0 = this.httpResponseMessage_0.Headers.GetValues("Openai-Model").FirstOrDefault<string>();
					}
				}
				catch (Exception)
				{
				}
				result2 = t;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00012808 File Offset: 0x00010A08
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400125B RID: 4699
		public int int_0;

		// Token: 0x0400125C RID: 4700
		public AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder_0;

		// Token: 0x0400125D RID: 4701
		public GClass143 gclass143_0;

		// Token: 0x0400125E RID: 4702
		public string string_0;

		// Token: 0x0400125F RID: 4703
		public HttpMethod httpMethod_0;

		// Token: 0x04001260 RID: 4704
		public object object_0;

		// Token: 0x04001261 RID: 4705
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001262 RID: 4706
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001263 RID: 4707
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000420 RID: 1056
	internal sealed class Class472
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00012816 File Offset: 0x00010A16
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0001281E File Offset: 0x00010A1E
		[JsonProperty("error")]
		public GClass143.Class471 Error
		{
			[CompilerGenerated]
			get
			{
				return this.class471_0;
			}
			[CompilerGenerated]
			set
			{
				this.class471_0 = value;
			}
		}

		// Token: 0x04001264 RID: 4708
		private GClass143.Class471 class471_0;
	}

	// Token: 0x02000421 RID: 1057
	[StructLayout(LayoutKind.Auto)]
	private struct Struct265 : IAsyncStateMachine
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x00076518 File Offset: 0x00074718
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<string>);
						this.int_0 = -1;
						goto IL_DA;
					}
					awaiter2 = gclass.method_3(this.string_0, this.httpMethod_0, this.object_0, false).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass143.Struct265>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
					this.int_0 = -1;
				}
				awaiter = awaiter2.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass143.Struct265>(ref awaiter, ref this);
					return;
				}
				IL_DA:
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

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00012827 File Offset: 0x00010A27
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001265 RID: 4709
		public int int_0;

		// Token: 0x04001266 RID: 4710
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001267 RID: 4711
		public GClass143 gclass143_0;

		// Token: 0x04001268 RID: 4712
		public string string_0;

		// Token: 0x04001269 RID: 4713
		public HttpMethod httpMethod_0;

		// Token: 0x0400126A RID: 4714
		public object object_0;

		// Token: 0x0400126B RID: 4715
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x0400126C RID: 4716
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000422 RID: 1058
	[StructLayout(LayoutKind.Auto)]
	private struct Struct266 : IAsyncStateMachine
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x00076648 File Offset: 0x00074848
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			HttpResponseMessage result2;
			try
			{
				if (num > 1)
				{
					if (string.IsNullOrEmpty(this.string_0))
					{
						this.string_0 = gclass.method_0();
					}
					if (this.httpMethod_0 == null)
					{
						this.httpMethod_0 = HttpMethod.Get;
					}
					this.httpClient_0 = gclass.method_1();
				}
				try
				{
					string text;
					TaskAwaiter<HttpResponseMessage> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_160;
						}
						this.httpResponseMessage_0 = null;
						text = null;
						HttpRequestMessage httpRequestMessage = new HttpRequestMessage(this.httpMethod_0, this.string_0);
						if (this.object_0 != null)
						{
							if (this.object_0 is HttpContent)
							{
								httpRequestMessage.Content = (this.object_0 as HttpContent);
							}
							else
							{
								StringContent content = new StringContent(JsonConvert.SerializeObject(this.object_0, new JsonSerializerSettings
								{
									NullValueHandling = 1
								}), Encoding.UTF8, "application/json");
								httpRequestMessage.Content = content;
							}
						}
						awaiter = this.httpClient_0.SendAsync(httpRequestMessage, this.bool_0 ? HttpCompletionOption.ResponseHeadersRead : HttpCompletionOption.ResponseContentRead).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass143.Struct266>(ref awaiter, ref this);
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
					if (this.httpResponseMessage_0.IsSuccessStatusCode)
					{
						result2 = this.httpResponseMessage_0;
						goto IL_33F;
					}
					IL_160:
					try
					{
						TaskAwaiter<string> awaiter2;
						if (num != 1)
						{
							awaiter2 = this.httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int num4 = 1;
								num = 1;
								this.int_0 = num4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass143.Struct266>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<string>);
							int num5 = -1;
							num = -1;
							this.int_0 = num5;
						}
						text = awaiter2.GetResult();
					}
					catch (Exception ex)
					{
						text = "Additionally, the following error was thrown when attemping to read the response content: " + ex.ToString();
					}
					if (this.httpResponseMessage_0.StatusCode == HttpStatusCode.Unauthorized)
					{
						throw new AuthenticationException("OpenAI rejected your authorization, most likely due to an invalid API Key.  Try checking your API Key and see https://github.com/OkGoDoIt/OpenAI-API-dotnet#authentication for guidance.  Full API response follows: " + text);
					}
					if (this.httpResponseMessage_0.StatusCode == HttpStatusCode.InternalServerError)
					{
						throw new HttpRequestException("OpenAI had an internal server error, which can happen occasionally.  Please retry your request.  " + gclass.method_2(text, this.httpResponseMessage_0, gclass.vmethod_0(), this.string_0));
					}
					HttpRequestException ex2 = new HttpRequestException(gclass.method_2(text, this.httpResponseMessage_0, gclass.vmethod_0(), this.string_0));
					GClass143.Class472 @class = JsonConvert.DeserializeObject<GClass143.Class472>(text);
					try
					{
						ex2.Data.Add("message", @class.Error.Message);
						ex2.Data.Add("type", @class.Error.String_0);
						ex2.Data.Add("param", @class.Error.String_1);
						ex2.Data.Add("code", @class.Error.String_2);
					}
					catch (Exception inner)
					{
						throw new HttpRequestException(ex2.Message, inner);
					}
					throw ex2;
				}
				finally
				{
					if (num < 0 && this.httpClient_0 != null)
					{
						((IDisposable)this.httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.httpClient_0 = null;
				this.httpResponseMessage_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_33F:
			this.int_0 = -2;
			this.httpClient_0 = null;
			this.httpResponseMessage_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00012835 File Offset: 0x00010A35
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400126D RID: 4717
		public int int_0;

		// Token: 0x0400126E RID: 4718
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x0400126F RID: 4719
		public string string_0;

		// Token: 0x04001270 RID: 4720
		public GClass143 gclass143_0;

		// Token: 0x04001271 RID: 4721
		public HttpMethod httpMethod_0;

		// Token: 0x04001272 RID: 4722
		public object object_0;

		// Token: 0x04001273 RID: 4723
		public bool bool_0;

		// Token: 0x04001274 RID: 4724
		private HttpClient httpClient_0;

		// Token: 0x04001275 RID: 4725
		private HttpResponseMessage httpResponseMessage_0;

		// Token: 0x04001276 RID: 4726
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x04001277 RID: 4727
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000423 RID: 1059
	[StructLayout(LayoutKind.Auto)]
	private struct Struct267<T> : IAsyncStateMachine where T : GClass33
	{
		// Token: 0x06001BA7 RID: 7079 RVA: 0x00076A1C File Offset: 0x00074C1C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass143 gclass = this.gclass143_0;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_6<T>(this.string_0, HttpMethod.Delete, this.object_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<T>, GClass143.Struct267<T>>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<T>);
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

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00012843 File Offset: 0x00010A43
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001278 RID: 4728
		public int int_0;

		// Token: 0x04001279 RID: 4729
		public AsyncTaskMethodBuilder<T> asyncTaskMethodBuilder_0;

		// Token: 0x0400127A RID: 4730
		public GClass143 gclass143_0;

		// Token: 0x0400127B RID: 4731
		public string string_0;

		// Token: 0x0400127C RID: 4732
		public object object_0;

		// Token: 0x0400127D RID: 4733
		private TaskAwaiter<T> taskAwaiter_0;
	}
}
