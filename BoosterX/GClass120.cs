using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020000D7 RID: 215
public sealed class GClass120 : GClass119
{
	// Token: 0x060006A2 RID: 1698 RVA: 0x0003B078 File Offset: 0x00039278
	public GClass120(GClass50 gclass50_1) : base(gclass50_1, null)
	{
		try
		{
			this.method_26();
		}
		catch
		{
		}
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x0003B0B4 File Offset: 0x000392B4
	private uint method_20(uint uint_0)
	{
		return BitConverter.ToUInt32(new byte[]
		{
			GClass120.byte_0[(int)(uint_0 & 255U)],
			GClass120.byte_0[(int)(uint_0 + 1U & 255U)],
			GClass120.byte_0[(int)(uint_0 + 2U & 255U)],
			GClass120.byte_0[(int)(uint_0 + 3U & 255U)]
		}, 0);
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x0003B114 File Offset: 0x00039314
	public uint method_21(uint uint_0, uint uint_1)
	{
		uint uint_2 = uint_1 << 1;
		uint num = this.method_20(uint_2);
		return uint_0 ^ num;
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x0003B130 File Offset: 0x00039330
	public string method_22(byte[] byte_1, uint uint_0)
	{
		uint num = uint_0 << 1;
		for (uint num2 = 0U; num2 < (uint)byte_1.Length; num2 += 1U)
		{
			uint num3 = num2;
			byte_1[(int)num3] = (byte_1[(int)num3] ^ GClass120.byte_0[(int)(num + num2 & 255U)]);
		}
		return Encoding.Unicode.GetString(byte_1).Trim(new char[1]);
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0003B180 File Offset: 0x00039380
	public void method_23(string string_0, ref NVDRS_SETTING nvdrs_SETTING_0)
	{
		if (nvdrs_SETTING_0.isPredefinedValid == 1U && this.method_25(string_0, nvdrs_SETTING_0.settingId))
		{
			if (nvdrs_SETTING_0.settingType == 3)
			{
				nvdrs_SETTING_0.predefinedValue.stringValue = this.method_22(nvdrs_SETTING_0.predefinedValue.rawData, nvdrs_SETTING_0.settingId);
				if (nvdrs_SETTING_0.isCurrentPredefined == 1U)
				{
					nvdrs_SETTING_0.currentValue.stringValue = this.method_22(nvdrs_SETTING_0.currentValue.rawData, nvdrs_SETTING_0.settingId);
					return;
				}
			}
			else if (nvdrs_SETTING_0.settingType == null)
			{
				nvdrs_SETTING_0.predefinedValue.dwordValue = this.method_21(nvdrs_SETTING_0.predefinedValue.dwordValue, nvdrs_SETTING_0.settingId);
				if (nvdrs_SETTING_0.isCurrentPredefined == 1U)
				{
					nvdrs_SETTING_0.currentValue.dwordValue = this.method_21(nvdrs_SETTING_0.currentValue.dwordValue, nvdrs_SETTING_0.settingId);
				}
			}
		}
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00006257 File Offset: 0x00004457
	private string method_24(string string_0, uint uint_0)
	{
		return string_0 + uint_0.ToString("X8").ToLowerInvariant();
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00006271 File Offset: 0x00004471
	public bool method_25(string string_0, uint uint_0)
	{
		return this.hashSet_0.Contains(this.method_24(string_0, uint_0));
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x0003B258 File Offset: 0x00039458
	private void method_26()
	{
		GClass120.Class141 @class = new GClass120.Class141();
		@class.gclass120_0 = this;
		@class.string_0 = GClass264.smethod_0();
		try
		{
			base.method_1(new Action<IntPtr>(@class.method_0), false, false);
			if (File.Exists(@class.string_0))
			{
				string[] array = File.ReadAllLines(@class.string_0);
				this.hashSet_0 = new HashSet<string>();
				Regex regex = new Regex("Profile\\s\\\"(?<profileName>.*?)\\\"", RegexOptions.Compiled);
				Regex regex2 = new Regex("ID_0x(?<sid>[0-9a-fA-F]+)\\s\\=.*?InternalSettingFlag\\=V0", RegexOptions.Compiled);
				string str = string.Empty;
				for (int i = 0; i < array.Length; i++)
				{
					foreach (object obj in regex.Matches(array[i]))
					{
						str = ((Match)obj).Result("${profileName}");
					}
					foreach (object obj2 in regex2.Matches(array[i]))
					{
						Match match = (Match)obj2;
						this.hashSet_0.Add(str + match.Result("${sid}"));
					}
				}
			}
		}
		catch
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
	}

	// Token: 0x04000384 RID: 900
	private static readonly byte[] byte_0 = new byte[]
	{
		47,
		124,
		79,
		139,
		32,
		36,
		82,
		141,
		38,
		60,
		148,
		119,
		243,
		124,
		152,
		165,
		250,
		113,
		182,
		128,
		221,
		53,
		132,
		186,
		253,
		182,
		166,
		27,
		57,
		196,
		204,
		176,
		126,
		149,
		217,
		238,
		24,
		75,
		156,
		245,
		45,
		78,
		208,
		193,
		85,
		23,
		223,
		24,
		30,
		11,
		24,
		139,
		136,
		88,
		134,
		90,
		30,
		3,
		237,
		86,
		251,
		22,
		254,
		138,
		1,
		50,
		156,
		141,
		242,
		232,
		74,
		230,
		144,
		142,
		21,
		104,
		232,
		45,
		244,
		64,
		55,
		154,
		114,
		199,
		2,
		12,
		209,
		211,
		88,
		234,
		98,
		209,
		152,
		54,
		43,
		178,
		22,
		213,
		222,
		147,
		241,
		186,
		116,
		227,
		50,
		196,
		159,
		246,
		18,
		254,
		24,
		192,
		187,
		53,
		121,
		156,
		107,
		122,
		35,
		127,
		43,
		21,
		155,
		66,
		7,
		26,
		byte.MaxValue,
		105,
		251,
		156,
		189,
		35,
		151,
		168,
		34,
		99,
		143,
		50,
		200,
		233,
		155,
		99,
		28,
		238,
		44,
		217,
		237,
		141,
		58,
		53,
		156,
		177,
		96,
		174,
		94,
		245,
		151,
		107,
		159,
		32,
		140,
		247,
		152,
		44,
		67,
		121,
		149,
		29,
		205,
		70,
		54,
		108,
		217,
		103,
		32,
		171,
		65,
		34,
		33,
		229,
		85,
		130,
		245,
		39,
		32,
		245,
		8,
		7,
		63,
		109,
		105,
		217,
		28,
		75,
		248,
		38,
		3,
		110,
		178,
		63,
		30,
		230,
		202,
		61,
		97,
		68,
		176,
		146,
		175,
		240,
		136,
		202,
		224,
		95,
		93,
		244,
		223,
		198,
		76,
		164,
		224,
		202,
		176,
		32,
		93,
		192,
		250,
		221,
		154,
		52,
		143,
		80,
		121,
		90,
		95,
		124,
		25,
		158,
		64,
		112,
		113,
		181,
		69,
		25,
		184,
		83,
		252,
		223,
		36,
		190,
		34,
		28,
		121,
		191,
		66,
		137
	};

	// Token: 0x04000385 RID: 901
	private HashSet<string> hashSet_0 = new HashSet<string>();

	// Token: 0x020000D8 RID: 216
	private sealed class Class141
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x00006286 File Offset: 0x00004486
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass120_0.method_19(intptr_0, this.string_0);
		}

		// Token: 0x04000386 RID: 902
		public GClass120 gclass120_0;

		// Token: 0x04000387 RID: 903
		public string string_0;
	}
}
