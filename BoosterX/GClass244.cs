using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200057F RID: 1407
public sealed class GClass244 : HttpClient
{
	// Token: 0x0600236F RID: 9071 RVA: 0x0001754F File Offset: 0x0001574F
	public GClass244() : base(GClass244.smethod_0())
	{
		this.class713_0.method_0();
		base.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "StoreLib");
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x0008B46C File Offset: 0x0008966C
	private static HttpClientHandler smethod_0()
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		if (!GClass244.bool_0)
		{
			HttpClientHandler httpClientHandler2 = httpClientHandler;
			Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> serverCertificateCustomValidationCallback;
			if ((serverCertificateCustomValidationCallback = GClass244.Class680.func_0) == null)
			{
				serverCertificateCustomValidationCallback = (GClass244.Class680.func_0 = new Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>(GClass244.smethod_1));
			}
			httpClientHandler2.ServerCertificateCustomValidationCallback = serverCertificateCustomValidationCallback;
		}
		return httpClientHandler;
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x00003982 File Offset: 0x00001B82
	private static bool smethod_1(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		return true;
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x0008B4A8 File Offset: 0x000896A8
	public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		GClass244.Struct362 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		@struct.gclass244_0 = this;
		@struct.httpRequestMessage_0 = request;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass244.Struct362>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001760 RID: 5984
	private readonly Class713 class713_0 = new Class713();

	// Token: 0x04001761 RID: 5985
	private static readonly bool bool_0 = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

	// Token: 0x02000580 RID: 1408
	private static class Class680
	{
		// Token: 0x04001762 RID: 5986
		public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> func_0;
	}

	// Token: 0x02000581 RID: 1409
	[StructLayout(LayoutKind.Auto)]
	private struct Struct362 : IAsyncStateMachine
	{
		// Token: 0x06002374 RID: 9076 RVA: 0x0008B4F4 File Offset: 0x000896F4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass244 gclass = this.gclass244_0;
			HttpResponseMessage result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					this.httpRequestMessage_0.Headers.Add("MS-CV", gclass.class713_0.method_4());
					gclass.class713_0.method_5();
					awaiter = gclass.SendAsync(this.httpRequestMessage_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass244.Struct362>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
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

		// Token: 0x06002375 RID: 9077 RVA: 0x0001759B File Offset: 0x0001579B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001763 RID: 5987
		public int int_0;

		// Token: 0x04001764 RID: 5988
		public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

		// Token: 0x04001765 RID: 5989
		public HttpRequestMessage httpRequestMessage_0;

		// Token: 0x04001766 RID: 5990
		public GClass244 gclass244_0;

		// Token: 0x04001767 RID: 5991
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
	}
}
