using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200038B RID: 907
public sealed class GClass145 : GClass143, GInterface1
{
	// Token: 0x060017A1 RID: 6049 RVA: 0x000102FD File Offset: 0x0000E4FD
	internal GClass145(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x00010321 File Offset: 0x0000E521
	[CompilerGenerated]
	public GClass142 imethod_0()
	{
		return this.gclass142_0;
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x00010329 File Offset: 0x0000E529
	[CompilerGenerated]
	public void imethod_1(GClass142 gclass142_1)
	{
		this.gclass142_0 = gclass142_1;
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00010332 File Offset: 0x0000E532
	protected override string vmethod_0()
	{
		return "completions";
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x0006B890 File Offset: 0x00069A90
	public Task<GClass35> imethod_2(GClass142 gclass142_1)
	{
		GClass145.Struct205 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass35>.Create();
		@struct.gclass145_0 = this;
		@struct.gclass142_0 = gclass142_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass145.Struct205>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x0001033A File Offset: 0x0000E53A
	public Task<GClass35> imethod_5(GClass142 gclass142_1, int int_0 = 5)
	{
		gclass142_1.Nullable_5 = new int?(int_0);
		return this.imethod_2(gclass142_1);
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x0006B8DC File Offset: 0x00069ADC
	public Task<GClass35> imethod_3(string string_0, GClass27 gclass27_0 = null, int? nullable_0 = null, double? nullable_1 = null, double? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, int? nullable_6 = null, bool? nullable_7 = null, params string[] string_1)
	{
		GClass142 gclass = new GClass142(this.imethod_0());
		gclass.String_2 = string_0;
		gclass.String_0 = (gclass27_0 ?? this.imethod_0().String_0);
		int? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		double? num2 = nullable_1;
		gclass.Nullable_1 = ((num2 != null) ? num2 : this.imethod_0().Nullable_1);
		num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		num = nullable_3;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		num2 = nullable_4;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num2 = nullable_5;
		gclass.Nullable_4 = ((num2 != null) ? num2 : this.imethod_0().Nullable_4);
		num = nullable_6;
		gclass.Nullable_6 = ((num != null) ? num : this.imethod_0().Nullable_6);
		bool? flag = nullable_7;
		gclass.Nullable_7 = ((flag != null) ? flag : this.imethod_0().Nullable_7);
		gclass.String_4 = (string_1 ?? this.imethod_0().String_4);
		GClass142 gclass142_ = gclass;
		return this.imethod_2(gclass142_);
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x0006BA3C File Offset: 0x00069C3C
	public Task<GClass35> imethod_4(params string[] string_0)
	{
		GClass142 gclass142_ = new GClass142(this.imethod_0())
		{
			String_1 = string_0
		};
		return this.imethod_2(gclass142_);
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x0006BA64 File Offset: 0x00069C64
	public Task imethod_6(GClass142 gclass142_1, Action<int, GClass35> action_0)
	{
		GClass145.Struct206 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass145_0 = this;
		@struct.gclass142_0 = gclass142_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass145.Struct206>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x0006BAB8 File Offset: 0x00069CB8
	public Task imethod_7(GClass142 gclass142_1, Action<GClass35> action_0)
	{
		GClass145.Struct208 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass145_0 = this;
		@struct.gclass142_0 = gclass142_1;
		@struct.action_0 = action_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass145.Struct208>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x0001034F File Offset: 0x0000E54F
	public IAsyncEnumerable<GClass35> imethod_8(GClass142 gclass142_1)
	{
		gclass142_1 = new GClass142(gclass142_1)
		{
			Boolean_0 = true
		};
		return base.method_11<GClass35>(base.method_0(), HttpMethod.Post, gclass142_1);
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x0006BB0C File Offset: 0x00069D0C
	public IAsyncEnumerable<GClass35> imethod_9(string string_0, GClass27 gclass27_0 = null, int? nullable_0 = null, double? nullable_1 = null, double? nullable_2 = null, int? nullable_3 = null, double? nullable_4 = null, double? nullable_5 = null, int? nullable_6 = null, bool? nullable_7 = null, params string[] string_1)
	{
		GClass142 gclass = new GClass142(this.imethod_0());
		gclass.String_2 = string_0;
		gclass.String_0 = (gclass27_0 ?? this.imethod_0().String_0);
		int? num = nullable_0;
		gclass.Nullable_0 = ((num != null) ? num : this.imethod_0().Nullable_0);
		double? num2 = nullable_1;
		gclass.Nullable_1 = ((num2 != null) ? num2 : this.imethod_0().Nullable_1);
		num2 = nullable_2;
		gclass.Nullable_2 = ((num2 != null) ? num2 : this.imethod_0().Nullable_2);
		num = nullable_3;
		gclass.Nullable_5 = ((num != null) ? num : this.imethod_0().Nullable_5);
		num2 = nullable_4;
		gclass.Nullable_3 = ((num2 != null) ? num2 : this.imethod_0().Nullable_3);
		num2 = nullable_5;
		gclass.Nullable_4 = ((num2 != null) ? num2 : this.imethod_0().Nullable_4);
		num = nullable_6;
		gclass.Nullable_6 = ((num != null) ? num : this.imethod_0().Nullable_6);
		bool? flag = nullable_7;
		gclass.Nullable_7 = ((flag != null) ? flag : this.imethod_0().Nullable_7);
		gclass.String_4 = (string_1 ?? this.imethod_0().String_4);
		gclass.Boolean_0 = true;
		GClass142 gclass142_ = gclass;
		return this.imethod_8(gclass142_);
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x0006BC70 File Offset: 0x00069E70
	public Task<string> imethod_10(GClass142 gclass142_1)
	{
		GClass145.Struct207 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass145_0 = this;
		@struct.gclass142_0 = gclass142_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass145.Struct207>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x0006BCBC File Offset: 0x00069EBC
	public Task<string> imethod_11(string string_0)
	{
		GClass145.Struct204 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass145_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass145.Struct204>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000F8F RID: 3983
	private GClass142 gclass142_0 = new GClass142
	{
		String_0 = GClass27.smethod_0()
	};

	// Token: 0x0200038C RID: 908
	[StructLayout(LayoutKind.Auto)]
	private struct Struct204 : IAsyncStateMachine
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x0006BD08 File Offset: 0x00069F08
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass145 gclass = this.gclass145_0;
			string result;
			try
			{
				TaskAwaiter<GClass35> awaiter;
				if (num != 0)
				{
					GClass142 gclass142_ = new GClass142(gclass.imethod_0())
					{
						String_2 = this.string_0,
						Nullable_5 = new int?(1)
					};
					awaiter = gclass.imethod_2(gclass142_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass35>, GClass145.Struct204>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass35>);
					this.int_0 = -1;
				}
				result = awaiter.GetResult().ToString();
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

		// Token: 0x060017B0 RID: 6064 RVA: 0x00010374 File Offset: 0x0000E574
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F90 RID: 3984
		public int int_0;

		// Token: 0x04000F91 RID: 3985
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000F92 RID: 3986
		public GClass145 gclass145_0;

		// Token: 0x04000F93 RID: 3987
		public string string_0;

		// Token: 0x04000F94 RID: 3988
		private TaskAwaiter<GClass35> taskAwaiter_0;
	}

	// Token: 0x0200038D RID: 909
	[StructLayout(LayoutKind.Auto)]
	private struct Struct205 : IAsyncStateMachine
	{
		// Token: 0x060017B1 RID: 6065 RVA: 0x0006BDEC File Offset: 0x00069FEC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass145 gclass = this.gclass145_0;
			GClass35 result;
			try
			{
				TaskAwaiter<GClass35> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_8<GClass35>(null, this.gclass142_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass35>, GClass145.Struct205>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass35>);
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

		// Token: 0x060017B2 RID: 6066 RVA: 0x00010382 File Offset: 0x0000E582
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F95 RID: 3989
		public int int_0;

		// Token: 0x04000F96 RID: 3990
		public AsyncTaskMethodBuilder<GClass35> asyncTaskMethodBuilder_0;

		// Token: 0x04000F97 RID: 3991
		public GClass145 gclass145_0;

		// Token: 0x04000F98 RID: 3992
		public GClass142 gclass142_0;

		// Token: 0x04000F99 RID: 3993
		private TaskAwaiter<GClass35> taskAwaiter_0;
	}

	// Token: 0x0200038E RID: 910
	[StructLayout(LayoutKind.Auto)]
	private struct Struct206 : IAsyncStateMachine
	{
		// Token: 0x060017B3 RID: 6067 RVA: 0x0006BEAC File Offset: 0x0006A0AC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass145 gclass = this.gclass145_0;
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
					this.iasyncEnumerator_0 = gclass.imethod_8(this.gclass142_0).GetAsyncEnumerator(default(CancellationToken));
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
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass145.Struct206>(ref awaiter2, ref this);
						return;
					}
					IL_DC:
					if (awaiter2.GetResult())
					{
						GClass35 arg = this.iasyncEnumerator_0.Current;
						Action<int, GClass35> action = this.action_0;
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
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass145.Struct206>(ref awaiter, ref this);
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

		// Token: 0x060017B4 RID: 6068 RVA: 0x00010390 File Offset: 0x0000E590
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F9A RID: 3994
		public int int_0;

		// Token: 0x04000F9B RID: 3995
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000F9C RID: 3996
		public GClass145 gclass145_0;

		// Token: 0x04000F9D RID: 3997
		public GClass142 gclass142_0;

		// Token: 0x04000F9E RID: 3998
		public Action<int, GClass35> action_0;

		// Token: 0x04000F9F RID: 3999
		private int int_1;

		// Token: 0x04000FA0 RID: 4000
		private IAsyncEnumerator<GClass35> iasyncEnumerator_0;

		// Token: 0x04000FA1 RID: 4001
		private object object_0;

		// Token: 0x04000FA2 RID: 4002
		private int int_2;

		// Token: 0x04000FA3 RID: 4003
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x04000FA4 RID: 4004
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}

	// Token: 0x0200038F RID: 911
	[StructLayout(LayoutKind.Auto)]
	private struct Struct207 : IAsyncStateMachine
	{
		// Token: 0x060017B5 RID: 6069 RVA: 0x0006C0AC File Offset: 0x0006A2AC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass145 gclass = this.gclass145_0;
			string result2;
			try
			{
				TaskAwaiter<GClass35> awaiter;
				if (num != 0)
				{
					this.string_0 = this.gclass142_0.String_2;
					awaiter = gclass.imethod_2(this.gclass142_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass35>, GClass145.Struct207>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass35>);
					this.int_0 = -1;
				}
				GClass35 result = awaiter.GetResult();
				result2 = this.string_0 + result.ToString();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.string_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.string_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0001039E File Offset: 0x0000E59E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000FA5 RID: 4005
		public int int_0;

		// Token: 0x04000FA6 RID: 4006
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000FA7 RID: 4007
		public GClass142 gclass142_0;

		// Token: 0x04000FA8 RID: 4008
		public GClass145 gclass145_0;

		// Token: 0x04000FA9 RID: 4009
		private string string_0;

		// Token: 0x04000FAA RID: 4010
		private TaskAwaiter<GClass35> taskAwaiter_0;
	}

	// Token: 0x02000390 RID: 912
	[StructLayout(LayoutKind.Auto)]
	private struct Struct208 : IAsyncStateMachine
	{
		// Token: 0x060017B7 RID: 6071 RVA: 0x0006C19C File Offset: 0x0006A39C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass145 gclass = this.gclass145_0;
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
					this.iasyncEnumerator_0 = gclass.imethod_8(this.gclass142_0).GetAsyncEnumerator(default(CancellationToken));
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
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter<bool>, GClass145.Struct208>(ref awaiter2, ref this);
						return;
					}
					IL_C3:
					if (awaiter2.GetResult())
					{
						GClass35 obj = this.iasyncEnumerator_0.Current;
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
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ValueTaskAwaiter, GClass145.Struct208>(ref awaiter, ref this);
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

		// Token: 0x060017B8 RID: 6072 RVA: 0x000103AC File Offset: 0x0000E5AC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000FAB RID: 4011
		public int int_0;

		// Token: 0x04000FAC RID: 4012
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000FAD RID: 4013
		public GClass145 gclass145_0;

		// Token: 0x04000FAE RID: 4014
		public GClass142 gclass142_0;

		// Token: 0x04000FAF RID: 4015
		public Action<GClass35> action_0;

		// Token: 0x04000FB0 RID: 4016
		private IAsyncEnumerator<GClass35> iasyncEnumerator_0;

		// Token: 0x04000FB1 RID: 4017
		private object object_0;

		// Token: 0x04000FB2 RID: 4018
		private int int_1;

		// Token: 0x04000FB3 RID: 4019
		private ValueTaskAwaiter<bool> valueTaskAwaiter_0;

		// Token: 0x04000FB4 RID: 4020
		private ValueTaskAwaiter valueTaskAwaiter_1;
	}
}
