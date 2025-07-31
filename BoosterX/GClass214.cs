using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

// Token: 0x0200048C RID: 1164
public static class GClass214
{
	// Token: 0x06001E33 RID: 7731 RVA: 0x00013EDF File Offset: 0x000120DF
	public static bool smethod_0()
	{
		return GClass214.smethod_5() != null;
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x00013EE9 File Offset: 0x000120E9
	public static bool smethod_1()
	{
		return GClass214.smethod_2().Any(new Func<GClass214.GClass215, bool>(GClass214.Class553.class553_0.method_0));
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x0007C17C File Offset: 0x0007A37C
	public static List<GClass214.GClass215> smethod_2()
	{
		if (!GClass214.smethod_9())
		{
			return new List<GClass214.GClass215>();
		}
		List<string> list = GClass214.string_0.Split(new char[]
		{
			'\n'
		}, StringSplitOptions.RemoveEmptyEntries).Select(new Func<string, string>(GClass214.Class553.class553_0.method_1)).Where(new Func<string, bool>(GClass214.Class553.class553_0.method_2)).ToList<string>();
		List<GClass214.GClass215> list2 = new List<GClass214.GClass215>();
		foreach (string text in list)
		{
			string[] array = text.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			List<GClass214.GClass215> list3 = list2;
			GClass214.GClass215 gclass = new GClass214.GClass215();
			gclass.method_1(array[0]);
			gclass.method_3((array.Length > 1) ? array[1] : "0");
			gclass.method_5((array.Length > 2) ? array[2] : "0");
			gclass.method_7(array[0].StartsWith("?:\\", StringComparison.OrdinalIgnoreCase) || array.Length == 1);
			list3.Add(gclass);
		}
		return list2;
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x0007C2B4 File Offset: 0x0007A4B4
	public static List<string> smethod_3()
	{
		if (!GClass214.smethod_10())
		{
			return new List<string>();
		}
		return GClass214.string_1.Split(new char[]
		{
			'\n'
		}, StringSplitOptions.RemoveEmptyEntries).Select(new Func<string, string>(GClass214.Class553.class553_0.method_3)).Where(new Func<string, bool>(GClass214.Class553.class553_0.method_4)).Select(new Func<string, string>(GClass214.Class553.class553_0.method_5)).Distinct(StringComparer.OrdinalIgnoreCase).ToList<string>();
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x0007C360 File Offset: 0x0007A560
	public static List<GClass214.GClass215> smethod_4()
	{
		List<GClass214.GClass215> list = GClass214.smethod_2();
		List<string> list2 = GClass214.smethod_3();
		if (list.Any(new Func<GClass214.GClass215, bool>(GClass214.Class553.class553_0.method_6)) && Class746.smethod_3<string>(list2))
		{
			return list2.Select(new Func<string, GClass214.GClass215>(GClass214.Class553.class553_0.method_7)).ToList<GClass214.GClass215>();
		}
		foreach (GClass214.GClass215 gclass in list)
		{
			gclass.method_9(File.Exists(gclass.method_0()));
		}
		return list;
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x00013F14 File Offset: 0x00012114
	public static GClass214.GClass215 smethod_5()
	{
		return GClass214.smethod_4().FirstOrDefault(new Func<GClass214.GClass215, bool>(GClass214.Class553.class553_0.method_8));
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x0007C420 File Offset: 0x0007A620
	public static List<GClass214.GClass216> smethod_6()
	{
		List<GClass214.GClass216> list = new List<GClass214.GClass216>();
		foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
		{
			if (driveInfo.IsReady)
			{
				List<GClass214.GClass216> list2 = list;
				GClass214.GClass216 gclass = new GClass214.GClass216();
				gclass.Name = driveInfo.Name.TrimEnd(new char[]
				{
					'\\'
				});
				gclass.Path = driveInfo.Name;
				gclass.method_1(driveInfo.AvailableFreeSpace);
				gclass.method_3(driveInfo.TotalSize);
				gclass.method_5(driveInfo.IsReady);
				list2.Add(gclass);
			}
		}
		return list;
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x00013F3F File Offset: 0x0001213F
	public static List<string> smethod_7()
	{
		return GClass214.smethod_3();
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x0007C4B0 File Offset: 0x0007A6B0
	public static GClass214.GClass215 smethod_8()
	{
		IEnumerable<GClass214.GClass215> source = GClass214.smethod_2();
		GClass214.GClass215 gclass = GClass214.smethod_5();
		if (source.Any(new Func<GClass214.GClass215, bool>(GClass214.Class553.class553_0.method_9)))
		{
			GClass214.GClass215 gclass2 = new GClass214.GClass215();
			gclass2.method_1("?:\\pagefile.sys");
			gclass2.method_3("0");
			gclass2.method_5("0");
			gclass2.method_7(true);
			gclass2.method_9(gclass != null);
			return gclass2;
		}
		return gclass ?? null;
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x0007C530 File Offset: 0x0007A730
	private static bool smethod_9()
	{
		bool result;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management");
			string text;
			if (registryKey == null)
			{
				text = null;
			}
			else
			{
				object value = registryKey.GetValue("PagingFiles");
				text = ((value != null) ? value.ToString() : null);
			}
			GClass214.string_0 = text;
			result = !string.IsNullOrEmpty(GClass214.string_0);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x0007C598 File Offset: 0x0007A798
	private static bool smethod_10()
	{
		bool result;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management");
			string text;
			if (registryKey == null)
			{
				text = null;
			}
			else
			{
				object value = registryKey.GetValue("ExistingPageFiles");
				text = ((value != null) ? value.ToString() : null);
			}
			GClass214.string_1 = text;
			result = !string.IsNullOrEmpty(GClass214.string_1);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x0007C600 File Offset: 0x0007A800
	public static void smethod_11(string[] string_2)
	{
		string text = "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management";
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text, true))
		{
			if (registryKey == null)
			{
				throw new InvalidOperationException("Не удалось открыть реестр по пути " + text);
			}
			registryKey.SetValue("PagingFiles", string_2, RegistryValueKind.MultiString);
		}
	}

	// Token: 0x0400140E RID: 5134
	private static string string_0;

	// Token: 0x0400140F RID: 5135
	private static string string_1;

	// Token: 0x0200048D RID: 1165
	public sealed class GClass215
	{
		// Token: 0x06001E40 RID: 7744 RVA: 0x00013F46 File Offset: 0x00012146
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00013F4E File Offset: 0x0001214E
		public void method_1(string string_3)
		{
			this.string_0 = string_3;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00013F57 File Offset: 0x00012157
		public string method_2()
		{
			return this.string_1;
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00013F5F File Offset: 0x0001215F
		public void method_3(string string_3)
		{
			this.string_1 = string_3;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00013F68 File Offset: 0x00012168
		public string method_4()
		{
			return this.string_2;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00013F70 File Offset: 0x00012170
		public void method_5(string string_3)
		{
			this.string_2 = string_3;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00013F79 File Offset: 0x00012179
		public bool method_6()
		{
			return this.bool_0;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00013F81 File Offset: 0x00012181
		public void method_7(bool bool_2)
		{
			this.bool_0 = bool_2;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00013F8A File Offset: 0x0001218A
		public bool method_8()
		{
			return this.bool_1;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00013F92 File Offset: 0x00012192
		public void method_9(bool bool_2)
		{
			this.bool_1 = bool_2;
		}

		// Token: 0x04001410 RID: 5136
		private string string_0;

		// Token: 0x04001411 RID: 5137
		private string string_1;

		// Token: 0x04001412 RID: 5138
		private string string_2;

		// Token: 0x04001413 RID: 5139
		private bool bool_0;

		// Token: 0x04001414 RID: 5140
		private bool bool_1;
	}

	// Token: 0x0200048E RID: 1166
	public sealed class GClass216
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00013F9B File Offset: 0x0001219B
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x00013FA3 File Offset: 0x000121A3
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00013FAC File Offset: 0x000121AC
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x00013FB4 File Offset: 0x000121B4
		public string Path
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

		// Token: 0x06001E4F RID: 7759 RVA: 0x00013FBD File Offset: 0x000121BD
		public long method_0()
		{
			return this.long_0;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00013FC5 File Offset: 0x000121C5
		public void method_1(long long_2)
		{
			this.long_0 = long_2;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00013FCE File Offset: 0x000121CE
		public long method_2()
		{
			return this.long_1;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00013FD6 File Offset: 0x000121D6
		public void method_3(long long_2)
		{
			this.long_1 = long_2;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00013FDF File Offset: 0x000121DF
		public bool method_4()
		{
			return this.bool_0;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00013FE7 File Offset: 0x000121E7
		public void method_5(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x04001415 RID: 5141
		private string string_0;

		// Token: 0x04001416 RID: 5142
		private string string_1;

		// Token: 0x04001417 RID: 5143
		private long long_0;

		// Token: 0x04001418 RID: 5144
		private long long_1;

		// Token: 0x04001419 RID: 5145
		private bool bool_0;
	}

	// Token: 0x0200048F RID: 1167
	[Serializable]
	private sealed class Class553
	{
		// Token: 0x06001E57 RID: 7767 RVA: 0x00013FFC File Offset: 0x000121FC
		internal bool method_0(GClass214.GClass215 gclass215_0)
		{
			return gclass215_0.method_6();
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0000C563 File Offset: 0x0000A763
		internal string method_1(string string_0)
		{
			return string_0.Trim();
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00014004 File Offset: 0x00012204
		internal bool method_2(string string_0)
		{
			return !string.IsNullOrWhiteSpace(string_0);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0000C563 File Offset: 0x0000A763
		internal string method_3(string string_0)
		{
			return string_0.Trim();
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00014004 File Offset: 0x00012204
		internal bool method_4(string string_0)
		{
			return !string.IsNullOrWhiteSpace(string_0);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0001400F File Offset: 0x0001220F
		internal string method_5(string string_0)
		{
			if (string_0.StartsWith("\\??\\", StringComparison.OrdinalIgnoreCase))
			{
				string_0 = string_0.Substring(4);
			}
			return string_0.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries)[0];
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00013FFC File Offset: 0x000121FC
		internal bool method_6(GClass214.GClass215 gclass215_0)
		{
			return gclass215_0.method_6();
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0001403F File Offset: 0x0001223F
		internal GClass214.GClass215 method_7(string string_0)
		{
			GClass214.GClass215 gclass = new GClass214.GClass215();
			gclass.method_1(string_0);
			gclass.method_3("0");
			gclass.method_5("0");
			gclass.method_7(true);
			gclass.method_9(File.Exists(string_0));
			return gclass;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00014078 File Offset: 0x00012278
		internal bool method_8(GClass214.GClass215 gclass215_0)
		{
			return gclass215_0.method_8();
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00013FFC File Offset: 0x000121FC
		internal bool method_9(GClass214.GClass215 gclass215_0)
		{
			return gclass215_0.method_6();
		}

		// Token: 0x0400141A RID: 5146
		public static readonly GClass214.Class553 class553_0 = new GClass214.Class553();

		// Token: 0x0400141B RID: 5147
		public static Func<GClass214.GClass215, bool> func_0;

		// Token: 0x0400141C RID: 5148
		public static Func<string, string> func_1;

		// Token: 0x0400141D RID: 5149
		public static Func<string, bool> func_2;

		// Token: 0x0400141E RID: 5150
		public static Func<string, string> func_3;

		// Token: 0x0400141F RID: 5151
		public static Func<string, bool> func_4;

		// Token: 0x04001420 RID: 5152
		public static Func<string, string> func_5;

		// Token: 0x04001421 RID: 5153
		public static Func<GClass214.GClass215, bool> func_6;

		// Token: 0x04001422 RID: 5154
		public static Func<string, GClass214.GClass215> func_7;

		// Token: 0x04001423 RID: 5155
		public static Func<GClass214.GClass215, bool> func_8;

		// Token: 0x04001424 RID: 5156
		public static Func<GClass214.GClass215, bool> func_9;
	}
}
