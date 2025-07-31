using System;
using Newtonsoft.Json;

// Token: 0x02000562 RID: 1378
public sealed class GClass241
{
	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x06002283 RID: 8835 RVA: 0x00016A54 File Offset: 0x00014C54
	// (set) Token: 0x06002284 RID: 8836 RVA: 0x00016A5C File Offset: 0x00014C5C
	[JsonProperty("object")]
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

	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x06002285 RID: 8837 RVA: 0x00016A65 File Offset: 0x00014C65
	// (set) Token: 0x06002286 RID: 8838 RVA: 0x00016A6D File Offset: 0x00014C6D
	[JsonProperty("embedding")]
	public float[] Single_0
	{
		get
		{
			return this.float_0;
		}
		set
		{
			this.float_0 = value;
		}
	}

	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x06002287 RID: 8839 RVA: 0x00016A76 File Offset: 0x00014C76
	// (set) Token: 0x06002288 RID: 8840 RVA: 0x00016A7E File Offset: 0x00014C7E
	[JsonProperty("index")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x040016F3 RID: 5875
	private string string_0;

	// Token: 0x040016F4 RID: 5876
	private float[] float_0;

	// Token: 0x040016F5 RID: 5877
	private int int_0;
}
