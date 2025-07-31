using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020003BA RID: 954
internal sealed class Class437
{
	// Token: 0x06001928 RID: 6440 RVA: 0x000111C8 File Offset: 0x0000F3C8
	// Note: this type is marked as 'beforefieldinit'.
	static Class437()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "@C3GLZa-jc", null);
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x0006F3BC File Offset: 0x0006D5BC
	public static Task smethod_0(int int_0)
	{
		object[] object_ = new object[]
		{
			int_0
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "UpRP:Za-jf", object_);
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x0006F3F4 File Offset: 0x0006D5F4
	public static Task<bool> smethod_1(Uri uri_4, int int_0)
	{
		object[] object_ = new object[]
		{
			uri_4,
			int_0
		};
		return (Task<bool>)Class392.smethod_3().method_105(Class392.smethod_1(), "-+((eZa-jW", object_);
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x0006F430 File Offset: 0x0006D630
	public static Uri smethod_2(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (Uri)Class392.smethod_3().method_105(Class392.smethod_1(), "W3it>Za-hk", object_);
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x000111DF File Offset: 0x0000F3DF
	private static void smethod_3(ref Class437.Struct226 struct226_0)
	{
		struct226_0.asyncTaskMethodBuilder_0.Start<Class437.Struct226>(ref struct226_0);
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x000111ED File Offset: 0x0000F3ED
	private static void smethod_4(ref Class437.Struct227 struct227_0)
	{
		struct227_0.asyncTaskMethodBuilder_0.Start<Class437.Struct227>(ref struct227_0);
	}

	// Token: 0x04001084 RID: 4228
	private static GClass128 gclass128_0;

	// Token: 0x04001085 RID: 4229
	public static bool bool_0;

	// Token: 0x04001086 RID: 4230
	private static readonly Uri uri_0;

	// Token: 0x04001087 RID: 4231
	private static readonly Uri uri_1;

	// Token: 0x04001088 RID: 4232
	private static readonly Uri uri_2;

	// Token: 0x04001089 RID: 4233
	private static readonly Uri uri_3;

	// Token: 0x0400108A RID: 4234
	private static HttpClient httpClient_0;

	// Token: 0x020003BB RID: 955
	[StructLayout(LayoutKind.Auto)]
	private struct Struct226 : IAsyncStateMachine
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x0006F464 File Offset: 0x0006D664
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
				@class.method_64(stream_, "J@)_kZa-jO", array);
			}
			finally
			{
				this = (Class437.Struct226)array[0];
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000111FB File Offset: 0x0000F3FB
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00011209 File Offset: 0x0000F409
		private static void MoveNext(ref TaskAwaiter<Task> taskAwaiter_2, ref Class437.Struct226 struct226_0)
		{
			struct226_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class437.Struct226>(ref taskAwaiter_2, ref struct226_0);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00011218 File Offset: 0x0000F418
		private static void MoveNext_1(ref TaskAwaiter<bool[]> taskAwaiter_2, ref Class437.Struct226 struct226_0)
		{
			struct226_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool[]>, Class437.Struct226>(ref taskAwaiter_2, ref struct226_0);
		}

		// Token: 0x0400108B RID: 4235
		public int int_0;

		// Token: 0x0400108C RID: 4236
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400108D RID: 4237
		public int int_1;

		// Token: 0x0400108E RID: 4238
		private Uri uri_0;

		// Token: 0x0400108F RID: 4239
		private Task<bool> task_0;

		// Token: 0x04001090 RID: 4240
		private Task<bool> task_1;

		// Token: 0x04001091 RID: 4241
		private Task<bool> task_2;

		// Token: 0x04001092 RID: 4242
		private Task<bool[]> task_3;

		// Token: 0x04001093 RID: 4243
		private TaskAwaiter<Task> taskAwaiter_0;

		// Token: 0x04001094 RID: 4244
		private TaskAwaiter<bool[]> taskAwaiter_1;
	}

	// Token: 0x020003BC RID: 956
	[StructLayout(LayoutKind.Auto)]
	private struct Struct227 : IAsyncStateMachine
	{
		// Token: 0x06001932 RID: 6450 RVA: 0x0006F4CC File Offset: 0x0006D6CC
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
				@class.method_64(stream_, "V6mY;Za-j[", array);
			}
			finally
			{
				this = (Class437.Struct227)array[0];
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00011227 File Offset: 0x0000F427
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00011235 File Offset: 0x0000F435
		private static void MoveNext(ref TaskAwaiter<Task> taskAwaiter_2, ref Class437.Struct227 struct227_0)
		{
			struct227_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class437.Struct227>(ref taskAwaiter_2, ref struct227_0);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00011244 File Offset: 0x0000F444
		private static void MoveNext_1(ref TaskAwaiter<HttpResponseMessage> taskAwaiter_2, ref Class437.Struct227 struct227_0)
		{
			struct227_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, Class437.Struct227>(ref taskAwaiter_2, ref struct227_0);
		}

		// Token: 0x04001095 RID: 4245
		public int int_0;

		// Token: 0x04001096 RID: 4246
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x04001097 RID: 4247
		public Uri uri_0;

		// Token: 0x04001098 RID: 4248
		public int int_1;

		// Token: 0x04001099 RID: 4249
		private Task<HttpResponseMessage> task_0;

		// Token: 0x0400109A RID: 4250
		private Task task_1;

		// Token: 0x0400109B RID: 4251
		private TaskAwaiter<Task> taskAwaiter_0;

		// Token: 0x0400109C RID: 4252
		private TaskAwaiter<HttpResponseMessage> taskAwaiter_1;
	}
}
