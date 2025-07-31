using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020002BA RID: 698
internal sealed class Class329
{
	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x0600129E RID: 4766 RVA: 0x0000D4F6 File Offset: 0x0000B6F6
	// (set) Token: 0x0600129F RID: 4767 RVA: 0x0000D4FE File Offset: 0x0000B6FE
	[JsonProperty("SUC")]
	public bool Boolean_0
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

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0000D507 File Offset: 0x0000B707
	// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0000D50F File Offset: 0x0000B70F
	[JsonProperty("PING")]
	public double Ping
	{
		[CompilerGenerated]
		get
		{
			return this.double_0;
		}
		[CompilerGenerated]
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0000D518 File Offset: 0x0000B718
	// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0000D520 File Offset: 0x0000B720
	[JsonProperty("SEND")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x060012A4 RID: 4772 RVA: 0x0000D529 File Offset: 0x0000B729
	// (set) Token: 0x060012A5 RID: 4773 RVA: 0x0000D531 File Offset: 0x0000B731
	[JsonProperty("RECT")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0000D53A File Offset: 0x0000B73A
	// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0000D542 File Offset: 0x0000B742
	[JsonProperty("SY")]
	public bool Boolean_1
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x0000D54B File Offset: 0x0000B74B
	public double method_0(double double_1)
	{
		if (double_1 - this.Ping <= 100.0)
		{
			return double_1 - this.Ping;
		}
		return 100.0;
	}

	// Token: 0x04000BA4 RID: 2980
	private bool bool_0;

	// Token: 0x04000BA5 RID: 2981
	private double double_0 = -1.0;

	// Token: 0x04000BA6 RID: 2982
	private long long_0;

	// Token: 0x04000BA7 RID: 2983
	private long long_1;

	// Token: 0x04000BA8 RID: 2984
	private bool bool_1 = true;
}
