using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

// Token: 0x0200059C RID: 1436
public sealed class GClass249
{
	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000187D7 File Offset: 0x000169D7
	// (set) Token: 0x060024A4 RID: 9380 RVA: 0x000187DF File Offset: 0x000169DF
	[JsonPropertyName("is_available")]
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

	// Token: 0x17000614 RID: 1556
	// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000187E8 File Offset: 0x000169E8
	// (set) Token: 0x060024A6 RID: 9382 RVA: 0x000187F0 File Offset: 0x000169F0
	[JsonPropertyName("balance_infos")]
	public List<GClass269> List_0
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

	// Token: 0x040017D1 RID: 6097
	private bool bool_0;

	// Token: 0x040017D2 RID: 6098
	private List<GClass269> list_0 = new List<GClass269>();
}
