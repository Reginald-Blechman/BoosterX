using System;
using System.Management;

// Token: 0x02000541 RID: 1345
internal sealed class Class643
{
	// Token: 0x060021F6 RID: 8694 RVA: 0x000883AC File Offset: 0x000865AC
	public static bool smethod_0()
	{
		bool result = false;
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					object obj = ((ManagementObject)managementBaseObject)["Name"];
					if (obj == null)
					{
						goto IL_4E;
					}
					string text = obj.ToString();
					if (text == null)
					{
						goto IL_4E;
					}
					string text2;
					if ((text2 = text.ToLowerInvariant()) == null)
					{
						goto IL_4E;
					}
					IL_54:
					if (!text2.Contains("nvidia"))
					{
						continue;
					}
					result = true;
					break;
					IL_4E:
					text2 = string.Empty;
					goto IL_54;
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch (ManagementException exception_)
		{
			GClass268.smethod_1(exception_);
		}
		return result;
	}
}
