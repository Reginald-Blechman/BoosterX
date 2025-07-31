using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

// Token: 0x020000A4 RID: 164
internal static class Class105
{
	// Token: 0x0600051D RID: 1309 RVA: 0x00037D88 File Offset: 0x00035F88
	public static void smethod_0(uint uint_0)
	{
		if (uint_0 != 0U)
		{
			uint num = uint_0;
			throw new InvalidOperationException(num.ToString());
		}
	}

	// Token: 0x0600051E RID: 1310
	[DllImport("ncrypt.dll")]
	public static extern uint NCryptFreeObject(IntPtr intptr_0);

	// Token: 0x0600051F RID: 1311
	[DllImport("ncrypt.dll")]
	public static extern uint NCryptEncrypt(Class105.Class106 class106_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_1, int int_1, out int int_2, int int_3);

	// Token: 0x06000520 RID: 1312
	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptImportKey(Class105.Class107 class107_0, IntPtr intptr_0, string string_0, IntPtr intptr_1, out Class105.Class106 class106_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, uint uint_0);

	// Token: 0x06000521 RID: 1313
	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptOpenStorageProvider(out Class105.Class107 class107_0, string string_0, uint uint_0);

	// Token: 0x020000A5 RID: 165
	[SecurityCritical]
	public sealed class Class106 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x0000564D File Offset: 0x0000384D
		public Class106() : base(true)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00005656 File Offset: 0x00003856
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00005668 File Offset: 0x00003868
		protected override bool ReleaseHandle()
		{
			return Class105.NCryptFreeObject(this.handle) == 0U;
		}
	}

	// Token: 0x020000A6 RID: 166
	public struct Struct15
	{
		// Token: 0x040002E5 RID: 741
		public uint uint_0;

		// Token: 0x040002E6 RID: 742
		public int int_0;

		// Token: 0x040002E7 RID: 743
		public int int_1;

		// Token: 0x040002E8 RID: 744
		public int int_2;

		// Token: 0x040002E9 RID: 745
		public int int_3;

		// Token: 0x040002EA RID: 746
		public int int_4;
	}

	// Token: 0x020000A7 RID: 167
	[SecurityCritical]
	public sealed class Class107 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x0000564D File Offset: 0x0000384D
		public Class107() : base(true)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00005656 File Offset: 0x00003856
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00005668 File Offset: 0x00003868
		protected override bool ReleaseHandle()
		{
			return Class105.NCryptFreeObject(this.handle) == 0U;
		}
	}
}
