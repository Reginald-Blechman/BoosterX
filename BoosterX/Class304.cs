using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using DevicesHelper;

// Token: 0x02000292 RID: 658
internal sealed class Class304
{
	// Token: 0x060011A7 RID: 4519 RVA: 0x00059940 File Offset: 0x00057B40
	private static void smethod_0()
	{
		try
		{
			if (Class304.hh_Lib_0 == null)
			{
				Class304.hh_Lib_0 = new HH_Lib();
			}
		}
		catch
		{
		}
		if (Class304.bool_0)
		{
			return;
		}
		if (!Directory.Exists(Class169.string_12))
		{
			Directory.CreateDirectory(Class169.string_12);
		}
		if (!Directory.Exists(Class169.string_13))
		{
			Directory.CreateDirectory(Class169.string_13);
		}
		Class304.string_0 = "\"" + Path.Combine(Class169.string_12, "pnputil.exe") + "\"";
		if (!File.Exists(Path.Combine(Class169.string_12, "pnputil.exe")))
		{
			Class765.smethod_4("BoosterX", Class169.string_12, "Resources.EmbedRes.Exes.Pnp", "pnputil.exe", false);
		}
		if (!File.Exists(Path.Combine(Class169.string_13, "pnputil.exe.mui")))
		{
			Class765.smethod_4("BoosterX", Class169.string_13, "Resources.EmbedRes.Exes.Pnp", "pnputil.exe.mui", false);
		}
		Class304.bool_0 = true;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x0000CD50 File Offset: 0x0000AF50
	public static List<GClass8> smethod_1()
	{
		return Class304.smethod_3("/enum-devices /disconnected");
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x0000CD5D File Offset: 0x0000AF5D
	public static List<GClass8> smethod_2()
	{
		return Class304.smethod_3("/enum-devices");
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00059A40 File Offset: 0x00057C40
	private static List<GClass8> smethod_3(string string_1)
	{
		List<GClass8> result;
		try
		{
			Class304.smethod_0();
			using (Process process = Process.Start(new ProcessStartInfo
			{
				UseShellExecute = false,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				Verb = "runas",
				RedirectStandardOutput = true,
				FileName = "cmd",
				Arguments = "/c chcp 437 & " + Class304.string_0 + " " + string_1
			}))
			{
				string text = process.StandardOutput.ReadToEnd();
				process.WaitForExit();
				result = Class304.smethod_5(Class304.smethod_4(text.Split(new string[]
				{
					"\r\n",
					"\r",
					"\n"
				}, StringSplitOptions.None)));
			}
		}
		catch
		{
			result = new List<GClass8>();
		}
		return result;
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00059B24 File Offset: 0x00057D24
	private static List<List<string>> smethod_4(string[] string_1)
	{
		List<List<string>> list = new List<List<string>>();
		List<string> list2 = null;
		bool flag = true;
		foreach (string text in string_1)
		{
			if (flag)
			{
				if (string.IsNullOrWhiteSpace(text))
				{
					flag = false;
				}
			}
			else if (string.IsNullOrWhiteSpace(text))
			{
				if (list2 != null)
				{
					list.Add(list2);
					list2 = null;
				}
			}
			else
			{
				if (list2 == null)
				{
					list2 = new List<string>();
				}
				list2.Add(text);
			}
		}
		if (list2 != null)
		{
			list.Add(list2);
		}
		return list;
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00059B98 File Offset: 0x00057D98
	private static List<GClass8> smethod_5(List<List<string>> list_0)
	{
		List<GClass8> list = new List<GClass8>();
		foreach (List<string> list2 in list_0)
		{
			GClass8 gclass = new GClass8();
			foreach (string text in list2)
			{
				int num = text.IndexOf(':');
				if (num > 0)
				{
					string string_ = text.Substring(0, num).Trim();
					string string_2 = text.Substring(num + 1).Trim();
					Class304.smethod_6(gclass, string_, string_2);
				}
			}
			gclass.method_15(Class607.smethod_0().method_4(gclass.method_0()));
			gclass.method_17(!Class607.smethod_0().method_5(gclass.method_0()));
			list.Add(gclass);
		}
		return list;
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00059C98 File Offset: 0x00057E98
	private static void smethod_6(GClass8 gclass8_0, string string_1, string string_2)
	{
		string_2 = (string_2 ?? string.Empty);
		if (string_1 != null)
		{
			switch (string_1.Length)
			{
			case 6:
				if (!(string_1 == "Status"))
				{
					return;
				}
				gclass8_0.Status = string_2;
				return;
			case 7:
			case 8:
			case 9:
			case 13:
			case 15:
			case 16:
				break;
			case 10:
			{
				char c = string_1[6];
				if (c != 'G')
				{
					if (c != 'N')
					{
						return;
					}
					if (!(string_1 == "Class Name"))
					{
						return;
					}
					gclass8_0.method_3(string_2);
					return;
				}
				else
				{
					if (!(string_1 == "Class GUID"))
					{
						return;
					}
					gclass8_0.method_5(string_2);
					return;
				}
				break;
			}
			case 11:
			{
				char c = string_1[0];
				if (c != 'D')
				{
					if (c != 'I')
					{
						return;
					}
					if (!(string_1 == "Instance ID"))
					{
						return;
					}
					gclass8_0.method_1(string_2);
					return;
				}
				else
				{
					if (!(string_1 == "Driver Name"))
					{
						return;
					}
					gclass8_0.method_9(string_2);
					return;
				}
				break;
			}
			case 12:
				if (!(string_1 == "Problem Code"))
				{
					return;
				}
				gclass8_0.method_11(string_2);
				return;
			case 14:
				if (!(string_1 == "Problem Status"))
				{
					return;
				}
				gclass8_0.method_13(string_2);
				break;
			case 17:
				if (!(string_1 == "Manufacturer Name"))
				{
					return;
				}
				gclass8_0.method_7(string_2);
				return;
			case 18:
				if (!(string_1 == "Device Description"))
				{
					return;
				}
				gclass8_0.Name = string_2;
				return;
			default:
				return;
			}
		}
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00059DF4 File Offset: 0x00057FF4
	public static void smethod_7(string string_1)
	{
		try
		{
			Class304.smethod_0();
			Class808.smethod_9(Class304.string_0, "/remove-device \"" + string_1 + "\"");
		}
		catch
		{
		}
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00059E38 File Offset: 0x00058038
	public static void smethod_8(string string_1)
	{
		Class304.Class306 @class = new Class304.Class306();
		@class.string_0 = string_1;
		Class304.smethod_0();
		try
		{
			if (!string.IsNullOrEmpty(@class.string_0))
			{
				Class808.smethod_9(Class304.string_0, "/disable-device \"" + @class.string_0 + "\"");
				HH_Lib hh_Lib = Class304.hh_Lib_0;
				DEVICE_INFO device_INFO = default(DEVICE_INFO);
				device_INFO.hardwareId = @class.string_0;
				hh_Lib.SetDeviceState(device_INFO, false);
				string text = GClass157.list_0.FirstOrDefault(new Func<string, bool>(@class.method_0)) ?? string.Empty;
				if (!string.IsNullOrEmpty(text))
				{
					Class808.smethod_9(Class304.string_0, "/disable-device \"" + text + "\"");
					HH_Lib hh_Lib2 = Class304.hh_Lib_0;
					device_INFO = default(DEVICE_INFO);
					device_INFO.hardwareId = text;
					hh_Lib2.SetDeviceState(device_INFO, false);
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00059F24 File Offset: 0x00058124
	public static void smethod_9(string string_1)
	{
		Class304.Class305 @class = new Class304.Class305();
		@class.string_0 = string_1;
		Class304.smethod_0();
		try
		{
			if (!string.IsNullOrEmpty(@class.string_0))
			{
				Class808.smethod_9(Class304.string_0, "/enable-device \"" + @class.string_0 + "\"");
				HH_Lib hh_Lib = Class304.hh_Lib_0;
				DEVICE_INFO device_INFO = default(DEVICE_INFO);
				device_INFO.hardwareId = @class.string_0;
				hh_Lib.SetDeviceState(device_INFO, true);
				string text = GClass157.list_0.FirstOrDefault(new Func<string, bool>(@class.method_0)) ?? string.Empty;
				if (!string.IsNullOrEmpty(text))
				{
					Class808.smethod_9(Class304.string_0, "/enable-device \"" + text + "\"");
					HH_Lib hh_Lib2 = Class304.hh_Lib_0;
					device_INFO = default(DEVICE_INFO);
					device_INFO.hardwareId = text;
					hh_Lib2.SetDeviceState(device_INFO, true);
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x04000AFD RID: 2813
	private static HH_Lib hh_Lib_0;

	// Token: 0x04000AFE RID: 2814
	private static string string_0 = string.Empty;

	// Token: 0x04000AFF RID: 2815
	private static bool bool_0 = false;

	// Token: 0x02000293 RID: 659
	private sealed class Class305
	{
		// Token: 0x060011B2 RID: 4530 RVA: 0x0000CD6A File Offset: 0x0000AF6A
		internal bool method_0(string string_1)
		{
			return !string.IsNullOrEmpty(string_1) && this.string_0.ToLower().StartsWith(string_1.ToLower());
		}

		// Token: 0x04000B00 RID: 2816
		public string string_0;
	}

	// Token: 0x02000294 RID: 660
	private sealed class Class306
	{
		// Token: 0x060011B4 RID: 4532 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		internal bool method_0(string string_1)
		{
			return !string.IsNullOrEmpty(string_1) && this.string_0.ToLower().StartsWith(string_1.ToLower());
		}

		// Token: 0x04000B01 RID: 2817
		public string string_0;
	}
}
