using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x02000680 RID: 1664
public sealed class GClass193 : GClass162
{
	// Token: 0x06002A21 RID: 10785 RVA: 0x0001B7C6 File Offset: 0x000199C6
	public GClass193()
	{
		this.AppXStatus = Class298.smethod_2("OnQueue");
	}

	// Token: 0x170006F0 RID: 1776
	// (get) Token: 0x06002A22 RID: 10786 RVA: 0x0001B7DF File Offset: 0x000199DF
	// (set) Token: 0x06002A23 RID: 10787 RVA: 0x0001B7E7 File Offset: 0x000199E7
	public int AppXID
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x170006F1 RID: 1777
	// (get) Token: 0x06002A24 RID: 10788 RVA: 0x0001B7F0 File Offset: 0x000199F0
	// (set) Token: 0x06002A25 RID: 10789 RVA: 0x0001B7F8 File Offset: 0x000199F8
	public string AppXName
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

	// Token: 0x170006F2 RID: 1778
	// (get) Token: 0x06002A26 RID: 10790 RVA: 0x0001B801 File Offset: 0x00019A01
	// (set) Token: 0x06002A27 RID: 10791 RVA: 0x0001B809 File Offset: 0x00019A09
	public string AppXUri
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

	// Token: 0x170006F3 RID: 1779
	// (get) Token: 0x06002A28 RID: 10792 RVA: 0x0001B812 File Offset: 0x00019A12
	// (set) Token: 0x06002A29 RID: 10793 RVA: 0x0001B81A File Offset: 0x00019A1A
	public string AppXAverageRating
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x170006F4 RID: 1780
	// (get) Token: 0x06002A2A RID: 10794 RVA: 0x0001B823 File Offset: 0x00019A23
	// (set) Token: 0x06002A2B RID: 10795 RVA: 0x0001B82B File Offset: 0x00019A2B
	public string AppXProductID
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("AppXProductID");
		}
	}

	// Token: 0x170006F5 RID: 1781
	// (get) Token: 0x06002A2C RID: 10796 RVA: 0x0001B840 File Offset: 0x00019A40
	// (set) Token: 0x06002A2D RID: 10797 RVA: 0x0001B848 File Offset: 0x00019A48
	public bool AppXIsChecked
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("AppXIsChecked");
		}
	}

	// Token: 0x170006F6 RID: 1782
	// (get) Token: 0x06002A2E RID: 10798 RVA: 0x0001B85D File Offset: 0x00019A5D
	// (set) Token: 0x06002A2F RID: 10799 RVA: 0x0001B865 File Offset: 0x00019A65
	public string AppXStatus
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("AppXStatus");
		}
	}

	// Token: 0x170006F7 RID: 1783
	// (get) Token: 0x06002A30 RID: 10800 RVA: 0x0001B87A File Offset: 0x00019A7A
	// (set) Token: 0x06002A31 RID: 10801 RVA: 0x0001B882 File Offset: 0x00019A82
	public BitmapSource AppXIcon
	{
		[CompilerGenerated]
		get
		{
			return this.bitmapSource_0;
		}
		[CompilerGenerated]
		set
		{
			this.bitmapSource_0 = value;
		}
	}

	// Token: 0x06002A32 RID: 10802 RVA: 0x0001B88B File Offset: 0x00019A8B
	private string method_2()
	{
		return this.string_5;
	}

	// Token: 0x06002A33 RID: 10803 RVA: 0x0001B893 File Offset: 0x00019A93
	private void method_3(string string_6)
	{
		this.string_5 = string_6;
	}

	// Token: 0x170006F8 RID: 1784
	// (get) Token: 0x06002A34 RID: 10804 RVA: 0x0001B89C File Offset: 0x00019A9C
	// (set) Token: 0x06002A35 RID: 10805 RVA: 0x0001B8A4 File Offset: 0x00019AA4
	public string AppXSize
	{
		get
		{
			return this.method_2();
		}
		set
		{
			this.method_3(value);
			base.method_0("AppXSize");
		}
	}

	// Token: 0x04001B91 RID: 7057
	private int int_0;

	// Token: 0x04001B92 RID: 7058
	private string string_0;

	// Token: 0x04001B93 RID: 7059
	private string string_1;

	// Token: 0x04001B94 RID: 7060
	private string string_2;

	// Token: 0x04001B95 RID: 7061
	private string string_3;

	// Token: 0x04001B96 RID: 7062
	private bool bool_0;

	// Token: 0x04001B97 RID: 7063
	private string string_4;

	// Token: 0x04001B98 RID: 7064
	private BitmapSource bitmapSource_0;

	// Token: 0x04001B99 RID: 7065
	private string string_5;
}
