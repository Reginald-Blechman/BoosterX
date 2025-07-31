using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020000D2 RID: 210
public sealed class GClass0
{
	// Token: 0x06000626 RID: 1574 RVA: 0x00005E01 File Offset: 0x00004001
	public GClass243 method_0()
	{
		List<GClass243> list = this.List_1;
		if (list == null)
		{
			return null;
		}
		return list.Find(new Predicate<GClass243>(GClass0.Class138.class138_0.method_0));
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000627 RID: 1575 RVA: 0x00005E33 File Offset: 0x00004033
	// (set) Token: 0x06000628 RID: 1576 RVA: 0x00005E3B File Offset: 0x0000403B
	[JsonProperty("categories")]
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

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000629 RID: 1577 RVA: 0x00005E44 File Offset: 0x00004044
	// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005E4C File Offset: 0x0000404C
	[JsonProperty("images")]
	public List<GClass243> List_1
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

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600062B RID: 1579 RVA: 0x00005E55 File Offset: 0x00004055
	// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005E5D File Offset: 0x0000405D
	[JsonProperty("productId")]
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

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600062D RID: 1581 RVA: 0x00005E66 File Offset: 0x00004066
	// (set) Token: 0x0600062E RID: 1582 RVA: 0x00005E6E File Offset: 0x0000406E
	[JsonProperty("title")]
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

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600062F RID: 1583 RVA: 0x00005E77 File Offset: 0x00004077
	// (set) Token: 0x06000630 RID: 1584 RVA: 0x00005E7F File Offset: 0x0000407F
	[JsonProperty("shortTitle")]
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

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000631 RID: 1585 RVA: 0x00005E88 File Offset: 0x00004088
	// (set) Token: 0x06000632 RID: 1586 RVA: 0x00005E90 File Offset: 0x00004090
	[JsonProperty("titleLayout")]
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

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000633 RID: 1587 RVA: 0x00005E99 File Offset: 0x00004099
	// (set) Token: 0x06000634 RID: 1588 RVA: 0x00005EA1 File Offset: 0x000040A1
	[JsonProperty("description")]
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_4;
		}
		[CompilerGenerated]
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000635 RID: 1589 RVA: 0x00005EAA File Offset: 0x000040AA
	// (set) Token: 0x06000636 RID: 1590 RVA: 0x00005EB2 File Offset: 0x000040B2
	[JsonProperty("publisherName")]
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

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000637 RID: 1591 RVA: 0x00005EBB File Offset: 0x000040BB
	// (set) Token: 0x06000638 RID: 1592 RVA: 0x00005EC3 File Offset: 0x000040C3
	[JsonProperty("publisherId")]
	public string String_5
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000639 RID: 1593 RVA: 0x00005ECC File Offset: 0x000040CC
	// (set) Token: 0x0600063A RID: 1594 RVA: 0x00005ED4 File Offset: 0x000040D4
	[JsonProperty("isUniversal")]
	public string String_6
	{
		get
		{
			return this.string_7;
		}
		set
		{
			this.string_7 = value;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600063B RID: 1595 RVA: 0x00005EDD File Offset: 0x000040DD
	// (set) Token: 0x0600063C RID: 1596 RVA: 0x00005EE5 File Offset: 0x000040E5
	[JsonProperty("language")]
	public string String_7
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600063D RID: 1597 RVA: 0x00005EEE File Offset: 0x000040EE
	// (set) Token: 0x0600063E RID: 1598 RVA: 0x00005EF6 File Offset: 0x000040F6
	[JsonProperty("bgColor")]
	public string String_8
	{
		get
		{
			return this.string_9;
		}
		set
		{
			this.string_9 = value;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600063F RID: 1599 RVA: 0x00005EFF File Offset: 0x000040FF
	// (set) Token: 0x06000640 RID: 1600 RVA: 0x00005F07 File Offset: 0x00004107
	[JsonProperty("fgColor")]
	public string String_9
	{
		get
		{
			return this.string_10;
		}
		set
		{
			this.string_10 = value;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000641 RID: 1601 RVA: 0x00005F10 File Offset: 0x00004110
	// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005F18 File Offset: 0x00004118
	[JsonProperty("averageRating")]
	public string String_10
	{
		get
		{
			return this.string_11;
		}
		set
		{
			this.string_11 = value;
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000643 RID: 1603 RVA: 0x00005F21 File Offset: 0x00004121
	// (set) Token: 0x06000644 RID: 1604 RVA: 0x00005F29 File Offset: 0x00004129
	[JsonProperty("ratingCount")]
	public string String_11
	{
		get
		{
			return this.string_12;
		}
		set
		{
			this.string_12 = value;
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000645 RID: 1605 RVA: 0x00005F32 File Offset: 0x00004132
	// (set) Token: 0x06000646 RID: 1606 RVA: 0x00005F3A File Offset: 0x0000413A
	[JsonProperty("hasFreeTrial")]
	public string String_12
	{
		get
		{
			return this.string_13;
		}
		set
		{
			this.string_13 = value;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000647 RID: 1607 RVA: 0x00005F43 File Offset: 0x00004143
	// (set) Token: 0x06000648 RID: 1608 RVA: 0x00005F4B File Offset: 0x0000414B
	[JsonProperty("productType")]
	public string String_13
	{
		get
		{
			return this.string_14;
		}
		set
		{
			this.string_14 = value;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000649 RID: 1609 RVA: 0x00005F54 File Offset: 0x00004154
	// (set) Token: 0x0600064A RID: 1610 RVA: 0x00005F5C File Offset: 0x0000415C
	[JsonProperty("price")]
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

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600064B RID: 1611 RVA: 0x00005F65 File Offset: 0x00004165
	// (set) Token: 0x0600064C RID: 1612 RVA: 0x00005F6D File Offset: 0x0000416D
	[JsonProperty("currencySymbol")]
	public string String_14
	{
		get
		{
			return this.string_15;
		}
		set
		{
			this.string_15 = value;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600064D RID: 1613 RVA: 0x00005F76 File Offset: 0x00004176
	// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005F7E File Offset: 0x0000417E
	[JsonProperty("currencyCode")]
	public string String_15
	{
		get
		{
			return this.string_16;
		}
		set
		{
			this.string_16 = value;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600064F RID: 1615 RVA: 0x00005F87 File Offset: 0x00004187
	// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005F8F File Offset: 0x0000418F
	[JsonProperty("displayPrice")]
	public string String_16
	{
		get
		{
			return this.string_17;
		}
		set
		{
			this.string_17 = value;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000651 RID: 1617 RVA: 0x00005F98 File Offset: 0x00004198
	// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005FA0 File Offset: 0x000041A0
	[JsonProperty("strikethroughPrice")]
	public string String_17
	{
		get
		{
			return this.string_18;
		}
		set
		{
			this.string_18 = value;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000653 RID: 1619 RVA: 0x00005FA9 File Offset: 0x000041A9
	// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005FB1 File Offset: 0x000041B1
	[JsonProperty("developerName")]
	public string String_18
	{
		get
		{
			return this.string_19;
		}
		set
		{
			this.string_19 = value;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000655 RID: 1621 RVA: 0x00005FBA File Offset: 0x000041BA
	// (set) Token: 0x06000656 RID: 1622 RVA: 0x00005FC2 File Offset: 0x000041C2
	[JsonProperty("productFamilyName")]
	public string String_19
	{
		get
		{
			return this.string_20;
		}
		set
		{
			this.string_20 = value;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000657 RID: 1623 RVA: 0x00005FCB File Offset: 0x000041CB
	// (set) Token: 0x06000658 RID: 1624 RVA: 0x00005FD3 File Offset: 0x000041D3
	[JsonProperty("mediaType")]
	public string String_20
	{
		get
		{
			return this.string_21;
		}
		set
		{
			this.string_21 = value;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000659 RID: 1625 RVA: 0x00005FDC File Offset: 0x000041DC
	// (set) Token: 0x0600065A RID: 1626 RVA: 0x00005FE4 File Offset: 0x000041E4
	[JsonProperty("contentIds")]
	public List<string> List_2
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

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x0600065B RID: 1627 RVA: 0x00005FED File Offset: 0x000041ED
	// (set) Token: 0x0600065C RID: 1628 RVA: 0x00005FF5 File Offset: 0x000041F5
	[JsonProperty("packageFamilyNames")]
	public List<string> List_3
	{
		get
		{
			return this.list_3;
		}
		set
		{
			this.list_3 = value;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600065D RID: 1629 RVA: 0x00005FFE File Offset: 0x000041FE
	// (set) Token: 0x0600065E RID: 1630 RVA: 0x00006006 File Offset: 0x00004206
	[JsonProperty("subcategoryName")]
	public string String_21
	{
		get
		{
			return this.string_22;
		}
		set
		{
			this.string_22 = value;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600065F RID: 1631 RVA: 0x0000600F File Offset: 0x0000420F
	// (set) Token: 0x06000660 RID: 1632 RVA: 0x00006017 File Offset: 0x00004217
	[JsonProperty("alternateIds")]
	public List<GClass23> List_4
	{
		get
		{
			return this.list_4;
		}
		set
		{
			this.list_4 = value;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000661 RID: 1633 RVA: 0x00006020 File Offset: 0x00004220
	// (set) Token: 0x06000662 RID: 1634 RVA: 0x00006028 File Offset: 0x00004228
	[JsonProperty("collectionItemType")]
	public string String_22
	{
		get
		{
			return this.string_23;
		}
		set
		{
			this.string_23 = value;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000663 RID: 1635 RVA: 0x00006031 File Offset: 0x00004231
	// (set) Token: 0x06000664 RID: 1636 RVA: 0x00006039 File Offset: 0x00004239
	[JsonProperty("numberOfSeasons")]
	public string String_23
	{
		get
		{
			return this.string_24;
		}
		set
		{
			this.string_24 = value;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000665 RID: 1637 RVA: 0x00006042 File Offset: 0x00004242
	// (set) Token: 0x06000666 RID: 1638 RVA: 0x0000604A File Offset: 0x0000424A
	[JsonProperty("releaseDateUtc")]
	public string String_24
	{
		get
		{
			return this.string_25;
		}
		set
		{
			this.string_25 = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000667 RID: 1639 RVA: 0x00006053 File Offset: 0x00004253
	// (set) Token: 0x06000668 RID: 1640 RVA: 0x0000605B File Offset: 0x0000425B
	[JsonProperty("durationInSeconds")]
	public string String_25
	{
		get
		{
			return this.string_26;
		}
		set
		{
			this.string_26 = value;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000669 RID: 1641 RVA: 0x00006064 File Offset: 0x00004264
	// (set) Token: 0x0600066A RID: 1642 RVA: 0x0000606C File Offset: 0x0000426C
	[JsonProperty("isCompatible")]
	public string String_26
	{
		get
		{
			return this.string_27;
		}
		set
		{
			this.string_27 = value;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600066B RID: 1643 RVA: 0x00006075 File Offset: 0x00004275
	// (set) Token: 0x0600066C RID: 1644 RVA: 0x0000607D File Offset: 0x0000427D
	[JsonProperty("isPurchaseEnabled")]
	public string String_27
	{
		get
		{
			return this.string_28;
		}
		set
		{
			this.string_28 = value;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600066D RID: 1645 RVA: 0x00006086 File Offset: 0x00004286
	// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000608E File Offset: 0x0000428E
	[JsonProperty("developerOptOutOfSDCardInstall")]
	public string String_28
	{
		get
		{
			return this.string_29;
		}
		set
		{
			this.string_29 = value;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600066F RID: 1647 RVA: 0x00006097 File Offset: 0x00004297
	// (set) Token: 0x06000670 RID: 1648 RVA: 0x0000609F File Offset: 0x0000429F
	[JsonProperty("hasAddOns")]
	public string String_29
	{
		get
		{
			return this.string_30;
		}
		set
		{
			this.string_30 = value;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000671 RID: 1649 RVA: 0x000060A8 File Offset: 0x000042A8
	// (set) Token: 0x06000672 RID: 1650 RVA: 0x000060B0 File Offset: 0x000042B0
	[JsonProperty("hasThirdPartyIAPs")]
	public string String_30
	{
		get
		{
			return this.string_31;
		}
		set
		{
			this.string_31 = value;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000673 RID: 1651 RVA: 0x000060B9 File Offset: 0x000042B9
	// (set) Token: 0x06000674 RID: 1652 RVA: 0x000060C1 File Offset: 0x000042C1
	[JsonProperty("voiceTitle")]
	public string String_31
	{
		get
		{
			return this.string_32;
		}
		set
		{
			this.string_32 = value;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000675 RID: 1653 RVA: 0x000060CA File Offset: 0x000042CA
	// (set) Token: 0x06000676 RID: 1654 RVA: 0x000060D2 File Offset: 0x000042D2
	[JsonProperty("hideFromCollections")]
	public string String_32
	{
		get
		{
			return this.string_33;
		}
		set
		{
			this.string_33 = value;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000677 RID: 1655 RVA: 0x000060DB File Offset: 0x000042DB
	// (set) Token: 0x06000678 RID: 1656 RVA: 0x000060E3 File Offset: 0x000042E3
	[JsonProperty("hideFromDownloadsAndUpdates")]
	public string String_33
	{
		get
		{
			return this.string_34;
		}
		set
		{
			this.string_34 = value;
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000679 RID: 1657 RVA: 0x000060EC File Offset: 0x000042EC
	// (set) Token: 0x0600067A RID: 1658 RVA: 0x000060F4 File Offset: 0x000042F4
	[JsonProperty("gamingOptionsXboxLive")]
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

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600067B RID: 1659 RVA: 0x000060FD File Offset: 0x000042FD
	// (set) Token: 0x0600067C RID: 1660 RVA: 0x00006105 File Offset: 0x00004305
	[JsonProperty("availableDevicesDisplayText")]
	public string String_34
	{
		get
		{
			return this.string_35;
		}
		set
		{
			this.string_35 = value;
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600067D RID: 1661 RVA: 0x0000610E File Offset: 0x0000430E
	// (set) Token: 0x0600067E RID: 1662 RVA: 0x00006116 File Offset: 0x00004316
	[JsonProperty("availableDevicesNarratorText")]
	public string String_35
	{
		get
		{
			return this.string_36;
		}
		set
		{
			this.string_36 = value;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600067F RID: 1663 RVA: 0x0000611F File Offset: 0x0000431F
	// (set) Token: 0x06000680 RID: 1664 RVA: 0x00006127 File Offset: 0x00004327
	[JsonProperty("isGamingAppOnly")]
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

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000681 RID: 1665 RVA: 0x00006130 File Offset: 0x00004330
	// (set) Token: 0x06000682 RID: 1666 RVA: 0x00006138 File Offset: 0x00004338
	[JsonProperty("isSoftBlocked")]
	public string String_36
	{
		get
		{
			return this.string_37;
		}
		set
		{
			this.string_37 = value;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000683 RID: 1667 RVA: 0x00006141 File Offset: 0x00004341
	// (set) Token: 0x06000684 RID: 1668 RVA: 0x00006149 File Offset: 0x00004349
	[JsonProperty("tileLayout")]
	public string String_37
	{
		get
		{
			return this.string_38;
		}
		set
		{
			this.string_38 = value;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x00006152 File Offset: 0x00004352
	// (set) Token: 0x06000686 RID: 1670 RVA: 0x0000615A File Offset: 0x0000435A
	[JsonProperty("typeTag")]
	public string String_38
	{
		get
		{
			return this.string_39;
		}
		set
		{
			this.string_39 = value;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000687 RID: 1671 RVA: 0x00006163 File Offset: 0x00004363
	// (set) Token: 0x06000688 RID: 1672 RVA: 0x0000616B File Offset: 0x0000436B
	[JsonProperty("longDescription")]
	public string String_39
	{
		get
		{
			return this.string_40;
		}
		set
		{
			this.string_40 = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000689 RID: 1673 RVA: 0x00006174 File Offset: 0x00004374
	// (set) Token: 0x0600068A RID: 1674 RVA: 0x0000617C File Offset: 0x0000437C
	[JsonProperty("schema")]
	public string String_40
	{
		get
		{
			return this.string_41;
		}
		set
		{
			this.string_41 = value;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x00006185 File Offset: 0x00004385
	// (set) Token: 0x0600068C RID: 1676 RVA: 0x0000618D File Offset: 0x0000438D
	[JsonProperty("iconUrl")]
	public string String_41
	{
		get
		{
			return this.string_42;
		}
		set
		{
			this.string_42 = value;
		}
	}

	// Token: 0x0400034B RID: 843
	private List<string> list_0;

	// Token: 0x0400034C RID: 844
	private List<GClass243> list_1;

	// Token: 0x0400034D RID: 845
	private string string_0;

	// Token: 0x0400034E RID: 846
	private string string_1;

	// Token: 0x0400034F RID: 847
	private string string_2;

	// Token: 0x04000350 RID: 848
	private string string_3;

	// Token: 0x04000351 RID: 849
	private string string_4;

	// Token: 0x04000352 RID: 850
	private string string_5;

	// Token: 0x04000353 RID: 851
	private string string_6;

	// Token: 0x04000354 RID: 852
	private string string_7;

	// Token: 0x04000355 RID: 853
	private string string_8;

	// Token: 0x04000356 RID: 854
	private string string_9;

	// Token: 0x04000357 RID: 855
	private string string_10;

	// Token: 0x04000358 RID: 856
	private string string_11;

	// Token: 0x04000359 RID: 857
	private string string_12;

	// Token: 0x0400035A RID: 858
	private string string_13;

	// Token: 0x0400035B RID: 859
	private string string_14;

	// Token: 0x0400035C RID: 860
	private long long_0;

	// Token: 0x0400035D RID: 861
	private string string_15;

	// Token: 0x0400035E RID: 862
	private string string_16;

	// Token: 0x0400035F RID: 863
	private string string_17;

	// Token: 0x04000360 RID: 864
	private string string_18;

	// Token: 0x04000361 RID: 865
	private string string_19;

	// Token: 0x04000362 RID: 866
	private string string_20;

	// Token: 0x04000363 RID: 867
	private string string_21;

	// Token: 0x04000364 RID: 868
	private List<string> list_2;

	// Token: 0x04000365 RID: 869
	private List<string> list_3;

	// Token: 0x04000366 RID: 870
	private string string_22;

	// Token: 0x04000367 RID: 871
	private List<GClass23> list_4;

	// Token: 0x04000368 RID: 872
	private string string_23;

	// Token: 0x04000369 RID: 873
	private string string_24;

	// Token: 0x0400036A RID: 874
	private string string_25;

	// Token: 0x0400036B RID: 875
	private string string_26;

	// Token: 0x0400036C RID: 876
	private string string_27;

	// Token: 0x0400036D RID: 877
	private string string_28;

	// Token: 0x0400036E RID: 878
	private string string_29;

	// Token: 0x0400036F RID: 879
	private string string_30;

	// Token: 0x04000370 RID: 880
	private string string_31;

	// Token: 0x04000371 RID: 881
	private string string_32;

	// Token: 0x04000372 RID: 882
	private string string_33;

	// Token: 0x04000373 RID: 883
	private string string_34;

	// Token: 0x04000374 RID: 884
	private bool bool_0;

	// Token: 0x04000375 RID: 885
	private string string_35;

	// Token: 0x04000376 RID: 886
	private string string_36;

	// Token: 0x04000377 RID: 887
	private bool bool_1;

	// Token: 0x04000378 RID: 888
	private string string_37;

	// Token: 0x04000379 RID: 889
	private string string_38;

	// Token: 0x0400037A RID: 890
	private string string_39;

	// Token: 0x0400037B RID: 891
	private string string_40;

	// Token: 0x0400037C RID: 892
	private string string_41;

	// Token: 0x0400037D RID: 893
	private string string_42;

	// Token: 0x020000D3 RID: 211
	[Serializable]
	private sealed class Class138
	{
		// Token: 0x0600068F RID: 1679 RVA: 0x000061A2 File Offset: 0x000043A2
		internal bool method_0(GClass243 gclass243_0)
		{
			return gclass243_0.String_0 == "logo";
		}

		// Token: 0x0400037E RID: 894
		public static readonly GClass0.Class138 class138_0 = new GClass0.Class138();

		// Token: 0x0400037F RID: 895
		public static Predicate<GClass243> predicate_0;
	}
}
