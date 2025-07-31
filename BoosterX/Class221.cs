using System;
using System.Windows;

// Token: 0x020001CC RID: 460
internal sealed class Class221
{
	// Token: 0x06000CBF RID: 3263 RVA: 0x0004CBBC File Offset: 0x0004ADBC
	public static GClass182 smethod_0(bool bool_1)
	{
		if (!Class221.bool_0 || bool_1)
		{
			Class221.bool_0 = true;
			Application.Current.Dispatcher.Invoke(new Action(Class221.Class222.class222_0.method_0));
		}
		return Class221.gclass182_0;
	}

	// Token: 0x0400082B RID: 2091
	private static GClass182 gclass182_0;

	// Token: 0x0400082C RID: 2092
	private static bool bool_0;

	// Token: 0x020001CD RID: 461
	[Serializable]
	private sealed class Class222
	{
		// Token: 0x06000CC2 RID: 3266 RVA: 0x00009BD1 File Offset: 0x00007DD1
		internal void method_0()
		{
			Class221.gclass182_0 = new GClass182();
		}

		// Token: 0x0400082D RID: 2093
		public static readonly Class221.Class222 class222_0 = new Class221.Class222();

		// Token: 0x0400082E RID: 2094
		public static Action action_0;
	}
}
