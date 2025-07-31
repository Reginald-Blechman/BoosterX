using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using ns0;
using PIManagerX;

// Token: 0x0200051C RID: 1308
public static class GClass227
{
	// Token: 0x060020FB RID: 8443 RVA: 0x00015BF9 File Offset: 0x00013DF9
	public static Task<List<GClass293>> smethod_0()
	{
		return Task.Run<List<GClass293>>(new Func<List<GClass293>>(GClass227.Class625.class625_0.method_0));
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x00084810 File Offset: 0x00082A10
	private static List<GClass293> smethod_1()
	{
		List<GClass293> list = new List<GClass293>();
		IntPtr intPtr = NetAdapManager.SetupDiGetClassDevs(ref GClass227.guid_0, IntPtr.Zero, IntPtr.Zero, 10U);
		if (!(intPtr == IntPtr.Zero) && !(intPtr == (IntPtr)(-1)))
		{
			try
			{
				NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA = default(NetAdapManager.SP_DEVINFO_DATA);
				sp_DEVINFO_DATA.cbSize = (uint)Marshal.SizeOf(typeof(NetAdapManager.SP_DEVINFO_DATA));
				NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA2 = sp_DEVINFO_DATA;
				uint num = 0U;
				while (NetAdapManager.SetupDiEnumDeviceInfo(intPtr, num, ref sp_DEVINFO_DATA2))
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					int num2;
					if (NetAdapManager.SetupDiGetDeviceInstanceId(intPtr, ref sp_DEVINFO_DATA2, stringBuilder, stringBuilder.Capacity, ref num2))
					{
						string text = stringBuilder.ToString();
						string text2;
						if ((text2 = GClass227.smethod_2(intPtr, ref sp_DEVINFO_DATA2, 12U)) == null)
						{
							text2 = (GClass227.smethod_2(intPtr, ref sp_DEVINFO_DATA2, 0U) ?? text);
						}
						string name = text2;
						string text3 = GClass227.smethod_2(intPtr, ref sp_DEVINFO_DATA2, 9U);
						string text4 = GClass227.smethod_7(text);
						string string_ = GClass227.smethod_8(text4);
						GClass293 gclass = new GClass293();
						gclass.method_1(text);
						gclass.method_3(text4);
						gclass.Name = name;
						gclass.method_7(string_);
						gclass.IsEnabled = false;
						gclass.method_5("SYSTEM\\CurrentControlSet\\Control\\Class\\" + text3);
						gclass.method_9(new List<GClass86>());
						GClass293 gclass2 = gclass;
						if (!string.IsNullOrEmpty(text3))
						{
							string string_2 = "SYSTEM\\CurrentControlSet\\Control\\Class\\" + text3;
							gclass2.method_9(GClass227.smethod_4(string_2));
						}
						list.Add(gclass2);
					}
					num += 1U;
				}
			}
			finally
			{
				NetAdapManager.SetupDiDestroyDeviceInfoList(intPtr);
			}
			try
			{
				Dictionary<string, bool> dictionary = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT PNPDeviceID, NetEnabled FROM Win32_NetworkAdapter WHERE PNPDeviceID IS NOT NULL");
				try
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						object obj = managementObject["PNPDeviceID"];
						if (obj == null)
						{
							goto IL_1B8;
						}
						string text5;
						if ((text5 = obj.ToString()) == null)
						{
							goto IL_1B8;
						}
						IL_1BE:
						string text6 = text5;
						bool valueOrDefault = ((bool?)managementObject["NetEnabled"]).GetValueOrDefault();
						if (!string.IsNullOrEmpty(text6))
						{
							dictionary[text6] = valueOrDefault;
							continue;
						}
						continue;
						IL_1B8:
						text5 = string.Empty;
						goto IL_1BE;
					}
					foreach (GClass293 gclass3 in list)
					{
						bool flag;
						gclass3.IsEnabled = (dictionary.TryGetValue(gclass3.method_0(), out flag) && flag);
					}
				}
				finally
				{
					((IDisposable)managementObjectSearcher).Dispose();
				}
			}
			catch
			{
			}
			GClass227.smethod_5(list.Where(new Func<GClass293, bool>(GClass227.Class625.class625_0.method_2)));
			return list;
		}
		return list;
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x00084B20 File Offset: 0x00082D20
	private static string smethod_2(IntPtr intptr_0, ref NetAdapManager.SP_DEVINFO_DATA sp_DEVINFO_DATA_0, uint uint_0)
	{
		byte[] array = new byte[1024];
		uint num;
		uint num2;
		if (NetAdapManager.SetupDiGetDeviceRegistryProperty(intptr_0, ref sp_DEVINFO_DATA_0, uint_0, ref num, array, (uint)array.Length, ref num2))
		{
			return Encoding.Unicode.GetString(array).TrimEnd(new char[1]);
		}
		return null;
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x00084B64 File Offset: 0x00082D64
	private static List<GClass293> smethod_3()
	{
		List<GClass293> list = new List<GClass293>();
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT PNPDeviceID, Name, NetEnabled FROM Win32_NetworkAdapter WHERE PhysicalAdapter = True");
		List<GClass293> result;
		try
		{
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				List<GClass293> list2 = list;
				GClass293 gclass = new GClass293();
				object obj = managementObject["PNPDeviceID"];
				if (obj == null)
				{
					goto IL_52;
				}
				string string_;
				if ((string_ = obj.ToString()) == null)
				{
					goto IL_52;
				}
				IL_58:
				gclass.method_1(string_);
				object obj2 = managementObject["Name"];
				if (obj2 == null)
				{
					goto IL_79;
				}
				string name;
				if ((name = obj2.ToString()) == null)
				{
					goto IL_79;
				}
				IL_7F:
				gclass.Name = name;
				gclass.IsEnabled = ((bool?)managementObject["NetEnabled"]).GetValueOrDefault();
				gclass.method_5(string.Empty);
				gclass.method_9(new List<GClass86>());
				list2.Add(gclass);
				continue;
				IL_79:
				name = string.Empty;
				goto IL_7F;
				IL_52:
				string_ = string.Empty;
				goto IL_58;
			}
			GClass227.smethod_5(list);
			result = list;
		}
		finally
		{
			((IDisposable)managementObjectSearcher).Dispose();
		}
		return result;
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x00084C78 File Offset: 0x00082E78
	private static List<GClass86> smethod_4(string string_0)
	{
		List<GClass86> list = new List<GClass86>();
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0, false))
			{
				using (RegistryKey registryKey2 = (registryKey != null) ? registryKey.OpenSubKey("Ndi\\params") : null)
				{
					if (registryKey2 == null)
					{
						return list;
					}
					foreach (string text in registryKey2.GetSubKeyNames())
					{
						GClass227.Struct345 @struct;
						@struct.registryKey_0 = registryKey2.OpenSubKey(text);
						try
						{
							if (@struct.registryKey_0 != null)
							{
								string displayName = (@struct.registryKey_0.GetValue("ParamDesc") as string) ?? text;
								string text2;
								if (registryKey != null)
								{
									object value = registryKey.GetValue(text);
									if (value != null)
									{
										if ((text2 = value.ToString()) != null)
										{
											goto IL_AD;
										}
									}
								}
								text2 = string.Empty;
								IL_AD:
								string text3 = text2;
								object value2 = @struct.registryKey_0.GetValue("Default");
								string text4;
								if (value2 != null)
								{
									if ((text4 = value2.ToString()) != null)
									{
										goto IL_D4;
									}
								}
								text4 = string.Empty;
								IL_D4:
								string text5 = text4;
								Dictionary<string, string> dictionary = new Dictionary<string, string>();
								string text6 = text3;
								string string_ = text5;
								using (RegistryKey registryKey3 = @struct.registryKey_0.OpenSubKey("Enum"))
								{
									if (registryKey3 != null)
									{
										foreach (string text7 in registryKey3.GetValueNames())
										{
											string value3 = (registryKey3.GetValue(text7) as string) ?? text7;
											dictionary[text7] = value3;
										}
										dictionary.TryGetValue(text3, out text6);
										dictionary.TryGetValue(text5, out string_);
									}
									bool bool_;
									if (!(bool_ = !string.IsNullOrEmpty(text5)))
									{
										text5 = text3;
										string_ = text6;
									}
									string a = ((@struct.registryKey_0.GetValue("type") as string) ?? "enum").ToLowerInvariant();
									dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd;
									if (!(a == "edit"))
									{
										if (!(a == "enum"))
										{
											dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd = dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Int;
										}
										else
										{
											dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd = dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Enum;
										}
									}
									else
									{
										dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd = dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Edit;
									}
									dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd type = dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd;
									long? nullable_ = GClass227.smethod_10("Min", ref @struct);
									long? nullable_2 = GClass227.smethod_10("Max", ref @struct);
									long? nullable_3 = GClass227.smethod_10("Step", ref @struct);
									long? nullable_4 = GClass227.smethod_10("LimitText", ref @struct);
									List<GClass86> list2 = list;
									GClass86 gclass = new GClass86();
									gclass.Key = text;
									gclass.DisplayName = displayName;
									gclass.method_2(text3);
									gclass.method_4(text6 ?? text3);
									gclass.method_8(text5);
									gclass.method_10(string_);
									gclass.method_12(bool_);
									gclass.method_6(dictionary);
									gclass.Type = type;
									gclass.method_20(nullable_4);
									gclass.method_14(nullable_);
									gclass.method_16(nullable_2);
									gclass.method_18(nullable_3);
									list2.Add(gclass);
								}
							}
						}
						finally
						{
							if (@struct.registryKey_0 != null)
							{
								((IDisposable)@struct.registryKey_0).Dispose();
							}
						}
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x00084FC8 File Offset: 0x000831C8
	private static void smethod_5(IEnumerable<GClass293> ienumerable_0)
	{
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root/StandardCimv2", "SELECT InstanceID, RegistryKeyword, RegistryValue, DisplayName, DefaultRegistryValue, DefaultDisplayValue FROM MSFT_NetAdapterAdvancedPropertySettingData");
			try
			{
				Dictionary<string, List<GClass86>> dictionary = new Dictionary<string, List<GClass86>>(StringComparer.OrdinalIgnoreCase);
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object obj = managementObject["InstanceID"];
					if (obj == null)
					{
						goto IL_59;
					}
					string text;
					if ((text = obj.ToString()) == null)
					{
						goto IL_59;
					}
					IL_5F:
					string text2 = text;
					object obj2 = managementObject["RegistryKeyword"];
					if (obj2 == null)
					{
						goto IL_7C;
					}
					string text3;
					if ((text3 = obj2.ToString()) == null)
					{
						goto IL_7C;
					}
					IL_82:
					string text4 = text3;
					if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text4))
					{
						object obj3 = managementObject["DisplayName"];
						if (obj3 == null)
						{
							goto IL_B7;
						}
						string text5;
						if ((text5 = obj3.ToString()) == null)
						{
							goto IL_B7;
						}
						IL_BA:
						string displayName = text5;
						object obj4 = managementObject["RegistryValue"];
						if (obj4 == null)
						{
							goto IL_D7;
						}
						string text6;
						if ((text6 = obj4.ToString()) == null)
						{
							goto IL_D7;
						}
						IL_DD:
						string text7 = text6;
						object obj5 = managementObject["DefaultRegistryValue"];
						if (obj5 == null)
						{
							goto IL_FA;
						}
						string text8;
						if ((text8 = obj5.ToString()) == null)
						{
							goto IL_FA;
						}
						IL_100:
						string text9 = text8;
						object obj6 = managementObject["DefaultDisplayValue"];
						if (obj6 == null)
						{
							goto IL_11C;
						}
						string text10;
						if ((text10 = obj6.ToString()) == null)
						{
							goto IL_11C;
						}
						IL_11E:
						string string_ = text10;
						string text11 = text7;
						bool bool_;
						if (!(bool_ = !string.IsNullOrEmpty(text9)))
						{
							text9 = text7;
							string_ = text11;
						}
						List<GClass86> list;
						if (!dictionary.TryGetValue(text2, out list))
						{
							list = (dictionary[text2] = new List<GClass86>());
						}
						List<GClass86> list2 = list;
						GClass86 gclass = new GClass86();
						gclass.Key = text4;
						gclass.DisplayName = displayName;
						gclass.method_2(text7);
						gclass.method_4(text11);
						gclass.method_8(text9);
						gclass.method_10(string_);
						gclass.method_12(bool_);
						gclass.method_6(new Dictionary<string, string>());
						list2.Add(gclass);
						continue;
						IL_11C:
						text10 = text9;
						goto IL_11E;
						IL_FA:
						text8 = string.Empty;
						goto IL_100;
						IL_D7:
						text6 = string.Empty;
						goto IL_DD;
						IL_B7:
						text5 = text4;
						goto IL_BA;
					}
					continue;
					IL_7C:
					text3 = string.Empty;
					goto IL_82;
					IL_59:
					text = string.Empty;
					goto IL_5F;
				}
				foreach (GClass293 gclass2 in ienumerable_0)
				{
					List<GClass86> list3;
					if (dictionary.TryGetValue(gclass2.method_0(), out list3) && list3.Count > 0)
					{
						gclass2.method_9(list3);
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x00085250 File Offset: 0x00083450
	public static string smethod_6(string string_0)
	{
		string result;
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\" + string_0 + "\\Connection"))
			{
				result = (registryKey.GetValue("PnpInstanceID") as string);
			}
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000852C0 File Offset: 0x000834C0
	public static string smethod_7(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return string.Empty;
		}
		string empty;
		using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}"))
		{
			if (registryKey == null)
			{
				empty = string.Empty;
			}
			else
			{
				foreach (string text in registryKey.GetSubKeyNames())
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(text + "\\Connection"))
					{
						string text2 = ((registryKey2 != null) ? registryKey2.GetValue("PnpInstanceID") : null) as string;
						if (!string.IsNullOrEmpty(text2) && text2.Equals(string_0, StringComparison.OrdinalIgnoreCase))
						{
							return text;
						}
					}
				}
				empty = string.Empty;
			}
		}
		return empty;
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x00085398 File Offset: 0x00083598
	public static string smethod_8(string string_0)
	{
		GClass227.Class624 @class = new GClass227.Class624();
		@class.string_0 = string_0;
		string result;
		try
		{
			NetworkInterface networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(new Func<NetworkInterface, bool>(@class.method_0));
			if (networkInterface == null)
			{
				result = "HelpNetworkOutline";
			}
			else if (GClass227.smethod_9(networkInterface))
			{
				result = "LanConnect";
			}
			else
			{
				NetworkInterfaceType networkInterfaceType = networkInterface.NetworkInterfaceType;
				if (networkInterfaceType <= NetworkInterfaceType.Loopback)
				{
					if (networkInterfaceType == NetworkInterfaceType.Ethernet)
					{
						goto IL_124;
					}
					if (networkInterfaceType == NetworkInterfaceType.Ppp)
					{
						return "Vpn";
					}
					if (networkInterfaceType == NetworkInterfaceType.Loopback)
					{
						return "Sync";
					}
				}
				else
				{
					if (networkInterfaceType == NetworkInterfaceType.Wireless80211)
					{
						return "Wifi";
					}
					if (networkInterfaceType == NetworkInterfaceType.GigabitEthernet)
					{
						goto IL_124;
					}
					if (networkInterfaceType == NetworkInterfaceType.Tunnel)
					{
						return "Vpn";
					}
				}
				string text = (networkInterface.Description ?? string.Empty).ToLowerInvariant();
				if (text.Contains("wifi") || text.Contains("wireless"))
				{
					return "Wifi";
				}
				if (text.Contains("tap") || text.Contains("vpn"))
				{
					return "Vpn";
				}
				if (text.Contains("virtual"))
				{
					return "LanConnect";
				}
				return "other";
				IL_124:
				result = "Ethernet";
			}
		}
		catch
		{
			result = "other";
		}
		return result;
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x00085504 File Offset: 0x00083704
	private static bool smethod_9(NetworkInterface networkInterface_0)
	{
		NetworkInterfaceType networkInterfaceType = networkInterface_0.NetworkInterfaceType;
		bool flag;
		if (networkInterfaceType != NetworkInterfaceType.Loopback)
		{
			if (networkInterfaceType != NetworkInterfaceType.Tunnel)
			{
				flag = false;
				goto IL_1C;
			}
		}
		flag = true;
		IL_1C:
		if (flag)
		{
			return true;
		}
		string @object = (networkInterface_0.Description ?? string.Empty).ToLowerInvariant();
		return new string[]
		{
			"virtual",
			"vmware",
			"hyper-v",
			"vbox",
			"tap",
			"host-only",
			"npcap"
		}.Any(new Func<string, bool>(@object.Contains));
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000855A0 File Offset: 0x000837A0
	internal static long? smethod_10(string string_0, ref GClass227.Struct345 struct345_0)
	{
		object value = struct345_0.registryKey_0.GetValue(string_0);
		if (value is int)
		{
			int num = (int)value;
			return new long?((long)num);
		}
		if (value is long)
		{
			long value2 = (long)value;
			return new long?(value2);
		}
		long value3;
		if (!long.TryParse((value != null) ? value.ToString() : null, out value3))
		{
			return null;
		}
		return new long?(value3);
	}

	// Token: 0x040015F3 RID: 5619
	private static Guid guid_0 = new Guid("4d36e972-e325-11ce-bfc1-08002be10318");

	// Token: 0x0200051D RID: 1309
	private sealed class Class624
	{
		// Token: 0x06002107 RID: 8455 RVA: 0x00015C1F File Offset: 0x00013E1F
		internal bool method_0(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.Id.Equals(this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x040015F4 RID: 5620
		public string string_0;
	}

	// Token: 0x0200051E RID: 1310
	[StructLayout(LayoutKind.Auto)]
	private struct Struct345
	{
		// Token: 0x040015F5 RID: 5621
		public RegistryKey registryKey_0;
	}

	// Token: 0x0200051F RID: 1311
	[Serializable]
	private sealed class Class625
	{
		// Token: 0x0600210A RID: 8458 RVA: 0x00085610 File Offset: 0x00083810
		internal List<GClass293> method_0()
		{
			List<GClass293> list;
			try
			{
				list = GClass227.smethod_1();
				if (list.Count == 0)
				{
					list = GClass227.smethod_3();
				}
			}
			catch
			{
				list = GClass227.smethod_3();
			}
			return list.Where(new Func<GClass293, bool>(GClass227.Class625.class625_0.method_1)).ToList<GClass293>();
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00015C3F File Offset: 0x00013E3F
		internal bool method_1(GClass293 gclass293_0)
		{
			return gclass293_0.method_8().Count > 0;
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00015C4F File Offset: 0x00013E4F
		internal bool method_2(GClass293 gclass293_0)
		{
			return gclass293_0.method_8().Count == 0;
		}

		// Token: 0x040015F6 RID: 5622
		public static readonly GClass227.Class625 class625_0 = new GClass227.Class625();

		// Token: 0x040015F7 RID: 5623
		public static Func<GClass293, bool> func_0;

		// Token: 0x040015F8 RID: 5624
		public static Func<List<GClass293>> func_1;

		// Token: 0x040015F9 RID: 5625
		public static Func<GClass293, bool> func_2;
	}
}
