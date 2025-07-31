using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Win32;
using Newtonsoft.Json;

// Token: 0x02000350 RID: 848
internal sealed class Class402
{
	// Token: 0x0600160C RID: 5644 RVA: 0x0000F258 File Offset: 0x0000D458
	// Note: this type is marked as 'beforefieldinit'.
	static Class402()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "'XY9TZa-j7", null);
	}

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x0600160D RID: 5645 RVA: 0x0000F26F File Offset: 0x0000D46F
	// (set) Token: 0x0600160E RID: 5646 RVA: 0x00065E54 File Offset: 0x00064054
	public static string String_0
	{
		get
		{
			return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "%(*FLZa-j\"", null);
		}
		private set
		{
			object[] object_ = new object[]
			{
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "K!_qmZa-j#", object_);
		}
	}

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x0600160F RID: 5647 RVA: 0x0000F28B File Offset: 0x0000D48B
	// (set) Token: 0x06001610 RID: 5648 RVA: 0x00065E84 File Offset: 0x00064084
	public static string String_1
	{
		get
		{
			return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "7C9J0Za-j\"", null);
		}
		private set
		{
			object[] object_ = new object[]
			{
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "2RKm!Za-j#", object_);
		}
	}

	// Token: 0x17000369 RID: 873
	// (get) Token: 0x06001611 RID: 5649 RVA: 0x0000F2A7 File Offset: 0x0000D4A7
	// (set) Token: 0x06001612 RID: 5650 RVA: 0x00065EB4 File Offset: 0x000640B4
	public static TimeSpan TimeSpan_0
	{
		get
		{
			return (TimeSpan)Class392.smethod_3().method_105(Class392.smethod_1(), "V6mY;Za-j$", null);
		}
		private set
		{
			object[] object_ = new object[]
			{
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "rj9)?Za-j$", object_);
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06001613 RID: 5651 RVA: 0x00065EE8 File Offset: 0x000640E8
	// (remove) Token: 0x06001614 RID: 5652 RVA: 0x00065F18 File Offset: 0x00064118
	public static event Class402.Delegate29 Event_0
	{
		add
		{
			object[] object_ = new object[]
			{
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "BXG1SZa-j&", object_);
		}
		remove
		{
			object[] object_ = new object[]
			{
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "/@;glZa-j'", object_);
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06001615 RID: 5653 RVA: 0x00065F48 File Offset: 0x00064148
	// (remove) Token: 0x06001616 RID: 5654 RVA: 0x00065F78 File Offset: 0x00064178
	public static event Class402.Delegate28 Event_1
	{
		add
		{
			object[] object_ = new object[]
			{
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "K!_qmZa-j*", object_);
		}
		remove
		{
			object[] object_ = new object[]
			{
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "@^NPMZa-j*", object_);
		}
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
	public static void smethod_0()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "+LJP`Za-j9", null);
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x0000F2DF File Offset: 0x0000D4DF
	public static void smethod_1()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "n[,^2Za-j>", null);
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x00065FA8 File Offset: 0x000641A8
	public static Task smethod_2(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), ":UIO:Za-j,", object_);
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x0000F2F6 File Offset: 0x0000D4F6
	internal static void smethod_3()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "j0Z5$Za-j\"", null);
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x0000F30D File Offset: 0x0000D50D
	private static void smethod_4()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "gpFJrZa-jI", null);
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x0000F324 File Offset: 0x0000D524
	private static void smethod_5(ref Class402.Struct181 struct181_0)
	{
		struct181_0.asyncVoidMethodBuilder_0.Start<Class402.Struct181>(ref struct181_0);
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x0000F332 File Offset: 0x0000D532
	private static void smethod_6(ref Class402.Struct184 struct184_0)
	{
		struct184_0.asyncVoidMethodBuilder_0.Start<Class402.Struct184>(ref struct184_0);
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x0000F340 File Offset: 0x0000D540
	private static void smethod_7(ref Class402.Struct183 struct183_0)
	{
		struct183_0.asyncTaskMethodBuilder_0.Start<Class402.Struct183>(ref struct183_0);
	}

	// Token: 0x04000E8D RID: 3725
	private static Struct9 struct9_0;

	// Token: 0x04000E8E RID: 3726
	private static Struct9 struct9_1;

	// Token: 0x04000E8F RID: 3727
	private static Struct16 struct16_0;

	// Token: 0x04000E90 RID: 3728
	private static Class402.Delegate29 delegate29_0;

	// Token: 0x04000E91 RID: 3729
	private static Class402.Delegate28 delegate28_0;

	// Token: 0x04000E92 RID: 3730
	public static Struct14 struct14_0;

	// Token: 0x02000351 RID: 849
	private static class Class403
	{
		// Token: 0x04000E93 RID: 3731
		public static Action action_0;
	}

	// Token: 0x02000352 RID: 850
	// (Invoke) Token: 0x06001620 RID: 5664
	public delegate void Delegate28();

	// Token: 0x02000353 RID: 851
	[StructLayout(LayoutKind.Auto)]
	private struct Struct181 : IAsyncStateMachine
	{
		// Token: 0x06001623 RID: 5667 RVA: 0x00065FDC File Offset: 0x000641DC
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
				@class.method_64(stream_, "VR3b<Za-j;", array);
			}
			finally
			{
				this = (Class402.Struct181)array[0];
			}
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0000F34E File Offset: 0x0000D54E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0000F35C File Offset: 0x0000D55C
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class402.Struct181 struct181_0)
		{
			struct181_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class402.Struct181>(ref taskAwaiter_1, ref struct181_0);
		}

		// Token: 0x04000E94 RID: 3732
		public int int_0;

		// Token: 0x04000E95 RID: 3733
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000E96 RID: 3734
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000354 RID: 852
	private sealed class Class404
	{
		// Token: 0x06001627 RID: 5671 RVA: 0x00066044 File Offset: 0x00064244
		internal Task method_0()
		{
			Class402.Class404.Struct182 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class404_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class402.Class404.Struct182>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000E97 RID: 3735
		public string string_0;

		// Token: 0x02000355 RID: 853
		[StructLayout(LayoutKind.Auto)]
		private struct Struct182 : IAsyncStateMachine
		{
			// Token: 0x06001628 RID: 5672 RVA: 0x00066088 File Offset: 0x00064288
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class402.Class404 @class = this.class404_0;
				try
				{
					TaskAwaiter<Class723> awaiter;
					TaskAwaiter<bool> awaiter2;
					TaskAwaiter awaiter3;
					switch (num)
					{
					case 0:
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Class723>);
						this.int_0 = -1;
						break;
					case 1:
						awaiter2 = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter<bool>);
						this.int_0 = -1;
						goto IL_18B;
					case 2:
						awaiter3 = this.taskAwaiter_2;
						this.taskAwaiter_2 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_245;
					default:
					{
						Class402.Delegate28 delegate28_ = Class402.delegate28_0;
						if (delegate28_ != null)
						{
							delegate28_();
						}
						bool flag;
						Class833<string, string, string> object_ = new Class833<string, string, string>((flag = @class.string_0.smethod_8()) ? @class.string_0 : string.Empty, flag ? string.Empty : @class.string_0, Class216.smethod_1());
						awaiter = Class215.smethod_1("Pro", object_).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class402.Class404.Struct182>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					Class723 result = awaiter.GetResult();
					this.class723_0 = result;
					this.bool_0 = false;
					if (!this.class723_0.Success)
					{
						goto IL_260;
					}
					Class139 class2 = JsonConvert.DeserializeObject<Class139>(this.class723_0.Message);
					Class402.TimeSpan_0 = class2.ExpiryLeft;
					Class402.String_1 = class2.DiscordNick;
					Class402.String_0 = (class2.Key.smethod_9() ? @class.string_0 : class2.Key);
					awaiter2 = Class216.smethod_10().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 1;
						this.taskAwaiter_1 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class402.Class404.Struct182>(ref awaiter2, ref this);
						return;
					}
					IL_18B:
					if (awaiter2.GetResult())
					{
						Class402.Delegate29 delegate29_ = Class402.delegate29_0;
						if (delegate29_ != null)
						{
							delegate29_(new Class723(false, "MotherBoardDriverNotInstalled", string.Empty));
						}
						Class402.struct14_0.method_1(true);
						Class733.smethod_1(false);
						goto IL_2AE;
					}
					if (!Class215.struct14_0.method_0() || Class215.struct9_0.method_1().smethod_9())
					{
						goto IL_24C;
					}
					this.bool_0 = true;
					awaiter3 = Class148.smethod_3().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.int_0 = 2;
						this.taskAwaiter_2 = awaiter3;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class402.Class404.Struct182>(ref awaiter3, ref this);
						return;
					}
					IL_245:
					awaiter3.GetResult();
					IL_24C:
					Class551.class753_0.Key = Class402.String_0;
					Class202.smethod_3();
					IL_260:
					Class733.smethod_1(this.bool_0);
					Class402.struct14_0.method_1(true);
					Class402.Delegate29 delegate29_2 = Class402.delegate29_0;
					if (delegate29_2 != null)
					{
						delegate29_2(this.class723_0);
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class723_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_2AE:
				this.int_0 = -2;
				this.class723_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001629 RID: 5673 RVA: 0x0000F36B File Offset: 0x0000D56B
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000E98 RID: 3736
			public int int_0;

			// Token: 0x04000E99 RID: 3737
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000E9A RID: 3738
			public Class402.Class404 class404_0;

			// Token: 0x04000E9B RID: 3739
			private Class723 class723_0;

			// Token: 0x04000E9C RID: 3740
			private bool bool_0;

			// Token: 0x04000E9D RID: 3741
			private TaskAwaiter<Class723> taskAwaiter_0;

			// Token: 0x04000E9E RID: 3742
			private TaskAwaiter<bool> taskAwaiter_1;

			// Token: 0x04000E9F RID: 3743
			private TaskAwaiter taskAwaiter_2;
		}
	}

	// Token: 0x02000356 RID: 854
	[StructLayout(LayoutKind.Auto)]
	private struct Struct183 : IAsyncStateMachine
	{
		// Token: 0x0600162A RID: 5674 RVA: 0x0006637C File Offset: 0x0006457C
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
				@class.method_64(stream_, "'\"#'RZa-j.", array);
			}
			finally
			{
				this = (Class402.Struct183)array[0];
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0000F379 File Offset: 0x0000D579
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0000F387 File Offset: 0x0000D587
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class402.Struct183 struct183_0)
		{
			struct183_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class402.Struct183>(ref taskAwaiter_1, ref struct183_0);
		}

		// Token: 0x04000EA0 RID: 3744
		public int int_0;

		// Token: 0x04000EA1 RID: 3745
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000EA2 RID: 3746
		public string string_0;

		// Token: 0x04000EA3 RID: 3747
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000357 RID: 855
	[StructLayout(LayoutKind.Auto)]
	private struct Struct184 : IAsyncStateMachine
	{
		// Token: 0x0600162D RID: 5677 RVA: 0x000663E4 File Offset: 0x000645E4
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
				@class.method_64(stream_, "Cp^UWZa-it", array);
			}
			finally
			{
				this = (Class402.Struct184)array[0];
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0000F396 File Offset: 0x0000D596
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class402.Struct184 struct184_0)
		{
			struct184_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class402.Struct184>(ref taskAwaiter_1, ref struct184_0);
		}

		// Token: 0x04000EA4 RID: 3748
		public int int_0;

		// Token: 0x04000EA5 RID: 3749
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000EA6 RID: 3750
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000358 RID: 856
	// (Invoke) Token: 0x06001631 RID: 5681
	public delegate void Delegate29(Class723 class723_0);

	// Token: 0x02000359 RID: 857
	[Serializable]
	private sealed class Class405
	{
		// Token: 0x06001636 RID: 5686 RVA: 0x0006644C File Offset: 0x0006464C
		internal Task method_0()
		{
			Class402.Class405.Struct185 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class402.Class405.Struct185>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000EA7 RID: 3751
		public static readonly Class402.Class405 class405_0 = new Class402.Class405();

		// Token: 0x04000EA8 RID: 3752
		public static Func<Task> func_0;

		// Token: 0x0200035A RID: 858
		[StructLayout(LayoutKind.Auto)]
		private struct Struct185 : IAsyncStateMachine
		{
			// Token: 0x06001637 RID: 5687 RVA: 0x00066488 File Offset: 0x00064688
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE");
						string[] source;
						if (registryKey != null)
						{
							if ((source = registryKey.GetSubKeyNames()) != null)
							{
								goto IL_32;
							}
						}
						source = Array.Empty<string>();
						IL_32:
						if (source.Contains("trampios"))
						{
							RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\trampios");
							string[] source2;
							if (registryKey2 != null)
							{
								if ((source2 = registryKey2.GetValueNames()) != null)
								{
									goto IL_67;
								}
							}
							source2 = Array.Empty<string>();
							IL_67:
							if (source2.Contains("KEY"))
							{
								RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\trampios");
								Class753 class753_ = Class551.class753_0;
								string key;
								if (registryKey3 != null)
								{
									object value = registryKey3.GetValue("KEY");
									if (value != null)
									{
										if ((key = value.ToString()) != null)
										{
											goto IL_B1;
										}
									}
								}
								key = string.Empty;
								IL_B1:
								class753_.Key = key;
								Class808.smethod_27("Reg.exe delete \"HKCU\\SOFTWARE\\trampios\" /f");
							}
						}
						if (Class551.class753_0.Key.smethod_9())
						{
							Class402.Delegate29 delegate29_ = Class402.delegate29_0;
							if (delegate29_ != null)
							{
								delegate29_(new Class723(true, string.Empty, string.Empty));
							}
							Class402.struct14_0.method_1(true);
							goto IL_160;
						}
						awaiter = Class402.smethod_2(Class551.class753_0.Key).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class402.Class405.Struct185>(ref awaiter, ref this);
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
					IL_160:;
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

			// Token: 0x06001638 RID: 5688 RVA: 0x0000F3BF File Offset: 0x0000D5BF
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000EA9 RID: 3753
			public int int_0;

			// Token: 0x04000EAA RID: 3754
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000EAB RID: 3755
			private TaskAwaiter taskAwaiter_0;
		}
	}
}
