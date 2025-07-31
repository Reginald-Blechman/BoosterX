using System;

// Token: 0x02000245 RID: 581
internal sealed class Class751 : Class749
{
	// Token: 0x06000FC9 RID: 4041 RVA: 0x0000B894 File Offset: 0x00009A94
	public Class751(string string_1)
	{
		this.method_2(string_1);
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x0000B8A3 File Offset: 0x00009AA3
	public string method_0()
	{
		return "GameModeX\\Games\\" + this.method_1();
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x0000B8B6 File Offset: 0x00009AB6
	public string method_1()
	{
		return this.string_0;
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x0000B8BE File Offset: 0x00009ABE
	public void method_2(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x0000B8C7 File Offset: 0x00009AC7
	public string method_3()
	{
		return Class749.smethod_0("ExeName", this.method_0());
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x0000B8DA File Offset: 0x00009ADA
	public void method_4(string string_1)
	{
		Class749.smethod_1("ExeName", string_1.ToString(), this.method_0());
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0000B8F3 File Offset: 0x00009AF3
	// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x0000B906 File Offset: 0x00009B06
	public string FoundIn
	{
		get
		{
			return Class749.smethod_0("FoundIn", this.method_0());
		}
		set
		{
			Class749.smethod_1("FoundIn", value.ToString(), this.method_0());
		}
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x0000B91F File Offset: 0x00009B1F
	public string method_5()
	{
		return Class749.smethod_0("GamePath", this.method_0());
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x0000B932 File Offset: 0x00009B32
	public void method_6(string string_1)
	{
		Class749.smethod_1("GamePath", string_1.ToString(), this.method_0());
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0000B94B File Offset: 0x00009B4B
	// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x0000B95E File Offset: 0x00009B5E
	public string Affinity
	{
		get
		{
			return Class749.smethod_0("Affinity", this.method_0());
		}
		set
		{
			Class749.smethod_1("Affinity", value.ToString(), this.method_0());
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0000B977 File Offset: 0x00009B77
	// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x0000B98A File Offset: 0x00009B8A
	public string LaunchDelay
	{
		get
		{
			return Class749.smethod_0("LaunchDelay", this.method_0());
		}
		set
		{
			Class749.smethod_1("LaunchDelay", value.ToString(), this.method_0());
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00055788 File Offset: 0x00053988
	// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x0000B9A3 File Offset: 0x00009BA3
	public bool? DisableDWM
	{
		get
		{
			if (Class749.smethod_0("DisableDWM", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class749.smethod_0("DisableDWM", this.method_0())));
		}
		set
		{
			Class749.smethod_1("DisableDWM", value.ToString(), this.method_0());
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000557D8 File Offset: 0x000539D8
	// (set) Token: 0x06000FDA RID: 4058 RVA: 0x0000B9C3 File Offset: 0x00009BC3
	public bool? DisableExplorer
	{
		get
		{
			if (Class749.smethod_0("DisableExplorer", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class749.smethod_0("DisableExplorer", this.method_0())));
		}
		set
		{
			Class749.smethod_1("DisableExplorer", value.ToString(), this.method_0());
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00055828 File Offset: 0x00053A28
	// (set) Token: 0x06000FDC RID: 4060 RVA: 0x0000B9E3 File Offset: 0x00009BE3
	public bool? UseGlobalProfile
	{
		get
		{
			if (Class749.smethod_0("UseGlobalProfile", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class749.smethod_0("UseGlobalProfile", this.method_0())));
		}
		set
		{
			Class749.smethod_1("UseGlobalProfile", value.ToString(), this.method_0());
		}
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00055878 File Offset: 0x00053A78
	// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0000BA03 File Offset: 0x00009C03
	public bool? ThreadCompatibility
	{
		get
		{
			if (Class749.smethod_0("UseGlobalProfile", this.method_0()) == string.Empty)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(Class749.smethod_0("ThreadCompatibility", this.method_0())));
		}
		set
		{
			Class749.smethod_1("ThreadCompatibility", value.ToString(), this.method_0());
		}
	}

	// Token: 0x04000A0F RID: 2575
	private string string_0;
}
