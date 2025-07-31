using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

// Token: 0x02000216 RID: 534
public sealed class GClass56
{
	// Token: 0x06000E74 RID: 3700 RVA: 0x00051C74 File Offset: 0x0004FE74
	public GClass56(GClass150 gclass150_1, GClass27 gclass27_0 = null, GClass78 gclass78_1 = null)
	{
		this.method_1(new GClass78(gclass78_1));
		if (gclass27_0 != null)
		{
			this.method_0().String_0 = gclass27_0;
		}
		if (this.method_0().String_0 == null)
		{
			this.method_0().String_0 = GClass27.smethod_2();
		}
		this.list_0 = new List<GClass258>();
		this.gclass150_0 = gclass150_1;
		this.method_0().Nullable_2 = new int?(1);
		this.method_0().Boolean_0 = false;
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x0000ABFE File Offset: 0x00008DFE
	public GClass78 method_0()
	{
		return this.gclass78_0;
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x0000AC06 File Offset: 0x00008E06
	private void method_1(GClass78 gclass78_1)
	{
		this.gclass78_0 = gclass78_1;
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x0000AC0F File Offset: 0x00008E0F
	public GClass27 method_2()
	{
		return this.method_0().String_0;
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x0000AC21 File Offset: 0x00008E21
	public void method_3(GClass27 gclass27_0)
	{
		this.method_0().String_0 = gclass27_0;
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x0000AC34 File Offset: 0x00008E34
	public GClass36 method_4()
	{
		return this.gclass36_0;
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x0000AC3C File Offset: 0x00008E3C
	private void method_5(GClass36 gclass36_1)
	{
		this.gclass36_0 = gclass36_1;
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x0000AC45 File Offset: 0x00008E45
	public IList<GClass258> method_6()
	{
		return this.list_0;
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x0000AC4D File Offset: 0x00008E4D
	public void method_7(GClass258 gclass258_0)
	{
		this.list_0.Add(gclass258_0);
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x0000AC5B File Offset: 0x00008E5B
	public void method_8(GClass54 gclass54_0, string string_0, GClass258.GClass259[] gclass259_0)
	{
		this.method_7(new GClass258(gclass54_0, string_0, gclass259_0));
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x0000AC6B File Offset: 0x00008E6B
	public void method_9(string string_0, GClass258.GClass259[] gclass259_0)
	{
		this.method_7(new GClass258(GClass54.smethod_2(), string_0, gclass259_0));
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x0000AC7F File Offset: 0x00008E7F
	public void method_10(string string_0, string string_1, GClass258.GClass259[] gclass259_0)
	{
		this.method_7(new GClass258(GClass54.smethod_2(), string_1, gclass259_0)
		{
			Name = string_0
		});
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x0000AC9A File Offset: 0x00008E9A
	public void method_11(string string_0)
	{
		this.method_7(new GClass258(GClass54.smethod_1(), string_0));
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x0000ACAD File Offset: 0x00008EAD
	public void method_12(string string_0)
	{
		this.method_7(new GClass258(GClass54.smethod_3(), string_0));
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00051D00 File Offset: 0x0004FF00
	public void method_13(EventHandler<List<GClass258>> eventHandler_1)
	{
		EventHandler<List<GClass258>> eventHandler = this.eventHandler_0;
		EventHandler<List<GClass258>> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<List<GClass258>> value = (EventHandler<List<GClass258>>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<List<GClass258>>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00051D38 File Offset: 0x0004FF38
	public void method_14(EventHandler<List<GClass258>> eventHandler_1)
	{
		EventHandler<List<GClass258>> eventHandler = this.eventHandler_0;
		EventHandler<List<GClass258>> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<List<GClass258>> value = (EventHandler<List<GClass258>>)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<List<GClass258>>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x0000ACC0 File Offset: 0x00008EC0
	public bool method_15()
	{
		return this.bool_0;
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x0000ACC8 File Offset: 0x00008EC8
	public void method_16(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00051D70 File Offset: 0x0004FF70
	public Task<string> method_17()
	{
		GClass56.Struct128 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass56_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass56.Struct128>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x0000ACD1 File Offset: 0x00008ED1
	public Task<string> method_18()
	{
		return this.method_17();
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00051DB4 File Offset: 0x0004FFB4
	public Task method_19(Action<string> action_0)
	{
		GClass56.Struct127 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass56_0 = this;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass56.Struct127>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00051E00 File Offset: 0x00050000
	public Task method_20(Action<int, string> action_0)
	{
		GClass56.Struct129 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass56_0 = this;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass56.Struct129>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x0000ACD9 File Offset: 0x00008ED9
	[AsyncIteratorStateMachine(typeof(GClass56.Class251))]
	public IAsyncEnumerable<string> method_21()
	{
		return new GClass56.Class251(-2)
		{
			gclass56_0 = this
		};
	}

	// Token: 0x04000943 RID: 2371
	private GClass150 gclass150_0;

	// Token: 0x04000944 RID: 2372
	private GClass78 gclass78_0;

	// Token: 0x04000945 RID: 2373
	private GClass36 gclass36_0;

	// Token: 0x04000946 RID: 2374
	private List<GClass258> list_0;

	// Token: 0x04000947 RID: 2375
	private EventHandler<List<GClass258>> eventHandler_0;

	// Token: 0x04000948 RID: 2376
	private bool bool_0 = true;

	// Token: 0x02000217 RID: 535
	[StructLayout(LayoutKind.Auto)]
	private struct Struct127 : IAsyncStateMachine
	{
		// Token: 0x06000E8B RID: 3723 RVA: 0x00051E4C File Offset: 0x0005004C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass56 gclass = this.gclass56_0;
			try
			{
				ValueTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.valueTaskAwaiter_1;
						this.valueTaskAwaiter_1 = default(ValueTaskAwaiter);
						this.int_0 = -1;
						goto IL_13B;
					}
					this.iasyncEnumerator_0 = gclass.method_21().GetAsyncEnumerator(default(CancellationToken));
					this.object_0 = null;
					this.int_1 = 0;
				}
				try
				{
					ValueTaskAwaiter<bool> awaiter2;
					if (num == 0)
					{
						awaiter2 = this.valueTaskAwaiter_0;
						this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
						this.int_0 = -1;
						goto IL_BD;
					}
					IL_9F:
					awaiter2 = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.valueTaskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass56.Struct127>(ref awaiter2, ref this);
						return;
					}
					IL_BD:
					if (awaiter2.GetResult())
					{
						string obj = this.iasyncEnumerator_0.Current;
						this.action_0(obj);
						goto IL_9F;
					}
				}
				catch (object obj2)
				{
					this.object_0 = obj2;
				}
				if (this.iasyncEnumerator_0 == null)
				{
					goto IL_142;
				}
				awaiter = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.valueTaskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass56.Struct127>(ref awaiter, ref this);
					return;
				}
				IL_13B:
				awaiter.GetResult();
				IL_142:
				object obj2 = this.object_0;
				if (obj2 != null)
				{
					Exception ex = obj2 as Exception;
					if (ex == null)
					{
						throw obj2;
					}
					ExceptionDispatchInfo.Capture(ex).Throw();
				}
				this.object_0 = null;
				this.iasyncEnumerator_0 = null;
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

		// Token: 0x06000E8C RID: 3724 RVA: 0x0000ACE9 File Offset: 0x00008EE9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000949 RID: 2377
		public int int_0;

		// Token: 0x0400094A RID: 2378
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400094B RID: 2379
		public GClass56 gclass56_0;

		// Token: 0x0400094C RID: 2380
		public Action<string> action_0;

		// Token: 0x0400094D RID: 2381
		private IAsyncEnumerator<string> iasyncEnumerator_0;

		// Token: 0x0400094E RID: 2382
		private object object_0;

		// Token: 0x0400094F RID: 2383
		private int int_1;

		// Token: 0x04000950 RID: 2384
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x04000951 RID: 2385
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x02000218 RID: 536
	private sealed class Class251 : IAsyncEnumerable<string>, IAsyncEnumerator<string>, IValueTaskSource<bool>, IAsyncStateMachine, IAsyncDisposable, IValueTaskSource
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x0000ACF7 File Offset: 0x00008EF7
		[DebuggerHidden]
		public Class251(int int_2)
		{
			this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
			this.int_0 = int_2;
			this.int_1 = Environment.CurrentManagedThreadId;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0005202C File Offset: 0x0005022C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass56 gclass = this.gclass56_0;
			try
			{
				GClass78 gclass78_;
				ValueTaskAwaiter<bool> awaiter;
				switch (num)
				{
				case -4:
				{
					int num2 = -1;
					num = -1;
					this.int_0 = num2;
					if (this.bool_0)
					{
						goto IL_4AE;
					}
					goto IL_39F;
				}
				case 0:
					IL_8F:
					try
					{
						if (num != 0)
						{
							this.iasyncEnumerable_0 = gclass.gclass150_0.imethod_10(gclass78_);
							this.iasyncEnumerator_0 = this.iasyncEnumerable_0.GetAsyncEnumerator(default(CancellationToken));
							this.string_0 = null;
							awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int num3 = 0;
								num = 0;
								this.int_0 = num3;
								this.valueTaskAwaiter_0 = awaiter;
								GClass56.Class251 @class = this;
								this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass56.Class251>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.valueTaskAwaiter_0;
							this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
							int num4 = -1;
							num = -1;
							this.int_0 = num4;
						}
						awaiter.GetResult();
						GClass36 gclass2 = this.iasyncEnumerator_0.Current;
						goto IL_307;
					}
					catch (HttpRequestException ex)
					{
						if (ex.Data.Contains("code") && !string.IsNullOrEmpty(ex.Data["code"] as string) && ex.Data["code"].Equals("context_length_exceeded"))
						{
							string text = "The context length of this conversation is too long for the OpenAI API to handle.  Consider shortening the message history by handling the OnTruncationNeeded event and removing some of the messages in the argument.";
							if (ex.Data.Contains("message"))
							{
								text = text + "  " + ex.Data["message"].ToString();
							}
							if (gclass.eventHandler_0 != null)
							{
								int num5 = gclass.method_6().Sum(new Func<GClass258, int>(GClass56.Class252.class252_0.method_2));
								gclass.eventHandler_0(gclass, gclass.list_0);
								if (num5 <= gclass.method_6().Sum(new Func<GClass258, int>(GClass56.Class252.class252_0.method_3)))
								{
									this.bool_1 = false;
									throw new ArgumentOutOfRangeException("OnTruncationNeeded was called but it did not reduce the message history length.  " + text, ex);
								}
								this.bool_1 = true;
							}
							else
							{
								if (!gclass.method_15())
								{
									this.bool_1 = false;
									throw new ArgumentOutOfRangeException(text, ex);
								}
								for (int i = 0; i < gclass.list_0.Count; i++)
								{
									if (gclass.list_0[i].GClass54_0 != GClass54.smethod_1())
									{
										gclass.list_0.RemoveAt(i);
										this.bool_1 = true;
										break;
									}
								}
							}
							goto IL_307;
						}
						throw ex;
					}
					goto IL_2DD;
				case 1:
				{
					awaiter = this.valueTaskAwaiter_0;
					this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
					int num6 = -1;
					num = -1;
					this.int_0 = num6;
					goto IL_3D7;
				}
				}
				if (this.bool_0)
				{
					goto IL_4AE;
				}
				int num7 = -1;
				num = -1;
				this.int_0 = num7;
				gclass78_ = null;
				this.stringBuilder_0 = new StringBuilder();
				this.gclass54_0 = null;
				this.iasyncEnumerable_0 = null;
				this.bool_1 = true;
				this.iasyncEnumerator_0 = null;
				goto IL_307;
				IL_2DD:
				this.bool_1 = false;
				gclass78_ = new GClass78(gclass.method_0())
				{
					IList_0 = gclass.list_0.ToList<GClass258>()
				};
				goto IL_8F;
				IL_307:
				if (this.bool_1)
				{
					goto IL_2DD;
				}
				if (this.iasyncEnumerable_0 == null)
				{
					throw new Exception("The chat result stream is null, but it shouldn't be");
				}
				IL_344:
				this.gclass36_0 = this.iasyncEnumerator_0.Current;
				GClass53 gclass3 = this.gclass36_0.IReadOnlyList_0.FirstOrDefault<GClass53>();
				GClass258 gclass4 = (gclass3 != null) ? gclass3.GClass258_0 : null;
				if (gclass4 != null)
				{
					if (gclass4.GClass54_0 != null)
					{
						this.gclass54_0 = gclass4.GClass54_0;
					}
					string string_ = gclass4.String_1;
					if (!string.IsNullOrEmpty(string_))
					{
						this.stringBuilder_0.Append(string_);
						this.string_0 = string_;
						int num8 = -4;
						num = -4;
						this.int_0 = num8;
						goto IL_4A1;
					}
				}
				IL_39F:
				gclass.method_5(this.gclass36_0);
				this.gclass36_0 = null;
				this.string_0 = null;
				awaiter = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num9 = 1;
					num = 1;
					this.int_0 = num9;
					this.valueTaskAwaiter_0 = awaiter;
					GClass56.Class251 @class = this;
					this.asyncIteratorMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass56.Class251>(ref awaiter, ref @class);
					return;
				}
				IL_3D7:
				if (!awaiter.GetResult())
				{
					if (this.gclass54_0 != null)
					{
						gclass.method_8(this.gclass54_0, this.stringBuilder_0.ToString(), Array.Empty<GClass258.GClass259>());
					}
					goto IL_4AE;
				}
				goto IL_344;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.stringBuilder_0 = null;
				this.gclass54_0 = null;
				this.iasyncEnumerable_0 = null;
				this.iasyncEnumerator_0 = null;
				this.gclass36_0 = null;
				this.string_0 = null;
				this.asyncIteratorMethodBuilder_0.Complete();
				this.manualResetValueTaskSourceCore_0.SetException(exception);
				return;
			}
			IL_4A1:
			this.manualResetValueTaskSourceCore_0.SetResult(true);
			return;
			IL_4AE:
			this.int_0 = -2;
			this.stringBuilder_0 = null;
			this.gclass54_0 = null;
			this.iasyncEnumerable_0 = null;
			this.iasyncEnumerator_0 = null;
			this.gclass36_0 = null;
			this.string_0 = null;
			this.asyncIteratorMethodBuilder_0.Complete();
			this.manualResetValueTaskSourceCore_0.SetResult(false);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0000311B File Offset: 0x0000131B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00052564 File Offset: 0x00050764
		[DebuggerHidden]
		[return: Attribute10(new byte[]
		{
			1,
			0
		})]
		IAsyncEnumerator<string> IAsyncEnumerable<string>.GetAsyncEnumerator(CancellationToken cancellationToken_0)
		{
			GClass56.Class251 @class;
			if (this.int_0 == -2 && this.int_1 == Environment.CurrentManagedThreadId)
			{
				this.int_0 = -3;
				this.asyncIteratorMethodBuilder_0 = AsyncIteratorMethodBuilder.Create();
				this.bool_0 = false;
				@class = this;
			}
			else
			{
				@class = new GClass56.Class251(-3);
				@class.gclass56_0 = this.gclass56_0;
			}
			return @class;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000525BC File Offset: 0x000507BC
		[DebuggerHidden]
		ValueTask<bool> IAsyncEnumerator<string>.MoveNextAsync()
		{
			if (this.int_0 == -2)
			{
				return default(ValueTask<bool>);
			}
			this.manualResetValueTaskSourceCore_0.Reset();
			GClass56.Class251 @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass56.Class251>(ref @class);
			short version = this.manualResetValueTaskSourceCore_0.Version;
			if (this.manualResetValueTaskSourceCore_0.GetStatus(version) == 1)
			{
				return new ValueTask<bool>(this.manualResetValueTaskSourceCore_0.GetResult(version));
			}
			return new ValueTask<bool>(this, version);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0000AD1C File Offset: 0x00008F1C
		[DebuggerHidden]
		string IAsyncEnumerator<string>.get_Current()
		{
			return this.string_0;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0000AD24 File Offset: 0x00008F24
		[DebuggerHidden]
		bool IValueTaskSource<bool>.GetResult(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0000AD32 File Offset: 0x00008F32
		[DebuggerHidden]
		ValueTaskSourceStatus IValueTaskSource<bool>.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0000AD40 File Offset: 0x00008F40
		[DebuggerHidden]
		void IValueTaskSource<bool>.OnCompleted(Action<object> action_0, object object_0, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_0, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0000AD52 File Offset: 0x00008F52
		[DebuggerHidden]
		void IValueTaskSource.GetResult(short short_0)
		{
			this.manualResetValueTaskSourceCore_0.GetResult(short_0);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0000AD32 File Offset: 0x00008F32
		[DebuggerHidden]
		ValueTaskSourceStatus IValueTaskSource.GetStatus(short short_0)
		{
			return this.manualResetValueTaskSourceCore_0.GetStatus(short_0);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0000AD40 File Offset: 0x00008F40
		[DebuggerHidden]
		void IValueTaskSource.OnCompleted(Action<object> action_0, object object_0, short short_0, ValueTaskSourceOnCompletedFlags valueTaskSourceOnCompletedFlags_0)
		{
			this.manualResetValueTaskSourceCore_0.OnCompleted(action_0, object_0, short_0, valueTaskSourceOnCompletedFlags_0);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0005262C File Offset: 0x0005082C
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
			GClass56.Class251 @class = this;
			this.asyncIteratorMethodBuilder_0.MoveNext<GClass56.Class251>(ref @class);
			return new ValueTask(this, this.manualResetValueTaskSourceCore_0.Version);
		}

		// Token: 0x04000952 RID: 2386
		public int int_0;

		// Token: 0x04000953 RID: 2387
		public AsyncIteratorMethodBuilder asyncIteratorMethodBuilder_0;

		// Token: 0x04000954 RID: 2388
		public ManualResetValueTaskSourceCore<bool> manualResetValueTaskSourceCore_0;

		// Token: 0x04000955 RID: 2389
		private string string_0;

		// Token: 0x04000956 RID: 2390
		private bool bool_0;

		// Token: 0x04000957 RID: 2391
		private int int_1;

		// Token: 0x04000958 RID: 2392
		public GClass56 gclass56_0;

		// Token: 0x04000959 RID: 2393
		private StringBuilder stringBuilder_0;

		// Token: 0x0400095A RID: 2394
		private GClass54 gclass54_0;

		// Token: 0x0400095B RID: 2395
		private IAsyncEnumerable<GClass36> iasyncEnumerable_0;

		// Token: 0x0400095C RID: 2396
		private bool bool_1;

		// Token: 0x0400095D RID: 2397
		private IAsyncEnumerator<GClass36> iasyncEnumerator_0;

		// Token: 0x0400095E RID: 2398
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x0400095F RID: 2399
		private GClass36 gclass36_0;
	}

	// Token: 0x02000219 RID: 537
	[StructLayout(LayoutKind.Auto)]
	private struct Struct128 : IAsyncStateMachine
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x00052690 File Offset: 0x00050890
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass56 gclass = this.gclass56_0;
			string result2;
			try
			{
				TaskAwaiter<string> awaiter;
				switch (num)
				{
				case 0:
					break;
				case 1:
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_332;
				case 2:
					awaiter = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<string>);
					this.int_0 = -1;
					goto IL_359;
				default:
					this.int_1 = 0;
					break;
				}
				try
				{
					TaskAwaiter<GClass36> awaiter2;
					if (num != 0)
					{
						GClass78 gclass78_ = new GClass78(gclass.method_0())
						{
							IList_0 = gclass.list_0.ToList<GClass258>()
						};
						awaiter2 = gclass.gclass150_0.imethod_3(gclass78_).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass36>, GClass56.Struct128>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass36>);
						this.int_0 = -1;
					}
					GClass36 result = awaiter2.GetResult();
					gclass.method_5(result);
					if (result.IReadOnlyList_0.Count > 0)
					{
						GClass258 message = result.IReadOnlyList_0[0].Message;
						gclass.method_7(message);
						result2 = message.String_1;
						goto IL_37D;
					}
				}
				catch (HttpRequestException ex)
				{
					this.object_0 = ex;
					this.int_1 = 1;
				}
				int num2 = this.int_1;
				if (num2 == 1)
				{
					HttpRequestException ex2 = (HttpRequestException)this.object_0;
					if (!ex2.Data.Contains("code") || string.IsNullOrEmpty(ex2.Data["code"] as string) || !ex2.Data["code"].Equals("context_length_exceeded"))
					{
						throw ex2;
					}
					string text = "The context length of this conversation is too long for the OpenAI API to handle.  Consider shortening the message history by handling the OnTruncationNeeded event and removing some of the messages in the argument.";
					if (ex2.Data.Contains("message"))
					{
						text = text + "  " + ex2.Data["message"].ToString();
					}
					if (gclass.eventHandler_0 != null)
					{
						int num3 = gclass.method_6().Sum(new Func<GClass258, int>(GClass56.Class252.class252_0.method_0));
						gclass.eventHandler_0(gclass, gclass.list_0);
						if (num3 <= gclass.method_6().Sum(new Func<GClass258, int>(GClass56.Class252.class252_0.method_1)))
						{
							throw new ArgumentOutOfRangeException("OnTruncationNeeded was called but it did not reduce the message history length.  " + text, ex2);
						}
						awaiter = gclass.method_17().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_1 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass56.Struct128>(ref awaiter, ref this);
							return;
						}
						goto IL_332;
					}
					else
					{
						if (!gclass.method_15())
						{
							throw new ArgumentOutOfRangeException(text, ex2);
						}
						int i = 0;
						while (i < gclass.list_0.Count)
						{
							if (gclass.list_0[i].GClass54_0 != GClass54.smethod_1())
							{
								gclass.list_0.RemoveAt(i);
								awaiter = gclass.method_17().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									this.int_0 = 2;
									this.taskAwaiter_1 = awaiter;
									this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass56.Struct128>(ref awaiter, ref this);
									return;
								}
								goto IL_359;
							}
							else
							{
								i++;
							}
						}
					}
				}
				this.object_0 = null;
				result2 = null;
				goto IL_37D;
				IL_332:
				result2 = awaiter.GetResult();
				goto IL_37D;
				IL_359:
				result2 = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_37D:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0000AD61 File Offset: 0x00008F61
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000960 RID: 2400
		public int int_0;

		// Token: 0x04000961 RID: 2401
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000962 RID: 2402
		public GClass56 gclass56_0;

		// Token: 0x04000963 RID: 2403
		private object object_0;

		// Token: 0x04000964 RID: 2404
		private int int_1;

		// Token: 0x04000965 RID: 2405
		private TaskAwaiter<GClass36> taskAwaiter_0;

		// Token: 0x04000966 RID: 2406
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x0200021A RID: 538
	[StructLayout(LayoutKind.Auto)]
	private struct Struct129 : IAsyncStateMachine
	{
		// Token: 0x06000E9C RID: 3740 RVA: 0x00052A64 File Offset: 0x00050C64
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass56 gclass = this.gclass56_0;
			try
			{
				ValueTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.valueTaskAwaiter_1;
						this.valueTaskAwaiter_1 = default(ValueTaskAwaiter);
						this.int_0 = -1;
						goto IL_156;
					}
					this.int_1 = 0;
					this.iasyncEnumerator_0 = gclass.method_21().GetAsyncEnumerator(default(CancellationToken));
					this.object_0 = null;
					this.int_2 = 0;
				}
				try
				{
					ValueTaskAwaiter<bool> awaiter2;
					if (num == 0)
					{
						awaiter2 = this.valueTaskAwaiter_0;
						this.valueTaskAwaiter_0 = default(ValueTaskAwaiter<bool>);
						this.int_0 = -1;
						goto IL_D6;
					}
					IL_B8:
					awaiter2 = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.valueTaskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass56.Struct129>(ref awaiter2, ref this);
						return;
					}
					IL_D6:
					if (awaiter2.GetResult())
					{
						string arg = this.iasyncEnumerator_0.Current;
						Action<int, string> action = this.action_0;
						int num2 = this.int_1;
						this.int_1 = num2 + 1;
						action(num2, arg);
						goto IL_B8;
					}
				}
				catch (object obj)
				{
					this.object_0 = obj;
				}
				if (this.iasyncEnumerator_0 == null)
				{
					goto IL_15D;
				}
				awaiter = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.valueTaskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass56.Struct129>(ref awaiter, ref this);
					return;
				}
				IL_156:
				awaiter.GetResult();
				IL_15D:
				object obj = this.object_0;
				if (obj != null)
				{
					Exception ex = obj as Exception;
					if (ex == null)
					{
						throw obj;
					}
					ExceptionDispatchInfo.Capture(ex).Throw();
				}
				this.object_0 = null;
				this.iasyncEnumerator_0 = null;
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

		// Token: 0x06000E9D RID: 3741 RVA: 0x0000AD6F File Offset: 0x00008F6F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000967 RID: 2407
		public int int_0;

		// Token: 0x04000968 RID: 2408
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000969 RID: 2409
		public GClass56 gclass56_0;

		// Token: 0x0400096A RID: 2410
		public Action<int, string> action_0;

		// Token: 0x0400096B RID: 2411
		private int int_1;

		// Token: 0x0400096C RID: 2412
		private IAsyncEnumerator<string> iasyncEnumerator_0;

		// Token: 0x0400096D RID: 2413
		private object object_0;

		// Token: 0x0400096E RID: 2414
		private int int_2;

		// Token: 0x0400096F RID: 2415
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x04000970 RID: 2416
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x0200021B RID: 539
	[Serializable]
	private sealed class Class252
	{
		// Token: 0x06000EA0 RID: 3744 RVA: 0x0000AD89 File Offset: 0x00008F89
		internal int method_0(GClass258 gclass258_0)
		{
			return gclass258_0.String_1.Length;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0000AD89 File Offset: 0x00008F89
		internal int method_1(GClass258 gclass258_0)
		{
			return gclass258_0.String_1.Length;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0000AD89 File Offset: 0x00008F89
		internal int method_2(GClass258 gclass258_0)
		{
			return gclass258_0.String_1.Length;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0000AD89 File Offset: 0x00008F89
		internal int method_3(GClass258 gclass258_0)
		{
			return gclass258_0.String_1.Length;
		}

		// Token: 0x04000971 RID: 2417
		public static readonly GClass56.Class252 class252_0 = new GClass56.Class252();

		// Token: 0x04000972 RID: 2418
		public static Func<GClass258, int> func_0;

		// Token: 0x04000973 RID: 2419
		public static Func<GClass258, int> func_1;

		// Token: 0x04000974 RID: 2420
		public static Func<GClass258, int> func_2;

		// Token: 0x04000975 RID: 2421
		public static Func<GClass258, int> func_3;
	}
}
