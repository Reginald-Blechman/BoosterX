using System;
using System.Collections.ObjectModel;
using ns0;

// Token: 0x020006AC RID: 1708
public sealed class GClass292
{
	// Token: 0x06002B14 RID: 11028 RVA: 0x000A63D4 File Offset: 0x000A45D4
	public static GClass292.GClass194 smethod_0()
	{
		if (GClass292.gclass194_0 != null)
		{
			return GClass292.gclass194_0;
		}
		GClass292.gclass194_0 = new GClass292.GClass194();
		Collection<GClass173> appsX = GClass292.gclass194_0.AppsX;
		GClass173 gclass = new GClass173();
		gclass.BackgroundMain = "/Resources/Images/Apps/StoreMain.jpg";
		gclass.Stroke = "/Resources/Images/Apps/StoreStroke.jpg";
		gclass.string_0 = "StoreX";
		gclass.NavigateTo = new GClass280(new Action<object>(GClass292.Class830.class830_0.method_0), null);
		appsX.Add(gclass);
		Collection<GClass173> appsX2 = GClass292.gclass194_0.AppsX;
		GClass173 gclass2 = new GClass173();
		gclass2.BackgroundMain = "/Resources/Images/Apps/GMXMain.jpg";
		gclass2.Stroke = "/Resources/Images/Apps/GMXStroke.jpg";
		gclass2.string_0 = "GMX";
		gclass2.NavigateTo = new GClass280(new Action<object>(GClass292.Class830.class830_0.method_1), null);
		appsX2.Add(gclass2);
		Collection<GClass173> appsX3 = GClass292.gclass194_0.AppsX;
		GClass173 gclass3 = new GClass173();
		gclass3.BackgroundMain = "/Resources/Images/Apps/GodModeMain.jpg";
		gclass3.Stroke = "/Resources/Images/Apps/GodModeStroke.jpg";
		gclass3.string_0 = "GodMode";
		gclass3.NavigateTo = new GClass280(new Action<object>(GClass292.Class830.class830_0.method_2), null);
		appsX3.Add(gclass3);
		Collection<GClass173> appsX4 = GClass292.gclass194_0.AppsX;
		GClass173 gclass4 = new GClass173();
		gclass4.BackgroundMain = "/Resources/Images/Apps/LatencyTestMain.jpg";
		gclass4.Stroke = "/Resources/Images/Apps/LatencyTestStroke.jpg";
		gclass4.string_0 = "LatencyTest";
		gclass4.NavigateTo = new GClass280(new Action<object>(GClass292.Class830.class830_0.method_3), null);
		appsX4.Add(gclass4);
		Collection<GClass173> appsX5 = GClass292.gclass194_0.AppsX;
		GClass173 gclass5 = new GClass173();
		gclass5.BackgroundMain = "/Resources/Images/Apps/InternetTestMain.jpg";
		gclass5.Stroke = "/Resources/Images/Apps/InternetTestStroke.jpg";
		gclass5.string_0 = "InternetTest";
		gclass5.NavigateTo = new GClass280(new Action<object>(GClass292.Class830.class830_0.method_4), null);
		appsX5.Add(gclass5);
		Collection<GClass173> appsX6 = GClass292.gclass194_0.AppsX;
		GClass173 gclass6 = new GClass173();
		gclass6.BackgroundMain = "/Resources/Images/Launchers/SteamMain.jpg";
		gclass6.Stroke = "/Resources/Images/Launchers/SteamStroke.jpg";
		gclass6.string_0 = "Steam";
		gclass6.NavigateTo = new GClass280(new Action<object>(GClass292.Class830.class830_0.method_5), null);
		appsX6.Add(gclass6);
		return GClass292.gclass194_0;
	}

	// Token: 0x06002B15 RID: 11029 RVA: 0x0001BD00 File Offset: 0x00019F00
	public static void smethod_1(Type type_0)
	{
		GClass292.smethod_2();
		Class406.smethod_0().method_4(type_0, Class406.smethod_0().frame_0);
	}

