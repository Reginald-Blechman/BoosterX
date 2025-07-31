using System;
using System.Runtime.InteropServices;

// Token: 0x0200015B RID: 347
internal sealed class Class188 : IDisposable
{
	// Token: 0x060009F4 RID: 2548 RVA: 0x000080E4 File Offset: 0x000062E4
	internal Class188(IntPtr intptr_1, Enum9 enum9_1)
	{
		this.enum9_0 = enum9_1;
		this.intptr_0 = intptr_1;
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x000457F0 File Offset: 0x000439F0
	~Class188()
	{
		this.method_0(false);
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00045820 File Offset: 0x00043A20
	private void method_0(bool bool_0)
	{
		if (this.intptr_0 != IntPtr.Zero)
		{
			if (this.enum9_0 == (Enum9)0)
			{
				Marshal.FreeHGlobal(this.intptr_0);
			}
			else if (this.enum9_0 == (Enum9)1)
			{
				Marshal.FreeCoTaskMem(this.intptr_0);
			}
			this.intptr_0 = IntPtr.Zero;
		}
		if (bool_0)
		{
			GC.SuppressFinalize(this);
		}
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x000080FA File Offset: 0x000062FA
	public void Dispose()
	{
		this.method_0(true);
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00008103 File Offset: 0x00006303
	public static implicit operator IntPtr(Class188 class188_0)
	{
		return class188_0.intptr_0;
	}

	// Token: 0x040006A5 RID: 1701
	private IntPtr intptr_0;

	// Token: 0x040006A6 RID: 1702
	private Enum9 enum9_0;
}
