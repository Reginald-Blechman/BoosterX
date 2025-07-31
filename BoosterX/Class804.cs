using System;
using System.IO;
using Microsoft.Win32;
using ns0;

// Token: 0x020003B7 RID: 951
internal sealed class Class804 : GClass283
{
	// Token: 0x06001905 RID: 6405 RVA: 0x00010EDB File Offset: 0x0000F0DB
	public Class804(Class490 class490_1)
	{
		this.class490_0 = class490_1;
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x0006ED2C File Offset: 0x0006CF2C
	protected override void vmethod_0(object object_0)
	{
		string a = (string)object_0;
		if (a == "Disable")
		{
			base.imethod_1(Class298.smethod_2("Disabling") + " " + this.class490_0.Name, (GEnum15)0);
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Registry)
			{
				Class808.smethod_27(string.Concat(new string[]
				{
					"reg add \"",
					this.class490_0.ARPath,
					"\\AutorunsDisabled\" /v \"",
					this.class490_0.Name,
					"\" /t REG_SZ /d \"",
					this.class490_0.Runs,
					"\" /f"
				}));
				Class808.smethod_27(string.Concat(new string[]
				{
					"reg delete \"",
					this.class490_0.ARPath,
					"\" /v \"",
					this.class490_0.Name,
					"\" /f"
				}));
				return;
			}
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.File)
			{
				string text = this.class490_0.ARPath + "\\AutorunsDisabled\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				new DirectoryInfo(text).Attributes |= FileAttributes.Hidden;
				File.Move(this.class490_0.ARPath + "\\" + this.class490_0.Name, text + this.class490_0.Name);
				return;
			}
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Service)
			{
				Class808.smethod_27(string.Format("reg add \"{0}\" /v \"AutorunsDisabled\" /t REG_DWORD /d \"{1}\" /f", this.class490_0.ARPath, Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + this.class490_0.Name).GetValue("Start")));
				Class808.smethod_27("reg add \"" + this.class490_0.ARPath + "\" /v \"Start\" /t REG_DWORD /d \"4\" /f");
				Class808.smethod_27("sc stop \"" + this.class490_0.Name + "\"");
				return;
			}
			if (this.class490_0.ARPath.StartsWith("\\"))
			{
				Class808.smethod_27("schtasks /Change /TN \"" + this.class490_0.ARPath + "\" /Disable");
				return;
			}
			Class808.smethod_27("schtasks /Change /TN \"\\" + this.class490_0.ARPath + "\" /Disable");
			return;
		}
		else if (a == "Enable")
		{
			base.imethod_1(Class298.smethod_2("Enabling") + " " + this.class490_0.Name, (GEnum15)0);
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Registry)
			{
				string text2 = this.class490_0.ARPath.Remove(this.class490_0.ARPath.Length - 17);
				Class808.smethod_27(string.Concat(new string[]
				{
					"reg add \"",
					text2,
					"\" /v \"",
					this.class490_0.Name,
					"\" /t REG_SZ /d \"",
					this.class490_0.Runs,
					"\" /f"
				}));
				Class808.smethod_27(string.Concat(new string[]
				{
					"reg delete \"",
					this.class490_0.ARPath,
					"\" /v \"",
					this.class490_0.Name,
					"\" /f"
				}));
				return;
			}
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.File)
			{
				File.Move(this.class490_0.ARPath + "\\" + this.class490_0.Name, this.class490_0.ARPath.Replace("\\AutorunsDisabled", string.Empty) + "\\" + this.class490_0.Name);
				return;
			}
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Service)
			{
				try
				{
					Class808.smethod_27(string.Format("reg add \"{0}\" /v \"Start\" /t REG_DWORD /d \"{1}\" /f", this.class490_0.ARPath, Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + this.class490_0.Name).GetValue("AutorunsDisabled")));
				}
				catch
				{
					Class808.smethod_27("reg add \"" + this.class490_0.ARPath + "\" /v \"Start\" /t REG_SZ /d \"2\" /f");
				}
				Class808.smethod_27("reg delete \"" + this.class490_0.ARPath + "\" /v \"AutorunsDisabled\" /f");
				return;
			}
			if (this.class490_0.ARPath.StartsWith("\\"))
			{
				Class808.smethod_27("schtasks /Change /TN \"" + this.class490_0.ARPath + "\" /Enable");
				return;
			}
			Class808.smethod_27("schtasks /Change /TN \"\\" + this.class490_0.ARPath + "\" /Enable");
			return;
		}
		else
		{
			base.imethod_1(Class298.smethod_2("Deleting") + " " + this.class490_0.Name, (GEnum15)0);
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Registry)
			{
				Class808.smethod_27(string.Concat(new string[]
				{
					"reg delete \"",
					this.class490_0.ARPath,
					"\" /v \"",
					this.class490_0.Name,
					"\" /f"
				}));
				return;
			}
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.File)
			{
				Class808.smethod_27(string.Concat(new string[]
				{
					"del /f \"",
					this.class490_0.ARPath,
					"\\",
					this.class490_0.Name,
					"\""
				}));
				return;
			}
			if (this.class490_0.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Service)
			{
				Class808.smethod_27("net stop " + this.class490_0.Name + " & sc delete " + this.class490_0.Name);
				return;
			}
			if (this.class490_0.ARPath.StartsWith("\\"))
			{
				Class808.smethod_27("schtasks /Delete /TN \"" + this.class490_0.ARPath + "\" /F");
				return;
			}
			Class808.smethod_27("schtasks /Delete /TN \"\\" + this.class490_0.ARPath + "\" /F");
			return;
		}
	}

	// Token: 0x0400107E RID: 4222
	private Class490 class490_0;
}
