using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using Microsoft.Win32;
using ns0;

// Token: 0x020000CE RID: 206
internal sealed class Class797 : GClass283
{
	// Token: 0x0600061A RID: 1562 RVA: 0x00005D85 File Offset: 0x00003F85
	public Class797(Class525 class525_1)
	{
		this.class525_0 = class525_1;
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x0003ACBC File Offset: 0x00038EBC
	protected override void vmethod_0(object object_0)
	{
		using (PowerShell powerShell = PowerShell.Create())
		{
			Class797.Class136 @class = new Class797.Class136();
			@class.string_0 = this.class525_0.AppxFullName.Split(new char[]
			{
				'_'
			}).First<string>();
			base.imethod_1(Class298.smethod_2("Deleting") + " " + @class.string_0, (GEnum15)0);
			powerShell.AddScript("Get-AppxPackage -Name \"*" + @class.string_0 + "*\" | Remove-AppxPackage");
			powerShell.Invoke();
			if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_1)
			{
				Class797.Class137 class2 = new Class797.Class137();
				class2.registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppModel\\PackageRepository\\Packages", true);
				class2.registryKey_0.GetSubKeyNames().ToList<string>().Where(new Func<string, bool>(@class.method_0)).ToList<string>().ForEach(new Action<string>(class2.method_0));
				class2.registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\UserData\\UninstallTimes", true);
				class2.registryKey_0.GetValueNames().ToList<string>().Where(new Func<string, bool>(@class.method_1)).ToList<string>().ForEach(new Action<string>(class2.method_1));
			}
		}
		if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_1)
		{
			Class797.Class135 class3 = new Class797.Class135();
			class3.string_1 = Class169.string_4 + "\\UninstallBat2.bat";
			class3.string_0 = this.class525_0.AppxLocation.Split(new char[]
			{
				'\\'
			}).Last<string>();
			Directory.GetDirectories(this.class525_0.AppxLocation.Replace(class3.string_0, string.Empty)).Where(new Func<string, bool>(class3.method_0)).ToList<string>().ForEach(new Action<string>(class3.method_1));
		}
	}

	// Token: 0x04000346 RID: 838
	private Class525 class525_0;

	// Token: 0x020000CF RID: 207
	private sealed class Class135
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x00005D94 File Offset: 0x00003F94
		internal bool method_0(string string_2)
		{
			return string_2.Contains(this.string_0.Split(new char[]
			{
				'_'
			}).First<string>());
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00005DB7 File Offset: 0x00003FB7
		internal void method_1(string string_2)
		{
			Class765.smethod_17(this.string_1, "rmdir /s /q \"" + string_2 + "\"", null);
		}

		// Token: 0x04000347 RID: 839
		public string string_0;

		// Token: 0x04000348 RID: 840
		public string string_1;
	}

	// Token: 0x020000D0 RID: 208
	private sealed class Class136
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00005DD7 File Offset: 0x00003FD7
		internal bool method_0(string string_1)
		{
			return string_1.StartsWith(this.string_0);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00005DD7 File Offset: 0x00003FD7
		internal bool method_1(string string_1)
		{
			return string_1.StartsWith(this.string_0);
		}

		// Token: 0x04000349 RID: 841
		public string string_0;
	}

	// Token: 0x020000D1 RID: 209
	private sealed class Class137
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00005DE5 File Offset: 0x00003FE5
		internal void method_0(string string_0)
		{
			this.registryKey_0.DeleteSubKeyTree(string_0);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00005DF3 File Offset: 0x00003FF3
		internal void method_1(string string_0)
		{
			this.registryKey_0.DeleteValue(string_0);
		}

		// Token: 0x0400034A RID: 842
		public RegistryKey registryKey_0;
	}
}
