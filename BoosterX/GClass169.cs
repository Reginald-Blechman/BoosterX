using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using ns0;

// Token: 0x02000192 RID: 402
public sealed class GClass169 : GClass162
{
	// Token: 0x06000B3E RID: 2878 RVA: 0x00049D34 File Offset: 0x00047F34
	public GClass169(dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_1)
	{
		this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0 = dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_1;
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00008D44 File Offset: 0x00006F44
	// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00008D4C File Offset: 0x00006F4C
	public bool AnalyzeFinished
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			base.method_1<bool>(ref this.bool_0, value, "AnalyzeFinished", null);
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00008D63 File Offset: 0x00006F63
	// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00008D6B File Offset: 0x00006F6B
	public int BottleneckPercent
	{
		get
		{
			return this.int_0;
		}
		set
		{
			base.method_1<int>(ref this.int_0, value, "BottleneckPercent", null);
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00008D82 File Offset: 0x00006F82
	// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00008D8A File Offset: 0x00006F8A
	public string BottleneckMainText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			base.method_1<string>(ref this.string_0, value, "BottleneckMainText", null);
		}
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00008DA1 File Offset: 0x00006FA1
	// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00008DA9 File Offset: 0x00006FA9
	public string BLToolTip
	{
		get
		{
			return this.string_1;
		}
		set
		{
			base.method_1<string>(ref this.string_1, value, "BLToolTip", null);
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00008DC0 File Offset: 0x00006FC0
	// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00008DC8 File Offset: 0x00006FC8
	public string BottleneckComment
	{
		get
		{
			return this.string_2;
		}
		set
		{
			base.method_1<string>(ref this.string_2, value, "BottleneckComment", null);
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00008DDF File Offset: 0x00006FDF
	// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00008DE7 File Offset: 0x00006FE7
	public int BoostEstimate
	{
		get
		{
			return this.int_1;
		}
		set
		{
			base.method_1<int>(ref this.int_1, value, "BoostEstimate", null);
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00008DFE File Offset: 0x00006FFE
	// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00008E06 File Offset: 0x00007006
	public string BoostEstimateComment
	{
		get
		{
			return this.string_3;
		}
		set
		{
			base.method_1<string>(ref this.string_3, value, "BoostEstimateComment", null);
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00008E1D File Offset: 0x0000701D
	// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00008E25 File Offset: 0x00007025
	public string BoostEstimatePercent
	{
		get
		{
			return this.string_4;
		}
		set
		{
			base.method_1<string>(ref this.string_4, value, "BoostEstimatePercent", null);
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00008E3C File Offset: 0x0000703C
	// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00008E44 File Offset: 0x00007044
	public int PrivacyPercent
	{
		get
		{
			return this.int_2;
		}
		set
		{
			base.method_1<int>(ref this.int_2, value, "PrivacyPercent", null);
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00008E5B File Offset: 0x0000705B
	// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00008E63 File Offset: 0x00007063
	public string PrivacyComment
	{
		get
		{
			return this.string_5;
		}
		set
		{
			base.method_1<string>(ref this.string_5, value, "PrivacyComment", null);
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00008E7A File Offset: 0x0000707A
	// (set) Token: 0x06000B54 RID: 2900 RVA: 0x00008E82 File Offset: 0x00007082
	public int FutureProofPercent
	{
		get
		{
			return this.int_3;
		}
		set
		{
			base.method_1<int>(ref this.int_3, value, "FutureProofPercent", null);
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00008E99 File Offset: 0x00007099
	// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00008EA1 File Offset: 0x000070A1
	public string FutureProofComment
	{
		get
		{
			return this.string_6;
		}
		set
		{
			base.method_1<string>(ref this.string_6, value, "FutureProofComment", null);
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00008EB8 File Offset: 0x000070B8
	// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00008EC0 File Offset: 0x000070C0
	public int PerformanceOverSecurity
	{
		get
		{
			return this.int_4;
		}
		set
		{
			base.method_1<int>(ref this.int_4, value, "PerformanceOverSecurity", null);
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00008ED7 File Offset: 0x000070D7
	// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00008EDF File Offset: 0x000070DF
	public int OptimizationLevel
	{
		get
		{
			return this.int_5;
		}
		set
		{
			base.method_1<int>(ref this.int_5, value, "OptimizationLevel", null);
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00008EF6 File Offset: 0x000070F6
	// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00008EFE File Offset: 0x000070FE
	public string PerformanceOverSecurityComment
	{
		get
		{
			return this.string_7;
		}
		set
		{
			base.method_1<string>(ref this.string_7, value, "PerformanceOverSecurityComment", null);
		}
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00049DA0 File Offset: 0x00047FA0
	public void method_2()
	{
		GClass169.Struct82 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass169_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass169.Struct82>(ref @struct);
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00049DD8 File Offset: 0x00047FD8
	private void method_3()
	{
		if (this.BottleneckPercent < 6)
		{
			((Storyboard)this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0.FindResource("AnimateLevelBackgroundGreen")).Begin(this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0.border_0);
			return;
		}
		if (this.BottleneckPercent < 15)
		{
			((Storyboard)this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0.FindResource("AnimateLevelBackgroundYellow")).Begin(this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0.border_0);
			return;
		}
		((Storyboard)this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0.FindResource("AnimateLevelBackgroundRed")).Begin(this.dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0.border_0);
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00049E6C File Offset: 0x0004806C
	private void method_4()
	{
		GClass169.Struct83 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass169_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass169.Struct83>(ref @struct);
	}

	// Token: 0x04000744 RID: 1860
	private bool bool_0;

	// Token: 0x04000745 RID: 1861
	private int int_0;

	// Token: 0x04000746 RID: 1862
	private string string_0 = Class298.smethod_2("Loading");

	// Token: 0x04000747 RID: 1863
	private string string_1 = Class298.smethod_2("Loading");

	// Token: 0x04000748 RID: 1864
	private string string_2 = Class298.smethod_2("Loading");

	// Token: 0x04000749 RID: 1865
	private int int_1;

	// Token: 0x0400074A RID: 1866
	private string string_3 = Class298.smethod_2("Loading");

	// Token: 0x0400074B RID: 1867
	private string string_4 = "0%";

	// Token: 0x0400074C RID: 1868
	private int int_2;

	// Token: 0x0400074D RID: 1869
	private string string_5;

	// Token: 0x0400074E RID: 1870
	private int int_3;

	// Token: 0x0400074F RID: 1871
	private string string_6;

	// Token: 0x04000750 RID: 1872
	private int int_4;

	// Token: 0x04000751 RID: 1873
	private int int_5;

	// Token: 0x04000752 RID: 1874
	private string string_7;

	// Token: 0x04000753 RID: 1875
	private dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd dje_z3SDD3EJ37KH8ETZLMBBL2PTEK24QR22ANY9DD7LT3F5HACLAJQ2UBWRELYKQ_ejd_0;

	// Token: 0x02000193 RID: 403
	[StructLayout(LayoutKind.Auto)]
	private struct Struct82 : IAsyncStateMachine
	{
		// Token: 0x06000B60 RID: 2912 RVA: 0x00049EA4 File Offset: 0x000480A4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass169 gclass = this.gclass169_0;
			try
			{
				if (num != 0)
				{
					gclass.AnalyzeFinished = false;
				}
				try
				{
					TaskAwaiter<GClass155> awaiter;
					if (num != 0)
					{
						awaiter = Class206.smethod_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass155>, GClass169.Struct82>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<GClass155>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					GClass155 result = awaiter.GetResult();
					if (result.method_0() > result.method_4())
					{
						gclass.BottleneckMainText = "CPU";
						gclass.BottleneckPercent = result.method_0();
					}
					else if (result.method_0() < result.method_4())
					{
						gclass.BottleneckMainText = "GPU";
						gclass.BottleneckPercent = result.method_4();
					}
					else
					{
						gclass.BottleneckMainText = "NO BOTTLENECK";
						gclass.BottleneckPercent = 0;
					}
					gclass.method_3();
					gclass.BLToolTip = string.Concat(new string[]
					{
						Class298.smethod_2("BottleneckComment"),
						"\n\nCPU: ",
						result.method_2(),
						"\nGPU: ",
						result.method_6(),
						"\nResolution: ",
						result.method_10()
					});
					gclass.BoostEstimate = result.method_14();
					gclass.BoostEstimateComment = result.BoostEstimateComment;
					gclass.method_4();
					gclass.BottleneckComment = result.method_12();
					gclass.FutureProofPercent = result.FutureProofPercent;
					gclass.PrivacyPercent = result.PrivacyPercent;
					gclass.OptimizationLevel = result.OptimizationLevel;
				}
				catch
				{
				}
				finally
				{
					if (num < 0)
					{
						gclass.AnalyzeFinished = true;
					}
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00008F15 File Offset: 0x00007115
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000754 RID: 1876
		public int int_0;

		// Token: 0x04000755 RID: 1877
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000756 RID: 1878
		public GClass169 gclass169_0;

		// Token: 0x04000757 RID: 1879
		private TaskAwaiter<GClass155> taskAwaiter_0;
	}

	// Token: 0x02000194 RID: 404
	[StructLayout(LayoutKind.Auto)]
	private struct Struct83 : IAsyncStateMachine
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x0004A0C4 File Offset: 0x000482C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass169 gclass = this.gclass169_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_9A;
				}
				this.int_1 = 2500 / ((gclass.BoostEstimate > 0) ? gclass.BoostEstimate : 1);
				this.int_2 = 0;
				IL_56:
				if (this.int_2 > gclass.BoostEstimate)
				{
					goto IL_EE;
				}
				gclass.BoostEstimatePercent = string.Format("{0}%", this.int_2);
				awaiter = Task.Delay(this.int_1).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass169.Struct83>(ref awaiter, ref this);
					return;
				}
				IL_9A:
				awaiter.GetResult();
				int num2 = this.int_2;
				this.int_2 = num2 + 1;
				goto IL_56;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_EE:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00008F23 File Offset: 0x00007123
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000758 RID: 1880
		public int int_0;

		// Token: 0x04000759 RID: 1881
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400075A RID: 1882
		public GClass169 gclass169_0;

		// Token: 0x0400075B RID: 1883
		private int int_1;

		// Token: 0x0400075C RID: 1884
		private int int_2;

		// Token: 0x0400075D RID: 1885
		private TaskAwaiter taskAwaiter_0;
	}
}
