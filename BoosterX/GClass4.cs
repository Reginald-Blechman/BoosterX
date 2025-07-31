using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Runtime.CompilerServices;

// Token: 0x0200010E RID: 270
public static class GClass4
{
	// Token: 0x060007C2 RID: 1986 RVA: 0x0004017C File Offset: 0x0003E37C
	public static List<GClass4.GClass5> smethod_0()
	{
		GClass4.Class165 @class = new GClass4.Class165();
		if (Class243.smethod_6())
		{
			return new List<GClass4.GClass5>();
		}
		if (Class673.smethod_24("AppXSvc") == "BEST")
		{
			return new List<GClass4.GClass5>();
		}
		@class.list_0 = GClass4.smethod_1();
		Collection<PSObject> collection = GClass132.smethod_0().method_0("Get-AppxPackage -ErrorAction SilentlyContinue");
		if (collection != null && collection.Count != 0)
		{
			return collection.Where(new Func<PSObject, bool>(GClass4.Class167.class167_0.method_0)).Select(new Func<PSObject, GClass4.GClass5>(@class.method_0)).ToList<GClass4.GClass5>();
		}
		return new List<GClass4.GClass5>();
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00006D04 File Offset: 0x00004F04
	public static List<GClass4.GClass6> smethod_1()
	{
		return GClass132.smethod_0().method_0("[Windows.Management.Deployment.PackageManager,Windows.Web,ContentType=WindowsRuntime]::new().FindPackages() | Select-Object DisplayName -ExpandProperty Id").ToList<PSObject>().Select(new Func<PSObject, GClass4.GClass6>(GClass4.Class167.class167_0.method_1)).ToList<GClass4.GClass6>();
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00040224 File Offset: 0x0003E424
	public static void smethod_2(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = string_0,
				WindowStyle = ProcessWindowStyle.Hidden
			});
		}
		catch
		{
		}
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0004026C File Offset: 0x0003E46C
	public static void smethod_3(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = string_0,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Hidden
			}).WaitForExit();
		}
		catch
		{
		}
	}

	// Token: 0x0200010F RID: 271
	private sealed class Class165
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x000402C4 File Offset: 0x0003E4C4
		internal GClass4.GClass5 method_0(PSObject psobject_0)
		{
			GClass4.Class166 @class = new GClass4.Class166();
			GClass4.Class166 class2 = @class;
			GClass4.GClass5 gclass = new GClass4.GClass5();
			PSPropertyInfo pspropertyInfo = psobject_0.Properties["Name"];
			string name;
			if (pspropertyInfo == null)
			{
				name = null;
			}
			else
			{
				object value = pspropertyInfo.Value;
				name = ((value != null) ? value.ToString() : null);
			}
			gclass.Name = name;
			PSPropertyInfo pspropertyInfo2 = psobject_0.Properties["Publisher"];
			string string_;
			if (pspropertyInfo2 == null)
			{
				string_ = null;
			}
			else
			{
				object value2 = pspropertyInfo2.Value;
				string_ = ((value2 != null) ? value2.ToString() : null);
			}
			gclass.method_1(string_);
			PSPropertyInfo pspropertyInfo3 = psobject_0.Properties["Architecture"];
			string string_2;
			if (pspropertyInfo3 == null)
			{
				string_2 = null;
			}
			else
			{
				object value3 = pspropertyInfo3.Value;
				string_2 = ((value3 != null) ? value3.ToString() : null);
			}
			gclass.method_3(string_2);
			PSPropertyInfo pspropertyInfo4 = psobject_0.Properties["Version"];
			string string_3;
			if (pspropertyInfo4 == null)
			{
				string_3 = null;
			}
			else
			{
				object value4 = pspropertyInfo4.Value;
				string_3 = ((value4 != null) ? value4.ToString() : null);
			}
			gclass.method_7(string_3);
			PSPropertyInfo pspropertyInfo5 = psobject_0.Properties["PackageFullName"];
			string string_4;
			if (pspropertyInfo5 == null)
			{
				string_4 = null;
			}
			else
			{
				object value5 = pspropertyInfo5.Value;
				string_4 = ((value5 != null) ? value5.ToString() : null);
			}
			gclass.method_9(string_4);
			PSPropertyInfo pspropertyInfo6 = psobject_0.Properties["IsFramework"];
			string a;
			if (pspropertyInfo6 == null)
			{
				a = null;
			}
			else
			{
				object value6 = pspropertyInfo6.Value;
				a = ((value6 != null) ? value6.ToString().ToLower() : null);
			}
			gclass.method_13(a == "true");
			PSPropertyInfo pspropertyInfo7 = psobject_0.Properties["PackageFamilyName"];
			string string_5;
			if (pspropertyInfo7 == null)
			{
				string_5 = null;
			}
			else
			{
				object value7 = pspropertyInfo7.Value;
				string_5 = ((value7 != null) ? value7.ToString() : null);
			}
			gclass.method_15(string_5);
			PSPropertyInfo pspropertyInfo8 = psobject_0.Properties["PublisherId"];
			string string_6;
			if (pspropertyInfo8 == null)
			{
				string_6 = null;
			}
			else
			{
				object value8 = pspropertyInfo8.Value;
				string_6 = ((value8 != null) ? value8.ToString() : null);
			}
			gclass.method_17(string_6);
			PSPropertyInfo pspropertyInfo9 = psobject_0.Properties["IsResourcePackage"];
			string a2;
			if (pspropertyInfo9 == null)
			{
				a2 = null;
			}
			else
			{
				object value9 = pspropertyInfo9.Value;
				a2 = ((value9 != null) ? value9.ToString().ToLower() : null);
			}
			gclass.method_19(a2 == "true");
			PSPropertyInfo pspropertyInfo10 = psobject_0.Properties["IsBundle"];
			string a3;
			if (pspropertyInfo10 == null)
			{
				a3 = null;
			}
			else
			{
				object value10 = pspropertyInfo10.Value;
				a3 = ((value10 != null) ? value10.ToString().ToLower() : null);
			}
			gclass.method_21(a3 == "true");
			PSPropertyInfo pspropertyInfo11 = psobject_0.Properties["IsDevelopmentMode"];
			string a4;
			if (pspropertyInfo11 == null)
			{
				a4 = null;
			}
			else
			{
				object value11 = pspropertyInfo11.Value;
				a4 = ((value11 != null) ? value11.ToString().ToLower() : null);
			}
			gclass.method_23(a4 == "true");
			PSPropertyInfo pspropertyInfo12 = psobject_0.Properties["NonRemovable"];
			string a5;
			if (pspropertyInfo12 == null)
			{
				a5 = null;
			}
			else
			{
				object value12 = pspropertyInfo12.Value;
				a5 = ((value12 != null) ? value12.ToString().ToLower() : null);
			}
			gclass.method_25(a5 == "true");
			PSPropertyInfo pspropertyInfo13 = psobject_0.Properties["IsPartiallyStaged"];
			string a6;
			if (pspropertyInfo13 == null)
			{
				a6 = null;
			}
			else
			{
				object value13 = pspropertyInfo13.Value;
				a6 = ((value13 != null) ? value13.ToString().ToLower() : null);
			}
			gclass.method_27(a6 == "true");
			PSPropertyInfo pspropertyInfo14 = psobject_0.Properties["SignatureKind"];
			string string_7;
			if (pspropertyInfo14 == null)
			{
				string_7 = null;
			}
			else
			{
				object value14 = pspropertyInfo14.Value;
				string_7 = ((value14 != null) ? value14.ToString() : null);
			}
			gclass.method_29(string_7);
			PSPropertyInfo pspropertyInfo15 = psobject_0.Properties["Status"];
			string status;
			if (pspropertyInfo15 == null)
			{
				status = null;
			}
			else
			{
				object value15 = pspropertyInfo15.Value;
				status = ((value15 != null) ? value15.ToString() : null);
			}
			gclass.Status = status;
			class2.gclass5_0 = gclass;
			try
			{
				GClass4.GClass5 gclass5_ = @class.gclass5_0;
				PSPropertyInfo pspropertyInfo16 = psobject_0.Properties["InstallLocation"];
				string string_8;
				if (pspropertyInfo16 == null)
				{
					string_8 = null;
				}
				else
				{
					object value16 = pspropertyInfo16.Value;
					string_8 = ((value16 != null) ? value16.ToString() : null);
				}
				gclass5_.method_11(string_8);
			}
			catch
			{
				@class.gclass5_0.method_11(null);
			}
			GClass4.GClass6 gclass2 = this.list_0.FirstOrDefault(new Func<GClass4.GClass6, bool>(@class.method_0));
			@class.gclass5_0.DisplayName = ((gclass2 != null) ? (gclass2.DisplayName ?? @class.gclass5_0.Name) : @class.gclass5_0.Name);
			return @class.gclass5_0;
		}

		// Token: 0x0400045E RID: 1118
		public List<GClass4.GClass6> list_0;
	}

	// Token: 0x02000110 RID: 272
	private sealed class Class166
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x00006D44 File Offset: 0x00004F44
		internal bool method_0(GClass4.GClass6 gclass6_0)
		{
			return gclass6_0.FullName == this.gclass5_0.method_8();
		}

		// Token: 0x0400045F RID: 1119
		public GClass4.GClass5 gclass5_0;
	}

	// Token: 0x02000111 RID: 273
	public sealed class GClass5
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00006D5C File Offset: 0x00004F5C
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00006D64 File Offset: 0x00004F64
		public string Name
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

		// Token: 0x060007CD RID: 1997 RVA: 0x00006D6D File Offset: 0x00004F6D
		public string method_0()
		{
			return this.string_1;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00006D75 File Offset: 0x00004F75
		public void method_1(string string_12)
		{
			this.string_1 = string_12;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00006D7E File Offset: 0x00004F7E
		public string method_2()
		{
			return this.string_2;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00006D86 File Offset: 0x00004F86
		public void method_3(string string_12)
		{
			this.string_2 = string_12;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00006D8F File Offset: 0x00004F8F
		public string method_4()
		{
			return this.string_3;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00006D97 File Offset: 0x00004F97
		public void method_5(string string_12)
		{
			this.string_3 = string_12;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00006DA0 File Offset: 0x00004FA0
		public string method_6()
		{
			return this.string_4;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00006DA8 File Offset: 0x00004FA8
		public void method_7(string string_12)
		{
			this.string_4 = string_12;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00006DB1 File Offset: 0x00004FB1
		public string method_8()
		{
			return this.string_5;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00006DB9 File Offset: 0x00004FB9
		public void method_9(string string_12)
		{
			this.string_5 = string_12;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00006DC2 File Offset: 0x00004FC2
		public string method_10()
		{
			return this.string_6;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00006DCA File Offset: 0x00004FCA
		public void method_11(string string_12)
		{
			this.string_6 = string_12;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00006DD3 File Offset: 0x00004FD3
		public bool method_12()
		{
			return this.bool_0;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00006DDB File Offset: 0x00004FDB
		public void method_13(bool bool_6)
		{
			this.bool_0 = bool_6;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00006DE4 File Offset: 0x00004FE4
		public string method_14()
		{
			return this.string_7;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00006DEC File Offset: 0x00004FEC
		public void method_15(string string_12)
		{
			this.string_7 = string_12;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00006DF5 File Offset: 0x00004FF5
		public string method_16()
		{
			return this.string_8;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00006DFD File Offset: 0x00004FFD
		public void method_17(string string_12)
		{
			this.string_8 = string_12;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00006E06 File Offset: 0x00005006
		public bool method_18()
		{
			return this.bool_1;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00006E0E File Offset: 0x0000500E
		public void method_19(bool bool_6)
		{
			this.bool_1 = bool_6;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00006E17 File Offset: 0x00005017
		public bool method_20()
		{
			return this.bool_2;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00006E1F File Offset: 0x0000501F
		public void method_21(bool bool_6)
		{
			this.bool_2 = bool_6;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00006E28 File Offset: 0x00005028
		public bool method_22()
		{
			return this.bool_3;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00006E30 File Offset: 0x00005030
		public void method_23(bool bool_6)
		{
			this.bool_3 = bool_6;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00006E39 File Offset: 0x00005039
		public bool method_24()
		{
			return this.bool_4;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00006E41 File Offset: 0x00005041
		public void method_25(bool bool_6)
		{
			this.bool_4 = bool_6;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00006E4A File Offset: 0x0000504A
		public bool method_26()
		{
			return this.bool_5;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00006E52 File Offset: 0x00005052
		public void method_27(bool bool_6)
		{
			this.bool_5 = bool_6;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00006E5B File Offset: 0x0000505B
		public string method_28()
		{
			return this.string_9;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00006E63 File Offset: 0x00005063
		public void method_29(string string_12)
		{
			this.string_9 = string_12;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00006E6C File Offset: 0x0000506C
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00006E74 File Offset: 0x00005074
		public string Status
		{
			[CompilerGenerated]
			get
			{
				return this.string_10;
			}
			[CompilerGenerated]
			set
			{
				this.string_10 = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00006E7D File Offset: 0x0000507D
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00006E85 File Offset: 0x00005085
		public string DisplayName
		{
			[CompilerGenerated]
			get
			{
				return this.string_11;
			}
			[CompilerGenerated]
			set
			{
				this.string_11 = value;
			}
		}

		// Token: 0x04000460 RID: 1120
		private string string_0;

		// Token: 0x04000461 RID: 1121
		private string string_1;

		// Token: 0x04000462 RID: 1122
		private string string_2;

		// Token: 0x04000463 RID: 1123
		private string string_3;

		// Token: 0x04000464 RID: 1124
		private string string_4;

		// Token: 0x04000465 RID: 1125
		private string string_5;

		// Token: 0x04000466 RID: 1126
		private string string_6;

		// Token: 0x04000467 RID: 1127
		private bool bool_0;

		// Token: 0x04000468 RID: 1128
		private string string_7;

		// Token: 0x04000469 RID: 1129
		private string string_8;

		// Token: 0x0400046A RID: 1130
		private bool bool_1;

		// Token: 0x0400046B RID: 1131
		private bool bool_2;

		// Token: 0x0400046C RID: 1132
		private bool bool_3;

		// Token: 0x0400046D RID: 1133
		private bool bool_4;

		// Token: 0x0400046E RID: 1134
		private bool bool_5;

		// Token: 0x0400046F RID: 1135
		private string string_9;

		// Token: 0x04000470 RID: 1136
		private string string_10;

		// Token: 0x04000471 RID: 1137
		private string string_11;
	}

	// Token: 0x02000112 RID: 274
	public sealed class GClass6
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00006E8E File Offset: 0x0000508E
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00006E96 File Offset: 0x00005096
		public string FullName
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00006E9F File Offset: 0x0000509F
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00006EA7 File Offset: 0x000050A7
		public string DisplayName
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

		// Token: 0x04000472 RID: 1138
		private string string_0;

		// Token: 0x04000473 RID: 1139
		private string string_1;
	}

	// Token: 0x02000113 RID: 275
	[Serializable]
	private sealed class Class167
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x00006EBC File Offset: 0x000050BC
		internal bool method_0(PSObject psobject_0)
		{
			PSPropertyInfo pspropertyInfo = psobject_0.Properties["SignatureKind"];
			string a;
			if (pspropertyInfo == null)
			{
				a = null;
			}
			else
			{
				object value = pspropertyInfo.Value;
				a = ((value != null) ? value.ToString().ToLower() : null);
			}
			return a != "system";
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000406A8 File Offset: 0x0003E8A8
		internal GClass4.GClass6 method_1(PSObject psobject_0)
		{
			GClass4.GClass6 result;
			try
			{
				GClass4.GClass6 gclass = new GClass4.GClass6();
				PSPropertyInfo pspropertyInfo = psobject_0.Properties["DisplayName"];
				gclass.DisplayName = ((pspropertyInfo != null) ? pspropertyInfo.Value.ToString() : null);
				PSPropertyInfo pspropertyInfo2 = psobject_0.Properties["FullName"];
				gclass.FullName = ((pspropertyInfo2 != null) ? pspropertyInfo2.Value.ToString() : null);
				result = gclass;
			}
			catch
			{
				GClass4.GClass6 gclass2 = new GClass4.GClass6();
				gclass2.DisplayName = null;
				PSPropertyInfo pspropertyInfo3 = psobject_0.Properties["FullName"];
				gclass2.FullName = ((pspropertyInfo3 != null) ? pspropertyInfo3.Value.ToString() : null);
				result = gclass2;
			}
			return result;
		}

		// Token: 0x04000474 RID: 1140
		public static readonly GClass4.Class167 class167_0 = new GClass4.Class167();

		// Token: 0x04000475 RID: 1141
		public static Func<PSObject, bool> func_0;

		// Token: 0x04000476 RID: 1142
		public static Func<PSObject, GClass4.GClass6> func_1;
	}
}
