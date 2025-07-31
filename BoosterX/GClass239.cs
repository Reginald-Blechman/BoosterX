using System;
using Newtonsoft.Json;

// Token: 0x02000546 RID: 1350
public sealed class GClass239
{
	// Token: 0x0600220D RID: 8717 RVA: 0x00016507 File Offset: 0x00014707
	public GClass239()
	{
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x00088610 File Offset: 0x00086810
	public GClass239(string string_4, GClass27 gclass27_0, GClass115 gclass115_1 = null, string string_5 = "standard", string string_6 = null, GClass1 gclass1_1 = null)
	{
		this.String_0 = string_4;
		this.String_1 = (gclass27_0 ?? GClass27.smethod_32());
		this.String_3 = (string_5 ?? "standard");
		this.String_2 = string_6;
		this.GClass115_0 = (gclass115_1 ?? GClass115.smethod_2());
		this.GClass1_0 = (gclass1_1 ?? GClass1.smethod_0());
		if (this.String_1 == GClass27.smethod_33())
		{
			if (this.GClass115_0 == GClass115.smethod_0() || this.GClass115_0 == GClass115.smethod_1())
			{
				throw new ArgumentException("For DALL-E 3, only sizes 1024x1024, 1024x1792, or 1792x1024 are allowed.");
			}
			if (this.string_0 != "standard" && this.string_0 != "hd")
			{
				throw new ArgumentException("Quality must be one of 'standard' or 'hd'");
			}
		}
		else
		{
			if (this.GClass115_0 == GClass115.smethod_4() || this.GClass115_0 == GClass115.smethod_3())
			{
				throw new ArgumentException("For DALL-E 2, only sizes 256x256, 512x512, or 1024x1024 are allowed.");
			}
			if (this.string_0 != "standard")
			{
				throw new ArgumentException("For DALL-E 2, only 'standard' quality is available");
			}
		}
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x00088778 File Offset: 0x00086978
	public GClass239(string string_4, int? nullable_1 = 1, GClass115 gclass115_1 = null, string string_5 = null, GClass1 gclass1_1 = null)
	{
		this.String_0 = string_4;
		this.Nullable_0 = nullable_1;
		this.String_2 = string_5;
		this.GClass115_0 = (gclass115_1 ?? GClass115.smethod_2());
		this.GClass1_0 = (gclass1_1 ?? GClass1.smethod_0());
	}

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x06002210 RID: 8720 RVA: 0x00016542 File Offset: 0x00014742
	// (set) Token: 0x06002211 RID: 8721 RVA: 0x0001654A File Offset: 0x0001474A
	[JsonProperty("prompt")]
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

	// Token: 0x170005B9 RID: 1465
	// (get) Token: 0x06002212 RID: 8722 RVA: 0x00016553 File Offset: 0x00014753
	// (set) Token: 0x06002213 RID: 8723 RVA: 0x0001658C File Offset: 0x0001478C
	[JsonProperty("n")]
	public int? Nullable_0
	{
		get
		{
			if (this.String_1 == GClass27.smethod_33() && this.nullable_0.GetValueOrDefault() != 1)
			{
				throw new ArgumentException("For DALL-E 3, only 1 NumOfImages is allowed.");
			}
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x170005BA RID: 1466
	// (get) Token: 0x06002214 RID: 8724 RVA: 0x00016595 File Offset: 0x00014795
	// (set) Token: 0x06002215 RID: 8725 RVA: 0x0001659D File Offset: 0x0001479D
	[JsonProperty("model")]
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

	// Token: 0x170005BB RID: 1467
	// (get) Token: 0x06002216 RID: 8726 RVA: 0x000165A6 File Offset: 0x000147A6
	// (set) Token: 0x06002217 RID: 8727 RVA: 0x000165AE File Offset: 0x000147AE
	[JsonProperty("user")]
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

	// Token: 0x170005BC RID: 1468
	// (get) Token: 0x06002218 RID: 8728 RVA: 0x000887F8 File Offset: 0x000869F8
	// (set) Token: 0x06002219 RID: 8729 RVA: 0x000165B7 File Offset: 0x000147B7
	[JsonProperty("size")]
	[JsonConverter(typeof(GClass115.Class401))]
	public GClass115 GClass115_0
	{
		get
		{
			if (this.String_1 == GClass27.smethod_33() && (this.gclass115_0 == GClass115.smethod_0() || this.gclass115_0 == GClass115.smethod_1()))
			{
				throw new ArgumentException("For DALL-E 3, only 1024x1024, 1024x1792, or 1792x1024 is allowed.");
			}
			if (this.String_1 == GClass27.smethod_32() && (this.gclass115_0 == GClass115.smethod_4() || this.gclass115_0 == GClass115.smethod_3()))
			{
				throw new ArgumentException("For DALL-E 2, only 256x256, 512x512, or 1024x1024 is allowed.");
			}
			return this.gclass115_0;
		}
		set
		{
			this.gclass115_0 = value;
		}
	}

	// Token: 0x170005BD RID: 1469
	// (get) Token: 0x0600221A RID: 8730 RVA: 0x0008889C File Offset: 0x00086A9C
	// (set) Token: 0x0600221B RID: 8731 RVA: 0x00088914 File Offset: 0x00086B14
	[JsonProperty("quality", NullValueHandling = 1)]
	public string String_3
	{
		get
		{
			if (this.String_1 == GClass27.smethod_32() && this.string_0 == "hd")
			{
				throw new ArgumentException("For DALL-E 2, hd quality is not available.");
			}
			if (this.String_1 == GClass27.smethod_33() && this.string_0 == "standard")
			{
				return null;
			}
			return this.string_0;
		}
		set
		{
			string a = value.ToLower().Trim();
			if (a == "standard")
			{
				this.string_0 = "standard";
				return;
			}
			if (!(a == "hd"))
			{
				throw new ArgumentException("Quality must be either 'standard' or 'hd'.");
			}
			this.string_0 = "hd";
		}
	}

	// Token: 0x170005BE RID: 1470
	// (get) Token: 0x0600221C RID: 8732 RVA: 0x000165C0 File Offset: 0x000147C0
	// (set) Token: 0x0600221D RID: 8733 RVA: 0x000165C8 File Offset: 0x000147C8
	[JsonProperty("response_format")]
	[JsonConverter(typeof(GClass1.Class140))]
	public GClass1 GClass1_0
	{
		get
		{
			return this.gclass1_0;
		}
		set
		{
			this.gclass1_0 = value;
		}
	}

	// Token: 0x040016B2 RID: 5810
	private int? nullable_0 = new int?(1);

	// Token: 0x040016B3 RID: 5811
	private GClass115 gclass115_0 = GClass115.smethod_2();

	// Token: 0x040016B4 RID: 5812
	private string string_0 = "standard";

	// Token: 0x040016B5 RID: 5813
	private string string_1;

	// Token: 0x040016B6 RID: 5814
	private string string_2 = GClass27.smethod_32();

	// Token: 0x040016B7 RID: 5815
	private string string_3;

	// Token: 0x040016B8 RID: 5816
	private GClass1 gclass1_0;
}
