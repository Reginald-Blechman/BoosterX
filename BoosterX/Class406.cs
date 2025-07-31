using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ns0;

// Token: 0x0200035B RID: 859
internal sealed class Class406
{
	// Token: 0x06001639 RID: 5689 RVA: 0x00066640 File Offset: 0x00064840
	private Class406()
	{
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x0000F3CD File Offset: 0x0000D5CD
	public static Class406 smethod_0()
	{
		if (Class406.class406_0 == null)
		{
			Class406.class406_0 = new Class406();
		}
		return Class406.class406_0;
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x000667E4 File Offset: 0x000649E4
	public Task<object> method_0(Type type_1)
	{
		Class406.Struct186 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<object>.Create();
		@struct.class406_0 = this;
		@struct.type_0 = type_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class406.Struct186>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x00066830 File Offset: 0x00064A30
	public Task<object> method_1(Type type_1)
	{
		Class406.Struct188 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<object>.Create();
		@struct.class406_0 = this;
		@struct.type_0 = type_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class406.Struct188>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0000F3E5 File Offset: 0x0000D5E5
	public bool method_2(Type type_1)
	{
		return this.type_0 == type_1;
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x0006687C File Offset: 0x00064A7C
	public Task method_3(Type type_1)
	{
		Class406.Struct190 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class406_0 = this;
		@struct.type_0 = type_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class406.Struct190>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x000668C8 File Offset: 0x00064AC8
	public void method_4(Type type_1, Frame frame_5)
	{
		Class406.Struct187 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class406_0 = this;
		@struct.type_0 = type_1;
		@struct.frame_0 = frame_5;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class406.Struct187>(ref @struct);
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x0000F3F3 File Offset: 0x0000D5F3
	public void method_5(Type type_1)
	{
		new dje_zKX6CYYJVP8WMPY4AAJAMKWET9RMFXW4UYRK49Q73_ejd(typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd)).Show();
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x00066910 File Offset: 0x00064B10
	public Window method_6(Type type_1)
	{
		Class406.Class410 @class = new Class406.Class410();
		@class.type_0 = type_1;
		return Application.Current.Dispatcher.Invoke<Window>(new Func<Window>(@class.method_0));
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0000F409 File Offset: 0x0000D609
	public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd method_7()
	{
		return Application.Current.Dispatcher.Invoke<dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd>(new Func<dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd>(this.method_9));
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x00066948 File Offset: 0x00064B48
	public Task method_8()
	{
		Class406.Struct189 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class406_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class406.Struct189>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x0000F426 File Offset: 0x0000D626
	private dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd method_9()
	{
		if (this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 != null)
		{
			return this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
		}
		this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0 = (Window.GetWindow(this.frame_0) as dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd);
		return this.dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0006698C File Offset: 0x00064B8C
	private void method_10()
	{
		this.list_2.Clear();
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
		catch
		{
		}
		Class605.smethod_1();
	}

	// Token: 0x04000EAC RID: 3756
	private static Class406 class406_0;

	// Token: 0x04000EAD RID: 3757
	public List<Type> list_0 = new List<Type>
	{
		typeof(dje_zZA5YXNN85RQEDRBPZE7A5M2UPE75H2DGEEV285VQRKVHWGHJYZ39FVL9MBDA_ejd),
		typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd),
		typeof(dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd),
		typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd),
		typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P8GKSQ477YXNFFJYAV9GYM8S278FJ3VXSLSUGWV2W_ejd),
		typeof(dje_zCXVRLC9JYDM7HBMZF3PKYAVM45FPRY2MWDPWDCXCHPM5LF6VDHTFMWKX4XGQ_ejd),
		typeof(dje_zY8TJ7HVSSL9J9VQH6V7EV8TJKMJV32VYYNUD95ZXTD6G6DK4JKGTBNA9KKRA_ejd),
		typeof(dje_zRLTJAE4HM9QEZA4XCZRB8CQJP23F3H6N7P96KCK67U3FNVEKLZBJJQB3ZPVQ_ejd),
		typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd),
		typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd),
		typeof(dje_zDYC5LKZ8NR7VV7RQQRXGJ8VMFWBXH8WSRH43R9UQZ8PRK2LJFBTWQ_ejd),
		typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd),
		typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd),
		typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TW4LTJ4MDTW787U8ZU6EPEUUSCU2XC89GWA_ejd),
		typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd),
		typeof(dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd),
		typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TJT6P4HVXCZBEX5BLD2JKUFM4PCTXZ75CCLQQGATQ_ejd)
	};

	// Token: 0x04000EAE RID: 3758
	public List<Type> list_1 = new List<Type>
	{
		typeof(dje_zJ9NUKRLGXC7JDT9ZUAF84NEVZ6WFZLVPU4EHJ856D2FJFNCVR2P34_ejd),
		typeof(dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd),
		typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd),
		typeof(dje_zDS9TTFNE363ZWXZZNLVGXCSGVEH3WZ97G35688NSQDTUU67X396394XZJURA_ejd),
		typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd),
		typeof(dje_zWT2KUZCDV7SNNFXMRLPD6XNJYLB3P7H4UXDGKCFV223H5EQ_ejd)
	};

	// Token: 0x04000EAF RID: 3759
	public List<Page> list_2 = new List<Page>();

	// Token: 0x04000EB0 RID: 3760
	public Frame frame_0;

	// Token: 0x04000EB1 RID: 3761
	public dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd dje_zWUVHZFHNQBTDWQSSNA622NWNDWYQZB89AVKRQLZ9R6A9VX2_ejd_0;

	// Token: 0x04000EB2 RID: 3762
	public dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd_0;

	// Token: 0x04000EB3 RID: 3763
	public Frame frame_1;

	// Token: 0x04000EB4 RID: 3764
	public Frame frame_2;

	// Token: 0x04000EB5 RID: 3765
	public Frame frame_3;

	// Token: 0x04000EB6 RID: 3766
	public Frame frame_4;

	// Token: 0x04000EB7 RID: 3767
	public Type type_0;

	// Token: 0x04000EB8 RID: 3768
	private Page page_0;

	// Token: 0x04000EB9 RID: 3769
	public bool bool_0;

	// Token: 0x0200035C RID: 860
	private sealed class Class407
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x000669C8 File Offset: 0x00064BC8
		internal object method_0()
		{
			IEnumerable<Page> list_ = this.class406_0.list_2;
			Func<Page, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<Page, bool>(this.method_1));
			}
			Page page = list_.FirstOrDefault(predicate);
			if (page == null)
			{
				return null;
			}
			return page.DataContext;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0000F453 File Offset: 0x0000D653
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000EBA RID: 3770
		public Class406 class406_0;

		// Token: 0x04000EBB RID: 3771
		public Type type_0;

		// Token: 0x04000EBC RID: 3772
		public Func<Page, bool> func_0;
	}

	// Token: 0x0200035D RID: 861
	[StructLayout(LayoutKind.Auto)]
	private struct Struct186 : IAsyncStateMachine
	{
		// Token: 0x06001649 RID: 5705 RVA: 0x00066A10 File Offset: 0x00064C10
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			object result;
			try
			{
				TaskAwaiter<object> awaiter;
				if (num != 0)
				{
					Class406.Class407 @class = new Class406.Class407();
					@class.class406_0 = this.class406_0;
					@class.type_0 = this.type_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<object>(new Func<object>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<object>, Class406.Struct186>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<object>);
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

		// Token: 0x0600164A RID: 5706 RVA: 0x0000F466 File Offset: 0x0000D666
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EBD RID: 3773
		public int int_0;

		// Token: 0x04000EBE RID: 3774
		public AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder_0;

		// Token: 0x04000EBF RID: 3775
		public Class406 class406_0;

		// Token: 0x04000EC0 RID: 3776
		public Type type_0;

		// Token: 0x04000EC1 RID: 3777
		private TaskAwaiter<object> taskAwaiter_0;
	}

	// Token: 0x0200035E RID: 862
	[StructLayout(LayoutKind.Auto)]
	private struct Struct187 : IAsyncStateMachine
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x00066AF4 File Offset: 0x00064CF4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class406 @class = this.class406_0;
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
						goto IL_18B;
					}
					this.class409_0 = new Class406.Class409();
					this.class409_0.type_0 = this.type_0;
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_16(this.frame_0, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class406.Struct187>(ref awaiter, ref this);
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
				FlowDirection flowDirection = Class374.smethod_0().method_2();
				Page page = @class.list_2.FirstOrDefault(new Func<Page, bool>(this.class409_0.method_0));
				if (page != null)
				{
					this.frame_0.NavigationService.Navigate(page);
					page.FlowDirection = flowDirection;
				}
				else
				{
					@class.page_0 = (Page)Activator.CreateInstance(this.class409_0.type_0);
					@class.page_0.FlowDirection = flowDirection;
					@class.list_2.Add(@class.page_0);
					this.frame_0.NavigationService.Navigate(@class.page_0);
				}
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_21(this.frame_0, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class406.Struct187>(ref awaiter, ref this);
					return;
				}
				IL_18B:
				awaiter.GetResult();
				if (this.frame_0 == @class.frame_3)
				{
					@class.type_0 = this.class409_0.type_0;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class409_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.class409_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0000F474 File Offset: 0x0000D674
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EC2 RID: 3778
		public int int_0;

		// Token: 0x04000EC3 RID: 3779
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000EC4 RID: 3780
		public Type type_0;

		// Token: 0x04000EC5 RID: 3781
		public Frame frame_0;

		// Token: 0x04000EC6 RID: 3782
		public Class406 class406_0;

		// Token: 0x04000EC7 RID: 3783
		private Class406.Class409 class409_0;

		// Token: 0x04000EC8 RID: 3784
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200035F RID: 863
	private sealed class Class408
	{
		// Token: 0x0600164E RID: 5710 RVA: 0x00066D0C File Offset: 0x00064F0C
		internal void method_0()
		{
			IEnumerable<Page> list_ = this.class406_0.list_2;
			Func<Page, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<Page, bool>(this.method_1));
			}
			if (list_.Any(predicate))
			{
				List<Page> list_2 = this.class406_0.list_2;
				IEnumerable<Page> list_3 = this.class406_0.list_2;
				Func<Page, bool> predicate2;
				if ((predicate2 = this.func_1) == null)
				{
					predicate2 = (this.func_1 = new Func<Page, bool>(this.method_2));
				}
				list_2.Remove(list_3.FirstOrDefault(predicate2));
			}
			this.class406_0.list_2.Add((Page)Activator.CreateInstance(this.type_0));
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0000F482 File Offset: 0x0000D682
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0000F482 File Offset: 0x0000D682
		internal bool method_2(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000EC9 RID: 3785
		public Class406 class406_0;

		// Token: 0x04000ECA RID: 3786
		public Type type_0;

		// Token: 0x04000ECB RID: 3787
		public Func<Page, bool> func_0;

		// Token: 0x04000ECC RID: 3788
		public Func<Page, bool> func_1;
	}

	// Token: 0x02000360 RID: 864
	[StructLayout(LayoutKind.Auto)]
	private struct Struct188 : IAsyncStateMachine
	{
		// Token: 0x06001651 RID: 5713 RVA: 0x00066DAC File Offset: 0x00064FAC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			object result;
			try
			{
				TaskAwaiter<Page> awaiter;
				if (num != 0)
				{
					Class406.Class411 @class = new Class406.Class411();
					@class.class406_0 = this.class406_0;
					@class.type_0 = this.type_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync<Page>(new Func<Page>(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Page>, Class406.Struct188>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Page>);
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

		// Token: 0x06001652 RID: 5714 RVA: 0x0000F495 File Offset: 0x0000D695
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000ECD RID: 3789
		public int int_0;

		// Token: 0x04000ECE RID: 3790
		public AsyncTaskMethodBuilder<object> asyncTaskMethodBuilder_0;

		// Token: 0x04000ECF RID: 3791
		public Class406 class406_0;

		// Token: 0x04000ED0 RID: 3792
		public Type type_0;

		// Token: 0x04000ED1 RID: 3793
		private TaskAwaiter<Page> taskAwaiter_0;
	}

	// Token: 0x02000361 RID: 865
	private sealed class Class409
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x0000F4A3 File Offset: 0x0000D6A3
		internal bool method_0(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000ED2 RID: 3794
		public Type type_0;
	}

	// Token: 0x02000362 RID: 866
	[StructLayout(LayoutKind.Auto)]
	private struct Struct189 : IAsyncStateMachine
	{
		// Token: 0x06001655 RID: 5717 RVA: 0x00066E90 File Offset: 0x00065090
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class406 @object = this.class406_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_10)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class406.Struct189>(ref awaiter, ref this);
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

		// Token: 0x06001656 RID: 5718 RVA: 0x0000F4B6 File Offset: 0x0000D6B6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000ED3 RID: 3795
		public int int_0;

		// Token: 0x04000ED4 RID: 3796
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000ED5 RID: 3797
		public Class406 class406_0;

		// Token: 0x04000ED6 RID: 3798
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000363 RID: 867
	private sealed class Class410
	{
		// Token: 0x06001658 RID: 5720 RVA: 0x00066F50 File Offset: 0x00065150
		internal Window method_0()
		{
			foreach (Window window in Application.Current.Windows.Cast<Window>())
			{
				if (window.GetType() == this.type_0)
				{
					return window;
				}
			}
			return null;
		}

		// Token: 0x04000ED7 RID: 3799
		public Type type_0;
	}

	// Token: 0x02000364 RID: 868
	private sealed class Class411
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x00066FBC File Offset: 0x000651BC
		internal Page method_0()
		{
			IEnumerable<Page> list_ = this.class406_0.list_2;
			Func<Page, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<Page, bool>(this.method_1));
			}
			Page page = list_.FirstOrDefault(predicate);
			if (page == null)
			{
				page = (Page)Activator.CreateInstance(this.type_0);
				this.class406_0.list_2.Add(page);
			}
			return page;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		internal bool method_1(Page page_0)
		{
			return page_0.GetType() == this.type_0;
		}

		// Token: 0x04000ED8 RID: 3800
		public Class406 class406_0;

		// Token: 0x04000ED9 RID: 3801
		public Type type_0;

		// Token: 0x04000EDA RID: 3802
		public Func<Page, bool> func_0;
	}

	// Token: 0x02000365 RID: 869
	[StructLayout(LayoutKind.Auto)]
	private struct Struct190 : IAsyncStateMachine
	{
		// Token: 0x0600165C RID: 5724 RVA: 0x00067020 File Offset: 0x00065220
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Class406.Class408 @class = new Class406.Class408();
					@class.class406_0 = this.class406_0;
					@class.type_0 = this.type_0;
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@class.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class406.Struct190>(ref awaiter, ref this);
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

		// Token: 0x0600165D RID: 5725 RVA: 0x0000F4D7 File Offset: 0x0000D6D7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000EDB RID: 3803
		public int int_0;

		// Token: 0x04000EDC RID: 3804
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000EDD RID: 3805
		public Class406 class406_0;

		// Token: 0x04000EDE RID: 3806
		public Type type_0;

		// Token: 0x04000EDF RID: 3807
		private TaskAwaiter taskAwaiter_0;
	}
}
