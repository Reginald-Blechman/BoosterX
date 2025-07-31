using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Newtonsoft.Json;
using ns0;

// Token: 0x020006DA RID: 1754
internal sealed class Class535 : GClass162
{
	// Token: 0x06002C11 RID: 11281 RVA: 0x0001C5B7 File Offset: 0x0001A7B7
	public Class535(GClass24 gclass24_1, Class495 class495_1 = null)
	{
		this.gclass24_0 = gclass24_1;
		this.class495_0 = class495_1;
		if (class495_1 == null)
		{
			this.DeleteVisibility = Visibility.Collapsed;
		}
	}

	// Token: 0x1700073B RID: 1851
	// (get) Token: 0x06002C12 RID: 11282 RVA: 0x0001C5ED File Offset: 0x0001A7ED
	// (set) Token: 0x06002C13 RID: 11283 RVA: 0x0001C5F5 File Offset: 0x0001A7F5
	public Visibility DeleteVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("DeleteVisibility");
		}
	}

	// Token: 0x1700073C RID: 1852
	// (get) Token: 0x06002C14 RID: 11284 RVA: 0x0001C60A File Offset: 0x0001A80A
	// (set) Token: 0x06002C15 RID: 11285 RVA: 0x0001C612 File Offset: 0x0001A812
	public string StatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x1700073D RID: 1853
	// (get) Token: 0x06002C16 RID: 11286 RVA: 0x0001C627 File Offset: 0x0001A827
	// (set) Token: 0x06002C17 RID: 11287 RVA: 0x0001C62F File Offset: 0x0001A82F
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x1700073E RID: 1854
	// (get) Token: 0x06002C18 RID: 11288 RVA: 0x0001C644 File Offset: 0x0001A844
	// (set) Token: 0x06002C19 RID: 11289 RVA: 0x0001C64C File Offset: 0x0001A84C
	public double StatusOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x000A8C0C File Offset: 0x000A6E0C
	private void method_2(string string_1, SolidColorBrush solidColorBrush_1)
	{
		Class535.Struct466 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class535_0 = this;
		@struct.string_0 = string_1;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class535.Struct466>(ref @struct);
	}

	// Token: 0x1700073F RID: 1855
	// (get) Token: 0x06002C1B RID: 11291 RVA: 0x0001C661 File Offset: 0x0001A861
	public string Name
	{
		get
		{
			return this.gclass24_0.Name;
		}
	}

	// Token: 0x17000740 RID: 1856
	// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000A8C54 File Offset: 0x000A6E54
	public string DateCreated
	{
		get
		{
			return this.gclass24_0.CreationDate.ToLocalTime().ToString("dd.MM.yyyy HH:mm");
		}
	}

	// Token: 0x17000741 RID: 1857
	// (get) Token: 0x06002C1D RID: 11293 RVA: 0x0001C66E File Offset: 0x0001A86E
	public GClass280 Delete
	{
		get
		{
			if (this.bool_0)
			{
				return null;
			}
			return new GClass280(new Action<object>(this.method_3), null);
		}
	}

	// Token: 0x17000742 RID: 1858
	// (get) Token: 0x06002C1E RID: 11294 RVA: 0x0001C68C File Offset: 0x0001A88C
	public GClass280 Download
	{
		get
		{
			if (this.bool_0)
			{
				return null;
			}
			return new GClass280(new Action<object>(this.method_5), null);
		}
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x000A8C84 File Offset: 0x000A6E84
	private void method_3(object object_0)
	{
		Class535.Struct465 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class535_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class535.Struct465>(ref @struct);
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x000A8CBC File Offset: 0x000A6EBC
	private Task method_4()
	{
		Class535.Struct468 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class535_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class535.Struct468>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002C21 RID: 11297 RVA: 0x000A8D00 File Offset: 0x000A6F00
	private void method_5(object object_0)
	{
		Class535.Struct467 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class535_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class535.Struct467>(ref @struct);
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x000A8D38 File Offset: 0x000A6F38
	private Task method_6()
	{
		Class535.Struct464 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class535_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class535.Struct464>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001C8A RID: 7306
	private Class495 class495_0;

	// Token: 0x04001C8B RID: 7307
	private GClass24 gclass24_0;

	// Token: 0x04001C8C RID: 7308
	private Visibility visibility_0;

	// Token: 0x04001C8D RID: 7309
	private string string_0 = string.Empty;

	// Token: 0x04001C8E RID: 7310
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04001C8F RID: 7311
	private double double_0;

	// Token: 0x04001C90 RID: 7312
	private bool bool_0;

	// Token: 0x020006DB RID: 1755
	[StructLayout(LayoutKind.Auto)]
	private struct Struct464 : IAsyncStateMachine
	{
		// Token: 0x06002C23 RID: 11299 RVA: 0x000A8D7C File Offset: 0x000A6F7C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class535 @class = this.class535_0;
			try
			{
				TaskAwaiter<Class723> awaiter;
				TaskAwaiter awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_2A0;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_2D8;
				case 3:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_310;
				case 4:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_345;
				default:
					@class.method_2(Class298.smethod_2("Downloading"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
					awaiter = Class215.smethod_1("BackUpGet", @class.gclass24_0.Id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class535.Struct464>(ref awaiter, ref this);
						return;
					}
					break;
				}
				Class723 result = awaiter.GetResult();
				if (!result.Success)
				{
					@class.method_2(result.Message, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
					awaiter2 = Task.Delay(1500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct464>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					string path = Path.Combine(Class169.string_6, @class.gclass24_0.Name + ".buxz");
					if (File.Exists(path))
					{
						@class.method_2(Class298.smethod_2("FileExists"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
						awaiter2 = Task.Delay(1500).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_1 = awaiter2;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct464>(ref awaiter2, ref this);
							return;
						}
						goto IL_2D8;
					}
					else
					{
						int num2 = 0;
						try
						{
							Class319 class2 = JsonConvert.DeserializeObject<Class319>(result.Message);
							File.WriteAllBytes(path, class2.Data);
						}
						catch (Exception obj)
						{
							num2 = 1;
						}
						if (num2 == 1)
						{
							object obj;
							GClass268.smethod_0(((Exception)obj).Message);
							@class.method_2(Class298.smethod_2("unknownerror"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
							awaiter2 = Task.Delay(1500).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 3;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct464>(ref awaiter2, ref this);
								return;
							}
							goto IL_310;
						}
						else
						{
							if (@class.class495_0 != null)
							{
								@class.class495_0.method_4();
							}
							@class.method_2(Class298.smethod_2("storexins7"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
							awaiter2 = Task.Delay(1500).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 4;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct464>(ref awaiter2, ref this);
								return;
							}
							goto IL_345;
						}
					}
				}
				IL_2A0:
				awaiter2.GetResult();
				@class.method_2(string.Empty, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				goto IL_377;
				IL_2D8:
				awaiter2.GetResult();
				@class.method_2(string.Empty, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				goto IL_377;
				IL_310:
				awaiter2.GetResult();
				@class.method_2(string.Empty, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				goto IL_377;
				IL_345:
				awaiter2.GetResult();
				@class.method_2(string.Empty, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_377:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x0001C6AA File Offset: 0x0001A8AA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C91 RID: 7313
		public int int_0;

		// Token: 0x04001C92 RID: 7314
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001C93 RID: 7315
		public Class535 class535_0;

		// Token: 0x04001C94 RID: 7316
		private TaskAwaiter<Class723> taskAwaiter_0;

		// Token: 0x04001C95 RID: 7317
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020006DC RID: 1756
	[StructLayout(LayoutKind.Auto)]
	private struct Struct465 : IAsyncStateMachine
	{
		// Token: 0x06002C25 RID: 11301 RVA: 0x000A9148 File Offset: 0x000A7348
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class535 @class = this.class535_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_0 = true;
					awaiter = Task.Run(new Func<Task>(@class.method_4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct465>(ref awaiter, ref this);
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
				@class.bool_0 = false;
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

		// Token: 0x06002C26 RID: 11302 RVA: 0x0001C6B8 File Offset: 0x0001A8B8
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C96 RID: 7318
		public int int_0;

		// Token: 0x04001C97 RID: 7319
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C98 RID: 7320
		public Class535 class535_0;

		// Token: 0x04001C99 RID: 7321
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006DD RID: 1757
	[StructLayout(LayoutKind.Auto)]
	private struct Struct466 : IAsyncStateMachine
	{
		// Token: 0x06002C27 RID: 11303 RVA: 0x000A9214 File Offset: 0x000A7414
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class535 @class = this.class535_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B8;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_127;
				}
				IL_56:
				if (@class.StatusOpacity == 0.0)
				{
					@class.StatusColor = this.solidColorBrush_0;
					@class.StatusText = this.string_0;
					goto IL_12E;
				}
				@class.StatusOpacity -= 0.1;
				if (@class.StatusOpacity < 0.05)
				{
					@class.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct466>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_127:
				awaiter.GetResult();
				IL_12E:
				if (@class.StatusOpacity != 1.0)
				{
					@class.StatusOpacity += 0.13333333333333333;
					if (@class.StatusOpacity > 0.95)
					{
						@class.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_127;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct466>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06002C28 RID: 11304 RVA: 0x0001C6C6 File Offset: 0x0001A8C6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001C9A RID: 7322
		public int int_0;

		// Token: 0x04001C9B RID: 7323
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C9C RID: 7324
		public Class535 class535_0;

		// Token: 0x04001C9D RID: 7325
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001C9E RID: 7326
		public string string_0;

		// Token: 0x04001C9F RID: 7327
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006DE RID: 1758
	[StructLayout(LayoutKind.Auto)]
	private struct Struct467 : IAsyncStateMachine
	{
		// Token: 0x06002C29 RID: 11305 RVA: 0x000A93E8 File Offset: 0x000A75E8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class535 @class = this.class535_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					@class.bool_0 = true;
					awaiter = Task.Run(new Func<Task>(@class.method_6)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct467>(ref awaiter, ref this);
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
				@class.bool_0 = false;
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

		// Token: 0x06002C2A RID: 11306 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CA0 RID: 7328
		public int int_0;

		// Token: 0x04001CA1 RID: 7329
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001CA2 RID: 7330
		public Class535 class535_0;

		// Token: 0x04001CA3 RID: 7331
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006DF RID: 1759
	[StructLayout(LayoutKind.Auto)]
	private struct Struct468 : IAsyncStateMachine
	{
		// Token: 0x06002C2B RID: 11307 RVA: 0x000A94B4 File Offset: 0x000A76B4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class535 @class = this.class535_0;
			try
			{
				TaskAwaiter<Class723> awaiter;
				TaskAwaiter awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_176;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1AB;
				default:
					@class.method_2(Class298.smethod_2("Deleting"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
					awaiter = Class215.smethod_1("BackUpDelete", @class.gclass24_0.Id).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class535.Struct468>(ref awaiter, ref this);
						return;
					}
					break;
				}
				Class723 result = awaiter.GetResult();
				if (!result.Success)
				{
					@class.method_2(result.Message, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
					awaiter2 = Task.Delay(1500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct468>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					@class.class495_0.method_5();
					@class.method_2(result.Message, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
					awaiter2 = Task.Delay(1500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class535.Struct468>(ref awaiter2, ref this);
						return;
					}
					goto IL_1AB;
				}
				IL_176:
				awaiter2.GetResult();
				@class.method_2(string.Empty, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				goto IL_1E3;
				IL_1AB:
				awaiter2.GetResult();
				@class.method_2(Class298.smethod_2("storexins7"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1E3:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0001C6E2 File Offset: 0x0001A8E2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CA4 RID: 7332
		public int int_0;

		// Token: 0x04001CA5 RID: 7333
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001CA6 RID: 7334
		public Class535 class535_0;

		// Token: 0x04001CA7 RID: 7335
		private TaskAwaiter<Class723> taskAwaiter_0;

		// Token: 0x04001CA8 RID: 7336
		private TaskAwaiter taskAwaiter_1;
	}
}
