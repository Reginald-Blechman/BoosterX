using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x02000619 RID: 1561
public sealed class GClass269
{
	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x060027C3 RID: 10179 RVA: 0x0001A61B File Offset: 0x0001881B
	// (set) Token: 0x060027C4 RID: 10180 RVA: 0x0001A623 File Offset: 0x00018823
	public string Currency
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

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x060027C5 RID: 10181 RVA: 0x0001A62C File Offset: 0x0001882C
	// (set) Token: 0x060027C6 RID: 10182 RVA: 0x0001A634 File Offset: 0x00018834
	[JsonPropertyName("total_balance")]
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

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x060027C7 RID: 10183 RVA: 0x0001A63D File Offset: 0x0001883D
	// (set) Token: 0x060027C8 RID: 10184 RVA: 0x0001A645 File Offset: 0x00018845
	[JsonPropertyName("granted_balance")]
	public string String_1
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

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x060027C9 RID: 10185 RVA: 0x0001A64E File Offset: 0x0001884E
	// (set) Token: 0x060027CA RID: 10186 RVA: 0x0001A656 File Offset: 0x00018856
	[JsonPropertyName("topped_up_balance")]
	public string String_2
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

	// Token: 0x04001A1C RID: 6684
	private string string_0 = "CNY";

	// Token: 0x04001A1D RID: 6685
	private string string_1 = string.Empty;

	// Token: 0x04001A1E RID: 6686
	private string string_2 = string.Empty;

	// Token: 0x04001A1F RID: 6687
	private string string_3 = string.Empty;
}
