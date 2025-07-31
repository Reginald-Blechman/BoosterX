using System;
using System.Threading;

// Token: 0x02000099 RID: 153
internal static class Class94
{
	// Token: 0x060004DE RID: 1246 RVA: 0x000054CF File Offset: 0x000036CF
	public static Interface5 smethod_0()
	{
		return Class94.smethod_1() ?? new Class96();
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00037678 File Offset: 0x00035878
	private static Interface5 smethod_1()
	{
		Interface5 result;
		try
		{
			Class12 @class = new Class12();
			if (!Class94.smethod_3(@class))
			{
				@class.Dispose();
				result = null;
			}
			else
			{
				result = @class;
			}
		}
		catch (Exception exception_) when (!Class94.smethod_2(exception_))
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x000054DF File Offset: 0x000036DF
	private static bool smethod_2(Exception exception_0)
	{
		return exception_0 is ThreadAbortException || exception_0 is ThreadInterruptedException;
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x000376D0 File Offset: 0x000358D0
	private static bool smethod_3(Interface5 interface5_0)
	{
		byte[] array = new byte[]
		{
			0,
			130,
			byte.MaxValue
		};
		for (int i = 0; i < array.Length; i++)
		{
			byte b = array[i];
			interface5_0.imethod_2(i, ref b);
		}
		if (interface5_0.imethod_0() != array.Length)
		{
			return false;
		}
		for (int j = 0; j < array.Length; j++)
		{
			byte b2;
			interface5_0.imethod_1(j, out b2);
			if (b2 != array[j])
			{
				return false;
			}
		}
		interface5_0.imethod_3();
		return interface5_0.imethod_0() == 0;
	}
}
