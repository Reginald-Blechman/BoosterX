using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;
using PIManagerX;

// Token: 0x020004F2 RID: 1266
internal sealed class Class605
{
	// Token: 0x06002024 RID: 8228 RVA: 0x00082740 File Offset: 0x00080940
	public static Task smethod_0()
	{
		Class605.Struct335 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class605.Struct335>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x0008277C File Offset: 0x0008097C
	public static void smethod_1()
	{
		try
		{
			using (WindowsIdentity current = WindowsIdentity.GetCurrent(TokenAccessLevels.Query | TokenAccessLevels.AdjustPrivileges))
			{
				PManagerX.TokPriv1Luid tokPriv1Luid;
				tokPriv1Luid.Count = 1;
				tokPriv1Luid.Luid = 0L;
				tokPriv1Luid.Attr = 2;
				PManagerX.LookupPrivilegeValue(null, "SeProfileSingleProcessPrivilege", ref tokPriv1Luid.Luid);
				PManagerX.AdjustTokenPrivileges(current.Token, false, ref tokPriv1Luid, 0, IntPtr.Zero, IntPtr.Zero);
				int num = 80;
				int structure = 4;
				PManagerX.NtSetSystemInformation(num, ref structure, Marshal.SizeOf<int>(structure));
			}
		}
		catch
		{
		}
	}

	// Token: 0x020004F3 RID: 1267
	[StructLayout(LayoutKind.Auto)]
	private struct Struct335 : IAsyncStateMachine
	{
		// Token: 0x06002026 RID: 8230 RVA: 0x00082820 File Offset: 0x00080A20
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class605.Class606.class606_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class605.Struct335>(ref awaiter, ref this);
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
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x000154BC File Offset: 0x000136BC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001566 RID: 5478
		public int int_0;

		// Token: 0x04001567 RID: 5479
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001568 RID: 5480
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004F4 RID: 1268
	[Serializable]
	private sealed class Class606
	{
		// Token: 0x0600202A RID: 8234 RVA: 0x000828EC File Offset: 0x00080AEC
		internal void method_0()
		{
			Class808.smethod_27("del /s /f /q %SYSTEMDRIVE%\\Windows\\Temp\\*.*");
			Class808.smethod_27("rd /s /q %SYSTEMDRIVE%\\Windows\\Temp");
			Class808.smethod_27("md C:\\Windows\\Temp");
			Class808.smethod_27("del /s /f /q %temp%\\*.*");
			Class808.smethod_27("rd /s /q %temp%");
			Class808.smethod_27("md %temp%");
			Class808.smethod_27("del /q /f /s %SYSTEMDRIVE%\\Temp\\*.*");
			Class808.smethod_27("del /q /f /s %SYSTEMDRIVE%\\Windows\\SoftwareDistribution\\Download\\*.*");
		}

		// Token: 0x04001569 RID: 5481
		public static readonly Class605.Class606 class606_0 = new Class605.Class606();

		// Token: 0x0400156A RID: 5482
		public static Action action_0;
	}
}
