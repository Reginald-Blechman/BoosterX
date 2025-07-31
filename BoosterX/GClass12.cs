using System;
using Newtonsoft.Json;

// Token: 0x02000120 RID: 288
[JsonObject]
public sealed class GClass12
{
	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000873 RID: 2163 RVA: 0x000073E8 File Offset: 0x000055E8
	public uint SettingValue
	{
		get
		{
			return Convert.ToUInt32(this.String_1.Trim(), 16);
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000874 RID: 2164 RVA: 0x000073FC File Offset: 0x000055FC
	// (set) Token: 0x06000875 RID: 2165 RVA: 0x00007404 File Offset: 0x00005604
	[JsonProperty("UserfriendlyName")]
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

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000876 RID: 2166 RVA: 0x0000740D File Offset: 0x0000560D
	// (set) Token: 0x06000877 RID: 2167 RVA: 0x00007415 File Offset: 0x00005615
	[JsonProperty("HexValue")]
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

	// Token: 0x040004C3 RID: 1219
	private string string_0;

	// Token: 0x040004C4 RID: 1220
	private string string_1;
}
