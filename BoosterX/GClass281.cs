using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000682 RID: 1666
public sealed class GClass281 : GInterface9
{
	// Token: 0x06002A37 RID: 10807 RVA: 0x0001B8B9 File Offset: 0x00019AB9
	public GClass281(GClass130 gclass130_1, GEnum4 genum4_1 = GEnum4.CustomSettings)
	{
		this.gclass130_0 = gclass130_1;
		this.genum4_0 = genum4_1;
	}

	// Token: 0x06002A38 RID: 10808 RVA: 0x000A3344 File Offset: 0x000A1544
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		GClass281.Class791 @class = new GClass281.Class791();
		@class.uint_0 = uint_0;
		GClass254 gclass = this.gclass130_0.list_0.FirstOrDefault(new Func<GClass254, bool>(@class.method_0));
		return this.method_0((gclass != null) ? gclass.String_4 : null);
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x000A3390 File Offset: 0x000A1590
	private NVDRS_SETTING_TYPE? method_0(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		string a = string_0.ToLowerInvariant();
		if (a == "dword")
		{
			return new NVDRS_SETTING_TYPE?(0);
		}
		if (a == "string")
		{
			return new NVDRS_SETTING_TYPE?(3);
		}
		if (!(a == "binary"))
		{
			throw new ArgumentOutOfRangeException(string_0);
		}
		return new NVDRS_SETTING_TYPE?(1);
	}

	// Token: 0x06002A3A RID: 10810 RVA: 0x000A33FC File Offset: 0x000A15FC
	public string imethod_2(uint uint_0)
	{
		GClass281.Class795 @class = new GClass281.Class795();
		@class.uint_0 = uint_0;
		GClass254 gclass = this.gclass130_0.list_0.FirstOrDefault(new Func<GClass254, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.String_0;
		}
		return null;
	}

	// Token: 0x06002A3B RID: 10811 RVA: 0x000A3440 File Offset: 0x000A1640
	public uint? imethod_4(uint uint_0)
	{
		GClass281.Class788 @class = new GClass281.Class788();
		@class.uint_0 = uint_0;
		GClass254 gclass = this.gclass130_0.list_0.FirstOrDefault(new Func<GClass254, bool>(@class.method_0));
		if (gclass != null)
		{
			return gclass.DefaultValue;
		}
		return null;
	}

	// Token: 0x06002A3C RID: 10812 RVA: 0x000039D3 File Offset: 0x00001BD3
	public string imethod_5(uint uint_0)
	{
		return null;
	}

