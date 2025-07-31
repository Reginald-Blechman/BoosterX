using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000401 RID: 1025
public sealed class GClass138
{
	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00011CC3 File Offset: 0x0000FEC3
	// (set) Token: 0x06001A6E RID: 6766 RVA: 0x00011CCB File Offset: 0x0000FECB
	[JsonProperty("FirstAvailableDate")]
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

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00011CD4 File Offset: 0x0000FED4
	// (set) Token: 0x06001A70 RID: 6768 RVA: 0x00011CDC File Offset: 0x0000FEDC
	[JsonProperty("SupportedLanguages")]
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

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06001A71 RID: 6769 RVA: 0x00011CE5 File Offset: 0x0000FEE5
	// (set) Token: 0x06001A72 RID: 6770 RVA: 0x00011CED File Offset: 0x0000FEED
	[JsonProperty("PackageIds")]
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

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06001A73 RID: 6771 RVA: 0x00011CF6 File Offset: 0x0000FEF6
	// (set) Token: 0x06001A74 RID: 6772 RVA: 0x00011CFE File Offset: 0x0000FEFE
	[JsonProperty("Markets")]
	public List<string> List_1
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

	// Token: 0x0400119F RID: 4511
	private string string_0;

	// Token: 0x040011A0 RID: 4512
	private List<string> list_0;

	// Token: 0x040011A1 RID: 4513
	private object object_0;

	// Token: 0x040011A2 RID: 4514
	private List<string> list_1;
}
