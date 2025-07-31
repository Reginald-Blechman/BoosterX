using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x020006E9 RID: 1769
internal sealed class Class859
{
	// Token: 0x17000746 RID: 1862
	// (get) Token: 0x06002C53 RID: 11347 RVA: 0x0001C840 File Offset: 0x0001AA40
	// (set) Token: 0x06002C54 RID: 11348 RVA: 0x0001C848 File Offset: 0x0001AA48
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

	// Token: 0x06002C55 RID: 11349 RVA: 0x0001C851 File Offset: 0x0001AA51
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x0001C859 File Offset: 0x0001AA59
	public void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x17000747 RID: 1863
	// (get) Token: 0x06002C57 RID: 11351 RVA: 0x000AA0C8 File Offset: 0x000A82C8
	public string TickName
	{
		get
		{
			return this.method_0().ToString() + " tick";
		}
	}

	// Token: 0x17000748 RID: 1864
	// (get) Token: 0x06002C58 RID: 11352 RVA: 0x0001C862 File Offset: 0x0001AA62
	// (set) Token: 0x06002C59 RID: 11353 RVA: 0x0001C86A File Offset: 0x0001AA6A
	public BitmapSource Icon
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

	// Token: 0x04001CC7 RID: 7367
	private string string_0;

	// Token: 0x04001CC8 RID: 7368
	private int int_0;

	// Token: 0x04001CC9 RID: 7369
	private BitmapSource bitmapSource_0;
}
