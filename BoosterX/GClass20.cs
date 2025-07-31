using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using LibreHardwareMonitor.Hardware;
using ns0;
using PIManagerX;

// Token: 0x0200015F RID: 351
public sealed class GClass20
{
	// Token: 0x06000A0C RID: 2572 RVA: 0x00045DA4 File Offset: 0x00043FA4
	public static void smethod_0()
	{
		try
		{
			bool bool_ = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_7;
			PManagerX.SpecFlags specFlags = GClass20.smethod_2();
			PManagerX.KvaFlags kvaFlags = GClass20.smethod_3();
			ulong num = bool_ ? GClass20.smethod_1() : 0UL;
			bool flag = (num & 1UL) > 0UL;
			object obj = bool_ ? ((num & 2UL) > 0UL) : (specFlags.RetpolineEnabled || specFlags.ImportOptEnabled);
			bool flag2 = (num & 33554432UL) > 0UL;
			bool flag3 = (num & 67108864UL) > 0UL;
			bool bpbEnabled = specFlags.BpbEnabled;
			object obj2 = obj;
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_14 = (obj2 != null || !bpbEnabled);
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_16 = (obj2 != null);
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_13 = (!flag && kvaFlags.Required);
			Version v = GClass267.smethod_11();
			Version v2 = new Version(10, 0, 22621, 2134);
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_15 = (flag2 && !flag3 && v < v2);
		}
		catch
		{
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_14 = false;
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_13 = false;
			dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_15 = false;
		}
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00045ED4 File Offset: 0x000440D4
	public static ulong smethod_1()
	{
		ulong result;
		if (!Ring0.ReadMsr(266U, ref result))
		{
			return 0UL;
		}
		return result;
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00045EFC File Offset: 0x000440FC
	public static PManagerX.SpecFlags smethod_2()
	{
		int num = Marshal.SizeOf(typeof(PManagerX.SYSTEM_SPECULATION_CONTROL_INFORMATION));
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		PManagerX.SpecFlags result;
		try
		{
			uint num3;
			int num2 = PManagerX.NtQuerySystemInformation(201, intPtr, (uint)num, ref num3);
			if (num2 != 0)
			{
				throw new Win32Exception(num2);
			}
			PManagerX.SYSTEM_SPECULATION_CONTROL_INFORMATION system_SPECULATION_CONTROL_INFORMATION = (PManagerX.SYSTEM_SPECULATION_CONTROL_INFORMATION)Marshal.PtrToStructure(intPtr, typeof(PManagerX.SYSTEM_SPECULATION_CONTROL_INFORMATION));
			bool flag = (system_SPECULATION_CONTROL_INFORMATION.Flags & 1UL) > 0UL;
			bool flag2 = (system_SPECULATION_CONTROL_INFORMATION.Flags & 16384UL) > 0UL;
			bool flag3 = (system_SPECULATION_CONTROL_INFORMATION.Flags & 32768UL) > 0UL;
			result = new PManagerX.SpecFlags(flag, flag2, flag3);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00045FCC File Offset: 0x000441CC
	public static PManagerX.KvaFlags smethod_3()
	{
		int num = Marshal.SizeOf(typeof(PManagerX.SYSTEM_KERNEL_VA_SHADOW_INFORMATION));
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		PManagerX.KvaFlags result;
		try
		{
			uint num3;
			int num2 = PManagerX.NtQuerySystemInformation(196, intPtr, (uint)num, ref num3);
			if (num2 != 0)
			{
				throw new Win32Exception(num2);
			}
			PManagerX.SYSTEM_KERNEL_VA_SHADOW_INFORMATION system_KERNEL_VA_SHADOW_INFORMATION = (PManagerX.SYSTEM_KERNEL_VA_SHADOW_INFORMATION)Marshal.PtrToStructure(intPtr, typeof(PManagerX.SYSTEM_KERNEL_VA_SHADOW_INFORMATION));
			result = new PManagerX.KvaFlags(system_KERNEL_VA_SHADOW_INFORMATION.KvaShadowRequired > 0, system_KERNEL_VA_SHADOW_INFORMATION.KvaShadowEnabled > 0);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}
}
