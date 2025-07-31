using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x020000C9 RID: 201
internal sealed class Class132 : IDisposable, Interface1
{
	// Token: 0x060005F7 RID: 1527 RVA: 0x0003A1D4 File Offset: 0x000383D4
	protected Class132(bool bool_2, Class100 class100_0)
	{
		if (class100_0 == null)
		{
			throw new ArgumentNullException("parameters");
		}
		int int_ = class100_0.method_1().method_1();
		this.int_0 = Class132.smethod_3(int_);
		this.method_0(Class132.smethod_1(int_, bool_2));
		this.method_1(Class132.smethod_2(int_, bool_2));
		Class105.smethod_0(Class105.NCryptOpenStorageProvider(out this.class107_0, "Microsoft Software Key Storage Provider", 0U));
		string string_;
		byte[] array = this.vmethod_0(class100_0, out string_);
		Class105.smethod_0(Class105.NCryptImportKey(this.class107_0, IntPtr.Zero, string_, IntPtr.Zero, out this.class106_0, array, array.Length, 64U));
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x0003A270 File Offset: 0x00038470
	public static Class132 smethod_0(bool bool_2, Class100 class100_0)
	{
		if (!Class132.bool_0)
		{
			return null;
		}
		if (!Class57.smethod_1())
		{
			Class132.bool_0 = false;
			return null;
		}
		Class132 @class = null;
		Class132 result;
		try
		{
			return new Class132(bool_2, class100_0);
		}
		catch
		{
			if (@class != null)
			{
				@class.Dispose();
			}
			Class132.bool_0 = false;
			result = null;
		}
		return result;
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00005CA9 File Offset: 0x00003EA9
	[CompilerGenerated]
	public int imethod_0()
	{
		return this.int_1;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00005CB1 File Offset: 0x00003EB1
	private void method_0(int int_3)
	{
		this.int_1 = int_3;
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00005CBA File Offset: 0x00003EBA
	[CompilerGenerated]
	public int imethod_1()
	{
		return this.int_2;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00005CC2 File Offset: 0x00003EC2
	private void method_1(int int_3)
	{
		this.int_2 = int_3;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x000034AF File Offset: 0x000016AF
	private static int smethod_1(int int_3, bool bool_2)
	{
		if (!bool_2)
		{
			return (int_3 + 7) / 8;
		}
		return (int_3 - 1) / 8;
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x000034BF File Offset: 0x000016BF
	private static int smethod_2(int int_3, bool bool_2)
	{
		if (!bool_2)
		{
			return (int_3 - 1) / 8;
		}
		return (int_3 + 7) / 8;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00005CCB File Offset: 0x00003ECB
	private static int smethod_3(int int_3)
	{
		return (int_3 + 7) / 8;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00005CD2 File Offset: 0x00003ED2
	private void method_2()
	{
		if (!this.bool_1)
		{
			this.byte_0 = new byte[this.int_0];
			this.byte_1 = new byte[this.int_0];
			this.bool_1 = true;
		}
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0003A2C8 File Offset: 0x000384C8
	public int imethod_2(byte[] byte_2, int int_3, int int_4, byte[] byte_3, int int_5, RandomNumberGenerator randomNumberGenerator_0)
	{
		this.method_2();
		byte[] array = this.byte_0;
		int num = array.Length - int_4;
		if (num > 0)
		{
			Array.Clear(array, 0, num);
		}
		Buffer.BlockCopy(byte_2, int_3, array, num, int_4);
		int num2;
		Class105.smethod_0(Class105.NCryptEncrypt(this.class106_0, array, array.Length, IntPtr.Zero, this.byte_1, this.int_0, out num2, 1));
		int num3 = this.imethod_1();
		int srcOffset = num2 - num3;
		Buffer.BlockCopy(this.byte_1, srcOffset, byte_3, int_5, num3);
		return num3;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00005D05 File Offset: 0x00003F05
	protected byte[] vmethod_0(Class100 class100_0, out string string_0)
	{
		string_0 = "RSAPUBLICBLOB";
		return Class132.smethod_4(class100_0);
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0003A344 File Offset: 0x00038544
	protected static byte[] smethod_4(Class100 class100_0)
	{
		int num = Marshal.SizeOf(typeof(Class105.Struct15));
		byte[] array = new byte[num + class100_0.method_2().method_10() + class100_0.method_1().method_10()];
		Class132.smethod_5(new Class105.Struct15
		{
			uint_0 = 826364754U,
			int_0 = class100_0.method_1().method_1(),
			int_1 = class100_0.method_2().method_10(),
			int_2 = class100_0.method_1().method_10()
		}, array, 0);
		int num2 = num;
		num2 += class100_0.method_2().method_11(array, num2);
		num2 += class100_0.method_1().method_11(array, num2);
		return array;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0003A3F4 File Offset: 0x000385F4
	protected static void smethod_5(Class105.Struct15 struct15_0, byte[] byte_2, int int_3)
	{
		int num = Marshal.SizeOf(struct15_0);
		if (int_3 + num > byte_2.Length)
		{
			throw new ArgumentException("blob");
		}
		try
		{
		}
		finally
		{
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(struct15_0, intPtr, false);
			Marshal.Copy(intPtr, byte_2, int_3, num);
			Marshal.DestroyStructure(intPtr, typeof(Class105.Struct15));
			Marshal.FreeHGlobal(intPtr);
		}
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00005D15 File Offset: 0x00003F15
	public void Dispose()
	{
		if (this.class107_0 != null)
		{
			this.class107_0.Dispose();
			this.class107_0 = null;
		}
		if (this.class106_0 != null)
		{
			this.class106_0.Dispose();
			this.class106_0 = null;
		}
	}

	// Token: 0x0400032E RID: 814
	private static bool bool_0 = true;

	// Token: 0x0400032F RID: 815
	protected Class105.Class107 class107_0;

	// Token: 0x04000330 RID: 816
	protected Class105.Class106 class106_0;

	// Token: 0x04000331 RID: 817
	protected int int_0;

	// Token: 0x04000332 RID: 818
	private int int_1;

	// Token: 0x04000333 RID: 819
	private int int_2;

	// Token: 0x04000334 RID: 820
	private byte[] byte_0;

	// Token: 0x04000335 RID: 821
	private byte[] byte_1;

	// Token: 0x04000336 RID: 822
	private bool bool_1;
}
