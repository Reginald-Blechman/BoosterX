using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using ns0;

// Token: 0x020006AF RID: 1711
internal sealed class Class531 : GClass162
{
	// Token: 0x06002B22 RID: 11042 RVA: 0x000A66F8 File Offset: 0x000A48F8
	public Class531(Class254 class254_1)
	{
		this.class254_0 = class254_1;
		this.class322_0 = class254_1.Contents.FirstOrDefault(new Func<Class322, bool>(Class531.Class832.class832_0.method_0));
		base.method_0(".ctor");
	}

	// Token: 0x17000711 RID: 1809
	// (get) Token: 0x06002B23 RID: 11043 RVA: 0x000A6750 File Offset: 0x000A4950
	public string DateCreated
	{
		get
		{
			DateTime dateCreated = this.class254_0.DateCreated;
			return this.class254_0.DateCreated.ToString("dd/MM/yyyy").Replace('/', '.');
		}
	}

	// Token: 0x17000712 RID: 1810
	// (get) Token: 0x06002B24 RID: 11044 RVA: 0x0001BDFD File Offset: 0x00019FFD
	public string Name
	{
		get
		{
			if (this.class254_0.Name != null && this.class254_0.Name != string.Empty)
			{
				return this.class254_0.Name;
			}
			return "UPDATE";
		}
	}

	// Token: 0x17000713 RID: 1811
	// (get) Token: 0x06002B25 RID: 11045 RVA: 0x0001BE35 File Offset: 0x0001A035
	public string Creator
	{
		get
		{
			if (this.class254_0.Creator != null && this.class254_0.Creator != string.Empty)
			{
				return this.class254_0.Creator;
			}
			return "Developer";
		}
	}

	// Token: 0x17000714 RID: 1812
	// (get) Token: 0x06002B26 RID: 11046 RVA: 0x0001BE6D File Offset: 0x0001A06D
	public string Content
	{
		get
		{
			if (this.class322_0 != null && this.class322_0.Content != string.Empty)
			{
				return this.class322_0.Content;
			}
			return Class298.smethod_2("unknownerror");
		}
	}

	// Token: 0x17000715 RID: 1813
	// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000A678C File Offset: 0x000A498C
	public SolidColorBrush Color
	{
		get
		{
			if (this.class322_0 != null && this.class322_0.Color != null && this.class322_0.Color != string.Empty)
			{
				return new SolidColorBrush((Color)ColorConverter.ConvertFromString(this.class322_0.Color));
			}
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd;
		}
	}

	// Token: 0x17000716 RID: 1814
	// (get) Token: 0x06002B28 RID: 11048 RVA: 0x0001BEA5 File Offset: 0x0001A0A5
	// (set) Token: 0x06002B29 RID: 11049 RVA: 0x0001BEAD File Offset: 0x0001A0AD
	public Visibility ButtonsVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("ButtonsVisibility");
		}
	}

	// Token: 0x17000717 RID: 1815
	// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000A67E8 File Offset: 0x000A49E8
	public List<Class530> Buttons
	{
		get
		{
			Class531.Class831 @class = new Class531.Class831();
			if (this.class254_0.Buttons != null && this.class254_0.Buttons.Count<Class465>() != 0)
			{
				@class.list_0 = new List<Class530>();
				this.class254_0.Buttons.ForEach(new Action<Class465>(@class.method_0));
				return @class.list_0;
			}
			this.visibility_0 = Visibility.Collapsed;
			return new List<Class530>();
		}
	}

	// Token: 0x04001C11 RID: 7185
	private readonly Class254 class254_0;

	// Token: 0x04001C12 RID: 7186
	private readonly Class322 class322_0;

	// Token: 0x04001C13 RID: 7187
	private Visibility visibility_0;

	// Token: 0x020006B0 RID: 1712
	private sealed class Class831
	{
		// Token: 0x06002B2C RID: 11052 RVA: 0x0001BEC2 File Offset: 0x0001A0C2
		internal void method_0(Class465 class465_0)
		{
			this.list_0.Add(new Class530(class465_0));
		}

		// Token: 0x04001C14 RID: 7188
		public List<Class530> list_0;
	}

	// Token: 0x020006B1 RID: 1713
	[Serializable]
	private sealed class Class832
	{
		// Token: 0x06002B2F RID: 11055 RVA: 0x0001BEE1 File Offset: 0x0001A0E1
		internal bool method_0(Class322 class322_0)
		{
			return class322_0.Language == Class298.smethod_2("CurrentLocalization");
		}

		// Token: 0x04001C15 RID: 7189
		public static readonly Class531.Class832 class832_0 = new Class531.Class832();

		// Token: 0x04001C16 RID: 7190
		public static Func<Class322, bool> func_0;
	}
}
