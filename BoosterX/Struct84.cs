using System;
using System.Runtime.InteropServices;

// Token: 0x02000199 RID: 409
internal struct Struct84 : IDisposable
{
	// Token: 0x06000B98 RID: 2968 RVA: 0x0004A41C File Offset: 0x0004861C
	public Struct84(string string_1, Guid guid_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct84));
		this.string_0 = string_1;
		if (guid_0 != Guid.Empty)
		{
			this.intptr_1 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid)));
			Marshal.StructureToPtr<Guid>(guid_0, this.intptr_1, true);
		}
		else
		{
			this.intptr_1 = IntPtr.Zero;
		}
		this.intptr_0 = IntPtr.Zero;
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0000914E File Offset: 0x0000734E
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x00009157 File Offset: 0x00007357
	private void method_0(bool bool_0)
	{
		if (this.intptr_1 != IntPtr.Zero)
		{
			Marshal.DestroyStructure(this.intptr_1, typeof(Guid));
			Marshal.FreeHGlobal(this.intptr_1);
		}
	}

	// Token: 0x04000779 RID: 1913
	public uint uint_0;

	// Token: 0x0400077A RID: 1914
	[MarshalAs(UnmanagedType.LPTStr)]
	public string string_0;

	// Token: 0x0400077B RID: 1915
	public IntPtr intptr_0;

	// Token: 0x0400077C RID: 1916
	public IntPtr intptr_1;
}