	// Token: 0x06002A3D RID: 10813 RVA: 0x000039D3 File Offset: 0x00001BD3
	public List<GClass277<string>> imethod_7(uint uint_0)
	{
		return null;
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x000A348C File Offset: 0x000A168C
	public List<GClass277<uint>> imethod_8(uint uint_0)
	{
		GClass281.Class789 @class = new GClass281.Class789();
		@class.uint_0 = uint_0;
		@class.gclass281_0 = this;
		GClass254 gclass = this.gclass130_0.list_0.FirstOrDefault(new Func<GClass254, bool>(@class.method_0));
		if (gclass != null)
		{
			GClass281.Class793 class2 = new GClass281.Class793();
			class2.class789_0 = @class;
			class2.int_0 = 0;
			return gclass.List_0.Select(new Func<GClass12, GClass277<uint>>(class2.method_0)).ToList<GClass277<uint>>();
		}
		return null;
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x0001B8CF File Offset: 0x00019ACF
	public List<uint> imethod_10()
	{
		return this.gclass130_0.list_0.Select(new Func<GClass254, uint>(GClass281.Class796.class796_0.method_0)).ToList<uint>();
	}

	// Token: 0x06002A40 RID: 10816 RVA: 0x000A3500 File Offset: 0x000A1700
	public string imethod_3(uint uint_0)
	{
		GClass281.Class794 @class = new GClass281.Class794();
		@class.uint_0 = uint_0;
		GClass254 gclass = this.gclass130_0.list_0.FirstOrDefault(new Func<GClass254, bool>(@class.method_0));
		if (gclass != null && !string.IsNullOrWhiteSpace(gclass.String_2))
		{
			return gclass.String_2;
		}
		return null;
	}

	// Token: 0x06002A41 RID: 10817 RVA: 0x000039D3 File Offset: 0x00001BD3
	public byte[] imethod_6(uint uint_0)
	{
		return null;
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x000039D3 File Offset: 0x00001BD3
	public List<GClass277<byte[]>> imethod_9(uint uint_0)
	{
		return null;
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x000A3550 File Offset: 0x000A1750
	public bool method_1(uint uint_0)
	{
		GClass281.Class790 @class = new GClass281.Class790();
		@class.uint_0 = uint_0;
		GClass254 gclass = this.gclass130_0.list_0.FirstOrDefault(new Func<GClass254, bool>(@class.method_0));
		return gclass != null && gclass.Boolean_0;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x000A3594 File Offset: 0x000A1794
	public string method_2(uint uint_0)
	{
		GClass281.Class792 @class = new GClass281.Class792();
		@class.uint_0 = uint_0;
		GClass254 gclass = this.gclass130_0.list_0.FirstOrDefault(new Func<GClass254, bool>(@class.method_0));
		if (gclass == null)
		{
			return null;
		}
		return gclass.Description;
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x0001B905 File Offset: 0x00019B05
	public GEnum4 imethod_0()
	{
		return this.genum4_0;
	}

	// Token: 0x04001B9C RID: 7068
	private readonly GClass130 gclass130_0;

	// Token: 0x04001B9D RID: 7069
	private readonly GEnum4 genum4_0;

	// Token: 0x02000683 RID: 1667
	private sealed class Class788
	{
		// Token: 0x06002A47 RID: 10823 RVA: 0x000A35D8 File Offset: 0x000A17D8
		internal bool method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001B9E RID: 7070
		public uint uint_0;
	}

	// Token: 0x02000684 RID: 1668
	private sealed class Class789
	{
		// Token: 0x06002A49 RID: 10825 RVA: 0x000A35FC File Offset: 0x000A17FC
		internal bool method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001B9F RID: 7071
		public uint uint_0;

		// Token: 0x04001BA0 RID: 7072
		public GClass281 gclass281_0;
	}

	// Token: 0x02000685 RID: 1669
	private sealed class Class790
	{
		// Token: 0x06002A4B RID: 10827 RVA: 0x000A3620 File Offset: 0x000A1820
		internal bool method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001BA1 RID: 7073
		public uint uint_0;
	}

	// Token: 0x02000686 RID: 1670
	private sealed class Class791
	{
		// Token: 0x06002A4D RID: 10829 RVA: 0x000A3644 File Offset: 0x000A1844
		internal bool method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001BA2 RID: 7074
		public uint uint_0;
	}

	// Token: 0x02000687 RID: 1671
	private sealed class Class792
	{
		// Token: 0x06002A4F RID: 10831 RVA: 0x000A3668 File Offset: 0x000A1868
		internal bool method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001BA3 RID: 7075
		public uint uint_0;
	}

	// Token: 0x02000688 RID: 1672
	private sealed class Class793
	{
		// Token: 0x06002A51 RID: 10833 RVA: 0x000A368C File Offset: 0x000A188C
		internal GClass277<uint> method_0(GClass12 gclass12_0)
		{
			GClass277<uint> gclass = new GClass277<uint>(this.class789_0.gclass281_0.imethod_0());
			int num = this.int_0;
			this.int_0 = num + 1;
			gclass.method_1(num);
			gclass.method_3(gclass12_0.SettingValue);
			gclass.imethod_2((this.class789_0.gclass281_0.genum4_0 == GEnum4.CustomSettings) ? gclass12_0.String_0 : (GClass223.smethod_0(gclass12_0.SettingValue) + " " + gclass12_0.String_0));
			return gclass;
		}

		// Token: 0x04001BA4 RID: 7076
		public int int_0;

		// Token: 0x04001BA5 RID: 7077
		public GClass281.Class789 class789_0;
	}

	// Token: 0x02000689 RID: 1673
	private sealed class Class794
	{
		// Token: 0x06002A53 RID: 10835 RVA: 0x000A3710 File Offset: 0x000A1910
		internal bool method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001BA6 RID: 7078
		public uint uint_0;
	}

	// Token: 0x0200068A RID: 1674
	private sealed class Class795
	{
		// Token: 0x06002A55 RID: 10837 RVA: 0x000A3734 File Offset: 0x000A1934
		internal bool method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId.Equals(this.uint_0);
		}

		// Token: 0x04001BA7 RID: 7079
		public uint uint_0;
	}

	// Token: 0x0200068B RID: 1675
	[Serializable]
	private sealed class Class796
	{
		// Token: 0x06002A58 RID: 10840 RVA: 0x0001B919 File Offset: 0x00019B19
		internal uint method_0(GClass254 gclass254_0)
		{
			return gclass254_0.SettingId;
		}

		// Token: 0x04001BA8 RID: 7080
		public static readonly GClass281.Class796 class796_0 = new GClass281.Class796();

		// Token: 0x04001BA9 RID: 7081
		public static Func<GClass254, uint> func_0;
	}
}
