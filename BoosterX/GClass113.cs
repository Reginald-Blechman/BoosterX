using System;
using Newtonsoft.Json;

// Token: 0x02000344 RID: 836
public sealed class GClass113
{
	// Token: 0x060015B2 RID: 5554 RVA: 0x00003332 File Offset: 0x00001532
	public GClass113()
	{
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x0000EE74 File Offset: 0x0000D074
	public GClass113(string string_2, GClass27 gclass27_0)
	{
		this.String_0 = gclass27_0;
		this.String_1 = string_2;
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x0000EE8F File Offset: 0x0000D08F
	public GClass113(string[] string_2, GClass27 gclass27_0)
	{
		this.String_0 = gclass27_0;
		this.String_2 = string_2;
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x0000EEAA File Offset: 0x0000D0AA
	public GClass113(params string[] string_2)
	{
		this.String_0 = GClass27.smethod_31();
		this.String_2 = string_2;
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x060015B6 RID: 5558 RVA: 0x0000EEC9 File Offset: 0x0000D0C9
	// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0000EED1 File Offset: 0x0000D0D1
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

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x060015B8 RID: 5560 RVA: 0x0000EEDA File Offset: 0x0000D0DA
	// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0000EEF1 File Offset: 0x0000D0F1
	[JsonIgnore]
	public string String_1
	{
		get
		{
			if (this.String_2 == null)
			{
				return null;
			}
			return Class746.smethod_2<string>(this.String_2);
		}
		set
		{
			this.String_2 = new string[]
			{
				value
			};
		}
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x060015BA RID: 5562 RVA: 0x0000EF03 File Offset: 0x0000D103
	// (set) Token: 0x060015BB RID: 5563 RVA: 0x0000EF0B File Offset: 0x0000D10B
	[JsonProperty("input")]
	public string[] String_2
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

	// Token: 0x04000E6E RID: 3694
	private string string_0;

	// Token: 0x04000E6F RID: 3695
	private string[] string_1;
}
