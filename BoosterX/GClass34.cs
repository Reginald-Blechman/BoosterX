using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200012A RID: 298
public sealed class GClass34 : GClass33
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000895 RID: 2197 RVA: 0x000074FC File Offset: 0x000056FC
	// (set) Token: 0x06000896 RID: 2198 RVA: 0x00007504 File Offset: 0x00005704
	[JsonProperty("id")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000897 RID: 2199 RVA: 0x0000750D File Offset: 0x0000570D
	// (set) Token: 0x06000898 RID: 2200 RVA: 0x00007515 File Offset: 0x00005715
	[JsonProperty("filename")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_5;
		}
		[CompilerGenerated]
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000899 RID: 2201 RVA: 0x0000751E File Offset: 0x0000571E
	// (set) Token: 0x0600089A RID: 2202 RVA: 0x00007526 File Offset: 0x00005726
	[JsonProperty("purpose")]
	public string String_5
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600089B RID: 2203 RVA: 0x0000752F File Offset: 0x0000572F
	// (set) Token: 0x0600089C RID: 2204 RVA: 0x00007537 File Offset: 0x00005737
	[JsonProperty("bytes")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600089D RID: 2205 RVA: 0x00007540 File Offset: 0x00005740
	// (set) Token: 0x0600089E RID: 2206 RVA: 0x00007548 File Offset: 0x00005748
	[JsonProperty("created_at")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600089F RID: 2207 RVA: 0x00007551 File Offset: 0x00005751
	// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00007559 File Offset: 0x00005759
	[JsonProperty("deleted")]
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

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00007562 File Offset: 0x00005762
	// (set) Token: 0x060008A2 RID: 2210 RVA: 0x0000756A File Offset: 0x0000576A
	[JsonProperty("status")]
	public string Status
	{
		[CompilerGenerated]
		get
		{
			return this.string_7;
		}
		[CompilerGenerated]
		set
		{
			this.string_7 = value;
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00007573 File Offset: 0x00005773
	// (set) Token: 0x060008A4 RID: 2212 RVA: 0x0000757B File Offset: 0x0000577B
	[JsonProperty("status_details")]
	public string String_6
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
		}
	}

	// Token: 0x040004DE RID: 1246
	private string string_4;

	// Token: 0x040004DF RID: 1247
	private string string_5;

	// Token: 0x040004E0 RID: 1248
	private string string_6;

	// Token: 0x040004E1 RID: 1249
	private long long_0;

	// Token: 0x040004E2 RID: 1250
	private long long_1;

	// Token: 0x040004E3 RID: 1251
	private bool bool_0;

	// Token: 0x040004E4 RID: 1252
	private string string_7;

	// Token: 0x040004E5 RID: 1253
	private string string_8;
}
