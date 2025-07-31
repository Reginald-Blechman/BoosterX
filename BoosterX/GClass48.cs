using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x020001D0 RID: 464
public sealed class GClass48 : GInterface9
{
	// Token: 0x06000CC6 RID: 3270 RVA: 0x0004CC10 File Offset: 0x0004AE10
	public GClass48()
	{
		this.dictionary_0 = this.method_0();
		this.imethod_10();
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0004CC68 File Offset: 0x0004AE68
	private Dictionary<ESetting, Type> method_0()
	{
		Dictionary<ESetting, Type> dictionary = new Dictionary<ESetting, Type>();
		List<Type> source = Assembly.GetExecutingAssembly().GetTypes().Where(new Func<Type, bool>(GClass48.Class225.class225_0.method_0)).ToList<Type>();
		using (List<string>.Enumerator enumerator = Enum.GetNames(typeof(ESetting)).Distinct<string>().ToList<string>().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass48.Class223 @class = new GClass48.Class223();
				@class.string_0 = enumerator.Current;
				if (!this.string_0.Contains(@class.string_0))
				{
					Type type = source.FirstOrDefault(new Func<Type, bool>(@class.method_0));
					if (type != null)
					{
						ESetting key = (ESetting)Enum.Parse(typeof(ESetting), @class.string_0);
						dictionary.Add(key, type);
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00009BFD File Offset: 0x00007DFD
	public Type method_1(uint uint_0)
	{
		if (this.dictionary_0.ContainsKey(uint_0))
		{
			return this.dictionary_0[uint_0];
		}
		return null;
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x0004CD64 File Offset: 0x0004AF64
	public NVDRS_SETTING_TYPE? imethod_1(uint uint_0)
	{
		return null;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x0004CD7C File Offset: 0x0004AF7C
	public string imethod_2(uint uint_0)
	{
		if (this.hashSet_0.Contains(uint_0))
		{
			ESetting esetting = uint_0;
			return esetting.ToString();
		}
		return null;
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x0004CDA8 File Offset: 0x0004AFA8
	public uint? imethod_4(uint uint_0)
	{
		if (this.dictionary_0.ContainsKey(uint_0))
		{
			Type enumType = this.dictionary_0[uint_0];
			string text = Enum.GetNames(enumType).FirstOrDefault(new Func<string, bool>(GClass48.Class225.class225_0.method_1));
			if (text != null)
			{
				return new uint?((uint)Enum.Parse(enumType, text));
			}
		}
		return null;
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x000039D3 File Offset: 0x00001BD3
	public string imethod_5(uint uint_0)
	{
		return null;
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x000039D3 File Offset: 0x00001BD3
	public List<GClass277<string>> imethod_7(uint uint_0)
	{
		return null;
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x0004CE1C File Offset: 0x0004B01C
	private uint method_2(Type type_0, string string_1)
	{
		uint result;
		try
		{
			result = (uint)Enum.Parse(type_0, string_1);
		}
		catch (InvalidCastException)
		{
			result = BitConverter.ToUInt32(BitConverter.GetBytes((int)Enum.Parse(type_0, string_1)), 0);
		}
		return result;
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x0004CE64 File Offset: 0x0004B064
	public List<GClass277<uint>> imethod_8(uint uint_0)
	{
		GClass48.Class224 @class = new GClass48.Class224();
		@class.gclass48_0 = this;
		if (this.dictionary_0.ContainsKey(uint_0))
		{
			@class.type_0 = this.dictionary_0[uint_0];
			return Enum.GetNames(@class.type_0).Where(new Func<string, bool>(GClass48.Class225.class225_0.method_2)).ToList<string>().Select(new Func<string, GClass277<uint>>(@class.method_0)).ToList<GClass277<uint>>();
		}
		return null;
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x0004CEEC File Offset: 0x0004B0EC
	public List<uint> imethod_10()
	{
		if (this.hashSet_0 == null)
		{
			this.hashSet_0 = new HashSet<uint>(Enum.GetValues(typeof(ESetting)).Cast<ESetting>().Where(new Func<ESetting, bool>(this.method_3)).Cast<uint>().Distinct<uint>().ToList<uint>());
		}
		return this.hashSet_0.ToList<uint>();
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x000039D3 File Offset: 0x00001BD3
	public string imethod_3(uint uint_0)
	{
		return null;
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x000039D3 File Offset: 0x00001BD3
	public byte[] imethod_6(uint uint_0)
	{
		return null;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x000039D3 File Offset: 0x00001BD3
	public List<GClass277<byte[]>> imethod_9(uint uint_0)
	{
		return null;
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00009C1B File Offset: 0x00007E1B
	public GEnum4 imethod_0()
	{
		return GEnum4.ConstantSettings;
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00009C1F File Offset: 0x00007E1F
	private bool method_3(ESetting esetting_0)
	{
		return !this.string_0.Contains(esetting_0.ToString());
	}

	// Token: 0x04000832 RID: 2098
	private readonly Dictionary<ESetting, Type> dictionary_0;

	// Token: 0x04000833 RID: 2099
	private string[] string_0 = new string[]
	{
		"TOTAL_DWORD_SETTING_NUM",
		"TOTAL_WSTRING_SETTING_NUM",
		"TOTAL_SETTING_NUM",
		"INVALID_SETTING_ID"
	};

	// Token: 0x04000834 RID: 2100
	private HashSet<uint> hashSet_0;

	// Token: 0x020001D1 RID: 465
	private sealed class Class223
	{
		// Token: 0x06000CD7 RID: 3287 RVA: 0x00009C3C File Offset: 0x00007E3C
		internal bool method_0(Type type_0)
		{
			return this.string_0.Substring(0, this.string_0.Length - 3).Equals(type_0.Name.Substring(8));
		}

		// Token: 0x04000835 RID: 2101
		public string string_0;
	}

	// Token: 0x020001D2 RID: 466
	private sealed class Class224
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x0004CF4C File Offset: 0x0004B14C
		internal GClass277<uint> method_0(string string_0)
		{
			GClass277<uint> gclass = new GClass277<uint>(this.gclass48_0.imethod_0());
			gclass.method_3(this.gclass48_0.method_2(this.type_0, string_0));
			gclass.imethod_2(GClass223.smethod_0(this.gclass48_0.method_2(this.type_0, string_0)) + " " + string_0);
			return gclass;
		}

		// Token: 0x04000836 RID: 2102
		public GClass48 gclass48_0;

		// Token: 0x04000837 RID: 2103
		public Type type_0;
	}

	// Token: 0x020001D3 RID: 467
	[Serializable]
	private sealed class Class225
	{
		// Token: 0x06000CDC RID: 3292 RVA: 0x00009C74 File Offset: 0x00007E74
		internal bool method_0(Type type_0)
		{
			return type_0.Namespace == "nspector.Native.NvApi.DriverSettings" && type_0.IsEnum && type_0.Name.StartsWith("EValues_");
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00009CA4 File Offset: 0x00007EA4
		internal bool method_1(string string_0)
		{
			return string_0.EndsWith("_DEFAULT");
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00009CB2 File Offset: 0x00007EB2
		internal bool method_2(string string_0)
		{
			return !string_0.EndsWith("_DEFAULT") && !string_0.EndsWith("_NUM_VALUES");
		}

		// Token: 0x04000838 RID: 2104
		public static readonly GClass48.Class225 class225_0 = new GClass48.Class225();

		// Token: 0x04000839 RID: 2105
		public static Func<Type, bool> func_0;

		// Token: 0x0400083A RID: 2106
		public static Func<string, bool> func_1;

		// Token: 0x0400083B RID: 2107
		public static Func<string, bool> func_2;
	}
}
