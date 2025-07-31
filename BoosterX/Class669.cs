using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x0200056D RID: 1389
internal sealed class Class669
{
	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00016E64 File Offset: 0x00015064
	// (set) Token: 0x060022D7 RID: 8919 RVA: 0x00016E6C File Offset: 0x0001506C
	[JsonProperty("C")]
	public string ChoosenArea
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x060022D8 RID: 8920 RVA: 0x00016E75 File Offset: 0x00015075
	// (set) Token: 0x060022D9 RID: 8921 RVA: 0x00016E7D File Offset: 0x0001507D
	[JsonProperty("N")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x060022DA RID: 8922 RVA: 0x00016E86 File Offset: 0x00015086
	// (set) Token: 0x060022DB RID: 8923 RVA: 0x00016E8E File Offset: 0x0001508E
	[JsonProperty("K")]
	public int Int32_0
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x060022DC RID: 8924 RVA: 0x00016E97 File Offset: 0x00015097
	// (set) Token: 0x060022DD RID: 8925 RVA: 0x00016E9F File Offset: 0x0001509F
	[JsonProperty("D")]
	public DateTime DateTime_0
	{
		get
		{
			return this.dateTime_0;
		}
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x060022DE RID: 8926 RVA: 0x00016EA8 File Offset: 0x000150A8
	// (set) Token: 0x060022DF RID: 8927 RVA: 0x00016EB0 File Offset: 0x000150B0
	[JsonProperty("V")]
	public List<double> Values
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x04001709 RID: 5897
	private string string_0;

	// Token: 0x0400170A RID: 5898
	private string string_1;

	// Token: 0x0400170B RID: 5899
	private int int_0;

	// Token: 0x0400170C RID: 5900
	private DateTime dateTime_0;

	// Token: 0x0400170D RID: 5901
	private List<double> list_0 = new List<double>();
}
