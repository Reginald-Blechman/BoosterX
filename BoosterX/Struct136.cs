using System;
using System.Runtime.InteropServices;

// Token: 0x0200023A RID: 570
internal struct Struct136 : IDisposable
{
	// Token: 0x06000F8A RID: 3978 RVA: 0x00054538 File Offset: 0x00052738
	public Struct136(Struct84 struct84_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf(typeof(Struct136));
		this.intptr_2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Struct84)));
		Marshal.StructureToPtr<Struct84>(struct84_0, this.intptr_2, false);
		this.enum5_0 = (Enum5)1;
		this.intptr_0 = IntPtr.Zero;
		this.intptr_1 = IntPtr.Zero;
		this.enum7_0 = (Enum7)2;
		this.enum16_0 = (Enum16)0;
		this.enum13_0 = (Enum13)0;
		this.intptr_3 = IntPtr.Zero;
		this.intptr_4 = IntPtr.Zero;
		this.enum6_0 = (Enum6)256;
		this.enum10_0 = (Enum10)0;
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x0000B692 File Offset: 0x00009892
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x000545DC File Offset: 0x000527DC
	private void method_0(bool bool_0)
	{
		if (this.enum5_0 == (Enum5)1)
		{
			Struct84 structure = default(Struct84);
			Marshal.PtrToStructure<Struct84>(this.intptr_2, structure);
			structure.Dispose();
			Marshal.DestroyStructure(this.intptr_2, typeof(Struct84));
		}
		Marshal.FreeHGlobal(this.intptr_2);
	}

	// Token: 0x040009F0 RID: 2544
	public uint uint_0;

	// Token: 0x040009F1 RID: 2545
	public IntPtr intptr_0;

	// Token: 0x040009F2 RID: 2546
	public IntPtr intptr_1;

	// Token: 0x040009F3 RID: 2547
	public Enum7 enum7_0;

	// Token: 0x040009F4 RID: 2548
	public Enum16 enum16_0;

	// Token: 0x040009F5 RID: 2549
	public Enum5 enum5_0;

	// Token: 0x040009F6 RID: 2550
	public IntPtr intptr_2;

	// Token: 0x040009F7 RID: 2551
	public Enum13 enum13_0;

	// Token: 0x040009F8 RID: 2552
	public IntPtr intptr_3;

	// Token: 0x040009F9 RID: 2553
	private IntPtr intptr_4;

	// Token: 0x040009FA RID: 2554
	public Enum6 enum6_0;

	// Token: 0x040009FB RID: 2555
	public Enum10 enum10_0;
}
