using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x02000486 RID: 1158
public sealed class GClass209
{
	// Token: 0x06001E1E RID: 7710 RVA: 0x00013E21 File Offset: 0x00012021
	public static bool smethod_0(GClass165 gclass165_0)
	{
		return GClass207.smethod_0().get_Item(GClass219.smethod_18(gclass165_0.ServiceName)) != null;
	}

	// Token: 0x02000487 RID: 1159
	public enum GEnum10
	{

	}

	// Token: 0x02000488 RID: 1160
	public sealed class GClass210
	{
		// Token: 0x06001E20 RID: 7712 RVA: 0x00013E3B File Offset: 0x0001203B
		public List<GClass209.GClass211> method_0()
		{
			return this.list_0;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00013E43 File Offset: 0x00012043
		public void method_1(List<GClass209.GClass211> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x04001409 RID: 5129
		private List<GClass209.GClass211> list_0;
	}

	// Token: 0x02000489 RID: 1161
	public sealed class GClass211
	{
		// Token: 0x06001E23 RID: 7715 RVA: 0x00013E4C File Offset: 0x0001204C
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00013E54 File Offset: 0x00012054
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00013E5D File Offset: 0x0001205D
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00013E65 File Offset: 0x00012065
		public bool IsRed
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

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00013E6E File Offset: 0x0001206E
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x00013E76 File Offset: 0x00012076
		public List<string> Services
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

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00013E7F File Offset: 0x0001207F
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x00013E87 File Offset: 0x00012087
		public MaterialIconKind Icon
		{
			[CompilerGenerated]
			get
			{
				return this.materialIconKind_0;
			}
			[CompilerGenerated]
			set
			{
				this.materialIconKind_0 = value;
			}
		}

		// Token: 0x0400140A RID: 5130
		private string string_0;

		// Token: 0x0400140B RID: 5131
		private bool bool_0;

		// Token: 0x0400140C RID: 5132
		private List<string> list_0;

		// Token: 0x0400140D RID: 5133
		private MaterialIconKind materialIconKind_0;
	}
}
