using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

// Token: 0x020003E0 RID: 992
public sealed class GClass134
{
	// Token: 0x060019DD RID: 6621 RVA: 0x000116C8 File Offset: 0x0000F8C8
	public static GClass134.GClass183 smethod_0(bool bool_2)
	{
		if (!GClass134.bool_0 || bool_2)
		{
			GClass279.smethod_0().method_17<Class798>();
			GClass134.bool_1 = false;
			GClass134.bool_0 = true;
			GClass134.smethod_1();
		}
		return GClass134.gclass183_0;
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x00071464 File Offset: 0x0006F664
	public static void smethod_1()
	{
		GClass134.Struct240 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass134.Struct240>(ref @struct);
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x00071494 File Offset: 0x0006F694
	public static Task smethod_2()
	{
		GClass134.Struct242 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass134.Struct242>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x000714D0 File Offset: 0x0006F6D0
	public static Task smethod_3()
	{
		GClass134.Struct241 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass134.Struct241>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0007150C File Offset: 0x0006F70C
	public static Task smethod_4()
	{
		GClass134.Struct239 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass134.Struct239>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x00071548 File Offset: 0x0006F748
	public static Task smethod_5()
	{
		GClass134.Struct238 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass134.Struct238>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001103 RID: 4355
	private static GClass134.GClass183 gclass183_0 = new GClass134.GClass183();

	// Token: 0x04001104 RID: 4356
	private static bool bool_0 = false;

	// Token: 0x04001105 RID: 4357
	private static bool bool_1 = false;

	// Token: 0x04001106 RID: 4358
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x020003E1 RID: 993
	private sealed class Class450
	{
		// Token: 0x060019E4 RID: 6628 RVA: 0x000116F6 File Offset: 0x0000F8F6
		internal void method_0()
		{
			this.observableCollection_0 = new ObservableCollection<GClass186>();
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00071584 File Offset: 0x0006F784
		internal void method_1(GClass8 gclass8_0)
		{
			GClass134.Class455 @class = new GClass134.Class455();
			@class.class450_0 = this;
			@class.gclass8_0 = gclass8_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00011703 File Offset: 0x0000F903
		internal void method_2()
		{
			GClass134.gclass183_0.CustomDisableDevices.Add(new GClass188
			{
				Name = "Bluetooth",
				Description = Class298.smethod_2("BlutoothDevicesDesc"),
				Devices = this.observableCollection_0
			});
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00011742 File Offset: 0x0000F942
		internal void method_3()
		{
			this.observableCollection_1 = new ObservableCollection<GClass186>();
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000715C0 File Offset: 0x0006F7C0
		internal void method_4(GClass8 gclass8_0)
		{
			GClass134.Class453 @class = new GClass134.Class453();
			@class.class450_0 = this;
			@class.gclass8_0 = gclass8_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x000715FC File Offset: 0x0006F7FC
		internal void method_5()
		{
			GClass134.gclass183_0.CustomDisableDevices.Add(new GClass188
			{
				Name = Class298.smethod_2("Print"),
				Description = Class298.smethod_2("PrintDesc"),
				Devices = this.observableCollection_1
			});
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0001174F File Offset: 0x0000F94F
		internal void method_6()
		{
			this.observableCollection_2 = new ObservableCollection<GClass186>();
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0007164C File Offset: 0x0006F84C
		internal void method_7(GClass8 gclass8_0)
		{
			GClass134.Class452 @class = new GClass134.Class452();
			@class.class450_0 = this;
			@class.gclass8_0 = gclass8_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0001175C File Offset: 0x0000F95C
		internal void method_8()
		{
			GClass134.gclass183_0.CustomDisableDevices.Add(new GClass188
			{
				Name = "WAN Miniports",
				Description = Class298.smethod_2("WanMiniPortsDesc"),
				Devices = this.observableCollection_2
			});
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0001179B File Offset: 0x0000F99B
		internal void method_9()
		{
			this.observableCollection_3 = new ObservableCollection<GClass186>();
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00071688 File Offset: 0x0006F888
		internal void method_10(GClass8 gclass8_0)
		{
			GClass134.Class451 @class = new GClass134.Class451();
			@class.class450_0 = this;
			@class.gclass8_0 = gclass8_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000716C4 File Offset: 0x0006F8C4
		internal void method_11()
		{
			GClass134.gclass183_0.CustomDisableDevices.Add(new GClass188
			{
				Name = Class298.smethod_2("NoDriverDevices"),
				Description = Class298.smethod_2("NoDriverDevicesDesc"),
				Devices = this.observableCollection_3
			});
		}

		// Token: 0x04001107 RID: 4359
		public ObservableCollection<GClass186> observableCollection_0;

		// Token: 0x04001108 RID: 4360
		public ObservableCollection<GClass186> observableCollection_1;

		// Token: 0x04001109 RID: 4361
		public ObservableCollection<GClass186> observableCollection_2;

		// Token: 0x0400110A RID: 4362
		public ObservableCollection<GClass186> observableCollection_3;
	}

	// Token: 0x020003E2 RID: 994
	private sealed class Class451
	{
		// Token: 0x060019F1 RID: 6641 RVA: 0x000117A8 File Offset: 0x0000F9A8
		internal void method_0()
		{
			this.class450_0.observableCollection_3.Add(new GClass186(this.gclass8_0, false, string.Empty));
		}

		// Token: 0x0400110B RID: 4363
		public GClass8 gclass8_0;

		// Token: 0x0400110C RID: 4364
		public GClass134.Class450 class450_0;
	}

	// Token: 0x020003E3 RID: 995
	private sealed class Class452
	{
		// Token: 0x060019F3 RID: 6643 RVA: 0x000117CB File Offset: 0x0000F9CB
		internal void method_0()
		{
			this.class450_0.observableCollection_2.Add(new GClass186(this.gclass8_0, false, string.Empty));
		}

		// Token: 0x0400110D RID: 4365
		public GClass8 gclass8_0;

		// Token: 0x0400110E RID: 4366
		public GClass134.Class450 class450_0;
	}

	// Token: 0x020003E4 RID: 996
	public sealed class GClass183 : GClass162
	{
		// Token: 0x060019F4 RID: 6644 RVA: 0x00071714 File Offset: 0x0006F914
		public GClass183()
		{
			this.observableCollection_0.CollectionChanged += this.observableCollection_2_CollectionChanged;
			this.observableCollection_1.CollectionChanged += this.observableCollection_2_CollectionChanged;
			this.observableCollection_2.CollectionChanged += this.observableCollection_2_CollectionChanged;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000117EE File Offset: 0x0000F9EE
		private void observableCollection_2_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			base.method_0("CollectionChanged");
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x000117FC File Offset: 0x0000F9FC
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x00011804 File Offset: 0x0000FA04
		public ObservableCollection<GClass186> MsiSupportedDevices
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("MsiSupportedDevices");
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00011819 File Offset: 0x0000FA19
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x00011821 File Offset: 0x0000FA21
		public ObservableCollection<GClass188> CustomDisableDevices
		{
			get
			{
				return this.observableCollection_1;
			}
			set
			{
				this.observableCollection_1 = value;
				base.method_0("CustomDisableDevices");
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00011836 File Offset: 0x0000FA36
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x0001183E File Offset: 0x0000FA3E
		public ObservableCollection<GClass186> CanBeDisabled
		{
			get
			{
				return this.observableCollection_2;
			}
			set
			{
				this.observableCollection_2 = value;
				base.method_0("CanBeDisabled");
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00011853 File Offset: 0x0000FA53
		public void method_2()
		{
			this.CanBeDisabled.Clear();
			this.CustomDisableDevices.Clear();
			this.MsiSupportedDevices.Clear();
			this.list_0.Clear();
		}

		// Token: 0x0400110F RID: 4367
		public List<GClass8> list_0 = new List<GClass8>();

		// Token: 0x04001110 RID: 4368
		private ObservableCollection<GClass186> observableCollection_0 = new ObservableCollection<GClass186>();

		// Token: 0x04001111 RID: 4369
		private ObservableCollection<GClass188> observableCollection_1 = new ObservableCollection<GClass188>();

		// Token: 0x04001112 RID: 4370
		private ObservableCollection<GClass186> observableCollection_2 = new ObservableCollection<GClass186>();
	}

	// Token: 0x020003E5 RID: 997
	[StructLayout(LayoutKind.Auto)]
	private struct Struct238 : IAsyncStateMachine
	{
		// Token: 0x060019FD RID: 6653 RVA: 0x00071798 File Offset: 0x0006F998
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_5E;
				}
				this.int_1 = 0;
				IL_41:
				if (GClass134.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass134.Struct238>(ref awaiter, ref this);
					return;
				}
				IL_5E:
				awaiter.GetResult();
				if (this.int_1 <= 500)
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_41;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_AD:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00011881 File Offset: 0x0000FA81
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001113 RID: 4371
		public int int_0;

		// Token: 0x04001114 RID: 4372
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001115 RID: 4373
		private int int_1;

		// Token: 0x04001116 RID: 4374
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003E6 RID: 998
	private sealed class Class453
	{
		// Token: 0x06001A00 RID: 6656 RVA: 0x0001188F File Offset: 0x0000FA8F
		internal void method_0()
		{
			this.class450_0.observableCollection_1.Add(new GClass186(this.gclass8_0, false, string.Empty));
		}

		// Token: 0x04001117 RID: 4375
		public GClass8 gclass8_0;

		// Token: 0x04001118 RID: 4376
		public GClass134.Class450 class450_0;
	}

	// Token: 0x020003E7 RID: 999
	private sealed class Class454
	{
		// Token: 0x06001A02 RID: 6658 RVA: 0x000118B2 File Offset: 0x0000FAB2
		internal void method_0()
		{
			GClass134.gclass183_0.CanBeDisabled.Add(new GClass186(this.gclass8_0, false, string.Empty));
		}

		// Token: 0x04001119 RID: 4377
		public GClass8 gclass8_0;
	}

	// Token: 0x020003E8 RID: 1000
	private sealed class Class455
	{
		// Token: 0x06001A04 RID: 6660 RVA: 0x000118D4 File Offset: 0x0000FAD4
		internal void method_0()
		{
			this.class450_0.observableCollection_0.Add(new GClass186(this.gclass8_0, false, string.Empty));
		}

		// Token: 0x0400111A RID: 4378
		public GClass8 gclass8_0;

		// Token: 0x0400111B RID: 4379
		public GClass134.Class450 class450_0;
	}

	// Token: 0x020003E9 RID: 1001
	[StructLayout(LayoutKind.Auto)]
	private struct Struct239 : IAsyncStateMachine
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x00071878 File Offset: 0x0006FA78
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!GClass134.bool_0)
					{
						GClass134.smethod_0(false);
					}
					awaiter = GClass134.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass134.Struct239>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<GClass186> enumerator = GClass134.gclass183_0.CanBeDisabled.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass186 gclass = enumerator.Current;
						gclass.IsEnabled = true;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerator<GClass188> enumerator2 = GClass134.gclass183_0.CustomDisableDevices.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass188 gclass2 = enumerator2.Current;
						gclass2.IsDisabled = new bool?(false);
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
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

		// Token: 0x06001A06 RID: 6662 RVA: 0x000118F7 File Offset: 0x0000FAF7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400111C RID: 4380
		public int int_0;

		// Token: 0x0400111D RID: 4381
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400111E RID: 4382
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003EA RID: 1002
	[StructLayout(LayoutKind.Auto)]
	private struct Struct240 : IAsyncStateMachine
	{
		// Token: 0x06001A07 RID: 6663 RVA: 0x000719C0 File Offset: 0x0006FBC0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(GClass134.Class458.class458_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass134.Struct240>(ref awaiter, ref this);
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

		// Token: 0x06001A08 RID: 6664 RVA: 0x00011905 File Offset: 0x0000FB05
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400111F RID: 4383
		public int int_0;

		// Token: 0x04001120 RID: 4384
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001121 RID: 4385
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003EB RID: 1003
	[StructLayout(LayoutKind.Auto)]
	private struct Struct241 : IAsyncStateMachine
	{
		// Token: 0x06001A09 RID: 6665 RVA: 0x00071A8C File Offset: 0x0006FC8C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!GClass134.bool_0)
					{
						GClass134.smethod_0(false);
					}
					awaiter = GClass134.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass134.Struct241>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<GClass186> enumerator = GClass134.gclass183_0.MsiSupportedDevices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass186 gclass = enumerator.Current;
						gclass.MsiStatus = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				enumerator = GClass134.gclass183_0.CanBeDisabled.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass186 gclass2 = enumerator.Current;
						gclass2.IsEnabled = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerator<GClass188> enumerator2 = GClass134.gclass183_0.CustomDisableDevices.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						GClass188 gclass3 = enumerator2.Current;
						gclass3.IsDisabled = new bool?(true);
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
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

		// Token: 0x06001A0A RID: 6666 RVA: 0x00011913 File Offset: 0x0000FB13
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001122 RID: 4386
		public int int_0;

		// Token: 0x04001123 RID: 4387
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001124 RID: 4388
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003EC RID: 1004
	private sealed class Class456
	{
		// Token: 0x06001A0C RID: 6668 RVA: 0x00071C48 File Offset: 0x0006FE48
		internal void method_0()
		{
			try
			{
				if (!string.IsNullOrEmpty(this.gclass8_0.Name) && !this.gclass8_0.Name.ToLower().Contains("audio"))
				{
					GClass134.gclass183_0.MsiSupportedDevices.Add(new GClass186(this.gclass8_0, true, string.Empty));
				}
			}
			catch
			{
			}
		}

		// Token: 0x04001125 RID: 4389
		public GClass8 gclass8_0;
	}

	// Token: 0x020003ED RID: 1005
	private sealed class Class457
	{
		// Token: 0x06001A0E RID: 6670 RVA: 0x00011921 File Offset: 0x0000FB21
		internal bool method_0(string string_0)
		{
			return !string.IsNullOrEmpty(string_0) && this.gclass8_0.method_0().ToLower().StartsWith(string_0.ToLower());
		}

		// Token: 0x04001126 RID: 4390
		public GClass8 gclass8_0;
	}

	// Token: 0x020003EE RID: 1006
	[StructLayout(LayoutKind.Auto)]
	private struct Struct242 : IAsyncStateMachine
	{
		// Token: 0x06001A0F RID: 6671 RVA: 0x00071CBC File Offset: 0x0006FEBC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!GClass134.bool_0)
					{
						GClass134.smethod_0(false);
					}
					awaiter = GClass134.smethod_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass134.Struct242>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<GClass186> enumerator = GClass134.gclass183_0.MsiSupportedDevices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass186 gclass = enumerator.Current;
						gclass.MsiStatus = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				enumerator = GClass134.gclass183_0.CanBeDisabled.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass186 gclass2 = enumerator.Current;
						gclass2.IsEnabled = false;
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
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

		// Token: 0x06001A10 RID: 6672 RVA: 0x00011948 File Offset: 0x0000FB48
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001127 RID: 4391
		public int int_0;

		// Token: 0x04001128 RID: 4392
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001129 RID: 4393
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003EF RID: 1007
	[Serializable]
	private sealed class Class458
	{
		// Token: 0x06001A13 RID: 6675 RVA: 0x00071E00 File Offset: 0x00070000
		internal Task method_0()
		{
			GClass134.Class458.Struct243 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass134.Class458.Struct243>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00011962 File Offset: 0x0000FB62
		internal void method_1()
		{
			GClass134.gclass183_0.method_2();
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0001196E File Offset: 0x0000FB6E
		internal bool method_2(GClass8 gclass8_0)
		{
			return gclass8_0 != null && gclass8_0.method_14();
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00071E3C File Offset: 0x0007003C
		internal void method_3(GClass8 gclass8_0)
		{
			GClass134.Class456 @class = new GClass134.Class456();
			@class.gclass8_0 = gclass8_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00071E74 File Offset: 0x00070074
		internal bool method_4(GClass8 gclass8_0)
		{
			GClass134.Class457 @class = new GClass134.Class457();
			@class.gclass8_0 = gclass8_0;
			return @class.gclass8_0 != null && !string.IsNullOrEmpty(@class.gclass8_0.method_0()) && GClass157.list_0.Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00071EC0 File Offset: 0x000700C0
		internal void method_5(GClass8 gclass8_0)
		{
			GClass134.Class454 @class = new GClass134.Class454();
			@class.gclass8_0 = gclass8_0;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0001197B File Offset: 0x0000FB7B
		internal bool method_6(GClass8 gclass8_0)
		{
			return gclass8_0 != null && !string.IsNullOrEmpty(gclass8_0.method_2()) && gclass8_0.method_2().Equals("Bluetooth", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000119A1 File Offset: 0x0000FBA1
		internal bool method_7(GClass8 gclass8_0)
		{
			return gclass8_0 != null && !string.IsNullOrEmpty(gclass8_0.method_2()) && gclass8_0.method_2().Equals("PrintQueue", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000119C7 File Offset: 0x0000FBC7
		internal bool method_8(GClass8 gclass8_0)
		{
			return gclass8_0 != null && !string.IsNullOrEmpty(gclass8_0.Name) && gclass8_0.Name.StartsWith("WAN Miniport", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x000119ED File Offset: 0x0000FBED
		internal bool method_9(GClass8 gclass8_0)
		{
			return gclass8_0 != null && !string.IsNullOrEmpty(gclass8_0.method_10()) && gclass8_0.method_10().Equals("28 (0x1C) [CM_PROB_FAILED_INSTALL]", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0400112A RID: 4394
		public static readonly GClass134.Class458 class458_0 = new GClass134.Class458();

		// Token: 0x0400112B RID: 4395
		public static Action action_0;

		// Token: 0x0400112C RID: 4396
		public static Func<GClass8, bool> func_0;

		// Token: 0x0400112D RID: 4397
		public static Action<GClass8> action_1;

		// Token: 0x0400112E RID: 4398
		public static Func<GClass8, bool> func_1;

		// Token: 0x0400112F RID: 4399
		public static Action<GClass8> action_2;

		// Token: 0x04001130 RID: 4400
		public static Func<GClass8, bool> func_2;

		// Token: 0x04001131 RID: 4401
		public static Func<GClass8, bool> func_3;

		// Token: 0x04001132 RID: 4402
		public static Func<GClass8, bool> func_4;

		// Token: 0x04001133 RID: 4403
		public static Func<GClass8, bool> func_5;

		// Token: 0x04001134 RID: 4404
		public static Func<Task> func_6;

		// Token: 0x020003F0 RID: 1008
		[StructLayout(LayoutKind.Auto)]
		private struct Struct243 : IAsyncStateMachine
		{
			// Token: 0x06001A1D RID: 6685 RVA: 0x00071EF8 File Offset: 0x000700F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = GClass134.semaphoreSlim_0.WaitAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass134.Class458.Struct243>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					awaiter.GetResult();
					try
					{
						GClass134.Class450 @class = new GClass134.Class450();
						Application.Current.Dispatcher.Invoke(new Action(GClass134.Class458.class458_0.method_1));
						List<GClass8> collection = Class304.smethod_2() ?? new List<GClass8>();
						GClass134.gclass183_0.list_0.AddRange(collection);
						if (GClass134.gclass183_0.list_0.Count != 0)
						{
							GClass134.gclass183_0.list_0.Where(new Func<GClass8, bool>(GClass134.Class458.class458_0.method_2)).ToList<GClass8>().ForEach(new Action<GClass8>(GClass134.Class458.class458_0.method_3));
							GClass134.gclass183_0.list_0.Where(new Func<GClass8, bool>(GClass134.Class458.class458_0.method_4)).ToList<GClass8>().ForEach(new Action<GClass8>(GClass134.Class458.class458_0.method_5));
							@class.observableCollection_0 = null;
							Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
							GClass134.gclass183_0.list_0.Where(new Func<GClass8, bool>(GClass134.Class458.class458_0.method_6)).ToList<GClass8>().ForEach(new Action<GClass8>(@class.method_1));
							if (@class.observableCollection_0.Count > 0)
							{
								Application.Current.Dispatcher.Invoke(new Action(@class.method_2));
							}
							@class.observableCollection_1 = null;
							Application.Current.Dispatcher.Invoke(new Action(@class.method_3));
							GClass134.gclass183_0.list_0.Where(new Func<GClass8, bool>(GClass134.Class458.class458_0.method_7)).ToList<GClass8>().ForEach(new Action<GClass8>(@class.method_4));
							if (@class.observableCollection_1.Count > 0)
							{
								Application.Current.Dispatcher.Invoke(new Action(@class.method_5));
							}
							@class.observableCollection_2 = null;
							Application.Current.Dispatcher.Invoke(new Action(@class.method_6));
							GClass134.gclass183_0.list_0.Where(new Func<GClass8, bool>(GClass134.Class458.class458_0.method_8)).ToList<GClass8>().ForEach(new Action<GClass8>(@class.method_7));
							if (@class.observableCollection_2.Count > 0)
							{
								Application.Current.Dispatcher.Invoke(new Action(@class.method_8));
							}
							@class.observableCollection_3 = null;
							Application.Current.Dispatcher.Invoke(new Action(@class.method_9));
							GClass134.gclass183_0.list_0.Where(new Func<GClass8, bool>(GClass134.Class458.class458_0.method_9)).ToList<GClass8>().ForEach(new Action<GClass8>(@class.method_10));
							if (@class.observableCollection_3.Count > 0)
							{
								Application.Current.Dispatcher.Invoke(new Action(@class.method_11));
							}
						}
					}
					catch
					{
					}
					finally
					{
						if (num < 0)
						{
							GClass134.bool_1 = true;
							GClass134.semaphoreSlim_0.Release();
						}
					}
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

			// Token: 0x06001A1E RID: 6686 RVA: 0x00011A13 File Offset: 0x0000FC13
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001135 RID: 4405
			public int int_0;

			// Token: 0x04001136 RID: 4406
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001137 RID: 4407
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
