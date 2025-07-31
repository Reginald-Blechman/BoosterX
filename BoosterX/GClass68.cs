using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x02000252 RID: 594
public sealed class GClass68
{
	// Token: 0x04000A2F RID: 2607
	public static GClass68.GClass69 gclass69_0 = new GClass68.GClass69();

	// Token: 0x02000253 RID: 595
	public sealed class GClass69
	{
		// Token: 0x0600100F RID: 4111 RVA: 0x00056E7C File Offset: 0x0005507C
		public bool method_0(string string_0, out MaterialIconKind materialIconKind_0)
		{
			foreach (GClass68.GClass70 gclass in this.list_0)
			{
				if (gclass.Name.Equals(string_0))
				{
					materialIconKind_0 = gclass.Icon;
					return true;
				}
			}
			materialIconKind_0 = 0;
			return false;
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00056EEC File Offset: 0x000550EC
		internal bool method_1(string string_0, out SolidColorBrush solidColorBrush_0)
		{
			foreach (GClass68.GClass70 gclass in this.list_0)
			{
				if (gclass.Name.Equals(string_0))
				{
					solidColorBrush_0 = gclass.Color;
					return true;
				}
			}
			solidColorBrush_0 = null;
			return false;
		}

		// Token: 0x04000A30 RID: 2608
		private List<GClass68.GClass70> list_0 = new List<GClass68.GClass70>
		{
			new GClass68.GClass70("WBAllJoyn (virtual network for smart devices)", 9, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAboutProgramInSettings", 6505, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBUpdatesFull", 3979, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBInternetShortCut", 3424, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMetaLink", 4300, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBEAGamesLaunch", 196, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBWSL2", 6988, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBPatchedWindowsLoaderEAC", 193, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBNotificationsWindows10", 912, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBNvidia3DAccessError", 2721, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBBatteryInSettings", 793, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMailWindows", 4401, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNvidiaApp", 2721, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBRDPWrapper", 6, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAntiZapret", 4827, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBLocation", 4419, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBISOMounting", 3657, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSecuityUI", 5988, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBEffinciencyModeTB", 4221, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPrinter", 5419, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBWindows Backup", 712, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRestrict software startup rights", 5883, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBInstalling PC applications on a local area network", 5938, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBLocal network", 4823, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Updates", 7014, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMicrosoft Store", 4574, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBBoosterX applications", 5755, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBStoreX", 6405, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Kiosk", 4592, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAll sound", 7178, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBAutomatic time setting via phone", 5219, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBBitLocker", 6010, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBData Encryption", 7190, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBFirewall", 7204, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRadeon Software", 414, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSMB1 Component", 4823, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBBluetooth", 974, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBMicrophone", 4560, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNight Light", 4270, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBVirtual Desktops", 2395, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBYour Phone", 1569, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSmart Cards", 2178, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBCOM+", 1973, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WB.NET Framework", 2505, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBActiveX", 355, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDirectX", 4596, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBLastActivityView", 1850, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBCaching of files in public folders", 3211, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBHDD Defragmentation", 3656, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSSD Optimization", 2103, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDevice Pairing", 6503, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDevices in Settings", 2002, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDevices with background support", 2395, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBInternet", 2557, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBRemote monitor management", 5675, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAdjusting monitor brightness via keys", 1183, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBOffline Windows updates", 7014, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBVPN", 7190, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBRemote control", 5674, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows updates (delivery optimization)", 7014, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBLocal network restriction", 5938, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNetwork usage in Task Manager", 4830, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBOnline auto driver selection", 1921, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAdding new Bluetooth devices", 976, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBRemoving Bluetooth devices", 977, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBWIN+SHIFT+S2", 4093, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBTrimming in Movies and TV", 7097, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNetwork and Internet option", 4826, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRemote access by password", 4355, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBExtended buffer WIN+V", 1835, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Event Log", 2846, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBFax", 2803, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBFile history", 3141, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMicrosoft Office", 4583, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBWebcam", 7313, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAdditional buttons on devices (scripts)", 4093, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBGHUB", 5935, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBOnboardMemoryManager", 4481, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRazer Synapse", 4689, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBBloody Software", 4139, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMicrosoft Virtual Machines", 2395, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBXBOX", 4595, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBIPv6", 5946, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBIPv4 IPv6 Conversion", 6503, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBVisual Studio Installation", 4590, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMicrosoft Office Installation", 4583, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPin code login", 4329, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBFingerprint login", 3006, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBFace recognition login", 32, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBLogitech GHUB Drivers Installation", 5935, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSaving data when canceling movement in the local network", 2348, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBGTA", 3444, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRockstar Launcher", 5757, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Archiving", 426, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSystem Protection", 5998, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAMD Ryzen Master", 1749, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDownloading other system languages", 6902, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMaps", 4411, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMixed reality", 7137, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBVirtual reality", 7167, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAugmented reality", 4473, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBExternal device login", 4370, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPassword login", 4329, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBProgram compatibility", 4768, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBHolograms", 3765, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAirplane mode", 156, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRadio", 5554, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRealtek Audio Console", 7178, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Recovery", 5704, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNFC", 4850, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBTablet sensors", 6563, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSystem integrity check", 1688, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRAID", 3656, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPowerShell command Get-PhysicalDisk", 5402, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDisk Management", 3657, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWi-Fi Direct", 7365, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBCheck HDD bad sectors", 197, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSystem Restore", 712, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPen", 5168, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBTouch Keyboard", 4093, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMicrosoft IME (Chinese, Japanese, etc. keyboards)", 4120, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBStorage Tiering Management for Windows Server", 5938, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSign in with Microsoft", 4576, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBOnline Time Synchronization", 1959, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Update Troubleshooter", 5490, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWallet", 7195, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBEDGE Protection", 4580, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRouter setup", 5795, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSystem Diagnostics", 6379, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWebDAV Public Access", 7311, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSystem Stability Monitor", 6252, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBVolume on Windows 11", 7178, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNew devices adding on Windows 11", 5355, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBBluetooth on Windows 11", 974, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBScanner", 5837, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBProxy", 5938, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Preinstallation Environment", 4593, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPerformance Analysis", 1633, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBWindows Media Player", 1555, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBUSB Modem", 7033, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBTimeline", 6720, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBContacts", 2094, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBRAGEMP", 3444, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBALTAB", 6480, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSMOOTHFONT", 3293, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd),
			new GClass68.GClass70("WBFaceItAC", 6014, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBBlueStacks", 1676, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAppxIncorrect", 409, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDefenderFix", 5986, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNightLightFix", 7302, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNightLightFix2", 7303, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBUpdates", 7014, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBDefender", 5988, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMinecraftLauncher", 2248, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBMonitorSettings", 4639, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAllElements", 4592, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSendToMonitorPanel", 4652, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNetworkSettings", 4836, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNetworkAndInternetInSettings", 4836, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBWindows11Panel", 424, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBSecondMonitor", 4649, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBVirtualDesktop", 4642, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPC Manager", 396, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBNahimic", 6472, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBPhoto", 3910, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd),
			new GClass68.GClass70("WBAppxMicrosoftApps", 423, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd),
			new GClass68.GClass70("WBWIFI", 7345, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd)
		};
	}

	// Token: 0x02000254 RID: 596
	public sealed class GClass70
	{
		// Token: 0x06001011 RID: 4113 RVA: 0x0000BBC2 File Offset: 0x00009DC2
		public GClass70(string string_1, MaterialIconKind materialIconKind_1, SolidColorBrush solidColorBrush_1)
		{
			this.Name = string_1;
			this.Icon = materialIconKind_1;
			this.Color = solidColorBrush_1;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0000BBDF File Offset: 0x00009DDF
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x0000BBE7 File Offset: 0x00009DE7
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		public MaterialIconKind Icon
		{
			[CompilerGenerated]
			get
			{
				return this.materialIconKind_0;
			}
			[CompilerGenerated]
			set
			{
				this.materialIconKind_0 = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0000BC01 File Offset: 0x00009E01
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x0000BC09 File Offset: 0x00009E09
		public SolidColorBrush Color
		{
			[CompilerGenerated]
			get
			{
				return this.solidColorBrush_0;
			}
			[CompilerGenerated]
			set
			{
				this.solidColorBrush_0 = value;
			}
		}

		// Token: 0x04000A31 RID: 2609
		private string string_0;

		// Token: 0x04000A32 RID: 2610
		private MaterialIconKind materialIconKind_0;

		// Token: 0x04000A33 RID: 2611
		private SolidColorBrush solidColorBrush_0;
	}
}
