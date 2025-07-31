using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

// Token: 0x0200047B RID: 1147
internal sealed class Class546
{
	// Token: 0x06001DB8 RID: 7608 RVA: 0x0007B93C File Offset: 0x00079B3C
	private Class546()
	{
		this.list_2 = new List<ServiceController>();
		this.list_3 = new List<ServiceController>();
		this.list_4 = new List<ServiceController>();
		this.list_0 = new List<GClass165>();
		this.list_1 = new List<GClass165>();
		this.list_5 = new List<GClass189>();
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x0007B9A8 File Offset: 0x00079BA8
	public static Class546 smethod_0()
	{
		if (Class546.class546_0 == null)
		{
			object obj = Class546.object_0;
			lock (obj)
			{
				if (Class546.class546_0 == null)
				{
					Class546.class546_0 = new Class546();
				}
			}
		}
		return Class546.class546_0;
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x00013A2F File Offset: 0x00011C2F
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x00013A37 File Offset: 0x00011C37
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x0007BA00 File Offset: 0x00079C00
	public void method_2()
	{
		this.list_1.Clear();
		this.list_0.Clear();
		foreach (ServiceController serviceController_ in ServiceController.GetServices())
		{
			this.list_0.Add(new GClass165(serviceController_));
		}
	}

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00013A40 File Offset: 0x00011C40
	public List<ServiceController> Services
	{
		get
		{
			return this.list_2;
		}
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x00013A48 File Offset: 0x00011C48
	public List<ServiceController> method_3()
	{
		return this.list_3;
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x00013A50 File Offset: 0x00011C50
	public List<ServiceController> method_4()
	{
		this.list_4.Clear();
		this.list_4.AddRange(this.list_2);
		this.list_4.AddRange(this.list_3);
		return this.list_4;
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x00013A85 File Offset: 0x00011C85
	private void method_5()
	{
		this.list_2.Clear();
		this.list_2.AddRange(ServiceController.GetServices());
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x00013AA2 File Offset: 0x00011CA2
	private void method_6()
	{
		this.list_3.Clear();
		this.list_3.AddRange(ServiceController.GetDevices());
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x00013ABF File Offset: 0x00011CBF
	private void method_7()
	{
		this.method_5();
		this.method_6();
		this.method_10();
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x0007BA4C File Offset: 0x00079C4C
	public List<GClass184> method_8()
	{
		object obj = this.object_1;
		List<GClass184> result;
		lock (obj)
		{
			Class546.Class548 @class = new Class546.Class548();
			this.method_7();
			@class.func_0 = this.method_12();
			List<GClass184> list = new List<GClass184>();
			foreach (GClass189 gclass189_ in this.method_9())
			{
				GClass184 gclass = new GClass184(gclass189_)
				{
					EnableParents = false
				};
				@class.method_0(gclass);
				list.Add(gclass);
			}
			result = list;
		}
		return result;
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x00013AD3 File Offset: 0x00011CD3
	private List<GClass189> method_9()
	{
		return this.list_5;
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x0007BB04 File Offset: 0x00079D04
	private void method_10()
	{
		List<GClass189> list = new List<GClass189>();
		List<ServiceController> list2 = this.method_4();
		this.method_1(GClass219.smethod_15(list2));
		Dictionary<string, ServiceController> dictionary = list2.ToDictionary(new Func<ServiceController, string>(Class546.Class549.class549_0.method_0));
		Dictionary<string, GClass189> dictionary2 = new Dictionary<string, GClass189>();
		foreach (ServiceController serviceController in list2)
		{
			try
			{
				GClass189 value = new GClass189(new GClass165(serviceController));
				dictionary2[serviceController.ServiceName] = value;
			}
			catch
			{
			}
		}
		foreach (string key in dictionary.Keys.ToList<string>())
		{
			try
			{
				ServiceController serviceController2 = dictionary[key];
				GClass189 gclass;
				if (dictionary2.TryGetValue(key, out gclass))
				{
					list.Add(gclass);
					foreach (ServiceController serviceController3 in serviceController2.ServicesDependedOn)
					{
						GClass189 gclass2;
						if (GClass219.smethod_13(serviceController3) && dictionary2.TryGetValue(serviceController3.ServiceName, out gclass2))
						{
							gclass.DependOn.Add(gclass2);
							gclass2.DependenciesTree.Add(gclass);
						}
					}
					foreach (ServiceController serviceController4 in serviceController2.DependentServices)
					{
						GClass189 item;
						if (GClass219.smethod_13(serviceController4) && dictionary2.TryGetValue(serviceController4.ServiceName, out item))
						{
							gclass.DependenciesLinear.Add(item);
						}
					}
				}
			}
			catch
			{
			}
		}
		this.list_5.Clear();
		this.list_5.AddRange(list);
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x0007BCF0 File Offset: 0x00079EF0
	private Dictionary<string, string> method_11()
	{
		Dictionary<string, string> result;
		if ((result = this.dictionary_0) == null)
		{
			result = (this.dictionary_0 = GClass219.smethod_19());
		}
		return result;
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x00013ADB File Offset: 0x00011CDB
	private Func<string, string> method_12()
	{
		return new Func<string, string>(this.method_17);
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x0007BD18 File Offset: 0x00079F18
	public void method_13()
	{
		this.list_1.Clear();
		using (List<string>.Enumerator enumerator = GClass260.gclass211_0.Services.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class546.Class547 @class = new Class546.Class547();
				@class.string_0 = enumerator.Current;
				try
				{
					GClass165 gclass = this.list_0.FirstOrDefault(new Func<GClass165, bool>(@class.method_0));
					if (gclass != null)
					{
						ServiceStartMode? defaultStartMode = gclass.DefaultStartMode;
						ServiceStartMode currentStartMode = gclass.CurrentStartMode;
						if (defaultStartMode.GetValueOrDefault() == currentStartMode & defaultStartMode != null)
						{
							this.method_16(gclass.ServiceName);
						}
						else
						{
							if (!this.list_1.Contains(gclass))
							{
								this.list_1.Add(gclass);
							}
							this.method_15(gclass.ServiceName, gclass.DefaultStartMode);
						}
					}
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x0007BE10 File Offset: 0x0007A010
	public void method_14()
	{
		try
		{
			foreach (GClass165 gclass in this.list_1)
			{
				this.method_15(gclass.ServiceName, new ServiceStartMode?(gclass.CurrentStartMode));
			}
			this.list_1.Clear();
		}
		catch
		{
		}
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x0007BE90 File Offset: 0x0007A090
	public void method_15(string string_1, ServiceStartMode? nullable_0)
	{
		if (nullable_0 == null)
		{
			return;
		}
		string text;
		if (nullable_0 != null)
		{
			ServiceStartMode valueOrDefault = nullable_0.GetValueOrDefault();
			if (valueOrDefault == ServiceStartMode.Automatic)
			{
				text = "auto";
				goto IL_3C;
			}
			if (valueOrDefault == ServiceStartMode.Manual)
			{
				text = "demand";
				goto IL_3C;
			}
		}
		text = "disabled";
		IL_3C:
		string str = text;
		GClass290.smethod_0("cmd.exe /c sc config " + string_1 + " start= " + str, false);
		if (nullable_0.GetValueOrDefault() != ServiceStartMode.Disabled)
		{
			GClass290.smethod_0("cmd.exe /c net start " + string_1, false);
			return;
		}
		GClass290.smethod_0("cmd.exe /c sc stop " + string_1, false);
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x00013AE9 File Offset: 0x00011CE9
	public void method_16(string string_1)
	{
		GClass290.smethod_0("cmd.exe /c net start " + string_1, false);
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x0007BF28 File Offset: 0x0007A128
	private string method_17(string string_1)
	{
		string result;
		if (!this.method_11().TryGetValue(string_1, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x040013D8 RID: 5080
	private static readonly object object_0 = new object();

	// Token: 0x040013D9 RID: 5081
	private static Class546 class546_0;

	// Token: 0x040013DA RID: 5082
	private readonly List<GClass165> list_0;

	// Token: 0x040013DB RID: 5083
	private readonly List<GClass165> list_1;

	// Token: 0x040013DC RID: 5084
	private string string_0 = string.Empty;

	// Token: 0x040013DD RID: 5085
	private readonly List<ServiceController> list_2;

	// Token: 0x040013DE RID: 5086
	private readonly List<ServiceController> list_3;

	// Token: 0x040013DF RID: 5087
	private readonly List<ServiceController> list_4;

	// Token: 0x040013E0 RID: 5088
	private object object_1 = new object();

	// Token: 0x040013E1 RID: 5089
	private readonly List<GClass189> list_5;

	// Token: 0x040013E2 RID: 5090
	private Dictionary<string, string> dictionary_0;

	// Token: 0x0200047C RID: 1148
	private sealed class Class547
	{
		// Token: 0x06001DCF RID: 7631 RVA: 0x00013AFE File Offset: 0x00011CFE
		internal bool method_0(GClass165 gclass165_0)
		{
			return GClass219.smethod_18(gclass165_0.ServiceName).ToLower() == this.string_0.ToLower();
		}

		// Token: 0x040013E3 RID: 5091
		public string string_0;
	}

	// Token: 0x0200047D RID: 1149
	private sealed class Class548
	{
		// Token: 0x06001DD1 RID: 7633 RVA: 0x00013B20 File Offset: 0x00011D20
		internal void method_0(GClass184 gclass184_0)
		{
			gclass184_0.Description = this.func_0(gclass184_0.ServiceName);
			gclass184_0.DependenciesTree.ForEach(new Action<GClass184>(this.method_0));
		}

		// Token: 0x040013E4 RID: 5092
		public Func<string, string> func_0;
	}

	// Token: 0x0200047E RID: 1150
	[Serializable]
	private sealed class Class549
	{
		// Token: 0x06001DD4 RID: 7636 RVA: 0x00013B5C File Offset: 0x00011D5C
		internal string method_0(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName;
		}

		// Token: 0x040013E5 RID: 5093
		public static readonly Class546.Class549 class549_0 = new Class546.Class549();

		// Token: 0x040013E6 RID: 5094
		public static Func<ServiceController, string> func_0;
	}
}
