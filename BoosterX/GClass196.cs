using System;
using System.Runtime.CompilerServices;
using Material.Icons;

// Token: 0x020006F6 RID: 1782
public sealed class GClass196 : GClass162
{
	// Token: 0x06002CA5 RID: 11429 RVA: 0x0001CB95 File Offset: 0x0001AD95
	public GClass196(GClass177 gclass177_1)
	{
		this.gclass177_0 = gclass177_1;
	}

	// Token: 0x17000763 RID: 1891
	// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x0001CBAB File Offset: 0x0001ADAB
	// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x0001CBB3 File Offset: 0x0001ADB3
	public string _Name
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

	// Token: 0x17000764 RID: 1892
	// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x0001CBBC File Offset: 0x0001ADBC
	// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x0001CBC9 File Offset: 0x0001ADC9
	public string Name
	{
		get
		{
			return Class298.smethod_2(this._Name);
		}
		set
		{
			this._Name = value;
			base.method_0("Name");
		}
	}

	// Token: 0x17000765 RID: 1893
	// (get) Token: 0x06002CAA RID: 11434 RVA: 0x0001CBDE File Offset: 0x0001ADDE
	public string Description
	{
		get
		{
			return Class298.smethod_2(this._Name + "Desc");
		}
	}

	// Token: 0x17000766 RID: 1894
	// (get) Token: 0x06002CAB RID: 11435 RVA: 0x0001CBF6 File Offset: 0x0001ADF6
	// (set) Token: 0x06002CAC RID: 11436 RVA: 0x0001CBFE File Offset: 0x0001ADFE
	public string _Param
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

	// Token: 0x17000767 RID: 1895
	// (get) Token: 0x06002CAD RID: 11437 RVA: 0x0001CC07 File Offset: 0x0001AE07
	// (set) Token: 0x06002CAE RID: 11438 RVA: 0x0001CC0F File Offset: 0x0001AE0F
	public string Param
	{
		get
		{
			return this._Param;
		}
		set
		{
			this._Param = value;
			this.method_4();
			base.method_0("Param");
		}
	}

	// Token: 0x17000768 RID: 1896
	// (get) Token: 0x06002CAF RID: 11439 RVA: 0x0001CC2A File Offset: 0x0001AE2A
	// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x0001CC32 File Offset: 0x0001AE32
	public bool _IsChecked
	{
		[CompilerGenerated]
		get
		{
			return this.bool_1;
		}
		[CompilerGenerated]
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x17000769 RID: 1897
	// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x0001CC3B File Offset: 0x0001AE3B
	// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x0001CC43 File Offset: 0x0001AE43
	public bool IsChecked
	{
		get
		{
			return this._IsChecked;
		}
		set
		{
			this._IsChecked = value;
			base.method_0("IsChecked");
			if (this.bool_0)
			{
				this.bool_0 = false;
				return;
			}
			if (value)
			{
				this.method_2();
				return;
			}
			this.method_3();
		}
	}

	// Token: 0x06002CB3 RID: 11443 RVA: 0x000AA8D4 File Offset: 0x000A8AD4
	public void method_2()
	{
		if (this.gclass177_0.CSGOLaunchOptions == string.Empty)
		{
			GClass177 gclass = this.gclass177_0;
			gclass.CSGOLaunchOptions += this.Param;
			return;
		}
		GClass177 gclass2 = this.gclass177_0;
		gclass2.CSGOLaunchOptions = gclass2.CSGOLaunchOptions + " " + this.Param;
	}

	// Token: 0x06002CB4 RID: 11444 RVA: 0x000AA938 File Offset: 0x000A8B38
	public void method_3()
	{
		this.gclass177_0.CSGOLaunchOptions = this.gclass177_0.CSGOLaunchOptions.Replace(this.Param, string.Empty);
		if (this.gclass177_0.CSGOLaunchOptions.StartsWith(" "))
		{
			this.gclass177_0.CSGOLaunchOptions.Substring(1);
		}
	}

	// Token: 0x06002CB5 RID: 11445 RVA: 0x0001CC78 File Offset: 0x0001AE78
	public void method_4()
	{
		this.IsChecked = this.gclass177_0.CSGOLaunchOptions.Contains(this.Param);
	}

	// Token: 0x06002CB6 RID: 11446 RVA: 0x0001CC96 File Offset: 0x0001AE96
	private MaterialIconKind method_5()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06002CB7 RID: 11447 RVA: 0x0001CC9E File Offset: 0x0001AE9E
	private void method_6(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x1700076A RID: 1898
	// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x0001CCA7 File Offset: 0x0001AEA7
	// (set) Token: 0x06002CB9 RID: 11449 RVA: 0x0001CCAF File Offset: 0x0001AEAF
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_5();
		}
		set
		{
			this.method_6(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x04001CFC RID: 7420
	private GClass177 gclass177_0;

	// Token: 0x04001CFD RID: 7421
	private string string_0;

	// Token: 0x04001CFE RID: 7422
	private string string_1;

	// Token: 0x04001CFF RID: 7423
	public bool bool_0 = true;

	// Token: 0x04001D00 RID: 7424
	private bool bool_1;

	// Token: 0x04001D01 RID: 7425
	private MaterialIconKind materialIconKind_0;
}
