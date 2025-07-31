using System;
using System.Collections.Generic;
using System.Linq;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020001DD RID: 477
public sealed class GClass50
{
	// Token: 0x06000D0F RID: 3343 RVA: 0x00009E54 File Offset: 0x00008054
	public GClass50(GClass130 gclass130_2, GClass130 gclass130_3 = null)
	{
		this.gclass130_0 = gclass130_2;
		this.gclass130_1 = gclass130_3;
		this.method_0(true);
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0004D4C8 File Offset: 0x0004B6C8
	public void method_0(bool bool_0)
	{
		this.dictionary_0 = new Dictionary<uint, GClass112>();
		this.list_0 = new List<GClass72>();
		this.ginterface9_1 = new GClass281(this.gclass130_0, GEnum4.CustomSettings);
		List<GClass72> list = this.list_0;
		GClass72 gclass = new GClass72();
		gclass.method_3(1U);
		gclass.method_1(this.ginterface9_1);
		list.Add(gclass);
		if (!bool_0)
		{
			this.ginterface9_4 = new GClass18();
			List<GClass72> list2 = this.list_0;
			GClass72 gclass2 = new GClass72();
			gclass2.method_3(5U);
			gclass2.method_1(this.ginterface9_4);
			list2.Add(gclass2);
			this.ginterface9_0 = new GClass48();
			List<GClass72> list3 = this.list_0;
			GClass72 gclass3 = new GClass72();
			gclass3.method_3(2U);
			gclass3.method_1(this.ginterface9_0);
			list3.Add(gclass3);
			if (GClass91.gclass121_0 != null)
			{
				this.ginterface9_2 = new GClass71(GClass91.gclass121_0.list_0);
				List<GClass72> list4 = this.list_0;
				GClass72 gclass4 = new GClass72();
				gclass4.method_3(3U);
				gclass4.method_1(this.ginterface9_2);
				list4.Add(gclass4);
			}
			if (this.gclass130_1 != null)
			{
				this.ginterface9_3 = new GClass281(this.gclass130_1, GEnum4.ReferenceSettings);
				List<GClass72> list5 = this.list_0;
				GClass72 gclass5 = new GClass72();
				gclass5.method_3(4U);
				gclass5.method_1(this.ginterface9_3);
				list5.Add(gclass5);
			}
		}
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x0004D600 File Offset: 0x0004B800
	private NVDRS_SETTING_TYPE? method_1(uint uint_0)
	{
		foreach (GClass72 gclass in this.list_0.OrderBy(new Func<GClass72, GEnum4>(GClass50.Class233.class233_0.method_0)))
		{
			NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = gclass.method_0().imethod_1(uint_0);
			if (nvdrs_SETTING_TYPE != null)
			{
				return new NVDRS_SETTING_TYPE?(nvdrs_SETTING_TYPE.Value);
			}
		}
		return new NVDRS_SETTING_TYPE?(0);
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x0004D698 File Offset: 0x0004B898
	private string method_2(uint uint_0)
	{
		string result = null;
		foreach (GClass72 gclass in this.list_0.OrderBy(new Func<GClass72, GEnum4>(GClass50.Class233.class233_0.method_1)))
		{
			string text = gclass.method_0().imethod_2(uint_0);
			if (!string.IsNullOrEmpty(text))
			{
				if (!text.StartsWith("0x"))
				{
					return text;
				}
				result = text;
			}
		}
		return result;
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x0004D730 File Offset: 0x0004B930
	private string method_3(uint uint_0)
	{
		foreach (GClass72 gclass in this.list_0.OrderBy(new Func<GClass72, GEnum4>(GClass50.Class233.class233_0.method_2)))
		{
			string text = gclass.method_0().imethod_3(uint_0);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0004D7B0 File Offset: 0x0004B9B0
	private uint method_4(uint uint_0)
	{
		foreach (GClass72 gclass in this.list_0.OrderBy(new Func<GClass72, GEnum4>(GClass50.Class233.class233_0.method_3)))
		{
			uint? num = gclass.method_0().imethod_4(uint_0);
			if (num != null)
			{
				return num.Value;
			}
		}
		return 0U;
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x0004D83C File Offset: 0x0004BA3C
	private string method_5(uint uint_0)
	{
		foreach (GClass72 gclass in this.list_0.OrderBy(new Func<GClass72, GEnum4>(GClass50.Class233.class233_0.method_4)))
		{
			string text = gclass.method_0().imethod_5(uint_0);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0004D8BC File Offset: 0x0004BABC
	private byte[] method_6(uint uint_0)
	{
		foreach (GClass72 gclass in this.list_0.OrderBy(new Func<GClass72, GEnum4>(GClass50.Class233.class233_0.method_5)))
		{
			byte[] array = gclass.method_0().imethod_6(uint_0);
			if (array != null)
			{
				return array;
			}
		}
		return null;
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0004D93C File Offset: 0x0004BB3C
	private List<GClass277<T>> method_7<T>(List<GClass277<T>> list_1, List<GClass277<T>> list_2)
	{
		if (list_2 == null)
		{
			return list_1;
		}
		if (list_2.Count > 0 && list_2.First<GClass277<T>>().genum4_0 == GEnum4.ScannedSettings)
		{
			list_1.AddRange(list_2);
		}
		else
		{
			GClass50.Class229<T> @class = new GClass50.Class229<T>();
			@class.list_0 = list_1.Where(new Func<GClass277<T>, bool>(GClass50.Class232<T>.class232_0.method_0)).Select(new Func<GClass277<T>, T>(GClass50.Class232<T>.class232_0.method_1)).ToList<T>();
			List<GClass277<T>> collection = list_2.Where(new Func<GClass277<T>, bool>(@class.method_0)).ToList<GClass277<T>>();
			list_1.AddRange(collection);
			using (List<GClass277<T>>.Enumerator enumerator = list_1.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass50.Class228<T> class2 = new GClass50.Class228<T>();
					class2.gclass277_0 = enumerator.Current;
					GClass277<T> gclass = list_2.FirstOrDefault(new Func<GClass277<T>, bool>(class2.method_0));
					if (gclass != null && gclass.imethod_1() != null)
					{
						class2.gclass277_0.imethod_2(gclass.imethod_1());
						class2.gclass277_0.genum4_0 = gclass.genum4_0;
						class2.gclass277_0.method_1(gclass.method_0());
					}
				}
			}
		}
		GClass277<T> gclass2 = Class746.smethod_0<GClass277<T>>(list_1);
		if (gclass2 != null && gclass2 is IComparable)
		{
			return list_1.OrderBy(new Func<GClass277<T>, T>(GClass50.Class232<T>.class232_0.method_2)).ToList<GClass277<T>>();
		}
		return list_1.ToList<GClass277<T>>();
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0004DAD0 File Offset: 0x0004BCD0
	private List<GClass277<byte[]>> method_8(uint uint_0)
	{
		List<GClass277<byte[]>> list = new List<GClass277<byte[]>>();
		foreach (GClass72 gclass in this.list_0.OrderByDescending(new Func<GClass72, uint>(GClass50.Class233.class233_0.method_6)))
		{
			list = this.method_7<byte[]>(list, gclass.method_0().imethod_9(uint_0));
		}
		return list;
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x0004DB58 File Offset: 0x0004BD58
	private List<GClass277<string>> method_9(uint uint_0)
	{
		List<GClass277<string>> list = new List<GClass277<string>>();
		foreach (GClass72 gclass in this.list_0.OrderByDescending(new Func<GClass72, uint>(GClass50.Class233.class233_0.method_7)))
		{
			list = this.method_7<string>(list, gclass.method_0().imethod_7(uint_0));
		}
		return list;
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
	private List<GClass277<uint>> method_10(uint uint_0)
	{
		List<GClass277<uint>> list = new List<GClass277<uint>>();
		foreach (GClass72 gclass in this.list_0.OrderByDescending(new Func<GClass72, uint>(GClass50.Class233.class233_0.method_8)))
		{
			list = this.method_7<uint>(list, gclass.method_0().imethod_8(uint_0));
		}
		if (list != null)
		{
			list = list.Where(new Func<GClass277<uint>, bool>(GClass50.Class233.class233_0.method_9)).GroupBy(new Func<GClass277<uint>, string>(GClass50.Class233.class233_0.method_10)).Select(new Func<IGrouping<string, GClass277<uint>>, GClass277<uint>>(GClass50.Class233.class233_0.method_11)).OrderBy(new Func<GClass277<uint>, GEnum4>(GClass50.Class233.class233_0.method_12)).ThenBy(new Func<GClass277<uint>, int>(GClass50.Class233.class233_0.method_13)).ThenBy(new Func<GClass277<uint>, string>(GClass50.Class233.class233_0.method_14)).ToList<GClass277<uint>>();
		}
		return list;
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x0004DD4C File Offset: 0x0004BF4C
	public List<uint> method_11(GEnum11 genum11_0)
	{
		List<uint> list = new List<uint>();
		GEnum4[] source = this.method_12(genum11_0);
		foreach (GClass72 gclass in this.list_0.OrderBy(new Func<GClass72, GEnum4>(GClass50.Class233.class233_0.method_15)))
		{
			if (source.Contains(gclass.method_0().imethod_0()))
			{
				list.AddRange(gclass.method_0().imethod_10());
			}
		}
		return list.Distinct<uint>().ToList<uint>();
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00009E87 File Offset: 0x00008087
	private GEnum4[] method_12(GEnum11 genum11_0)
	{
		if (genum11_0 == (GEnum11)1)
		{
			return new GEnum4[]
			{
				GEnum4.ConstantSettings,
				GEnum4.ScannedSettings,
				GEnum4.CustomSettings,
				GEnum4.DriverSettings,
				GEnum4.ReferenceSettings
			};
		}
		if (genum11_0 == (GEnum11)2)
		{
			return new GEnum4[]
			{
				GEnum4.CustomSettings
			};
		}
		return new GEnum4[]
		{
			GEnum4.CustomSettings,
			GEnum4.DriverSettings
		};
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00009EBF File Offset: 0x000080BF
	private GEnum4[] method_13(GEnum11 genum11_0)
	{
		if (genum11_0 == (GEnum11)2)
		{
			return new GEnum4[]
			{
				GEnum4.CustomSettings,
				GEnum4.ScannedSettings
			};
		}
		return new GEnum4[]
		{
			GEnum4.ConstantSettings,
			GEnum4.ScannedSettings,
			GEnum4.CustomSettings,
			GEnum4.DriverSettings,
			GEnum4.ReferenceSettings
		};
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x0004DDF4 File Offset: 0x0004BFF4
	private GClass112 method_14(uint uint_0)
	{
		NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = this.method_1(uint_0);
		string text = this.method_2(uint_0);
		string text2 = this.method_3(uint_0);
		if (text2 == null)
		{
			text2 = this.method_17(uint_0, text);
		}
		GClass112 gclass = new GClass112();
		gclass.method_1(nvdrs_SETTING_TYPE);
		gclass.method_5(text);
		gclass.method_3(text2);
		gclass.method_13(this.method_18(uint_0));
		gclass.method_15(this.method_19(uint_0));
		gclass.Description = this.method_20(uint_0);
		NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_9((nvdrs_SETTING_TYPE2.GetValueOrDefault() == 0 & nvdrs_SETTING_TYPE2 != null) ? this.method_4(uint_0) : 0U);
		gclass.method_7((nvdrs_SETTING_TYPE.GetValueOrDefault() == 3) ? this.method_5(uint_0) : null);
		gclass.method_11((nvdrs_SETTING_TYPE.GetValueOrDefault() == 1) ? this.method_6(uint_0) : null);
		nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
		gclass.method_19((nvdrs_SETTING_TYPE2.GetValueOrDefault() == 0 & nvdrs_SETTING_TYPE2 != null) ? this.method_10(uint_0) : null);
		gclass.method_17((nvdrs_SETTING_TYPE.GetValueOrDefault() == 3) ? this.method_9(uint_0) : null);
		gclass.method_21((nvdrs_SETTING_TYPE.GetValueOrDefault() == 1) ? this.method_8(uint_0) : null);
		return gclass;
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x0004DF1C File Offset: 0x0004C11C
	private GClass112 method_15(uint uint_0, GClass112 gclass112_0, GEnum11 genum11_0)
	{
		GClass50.Class230 @class = new GClass50.Class230();
		GClass112 gclass = new GClass112();
		gclass.method_9(gclass112_0.method_8());
		gclass.method_7(gclass112_0.method_6());
		gclass.method_11(gclass112_0.method_10());
		gclass.method_5(gclass112_0.method_4());
		gclass.method_1(gclass112_0.method_0());
		gclass.method_3(gclass112_0.method_2());
		gclass.method_13(gclass112_0.method_12());
		gclass.method_15(gclass112_0.method_14());
		gclass.Description = gclass112_0.Description;
		GClass112 gclass2 = gclass;
		if (string.IsNullOrEmpty(gclass2.method_4()))
		{
			gclass2.method_5(string.Format("0x{0:X8}", uint_0));
		}
		@class.genum4_0 = this.method_13(genum11_0);
		if (gclass112_0.method_18() != null)
		{
			gclass2.method_19(gclass112_0.method_18().Where(new Func<GClass277<uint>, bool>(@class.method_0)).ToList<GClass277<uint>>());
		}
		if (gclass112_0.method_16() != null)
		{
			gclass2.method_17(gclass112_0.method_16().Where(new Func<GClass277<string>, bool>(@class.method_1)).ToList<GClass277<string>>());
		}
		if (gclass112_0.method_20() != null)
		{
			gclass2.method_21(gclass112_0.method_20().Where(new Func<GClass277<byte[]>, bool>(@class.method_2)).ToList<GClass277<byte[]>>());
		}
		return gclass2;
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x0004E054 File Offset: 0x0004C254
	public GClass112 method_16(uint uint_0, GEnum11 genum11_0)
	{
		if (this.dictionary_0.ContainsKey(uint_0))
		{
			return this.method_15(uint_0, this.dictionary_0[uint_0], genum11_0);
		}
		GClass112 gclass = this.method_14(uint_0);
		this.dictionary_0.Add(uint_0, gclass);
		return this.method_15(uint_0, gclass, genum11_0);
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x0004E0A4 File Offset: 0x0004C2A4
	private string method_17(uint uint_0, string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.ToUpper().Contains("SLI"))
		{
			return "SLI";
		}
		if (string_0.ToUpper().Contains("STEREO"))
		{
			return "Stereo";
		}
		if (string_0.StartsWith("0x"))
		{
			return "Unknown";
		}
		return "Other";
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0004E108 File Offset: 0x0004C308
	private bool method_18(uint uint_0)
	{
		GClass72 gclass = this.list_0.FirstOrDefault(new Func<GClass72, bool>(GClass50.Class233.class233_0.method_16));
		return gclass != null && gclass.method_0().imethod_10().Contains(uint_0);
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x0004E158 File Offset: 0x0004C358
	private bool method_19(uint uint_0)
	{
		GClass72 gclass = this.list_0.FirstOrDefault(new Func<GClass72, bool>(GClass50.Class233.class233_0.method_17));
		return gclass != null && ((GClass281)gclass.method_0()).method_1(uint_0);
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0004E1A8 File Offset: 0x0004C3A8
	private string method_20(uint uint_0)
	{
		GClass72 gclass = this.list_0.FirstOrDefault(new Func<GClass72, bool>(GClass50.Class233.class233_0.method_18));
		string text = (gclass != null) ? (((GClass281)gclass.method_0()).method_2(uint_0) ?? string.Empty) : string.Empty;
		GClass72 gclass2 = this.list_0.FirstOrDefault(new Func<GClass72, bool>(GClass50.Class233.class233_0.method_19));
		string result = (gclass2 != null) ? (((GClass281)gclass2.method_0()).method_2(uint_0) ?? string.Empty) : string.Empty;
		if (string.IsNullOrEmpty(text))
		{
			return result;
		}
		return text;
	}

	// Token: 0x04000859 RID: 2137
	private GInterface9 ginterface9_0;

	// Token: 0x0400085A RID: 2138
	private GInterface9 ginterface9_1;

	// Token: 0x0400085B RID: 2139
	private GInterface9 ginterface9_2;

	// Token: 0x0400085C RID: 2140
	private GInterface9 ginterface9_3;

	// Token: 0x0400085D RID: 2141
	public GInterface9 ginterface9_4;

	// Token: 0x0400085E RID: 2142
	private readonly GClass130 gclass130_0;

	// Token: 0x0400085F RID: 2143
	private readonly GClass130 gclass130_1;

	// Token: 0x04000860 RID: 2144
	private List<GClass72> list_0 = new List<GClass72>();

	// Token: 0x04000861 RID: 2145
	private Dictionary<uint, GClass112> dictionary_0 = new Dictionary<uint, GClass112>();

	// Token: 0x020001DE RID: 478
	private sealed class Class228<T>
	{
		// Token: 0x06000D26 RID: 3366 RVA: 0x0004E260 File Offset: 0x0004C460
		internal bool method_0(GClass277<T> gclass277_1)
		{
			T t = gclass277_1.method_2();
			return t.Equals(this.gclass277_0.method_2()) && this.gclass277_0.genum4_0 != GEnum4.ScannedSettings;
		}

		// Token: 0x04000862 RID: 2146
		public GClass277<T> gclass277_0;
	}

	// Token: 0x020001DF RID: 479
	private sealed class Class229<T>
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x00009EE7 File Offset: 0x000080E7
		internal bool method_0(GClass277<T> gclass277_0)
		{
			return !this.list_0.Contains(gclass277_0.method_2());
		}

		// Token: 0x04000863 RID: 2147
		public List<T> list_0;
	}

	// Token: 0x020001E0 RID: 480
	private sealed class Class230
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x00009EFD File Offset: 0x000080FD
		internal bool method_0(GClass277<uint> gclass277_0)
		{
			return this.genum4_0.Contains(gclass277_0.genum4_0);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00009F10 File Offset: 0x00008110
		internal bool method_1(GClass277<string> gclass277_0)
		{
			return this.genum4_0.Contains(gclass277_0.genum4_0);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00009F23 File Offset: 0x00008123
		internal bool method_2(GClass277<byte[]> gclass277_0)
		{
			return this.genum4_0.Contains(gclass277_0.genum4_0);
		}

		// Token: 0x04000864 RID: 2148
		public GEnum4[] genum4_0;
	}

	// Token: 0x020001E1 RID: 481
	private sealed class Class231
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x00009F36 File Offset: 0x00008136
		internal bool method_0(GClass277<uint> gclass277_0)
		{
			return gclass277_0.imethod_1() == this.igrouping_0.Key;
		}

		// Token: 0x04000865 RID: 2149
		public IGrouping<string, GClass277<uint>> igrouping_0;
	}

	// Token: 0x020001E2 RID: 482
	[Serializable]
	private sealed class Class232<T>
	{
		// Token: 0x06000D31 RID: 3377 RVA: 0x00009F5A File Offset: 0x0000815A
		internal bool method_0(GClass277<T> gclass277_0)
		{
			return gclass277_0.genum4_0 != GEnum4.ScannedSettings;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00009F69 File Offset: 0x00008169
		internal T method_1(GClass277<T> gclass277_0)
		{
			return gclass277_0.method_2();
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00009F69 File Offset: 0x00008169
		internal T method_2(GClass277<T> gclass277_0)
		{
			return gclass277_0.method_2();
		}

		// Token: 0x04000866 RID: 2150
		public static readonly GClass50.Class232<T> class232_0 = new GClass50.Class232<T>();

		// Token: 0x04000867 RID: 2151
		public static Func<GClass277<T>, bool> func_0;

		// Token: 0x04000868 RID: 2152
		public static Func<GClass277<T>, T> func_1;

		// Token: 0x04000869 RID: 2153
		public static Func<GClass277<T>, T> func_2;
	}

	// Token: 0x020001E3 RID: 483
	[Serializable]
	private sealed class Class233
	{
		// Token: 0x06000D36 RID: 3382 RVA: 0x00009F7D File Offset: 0x0000817D
		internal GEnum4 method_0(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0();
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00009F7D File Offset: 0x0000817D
		internal GEnum4 method_1(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0();
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00009F7D File Offset: 0x0000817D
		internal GEnum4 method_2(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0();
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00009F7D File Offset: 0x0000817D
		internal GEnum4 method_3(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0();
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00009F7D File Offset: 0x0000817D
		internal GEnum4 method_4(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0();
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00009F7D File Offset: 0x0000817D
		internal GEnum4 method_5(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0();
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00009F8A File Offset: 0x0000818A
		internal uint method_6(GClass72 gclass72_0)
		{
			return gclass72_0.method_2();
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00009F8A File Offset: 0x0000818A
		internal uint method_7(GClass72 gclass72_0)
		{
			return gclass72_0.method_2();
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00009F8A File Offset: 0x0000818A
		internal uint method_8(GClass72 gclass72_0)
		{
			return gclass72_0.method_2();
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0004E2A8 File Offset: 0x0004C4A8
		internal bool method_9(GClass277<uint> gclass277_0)
		{
			return !gclass277_0.imethod_1().EndsWith("_NUM") && !gclass277_0.imethod_1().EndsWith("_MASK") && (!gclass277_0.imethod_1().EndsWith("_MIN") || gclass277_0.imethod_1().Equals("PREFERRED_PSTATE_PREFER_MIN")) && (!gclass277_0.imethod_1().EndsWith("_MAX") || gclass277_0.imethod_1().Equals("PREFERRED_PSTATE_PREFER_MAX"));
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00009F92 File Offset: 0x00008192
		internal string method_10(GClass277<uint> gclass277_0)
		{
			return gclass277_0.imethod_1();
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0004E32C File Offset: 0x0004C52C
		internal GClass277<uint> method_11(IGrouping<string, GClass277<uint>> igrouping_0)
		{
			GClass50.Class231 @class = new GClass50.Class231();
			@class.igrouping_0 = igrouping_0;
			return @class.igrouping_0.First(new Func<GClass277<uint>, bool>(@class.method_0));
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00009F9A File Offset: 0x0000819A
		internal GEnum4 method_12(GClass277<uint> gclass277_0)
		{
			return gclass277_0.genum4_0;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00009FA2 File Offset: 0x000081A2
		internal int method_13(GClass277<uint> gclass277_0)
		{
			return gclass277_0.method_0();
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00009F92 File Offset: 0x00008192
		internal string method_14(GClass277<uint> gclass277_0)
		{
			return gclass277_0.imethod_1();
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00009F7D File Offset: 0x0000817D
		internal GEnum4 method_15(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0();
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00009FAA File Offset: 0x000081AA
		internal bool method_16(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0() == GEnum4.DriverSettings;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00009FBB File Offset: 0x000081BB
		internal bool method_17(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0() == GEnum4.CustomSettings;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00009FBB File Offset: 0x000081BB
		internal bool method_18(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0() == GEnum4.CustomSettings;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00009FCC File Offset: 0x000081CC
		internal bool method_19(GClass72 gclass72_0)
		{
			return gclass72_0.method_0().imethod_0() == GEnum4.ReferenceSettings;
		}

		// Token: 0x0400086A RID: 2154
		public static readonly GClass50.Class233 class233_0 = new GClass50.Class233();

		// Token: 0x0400086B RID: 2155
		public static Func<GClass72, GEnum4> func_0;

		// Token: 0x0400086C RID: 2156
		public static Func<GClass72, GEnum4> func_1;

		// Token: 0x0400086D RID: 2157
		public static Func<GClass72, GEnum4> func_2;

		// Token: 0x0400086E RID: 2158
		public static Func<GClass72, GEnum4> func_3;

		// Token: 0x0400086F RID: 2159
		public static Func<GClass72, GEnum4> func_4;

		// Token: 0x04000870 RID: 2160
		public static Func<GClass72, GEnum4> func_5;

		// Token: 0x04000871 RID: 2161
		public static Func<GClass72, uint> func_6;

		// Token: 0x04000872 RID: 2162
		public static Func<GClass72, uint> func_7;

		// Token: 0x04000873 RID: 2163
		public static Func<GClass72, uint> func_8;

		// Token: 0x04000874 RID: 2164
		public static Func<GClass277<uint>, bool> func_9;

		// Token: 0x04000875 RID: 2165
		public static Func<GClass277<uint>, string> func_10;

		// Token: 0x04000876 RID: 2166
		public static Func<IGrouping<string, GClass277<uint>>, GClass277<uint>> func_11;

		// Token: 0x04000877 RID: 2167
		public static Func<GClass277<uint>, GEnum4> func_12;

		// Token: 0x04000878 RID: 2168
		public static Func<GClass277<uint>, int> func_13;

		// Token: 0x04000879 RID: 2169
		public static Func<GClass277<uint>, string> func_14;

		// Token: 0x0400087A RID: 2170
		public static Func<GClass72, GEnum4> func_15;

		// Token: 0x0400087B RID: 2171
		public static Func<GClass72, bool> func_16;

		// Token: 0x0400087C RID: 2172
		public static Func<GClass72, bool> func_17;

		// Token: 0x0400087D RID: 2173
		public static Func<GClass72, bool> func_18;

		// Token: 0x0400087E RID: 2174
		public static Func<GClass72, bool> func_19;
	}
}
