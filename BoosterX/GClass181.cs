using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

// Token: 0x0200034C RID: 844
public sealed class GClass181 : GClass162
{
	// Token: 0x060015E6 RID: 5606 RVA: 0x0000F088 File Offset: 0x0000D288
	public GClass181()
	{
		this.AddCommand = new GClass280(new Action<object>(this.method_4), null);
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
	// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
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

	// Token: 0x060015E9 RID: 5609 RVA: 0x0000F0CB File Offset: 0x0000D2CB
	private void method_2()
	{
		if (this.IsAdded)
		{
			Class657.smethod_2();
			this.FoundIn = Class298.smethod_2("added");
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x060015EA RID: 5610 RVA: 0x0000F0EB File Offset: 0x0000D2EB
	// (set) Token: 0x060015EB RID: 5611 RVA: 0x0000F0F3 File Offset: 0x0000D2F3
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			this.method_3();
			base.method_0("Name");
		}
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x00065CD8 File Offset: 0x00063ED8
	public void method_3()
	{
		GClass181.Struct180 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass181_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass181.Struct180>(ref @struct);
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x060015ED RID: 5613 RVA: 0x0000F10E File Offset: 0x0000D30E
	// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000F116 File Offset: 0x0000D316
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

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x060015EF RID: 5615 RVA: 0x0000F11F File Offset: 0x0000D31F
	// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000F127 File Offset: 0x0000D327
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

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0000F13C File Offset: 0x0000D33C
	// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000F144 File Offset: 0x0000D344
	public string ExeDir
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("ExeDir");
		}
	}

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0000F159 File Offset: 0x0000D359
	// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000F161 File Offset: 0x0000D361
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

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x060015F5 RID: 5621 RVA: 0x0000F176 File Offset: 0x0000D376
	// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0000F17E File Offset: 0x0000D37E
	public string FoundIn
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("FoundIn");
		}
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x0000F193 File Offset: 0x0000D393
	private void method_4(object object_0)
	{
		Class657.smethod_3(this);
		this.IsAdded = true;
	}

	// Token: 0x04000E81 RID: 3713
	private bool bool_0;

	// Token: 0x04000E82 RID: 3714
	private string string_0;

	// Token: 0x04000E83 RID: 3715
	private GClass280 gclass280_0;

	// Token: 0x04000E84 RID: 3716
	private string string_1;

	// Token: 0x04000E85 RID: 3717
	private string string_2;

	// Token: 0x04000E86 RID: 3718
	private BitmapSource bitmapSource_0;

	// Token: 0x04000E87 RID: 3719
	private string string_3;

	// Token: 0x0200034D RID: 845
	[StructLayout(LayoutKind.Auto)]
	private struct Struct180 : IAsyncStateMachine
	{
		// Token: 0x060015F8 RID: 5624 RVA: 0x00065D10 File Offset: 0x00063F10
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass181 gclass = this.gclass181_0;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = Class602.smethod_0(gclass.Name.EndsWith(".exe") ? gclass.Name.Replace(".exe", string.Empty) : gclass.Name).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass181.Struct180>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				string result = awaiter.GetResult();
				if (result != null)
				{
					gclass.Icon = Class765.smethod_5(result);
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

		// Token: 0x060015F9 RID: 5625 RVA: 0x0000F1A2 File Offset: 0x0000D3A2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000E88 RID: 3720
		public int int_0;

		// Token: 0x04000E89 RID: 3721
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000E8A RID: 3722
		public GClass181 gclass181_0;

		// Token: 0x04000E8B RID: 3723
		private TaskAwaiter<string> taskAwaiter_0;
	}
}
