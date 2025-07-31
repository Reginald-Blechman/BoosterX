using System;
using System.Text.Json.Serialization;

// Token: 0x02000481 RID: 1153
public sealed class GClass206
{
	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00013C38 File Offset: 0x00011E38
	// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00013C40 File Offset: 0x00011E40
	[JsonPropertyName("include_usage")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x040013F4 RID: 5108
	private bool bool_0;
}
