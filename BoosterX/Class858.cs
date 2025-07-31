using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x020006E5 RID: 1765
internal sealed class Class858
{
	// Token: 0x06002C45 RID: 11333 RVA: 0x0001C7EA File Offset: 0x0001A9EA
	public static Class492 smethod_0(bool bool_0)
	{
		if (bool_0)
		{
			Class858.class492_0.method_3();
		}
		return Class858.class492_0;
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x000A9A5C File Offset: 0x000A7C5C
	public static Task<string> smethod_1(Class466 class466_0)
	{
		Class858.Struct471 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.class466_0 = class466_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class858.Struct471>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002C47 RID: 11335 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
	public static Task<string> smethod_2(Class466 class466_0)
	{
		Class858.Struct472 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.class466_0 = class466_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class858.Struct472>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002C48 RID: 11336 RVA: 0x000A9AE4 File Offset: 0x000A7CE4
	public static Task<string> smethod_3(Class466 class466_0)
	{
		Class858.Struct470 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		@struct.class466_0 = class466_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class858.Struct470>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002C49 RID: 11337 RVA: 0x0001C7FE File Offset: 0x0001A9FE
	internal static void smethod_4()
	{
		Class858.class492_0.method_4();
	}

	// Token: 0x06002C4A RID: 11338 RVA: 0x0001C80A File Offset: 0x0001AA0A
	internal static void smethod_5()
	{
		Class858.class492_0.method_5();
	}

	// Token: 0x06002C4B RID: 11339 RVA: 0x000A9B28 File Offset: 0x000A7D28
	internal static List<string> smethod_6()
	{
		List<string> list = new List<string>();
		foreach (Class512 @class in Class858.class492_0.Tweaks)
		{
			list.Add(@class.method_7());
		}
		return list;
	}

	// Token: 0x04001CB7 RID: 7351
	private static Class492 class492_0 = new Class492();

	// Token: 0x020006E6 RID: 1766
	[StructLayout(LayoutKind.Auto)]
	private struct Struct470 : IAsyncStateMachine
	{
		// Token: 0x06002C4C RID: 11340 RVA: 0x000A9B88 File Offset: 0x000A7D88
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					TaskAwaiter<Class723> awaiter2;
					if (num != 1)
					{
						Guid guid_ = this.class466_0.Guid_0;
						if (this.class466_0.Guid_0 == Guid.Empty)
						{
							awaiter = Class858.smethod_1(this.class466_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Class858.Struct470>(ref awaiter, ref this);
								return;
							}
							goto IL_186;
						}
						else
						{
							this.class276_0 = new Class276<Guid, string>(this.class466_0.Guid_0, JsonConvert.SerializeObject(this.class466_0));
							awaiter2 = Class215.smethod_1("TweaksUpdate", this.class276_0).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_1 = awaiter2;
								this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class858.Struct470>(ref awaiter2, ref this);
								return;
							}
						}
					}
					else
					{
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<Class723>);
						this.int_0 = -1;
					}
					Class723 result = awaiter2.GetResult();
					if (!result.Success)
					{
						result2 = Class298.smethod_2(result.Message);
						goto IL_1B0;
					}
					Class765.smethod_18(Path.Combine(Class169.string_10, this.class276_0.Id.ToString()), Class868.smethod_0(this.class276_0.Json), null);
					Class858.smethod_0(true);
					result2 = Class298.smethod_2("success");
					goto IL_1B0;
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<string>);
					this.int_0 = -1;
				}
				IL_186:
				result2 = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class276_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1B0:
			this.int_0 = -2;
			this.class276_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0001C816 File Offset: 0x0001AA16
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CB8 RID: 7352
		public int int_0;

		// Token: 0x04001CB9 RID: 7353
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001CBA RID: 7354
		public Class466 class466_0;

		// Token: 0x04001CBB RID: 7355
		private Class276<Guid, string> class276_0;

		// Token: 0x04001CBC RID: 7356
		private TaskAwaiter<string> taskAwaiter_0;

		// Token: 0x04001CBD RID: 7357
		private TaskAwaiter<Class723> taskAwaiter_1;
	}

	// Token: 0x020006E7 RID: 1767
	[StructLayout(LayoutKind.Auto)]
	private struct Struct471 : IAsyncStateMachine
	{
		// Token: 0x06002C4E RID: 11342 RVA: 0x000A9D7C File Offset: 0x000A7F7C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result;
			try
			{
				TaskAwaiter<Class723> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
						this.int_0 = -1;
						goto IL_148;
					}
					Guid guid_ = this.class466_0.Guid_0;
					Class199<Guid> object_ = new Class199<Guid>(this.class466_0.Guid_0);
					awaiter = Class215.smethod_1("TweaksCheck", object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class858.Struct471>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
					this.int_0 = -1;
				}
				if (awaiter.GetResult().Success)
				{
					result = Class298.smethod_2("TweakAlreadyExists");
					goto IL_1D5;
				}
				this.class466_0.Guid_0 = Guid.NewGuid();
				this.class325_0 = new Class325<string, Guid, string>(Class551.class753_0.Key, this.class466_0.Guid_0, JsonConvert.SerializeObject(this.class466_0));
				awaiter = Class215.smethod_1("TweaksAdd", this.class325_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class858.Struct471>(ref awaiter, ref this);
					return;
				}
				IL_148:
				Class723 result2 = awaiter.GetResult();
				if (!result2.Success)
				{
					result = Class298.smethod_2(result2.Message);
				}
				else
				{
					Class765.smethod_17(Path.Combine(Class169.string_10, this.class325_0.Id.ToString()), Class868.smethod_0(this.class325_0.Json), null);
					Class858.smethod_0(true);
					result = Class298.smethod_2("success");
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class325_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_1D5:
			this.int_0 = -2;
			this.class325_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0001C824 File Offset: 0x0001AA24
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CBE RID: 7358
		public int int_0;

		// Token: 0x04001CBF RID: 7359
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001CC0 RID: 7360
		public Class466 class466_0;

		// Token: 0x04001CC1 RID: 7361
		private Class325<string, Guid, string> class325_0;

		// Token: 0x04001CC2 RID: 7362
		private TaskAwaiter<Class723> taskAwaiter_0;
	}

	// Token: 0x020006E8 RID: 1768
	[StructLayout(LayoutKind.Auto)]
	private struct Struct472 : IAsyncStateMachine
	{
		// Token: 0x06002C50 RID: 11344 RVA: 0x000A9F98 File Offset: 0x000A8198
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			string result2;
			try
			{
				TaskAwaiter<Class723> awaiter;
				if (num != 0)
				{
					Class199<Guid> object_ = new Class199<Guid>(this.class466_0.Guid_0);
					awaiter = Class215.smethod_1("TweaksDelete", object_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class858.Struct472>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
					this.int_0 = -1;
				}
				Class723 result = awaiter.GetResult();
				try
				{
					File.Delete(Path.Combine(Class169.string_10, this.class466_0.Guid_0.ToString()));
				}
				catch
				{
				}
				Class858.smethod_0(true);
				if (!result.Success)
				{
					result2 = Class298.smethod_2(result.Message);
				}
				else
				{
					result2 = Class298.smethod_2("success");
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult(result2);
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x0001C832 File Offset: 0x0001AA32
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001CC3 RID: 7363
		public int int_0;

		// Token: 0x04001CC4 RID: 7364
		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		// Token: 0x04001CC5 RID: 7365
		public Class466 class466_0;

		// Token: 0x04001CC6 RID: 7366
		private TaskAwaiter<Class723> taskAwaiter_0;
	}
}
