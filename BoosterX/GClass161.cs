using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200044E RID: 1102
public sealed class GClass161
{
	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06001C9C RID: 7324 RVA: 0x00012FB1 File Offset: 0x000111B1
	// (set) Token: 0x06001C9D RID: 7325 RVA: 0x00012FB9 File Offset: 0x000111B9
	[JsonProperty("title")]
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

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00012FC2 File Offset: 0x000111C2
	// (set) Token: 0x06001C9F RID: 7327 RVA: 0x00012FCA File Offset: 0x000111CA
	[JsonProperty("description")]
	public string Description
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

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00012FD3 File Offset: 0x000111D3
	// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x00012FDB File Offset: 0x000111DB
	[JsonProperty("productsList")]
	public List<GClass0> List_0
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

	// Token: 0x06001CA2 RID: 7330 RVA: 0x00012FE4 File Offset: 0x000111E4
	public static GClass161 smethod_0(string string_2)
	{
		return JsonConvert.DeserializeObject<GClass161>(string_2, Class273.jsonSerializerSettings_0);
	}

	// Token: 0x0400130D RID: 4877
	private string string_0;

	// Token: 0x0400130E RID: 4878
	private string string_1;

	// Token: 0x0400130F RID: 4879
	private List<GClass0> list_0;
}
