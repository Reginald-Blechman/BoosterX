using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;

// Token: 0x020000CD RID: 205
public sealed class GClass163 : GClass162
{
	// Token: 0x06000615 RID: 1557 RVA: 0x0003A71C File Offset: 0x0003891C
	public GClass163()
	{
		this.observableCollection_0 = this.method_3();
		this.icollectionView_0 = CollectionViewSource.GetDefaultView(this.SettingsVMs);
		this.SettingItemsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("Group"));
		Class402.Event_0 += this.method_2;
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000616 RID: 1558 RVA: 0x00005D75 File Offset: 0x00003F75
	public ObservableCollection<GClass192> SettingsVMs
	{
		[CompilerGenerated]
		get
		{
			return this.observableCollection_0;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x00005D7D File Offset: 0x00003F7D
	public ICollectionView SettingItemsCollectionView
	{
		[CompilerGenerated]
		get
		{
			return this.icollectionView_0;
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x0003A778 File Offset: 0x00038978
	private void method_2(Class723 class723_0)
	{
		foreach (GClass192 gclass in this.SettingsVMs)
		{
			gclass.method_2();
		}
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x0003A7C4 File Offset: 0x000389C4
	private ObservableCollection<GClass192> method_3()
	{
		ObservableCollection<GClass192> observableCollection = new ObservableCollection<GClass192>();
		GClass192 gclass = new GClass192();
		gclass.Group = "Performance";
		gclass.NameRaw = "SlowPCMode";
		gclass.method_4(false);
		gclass.RegistryValue = "SlowPCMode";
		gclass.IconString = "FanChevronDown";
		observableCollection.Add(gclass);
		GClass192 gclass2 = new GClass192();
		gclass2.Group = "AdvancedUser";
		gclass2.NameRaw = "ICanReadAndBeCareful";
		gclass2.method_4(false);
		gclass2.RegistryValue = "ICanReadAndBeCareful";
		gclass2.IconString = "CloseOctagon";
		observableCollection.Add(gclass2);
		GClass192 gclass3 = new GClass192();
		gclass3.Group = "AdvancedUser";
		gclass3.NameRaw = "AlwaysShowFullDescription";
		gclass3.method_4(false);
		gclass3.RegistryValue = "AlwaysShowFullDescription";
		gclass3.IconString = "TextBoxPlusOutline";
		observableCollection.Add(gclass3);
		GClass192 gclass4 = new GClass192();
		gclass4.Group = "AdvancedUser";
		gclass4.NameRaw = "ShowGroupServices";
		gclass4.method_4(false);
		gclass4.RegistryValue = "ShowServicesPage";
		gclass4.IconString = "Cogs";
		observableCollection.Add(gclass4);
		GClass192 gclass5 = new GClass192();
		gclass5.Group = "AdvancedUser";
		gclass5.NameRaw = "ShowServicesManagerPage";
		gclass5.method_4(false);
		gclass5.RegistryValue = "ShowServicesManagerPage";
		gclass5.IconString = "TableCog";
		observableCollection.Add(gclass5);
		GClass192 gclass6 = new GClass192();
		gclass6.Group = "AdvancedUser";
		gclass6.NameRaw = "ShowAffinityPage";
		gclass6.method_4(false);
		gclass6.RegistryValue = "ShowAffinityPage";
		gclass6.IconString = "Counter";
		observableCollection.Add(gclass6);
		GClass192 gclass7 = new GClass192();
		gclass7.Group = "AdvancedUser";
		gclass7.NameRaw = "NvidiaHardmode";
		gclass7.method_4(false);
		gclass7.RegistryValue = "IsNvidiaHardMode";
		gclass7.IconString = "EyeLockOpen";
		observableCollection.Add(gclass7);
		GClass192 gclass8 = new GClass192();
		gclass8.Group = "AdvancedUser";
		gclass8.NameRaw = "ShowHiddenTweaks2";
		gclass8.method_4(false);
		gclass8.RegistryValue = "ShowHiddenTweaks";
		gclass8.IconString = "FileHidden";
		observableCollection.Add(gclass8);
		GClass192 gclass9 = new GClass192();
		gclass9.Group = "AdvancedUser";
		gclass9.NameRaw = "ShowExperimentalTweaks";
		gclass9.method_4(true);
		gclass9.RegistryValue = "ShowExperimentalTweaks";
		gclass9.IconString = "TestTube";
		observableCollection.Add(gclass9);
		GClass192 gclass10 = new GClass192();
		gclass10.Group = "Performance";
		gclass10.NameRaw = "ShowMetrics";
		gclass10.method_4(false);
		gclass10.RegistryValue = "ShowMetrics";
		gclass10.IconString = "CarSpeedLimiter";
		observableCollection.Add(gclass10);
		GClass192 gclass11 = new GClass192();
		gclass11.Group = "Performance";
		gclass11.NameRaw = "ShowRAMMetrics";
		gclass11.method_4(false);
		gclass11.RegistryValue = "ShowRAMMetrics";
		gclass11.IconString = "Memory";
		observableCollection.Add(gclass11);
		GClass192 gclass12 = new GClass192();
		gclass12.Group = "Performance";
		gclass12.NameRaw = "ShowDISKMetrics";
		gclass12.method_4(false);
		gclass12.RegistryValue = "ShowDISKMetrics";
		gclass12.IconString = "Harddisk";
		observableCollection.Add(gclass12);
		GClass192 gclass13 = new GClass192();
		gclass13.Group = "SkipPagesSettings";
		gclass13.NameRaw = "DoNotShowILTFirstPage";
		gclass13.method_4(false);
		gclass13.RegistryValue = "DoNotShowILTFirstPage";
		gclass13.IconString = "ImageOffOutline";
		observableCollection.Add(gclass13);
		GClass192 gclass14 = new GClass192();
		gclass14.Group = "SkipPagesSettings";
		gclass14.NameRaw = "DoNotShowStoreXFirstPage";
		gclass14.method_4(false);
		gclass14.RegistryValue = "DoNotShowStoreXFirstPage";
		gclass14.IconString = "ImageOffOutline";
		observableCollection.Add(gclass14);
		GClass192 gclass15 = new GClass192();
		gclass15.Group = "SkipPagesSettings";
		gclass15.NameRaw = "DoNotShowInternetTFirstPage";
		gclass15.method_4(false);
		gclass15.RegistryValue = "DoNotShowInternetTFirstPage";
		gclass15.IconString = "ImageOffOutline";
		observableCollection.Add(gclass15);
		GClass192 gclass16 = new GClass192();
		gclass16.Group = "BoosterX";
		gclass16.NameRaw = "ShowDiscordRPC";
		gclass16.method_4(false);
		gclass16.RegistryValue = "ShowDiscordRPC";
		gclass16.IconString = "HumanMaleBoard";
		observableCollection.Add(gclass16);
		GClass192 gclass17 = new GClass192();
		gclass17.Group = "BoosterX";
		gclass17.NameRaw = "ShowErrors";
		gclass17.method_4(false);
		gclass17.RegistryValue = "ShowErrors";
		gclass17.IconString = "AlertCircle";
		observableCollection.Add(gclass17);
		GClass192 gclass18 = new GClass192();
		gclass18.Group = "BoosterX";
		gclass18.NameRaw = "AutoUpdate";
		gclass18.method_4(false);
		gclass18.RegistryValue = "AutoUpdate";
		gclass18.IconString = "ProgressDownload";
		observableCollection.Add(gclass18);
		GClass192 gclass19 = new GClass192();
		gclass19.Group = "AdvancedUser";
		gclass19.NameRaw = "InstantTweaksApply";
		gclass19.method_4(true);
		gclass19.RegistryValue = "InstantTweaksApply";
		gclass19.IconString = "CheckboxMarkedCircleAutoOutline";
		observableCollection.Add(gclass19);
		return observableCollection;
	}

	// Token: 0x04000344 RID: 836
	private readonly ObservableCollection<GClass192> observableCollection_0;

	// Token: 0x04000345 RID: 837
	private readonly ICollectionView icollectionView_0;
}
