using System;
using Newtonsoft.Json;

// Token: 0x0200061B RID: 1563
public sealed class GClass271
{
	// Token: 0x060027CD RID: 10189 RVA: 0x00003332 File Offset: 0x00001532
	public GClass271()
	{
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x0001A675 File Offset: 0x00018875
	public GClass271(GClass27 gclass27_0, string string_2)
	{
		this.String_0 = gclass27_0;
		this.String_1 = string_2;
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x0001A690 File Offset: 0x00018890
	public GClass271(string string_2)
	{
		this.String_0 = GClass27.smethod_29();
		this.String_1 = string_2;
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x060027D0 RID: 10192 RVA: 0x0001A6AF File Offset: 0x000188AF
	// (set) Token: 0x060027D1 RID: 10193 RVA: 0x0001A6B7 File Offset: 0x000188B7
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

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x060027D2 RID: 10194 RVA: 0x0001A6C0 File Offset: 0x000188C0
	// (set) Token: 0x060027D3 RID: 10195 RVA: 0x0001A6C8 File Offset: 0x000188C8
	[JsonProperty("input")]
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

	// Token: 0x04001A22 RID: 6690
	private string string_0;

	// Token: 0x04001A23 RID: 6691
	private string string_1;
}
