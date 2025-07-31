using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200057C RID: 1404
public sealed class GClass242
{
	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x0600234F RID: 9039 RVA: 0x0001743E File Offset: 0x0001563E
	// (set) Token: 0x06002350 RID: 9040 RVA: 0x00017446 File Offset: 0x00015646
	[JsonProperty("text")]
	public string Text
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

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x06002351 RID: 9041 RVA: 0x0001744F File Offset: 0x0001564F
	// (set) Token: 0x06002352 RID: 9042 RVA: 0x00017457 File Offset: 0x00015657
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

	// Token: 0x170005EA RID: 1514
	// (get) Token: 0x06002353 RID: 9043 RVA: 0x00017460 File Offset: 0x00015660
	// (set) Token: 0x06002354 RID: 9044 RVA: 0x00017468 File Offset: 0x00015668
	[JsonProperty("logprobs")]
	public GClass129 GClass129_0
	{
		get
		{
			return this.gclass129_0;
		}
		set
		{
			this.gclass129_0 = value;
		}
	}

	// Token: 0x170005EB RID: 1515
	// (get) Token: 0x06002355 RID: 9045 RVA: 0x00017471 File Offset: 0x00015671
	// (set) Token: 0x06002356 RID: 9046 RVA: 0x00017479 File Offset: 0x00015679
	[JsonProperty("finish_reason")]
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

	// Token: 0x06002357 RID: 9047 RVA: 0x00017482 File Offset: 0x00015682
	public override string ToString()
	{
		return this.Text;
	}

	// Token: 0x04001754 RID: 5972
	private string string_0;

	// Token: 0x04001755 RID: 5973
	private int int_0;

	// Token: 0x04001756 RID: 5974
	private GClass129 gclass129_0;

	// Token: 0x04001757 RID: 5975
	private string string_1;
}
