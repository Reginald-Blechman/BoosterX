using System;
using System.Collections.Generic;
using System.Linq;
using Material.Icons;

// Token: 0x0200014E RID: 334
public sealed class GClass166 : GClass162
{
	// Token: 0x06000986 RID: 2438 RVA: 0x00007D15 File Offset: 0x00005F15
	public GClass166(GClass172 gclass172_1)
	{
		this.gclass172_0 = gclass172_1;
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000987 RID: 2439 RVA: 0x00007D2B File Offset: 0x00005F2B
	// (set) Token: 0x06000988 RID: 2440 RVA: 0x00007D38 File Offset: 0x00005F38
	public string Name
	{
		get
		{
			return Class298.smethod_2(this.string_0);
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000989 RID: 2441 RVA: 0x00007D4D File Offset: 0x00005F4D
	public string Description
	{
		get
		{
			return Class298.smethod_2(this.string_0 + "Desc");
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x0600098A RID: 2442 RVA: 0x00007D65 File Offset: 0x00005F65
	// (set) Token: 0x0600098B RID: 2443 RVA: 0x00007D6D File Offset: 0x00005F6D
	public bool IsChecked
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
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

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x0600098C RID: 2444 RVA: 0x00007DA2 File Offset: 0x00005FA2
	// (set) Token: 0x0600098D RID: 2445 RVA: 0x00007DAA File Offset: 0x00005FAA
	public List<GClass137> CVars
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
			this.method_4();
			base.method_0("CVars");
		}
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00007DC5 File Offset: 0x00005FC5
	private void method_2()
	{
		this.CVars.ForEach(new Action<GClass137>(this.method_7));
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00007DDE File Offset: 0x00005FDE
	private void method_3()
	{
		this.CVars.ForEach(new Action<GClass137>(this.method_8));
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00045440 File Offset: 0x00043640
	public void method_4()
	{
		GClass166.Class186 @class = new GClass166.Class186();
		@class.list_0 = this.gclass172_0.list_0;
		if (@class.list_0 != null && @class.list_0.Count != 0)
		{
			this.IsChecked = this.CVars.Any(new Func<GClass137, bool>(@class.method_0));
			return;
		}
		this.IsChecked = false;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00007DF7 File Offset: 0x00005FF7
	private MaterialIconKind method_5()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00007DFF File Offset: 0x00005FFF
	private void method_6(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000993 RID: 2451 RVA: 0x00007E08 File Offset: 0x00006008
	// (set) Token: 0x06000994 RID: 2452 RVA: 0x00007E10 File Offset: 0x00006010
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

	// Token: 0x06000995 RID: 2453 RVA: 0x00007E25 File Offset: 0x00006025
	private void method_7(GClass137 gclass137_0)
	{
		this.gclass172_0.method_3(gclass137_0);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00007E33 File Offset: 0x00006033
	private void method_8(GClass137 gclass137_0)
	{
		this.gclass172_0.method_4(gclass137_0);
	}

	// Token: 0x04000677 RID: 1655
	private GClass172 gclass172_0;

	// Token: 0x04000678 RID: 1656
	private string string_0;

	// Token: 0x04000679 RID: 1657
	public bool bool_0 = true;

	// Token: 0x0400067A RID: 1658
	private bool bool_1;

	// Token: 0x0400067B RID: 1659
	private List<GClass137> list_0;

	// Token: 0x0400067C RID: 1660
	private MaterialIconKind materialIconKind_0;

	// Token: 0x0200014F RID: 335
	private sealed class Class186
	{
		// Token: 0x06000998 RID: 2456 RVA: 0x000454A0 File Offset: 0x000436A0
		internal bool method_0(GClass137 gclass137_0)
		{
			GClass166.Class187 @class = new GClass166.Class187();
			@class.gclass137_0 = gclass137_0;
			return this.list_0.Any(new Func<GClass137, bool>(@class.method_0));
		}

		// Token: 0x0400067D RID: 1661
		public List<GClass137> list_0;
	}

	// Token: 0x02000150 RID: 336
	private sealed class Class187
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x00007E41 File Offset: 0x00006041
		internal bool method_0(GClass137 gclass137_1)
		{
			return gclass137_1 == this.gclass137_0;
		}

		// Token: 0x0400067E RID: 1662
		public GClass137 gclass137_0;
	}
}
