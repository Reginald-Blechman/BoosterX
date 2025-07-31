using System;

// Token: 0x02000525 RID: 1317
public sealed class GClass233
{
	// Token: 0x060021A4 RID: 8612 RVA: 0x00086064 File Offset: 0x00084264
	public GClass233(GEnum0 genum0_1, GEnum6 genum6_1, bool bool_0)
	{
		this.method_1(genum0_1);
		this.method_3(genum6_1);
		this.method_5(genum0_1.ToString());
		this.method_7(genum6_1.ToString());
		if (bool_0)
		{
			this.method_9(string.Concat(new string[]
			{
				"market=",
				this.method_4(),
				"&languages=",
				this.method_6(),
				"-",
				this.method_4(),
				",",
				this.method_6(),
				",neutral"
			}));
			return;
		}
		this.method_9(string.Concat(new string[]
		{
			"market=",
			this.method_4(),
			"&languages=",
			this.method_6(),
			"-",
			this.method_4(),
			",",
			this.method_6()
		}));
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x0001627E File Offset: 0x0001447E
	public GEnum0 method_0()
	{
		return this.genum0_0;
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x00016286 File Offset: 0x00014486
	private void method_1(GEnum0 genum0_1)
	{
		this.genum0_0 = genum0_1;
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x0001628F File Offset: 0x0001448F
	public GEnum6 method_2()
	{
		return this.genum6_0;
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x00016297 File Offset: 0x00014497
	private void method_3(GEnum6 genum6_1)
	{
		this.genum6_0 = genum6_1;
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000162A0 File Offset: 0x000144A0
	public string method_4()
	{
		return this.string_0;
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x000162A8 File Offset: 0x000144A8
	private void method_5(string string_3)
	{
		this.string_0 = string_3;
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x000162B1 File Offset: 0x000144B1
	public string method_6()
	{
		return this.string_1;
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x000162B9 File Offset: 0x000144B9
	private void method_7(string string_3)
	{
		this.string_1 = string_3;
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x000162C2 File Offset: 0x000144C2
	public string method_8()
	{
		return this.string_2;
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x000162CA File Offset: 0x000144CA
	private void method_9(string string_3)
	{
		this.string_2 = string_3;
	}

	// Token: 0x04001641 RID: 5697
	private GEnum0 genum0_0;

	// Token: 0x04001642 RID: 5698
	private GEnum6 genum6_0;

	// Token: 0x04001643 RID: 5699
	private string string_0;

	// Token: 0x04001644 RID: 5700
	private string string_1;

	// Token: 0x04001645 RID: 5701
	private string string_2;
}
