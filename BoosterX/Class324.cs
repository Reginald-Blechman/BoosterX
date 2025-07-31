using System;
using System.Windows.Media;
using ns0;

// Token: 0x020002B3 RID: 691
internal sealed class Class324
{
	// Token: 0x06001248 RID: 4680 RVA: 0x0000D199 File Offset: 0x0000B399
	internal Class324(Class275 class275_1, bool bool_1)
	{
		this.class275_0 = class275_1;
		this.bool_0 = bool_1;
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x06001249 RID: 4681 RVA: 0x0000D1AF File Offset: 0x0000B3AF
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

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x0600124A RID: 4682 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
	public string ValueHandler
	{
		get
		{
			return this.class275_0.String_2;
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x0600124B RID: 4683 RVA: 0x0000D1D1 File Offset: 0x0000B3D1
	public bool ContainsOpt
	{
		get
		{
			return this.class275_0.Boolean_1;
		}
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x0600124C RID: 4684 RVA: 0x0000D1DE File Offset: 0x0000B3DE
	public bool ContainsOn
	{
		get
		{
			return this.class275_0.Boolean_2;
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x0600124D RID: 4685 RVA: 0x0000D1EB File Offset: 0x0000B3EB
	public bool ContainsOff
	{
		get
		{
			return this.class275_0.Boolean_3;
		}
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x0600124E RID: 4686 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
	public bool ContainsBest
	{
		get
		{
			return this.class275_0.Boolean_4;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x0600124F RID: 4687 RVA: 0x0000D205 File Offset: 0x0000B405
	public bool ContainsDefault
	{
		get
		{
			return this.class275_0.Boolean_5;
		}
	}

	// Token: 0x04000B80 RID: 2944
	private Class275 class275_0;

	// Token: 0x04000B81 RID: 2945
	private bool bool_0;
}
