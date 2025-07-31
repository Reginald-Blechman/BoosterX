using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

// Token: 0x0200011E RID: 286
internal sealed class Class489 : GClass162
{
	// Token: 0x06000845 RID: 2117 RVA: 0x000071A1 File Offset: 0x000053A1
	internal Class489(Class245 class245_1, Class512 class512_1)
	{
		this.class512_0 = class512_1;
		this.class245_0 = class245_1;
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000846 RID: 2118 RVA: 0x000071E0 File Offset: 0x000053E0
	public bool OnEdit
	{
		get
		{
			return this.class512_0.OnEdit;
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x000071ED File Offset: 0x000053ED
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("ColChandes");
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000848 RID: 2120 RVA: 0x000071FB File Offset: 0x000053FB
	public bool IsRegTweakD
	{
		get
		{
			return this.TypeD == "REG";
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000849 RID: 2121 RVA: 0x00040FFC File Offset: 0x0003F1FC
	// (set) Token: 0x0600084A RID: 2122 RVA: 0x0000720E File Offset: 0x0000540E
	public ObservableCollection<Class504> ValuesD
	{
		get
		{
			if (this.class245_0.List_0 != null && this.class245_0.List_0.Count<Class275>() > 0)
			{
				foreach (Class275 class275_ in this.class245_0.List_0)
				{
					this.observableCollection_0.Add(new Class504(class275_, this));
				}
			}
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("ValuesD");
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600084B RID: 2123 RVA: 0x00007223 File Offset: 0x00005423
	// (set) Token: 0x0600084C RID: 2124 RVA: 0x00007230 File Offset: 0x00005430
	public string TweakTypeD
	{
		get
		{
			return this.class245_0.String_0;
		}
		set
		{
			this.class245_0.String_0 = value;
			base.method_0("TweakTypeD");
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600084D RID: 2125 RVA: 0x0000724A File Offset: 0x0000544A
	// (set) Token: 0x0600084E RID: 2126 RVA: 0x00007257 File Offset: 0x00005457
	public string PathD
	{
		get
		{
			return this.class245_0.String_1;
		}
		set
		{
			this.class245_0.String_1 = value;
			base.method_0("PathD");
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x0600084F RID: 2127 RVA: 0x00007271 File Offset: 0x00005471
	// (set) Token: 0x06000850 RID: 2128 RVA: 0x0000727E File Offset: 0x0000547E
	public string KeyD
	{
		get
		{
			return this.class245_0.String_2;
		}
		set
		{
			this.class245_0.String_2 = value;
			base.method_0("KeyD");
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000851 RID: 2129 RVA: 0x00041088 File Offset: 0x0003F288
	public GClass280 RemoveStepCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_6), null));
			}
			return result;
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000852 RID: 2130 RVA: 0x00007298 File Offset: 0x00005498
	public string TypeD
	{
		get
		{
			return this.class245_0.String_4;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000853 RID: 2131 RVA: 0x000072A5 File Offset: 0x000054A5
	// (set) Token: 0x06000854 RID: 2132 RVA: 0x000072B2 File Offset: 0x000054B2
	public string RegTypeD
	{
		get
		{
			return this.class245_0.String_5;
		}
		set
		{
			this.class245_0.String_5 = value;
			base.method_0("RegTypeD");
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000855 RID: 2133 RVA: 0x000410BC File Offset: 0x0003F2BC
	public ObservableCollection<string> RegTypesD
	{
		get
		{
			if (this.observableCollection_1 == null)
			{
				this.observableCollection_1 = new ObservableCollection<string>
				{
					"REG_DWORD",
					"REG_SZ",
					"REG_BINARY",
					"REG_EXPAND_SZ"
				};
			}
			return this.observableCollection_1;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000856 RID: 2134 RVA: 0x000072CC File Offset: 0x000054CC
	public string HideTip
	{
		get
		{
			if (!(this.TypeD == "REG") && !(this.TypeD == "BCDEDIT"))
			{
				return "HIDE";
			}
			return "SHOW";
		}
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00007301 File Offset: 0x00005501
	public bool method_2()
	{
		return this.class245_0.method_1();
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0000730E File Offset: 0x0000550E
	public bool method_3()
	{
		return this.class245_0.method_2();
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0000731B File Offset: 0x0000551B
	public bool method_4()
	{
		return this.class245_0.method_3();
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00007328 File Offset: 0x00005528
	public bool method_5()
	{
		return this.class245_0.method_4();
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00007335 File Offset: 0x00005535
	private void method_6(object object_0)
	{
		this.class512_0.method_2(this);
	}

	// Token: 0x040004AE RID: 1198
	internal Class245 class245_0;

	// Token: 0x040004AF RID: 1199
	internal Class512 class512_0;

	// Token: 0x040004B0 RID: 1200
	public bool bool_0 = true;

	// Token: 0x040004B1 RID: 1201
	public ObservableCollection<Class504> observableCollection_0 = new ObservableCollection<Class504>();

	// Token: 0x040004B2 RID: 1202
	private GClass280 gclass280_0;

	// Token: 0x040004B3 RID: 1203
	private ObservableCollection<string> observableCollection_1;
}
