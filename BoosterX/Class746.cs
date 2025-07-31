using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x02000614 RID: 1556
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class Class746
{
	// Token: 0x06002792 RID: 10130 RVA: 0x0009AC48 File Offset: 0x00098E48
	internal static T smethod_0<T>(List<T> list_0)
	{
		if (list_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (list_0.Count > 0)
		{
			return list_0[0];
		}
		return default(T);
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x0009AC78 File Offset: 0x00098E78
	internal static bool smethod_1(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0 == null || byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (byte_0 == byte_1)
		{
			return true;
		}
		if (byte_0.Length != byte_1.Length)
		{
			return false;
		}
		for (int i = 0; i < byte_0.Length; i++)
		{
			if (byte_0[i] != byte_1[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x0009ACBC File Offset: 0x00098EBC
	internal static T smethod_2<T>(T[] gparam_0)
	{
		if (gparam_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (gparam_0.Length != 0)
		{
			return gparam_0[0];
		}
		return default(T);
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x0001A3F5 File Offset: 0x000185F5
	internal static bool smethod_3<T>(List<T> list_0)
	{
		if (list_0 == null)
		{
			throw new ArgumentNullException();
		}
		return list_0.Count != 0;
	}

	// Token: 0x06002796 RID: 10134 RVA: 0x0001A40D File Offset: 0x0001860D
	internal static bool smethod_4<T>(T[] gparam_0)
	{
		if (gparam_0 == null)
		{
			throw new ArgumentNullException();
		}
		return gparam_0.Length != 0;
	}
}
