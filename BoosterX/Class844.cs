using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

// Token: 0x020006CE RID: 1742
internal static class Class844
{
	// Token: 0x06002BE4 RID: 11236 RVA: 0x000A7E94 File Offset: 0x000A6094
	internal static long smethod_0()
	{
		if (Assembly.GetCallingAssembly() == typeof(Class844).Assembly && Class844.smethod_2())
		{
			long result;
			lock (Class844.class850_0)
			{
				long num = Class844.class850_0.method_0();
				if (num == 0L)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					List<byte> list = new List<byte>();
					AssemblyName assemblyName;
					try
					{
						assemblyName = executingAssembly.GetName();
					}
					catch
					{
						assemblyName = new AssemblyName(executingAssembly.FullName);
					}
					byte[] array = assemblyName.GetPublicKeyToken();
					if (array != null && array.Length == 0)
					{
						array = null;
					}
					if (array != null)
					{
						list.AddRange(array);
					}
					list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
					int num2 = Class844.smethod_4(typeof(Class844));
					int num3 = Class844.Class851.smethod_0();
					list.Add((byte)(num2 >> 16));
					list.Add((byte)(num3 >> 24));
					list.Add((byte)(num2 >> 24));
					list.Add((byte)(num3 >> 16));
					list.Add((byte)(num2 >> 8));
					list.Add((byte)(num3 >> 8));
					list.Add((byte)num2);
					list.Add((byte)num3);
					int count = list.Count;
					ulong num4 = 0UL;
					for (int num5 = 0; num5 != count; num5++)
					{
						num4 += (ulong)list[num5];
						num4 += num4 << 20;
						num4 ^= num4 >> 12;
						list[num5] = 0;
					}
					num4 += num4 << 6;
					num4 ^= num4 >> 22;
					num4 += num4 << 30;
					num = (long)num4;
					num ^= 6609968273890108903L;
					Class844.class850_0.method_1(num);
				}
				result = num;
			}
			return result;
		}
		return 0L;
	}

	// Token: 0x06002BE5 RID: 11237 RVA: 0x000A8078 File Offset: 0x000A6278
	internal static void smethod_1(byte[] byte_0)
	{
		if (Assembly.GetCallingAssembly() == typeof(Class844).Assembly && Class844.smethod_2())
		{
			long num = Class844.smethod_0();
			byte[] array = new byte[]
			{
				(byte)num,
				(byte)(num >> 40),
				(byte)(num >> 56),
				(byte)(num >> 48),
				(byte)(num >> 32),
				(byte)(num >> 24),
				(byte)(num >> 16),
				(byte)(num >> 8)
			};
			int num2 = byte_0.Length;
			for (int num3 = 0; num3 != num2; num3++)
			{
				int num4 = num3;
				byte_0[num4] ^= (byte)((int)array[num3 & 7] + num3);
			}
			return;
		}
	}

	// Token: 0x06002BE6 RID: 11238 RVA: 0x0001C44D File Offset: 0x0001A64D
	private static bool smethod_2()
	{
		return Class844.smethod_3();
	}

	// Token: 0x06002BE7 RID: 11239 RVA: 0x000A8118 File Offset: 0x000A6318
	private static bool smethod_3()
	{
		StackTrace stackTrace = new StackTrace();
		StackFrame frame = stackTrace.GetFrame(3);
		MethodBase methodBase = (frame == null) ? null : frame.GetMethod();
		Type type = (methodBase == null) ? null : methodBase.DeclaringType;
		return type != typeof(RuntimeMethodHandle) && type != null && type.Assembly == typeof(Class844).Assembly;
	}

	// Token: 0x06002BE8 RID: 11240 RVA: 0x0001C459 File Offset: 0x0001A659
	private static int smethod_4(Type type_0)
	{
		return type_0.MetadataToken;
	}

	// Token: 0x04001C82 RID: 7298
	private static Class844.Class850 class850_0 = new Class844.Class850();

	// Token: 0x020006CF RID: 1743
	private sealed class Class845
	{
		// Token: 0x06002BEA RID: 11242 RVA: 0x000A817C File Offset: 0x000A637C
		internal static int smethod_0()
		{
			return Class844.Class847.smethod_0(Class844.smethod_4(typeof(Class844.Class845)), Class844.Class847.smethod_2(Class844.Class847.smethod_1(Class844.smethod_4(typeof(Class844.Class848)), Class844.smethod_4(typeof(Class844.Class851))), Class844.Class847.smethod_2(Class844.smethod_4(typeof(Class844.Class846)) ^ -1620729528, Class844.Class848.smethod_0())));
		}
	}

	// Token: 0x020006D0 RID: 1744
	private sealed class Class846
	{
		// Token: 0x06002BEC RID: 11244 RVA: 0x000A81E4 File Offset: 0x000A63E4
		internal static int smethod_0()
		{
			return Class844.Class847.smethod_2(Class844.Class847.smethod_0(Class844.Class849.smethod_0() ^ 527758446, Class844.smethod_4(typeof(Class844.Class852))), Class844.Class847.smethod_1(Class844.smethod_4(typeof(Class844.Class851)) ^ Class844.smethod_4(typeof(Class844.Class845)), -221486918));
		}
	}

	// Token: 0x020006D1 RID: 1745
	private static class Class847
	{
		// Token: 0x06002BED RID: 11245 RVA: 0x0001C461 File Offset: 0x0001A661
		internal static int smethod_0(int int_0, int int_1)
		{
			return int_0 ^ int_1 - -154958426;
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x0001C46C File Offset: 0x0001A66C
		internal static int smethod_1(int int_0, int int_1)
		{
			return int_0 - 1608453098 ^ int_1 + 2096412311;
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0001C47D File Offset: 0x0001A67D
		internal static int smethod_2(int int_0, int int_1)
		{
			return int_0 ^ (int_1 - -1908020686 ^ int_0 - int_1);
		}
	}

	// Token: 0x020006D2 RID: 1746
	private sealed class Class848
	{
		// Token: 0x06002BF1 RID: 11249 RVA: 0x0001C48C File Offset: 0x0001A68C
		internal static int smethod_0()
		{
			return Class844.Class847.smethod_1(Class844.Class847.smethod_1(Class844.Class846.smethod_0(), Class844.Class847.smethod_0(Class844.smethod_4(typeof(Class844.Class848)), Class844.Class849.smethod_0())), Class844.smethod_4(typeof(Class844.Class845)));
		}
	}

	// Token: 0x020006D3 RID: 1747
	private sealed class Class849
	{
		// Token: 0x06002BF3 RID: 11251 RVA: 0x000A8240 File Offset: 0x000A6440
		internal static int smethod_0()
		{
			return Class844.Class847.smethod_0(Class844.smethod_4(typeof(Class844.Class846)), Class844.smethod_4(typeof(Class844.Class852)) ^ Class844.Class847.smethod_1(Class844.smethod_4(typeof(Class844.Class849)), Class844.Class847.smethod_2(Class844.smethod_4(typeof(Class844.Class845)), Class844.Class852.smethod_0())));
		}
	}

	// Token: 0x020006D4 RID: 1748
	private sealed class Class850
	{
		// Token: 0x06002BF4 RID: 11252 RVA: 0x0001C4C5 File Offset: 0x0001A6C5
		internal Class850()
		{
			this.method_1(0L);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000A82A0 File Offset: 0x000A64A0
		internal long method_0()
		{
			if (Assembly.GetCallingAssembly() != typeof(Class844.Class850).Assembly)
			{
				return 2918384L;
			}
			if (!Class844.smethod_2())
			{
				return 2918384L;
			}
			int[] array = new int[]
			{
				0,
				0,
				0,
				-1406994882
			};
			array[1] = 1899332624;
			array[2] = 98380201;
			array[0] = -417687841;
			int num = this.int_0;
			int num2 = this.int_1;
			int num3 = -1640531527;
			int num4 = -957401312;
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 -= ((num << 4 ^ num >> 5) + num ^ num4 + array[num4 >> 11 & 3]);
				num4 -= num3;
				num -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			ulong num7 = (ulong)((ulong)((long)num2) << 32);
			return (long)(num7 | (ulong)num);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000A8388 File Offset: 0x000A6588
		internal void method_1(long long_0)
		{
			if (Assembly.GetCallingAssembly() != typeof(Class844.Class850).Assembly)
			{
				return;
			}
			if (!Class844.smethod_2())
			{
				return;
			}
			int[] array = new int[4];
			array[1] = 1899332624;
			array[0] = -417687841;
			array[2] = 98380201;
			array[3] = -1406994882;
			int num = -1640531527;
			int num2 = (int)long_0;
			int num3 = (int)(long_0 >> 32);
			int num4 = 0;
			for (int num5 = 0; num5 != 32; num5++)
			{
				num2 += ((num3 << 4 ^ num3 >> 5) + num3 ^ num4 + array[num4 & 3]);
				num4 += num;
				num3 += ((num2 << 4 ^ num2 >> 5) + num2 ^ num4 + array[num4 >> 11 & 3]);
			}
			for (int num6 = 0; num6 != 4; num6++)
			{
				array[num6] = 0;
			}
			this.int_0 = num2;
			this.int_1 = num3;
		}

		// Token: 0x04001C83 RID: 7299
		private int int_0;

		// Token: 0x04001C84 RID: 7300
		private int int_1;
	}

	// Token: 0x020006D5 RID: 1749
	private sealed class Class851
	{
		// Token: 0x06002BF8 RID: 11256 RVA: 0x000A8454 File Offset: 0x000A6654
		internal static int smethod_0()
		{
			return Class844.Class847.smethod_2(Class844.Class847.smethod_1(Class844.smethod_4(typeof(Class844.Class849)), Class844.Class847.smethod_2(Class844.smethod_4(typeof(Class844.Class851)), Class844.smethod_4(typeof(Class844.Class848)))), Class844.Class845.smethod_0());
		}
	}

	// Token: 0x020006D6 RID: 1750
	private sealed class Class852
	{
		// Token: 0x06002BFA RID: 11258 RVA: 0x000A84A4 File Offset: 0x000A66A4
		internal static int smethod_0()
		{
			return Class844.Class847.smethod_2(Class844.smethod_4(typeof(Class844.Class852)), Class844.Class847.smethod_0(Class844.smethod_4(typeof(Class844.Class851)), Class844.Class847.smethod_1(Class844.smethod_4(typeof(Class844.Class849)), Class844.Class847.smethod_2(Class844.smethod_4(typeof(Class844.Class846)), Class844.Class847.smethod_0(Class844.smethod_4(typeof(Class844.Class848)), Class844.smethod_4(typeof(Class844.Class845)))))));
		}
	}
}
