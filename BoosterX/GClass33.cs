using System;
using Newtonsoft.Json;

// Token: 0x0200019F RID: 415
public abstract class GClass33
{
	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0004A63C File Offset: 0x0004883C
	[JsonIgnore]
	public DateTime? Nullable_0
	{
		get
		{
			if (this.Nullable_1 == null)
			{
				return null;
			}
			return new DateTime?(DateTimeOffset.FromUnixTimeSeconds(this.Nullable_1.Value).DateTime);
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00009290 File Offset: 0x00007490
	// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00009298 File Offset: 0x00007498
	[JsonProperty("created")]
	public long? Nullable_1
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000092A1 File Offset: 0x000074A1
	// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x000092A9 File Offset: 0x000074A9
	[JsonProperty("model")]
	public GClass27 GClass27_0
	{
		get
		{
			return this.gclass27_0;
		}
		set
		{
			this.gclass27_0 = value;
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x000092B2 File Offset: 0x000074B2
	// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x000092BA File Offset: 0x000074BA
	[JsonProperty("object")]
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

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x000092C3 File Offset: 0x000074C3
	// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x000092CB File Offset: 0x000074CB
	[JsonIgnore]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		internal set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000092D4 File Offset: 0x000074D4
	// (set) Token: 0x06000BCA RID: 3018 RVA: 0x000092DC File Offset: 0x000074DC
	[JsonIgnore]
	public TimeSpan TimeSpan_0
	{
		get
		{
			return this.timeSpan_0;
		}
		internal set
		{
			this.timeSpan_0 = value;
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000092E5 File Offset: 0x000074E5
	// (set) Token: 0x06000BCC RID: 3020 RVA: 0x000092ED File Offset: 0x000074ED
	[JsonIgnore]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		internal set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000092F6 File Offset: 0x000074F6
	// (set) Token: 0x06000BCE RID: 3022 RVA: 0x000092FE File Offset: 0x000074FE
	[JsonIgnore]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		internal set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x04000788 RID: 1928
	private long? nullable_0;

	// Token: 0x04000789 RID: 1929
	private GClass27 gclass27_0;

	// Token: 0x0400078A RID: 1930
	private string string_0;

	// Token: 0x0400078B RID: 1931
	private string string_1;

	// Token: 0x0400078C RID: 1932
	private TimeSpan timeSpan_0;

	// Token: 0x0400078D RID: 1933
	private string string_2;

	// Token: 0x0400078E RID: 1934
	private string string_3;
}
