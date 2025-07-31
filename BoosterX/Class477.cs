using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x0200042C RID: 1068
internal sealed class Class477
{
	// Token: 0x06001BD4 RID: 7124 RVA: 0x00012A1A File Offset: 0x00010C1A
	// Note: this type is marked as 'beforefieldinit'.
	static Class477()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "D7?p[Za-i3", null);
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00012A31 File Offset: 0x00010C31
	public static Task<GClass58> smethod_0()
	{
		return (Task<GClass58>)Class392.smethod_3().method_105(Class392.smethod_1(), "Za@-IZa-jB", null);
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x00012A4D File Offset: 0x00010C4D
	private static void smethod_1(ref Class477.Struct268 struct268_0)
	{
		struct268_0.asyncTaskMethodBuilder_0.Start<Class477.Struct268>(ref struct268_0);
	}

	// Token: 0x0400128E RID: 4750
	public static GClass135 gclass135_0;

	// Token: 0x0400128F RID: 4751
	private static string string_0;

	// Token: 0x0200042D RID: 1069
	[StructLayout(LayoutKind.Auto)]
	private struct Struct268 : IAsyncStateMachine
	{
		// Token: 0x06001BD7 RID: 7127 RVA: 0x00076F70 File Offset: 0x00075170
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
				@class.method_64(stream_, "qm<c<Za-jF", array);
			}
			finally
			{
				this = (Class477.Struct268)array[0];
			}
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00012A5B File Offset: 0x00010C5B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00012A69 File Offset: 0x00010C69
		private static void MoveNext(ref TaskAwaiter<GClass58> taskAwaiter_1, ref Class477.Struct268 struct268_0)
		{
			struct268_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GClass58>, Class477.Struct268>(ref taskAwaiter_1, ref struct268_0);
		}

		// Token: 0x04001290 RID: 4752
		public int int_0;

		// Token: 0x04001291 RID: 4753
		public AsyncTaskMethodBuilder<GClass58> asyncTaskMethodBuilder_0;

		// Token: 0x04001292 RID: 4754
		private TaskAwaiter<GClass58> taskAwaiter_0;
	}

	// Token: 0x0200042E RID: 1070
	[Serializable]
	private sealed class Class478
	{
		// Token: 0x06001BDC RID: 7132 RVA: 0x00076FD8 File Offset: 0x000751D8
		internal GClass58 method_0()
		{
			Class477.gclass135_0 = new GClass135(Class477.string_0);
			GClass58 gclass = new GClass58();
			double? num = Class551.class753_0.method_50();
			double num2 = (double)2f;
			if ((num.GetValueOrDefault() == num2 & num != null) && Class733.smethod_0())
			{
				gclass.Model = "deepseek-reasoner";
			}
			else
			{
				gclass.Model = "deepseek-chat";
			}
			return gclass;
		}

		// Token: 0x04001293 RID: 4755
		public static readonly Class477.Class478 class478_0 = new Class477.Class478();

		// Token: 0x04001294 RID: 4756
		public static Func<GClass58> func_0;
	}
}
