using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

// Token: 0x0200040F RID: 1039
internal sealed class Class466
{
	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00011E1B File Offset: 0x0001001B
	// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x00011E23 File Offset: 0x00010023
	[JsonProperty("Id")]
	internal Guid Guid_0
	{
		get
		{
			return this.guid_0;
		}
		set
		{
			this.guid_0 = value;
		}
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00011E2C File Offset: 0x0001002C
	// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x00011E34 File Offset: 0x00010034
	[JsonProperty("IsEditable")]
	internal bool Boolean_0
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

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x00011E3D File Offset: 0x0001003D
	// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x00011E45 File Offset: 0x00010045
	[JsonProperty("IsBlocked")]
	internal bool Boolean_1
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

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00011E4E File Offset: 0x0001004E
	// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x00011E56 File Offset: 0x00010056
	[JsonProperty("Name")]
	internal string String_0
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

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06001AAA RID: 6826 RVA: 0x00011E5F File Offset: 0x0001005F
	// (set) Token: 0x06001AAB RID: 6827 RVA: 0x00011E67 File Offset: 0x00010067
	[JsonProperty("Description")]
	internal string String_1
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

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00011E70 File Offset: 0x00010070
	// (set) Token: 0x06001AAD RID: 6829 RVA: 0x00011E78 File Offset: 0x00010078
	[JsonProperty("WillBrake")]
	internal List<string> List_0
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

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00011E81 File Offset: 0x00010081
	// (set) Token: 0x06001AAF RID: 6831 RVA: 0x00011E89 File Offset: 0x00010089
	[JsonProperty("Level")]
	internal int Int32_0
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

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00011E92 File Offset: 0x00010092
	// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00011E9A File Offset: 0x0001009A
	[JsonProperty("Group")]
	internal string String_2
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

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00011EA3 File Offset: 0x000100A3
	// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x00011EAB File Offset: 0x000100AB
	[JsonProperty("PowerSchemesForImport")]
	internal int Int32_1
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00011EB4 File Offset: 0x000100B4
	// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x00011EBC File Offset: 0x000100BC
	[JsonProperty("IconPath")]
	internal string String_3
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

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00011EC5 File Offset: 0x000100C5
	// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00011ECD File Offset: 0x000100CD
	[JsonProperty("RamInMB")]
	internal int Int32_2
	{
		get
		{
			return this.int_2;
		}
		set
		{
			this.int_2 = value;
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00011ED6 File Offset: 0x000100D6
	// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x00011EDE File Offset: 0x000100DE
	[JsonProperty("Arguments")]
	internal List<string> List_1
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

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00011EE7 File Offset: 0x000100E7
	// (set) Token: 0x06001ABB RID: 6843 RVA: 0x00011EEF File Offset: 0x000100EF
	[JsonProperty("NoSupport")]
	internal List<string> List_2
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

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00011EF8 File Offset: 0x000100F8
	// (set) Token: 0x06001ABD RID: 6845 RVA: 0x00011F00 File Offset: 0x00010100
	[JsonProperty("OffWith")]
	internal List<string> List_3
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

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00011F09 File Offset: 0x00010109
	// (set) Token: 0x06001ABF RID: 6847 RVA: 0x00011F11 File Offset: 0x00010111
	[JsonProperty("OnWith")]
	internal List<string> List_4
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

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x00011F1A File Offset: 0x0001011A
	// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x00011F22 File Offset: 0x00010122
	[JsonProperty("Type")]
	internal string String_4
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

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00011F2B File Offset: 0x0001012B
	// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x00011F33 File Offset: 0x00010133
	[JsonProperty("Tweaks")]
	internal List<Class245> List_5
	{
		get
		{
			return this.list_5;
		}
		set
		{
			this.list_5 = value;
		}
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x00011F3C File Offset: 0x0001013C
	internal bool method_0()
	{
		return this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_0));
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x00074878 File Offset: 0x00072A78
	internal bool method_1()
	{
		if (this.String_4 != "DOUBLE")
		{
			return true;
		}
		return this.List_5.All(new Func<Class245, bool>(Class466.Class467.class467_0.method_1));
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x000748C4 File Offset: 0x00072AC4
	internal bool method_2()
	{
		if (this.String_4 != "DOUBLE")
		{
			return true;
		}
		foreach (Class245 @class in this.List_5)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			foreach (Class275 class2 in @class.List_0)
			{
				if (class2.Boolean_2)
				{
					flag = true;
				}
				if (class2.Boolean_3)
				{
					flag2 = true;
				}
				if (class2.Boolean_4)
				{
					flag3 = true;
				}
				if (class2.Boolean_5)
				{
					flag4 = true;
				}
			}
			if (!flag || !flag2 || !flag3 || !flag4)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x000749A8 File Offset: 0x00072BA8
	internal bool method_3()
	{
		if (this.String_4 != "DOUBLE")
		{
			return true;
		}
		foreach (Class245 @class in this.List_5)
		{
			foreach (Class275 class2 in @class.List_0)
			{
				if (class2.Boolean_2 && class2.Boolean_3)
				{
					return false;
				}
				if (class2.Boolean_4 && class2.Boolean_5)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x00011F68 File Offset: 0x00010168
	internal bool method_4()
	{
		return this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_2));
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x00011F94 File Offset: 0x00010194
	internal bool method_5()
	{
		return this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_3));
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x00011FC0 File Offset: 0x000101C0
	internal bool method_6()
	{
		return this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_4));
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x00011FEC File Offset: 0x000101EC
	internal bool method_7()
	{
		return this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_5));
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x00012018 File Offset: 0x00010218
	internal bool method_8()
	{
		return this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_6));
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x00012044 File Offset: 0x00010244
	internal bool method_9()
	{
		return this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_7));
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x00074A70 File Offset: 0x00072C70
	internal string method_10(bool bool_2)
	{
		if (this.List_5.Any(new Func<Class245, bool>(Class466.Class467.class467_0.method_8)))
		{
			return Class673.smethod_5(this.List_5.First(new Func<Class245, bool>(Class466.Class467.class467_0.method_9)).String_1);
		}
		return Class673.smethod_2(this, bool_2);
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x00012070 File Offset: 0x00010270
	internal string method_11()
	{
		return Class673.smethod_3(this);
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x00012078 File Offset: 0x00010278
	internal string method_12(string string_5)
	{
		return Class673.smethod_4(this, string_5);
	}

	// Token: 0x040011DA RID: 4570
	private Guid guid_0;

	// Token: 0x040011DB RID: 4571
	private bool bool_0;

	// Token: 0x040011DC RID: 4572
	private bool bool_1;

	// Token: 0x040011DD RID: 4573
	private string string_0;

	// Token: 0x040011DE RID: 4574
	private string string_1;

	// Token: 0x040011DF RID: 4575
	private List<string> list_0 = new List<string>();

	// Token: 0x040011E0 RID: 4576
	private int int_0;

	// Token: 0x040011E1 RID: 4577
	private string string_2 = string.Empty;

	// Token: 0x040011E2 RID: 4578
	private int int_1;

	// Token: 0x040011E3 RID: 4579
	private string string_3;

	// Token: 0x040011E4 RID: 4580
	private int int_2;

	// Token: 0x040011E5 RID: 4581
	private List<string> list_1;

	// Token: 0x040011E6 RID: 4582
	private List<string> list_2 = new List<string>();

	// Token: 0x040011E7 RID: 4583
	private List<string> list_3;

	// Token: 0x040011E8 RID: 4584
	private List<string> list_4;

	// Token: 0x040011E9 RID: 4585
	private string string_4;

	// Token: 0x040011EA RID: 4586
	private List<Class245> list_5;

	// Token: 0x02000410 RID: 1040
	[Serializable]
	private sealed class Class467
	{
		// Token: 0x06001AD3 RID: 6867 RVA: 0x0001208D File Offset: 0x0001028D
		internal bool method_0(Class245 class245_0)
		{
			return class245_0.method_1();
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00012095 File Offset: 0x00010295
		internal bool method_1(Class245 class245_0)
		{
			return class245_0.List_0.Count<Class275>() == 2;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000120A5 File Offset: 0x000102A5
		internal bool method_2(Class245 class245_0)
		{
			return class245_0.method_2();
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000120AD File Offset: 0x000102AD
		internal bool method_3(Class245 class245_0)
		{
			return class245_0.method_5();
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000120B5 File Offset: 0x000102B5
		internal bool method_4(Class245 class245_0)
		{
			return class245_0.method_6();
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000120BD File Offset: 0x000102BD
		internal bool method_5(Class245 class245_0)
		{
			return class245_0.method_7();
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x000120C5 File Offset: 0x000102C5
		internal bool method_6(Class245 class245_0)
		{
			return class245_0.method_3();
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x000120CD File Offset: 0x000102CD
		internal bool method_7(Class245 class245_0)
		{
			return class245_0.method_4();
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x000120D5 File Offset: 0x000102D5
		internal bool method_8(Class245 class245_0)
		{
			return class245_0.String_0 == "CHECK";
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000120D5 File Offset: 0x000102D5
		internal bool method_9(Class245 class245_0)
		{
			return class245_0.String_0 == "CHECK";
		}

		// Token: 0x040011EB RID: 4587
		public static readonly Class466.Class467 class467_0 = new Class466.Class467();

		// Token: 0x040011EC RID: 4588
		public static Func<Class245, bool> func_0;

		// Token: 0x040011ED RID: 4589
		public static Func<Class245, bool> func_1;

		// Token: 0x040011EE RID: 4590
		public static Func<Class245, bool> func_2;

		// Token: 0x040011EF RID: 4591
		public static Func<Class245, bool> func_3;

		// Token: 0x040011F0 RID: 4592
		public static Func<Class245, bool> func_4;

		// Token: 0x040011F1 RID: 4593
		public static Func<Class245, bool> func_5;

		// Token: 0x040011F2 RID: 4594
		public static Func<Class245, bool> func_6;

		// Token: 0x040011F3 RID: 4595
		public static Func<Class245, bool> func_7;

		// Token: 0x040011F4 RID: 4596
		public static Func<Class245, bool> func_8;

		// Token: 0x040011F5 RID: 4597
		public static Func<Class245, bool> func_9;
	}
}
