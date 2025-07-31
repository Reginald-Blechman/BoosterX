using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x020001D5 RID: 469
public sealed class GClass49
{
	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00009CF2 File Offset: 0x00007EF2
	// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00009CFA File Offset: 0x00007EFA
	public string Content
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

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00009D03 File Offset: 0x00007F03
	// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00009D0B File Offset: 0x00007F0B
	public string Role
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

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00009D14 File Offset: 0x00007F14
	// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00009D1C File Offset: 0x00007F1C
	public string Name
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

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00009D25 File Offset: 0x00007F25
	// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00009D2D File Offset: 0x00007F2D
	public bool? Prefix
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

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00009D36 File Offset: 0x00007F36
	// (set) Token: 0x06000CED RID: 3309 RVA: 0x00009D3E File Offset: 0x00007F3E
	[JsonPropertyName("reasoning_content")]
	public string String_0
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

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00009D47 File Offset: 0x00007F47
	// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00009D4F File Offset: 0x00007F4F
	[JsonPropertyName("tool_call_id")]
	public string String_1
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

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00009D58 File Offset: 0x00007F58
	public static GClass49 smethod_0(string string_5)
	{
		return new GClass49
		{
			Content = string_5,
			Role = "user"
		};
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00009D72 File Offset: 0x00007F72
	public static GClass49 smethod_1(string string_5)
	{
		return new GClass49
		{
			Content = string_5,
			Role = "system"
		};
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00009D8C File Offset: 0x00007F8C
	public static GClass49 smethod_2(string string_5)
	{
		return new GClass49
		{
			Content = string_5,
			Role = "assistant"
		};
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00009DA6 File Offset: 0x00007FA6
	public static GClass49 smethod_3(string string_5, string string_6)
	{
		return new GClass49
		{
			Content = string_5,
			Role = "tool",
			String_1 = string_6
		};
	}

	// Token: 0x0400083C RID: 2108
	private string string_0 = string.Empty;

	// Token: 0x0400083D RID: 2109
	private string string_1 = "user";

	// Token: 0x0400083E RID: 2110
	private string string_2;

	// Token: 0x0400083F RID: 2111
	private bool? nullable_0;

	// Token: 0x04000840 RID: 2112
	private string string_3;

	// Token: 0x04000841 RID: 2113
	private string string_4;
}
