using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x0200021F RID: 543
public sealed class GClass58
{
	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0000AE8D File Offset: 0x0000908D
	// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x0000AE95 File Offset: 0x00009095
	public List<GClass49> Messages
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

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0000AE9E File Offset: 0x0000909E
	// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x0000AEA6 File Offset: 0x000090A6
	public string Model
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

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0000AEAF File Offset: 0x000090AF
	// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0000AEB7 File Offset: 0x000090B7
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

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0000AEC0 File Offset: 0x000090C0
	// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x0000AEC8 File Offset: 0x000090C8
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

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0000AED1 File Offset: 0x000090D1
	// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0000AED9 File Offset: 0x000090D9
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

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0000AEE2 File Offset: 0x000090E2
	// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0000AEEA File Offset: 0x000090EA
	[JsonPropertyName("response_format")]
	public GClass95 GClass95_0
	{
		get
		{
			return this.gclass95_0;
		}
		set
		{
			this.gclass95_0 = value;
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0000AEF3 File Offset: 0x000090F3
	// (set) Token: 0x06000ECD RID: 3789 RVA: 0x0000AEFB File Offset: 0x000090FB
	public List<string> Stop
	{
		[CompilerGenerated]
		get
		{
			return this.list_1;
		}
		[CompilerGenerated]
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0000AF04 File Offset: 0x00009104
	// (set) Token: 0x06000ECF RID: 3791 RVA: 0x0000AF0C File Offset: 0x0000910C
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

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0000AF15 File Offset: 0x00009115
	// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x0000AF1D File Offset: 0x0000911D
	public List<GClass99> Tools
	{
		[CompilerGenerated]
		get
		{
			return this.list_2;
		}
		[CompilerGenerated]
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0000AF26 File Offset: 0x00009126
	// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x0000AF2E File Offset: 0x0000912E
	[JsonPropertyName("tool_choice")]
	public JsonElement? Nullable_0
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

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0000AF37 File Offset: 0x00009137
	// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x0000AF3F File Offset: 0x0000913F
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

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0000AF48 File Offset: 0x00009148
	// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x0000AF50 File Offset: 0x00009150
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

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0000AF59 File Offset: 0x00009159
	// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x0000AF61 File Offset: 0x00009161
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

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0000AF6A File Offset: 0x0000916A
	// (set) Token: 0x06000EDB RID: 3803 RVA: 0x0000AF72 File Offset: 0x00009172
	[JsonPropertyName("logprobs")]
	public bool Boolean_0
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

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0000AF7B File Offset: 0x0000917B
	// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0000AF83 File Offset: 0x00009183
	[JsonPropertyName("top_logprobs")]
	public int? Nullable_1
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

	// Token: 0x04000981 RID: 2433
	private List<GClass49> list_0 = new List<GClass49>();

	// Token: 0x04000982 RID: 2434
	private string string_0 = "deepseek-chat";

	// Token: 0x04000983 RID: 2435
	private double double_0;

	// Token: 0x04000984 RID: 2436
	private long long_0 = 8000L;

	// Token: 0x04000985 RID: 2437
	private double double_1;

	// Token: 0x04000986 RID: 2438
	private GClass95 gclass95_0;

	// Token: 0x04000987 RID: 2439
	private List<string> list_1 = new List<string>();

	// Token: 0x04000988 RID: 2440
	private bool bool_0;

	// Token: 0x04000989 RID: 2441
	private List<GClass99> list_2;

	// Token: 0x0400098A RID: 2442
	private JsonElement? nullable_0;

	// Token: 0x0400098B RID: 2443
	private GClass206 gclass206_0;

	// Token: 0x0400098C RID: 2444
	private double double_2 = 1.0;

	// Token: 0x0400098D RID: 2445
	private long long_1 = 1L;

	// Token: 0x0400098E RID: 2446
	private bool bool_1;

	// Token: 0x0400098F RID: 2447
	private int? nullable_1;
}
