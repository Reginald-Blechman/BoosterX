using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x020001B8 RID: 440
internal sealed class Class215
{
	// Token: 0x06000C51 RID: 3153 RVA: 0x0000972D File Offset: 0x0000792D
	static Class215()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "6+\"&,Za-i#", null);
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00009744 File Offset: 0x00007944
	public static Task<bool> smethod_0()
	{
		return (Task<bool>)Class392.smethod_3().method_105(Class392.smethod_1(), "Za[?LZa-il", null);
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x0004C07C File Offset: 0x0004A27C
	public static Task<Class723> smethod_1(string string_0, object object_0)
	{
		object[] object_ = new object[]
		{
			string_0,
			object_0
		};
		return (Task<Class723>)Class392.smethod_3().method_105(Class392.smethod_1(), "E4<6^Za-k%", object_);
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00009760 File Offset: 0x00007960
	private static void smethod_2(ref Class215.Struct98 struct98_0)
	{
		struct98_0.asyncTaskMethodBuilder_0.Start<Class215.Struct98>(ref struct98_0);
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x0000976E File Offset: 0x0000796E
	private static void smethod_3(ref Class215.Struct99 struct99_0)
	{
		struct99_0.asyncTaskMethodBuilder_0.Start<Class215.Struct99>(ref struct99_0);
	}

	// Token: 0x040007E5 RID: 2021
	public static Struct9 struct9_0;

	// Token: 0x040007E6 RID: 2022
	public static Struct9 struct9_1;

	// Token: 0x040007E7 RID: 2023
	public static Struct14 struct14_0;

	// Token: 0x040007E8 RID: 2024
	private static Struct14 struct14_1;

	// Token: 0x040007E9 RID: 2025
	public static Struct9 struct9_2;

	// Token: 0x040007EA RID: 2026
	private static readonly SemaphoreSlim semaphoreSlim_0;

	// Token: 0x040007EB RID: 2027
	private static readonly HttpClient httpClient_0;

	// Token: 0x020001B9 RID: 441
	[StructLayout(LayoutKind.Auto)]
	private struct Struct98 : IAsyncStateMachine
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x0004C0B4 File Offset: 0x0004A2B4
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
				@class.method_64(stream_, "YICpHZa-jp", array);
			}
			finally
			{
				this = (Class215.Struct98)array[0];
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0000977C File Offset: 0x0000797C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0000978A File Offset: 0x0000798A
		private static void MoveNext(ref TaskAwaiter taskAwaiter_2, ref Class215.Struct98 struct98_0)
		{
			struct98_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class215.Struct98>(ref taskAwaiter_2, ref struct98_0);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0000978A File Offset: 0x0000798A
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_2, ref Class215.Struct98 struct98_0)
		{
			struct98_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class215.Struct98>(ref taskAwaiter_2, ref struct98_0);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00009799 File Offset: 0x00007999
		private static void MoveNext_2(ref TaskAwaiter<string> taskAwaiter_2, ref Class215.Struct98 struct98_0)
		{
			struct98_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class215.Struct98>(ref taskAwaiter_2, ref struct98_0);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000097A8 File Offset: 0x000079A8
		private static void MoveNext_3(ref ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class215.Struct98 struct98_0)
		{
			struct98_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, Class215.Struct98>(ref configuredTaskAwaiter_2, ref struct98_0);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000097B7 File Offset: 0x000079B7
		private static void MoveNext_4(ref ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class215.Struct98 struct98_0)
		{
			struct98_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, Class215.Struct98>(ref configuredTaskAwaiter_2, ref struct98_0);
		}

		// Token: 0x040007EC RID: 2028
		public int int_0;

		// Token: 0x040007ED RID: 2029
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x040007EE RID: 2030
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x040007EF RID: 2031
		private TaskAwaiter<string> taskAwaiter_1;

		// Token: 0x040007F0 RID: 2032
		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		// Token: 0x040007F1 RID: 2033
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;
	}

	// Token: 0x020001BA RID: 442
	[StructLayout(LayoutKind.Auto)]
	private struct Struct99 : IAsyncStateMachine
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x0004C11C File Offset: 0x0004A31C
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
				@class.method_64(stream_, "W401AZa-j_", array);
			}
			finally
			{
				this = (Class215.Struct99)array[0];
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000097C6 File Offset: 0x000079C6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000097D4 File Offset: 0x000079D4
		private static void MoveNext(ref TaskAwaiter<bool> taskAwaiter_1, ref Class215.Struct99 struct99_0)
		{
			struct99_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class215.Struct99>(ref taskAwaiter_1, ref struct99_0);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000097E3 File Offset: 0x000079E3
		private static void MoveNext_1(ref ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class215.Struct99 struct99_0)
		{
			struct99_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, Class215.Struct99>(ref configuredTaskAwaiter_2, ref struct99_0);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000097F2 File Offset: 0x000079F2
		private static void MoveNext_2(ref ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_2, ref Class215.Struct99 struct99_0)
		{
			struct99_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, Class215.Struct99>(ref configuredTaskAwaiter_2, ref struct99_0);
		}

		// Token: 0x040007F2 RID: 2034
		public int int_0;

		// Token: 0x040007F3 RID: 2035
		public AsyncTaskMethodBuilder<Class723> asyncTaskMethodBuilder_0;

		// Token: 0x040007F4 RID: 2036
		public object object_0;

		// Token: 0x040007F5 RID: 2037
		public string string_0;

		// Token: 0x040007F6 RID: 2038
		private TaskAwaiter<bool> taskAwaiter_0;

		// Token: 0x040007F7 RID: 2039
		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		// Token: 0x040007F8 RID: 2040
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;
	}
}
