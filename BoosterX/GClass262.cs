using System;
using Newtonsoft.Json;

// Token: 0x020005F8 RID: 1528
public sealed class GClass262
{
	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x06002720 RID: 10016 RVA: 0x0001A087 File Offset: 0x00018287
	// (set) Token: 0x06002721 RID: 10017 RVA: 0x0001A08F File Offset: 0x0001828F
	[JsonProperty("MaxVersion")]
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

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x06002722 RID: 10018 RVA: 0x0001A098 File Offset: 0x00018298
	// (set) Token: 0x06002723 RID: 10019 RVA: 0x0001A0A0 File Offset: 0x000182A0
	[JsonProperty("MinVersion")]
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

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x06002724 RID: 10020 RVA: 0x0001A0A9 File Offset: 0x000182A9
	// (set) Token: 0x06002725 RID: 10021 RVA: 0x0001A0B1 File Offset: 0x000182B1
	[JsonProperty("PlatformName")]
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

	// Token: 0x040019CA RID: 6602
	private long long_0;

	// Token: 0x040019CB RID: 6603
	private long long_1;

	// Token: 0x040019CC RID: 6604
	private string string_0;
}
