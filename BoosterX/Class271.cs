using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x02000247 RID: 583
internal sealed class Class271
{
	// Token: 0x06000FE0 RID: 4064 RVA: 0x000558C8 File Offset: 0x00053AC8
	public static void smethod_0(string string_1)
	{
		object[] object_ = new object[]
		{
			string_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Za[?LZa-hr", object_);
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0000BA23 File Offset: 0x00009C23
	public static string smethod_1()
	{
		return Class271.string_0;
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0000BA2A File Offset: 0x00009C2A
	public static void smethod_2(string string_1)
	{
		Class271.string_0 = string_1;
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x000558F8 File Offset: 0x00053AF8
	public static void smethod_3(string string_1, double double_0)
	{
		object[] object_ = new object[]
		{
			string_1,
			double_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "M79n\"Za-ht", object_);
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0000BA32 File Offset: 0x00009C32
	private static void smethod_4(ref Class271.Struct137 struct137_0)
	{
		struct137_0.asyncVoidMethodBuilder_0.Start<Class271.Struct137>(ref struct137_0);
	}

	// Token: 0x04000A11 RID: 2577
	private static string string_0;

	// Token: 0x02000248 RID: 584
	[StructLayout(LayoutKind.Auto)]
	private struct Struct137 : IAsyncStateMachine
	{
		// Token: 0x06000FE5 RID: 4069 RVA: 0x00055930 File Offset: 0x00053B30
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
				@class.method_64(stream_, "<k#KDZa-i\"", array);
			}
			finally
			{
				this = (Class271.Struct137)array[0];
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0000BA40 File Offset: 0x00009C40
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0000BA4E File Offset: 0x00009C4E
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class271.Struct137 struct137_0)
		{
			struct137_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct137>(ref taskAwaiter_1, ref struct137_0);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0000BA4E File Offset: 0x00009C4E
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class271.Struct137 struct137_0)
		{
			struct137_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class271.Struct137>(ref taskAwaiter_1, ref struct137_0);
		}

		// Token: 0x04000A12 RID: 2578
		public int int_0;

		// Token: 0x04000A13 RID: 2579
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000A14 RID: 2580
		public string string_0;

		// Token: 0x04000A15 RID: 2581
		public double double_0;

		// Token: 0x04000A16 RID: 2582
		private DateTime dateTime_0;

		// Token: 0x04000A17 RID: 2583
		private DateTime dateTime_1;

		// Token: 0x04000A18 RID: 2584
		private bool bool_0;

		// Token: 0x04000A19 RID: 2585
		private SHA256 sha256_0;

		// Token: 0x04000A1A RID: 2586
		private TaskAwaiter taskAwaiter_0;
	}
}
