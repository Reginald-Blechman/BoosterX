using System;
using Newtonsoft.Json;

// Token: 0x02000417 RID: 1047
public sealed class GClass142
{
	// Token: 0x06001B4A RID: 6986 RVA: 0x000124A5 File Offset: 0x000106A5
	public GClass142()
	{
		this.String_0 = GClass27.smethod_0();
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x0007534C File Offset: 0x0007354C
	public GClass142(GClass142 gclass142_0)
	{
		this.String_0 = gclass142_0.String_0;
		this.String_1 = gclass142_0.String_1;
		this.Nullable_0 = gclass142_0.Nullable_0;
		this.Nullable_1 = gclass142_0.Nullable_1;
		this.Nullable_2 = gclass142_0.Nullable_2;
		this.Nullable_5 = gclass142_0.Nullable_5;
		this.Nullable_3 = gclass142_0.Nullable_3;
		this.Nullable_4 = gclass142_0.Nullable_4;
		this.Nullable_6 = gclass142_0.Nullable_6;
		this.Nullable_7 = gclass142_0.Nullable_7;
		this.String_4 = gclass142_0.String_4;
		this.Nullable_8 = gclass142_0.Nullable_8;
		this.String_6 = gclass142_0.String_6;
		this.String_3 = gclass142_0.String_3;
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x000124CD File Offset: 0x000106CD
	public GClass142(params string[] string_5)
	{
		this.String_1 = string_5;
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x00075418 File Offset: 0x00073618
	public GClass142(string string_5, GClass27 gclass27_0 = null, int? nullable_9 = null, double? nullable_10 = null, string string_6 = null, double? nullable_11 = null, int? nullable_12 = null, double? nullable_13 = null, double? nullable_14 = null, int? nullable_15 = null, bool? nullable_16 = null, params string[] string_7)
	{
		this.String_0 = gclass27_0;
		this.String_2 = string_5;
		this.Nullable_0 = nullable_9;
		this.Nullable_1 = nullable_10;
		this.String_3 = string_6;
		this.Nullable_2 = nullable_11;
		this.Nullable_5 = nullable_12;
		this.Nullable_3 = nullable_13;
		this.Nullable_4 = nullable_14;
		this.Nullable_6 = nullable_15;
		this.Nullable_7 = nullable_16;
		this.String_4 = string_7;
	}

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000124EC File Offset: 0x000106EC
	// (set) Token: 0x06001B4F RID: 6991 RVA: 0x000124F4 File Offset: 0x000106F4
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

	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x06001B50 RID: 6992 RVA: 0x000124FD File Offset: 0x000106FD
	[JsonProperty("prompt")]
	public object Object_0
	{
		get
		{
			string[] array = this.String_1;
			if (array != null && array.Length == 1)
			{
				return this.String_2;
			}
			return this.String_1;
		}
	}

	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00012520 File Offset: 0x00010720
	// (set) Token: 0x06001B52 RID: 6994 RVA: 0x00012528 File Offset: 0x00010728
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

	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00012531 File Offset: 0x00010731
	// (set) Token: 0x06001B54 RID: 6996 RVA: 0x0001253E File Offset: 0x0001073E
	[JsonIgnore]
	public string String_2
	{
		get
		{
			return Class746.smethod_2<string>(this.String_1);
		}
		set
		{
			this.String_1 = new string[]
			{
				value
			};
		}
	}

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00012550 File Offset: 0x00010750
	// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00012558 File Offset: 0x00010758
	[JsonProperty("suffix")]
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

	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00012561 File Offset: 0x00010761
	// (set) Token: 0x06001B58 RID: 7000 RVA: 0x00012569 File Offset: 0x00010769
	[JsonProperty("max_tokens")]
	public int? Nullable_0
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

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00012572 File Offset: 0x00010772
	// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0001257A File Offset: 0x0001077A
	[JsonProperty("temperature")]
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

	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00012583 File Offset: 0x00010783
	// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0001258B File Offset: 0x0001078B
	[JsonProperty("top_p")]
	public double? Nullable_2
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

	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00012594 File Offset: 0x00010794
	// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0001259C File Offset: 0x0001079C
	[JsonProperty("presence_penalty")]
	public double? Nullable_3
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

	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x06001B5F RID: 7007 RVA: 0x000125A5 File Offset: 0x000107A5
	// (set) Token: 0x06001B60 RID: 7008 RVA: 0x000125AD File Offset: 0x000107AD
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

	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x06001B61 RID: 7009 RVA: 0x000125B6 File Offset: 0x000107B6
	// (set) Token: 0x06001B62 RID: 7010 RVA: 0x000125BE File Offset: 0x000107BE
	[JsonProperty("n")]
	public int? Nullable_5
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

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x06001B63 RID: 7011 RVA: 0x000125C7 File Offset: 0x000107C7
	// (set) Token: 0x06001B64 RID: 7012 RVA: 0x000125CF File Offset: 0x000107CF
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

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x06001B65 RID: 7013 RVA: 0x000125D8 File Offset: 0x000107D8
	// (set) Token: 0x06001B66 RID: 7014 RVA: 0x000125E0 File Offset: 0x000107E0
	[JsonProperty("logprobs")]
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

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x06001B67 RID: 7015 RVA: 0x000125E9 File Offset: 0x000107E9
	// (set) Token: 0x06001B68 RID: 7016 RVA: 0x000125F1 File Offset: 0x000107F1
	[JsonProperty("echo")]
	public bool? Nullable_7
	{
		get
		{
			return this.nullable_7;
		}
		set
		{
			this.nullable_7 = value;
		}
	}

	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000125FA File Offset: 0x000107FA
	[JsonProperty("stop")]
	public object Object_1
	{
		get
		{
			string[] array = this.String_4;
			if (array != null && array.Length == 1)
			{
				return this.String_5;
			}
			string[] array2 = this.String_4;
			if (array2 != null && array2.Length != 0)
			{
				return this.String_4;
			}
			return null;
		}
	}

	// Token: 0x17000491 RID: 1169
	// (get) Token: 0x06001B6A RID: 7018 RVA: 0x00012632 File Offset: 0x00010832
	// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0001263A File Offset: 0x0001083A
	[JsonIgnore]
	public string[] String_4
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

	// Token: 0x17000492 RID: 1170
	// (get) Token: 0x06001B6C RID: 7020 RVA: 0x00012643 File Offset: 0x00010843
	// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0001265C File Offset: 0x0001085C
	[JsonIgnore]
	public string String_5
	{
		get
		{
			string[] array = this.String_4;
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
				this.String_4 = new string[]
				{
					value
				};
			}
		}
	}

	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x06001B6E RID: 7022 RVA: 0x00012671 File Offset: 0x00010871
	// (set) Token: 0x06001B6F RID: 7023 RVA: 0x00012679 File Offset: 0x00010879
	[JsonProperty("best_of")]
	public int? Nullable_8
	{
		get
		{
			return this.nullable_8;
		}
		set
		{
			this.nullable_8 = value;
		}
	}

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x06001B70 RID: 7024 RVA: 0x00012682 File Offset: 0x00010882
	// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0001268A File Offset: 0x0001088A
	[JsonProperty("user")]
	public string String_6
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x04001216 RID: 4630
	private string string_0 = GClass27.smethod_0();

	// Token: 0x04001217 RID: 4631
	private string[] string_1;

	// Token: 0x04001218 RID: 4632
	private string string_2;

	// Token: 0x04001219 RID: 4633
	private int? nullable_0;

	// Token: 0x0400121A RID: 4634
	private double? nullable_1;

	// Token: 0x0400121B RID: 4635
	private double? nullable_2;

	// Token: 0x0400121C RID: 4636
	private double? nullable_3;

	// Token: 0x0400121D RID: 4637
	private double? nullable_4;

	// Token: 0x0400121E RID: 4638
	private int? nullable_5;

	// Token: 0x0400121F RID: 4639
	private bool bool_0;

	// Token: 0x04001220 RID: 4640
	private int? nullable_6;

	// Token: 0x04001221 RID: 4641
	private bool? nullable_7;

	// Token: 0x04001222 RID: 4642
	private string[] string_3;

	// Token: 0x04001223 RID: 4643
	private int? nullable_8;

	// Token: 0x04001224 RID: 4644
	private string string_4;
}
