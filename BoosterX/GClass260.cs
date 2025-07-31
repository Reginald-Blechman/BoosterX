using System;
using System.Collections.Generic;

// Token: 0x020005E9 RID: 1513
public sealed class GClass260
{
	// Token: 0x060026C8 RID: 9928 RVA: 0x000974BC File Offset: 0x000956BC
	// Note: this type is marked as 'beforefieldinit'.
	static GClass260()
	{
		GClass209.GClass211 gclass = new GClass209.GClass211();
		gclass.Icon = 423;
		gclass.method_1("storeXRequiredServices");
		gclass.Services = new List<string>
		{
			"ClipSVC",
			"BFE",
			"mpssvc",
			"LicenseManager"
		};
		GClass260.gclass211_0 = gclass;
		GClass209.GClass211 gclass2 = new GClass209.GClass211();
		gclass2.Icon = 5419;
		gclass2.IsRed = false;
		gclass2.method_1("printAndScannerServices");
		gclass2.Services = new List<string>
		{
			"PrintNotify",
			"Spooler",
			"PrintWorkflowUserSvc",
			"McpManagementService",
			"stisvc",
			"WiaRpc",
			"Fax",
			"TapiSrv",
			"WBPrinter",
			"PrintScanBrokerService"
		};
		GClass260.gclass211_1 = gclass2;
		GClass209.GClass211 gclass3 = new GClass209.GClass211();
		gclass3.Icon = 2395;
		gclass3.IsRed = false;
		gclass3.method_1("hypervServices");
		gclass3.Services = new List<string>
		{
			"HvHost",
			"vmicguestinterface",
			"vmicheartbeat",
			"vmickvpexchange",
			"vmicrdv",
			"vmicshutdown",
			"vmictimesync",
			"vmicvmsession",
			"vmicvss"
		};
		GClass260.gclass211_2 = gclass3;
		GClass209.GClass211 gclass4 = new GClass209.GClass211();
		gclass4.Icon = 7345;
		gclass4.IsRed = true;
		gclass4.method_1("wifiServices");
		gclass4.Services = new List<string>
		{
			"WlanSvc",
			"vwifibus",
			"wdiwifi",
			"WinHttpAutoProxySvc",
			"Wcmsvc"
		};
		GClass260.gclass211_3 = gclass4;
		GClass209.GClass211 gclass5 = new GClass209.GClass211();
		gclass5.Icon = 974;
		gclass5.IsRed = false;
		gclass5.method_1("bluetoothServices");
		gclass5.Services = new List<string>
		{
			"BluetoothUserService",
			"BthAvctpSvc",
			"bthserv",
			"BTAGService",
			"NcbService",
			"DeviceAssociationService",
			"DsmSvc"
		};
		GClass260.gclass211_4 = gclass5;
		GClass209.GClass211 gclass6 = new GClass209.GClass211();
		gclass6.Icon = 4355;
		gclass6.IsRed = false;
		gclass6.method_1("encryptServices");
		gclass6.Services = new List<string>
		{
			"BDESVC",
			"EFS"
		};
		GClass260.gclass211_5 = gclass6;
		GClass209.GClass211 gclass7 = new GClass209.GClass211();
		gclass7.Icon = 4355;
		gclass7.IsRed = false;
		gclass7.method_1("bufferServices");
		gclass7.Services = new List<string>
		{
			"cbdhsvc",
			"TokenBroker",
			"EFS"
		};
		GClass260.gclass211_6 = gclass7;
		GClass209.GClass211 gclass8 = new GClass209.GClass211();
		gclass8.Icon = 423;
		gclass8.IsRed = false;
		gclass8.method_1("storeServices");
		gclass8.Services = new List<string>
		{
			"ClipSVC",
			"BFE",
			"mpssvc",
			"InstallService",
			"PushToInstall",
			"VaultSvc",
			"StorSvc",
			"TokenBroker",
			"wlidsvc",
			"UserDataSvc",
			"UnistoreSvc"
		};
		GClass260.gclass211_7 = gclass8;
		GClass209.GClass211 gclass9 = new GClass209.GClass211();
		gclass9.Icon = 4592;
		gclass9.IsRed = false;
		gclass9.method_1("microsoftAccountServices");
		gclass9.Services = new List<string>
		{
			"VaultSvc",
			"wlidsvc",
			"TokenBroker"
		};
		GClass260.gclass211_8 = gclass9;
		GClass209.GClass211 gclass10 = new GClass209.GClass211();
		gclass10.Icon = 2384;
		gclass10.IsRed = false;
		gclass10.method_1("uselessServices");
		gclass10.Services = new List<string>
		{
			"AssignedAccessManagerSvc",
			"AppReadiness",
			"ScDeviceEnum",
			"RetailDemo",
			"TrkWks",
			"ALG",
			"AxInstSV",
			"CertPropSvc",
			"DevQueryBroker",
			"FontCache",
			"FontCache3.0.0.0",
			"IpxlatCfgSvc",
			"MapsBroker",
			"perceptionsimulation",
			"spectrum",
			"PhoneSvc",
			"PNRPAutoReg",
			"PNRPsvc",
			"RmSvc",
			"WpnUserService",
			"RpcLocator",
			"SCPolicySvc",
			"SmsRouter",
			"SNMPTRAP",
			"TieringEngineService",
			"wcncsvc",
			"WEPHOSTSVC",
			"wercplsupport",
			"WpcMonSvc",
			"WpnService",
			"CDPUserSvc",
			"PimIndexMaintenanceSvc",
			"SEMgrSvc",
			"autotimesvc",
			"KtmRm",
			"SensorDataService",
			"SensorService",
			"SensrSvc",
			"WalletService",
			"Beep",
			"tcpipreg",
			"PCManager Service Store",
			"NahimicService",
			"lfsvc"
		};
		GClass260.gclass211_9 = gclass10;
		GClass209.GClass211 gclass11 = new GClass209.GClass211();
		gclass11.Icon = 5883;
		gclass11.IsRed = false;
		gclass11.method_1("firewallServices");
		gclass11.Services = new List<string>
		{
			"BFE",
			"mpssvc"
		};
		GClass260.gclass211_10 = gclass11;
		GClass209.GClass211 gclass12 = new GClass209.GClass211();
		gclass12.Icon = 7190;
		gclass12.IsRed = false;
		gclass12.method_1("vpnOrProxyServices");
		gclass12.Services = new List<string>
		{
			"SstpSvc",
			"IKEEXT",
			"RasMan",
			"PolicyAgent",
			"WinHttpAutoProxySvc"
		};
		GClass260.gclass211_11 = gclass12;
		GClass209.GClass211 gclass13 = new GClass209.GClass211();
		gclass13.Icon = 7167;
		gclass13.IsRed = false;
		gclass13.method_1("virtualRealityServices");
		gclass13.Services = new List<string>
		{
			"MixedRealityOpenXRSvc",
			"SharedRealitySvc",
			"VacSvc"
		};
		GClass260.gclass211_12 = gclass13;
		GClass209.GClass211 gclass14 = new GClass209.GClass211();
		gclass14.Icon = 4161;
		gclass14.IsRed = false;
		gclass14.method_1("localNetworkServices");
		gclass14.Services = new List<string>
		{
			"LanmanServer",
			"lmhosts",
			"workfolderssvc",
			"fdPHost",
			"AppMgmt",
			"CscService",
			"dot3svc",
			"lltdsvc",
			"MSDTC",
			"p2pimsvc",
			"p2psvc",
			"PeerDistSvc",
			"QWAVE",
			"SEMgrSvc",
			"SharedAccess",
			"SSDPSRV",
			"Browser",
			"upnphost",
			"Wecsvc",
			"WinRM",
			"WMPNetworkSvc",
			"AJRouter",
			"NetBT"
		};
		GClass260.gclass211_13 = gclass14;
		GClass209.GClass211 gclass15 = new GClass209.GClass211();
		gclass15.Icon = 4163;
		gclass15.IsRed = false;
		gclass15.method_1("remoteControlServices");
		gclass15.Services = new List<string>
		{
			"UmRdpService",
			"RasAuto",
			"TermService",
			"EntAppSvc",
			"SessionEnv",
			"Eaphost",
			"WebClient"
		};
		GClass260.gclass211_14 = gclass15;
		GClass209.GClass211 gclass16 = new GClass209.GClass211();
		gclass16.Icon = 2011;
		gclass16.IsRed = false;
		gclass16.method_1("diagnosisServices");
		gclass16.Services = new List<string>
		{
			"pla",
			"TroubleshootingSvc",
			"WerSvc",
			"DPS",
			"diagnosticshub.standardcollector.service",
			"CDPSvc",
			"WdiServiceHost",
			"WdiSystemHost",
			"wmiApSrv",
			"SgrmBroker",
			"bam",
			"dam",
			"GpuEnergyDrv"
		};
		GClass260.gclass211_15 = gclass16;
		GClass209.GClass211 gclass17 = new GClass209.GClass211();
		gclass17.Icon = 430;
		gclass17.IsRed = false;
		gclass17.method_1("archiveAndRestoreWindowsServices");
		gclass17.Services = new List<string>
		{
			"SDRSVC",
			"swprv",
			"VSS",
			"wbengine",
			"fhsvc"
		};
		GClass260.gclass211_16 = gclass17;
		GClass209.GClass211 gclass18 = new GClass209.GClass211();
		gclass18.Icon = 3006;
		gclass18.IsRed = true;
		gclass18.method_1("passwordBiometryServices");
		gclass18.Services = new List<string>
		{
			"NgcSvc",
			"KeyIso",
			"NgcCtnrSvc",
			"NaturalAuthentication",
			"WbioSrvc"
		};
		GClass260.gclass211_17 = gclass18;
		GClass209.GClass211 gclass19 = new GClass209.GClass211();
		gclass19.Icon = 3006;
		gclass19.IsRed = true;
		gclass19.method_1("passwordBiometryServices");
		gclass19.Services = new List<string>
		{
			"NgcSvc",
			"NgcCtnrSvc",
			"NaturalAuthentication",
			"WbioSrvc"
		};
		GClass260.gclass211_18 = gclass19;
		GClass209.GClass211 gclass20 = new GClass209.GClass211();
		gclass20.Icon = 4595;
		gclass20.IsRed = false;
		gclass20.method_1("xboxServices");
		gclass20.Services = new List<string>
		{
			"IKEEXT",
			"iphlpsvc",
			"DeviceAssociationBrokerSvc",
			"XblAuthManager",
			"XblGameSave",
			"XboxNetApiSvc",
			"xbgm",
			"XboxGipSvc",
			"TokenBroker"
		};
		GClass260.gclass211_19 = gclass20;
		GClass209.GClass211 gclass21 = new GClass209.GClass211();
		gclass21.Icon = 3176;
		gclass21.IsRed = false;
		gclass21.method_1("windowsMediaPlayerServices");
		gclass21.Services = new List<string>
		{
			"WMPNetworkSvc",
			"WPDBusEnum"
		};
		GClass260.gclass211_20 = gclass21;
		GClass209.GClass211 gclass22 = new GClass209.GClass211();
		gclass22.Icon = 2073;
		gclass22.IsRed = false;
		gclass22.method_1("themesService");
		gclass22.Services = new List<string>
		{
			"Themes"
		};
		GClass260.gclass211_21 = gclass22;
		GClass209.GClass211 gclass23 = new GClass209.GClass211();
		gclass23.Icon = 3656;
		gclass23.IsRed = false;
		gclass23.method_1("sysmainServices");
		gclass23.Services = new List<string>
		{
			"SysMain",
			"svsvc"
		};
		GClass260.gclass211_22 = gclass23;
		GClass209.GClass211 gclass24 = new GClass209.GClass211();
		gclass24.Icon = 2827;
		gclass24.IsRed = false;
		gclass24.method_1("indexServices");
		gclass24.Services = new List<string>
		{
			"WSearch"
		};
		GClass260.gclass211_23 = gclass24;
		GClass209.GClass211 gclass25 = new GClass209.GClass211();
		gclass25.Icon = 6786;
		gclass25.IsRed = false;
		gclass25.method_1("wisvcService");
		gclass25.Services = new List<string>
		{
			"wisvc"
		};
		GClass260.gclass211_24 = gclass25;
		GClass209.GClass211 gclass26 = new GClass209.GClass211();
		gclass26.Icon = 7033;
		gclass26.IsRed = false;
		gclass26.method_1("shellHWDetectionService");
		gclass26.Services = new List<string>
		{
			"ShellHWDetection"
		};
		GClass260.gclass211_25 = gclass26;
		GClass209.GClass211 gclass27 = new GClass209.GClass211();
		gclass27.Icon = 7032;
		gclass27.IsRed = false;
		gclass27.method_1("WwanSvcService");
		gclass27.Services = new List<string>
		{
			"WwanSvc"
		};
		GClass260.gclass211_26 = gclass27;
		GClass209.GClass211 gclass28 = new GClass209.GClass211();
		gclass28.Icon = 2843;
		gclass28.IsRed = false;
		gclass28.method_1("PcaSvcService");
		gclass28.Services = new List<string>
		{
			"PcaSvc"
		};
		GClass260.gclass211_27 = gclass28;
		GClass209.GClass211 gclass29 = new GClass209.GClass211();
		gclass29.Icon = 7352;
		gclass29.IsRed = false;
		gclass29.method_1("DusmSvcService");
		gclass29.Services = new List<string>
		{
			"DusmSvc"
		};
		GClass260.gclass211_28 = gclass29;
		GClass209.GClass211 gclass30 = new GClass209.GClass211();
		gclass30.Icon = 3657;
		gclass30.IsRed = false;
		gclass30.method_1("defragsvcService");
		gclass30.Services = new List<string>
		{
			"defragsvc"
		};
		GClass260.gclass211_29 = gclass30;
		GClass209.GClass211 gclass31 = new GClass209.GClass211();
		gclass31.Icon = 7278;
		gclass31.IsRed = false;
		gclass31.method_1("W32TimeService");
		gclass31.Services = new List<string>
		{
			"W32Time"
		};
		GClass260.gclass211_30 = gclass31;
		GClass209.GClass211 gclass32 = new GClass209.GClass211();
		gclass32.Icon = 1579;
		gclass32.IsRed = false;
		gclass32.method_1("DeviceAssociationService");
		gclass32.Services = new List<string>
		{
			"DeviceAssociationService"
		};
		GClass260.gclass211_31 = gclass32;
		GClass209.GClass211 gclass33 = new GClass209.GClass211();
		gclass33.Icon = 7307;
		gclass33.IsRed = false;
		gclass33.method_1("DisplayEnhancementService");
		gclass33.Services = new List<string>
		{
			"DisplayEnhancementService"
		};
		GClass260.gclass211_32 = gclass33;
		GClass209.GClass211 gclass34 = new GClass209.GClass211();
		gclass34.Icon = 1929;
		gclass34.IsRed = false;
		gclass34.method_1("DsmSvcService");
		gclass34.Services = new List<string>
		{
			"DsmSvc"
		};
		GClass260.gclass211_33 = gclass34;
		GClass209.GClass211 gclass35 = new GClass209.GClass211();
		gclass35.Icon = 7313;
		gclass35.IsRed = false;
		gclass35.method_1("FrameServerService");
		gclass35.Services = new List<string>
		{
			"FrameServer"
		};
		GClass260.gclass211_34 = gclass35;
		GClass209.GClass211 gclass36 = new GClass209.GClass211();
		gclass36.Icon = 4116;
		gclass36.IsRed = true;
		gclass36.method_1("hidservService");
		gclass36.Services = new List<string>
		{
			"hidserv"
		};
		GClass260.gclass211_35 = gclass36;
		GClass209.GClass211 gclass37 = new GClass209.GClass211();
		gclass37.Icon = 6904;
		gclass37.IsRed = false;
		gclass37.method_1("LxpSvcService");
		gclass37.Services = new List<string>
		{
			"LxpSvc"
		};
		GClass260.gclass211_36 = gclass37;
		GClass209.GClass211 gclass38 = new GClass209.GClass211();
		gclass38.Icon = 2106;
		gclass38.IsRed = false;
		gclass38.method_1("smphostService");
		gclass38.Services = new List<string>
		{
			"smphost"
		};
		GClass260.gclass211_37 = gclass38;
	}

