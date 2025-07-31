using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

// Token: 0x02000402 RID: 1026
public sealed class GClass139
{
	// Token: 0x06001A75 RID: 6773 RVA: 0x00011D07 File Offset: 0x0000FF07
	public GClass139()
	{
		GClass139.smethod_0(ref this.object_0);
		base..ctor();
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x00073E00 File Offset: 0x00072000
	public void method_0(EventHandler<double> eventHandler_1)
	{
		EventHandler<double> eventHandler = this.eventHandler_0;
		EventHandler<double> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<double> value = (EventHandler<double>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<double>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x00073E38 File Offset: 0x00072038
	public void method_1(EventHandler<double> eventHandler_1)
	{
		EventHandler<double> eventHandler = this.eventHandler_0;
		EventHandler<double> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<double> value = (EventHandler<double>)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<double>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x00073E70 File Offset: 0x00072070
	public Task<double> method_2(CancellationToken cancellationToken_0, TimeSpan timeSpan_0, int int_0)
	{
		object[] object_ = new object[]
		{
			this,
			cancellationToken_0,
			timeSpan_0,
			int_0
		};
		return (Task<double>)Class392.smethod_3().method_105(Class392.smethod_1(), "(pp]XZa-k3", object_);
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x00073EC0 File Offset: 0x000720C0
	public Task<double> method_3(CancellationToken cancellationToken_0, TimeSpan timeSpan_0, int int_0)
	{
		object[] object_ = new object[]
		{
			this,
			cancellationToken_0,
			timeSpan_0,
			int_0
		};
		return (Task<double>)Class392.smethod_3().method_105(Class392.smethod_1(), "#ILnGZa-k$", object_);
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x00073F10 File Offset: 0x00072110
	private static void smethod_0(ref object object_1)
	{
		object[] array = new object[]
		{
			object_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "<OB0@Za-k/", array);
		}
		finally
		{
			object_1 = (object)array[0];
		}
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x00011D1A File Offset: 0x0000FF1A
	private static void smethod_1(ref GClass139.Struct257 struct257_0)
	{
		struct257_0.asyncTaskMethodBuilder_0.Start<GClass139.Struct257>(ref struct257_0);
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x00011D28 File Offset: 0x0000FF28
	private static void smethod_2(ref GClass139.Struct254 struct254_0)
	{
		struct254_0.asyncTaskMethodBuilder_0.Start<GClass139.Struct254>(ref struct254_0);
	}

	// Token: 0x040011A3 RID: 4515
	private EventHandler<double> eventHandler_0;

	// Token: 0x040011A4 RID: 4516
	private readonly object object_0;

	// Token: 0x02000403 RID: 1027
	private sealed class Class461
	{
		// Token: 0x06001A7E RID: 6782 RVA: 0x00073F6C File Offset: 0x0007216C
		internal void method_0(object sender, ElapsedEventArgs e)
		{
			object object_ = this.gclass139_0.object_0;
			long num;
			lock (object_)
			{
				num = this.long_0.Sum();
			}
			double num2 = (double)this.stopwatch_0.ElapsedMilliseconds / 1000.0;
			if (num2 > 0.0)
			{
				double num3 = (double)num * 8.0 / 1024.0 / 1024.0 / num2;
				if (num3 > 10.0)
				{
					EventHandler<double> eventHandler_ = this.gclass139_0.eventHandler_0;
					if (eventHandler_ == null)
					{
						return;
					}
					eventHandler_(this.gclass139_0, num3);
				}
			}
		}

		// Token: 0x040011A5 RID: 4517
		public GClass139 gclass139_0;

		// Token: 0x040011A6 RID: 4518
		public long[] long_0;

		// Token: 0x040011A7 RID: 4519
		public CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x040011A8 RID: 4520
		public Stopwatch stopwatch_0;
	}

	// Token: 0x02000404 RID: 1028
	[StructLayout(LayoutKind.Auto)]
	private struct Struct254 : IAsyncStateMachine
	{
		// Token: 0x06001A7F RID: 6783 RVA: 0x00074028 File Offset: 0x00072228
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "A$iYNZa-k(", array);
			}
			finally
			{
				this = (GClass139.Struct254)array[0];
			}
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00011D36 File Offset: 0x0000FF36
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00011D44 File Offset: 0x0000FF44
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass139.Struct254 struct254_0)
		{
			struct254_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass139.Struct254>(ref taskAwaiter_1, ref struct254_0);
		}

		// Token: 0x040011A9 RID: 4521
		public int int_0;

		// Token: 0x040011AA RID: 4522
		public AsyncTaskMethodBuilder<double> asyncTaskMethodBuilder_0;

		// Token: 0x040011AB RID: 4523
		public GClass139 gclass139_0;

		// Token: 0x040011AC RID: 4524
		public int int_1;

		// Token: 0x040011AD RID: 4525
		public CancellationToken cancellationToken_0;

		// Token: 0x040011AE RID: 4526
		public TimeSpan timeSpan_0;

		// Token: 0x040011AF RID: 4527
		private GClass139.Class462 class462_0;

		// Token: 0x040011B0 RID: 4528
		private System.Timers.Timer timer_0;

		// Token: 0x040011B1 RID: 4529
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000405 RID: 1029
	private sealed class Class462
	{
		// Token: 0x06001A83 RID: 6787 RVA: 0x00074090 File Offset: 0x00072290
		internal void method_0(object sender, ElapsedEventArgs e)
		{
			object object_ = this.gclass139_0.object_0;
			long num;
			lock (object_)
			{
				num = this.long_0.Sum();
			}
			double num2 = (double)this.stopwatch_0.ElapsedMilliseconds / 1000.0;
			if (num2 > 0.0)
			{
				double num3 = (double)num * 8.0 / 1024.0 / 1024.0 / num2;
				if (num3 > 10.0)
				{
					EventHandler<double> eventHandler_ = this.gclass139_0.eventHandler_0;
					if (eventHandler_ == null)
					{
						return;
					}
					eventHandler_(this.gclass139_0, num3);
				}
			}
		}

		// Token: 0x040011B2 RID: 4530
		public GClass139 gclass139_0;

		// Token: 0x040011B3 RID: 4531
		public long[] long_0;

		// Token: 0x040011B4 RID: 4532
		public CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x040011B5 RID: 4533
		public Stopwatch stopwatch_0;

		// Token: 0x040011B6 RID: 4534
		public byte[] byte_0;
	}

	// Token: 0x02000406 RID: 1030
	private sealed class Class463
	{
		// Token: 0x06001A85 RID: 6789 RVA: 0x0007414C File Offset: 0x0007234C
		internal Task method_0()
		{
			GClass139.Class463.Struct255 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class463_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass139.Class463.Struct255>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040011B7 RID: 4535
		public int int_0;

		// Token: 0x040011B8 RID: 4536
		public GClass139.Class461 class461_0;

		// Token: 0x02000407 RID: 1031
		[StructLayout(LayoutKind.Auto)]
		private struct Struct255 : IAsyncStateMachine
		{
			// Token: 0x06001A86 RID: 6790 RVA: 0x00074190 File Offset: 0x00072390
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass139.Class463 @class = this.class463_0;
				try
				{
					if (num > 2)
					{
						this.httpClient_0 = new HttpClient
						{
							Timeout = TimeSpan.FromSeconds(10.0)
						};
					}
					try
					{
						if (num > 2)
						{
							goto IL_290;
						}
						IL_39:
						try
						{
							TaskAwaiter<HttpResponseMessage> awaiter;
							if (num != 0)
							{
								if (num - 1 <= 1)
								{
									goto IL_C7;
								}
								awaiter = this.httpClient_0.GetAsync("http://77.110.116.81:81/downloading", HttpCompletionOption.ResponseHeadersRead, @class.class461_0.cancellationTokenSource_0.Token).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									int num2 = 0;
									num = 0;
									this.int_0 = num2;
									this.taskAwaiter_0 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass139.Class463.Struct255>(ref awaiter, ref this);
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
							IL_C7:
							try
							{
								TaskAwaiter<Stream> awaiter2;
								if (num != 1)
								{
									if (num == 2)
									{
										goto IL_14B;
									}
									this.httpResponseMessage_0.EnsureSuccessStatusCode();
									awaiter2 = this.httpResponseMessage_0.Content.ReadAsStreamAsync().GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										int num4 = 1;
										num = 1;
										this.int_0 = num4;
										this.taskAwaiter_1 = awaiter2;
										this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, GClass139.Class463.Struct255>(ref awaiter2, ref this);
										return;
									}
								}
								else
								{
									awaiter2 = this.taskAwaiter_1;
									this.taskAwaiter_1 = default(TaskAwaiter<Stream>);
									int num5 = -1;
									num = -1;
									this.int_0 = num5;
								}
								Stream result2 = awaiter2.GetResult();
								this.stream_0 = result2;
								IL_14B:
								try
								{
									if (num != 2)
									{
										this.byte_0 = new byte[8192];
										goto IL_1DC;
									}
									TaskAwaiter<int> awaiter3 = this.taskAwaiter_2;
									this.taskAwaiter_2 = default(TaskAwaiter<int>);
									int num6 = -1;
									num = -1;
									this.int_0 = num6;
									IL_17F:
									int result3;
									if ((result3 = awaiter3.GetResult()) <= 0)
									{
										this.byte_0 = null;
										goto IL_260;
									}
									object object_ = @class.class461_0.gclass139_0.object_0;
									bool flag = false;
									try
									{
										Monitor.Enter(object_, ref flag);
										@class.class461_0.long_0[@class.int_0] += (long)result3;
									}
									finally
									{
										if (num < 0 && flag)
										{
											Monitor.Exit(object_);
										}
									}
									IL_1DC:
									awaiter3 = this.stream_0.ReadAsync(this.byte_0, 0, this.byte_0.Length, @class.class461_0.cancellationTokenSource_0.Token).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										int num7 = 2;
										num = 2;
										this.int_0 = num7;
										this.taskAwaiter_2 = awaiter3;
										this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, GClass139.Class463.Struct255>(ref awaiter3, ref this);
										return;
									}
									goto IL_17F;
								}
								finally
								{
									if (num < 0 && this.stream_0 != null)
									{
										((IDisposable)this.stream_0).Dispose();
									}
								}
								IL_260:
								this.stream_0 = null;
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
						catch (OperationCanceledException)
						{
							goto IL_2AE;
						}
						catch (Exception)
						{
						}
						IL_290:
						if (!@class.class461_0.cancellationTokenSource_0.Token.IsCancellationRequested)
						{
							goto IL_39;
						}
						IL_2AE:;
					}
					finally
					{
						if (num < 0 && this.httpClient_0 != null)
						{
							((IDisposable)this.httpClient_0).Dispose();
						}
					}
					this.httpClient_0 = null;
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

			// Token: 0x06001A87 RID: 6791 RVA: 0x00011D53 File Offset: 0x0000FF53
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040011B9 RID: 4537
			public int int_0;

			// Token: 0x040011BA RID: 4538
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040011BB RID: 4539
			public GClass139.Class463 class463_0;

			// Token: 0x040011BC RID: 4540
			private HttpClient httpClient_0;

			// Token: 0x040011BD RID: 4541
			private HttpResponseMessage httpResponseMessage_0;

			// Token: 0x040011BE RID: 4542
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

			// Token: 0x040011BF RID: 4543
			private Stream stream_0;

			// Token: 0x040011C0 RID: 4544
			private TaskAwaiter<Stream> taskAwaiter_1;

			// Token: 0x040011C1 RID: 4545
			private byte[] byte_0;

			// Token: 0x040011C2 RID: 4546
			private TaskAwaiter<int> taskAwaiter_2;
		}
	}

	// Token: 0x02000408 RID: 1032
	private sealed class Class464
	{
		// Token: 0x06001A89 RID: 6793 RVA: 0x00074548 File Offset: 0x00072748
		internal Task method_0()
		{
			GClass139.Class464.Struct256 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class464_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass139.Class464.Struct256>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040011C3 RID: 4547
		public int int_0;

		// Token: 0x040011C4 RID: 4548
		public GClass139.Class462 class462_0;

		// Token: 0x02000409 RID: 1033
		[StructLayout(LayoutKind.Auto)]
		private struct Struct256 : IAsyncStateMachine
		{
			// Token: 0x06001A8A RID: 6794 RVA: 0x0007458C File Offset: 0x0007278C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass139.Class464 @class = this.class464_0;
				try
				{
					if (num != 0)
					{
						this.httpClient_0 = new HttpClient
						{
							Timeout = TimeSpan.FromSeconds(10.0)
						};
					}
					try
					{
						if (num != 0)
						{
							goto IL_174;
						}
						IL_37:
						try
						{
							if (num != 0)
							{
								this.httpContent_0 = new ByteArrayContent(@class.class462_0.byte_0);
							}
							try
							{
								TaskAwaiter<HttpResponseMessage> awaiter;
								if (num != 0)
								{
									this.httpContent_0.Headers.Add("Content-Type", "application/octet-stream");
									awaiter = this.httpClient_0.PostAsync("http://77.110.116.81:81/upload", this.httpContent_0, @class.class462_0.cancellationTokenSource_0.Token).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										int num2 = 0;
										num = 0;
										this.int_0 = num2;
										this.taskAwaiter_0 = awaiter;
										this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, GClass139.Class464.Struct256>(ref awaiter, ref this);
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
								awaiter.GetResult().EnsureSuccessStatusCode();
								object object_ = @class.class462_0.gclass139_0.object_0;
								bool flag = false;
								try
								{
									Monitor.Enter(object_, ref flag);
									@class.class462_0.long_0[@class.int_0] += (long)@class.class462_0.byte_0.Length;
								}
								finally
								{
									if (num < 0 && flag)
									{
										Monitor.Exit(object_);
									}
								}
							}
							finally
							{
								if (num < 0 && this.httpContent_0 != null)
								{
									((IDisposable)this.httpContent_0).Dispose();
								}
							}
							this.httpContent_0 = null;
						}
						catch (OperationCanceledException)
						{
							goto IL_192;
						}
						catch (Exception)
						{
						}
						IL_174:
						if (!@class.class462_0.cancellationTokenSource_0.Token.IsCancellationRequested)
						{
							goto IL_37;
						}
						IL_192:;
					}
					finally
					{
						if (num < 0 && this.httpClient_0 != null)
						{
							((IDisposable)this.httpClient_0).Dispose();
						}
					}
					this.httpClient_0 = null;
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

			// Token: 0x06001A8B RID: 6795 RVA: 0x00011D61 File Offset: 0x0000FF61
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040011C5 RID: 4549
			public int int_0;

			// Token: 0x040011C6 RID: 4550
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040011C7 RID: 4551
			public GClass139.Class464 class464_0;

			// Token: 0x040011C8 RID: 4552
			private HttpClient httpClient_0;

			// Token: 0x040011C9 RID: 4553
			private HttpContent httpContent_0;

			// Token: 0x040011CA RID: 4554
			private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;
		}
	}

	// Token: 0x0200040A RID: 1034
	[StructLayout(LayoutKind.Auto)]
	private struct Struct257 : IAsyncStateMachine
	{
		// Token: 0x06001A8C RID: 6796 RVA: 0x00074810 File Offset: 0x00072A10
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "&[\\sQZa-jr", array);
			}
			finally
			{
				this = (GClass139.Struct257)array[0];
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00011D6F File Offset: 0x0000FF6F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00011D7D File Offset: 0x0000FF7D
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass139.Struct257 struct257_0)
		{
			struct257_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass139.Struct257>(ref taskAwaiter_1, ref struct257_0);
		}

		// Token: 0x040011CB RID: 4555
		public int int_0;

		// Token: 0x040011CC RID: 4556
		public AsyncTaskMethodBuilder<double> asyncTaskMethodBuilder_0;

		// Token: 0x040011CD RID: 4557
		public GClass139 gclass139_0;

		// Token: 0x040011CE RID: 4558
		public int int_1;

		// Token: 0x040011CF RID: 4559
		public CancellationToken cancellationToken_0;

		// Token: 0x040011D0 RID: 4560
		public TimeSpan timeSpan_0;

		// Token: 0x040011D1 RID: 4561
		private GClass139.Class461 class461_0;

		// Token: 0x040011D2 RID: 4562
		private System.Timers.Timer timer_0;

		// Token: 0x040011D3 RID: 4563
		private TaskAwaiter taskAwaiter_0;
	}
}
