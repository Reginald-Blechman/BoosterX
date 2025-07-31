using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ns0;

// Token: 0x020001A1 RID: 417
internal sealed class Class206
{
	// Token: 0x06000BDA RID: 3034 RVA: 0x0004A7E8 File Offset: 0x000489E8
	public static Task<GClass155> smethod_0()
	{
		Class206.Struct87 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass155>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class206.Struct87>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x0004A824 File Offset: 0x00048A24
	private static Task<int> smethod_1()
	{
		Class206.Struct89 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<int>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class206.Struct89>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x0004A860 File Offset: 0x00048A60
	private static Task<int> smethod_2()
	{
		Class206.Struct86 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<int>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class206.Struct86>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x0004A89C File Offset: 0x00048A9C
	private static Task<int> smethod_3()
	{
		Class206.Struct88 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<int>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class206.Struct88>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x0004A8D8 File Offset: 0x00048AD8
	private static string smethod_4(GClass57 gclass57_0, int int_0, double double_0)
	{
		if (gclass57_0 == null)
		{
			return Class298.smethod_2("CanNotBeCalculated");
		}
		if (double_0 >= 90.0)
		{
			return Class298.smethod_2("BoostFullyOptimized2");
		}
		if (int_0 <= 5)
		{
			return Class298.smethod_2("BoostProbVeryUnlikely2");
		}
		if (int_0 <= 15)
		{
			return Class298.smethod_2("BoostProbUnlikely2");
		}
		if (int_0 <= 30)
		{
			return Class298.smethod_2("BoostProbPossible2");
		}
		if (int_0 <= 50)
		{
			return Class298.smethod_2("BoostProbLikely2");
		}
		if (int_0 <= 80)
		{
			return Class298.smethod_2("BoostProbVeryLikely2");
		}
		return Class298.smethod_2("BoostProbAlmostCertain2");
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x0004A96C File Offset: 0x00048B6C
	private static int smethod_5(GClass57 gclass57_0, double double_0)
	{
		if (gclass57_0 == null)
		{
			return 0;
		}
		if (double_0 >= 0.0 && double_0 < 100.0 && gclass57_0.method_8() <= 0)
		{
			int num = gclass57_0.method_6();
			if (num == 0)
			{
				num = 1;
			}
			double num2;
			if (num < 1)
			{
				num2 = 0.05;
			}
			else if (num < 15)
			{
				num2 = 0.05 + (double)(num - 1) * 0.06785714285714285;
			}
			else
			{
				num2 = 1.0;
			}
			double num3;
			if (double_0 < 30.0)
			{
				num3 = 1.0;
			}
			else if (double_0 > 90.0)
			{
				num3 = 0.0;
			}
			else
			{
				num3 = (90.0 - double_0) / 60.0;
			}
			double num4 = num2 * num3 * 100.0;
			num4 = Math.Max(0.0, Math.Min(100.0, num4));
			return (int)num4;
		}
		return 0;
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x0004AA64 File Offset: 0x00048C64
	private static string smethod_6(GClass57 gclass57_0)
	{
		if (gclass57_0 == null)
		{
			return Class298.smethod_2("BoosterXCanNotCalculateBn");
		}
		int num = gclass57_0.method_6();
		int num2 = gclass57_0.method_8();
		gclass57_0.method_4();
		if (num == num2)
		{
			return Class298.smethod_2("BalancedBottleneckNoSignificantLean2");
		}
		if (num > 0)
		{
			if (num < 6)
			{
				return Class298.smethod_2("CpuSlightlyBottlenecked2");
			}
			if (num < 15)
			{
				return Class298.smethod_2("CpuModerateBottleneck2");
			}
			return Class298.smethod_2("CpuHighBottleneck2");
		}
		else
		{
			if (num2 <= 0)
			{
				return Class298.smethod_2("BoosterXCanNotCalculateBn");
			}
			if (num2 < 6)
			{
				return Class298.smethod_2("GpuSlightlyBottlenecked2");
			}
			if (num2 < 15)
			{
				return Class298.smethod_2("GpuModerateBottleneck2");
			}
			return Class298.smethod_2("GpuHighBottleneck2");
		}
	}

	// Token: 0x04000793 RID: 1939
	private static readonly IReadOnlyList<string> ireadOnlyList_0 = new string[]
	{
		"FontCache",
		"WpnService",
		"TrkWks",
		"RmSvc",
		"Spooler",
		"NcbService",
		"Beep",
		"tcpipreg",
		"Fax",
		"XboxNetApiSvc",
		"IKEEXT",
		"PolicyAgent",
		"lmhosts",
		"iphlpsvc",
		"WinHttpAutoProxySvc",
		"LanmanServer",
		"CDPSvc",
		"DPS",
		"WdiServiceHost",
		"MSDTC",
		"upnphost",
		"SSDPSRV",
		"wmiApSrv",
		"GpuEnergyDrv",
		"ShellHWDetection",
		"SharedAccess",
		"PcaSvc",
		"WPDBusEnum",
		"DusmSvc",
		"BFE",
		"mpssvc",
		"TokenBroker",
		"VSS",
		"Themes"
	};

	// Token: 0x020001A2 RID: 418
	private sealed class Class207
	{
		// Token: 0x06000BE2 RID: 3042 RVA: 0x0004AB14 File Offset: 0x00048D14
		internal void method_0(string string_0)
		{
			if (this.class490_0.Name.ToLower().Contains(string_0))
			{
				this.class208_0.int_0 = this.class208_0.int_0 + 2;
				if (this.class490_0.Status.GetValueOrDefault())
				{
					this.class208_0.int_1 = this.class208_0.int_1 + 2;
				}
			}
		}

		// Token: 0x04000794 RID: 1940
		public Class490 class490_0;

		// Token: 0x04000795 RID: 1941
		public Class206.Class208 class208_0;
	}

	// Token: 0x020001A3 RID: 419
	[StructLayout(LayoutKind.Auto)]
	private struct Struct86 : IAsyncStateMachine
	{
		// Token: 0x06000BE3 RID: 3043 RVA: 0x0004AB80 File Offset: 0x00048D80
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			int result;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<List<Class512>> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_18A;
					}
					this.class208_0 = new Class206.Class208();
					this.class208_0.int_0 = 0;
					this.class208_0.int_1 = 0;
					awaiter2 = Class148.smethod_8().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class512>>, Class206.Struct86>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class512>>);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
				}
				List<Class512>.Enumerator enumerator = awaiter2.GetResult().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 @class = enumerator.Current;
						if (@class.method_40() && !@class.method_19() && @class.method_20())
						{
							int int_ = this.class208_0.int_0;
							this.class208_0.int_0 = int_ + 1;
							if (@class.CurrentValueType == "BEST")
							{
								int_ = this.class208_0.int_1;
								this.class208_0.int_1 = int_ + 1;
							}
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				this.class652_0 = Class646.smethod_1(false);
				awaiter = Class646.smethod_6().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class206.Struct86>(ref awaiter, ref this);
					return;
				}
				IL_18A:
				awaiter.GetResult();
				IEnumerator<Class490> enumerator2 = this.class652_0.method_0().GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class206.Class207 class2 = new Class206.Class207();
						class2.class208_0 = this.class208_0;
						class2.class490_0 = enumerator2.Current;
						Class206.Class209 class3 = new Class206.Class209();
						class3.class207_0 = class2;
						class3.bool_0 = false;
						Class725.list_6.ForEach(new Action<string>(class3.method_0));
						if (!class3.bool_0)
						{
							Class725.list_5.ForEach(new Action<string>(class3.class207_0.method_0));
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				result = (int)Math.Round((double)this.class208_0.int_1 / (double)this.class208_0.int_0 * 100.0);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class208_0 = null;
				this.class652_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class208_0 = null;
			this.class652_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000934B File Offset: 0x0000754B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000796 RID: 1942
		public int int_0;

		// Token: 0x04000797 RID: 1943
		public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

		// Token: 0x04000798 RID: 1944
		private Class206.Class208 class208_0;

		// Token: 0x04000799 RID: 1945
		private Class646.Class652 class652_0;

		// Token: 0x0400079A RID: 1946
		private TaskAwaiter<List<Class512>> taskAwaiter_0;

		// Token: 0x0400079B RID: 1947
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020001A4 RID: 420
	[StructLayout(LayoutKind.Auto)]
	private struct Struct87 : IAsyncStateMachine
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x0004AE7C File Offset: 0x0004907C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass155 result2;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<int> awaiter2;
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
					goto IL_180;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<int>);
					this.int_0 = -1;
					goto IL_271;
				case 3:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<int>);
					this.int_0 = -1;
					goto IL_2EB;
				case 4:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<int>);
					this.int_0 = -1;
					goto IL_365;
				default:
				{
					this.gclass155_0 = new GClass155();
					GClass131 gclass = new GClass131();
					gclass.method_1(GClass2.smethod_0());
					gclass.method_3(GClass2.smethod_1());
					gclass.method_5(GClass2.smethod_2());
					this.gclass57_0 = Class445.smethod_0(gclass);
					if (this.gclass57_0 == null)
					{
						this.gclass155_0.method_9(true);
					}
					this.gclass155_0.method_1(this.gclass57_0.method_6());
					this.gclass155_0.method_3(this.gclass57_0.method_0());
					this.gclass155_0.method_5(this.gclass57_0.method_8());
					this.gclass155_0.method_7(this.gclass57_0.method_2());
					this.gclass155_0.method_11(this.gclass57_0.method_4());
					dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.smethod_18();
					awaiter = Task.Delay(20).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class206.Struct87>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				awaiter.GetResult();
				IL_160:
				if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_21)
				{
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class206.Struct87>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					double double_ = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.double_0;
					this.gclass155_0.OptimizationLevel = (int)double_;
					this.gclass155_0.method_13(Class206.smethod_6(this.gclass57_0));
					this.gclass155_0.method_15(Class206.smethod_5(this.gclass57_0, double_));
					this.gclass155_0.BoostEstimateComment = Class206.smethod_4(this.gclass57_0, this.gclass155_0.method_14(), double_);
					this.gclass155_1 = this.gclass155_0;
					awaiter2 = Class206.smethod_3().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, Class206.Struct87>(ref awaiter2, ref this);
						return;
					}
					goto IL_271;
				}
				IL_180:
				awaiter.GetResult();
				goto IL_160;
				IL_271:
				int result = awaiter2.GetResult();
				this.gclass155_1.PrivacyPercent = result;
				this.gclass155_1 = null;
				this.gclass155_1 = this.gclass155_0;
				awaiter2 = Class206.smethod_2().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, Class206.Struct87>(ref awaiter2, ref this);
					return;
				}
				IL_2EB:
				result = awaiter2.GetResult();
				this.gclass155_1.FutureProofPercent = result;
				this.gclass155_1 = null;
				this.gclass155_1 = this.gclass155_0;
				awaiter2 = Class206.smethod_1().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 4;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<int>, Class206.Struct87>(ref awaiter2, ref this);
					return;
				}
				IL_365:
				result = awaiter2.GetResult();
				this.gclass155_1.method_21(result);
				this.gclass155_1 = null;
				result2 = this.gclass155_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.gclass155_0 = null;
				this.gclass57_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.gclass155_0 = null;
			this.gclass57_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00009359 File Offset: 0x00007559
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400079C RID: 1948
		public int int_0;

		// Token: 0x0400079D RID: 1949
		public AsyncTaskMethodBuilder<GClass155> asyncTaskMethodBuilder_0;

		// Token: 0x0400079E RID: 1950
		private GClass155 gclass155_0;

		// Token: 0x0400079F RID: 1951
		private GClass57 gclass57_0;

		// Token: 0x040007A0 RID: 1952
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040007A1 RID: 1953
		private GClass155 gclass155_1;

		// Token: 0x040007A2 RID: 1954
		private TaskAwaiter<int> taskAwaiter_1;
	}

	// Token: 0x020001A5 RID: 421
	[StructLayout(LayoutKind.Auto)]
	private struct Struct88 : IAsyncStateMachine
	{
		// Token: 0x06000BE7 RID: 3047 RVA: 0x0004B27C File Offset: 0x0004947C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			int result2;
			try
			{
				TaskAwaiter<ObservableCollection<Class512>> awaiter;
				if (num != 0)
				{
					awaiter = Class148.smethod_2(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd), false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class206.Struct88>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				Collection<Class512> result = awaiter.GetResult();
				int num4 = 0;
				int num5 = 0;
				IEnumerator<Class512> enumerator = result.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class512 @class = enumerator.Current;
						if (!@class.method_19() && @class.method_20())
						{
							num4++;
							if (@class.CurrentValueType == "BEST")
							{
								num5++;
							}
						}
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (num4 == 0)
				{
					result2 = 0;
				}
				else
				{
					result2 = (int)Math.Round((double)num5 / (double)num4 * 100.0);
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00009367 File Offset: 0x00007567
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007A3 RID: 1955
		public int int_0;

		// Token: 0x040007A4 RID: 1956
		public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

		// Token: 0x040007A5 RID: 1957
		private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
	}

	// Token: 0x020001A6 RID: 422
	private sealed class Class208
	{
		// Token: 0x040007A6 RID: 1958
		public int int_0;

		// Token: 0x040007A7 RID: 1959
		public int int_1;
	}

	// Token: 0x020001A7 RID: 423
	private sealed class Class209
	{
		// Token: 0x06000BEB RID: 3051 RVA: 0x00009375 File Offset: 0x00007575
		internal void method_0(string string_0)
		{
			if (this.class207_0.class490_0.Name.ToLower().Contains(string_0))
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x040007A8 RID: 1960
		public bool bool_0;

		// Token: 0x040007A9 RID: 1961
		public Class206.Class207 class207_0;
	}

	// Token: 0x020001A8 RID: 424
	[StructLayout(LayoutKind.Auto)]
	private struct Struct89 : IAsyncStateMachine
	{
		// Token: 0x06000BEC RID: 3052 RVA: 0x0004B3C4 File Offset: 0x000495C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			int result;
			try
			{
				TaskAwaiter<List<Class512>> awaiter;
				if (num != 0)
				{
					awaiter = Class148.smethod_8().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<List<Class512>>, Class206.Struct89>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<List<Class512>>);
					this.int_0 = -1;
				}
				int num2 = awaiter.GetResult().Sum(new Func<Class512, int>(Class206.Class210.class210_0.method_0));
				int num3 = Class206.ireadOnlyList_0.Count(new Func<string, bool>(Class206.Class210.class210_0.method_1));
				result = num2 + num3 * 2;
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

		// Token: 0x06000BED RID: 3053 RVA: 0x0000939B File Offset: 0x0000759B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040007AA RID: 1962
		public int int_0;

		// Token: 0x040007AB RID: 1963
		public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

		// Token: 0x040007AC RID: 1964
		private TaskAwaiter<List<Class512>> taskAwaiter_0;
	}

	// Token: 0x020001A9 RID: 425
	[Serializable]
	private sealed class Class210
	{
		// Token: 0x06000BF0 RID: 3056 RVA: 0x000093B5 File Offset: 0x000075B5
		internal int method_0(Class512 class512_0)
		{
			return class512_0.method_41();
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000093BD File Offset: 0x000075BD
		internal bool method_1(string string_0)
		{
			return Class673.smethod_24(string_0) == "DEFAULT";
		}

		// Token: 0x040007AD RID: 1965
		public static readonly Class206.Class210 class210_0 = new Class206.Class210();

		// Token: 0x040007AE RID: 1966
		public static Func<Class512, int> func_0;

		// Token: 0x040007AF RID: 1967
		public static Func<string, bool> func_1;
	}
}
