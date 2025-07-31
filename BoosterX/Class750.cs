using System;

// Token: 0x0200023D RID: 573
internal sealed class Class750 : Class749
{
	// Token: 0x06000F93 RID: 3987 RVA: 0x0000B69B File Offset: 0x0000989B
	public Class750(string string_1)
	{
		this.method_2(string_1);
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x0000B6AA File Offset: 0x000098AA
	public string method_0()
	{
		return "GameModeX\\Apps\\" + this.method_1();
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x0000B6BD File Offset: 0x000098BD
	public string method_1()
	{
		return this.string_0;
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x0000B6C5 File Offset: 0x000098C5
	public void method_2(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x0000B6CE File Offset: 0x000098CE
	public string method_3()
	{
		return Class749.smethod_0("ExeName", this.method_0());
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0000B6E1 File Offset: 0x000098E1
	public void method_4(string string_1)
	{
		Class749.smethod_1("ExeName", string_1.ToString(), this.method_0());
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000F99 RID: 3993 RVA: 0x0000B6FA File Offset: 0x000098FA
	// (set) Token: 0x06000F9A RID: 3994 RVA: 0x0000B70D File Offset: 0x0000990D
	public string ExeDir
	{
		get
		{
			return Class749.smethod_0("ExeDir", this.method_0());
		}
		set
		{
			Class749.smethod_1("ExeDir", value.ToString(), this.method_0());
		}
	}

	// Token: 0x04000A00 RID: 2560
	private string string_0;
}
