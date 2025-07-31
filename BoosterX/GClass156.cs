using System;
using Newtonsoft.Json;

// Token: 0x02000440 RID: 1088
public sealed class GClass156
{
	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00012D36 File Offset: 0x00010F36
	// (set) Token: 0x06001C42 RID: 7234 RVA: 0x00012D3E File Offset: 0x00010F3E
	[JsonProperty("IdType")]
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

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00012D47 File Offset: 0x00010F47
	// (set) Token: 0x06001C44 RID: 7236 RVA: 0x00012D4F File Offset: 0x00010F4F
	[JsonProperty("Value")]
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

	// Token: 0x040012DC RID: 4828
	private string string_0;

	// Token: 0x040012DD RID: 4829
	private string string_1;
}
