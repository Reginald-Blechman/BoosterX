using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x020001BD RID: 445
public sealed class GClass43
{
	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00009855 File Offset: 0x00007A55
	// (set) Token: 0x06000C6B RID: 3179 RVA: 0x0000985D File Offset: 0x00007A5D
	public string Id
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

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00009866 File Offset: 0x00007A66
	// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0000986E File Offset: 0x00007A6E
	public string Object
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00009877 File Offset: 0x00007A77
	// (set) Token: 0x06000C6F RID: 3183 RVA: 0x0000987F File Offset: 0x00007A7F
	[JsonPropertyName("owned_by")]
	public string String_0
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

	// Token: 0x040007FC RID: 2044
	private string string_0;

	// Token: 0x040007FD RID: 2045
	private string string_1;

	// Token: 0x040007FE RID: 2046
	private string string_2;
}
