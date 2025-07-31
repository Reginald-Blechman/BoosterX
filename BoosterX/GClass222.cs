using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using Newtonsoft.Json;

// Token: 0x020004FE RID: 1278
public sealed class GClass222
{
	// Token: 0x06002086 RID: 8326 RVA: 0x00015824 File Offset: 0x00013A24
	public GClass222(string string_1, ServiceStartMode? nullable_1, bool bool_2 = false, bool bool_3 = false)
	{
		this.ServiceName = string_1;
		this.IsBlocked = bool_2;
		this.Boolean_0 = bool_3;
		this.DefaultStartMode = nullable_1;
	}

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x06002087 RID: 8327 RVA: 0x00015854 File Offset: 0x00013A54
	// (set) Token: 0x06002088 RID: 8328 RVA: 0x0001585C File Offset: 0x00013A5C
	[JsonProperty("ServiceName")]
	public string ServiceName
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

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06002089 RID: 8329 RVA: 0x00015865 File Offset: 0x00013A65
	// (set) Token: 0x0600208A RID: 8330 RVA: 0x0001586D File Offset: 0x00013A6D
	[JsonProperty("IsBlocked")]
	public bool IsBlocked
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700059C RID: 1436
	// (get) Token: 0x0600208B RID: 8331 RVA: 0x00015876 File Offset: 0x00013A76
	// (set) Token: 0x0600208C RID: 8332 RVA: 0x0001587E File Offset: 0x00013A7E
	[JsonProperty("IsBlocked11")]
	public bool Boolean_0
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

	// Token: 0x1700059D RID: 1437
	// (get) Token: 0x0600208D RID: 8333 RVA: 0x00015887 File Offset: 0x00013A87
	// (set) Token: 0x0600208E RID: 8334 RVA: 0x0001588F File Offset: 0x00013A8F
	[JsonProperty("DefaultStartMode")]
	public ServiceStartMode? DefaultStartMode
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x1700059E RID: 1438
	// (get) Token: 0x0600208F RID: 8335 RVA: 0x00015898 File Offset: 0x00013A98
	// (set) Token: 0x06002090 RID: 8336 RVA: 0x000158A0 File Offset: 0x00013AA0
	[JsonProperty("WillBrakeLoc")]
	public List<string> List_0
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

	// Token: 0x04001590 RID: 5520
	private string string_0;

	// Token: 0x04001591 RID: 5521
	private bool bool_0;

	// Token: 0x04001592 RID: 5522
	private bool bool_1;

	// Token: 0x04001593 RID: 5523
	private ServiceStartMode? nullable_0;

	// Token: 0x04001594 RID: 5524
	private List<string> list_0 = new List<string>();
}
