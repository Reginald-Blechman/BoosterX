using System;
using Material.Icons;

// Token: 0x020000D9 RID: 217
internal sealed class Class485 : GClass162
{
	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060006AE RID: 1710 RVA: 0x000062A2 File Offset: 0x000044A2
	// (set) Token: 0x060006AF RID: 1711 RVA: 0x000062AA File Offset: 0x000044AA
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = Class298.smethod_2(value);
			base.method_0("Name");
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000062C4 File Offset: 0x000044C4
	// (set) Token: 0x060006B1 RID: 1713 RVA: 0x000062CC File Offset: 0x000044CC
	public string Description
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = Class298.smethod_2(value + "Desc");
			base.method_0("Description");
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060006B2 RID: 1714 RVA: 0x000062F1 File Offset: 0x000044F1
	// (set) Token: 0x060006B3 RID: 1715 RVA: 0x000062F9 File Offset: 0x000044F9
	public MaterialIconKind Icon
	{
		get
		{
			return this.materialIconKind_0;
		}
		set
		{
			this.materialIconKind_0 = value;
			base.method_0("Icon");
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0000630E File Offset: 0x0000450E
	// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00006316 File Offset: 0x00004516
	public bool ShowDescription
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

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0000631F File Offset: 0x0000451F
	// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00006327 File Offset: 0x00004527
	public string Cmd
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

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00006330 File Offset: 0x00004530
	// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00006338 File Offset: 0x00004538
	public string CmdAdd
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

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060006BA RID: 1722 RVA: 0x0003B430 File Offset: 0x00039630
	public GClass280 RunCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(Class485.Class142.class142_0.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x04000388 RID: 904
	private string string_0;

	// Token: 0x04000389 RID: 905
	private string string_1;

	// Token: 0x0400038A RID: 906
	private MaterialIconKind materialIconKind_0;

	// Token: 0x0400038B RID: 907
	private bool bool_0;

	// Token: 0x0400038C RID: 908
	private string string_2;

	// Token: 0x0400038D RID: 909
	private string string_3;

	// Token: 0x0400038E RID: 910
	private GClass280 gclass280_0;

	// Token: 0x020000DA RID: 218
	[Serializable]
	private sealed class Class142
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x0000311B File Offset: 0x0000131B
		internal void method_0(object object_0)
		{
		}

		// Token: 0x0400038F RID: 911
		public static readonly Class485.Class142 class142_0 = new Class485.Class142();

		// Token: 0x04000390 RID: 912
		public static Action<object> action_0;
	}
}
