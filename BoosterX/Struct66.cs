using System;
using System.Runtime.InteropServices;

// Token: 0x0200015D RID: 349
internal struct Struct66 : IDisposable
{
	// Token: 0x06000A08 RID: 2568 RVA: 0x00045C4C File Offset: 0x00043E4C
	public Struct66(string string_1, Guid guid_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf<Struct66>();
		this.string_0 = string_1;
		this.intptr_0 = IntPtr.Zero;
		if (guid_0 != Guid.Empty)
		{
			this.intptr_1 = Marshal.AllocHGlobal(Marshal.SizeOf<Guid>());
			Marshal.StructureToPtr<Guid>(guid_0, this.intptr_1, false);
			return;
		}
		this.intptr_1 = IntPtr.Zero;
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00008132 File Offset: 0x00006332
	public void Dispose()
	{
		if (this.intptr_1 != IntPtr.Zero)
		{
			Marshal.DestroyStructure<Guid>(this.intptr_1);
			Marshal.FreeHGlobal(this.intptr_1);
			this.intptr_1 = IntPtr.Zero;
		}
	}

	// Token: 0x040006A9 RID: 1705
	public uint uint_0;

	// Token: 0x040006AA RID: 1706
	[MarshalAs(UnmanagedType.LPTStr)]
	public string string_0;

	// Token: 0x040006AB RID: 1707
	public IntPtr intptr_0;

	// Token: 0x040006AC RID: 1708
	public IntPtr intptr_1;
}
