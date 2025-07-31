using System;
using System.Diagnostics;
using System.Windows;

// Token: 0x02000672 RID: 1650
internal sealed class Class530 : GClass162
{
	// Token: 0x06002995 RID: 10645 RVA: 0x0001B3B8 File Offset: 0x000195B8
	public Class530(Class465 class465_1)
	{
		this.class465_0 = class465_1;
	}

	// Token: 0x170006EB RID: 1771
	// (get) Token: 0x06002996 RID: 10646 RVA: 0x0001B3C7 File Offset: 0x000195C7
	public Style Style
	{
		get
		{
			return Class298.smethod_3(this.class465_0.Style);
		}
	}

	// Token: 0x170006EC RID: 1772
	// (get) Token: 0x06002997 RID: 10647 RVA: 0x0001B3D9 File Offset: 0x000195D9
	public string Content
	{
		get
		{
			return Class298.smethod_2(this.class465_0.Name);
		}
	}

	// Token: 0x170006ED RID: 1773
	// (get) Token: 0x06002998 RID: 10648 RVA: 0x000A2A88 File Offset: 0x000A0C88
	public GClass280 Command
	{
		get
		{
			if (this.class465_0.Type == 0)
			{
				return new GClass280(new Action<object>(this.method_2), null);
			}
			if (this.class465_0.Type == 1)
			{
				return new GClass280(new Action<object>(Class530.Class783.class783_0.method_0), null);
			}
			return new GClass280(new Action<object>(Class530.Class783.class783_0.method_1), null);
		}
	}

	// Token: 0x06002999 RID: 10649 RVA: 0x0001B3EB File Offset: 0x000195EB
	private void method_2(object object_0)
	{
		Process.Start(this.class465_0.Content);
	}

	// Token: 0x04001B5D RID: 7005
	private readonly Class465 class465_0;

	// Token: 0x02000673 RID: 1651
	[Serializable]
	private sealed class Class783
	{
		// Token: 0x0600299C RID: 10652 RVA: 0x0000311B File Offset: 0x0000131B
		internal void method_0(object object_0)
		{
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0000311B File Offset: 0x0000131B
		internal void method_1(object object_0)
		{
		}

		// Token: 0x04001B5E RID: 7006
		public static readonly Class530.Class783 class783_0 = new Class530.Class783();

		// Token: 0x04001B5F RID: 7007
		public static Action<object> action_0;

		// Token: 0x04001B60 RID: 7008
		public static Action<object> action_1;
	}
}
