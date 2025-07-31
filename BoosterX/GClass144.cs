using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x0200016E RID: 366
public sealed class GClass144 : GClass143, GInterface6
{
	// Token: 0x06000A4C RID: 2636 RVA: 0x000083B1 File Offset: 0x000065B1
	internal GClass144(GClass11 gclass11_1) : base(gclass11_1)
	{
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x000083BA File Offset: 0x000065BA
	protected override string vmethod_0()
	{
		return "files";
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00046C28 File Offset: 0x00044E28
	public Task<List<GClass34>> imethod_0()
	{
		GClass144.Struct75 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<GClass34>>.Create();
		@struct.gclass144_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass144.Struct75>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00046C6C File Offset: 0x00044E6C
	public Task<GClass34> imethod_1(string string_0)
	{
		GClass144.Struct74 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass34>.Create();
		@struct.gclass144_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass144.Struct74>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x00046CB8 File Offset: 0x00044EB8
	public Task<string> imethod_2(string string_0)
	{
		GClass144.Struct72 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.gclass144_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass144.Struct72>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00046D04 File Offset: 0x00044F04
	public Task<GClass34> imethod_3(string string_0)
	{
		GClass144.Struct73 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass34>.Create();
		@struct.gclass144_0 = this;
		@struct.string_0 = string_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass144.Struct73>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00046D50 File Offset: 0x00044F50
	public Task<GClass34> imethod_4(string string_0, string string_1 = "fine-tune")
	{
		GClass144.Struct76 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<GClass34>.Create();
		@struct.gclass144_0 = this;
		@struct.string_1 = string_0;
		@struct.string_0 = string_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass144.Struct76>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0200016F RID: 367
	[StructLayout(LayoutKind.Auto)]
	private struct Struct72 : IAsyncStateMachine
	{
		// Token: 0x06000A53 RID: 2643 RVA: 0x00046DA4 File Offset: 0x00044FA4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass144 gclass = this.gclass144_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_4(gclass.method_0() + "/" + this.string_0 + "/content", null, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, GClass144.Struct72>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
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

		// Token: 0x06000A54 RID: 2644 RVA: 0x000083C2 File Offset: 0x000065C2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006D6 RID: 1750
		public int int_0;

		// Token: 0x040006D7 RID: 1751
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x040006D8 RID: 1752
		public GClass144 gclass144_0;

		// Token: 0x040006D9 RID: 1753
		public string string_0;

		// Token: 0x040006DA RID: 1754
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x02000170 RID: 368
	[StructLayout(LayoutKind.Auto)]
	private struct Struct73 : IAsyncStateMachine
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x00046E7C File Offset: 0x0004507C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass144 gclass = this.gclass144_0;
			GClass34 result;
			try
			{
				TaskAwaiter<GClass34> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_9<GClass34>(gclass.method_0() + "/" + this.string_0, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass34>, GClass144.Struct73>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass34>);
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

		// Token: 0x06000A56 RID: 2646 RVA: 0x000083D0 File Offset: 0x000065D0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006DB RID: 1755
		public int int_0;

		// Token: 0x040006DC RID: 1756
		public AsyncTaskMethodBuilder<GClass34> asyncTaskMethodBuilder_0;

		// Token: 0x040006DD RID: 1757
		public GClass144 gclass144_0;

		// Token: 0x040006DE RID: 1758
		public string string_0;

		// Token: 0x040006DF RID: 1759
		private TaskAwaiter<GClass34> taskAwaiter_0;
	}

	// Token: 0x02000171 RID: 369
	[StructLayout(LayoutKind.Auto)]
	private struct Struct74 : IAsyncStateMachine
	{
		// Token: 0x06000A57 RID: 2647 RVA: 0x00046F4C File Offset: 0x0004514C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass144 gclass = this.gclass144_0;
			GClass34 result;
			try
			{
				TaskAwaiter<GClass34> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_7<GClass34>(gclass.method_0() + "/" + this.string_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass34>, GClass144.Struct74>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass34>);
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

		// Token: 0x06000A58 RID: 2648 RVA: 0x000083DE File Offset: 0x000065DE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006E0 RID: 1760
		public int int_0;

		// Token: 0x040006E1 RID: 1761
		public AsyncTaskMethodBuilder<GClass34> asyncTaskMethodBuilder_0;

		// Token: 0x040006E2 RID: 1762
		public GClass144 gclass144_0;

		// Token: 0x040006E3 RID: 1763
		public string string_0;

		// Token: 0x040006E4 RID: 1764
		private TaskAwaiter<GClass34> taskAwaiter_0;
	}

	// Token: 0x02000172 RID: 370
	[StructLayout(LayoutKind.Auto)]
	private struct Struct75 : IAsyncStateMachine
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x0004701C File Offset: 0x0004521C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass144 gclass = this.gclass144_0;
			List<GClass34> list_;
			try
			{
				TaskAwaiter<GClass144.Class204> awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_7<GClass144.Class204>(null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass144.Class204>, GClass144.Struct75>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass144.Class204>);
					this.int_0 = -1;
				}
				list_ = awaiter.GetResult().List_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(list_);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000083EC File Offset: 0x000065EC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006E5 RID: 1765
		public int int_0;

		// Token: 0x040006E6 RID: 1766
		public AsyncTaskMethodBuilder<List<GClass34>> asyncTaskMethodBuilder_0;

		// Token: 0x040006E7 RID: 1767
		public GClass144 gclass144_0;

		// Token: 0x040006E8 RID: 1768
		private TaskAwaiter<GClass144.Class204> taskAwaiter_0;
	}

	// Token: 0x02000173 RID: 371
	[StructLayout(LayoutKind.Auto)]
	private struct Struct76 : IAsyncStateMachine
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x000470D8 File Offset: 0x000452D8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass144 gclass = this.gclass144_0;
			GClass34 result;
			try
			{
				TaskAwaiter<GClass34> awaiter;
				if (num != 0)
				{
					MultipartFormDataContent object_ = new MultipartFormDataContent
					{
						{
							new StringContent(this.string_0),
							"purpose"
						},
						{
							new ByteArrayContent(File.ReadAllBytes(this.string_1)),
							"file",
							Path.GetFileName(this.string_1)
						}
					};
					awaiter = gclass.method_8<GClass34>(gclass.method_0(), object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass34>, GClass144.Struct76>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GClass34>);
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

		// Token: 0x06000A5C RID: 2652 RVA: 0x000083FA File Offset: 0x000065FA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040006E9 RID: 1769
		public int int_0;

		// Token: 0x040006EA RID: 1770
		public AsyncTaskMethodBuilder<GClass34> asyncTaskMethodBuilder_0;

		// Token: 0x040006EB RID: 1771
		public string string_0;

		// Token: 0x040006EC RID: 1772
		public string string_1;

		// Token: 0x040006ED RID: 1773
		public GClass144 gclass144_0;

		// Token: 0x040006EE RID: 1774
		private TaskAwaiter<GClass34> taskAwaiter_0;
	}

	// Token: 0x02000174 RID: 372
	private sealed class Class204 : GClass33
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00008408 File Offset: 0x00006608
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00008410 File Offset: 0x00006610
		[JsonProperty("data")]
		public List<GClass34> List_0
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00008419 File Offset: 0x00006619
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00008421 File Offset: 0x00006621
		[JsonProperty("object")]
		public string String_4
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		// Token: 0x040006EF RID: 1775
		private List<GClass34> list_0;

		// Token: 0x040006F0 RID: 1776
		private string string_4;
	}
}
