using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200017C RID: 380
internal sealed class Class196
{
	// Token: 0x06000A9C RID: 2716 RVA: 0x00049498 File Offset: 0x00047698
	public static void smethod_0(string string_0)
	{
		string text = string_0;
		if (string_0.EndsWith(".lnk"))
		{
			Class196.Class197 @class = new Class196.Class197();
			((Class196.Interface9)@class).imethod_3(string_0, 0U);
			StringBuilder stringBuilder = new StringBuilder(260);
			Class196.Struct78 @struct = default(Class196.Struct78);
			((Class196.Interface10)@class).imethod_0(stringBuilder, stringBuilder.Capacity, out @struct, (Class196.Enum3)0);
			text = stringBuilder.ToString();
		}
		if (text.EndsWith(".reg"))
		{
			GClass290.smethod_1("cmd.exe /c \"" + text + "\"", false);
			return;
		}
		if (text.EndsWith(".bat"))
		{
			GClass290.smethod_1("cmd.exe /c \"" + text + "\"", true);
			return;
		}
		if (text.EndsWith(".ps1"))
		{
			GClass290.smethod_1("cmd.exe /c \"" + text + "\"", true);
			return;
		}
		GClass290.smethod_1(text, true);
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00049578 File Offset: 0x00047778
	public static void smethod_1(string string_0)
	{
		string text = string_0;
		if (string_0.EndsWith(".lnk"))
		{
			Class196.Class197 @class = new Class196.Class197();
			((Class196.Interface9)@class).imethod_3(string_0, 0U);
			StringBuilder stringBuilder = new StringBuilder(260);
			Class196.Struct78 @struct = default(Class196.Struct78);
			((Class196.Interface10)@class).imethod_0(stringBuilder, stringBuilder.Capacity, out @struct, (Class196.Enum3)0);
			text = stringBuilder.ToString();
		}
		if (text.EndsWith(".reg"))
		{
			GClass290.smethod_1("cmd.exe /c \"" + text + "\"", false);
			return;
		}
		if (text.EndsWith(".bat"))
		{
			GClass290.smethod_1("cmd.exe /c \"" + text + "\"", false);
			return;
		}
		if (text.EndsWith(".ps1"))
		{
			GClass290.smethod_1("cmd.exe /c \"" + text + "\"", false);
			return;
		}
		GClass290.smethod_1(text, false);
	}

	// Token: 0x0200017D RID: 381
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct Struct78
	{
		// Token: 0x0400070F RID: 1807
		public uint uint_0;

		// Token: 0x04000710 RID: 1808
		public long long_0;

		// Token: 0x04000711 RID: 1809
		public long long_1;

		// Token: 0x04000712 RID: 1810
		public long long_2;

		// Token: 0x04000713 RID: 1811
		public uint uint_1;

		// Token: 0x04000714 RID: 1812
		public uint uint_2;

		// Token: 0x04000715 RID: 1813
		public uint uint_3;

		// Token: 0x04000716 RID: 1814
		public uint uint_4;

		// Token: 0x04000717 RID: 1815
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		// Token: 0x04000718 RID: 1816
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string string_1;
	}

	// Token: 0x0200017E RID: 382
	private enum Enum3
	{

	}

	// Token: 0x0200017F RID: 383
	[Guid("0000010b-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface Interface9 : Class196.Interface11
	{
		// Token: 0x06000A9E RID: 2718
		void imethod_1(out Guid guid_0);

		// Token: 0x06000A9F RID: 2719
		[PreserveSig]
		int imethod_2();

		// Token: 0x06000AA0 RID: 2720
		[PreserveSig]
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, uint uint_0);

		// Token: 0x06000AA1 RID: 2721
		[PreserveSig]
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

		// Token: 0x06000AA2 RID: 2722
		[PreserveSig]
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

		// Token: 0x06000AA3 RID: 2723
		[PreserveSig]
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);
	}

	// Token: 0x02000180 RID: 384
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[ComImport]
	private interface Interface10
	{
		// Token: 0x06000AA4 RID: 2724
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out Class196.Struct78 struct78_0, Class196.Enum3 enum3_0);

		// Token: 0x06000AA5 RID: 2725
		void imethod_1(out IntPtr intptr_0);

		// Token: 0x06000AA6 RID: 2726
		void imethod_2(IntPtr intptr_0);

		// Token: 0x06000AA7 RID: 2727
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06000AA8 RID: 2728
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06000AA9 RID: 2729
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06000AAA RID: 2730
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06000AAB RID: 2731
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06000AAC RID: 2732
		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06000AAD RID: 2733
		void imethod_9(out short short_0);

		// Token: 0x06000AAE RID: 2734
		void imethod_10(short short_0);

		// Token: 0x06000AAF RID: 2735
		void imethod_11(out int int_0);

		// Token: 0x06000AB0 RID: 2736
		void imethod_12(int int_0);

		// Token: 0x06000AB1 RID: 2737
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out int int_1);

		// Token: 0x06000AB2 RID: 2738
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06000AB3 RID: 2739
		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06000AB4 RID: 2740
		void imethod_16(IntPtr intptr_0, Class196.Enum4 enum4_0);

		// Token: 0x06000AB5 RID: 2741
		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	// Token: 0x02000181 RID: 385
	[Guid("0000010c-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface Interface11
	{
		// Token: 0x06000AB6 RID: 2742
		[PreserveSig]
		void imethod_0(out Guid guid_0);
	}

	// Token: 0x02000182 RID: 386
	[Guid("00021401-0000-0000-C000-000000000046")]
	[ComImport]
	public sealed class Class197
	{
		// Token: 0x06000AB7 RID: 2743
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class197();
	}

	// Token: 0x02000183 RID: 387
	private enum Enum4
	{

	}
}
