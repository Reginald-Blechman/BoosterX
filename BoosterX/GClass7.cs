using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x02000114 RID: 276
public sealed class GClass7
{
	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00006F15 File Offset: 0x00005115
	// (set) Token: 0x060007FA RID: 2042 RVA: 0x00006F1D File Offset: 0x0000511D
	public string Token
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060007FB RID: 2043 RVA: 0x00006F26 File Offset: 0x00005126
	// (set) Token: 0x060007FC RID: 2044 RVA: 0x00006F2E File Offset: 0x0000512E
	public long Logprob
	{
		[CompilerGenerated]
		get
		{
			return this.long_0;
		}
		[CompilerGenerated]
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060007FD RID: 2045 RVA: 0x00006F37 File Offset: 0x00005137
	// (set) Token: 0x060007FE RID: 2046 RVA: 0x00006F3F File Offset: 0x0000513F
	public byte[] Bytes
	{
		[CompilerGenerated]
		get
		{
			return this.byte_0;
		}
		[CompilerGenerated]
		set
		{
			this.byte_0 = value;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060007FF RID: 2047 RVA: 0x00006F48 File Offset: 0x00005148
	// (set) Token: 0x06000800 RID: 2048 RVA: 0x00006F50 File Offset: 0x00005150
	[JsonPropertyName("top_logprobs")]
	public List<GClass203> List_0
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

	// Token: 0x04000477 RID: 1143
	private string string_0;

	// Token: 0x04000478 RID: 1144
	private long long_0;

	// Token: 0x04000479 RID: 1145
	private byte[] byte_0 = Array.Empty<byte>();

	// Token: 0x0400047A RID: 1146
	private List<GClass203> list_0 = new List<GClass203>();
}
