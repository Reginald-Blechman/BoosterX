using System;
using System.Diagnostics;
using System.Threading;
using PIManagerX;

// Token: 0x020002EC RID: 748
internal sealed class Class358
{
	// Token: 0x06001399 RID: 5017 RVA: 0x00061F54 File Offset: 0x00060154
	public static void smethod_0(Class358.Delegate26 delegate26_1)
	{
		Class358.Delegate26 @delegate = Class358.delegate26_0;
		Class358.Delegate26 delegate2;
		do
		{
			delegate2 = @delegate;
			Class358.Delegate26 value = (Class358.Delegate26)Delegate.Combine(delegate2, delegate26_1);
			@delegate = Interlocked.CompareExchange<Class358.Delegate26>(ref Class358.delegate26_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x00061F88 File Offset: 0x00060188
	public static void smethod_1(Class358.Delegate26 delegate26_1)
	{
		Class358.Delegate26 @delegate = Class358.delegate26_0;
		Class358.Delegate26 delegate2;
		do
		{
			delegate2 = @delegate;
			Class358.Delegate26 value = (Class358.Delegate26)Delegate.Remove(delegate2, delegate26_1);
			@delegate = Interlocked.CompareExchange<Class358.Delegate26>(ref Class358.delegate26_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x0000DDB6 File Offset: 0x0000BFB6
	public static void smethod_2()
	{
		Class358.intptr_0 = Class358.smethod_4(Class358.lowLevelMouseProc_0);
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x0000DDC7 File Offset: 0x0000BFC7
	public static void smethod_3()
	{
		PManagerX.UnhookWindowsHookEx(Class358.intptr_0);
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x00061FBC File Offset: 0x000601BC
	private static IntPtr smethod_4(PManagerX.LowLevelMouseProc lowLevelMouseProc_1)
	{
		IntPtr result;
		using (Process currentProcess = Process.GetCurrentProcess())
		{
			using (ProcessModule mainModule = currentProcess.MainModule)
			{
				result = PManagerX.SetWindowsHookEx(14, lowLevelMouseProc_1, PManagerX.GetModuleHandle(mainModule.ModuleName), 0U);
			}
		}
		return result;
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
	private static IntPtr smethod_5(int int_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (int_0 >= 0 && (int)intptr_1 == 513)
		{
			Class358.Delegate26 @delegate = Class358.delegate26_0;
			if (@delegate != null)
			{
				@delegate();
			}
		}
		return PManagerX.CallNextHookEx(Class358.intptr_0, int_0, intptr_1, intptr_2);
	}

	// Token: 0x04000C45 RID: 3141
	private static PManagerX.LowLevelMouseProc lowLevelMouseProc_0 = new PManagerX.LowLevelMouseProc(Class358.smethod_5);

	// Token: 0x04000C46 RID: 3142
	private static IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x04000C47 RID: 3143
	private static Class358.Delegate26 delegate26_0;

	// Token: 0x020002ED RID: 749
	// (Invoke) Token: 0x060013A0 RID: 5024
	public delegate void Delegate26();
}
