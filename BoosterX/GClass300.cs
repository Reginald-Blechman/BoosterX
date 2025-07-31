using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x020006F8 RID: 1784
public static class GClass300
{
	// Token: 0x06002CBF RID: 11455 RVA: 0x0001CD05 File Offset: 0x0001AF05
	public static bool smethod_0()
	{
		return GClass300.bool_0;
	}

	// Token: 0x06002CC0 RID: 11456 RVA: 0x0001CD0C File Offset: 0x0001AF0C
	private static void smethod_1(bool bool_1)
	{
		GClass300.bool_0 = bool_1;
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x000AA9E4 File Offset: 0x000A8BE4
	public static Task<GStruct1> smethod_2()
	{
		GClass300.Struct485 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GStruct1>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct485>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC2 RID: 11458 RVA: 0x000AAA20 File Offset: 0x000A8C20
	public static Task<GStruct1> smethod_3(CancellationToken cancellationToken_0)
	{
		GClass300.Struct483 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GStruct1>.Create();
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct483>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC3 RID: 11459 RVA: 0x000AAA64 File Offset: 0x000A8C64
	public static Task<GStruct1> smethod_4(CancellationToken cancellationToken_0, bool bool_1)
	{
		GClass300.Struct486 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GStruct1>.Create();
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.bool_0 = bool_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct486>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC4 RID: 11460 RVA: 0x000AAAB0 File Offset: 0x000A8CB0
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_5(this GClass32 gclass32_0)
	{
		GClass300.Struct484 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass32_0 = gclass32_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct484>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x000AAAF4 File Offset: 0x000A8CF4
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_6(this GClass32 gclass32_0, GEnum11 genum11_0)
	{
		GClass300.Struct480 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass32_0 = gclass32_0;
		@struct.genum11_0 = genum11_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct480>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC6 RID: 11462 RVA: 0x000AAB40 File Offset: 0x000A8D40
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_7(this GClass32 gclass32_0, GEnum11 genum11_0, bool bool_1)
	{
		GClass300.Struct487 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass32_0 = gclass32_0;
		@struct.genum11_0 = genum11_0;
		@struct.bool_0 = bool_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct487>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x000AAB94 File Offset: 0x000A8D94
	public static Task<ValueTuple<List<GStruct0>, Dictionary<string, string>>> smethod_8(this GClass32 gclass32_0, GEnum11 genum11_0, bool bool_1, CancellationToken cancellationToken_0)
	{
		GClass300.Struct479 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>>.Create();
		@struct.gclass32_0 = gclass32_0;
		@struct.genum11_0 = genum11_0;
		@struct.bool_0 = bool_1;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct479>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x000AABF0 File Offset: 0x000A8DF0
	public static Task smethod_9()
	{
		GClass300.Struct477 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct477>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CC9 RID: 11465 RVA: 0x000AAC2C File Offset: 0x000A8E2C
	public static Task smethod_10(CancellationToken cancellationToken_0)
	{
		GClass300.Struct478 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct478>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CCA RID: 11466 RVA: 0x0001CD14 File Offset: 0x0001AF14
	public static void smethod_11()
	{
		GClass300.smethod_12(false);
	}

	// Token: 0x06002CCB RID: 11467 RVA: 0x0001CD1C File Offset: 0x0001AF1C
	public static void smethod_12(bool bool_1)
	{
		GClass300.gclass50_0.method_0(bool_1);
	}

	// Token: 0x06002CCC RID: 11468 RVA: 0x000AAC70 File Offset: 0x000A8E70
	public static Task smethod_13(this GClass32 gclass32_0, IEnumerable<GClass208> ienumerable_0, CancellationToken cancellationToken_0)
	{
		GClass300.Struct476 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass32_0 = gclass32_0;
		@struct.ienumerable_0 = ienumerable_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct476>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CCD RID: 11469 RVA: 0x000AACC4 File Offset: 0x000A8EC4
	public static void smethod_14()
	{
		GClass300.smethod_15(default(CancellationToken));
	}

	// Token: 0x06002CCE RID: 11470 RVA: 0x0001CD29 File Offset: 0x0001AF29
	public static void smethod_15(CancellationToken cancellationToken_0)
	{
		GClass265.smethod_1();
		GClass300.smethod_1(false);
	}

	// Token: 0x06002CCF RID: 11471 RVA: 0x0001CD36 File Offset: 0x0001AF36
	public static void smethod_16(this GClass32 gclass32_0, string string_0)
	{
		gclass32_0.smethod_17(string_0, true);
	}

	// Token: 0x06002CD0 RID: 11472 RVA: 0x0001CD40 File Offset: 0x0001AF40
	public static void smethod_17(this GClass32 gclass32_0, string string_0, bool bool_1)
	{
		GClass300.gclass122_0.method_22(new GClass32[]
		{
			gclass32_0
		}, string_0, bool_1);
	}

	// Token: 0x06002CD1 RID: 11473 RVA: 0x0001CD58 File Offset: 0x0001AF58
	public static void smethod_18(this IEnumerable<GClass32> ienumerable_0, string string_0)
	{
		ienumerable_0.smethod_19(string_0, true);
	}

	// Token: 0x06002CD2 RID: 11474 RVA: 0x0001CD62 File Offset: 0x0001AF62
	public static void smethod_19(this IEnumerable<GClass32> ienumerable_0, string string_0, bool bool_1)
	{
		GClass300.gclass122_0.method_22(ienumerable_0, string_0, bool_1);
	}

	// Token: 0x06002CD3 RID: 11475 RVA: 0x0001CD71 File Offset: 0x0001AF71
	public static byte[] smethod_20(this IEnumerable<GClass32> ienumerable_0, bool bool_1)
	{
		return GClass300.gclass122_0.method_23(ienumerable_0, bool_1);
	}

	// Token: 0x06002CD4 RID: 11476 RVA: 0x0001CD7F File Offset: 0x0001AF7F
	public static void smethod_21(string string_0)
	{
		GClass300.gclass122_0.method_20(string_0);
	}

	// Token: 0x06002CD5 RID: 11477 RVA: 0x0001CD8C File Offset: 0x0001AF8C
	public static void smethod_22(string string_0)
	{
		GClass300.gclass122_0.method_26(string_0);
	}

	// Token: 0x06002CD6 RID: 11478 RVA: 0x0001CD9A File Offset: 0x0001AF9A
	internal static dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd smethod_23(string string_0)
	{
		return GClass300.gclass122_0.method_25(string_0);
	}

	// Token: 0x06002CD7 RID: 11479 RVA: 0x0001CDA7 File Offset: 0x0001AFA7
	public static void smethod_24(string string_0)
	{
		GClass300.gclass122_0.method_21(string_0);
	}

	// Token: 0x06002CD8 RID: 11480 RVA: 0x000AACE0 File Offset: 0x000A8EE0
	public static Task<bool> smethod_25(this GClass32 gclass32_0)
	{
		GClass300.Struct481 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.gclass32_0 = gclass32_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct481>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CD9 RID: 11481 RVA: 0x000AAD24 File Offset: 0x000A8F24
	public static Task<bool> smethod_26()
	{
		GClass300.Struct482 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass300.Struct482>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002CDA RID: 11482 RVA: 0x0001CDB4 File Offset: 0x0001AFB4
	public static List<GClass32> smethod_27()
	{
		return GClass300.gclass121_0.list_1;
	}

	// Token: 0x06002CDB RID: 11483 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
	public static GEnum5 smethod_28(this GClass32 gclass32_0)
	{
		if (GClass300.gclass121_0.list_1.Contains(gclass32_0))
		{
			return (GEnum5)0;
		}
		if (GClass300.gclass121_0.hashSet_0.Contains(gclass32_0))
		{
			return (GEnum5)1;
		}
		return (GEnum5)2;
	}

	// Token: 0x04001D03 RID: 7427
	private static GClass123 gclass123_0 = GClass91.gclass123_0;

	// Token: 0x04001D04 RID: 7428
	private static GClass121 gclass121_0 = GClass91.gclass121_0;

	// Token: 0x04001D05 RID: 7429
	private static GClass50 gclass50_0 = GClass91.gclass50_0;

	// Token: 0x04001D06 RID: 7430
	private static GClass122 gclass122_0 = GClass91.gclass122_0;

	// Token: 0x04001D07 RID: 7431
	private static bool bool_0 = false;

	// Token: 0x020006F9 RID: 1785
	[StructLayout(LayoutKind.Auto)]
	private struct Struct476 : IAsyncStateMachine
	{
		// Token: 0x06002CDC RID: 11484 RVA: 0x000AAD60 File Offset: 0x000A8F60
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new GClass300.Class865
					{
						ienumerable_0 = this.ienumerable_0,
						gclass32_0 = this.gclass32_0
					}.method_0), this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct476>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x06002CDD RID: 11485 RVA: 0x0001CDEB File Offset: 0x0001AFEB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D08 RID: 7432
		public int int_0;

		// Token: 0x04001D09 RID: 7433
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001D0A RID: 7434
		public IEnumerable<GClass208> ienumerable_0;

		// Token: 0x04001D0B RID: 7435
		public GClass32 gclass32_0;

		// Token: 0x04001D0C RID: 7436
		public CancellationToken cancellationToken_0;

		// Token: 0x04001D0D RID: 7437
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006FA RID: 1786
	private sealed class Class863
	{
		// Token: 0x06002CDF RID: 11487 RVA: 0x000AAE38 File Offset: 0x000A9038
		internal void method_0()
		{
			IEnumerable<GClass208> source = GClass300.gclass123_0.method_36(this.gclass32_0.ProfileName, this.genum11_0, ref this.dictionary_0);
			Func<GClass208, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<GClass208, bool>(this.method_1));
			}
			foreach (GClass208 gclass in source.Where(predicate))
			{
				GClass112 gclass2 = GClass300.gclass50_0.method_16(gclass.method_0(), this.genum11_0);
				if (gclass2 == null || gclass2.Values.Count<GInterface11>() >= 1)
				{
					List<GStruct0> list = this.list_0;
					GStruct0 item = default(GStruct0);
					item.SettingItem = gclass;
					item.method_1(gclass2);
					list.Add(item);
				}
			}
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x0001CDF9 File Offset: 0x0001AFF9
		internal bool method_1(GClass208 gclass208_0)
		{
			return gclass208_0.method_16() == this.bool_0;
		}

		// Token: 0x04001D0E RID: 7438
		public GClass32 gclass32_0;

		// Token: 0x04001D0F RID: 7439
		public GEnum11 genum11_0;

		// Token: 0x04001D10 RID: 7440
		public Dictionary<string, string> dictionary_0;

		// Token: 0x04001D11 RID: 7441
		public bool bool_0;

		// Token: 0x04001D12 RID: 7442
		public List<GStruct0> list_0;

		// Token: 0x04001D13 RID: 7443
		public Func<GClass208, bool> func_0;
	}

	// Token: 0x020006FB RID: 1787
	[StructLayout(LayoutKind.Auto)]
	private struct Struct477 : IAsyncStateMachine
	{
		// Token: 0x06002CE1 RID: 11489 RVA: 0x000AAF0C File Offset: 0x000A910C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = GClass300.smethod_10(default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct477>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0001CE09 File Offset: 0x0001B009
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D14 RID: 7444
		public int int_0;

		// Token: 0x04001D15 RID: 7445
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001D16 RID: 7446
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006FC RID: 1788
	[StructLayout(LayoutKind.Auto)]
	private struct Struct478 : IAsyncStateMachine
	{
		// Token: 0x06002CE3 RID: 11491 RVA: 0x000AAFC0 File Offset: 0x000A91C0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num != 1)
					{
						if (!GClass300.smethod_0())
						{
							awaiter = GClass300.gclass121_0.method_22(false, null, this.cancellationToken_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct478>(ref awaiter, ref this);
								return;
							}
							goto IL_E4;
						}
						else
						{
							awaiter = GClass300.gclass121_0.method_22(true, null, this.cancellationToken_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct478>(ref awaiter, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
					}
					awaiter.GetResult();
					goto IL_F6;
				}
				awaiter = this.taskAwaiter_0;
				this.taskAwaiter_0 = default(TaskAwaiter);
				this.int_0 = -1;
				IL_E4:
				awaiter.GetResult();
				GClass300.smethod_11();
				GClass300.smethod_1(true);
				IL_F6:;
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

		// Token: 0x06002CE4 RID: 11492 RVA: 0x0001CE17 File Offset: 0x0001B017
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D17 RID: 7447
		public int int_0;

		// Token: 0x04001D18 RID: 7448
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001D19 RID: 7449
		public CancellationToken cancellationToken_0;

		// Token: 0x04001D1A RID: 7450
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006FD RID: 1789
	private sealed class Class864
	{
		// Token: 0x06002CE6 RID: 11494 RVA: 0x0001CE25 File Offset: 0x0001B025
		internal void method_0()
		{
			GClass300.gclass123_0.method_29(this.gclass32_0.ProfileName, out this.bool_0);
		}

		// Token: 0x04001D1B RID: 7451
		public GClass32 gclass32_0;

		// Token: 0x04001D1C RID: 7452
		public bool bool_0;
	}

	// Token: 0x020006FE RID: 1790
	[StructLayout(LayoutKind.Auto)]
	private struct Struct479 : IAsyncStateMachine
	{
		// Token: 0x06002CE7 RID: 11495 RVA: 0x000AB100 File Offset: 0x000A9300
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class863_0 = new GClass300.Class863();
					this.class863_0.gclass32_0 = this.gclass32_0;
					this.class863_0.genum11_0 = this.genum11_0;
					this.class863_0.bool_0 = this.bool_0;
					if (this.class863_0.genum11_0 == (GEnum11)1 && !GClass300.smethod_0())
					{
						throw new InvalidOperationException("ProfilesScanned");
					}
					this.class863_0.list_0 = new List<GStruct0>();
					this.class863_0.dictionary_0 = new Dictionary<string, string>();
					awaiter = Task.Run(new Action(this.class863_0.method_0), this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct479>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				result = new ValueTuple<List<GStruct0>, Dictionary<string, string>>(this.class863_0.list_0, this.class863_0.dictionary_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class863_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class863_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x0001CE42 File Offset: 0x0001B042
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D1D RID: 7453
		public int int_0;

		// Token: 0x04001D1E RID: 7454
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04001D1F RID: 7455
		public GClass32 gclass32_0;

		// Token: 0x04001D20 RID: 7456
		public GEnum11 genum11_0;

		// Token: 0x04001D21 RID: 7457
		public bool bool_0;

		// Token: 0x04001D22 RID: 7458
		public CancellationToken cancellationToken_0;

		// Token: 0x04001D23 RID: 7459
		private GClass300.Class863 class863_0;

		// Token: 0x04001D24 RID: 7460
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006FF RID: 1791
	[StructLayout(LayoutKind.Auto)]
	private struct Struct480 : IAsyncStateMachine
	{
		// Token: 0x06002CE9 RID: 11497 RVA: 0x000AB27C File Offset: 0x000A947C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass32_0.smethod_8(this.genum11_0, false, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass300.Struct480>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
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

		// Token: 0x06002CEA RID: 11498 RVA: 0x0001CE50 File Offset: 0x0001B050
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D25 RID: 7461
		public int int_0;

		// Token: 0x04001D26 RID: 7462
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04001D27 RID: 7463
		public GClass32 gclass32_0;

		// Token: 0x04001D28 RID: 7464
		public GEnum11 genum11_0;

		// Token: 0x04001D29 RID: 7465
		private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
	}

	// Token: 0x02000700 RID: 1792
	[StructLayout(LayoutKind.Auto)]
	private struct Struct481 : IAsyncStateMachine
	{
		// Token: 0x06002CEB RID: 11499 RVA: 0x000AB340 File Offset: 0x000A9540
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			bool bool_;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class864_0 = new GClass300.Class864();
					this.class864_0.gclass32_0 = this.gclass32_0;
					this.class864_0.bool_0 = false;
					awaiter = Task.Run(new Action(this.class864_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct481>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				bool_ = this.class864_0.bool_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class864_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class864_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(bool_);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0001CE5E File Offset: 0x0001B05E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D2A RID: 7466
		public int int_0;

		// Token: 0x04001D2B RID: 7467
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04001D2C RID: 7468
		public GClass32 gclass32_0;

		// Token: 0x04001D2D RID: 7469
		private GClass300.Class864 class864_0;

		// Token: 0x04001D2E RID: 7470
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000701 RID: 1793
	private sealed class Class865
	{
		// Token: 0x06002CEE RID: 11502 RVA: 0x0001CE6C File Offset: 0x0001B06C
		internal void method_0()
		{
			if (this.ienumerable_0.Count<GClass208>() > 0)
			{
				GClass300.gclass123_0.method_34(this.gclass32_0, this.ienumerable_0);
			}
		}

		// Token: 0x04001D2F RID: 7471
		public IEnumerable<GClass208> ienumerable_0;

		// Token: 0x04001D30 RID: 7472
		public GClass32 gclass32_0;
	}

	// Token: 0x02000702 RID: 1794
	[StructLayout(LayoutKind.Auto)]
	private struct Struct482 : IAsyncStateMachine
	{
		// Token: 0x06002CEF RID: 11503 RVA: 0x000AB440 File Offset: 0x000A9640
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			bool result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.bool_0 = false;
					awaiter = Task.Run(new Action(GClass300.Class867.class867_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct482>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				result = this.bool_0;
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

		// Token: 0x06002CF0 RID: 11504 RVA: 0x0001CE93 File Offset: 0x0001B093
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D31 RID: 7473
		public int int_0;

		// Token: 0x04001D32 RID: 7474
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04001D33 RID: 7475
		private bool bool_0;

		// Token: 0x04001D34 RID: 7476
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000703 RID: 1795
	[StructLayout(LayoutKind.Auto)]
	private struct Struct483 : IAsyncStateMachine
	{
		// Token: 0x06002CF1 RID: 11505 RVA: 0x000AB518 File Offset: 0x000A9718
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GStruct1 result;
			try
			{
				TaskAwaiter<GStruct1> awaiter;
				if (num != 0)
				{
					awaiter = GClass300.smethod_4(this.cancellationToken_0, false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GStruct1>, GClass300.Struct483>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GStruct1>);
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

		// Token: 0x06002CF2 RID: 11506 RVA: 0x0001CEA1 File Offset: 0x0001B0A1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D35 RID: 7477
		public int int_0;

		// Token: 0x04001D36 RID: 7478
		public AsyncTaskMethodBuilder<GStruct1> asyncTaskMethodBuilder_0;

		// Token: 0x04001D37 RID: 7479
		public CancellationToken cancellationToken_0;

		// Token: 0x04001D38 RID: 7480
		private TaskAwaiter<GStruct1> taskAwaiter_0;
	}

	// Token: 0x02000704 RID: 1796
	[StructLayout(LayoutKind.Auto)]
	private struct Struct484 : IAsyncStateMachine
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x000AB5CC File Offset: 0x000A97CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass32_0.smethod_8((GEnum11)0, false, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass300.Struct484>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
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

		// Token: 0x06002CF4 RID: 11508 RVA: 0x0001CEAF File Offset: 0x0001B0AF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D39 RID: 7481
		public int int_0;

		// Token: 0x04001D3A RID: 7482
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04001D3B RID: 7483
		public GClass32 gclass32_0;

		// Token: 0x04001D3C RID: 7484
		private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
	}

	// Token: 0x02000705 RID: 1797
	private sealed class Class866
	{
		// Token: 0x06002CF6 RID: 11510 RVA: 0x000AB68C File Offset: 0x000A988C
		internal void method_0()
		{
			this.list_0 = GClass300.gclass123_0.method_26(ref this.gclass32_0);
			if (this.bool_0)
			{
				this.list_0.Remove(this.gclass32_0);
				this.list_0.Sort();
				this.list_0.Insert(0, this.gclass32_0);
			}
		}

		// Token: 0x04001D3D RID: 7485
		public List<GClass32> list_0;

		// Token: 0x04001D3E RID: 7486
		public GClass32 gclass32_0;

		// Token: 0x04001D3F RID: 7487
		public bool bool_0;
	}

	// Token: 0x02000706 RID: 1798
	[StructLayout(LayoutKind.Auto)]
	private struct Struct485 : IAsyncStateMachine
	{
		// Token: 0x06002CF7 RID: 11511 RVA: 0x000AB6E8 File Offset: 0x000A98E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GStruct1 result;
			try
			{
				TaskAwaiter<GStruct1> awaiter;
				if (num != 0)
				{
					awaiter = GClass300.smethod_4(default(CancellationToken), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GStruct1>, GClass300.Struct485>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GStruct1>);
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

		// Token: 0x06002CF8 RID: 11512 RVA: 0x0001CEBD File Offset: 0x0001B0BD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D40 RID: 7488
		public int int_0;

		// Token: 0x04001D41 RID: 7489
		public AsyncTaskMethodBuilder<GStruct1> asyncTaskMethodBuilder_0;

		// Token: 0x04001D42 RID: 7490
		private TaskAwaiter<GStruct1> taskAwaiter_0;
	}

	// Token: 0x02000707 RID: 1799
	[StructLayout(LayoutKind.Auto)]
	private struct Struct486 : IAsyncStateMachine
	{
		// Token: 0x06002CF9 RID: 11513 RVA: 0x000AB7A0 File Offset: 0x000A99A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GStruct1 result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.class866_0 = new GClass300.Class866();
					this.class866_0.bool_0 = this.bool_0;
					this.class866_0.list_0 = null;
					this.class866_0.gclass32_0 = null;
					awaiter = Task.Run(new Action(this.class866_0.method_0), this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass300.Struct486>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				result = new GStruct1(this.class866_0.list_0, this.class866_0.gclass32_0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class866_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class866_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x0001CECB File Offset: 0x0001B0CB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D43 RID: 7491
		public int int_0;

		// Token: 0x04001D44 RID: 7492
		public AsyncTaskMethodBuilder<GStruct1> asyncTaskMethodBuilder_0;

		// Token: 0x04001D45 RID: 7493
		public bool bool_0;

		// Token: 0x04001D46 RID: 7494
		public CancellationToken cancellationToken_0;

		// Token: 0x04001D47 RID: 7495
		private GClass300.Class866 class866_0;

		// Token: 0x04001D48 RID: 7496
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000708 RID: 1800
	[StructLayout(LayoutKind.Auto)]
	private struct Struct487 : IAsyncStateMachine
	{
		// Token: 0x06002CFB RID: 11515 RVA: 0x000AB8C0 File Offset: 0x000A9AC0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			ValueTuple<List<GStruct0>, Dictionary<string, string>> result;
			try
			{
				TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
				if (num != 0)
				{
					awaiter = this.gclass32_0.smethod_8(this.genum11_0, this.bool_0, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass300.Struct487>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
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

		// Token: 0x06002CFC RID: 11516 RVA: 0x0001CED9 File Offset: 0x0001B0D9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001D49 RID: 7497
		public int int_0;

		// Token: 0x04001D4A RID: 7498
		public AsyncTaskMethodBuilder<ValueTuple<List<GStruct0>, Dictionary<string, string>>> asyncTaskMethodBuilder_0;

		// Token: 0x04001D4B RID: 7499
		public GClass32 gclass32_0;

		// Token: 0x04001D4C RID: 7500
		public GEnum11 genum11_0;

		// Token: 0x04001D4D RID: 7501
		public bool bool_0;

		// Token: 0x04001D4E RID: 7502
		private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
	}

	// Token: 0x02000709 RID: 1801
	[Serializable]
	private sealed class Class867
	{
		// Token: 0x06002CFF RID: 11519 RVA: 0x0001CEF3 File Offset: 0x0001B0F3
		internal void method_0()
		{
			GClass300.gclass123_0.method_28();
		}

		// Token: 0x04001D4F RID: 7503
		public static readonly GClass300.Class867 class867_0 = new GClass300.Class867();

		// Token: 0x04001D50 RID: 7504
		public static Action action_0;
	}
}
