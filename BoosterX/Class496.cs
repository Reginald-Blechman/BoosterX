using System;
using System.Collections.Generic;

// Token: 0x020001BB RID: 443
internal sealed class Class496 : GClass162
{
	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0004C184 File Offset: 0x0004A384
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

	// Token: 0x06000C65 RID: 3173 RVA: 0x00009801 File Offset: 0x00007A01
	private GClass177 method_2()
	{
		return this.gclass177_0;
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00009809 File Offset: 0x00007A09
	private void method_3(GClass177 gclass177_1)
	{
		this.gclass177_0 = gclass177_1;
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00009812 File Offset: 0x00007A12
	// (set) Token: 0x06000C68 RID: 3176 RVA: 0x00009840 File Offset: 0x00007A40
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

	// Token: 0x040007F9 RID: 2041
	private List<GClass177> list_0;

	// Token: 0x040007FA RID: 2042
	private GClass177 gclass177_0;
}
