using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x020006F3 RID: 1779
public sealed class GClass297
{
	// Token: 0x17000756 RID: 1878
	// (get) Token: 0x06002C86 RID: 11398 RVA: 0x0001CA3E File Offset: 0x0001AC3E
	// (set) Token: 0x06002C87 RID: 11399 RVA: 0x0001CA46 File Offset: 0x0001AC46
	public string Prompt
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

	// Token: 0x17000757 RID: 1879
	// (get) Token: 0x06002C88 RID: 11400 RVA: 0x0001CA4F File Offset: 0x0001AC4F
	// (set) Token: 0x06002C89 RID: 11401 RVA: 0x0001CA57 File Offset: 0x0001AC57
	public string Model
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000758 RID: 1880
	// (get) Token: 0x06002C8A RID: 11402 RVA: 0x0001CA60 File Offset: 0x0001AC60
	// (set) Token: 0x06002C8B RID: 11403 RVA: 0x0001CA68 File Offset: 0x0001AC68
	public bool? Echo
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000759 RID: 1881
	// (get) Token: 0x06002C8C RID: 11404 RVA: 0x0001CA71 File Offset: 0x0001AC71
	// (set) Token: 0x06002C8D RID: 11405 RVA: 0x0001CA79 File Offset: 0x0001AC79
	[JsonPropertyName("frequency_penalty")]
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

	// Token: 0x1700075A RID: 1882
	// (get) Token: 0x06002C8E RID: 11406 RVA: 0x0001CA82 File Offset: 0x0001AC82
	// (set) Token: 0x06002C8F RID: 11407 RVA: 0x0001CA8A File Offset: 0x0001AC8A
	[JsonPropertyName("max_tokens")]
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

	// Token: 0x1700075B RID: 1883
	// (get) Token: 0x06002C90 RID: 11408 RVA: 0x0001CA93 File Offset: 0x0001AC93
	// (set) Token: 0x06002C91 RID: 11409 RVA: 0x0001CA9B File Offset: 0x0001AC9B
	[JsonPropertyName("presence_penalty")]
	public double Double_1
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
		}
	}

	// Token: 0x1700075C RID: 1884
	// (get) Token: 0x06002C92 RID: 11410 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
	// (set) Token: 0x06002C93 RID: 11411 RVA: 0x0001CAAC File Offset: 0x0001ACAC
	public List<string> Stop
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x1700075D RID: 1885
	// (get) Token: 0x06002C94 RID: 11412 RVA: 0x0001CAB5 File Offset: 0x0001ACB5
	// (set) Token: 0x06002C95 RID: 11413 RVA: 0x0001CABD File Offset: 0x0001ACBD
	[JsonInclude]
	public bool Stream
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700075E RID: 1886
	// (get) Token: 0x06002C96 RID: 11414 RVA: 0x0001CAC6 File Offset: 0x0001ACC6
	// (set) Token: 0x06002C97 RID: 11415 RVA: 0x0001CACE File Offset: 0x0001ACCE
	public string Suffix
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700075F RID: 1887
	// (get) Token: 0x06002C98 RID: 11416 RVA: 0x0001CAD7 File Offset: 0x0001ACD7
	// (set) Token: 0x06002C99 RID: 11417 RVA: 0x0001CADF File Offset: 0x0001ACDF
	[JsonPropertyName("stream_options")]
	public GClass206 GClass206_0
	{
		get
		{
			return this.gclass206_0;
		}
		set
		{
			this.gclass206_0 = value;
		}
	}

	// Token: 0x17000760 RID: 1888
	// (get) Token: 0x06002C9A RID: 11418 RVA: 0x0001CAE8 File Offset: 0x0001ACE8
	// (set) Token: 0x06002C9B RID: 11419 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
	public double Temperature
	{
		[CompilerGenerated]
		get
		{
			return this.double_2;
		}
		[CompilerGenerated]
		set
		{
			this.double_2 = value;
		}
	}

	// Token: 0x17000761 RID: 1889
	// (get) Token: 0x06002C9C RID: 11420 RVA: 0x0001CAF9 File Offset: 0x0001ACF9
	// (set) Token: 0x06002C9D RID: 11421 RVA: 0x0001CB01 File Offset: 0x0001AD01
	[JsonPropertyName("top_p")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x17000762 RID: 1890
	// (get) Token: 0x06002C9E RID: 11422 RVA: 0x0001CB0A File Offset: 0x0001AD0A
	// (set) Token: 0x06002C9F RID: 11423 RVA: 0x0001CB12 File Offset: 0x0001AD12
	[JsonPropertyName("logprobs")]
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

	// Token: 0x04001CEA RID: 7402
	private string string_0;

	// Token: 0x04001CEB RID: 7403
	private string string_1 = "deepseek-chat";

	// Token: 0x04001CEC RID: 7404
	private bool? nullable_0;

	// Token: 0x04001CED RID: 7405
	private double double_0;

	// Token: 0x04001CEE RID: 7406
	private long long_0 = 4096L;

	// Token: 0x04001CEF RID: 7407
	private double double_1;

	// Token: 0x04001CF0 RID: 7408
	private List<string> list_0;

	// Token: 0x04001CF1 RID: 7409
	private bool bool_0;

	// Token: 0x04001CF2 RID: 7410
	private string string_2;

	// Token: 0x04001CF3 RID: 7411
	private GClass206 gclass206_0;

	// Token: 0x04001CF4 RID: 7412
	private double double_2 = 1.0;

	// Token: 0x04001CF5 RID: 7413
	private long long_1 = 1L;

	// Token: 0x04001CF6 RID: 7414
	private int int_0;
}
