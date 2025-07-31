using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using FamFamFam.Flags.Wpf;

// Token: 0x020006BD RID: 1725
internal sealed class Class533 : GClass162
{
	// Token: 0x17000727 RID: 1831
	// (get) Token: 0x06002B89 RID: 11145 RVA: 0x0001C1B6 File Offset: 0x0001A3B6
	// (set) Token: 0x06002B8A RID: 11146 RVA: 0x0001C1BE File Offset: 0x0001A3BE
	public string City
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000728 RID: 1832
	// (get) Token: 0x06002B8B RID: 11147 RVA: 0x0001C1C7 File Offset: 0x0001A3C7
	// (set) Token: 0x06002B8C RID: 11148 RVA: 0x0001C1CF File Offset: 0x0001A3CF
	public string Country
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000729 RID: 1833
	// (get) Token: 0x06002B8D RID: 11149 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
	public BitmapSource Icon
	{
		get
		{
			if (this.bitmapSource_0 == null)
			{
				this.bitmapSource_0 = (new CountryIdToFlagImageSourceConverter().Convert(this.Country.ToLower(), null, null, null) as BitmapImage);
			}
			return this.bitmapSource_0;
		}
	}

	// Token: 0x1700072A RID: 1834
	// (get) Token: 0x06002B8E RID: 11150 RVA: 0x0001C20B File Offset: 0x0001A40B
	// (set) Token: 0x06002B8F RID: 11151 RVA: 0x0001C213 File Offset: 0x0001A413
	public string IP
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			if (this.string_2 != null)
			{
				this.method_2();
			}
		}
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x000A7154 File Offset: 0x000A5354
	private void method_2()
	{
		Class533.Struct460 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class533_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class533.Struct460>(ref @struct);
	}

	// Token: 0x1700072B RID: 1835
	// (get) Token: 0x06002B91 RID: 11153 RVA: 0x0001C22A File Offset: 0x0001A42A
	// (set) Token: 0x06002B92 RID: 11154 RVA: 0x0001C232 File Offset: 0x0001A432
	public int Port
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x1700072C RID: 1836
	// (get) Token: 0x06002B93 RID: 11155 RVA: 0x0001C23B File Offset: 0x0001A43B
	// (set) Token: 0x06002B94 RID: 11156 RVA: 0x0001C243 File Offset: 0x0001A443
	public string Ping
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
		[CompilerGenerated]
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x000A718C File Offset: 0x000A538C
	private void method_3()
	{
		this.Ping = ((int)Class168.smethod_0(this.IP)).ToString() + " ms";
		base.method_0("Ping");
	}

	// Token: 0x04001C4A RID: 7242
	private string string_0;

	// Token: 0x04001C4B RID: 7243
	private string string_1;

	// Token: 0x04001C4C RID: 7244
	private BitmapSource bitmapSource_0;

	// Token: 0x04001C4D RID: 7245
	private string string_2;

	// Token: 0x04001C4E RID: 7246
	private int int_0;

	// Token: 0x04001C4F RID: 7247
	private string string_3;

	// Token: 0x020006BE RID: 1726
	[StructLayout(LayoutKind.Auto)]
	private struct Struct460 : IAsyncStateMachine
	{
		// Token: 0x06002B96 RID: 11158 RVA: 0x000A71CC File Offset: 0x000A53CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class533 @object = this.class533_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_3)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class533.Struct460>(ref awaiter, ref this);
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

		// Token: 0x06002B97 RID: 11159 RVA: 0x0001C24C File Offset: 0x0001A44C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C50 RID: 7248
		public int int_0;

		// Token: 0x04001C51 RID: 7249
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C52 RID: 7250
		public Class533 class533_0;

		// Token: 0x04001C53 RID: 7251
		private TaskAwaiter taskAwaiter_0;
	}
}
