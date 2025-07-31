using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200011B RID: 283
public sealed class GClass164 : GClass162
{
	// Token: 0x0600082F RID: 2095 RVA: 0x00040CE4 File Offset: 0x0003EEE4
	public GClass164(GStruct0 gstruct0_0, bool bool_1)
	{
		this.IsEdited = false;
		this.GroupName = gstruct0_0.method_2();
		this.SettingItem = gstruct0_0.SettingItem;
		this.SettingMeta = gstruct0_0.method_0();
		List<GInterface11> values;
		if (!bool_1)
		{
			values = gstruct0_0.Values.Where(new Func<GInterface11, bool>(GClass164.Class170.class170_0.method_0)).ToList<GInterface11>();
		}
		else
		{
			values = gstruct0_0.Values;
		}
		this.Values = values;
		this.DefaultValue = (this.CurrentValue = gstruct0_0.CurrentValue);
		if (!string.IsNullOrEmpty(this.SettingMeta.Description))
		{
			this.Description = this.SettingMeta.Description;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000830 RID: 2096 RVA: 0x000070D0 File Offset: 0x000052D0
	// (set) Token: 0x06000831 RID: 2097 RVA: 0x000070D8 File Offset: 0x000052D8
	public bool IsEdited
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsEdited");
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000832 RID: 2098 RVA: 0x000070ED File Offset: 0x000052ED
	// (set) Token: 0x06000833 RID: 2099 RVA: 0x000070F5 File Offset: 0x000052F5
	public string GroupName
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

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000834 RID: 2100 RVA: 0x000070FE File Offset: 0x000052FE
	// (set) Token: 0x06000835 RID: 2101 RVA: 0x00007106 File Offset: 0x00005306
	public string Description
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

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000836 RID: 2102 RVA: 0x0000710F File Offset: 0x0000530F
	// (set) Token: 0x06000837 RID: 2103 RVA: 0x00007117 File Offset: 0x00005317
	public List<GInterface11> Values
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

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000838 RID: 2104 RVA: 0x00007120 File Offset: 0x00005320
	// (set) Token: 0x06000839 RID: 2105 RVA: 0x00007128 File Offset: 0x00005328
	public GInterface11 CurrentValue
	{
		get
		{
			return this.ginterface11_0;
		}
		set
		{
			if (this.ginterface11_1 == null)
			{
				this.ginterface11_1 = value;
			}
			this.ginterface11_0 = value;
			base.method_0("CurrentValue");
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x0600083A RID: 2106 RVA: 0x0000714C File Offset: 0x0000534C
	// (set) Token: 0x0600083B RID: 2107 RVA: 0x00007154 File Offset: 0x00005354
	public GInterface11 DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return this.ginterface11_2;
		}
		[CompilerGenerated]
		set
		{
			this.ginterface11_2 = value;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x0600083C RID: 2108 RVA: 0x0000715D File Offset: 0x0000535D
	// (set) Token: 0x0600083D RID: 2109 RVA: 0x00007165 File Offset: 0x00005365
	public GClass208 SettingItem
	{
		[CompilerGenerated]
		get
		{
			return this.gclass208_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass208_0 = value;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x0600083E RID: 2110 RVA: 0x0000716E File Offset: 0x0000536E
	// (set) Token: 0x0600083F RID: 2111 RVA: 0x00007176 File Offset: 0x00005376
	public GClass112 SettingMeta
	{
		[CompilerGenerated]
		get
		{
			return this.gclass112_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass112_0 = value;
		}
	}

	// Token: 0x040004A3 RID: 1187
	private bool bool_0;

	// Token: 0x040004A4 RID: 1188
	private string string_0;

	// Token: 0x040004A5 RID: 1189
	private string string_1 = "No description..";

	// Token: 0x040004A6 RID: 1190
	private List<GInterface11> list_0;

	// Token: 0x040004A7 RID: 1191
	private GInterface11 ginterface11_0;

	// Token: 0x040004A8 RID: 1192
	public GInterface11 ginterface11_1;

	// Token: 0x040004A9 RID: 1193
	private GInterface11 ginterface11_2;

	// Token: 0x040004AA RID: 1194
	private GClass208 gclass208_0;

	// Token: 0x040004AB RID: 1195
	private GClass112 gclass112_0;

	// Token: 0x0200011C RID: 284
	[Serializable]
	private sealed class Class170
	{
		// Token: 0x06000842 RID: 2114 RVA: 0x0000718B File Offset: 0x0000538B
		internal bool method_0(GInterface11 ginterface11_0)
		{
			return !ginterface11_0.imethod_1().StartsWith("0x");
		}

		// Token: 0x040004AC RID: 1196
		public static readonly GClass164.Class170 class170_0 = new GClass164.Class170();

		// Token: 0x040004AD RID: 1197
		public static Func<GInterface11, bool> func_0;
	}
}