	// Token: 0x06002B16 RID: 11030 RVA: 0x000A6650 File Offset: 0x000A4850
	public static void smethod_2()
	{
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = Class406.smethod_0().method_7();
		bool? isChecked = dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.radioButton_2.IsChecked;
		if (!isChecked.GetValueOrDefault() & isChecked != null)
		{
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_22 = true;
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.radioButton_2.IsChecked = new bool?(true);
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_22 = false;
		}
	}

	// Token: 0x04001C08 RID: 7176
	private static GClass292.GClass194 gclass194_0;

	// Token: 0x020006AD RID: 1709
	public sealed class GClass194 : GClass162
	{
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x0001BD2F File Offset: 0x00019F2F
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x0001BD37 File Offset: 0x00019F37
		public ObservableCollection<GClass173> AppsX
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("AppsX");
			}
		}

		// Token: 0x04001C09 RID: 7177
		private ObservableCollection<GClass173> observableCollection_0 = new ObservableCollection<GClass173>();
	}

	// Token: 0x020006AE RID: 1710
	[Serializable]
	private sealed class Class830
	{
		// Token: 0x06002B1C RID: 11036 RVA: 0x000A66A8 File Offset: 0x000A48A8
		internal void method_0(object object_0)
		{
			Class551.class753_0.method_3("StoreX");
			if (Class551.class753_0.method_66().GetValueOrDefault())
			{
				GClass292.smethod_1(typeof(dje_z77EFLA4PV3MZUEQU3R4HLE3ZWY2VDLH6LQ3W7CVBDKT9UGNX4UJZ3_ejd));
				return;
			}
			GClass292.smethod_1(typeof(dje_zUDE23GUASL6NYX8CQDMSLA4C6R2XKAXD7HMGF9HUTVVRXLH4DFAC5J9ZTWGQ_ejd));
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0001BD58 File Offset: 0x00019F58
		internal void method_1(object object_0)
		{
			Class551.class753_0.method_3("GMX");
			GClass292.smethod_1(typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P2YPZZ43QZRMSXBYXHM3SBGMHKS4_ejd));
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x0001BD79 File Offset: 0x00019F79
		internal void method_2(object object_0)
		{
			Class551.class753_0.method_3("GodMode");
			GClass292.smethod_1(typeof(dje_zC2NJRMFW869HG6SMD7D73TQX3AHTPYGHL3SJYXUQ9Z8E87R726PZ5_ejd));
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0001BD9A File Offset: 0x00019F9A
		internal void method_3(object object_0)
		{
			Class551.class753_0.method_3("LatencyTest");
			GClass292.smethod_1(typeof(dje_zZCUAVPNLG8AUBH2M8QYRJL9ZSBM4VNU6DKLDXAH59QVK4AE9K647X7TKNRGQ_ejd));
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x0001BDBB File Offset: 0x00019FBB
		internal void method_4(object object_0)
		{
			Class551.class753_0.method_3("InternetTest");
			GClass292.smethod_1(typeof(dje_zJUUFNV7ZNQCF29T6KEV6HFT6FEA8CF7J84L4HL8GTCNF7CDYTPQJE_ejd));
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0001BDDC File Offset: 0x00019FDC
		internal void method_5(object object_0)
		{
			Class551.class753_0.method_3("Steam");
			GClass292.smethod_1(typeof(dje_zQB54HQCJ26ASRT6GBACQNFDHKQ5FAVCLQ7LSNYLC6ZETJ9SF8FN63_ejd));
		}

		// Token: 0x04001C0A RID: 7178
		public static readonly GClass292.Class830 class830_0 = new GClass292.Class830();

		// Token: 0x04001C0B RID: 7179
		public static Action<object> action_0;

		// Token: 0x04001C0C RID: 7180
		public static Action<object> action_1;

		// Token: 0x04001C0D RID: 7181
		public static Action<object> action_2;

		// Token: 0x04001C0E RID: 7182
		public static Action<object> action_3;

		// Token: 0x04001C0F RID: 7183
		public static Action<object> action_4;

		// Token: 0x04001C10 RID: 7184
		public static Action<object> action_5;
	}
}
