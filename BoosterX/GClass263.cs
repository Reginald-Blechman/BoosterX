using System;
using Newtonsoft.Json;

// Token: 0x020005F9 RID: 1529
public sealed class GClass263
{
	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x06002727 RID: 10023 RVA: 0x0001A0BA File Offset: 0x000182BA
	// (set) Token: 0x06002728 RID: 10024 RVA: 0x0001A0C2 File Offset: 0x000182C2
	[JsonProperty("category.first")]
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

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x06002729 RID: 10025 RVA: 0x0001A0CB File Offset: 0x000182CB
	// (set) Token: 0x0600272A RID: 10026 RVA: 0x0001A0D3 File Offset: 0x000182D3
	[JsonProperty("category.second")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x1700069A RID: 1690
	// (get) Token: 0x0600272B RID: 10027 RVA: 0x0001A0DC File Offset: 0x000182DC
	// (set) Token: 0x0600272C RID: 10028 RVA: 0x0001A0E4 File Offset: 0x000182E4
	[JsonProperty("category.third")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x0600272D RID: 10029 RVA: 0x0001A0ED File Offset: 0x000182ED
	// (set) Token: 0x0600272E RID: 10030 RVA: 0x0001A0F5 File Offset: 0x000182F5
	[JsonProperty("optOut.backupRestore")]
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

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x0600272F RID: 10031 RVA: 0x0001A0FE File Offset: 0x000182FE
	// (set) Token: 0x06002730 RID: 10032 RVA: 0x0001A106 File Offset: 0x00018306
	[JsonProperty("optOut.removeableMedia")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x040019CD RID: 6605
	private string string_0;

	// Token: 0x040019CE RID: 6606
	private string string_1;

	// Token: 0x040019CF RID: 6607
	private string string_2;

	// Token: 0x040019D0 RID: 6608
	private bool bool_0;

	// Token: 0x040019D1 RID: 6609
	private bool bool_1;
}
