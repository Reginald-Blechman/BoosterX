using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using ns0;

// Token: 0x020004F8 RID: 1272
internal sealed class Class520 : GClass162
{
	// Token: 0x06002038 RID: 8248 RVA: 0x00082C60 File Offset: 0x00080E60
	public Class520()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x000078FD File Offset: 0x00005AFD
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("ColChanged");
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x0600203A RID: 8250 RVA: 0x0001554A File Offset: 0x0001374A
	// (set) Token: 0x0600203B RID: 8251 RVA: 0x00015552 File Offset: 0x00013752
	public ObservableCollection<Class493> GroupServices
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("GroupServices");
		}
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x0600203C RID: 8252 RVA: 0x00015567 File Offset: 0x00013767
	// (set) Token: 0x0600203D RID: 8253 RVA: 0x0001556F File Offset: 0x0001376F
	public ObservableCollection<GClass184> AllServices
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("AllServices");
		}
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x00015584 File Offset: 0x00013784
	public void method_2()
	{
		this.AllServices.Clear();
		this.GroupServices.Clear();
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x0600203F RID: 8255 RVA: 0x00082CB8 File Offset: 0x00080EB8
	// (set) Token: 0x06002040 RID: 8256 RVA: 0x0001559C File Offset: 0x0001379C
	public bool HideManualServicesIsChecked
	{
		get
		{
			bool valueOrDefault = Class551.class753_0.method_42().GetValueOrDefault();
			this.method_3(valueOrDefault);
			return valueOrDefault;
		}
		set
		{
			Class551.class753_0.method_43(new bool?(value));
			Class589.smethod_1(true);
			base.method_0("HideManualServicesIsChecked");
		}
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x06002041 RID: 8257 RVA: 0x000155C1 File Offset: 0x000137C1
	// (set) Token: 0x06002042 RID: 8258 RVA: 0x000155C9 File Offset: 0x000137C9
	public string HideManualServicesStatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("HideManualServicesStatusText");
		}
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x06002043 RID: 8259 RVA: 0x000155DE File Offset: 0x000137DE
	// (set) Token: 0x06002044 RID: 8260 RVA: 0x000155E6 File Offset: 0x000137E6
	public SolidColorBrush HideManualServicesStatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("HideManualServicesStatusColor");
		}
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x06002045 RID: 8261 RVA: 0x000155FB File Offset: 0x000137FB
	// (set) Token: 0x06002046 RID: 8262 RVA: 0x00015603 File Offset: 0x00013803
	public double HideManualServicesStatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("HideManualServicesStatusOpacity");
		}
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x00082CE0 File Offset: 0x00080EE0
	private void method_3(bool bool_0)
	{
		Class520.Struct336 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class520_0 = this;
		@struct.bool_0 = bool_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class520.Struct336>(ref @struct);
	}

	// Token: 0x0400156F RID: 5487
	public ObservableCollection<Class493> observableCollection_0 = new ObservableCollection<Class493>();

	// Token: 0x04001570 RID: 5488
	public ObservableCollection<GClass184> observableCollection_1 = new ObservableCollection<GClass184>();

	// Token: 0x04001571 RID: 5489
	private string string_0 = string.Empty;

	// Token: 0x04001572 RID: 5490
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04001573 RID: 5491
	private double double_0;

	// Token: 0x020004F9 RID: 1273
	[StructLayout(LayoutKind.Auto)]
	private struct Struct336 : IAsyncStateMachine
	{
		// Token: 0x06002048 RID: 8264 RVA: 0x00082D20 File Offset: 0x00080F20
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class520 @class = this.class520_0;
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
					goto IL_14F;
				}
				IL_56:
				if (@class.HideManualServicesStatusOpacity == 0.0)
				{
					@class.HideManualServicesStatusColor = (this.bool_0 ? dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd : dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
					@class.HideManualServicesStatusText = (this.bool_0 ? Class298.smethod_2("enabled") : Class298.smethod_2("disabled"));
					goto IL_156;
				}
				@class.HideManualServicesStatusOpacity -= 0.1;
				if (@class.HideManualServicesStatusOpacity < 0.05)
				{
					@class.HideManualServicesStatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class520.Struct336>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_14F:
				awaiter.GetResult();
				IL_156:
				if (@class.HideManualServicesStatusOpacity != 1.0)
				{
					@class.HideManualServicesStatusOpacity += 0.13333333333333333;
					if (@class.HideManualServicesStatusOpacity > 0.95)
					{
						@class.HideManualServicesStatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_14F;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class520.Struct336>(ref awaiter, ref this);
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

		// Token: 0x06002049 RID: 8265 RVA: 0x00015618 File Offset: 0x00013818
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001574 RID: 5492
		public int int_0;

		// Token: 0x04001575 RID: 5493
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001576 RID: 5494
		public Class520 class520_0;

		// Token: 0x04001577 RID: 5495
		public bool bool_0;

		// Token: 0x04001578 RID: 5496
		private TaskAwaiter taskAwaiter_0;
	}
}
