using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x02000514 RID: 1300
public sealed class GClass225
{
	// Token: 0x060020D7 RID: 8407 RVA: 0x00015AD9 File Offset: 0x00013CD9
	public GClass225(GEnum7 genum7_1, GClass233 gclass233_1)
	{
		this.gclass244_0 = new GClass244();
		this.genum7_0 = genum7_1;
		this.gclass233_0 = gclass233_1;
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x00015B05 File Offset: 0x00013D05
	public static GClass225 smethod_0()
	{
		return new GClass225((GEnum7)0, new GClass233(GEnum0.US, GEnum6.en, true));
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x000839DC File Offset: 0x00081BDC
	public Task<IList<GClass298>> method_0(GClass197 gclass197_0, string string_0)
	{
		GClass225.Struct344 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IList<GClass298>>.Create();
		@struct.gclass197_0 = gclass197_0;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass225.Struct344>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x00083A28 File Offset: 0x00081C28
	public Task<GClass42> method_1(string string_0, GEnum9 genum9_0, string string_1)
	{
		GClass225.Struct343 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass42>.Create();
		@struct.gclass225_0 = this;
		@struct.string_0 = string_0;
		@struct.genum9_0 = genum9_0;
		@struct.string_1 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass225.Struct343>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x00083A84 File Offset: 0x00081C84
	public Task<GClass92> method_2(string string_0)
	{
		GClass225.Struct342 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass92>.Create();
		@struct.gclass225_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass225.Struct342>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x00083AD0 File Offset: 0x00081CD0
	public Task<GClass16> method_3(string string_0, GEnum14 genum14_0)
	{
		GClass225.Struct340 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass16>.Create();
		@struct.gclass225_0 = this;
		@struct.string_0 = string_0;
		@struct.genum14_0 = genum14_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass225.Struct340>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x00083B24 File Offset: 0x00081D24
	public Task<GClass161> method_4(string string_0)
	{
		GClass225.Struct339 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass161>.Create();
		@struct.gclass225_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass225.Struct339>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x00083B70 File Offset: 0x00081D70
	private Task<HttpResponseMessage> method_5(Uri uri_0, HttpMethod httpMethod_0, string string_0)
	{
		GClass225.Struct341 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		@struct.gclass225_0 = this;
		@struct.uri_0 = uri_0;
		@struct.httpMethod_0 = httpMethod_0;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass225.Struct341>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x00083BCC File Offset: 0x00081DCC
	private HttpClient method_6()
	{
		if (this.bool_0)
		{
			object obj = this.object_0;
			HttpClient result;
			lock (obj)
			{
				if (this.httpClient_0 == null)
				{
					HttpClientHandler handler = new HttpClientHandler
					{
						UseProxy = true,
						Proxy = new WebProxy("http://147.45.114.104:3128")
						{
							Credentials = new NetworkCredential("boosterx", "boosterxx")
						}
					};
					this.httpClient_0 = new HttpClient(handler);
				}
				result = this.httpClient_0;
			}
			return result;
		}
		return this.gclass244_0;
	}

	// Token: 0x040015B7 RID: 5559
	private readonly GClass244 gclass244_0;

	// Token: 0x040015B8 RID: 5560
	private readonly GEnum7 genum7_0;

	// Token: 0x040015B9 RID: 5561
	private readonly GClass233 gclass233_0;

	// Token: 0x040015BA RID: 5562
	private HttpClient httpClient_0;

	// Token: 0x040015BB RID: 5563
	private bool bool_0;

	// Token: 0x040015BC RID: 5564
	private readonly object object_0 = new object();

	// Token: 0x02000515 RID: 1301
	[StructLayout(LayoutKind.Auto)]
	private struct Struct339 : IAsyncStateMachine
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x00083C68 File Offset: 0x00081E68
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			GClass161 result;
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
						goto IL_E2;
					}
					Uri uri_ = GClass126.smethod_2(gclass.gclass233_0, this.string_0);
					awaiter2 = gclass.method_5(uri_, HttpMethod.Get, null).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass225.Struct339>(ref awaiter2, ref this);
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
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass225.Struct339>(ref awaiter, ref this);
					return;
				}
				IL_E2:
				result = GClass161.smethod_0(awaiter.GetResult());
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

		// Token: 0x060020E1 RID: 8417 RVA: 0x00015B16 File Offset: 0x00013D16
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015BD RID: 5565
		public int int_0;

		// Token: 0x040015BE RID: 5566
		public AsyncTaskMethodBuilder<GClass161> asyncTaskMethodBuilder_0;

		// Token: 0x040015BF RID: 5567
		public GClass225 gclass225_0;

		// Token: 0x040015C0 RID: 5568
		public string string_0;

		// Token: 0x040015C1 RID: 5569
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040015C2 RID: 5570
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000516 RID: 1302
	[StructLayout(LayoutKind.Auto)]
	private struct Struct340 : IAsyncStateMachine
	{
		// Token: 0x060020E2 RID: 8418 RVA: 0x00083DA8 File Offset: 0x00081FA8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			GClass16 result;
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
						goto IL_F1;
					}
					Uri uri_ = GClass126.smethod_1(gclass.genum7_0, this.genum14_0, gclass.gclass233_0, this.string_0);
					awaiter2 = gclass.method_5(uri_, HttpMethod.Get, null).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass225.Struct340>(ref awaiter2, ref this);
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
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass225.Struct340>(ref awaiter, ref this);
					return;
				}
				IL_F1:
				result = GClass16.smethod_0(awaiter.GetResult());
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

		// Token: 0x060020E3 RID: 8419 RVA: 0x00015B24 File Offset: 0x00013D24
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015C3 RID: 5571
		public int int_0;

		// Token: 0x040015C4 RID: 5572
		public AsyncTaskMethodBuilder<GClass16> asyncTaskMethodBuilder_0;

		// Token: 0x040015C5 RID: 5573
		public GClass225 gclass225_0;

		// Token: 0x040015C6 RID: 5574
		public GEnum14 genum14_0;

		// Token: 0x040015C7 RID: 5575
		public string string_0;

		// Token: 0x040015C8 RID: 5576
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040015C9 RID: 5577
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000517 RID: 1303
	[StructLayout(LayoutKind.Auto)]
	private struct Struct341 : IAsyncStateMachine
	{
		// Token: 0x060020E4 RID: 8420 RVA: 0x00083EF4 File Offset: 0x000820F4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			HttpResponseMessage result2;
			try
			{
				TaskAwaiter<string> awaiter;
				HttpRequestMessage httpRequestMessage;
				HttpClient httpClient;
				switch (num)
				{
				case 0:
					break;
				case 1:
				{
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					goto IL_270;
				}
				case 2:
				{
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_2A9;
				}
				default:
					httpRequestMessage = new HttpRequestMessage(this.httpMethod_0, this.uri_0);
					if (!string.IsNullOrEmpty(this.string_0))
					{
						httpRequestMessage.Headers.TryAddWithoutValidation("Authentication", this.string_0);
					}
					httpClient = gclass.method_6();
					this.cancellationTokenSource_0 = new CancellationTokenSource(TimeSpan.FromSeconds(3.0));
					break;
				}
				HttpResponseMessage result;
				try
				{
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						awaiter2 = httpClient.SendAsync(httpRequestMessage, this.cancellationTokenSource_0.Token).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							int num4 = 0;
							num = 0;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass225.Struct341>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						int num5 = -1;
						num = -1;
						this.int_0 = num5;
					}
					result = awaiter2.GetResult();
				}
				catch (TaskCanceledException ex) when (ex.CancellationToken == this.cancellationTokenSource_0.Token)
				{
					object object_ = gclass.object_0;
					bool flag = false;
					try
					{
						Monitor.Enter(object_, ref flag);
						gclass.bool_0 = true;
					}
					finally
					{
						if (num < 0 && flag)
						{
							Monitor.Exit(object_);
						}
					}
					throw new GException3(this.uri_0.ToString(), 0, null);
				}
				catch (Exception innerException)
				{
					throw new ApplicationException("Request failed", innerException);
				}
				finally
				{
					if (num < 0 && this.cancellationTokenSource_0 != null)
					{
						((IDisposable)this.cancellationTokenSource_0).Dispose();
					}
				}
				this.cancellationTokenSource_0 = null;
				if (result.StatusCode == HttpStatusCode.NotFound)
				{
					this.string_1 = this.uri_0.ToString();
					this.int_1 = (int)result.StatusCode;
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num6 = 1;
						num = 1;
						this.int_0 = num6;
						this.taskAwaiter_1 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass225.Struct341>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					if (result.IsSuccessStatusCode)
					{
						result2 = result;
						goto IL_2E4;
					}
					this.string_1 = this.uri_0.ToString();
					this.int_1 = (int)result.StatusCode;
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num7 = 2;
						num = 2;
						this.int_0 = num7;
						this.taskAwaiter_1 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass225.Struct341>(ref awaiter, ref this);
						return;
					}
					goto IL_2A9;
				}
				IL_270:
				string result3 = awaiter.GetResult();
				throw new GException2(this.string_1, this.int_1, result3);
				IL_2A9:
				result3 = awaiter.GetResult();
				throw new GException2(this.string_1, this.int_1, result3);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2E4:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00015B32 File Offset: 0x00013D32
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015CA RID: 5578
		public int int_0;

		// Token: 0x040015CB RID: 5579
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x040015CC RID: 5580
		public HttpMethod httpMethod_0;

		// Token: 0x040015CD RID: 5581
		public Uri uri_0;

		// Token: 0x040015CE RID: 5582
		public string string_0;

		// Token: 0x040015CF RID: 5583
		public GClass225 gclass225_0;

		// Token: 0x040015D0 RID: 5584
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x040015D1 RID: 5585
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040015D2 RID: 5586
		private string string_1;

		// Token: 0x040015D3 RID: 5587
		private int int_1;

		// Token: 0x040015D4 RID: 5588
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000518 RID: 1304
	[StructLayout(LayoutKind.Auto)]
	private struct Struct342 : IAsyncStateMachine
	{
		// Token: 0x060020E6 RID: 8422 RVA: 0x00084278 File Offset: 0x00082478
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			GClass92 result;
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
						goto IL_E3;
					}
					awaiter2 = gclass.method_5(new Uri("https://apps.microsoft.com/api/pages/pdp?productId=" + this.string_0), HttpMethod.Get, null).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass225.Struct342>(ref awaiter2, ref this);
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
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass225.Struct342>(ref awaiter, ref this);
					return;
				}
				IL_E3:
				result = JsonConvert.DeserializeObject<GClass92>(awaiter.GetResult());
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

		// Token: 0x060020E7 RID: 8423 RVA: 0x00015B40 File Offset: 0x00013D40
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015D5 RID: 5589
		public int int_0;

		// Token: 0x040015D6 RID: 5590
		public AsyncTaskMethodBuilder<GClass92> asyncTaskMethodBuilder_0;

		// Token: 0x040015D7 RID: 5591
		public GClass225 gclass225_0;

		// Token: 0x040015D8 RID: 5592
		public string string_0;

		// Token: 0x040015D9 RID: 5593
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040015DA RID: 5594
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000519 RID: 1305
	[StructLayout(LayoutKind.Auto)]
	private struct Struct343 : IAsyncStateMachine
	{
		// Token: 0x060020E8 RID: 8424 RVA: 0x000843B8 File Offset: 0x000825B8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass225 gclass = this.gclass225_0;
			GClass42 result;
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
						goto IL_F6;
					}
					Uri uri_ = GClass126.smethod_0(gclass.genum7_0, this.string_0, this.genum9_0, gclass.gclass233_0);
					awaiter2 = gclass.method_5(uri_, HttpMethod.Get, this.string_1).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass225.Struct343>(ref awaiter2, ref this);
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
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass225.Struct343>(ref awaiter, ref this);
					return;
				}
				IL_F6:
				result = GClass42.smethod_0(awaiter.GetResult());
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

		// Token: 0x060020E9 RID: 8425 RVA: 0x00015B4E File Offset: 0x00013D4E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015DB RID: 5595
		public int int_0;

		// Token: 0x040015DC RID: 5596
		public AsyncTaskMethodBuilder<GClass42> asyncTaskMethodBuilder_0;

		// Token: 0x040015DD RID: 5597
		public GClass225 gclass225_0;

		// Token: 0x040015DE RID: 5598
		public string string_0;

		// Token: 0x040015DF RID: 5599
		public GEnum9 genum9_0;

		// Token: 0x040015E0 RID: 5600
		public string string_1;

		// Token: 0x040015E1 RID: 5601
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		// Token: 0x040015E2 RID: 5602
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200051A RID: 1306
	[StructLayout(LayoutKind.Auto)]
	private struct Struct344 : IAsyncStateMachine
	{
		// Token: 0x060020EA RID: 8426 RVA: 0x0008450C File Offset: 0x0008270C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			IList<GClass298> result4;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<IList<GClass298>> awaiter2;
				TaskAwaiter<IList<Uri>> awaiter3;
				switch (num)
				{
				case 0:
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					break;
				}
				case 1:
				{
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<IList<GClass298>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_108;
				}
				case 2:
				{
					awaiter3 = this.taskAwaiter_2;
					this.taskAwaiter_2 = default(TaskAwaiter<IList<Uri>>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
					goto IL_181;
				}
				default:
					awaiter = GClass272.smethod_0(this.gclass197_0.List_4[0].GClass232_0.GClass291_0.GClass111_0.String_1, this.string_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num5 = 0;
						num = 0;
						this.int_0 = num5;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass225.Struct344>(ref awaiter, ref this);
						return;
					}
					break;
				}
				string result = awaiter.GetResult();
				IList<string> list;
				GClass272.smethod_4(result, out this.ilist_0, out list, out this.ilist_1);
				awaiter2 = GClass272.smethod_2(result).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					int num6 = 1;
					num = 1;
					this.int_0 = num6;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<GClass298>>, GClass225.Struct344>(ref awaiter2, ref this);
					return;
				}
				IL_108:
				IList<GClass298> result2 = awaiter2.GetResult();
				this.ilist_2 = result2;
				awaiter3 = GClass272.smethod_5(this.ilist_1, this.ilist_0, this.string_0).GetAwaiter();
				if (!awaiter3.IsCompleted)
				{
					int num7 = 2;
					num = 2;
					this.int_0 = num7;
					this.taskAwaiter_2 = awaiter3;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IList<Uri>>, GClass225.Struct344>(ref awaiter3, ref this);
					return;
				}
				IL_181:
				IList<Uri> result3 = awaiter3.GetResult();
				IEnumerator<GClass298> enumerator = this.ilist_2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass298 gclass = enumerator.Current;
						int index = this.ilist_2.IndexOf(gclass);
						gclass.uri_0 = result3[index];
						gclass.string_1 = this.ilist_1[index];
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result4 = this.ilist_2;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.ilist_0 = null;
				this.ilist_1 = null;
				this.ilist_2 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.ilist_0 = null;
			this.ilist_1 = null;
			this.ilist_2 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result4);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00015B5C File Offset: 0x00013D5C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040015E3 RID: 5603
		public int int_0;

		// Token: 0x040015E4 RID: 5604
		public AsyncTaskMethodBuilder<IList<GClass298>> asyncTaskMethodBuilder_0;

		// Token: 0x040015E5 RID: 5605
		public GClass197 gclass197_0;

		// Token: 0x040015E6 RID: 5606
		public string string_0;

		// Token: 0x040015E7 RID: 5607
		private IList<string> ilist_0;

		// Token: 0x040015E8 RID: 5608
		private IList<string> ilist_1;

		// Token: 0x040015E9 RID: 5609
		private IList<GClass298> ilist_2;

		// Token: 0x040015EA RID: 5610
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x040015EB RID: 5611
		private TaskAwaiter<IList<GClass298>> taskAwaiter_1;

		// Token: 0x040015EC RID: 5612
		private TaskAwaiter<IList<Uri>> taskAwaiter_2;
	}
}
