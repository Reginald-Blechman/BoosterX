using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000567 RID: 1383
internal sealed class Class752 : Class749
{
	// Token: 0x060022A6 RID: 8870 RVA: 0x00089E74 File Offset: 0x00088074
	public ObservableCollection<Class499> method_0()
	{
		Class752.Class665 @class = new Class752.Class665();
		@class.observableCollection_0 = new ObservableCollection<Class499>();
		List<string> list = Class749.smethod_2("Games", "GameModeX");
		if (list != null)
		{
			list.ForEach(new Action<string>(@class.method_0));
		}
		return @class.observableCollection_0;
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x00089EC0 File Offset: 0x000880C0
	public ObservableCollection<Class500> method_1()
	{
		Class752.Class666 @class = new Class752.Class666();
		@class.observableCollection_0 = new ObservableCollection<Class500>();
		List<string> list = Class749.smethod_2("Apps", "GameModeX");
		if (list != null)
		{
			list.ForEach(new Action<string>(@class.method_0));
		}
		return @class.observableCollection_0;
	}

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00089F0C File Offset: 0x0008810C
	// (set) Token: 0x060022A9 RID: 8873 RVA: 0x00016B3A File Offset: 0x00014D3A
	public string OnOffShortcut
	{
		get
		{
			string text = "CTRL+SHIFT+O";
			return Class749.smethod_0("OnOffShortcut", this.string_0) ?? text;
		}
		set
		{
			Class749.smethod_1("OnOffShortcut", value.ToString(), this.string_0);
		}
	}

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x060022AA RID: 8874 RVA: 0x00089F38 File Offset: 0x00088138
	// (set) Token: 0x060022AB RID: 8875 RVA: 0x00016B53 File Offset: 0x00014D53
	public bool? DisableDWM
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class749.smethod_0("DisableDWM", this.string_0))).GetValueOrDefault());
		}
		set
		{
			Class749.smethod_1("DisableDWM", value.ToString(), this.string_0);
		}
	}

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x060022AC RID: 8876 RVA: 0x00089F70 File Offset: 0x00088170
	// (set) Token: 0x060022AD RID: 8877 RVA: 0x00016B73 File Offset: 0x00014D73
	public bool? DisableMouseHooks
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class749.smethod_0("DisableMouseHooks", this.string_0))).GetValueOrDefault());
		}
		set
		{
			Class749.smethod_1("DisableMouseHooks", value.ToString(), this.string_0);
		}
	}

	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x060022AE RID: 8878 RVA: 0x00089FA8 File Offset: 0x000881A8
	// (set) Token: 0x060022AF RID: 8879 RVA: 0x00016B93 File Offset: 0x00014D93
	public bool? DisableExplorer
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class749.smethod_0("DisableExplorer", this.string_0))).GetValueOrDefault(true));
		}
		set
		{
			Class749.smethod_1("DisableExplorer", value.ToString(), this.string_0);
		}
	}

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00016BB3 File Offset: 0x00014DB3
	// (set) Token: 0x060022B1 RID: 8881 RVA: 0x00016BD0 File Offset: 0x00014DD0
	public string CleanCacheShortcut
	{
		get
		{
			return Class749.smethod_0("CleanCacheShortcut", this.string_0) ?? "CTRL+SHIFT+P";
		}
		set
		{
			Class749.smethod_1("CleanCacheShortcut", value.ToString(), this.string_0);
		}
	}

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00089FE0 File Offset: 0x000881E0
	// (set) Token: 0x060022B3 RID: 8883 RVA: 0x00016BE9 File Offset: 0x00014DE9
	public bool? CleanCacheAtStart
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class749.smethod_0("CleanCacheAtStart", this.string_0))).GetValueOrDefault(true));
		}
		set
		{
			Class749.smethod_1("CleanCacheAtStart", value.ToString(), this.string_0);
		}
	}

	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x060022B4 RID: 8884 RVA: 0x0008A018 File Offset: 0x00088218
	// (set) Token: 0x060022B5 RID: 8885 RVA: 0x00016C09 File Offset: 0x00014E09
	public bool? SnapTap
	{
		get
		{
			return new bool?(new bool?(Convert.ToBoolean(Class749.smethod_0("SnapTap", this.string_0))).GetValueOrDefault());
		}
		set
		{
			Class749.smethod_1("SnapTap", value.ToString(), this.string_0);
		}
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x00016C29 File Offset: 0x00014E29
	public string method_2()
	{
		return Class749.smethod_0("SnapTapKeys", this.string_0) ?? "A+D";
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x00016C46 File Offset: 0x00014E46
	public void method_3(string string_1)
	{
		Class749.smethod_1("SnapTapKeys", string_1.ToString(), this.string_0);
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x00016C5F File Offset: 0x00014E5F
	private List<Class752.Class664> method_4()
	{
		return this.list_0;
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x00016C67 File Offset: 0x00014E67
	private void method_5(List<Class752.Class664> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x060022BA RID: 8890 RVA: 0x0008A050 File Offset: 0x00088250
	public List<Class752.Class664> PowerSchemes
	{
		get
		{
			if (this.method_4() != null)
			{
				return this.method_4();
			}
			this.method_5(new List<Class752.Class664>());
			try
			{
				GClass250.smethod_4().ToList<Guid>().ForEach(new Action<Guid>(this.method_6));
			}
			catch
			{
			}
			finally
			{
				this.method_4().Add(new Class752.Class664
				{
					Name = Class298.smethod_2("disabled"),
					Guid = string.Empty
				});
			}
			return this.method_4();
		}
	}

	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x060022BB RID: 8891 RVA: 0x00016C70 File Offset: 0x00014E70
	// (set) Token: 0x060022BC RID: 8892 RVA: 0x00016CAE File Offset: 0x00014EAE
	public Class752.Class664 PSGaming
	{
		get
		{
			if (this.PowerSchemes.Any(new Func<Class752.Class664, bool>(this.method_7)))
			{
				return this.PowerSchemes.First(new Func<Class752.Class664, bool>(this.method_8));
			}
			return this.PowerSchemes.Last<Class752.Class664>();
		}
		set
		{
			Class749.smethod_1("PSGaming", value.Guid.ToString(), this.string_0);
		}
	}

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x060022BD RID: 8893 RVA: 0x00016CCC File Offset: 0x00014ECC
	// (set) Token: 0x060022BE RID: 8894 RVA: 0x00016D0A File Offset: 0x00014F0A
	public Class752.Class664 PSGameOff
	{
		get
		{
			if (this.PowerSchemes.Any(new Func<Class752.Class664, bool>(this.method_9)))
			{
				return this.PowerSchemes.First(new Func<Class752.Class664, bool>(this.method_10));
			}
			return this.PowerSchemes.Last<Class752.Class664>();
		}
		set
		{
			Class749.smethod_1("PSGameOff", value.Guid.ToString(), this.string_0);
		}
	}

	// Token: 0x060022BF RID: 8895 RVA: 0x00016D28 File Offset: 0x00014F28
	private void method_6(Guid guid_0)
	{
		this.method_4().Add(new Class752.Class664
		{
			Name = GClass250.smethod_3(guid_0),
			Guid = guid_0.ToString()
		});
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x00016D59 File Offset: 0x00014F59
	private bool method_7(Class752.Class664 class664_0)
	{
		return class664_0.Guid == Class749.smethod_0("PSGaming", this.string_0);
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x00016D59 File Offset: 0x00014F59
	private bool method_8(Class752.Class664 class664_0)
	{
		return class664_0.Guid == Class749.smethod_0("PSGaming", this.string_0);
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x00016D77 File Offset: 0x00014F77
	private bool method_9(Class752.Class664 class664_0)
	{
		return class664_0.Guid == Class749.smethod_0("PSGameOff", this.string_0);
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x00016D77 File Offset: 0x00014F77
	private bool method_10(Class752.Class664 class664_0)
	{
		return class664_0.Guid == Class749.smethod_0("PSGameOff", this.string_0);
	}

	// Token: 0x040016FE RID: 5886
	private string string_0 = "GameModeX";

	// Token: 0x040016FF RID: 5887
	private List<Class752.Class664> list_0;

	// Token: 0x02000568 RID: 1384
	public sealed class Class664
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00016D95 File Offset: 0x00014F95
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00016D9D File Offset: 0x00014F9D
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00016DA6 File Offset: 0x00014FA6
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x00016DAE File Offset: 0x00014FAE
		public string Guid
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x04001700 RID: 5888
		private string string_0;

		// Token: 0x04001701 RID: 5889
		private string string_1;
	}

	// Token: 0x02000569 RID: 1385
	private sealed class Class665
	{
		// Token: 0x060022CA RID: 8906 RVA: 0x00016DB7 File Offset: 0x00014FB7
		internal void method_0(string string_0)
		{
			this.observableCollection_0.Add(new Class499(string_0));
		}

		// Token: 0x04001702 RID: 5890
		public ObservableCollection<Class499> observableCollection_0;
	}

	// Token: 0x0200056A RID: 1386
	private sealed class Class666
	{
		// Token: 0x060022CC RID: 8908 RVA: 0x00016DCA File Offset: 0x00014FCA
		internal void method_0(string string_0)
		{
			this.observableCollection_0.Add(new Class500(string_0));
		}

		// Token: 0x04001703 RID: 5891
		public ObservableCollection<Class500> observableCollection_0;
	}
}
