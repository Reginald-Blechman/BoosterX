using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200053C RID: 1340
public sealed class GClass234
{
	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x060021E4 RID: 8676 RVA: 0x000163E7 File Offset: 0x000145E7
	// (set) Token: 0x060021E5 RID: 8677 RVA: 0x000163EF File Offset: 0x000145EF
	[JsonProperty("url")]
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

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x060021E6 RID: 8678 RVA: 0x000163F8 File Offset: 0x000145F8
	// (set) Token: 0x060021E7 RID: 8679 RVA: 0x00016400 File Offset: 0x00014600
	[JsonProperty("b64_json")]
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

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x060021E8 RID: 8680 RVA: 0x00016409 File Offset: 0x00014609
	// (set) Token: 0x060021E9 RID: 8681 RVA: 0x00016411 File Offset: 0x00014611
	public string RevisedPrompt
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

	// Token: 0x040016A0 RID: 5792
	private string string_0;

	// Token: 0x040016A1 RID: 5793
	private string string_1;

	// Token: 0x040016A2 RID: 5794
	private string string_2;
}
