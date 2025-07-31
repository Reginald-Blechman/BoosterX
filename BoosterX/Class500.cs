using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

// Token: 0x02000231 RID: 561
internal sealed class Class500 : GClass162
{
	// Token: 0x06000F3A RID: 3898 RVA: 0x0000B29A File Offset: 0x0000949A
	public Class500(string string_1)
	{
		this.class750_0 = new Class750(string_1);
		this.DeleteCommand = new GClass280(new Action<object>(this.method_4), null);
		this.method_3();
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0000B2CC File Offset: 0x000094CC
	// (set) Token: 0x06000F3C RID: 3900 RVA: 0x0000B2D4 File Offset: 0x000094D4
	public GClass280 DeleteCommand
	{
		[CompilerGenerated]
		get
		{
			return this.gclass280_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass280_0 = value;
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0000B2DD File Offset: 0x000094DD
	// (set) Token: 0x06000F3E RID: 3902 RVA: 0x0000B2E5 File Offset: 0x000094E5
	public bool IsAdded
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			this.method_2();
			base.method_0("IsAdded");
		}
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x0000B300 File Offset: 0x00009500
	private void method_2()
	{
		if (this.IsAdded)
		{
			Class657.smethod_2();
			this.FoundIn = Class298.smethod_2("added");
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0000B320 File Offset: 0x00009520
	public string Name
	{
		get
		{
			return this.class750_0.method_1();
		}
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00053678 File Offset: 0x00051878
	public void method_3()
	{
		Class500.Struct131 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class500_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class500.Struct131>(ref @struct);
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0000B32D File Offset: 0x0000952D
	// (set) Token: 0x06000F43 RID: 3907 RVA: 0x0000B335 File Offset: 0x00009535
	public GClass280 AddCommand
	{
		[CompilerGenerated]
		get
		{
			return this.gclass280_1;
		}
		[CompilerGenerated]
		set
		{
			this.gclass280_1 = value;
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0000B33E File Offset: 0x0000953E
	public string ExeName
	{
		get
		{
			return this.class750_0.method_3();
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000F45 RID: 3909 RVA: 0x0000B34B File Offset: 0x0000954B
	public string ExeDir
	{
		get
		{
			return this.class750_0.ExeDir;
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0000B358 File Offset: 0x00009558
	// (set) Token: 0x06000F47 RID: 3911 RVA: 0x0000B360 File Offset: 0x00009560
	public BitmapSource Icon
	{
		get
		{
			return this.bitmapSource_0;
		}
		set
		{
			this.bitmapSource_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0000B375 File Offset: 0x00009575
	// (set) Token: 0x06000F49 RID: 3913 RVA: 0x0000B37D File Offset: 0x0000957D
	public string FoundIn
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("FoundIn");
		}
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0000B392 File Offset: 0x00009592
	private void method_4(object object_0)
	{
		Class657.smethod_6(this);
		Class657.smethod_2();
	}

	// Token: 0x040009BA RID: 2490
	private Class750 class750_0;

	// Token: 0x040009BB RID: 2491
	private GClass280 gclass280_0;

	// Token: 0x040009BC RID: 2492
	private bool bool_0;

	// Token: 0x040009BD RID: 2493
	private GClass280 gclass280_1;

	// Token: 0x040009BE RID: 2494
	private BitmapSource bitmapSource_0;

	// Token: 0x040009BF RID: 2495
	private string string_0;

	// Token: 0x02000232 RID: 562
	[StructLayout(LayoutKind.Auto)]
	private struct Struct131 : IAsyncStateMachine
	{
		// Token: 0x06000F4B RID: 3915 RVA: 0x000536B0 File Offset: 0x000518B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class500 @class = this.class500_0;
			try
			{
				TaskAwaiter<BitmapSource> awaiter;
				if (num != 0)
				{
					awaiter = Class765.smethod_6(@class.ExeDir).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapSource>, Class500.Struct131>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<BitmapSource>);
					this.int_0 = -1;
				}
				BitmapSource result = awaiter.GetResult();
				@class.Icon = result;
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

		// Token: 0x06000F4C RID: 3916 RVA: 0x0000B39F File Offset: 0x0000959F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040009C0 RID: 2496
		public int int_0;

		// Token: 0x040009C1 RID: 2497
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040009C2 RID: 2498
		public Class500 class500_0;

		// Token: 0x040009C3 RID: 2499
		private TaskAwaiter<BitmapSource> taskAwaiter_0;
	}
}
