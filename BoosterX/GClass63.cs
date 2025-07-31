using System;
using Newtonsoft.Json;

// Token: 0x02000244 RID: 580
public class GClass63
{
	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0000B872 File Offset: 0x00009A72
	// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0000B87A File Offset: 0x00009A7A
	[JsonProperty("prompt_tokens")]
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

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0000B883 File Offset: 0x00009A83
	// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x0000B88B File Offset: 0x00009A8B
	[JsonProperty("total_tokens")]
	public int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x04000A0D RID: 2573
	private int int_0;

	// Token: 0x04000A0E RID: 2574
	private int int_1;
}
