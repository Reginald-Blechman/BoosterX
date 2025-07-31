using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Windows.Media.Imaging;

// Token: 0x020004EF RID: 1263
public sealed class GClass189 : GClass162
{
	// Token: 0x06001FF2 RID: 8178 RVA: 0x0008233C File Offset: 0x0008053C
	public GClass189(GClass165 gclass165_1)
	{
		this.Service = gclass165_1;
		this.ShowDisplayName = true;
		this.NewStartMode = gclass165_1.CurrentStartMode;
		this.NewStatus = gclass165_1.Status;
		this.method_4(new Class799(gclass165_1));
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x00015207 File Offset: 0x00013407
	internal void method_2()
	{
		this.Service.method_2();
		base.method_0("NewStatusChanged");
		base.method_0("NewStartModeChanged");
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x0001522C File Offset: 0x0001342C
	internal Class799 method_3()
	{
		return this.class799_0;
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x00015234 File Offset: 0x00013434
	internal void method_4(Class799 class799_1)
	{
		this.class799_0 = class799_1;
	}

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0001523D File Offset: 0x0001343D
	// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x00015245 File Offset: 0x00013445
	public GClass165 Service
	{
		get
		{
			return this.gclass165_0;
		}
		set
		{
			if (object.Equals(value, this.gclass165_0))
			{
				return;
			}
			this.gclass165_0 = value;
			base.method_0("Service");
		}
	}

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00015269 File Offset: 0x00013469
	public BitmapSource Icon
	{
		get
		{
			this.method_5();
			return this.bitmapSource_0;
		}
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000823A4 File Offset: 0x000805A4
	private void method_5()
	{
		GClass189.Struct334 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass189_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass189.Struct334>(ref @struct);
	}

	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x06001FFA RID: 8186 RVA: 0x00015277 File Offset: 0x00013477
	public string DisplayName
	{
		get
		{
			return this.gclass165_0.DisplayName;
		}
	}

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00015284 File Offset: 0x00013484
	public List<string> WillBrake
	{
		get
		{
			return this.gclass165_0.WillBrake;
		}
	}

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00015291 File Offset: 0x00013491
	public bool IsService
	{
		get
		{
			return this.gclass165_0.method_3();
		}
	}

	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0001529E File Offset: 0x0001349E
	public string ServiceName
	{
		get
		{
			return this.gclass165_0.ServiceName;
		}
	}

	// Token: 0x17000563 RID: 1379
	// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000152AB File Offset: 0x000134AB
	// (set) Token: 0x06001FFF RID: 8191 RVA: 0x000152B3 File Offset: 0x000134B3
	public string Description
	{
		get
		{
			return this.string_0;
		}
		set
		{
			if (value == this.string_0)
			{
				return;
			}
			this.string_0 = value;
			base.method_0("Description");
		}
	}

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x06002000 RID: 8192 RVA: 0x000152D7 File Offset: 0x000134D7
	public List<GClass189> DependenciesLinear
	{
		get
		{
			return this.list_2;
		}
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x06002001 RID: 8193 RVA: 0x000152DF File Offset: 0x000134DF
	public List<GClass189> DependenciesTree
	{
		get
		{
			return this.list_0;
		}
	}

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x06002002 RID: 8194 RVA: 0x000152E7 File Offset: 0x000134E7
	public bool DependenciesTreeHasValue
	{
		get
		{
			return this.DependenciesTree.Count > 0;
		}
	}

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x06002003 RID: 8195 RVA: 0x000152F7 File Offset: 0x000134F7
	public List<GClass189> DependOn
	{
		get
		{
			return this.list_1;
		}
	}

	// Token: 0x17000568 RID: 1384
	// (set) Token: 0x06002004 RID: 8196 RVA: 0x000152FF File Offset: 0x000134FF
	public bool ShowDisplayName
	{
		set
		{
			if (value == this.bool_0)
			{
				return;
			}
			this.bool_0 = value;
			this.ServiceViewName = (value ? this.DisplayName : this.ServiceName);
		}
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x06002005 RID: 8197 RVA: 0x00015329 File Offset: 0x00013529
	// (set) Token: 0x06002006 RID: 8198 RVA: 0x000823DC File Offset: 0x000805DC
	public ServiceStartMode NewStartMode
	{
		get
		{
			return this.serviceStartMode_0;
		}
		set
		{
			if (value == this.serviceStartMode_0)
			{
				return;
			}
			this.serviceStartMode_0 = value;
			base.method_0("NewStartMode");
			base.method_0("IsChecked");
			base.method_0("NewStartModeChanged");
			base.method_0("HasChanges");
			base.method_0("IsDefault");
			base.method_0("IsDisabled");
		}
	}

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x06002007 RID: 8199 RVA: 0x00015331 File Offset: 0x00013531
	public bool NewStartModeChanged
	{
		get
		{
			return this.NewStartMode != this.Service.CurrentStartMode;
		}
	}

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x06002008 RID: 8200 RVA: 0x00015349 File Offset: 0x00013549
	// (set) Token: 0x06002009 RID: 8201 RVA: 0x00015351 File Offset: 0x00013551
	public ServiceControllerStatus NewStatus
	{
		get
		{
			return this.serviceControllerStatus_0;
		}
		set
		{
			if (value == this.serviceControllerStatus_0)
			{
				return;
			}
			this.serviceControllerStatus_0 = value;
			base.method_0("NewStatus");
			base.method_0("NewStatusChanged");
			base.method_0("HasChanges");
		}
	}

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x0600200A RID: 8202 RVA: 0x00015388 File Offset: 0x00013588
	public bool NewStatusChanged
	{
		get
		{
			return this.NewStatus != this.Service.Status;
		}
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x0600200B RID: 8203 RVA: 0x000153A0 File Offset: 0x000135A0
	public bool HasChanges
	{
		get
		{
			return this.NewStatusChanged || this.NewStartModeChanged;
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x0600200C RID: 8204 RVA: 0x000153B2 File Offset: 0x000135B2
	// (set) Token: 0x0600200D RID: 8205 RVA: 0x000153BA File Offset: 0x000135BA
	public string ServiceViewName
	{
		get
		{
			return this.string_1;
		}
		set
		{
			if (value == this.string_1)
			{
				return;
			}
			this.string_1 = value;
			base.method_0("ServiceViewName");
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x0600200E RID: 8206 RVA: 0x000153DE File Offset: 0x000135DE
	public ServiceStartMode? DefaultStartMode
	{
		get
		{
			return this.gclass165_0.DefaultStartMode;
		}
	}

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x0600200F RID: 8207 RVA: 0x00082444 File Offset: 0x00080644
	public bool DefaultStartNodeExists
	{
		get
		{
			return this.DefaultStartMode != null;
		}
	}

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x06002010 RID: 8208 RVA: 0x00082460 File Offset: 0x00080660
	public string DependOnString
	{
		get
		{
			if (this.DependOn.Count == 0)
			{
				return Class298.smethod_2("NoDependOn");
			}
			return string.Join(", ", this.DependOn.Select(new Func<GClass189, string>(GClass189.Class604.class604_0.method_0)).ToList<string>());
		}
	}

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x06002011 RID: 8209 RVA: 0x000824C0 File Offset: 0x000806C0
	public string ServiceDependencies
	{
		get
		{
			if (this.DependenciesLinear.Count == 0)
			{
				return Class298.smethod_2("NoDependencies");
			}
			return string.Join(", ", this.DependenciesLinear.Select(new Func<GClass189, string>(GClass189.Class604.class604_0.method_1)).ToList<string>());
		}
	}

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x06002012 RID: 8210 RVA: 0x000153EB File Offset: 0x000135EB
	public bool IsBlocked
	{
		get
		{
			return this.Service.IsBlocked;
		}
	}

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x06002013 RID: 8211 RVA: 0x000153F8 File Offset: 0x000135F8
	// (set) Token: 0x06002014 RID: 8212 RVA: 0x0001540E File Offset: 0x0001360E
	public bool IsChecked
	{
		get
		{
			return this.NewStartMode == ServiceStartMode.Disabled && !this.IsDefault;
		}
		set
		{
			this.method_6(!value);
			base.method_0("IsChecked");
		}
	}

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x06002015 RID: 8213 RVA: 0x00082520 File Offset: 0x00080720
	public bool IsDefault
	{
		get
		{
			if (this.Service.DefaultStartMode != null)
			{
				ServiceStartMode? defaultStartMode = this.Service.DefaultStartMode;
				ServiceStartMode newStartMode = this.NewStartMode;
				return defaultStartMode.GetValueOrDefault() == newStartMode & defaultStartMode != null;
			}
			return false;
		}
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06002016 RID: 8214 RVA: 0x00015426 File Offset: 0x00013626
	public bool IsDisabled
	{
		get
		{
			if (this.NewStartModeChanged)
			{
				return this.NewStartMode == ServiceStartMode.Disabled;
			}
			return this.Service.CurrentStartMode == ServiceStartMode.Disabled;
		}
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x06002017 RID: 8215 RVA: 0x00015448 File Offset: 0x00013648
	public bool CheckBoxEnabled
	{
		get
		{
			return this.DefaultStartNodeExists && !this.IsBlocked;
		}
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x0008256C File Offset: 0x0008076C
	public void method_6(bool bool_1)
	{
		if (bool_1)
		{
			this.NewStartMode = (this.Service.DefaultStartMode ?? this.NewStartMode);
			return;
		}
		this.NewStartMode = ServiceStartMode.Disabled;
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x0001545D File Offset: 0x0001365D
	public void method_7()
	{
		this.NewStartMode = ServiceStartMode.Disabled;
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x000825B0 File Offset: 0x000807B0
	public void method_8()
	{
		if (this.Service.DefaultStartMode != null)
		{
			ServiceStartMode newStartMode = this.NewStartMode;
			ServiceStartMode? defaultStartMode = this.Service.DefaultStartMode;
			if (!(newStartMode == defaultStartMode.GetValueOrDefault() & defaultStartMode != null))
			{
				this.NewStartMode = this.Service.DefaultStartMode.Value;
			}
		}
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x00015466 File Offset: 0x00013666
	public void method_9()
	{
		if (this.NewStartModeChanged)
		{
			this.NewStartMode = this.Service.CurrentStartMode;
		}
		if (this.NewStatusChanged)
		{
			this.NewStatus = this.Service.Status;
		}
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x00082610 File Offset: 0x00080810
	public string method_10()
	{
		string text = string.Empty;
		if (this.NewStartModeChanged)
		{
			text += this.NewStartMode.ToString();
		}
		if (this.NewStatusChanged)
		{
			text = text + "|" + this.NewStatus.ToString();
		}
		return text;
	}

	// Token: 0x04001554 RID: 5460
	private GClass165 gclass165_0;

	// Token: 0x04001555 RID: 5461
	private string string_0;

	// Token: 0x04001556 RID: 5462
	private readonly List<GClass189> list_0 = new List<GClass189>();

	// Token: 0x04001557 RID: 5463
	private readonly List<GClass189> list_1 = new List<GClass189>();

	// Token: 0x04001558 RID: 5464
	private bool bool_0;

	// Token: 0x04001559 RID: 5465
	private ServiceStartMode serviceStartMode_0;

	// Token: 0x0400155A RID: 5466
	private ServiceControllerStatus serviceControllerStatus_0;

	// Token: 0x0400155B RID: 5467
	private readonly List<GClass189> list_2 = new List<GClass189>();

	// Token: 0x0400155C RID: 5468
	private string string_1;

	// Token: 0x0400155D RID: 5469
	private Class799 class799_0;

	// Token: 0x0400155E RID: 5470
	private BitmapSource bitmapSource_0;

	// Token: 0x020004F0 RID: 1264
	[StructLayout(LayoutKind.Auto)]
	private struct Struct334 : IAsyncStateMachine
	{
		// Token: 0x0600201D RID: 8221 RVA: 0x00082670 File Offset: 0x00080870
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass189 gclass = this.gclass189_0;
			try
			{
				TaskAwaiter<BitmapSource> awaiter;
				if (num != 0)
				{
					awaiter = GClass219.smethod_23(gclass.ServiceName).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapSource>, GClass189.Struct334>(ref awaiter, ref this);
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
				gclass.bitmapSource_0 = result;
				gclass.method_0("_Icon");
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

		// Token: 0x0600201E RID: 8222 RVA: 0x0001549A File Offset: 0x0001369A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400155F RID: 5471
		public int int_0;

		// Token: 0x04001560 RID: 5472
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001561 RID: 5473
		public GClass189 gclass189_0;

		// Token: 0x04001562 RID: 5474
		private TaskAwaiter<BitmapSource> taskAwaiter_0;
	}

	// Token: 0x020004F1 RID: 1265
	[Serializable]
	private sealed class Class604
	{
		// Token: 0x06002021 RID: 8225 RVA: 0x000154B4 File Offset: 0x000136B4
		internal string method_0(GClass189 gclass189_0)
		{
			return gclass189_0.ServiceName;
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x000154B4 File Offset: 0x000136B4
		internal string method_1(GClass189 gclass189_0)
		{
			return gclass189_0.ServiceName;
		}

		// Token: 0x04001563 RID: 5475
		public static readonly GClass189.Class604 class604_0 = new GClass189.Class604();

		// Token: 0x04001564 RID: 5476
		public static Func<GClass189, string> func_0;

		// Token: 0x04001565 RID: 5477
		public static Func<GClass189, string> func_1;
	}
}
