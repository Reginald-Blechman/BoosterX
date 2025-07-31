using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;
using PIManagerX;

// Token: 0x0200045C RID: 1116
public sealed class GClass187 : GClass162
{
	// Token: 0x06001D24 RID: 7460 RVA: 0x000133DD File Offset: 0x000115DD
	public GClass187(PManagerX.MonitorModel monitorModel_1, int int_5, dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd_1)
	{
		this.monitorModel_0 = monitorModel_1;
		this.int_0 = int_5;
		this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd_0 = dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd_1;
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00013410 File Offset: 0x00011610
	public string MonitorName
	{
		get
		{
			return string.Format("{0} {1} ({2})", Class298.smethod_2("Monitor"), this.int_0, this.monitorModel_0.DeviceName);
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0001343E File Offset: 0x0001163E
	public Visibility PrimaryVisibility
	{
		get
		{
			if (this.int_0 != 1)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x000793D8 File Offset: 0x000775D8
	private bool method_2()
	{
		return this.monitorModel_0.Width != this.monitorModel_0.MaxWidth || this.monitorModel_0.Height != this.monitorModel_0.MaxHeight || this.monitorModel_0.CurrentRefreshRate != this.monitorModel_0.MaxRefreshRate;
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001D28 RID: 7464 RVA: 0x0001344C File Offset: 0x0001164C
	public bool HasProblem
	{
		get
		{
			return !this.bool_0 && this.method_2();
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0001345E File Offset: 0x0001165E
	public Visibility FixButtonVisibility
	{
		get
		{
			if (!this.bool_0 && this.HasProblem)
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00013473 File Offset: 0x00011673
	public Visibility ISeeButtonVisibility
	{
		get
		{
			if (!this.bool_0)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00013480 File Offset: 0x00011680
	public Visibility ResWarnVisibility
	{
		get
		{
			if (!this.bool_0)
			{
				if (this.monitorModel_0.Width != this.monitorModel_0.MaxWidth)
				{
					return Visibility.Visible;
				}
			}
			return Visibility.Collapsed;
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000134A7 File Offset: 0x000116A7
	public Visibility FreqWarnVisibility
	{
		get
		{
			if (!this.bool_0)
			{
				if (this.monitorModel_0.CurrentRefreshRate != this.monitorModel_0.MaxRefreshRate)
				{
					return Visibility.Visible;
				}
			}
			return Visibility.Collapsed;
		}
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06001D2D RID: 7469 RVA: 0x000134CE File Offset: 0x000116CE
	public Brush CurrentResColor
	{
		get
		{
			if (this.monitorModel_0.Width == this.monitorModel_0.MaxWidth)
			{
				return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;
			}
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
		}
	}

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000134F3 File Offset: 0x000116F3
	public Brush CurrentFreqColor
	{
		get
		{
			if (this.monitorModel_0.CurrentRefreshRate == this.monitorModel_0.MaxRefreshRate)
			{
				return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;
			}
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
		}
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00013518 File Offset: 0x00011718
	public string CurrentResolution
	{
		get
		{
			return string.Format("{0} x {1}", this.monitorModel_0.Width, this.monitorModel_0.Height);
		}
	}

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00013545 File Offset: 0x00011745
	public string MaxResolution
	{
		get
		{
			return string.Format("({0} x {1})", this.monitorModel_0.MaxWidth, this.monitorModel_0.MaxHeight);
		}
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00013572 File Offset: 0x00011772
	public string CurrentFrequency
	{
		get
		{
			return string.Format("{0}", this.monitorModel_0.CurrentRefreshRate);
		}
	}

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0001358F File Offset: 0x0001178F
	public string MaxFrequency
	{
		get
		{
			return string.Format("({0})", this.monitorModel_0.MaxRefreshRate);
		}
	}

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06001D33 RID: 7475 RVA: 0x000135AC File Offset: 0x000117AC
	// (set) Token: 0x06001D34 RID: 7476 RVA: 0x000135B4 File Offset: 0x000117B4
	public string StatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000135C9 File Offset: 0x000117C9
	// (set) Token: 0x06001D36 RID: 7478 RVA: 0x000135D1 File Offset: 0x000117D1
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06001D37 RID: 7479 RVA: 0x000135E6 File Offset: 0x000117E6
	// (set) Token: 0x06001D38 RID: 7480 RVA: 0x000135EE File Offset: 0x000117EE
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x00079434 File Offset: 0x00077634
	private void method_3(string string_1, SolidColorBrush solidColorBrush_1)
	{
		GClass187.Struct285 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass187_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass187.Struct285>(ref @struct);
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0007947C File Offset: 0x0007767C
	public GClass280 FixCmd
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_4), null));
			}
			return result;
		}
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x06001D3B RID: 7483 RVA: 0x000794B0 File Offset: 0x000776B0
	public GClass280 ISeeCmd
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_7), null));
			}
			return result;
		}
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x000794E4 File Offset: 0x000776E4
	private void method_4(object object_0)
	{
		GClass187.Struct287 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass187_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass187.Struct287>(ref @struct);
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x00013603 File Offset: 0x00011803
	private bool method_5(PManagerX.MonitorModel monitorModel_1)
	{
		return monitorModel_1.DeviceName == this.monitorModel_0.DeviceName;
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x00013603 File Offset: 0x00011803
	private bool method_6(PManagerX.MonitorModel monitorModel_1)
	{
		return monitorModel_1.DeviceName == this.monitorModel_0.DeviceName;
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x0001361B File Offset: 0x0001181B
	private void method_7(object object_0)
	{
		CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource_0;
		if (cancellationTokenSource != null)
		{
			cancellationTokenSource.Cancel();
		}
		this.bool_0 = false;
		this.StatusOpacity = 0.0;
		this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd_0.method_1();
	}

	// Token: 0x04001355 RID: 4949
	private PManagerX.MonitorModel monitorModel_0;

	// Token: 0x04001356 RID: 4950
	private readonly int int_0;

	// Token: 0x04001357 RID: 4951
	private dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd_0;

	// Token: 0x04001358 RID: 4952
	private int int_1;

	// Token: 0x04001359 RID: 4953
	private int int_2;

	// Token: 0x0400135A RID: 4954
	private int int_3;

	// Token: 0x0400135B RID: 4955
	private int int_4;

	// Token: 0x0400135C RID: 4956
	private bool bool_0;

	// Token: 0x0400135D RID: 4957
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400135E RID: 4958
	private string string_0 = string.Empty;

	// Token: 0x0400135F RID: 4959
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04001360 RID: 4960
	private double double_0;

	// Token: 0x04001361 RID: 4961
	private GClass280 gclass280_0;

	// Token: 0x04001362 RID: 4962
	private GClass280 gclass280_1;

	// Token: 0x0200045D RID: 1117
	[StructLayout(LayoutKind.Auto)]
	private struct Struct285 : IAsyncStateMachine
	{
		// Token: 0x06001D40 RID: 7488 RVA: 0x0007951C File Offset: 0x0007771C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass187 gclass = this.gclass187_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_A4;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_101;
				}
				IL_56:
				if (gclass.StatusOpacity <= 0.0)
				{
					gclass.StatusColor = this.solidColorBrush_0;
					gclass.StatusText = this.string_0;
					goto IL_108;
				}
				gclass.StatusOpacity = Math.Max(0.0, gclass.StatusOpacity - 0.1);
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass187.Struct285>(ref awaiter, ref this);
					return;
				}
				IL_A4:
				awaiter.GetResult();
				goto IL_56;
				IL_101:
				awaiter.GetResult();
				IL_108:
				if (gclass.StatusOpacity < 1.0)
				{
					gclass.StatusOpacity = Math.Min(1.0, gclass.StatusOpacity + 0.1333);
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_101;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass187.Struct285>(ref awaiter, ref this);
					return;
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

		// Token: 0x06001D41 RID: 7489 RVA: 0x0001364F File Offset: 0x0001184F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001363 RID: 4963
		public int int_0;

		// Token: 0x04001364 RID: 4964
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001365 RID: 4965
		public GClass187 gclass187_0;

		// Token: 0x04001366 RID: 4966
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001367 RID: 4967
		public string string_0;

		// Token: 0x04001368 RID: 4968
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200045E RID: 1118
	private sealed class Class540
	{
		// Token: 0x06001D43 RID: 7491 RVA: 0x000796CC File Offset: 0x000778CC
		internal Task method_0()
		{
			GClass187.Class540.Struct286 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class540_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass187.Class540.Struct286>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001369 RID: 4969
		public CancellationToken cancellationToken_0;

		// Token: 0x0400136A RID: 4970
		public GClass187 gclass187_0;

		// Token: 0x0200045F RID: 1119
		[StructLayout(LayoutKind.Auto)]
		private struct Struct286 : IAsyncStateMachine
		{
			// Token: 0x06001D44 RID: 7492 RVA: 0x00079710 File Offset: 0x00077910
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass187.Class540 @class = this.class540_0;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_A8;
					}
					this.int_1 = 15;
					IL_39:
					if (this.int_1 < 0)
					{
						if (!@class.cancellationToken_0.IsCancellationRequested)
						{
							MethodInfo method = typeof(PManagerX).GetMethod("ChangeDisplayMode", BindingFlags.Static | BindingFlags.NonPublic);
							if (method != null)
							{
								method.Invoke(null, new object[]
								{
									@class.gclass187_0.monitorModel_0.DeviceName,
									@class.gclass187_0.int_1,
									@class.gclass187_0.int_2,
									@class.gclass187_0.int_4,
									@class.gclass187_0.int_3
								});
							}
							PManagerX.MonitorModel monitorModel = PManagerX.GetMonitors().FirstOrDefault(new Func<PManagerX.MonitorModel, bool>(@class.gclass187_0.method_6));
							if (monitorModel != null)
							{
								@class.gclass187_0.monitorModel_0 = monitorModel;
							}
							@class.gclass187_0.bool_0 = false;
							@class.gclass187_0.StatusOpacity = 0.0;
							@class.gclass187_0.method_0("StatusOpacity");
							@class.gclass187_0.method_0(string.Empty);
						}
						goto IL_208;
					}
					if (@class.cancellationToken_0.IsCancellationRequested)
					{
						goto IL_208;
					}
					@class.gclass187_0.method_3(Class298.smethod_2("ClickISeeIn") + " " + this.int_1.ToString(), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd);
					awaiter = Task.Delay(1000, @class.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass187.Class540.Struct286>(ref awaiter, ref this);
						return;
					}
					IL_A8:
					awaiter.GetResult();
					int num2 = this.int_1;
					this.int_1 = num2 - 1;
					goto IL_39;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_208:
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001D45 RID: 7493 RVA: 0x0001365D File Offset: 0x0001185D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x0400136B RID: 4971
			public int int_0;

			// Token: 0x0400136C RID: 4972
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400136D RID: 4973
			public GClass187.Class540 class540_0;

			// Token: 0x0400136E RID: 4974
			private int int_1;

			// Token: 0x0400136F RID: 4975
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x02000460 RID: 1120
	[StructLayout(LayoutKind.Auto)]
	private struct Struct287 : IAsyncStateMachine
	{
		// Token: 0x06001D46 RID: 7494 RVA: 0x00079954 File Offset: 0x00077B54
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass187 gclass = this.gclass187_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					GClass187.Class540 @class = new GClass187.Class540();
					@class.gclass187_0 = gclass;
					gclass.int_1 = gclass.monitorModel_0.Width;
					gclass.int_2 = gclass.monitorModel_0.Height;
					gclass.int_3 = gclass.monitorModel_0.CurrentRefreshRate;
					gclass.int_4 = gclass.monitorModel_0.BitsPerPel;
					PManagerX.SetMonitorToMax(gclass.monitorModel_0.DeviceName);
					PManagerX.MonitorModel monitorModel = PManagerX.GetMonitors().FirstOrDefault(new Func<PManagerX.MonitorModel, bool>(gclass.method_5));
					if (monitorModel != null)
					{
						gclass.monitorModel_0 = monitorModel;
					}
					gclass.bool_0 = true;
					gclass.method_0("FixButtonVisibility");
					gclass.method_0("ISeeButtonVisibility");
					gclass.method_0("ResWarnVisibility");
					gclass.method_0("FreqWarnVisibility");
					gclass.method_0("CurrentResColor");
					gclass.method_0("CurrentFreqColor");
					gclass.method_0("CurrentResolution");
					gclass.method_0("CurrentFrequency");
					gclass.method_0("HasProblem");
					CancellationTokenSource cancellationTokenSource_ = gclass.cancellationTokenSource_0;
					if (cancellationTokenSource_ != null)
					{
						cancellationTokenSource_.Cancel();
					}
					gclass.cancellationTokenSource_0 = new CancellationTokenSource();
					@class.cancellationToken_0 = gclass.cancellationTokenSource_0.Token;
					awaiter = Task.Run(new Func<Task>(@class.method_0), @class.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass187.Struct287>(ref awaiter, ref this);
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
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0001366B File Offset: 0x0001186B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001370 RID: 4976
		public int int_0;

		// Token: 0x04001371 RID: 4977
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001372 RID: 4978
		public GClass187 gclass187_0;

		// Token: 0x04001373 RID: 4979
		private TaskAwaiter taskAwaiter_0;
	}
}
