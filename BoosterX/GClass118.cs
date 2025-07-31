using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

// Token: 0x02000380 RID: 896
public sealed class GClass118
{
	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x0600174C RID: 5964 RVA: 0x00010072 File Offset: 0x0000E272
	// (set) Token: 0x0600174D RID: 5965 RVA: 0x0001007A File Offset: 0x0000E27A
	[JsonProperty("categories")]
	public IDictionary<string, bool> IDictionary_0
	{
		get
		{
			return this.idictionary_0;
		}
		set
		{
			this.idictionary_0 = value;
		}
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x0600174E RID: 5966 RVA: 0x00010083 File Offset: 0x0000E283
	// (set) Token: 0x0600174F RID: 5967 RVA: 0x0001008B File Offset: 0x0000E28B
	[JsonProperty("category_scores")]
	public IDictionary<string, double> IDictionary_1
	{
		get
		{
			return this.idictionary_1;
		}
		set
		{
			this.idictionary_1 = value;
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x06001750 RID: 5968 RVA: 0x00010094 File Offset: 0x0000E294
	// (set) Token: 0x06001751 RID: 5969 RVA: 0x0001009C File Offset: 0x0000E29C
	[JsonProperty("flagged")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06001752 RID: 5970 RVA: 0x0006AEFC File Offset: 0x000690FC
	public IList<string> FlaggedCategories
	{
		get
		{
			return this.IDictionary_0.Where(new Func<KeyValuePair<string, bool>, bool>(GClass118.Class420.class420_0.method_0)).OrderByDescending(new Func<KeyValuePair<string, bool>, double?>(this.method_0)).Select(new Func<KeyValuePair<string, bool>, string>(GClass118.Class420.class420_0.method_1)).ToList<string>();
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06001753 RID: 5971 RVA: 0x000100A5 File Offset: 0x0000E2A5
	public string MainContentFlag
	{
		get
		{
			return this.FlaggedCategories.FirstOrDefault<string>();
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06001754 RID: 5972 RVA: 0x0006AF70 File Offset: 0x00069170
	public double HighestFlagScore
	{
		get
		{
			return this.IDictionary_1.OrderByDescending(new Func<KeyValuePair<string, double>, double>(GClass118.Class420.class420_0.method_2)).First<KeyValuePair<string, double>>().Value;
		}
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x0006AFB4 File Offset: 0x000691B4
	private double? method_0(KeyValuePair<string, bool> keyValuePair_0)
	{
		IDictionary<string, double> dictionary = this.IDictionary_1;
		if (dictionary == null)
		{
			return null;
		}
		return new double?(dictionary[keyValuePair_0.Key]);
	}

	// Token: 0x04000F73 RID: 3955
	private IDictionary<string, bool> idictionary_0;

	// Token: 0x04000F74 RID: 3956
	private IDictionary<string, double> idictionary_1;

	// Token: 0x04000F75 RID: 3957
	private bool bool_0;

	// Token: 0x02000381 RID: 897
	[Serializable]
	private sealed class Class420
	{
		// Token: 0x06001758 RID: 5976 RVA: 0x000100BE File Offset: 0x0000E2BE
		internal bool method_0(KeyValuePair<string, bool> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000100C7 File Offset: 0x0000E2C7
		internal string method_1(KeyValuePair<string, bool> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000100D0 File Offset: 0x0000E2D0
		internal double method_2(KeyValuePair<string, double> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}

		// Token: 0x04000F76 RID: 3958
		public static readonly GClass118.Class420 class420_0 = new GClass118.Class420();

		// Token: 0x04000F77 RID: 3959
		public static Func<KeyValuePair<string, bool>, bool> func_0;

		// Token: 0x04000F78 RID: 3960
		public static Func<KeyValuePair<string, bool>, string> func_1;

		// Token: 0x04000F79 RID: 3961
		public static Func<KeyValuePair<string, double>, double> func_2;
	}
}
