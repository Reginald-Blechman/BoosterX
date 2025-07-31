using System;
using System.Runtime.InteropServices;

// Token: 0x02000594 RID: 1428
internal sealed class Class693 : IDisposable
{
	// Token: 0x060023F9 RID: 9209 RVA: 0x0001796D File Offset: 0x00015B6D
	internal Class693(IntPtr intptr_1, Enum20 enum20_1)
	{
		this.intptr_0 = intptr_1;
		this.enum20_0 = enum20_1;
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x0008CCE4 File Offset: 0x0008AEE4
	public void Dispose()
	{
		if (this.intptr_0 != IntPtr.Zero)
		{
			if (this.enum20_0 == (Enum20)0)
			{
				Marshal.FreeHGlobal(this.intptr_0);
			}
			else
			{
				Marshal.FreeCoTaskMem(this.intptr_0);
			}
			this.intptr_0 = IntPtr.Zero;
			GC.SuppressFinalize(this);
		}
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x00017983 File Offset: 0x00015B83
	public static implicit operator IntPtr(Class693 class693_0)
	{
		return class693_0.intptr_0;
	}

	// Token: 0x040017B3 RID: 6067
	private IntPtr intptr_0;

	// Token: 0x040017B4 RID: 6068
	private readonly Enum20 enum20_0;
}
