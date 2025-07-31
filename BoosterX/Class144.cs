using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ns0;

// Token: 0x020000DC RID: 220
internal sealed class Class144
{
	// Token: 0x060006C1 RID: 1729 RVA: 0x0003B4C0 File Offset: 0x000396C0
	public static Task smethod_0()
	{
		Class144.Struct25 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class144.Struct25>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x0003B4FC File Offset: 0x000396FC
	public static Task smethod_1()
	{
		Class144.Struct20 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class144.Struct20>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x0003B538 File Offset: 0x00039738
	public static Task smethod_2()
	{
		Class144.Struct23 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class144.Struct23>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x0003B574 File Offset: 0x00039774
	public static Task smethod_3()
	{
		Class144.Struct24 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class144.Struct24>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x0003B5B0 File Offset: 0x000397B0
	public static Task smethod_4()
	{
		Class144.Struct21 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class144.Struct21>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0003B5EC File Offset: 0x000397EC
	public static Task smethod_5()
	{
		Class144.Struct22 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class144.Struct22>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000391 RID: 913
	public static bool bool_0;

	// Token: 0x04000392 RID: 914
	public static bool bool_1;

	// Token: 0x04000393 RID: 915
	public static Class543 class543_0;

	// Token: 0x020000DD RID: 221
	[StructLayout(LayoutKind.Auto)]
	private struct Struct20 : IAsyncStateMachine
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x0003B628 File Offset: 0x00039828
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_D9;
					}
					awaiter = Class144.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct20>(ref awaiter, ref this);
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
				awaiter = Task.Run(new Func<Task>(Class144.Class145.class145_0.method_1)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct20>(ref awaiter, ref this);
					return;
				}
				IL_D9:
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

		// Token: 0x060006C8 RID: 1736 RVA: 0x00006364 File Offset: 0x00004564
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000394 RID: 916
		public int int_0;

		// Token: 0x04000395 RID: 917
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000396 RID: 918
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000DE RID: 222
	[StructLayout(LayoutKind.Auto)]
	private struct Struct21 : IAsyncStateMachine
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x0003B754 File Offset: 0x00039954
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_D9;
					}
					awaiter = Class144.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct21>(ref awaiter, ref this);
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
				awaiter = Task.Run(new Func<Task>(Class144.Class145.class145_0.method_4)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct21>(ref awaiter, ref this);
					return;
				}
				IL_D9:
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

		// Token: 0x060006CA RID: 1738 RVA: 0x00006372 File Offset: 0x00004572
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000397 RID: 919
		public int int_0;

		// Token: 0x04000398 RID: 920
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000399 RID: 921
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000DF RID: 223
	[StructLayout(LayoutKind.Auto)]
	private struct Struct22 : IAsyncStateMachine
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x0003B880 File Offset: 0x00039A80
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class144.class543_0 == null)
					{
						goto IL_A5;
					}
					awaiter = Task.Run(new Func<Task>(Class144.Class145.class145_0.method_5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct22>(ref awaiter, ref this);
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
			IL_A5:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00006380 File Offset: 0x00004580
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400039A RID: 922
		public int int_0;

		// Token: 0x0400039B RID: 923
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400039C RID: 924
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000E0 RID: 224
	[StructLayout(LayoutKind.Auto)]
	private struct Struct23 : IAsyncStateMachine
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x0003B958 File Offset: 0x00039B58
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_D9;
					}
					awaiter = Class144.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct23>(ref awaiter, ref this);
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
				awaiter = Task.Run(new Func<Task>(Class144.Class145.class145_0.method_2)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct23>(ref awaiter, ref this);
					return;
				}
				IL_D9:
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

		// Token: 0x060006CE RID: 1742 RVA: 0x0000638E File Offset: 0x0000458E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400039D RID: 925
		public int int_0;

		// Token: 0x0400039E RID: 926
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400039F RID: 927
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000E1 RID: 225
	[StructLayout(LayoutKind.Auto)]
	private struct Struct24 : IAsyncStateMachine
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x0003BA84 File Offset: 0x00039C84
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_D9;
					}
					awaiter = Class144.smethod_0().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct24>(ref awaiter, ref this);
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
				awaiter = Task.Run(new Func<Task>(Class144.Class145.class145_0.method_3)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct24>(ref awaiter, ref this);
					return;
				}
				IL_D9:
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

		// Token: 0x060006D0 RID: 1744 RVA: 0x0000639C File Offset: 0x0000459C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003A0 RID: 928
		public int int_0;

		// Token: 0x040003A1 RID: 929
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040003A2 RID: 930
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000E2 RID: 226
	[StructLayout(LayoutKind.Auto)]
	private struct Struct25 : IAsyncStateMachine
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x0003BBB0 File Offset: 0x00039DB0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class144.Class145.class145_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Struct25>(ref awaiter, ref this);
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

		// Token: 0x060006D2 RID: 1746 RVA: 0x000063AA File Offset: 0x000045AA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040003A3 RID: 931
		public int int_0;

		// Token: 0x040003A4 RID: 932
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040003A5 RID: 933
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000E3 RID: 227
	[Serializable]
	private sealed class Class145
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x0003BC7C File Offset: 0x00039E7C
		internal Task method_0()
		{
			Class144.Class145.Struct30 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class144.Class145.Struct30>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0003BCB8 File Offset: 0x00039EB8
		internal Task method_1()
		{
			Class144.Class145.Struct27 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class144.Class145.Struct27>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0003BCF4 File Offset: 0x00039EF4
		internal Task method_2()
		{
			Class144.Class145.Struct29 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class144.Class145.Struct29>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0003BD30 File Offset: 0x00039F30
		internal Task method_3()
		{
			Class144.Class145.Struct31 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class144.Class145.Struct31>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0003BD6C File Offset: 0x00039F6C
		internal Task method_4()
		{
			Class144.Class145.Struct26 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class144.Class145.Struct26>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0003BDA8 File Offset: 0x00039FA8
		internal Task method_5()
		{
			Class144.Class145.Struct28 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class144.Class145.Struct28>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000063C4 File Offset: 0x000045C4
		internal bool method_6(Class512 class512_0)
		{
			return class512_0.method_21() == "GameBar";
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000063D7 File Offset: 0x000045D7
		internal bool method_7(Class512 class512_0)
		{
			return class512_0.method_21() == "setsfirewall";
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000063EA File Offset: 0x000045EA
		internal bool method_8(Class512 class512_0)
		{
			return class512_0.method_21() == "TaskXBOX";
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000063D7 File Offset: 0x000045D7
		internal bool method_9(Class512 class512_0)
		{
			return class512_0.method_21() == "setsfirewall";
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000063EA File Offset: 0x000045EA
		internal bool method_10(Class512 class512_0)
		{
			return class512_0.method_21() == "TaskXBOX";
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000063FD File Offset: 0x000045FD
		internal bool method_11(Class512 class512_0)
		{
			return class512_0.method_21() == "ReduceVisuals";
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000063FD File Offset: 0x000045FD
		internal bool method_12(Class512 class512_0)
		{
			return class512_0.method_21() == "ReduceVisuals";
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00006410 File Offset: 0x00004610
		internal bool method_13(Class512 class512_0)
		{
			return class512_0.method_21() == "PauseWindowsUpdates";
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00006423 File Offset: 0x00004623
		internal bool method_14(GClass188 gclass188_0)
		{
			return gclass188_0.Name == "Bluetooth";
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00006436 File Offset: 0x00004636
		internal bool method_15(GClass188 gclass188_0)
		{
			return gclass188_0.Name == "Print";
		}

		// Token: 0x040003A6 RID: 934
		public static readonly Class144.Class145 class145_0 = new Class144.Class145();

		// Token: 0x040003A7 RID: 935
		public static Func<Task> func_0;

		// Token: 0x040003A8 RID: 936
		public static Func<Task> func_1;

		// Token: 0x040003A9 RID: 937
		public static Func<Task> func_2;

		// Token: 0x040003AA RID: 938
		public static Func<Task> func_3;

		// Token: 0x040003AB RID: 939
		public static Func<Task> func_4;

		// Token: 0x040003AC RID: 940
		public static Func<Class512, bool> func_5;

		// Token: 0x040003AD RID: 941
		public static Func<Class512, bool> func_6;

		// Token: 0x040003AE RID: 942
		public static Func<Class512, bool> func_7;

		// Token: 0x040003AF RID: 943
		public static Func<Class512, bool> func_8;

		// Token: 0x040003B0 RID: 944
		public static Func<Class512, bool> func_9;

		// Token: 0x040003B1 RID: 945
		public static Func<Class512, bool> func_10;

		// Token: 0x040003B2 RID: 946
		public static Func<Class512, bool> func_11;

		// Token: 0x040003B3 RID: 947
		public static Func<Class512, bool> func_12;

		// Token: 0x040003B4 RID: 948
		public static Func<GClass188, bool> func_13;

		// Token: 0x040003B5 RID: 949
		public static Func<GClass188, bool> func_14;

		// Token: 0x040003B6 RID: 950
		public static Func<Task> func_15;

		// Token: 0x020000E4 RID: 228
		[StructLayout(LayoutKind.Auto)]
		private struct Struct26 : IAsyncStateMachine
		{
			// Token: 0x060006E5 RID: 1765 RVA: 0x0003BDE4 File Offset: 0x00039FE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						List<Task> list = new List<Task>
						{
							Class148.smethod_11(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd)),
							Class148.smethod_11(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd)),
							Class148.smethod_11(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd)),
							Class148.smethod_11(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd)),
							Class148.smethod_11(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd)),
							GClass134.smethod_3(),
							Class335.smethod_5(),
							Class313.smethod_2(),
							Class362.smethod_3(),
							Class646.smethod_4()
						};
						if (Class551.class753_0.method_72().GetValueOrDefault())
						{
							list.Add(Class589.smethod_5(null));
						}
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct26>(ref awaiter, ref this);
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
					if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18)
					{
						GClass182 gclass = Class221.smethod_0(false);
						int num2 = 0;
						while (gclass.bool_0 && num2++ <= 500)
						{
							Task.Delay(20).Wait();
						}
						gclass.OptimalClickCommand.Execute(null);
					}
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

			// Token: 0x060006E6 RID: 1766 RVA: 0x00006449 File Offset: 0x00004649
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040003B7 RID: 951
			public int int_0;

			// Token: 0x040003B8 RID: 952
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040003B9 RID: 953
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020000E5 RID: 229
		[StructLayout(LayoutKind.Auto)]
		private struct Struct27 : IAsyncStateMachine
		{
			// Token: 0x060006E7 RID: 1767 RVA: 0x0003BFAC File Offset: 0x0003A1AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.WhenAll(new List<Task>
						{
							Class148.smethod_12(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd)),
							Class148.smethod_12(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd)),
							Class148.smethod_12(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd)),
							Class148.smethod_12(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd)),
							Class148.smethod_12(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd)),
							Class242.smethod_3(),
							GClass134.smethod_2(),
							Class335.smethod_5(),
							Class313.smethod_2()
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct27>(ref awaiter, ref this);
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
					if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18)
					{
						GClass182 gclass = Class221.smethod_0(false);
						int num2 = 0;
						while (gclass.bool_0 && num2++ <= 500)
						{
							Task.Delay(20).Wait();
						}
						gclass.OptimalClickCommand.Execute(null);
					}
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

			// Token: 0x060006E8 RID: 1768 RVA: 0x00006457 File Offset: 0x00004657
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040003BA RID: 954
			public int int_0;

			// Token: 0x040003BB RID: 955
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040003BC RID: 956
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020000E6 RID: 230
		[StructLayout(LayoutKind.Auto)]
		private struct Struct28 : IAsyncStateMachine
		{
			// Token: 0x060006E9 RID: 1769 RVA: 0x0003C144 File Offset: 0x0003A344
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<ObservableCollection<Class512>> awaiter2;
						switch (num)
						{
						case 0:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							break;
						case 1:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_1BD;
						case 2:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_256;
						case 3:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_312;
						case 4:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_405;
						case 5:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_499;
						case 6:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_4F3;
						case 7:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_587;
						case 8:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_67C;
						case 9:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_6D0;
						case 10:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<ObservableCollection<Class512>>);
							this.int_0 = -1;
							goto IL_780;
						case 11:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_831;
						case 12:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_8FC;
						default:
							awaiter = Class144.smethod_0().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct28>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						awaiter = Task.WhenAll(new List<Task>
						{
							Class148.smethod_12(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd)),
							Class148.smethod_12(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd)),
							Class148.smethod_12(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd)),
							Class148.smethod_12(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd)),
							Class148.smethod_11(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd)),
							Class148.smethod_12(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd)),
							Class148.smethod_12(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd)),
							Class242.smethod_3(),
							GClass134.smethod_2(),
							Class335.smethod_5(),
							Class313.smethod_2(),
							Class646.smethod_4()
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct28>(ref awaiter, ref this);
							return;
						}
						IL_1BD:
						awaiter.GetResult();
						if (!dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18 || !Class144.class543_0.method_14("QNvidia2").IsChecked)
						{
							goto IL_29A;
						}
						this.gclass182_0 = Class221.smethod_0(false);
						this.int_1 = 0;
						IL_21B:
						if (this.gclass182_0.bool_0)
						{
							int num2 = this.int_1;
							this.int_1 = num2 + 1;
							if (num2 <= 500)
							{
								awaiter = Task.Delay(20).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto IL_256;
								}
								this.int_0 = 2;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct28>(ref awaiter, ref this);
								return;
							}
						}
						this.gclass182_0.OptimalClickCommand.Execute(null);
						this.gclass182_0 = null;
						goto IL_29A;
						IL_256:
						awaiter.GetResult();
						goto IL_21B;
						IL_29A:
						if (!Class144.class543_0.method_14("QGameBar").IsChecked)
						{
							goto IL_348;
						}
						awaiter2 = Class148.smethod_2(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 3;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
							return;
						}
						IL_312:
						Class512 @class = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_6));
						if (@class != null)
						{
							@class.method_34();
						}
						IL_348:
						if (Class144.class543_0.method_14("QXBOX").IsChecked)
						{
							awaiter2 = Class148.smethod_2(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd), false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = Class148.smethod_2(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd), false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 6;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
								return;
							}
							goto IL_4F3;
						}
						IL_405:
						Class512 class2 = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_7));
						if (class2 != null)
						{
							class2.method_34();
						}
						awaiter2 = Class148.smethod_2(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 5;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
							return;
						}
						IL_499:
						Class512 class3 = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_8));
						if (class3 == null)
						{
							goto IL_5BD;
						}
						class3.method_34();
						goto IL_5BD;
						IL_4F3:
						Class512 class4 = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_9));
						if (class4 != null)
						{
							class4.method_36();
						}
						awaiter2 = Class148.smethod_2(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 7;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
							return;
						}
						IL_587:
						Class512 class5 = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_10));
						if (class5 != null)
						{
							class5.method_36();
						}
						IL_5BD:
						if (Class144.class543_0.method_14("QVisuals2").IsChecked)
						{
							awaiter2 = Class148.smethod_2(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd), false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 8;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = Class148.smethod_2(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd), false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 9;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
								return;
							}
							goto IL_6D0;
						}
						IL_67C:
						Class512 class6 = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_11));
						if (class6 == null)
						{
							goto IL_706;
						}
						class6.method_34();
						goto IL_706;
						IL_6D0:
						Class512 class7 = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_12));
						if (class7 != null)
						{
							class7.method_36();
						}
						IL_706:
						if (Class144.class543_0.method_14("QUpdates2").IsChecked)
						{
							goto IL_7B6;
						}
						awaiter2 = Class148.smethod_2(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd), false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 10;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class144.Class145.Struct28>(ref awaiter2, ref this);
							return;
						}
						IL_780:
						Class512 class8 = awaiter2.GetResult().FirstOrDefault(new Func<Class512, bool>(Class144.Class145.class145_0.method_13));
						if (class8 != null)
						{
							class8.method_34();
						}
						IL_7B6:
						if (Class144.class543_0.method_14("QBluetooth").IsChecked)
						{
							goto IL_881;
						}
						this.gclass183_0 = GClass134.smethod_0(false);
						awaiter = GClass134.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 11;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct28>(ref awaiter, ref this);
							return;
						}
						IL_831:
						awaiter.GetResult();
						GClass188 gclass = this.gclass183_0.CustomDisableDevices.FirstOrDefault(new Func<GClass188, bool>(Class144.Class145.class145_0.method_14));
						if (gclass != null)
						{
							gclass.IsDisabled = new bool?(true);
						}
						this.gclass183_0 = null;
						IL_881:
						if (Class144.class543_0.method_14("QPrinter").IsChecked)
						{
							goto IL_94C;
						}
						this.gclass183_0 = GClass134.smethod_0(false);
						awaiter = GClass134.smethod_5().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 12;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct28>(ref awaiter, ref this);
							return;
						}
						IL_8FC:
						awaiter.GetResult();
						GClass188 gclass2 = this.gclass183_0.CustomDisableDevices.FirstOrDefault(new Func<GClass188, bool>(Class144.Class145.class145_0.method_15));
						if (gclass2 != null)
						{
							gclass2.IsDisabled = new bool?(true);
						}
						this.gclass183_0 = null;
						IL_94C:;
					}
					catch
					{
					}
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

			// Token: 0x060006EA RID: 1770 RVA: 0x00006465 File Offset: 0x00004665
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040003BD RID: 957
			public int int_0;

			// Token: 0x040003BE RID: 958
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040003BF RID: 959
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x040003C0 RID: 960
			private GClass182 gclass182_0;

			// Token: 0x040003C1 RID: 961
			private int int_1;

			// Token: 0x040003C2 RID: 962
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_1;

			// Token: 0x040003C3 RID: 963
			private GClass134.GClass183 gclass183_0;
		}

		// Token: 0x020000E7 RID: 231
		[StructLayout(LayoutKind.Auto)]
		private struct Struct29 : IAsyncStateMachine
		{
			// Token: 0x060006EB RID: 1771 RVA: 0x0003CB04 File Offset: 0x0003AD04
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						List<Task> list = new List<Task>
						{
							Class148.smethod_12(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd)),
							Class148.smethod_12(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd)),
							Class148.smethod_12(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd)),
							Class148.smethod_12(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd)),
							Class148.smethod_12(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd)),
							Class148.smethod_12(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd)),
							Class242.smethod_3(),
							GClass134.smethod_2(),
							Class335.smethod_5(),
							Class313.smethod_2()
						};
						if (Class551.class753_0.method_72().GetValueOrDefault())
						{
							list.Add(Class589.smethod_4());
						}
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct29>(ref awaiter, ref this);
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
					if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18)
					{
						GClass182 gclass = Class221.smethod_0(false);
						int num2 = 0;
						while (gclass.bool_0 && num2++ <= 500)
						{
							Task.Delay(20).Wait();
						}
						gclass.OptimalClickCommand.Execute(null);
					}
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

			// Token: 0x060006EC RID: 1772 RVA: 0x00006473 File Offset: 0x00004673
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040003C4 RID: 964
			public int int_0;

			// Token: 0x040003C5 RID: 965
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040003C6 RID: 966
			private TaskAwaiter taskAwaiter_0;
		}

		// Token: 0x020000E8 RID: 232
		[StructLayout(LayoutKind.Auto)]
		private struct Struct30 : IAsyncStateMachine
		{
			// Token: 0x060006ED RID: 1773 RVA: 0x0003CCD4 File Offset: 0x0003AED4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					if (num > 4)
					{
						if (Class144.bool_1)
						{
							goto IL_2D0;
						}
						Class144.bool_1 = true;
					}
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<bool> awaiter2;
						TaskAwaiter<Class534> awaiter3;
						switch (num)
						{
						case 0:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							break;
						case 1:
							awaiter2 = this.taskAwaiter_1;
							this.taskAwaiter_1 = default(TaskAwaiter<bool>);
							this.int_0 = -1;
							goto IL_E5;
						case 2:
							awaiter3 = this.taskAwaiter_2;
							this.taskAwaiter_2 = default(TaskAwaiter<Class534>);
							this.int_0 = -1;
							goto IL_186;
						case 3:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_1E1;
						case 4:
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
							goto IL_28B;
						default:
							awaiter = Class148.smethod_6().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct30>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						awaiter2 = Class148.smethod_10().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 1;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class144.Class145.Struct30>(ref awaiter2, ref this);
							return;
						}
						IL_E5:
						awaiter2.GetResult();
						GClass134.smethod_0(true);
						Class335.smethod_2(true);
						Class313.smethod_0(true);
						GClass28.smethod_0(true);
						Class589.smethod_1(true);
						Class362.smethod_0(true);
						Class646.smethod_1(true);
						if (Class242.class534_0 == null || Class277.bool_1)
						{
							goto IL_1E8;
						}
						awaiter3 = Class242.smethod_0(true).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_2 = awaiter3;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class534>, Class144.Class145.Struct30>(ref awaiter3, ref this);
							return;
						}
						IL_186:
						awaiter3.GetResult();
						awaiter = Class242.smethod_4().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 3;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct30>(ref awaiter, ref this);
							return;
						}
						IL_1E1:
						awaiter.GetResult();
						IL_1E8:
						awaiter = Task.WhenAll(new List<Task>(7)
						{
							GClass134.smethod_5(),
							Class335.smethod_6(),
							Class313.smethod_4(),
							Class589.smethod_7(),
							Class362.smethod_5(),
							Class646.smethod_6(),
							GClass28.smethod_1()
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct30>(ref awaiter, ref this);
							return;
						}
						IL_28B:
						awaiter.GetResult();
						if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18)
						{
							Class221.smethod_0(false).RefreshCommand.Execute(null);
						}
					}
					catch
					{
					}
					Class144.bool_1 = false;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_2D0:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x00006481 File Offset: 0x00004681
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040003C7 RID: 967
			public int int_0;

			// Token: 0x040003C8 RID: 968
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040003C9 RID: 969
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x040003CA RID: 970
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x040003CB RID: 971
			private TaskAwaiter<Class534> taskAwaiter_2;
		}

		// Token: 0x020000E9 RID: 233
		[StructLayout(LayoutKind.Auto)]
		private struct Struct31 : IAsyncStateMachine
		{
			// Token: 0x060006EF RID: 1775 RVA: 0x0003CFF8 File Offset: 0x0003B1F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						List<Task> list = new List<Task>
						{
							Class148.smethod_11(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd)),
							Class148.smethod_12(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd)),
							Class148.smethod_12(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd)),
							Class148.smethod_11(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd)),
							Class148.smethod_11(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd)),
							Class148.smethod_11(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd)),
							Class148.smethod_12(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd)),
							Class242.smethod_2(),
							GClass134.smethod_2(),
							Class335.smethod_5(),
							Class313.smethod_2(),
							Class362.smethod_3(),
							Class646.smethod_4()
						};
						if (Class551.class753_0.method_72().GetValueOrDefault())
						{
							list.Add(Class589.smethod_4());
						}
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class144.Class145.Struct31>(ref awaiter, ref this);
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
					if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_18)
					{
						GClass182 gclass = Class221.smethod_0(false);
						int num2 = 0;
						while (gclass.bool_0 && num2++ <= 500)
						{
							Task.Delay(20).Wait();
						}
						gclass.OptimalClickCommand.Execute(null);
					}
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

			// Token: 0x060006F0 RID: 1776 RVA: 0x0000648F File Offset: 0x0000468F
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040003CC RID: 972
			public int int_0;

			// Token: 0x040003CD RID: 973
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040003CE RID: 974
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
