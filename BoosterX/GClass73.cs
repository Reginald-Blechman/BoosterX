using System;
using Newtonsoft.Json;

// Token: 0x02000277 RID: 631
public sealed class GClass73
{
	// Token: 0x17000234 RID: 564
	// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0000C4AC File Offset: 0x0000A6AC
	// (set) Token: 0x060010EA RID: 4330 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
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

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x060010EB RID: 4331 RVA: 0x0000C4BD File Offset: 0x0000A6BD
	// (set) Token: 0x060010EC RID: 4332 RVA: 0x0000C4C5 File Offset: 0x0000A6C5
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

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x060010ED RID: 4333 RVA: 0x0000C4CE File Offset: 0x0000A6CE
	// (set) Token: 0x060010EE RID: 4334 RVA: 0x0000C4D6 File Offset: 0x0000A6D6
	[JsonProperty("voice")]
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

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x060010EF RID: 4335 RVA: 0x0000C4DF File Offset: 0x0000A6DF
	// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0000C4E7 File Offset: 0x0000A6E7
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

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
	// (set) Token: 0x060010F2 RID: 4338 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
	[JsonProperty("speed", DefaultValueHandling = 1)]
	public double? Nullable_0
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x04000AA3 RID: 2723
	private string string_0 = GClass27.smethod_4();

	// Token: 0x04000AA4 RID: 2724
	private string string_1;

	// Token: 0x04000AA5 RID: 2725
	private string string_2 = "alloy";

	// Token: 0x04000AA6 RID: 2726
	private string string_3;

	// Token: 0x04000AA7 RID: 2727
	private double? nullable_0;

	// Token: 0x02000278 RID: 632
	public static class GClass74
	{
	}

	// Token: 0x02000279 RID: 633
	public static class GClass75
	{
	}
}
