using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020005C6 RID: 1478
[JsonObject]
public sealed class GClass254
{
	// Token: 0x1700065F RID: 1631
	// (get) Token: 0x060025F3 RID: 9715 RVA: 0x00019463 File Offset: 0x00017663
	// (set) Token: 0x060025F4 RID: 9716 RVA: 0x0001946B File Offset: 0x0001766B
	[JsonProperty("UserfriendlyName")]
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

	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x060025F5 RID: 9717 RVA: 0x00019474 File Offset: 0x00017674
	// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0001947C File Offset: 0x0001767C
	[JsonProperty("HexSettingID")]
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

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x060025F7 RID: 9719 RVA: 0x00019485 File Offset: 0x00017685
	// (set) Token: 0x060025F8 RID: 9720 RVA: 0x0001948D File Offset: 0x0001768D
	[JsonProperty("Description")]
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x060025F9 RID: 9721 RVA: 0x00019496 File Offset: 0x00017696
	// (set) Token: 0x060025FA RID: 9722 RVA: 0x0001949E File Offset: 0x0001769E
	[JsonProperty("GroupName")]
	public string String_2
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

	// Token: 0x17000663 RID: 1635
	// (get) Token: 0x060025FB RID: 9723 RVA: 0x000194A7 File Offset: 0x000176A7
	// (set) Token: 0x060025FC RID: 9724 RVA: 0x000194AF File Offset: 0x000176AF
	[JsonProperty("OverrideDefault")]
	public string String_3
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x060025FD RID: 9725 RVA: 0x000194B8 File Offset: 0x000176B8
	// (set) Token: 0x060025FE RID: 9726 RVA: 0x000194C0 File Offset: 0x000176C0
	[JsonProperty("MinRequiredDriverVersion")]
	public float Single_0
	{
		get
		{
			return this.float_0;
		}
		set
		{
			this.float_0 = value;
		}
	}

	// Token: 0x17000665 RID: 1637
	// (get) Token: 0x060025FF RID: 9727 RVA: 0x000194C9 File Offset: 0x000176C9
	// (set) Token: 0x06002600 RID: 9728 RVA: 0x000194D1 File Offset: 0x000176D1
	[JsonProperty("Hidden")]
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

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x06002601 RID: 9729 RVA: 0x000194DA File Offset: 0x000176DA
	// (set) Token: 0x06002602 RID: 9730 RVA: 0x000194E2 File Offset: 0x000176E2
	[JsonProperty("HasConstraints")]
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

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x06002603 RID: 9731 RVA: 0x000194EB File Offset: 0x000176EB
	// (set) Token: 0x06002604 RID: 9732 RVA: 0x000194F3 File Offset: 0x000176F3
	[JsonProperty("DataType")]
	public string String_4
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x06002605 RID: 9733 RVA: 0x000194FC File Offset: 0x000176FC
	// (set) Token: 0x06002606 RID: 9734 RVA: 0x00019504 File Offset: 0x00017704
	[JsonProperty("SettingValues")]
	public List<GClass12> List_0
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

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x06002607 RID: 9735 RVA: 0x0001950D File Offset: 0x0001770D
	public uint SettingId
	{
		get
		{
			return Convert.ToUInt32(this.String_1.Trim(), 16);
		}
	}

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x06002608 RID: 9736 RVA: 0x00092480 File Offset: 0x00090680
	public uint? DefaultValue
	{
		get
		{
			if (!string.IsNullOrEmpty(this.String_3))
			{
				return new uint?(Convert.ToUInt32(this.String_3.Trim(), 16));
			}
			return null;
		}
	}

	// Token: 0x040018E9 RID: 6377
	private string string_0;

	// Token: 0x040018EA RID: 6378
	private string string_1;

	// Token: 0x040018EB RID: 6379
	private string string_2;

	// Token: 0x040018EC RID: 6380
	private string string_3;

	// Token: 0x040018ED RID: 6381
	private string string_4;

	// Token: 0x040018EE RID: 6382
	private float float_0;

	// Token: 0x040018EF RID: 6383
	private bool bool_0;

	// Token: 0x040018F0 RID: 6384
	private bool bool_1;

	// Token: 0x040018F1 RID: 6385
	private string string_5;

	// Token: 0x040018F2 RID: 6386
	private List<GClass12> list_0;
}