	// Token: 0x0400196A RID: 6506
	public static readonly GClass209.GClass211 gclass211_0;

	// Token: 0x0400196B RID: 6507
	public static readonly GClass209.GClass211 gclass211_1;

	// Token: 0x0400196C RID: 6508
	public static readonly GClass209.GClass211 gclass211_2;

	// Token: 0x0400196D RID: 6509
	public static readonly GClass209.GClass211 gclass211_3;

	// Token: 0x0400196E RID: 6510
	public static readonly GClass209.GClass211 gclass211_4;

	// Token: 0x0400196F RID: 6511
	public static readonly GClass209.GClass211 gclass211_5;

	// Token: 0x04001970 RID: 6512
	public static readonly GClass209.GClass211 gclass211_6;

	// Token: 0x04001971 RID: 6513
	public static readonly GClass209.GClass211 gclass211_7;

	// Token: 0x04001972 RID: 6514
	public static readonly GClass209.GClass211 gclass211_8;

	// Token: 0x04001973 RID: 6515
	public static readonly GClass209.GClass211 gclass211_9;

	// Token: 0x04001974 RID: 6516
	public static readonly GClass209.GClass211 gclass211_10;

	// Token: 0x04001975 RID: 6517
	public static readonly GClass209.GClass211 gclass211_11;

