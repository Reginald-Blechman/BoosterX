using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020002D4 RID: 724
public sealed class GClass177 : GClass162
{
	// Token: 0x0600132D RID: 4909 RVA: 0x00060B38 File Offset: 0x0005ED38
	public GClass177(KeyValuePair<string, string> keyValuePair_0)
	{
		this.Name = keyValuePair_0.Key;
		this.ID = keyValuePair_0.Value;
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x0600132E RID: 4910 RVA: 0x0000D97D File Offset: 0x0000BB7D
	public string FullName
	{
		get
		{
			return this.Name + " [ID:" + this.ID + "]";
		}
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x0600132F RID: 4911 RVA: 0x0000D99C File Offset: 0x0000BB9C
	// (set) Token: 0x06001330 RID: 4912 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x06001331 RID: 4913 RVA: 0x0000D9B9 File Offset: 0x0000BBB9
	// (set) Token: 0x06001332 RID: 4914 RVA: 0x0000D9C1 File Offset: 0x0000BBC1
	public string ID
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("ID");
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x06001333 RID: 4915 RVA: 0x0000D9D6 File Offset: 0x0000BBD6
	public GClass172 Autoexec
	{
		get
		{
			if (this.gclass172_0 != null)
			{
				return this.gclass172_0;
			}
			this.gclass172_0 = new GClass172(GClass22.smethod_0().method_3() + "\\game\\csgo\\cfg\\autoexec.cfg");
			return this.gclass172_0;
		}
	}

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x06001334 RID: 4916 RVA: 0x0000DA0D File Offset: 0x0000BC0D
	public List<GClass166> GroupCommands
	{
		get
		{
			if (this.list_0 != null)
			{
				return this.list_0;
			}
			this.list_0 = this.method_5(this.Autoexec);
			return this.list_0;
		}
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x06001335 RID: 4917 RVA: 0x0000DA36 File Offset: 0x0000BC36
	// (set) Token: 0x06001336 RID: 4918 RVA: 0x0000DA4F File Offset: 0x0000BC4F
	public string CSGOLaunchOptions
	{
		get
		{
			return this.method_2().Replace("  ", " ");
		}
		set
		{
			this.method_3(value);
			base.method_0("CSGOLaunchOptions");
		}
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00060BAC File Offset: 0x0005EDAC
	private string method_2()
	{
		if (this.class192_0 == null)
		{
			this.class192_0 = new Class192(GClass22.smethod_0().method_5() + "\\userdata\\" + this.ID + "\\config\\localconfig.vdf").method_1();
		}
		FileStream fileStream = new FileStream(GClass22.smethod_0().method_5() + "\\userdata\\" + this.ID + "\\config\\localconfig.vdf", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		try
		{
			StreamReader streamReader = new StreamReader(fileStream);
			try
			{
				if (streamReader.ReadToEnd().Contains("\"steam\""))
				{
					this.list_1[2] = "steam";
				}
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
		try
		{
			if (this.class192_0.method_3(this.list_1, "LaunchOptions") == null)
			{
				try
				{
					this.class192_0.method_4(this.list_1, "LaunchOptions", string.Empty).method_5();
				}
				catch
				{
					return string.Empty;
				}
			}
		}
		catch
		{
		}
		return this.class192_0.method_3(this.list_1, "LaunchOptions").TrimEnd(new char[]
		{
			' '
		}).TrimStart(new char[]
		{
			' '
		});
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x00060D10 File Offset: 0x0005EF10
	private void method_3(string string_2)
	{
		try
		{
			this.class192_0.method_4(this.list_1, "LaunchOptions", string_2).method_5();
		}
		catch
		{
		}
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x06001339 RID: 4921 RVA: 0x0000DA64 File Offset: 0x0000BC64
	public List<GClass196> CSGOLaunchOptionsVMs
	{
		get
		{
			if (this.list_2 != null)
			{
				return this.list_2;
			}
			this.list_2 = this.method_4(this);
			return this.list_2;
		}
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x00060D50 File Offset: 0x0005EF50
	public List<GClass196> method_4(GClass177 gclass177_0)
	{
		return new List<GClass196>
		{
			new GClass196(gclass177_0)
			{
				Name = "startupscreen",
				Icon = 5115,
				Param = "-novid"
			},
			new GClass196(gclass177_0)
			{
				Name = "limitparticles",
				Icon = 2508,
				Param = "-particles 512"
			},
			new GClass196(gclass177_0)
			{
				Name = "joysticksupport",
				Icon = 3443,
				Param = "-nojoy"
			},
			new GClass196(gclass177_0)
			{
				Name = "englishlang",
				Icon = 3,
				Param = "-language english"
			},
			new GClass196(gclass177_0)
			{
				Name = "openconsole",
				Icon = 2086,
				Param = "-console"
			},
			new GClass196(gclass177_0)
			{
				Name = "3partysoftware",
				Icon = 5055,
				Param = "-allow_third_party_software"
			}
		};
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x00060E78 File Offset: 0x0005F078
	public List<GClass166> method_5(GClass172 gclass172_1)
	{
		return new List<GClass166>
		{
			new GClass166(gclass172_1)
			{
				Name = "SPUNJBinds",
				Icon = 7280,
				CVars = new List<GClass137>
				{
					new GClass137("bind d \"+right;\""),
					new GClass137("bind a \"+left;\""),
					new GClass137("bind w \"+forward;\""),
					new GClass137("bind s \"+back;\""),
					new GClass137("bind ctrl \"+duck;\""),
					new GClass137("bind shift \"+sprint;\"")
				}
			}
		};
	}

	// Token: 0x04000C00 RID: 3072
	private string string_0;

	// Token: 0x04000C01 RID: 3073
	private string string_1;

	// Token: 0x04000C02 RID: 3074
	private GClass172 gclass172_0;

	// Token: 0x04000C03 RID: 3075
	private List<GClass166> list_0;

	// Token: 0x04000C04 RID: 3076
	private List<string> list_1 = new List<string>
	{
		"Software",
		"Valve",
		"Steam",
		"apps",
		"730"
	};

	// Token: 0x04000C05 RID: 3077
	private Class192 class192_0;

	// Token: 0x04000C06 RID: 3078
	private List<GClass196> list_2;
}
