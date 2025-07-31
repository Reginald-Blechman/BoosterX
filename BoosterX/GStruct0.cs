using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000176 RID: 374
public struct GStruct0
{
	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0000846E File Offset: 0x0000666E
	// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00008476 File Offset: 0x00006676
	public GClass208 SettingItem
	{
		[CompilerGenerated]
		readonly get
		{
			return this.gclass208_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass208_0 = value;
		}
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x0000847F File Offset: 0x0000667F
	public readonly GClass112 method_0()
	{
		return this.gclass112_0;
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00008487 File Offset: 0x00006687
	public void method_1(GClass112 gclass112_1)
	{
		this.gclass112_0 = gclass112_1;
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000471E0 File Offset: 0x000453E0
	public List<GInterface11> Values
	{
		get
		{
			GStruct0.Class194 @class = new GStruct0.Class194();
			List<GInterface11> list = new List<GInterface11>(this.method_0().Values);
			@class.object_0 = this.SettingItem.method_8();
			GInterface11 ginterface = list.FirstOrDefault(new Func<GInterface11, bool>(@class.method_0));
			if (ginterface == null)
			{
				List<GInterface11> list2 = list;
				int index = 0;
				GClass277<string> gclass = new GClass277<string>(GEnum4.CustomSettings);
				gclass.imethod_2("[ NONE ]");
				list2.Insert(index, gclass);
				this.CurrentValue = list.First<GInterface11>();
			}
			else
			{
				this.CurrentValue = ginterface;
			}
			return list;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00008490 File Offset: 0x00006690
	// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00008498 File Offset: 0x00006698
	public GInterface11 CurrentValue
	{
		[CompilerGenerated]
		readonly get
		{
			return this.ginterface11_0;
		}
		[CompilerGenerated]
		private set
		{
			this.ginterface11_0 = value;
		}
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x000084A1 File Offset: 0x000066A1
	public string method_2()
	{
		if (string.IsNullOrEmpty(this.SettingItem.method_10()))
		{
			return "Unknown";
		}
		return this.SettingItem.method_10();
	}

	// Token: 0x040006F5 RID: 1781
	private GClass208 gclass208_0;

	// Token: 0x040006F6 RID: 1782
	private GClass112 gclass112_0;

	// Token: 0x040006F7 RID: 1783
	private GInterface11 ginterface11_0;

	// Token: 0x02000177 RID: 375
	private sealed class Class194
	{
		// Token: 0x06000A74 RID: 2676 RVA: 0x000084C7 File Offset: 0x000066C7
		internal bool method_0(GInterface11 ginterface11_0)
		{
			return ginterface11_0.imethod_0().ToString() == this.object_0.ToString();
		}

		// Token: 0x040006F8 RID: 1784
		public object object_0;
	}
}
