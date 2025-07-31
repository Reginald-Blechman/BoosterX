using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200019B RID: 411
internal sealed class Class202
{
	// Token: 0x06000BAC RID: 2988 RVA: 0x0004A4F4 File Offset: 0x000486F4
	private static uint smethod_0(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (uint)Class392.smethod_3().method_105(Class392.smethod_1(), ".^ugmZa-i*", object_);
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x0004A52C File Offset: 0x0004872C
	public static bool smethod_1(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "caU<hZa-i,", object_);
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x0004A564 File Offset: 0x00048764
	public static bool smethod_2(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "ag\\[bZa-i-", object_);
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00009242 File Offset: 0x00007442
	public static void smethod_3()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "L:=RtZa-i0", null);
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00009259 File Offset: 0x00007459
	private static void smethod_4(ref Class202.Struct85 struct85_0)
	{
		struct85_0.asyncVoidMethodBuilder_0.Start<Class202.Struct85>(ref struct85_0);
	}

	// Token: 0x0200019C RID: 412
	[StructLayout(LayoutKind.Auto)]
	private struct Struct85 : IAsyncStateMachine
	{
		// Token: 0x06000BB1 RID: 2993 RVA: 0x0004A59C File Offset: 0x0004879C
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
				@class.method_64(stream_, ")7R#\\Za-i1", array);
			}
			finally
			{
				this = (Class202.Struct85)array[0];
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00009267 File Offset: 0x00007467
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00009275 File Offset: 0x00007475
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class202.Struct85 struct85_0)
		{
			struct85_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class202.Struct85>(ref taskAwaiter_1, ref struct85_0);
		}

		// Token: 0x04000783 RID: 1923
		public int int_0;

		// Token: 0x04000784 RID: 1924
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000785 RID: 1925
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200019D RID: 413
	[Serializable]
	private sealed class Class203
	{
		// Token: 0x06000BB6 RID: 2998 RVA: 0x0004A604 File Offset: 0x00048804
		internal void method_0()
		{
			string fileName = Process.GetCurrentProcess().MainModule.FileName;
			if (!Class202.smethod_1(fileName) && !Class202.smethod_2(fileName))
			{
				Class733.smethod_1(false);
				Class402.smethod_3();
			}
		}

		// Token: 0x04000786 RID: 1926
		public static readonly Class202.Class203 class203_0 = new Class202.Class203();

		// Token: 0x04000787 RID: 1927
		public static Action action_0;
	}
}
