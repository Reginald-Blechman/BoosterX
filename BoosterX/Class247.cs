using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200020E RID: 526
internal sealed class Class247
{
	// Token: 0x06000E42 RID: 3650 RVA: 0x0000AA65 File Offset: 0x00008C65
	// Note: this type is marked as 'beforefieldinit'.
	static Class247()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "0\"86qZa-iK", null);
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x0000AA7C File Offset: 0x00008C7C
	public static Task<string> smethod_0()
	{
		return (Task<string>)Class392.smethod_3().method_105(Class392.smethod_1(), "1q0m\"Za-iN", null);
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x0000AA98 File Offset: 0x00008C98
	public static Task<string> smethod_1()
	{
		return (Task<string>)Class392.smethod_3().method_105(Class392.smethod_1(), "-F^CiZa-i8", null);
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x0000AAB4 File Offset: 0x00008CB4
	public static Task<string> smethod_2()
	{
		return (Task<string>)Class392.smethod_3().method_105(Class392.smethod_1(), "WOK:BZa-i>", null);
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x000511F8 File Offset: 0x0004F3F8
	public static bool smethod_3(string string_3)
	{
		object[] object_ = new object[]
		{
			string_3
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "(q6o[Za-iB", object_);
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x0000AAD0 File Offset: 0x00008CD0
	private static void smethod_4(ref Class247.Struct126 struct126_0)
	{
		struct126_0.asyncTaskMethodBuilder_0.Start<Class247.Struct126>(ref struct126_0);
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x0000AADE File Offset: 0x00008CDE
	private static void smethod_5(ref Class247.Struct124 struct124_0)
	{
		struct124_0.asyncTaskMethodBuilder_0.Start<Class247.Struct124>(ref struct124_0);
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x0000AAEC File Offset: 0x00008CEC
	private static void smethod_6(ref Class247.Struct125 struct125_0)
	{
		struct125_0.asyncTaskMethodBuilder_0.Start<Class247.Struct125>(ref struct125_0);
	}

	// Token: 0x04000929 RID: 2345
	private static readonly SemaphoreSlim semaphoreSlim_0;

	// Token: 0x0400092A RID: 2346
	public static string string_0;

	// Token: 0x0400092B RID: 2347
	public static string string_1;

	// Token: 0x0400092C RID: 2348
	public static string string_2;

	// Token: 0x0400092D RID: 2349
	private static List<string> list_0;

	// Token: 0x0200020F RID: 527
	[StructLayout(LayoutKind.Auto)]
	private struct Struct124 : IAsyncStateMachine
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x00051230 File Offset: 0x0004F430
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
				@class.method_64(stream_, "#e.4KZa-i:", array);
			}
			finally
			{
				this = (Class247.Struct124)array[0];
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0000AAFA File Offset: 0x00008CFA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0000AB08 File Offset: 0x00008D08
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class247.Struct124 struct124_0)
		{
			struct124_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class247.Struct124>(ref taskAwaiter_1, ref struct124_0);
		}

		// Token: 0x0400092E RID: 2350
		public int int_0;

		// Token: 0x0400092F RID: 2351
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000930 RID: 2352
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x02000210 RID: 528
	[StructLayout(LayoutKind.Auto)]
	private struct Struct125 : IAsyncStateMachine
	{
		// Token: 0x06000E4D RID: 3661 RVA: 0x00051298 File Offset: 0x0004F498
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
				@class.method_64(stream_, "S@>o5Za-i?", array);
			}
			finally
			{
				this = (Class247.Struct125)array[0];
			}
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0000AB17 File Offset: 0x00008D17
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0000AB25 File Offset: 0x00008D25
		private static void MoveNext(ref TaskAwaiter<string> taskAwaiter_1, ref Class247.Struct125 struct125_0)
		{
			struct125_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class247.Struct125>(ref taskAwaiter_1, ref struct125_0);
		}

		// Token: 0x04000931 RID: 2353
		public int int_0;

		// Token: 0x04000932 RID: 2354
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000933 RID: 2355
		private TaskAwaiter<string> taskAwaiter_0;
	}

	// Token: 0x02000211 RID: 529
	[StructLayout(LayoutKind.Auto)]
	private struct Struct126 : IAsyncStateMachine
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x00051300 File Offset: 0x0004F500
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
				@class.method_64(stream_, ".^ugmZa-iQ", array);
			}
			finally
			{
				this = (Class247.Struct126)array[0];
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0000AB34 File Offset: 0x00008D34
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0000AB42 File Offset: 0x00008D42
		private static void MoveNext(ref TaskAwaiter taskAwaiter_2, ref Class247.Struct126 struct126_0)
		{
			struct126_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class247.Struct126>(ref taskAwaiter_2, ref struct126_0);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0000AB51 File Offset: 0x00008D51
		private static void MoveNext_1(ref TaskAwaiter<string> taskAwaiter_2, ref Class247.Struct126 struct126_0)
		{
			struct126_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class247.Struct126>(ref taskAwaiter_2, ref struct126_0);
		}

		// Token: 0x04000934 RID: 2356
		public int int_0;

		// Token: 0x04000935 RID: 2357
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04000936 RID: 2358
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000937 RID: 2359
		private HttpClient httpClient_0;

		// Token: 0x04000938 RID: 2360
		private string string_0;

		// Token: 0x04000939 RID: 2361
		private List<string>.Enumerator enumerator_0;

		// Token: 0x0400093A RID: 2362
		private TaskAwaiter<string> taskAwaiter_1;
	}

	// Token: 0x02000212 RID: 530
	[Serializable]
	private sealed class Class248
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x00051368 File Offset: 0x0004F568
		internal string method_0()
		{
			try
			{
				List<string> list = new List<string>();
				foreach (IPAddress ipaddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
				{
					if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
					{
						list.Add(ipaddress.ToString());
					}
				}
				Class247.string_1 = list.Last<string>();
			}
			catch
			{
			}
			finally
			{
				if (Class247.string_1 == string.Empty)
				{
					Class247.string_1 = "1";
				}
			}
			return Class247.string_1;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00051400 File Offset: 0x0004F600
		internal string method_1()
		{
			try
			{
				Class247.string_2 = NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(Class247.Class248.class248_0.method_2)).Select(new Func<NetworkInterface, string>(Class247.Class248.class248_0.method_3)).FirstOrDefault<string>();
			}
			catch
			{
			}
			finally
			{
				if (Class247.string_2 == string.Empty)
				{
					Class247.string_2 = "1";
				}
			}
			return Class247.string_2;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0000AB6C File Offset: 0x00008D6C
		internal bool method_2(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.OperationalStatus == OperationalStatus.Up;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0000AB77 File Offset: 0x00008D77
		internal string method_3(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.GetPhysicalAddress().ToString();
		}

		// Token: 0x0400093B RID: 2363
		public static readonly Class247.Class248 class248_0 = new Class247.Class248();

		// Token: 0x0400093C RID: 2364
		public static Func<string> func_0;

		// Token: 0x0400093D RID: 2365
		public static Func<NetworkInterface, bool> func_1;

		// Token: 0x0400093E RID: 2366
		public static Func<NetworkInterface, string> func_2;

		// Token: 0x0400093F RID: 2367
		public static Func<string> func_3;
	}
}