	// Token: 0x04001976 RID: 6518
	public static readonly GClass209.GClass211 gclass211_12;

	// Token: 0x04001977 RID: 6519
	public static readonly GClass209.GClass211 gclass211_13;

	// Token: 0x04001978 RID: 6520
	public static readonly GClass209.GClass211 gclass211_14;

	// Token: 0x04001979 RID: 6521
	public static readonly GClass209.GClass211 gclass211_15;

	// Token: 0x0400197A RID: 6522
	public static readonly GClass209.GClass211 gclass211_16;

	// Token: 0x0400197B RID: 6523
	public static readonly GClass209.GClass211 gclass211_17;

	// Token: 0x0400197C RID: 6524
	public static readonly GClass209.GClass211 gclass211_18;

	// Token: 0x0400197D RID: 6525
	public static readonly GClass209.GClass211 gclass211_19;

	// Token: 0x0400197E RID: 6526
	public static readonly GClass209.GClass211 gclass211_20;

	// Token: 0x0400197F RID: 6527
	public static readonly GClass209.GClass211 gclass211_21;

	// Token: 0x04001980 RID: 6528
	public static readonly GClass209.GClass211 gclass211_22;

	// Token: 0x04001981 RID: 6529
	public static readonly GClass209.GClass211 gclass211_23;

