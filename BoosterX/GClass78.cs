using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000282 RID: 642
public sealed class GClass78
{
	// Token: 0x06001128 RID: 4392 RVA: 0x0000C81D File Offset: 0x0000AA1D
	public GClass78()
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00059534 File Offset: 0x00057734
	public GClass78(GClass78 gclass78_0)
	{
		if (gclass78_0 == null)
		{
			return;
		}
		this.String_0 = gclass78_0.String_0;
		this.IList_0 = gclass78_0.IList_0;
		this.Nullable_0 = gclass78_0.Nullable_0;
		this.Nullable_1 = gclass78_0.Nullable_1;
		this.Nullable_2 = gclass78_0.Nullable_2;
		this.String_1 = gclass78_0.String_1;
		this.Nullable_3 = gclass78_0.Nullable_3;
		this.Nullable_4 = gclass78_0.Nullable_4;
		this.Nullable_5 = gclass78_0.Nullable_5;
		this.IReadOnlyDictionary_0 = gclass78_0.IReadOnlyDictionary_0;
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x0600112A RID: 4394 RVA: 0x0000C841 File Offset: 0x0000AA41
	// (set) Token: 0x0600112B RID: 4395 RVA: 0x0000C849 File Offset: 0x0000AA49
	[JsonProperty("model")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x0600112C RID: 4396 RVA: 0x0000C852 File Offset: 0x0000AA52
	// (set) Token: 0x0600112D RID: 4397 RVA: 0x0000C85A File Offset: 0x0000AA5A
	[JsonProperty("messages")]
	public IList<GClass258> IList_0
	{
		get
		{
			return this.ilist_0;
		}
		set
		{
			this.ilist_0 = value;
		}
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x0600112E RID: 4398 RVA: 0x0000C863 File Offset: 0x0000AA63
	// (set) Token: 0x0600112F RID: 4399 RVA: 0x0000C86B File Offset: 0x0000AA6B
	[JsonProperty("temperature")]
	public double? Nullable_0
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x06001130 RID: 4400 RVA: 0x0000C874 File Offset: 0x0000AA74
	// (set) Token: 0x06001131 RID: 4401 RVA: 0x0000C87C File Offset: 0x0000AA7C
	[JsonProperty("top_p")]
	public double? Nullable_1
	{
		get
		{
			return this.nullable_1;
		}
		set
		{
			this.nullable_1 = value;
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x06001132 RID: 4402 RVA: 0x0000C885 File Offset: 0x0000AA85
	// (set) Token: 0x06001133 RID: 4403 RVA: 0x0000C88D File Offset: 0x0000AA8D
	[JsonProperty("n")]
	public int? Nullable_2
	{
		get
		{
			return this.nullable_2;
		}
		set
		{
			this.nullable_2 = value;
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06001134 RID: 4404 RVA: 0x0000C896 File Offset: 0x0000AA96
	// (set) Token: 0x06001135 RID: 4405 RVA: 0x0000C89E File Offset: 0x0000AA9E
	[JsonProperty("stream")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		internal set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x06001136 RID: 4406 RVA: 0x0000C8A7 File Offset: 0x0000AAA7
	[JsonProperty("stop")]
	internal object Object_0
	{
		get
		{
			string[] array = this.String_1;
			if (array != null && array.Length == 1)
			{
				return this.String_2;
			}
			string[] array2 = this.String_1;
			if (array2 != null && array2.Length != 0)
			{
				return this.String_1;
			}
			return null;
		}
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06001137 RID: 4407 RVA: 0x0000C8DF File Offset: 0x0000AADF
	// (set) Token: 0x06001138 RID: 4408 RVA: 0x0000C8E7 File Offset: 0x0000AAE7
	[JsonIgnore]
	public string[] String_1
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

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06001139 RID: 4409 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
	// (set) Token: 0x0600113A RID: 4410 RVA: 0x0000C909 File Offset: 0x0000AB09
	[JsonIgnore]
	public string String_2
	{
		get
		{
			string[] array = this.String_1;
			string result;
			if (array != null)
			{
				if ((result = Class746.smethod_2<string>(array)) != null)
				{
					return result;
				}
			}
			result = null;
			return result;
		}
		set
		{
			if (value != null)
			{
				this.String_1 = new string[]
				{
					value
				};
			}
		}
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x0600113B RID: 4411 RVA: 0x0000C91E File Offset: 0x0000AB1E
	// (set) Token: 0x0600113C RID: 4412 RVA: 0x0000C926 File Offset: 0x0000AB26
	[JsonProperty("max_tokens")]
	public int? Nullable_3
	{
		get
		{
			return this.nullable_3;
		}
		set
		{
			this.nullable_3 = value;
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x0600113D RID: 4413 RVA: 0x0000C92F File Offset: 0x0000AB2F
	// (set) Token: 0x0600113E RID: 4414 RVA: 0x0000C937 File Offset: 0x0000AB37
	[JsonProperty("frequency_penalty")]
	public double? Nullable_4
	{
		get
		{
			return this.nullable_4;
		}
		set
		{
			this.nullable_4 = value;
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x0600113F RID: 4415 RVA: 0x0000C940 File Offset: 0x0000AB40
	// (set) Token: 0x06001140 RID: 4416 RVA: 0x0000C948 File Offset: 0x0000AB48
	[JsonProperty("presence_penalty")]
	public double? Nullable_5
	{
		get
		{
			return this.nullable_5;
		}
		set
		{
			this.nullable_5 = value;
		}
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06001141 RID: 4417 RVA: 0x0000C951 File Offset: 0x0000AB51
	// (set) Token: 0x06001142 RID: 4418 RVA: 0x0000C959 File Offset: 0x0000AB59
	[JsonProperty("logit_bias")]
	public IReadOnlyDictionary<string, float> IReadOnlyDictionary_0
	{
		get
		{
			return this.ireadOnlyDictionary_0;
		}
		set
		{
			this.ireadOnlyDictionary_0 = value;
		}
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06001143 RID: 4419 RVA: 0x0000C962 File Offset: 0x0000AB62
	// (set) Token: 0x06001144 RID: 4420 RVA: 0x0000C96A File Offset: 0x0000AB6A
	[JsonProperty("user")]
	public string String_3
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x06001145 RID: 4421 RVA: 0x0000C973 File Offset: 0x0000AB73
	// (set) Token: 0x06001146 RID: 4422 RVA: 0x0000C97B File Offset: 0x0000AB7B
	[JsonIgnore]
	public string String_4
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x06001147 RID: 4423 RVA: 0x0000C984 File Offset: 0x0000AB84
	[JsonProperty("response_format", DefaultValueHandling = 1)]
	internal Dictionary<string, string> Dictionary_0
	{
		get
		{
			if (this.String_4 != null && !(this.String_4 == "text"))
			{
				return new Dictionary<string, string>
				{
					{
						"type",
						this.String_4
					}
				};
			}
			return null;
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x06001148 RID: 4424 RVA: 0x0000C9BA File Offset: 0x0000ABBA
	// (set) Token: 0x06001149 RID: 4425 RVA: 0x0000C9C2 File Offset: 0x0000ABC2
	[JsonProperty("seed", DefaultValueHandling = 1)]
	public int? Nullable_6
	{
		get
		{
			return this.nullable_6;
		}
		set
		{
			this.nullable_6 = value;
		}
	}

	// Token: 0x04000ABB RID: 2747
	private string string_0 = GClass27.smethod_2();

	// Token: 0x04000ABC RID: 2748
	private IList<GClass258> ilist_0;

	// Token: 0x04000ABD RID: 2749
	private double? nullable_0;

	// Token: 0x04000ABE RID: 2750
	private double? nullable_1;

	// Token: 0x04000ABF RID: 2751
	private int? nullable_2;

	// Token: 0x04000AC0 RID: 2752
	private bool bool_0;

	// Token: 0x04000AC1 RID: 2753
	private string[] string_1;

	// Token: 0x04000AC2 RID: 2754
	private int? nullable_3;

	// Token: 0x04000AC3 RID: 2755
	private double? nullable_4;

	// Token: 0x04000AC4 RID: 2756
	private double? nullable_5;

	// Token: 0x04000AC5 RID: 2757
	private IReadOnlyDictionary<string, float> ireadOnlyDictionary_0;

	// Token: 0x04000AC6 RID: 2758
	private string string_2;

	// Token: 0x04000AC7 RID: 2759
	private string string_3 = "text";

	// Token: 0x04000AC8 RID: 2760
	private int? nullable_6;

	// Token: 0x02000283 RID: 643
	public static class GClass79
	{
	}
}
