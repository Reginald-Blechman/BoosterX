using System;
using System.Collections.Generic;

// Token: 0x02000560 RID: 1376
public sealed class GClass190 : GClass162
{
	// Token: 0x170005C9 RID: 1481
	// (get) Token: 0x0600227D RID: 8829 RVA: 0x00089870 File Offset: 0x00087A70
	public List<GClass177> Profiles
	{
		get
		{
			if (this.list_0 != null)
			{
				return this.list_0;
			}
			List<GClass177> list = new List<GClass177>();
			foreach (KeyValuePair<string, string> keyValuePair_ in GClass22.smethod_0().method_0())
			{
				list.Add(new GClass177(keyValuePair_));
			}
			this.list_0 = list;
			return this.list_0;
		}
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x00016A00 File Offset: 0x00014C00
	private GClass177 method_2()
	{
		return this.gclass177_0;
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x00016A08 File Offset: 0x00014C08
	private void method_3(GClass177 gclass177_1)
	{
		this.gclass177_0 = gclass177_1;
	}

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x06002280 RID: 8832 RVA: 0x00016A11 File Offset: 0x00014C11
	// (set) Token: 0x06002281 RID: 8833 RVA: 0x00016A3F File Offset: 0x00014C3F
	public GClass177 SelectedProfile
	{
		get
		{
			if (this.method_2() == null)
			{
				this.method_3(this.Profiles[0]);
				base.method_0("SelectedProfile");
			}
			return this.method_2();
		}
		set
		{
			this.method_3(value);
			base.method_0("SelectedProfile");
		}
	}

	// Token: 0x040016F0 RID: 5872
	private List<GClass177> list_0;

	// Token: 0x040016F1 RID: 5873
	private GClass177 gclass177_0;
}
