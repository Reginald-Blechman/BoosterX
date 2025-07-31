using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000494 RID: 1172
public sealed class GClass39 : GClass33
{
	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000140C2 File Offset: 0x000122C2
	// (set) Token: 0x06001E67 RID: 7783 RVA: 0x000140CA File Offset: 0x000122CA
	[JsonProperty("data")]
	public List<GClass241> List_0
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

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06001E68 RID: 7784 RVA: 0x000140D3 File Offset: 0x000122D3
	// (set) Token: 0x06001E69 RID: 7785 RVA: 0x000140DB File Offset: 0x000122DB
	[JsonProperty("usage")]
	public GClass63 GClass63_0
	{
		get
		{
			return this.gclass63_0;
		}
		set
		{
			this.gclass63_0 = value;
		}
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x000140E4 File Offset: 0x000122E4
	public static implicit operator float[](GClass39 gclass39_0)
	{
		GClass241 gclass = Class746.smethod_0<GClass241>(gclass39_0.List_0);
		if (gclass == null)
		{
			return null;
		}
		return gclass.Single_0;
	}

	// Token: 0x04001427 RID: 5159
	private List<GClass241> list_0;

	// Token: 0x04001428 RID: 5160
	private GClass63 gclass63_0;
}
