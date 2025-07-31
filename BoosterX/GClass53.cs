using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020001F2 RID: 498
public sealed class GClass53
{
	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0000A2AF File Offset: 0x000084AF
	// (set) Token: 0x06000D9C RID: 3484 RVA: 0x0000A2B7 File Offset: 0x000084B7
	[JsonProperty("index")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0000A2C0 File Offset: 0x000084C0
	// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0000A2C8 File Offset: 0x000084C8
	[JsonProperty("message")]
	public GClass258 Message
	{
		[CompilerGenerated]
		get
		{
			return this.gclass258_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass258_0 = value;
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0000A2D1 File Offset: 0x000084D1
	// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0000A2D9 File Offset: 0x000084D9
	[JsonProperty("finish_reason")]
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

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0000A2E2 File Offset: 0x000084E2
	// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0000A2EA File Offset: 0x000084EA
	[JsonProperty("delta")]
	public GClass258 GClass258_0
	{
		get
		{
			return this.gclass258_1;
		}
		set
		{
			this.gclass258_1 = value;
		}
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0000A2F3 File Offset: 0x000084F3
	public override string ToString()
	{
		if (this.Message == null && this.GClass258_0 != null)
		{
			return this.GClass258_0.String_1;
		}
		return this.Message.String_1;
	}

	// Token: 0x040008B1 RID: 2225
	private int int_0;

	// Token: 0x040008B2 RID: 2226
	private GClass258 gclass258_0;

	// Token: 0x040008B3 RID: 2227
	private string string_0;

	// Token: 0x040008B4 RID: 2228
	private GClass258 gclass258_1;
}
