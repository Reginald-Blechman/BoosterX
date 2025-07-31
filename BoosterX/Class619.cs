using System;
using System.Management;
using System.Management.Automation;

// Token: 0x0200050D RID: 1293
internal sealed class Class619
{
	// Token: 0x060020C2 RID: 8386 RVA: 0x00083640 File Offset: 0x00081840
	public static bool smethod_0()
	{
		using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMv2\\Security\\MicrosoftVolumeEncryption", "SELECT * FROM Win32_EncryptableVolume").Get().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((ManagementObject)enumerator.Current)["ConversionStatus"].ToString().smethod_3("1"))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x000836C0 File Offset: 0x000818C0
	public static void smethod_1()
	{
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("Get-BitLockerVolume | Where-Object { $_.VolumeType -eq 'OperatingSystem' -and $_.ProtectionStatus -eq 'On' } | Disable-BitLocker -MountPoint $_.MountPoint -RebootCount 0");
			try
			{
				powerShell.Invoke();
			}
			catch (Exception exception_)
			{
				GClass268.smethod_1(exception_);
			}
			powerShell.Dispose();
		}
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x00083720 File Offset: 0x00081920
	public static void smethod_2()
	{
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("Get-BitLockerVolume | Where-Object { $_.VolumeType -eq 'OperatingSystem' -and $_.ProtectionStatus -eq 'Off' } | Enable-BitLocker -MountPoint $_.MountPoint -RebootCount 0");
			try
			{
				powerShell.Invoke();
			}
			catch (Exception exception_)
			{
				GClass268.smethod_1(exception_);
			}
			powerShell.Dispose();
		}
	}
}
