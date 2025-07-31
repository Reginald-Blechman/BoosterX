using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000603 RID: 1539
internal static class Class733
{
	// Token: 0x06002749 RID: 10057 RVA: 0x0001A183 File Offset: 0x00018383
	// Note: this type is marked as 'beforefieldinit'.
	static Class733()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "agAI_Za-ie", null);
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x0001A19A File Offset: 0x0001839A
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool smethod_0()
	{
		return (Volatile.Read(ref Class733.int_1) ^ Class733.int_0) == 1;
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x00099E08 File Offset: 0x00098008
	internal static void smethod_1(bool bool_0)
	{
		object[] object_ = new object[]
		{
			bool_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "EO<-\\Za-if", object_);
	}

	// Token: 0x040019F8 RID: 6648
	private static int int_0;

	// Token: 0x040019F9 RID: 6649
	private static int int_1;
}
