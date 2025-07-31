using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020006F1 RID: 1777
public sealed class GClass295
{
	// Token: 0x17000754 RID: 1876
	// (get) Token: 0x06002C7E RID: 11390 RVA: 0x0001CA0A File Offset: 0x0001AC0A
	// (set) Token: 0x06002C7F RID: 11391 RVA: 0x0001CA12 File Offset: 0x0001AC12
	[JsonProperty("ProductFamilyName")]
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

	// Token: 0x17000755 RID: 1877
	// (get) Token: 0x06002C80 RID: 11392 RVA: 0x0001CA1B File Offset: 0x0001AC1B
	// (set) Token: 0x06002C81 RID: 11393 RVA: 0x0001CA23 File Offset: 0x0001AC23
	[JsonProperty("Products")]
	public List<GClass197> List_0
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

	// Token: 0x04001CE7 RID: 7399
	private string string_0;

	// Token: 0x04001CE8 RID: 7400
	private List<GClass197> list_0;
}
