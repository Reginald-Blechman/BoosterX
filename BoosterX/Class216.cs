using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x020001BF RID: 447
internal sealed class Class216
{
	// Token: 0x06000C7D RID: 3197 RVA: 0x000098C6 File Offset: 0x00007AC6
	// Note: this type is marked as 'beforefieldinit'.
	static Class216()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "^ULVXZa-h_", null);
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x000098DD File Offset: 0x00007ADD
	public static bool smethod_0()
	{
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "9t.O;Za-hb", null);
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x000098FE File Offset: 0x00007AFE
	public static string smethod_1()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), ";Ra'@Za-hd", null);
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0000991A File Offset: 0x00007B1A
	public static string smethod_2()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "?FR>LZa-hK", null);
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00009936 File Offset: 0x00007B36
	public static string smethod_3()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "Xgb^FZa-hO", null);
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00009952 File Offset: 0x00007B52
	public static string smethod_4()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "pp[Z<Za-hR", null);
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x0000996E File Offset: 0x00007B6E
	public static Task<string> smethod_5()
	{
		return (Task<string>)Class392.smethod_3().method_105(Class392.smethod_1(), "a1&I`Za-iW", null);
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0000998A File Offset: 0x00007B8A
	public static Task<string> smethod_6()
	{
		return (Task<string>)Class392.smethod_3().method_105(Class392.smethod_1(), "7(9S2Za-i\\", null);
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x000099A6 File Offset: 0x00007BA6
	public static string smethod_7()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "9XhF:Za-hV", null);
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x000099C2 File Offset: 0x00007BC2
	public static string smethod_8()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "gUFStZa-hX", null);
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x000099DE File Offset: 0x00007BDE
	public static string smethod_9()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "@(3PNZa-h?", null);
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x000099FA File Offset: 0x00007BFA
	public static Task<bool> smethod_10()
	{
		return (Task<bool>)Class392.smethod_3().method_105(Class392.smethod_1(), "E4<6^Za-ia", null);
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00009A16 File Offset: 0x00007C16
	public static string smethod_11()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "S%#f4Za-hD", null);
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
	private static string smethod_12(string string_8, string string_9)
	{
		object[] array = new object[]
		{
			string_8,
			string_9
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "OLMX)Za-iE", array);
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00009A32 File Offset: 0x00007C32
	private static string smethod_13()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "ICHVkZa-hE", null);
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x0004C520 File Offset: 0x0004A720
	private static string smethod_14(string string_8)
	{
		object[] array = new object[]
		{
			string_8
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "EOW?_Za-iF", array);
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00009A4E File Offset: 0x00007C4E
	public static string smethod_15()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "jL;P(Za-hG", null);
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0004C554 File Offset: 0x0004A754
	private static bool smethod_16(string string_8)
	{
		object[] array = new object[]
		{
			string_8
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "Vmj(@Za-iH", array);
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00009A6A File Offset: 0x00007C6A
	private static string smethod_17()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "NjlF'Za-iT", null);
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0004C58C File Offset: 0x0004A78C
	private static void smethod_18(string string_8)
	{
		object[] array = new object[]
		{
			string_8
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "R^]]3Za-iI", array);
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0004C5BC File Offset: 0x0004A7BC
	private static string smethod_19(string string_8)
	{
		object[] array = new object[]
		{
			string_8
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "M79n\"Za-iG", array);
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0004C5F0 File Offset: 0x0004A7F0
	private static void smethod_20(string string_8, string string_9)
	{
		object[] array = new object[]
		{
			string_8,
			string_9
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "2Rg*$Za-iJ", array);
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x0004C624 File Offset: 0x0004A824
	private static void smethod_21(string string_8)
	{
		object[] array = new object[]
		{
			string_8
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Upmb=Za-iJ", array);
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00009A86 File Offset: 0x00007C86
	private static void smethod_22(ref Class216.Struct100 struct100_0)
	{
		struct100_0.asyncTaskMethodBuilder_0.Start<Class216.Struct100>(ref struct100_0);
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x00009A94 File Offset: 0x00007C94
	private static void smethod_23(ref Class216.Struct101 struct101_0)
	{
		struct101_0.asyncTaskMethodBuilder_0.Start<Class216.Struct101>(ref struct101_0);
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x00009AA2 File Offset: 0x00007CA2
	private static void smethod_24(ref Class216.Struct102 struct102_0)
	{
		struct102_0.asyncTaskMethodBuilder_0.Start<Class216.Struct102>(ref struct102_0);
	}

	// Token: 0x04000802 RID: 2050
	private static bool bool_0;

	// Token: 0x04000803 RID: 2051
	private static string string_0;

	// Token: 0x04000804 RID: 2052
	private static string string_1;

	// Token: 0x04000805 RID: 2053
	private static object object_0;

	// Token: 0x04000806 RID: 2054
	private static object object_1;

	// Token: 0x04000807 RID: 2055
	private static string string_2;

	// Token: 0x04000808 RID: 2056
	private static object object_2;

	// Token: 0x04000809 RID: 2057
	private static string string_3;

	// Token: 0x0400080A RID: 2058
	private static object object_3;

	// Token: 0x0400080B RID: 2059
	private static string string_4;

	// Token: 0x0400080C RID: 2060
	private static object object_4;

	// Token: 0x0400080D RID: 2061
	private static readonly object object_5;

	// Token: 0x0400080E RID: 2062
	private static string string_5;

	// Token: 0x0400080F RID: 2063
	private static readonly object object_6;

	// Token: 0x04000810 RID: 2064
	private static string string_6;

	// Token: 0x04000811 RID: 2065
	private static readonly string string_7;

	// Token: 0x020001C0 RID: 448
	[StructLayout(LayoutKind.Auto)]
	private struct Struct100 : IAsyncStateMachine
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x0004C654 File Offset: 0x0004A854
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "\\[SuRZa-iY", array);
			}
			finally
			{
				this = (Class216.Struct100)array[0];
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00009ABE File Offset: 0x00007CBE
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class216.Struct100 struct100_0)
		{
			struct100_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class216.Struct100>(ref taskAwaiter_1, ref struct100_0);
		}

		// Token: 0x04000812 RID: 2066
		public int int_0;

		// Token: 0x04000813 RID: 2067
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000814 RID: 2068
		private StringBuilder stringBuilder_0;

		// Token: 0x04000815 RID: 2069
		private StringBuilder stringBuilder_1;

		// Token: 0x04000816 RID: 2070
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020001C1 RID: 449
	[StructLayout(LayoutKind.Auto)]
	private struct Struct101 : IAsyncStateMachine
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "?+75KZa-i]", array);
			}
			finally
			{
				this = (Class216.Struct101)array[0];
			}
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00009ACD File Offset: 0x00007CCD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00009ADB File Offset: 0x00007CDB
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class216.Struct101 struct101_0)
		{
			struct101_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class216.Struct101>(ref taskAwaiter_1, ref struct101_0);
		}

		// Token: 0x04000817 RID: 2071
		public int int_0;

		// Token: 0x04000818 RID: 2072
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000819 RID: 2073
		private StringBuilder stringBuilder_0;

		// Token: 0x0400081A RID: 2074
		private StringBuilder stringBuilder_1;

		// Token: 0x0400081B RID: 2075
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x020001C2 RID: 450
	private sealed class Class217
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x0004C724 File Offset: 0x0004A924
		internal void method_0()
		{
			while (this.string_0 == string.Empty)
			{
				int num = 0;
				try
				{
					foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						this.string_0 = managementObject["ProcessorId"].ToString();
					}
					goto IL_F2;
				}
				catch
				{
					goto IL_F2;
				}
				goto IL_79;
				IL_DA:
				if (num > 3)
				{
					this.string_0 = "FAILED";
					continue;
				}
				continue;
				IL_79:
				Class808.smethod_27("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\" /v \"SCMApiConnectionParam\"  /t REG_SZ /d \"1000\" /f");
				Thread.Sleep(TimeSpan.FromSeconds(1.0));
				Class808.smethod_27("sc config Winmgmt start= auto");
				Class808.smethod_27("net start Winmgmt");
				Class808.smethod_27("winmgmt /salvagerepository");
				Class808.smethod_27("winmgmt /resetRepository");
				Thread.Sleep(TimeSpan.FromSeconds(1.0));
				num++;
				goto IL_DA;
				IL_F2:
				if (this.string_0 == string.Empty)
				{
					goto IL_79;
				}
				goto IL_DA;
			}
		}

		// Token: 0x0400081C RID: 2076
		public string string_0;
	}

	// Token: 0x020001C3 RID: 451
	[StructLayout(LayoutKind.Auto)]
	private struct Struct102 : IAsyncStateMachine
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x0004C858 File Offset: 0x0004AA58
		void IAsyncStateMachine.MoveNext()
		{
			object[] array = new object[]
			{
				this
			};
			Class31 @class = Class392.smethod_3();
			Stream stream_ = Class392.smethod_1();
			try
			{
				@class.method_64(stream_, "hm^##Za-ic", array);
			}
			finally
			{
				this = (Class216.Struct102)array[0];
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00009AEA File Offset: 0x00007CEA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00009AF8 File Offset: 0x00007CF8
		private static void MoveNext(ref TaskAwaiter<bool> taskAwaiter_1, ref Class216.Struct102 struct102_0)
		{
			struct102_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class216.Struct102>(ref taskAwaiter_1, ref struct102_0);
		}

		// Token: 0x0400081D RID: 2077
		public int int_0;

		// Token: 0x0400081E RID: 2078
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x0400081F RID: 2079
		private TaskAwaiter<bool> taskAwaiter_0;
	}

	// Token: 0x020001C4 RID: 452
	[Serializable]
	private sealed class Class218
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00009B13 File Offset: 0x00007D13
		internal bool method_0(DriveInfo driveInfo_0)
		{
			return driveInfo_0.DriveType == DriveType.Fixed;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0004C8C0 File Offset: 0x0004AAC0
		internal bool method_1()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
				try
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							if (managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL") || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
				}
				finally
				{
					((IDisposable)managementObjectSearcher).Dispose();
				}
			}
			catch
			{
			}
			return Directory.Exists("C:\\Program Files\\VMware\\VMware Tools") || Class808.smethod_33("chcp 437 & wmic /namespace:\\\\root\\WMI path MSAcpi_ThermalZoneTemperature get CurrentTemperature").smethod_3("Error");
		}

		// Token: 0x04000820 RID: 2080
		public static readonly Class216.Class218 class218_0 = new Class216.Class218();

		// Token: 0x04000821 RID: 2081
		public static Func<DriveInfo, bool> func_0;

		// Token: 0x04000822 RID: 2082
		public static Func<bool> func_1;
	}
}
