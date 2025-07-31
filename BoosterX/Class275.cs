using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000257 RID: 599
internal sealed class Class275
{
	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06001022 RID: 4130 RVA: 0x0000BC44 File Offset: 0x00009E44
	// (set) Token: 0x06001023 RID: 4131 RVA: 0x0000BC4C File Offset: 0x00009E4C
	[JsonProperty("ValueTypes")]
	internal List<string> List_0
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

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06001024 RID: 4132 RVA: 0x0000BC55 File Offset: 0x00009E55
	// (set) Token: 0x06001025 RID: 4133 RVA: 0x0000BC5D File Offset: 0x00009E5D
	[JsonProperty("Value")]
	internal string String_0
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

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06001026 RID: 4134 RVA: 0x0000BC66 File Offset: 0x00009E66
	// (set) Token: 0x06001027 RID: 4135 RVA: 0x0000BC6E File Offset: 0x00009E6E
	[JsonProperty("ValueName")]
	internal string String_1
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

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06001028 RID: 4136 RVA: 0x0000BC77 File Offset: 0x00009E77
	// (set) Token: 0x06001029 RID: 4137 RVA: 0x0000BC7F File Offset: 0x00009E7F
	[JsonProperty("LocValue")]
	internal bool Boolean_0
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

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x0600102A RID: 4138 RVA: 0x0000BC88 File Offset: 0x00009E88
	[JsonIgnore]
	internal string String_2
	{
		get
		{
			if (!(this.String_0 == "Null"))
			{
				return this.String_0;
			}
			return Class298.smethod_2("Remove");
		}
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x0000BCAF File Offset: 0x00009EAF
	internal bool method_0()
	{
		return this.List_0.Contains("BEST") && this.List_0.Contains("ON");
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x0000BCD7 File Offset: 0x00009ED7
	internal bool method_1()
	{
		return this.List_0.Contains("OPTIMAL");
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x0600102D RID: 4141 RVA: 0x0000BCD7 File Offset: 0x00009ED7
	[JsonIgnore]
	internal bool Boolean_1
	{
		get
		{
			return this.List_0.Contains("OPTIMAL");
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x0600102E RID: 4142 RVA: 0x0000BCEA File Offset: 0x00009EEA
	[JsonIgnore]
	internal bool Boolean_2
	{
		get
		{
			return this.List_0.Contains("ON");
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x0600102F RID: 4143 RVA: 0x0000BCFD File Offset: 0x00009EFD
	[JsonIgnore]
	internal bool Boolean_3
	{
		get
		{
			return this.List_0.Contains("OFF");
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06001030 RID: 4144 RVA: 0x0000BD10 File Offset: 0x00009F10
	[JsonIgnore]
	internal bool Boolean_4
	{
		get
		{
			return this.List_0.Contains("BEST");
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06001031 RID: 4145 RVA: 0x0000BD23 File Offset: 0x00009F23
	[JsonIgnore]
	internal bool Boolean_5
	{
		get
		{
			return this.List_0.Contains("DEFAULT");
		}
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x0000BD36 File Offset: 0x00009F36
	internal bool method_2()
	{
		return this.List_0.Contains("DEFAULT") && this.List_0.Contains("ON");
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0000BD5E File Offset: 0x00009F5E
	internal bool method_3()
	{
		return this.List_0.Contains("DEFAULT") && this.List_0.Contains("BEST");
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x0000BD86 File Offset: 0x00009F86
	internal bool method_4()
	{
		return this.List_0.Contains("DEFAULT") && this.List_0.Contains("BEST") && this.List_0.Contains("OFF");
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x0000BDC1 File Offset: 0x00009FC1
	internal bool method_5()
	{
		return this.List_0.Contains("DEFAULT") && this.List_0.Contains("BEST") && this.List_0.Contains("ON");
	}

	// Token: 0x04000A34 RID: 2612
	private List<string> list_0;

	// Token: 0x04000A35 RID: 2613
	private string string_0;

	// Token: 0x04000A36 RID: 2614
	internal string string_1;

	// Token: 0x04000A37 RID: 2615
	private bool bool_0;
}
