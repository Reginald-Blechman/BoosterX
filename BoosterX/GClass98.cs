using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020002F6 RID: 758
public sealed class GClass98
{
	// Token: 0x170002DD RID: 733
	// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0000DE82 File Offset: 0x0000C082
	// (set) Token: 0x060013BA RID: 5050 RVA: 0x0000DE8A File Offset: 0x0000C08A
	[JsonProperty("OriginalReleaseDate")]
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x060013BB RID: 5051 RVA: 0x0000DE93 File Offset: 0x0000C093
	// (set) Token: 0x060013BC RID: 5052 RVA: 0x0000DE9B File Offset: 0x0000C09B
	[JsonProperty("OriginalReleaseDateFriendlyName")]
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

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x060013BD RID: 5053 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
	// (set) Token: 0x060013BE RID: 5054 RVA: 0x0000DEAC File Offset: 0x0000C0AC
	[JsonProperty("MinimumUserAge")]
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

	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x060013BF RID: 5055 RVA: 0x0000DEB5 File Offset: 0x0000C0B5
	// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0000DEBD File Offset: 0x0000C0BD
	[JsonProperty("ContentRatings")]
	public List<GClass62> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0000DEC6 File Offset: 0x0000C0C6
	// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000DECE File Offset: 0x0000C0CE
	[JsonProperty("RelatedProducts")]
	public List<object> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0000DED7 File Offset: 0x0000C0D7
	// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000DEDF File Offset: 0x0000C0DF
	[JsonProperty("UsageData")]
	public List<GClass84> List_2
	{
		get
		{
			return this.list_2;
		}
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
	// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
	[JsonProperty("BundleConfig")]
	public object Object_0
	{
		get
		{
			return this.object_0;
		}
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0000DEF9 File Offset: 0x0000C0F9
	// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0000DF01 File Offset: 0x0000C101
	[JsonProperty("Markets")]
	public List<string> List_3
	{
		get
		{
			return this.list_3;
		}
		set
		{
			this.list_3 = value;
		}
	}

	// Token: 0x04000D3A RID: 3386
	private DateTime dateTime_0;

	// Token: 0x04000D3B RID: 3387
	private string string_0;

	// Token: 0x04000D3C RID: 3388
	private long long_0;

	// Token: 0x04000D3D RID: 3389
	private List<GClass62> list_0;

	// Token: 0x04000D3E RID: 3390
	private List<object> list_1;

	// Token: 0x04000D3F RID: 3391
	private List<GClass84> list_2;

	// Token: 0x04000D40 RID: 3392
	private object object_0;

	// Token: 0x04000D41 RID: 3393
	private List<string> list_3;
}
