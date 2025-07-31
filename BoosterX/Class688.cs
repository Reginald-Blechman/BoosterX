using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200058B RID: 1419
internal sealed class Class688
{
	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x0600239F RID: 9119 RVA: 0x000176B0 File Offset: 0x000158B0
	// (set) Token: 0x060023A0 RID: 9120 RVA: 0x000176B8 File Offset: 0x000158B8
	[JsonProperty("DS")]
	public double Double_0
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x060023A1 RID: 9121 RVA: 0x000176C1 File Offset: 0x000158C1
	// (set) Token: 0x060023A2 RID: 9122 RVA: 0x000176C9 File Offset: 0x000158C9
	[JsonProperty("US")]
	public double Double_1
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x060023A3 RID: 9123 RVA: 0x000176D2 File Offset: 0x000158D2
	// (set) Token: 0x060023A4 RID: 9124 RVA: 0x000176DA File Offset: 0x000158DA
	[JsonProperty("ULP")]
	public List<GClass41> List_0
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

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000176E3 File Offset: 0x000158E3
	// (set) Token: 0x060023A6 RID: 9126 RVA: 0x000176EB File Offset: 0x000158EB
	[JsonProperty("DP")]
	public List<GClass41> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x170005FA RID: 1530
	// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000176F4 File Offset: 0x000158F4
	// (set) Token: 0x060023A8 RID: 9128 RVA: 0x000176FC File Offset: 0x000158FC
	[JsonProperty("UP")]
	public List<GClass41> List_2
	{
		get
		{
			return this.list_2;
		}
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x04001789 RID: 6025
	private double double_0;

	// Token: 0x0400178A RID: 6026
	private double double_1;

	// Token: 0x0400178B RID: 6027
	private List<GClass41> list_0 = new List<GClass41>();

	// Token: 0x0400178C RID: 6028
	private List<GClass41> list_1 = new List<GClass41>();

	// Token: 0x0400178D RID: 6029
	private List<GClass41> list_2 = new List<GClass41>();
}
