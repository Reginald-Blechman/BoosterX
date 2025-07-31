using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000191 RID: 401
[Guid("EA502723-A23D-11d1-A7D3-0000F87571E3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface3
{
	// Token: 0x06000B2C RID: 2860
	uint imethod_0([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, uint uint_0);

	// Token: 0x06000B2D RID: 2861
	uint imethod_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

	// Token: 0x06000B2E RID: 2862
	uint imethod_2(uint uint_0);

	// Token: 0x06000B2F RID: 2863
	uint imethod_3([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

	// Token: 0x06000B30 RID: 2864
	uint imethod_4([MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, [MarshalAs(UnmanagedType.LPStruct)] Guid guid_1);

	// Token: 0x06000B31 RID: 2865
	uint imethod_5();

	// Token: 0x06000B32 RID: 2866
	uint imethod_6([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000B33 RID: 2867
	uint imethod_7([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000B34 RID: 2868
	uint imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

	// Token: 0x06000B35 RID: 2869
	uint imethod_9([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000B36 RID: 2870
	uint imethod_10(uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000B37 RID: 2871
	uint imethod_11(uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000B38 RID: 2872
	uint imethod_12(uint uint_0, out IntPtr intptr_0);

	// Token: 0x06000B39 RID: 2873
	uint imethod_13(out uint uint_0);

	// Token: 0x06000B3A RID: 2874
	uint imethod_14(uint uint_0, uint uint_1);

	// Token: 0x06000B3B RID: 2875
	uint imethod_15(out IntPtr intptr_0);

	// Token: 0x06000B3C RID: 2876
	uint imethod_16([MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

	// Token: 0x06000B3D RID: 2877
	uint imethod_17(out IntPtr intptr_0);
}
