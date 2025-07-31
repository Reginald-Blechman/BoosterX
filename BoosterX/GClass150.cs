using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02000467 RID: 1127
public sealed class GClass150 : GClass143, GInterface14
{
	// Token: 0x06001D5E RID: 7518 RVA: 0x00013728 File Offset: 0x00011928
	internal GClass150(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x0001374C File Offset: 0x0001194C
	[CompilerGenerated]
	public GClass78 imethod_0()
	{
		return this.gclass78_0;
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x00013754 File Offset: 0x00011954
	[CompilerGenerated]
	public void imethod_1(GClass78 gclass78_1)
	{
		this.gclass78_0 = gclass78_1;
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x0001375D File Offset: 0x0001195D
	protected override string vmethod_0()
	{
		return "chat/completions";
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x00013765 File Offset: 0x00011965
	public GClass56 imethod_2(GClass78 gclass78_1 = null)
	{
		return new GClass56(this, null, gclass78_1 ?? this.imethod_0());
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00079D30 File Offset: 0x00077F30
	public Task<GClass36> imethod_3(GClass78 gclass78_1)
	{
		GClass150.Struct290 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass36>.Create();
		@struct.gclass150_0 = this;
		@struct.gclass78_0 = gclass78_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass150.Struct290>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x00013779 File Offset: 0x00011979
	public Task<GClass36> imethod_4(GClass78 gclass78_1, int int_0 = 5)
	{
		gclass78_1.Nullable_2 = new int?(int_0);
		return this.imethod_3(gclass78_1);
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x00079D7C File Offset: 0x00077F7C
	public Task<GClass36> imethod_5(IList<GClass258> ilist_0, GClass27 gclass27_0 = null, double? nullable_0 = null, double? nullable_1 = null, int? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0 = null, params string[] string_0)
	{
		GClass78 gclass = new GClass78(this.imethod_0());
		gclass.IList_0 = ilist_0;
		gclass.String_0 = (gclass27_0 ?? this.imethod_0().String_0);
		double? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		num = nullable_1;
		gclass.Nullable_1 = ((num != null) ? num : this.imethod_0().Nullable_1);
		int? num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		gclass.String_1 = (string_0 ?? this.imethod_0().String_1);
		num2 = nullable_3;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num = nullable_4;
		gclass.Nullable_4 = ((num != null) ? num : this.imethod_0().Nullable_4);
		num = nullable_5;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		gclass.IReadOnlyDictionary_0 = (ireadOnlyDictionary_0 ?? this.imethod_0().IReadOnlyDictionary_0);
		GClass78 gclass78_ = gclass;
		return this.imethod_3(gclass78_);
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x00079EB0 File Offset: 0x000780B0
	public Task<GClass36> imethod_6(params GClass258[] gclass258_0)
	{
		GClass78 gclass78_ = new GClass78(this.imethod_0())
		{
			IList_0 = gclass258_0
		};
		return this.imethod_3(gclass78_);
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x0001378E File Offset: 0x0001198E
	public Task<GClass36> imethod_7(params string[] string_0)
	{
		return this.imethod_6(string_0.Select(new Func<string, GClass258>(GClass150.Class542.class542_0.method_0)).ToArray<GClass258>());
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x00079ED8 File Offset: 0x000780D8
	public Task<GClass36> imethod_8(string string_0, params GClass258.GClass259[] gclass259_0)
	{
		GClass78 gclass78_ = new GClass78(this.imethod_0())
		{
			String_0 = GClass27.smethod_10(),
			IList_0 = new GClass258[]
			{
				new GClass258(GClass54.smethod_2(), string_0, gclass259_0)
			}
		};
		return this.imethod_3(gclass78_);
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x00079F28 File Offset: 0x00078128
	public Task imethod_12(GClass78 gclass78_1, Action<int, GClass36> action_0)
	{
		GClass150.Struct289 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass150_0 = this;
		@struct.gclass78_0 = gclass78_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass150.Struct289>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x00079F7C File Offset: 0x0007817C
	public Task imethod_9(GClass78 gclass78_1, Action<GClass36> action_0)
	{
		GClass150.Struct288 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass150_0 = this;
		@struct.gclass78_0 = gclass78_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass150.Struct288>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001D6B RID: 7531 RVA: 0x000137C0 File Offset: 0x000119C0
	public IAsyncEnumerable<GClass36> imethod_10(GClass78 gclass78_1)
	{
		gclass78_1 = new GClass78(gclass78_1)
		{
			Boolean_0 = true
		};
		return base.method_11<GClass36>(base.method_0(), HttpMethod.Post, gclass78_1);
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x00079FD0 File Offset: 0x000781D0
	public IAsyncEnumerable<GClass36> imethod_11(IList<GClass258> ilist_0, GClass27 gclass27_0 = null, double? nullable_0 = null, double? nullable_1 = null, int? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, IReadOnlyDictionary<string, float> ireadOnlyDictionary_0 = null, params string[] string_0)
	{
		GClass78 gclass = new GClass78(this.imethod_0());
		gclass.IList_0 = ilist_0;
		gclass.String_0 = (gclass27_0 ?? this.imethod_0().String_0);
		double? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		num = nullable_1;
		gclass.Nullable_1 = ((num != null) ? num : this.imethod_0().Nullable_1);
		int? num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		gclass.String_1 = (string_0 ?? this.imethod_0().String_1);
		num2 = nullable_3;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num = nullable_4;
		gclass.Nullable_4 = ((num != null) ? num : this.imethod_0().Nullable_4);
		num = nullable_5;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		gclass.IReadOnlyDictionary_0 = (ireadOnlyDictionary_0 ?? this.imethod_0().IReadOnlyDictionary_0);
		GClass78 gclass78_ = gclass;
		return this.imethod_10(gclass78_);
	}

	// Token: 0x0400137E RID: 4990
	private GClass78 gclass78_0 = new GClass78
	{
		String_0 = GClass27.smethod_2()
	};

	// Token: 0x02000468 RID: 1128
	[StructLayout(LayoutKind.Auto)]
	private struct Struct288 : IAsyncStateMachine
	{
		// Token: 0x06001D6D RID: 7533 RVA: 0x0007A104 File Offset: 0x00078304
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass150 gclass = this.gclass150_0;
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
						goto IL_141;
					}
					this.iasyncEnumerator_0 = gclass.imethod_10(this.gclass78_0).GetAsyncEnumerator(default(CancellationToken));
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
						goto IL_C3;
					}
					IL_A5:
					awaiter2 = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.valueTaskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass150.Struct288>(ref awaiter2, ref this);
						return;
					}
					IL_C3:
					if (awaiter2.GetResult())
					{
						GClass36 obj = this.iasyncEnumerator_0.Current;
						this.action_0(obj);
						goto IL_A5;
					}
				}
				catch (object obj2)
				{
					this.object_0 = obj2;
				}
				if (this.iasyncEnumerator_0 == null)
				{
					goto IL_148;
				}
				awaiter = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.valueTaskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass150.Struct288>(ref awaiter, ref this);
					return;
				}
				IL_141:
				awaiter.GetResult();
				IL_148:
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

		// Token: 0x06001D6E RID: 7534 RVA: 0x000137E5 File Offset: 0x000119E5
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400137F RID: 4991
		public int int_0;

		// Token: 0x04001380 RID: 4992
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001381 RID: 4993
		public GClass150 gclass150_0;

		// Token: 0x04001382 RID: 4994
		public GClass78 gclass78_0;

		// Token: 0x04001383 RID: 4995
		public Action<GClass36> action_0;

		// Token: 0x04001384 RID: 4996
		private IAsyncEnumerator<GClass36> iasyncEnumerator_0;

		// Token: 0x04001385 RID: 4997
		private object object_0;

		// Token: 0x04001386 RID: 4998
		private int int_1;

		// Token: 0x04001387 RID: 4999
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x04001388 RID: 5000
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x02000469 RID: 1129
	[StructLayout(LayoutKind.Auto)]
	private struct Struct289 : IAsyncStateMachine
	{
		// Token: 0x06001D6F RID: 7535 RVA: 0x0007A2E8 File Offset: 0x000784E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass150 gclass = this.gclass150_0;
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
						goto IL_15C;
					}
					this.int_1 = 0;
					this.iasyncEnumerator_0 = gclass.imethod_10(this.gclass78_0).GetAsyncEnumerator(default(CancellationToken));
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
						goto IL_DC;
					}
					IL_BE:
					awaiter2 = this.iasyncEnumerator_0.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.valueTaskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass150.Struct289>(ref awaiter2, ref this);
						return;
					}
					IL_DC:
					if (awaiter2.GetResult())
					{
						GClass36 arg = this.iasyncEnumerator_0.Current;
						Action<int, GClass36> action = this.action_0;
						int num2 = this.int_1;
						this.int_1 = num2 + 1;
						action(num2, arg);
						goto IL_BE;
					}
				}
				catch (object obj)
				{
					this.object_0 = obj;
				}
				if (this.iasyncEnumerator_0 == null)
				{
					goto IL_163;
				}
				awaiter = this.iasyncEnumerator_0.DisposeAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.valueTaskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass150.Struct289>(ref awaiter, ref this);
					return;
				}
				IL_15C:
				awaiter.GetResult();
				IL_163:
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

		// Token: 0x06001D70 RID: 7536 RVA: 0x000137F3 File Offset: 0x000119F3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001389 RID: 5001
		public int int_0;

		// Token: 0x0400138A RID: 5002
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400138B RID: 5003
		public GClass150 gclass150_0;

		// Token: 0x0400138C RID: 5004
		public GClass78 gclass78_0;

		// Token: 0x0400138D RID: 5005
		public Action<int, GClass36> action_0;

		// Token: 0x0400138E RID: 5006
		private int int_1;

		// Token: 0x0400138F RID: 5007
		private IAsyncEnumerator<GClass36> iasyncEnumerator_0;

		// Token: 0x04001390 RID: 5008
		private object object_0;

		// Token: 0x04001391 RID: 5009
		private int int_2;

		// Token: 0x04001392 RID: 5010
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x04001393 RID: 5011
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x0200046A RID: 1130
	[StructLayout(LayoutKind.Auto)]
	private struct Struct290 : IAsyncStateMachine
	{
		// Token: 0x06001D71 RID: 7537 RVA: 0x0007A4E8 File Offset: 0x000786E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass150 gclass = this.gclass150_0;
			GClass36 result;
			try
			{
				TaskAwaiter<GClass36> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass36>(null, this.gclass78_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass36>, GClass150.Struct290>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass36>);
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

		// Token: 0x06001D72 RID: 7538 RVA: 0x00013801 File Offset: 0x00011A01
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001394 RID: 5012
		public int int_0;

		// Token: 0x04001395 RID: 5013
		public AsyncTaskMethodBuilder<GClass36> asyncTaskMethodBuilder_0;

		// Token: 0x04001396 RID: 5014
		public GClass150 gclass150_0;

		// Token: 0x04001397 RID: 5015
		public GClass78 gclass78_0;

		// Token: 0x04001398 RID: 5016
		private TaskAwaiter<GClass36> taskAwaiter_0;
	}

	// Token: 0x0200046B RID: 1131
	[Serializable]
	private sealed class Class542
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x0001381B File Offset: 0x00011A1B
		internal GClass258 method_0(string string_0)
		{
			return new GClass258(GClass54.smethod_2(), string_0);
		}

		// Token: 0x04001399 RID: 5017
		public static readonly GClass150.Class542 class542_0 = new GClass150.Class542();

		// Token: 0x0400139A RID: 5018
		public static Func<string, GClass258> func_0;
	}
}
