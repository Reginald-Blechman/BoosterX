using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;

// Token: 0x020006B9 RID: 1721
internal sealed class Class834
{
	// Token: 0x06002B6F RID: 11119 RVA: 0x000A6F58 File Offset: 0x000A5158
	public static void smethod_0()
	{
		Class834.Struct459 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class834.Struct459>(ref @struct);
	}

	// Token: 0x020006BA RID: 1722
	[StructLayout(LayoutKind.Auto)]
	private struct Struct459 : IAsyncStateMachine
	{
		// Token: 0x06002B70 RID: 11120 RVA: 0x000A6F88 File Offset: 0x000A5188
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class834.Class835.class835_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class834.Struct459>(ref awaiter, ref this);
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

		// Token: 0x06002B71 RID: 11121 RVA: 0x0001C0F9 File Offset: 0x0001A2F9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C3A RID: 7226
		public int int_0;

		// Token: 0x04001C3B RID: 7227
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C3C RID: 7228
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006BB RID: 1723
	[Serializable]
	private sealed class Class835
	{
		// Token: 0x06002B74 RID: 11124 RVA: 0x000A7054 File Offset: 0x000A5254
		internal void method_0()
		{
			List<ServiceController> list = ServiceController.GetServices().Where(new Func<ServiceController, bool>(Class834.Class835.class835_0.method_1)).ToList<ServiceController>();
			list.AddRange(ServiceController.GetDevices().Where(new Func<ServiceController, bool>(Class834.Class835.class835_0.method_2)));
			list.ForEach(new Action<ServiceController>(Class834.Class835.class835_0.method_3));
			Class808.smethod_30("sc stop inpoutx64");
			Class808.smethod_30("sc delete inpoutx64");
			Directory.GetFiles(Class169.string_4).ToList<string>().ForEach(new Action<string>(Class834.Class835.class835_0.method_4));
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0001C113 File Offset: 0x0001A313
		internal bool method_1(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName.StartsWith("R0BoosterX");
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x0001C113 File Offset: 0x0001A313
		internal bool method_2(ServiceController serviceController_0)
		{
			return serviceController_0.ServiceName.StartsWith("R0BoosterX");
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x0001C126 File Offset: 0x0001A326
		internal void method_3(ServiceController serviceController_0)
		{
			serviceController_0.Stop();
			Class808.smethod_30(string.Format("sc delete {0}", serviceController_0));
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000A712C File Offset: 0x000A532C
		internal void method_4(string string_0)
		{
			try
			{
				File.Delete(string_0);
			}
			catch
			{
			}
		}

		// Token: 0x04001C3D RID: 7229
		public static readonly Class834.Class835 class835_0 = new Class834.Class835();

		// Token: 0x04001C3E RID: 7230
		public static Func<ServiceController, bool> func_0;

		// Token: 0x04001C3F RID: 7231
		public static Func<ServiceController, bool> func_1;

		// Token: 0x04001C40 RID: 7232
		public static Action<ServiceController> action_0;

		// Token: 0x04001C41 RID: 7233
		public static Action<string> action_1;

		// Token: 0x04001C42 RID: 7234
		public static Action action_2;
	}
}
