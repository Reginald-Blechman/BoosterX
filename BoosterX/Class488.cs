using System;
using System.Collections.Generic;

// Token: 0x02000118 RID: 280
internal sealed class Class488 : GClass162
{
	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600081C RID: 2076 RVA: 0x000407D0 File Offset: 0x0003E9D0
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

	// Token: 0x0600081D RID: 2077 RVA: 0x00007027 File Offset: 0x00005227
	private GClass177 method_2()
	{
		return this.gclass177_0;
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0000702F File Offset: 0x0000522F
	private void method_3(GClass177 gclass177_1)
	{
		this.gclass177_0 = gclass177_1;
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x0600081F RID: 2079 RVA: 0x00007038 File Offset: 0x00005238
	// (set) Token: 0x06000820 RID: 2080 RVA: 0x00007066 File Offset: 0x00005266
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

	// Token: 0x04000486 RID: 1158
	private List<GClass177> list_0;

	// Token: 0x04000487 RID: 1159
	private GClass177 gclass177_0;
}
