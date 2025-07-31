using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200026E RID: 622
public sealed class GClass71 : GInterface9
{
	// Token: 0x060010C0 RID: 4288 RVA: 0x0000C2BC File Offset: 0x0000A4BC
	public GClass71(List<GClass235> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0000C2CB File Offset: 0x0000A4CB
	public GEnum4 imethod_0()
	{
		return GEnum4.ScannedSettings;
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x00058B5C File Offset: 0x00056D5C
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		GClass71.Class289 @class = new GClass71.Class289();
		@class.uint_0 = uint_0;
		GClass235 gclass = this.list_0.FirstOrDefault(new Func<GClass235, bool>(@class.method_0));
		if (gclass != null)
		{
			return new NVDRS_SETTING_TYPE?(gclass.nvdrs_SETTING_TYPE_0);
		}
		return null;
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00058BA8 File Offset: 0x00056DA8
	public string imethod_2(uint uint_0)
	{
		GClass71.Class291 @class = new GClass71.Class291();
		@class.uint_0 = uint_0;
		GClass235 gclass = this.list_0.FirstOrDefault(new Func<GClass235, bool>(@class.method_0));
		if (gclass != null)
		{
			return string.Format("0x{0:X8} ({1} Profiles)", @class.uint_0, gclass.uint_1);
		}
		return null;
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x000039D3 File Offset: 0x00001BD3
	public string imethod_3(uint uint_0)
	{
		return null;
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x00058C00 File Offset: 0x00056E00
	public uint? imethod_4(uint uint_0)
	{
		return null;
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x000039D3 File Offset: 0x00001BD3
	public string imethod_5(uint uint_0)
	{
		return null;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x00058C18 File Offset: 0x00056E18
	public List<GClass277<string>> imethod_7(uint uint_0)
	{
		GClass71.Class287 @class = new GClass71.Class287();
		@class.uint_0 = uint_0;
		@class.gclass71_0 = this;
		GClass235 gclass = this.list_0.FirstOrDefault(new Func<GClass235, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.list_0.Select(new Func<GClass231, GClass277<string>>(@class.method_1)).ToList<GClass277<string>>();
		}
		return null;
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00058C74 File Offset: 0x00056E74
	public List<GClass277<uint>> imethod_8(uint uint_0)
	{
		GClass71.Class290 @class = new GClass71.Class290();
		@class.uint_0 = uint_0;
		@class.gclass71_0 = this;
		GClass235 gclass = this.list_0.FirstOrDefault(new Func<GClass235, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.list_0.Select(new Func<GClass231, GClass277<uint>>(@class.method_1)).ToList<GClass277<uint>>();
		}
		return null;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0000C2CF File Offset: 0x0000A4CF
	public List<uint> imethod_10()
	{
		return this.list_0.Select(new Func<GClass235, uint>(GClass71.Class292.class292_0.method_0)).ToList<uint>();
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x000039D3 File Offset: 0x00001BD3
	public byte[] imethod_6(uint uint_0)
	{
		return null;
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00058CD0 File Offset: 0x00056ED0
	public List<GClass277<byte[]>> imethod_9(uint uint_0)
	{
		GClass71.Class288 @class = new GClass71.Class288();
		@class.uint_0 = uint_0;
		@class.gclass71_0 = this;
		GClass235 gclass = this.list_0.FirstOrDefault(new Func<GClass235, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.list_0.Select(new Func<GClass231, GClass277<byte[]>>(@class.method_1)).ToList<GClass277<byte[]>>();
		}
		return null;
	}

	// Token: 0x04000A93 RID: 2707
	private readonly List<GClass235> list_0;

	// Token: 0x0200026F RID: 623
	private sealed class Class287
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x0000C300 File Offset: 0x0000A500
		internal bool method_0(GClass235 gclass235_0)
		{
			return gclass235_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0000C313 File Offset: 0x0000A513
		internal GClass277<string> method_1(GClass231 gclass231_0)
		{
			GClass277<string> gclass = new GClass277<string>(this.gclass71_0.imethod_0());
			gclass.method_3(gclass231_0.string_0);
			gclass.imethod_2(string.Format("'{0}' ({1})", gclass231_0.string_0.Trim(), gclass231_0.stringBuilder_0));
			return gclass;
		}

		// Token: 0x04000A94 RID: 2708
		public uint uint_0;

		// Token: 0x04000A95 RID: 2709
		public GClass71 gclass71_0;
	}

	// Token: 0x02000270 RID: 624
	private sealed class Class288
	{
		// Token: 0x060010D0 RID: 4304 RVA: 0x0000C353 File Offset: 0x0000A553
		internal bool method_0(GClass235 gclass235_0)
		{
			return gclass235_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0000C366 File Offset: 0x0000A566
		internal GClass277<byte[]> method_1(GClass231 gclass231_0)
		{
			GClass277<byte[]> gclass = new GClass277<byte[]>(this.gclass71_0.imethod_0());
			gclass.method_3(gclass231_0.byte_0);
			gclass.imethod_2(string.Format("{0} ({1})", GClass223.smethod_6(gclass231_0.byte_0), gclass231_0.stringBuilder_0));
			return gclass;
		}

		// Token: 0x04000A96 RID: 2710
		public uint uint_0;

		// Token: 0x04000A97 RID: 2711
		public GClass71 gclass71_0;
	}

	// Token: 0x02000271 RID: 625
	private sealed class Class289
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x0000C3A6 File Offset: 0x0000A5A6
		internal bool method_0(GClass235 gclass235_0)
		{
			return gclass235_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x04000A98 RID: 2712
		public uint uint_0;
	}

	// Token: 0x02000272 RID: 626
	private sealed class Class290
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x0000C3B9 File Offset: 0x0000A5B9
		internal bool method_0(GClass235 gclass235_0)
		{
			return gclass235_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		internal GClass277<uint> method_1(GClass231 gclass231_0)
		{
			GClass277<uint> gclass = new GClass277<uint>(this.gclass71_0.imethod_0());
			gclass.method_3(gclass231_0.uint_0);
			gclass.imethod_2(string.Format("0x{0:X8} ({1})", gclass231_0.uint_0, gclass231_0.stringBuilder_0));
			return gclass;
		}

		// Token: 0x04000A99 RID: 2713
		public uint uint_0;

		// Token: 0x04000A9A RID: 2714
		public GClass71 gclass71_0;
	}

	// Token: 0x02000273 RID: 627
	private sealed class Class291
	{
		// Token: 0x060010D8 RID: 4312 RVA: 0x0000C40C File Offset: 0x0000A60C
		internal bool method_0(GClass235 gclass235_0)
		{
			return gclass235_0.uint_0.Equals(this.uint_0);
		}

		// Token: 0x04000A9B RID: 2715
		public uint uint_0;
	}

	// Token: 0x02000274 RID: 628
	[Serializable]
	private sealed class Class292
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x0000C42B File Offset: 0x0000A62B
		internal uint method_0(GClass235 gclass235_0)
		{
			return gclass235_0.uint_0;
		}

		// Token: 0x04000A9C RID: 2716
		public static readonly GClass71.Class292 class292_0 = new GClass71.Class292();

		// Token: 0x04000A9D RID: 2717
		public static Func<GClass235, uint> func_0;
	}
}
