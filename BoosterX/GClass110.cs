using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000339 RID: 825
public static class GClass110
{
	// Token: 0x06001567 RID: 5479 RVA: 0x0000EC0E File Offset: 0x0000CE0E
	public static void smethod_0<T>(this IEnumerable<T> ienumerable_0, Action<T> action_0)
	{
		ienumerable_0.smethod_1(action_0, new Func<T, bool>(GClass110.Class391<T>.class391_0.method_0));
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x0006565C File Offset: 0x0006385C
	public static void smethod_1<T>(this IEnumerable<T> ienumerable_0, Action<T> action_0, Func<T, bool> func_0)
	{
		ienumerable_0 = ienumerable_0.Where(func_0);
		for (int i = 0; i < ienumerable_0.Count<T>(); i++)
		{
			action_0(ienumerable_0.ElementAt(i));
		}
	}

	// Token: 0x0200033A RID: 826
	[Serializable]
	private sealed class Class391<T>
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x00003982 File Offset: 0x00001B82
		internal bool method_0(T gparam_0)
		{
			return true;
		}

		// Token: 0x04000E43 RID: 3651
		public static readonly GClass110.Class391<T> class391_0 = new GClass110.Class391<T>();

		// Token: 0x04000E44 RID: 3652
		public static Func<T, bool> func_0;
	}
}
