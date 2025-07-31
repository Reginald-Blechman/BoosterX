using System;
using System.Windows.Controls;
using ns0;

// Token: 0x0200060D RID: 1549
internal sealed class Class526 : GClass162
{
	// Token: 0x0600276F RID: 10095 RVA: 0x0001A2C4 File Offset: 0x000184C4
	public Class526(Frame frame_1)
	{
		this.frame_0 = frame_1;
		this.AutoexecCommand.Execute(null);
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x0001A2DF File Offset: 0x000184DF
	private void method_2()
	{
		Class406.smethod_0().method_4(typeof(dje_zF9YLL4YM7YMKTBYTMEKK8F8U5CAEBSS5CSHERDW92HQT7TXCFTEK7QHWPQGQ_ejd), this.frame_0);
	}

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x06002771 RID: 10097 RVA: 0x0009A96C File Offset: 0x00098B6C
	public GClass280 AutoexecCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_3), null));
			}
			return result;
		}
	}

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x06002772 RID: 10098 RVA: 0x0009A9A0 File Offset: 0x00098BA0
	public GClass280 LauchOptionsCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_4), null));
			}
			return result;
		}
	}

	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x06002773 RID: 10099 RVA: 0x0009A9D4 File Offset: 0x00098BD4
	public GClass280 BackCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(Class526.Class743.class743_0.method_0), null));
			}
			return result;
		}
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x0001A2FB File Offset: 0x000184FB
	private void method_3(object object_0)
	{
		if (!Class328.smethod_0())
		{
			this.method_2();
		}
		Class406.smethod_0().method_4(typeof(dje_zRG7M2VFCRP7RM6XYKG5ZABP7DAP3LGZCX4MTQBNQJNPQZPSRAKJ9ECE3PFKRGPG4KW_ejd), this.frame_0);
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x0001A324 File Offset: 0x00018524
	private void method_4(object object_0)
	{
		if (!Class328.smethod_0())
		{
			this.method_2();
		}
		Class406.smethod_0().method_4(typeof(dje_zH5YLBSZL4F2PHBSJNM6UDEJ8YG5WWX9QCB9XV3RHBY8FRM53VHM7HB27QDH2R48KNA_ejd), this.frame_0);
	}

	// Token: 0x04001A07 RID: 6663
	private Frame frame_0;

	// Token: 0x04001A08 RID: 6664
	private GClass280 gclass280_0;

	// Token: 0x04001A09 RID: 6665
	private GClass280 gclass280_1;

	// Token: 0x04001A0A RID: 6666
	private GClass280 gclass280_2;

	// Token: 0x0200060E RID: 1550
	[Serializable]
	private sealed class Class743
	{
		// Token: 0x06002778 RID: 10104 RVA: 0x00007C85 File Offset: 0x00005E85
		internal void method_0(object object_0)
		{
			Class406.smethod_0().method_4(typeof(dje_z5N7EUTRT9STESYFN23F9VDWQW2GLETFX7ZTL7JUY4GQS6HZ_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x04001A0B RID: 6667
		public static readonly Class526.Class743 class743_0 = new Class526.Class743();

		// Token: 0x04001A0C RID: 6668
		public static Action<object> action_0;
	}
}
