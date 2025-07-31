using System;
using System.Runtime.InteropServices;

// Token: 0x0200028D RID: 653
internal struct Struct144 : IDisposable
{
	// Token: 0x06001176 RID: 4470 RVA: 0x00059854 File Offset: 0x00057A54
	public Struct144(Struct66 struct66_0)
	{
		this.uint_0 = (uint)Marshal.SizeOf<Struct144>();
		this.intptr_0 = IntPtr.Zero;
		this.intptr_1 = IntPtr.Zero;
		this.enum14_0 = (Enum14)2;
		this.enum17_0 = (Enum17)0;
		this.enum11_0 = (Enum11)1;
		this.intptr_2 = Marshal.AllocHGlobal(Marshal.SizeOf<Struct66>());
		Marshal.StructureToPtr<Struct66>(struct66_0, this.intptr_2, false);
		this.enum8_0 = (Enum8)0;
		this.intptr_3 = IntPtr.Zero;
		this.intptr_4 = IntPtr.Zero;
		this.enum12_0 = (Enum12)256;
		this.enum15_0 = (Enum15)0;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x000598E4 File Offset: 0x00057AE4
	public void Dispose()
	{
		if (this.enum11_0 == (Enum11)1 && this.intptr_2 != IntPtr.Zero)
		{
			Marshal.PtrToStructure<Struct66>(this.intptr_2).Dispose();
			Marshal.DestroyStructure<Struct66>(this.intptr_2);
			Marshal.FreeHGlobal(this.intptr_2);
			this.intptr_2 = IntPtr.Zero;
		}
	}

	// Token: 0x04000ADB RID: 2779
	public uint uint_0;

	// Token: 0x04000ADC RID: 2780
	public IntPtr intptr_0;

	// Token: 0x04000ADD RID: 2781
	public IntPtr intptr_1;

	// Token: 0x04000ADE RID: 2782
	public Enum14 enum14_0;

	// Token: 0x04000ADF RID: 2783
	public Enum17 enum17_0;

	// Token: 0x04000AE0 RID: 2784
	public Enum11 enum11_0;

	// Token: 0x04000AE1 RID: 2785
	public IntPtr intptr_2;

	// Token: 0x04000AE2 RID: 2786
	public Enum8 enum8_0;

	// Token: 0x04000AE3 RID: 2787
	public IntPtr intptr_3;

	// Token: 0x04000AE4 RID: 2788
	private IntPtr intptr_4;

	// Token: 0x04000AE5 RID: 2789
	public Enum12 enum12_0;

	// Token: 0x04000AE6 RID: 2790
	public Enum15 enum15_0;
}
