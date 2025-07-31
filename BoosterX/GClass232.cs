using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000524 RID: 1316
public sealed class GClass232
{
	// Token: 0x170005A9 RID: 1449
	// (get) Token: 0x06002190 RID: 8592 RVA: 0x000161D4 File Offset: 0x000143D4
	// (set) Token: 0x06002191 RID: 8593 RVA: 0x000161DC File Offset: 0x000143DC
	[JsonProperty("LastModifiedDate")]
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

	// Token: 0x170005AA RID: 1450
	// (get) Token: 0x06002192 RID: 8594 RVA: 0x000161E5 File Offset: 0x000143E5
	// (set) Token: 0x06002193 RID: 8595 RVA: 0x000161ED File Offset: 0x000143ED
	[JsonProperty("LocalizedProperties")]
	public List<GClass31> List_0
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

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x06002194 RID: 8596 RVA: 0x000161F6 File Offset: 0x000143F6
	// (set) Token: 0x06002195 RID: 8597 RVA: 0x000161FE File Offset: 0x000143FE
	[JsonProperty("MarketProperties")]
	public List<GClass138> List_1
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

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x06002196 RID: 8598 RVA: 0x00016207 File Offset: 0x00014407
	// (set) Token: 0x06002197 RID: 8599 RVA: 0x0001620F File Offset: 0x0001440F
	[JsonProperty("Properties")]
	public GClass291 GClass291_0
	{
		get
		{
			return this.gclass291_0;
		}
		set
		{
			this.gclass291_0 = value;
		}
	}

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x06002198 RID: 8600 RVA: 0x00016218 File Offset: 0x00014418
	// (set) Token: 0x06002199 RID: 8601 RVA: 0x00016220 File Offset: 0x00014420
	[JsonProperty("SkuASchema")]
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

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x0600219A RID: 8602 RVA: 0x00016229 File Offset: 0x00014429
	// (set) Token: 0x0600219B RID: 8603 RVA: 0x00016231 File Offset: 0x00014431
	[JsonProperty("SkuBSchema")]
	public string String_1
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

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x0600219C RID: 8604 RVA: 0x0001623A File Offset: 0x0001443A
	// (set) Token: 0x0600219D RID: 8605 RVA: 0x00016242 File Offset: 0x00014442
	[JsonProperty("SkuId")]
	public string String_2
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

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x0600219E RID: 8606 RVA: 0x0001624B File Offset: 0x0001444B
	// (set) Token: 0x0600219F RID: 8607 RVA: 0x00016253 File Offset: 0x00014453
	[JsonProperty("SkuType")]
	public string String_3
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

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x060021A0 RID: 8608 RVA: 0x0001625C File Offset: 0x0001445C
	// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00016264 File Offset: 0x00014464
	[JsonProperty("RecurrencePolicy")]
	public object Object_0
	{
		get
		{
			return this.object_0;
		}
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x060021A2 RID: 8610 RVA: 0x0001626D File Offset: 0x0001446D
	// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00016275 File Offset: 0x00014475
	[JsonProperty("SubscriptionPolicyId")]
	public object Object_1
	{
		get
		{
			return this.object_1;
		}
		set
		{
			this.object_1 = value;
		}
	}

	// Token: 0x04001637 RID: 5687
	private DateTime dateTime_0;

	// Token: 0x04001638 RID: 5688
	private List<GClass31> list_0;

	// Token: 0x04001639 RID: 5689
	private List<GClass138> list_1;

	// Token: 0x0400163A RID: 5690
	private GClass291 gclass291_0;

	// Token: 0x0400163B RID: 5691
	private string string_0;

	// Token: 0x0400163C RID: 5692
	private string string_1;

	// Token: 0x0400163D RID: 5693
	private string string_2;

	// Token: 0x0400163E RID: 5694
	private string string_3;

	// Token: 0x0400163F RID: 5695
	private object object_0;

	// Token: 0x04001640 RID: 5696
	private object object_1;
}
