using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x020004E5 RID: 1253
internal sealed class Class598
{
	// Token: 0x06001FCF RID: 8143 RVA: 0x000150EC File Offset: 0x000132EC
	// Note: this type is marked as 'beforefieldinit'.
	static Class598()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "q6[Q:Za-ik", null);
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x00015103 File Offset: 0x00013303
	public static Task<GClass56> smethod_0()
	{
		return (Task<GClass56>)Class392.smethod_3().method_105(Class392.smethod_1(), "&[\\sQZa-in", null);
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x0001511F File Offset: 0x0001331F
	public static Task<GClass56> smethod_1()
	{
		return (Task<GClass56>)Class392.smethod_3().method_105(Class392.smethod_1(), "oX)$5Za-k,", null);
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x0001513B File Offset: 0x0001333B
	private static void smethod_2(ref Class598.Struct331 struct331_0)
	{
		struct331_0.asyncTaskMethodBuilder_0.Start<Class598.Struct331>(ref struct331_0);
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x00015149 File Offset: 0x00013349
	private static void smethod_3(ref Class598.Struct330 struct330_0)
	{
		struct330_0.asyncTaskMethodBuilder_0.Start<Class598.Struct330>(ref struct330_0);
	}

	// Token: 0x04001538 RID: 5432
	private static GClass11 gclass11_0;

	// Token: 0x04001539 RID: 5433
	private static string string_0;

	// Token: 0x020004E6 RID: 1254
	[StructLayout(LayoutKind.Auto)]
	private struct Struct330 : IAsyncStateMachine
	{
		// Token: 0x06001FD4 RID: 8148 RVA: 0x00081460 File Offset: 0x0007F660
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
				@class.method_64(stream_, "o<bp4Za-k-", array);
			}
			finally
			{
				this = (Class598.Struct330)array[0];
			}
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00015157 File Offset: 0x00013357
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00015165 File Offset: 0x00013365
		private static void MoveNext(ref TaskAwaiter<GClass56> taskAwaiter_1, ref Class598.Struct330 struct330_0)
		{
			struct330_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass56>, Class598.Struct330>(ref taskAwaiter_1, ref struct330_0);
		}

		// Token: 0x0400153A RID: 5434
		public int int_0;

		// Token: 0x0400153B RID: 5435
		public AsyncTaskMethodBuilder<GClass56> asyncTaskMethodBuilder_0;

		// Token: 0x0400153C RID: 5436
		private TaskAwaiter<GClass56> taskAwaiter_0;
	}

	// Token: 0x020004E7 RID: 1255
	[StructLayout(LayoutKind.Auto)]
	private struct Struct331 : IAsyncStateMachine
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x000814C8 File Offset: 0x0007F6C8
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
				@class.method_64(stream_, "Z*^pGZa-is", array);
			}
			finally
			{
				this = (Class598.Struct331)array[0];
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00015174 File Offset: 0x00013374
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00015182 File Offset: 0x00013382
		private static void MoveNext(ref TaskAwaiter<GClass56> taskAwaiter_1, ref Class598.Struct331 struct331_0)
		{
			struct331_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass56>, Class598.Struct331>(ref taskAwaiter_1, ref struct331_0);
		}

		// Token: 0x0400153D RID: 5437
		public int int_0;

		// Token: 0x0400153E RID: 5438
		public AsyncTaskMethodBuilder<GClass56> asyncTaskMethodBuilder_0;

		// Token: 0x0400153F RID: 5439
		private TaskAwaiter<GClass56> taskAwaiter_0;
	}

	// Token: 0x020004E8 RID: 1256
	[Serializable]
	private sealed class Class599
	{
		// Token: 0x06001FDC RID: 8156 RVA: 0x00081530 File Offset: 0x0007F730
		internal GClass56 method_0()
		{
			Class598.gclass11_0 = new GClass11(Class598.string_0);
			GClass56 gclass = Class598.gclass11_0.imethod_6().imethod_2(null);
			gclass.method_0().String_0 = GClass27.smethod_14();
			gclass.method_0().Nullable_0 = new double?(0.4);
			return gclass;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00081530 File Offset: 0x0007F730
		internal GClass56 method_1()
		{
			Class598.gclass11_0 = new GClass11(Class598.string_0);
			GClass56 gclass = Class598.gclass11_0.imethod_6().imethod_2(null);
			gclass.method_0().String_0 = GClass27.smethod_14();
			gclass.method_0().Nullable_0 = new double?(0.4);
			return gclass;
		}

		// Token: 0x04001540 RID: 5440
		public static readonly Class598.Class599 class599_0 = new Class598.Class599();

		// Token: 0x04001541 RID: 5441
		public static Func<GClass56> func_0;

		// Token: 0x04001542 RID: 5442
		public static Func<GClass56> func_1;
	}
}
