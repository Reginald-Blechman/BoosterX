using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020003BE RID: 958
public sealed class GClass129
{
	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06001937 RID: 6455 RVA: 0x00011253 File Offset: 0x0000F453
	// (set) Token: 0x06001938 RID: 6456 RVA: 0x0001125B File Offset: 0x0000F45B
	[JsonProperty("tokens")]
	public List<string> List_0
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

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06001939 RID: 6457 RVA: 0x00011264 File Offset: 0x0000F464
	// (set) Token: 0x0600193A RID: 6458 RVA: 0x0001126C File Offset: 0x0000F46C
	[JsonProperty("token_logprobs")]
	public List<double?> List_1
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

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x0600193B RID: 6459 RVA: 0x00011275 File Offset: 0x0000F475
	// (set) Token: 0x0600193C RID: 6460 RVA: 0x0001127D File Offset: 0x0000F47D
	[JsonProperty("top_logprobs")]
	public IList<IDictionary<string, double>> IList_0
	{
		get
		{
			return this.ilist_0;
		}
		set
		{
			this.ilist_0 = value;
		}
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x0600193D RID: 6461 RVA: 0x00011286 File Offset: 0x0000F486
	// (set) Token: 0x0600193E RID: 6462 RVA: 0x0001128E File Offset: 0x0000F48E
	[JsonProperty("text_offset")]
	public List<int> List_2
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

	// Token: 0x0400109E RID: 4254
	private List<string> list_0;

	// Token: 0x0400109F RID: 4255
	private List<double?> list_1;

	// Token: 0x040010A0 RID: 4256
	private IList<IDictionary<string, double>> ilist_0;

	// Token: 0x040010A1 RID: 4257
	private List<int> list_2;
}
