using System;
using System.Collections;
using System.IO;

// Token: 0x0200002F RID: 47
internal static class Class24
{
	// Token: 0x0600010D RID: 269 RVA: 0x00024B1C File Offset: 0x00022D1C
	private static void smethod_0()
	{
		if (Class24.bool_0)
		{
			return;
		}
		object obj = Class24.object_0;
		lock (obj)
		{
			if (!Class24.bool_0)
			{
				Class128 class128_ = new Class128(1, Class24.byte_0);
				Class100 class100_ = new Class100(false, class128_, Class24.class128_0);
				Class24.class133_0 = new Class133(true, class100_, false);
				Class24.bool_0 = true;
			}
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000039D3 File Offset: 0x00001BD3
	private static byte[] smethod_1()
	{
		return null;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00024B94 File Offset: 0x00022D94
	public static bool smethod_2(object object_1, byte[] byte_1, ulong ulong_0, int int_0)
	{
		if (byte_1 == null)
		{
			return false;
		}
		if (!Class24.smethod_5(object_1))
		{
			Class24.smethod_0();
			byte[] byte_2 = Class0.smethod_0(object_1, ulong_0, Class24.class133_0, null);
			return Class24.smethod_3(byte_1, byte_2);
		}
		switch (int_0)
		{
		case 0:
			return false;
		case 1:
			throw new ArgumentNullException("value");
		case 2:
			throw new NullReferenceException("value");
		default:
			throw new ArgumentOutOfRangeException("nullArgBehaviour");
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00024C00 File Offset: 0x00022E00
	private static bool smethod_3(byte[] byte_1, byte[] byte_2)
	{
		if (byte_1.Length != byte_2.Length)
		{
			return false;
		}
		for (int i = 0; i < byte_1.Length; i++)
		{
			if (byte_1[i] != byte_2[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00024C34 File Offset: 0x00022E34
	public static byte[] smethod_4(object[] object_1, byte[] byte_1, ulong ulong_0)
	{
		if (object_1 == null)
		{
			throw new ArgumentNullException("#=zPWibic8=");
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException("#=z2_sBKLs=");
		}
		byte[] array2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			for (int i = 0; i < object_1.Length; i++)
			{
				byte[] array = Class0.smethod_3(object_1[i]);
				memoryStream.Write(array, 0, array.Length);
			}
			array2 = memoryStream.ToArray();
		}
		return new Class44(array2, (long)ulong_0).method_2(byte_1);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00024CBC File Offset: 0x00022EBC
	internal static bool smethod_5(object object_1)
	{
		if (object_1 == null)
		{
			return true;
		}
		if (!(object_1 is string))
		{
			IEnumerable enumerable = object_1 as IEnumerable;
			if (enumerable != null)
			{
				using (IEnumerator enumerator = enumerable.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (Class24.smethod_5(enumerator.Current))
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}
		return false;
	}

	// Token: 0x0400005D RID: 93
	private static readonly Class128 class128_0 = Class128.smethod_18(65537UL);

	// Token: 0x0400005E RID: 94
	private static readonly byte[] byte_0 = Class24.smethod_1();

	// Token: 0x0400005F RID: 95
	private static Class133 class133_0;

	// Token: 0x04000060 RID: 96
	private static readonly object object_0 = new object();

	// Token: 0x04000061 RID: 97
	private static bool bool_0;
}
