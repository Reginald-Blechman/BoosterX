using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;

// Token: 0x0200027A RID: 634
internal sealed class Class802 : GClass283
{
	// Token: 0x060010F4 RID: 4340 RVA: 0x00058D2C File Offset: 0x00056F2C
	protected override void vmethod_0(object object_0)
	{
		Class802.Class295 @class = new Class802.Class295();
		string text = object_0 as string;
		if (text != null && text == "RegistryClean")
		{
			foreach (string text2 in Class169.string_15)
			{
				try
				{
					using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text2, true))
					{
						if (registryKey != null)
						{
							foreach (string text3 in registryKey.GetValueNames())
							{
								Class808.smethod_27(string.Concat(new string[]
								{
									"reg delete \"HKCU\\",
									text2,
									"\" /v \"",
									text3,
									"\" /f"
								}));
							}
						}
					}
				}
				catch
				{
				}
			}
			foreach (string text4 in Class169.string_16)
			{
				try
				{
					using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(text4, true))
					{
						if (registryKey2 != null)
						{
							foreach (string text5 in registryKey2.GetValueNames())
							{
								Class808.smethod_27(string.Concat(new string[]
								{
									"reg delete \"HKLM\\",
									text4,
									"\" /v \"",
									text5,
									"\" /f"
								}));
							}
						}
					}
				}
				catch
				{
				}
			}
			return;
		}
		@class.class527_0 = (object_0 as Class527);
		if (@class.class527_0 != null)
		{
			base.imethod_1(Class298.smethod_2("Deleting") + " " + @class.class527_0.Name, (GEnum15)0);
			try
			{
				foreach (string str in Directory.GetDirectories("C:\\Program Files\\WindowsApps").Where(new Func<string, bool>(@class.method_0)).ToList<string>())
				{
					Class765.smethod_17(this.string_1, "rmdir /s /q \"" + str + "\"", null);
				}
			}
			catch
			{
			}
			return;
		}
		Class528 class2 = object_0 as Class528;
		if (class2 != null)
		{
			base.imethod_1(Class298.smethod_2("Deleting") + " " + class2.Name, (GEnum15)0);
			try
			{
				Class304.smethod_7(class2.Id);
			}
			catch
			{
			}
			return;
		}
		Class757 class3 = object_0 as Class757;
		if (class3 != null)
		{
			foreach (string name in class3.List_0)
			{
				Class802.Class294 class4 = new Class802.Class294();
				class4.string_0 = Environment.ExpandEnvironmentVariables(name).Replace("%username%", Environment.UserName);
				IEnumerable<string> enumerable2;
				if (!class4.string_0.StartsWith("?:\\"))
				{
					IEnumerable<string> enumerable = new string[]
					{
						class4.string_0
					};
					enumerable2 = enumerable;
				}
				else
				{
					enumerable2 = DriveInfo.GetDrives().Select(new Func<DriveInfo, string>(class4.method_0));
				}
				IEnumerable<string> enumerable3 = enumerable2;
				string[] array2 = class3.String_3.Split(new char[]
				{
					'|'
				}).Select(new Func<string, string>(Class802.Class296.class296_0.method_0)).ToArray<string>();
				foreach (string text6 in enumerable3)
				{
					foreach (string path in array2)
					{
						Class765.smethod_17(this.string_1, "del /s /f /q \"" + Path.Combine(text6, path) + "\"", null);
					}
					if (class3.Boolean_1 && Directory.Exists(text6))
					{
						foreach (string path2 in Directory.EnumerateDirectories(text6))
						{
							foreach (string path3 in array2)
							{
								Class765.smethod_17(this.string_1, "del /s /f /q \"" + Path.Combine(path2, path3) + "\"", null);
							}
						}
					}
				}
			}
			return;
		}
	}

	// Token: 0x04000AA8 RID: 2728
	private readonly string string_1 = Class169.string_4 + "\\UninstallBat.bat";

	// Token: 0x0200027B RID: 635
	private sealed class Class294
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x0000C51F File Offset: 0x0000A71F
		internal string method_0(DriveInfo driveInfo_0)
		{
			return this.string_0.Replace("?:\\", driveInfo_0.Name);
		}

		// Token: 0x04000AA9 RID: 2729
		public string string_0;
	}

	// Token: 0x0200027C RID: 636
	private sealed class Class295
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x0000C538 File Offset: 0x0000A738
		internal bool method_0(string string_0)
		{
			string fileName = Path.GetFileName(string_0);
			return fileName != null && fileName.StartsWith(this.class527_0.Name, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000AAA RID: 2730
		public Class527 class527_0;
	}

	// Token: 0x0200027D RID: 637
	[Serializable]
	private sealed class Class296
	{
		// Token: 0x060010FB RID: 4347 RVA: 0x0000C563 File Offset: 0x0000A763
		internal string method_0(string string_0)
		{
			return string_0.Trim();
		}

		// Token: 0x04000AAB RID: 2731
		public static readonly Class802.Class296 class296_0 = new Class802.Class296();

		// Token: 0x04000AAC RID: 2732
		public static Func<string, string> func_0;
	}
}
