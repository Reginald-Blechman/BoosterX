using System;
using Newtonsoft.Json;

// Token: 0x02000320 RID: 800
public sealed class GClass106
{
	// Token: 0x1700031E RID: 798
	// (get) Token: 0x060014CB RID: 5323 RVA: 0x0000E748 File Offset: 0x0000C948
	// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000E750 File Offset: 0x0000C950
	[JsonProperty("model")]
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

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x060014CD RID: 5325 RVA: 0x0000E759 File Offset: 0x0000C959
	// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000E761 File Offset: 0x0000C961
	[JsonProperty("prompt", DefaultValueHandling = 1)]
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

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x060014CF RID: 5327 RVA: 0x0000E76A File Offset: 0x0000C96A
	// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0000E772 File Offset: 0x0000C972
	[JsonProperty("language", DefaultValueHandling = 1)]
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

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0000E77B File Offset: 0x0000C97B
	// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000E783 File Offset: 0x0000C983
	[JsonProperty("response_format", DefaultValueHandling = 1)]
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

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0000E78C File Offset: 0x0000C98C
	// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0000E794 File Offset: 0x0000C994
	[JsonProperty("temperature", DefaultValueHandling = 1)]
	public double Double_0
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x04000DE3 RID: 3555
	private string string_0 = GClass27.smethod_6();

	// Token: 0x04000DE4 RID: 3556
	private string string_1;

	// Token: 0x04000DE5 RID: 3557
	private string string_2;

	// Token: 0x04000DE6 RID: 3558
	private string string_3;

	// Token: 0x04000DE7 RID: 3559
	private double double_0;

	// Token: 0x02000321 RID: 801
	public static class GClass107
	{
	}
}
