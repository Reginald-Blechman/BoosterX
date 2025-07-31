using System;
using Newtonsoft.Json;

// Token: 0x0200044B RID: 1099
public sealed class GClass158
{
	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00012ED8 File Offset: 0x000110D8
	// (set) Token: 0x06001C81 RID: 7297 RVA: 0x00012EE0 File Offset: 0x000110E0
	[JsonProperty("id")]
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

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x06001C82 RID: 7298 RVA: 0x00012EE9 File Offset: 0x000110E9
	// (set) Token: 0x06001C83 RID: 7299 RVA: 0x00012EF1 File Offset: 0x000110F1
	[JsonProperty("object")]
	public string String_1
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

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00078958 File Offset: 0x00076B58
	[JsonIgnore]
	public DateTime DateTime_0
	{
		get
		{
			return DateTimeOffset.FromUnixTimeSeconds(this.Int64_0).DateTime;
		}
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00012EFA File Offset: 0x000110FA
	// (set) Token: 0x06001C86 RID: 7302 RVA: 0x00012F02 File Offset: 0x00011102
	[JsonProperty("created")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00012F0B File Offset: 0x0001110B
	// (set) Token: 0x06001C88 RID: 7304 RVA: 0x00012F13 File Offset: 0x00011113
	[JsonProperty("allow_create_engine")]
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

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00012F1C File Offset: 0x0001111C
	// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00012F24 File Offset: 0x00011124
	[JsonProperty("allow_sampling")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00012F2D File Offset: 0x0001112D
	// (set) Token: 0x06001C8C RID: 7308 RVA: 0x00012F35 File Offset: 0x00011135
	[JsonProperty("allow_logprobs")]
	public bool Boolean_2
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
		}
	}

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00012F3E File Offset: 0x0001113E
	// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00012F46 File Offset: 0x00011146
	[JsonProperty("allow_search_indices")]
	public bool Boolean_3
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00012F4F File Offset: 0x0001114F
	// (set) Token: 0x06001C90 RID: 7312 RVA: 0x00012F57 File Offset: 0x00011157
	[JsonProperty("allow_view")]
	public bool Boolean_4
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
		}
	}

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00012F60 File Offset: 0x00011160
	// (set) Token: 0x06001C92 RID: 7314 RVA: 0x00012F68 File Offset: 0x00011168
	[JsonProperty("allow_fine_tuning")]
	public bool Boolean_5
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
		}
	}

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00012F71 File Offset: 0x00011171
	// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00012F79 File Offset: 0x00011179
	[JsonProperty("organization")]
	public string String_2
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

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00012F82 File Offset: 0x00011182
	// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00012F8A File Offset: 0x0001118A
	[JsonProperty("group")]
	public string String_3
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

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00012F93 File Offset: 0x00011193
	// (set) Token: 0x06001C98 RID: 7320 RVA: 0x00012F9B File Offset: 0x0001119B
	[JsonProperty("is_blocking")]
	public bool Boolean_6
	{
		get
		{
			return this.bool_6;
		}
		set
		{
			this.bool_6 = value;
		}
	}

	// Token: 0x04001301 RID: 4865
	private string string_0;

	// Token: 0x04001302 RID: 4866
	private string string_1;

	// Token: 0x04001303 RID: 4867
	private long long_0;

	// Token: 0x04001304 RID: 4868
	private bool bool_0;

	// Token: 0x04001305 RID: 4869
	private bool bool_1;

	// Token: 0x04001306 RID: 4870
	private bool bool_2;

	// Token: 0x04001307 RID: 4871
	private bool bool_3;

	// Token: 0x04001308 RID: 4872
	private bool bool_4;

	// Token: 0x04001309 RID: 4873
	private bool bool_5;

	// Token: 0x0400130A RID: 4874
	private string string_2;

	// Token: 0x0400130B RID: 4875
	private string string_3;

	// Token: 0x0400130C RID: 4876
	private bool bool_6;
}
