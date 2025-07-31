using System;
using System.Collections.Generic;
using System.Windows.Media;
using ns0;

// Token: 0x0200055E RID: 1374
internal sealed class Class659
{
	// Token: 0x06002272 RID: 8818 RVA: 0x0001690A File Offset: 0x00014B0A
	internal Class659(Class245 class245_1, bool bool_1)
	{
		this.class245_0 = class245_1;
		this.bool_0 = bool_1;
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x00016920 File Offset: 0x00014B20
	public string method_0()
	{
		if (this.bool_0)
		{
			return this.class245_0.String_0;
		}
		return new string('X', this.class245_0.String_0.Length);
	}

	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x06002274 RID: 8820 RVA: 0x0001694D File Offset: 0x00014B4D
	public string Path
	{
		get
		{
			if (this.bool_0)
			{
				return this.class245_0.String_1;
			}
			return new string('X', this.class245_0.String_1.Length);
		}
	}

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x06002275 RID: 8821 RVA: 0x0001697A File Offset: 0x00014B7A
	public string Key
	{
		get
		{
			if (this.bool_0)
			{
				return this.class245_0.String_2;
			}
			return new string('X', this.class245_0.String_2.Length);
		}
	}

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x06002276 RID: 8822 RVA: 0x000169A7 File Offset: 0x00014BA7
	public FontFamily MyFontFamily
	{
		get
		{
			if (!this.bool_0)
			{
				return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.fontFamily_0;
			}
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_0();
		}
	}

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x06002277 RID: 8823 RVA: 0x00089828 File Offset: 0x00087A28
	public List<Class324> Values
	{
		get
		{
			Class659.Class660 @class = new Class659.Class660();
			@class.class659_0 = this;
			@class.list_0 = new List<Class324>();
			this.class245_0.List_0.ForEach(new Action<Class275>(@class.method_0));
			return @class.list_0;
		}
	}

	// Token: 0x170005C7 RID: 1479
	// (get) Token: 0x06002278 RID: 8824 RVA: 0x000169BC File Offset: 0x00014BBC
	public string Type
	{
		get
		{
			Class245 @class = this.class245_0;
			if (@class == null)
			{
				return null;
			}
			return @class.String_4;
		}
	}

	// Token: 0x170005C8 RID: 1480
	// (get) Token: 0x06002279 RID: 8825 RVA: 0x000169CF File Offset: 0x00014BCF
	public string RegType
	{
		get
		{
			Class245 @class = this.class245_0;
			if (@class == null)
			{
				return null;
			}
			return @class.String_5;
		}
	}

	// Token: 0x040016EC RID: 5868
	internal Class245 class245_0;

	// Token: 0x040016ED RID: 5869
	public bool bool_0;

	// Token: 0x0200055F RID: 1375
	private sealed class Class660
	{
		// Token: 0x0600227B RID: 8827 RVA: 0x000169E2 File Offset: 0x00014BE2
		internal void method_0(Class275 class275_0)
		{
			this.list_0.Add(new Class324(class275_0, this.class659_0.bool_0));
		}

		// Token: 0x040016EE RID: 5870
		public List<Class324> list_0;

		// Token: 0x040016EF RID: 5871
		public Class659 class659_0;
	}
}
