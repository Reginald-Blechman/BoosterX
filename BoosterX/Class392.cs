using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200033C RID: 828
internal static class Class392
{
	// Token: 0x06001577 RID: 5495 RVA: 0x0000EC97 File Offset: 0x0000CE97
	public static string smethod_0()
	{
		return "I7uXX+Jd7vu3ficAxhH6IwmHtXhRFEz7OT1tQkexO/584OtZ13iIdIfV+QP5FVhVyJa3amrQZdFCblBvc9d1uzHr4XXMOID8wBAzqNsW1TMFWmGpAAyg9zbo7J41KFgtYnHCsm8AnXMepdOm2MKY28vrLUyFfpDyqpfdj7VTBRE=";
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00065694 File Offset: 0x00063894
	public static Stream smethod_1()
	{
		if (Class392.stream_0 == null)
		{
			Class392.stream_0 = Class118.smethod_0(typeof(Class392).Assembly.GetManifestResourceStream("da89296731c2450d7de6c214f4c8d077"), new byte[]
			{
				171,
				81,
				246,
				65,
				133,
				56,
				0,
				149,
				201,
				141,
				162,
				242,
				107,
				114,
				238,
				53,
				162,
				69,
				111,
				14,
				163,
				177,
				164,
				69,
				56,
				164,
				219,
				178,
				151,
				232,
				64,
				182,
				117,
				196,
				105,
				228,
				135,
				68,
				0,
				199,
				85,
				192,
				78,
				39,
				227,
				146,
				160,
				182,
				59,
				147,
				21,
				122,
				199,
				200,
				10,
				131,
				24,
				167,
				10,
				172,
				45,
				3,
				98,
				192,
				243,
				193,
				1,
				40,
				78,
				90,
				181,
				189,
				191,
				93,
				149,
				101,
				61,
				26,
				99,
				190,
				240,
				17,
				166,
				197,
				212,
				93,
				31,
				44,
				109,
				7,
				85,
				174,
				177,
				22,
				174,
				157,
				133,
				215,
				212,
				195,
				85,
				66,
				34,
				168,
				68,
				56,
				249,
				85,
				129,
				104,
				56,
				81,
				176,
				208,
				237,
				207,
				151,
				74,
				32,
				238,
				47,
				122,
				238,
				251,
				161,
				67,
				210,
				192
			}, Class392.smethod_0());
		}
		return Class392.stream_0;
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x000656EC File Offset: 0x000638EC
	internal static void smethod_2(Class31 class31_0)
	{
		object[] object_ = new object[]
		{
			class31_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "h6s_uZa-j@", object_);
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x0006571C File Offset: 0x0006391C
	[MethodImpl(MethodImplOptions.Synchronized)]
	public static Class31 smethod_3()
	{
		bool flag;
		if (Class392.class41_0 == null)
		{
			Class392.class41_0 = new Class41();
			flag = true;
		}
		Class31 result;
		Class31 @class = result = new Class31(Class392.class41_0);
		if (flag)
		{
			result = @class;
			Class392.smethod_2(@class);
		}
		return result;
	}

	// Token: 0x04000E4A RID: 3658
	private static Class41 class41_0;

	// Token: 0x04000E4B RID: 3659
	[ThreadStatic]
	private static Stream stream_0;

	// Token: 0x04000E4C RID: 3660 RVA: 0x00002E50 File Offset: 0x00001050
	internal static Class392.a1 a1;

	// Token: 0x0200033D RID: 829
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 128)]
	private struct a1
	{
	}
}
