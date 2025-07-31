using System;
using System.Collections.Generic;

// Token: 0x0200028A RID: 650
internal sealed class Class504 : GClass162
{
	// Token: 0x06001159 RID: 4441 RVA: 0x0000CA1D File Offset: 0x0000AC1D
	internal Class504(Class275 class275_1, Class489 class489_1)
	{
		this.class489_0 = class489_1;
		this.class275_0 = class275_1;
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x0600115A RID: 4442 RVA: 0x0000CA33 File Offset: 0x0000AC33
	public bool OnEdit
	{
		get
		{
			return this.class489_0.OnEdit && this.class489_0.OnEdit;
		}
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x0600115B RID: 4443 RVA: 0x0000CA4F File Offset: 0x0000AC4F
	public bool IsReadOnly
	{
		get
		{
			return this.class489_0.TypeD == "DEVICE" || this.class489_0.TypeD == "TASK";
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x0600115C RID: 4444 RVA: 0x0000CA81 File Offset: 0x0000AC81
	public List<string> ValueTypesD
	{
		get
		{
			return this.class275_0.List_0;
		}
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x0600115D RID: 4445 RVA: 0x0000CA8E File Offset: 0x0000AC8E
	// (set) Token: 0x0600115E RID: 4446 RVA: 0x0000CA9B File Offset: 0x0000AC9B
	public string ValueD
	{
		get
		{
			return this.class275_0.String_0;
		}
		set
		{
			if (!this.class489_0.OnEdit)
			{
				return;
			}
			this.class275_0.String_0 = value;
			base.method_0("ValueD");
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x0600115F RID: 4447 RVA: 0x0000CAC3 File Offset: 0x0000ACC3
	public string ValueHandlerD
	{
		get
		{
			return this.class275_0.String_2;
		}
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
	public bool method_2()
	{
		return this.class275_0.method_0();
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x0000CADD File Offset: 0x0000ACDD
	public bool method_3()
	{
		return this.class275_0.method_1();
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x06001162 RID: 4450 RVA: 0x0000CAEA File Offset: 0x0000ACEA
	public bool ContainsOpt
	{
		get
		{
			return this.class275_0.Boolean_1;
		}
	}

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x06001163 RID: 4451 RVA: 0x0000CAF7 File Offset: 0x0000ACF7
	public bool ContainsOn
	{
		get
		{
			return this.class275_0.Boolean_2;
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x0000CB04 File Offset: 0x0000AD04
	public bool ContainsOff
	{
		get
		{
			return this.class275_0.Boolean_3;
		}
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x06001165 RID: 4453 RVA: 0x0000CB11 File Offset: 0x0000AD11
	public bool ContainsBest
	{
		get
		{
			return this.class275_0.Boolean_4;
		}
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x06001166 RID: 4454 RVA: 0x0000CB1E File Offset: 0x0000AD1E
	public bool ContainsDefault
	{
		get
		{
			return this.class275_0.Boolean_5;
		}
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x0000CB2B File Offset: 0x0000AD2B
	public bool method_4()
	{
		return this.class275_0.method_2();
	}

	// Token: 0x04000AD3 RID: 2771
	internal Class275 class275_0;

	// Token: 0x04000AD4 RID: 2772
	internal Class489 class489_0;
}
