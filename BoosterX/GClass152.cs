using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020005BC RID: 1468
public sealed class GClass152 : GClass143, GInterface4
{
	// Token: 0x060025A3 RID: 9635 RVA: 0x00019155 File Offset: 0x00017355
	internal GClass152(GClass11 gclass11_1, bool bool_1) : base(gclass11_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x00019170 File Offset: 0x00017370
	protected override string vmethod_0()
	{
		if (this.method_12())
		{
			return "audio/translations";
		}
		return "audio/transcriptions";
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x00019187 File Offset: 0x00017387
	[CompilerGenerated]
	public GClass106 imethod_0()
	{
		return this.gclass106_0;
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x0001918F File Offset: 0x0001738F
	[CompilerGenerated]
	public void imethod_1(GClass106 gclass106_1)
	{
		this.gclass106_0 = gclass106_1;
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x00019198 File Offset: 0x00017398
	private bool method_12()
	{
		return this.bool_0;
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x00091298 File Offset: 0x0008F498
	public Task<string> imethod_6(Stream stream_0, string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass152.Struct385 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass152_0 = this;
		@struct.stream_0 = stream_0;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass152.Struct385>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x00091308 File Offset: 0x0008F508
	public Task<string> imethod_7(string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass152.Struct384 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass152_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass152.Struct384>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x0009136C File Offset: 0x0008F56C
	public Task<GClass38> imethod_4(Stream stream_0, string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass152.Struct386 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass38>.Create();
		@struct.gclass152_0 = this;
		@struct.stream_0 = stream_0;
		@struct.string_2 = string_0;
		@struct.string_0 = string_1;
		@struct.string_1 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass152.Struct386>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x000913DC File Offset: 0x0008F5DC
	public Task<GClass38> imethod_5(string string_0, string string_1 = null, string string_2 = null, double? nullable_0 = null)
	{
		GClass152.Struct383 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass38>.Create();
		@struct.gclass152_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass152.Struct383>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x00091440 File Offset: 0x0008F640
	public Task<string> imethod_2(Stream stream_0, string string_0, string string_1, string string_2 = null, string string_3 = null, double? nullable_0 = null)
	{
		GClass152.Struct387 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass152_0 = this;
		@struct.stream_0 = stream_0;
		@struct.string_3 = string_0;
		@struct.string_2 = string_1;
		@struct.string_0 = string_2;
		@struct.string_1 = string_3;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass152.Struct387>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x000914B8 File Offset: 0x0008F6B8
	public Task<string> imethod_3(string string_0, string string_1, string string_2 = null, string string_3 = null, double? nullable_0 = null)
	{
		GClass152.Struct382 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass152_0 = this;
		@struct.string_0 = string_0;
		@struct.string_1 = string_1;
		@struct.string_2 = string_2;
		@struct.string_3 = string_3;
		@struct.nullable_0 = nullable_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass152.Struct382>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0400189B RID: 6299
	private GClass106 gclass106_0 = new GClass106();

	// Token: 0x0400189C RID: 6300
	private readonly bool bool_0;

	// Token: 0x020005BD RID: 1469
	[StructLayout(LayoutKind.Auto)]
	private struct Struct382 : IAsyncStateMachine
	{
		// Token: 0x060025AE RID: 9646 RVA: 0x00091528 File Offset: 0x0008F728
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass152 gclass = this.gclass152_0;
			string result;
			try
			{
				if (num != 0)
				{
					this.fileStream_0 = File.OpenRead(this.string_0);
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = gclass.imethod_2(this.fileStream_0, Path.GetFileName(this.string_0), this.string_1, this.string_2, this.string_3, this.nullable_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass152.Struct382>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
					}
				}
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

		// Token: 0x060025AF RID: 9647 RVA: 0x000191A0 File Offset: 0x000173A0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400189D RID: 6301
		public int int_0;

		// Token: 0x0400189E RID: 6302
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x0400189F RID: 6303
		public string string_0;

		// Token: 0x040018A0 RID: 6304
		public GClass152 gclass152_0;

		// Token: 0x040018A1 RID: 6305
		public string string_1;

		// Token: 0x040018A2 RID: 6306
		public string string_2;

		// Token: 0x040018A3 RID: 6307
		public string string_3;

		// Token: 0x040018A4 RID: 6308
		public double? nullable_0;

		// Token: 0x040018A5 RID: 6309
		private FileStream fileStream_0;

		// Token: 0x040018A6 RID: 6310
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020005BE RID: 1470
	[StructLayout(LayoutKind.Auto)]
	private struct Struct383 : IAsyncStateMachine
	{
		// Token: 0x060025B0 RID: 9648 RVA: 0x00091640 File Offset: 0x0008F840
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass152 gclass = this.gclass152_0;
			GClass38 result;
			try
			{
				if (num != 0)
				{
					this.fileStream_0 = File.OpenRead(this.string_0);
				}
				try
				{
					TaskAwaiter<GClass38> awaiter;
					if (num != 0)
					{
						awaiter = gclass.imethod_4(this.fileStream_0, Path.GetFileName(this.string_0), this.string_1, this.string_2, this.nullable_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass38>, GClass152.Struct383>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass38>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
					}
				}
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

		// Token: 0x060025B1 RID: 9649 RVA: 0x000191AE File Offset: 0x000173AE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040018A7 RID: 6311
		public int int_0;

		// Token: 0x040018A8 RID: 6312
		public AsyncTaskMethodBuilder<GClass38> asyncTaskMethodBuilder_0;

		// Token: 0x040018A9 RID: 6313
		public string string_0;

		// Token: 0x040018AA RID: 6314
		public GClass152 gclass152_0;

		// Token: 0x040018AB RID: 6315
		public string string_1;

		// Token: 0x040018AC RID: 6316
		public string string_2;

		// Token: 0x040018AD RID: 6317
		public double? nullable_0;

		// Token: 0x040018AE RID: 6318
		private FileStream fileStream_0;

		// Token: 0x040018AF RID: 6319
		private TaskAwaiter<GClass38> taskAwaiter_0;
	}

	// Token: 0x020005BF RID: 1471
	[StructLayout(LayoutKind.Auto)]
	private struct Struct384 : IAsyncStateMachine
	{
		// Token: 0x060025B2 RID: 9650 RVA: 0x00091754 File Offset: 0x0008F954
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass152 gclass = this.gclass152_0;
			string result;
			try
			{
				if (num != 0)
				{
					this.fileStream_0 = File.OpenRead(this.string_0);
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						awaiter = gclass.imethod_6(this.fileStream_0, Path.GetFileName(this.string_0), this.string_1, this.string_2, this.nullable_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass152.Struct384>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<string>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && this.fileStream_0 != null)
					{
						((IDisposable)this.fileStream_0).Dispose();
					}
				}
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

		// Token: 0x060025B3 RID: 9651 RVA: 0x000191BC File Offset: 0x000173BC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040018B0 RID: 6320
		public int int_0;

		// Token: 0x040018B1 RID: 6321
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040018B2 RID: 6322
		public string string_0;

		// Token: 0x040018B3 RID: 6323
		public GClass152 gclass152_0;

		// Token: 0x040018B4 RID: 6324
		public string string_1;

		// Token: 0x040018B5 RID: 6325
		public string string_2;

		// Token: 0x040018B6 RID: 6326
		public double? nullable_0;

		// Token: 0x040018B7 RID: 6327
		private FileStream fileStream_0;

		// Token: 0x040018B8 RID: 6328
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020005C0 RID: 1472
	[StructLayout(LayoutKind.Auto)]
	private struct Struct385 : IAsyncStateMachine
	{
		// Token: 0x060025B4 RID: 9652 RVA: 0x00091868 File Offset: 0x0008FA68
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass152 gclass = this.gclass152_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = gclass.imethod_2(this.stream_0, this.string_0, "text", this.string_1, this.string_2, this.nullable_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass152.Struct385>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
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

		// Token: 0x060025B5 RID: 9653 RVA: 0x000191CA File Offset: 0x000173CA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040018B9 RID: 6329
		public int int_0;

		// Token: 0x040018BA RID: 6330
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040018BB RID: 6331
		public GClass152 gclass152_0;

		// Token: 0x040018BC RID: 6332
		public Stream stream_0;

		// Token: 0x040018BD RID: 6333
		public string string_0;

		// Token: 0x040018BE RID: 6334
		public string string_1;

		// Token: 0x040018BF RID: 6335
		public string string_2;

		// Token: 0x040018C0 RID: 6336
		public double? nullable_0;

		// Token: 0x040018C1 RID: 6337
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020005C1 RID: 1473
	[StructLayout(LayoutKind.Auto)]
	private struct Struct386 : IAsyncStateMachine
	{
		// Token: 0x060025B6 RID: 9654 RVA: 0x00091944 File Offset: 0x0008FB44
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass152 gclass = this.gclass152_0;
			GClass38 result;
			try
			{
				TaskAwaiter<GClass38> awaiter;
				if (num != 0)
				{
					GClass106 gclass2 = new GClass106
					{
						String_2 = (this.string_0 ?? gclass.imethod_0().String_2),
						String_0 = gclass.imethod_0().String_0,
						String_1 = (this.string_1 ?? gclass.imethod_0().String_1),
						Double_0 = (this.nullable_0 ?? gclass.imethod_0().Double_0),
						String_3 = "verbose_json"
					};
					MemoryStream memoryStream = new MemoryStream();
					MultipartFormDataContent multipartFormDataContent;
					try
					{
						this.stream_0.CopyTo(memoryStream);
						multipartFormDataContent = new MultipartFormDataContent
						{
							{
								new StringContent(gclass2.String_0),
								"model"
							},
							{
								new StringContent(gclass2.String_3),
								"response_format"
							},
							{
								new ByteArrayContent(memoryStream.ToArray()),
								"file",
								this.string_2
							}
						};
						if (!string.IsNullOrEmpty(gclass2.String_2))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_2), "language");
						}
						if (!string.IsNullOrEmpty(gclass2.String_1))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_1), "prompt");
						}
						if (gclass2.Double_0 != 0.0)
						{
							multipartFormDataContent.Add(new StringContent(gclass2.Double_0.ToString()), "temperature");
						}
					}
					finally
					{
						if (num < 0 && memoryStream != null)
						{
							((IDisposable)memoryStream).Dispose();
						}
					}
					awaiter = gclass.method_8<GClass38>(gclass.method_0(), multipartFormDataContent).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass38>, GClass152.Struct386>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass38>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
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

		// Token: 0x060025B7 RID: 9655 RVA: 0x000191D8 File Offset: 0x000173D8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040018C2 RID: 6338
		public int int_0;

		// Token: 0x040018C3 RID: 6339
		public AsyncTaskMethodBuilder<GClass38> asyncTaskMethodBuilder_0;

		// Token: 0x040018C4 RID: 6340
		public string string_0;

		// Token: 0x040018C5 RID: 6341
		public GClass152 gclass152_0;

		// Token: 0x040018C6 RID: 6342
		public string string_1;

		// Token: 0x040018C7 RID: 6343
		public double? nullable_0;

		// Token: 0x040018C8 RID: 6344
		public Stream stream_0;

		// Token: 0x040018C9 RID: 6345
		public string string_2;

		// Token: 0x040018CA RID: 6346
		private TaskAwaiter<GClass38> taskAwaiter_0;
	}

	// Token: 0x020005C2 RID: 1474
	[StructLayout(LayoutKind.Auto)]
	private struct Struct387 : IAsyncStateMachine
	{
		// Token: 0x060025B8 RID: 9656 RVA: 0x00091BA4 File Offset: 0x0008FDA4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass152 gclass = this.gclass152_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					GClass106 gclass2 = new GClass106
					{
						String_2 = (this.string_0 ?? gclass.imethod_0().String_2),
						String_0 = gclass.imethod_0().String_0,
						String_1 = (this.string_1 ?? gclass.imethod_0().String_1),
						Double_0 = (this.nullable_0 ?? gclass.imethod_0().Double_0),
						String_3 = (this.string_2 ?? gclass.imethod_0().String_3)
					};
					MemoryStream memoryStream = new MemoryStream();
					MultipartFormDataContent multipartFormDataContent;
					try
					{
						this.stream_0.CopyTo(memoryStream);
						multipartFormDataContent = new MultipartFormDataContent
						{
							{
								new StringContent(gclass2.String_0),
								"model"
							},
							{
								new StringContent(gclass2.String_3),
								"response_format"
							},
							{
								new ByteArrayContent(memoryStream.ToArray()),
								"file",
								this.string_3
							}
						};
						if (!string.IsNullOrEmpty(gclass2.String_2))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_2), "language");
						}
						if (!string.IsNullOrEmpty(gclass2.String_1))
						{
							multipartFormDataContent.Add(new StringContent(gclass2.String_1), "prompt");
						}
						if (gclass2.Double_0 != 0.0)
						{
							multipartFormDataContent.Add(new StringContent(gclass2.Double_0.ToString()), "temperature");
						}
					}
					finally
					{
						if (num < 0 && memoryStream != null)
						{
							((IDisposable)memoryStream).Dispose();
						}
					}
					awaiter = gclass.method_4(gclass.method_0(), HttpMethod.Post, multipartFormDataContent).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass152.Struct387>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
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

		// Token: 0x060025B9 RID: 9657 RVA: 0x000191E6 File Offset: 0x000173E6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040018CB RID: 6347
		public int int_0;

		// Token: 0x040018CC RID: 6348
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040018CD RID: 6349
		public string string_0;

		// Token: 0x040018CE RID: 6350
		public GClass152 gclass152_0;

		// Token: 0x040018CF RID: 6351
		public string string_1;

		// Token: 0x040018D0 RID: 6352
		public double? nullable_0;

		// Token: 0x040018D1 RID: 6353
		public string string_2;

		// Token: 0x040018D2 RID: 6354
		public Stream stream_0;

		// Token: 0x040018D3 RID: 6355
		public string string_3;

		// Token: 0x040018D4 RID: 6356
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
