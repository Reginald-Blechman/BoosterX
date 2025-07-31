using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using Linearstar.Windows.RawInput;
using Linearstar.Windows.RawInput.Native;
using ns0;

// Token: 0x020006C4 RID: 1732
internal sealed class Class839
{
	// Token: 0x06002BB0 RID: 11184 RVA: 0x000A799C File Offset: 0x000A5B9C
	public static void smethod_0(Class839.Delegate33 delegate33_1)
	{
		Class839.Delegate33 @delegate = Class839.delegate33_0;
		Class839.Delegate33 delegate2;
		do
		{
			delegate2 = @delegate;
			Class839.Delegate33 value = (Class839.Delegate33)Delegate.Combine(delegate2, delegate33_1);
			@delegate = Interlocked.CompareExchange<Class839.Delegate33>(ref Class839.delegate33_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002BB1 RID: 11185 RVA: 0x000A79D0 File Offset: 0x000A5BD0
	public static void smethod_1(Class839.Delegate33 delegate33_1)
	{
		Class839.Delegate33 @delegate = Class839.delegate33_0;
		Class839.Delegate33 delegate2;
		do
		{
			delegate2 = @delegate;
			Class839.Delegate33 value = (Class839.Delegate33)Delegate.Remove(delegate2, delegate33_1);
			@delegate = Interlocked.CompareExchange<Class839.Delegate33>(ref Class839.delegate33_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x000A7A04 File Offset: 0x000A5C04
	public static void smethod_2(Class839.Delegate34 delegate34_1)
	{
		Class839.Delegate34 @delegate = Class839.delegate34_0;
		Class839.Delegate34 delegate2;
		do
		{
			delegate2 = @delegate;
			Class839.Delegate34 value = (Class839.Delegate34)Delegate.Combine(delegate2, delegate34_1);
			@delegate = Interlocked.CompareExchange<Class839.Delegate34>(ref Class839.delegate34_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x000A7A38 File Offset: 0x000A5C38
	public static void smethod_3(Class839.Delegate34 delegate34_1)
	{
		Class839.Delegate34 @delegate = Class839.delegate34_0;
		Class839.Delegate34 delegate2;
		do
		{
			delegate2 = @delegate;
			Class839.Delegate34 value = (Class839.Delegate34)Delegate.Remove(delegate2, delegate34_1);
			@delegate = Interlocked.CompareExchange<Class839.Delegate34>(ref Class839.delegate34_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x000A7A6C File Offset: 0x000A5C6C
	public static void smethod_4()
	{
		Class839.Struct463 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class839.Struct463>(ref @struct);
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x000A7A9C File Offset: 0x000A5C9C
	public static void smethod_5()
	{
		Class839.Struct462 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class839.Struct462>(ref @struct);
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x000A7ACC File Offset: 0x000A5CCC
	private void method_0(object sender, EventArgs e)
	{
		IntPtr handle = new WindowInteropHelper(Class406.smethod_0().method_6(typeof(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd))).Handle;
		RawInputDevice.GetDevices();
		RawInputDevice.RegisterDevice(HidUsageAndPage.Mouse, 4144, handle);
		HwndSource hwndSource = HwndSource.FromHwnd(handle);
		HwndSourceHook hook;
		if ((hook = Class839.Class841.hwndSourceHook_0) == null)
		{
			hook = (Class839.Class841.hwndSourceHook_0 = new HwndSourceHook(Class839.smethod_6));
		}
		hwndSource.AddHook(hook);
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x000A7B34 File Offset: 0x000A5D34
	private static IntPtr smethod_6(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2, ref bool bool_1)
	{
		if (int_0 == 255)
		{
			RawInputData rawInputData = RawInputData.FromHandle(intptr_2);
			RawInputMouseData rawInputMouseData = rawInputData as RawInputMouseData;
			if (rawInputMouseData == null)
			{
				RawInputKeyboardData rawInputKeyboardData = rawInputData as RawInputKeyboardData;
				if (rawInputKeyboardData != null)
				{
					Class839.smethod_8(rawInputKeyboardData.Keyboard);
				}
			}
			else
			{
				Class839.smethod_7(rawInputMouseData.Mouse);
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x0001C31C File Offset: 0x0001A51C
	private static void smethod_7(RawMouse rawMouse_0)
	{
		if (rawMouse_0.Buttons == 1)
		{
			Class839.Delegate33 @delegate = Class839.delegate33_0;
			if (@delegate == null)
			{
				return;
			}
			@delegate();
		}
	}

	// Token: 0x06002BB9 RID: 11193 RVA: 0x0001C337 File Offset: 0x0001A537
	private static void smethod_8(RawKeyboard rawKeyboard_0)
	{
		Class839.Delegate34 @delegate = Class839.delegate34_0;
		if (@delegate == null)
		{
			return;
		}
		@delegate(rawKeyboard_0);
	}

	// Token: 0x04001C67 RID: 7271
	private static Class839.Delegate33 delegate33_0;

	// Token: 0x04001C68 RID: 7272
	private static Class839.Delegate34 delegate34_0;

	// Token: 0x04001C69 RID: 7273
	private static bool bool_0;

	// Token: 0x020006C5 RID: 1733
	// (Invoke) Token: 0x06002BBB RID: 11195
	public delegate void Delegate33();

	// Token: 0x020006C6 RID: 1734
	private sealed class Class840
	{
		// Token: 0x06002BBF RID: 11199 RVA: 0x0001C349 File Offset: 0x0001A549
		internal void method_0()
		{
			this.intptr_0 = this.windowInteropHelper_0.Handle;
		}

		// Token: 0x04001C6A RID: 7274
		public IntPtr intptr_0;

		// Token: 0x04001C6B RID: 7275
		public WindowInteropHelper windowInteropHelper_0;
	}

	// Token: 0x020006C7 RID: 1735
	private static class Class841
	{
		// Token: 0x04001C6C RID: 7276
		public static HwndSourceHook hwndSourceHook_0;
	}

	// Token: 0x020006C8 RID: 1736
	[StructLayout(LayoutKind.Auto)]
	private struct Struct462 : IAsyncStateMachine
	{
		// Token: 0x06002BC0 RID: 11200 RVA: 0x000A7B84 File Offset: 0x000A5D84
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class839.Class843.class843_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class839.Struct462>(ref awaiter, ref this);
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

		// Token: 0x06002BC1 RID: 11201 RVA: 0x0001C35C File Offset: 0x0001A55C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C6D RID: 7277
		public int int_0;

		// Token: 0x04001C6E RID: 7278
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C6F RID: 7279
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006C9 RID: 1737
	[StructLayout(LayoutKind.Auto)]
	private struct Struct463 : IAsyncStateMachine
	{
		// Token: 0x06002BC2 RID: 11202 RVA: 0x000A7C50 File Offset: 0x000A5E50
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class839.Class843.class843_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class839.Struct463>(ref awaiter, ref this);
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

		// Token: 0x06002BC3 RID: 11203 RVA: 0x0001C36A File Offset: 0x0001A56A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C70 RID: 7280
		public int int_0;

		// Token: 0x04001C71 RID: 7281
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C72 RID: 7282
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006CA RID: 1738
	private sealed class Class842
	{
		// Token: 0x06002BC5 RID: 11205 RVA: 0x0001C378 File Offset: 0x0001A578
		internal void method_0()
		{
			this.intptr_0 = this.windowInteropHelper_0.Handle;
		}

		// Token: 0x04001C73 RID: 7283
		public IntPtr intptr_0;

		// Token: 0x04001C74 RID: 7284
		public WindowInteropHelper windowInteropHelper_0;
	}

	// Token: 0x020006CB RID: 1739
	// (Invoke) Token: 0x06002BC7 RID: 11207
	public delegate void Delegate34(RawKeyboard rawKeyboard_0);

	// Token: 0x020006CC RID: 1740
	[Serializable]
	private sealed class Class843
	{
		// Token: 0x06002BCC RID: 11212 RVA: 0x000A7D1C File Offset: 0x000A5F1C
		internal void method_0()
		{
			Class839.Class840 @class = new Class839.Class840();
			if (Class839.bool_0)
			{
				return;
			}
			Class839.bool_0 = true;
			@class.windowInteropHelper_0 = new WindowInteropHelper(Class406.smethod_0().method_6(typeof(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)));
			@class.intptr_0 = IntPtr.Zero;
			Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			RawInputDevice.GetDevices();
			RawInputDevice.RegisterDevice(HidUsageAndPage.Mouse, 304, @class.intptr_0);
			RawInputDevice.RegisterDevice(HidUsageAndPage.Keyboard, 304, @class.intptr_0);
			HwndSource hwndSource = HwndSource.FromHwnd(@class.intptr_0);
			HwndSourceHook hook;
			if ((hook = Class839.Class841.hwndSourceHook_0) == null)
			{
				hook = (Class839.Class841.hwndSourceHook_0 = new HwndSourceHook(Class839.smethod_6));
			}
			hwndSource.AddHook(hook);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000A7DE0 File Offset: 0x000A5FE0
		internal void method_1()
		{
			Class839.bool_0 = false;
			try
			{
				Class839.Class842 @class = new Class839.Class842();
				@class.windowInteropHelper_0 = new WindowInteropHelper(Class406.smethod_0().method_6(typeof(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)));
				@class.intptr_0 = IntPtr.Zero;
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				RawInputDevice.UnregisterDevice(HidUsageAndPage.Mouse);
				RawInputDevice.UnregisterDevice(HidUsageAndPage.Keyboard);
				HwndSource hwndSource = HwndSource.FromHwnd(@class.intptr_0);
				HwndSourceHook hook;
				if ((hook = Class839.Class841.hwndSourceHook_0) == null)
				{
					hook = (Class839.Class841.hwndSourceHook_0 = new HwndSourceHook(Class839.smethod_6));
				}
				hwndSource.RemoveHook(hook);
			}
			catch
			{
			}
		}

		// Token: 0x04001C75 RID: 7285
		public static readonly Class839.Class843 class843_0 = new Class839.Class843();

		// Token: 0x04001C76 RID: 7286
		public static Action action_0;

		// Token: 0x04001C77 RID: 7287
		public static Action action_1;
	}
}
