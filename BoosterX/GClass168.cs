using System;
using System.Windows.Media;
using ns0;

// Token: 0x0200017B RID: 379
public sealed class GClass168 : GClass162
{
	// Token: 0x06000A8D RID: 2701 RVA: 0x0000861D File Offset: 0x0000681D
	internal GClass168(Class275 class275_1)
	{
		this.class275_0 = class275_1;
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0000862C File Offset: 0x0000682C
	public string RawName
	{
		get
		{
			return this.method_2<string>(ref this.string_0, new Func<string>(this.method_10), "RawName");
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0000864C File Offset: 0x0000684C
	public string Name
	{
		get
		{
			return this.method_2<string>(ref this.string_1, new Func<string>(this.method_11), "Name");
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0000866C File Offset: 0x0000686C
	public SolidColorBrush Foreground
	{
		get
		{
			return this.method_2<SolidColorBrush>(ref this.solidColorBrush_0, new Func<SolidColorBrush>(this.method_4), "Foreground");
		}
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x0000868C File Offset: 0x0000688C
	private T method_2<T>(ref T gparam_0, Func<T> func_0, string string_2) where T : class
	{
		if (gparam_0 == null)
		{
			gparam_0 = func_0();
			base.method_0(string_2);
		}
		return gparam_0;
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x000492EC File Offset: 0x000474EC
	private string method_3(bool bool_0)
	{
		if (!this.class275_0.String_1.smethod_9())
		{
			if (!bool_0)
			{
				return this.class275_0.String_1;
			}
			return Class298.smethod_2(this.class275_0.String_1);
		}
		else if (this.class275_0.List_0.Contains("OWNVALUE"))
		{
			if (!bool_0)
			{
				return "OWNVALUE";
			}
			return Class298.smethod_2("OwnValue");
		}
		else if (this.class275_0.List_0.Contains("DEFAULT"))
		{
			if (!bool_0)
			{
				return "DEFAULT";
			}
			return Class298.smethod_2("default");
		}
		else if (this.class275_0.List_0.Contains("OPTIMAL"))
		{
			if (!bool_0)
			{
				return "OPTIMAL";
			}
			return Class298.smethod_2("optimal");
		}
		else
		{
			if (!this.class275_0.List_0.Contains("BEST"))
			{
				return this.class275_0.String_0;
			}
			if (!bool_0)
			{
				return "BEST";
			}
			return Class298.smethod_2("bestest");
		}
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x000493F0 File Offset: 0x000475F0
	private SolidColorBrush method_4()
	{
		if (this.class275_0.List_0.Contains("OWNVALUE"))
		{
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd;
		}
		if (this.class275_0.List_0.Contains("BEST"))
		{
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;
		}
		if (this.class275_0.List_0.Contains("OPTIMAL"))
		{
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGR5QHU2M7DAPA2_ejd;
		}
		if (this.class275_0.List_0.Contains("OCOLORED"))
		{
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGR5QHU2M7DAPA2_ejd;
		}
		if (this.class275_0.List_0.Contains("DEFAULT"))
		{
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
		}
		return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGR5QHU2M7DAPA2_ejd;
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x000086B4 File Offset: 0x000068B4
	public bool method_5()
	{
		return this.class275_0.Boolean_5;
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x000086C1 File Offset: 0x000068C1
	public bool method_6()
	{
		return this.class275_0.Boolean_4;
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x000086CE File Offset: 0x000068CE
	public bool method_7()
	{
		return this.class275_0.method_1();
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x000086DB File Offset: 0x000068DB
	public string method_8()
	{
		if (this.method_6())
		{
			return "BEST";
		}
		if (this.method_7())
		{
			return "OPTIMAL";
		}
		return "DEFAULT";
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x00008701 File Offset: 0x00006901
	internal void method_9()
	{
		this.string_1 = this.method_3(true);
		base.method_0("Name");
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x0000871C File Offset: 0x0000691C
	private string method_10()
	{
		return this.method_3(false);
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00008725 File Offset: 0x00006925
	private string method_11()
	{
		return this.method_3(true);
	}

	// Token: 0x0400070B RID: 1803
	private readonly Class275 class275_0;

	// Token: 0x0400070C RID: 1804
	private string string_0;

	// Token: 0x0400070D RID: 1805
	private string string_1;

	// Token: 0x0400070E RID: 1806
	private SolidColorBrush solidColorBrush_0;
}
