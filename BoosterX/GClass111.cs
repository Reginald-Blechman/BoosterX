using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200033B RID: 827
public sealed class GClass111
{
	// Token: 0x17000348 RID: 840
	// (get) Token: 0x0600156D RID: 5485 RVA: 0x0000EC42 File Offset: 0x0000CE42
	// (set) Token: 0x0600156E RID: 5486 RVA: 0x0000EC4A File Offset: 0x0000CE4A
	[JsonProperty("WuBundleId")]
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

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x0600156F RID: 5487 RVA: 0x0000EC53 File Offset: 0x0000CE53
	// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000EC5B File Offset: 0x0000CE5B
	[JsonProperty("WuCategoryId")]
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

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06001571 RID: 5489 RVA: 0x0000EC64 File Offset: 0x0000CE64
	// (set) Token: 0x06001572 RID: 5490 RVA: 0x0000EC6C File Offset: 0x0000CE6C
	[JsonProperty("PackageFamilyName")]
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

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06001573 RID: 5491 RVA: 0x0000EC75 File Offset: 0x0000CE75
	// (set) Token: 0x06001574 RID: 5492 RVA: 0x0000EC7D File Offset: 0x0000CE7D
	[JsonProperty("SkuId")]
	public string String_3
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

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06001575 RID: 5493 RVA: 0x0000EC86 File Offset: 0x0000CE86
	// (set) Token: 0x06001576 RID: 5494 RVA: 0x0000EC8E File Offset: 0x0000CE8E
	[JsonProperty("Content")]
	public object Content
	{
		[CompilerGenerated]
		get
		{
			return this.object_0;
		}
		[CompilerGenerated]
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x04000E45 RID: 3653
	private string string_0;

	// Token: 0x04000E46 RID: 3654
	private string string_1;

	// Token: 0x04000E47 RID: 3655
	private string string_2;

	// Token: 0x04000E48 RID: 3656
	private string string_3;

	// Token: 0x04000E49 RID: 3657
	private object object_0;
}
