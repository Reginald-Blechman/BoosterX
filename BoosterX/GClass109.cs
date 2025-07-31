using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x02000338 RID: 824
public sealed class GClass109
{
	// Token: 0x17000342 RID: 834
	// (get) Token: 0x0600155B RID: 5467 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
	// (set) Token: 0x0600155C RID: 5468 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
	[JsonPropertyName("finish_reason")]
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

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x0600155D RID: 5469 RVA: 0x0000EBB9 File Offset: 0x0000CDB9
	// (set) Token: 0x0600155E RID: 5470 RVA: 0x0000EBC1 File Offset: 0x0000CDC1
	public int Index
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x0600155F RID: 5471 RVA: 0x0000EBCA File Offset: 0x0000CDCA
	// (set) Token: 0x06001560 RID: 5472 RVA: 0x0000EBD2 File Offset: 0x0000CDD2
	public GClass49 Message
	{
		[CompilerGenerated]
		get
		{
			return this.gclass49_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass49_0 = value;
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06001561 RID: 5473 RVA: 0x0000EBDB File Offset: 0x0000CDDB
	// (set) Token: 0x06001562 RID: 5474 RVA: 0x0000EBE3 File Offset: 0x0000CDE3
	public GClass83 Logprobs
	{
		[CompilerGenerated]
		get
		{
			return this.gclass83_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass83_0 = value;
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x06001563 RID: 5475 RVA: 0x0000EBEC File Offset: 0x0000CDEC
	// (set) Token: 0x06001564 RID: 5476 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
	public GClass49 Delta
	{
		[CompilerGenerated]
		get
		{
			return this.gclass49_1;
		}
		[CompilerGenerated]
		set
		{
			this.gclass49_1 = value;
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x06001565 RID: 5477 RVA: 0x0000EBFD File Offset: 0x0000CDFD
	// (set) Token: 0x06001566 RID: 5478 RVA: 0x0000EC05 File Offset: 0x0000CE05
	public string Text
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

	// Token: 0x04000E3D RID: 3645
	private string string_0;

	// Token: 0x04000E3E RID: 3646
	private int int_0;

	// Token: 0x04000E3F RID: 3647
	private GClass49 gclass49_0;

	// Token: 0x04000E40 RID: 3648
	private GClass83 gclass83_0;

	// Token: 0x04000E41 RID: 3649
	private GClass49 gclass49_1;

	// Token: 0x04000E42 RID: 3650
	private string string_1 = string.Empty;
}
