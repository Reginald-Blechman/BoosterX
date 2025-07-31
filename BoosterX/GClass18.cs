using System;
using System.Collections.Generic;
using System.Text;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200015C RID: 348
public sealed class GClass18 : GInterface9
{
	// Token: 0x060009F9 RID: 2553 RVA: 0x0000810B File Offset: 0x0000630B
	public GClass18()
	{
		this.list_0 = this.method_0();
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0004587C File Offset: 0x00043A7C
	private List<uint> method_0()
	{
		List<uint> result = new List<uint>();
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_EnumAvailableSettingIds(ref result, 512U);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_EnumAvailableSettingIds", nvapi_STATUS);
		}
		return result;
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x000458B0 File Offset: 0x00043AB0
	private GClass112 method_1(uint uint_0)
	{
		if ((uint_0 & 4294963200U) == 281530368U)
		{
			return null;
		}
		NVDRS_SETTING_VALUES nvdrs_SETTING_VALUES = default(NVDRS_SETTING_VALUES);
		nvdrs_SETTING_VALUES.version = NVAPIDrsWrapper.NVDRS_SETTING_VALUES_VER;
		NVDRS_SETTING_VALUES nvdrs_SETTING_VALUES2 = nvdrs_SETTING_VALUES;
		uint num = 255U;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_EnumAvailableSettingValues(uint_0, ref num, ref nvdrs_SETTING_VALUES2);
		if (nvapi_STATUS == -160)
		{
			return null;
		}
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_EnumAvailableSettingValues", nvapi_STATUS);
		}
		StringBuilder stringBuilder = new StringBuilder(2048);
		nvapi_STATUS = NVAPIDrsWrapper.DRS_GetSettingNameFromId.Invoke(uint_0, stringBuilder);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_GetSettingNameFromId", nvapi_STATUS);
		}
		string text = stringBuilder.ToString();
		if (string.IsNullOrWhiteSpace(text))
		{
			text = GClass223.smethod_0(uint_0);
		}
		GClass112 gclass = new GClass112();
		gclass.method_1(new NVDRS_SETTING_TYPE?(nvdrs_SETTING_VALUES2.settingType));
		gclass.method_5(text);
		GClass112 gclass2 = gclass;
		if (nvdrs_SETTING_VALUES2.settingType == null)
		{
			gclass2.method_9(nvdrs_SETTING_VALUES2.defaultValue.dwordValue);
			gclass2.method_19(new List<GClass277<uint>>());
			int num2 = 0;
			while ((long)num2 < (long)((ulong)nvdrs_SETTING_VALUES2.numSettingValues))
			{
				List<GClass277<uint>> list = gclass2.method_18();
				GClass277<uint> gclass3 = new GClass277<uint>(this.imethod_0());
				gclass3.method_3(nvdrs_SETTING_VALUES2.settingValues[num2].dwordValue);
				gclass3.imethod_2(GClass223.smethod_0(nvdrs_SETTING_VALUES2.settingValues[num2].dwordValue));
				list.Add(gclass3);
				num2++;
			}
		}
		if (nvdrs_SETTING_VALUES2.settingType == 3)
		{
			gclass2.method_7(nvdrs_SETTING_VALUES2.defaultValue.stringValue);
			gclass2.method_17(new List<GClass277<string>>());
			int num3 = 0;
			while ((long)num3 < (long)((ulong)nvdrs_SETTING_VALUES2.numSettingValues))
			{
				string stringValue = nvdrs_SETTING_VALUES2.settingValues[num3].stringValue;
				if (stringValue != null)
				{
					List<GClass277<string>> list2 = gclass2.method_16();
					GClass277<string> gclass4 = new GClass277<string>(this.imethod_0());
					gclass4.method_3(stringValue);
					gclass4.imethod_2(stringValue);
					list2.Add(gclass4);
				}
				num3++;
			}
		}
		if (nvdrs_SETTING_VALUES2.settingType == 1)
		{
			gclass2.method_11(nvdrs_SETTING_VALUES2.defaultValue.binaryValue);
			gclass2.method_21(new List<GClass277<byte[]>>());
			int num4 = 0;
			while ((long)num4 < (long)((ulong)nvdrs_SETTING_VALUES2.numSettingValues))
			{
				byte[] binaryValue = nvdrs_SETTING_VALUES2.settingValues[num4].binaryValue;
				if (binaryValue != null)
				{
					List<GClass277<byte[]>> list3 = gclass2.method_20();
					GClass277<byte[]> gclass5 = new GClass277<byte[]>(this.imethod_0());
					gclass5.method_3(binaryValue);
					gclass5.imethod_2(GClass223.smethod_6(binaryValue));
					list3.Add(gclass5);
				}
				num4++;
			}
		}
		return gclass2;
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00045AF0 File Offset: 0x00043CF0
	private GClass112 method_2(uint uint_0)
	{
		if (this.dictionary_0.ContainsKey(uint_0))
		{
			return this.dictionary_0[uint_0];
		}
		GClass112 gclass = this.method_1(uint_0);
		if (gclass != null)
		{
			this.dictionary_0.Add(uint_0, gclass);
			return gclass;
		}
		return null;
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00045B34 File Offset: 0x00043D34
	public string imethod_2(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_4();
		}
		return null;
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00045B54 File Offset: 0x00043D54
	public uint? imethod_4(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return new uint?(gclass.method_8());
		}
		return null;
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00045B84 File Offset: 0x00043D84
	public string imethod_5(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_6();
		}
		return null;
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00045BA4 File Offset: 0x00043DA4
	public List<GClass277<string>> imethod_7(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_16();
		}
		return null;
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00045BC4 File Offset: 0x00043DC4
	public List<GClass277<uint>> imethod_8(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_18();
		}
		return null;
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x0000812A File Offset: 0x0000632A
	public List<uint> imethod_10()
	{
		return this.list_0;
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00045BE4 File Offset: 0x00043DE4
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_0();
		}
		return null;
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x000039D3 File Offset: 0x00001BD3
	public string imethod_3(uint uint_0)
	{
		return null;
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00045C0C File Offset: 0x00043E0C
	public byte[] imethod_6(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_10();
		}
		return null;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00045C2C File Offset: 0x00043E2C
	public List<GClass277<byte[]>> imethod_9(uint uint_0)
	{
		GClass112 gclass = this.method_2(uint_0);
		if (gclass != null)
		{
			return gclass.method_20();
		}
		return null;
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00004E86 File Offset: 0x00003086
	public GEnum4 imethod_0()
	{
		return GEnum4.DriverSettings;
	}

	// Token: 0x040006A7 RID: 1703
	private readonly Dictionary<uint, GClass112> dictionary_0 = new Dictionary<uint, GClass112>();

	// Token: 0x040006A8 RID: 1704
	private readonly List<uint> list_0;
}
