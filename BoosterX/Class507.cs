using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ns0;

// Token: 0x020002D7 RID: 727
internal sealed class Class507 : GClass162
{
	// Token: 0x06001346 RID: 4934 RVA: 0x0000DACC File Offset: 0x0000BCCC
	public Class507()
	{
		this.method_2();
	}

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x06001347 RID: 4935 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
	public ObservableCollection<UserControl> Checkers
	{
		[CompilerGenerated]
		get
		{
			return this.observableCollection_0;
		}
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x06001348 RID: 4936 RVA: 0x0000DAFB File Offset: 0x0000BCFB
	// (set) Token: 0x06001349 RID: 4937 RVA: 0x0000DB03 File Offset: 0x0000BD03
	public Visibility StatusGoodVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("StatusGoodVisibility");
		}
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x0600134A RID: 4938 RVA: 0x0000DB18 File Offset: 0x0000BD18
	// (set) Token: 0x0600134B RID: 4939 RVA: 0x0000DB20 File Offset: 0x0000BD20
	public Visibility StatusAttentionVisibility
	{
		get
		{
			return this.visibility_1;
		}
		set
		{
			this.visibility_1 = value;
			base.method_0("StatusAttentionVisibility");
		}
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x0600134C RID: 4940 RVA: 0x00060F20 File Offset: 0x0005F120
	public GClass280 GoBackCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(Class507.Class343.class343_0.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x0600134D RID: 4941 RVA: 0x00060F68 File Offset: 0x0005F168
	public GClass280 UpdateCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_4), null));
			}
			return result;
		}
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00060F9C File Offset: 0x0005F19C
	private void method_2()
	{
		this.Checkers.Add(new dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd());
		this.Checkers.Add(new dje_z2JLZCGZ3QXEER9XV34JWZVWRQJNTUTLFJF8HLJEVV6Y93Y5NX8GDXSFE2Y4GSASABBJA8N8LZCCJQC2_ejd());
		for (int i = 1; i < this.Checkers.Count; i++)
		{
			this.Checkers[i].Margin = new Thickness(0.0, 20.0, 0.0, 0.0);
		}
		this.method_3();
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x00061020 File Offset: 0x0005F220
	private void method_3()
	{
		if (this.Checkers.OfType<GInterface0>().Any(new Func<GInterface0, bool>(Class507.Class343.class343_0.method_1)))
		{
			this.StatusAttentionVisibility = Visibility.Visible;
			this.StatusGoodVisibility = Visibility.Collapsed;
			return;
		}
		this.StatusAttentionVisibility = Visibility.Collapsed;
		this.StatusGoodVisibility = Visibility.Visible;
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x0006107C File Offset: 0x0005F27C
	private void method_4(object object_0)
	{
		Class507.Struct161 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class507_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class507.Struct161>(ref @struct);
	}

	// Token: 0x04000C0B RID: 3083
	private readonly ObservableCollection<UserControl> observableCollection_0 = new ObservableCollection<UserControl>();

	// Token: 0x04000C0C RID: 3084
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x04000C0D RID: 3085
	private Visibility visibility_1 = Visibility.Collapsed;

	// Token: 0x04000C0E RID: 3086
	private GClass280 gclass280_0;

	// Token: 0x04000C0F RID: 3087
	private bool bool_0;

	// Token: 0x04000C10 RID: 3088
	private GClass280 gclass280_1;

	// Token: 0x020002D8 RID: 728
	[StructLayout(LayoutKind.Auto)]
	private struct Struct161 : IAsyncStateMachine
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x000610B4 File Offset: 0x0005F2B4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class507 @class = this.class507_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (@class.bool_0)
					{
						goto IL_B2;
					}
					@class.bool_0 = true;
					@class.Checkers.Clear();
					@class.method_2();
					awaiter = Task.Delay(3000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class507.Struct161>(ref awaiter, ref this);
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
				@class.bool_0 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_B2:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0000DB35 File Offset: 0x0000BD35
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C11 RID: 3089
		public int int_0;

		// Token: 0x04000C12 RID: 3090
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000C13 RID: 3091
		public Class507 class507_0;

		// Token: 0x04000C14 RID: 3092
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002D9 RID: 729
	[Serializable]
	private sealed class Class343
	{
		// Token: 0x06001355 RID: 4949 RVA: 0x00007C85 File Offset: 0x00005E85
		internal void method_0(object object_0)
		{
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0000DB4F File Offset: 0x0000BD4F
		internal bool method_1(GInterface0 ginterface0_0)
		{
			return ginterface0_0.imethod_0();
		}

		// Token: 0x04000C15 RID: 3093
		public static readonly Class507.Class343 class343_0 = new Class507.Class343();

		// Token: 0x04000C16 RID: 3094
		public static Action<object> action_0;

		// Token: 0x04000C17 RID: 3095
		public static Func<GInterface0, bool> func_0;
	}
}