	// Token: 0x04001982 RID: 6530
	public static readonly GClass209.GClass211 gclass211_24;

	// Token: 0x04001983 RID: 6531
	public static readonly GClass209.GClass211 gclass211_25;

	// Token: 0x04001984 RID: 6532
	public static readonly GClass209.GClass211 gclass211_26;

	// Token: 0x04001985 RID: 6533
	public static readonly GClass209.GClass211 gclass211_27;

	// Token: 0x04001986 RID: 6534
	public static readonly GClass209.GClass211 gclass211_28;

	// Token: 0x04001987 RID: 6535
	public static readonly GClass209.GClass211 gclass211_29;

	// Token: 0x04001988 RID: 6536
	public static readonly GClass209.GClass211 gclass211_30;

	// Token: 0x04001989 RID: 6537
	public static readonly GClass209.GClass211 gclass211_31;

	// Token: 0x0400198A RID: 6538
	public static readonly GClass209.GClass211 gclass211_32;

	// Token: 0x0400198B RID: 6539
	public static readonly GClass209.GClass211 gclass211_33;

	// Token: 0x0400198C RID: 6540
	public static readonly GClass209.GClass211 gclass211_34;

	// Token: 0x0400198D RID: 6541
	public static readonly GClass209.GClass211 gclass211_35;

	// Token: 0x0400198E RID: 6542
	public static readonly GClass209.GClass211 gclass211_36;

	// Token: 0x0400198F RID: 6543
	public static readonly GClass209.GClass211 gclass211_37;
}
