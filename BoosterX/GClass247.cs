using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x02000590 RID: 1424
public static class GClass247
{
	// Token: 0x060023E0 RID: 9184 RVA: 0x0008C7A4 File Offset: 0x0008A9A4
	private static ValueTuple<int, int> smethod_0(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return new ValueTuple<int, int>(1920, 1080);
		}
		string[] array = string_0.Replace('×', 'x').Split(new char[]
		{
			'x'
		}, StringSplitOptions.RemoveEmptyEntries);
		int num;
		int num2;
		if (array.Length == 2 && int.TryParse(array[0], out num) && int.TryParse(array[1], out num2) && num > 0 && num2 > 0)
		{
			return new ValueTuple<int, int>(num, num2);
		}
		return new ValueTuple<int, int>(1920, 1080);
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x0008C828 File Offset: 0x0008AA28
	private static ValueTuple<double, double> smethod_1(double double_0, int int_0, int int_1)
	{
		double num = (double)(int_0 * int_1) / 2073600.0;
		double num2 = (25.0 + 0.0002 * double_0) * num;
		return new ValueTuple<double, double>(num2 * 0.4, num2);
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x0008C870 File Offset: 0x0008AA70
	public static List<GClass247.GClass248> smethod_2(string string_0)
	{
		List<GClass247.GClass248> list = JObject.Parse(string_0)["d"].ToObject<List<GClass247.GClass248>>();
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		dictionary["%"] = "Intel";
		dictionary["#"] = "AMD";
		dictionary["?"] = "Core";
		dictionary["^"] = "Ryzen";
		dictionary["@"] = "Pentium";
		dictionary["&"] = "Xeon";
		dictionary["!"] = "QUALCOMM";
		dictionary["№"] = "NVIDIA";
		dictionary["*"] = "GeForce";
		dictionary["~"] = "Radeon";
		dictionary[">"] = "RTX";
		Dictionary<string, string> dictionary2 = dictionary;
		foreach (GClass247.GClass248 gclass in list)
		{
			foreach (KeyValuePair<string, string> keyValuePair in dictionary2)
			{
				string pattern = Regex.Escape(keyValuePair.Key);
				gclass.Name = Regex.Replace(gclass.Name, pattern, keyValuePair.Value, RegexOptions.IgnoreCase);
				if (!string.IsNullOrEmpty(gclass.String_0))
				{
					gclass.String_0 = Regex.Replace(gclass.String_0, pattern, keyValuePair.Value, RegexOptions.IgnoreCase);
				}
			}
		}
		return list;
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x0001789D File Offset: 0x00015A9D
	private static string smethod_3(string string_0)
	{
		return Regex.Replace(string_0.ToLowerInvariant(), "[^0-9a-z]", string.Empty);
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x0008CA30 File Offset: 0x0008AC30
	private static string smethod_4(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return string_0;
		}
		string_0 = Regex.Replace(string_0, "\\b\\d+(st|nd|rd|th)\\s+Gen\\b", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "[\\(\\)®™]", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "tm", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "\\bprocessor\\b", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "\\bcpu\\b", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "@", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "\\b\\d+-core\\b", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "\\b[a-zA-Z]+-core\\b", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "\\bwith\\b.*$", string.Empty, RegexOptions.IgnoreCase);
		string_0 = Regex.Replace(string_0, "\\b\\d+(\\.\\d+)?\\s*ghz\\b", string.Empty, RegexOptions.IgnoreCase);
		return Regex.Replace(string_0, "\\s+", " ").Trim();
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x0008CB3C File Offset: 0x0008AD3C
	private static ValueTuple<GClass247.GClass248, double> smethod_5(string string_0, List<GClass247.GClass248> list_0)
	{
		GClass247.Class691 @class = new GClass247.Class691();
		string string_ = GClass247.smethod_4(string_0);
		@class.string_0 = GClass247.smethod_3(string_);
		List<Class786<GClass247.GClass248, int>> list = list_0.Select(new Func<GClass247.GClass248, Class786<GClass247.GClass248, int>>(@class.method_0)).OrderBy(new Func<Class786<GClass247.GClass248, int>, int>(GClass247.Class692.class692_0.method_0)).ThenBy(new Func<Class786<GClass247.GClass248, int>, int>(@class.method_1)).ToList<Class786<GClass247.GClass248, int>>();
		if (!Class746.smethod_3<Class786<GClass247.GClass248, int>>(list))
		{
			throw new ArgumentException("Device '" + string_0 + "' not found in database");
		}
		GClass247.GClass248 gclass = list.First<Class786<GClass247.GClass248, int>>().method_0();
		if (gclass.Int32_0 <= 0)
		{
			throw new ArgumentException(gclass.Name + " has no valid score in DB");
		}
		return new ValueTuple<GClass247.GClass248, double>(gclass, (double)gclass.Int32_0);
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x000178B5 File Offset: 0x00015AB5
	public static ValueTuple<GClass247.GClass248, double> smethod_6(string string_0, List<GClass247.GClass248> list_0)
	{
		return GClass247.smethod_5(string_0, list_0);
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x0008CC08 File Offset: 0x0008AE08
	public static ValueTuple<int, int> smethod_7(double double_0, double double_1, string string_0)
	{
		ValueTuple<int, int> valueTuple = GClass247.smethod_0(string_0);
		int item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		ValueTuple<double, double> valueTuple2 = GClass247.smethod_1(double_1, item, item2);
		double item3 = valueTuple2.Item1;
		double item4 = valueTuple2.Item2;
		double num = double_1 / double_0;
		int item5 = 0;
		int item6 = 0;
		if (num > item4)
		{
			double val = (num - item4) / (num + 0.28 * item4);
			item5 = (int)Math.Round(Math.Min(1.0, Math.Max(0.0, val)) * 100.0);
		}
		else if (num < item3)
		{
			double val2 = (item3 - num) / (item3 + 0.28 * num);
			item6 = (int)Math.Round(Math.Min(1.0, Math.Max(0.0, val2)) * 100.0);
		}
		return new ValueTuple<int, int>(item5, item6);
	}

	// Token: 0x02000591 RID: 1425
	private sealed class Class691
	{
		// Token: 0x060023E9 RID: 9193 RVA: 0x000178BE File Offset: 0x00015ABE
		internal Class786<GClass247.GClass248, int> method_0(GClass247.GClass248 gclass248_0)
		{
			return new Class786<GClass247.GClass248, int>(gclass248_0, Class249.smethod_12(GClass247.smethod_3(gclass248_0.Name), this.string_0));
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x000178DC File Offset: 0x00015ADC
		internal int method_1(Class786<GClass247.GClass248, int> class786_0)
		{
			return Math.Abs(GClass247.smethod_3(class786_0.method_0().Name).Length - this.string_0.Length);
		}

		// Token: 0x040017AB RID: 6059
		public string string_0;
	}

	// Token: 0x02000592 RID: 1426
	[Serializable]
	private sealed class Class692
	{
		// Token: 0x060023ED RID: 9197 RVA: 0x00017910 File Offset: 0x00015B10
		internal int method_0(Class786<GClass247.GClass248, int> class786_0)
		{
			return class786_0.method_1();
		}

		// Token: 0x040017AC RID: 6060
		public static readonly GClass247.Class692 class692_0 = new GClass247.Class692();

		// Token: 0x040017AD RID: 6061
		public static Func<Class786<GClass247.GClass248, int>, int> func_0;
	}

	// Token: 0x02000593 RID: 1427
	public sealed class GClass248
	{
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x00017918 File Offset: 0x00015B18
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x00017920 File Offset: 0x00015B20
		[JsonProperty("n")]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x00017929 File Offset: 0x00015B29
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x00017931 File Offset: 0x00015B31
		[JsonProperty("s")]
		public int Int32_0
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0001793A File Offset: 0x00015B3A
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x00017942 File Offset: 0x00015B42
		[JsonProperty("m")]
		public string String_0
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0001794B File Offset: 0x00015B4B
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x00017953 File Offset: 0x00015B53
		[JsonProperty("f")]
		public double Double_0
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0001795C File Offset: 0x00015B5C
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x00017964 File Offset: 0x00015B64
		[JsonProperty("c")]
		public int Int32_1
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x040017AE RID: 6062
		private string string_0;

		// Token: 0x040017AF RID: 6063
		private int int_0;

		// Token: 0x040017B0 RID: 6064
		private string string_1;

		// Token: 0x040017B1 RID: 6065
		private double double_0;

		// Token: 0x040017B2 RID: 6066
		private int int_1;
	}
}
