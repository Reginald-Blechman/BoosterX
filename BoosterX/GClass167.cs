using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

// Token: 0x02000179 RID: 377
public sealed class GClass167 : GClass162
{
	// Token: 0x06000A77 RID: 2679 RVA: 0x000084E4 File Offset: 0x000066E4
	public GClass167()
	{
		this.AddCommand = new GClass280(new Action<object>(this.method_6), null);
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00008504 File Offset: 0x00006704
	// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0000850C File Offset: 0x0000670C
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

	// Token: 0x06000A7A RID: 2682 RVA: 0x00008527 File Offset: 0x00006727
	private void method_2()
	{
		if (this.IsAdded)
		{
			Class657.smethod_2();
			this.FoundIn = Class298.smethod_2("added");
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00008547 File Offset: 0x00006747
	// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0000854F File Offset: 0x0000674F
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

	// Token: 0x06000A7D RID: 2685 RVA: 0x000491F0 File Offset: 0x000473F0
	public void method_3()
	{
		GClass167.Struct77 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass167_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass167.Struct77>(ref @struct);
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00008564 File Offset: 0x00006764
	// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0000856C File Offset: 0x0000676C
	public GClass280 AddCommand
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

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00008575 File Offset: 0x00006775
	// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0000857D File Offset: 0x0000677D
	public string ExeName
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("ExeName");
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00008592 File Offset: 0x00006792
	// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0000859A File Offset: 0x0000679A
	public string ExeDir
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			this.method_3();
			base.method_0("ExeDir");
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000A84 RID: 2692 RVA: 0x000085B5 File Offset: 0x000067B5
	// (set) Token: 0x06000A85 RID: 2693 RVA: 0x000085BD File Offset: 0x000067BD
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

	// Token: 0x06000A86 RID: 2694 RVA: 0x000085D2 File Offset: 0x000067D2
	private string method_4()
	{
		return this.string_3;
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x000085DA File Offset: 0x000067DA
	private void method_5(string string_4)
	{
		this.string_3 = string_4;
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000085E3 File Offset: 0x000067E3
	// (set) Token: 0x06000A89 RID: 2697 RVA: 0x000085EB File Offset: 0x000067EB
	public string FoundIn
	{
		get
		{
			return this.method_4();
		}
		set
		{
			this.method_5(value);
			base.method_0("FoundIn");
		}
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00008600 File Offset: 0x00006800
	private void method_6(object object_0)
	{
		Class657.smethod_5(this);
		this.IsAdded = true;
	}

	// Token: 0x04000700 RID: 1792
	private bool bool_0;

	// Token: 0x04000701 RID: 1793
	private string string_0;

	// Token: 0x04000702 RID: 1794
	private GClass280 gclass280_0;

	// Token: 0x04000703 RID: 1795
	private string string_1;

	// Token: 0x04000704 RID: 1796
	private string string_2;

	// Token: 0x04000705 RID: 1797
	private BitmapSource bitmapSource_0;

	// Token: 0x04000706 RID: 1798
	private string string_3;

	// Token: 0x0200017A RID: 378
	[StructLayout(LayoutKind.Auto)]
	private struct Struct77 : IAsyncStateMachine
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x00049228 File Offset: 0x00047428
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass167 gclass = this.gclass167_0;
			try
			{
				TaskAwaiter<BitmapSource> awaiter;
				if (num != 0)
				{
					awaiter = Class765.smethod_6(gclass.ExeDir).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapSource>, GClass167.Struct77>(ref awaiter, ref this);
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
				gclass.Icon = result;
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

		// Token: 0x06000A8C RID: 2700 RVA: 0x0000860F File Offset: 0x0000680F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000707 RID: 1799
		public int int_0;

		// Token: 0x04000708 RID: 1800
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000709 RID: 1801
		public GClass167 gclass167_0;

		// Token: 0x0400070A RID: 1802
		private TaskAwaiter<BitmapSource> taskAwaiter_0;
	}
}
