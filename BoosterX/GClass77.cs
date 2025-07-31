using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x02000280 RID: 640
public sealed class GClass77 : INotifyPropertyChanged
{
	// Token: 0x06001105 RID: 4357 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
	public GClass77(GClass209.GClass211 gclass211_1, List<GClass184> list_1)
	{
		this.ServicesViewGroupName = gclass211_1;
		this.Services = list_1;
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x000592BC File Offset: 0x000574BC
	private void method_0(object sender, PropertyChangedEventArgs e)
	{
		if (e.PropertyName == "IsDefault")
		{
			this.vmethod_0("IsDefault");
		}
		if (e.PropertyName == "IsDisabled")
		{
			this.vmethod_0("IsDisabled");
		}
		if (e.PropertyName == "HasChanges")
		{
			this.vmethod_0("HasChanges");
		}
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x06001107 RID: 4359 RVA: 0x0000C5D5 File Offset: 0x0000A7D5
	// (set) Token: 0x06001108 RID: 4360 RVA: 0x0000C5DD File Offset: 0x0000A7DD
	public GClass209.GClass211 ServicesViewGroupName
	{
		get
		{
			return this.gclass211_0;
		}
		set
		{
			if (object.Equals(value, this.gclass211_0))
			{
				return;
			}
			this.gclass211_0 = value;
			this.vmethod_0("ServicesViewGroupName");
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x06001109 RID: 4361 RVA: 0x0000C601 File Offset: 0x0000A801
	// (set) Token: 0x0600110A RID: 4362 RVA: 0x00059328 File Offset: 0x00057528
	public List<GClass184> Services
	{
		get
		{
			return this.list_0;
		}
		set
		{
			if (object.Equals(value, this.list_0))
			{
				return;
			}
			this.list_0.ForEach(new Action<GClass184>(this.method_4));
			this.list_0 = value;
			this.list_0.ForEach(new Action<GClass184>(this.method_5));
			this.vmethod_0("Services");
			this.vmethod_0("IsDefault");
			this.vmethod_0("IsDisabled");
			this.vmethod_0("HasChanges");
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x0600110B RID: 4363 RVA: 0x0000C609 File Offset: 0x0000A809
	public bool HasChanges
	{
		get
		{
			return this.list_0.Any(new Func<GClass184, bool>(GClass77.Class297.class297_0.method_0));
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x0600110C RID: 4364 RVA: 0x0000C635 File Offset: 0x0000A835
	public bool HasServices
	{
		get
		{
			return this.list_0.Count > 0;
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x0600110D RID: 4365 RVA: 0x0000C645 File Offset: 0x0000A845
	public string GroupNameLoc
	{
		get
		{
			return Class298.smethod_2(this.GroupName);
		}
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x0600110E RID: 4366 RVA: 0x0000C652 File Offset: 0x0000A852
	// (set) Token: 0x0600110F RID: 4367 RVA: 0x0000C65F File Offset: 0x0000A85F
	public string GroupName
	{
		get
		{
			return this.gclass211_0.method_0();
		}
		set
		{
			this.gclass211_0.method_1(value);
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06001110 RID: 4368 RVA: 0x0000C66D File Offset: 0x0000A86D
	public SolidColorBrush IsRed
	{
		get
		{
			if (!this.gclass211_0.IsRed)
			{
				return Brushes.White;
			}
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
		}
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06001111 RID: 4369 RVA: 0x0000C687 File Offset: 0x0000A887
	public MaterialIconKind Icon
	{
		get
		{
			return this.gclass211_0.Icon;
		}
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06001112 RID: 4370 RVA: 0x0000C694 File Offset: 0x0000A894
	public string GroupDescriptionLoc
	{
		get
		{
			return Class298.smethod_2(this.GroupName + "Desc");
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06001113 RID: 4371 RVA: 0x000593AC File Offset: 0x000575AC
	// (set) Token: 0x06001114 RID: 4372 RVA: 0x0000C6AC File Offset: 0x0000A8AC
	public bool? IsDefault
	{
		get
		{
			if (!this.HasServices)
			{
				return new bool?(true);
			}
			if (this.Services.All(new Func<GClass184, bool>(GClass77.Class297.class297_0.method_1)))
			{
				return new bool?(true);
			}
			if (this.Services.All(new Func<GClass184, bool>(GClass77.Class297.class297_0.method_2)))
			{
				return new bool?(false);
			}
			return null;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			if (!value.Value)
			{
				this.method_1();
			}
			else
			{
				this.method_2();
			}
			this.vmethod_0("IsDefault");
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06001115 RID: 4373 RVA: 0x00059438 File Offset: 0x00057638
	// (set) Token: 0x06001116 RID: 4374 RVA: 0x0000C6DB File Offset: 0x0000A8DB
	public bool? IsDisabled
	{
		get
		{
			if (!this.HasServices)
			{
				return new bool?(true);
			}
			if (this.Services.All(new Func<GClass184, bool>(GClass77.Class297.class297_0.method_3)))
			{
				return new bool?(false);
			}
			if (this.Services.All(new Func<GClass184, bool>(GClass77.Class297.class297_0.method_4)))
			{
				return new bool?(true);
			}
			return null;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			if (!value.Value)
			{
				this.method_1();
			}
			else
			{
				this.method_2();
			}
			this.vmethod_0("IsDisabled");
		}
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x0000C70A File Offset: 0x0000A90A
	public void method_1()
	{
		this.Services.ForEach(new Action<GClass184>(GClass77.Class297.class297_0.method_5));
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x0000C736 File Offset: 0x0000A936
	public void method_2()
	{
		this.Services.ForEach(new Action<GClass184>(GClass77.Class297.class297_0.method_6));
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06001119 RID: 4377 RVA: 0x000594C4 File Offset: 0x000576C4
	// (remove) Token: 0x0600111A RID: 4378 RVA: 0x000594FC File Offset: 0x000576FC
	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x0000C762 File Offset: 0x0000A962
	protected void vmethod_0([CallerMemberName] string string_0)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_0));
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x0000C77B File Offset: 0x0000A97B
	protected bool method_3<T>(ref T gparam_0, T gparam_1, [CallerMemberName] string string_0)
	{
		if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
		{
			return false;
		}
		gparam_0 = gparam_1;
		this.vmethod_0(string_0);
		return true;
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x0000C7A1 File Offset: 0x0000A9A1
	private void method_4(GClass184 gclass184_0)
	{
		gclass184_0.PropertyChanged -= this.method_0;
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x0000C7B5 File Offset: 0x0000A9B5
	private void method_5(GClass184 gclass184_0)
	{
		gclass184_0.PropertyChanged += this.method_0;
	}

	// Token: 0x04000AB0 RID: 2736
	private GClass209.GClass211 gclass211_0;

	// Token: 0x04000AB1 RID: 2737
	private List<GClass184> list_0 = new List<GClass184>();

	// Token: 0x04000AB2 RID: 2738
	private PropertyChangedEventHandler propertyChangedEventHandler_0;

	// Token: 0x02000281 RID: 641
	[Serializable]
	private sealed class Class297
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x0000C7D5 File Offset: 0x0000A9D5
		internal bool method_0(GClass184 gclass184_0)
		{
			return gclass184_0.HasChanges;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000C7DD File Offset: 0x0000A9DD
		internal bool method_1(GClass184 gclass184_0)
		{
			return !gclass184_0.IsDefault;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		internal bool method_2(GClass184 gclass184_0)
		{
			return gclass184_0.IsDefault;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0000C7F0 File Offset: 0x0000A9F0
		internal bool method_3(GClass184 gclass184_0)
		{
			return !gclass184_0.IsDisabled;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0000C7FB File Offset: 0x0000A9FB
		internal bool method_4(GClass184 gclass184_0)
		{
			return gclass184_0.IsDisabled;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0000C803 File Offset: 0x0000AA03
		internal void method_5(GClass184 gclass184_0)
		{
			gclass184_0.WinServiceViewModel.method_8();
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0000C810 File Offset: 0x0000AA10
		internal void method_6(GClass184 gclass184_0)
		{
			gclass184_0.WinServiceViewModel.method_7();
		}

		// Token: 0x04000AB3 RID: 2739
		public static readonly GClass77.Class297 class297_0 = new GClass77.Class297();

		// Token: 0x04000AB4 RID: 2740
		public static Func<GClass184, bool> func_0;

		// Token: 0x04000AB5 RID: 2741
		public static Func<GClass184, bool> func_1;

		// Token: 0x04000AB6 RID: 2742
		public static Func<GClass184, bool> func_2;

		// Token: 0x04000AB7 RID: 2743
		public static Func<GClass184, bool> func_3;

		// Token: 0x04000AB8 RID: 2744
		public static Func<GClass184, bool> func_4;

		// Token: 0x04000AB9 RID: 2745
		public static Action<GClass184> action_0;

		// Token: 0x04000ABA RID: 2746
		public static Action<GClass184> action_1;
	}
}
