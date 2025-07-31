using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000C3 RID: 195
internal static class Class126
{
	// Token: 0x060005AE RID: 1454 RVA: 0x00038E9C File Offset: 0x0003709C
	public static Class102 smethod_0(string string_0)
	{
		byte[] array = Class89.smethod_5(string_0);
		if (array == null)
		{
			return null;
		}
		return new Class102
		{
			class23_0 = new Class23
			{
				byte_0 = array,
				bool_0 = true,
				bool_1 = true
			}
		};
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00038EDC File Offset: 0x000370DC
	public static byte[] smethod_1(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (string_0.Length == 0)
		{
			return new byte[0];
		}
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		Array array_ = bytes;
		Struct18 struct18_ = Class3.smethod_5();
		Func<byte[]> func_;
		if ((func_ = Class126.Class127.func_0) == null)
		{
			func_ = (Class126.Class127.func_0 = new Func<byte[]>(Class126.smethod_4));
		}
		byte[] result = Class53.smethod_0(array_, struct18_, func_);
		Array.Clear(bytes, 0, bytes.Length);
		return result;
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00038F3C File Offset: 0x0003713C
	public static string smethod_2(byte[] byte_0, bool bool_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		if (byte_0.Length == 0)
		{
			return string.Empty;
		}
		int int_ = 0;
		Struct18 struct18_ = Class3.smethod_5();
		Func<byte[]> func_;
		if ((func_ = Class126.Class127.func_0) == null)
		{
			func_ = (Class126.Class127.func_0 = new Func<byte[]>(Class126.smethod_4));
		}
		byte[] array = Class53.smethod_1<byte>(byte_0, int_, struct18_, func_, bool_0);
		string @string = Encoding.UTF8.GetString(array);
		Array.Clear(array, 0, array.Length);
		return @string;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00038F98 File Offset: 0x00037198
	public static void smethod_3(string string_0)
	{
		if (string.IsInterned(string_0) != null)
		{
			return;
		}
		GCHandle gchandle = default(GCHandle);
		try
		{
			gchandle = GCHandle.Alloc(string_0, GCHandleType.Pinned);
			IntPtr ptr = gchandle.AddrOfPinnedObject();
			bool flag = IntPtr.Size == 4;
			int num = string_0.Length * 2;
			int i = 0;
			int num2 = num / IntPtr.Size;
			for (int j = 0; j < num2; j++)
			{
				if (flag)
				{
					Marshal.WriteInt32(ptr, i, 0);
				}
				else
				{
					Marshal.WriteInt64(ptr, i, 0L);
				}
				i += IntPtr.Size;
			}
			while (i < num)
			{
				Marshal.WriteInt16(ptr, i, 0);
				i += 2;
			}
			gchandle.Free();
		}
		catch (Exception)
		{
			if (gchandle.IsAllocated)
			{
				gchandle.Free();
			}
		}
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00005AD8 File Offset: 0x00003CD8
	private static byte[] smethod_4()
	{
		return (byte[])Class392.smethod_3().method_105(Class392.smethod_1(), "7^TS1Za-hQ", null);
	}

	// Token: 0x020000C4 RID: 196
	private static class Class127
	{
		// Token: 0x0400031A RID: 794
		public static Func<byte[]> func_0;
	}
}
