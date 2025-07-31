using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

// Token: 0x0200039A RID: 922
internal sealed class Class424
{
	// Token: 0x060017DA RID: 6106 RVA: 0x000104A3 File Offset: 0x0000E6A3
	public static void smethod_0()
	{
		Class808.smethod_27("reg delete \"HKEY_CLASSES_ROOT\\BoosterX\" /f");
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x0006CBBC File Offset: 0x0006ADBC
	public static string smethod_1()
	{
		if (Class424.string_1 != null)
		{
			return Class424.string_1;
		}
		string[] array = Class424.smethod_2().Split(new char[]
		{
			'.'
		});
		Class424.string_1 = array[0] + "." + array[1];
		return Class424.string_1;
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x0006CC08 File Offset: 0x0006AE08
	public static string smethod_2()
	{
		FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Process.GetCurrentProcess().MainModule.FileName);
		string result;
		if ((result = Class424.string_0) == null)
		{
			result = (Class424.string_0 = versionInfo.ProductVersion);
		}
		return result;
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x0006CC40 File Offset: 0x0006AE40
	public static bool smethod_3(string string_2)
	{
		bool result;
		try
		{
			result = (Version.Parse(Class424.smethod_2().Replace(',', '.')).CompareTo(Version.Parse(string_2)) < 0);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x0006CC88 File Offset: 0x0006AE88
	public static void smethod_4()
	{
		Class424.Struct213 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class424.Struct213>(ref @struct);
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x0006CCB8 File Offset: 0x0006AEB8
	public static string smethod_5()
	{
		string result;
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(Process.GetCurrentProcess().MainModule.FileName))
			{
				result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", string.Empty).ToLowerInvariant();
			}
		}
		return result;
	}

	// Token: 0x04000FDB RID: 4059
	private static string string_0;

	// Token: 0x04000FDC RID: 4060
	private static string string_1;

	// Token: 0x04000FDD RID: 4061
	public static IntPtr intptr_0 = Process.GetCurrentProcess().MainWindowHandle;

	// Token: 0x0200039B RID: 923
	[StructLayout(LayoutKind.Auto)]
	private struct Struct213 : IAsyncStateMachine
	{
		// Token: 0x060017E0 RID: 6112 RVA: 0x0006CD38 File Offset: 0x0006AF38
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class424.Class425.class425_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class424.Struct213>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000104B0 File Offset: 0x0000E6B0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000FDE RID: 4062
		public int int_0;

		// Token: 0x04000FDF RID: 4063
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000FE0 RID: 4064
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200039C RID: 924
	[Serializable]
	private sealed class Class425
	{
		// Token: 0x060017E4 RID: 6116 RVA: 0x0000311B File Offset: 0x0000131B
		internal void method_0()
		{
		}

		// Token: 0x04000FE1 RID: 4065
		public static readonly Class424.Class425 class425_0 = new Class424.Class425();

		// Token: 0x04000FE2 RID: 4066
		public static Action action_0;
	}
}
