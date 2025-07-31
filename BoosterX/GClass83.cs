using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

// Token: 0x02000291 RID: 657
public sealed class GClass83
{
	// Token: 0x17000275 RID: 629
	// (get) Token: 0x0600119B RID: 4507 RVA: 0x0000CCE9 File Offset: 0x0000AEE9
	// (set) Token: 0x0600119C RID: 4508 RVA: 0x0000CCF1 File Offset: 0x0000AEF1
	[JsonPropertyName("text_offset")]
	public int[] Int32_0
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

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x0600119D RID: 4509 RVA: 0x0000CCFA File Offset: 0x0000AEFA
	// (set) Token: 0x0600119E RID: 4510 RVA: 0x0000CD02 File Offset: 0x0000AF02
	public string[] Tokens
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

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x0600119F RID: 4511 RVA: 0x0000CD0B File Offset: 0x0000AF0B
	// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0000CD13 File Offset: 0x0000AF13
	[JsonPropertyName("token_logprobs")]
	public double[] Double_0
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

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0000CD1C File Offset: 0x0000AF1C
	// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0000CD24 File Offset: 0x0000AF24
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

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0000CD2D File Offset: 0x0000AF2D
	// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000CD35 File Offset: 0x0000AF35
	public List<GClass7> Content
	{
		[CompilerGenerated]
		get
		{
			return this.list_1;
		}
		[CompilerGenerated]
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x04000AF8 RID: 2808
	private int[] int_0 = Array.Empty<int>();

	// Token: 0x04000AF9 RID: 2809
	private string[] string_0 = Array.Empty<string>();

	// Token: 0x04000AFA RID: 2810
	private double[] double_0 = Array.Empty<double>();

	// Token: 0x04000AFB RID: 2811
	private List<GClass203> list_0;

	// Token: 0x04000AFC RID: 2812
	private List<GClass7> list_1 = new List<GClass7>();
}
