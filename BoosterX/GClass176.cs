using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;

// Token: 0x0200027F RID: 639
public sealed class GClass176 : GClass162
{
	// Token: 0x17000239 RID: 569
	// (get) Token: 0x060010FF RID: 4351 RVA: 0x0000C56B File Offset: 0x0000A76B
	// (set) Token: 0x06001100 RID: 4352 RVA: 0x0000C573 File Offset: 0x0000A773
	public string NameRaw
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

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x06001101 RID: 4353 RVA: 0x0000C57C File Offset: 0x0000A77C
	public string Name
	{
		get
		{
			return this.string_1;
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x06001102 RID: 4354 RVA: 0x0000C584 File Offset: 0x0000A784
	// (set) Token: 0x06001103 RID: 4355 RVA: 0x0000C58C File Offset: 0x0000A78C
	public SolidColorBrush Foreground
	{
		[CompilerGenerated]
		get
		{
			return this.solidColorBrush_0;
		}
		[CompilerGenerated]
		set
		{
			this.solidColorBrush_0 = value;
		}
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x0000C595 File Offset: 0x0000A795
	public void method_2()
	{
		this.string_1 = Class298.smethod_2(this.NameRaw);
		base.method_0("Name");
	}

	// Token: 0x04000AAD RID: 2733
	private string string_0;

	// Token: 0x04000AAE RID: 2734
	public string string_1;

	// Token: 0x04000AAF RID: 2735
	private SolidColorBrush solidColorBrush_0;
}
