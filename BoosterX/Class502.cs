using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x02000269 RID: 617
internal sealed class Class502 : GClass162
{
	// Token: 0x060010A2 RID: 4258 RVA: 0x00058480 File Offset: 0x00056680
	public Class502(Type type_1, DrawingImage drawingImage_1 = null, string string_3 = "", string string_4 = "", bool bool_2 = false)
	{
		Class502.Class285 @class = new Class502.Class285();
		@class.type_0 = type_1;
		base..ctor();
		if (@class.type_0 != null)
		{
			this.type_0 = @class.type_0;
			this.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
			this.class762_0 = Class761.smethod_0().First(new Func<Class761.Class762, bool>(@class.method_0));
			this.Name = this.class762_0.Name;
			this.Icon = this.class762_0.Icon;
		}
		else
		{
			this.Margin = new Thickness(20.0, 0.0, 0.0, 0.0);
			this.Icon = drawingImage_1;
			this.Name = string_3;
		}
		this.Desc = string_4;
		this.bool_0 = bool_2;
		this.ToApply = true;
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0000C191 File Offset: 0x0000A391
	// (set) Token: 0x060010A4 RID: 4260 RVA: 0x0000C199 File Offset: 0x0000A399
	public Thickness Margin
	{
		get
		{
			return this.thickness_0;
		}
		set
		{
			this.thickness_0 = value;
			base.method_0("Margin");
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0000C1AE File Offset: 0x0000A3AE
	// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0000C1B6 File Offset: 0x0000A3B6
	public DrawingImage Icon
	{
		get
		{
			return this.drawingImage_0;
		}
		set
		{
			this.drawingImage_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0000C1CB File Offset: 0x0000A3CB
	// (set) Token: 0x060010A8 RID: 4264 RVA: 0x0000C1D3 File Offset: 0x0000A3D3
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
	// (set) Token: 0x060010AA RID: 4266 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
	public string Desc
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("Desc");
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x060010AB RID: 4267 RVA: 0x0000C205 File Offset: 0x0000A405
	// (set) Token: 0x060010AC RID: 4268 RVA: 0x00058594 File Offset: 0x00056794
	public bool ToApply
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			if (this.bool_0)
			{
				this.method_2(value ? Class298.smethod_2("willbeinstalled") : Class298.smethod_2("willnotbeinstalled"), value ? dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd : dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
			}
			else
			{
				this.method_2(value ? Class298.smethod_2("WillBeApplied") : Class298.smethod_2("WillNotBeAppied"), value ? dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd : dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
			}
			base.method_0("ToApply");
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x060010AD RID: 4269 RVA: 0x0000C20D File Offset: 0x0000A40D
	// (set) Token: 0x060010AE RID: 4270 RVA: 0x0000C215 File Offset: 0x0000A415
	public string StatusText
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x060010AF RID: 4271 RVA: 0x0000C22A File Offset: 0x0000A42A
	// (set) Token: 0x060010B0 RID: 4272 RVA: 0x0000C232 File Offset: 0x0000A432
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

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0000C247 File Offset: 0x0000A447
	// (set) Token: 0x060010B2 RID: 4274 RVA: 0x0000C24F File Offset: 0x0000A44F
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

	// Token: 0x060010B3 RID: 4275 RVA: 0x00058620 File Offset: 0x00056820
	private void method_2(string string_3, SolidColorBrush solidColorBrush_1)
	{
		Class502.Struct143 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class502_0 = this;
		@struct.string_0 = string_3;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class502.Struct143>(ref @struct);
	}

	// Token: 0x04000A7D RID: 2685
	public Type type_0;

	// Token: 0x04000A7E RID: 2686
	public bool bool_0;

	// Token: 0x04000A7F RID: 2687
	public Class761.Class762 class762_0;

	// Token: 0x04000A80 RID: 2688
	public Thickness thickness_0;

	// Token: 0x04000A81 RID: 2689
	public DrawingImage drawingImage_0;

	// Token: 0x04000A82 RID: 2690
	private string string_0;

	// Token: 0x04000A83 RID: 2691
	public string string_1;

	// Token: 0x04000A84 RID: 2692
	private bool bool_1;

	// Token: 0x04000A85 RID: 2693
	private string string_2 = string.Empty;

	// Token: 0x04000A86 RID: 2694
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04000A87 RID: 2695
	private double double_0;

	// Token: 0x0200026A RID: 618
	private sealed class Class285
	{
		// Token: 0x060010B5 RID: 4277 RVA: 0x0000C264 File Offset: 0x0000A464
		internal bool method_0(Class761.Class762 class762_0)
		{
			return class762_0.method_0() == this.type_0;
		}

		// Token: 0x04000A88 RID: 2696
		public Type type_0;
	}

	// Token: 0x0200026B RID: 619
	[StructLayout(LayoutKind.Auto)]
	private struct Struct143 : IAsyncStateMachine
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x00058668 File Offset: 0x00056868
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class502 @class = this.class502_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B8;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_127;
				}
				IL_56:
				if (@class.StatusOpacity == 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_12E;
				}
				@class.StatusOpacity -= 0.1;
				if (@class.StatusOpacity < 0.05)
				{
					@class.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class502.Struct143>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_127:
				awaiter.GetResult();
				IL_12E:
				if (@class.StatusOpacity != 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_127;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class502.Struct143>(ref awaiter, ref this);
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

		// Token: 0x060010B7 RID: 4279 RVA: 0x0000C277 File Offset: 0x0000A477
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A89 RID: 2697
		public int int_0;

		// Token: 0x04000A8A RID: 2698
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000A8B RID: 2699
		public Class502 class502_0;

		// Token: 0x04000A8C RID: 2700
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000A8D RID: 2701
		public string string_0;

		// Token: 0x04000A8E RID: 2702
		private TaskAwaiter taskAwaiter_0;
	}
}
