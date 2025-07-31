using System;
using System.Collections.Generic;
using System.Linq;
using DevicesHelper;
using Microsoft.Win32;

// Token: 0x020004F6 RID: 1270
internal sealed class Class607
{
	// Token: 0x0600202E RID: 8238 RVA: 0x000154F2 File Offset: 0x000136F2
	private Class607()
	{
		if (Class607.hh_Lib_0 == null)
		{
			Class607.hh_Lib_0 = new HH_Lib();
		}
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x0001550B File Offset: 0x0001370B
	public static Class607 smethod_0()
	{
		Class607 result;
		if ((result = Class607.class607_0) == null)
		{
			result = (Class607.class607_0 = new Class607());
		}
		return result;
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000829C8 File Offset: 0x00080BC8
	public List<GClass8> method_0()
	{
		List<GClass8> list = new List<GClass8>();
		foreach (DEVICE_INFO device_INFO in Class607.hh_Lib_0.GetAll())
		{
			List<GClass8> list2 = list;
			GClass8 gclass = new GClass8();
			gclass.method_1(device_INFO.id);
			gclass.Name = (device_INFO.friendlyName.smethod_9() ? device_INFO.name : device_INFO.friendlyName);
			gclass.method_3(device_INFO.className);
			gclass.method_5(device_INFO.classGuid);
			gclass.method_7(device_INFO.manufacturer);
			gclass.Status = device_INFO.statusstr;
			gclass.method_9(device_INFO.driverName);
			gclass.method_11(device_INFO.errorCode);
			gclass.method_15(this.method_4(device_INFO.id));
			gclass.method_17(!this.method_5(device_INFO.id));
			list2.Add(gclass);
		}
		return list;
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x00082AD0 File Offset: 0x00080CD0
	public void method_1(string string_0, bool bool_0)
	{
		DEVICE_INFO device_INFO = default(DEVICE_INFO);
		device_INFO.hardwareId = string_0;
		DEVICE_INFO device_INFO2 = device_INFO;
		Class607.hh_Lib_0.SetDeviceState(device_INFO2, bool_0);
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x00082AFC File Offset: 0x00080CFC
	public bool method_2(string string_0)
	{
		Class607.Class608 @class = new Class607.Class608();
		@class.string_0 = string_0;
		bool result;
		try
		{
			result = (Class607.hh_Lib_0.GetAll().First(new Func<DEVICE_INFO, bool>(@class.method_0)).status == 1);
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x00015521 File Offset: 0x00013721
	public List<DEVICE_INFO> method_3()
	{
		return Class607.hh_Lib_0.GetAll();
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x00082B54 File Offset: 0x00080D54
	public bool method_4(string string_0)
	{
		bool result;
		try
		{
			string name = "SYSTEM\\CurrentControlSet\\Enum\\" + string_0 + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties";
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name))
			{
				if (registryKey == null)
				{
					result = false;
				}
				else
				{
					object value = registryKey.GetValue("MSISupported");
					result = (value != null && !string.IsNullOrEmpty(value.ToString()));
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x00082BD8 File Offset: 0x00080DD8
	public bool method_5(string string_0)
	{
		bool result;
		try
		{
			string name = "SYSTEM\\CurrentControlSet\\Enum\\" + string_0 + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties";
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name))
			{
				if (registryKey == null)
				{
					result = false;
				}
				else
				{
					object value = registryKey.GetValue("MSISupported");
					result = (value != null && value.ToString() == "1");
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0400156C RID: 5484
	private static Class607 class607_0;

	// Token: 0x0400156D RID: 5485
	private static HH_Lib hh_Lib_0;

	// Token: 0x020004F7 RID: 1271
	private sealed class Class608
	{
		// Token: 0x06002037 RID: 8247 RVA: 0x0001552D File Offset: 0x0001372D
		internal bool method_0(DEVICE_INFO device_INFO_0)
		{
			return device_INFO_0.id.ToLower() == this.string_0.ToLower();
		}

		// Token: 0x0400156E RID: 5486
		public string string_0;
	}
}
