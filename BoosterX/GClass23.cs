using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200016D RID: 365
public sealed class GClass23
{
	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0000836D File Offset: 0x0000656D
	// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00008375 File Offset: 0x00006575
	[JsonProperty("type")]
	public string Type
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

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0000837E File Offset: 0x0000657E
	// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00008386 File Offset: 0x00006586
	[JsonProperty("alternateIdType")]
	public string String_0
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

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0000838F File Offset: 0x0000658F
	// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00008397 File Offset: 0x00006597
	[JsonProperty("alternateIdValue")]
	public string String_1
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

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06000A4A RID: 2634 RVA: 0x000083A0 File Offset: 0x000065A0
	// (set) Token: 0x06000A4B RID: 2635 RVA: 0x000083A8 File Offset: 0x000065A8
	[JsonProperty("alternatedIdTypeString")]
	public string String_2
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x040006D2 RID: 1746
	private string string_0;

	// Token: 0x040006D3 RID: 1747
	private string string_1;

	// Token: 0x040006D4 RID: 1748
	private string string_2;

	// Token: 0x040006D5 RID: 1749
	private string string_3;
}
