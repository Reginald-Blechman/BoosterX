using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PIManagerX;
using WinCopies.Util;

// Token: 0x0200066E RID: 1646
internal sealed class Class781
{
	// Token: 0x06002987 RID: 10631 RVA: 0x000A24B8 File Offset: 0x000A06B8
	public static void smethod_0()
	{
		Class781.Struct451 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class781.Struct451>(ref @struct);
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x000A24E8 File Offset: 0x000A06E8
	private static void smethod_1(Class175.Class176 class176_0)
	{
		Class781.int_2 = class176_0.method_2();
		Class781.int_3 = class176_0.method_4();
		int num = 0;
		for (int i = 0; i < Class781.int_2; i++)
		{
			Class781.list_0.Add(new Class552
			{
				Core = i,
				Thread = num++,
				IsECore = false
			});
			if (Class781.bool_0)
			{
				Class781.list_0.Add(new Class552
				{
					Core = i,
					Thread = num++,
					IsECore = false
				});
			}
		}
		Class551.class753_0.method_93(num.ToString());
		for (int j = Class781.int_2; j < Class781.int_3 + Class781.int_2; j++)
		{
			Class781.list_0.Add(new Class552
			{
				Core = j,
				Thread = num++,
				IsECore = true
			});
		}
	}

	// Token: 0x06002989 RID: 10633 RVA: 0x000A25C8 File Offset: 0x000A07C8
	private static void smethod_2()
	{
		int num = 0;
		for (int i = 0; i < Class781.int_0; i++)
		{
			Class781.list_0.Add(new Class552
			{
				Core = i,
				Thread = num++,
				IsECore = false
			});
			if (Class781.bool_0)
			{
				Class781.list_0.Add(new Class552
				{
					Core = i,
					Thread = num++,
					IsECore = false
				});
			}
		}
	}

	// Token: 0x0600298A RID: 10634 RVA: 0x0001B301 File Offset: 0x00019501
	private static bool smethod_3(Class175.Class176 class176_0)
	{
		return (Class781.int_1 == class176_0.method_2() + class176_0.method_4() && !Class781.bool_0) || (Class781.int_1 == class176_0.method_2() * 2 + class176_0.method_4() && Class781.bool_0);
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x000A2640 File Offset: 0x000A0840
	private static void smethod_4()
	{
		if (!Extensions.Contains(Class781.string_0, new object[]
		{
			"AMD",
			StringComparison.OrdinalIgnoreCase
		}) && !Extensions.Contains(Class781.string_0, new object[]
		{
			"Ryzen",
			StringComparison.OrdinalIgnoreCase
		}))
		{
			return;
		}
		foreach (Class552 @class in Class781.list_0)
		{
			try
			{
				uint num;
				uint num2;
				uint num3;
				uint num4;
				if (LLCpuHelpers.TryCpuidOnLogical(@class.Thread, -2147483618, 0, ref num, ref num2, ref num3, ref num4))
				{
					@class.method_1((int)(num2 >> 8 & 255U));
				}
			}
			catch
			{
				break;
			}
		}
	}

	// Token: 0x04001B4A RID: 6986
	public static int int_0 = 0;

	// Token: 0x04001B4B RID: 6987
	public static int int_1 = 0;

	// Token: 0x04001B4C RID: 6988
	public static int int_2 = 0;

	// Token: 0x04001B4D RID: 6989
	public static int int_3 = 0;

	// Token: 0x04001B4E RID: 6990
	public static bool bool_0 = false;

	// Token: 0x04001B4F RID: 6991
	public static string string_0 = "UNKNOWN";

	// Token: 0x04001B50 RID: 6992
	public static bool bool_1 = false;

	// Token: 0x04001B51 RID: 6993
	public static List<Class552> list_0 = new List<Class552>();

	// Token: 0x0200066F RID: 1647
	[StructLayout(LayoutKind.Auto)]
	private struct Struct451 : IAsyncStateMachine
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x000A2710 File Offset: 0x000A0910
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class781.Class782.class782_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class781.Struct451>(ref awaiter, ref this);
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

		// Token: 0x0600298D RID: 10637 RVA: 0x0001B340 File Offset: 0x00019540
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B52 RID: 6994
		public int int_0;

		// Token: 0x04001B53 RID: 6995
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B54 RID: 6996
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000670 RID: 1648
	[Serializable]
	private sealed class Class782
	{
		// Token: 0x06002990 RID: 10640 RVA: 0x000A27DC File Offset: 0x000A09DC
		internal Task method_0()
		{
			Class781.Class782.Struct452 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class781.Class782.Struct452>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0001B35A File Offset: 0x0001955A
		internal bool method_1(Class175.Class176 class176_0)
		{
			return class176_0.method_0().Equals(Class781.string_0.Split(new char[]
			{
				' '
			}).Last<string>(), StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x0001B382 File Offset: 0x00019582
		internal bool method_2(Class175.Class176 class176_0)
		{
			return class176_0.method_0().Equals(Class781.string_0.Split(new char[]
			{
				'-'
			}).Last<string>(), StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04001B55 RID: 6997
		public static readonly Class781.Class782 class782_0 = new Class781.Class782();

		// Token: 0x04001B56 RID: 6998
		public static Func<Class175.Class176, bool> func_0;

		// Token: 0x04001B57 RID: 6999
		public static Func<Class175.Class176, bool> func_1;

		// Token: 0x04001B58 RID: 7000
		public static Func<Task> func_2;

		// Token: 0x02000671 RID: 1649
		[StructLayout(LayoutKind.Auto)]
		private struct Struct452 : IAsyncStateMachine
		{
			// Token: 0x06002993 RID: 10643 RVA: 0x000A2818 File Offset: 0x000A0A18
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						Class781.int_0 = Class243.smethod_3();
						Class781.int_1 = Class243.smethod_2();
						Class551.class753_0.method_95(Class781.int_1.ToString());
						Class781.bool_0 = (Class781.int_0 != Class781.int_1);
						try
						{
							ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT Name FROM Win32_Processor").Get().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									ManagementBaseObject managementBaseObject = enumerator.Current;
									Class781.string_0 = ((ManagementObject)managementBaseObject)["Name"].ToString();
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									((IDisposable)enumerator).Dispose();
								}
							}
						}
						catch
						{
						}
						if (Extensions.Contains(Class781.string_0, new object[]
						{
							"Ultra",
							StringComparison.OrdinalIgnoreCase
						}))
						{
							this.class176_0 = Class175.list_0.FirstOrDefault(new Func<Class175.Class176, bool>(Class781.Class782.class782_0.method_1));
						}
						else
						{
							this.class176_0 = Class175.list_0.FirstOrDefault(new Func<Class175.Class176, bool>(Class781.Class782.class782_0.method_2));
						}
						if (this.class176_0 == null)
						{
							Class781.smethod_2();
							Class781.smethod_4();
							Class781.bool_1 = true;
							goto IL_1FA;
						}
						awaiter = Class480.smethod_7().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class781.Class782.Struct452>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<bool>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					Class781.bool_0 = awaiter.GetResult();
					if (!Class781.smethod_3(this.class176_0))
					{
						Class781.smethod_2();
						Class781.smethod_4();
						Class781.bool_1 = true;
					}
					else
					{
						Class781.smethod_1(this.class176_0);
						Class781.smethod_4();
						Class781.bool_1 = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class176_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_1FA:
				this.int_0 = -2;
				this.class176_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06002994 RID: 10644 RVA: 0x0001B3AA File Offset: 0x000195AA
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001B59 RID: 7001
			public int int_0;

			// Token: 0x04001B5A RID: 7002
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001B5B RID: 7003
			private Class175.Class176 class176_0;

			// Token: 0x04001B5C RID: 7004
			private TaskAwaiter<bool> taskAwaiter_0;
		}
	}
}
