using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000314 RID: 788
public sealed class GClass103
{
	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x06001446 RID: 5190 RVA: 0x0000E29E File Offset: 0x0000C49E
	// (set) Token: 0x06001447 RID: 5191 RVA: 0x0000E2A6 File Offset: 0x0000C4A6
	[JsonProperty("blob.version")]
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

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x06001448 RID: 5192 RVA: 0x0000E2AF File Offset: 0x0000C4AF
	// (set) Token: 0x06001449 RID: 5193 RVA: 0x0000E2B7 File Offset: 0x0000C4B7
	[JsonProperty("content.isMain")]
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

	// Token: 0x170002F2 RID: 754
	// (get) Token: 0x0600144A RID: 5194 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
	// (set) Token: 0x0600144B RID: 5195 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
	[JsonProperty("content.packageId")]
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

	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x0600144C RID: 5196 RVA: 0x0000E2D1 File Offset: 0x0000C4D1
	// (set) Token: 0x0600144D RID: 5197 RVA: 0x0000E2D9 File Offset: 0x0000C4D9
	[JsonProperty("content.productId")]
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

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x0600144E RID: 5198 RVA: 0x0000E2E2 File Offset: 0x0000C4E2
	// (set) Token: 0x0600144F RID: 5199 RVA: 0x0000E2EA File Offset: 0x0000C4EA
	[JsonProperty("content.targetPlatforms")]
	public List<GClass21> List_0
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

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x06001450 RID: 5200 RVA: 0x0000E2F3 File Offset: 0x0000C4F3
	// (set) Token: 0x06001451 RID: 5201 RVA: 0x0000E2FB File Offset: 0x0000C4FB
	[JsonProperty("content.type")]
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

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x06001452 RID: 5202 RVA: 0x0000E304 File Offset: 0x0000C504
	// (set) Token: 0x06001453 RID: 5203 RVA: 0x0000E30C File Offset: 0x0000C50C
	[JsonProperty("policy")]
	public GClass263 GClass263_0
	{
		get
		{
			return this.gclass263_0;
		}
		set
		{
			this.gclass263_0 = value;
		}
	}

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x06001454 RID: 5204 RVA: 0x0000E315 File Offset: 0x0000C515
	// (set) Token: 0x06001455 RID: 5205 RVA: 0x0000E31D File Offset: 0x0000C51D
	[JsonProperty("policy2")]
	public GClass44 GClass44_0
	{
		get
		{
			return this.gclass44_0;
		}
		set
		{
			this.gclass44_0 = value;
		}
	}

	// Token: 0x04000DA9 RID: 3497
	private long long_0;

	// Token: 0x04000DAA RID: 3498
	private bool bool_0;

	// Token: 0x04000DAB RID: 3499
	private string string_0;

	// Token: 0x04000DAC RID: 3500
	private string string_1;

	// Token: 0x04000DAD RID: 3501
	private List<GClass21> list_0;

	// Token: 0x04000DAE RID: 3502
	private int int_0;

	// Token: 0x04000DAF RID: 3503
	private GClass263 gclass263_0;

	// Token: 0x04000DB0 RID: 3504
	private GClass44 gclass44_0;
}
