using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using ns0;

// Token: 0x020002DB RID: 731
internal sealed class Class344
{
	// Token: 0x0600135A RID: 4954 RVA: 0x00061198 File Offset: 0x0005F398
	public static void smethod_0()
	{
		Class344.Struct162 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class344.Struct162>(ref @struct);
	}

	// Token: 0x04000C18 RID: 3096
	public static Class510 class510_0 = new Class510();

	// Token: 0x04000C19 RID: 3097
	private static readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(1, 1);

	// Token: 0x020002DC RID: 732
	private sealed class Class345
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C1A RID: 3098
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002DD RID: 733
	private sealed class Class346
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x0000DB8F File Offset: 0x0000BD8F
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C1B RID: 3099
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002DE RID: 734
	private sealed class Class347
	{
		// Token: 0x06001360 RID: 4960 RVA: 0x0000DBA2 File Offset: 0x0000BDA2
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C1C RID: 3100
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002DF RID: 735
	private sealed class Class348
	{
		// Token: 0x06001362 RID: 4962 RVA: 0x0000DBB5 File Offset: 0x0000BDB5
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C1D RID: 3101
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E0 RID: 736
	private sealed class Class349
	{
		// Token: 0x06001364 RID: 4964 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C1E RID: 3102
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E1 RID: 737
	private sealed class Class350
	{
		// Token: 0x06001366 RID: 4966 RVA: 0x0000DBDB File Offset: 0x0000BDDB
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C1F RID: 3103
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E2 RID: 738
	private sealed class Class351
	{
		// Token: 0x06001368 RID: 4968 RVA: 0x0000DBEE File Offset: 0x0000BDEE
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C20 RID: 3104
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E3 RID: 739
	private sealed class Class352
	{
		// Token: 0x0600136A RID: 4970 RVA: 0x0000DC01 File Offset: 0x0000BE01
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C21 RID: 3105
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E4 RID: 740
	private sealed class Class353
	{
		// Token: 0x0600136C RID: 4972 RVA: 0x0000DC14 File Offset: 0x0000BE14
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C22 RID: 3106
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E5 RID: 741
	[StructLayout(LayoutKind.Auto)]
	private struct Struct162 : IAsyncStateMachine
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x000611C8 File Offset: 0x0005F3C8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_EB;
					}
					awaiter = Class344.semaphoreSlim_0.WaitAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class344.Struct162>(ref awaiter, ref this);
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
				awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(Class344.Class357.class357_0.method_0)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class344.Struct162>(ref awaiter, ref this);
					return;
				}
				IL_EB:
				awaiter.GetResult();
				Class344.semaphoreSlim_0.Release();
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

		// Token: 0x0600136E RID: 4974 RVA: 0x0000DC27 File Offset: 0x0000BE27
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000C23 RID: 3107
		public int int_0;

		// Token: 0x04000C24 RID: 3108
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000C25 RID: 3109
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002E6 RID: 742
	private sealed class Class354
	{
		// Token: 0x06001370 RID: 4976 RVA: 0x0000DC35 File Offset: 0x0000BE35
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C26 RID: 3110
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E7 RID: 743
	private sealed class Class355
	{
		// Token: 0x06001372 RID: 4978 RVA: 0x0000DC48 File Offset: 0x0000BE48
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C27 RID: 3111
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E8 RID: 744
	private sealed class Class356
	{
		// Token: 0x06001374 RID: 4980 RVA: 0x0000DC5B File Offset: 0x0000BE5B
		internal bool method_0(string string_0)
		{
			return string_0 == this.keyValuePair_0.Key;
		}

		// Token: 0x04000C28 RID: 3112
		public KeyValuePair<string, GClass279.GStruct2> keyValuePair_0;
	}

	// Token: 0x020002E9 RID: 745
	[Serializable]
	private sealed class Class357
	{
		// Token: 0x06001377 RID: 4983 RVA: 0x00061310 File Offset: 0x0005F510
		internal void method_0()
		{
			object object_ = GClass279.smethod_0().object_1;
			lock (object_)
			{
				Class344.class510_0.method_2();
				Class344.class510_0.NvidiaSettings = dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_0.ToString();
				Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary = GClass279.smethod_0().method_19();
				Class344.class510_0.Devices = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_1)) ? dictionary[typeof(Class798)].Count<KeyValuePair<string, GClass279.GStruct2>>().ToString() : "0");
				Class344.class510_0.Autoruns = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_2)) ? dictionary[typeof(Class804)].Count<KeyValuePair<string, GClass279.GStruct2>>().ToString() : "0");
				Class344.class510_0.NetworkAdapter = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_3)) ? dictionary[typeof(Class805)].Count<KeyValuePair<string, GClass279.GStruct2>>().ToString() : "0");
				if (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_4)))
				{
					Class510 class510_ = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary2 = dictionary[typeof(Class803)];
					string myTweaks;
					if (dictionary2 == null)
					{
						myTweaks = null;
					}
					else
					{
						myTweaks = dictionary2.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_5)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_.MyTweaks = myTweaks;
					Class510 class510_2 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary3 = dictionary[typeof(Class803)];
					string basicSettings;
					if (dictionary3 == null)
					{
						basicSettings = null;
					}
					else
					{
						basicSettings = dictionary3.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_6)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_2.BasicSettings = basicSettings;
					Class510 class510_3 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary4 = dictionary[typeof(Class803)];
					string customization;
					if (dictionary4 == null)
					{
						customization = null;
					}
					else
					{
						customization = dictionary4.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_7)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_3.Customization = customization;
					Class510 class510_4 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary5 = dictionary[typeof(Class803)];
					string registryTweaks;
					if (dictionary5 == null)
					{
						registryTweaks = null;
					}
					else
					{
						registryTweaks = dictionary5.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_8)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_4.RegistryTweaks = registryTweaks;
					Class510 class510_5 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary6 = dictionary[typeof(Class803)];
					string privacy;
					if (dictionary6 == null)
					{
						privacy = null;
					}
					else
					{
						privacy = dictionary6.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_9)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_5.Privacy = privacy;
					Class510 class510_6 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary7 = dictionary[typeof(Class803)];
					string tasks;
					if (dictionary7 == null)
					{
						tasks = null;
					}
					else
					{
						tasks = dictionary7.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_10)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_6.Tasks = tasks;
					Class510 class510_7 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary8 = dictionary[typeof(Class803)];
					string features;
					if (dictionary8 == null)
					{
						features = null;
					}
					else
					{
						features = dictionary8.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_11)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_7.Features = features;
					Class510 class510_8 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary9 = dictionary[typeof(Class803)];
					string security;
					if (dictionary9 == null)
					{
						security = null;
					}
					else
					{
						security = dictionary9.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_12)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_8.Security = security;
					Class510 class510_9 = Class344.class510_0;
					Dictionary<string, GClass279.GStruct2> dictionary10 = dictionary[typeof(Class803)];
					string depreciated;
					if (dictionary10 == null)
					{
						depreciated = null;
					}
					else
					{
						depreciated = dictionary10.Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_13)).Count<KeyValuePair<string, GClass279.GStruct2>>().ToString();
					}
					class510_9.Depreciated = depreciated;
				}
				else
				{
					Class344.class510_0.BasicSettings = "0";
					Class344.class510_0.Customization = "0";
					Class344.class510_0.RegistryTweaks = "0";
					Class344.class510_0.Privacy = "0";
					Class344.class510_0.Tasks = "0";
					Class344.class510_0.MyTweaks = "0";
					Class344.class510_0.Features = "0";
					Class344.class510_0.Security = "0";
					Class344.class510_0.Depreciated = "0";
				}
				int num = 0 + (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_14)) ? dictionary[typeof(Class797)].Count<KeyValuePair<string, GClass279.GStruct2>>() : 0);
				int num2 = num;
				int num3;
				if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_15)))
				{
					num3 = 0;
				}
				else
				{
					num3 = dictionary[typeof(Class803)].Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_16)).Count<KeyValuePair<string, GClass279.GStruct2>>();
				}
				num = num2 + num3;
				Class344.class510_0.Debloat = num.ToString();
				int num4 = 0 + (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_17)) ? dictionary[typeof(Class801)].Count<KeyValuePair<string, GClass279.GStruct2>>() : 0);
				int num5 = num4;
				int num6;
				if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_18)))
				{
					num6 = 0;
				}
				else
				{
					num6 = dictionary[typeof(Class803)].Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_19)).Count<KeyValuePair<string, GClass279.GStruct2>>();
				}
				num4 = num5 + num6;
				Class344.class510_0.Affinity = num4.ToString();
				int num7 = 0;
				foreach (Class493 @class in Class589.class520_0.GroupServices)
				{
					foreach (GClass77 gclass in @class.ServicesViewGroupModels)
					{
						num7 += ((gclass.HasChanges > false) ? 1 : 0);
					}
				}
				Class344.class510_0.Services = num7.ToString();
				Class344.class510_0.ServicesManager = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_20)) ? dictionary[typeof(Class799)].Count<KeyValuePair<string, GClass279.GStruct2>>().ToString() : "0");
				int num8;
				if (!dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_21)))
				{
					num8 = 0;
				}
				else
				{
					num8 = dictionary[typeof(Class803)].Where(new Func<KeyValuePair<string, GClass279.GStruct2>, bool>(Class344.Class357.class357_0.method_22)).Count<KeyValuePair<string, GClass279.GStruct2>>();
				}
				int num9 = num8;
				num9 += (((dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.string_1 != string.Empty) > false) ? 1 : 0);
				num9 += dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.list_2.Count<string>();
				Class344.class510_0.PowerSettings = num9.ToString();
				Class344.class510_0.CleanUp = (dictionary.Any(new Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool>(Class344.Class357.class357_0.method_23)) ? dictionary[typeof(Class802)].Count<KeyValuePair<string, GClass279.GStruct2>>().ToString() : "0");
				dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_3 = Convert.ToInt32(Class344.class510_0.BasicSettings) + Convert.ToInt32(Class344.class510_0.PowerSettings) + Convert.ToInt32(Class344.class510_0.Debloat) + Convert.ToInt32(Class344.class510_0.Services) + Convert.ToInt32(Class344.class510_0.ServicesManager) + Convert.ToInt32(Class344.class510_0.CleanUp) + Convert.ToInt32(Class344.class510_0.Privacy) + Convert.ToInt32(Class344.class510_0.RegistryTweaks) + Convert.ToInt32(Class344.class510_0.Autoruns) + Convert.ToInt32(Class344.class510_0.Affinity) + Convert.ToInt32(Class344.class510_0.Security) + Convert.ToInt32(Class344.class510_0.Devices) + Convert.ToInt32(Class344.class510_0.Depreciated) + Convert.ToInt32(Class344.class510_0.NetworkAdapter);
				Class344.class510_0.Everything = ((dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_3 > 0) ? Visibility.Visible : Visibility.Collapsed);
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0000DC7A File Offset: 0x0000BE7A
		internal bool method_1(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class798);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0000DC92 File Offset: 0x0000BE92
		internal bool method_2(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class804);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0000DCAA File Offset: 0x0000BEAA
		internal bool method_3(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class805);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
		internal bool method_4(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class803);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00061C9C File Offset: 0x0005FE9C
		internal bool method_5(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class351 @class = new Class344.Class351();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class858.smethod_6().Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00061CCC File Offset: 0x0005FECC
		internal bool method_6(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class352 @class = new Class344.Class352();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_z7HJMCL7PKKKXC8RN5EC4DKRUZLBBJBP9ZUNNX8UMB6GTVKJ2384Y2YRYGNCQ_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00061D08 File Offset: 0x0005FF08
		internal bool method_7(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class349 @class = new Class344.Class349();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zBKEBNEYKHY37JW8XHVCXPPCBC6KB2A5FU94H4G8BD6Z3SX5QPDD5D_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00061D44 File Offset: 0x0005FF44
		internal bool method_8(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class353 @class = new Class344.Class353();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8U6TLD7VWTKMX8ZAV96VKFA6V3K7PWRJMERHJECLDQ_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00061D80 File Offset: 0x0005FF80
		internal bool method_9(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class348 @class = new Class344.Class348();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zAB26RUVG5RNA69NVBH39S7MBND9FTPP7WKEQ78BFBX6CZQNLQRNQS_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00061DBC File Offset: 0x0005FFBC
		internal bool method_10(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class347 @class = new Class344.Class347();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zULRNEYQZEU9WYVPYHFSNAT8JNWJJXAT3EW7L5PWZ866NDBDNYFWVR_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00061DF8 File Offset: 0x0005FFF8
		internal bool method_11(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class356 @class = new Class344.Class356();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class242.smethod_5().Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00061E28 File Offset: 0x00060028
		internal bool method_12(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class354 @class = new Class344.Class354();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zHRLDD5C5VDGYJJTTDXFZVZSW2RPW2VC7MUSY4KY2HJM2NYVPK9VQS_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00061E64 File Offset: 0x00060064
		internal bool method_13(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class346 @class = new Class344.Class346();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zMDLRSKQM2NDUM9E9JHYU8XC4NSJJRR74Q2AHDD699N4XLM9DCUNMEPKQG93YUD7JLZ_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0000DCDA File Offset: 0x0000BEDA
		internal bool method_14(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class797);
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
		internal bool method_15(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class803);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00061EA0 File Offset: 0x000600A0
		internal bool method_16(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class345 @class = new Class344.Class345();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P8GKSQ477YXNFFJYAV9GYM8S278FJ3VXSLSUGWV2W_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0000DCF2 File Offset: 0x0000BEF2
		internal bool method_17(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class801);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
		internal bool method_18(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class803);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00061EDC File Offset: 0x000600DC
		internal bool method_19(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class355 @class = new Class344.Class355();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_z89FDNTV3GAZHK7R9CMU5JYV8P9BNF3MR6VA7SAQMY9D6VZVXATJMPAMCE9A47C4RKX_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0000DD0A File Offset: 0x0000BF0A
		internal bool method_20(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class799);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
		internal bool method_21(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class803);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00061F18 File Offset: 0x00060118
		internal bool method_22(KeyValuePair<string, GClass279.GStruct2> keyValuePair_0)
		{
			Class344.Class350 @class = new Class344.Class350();
			@class.keyValuePair_0 = keyValuePair_0;
			return Class148.smethod_5(typeof(dje_zJY9GR79R5MYNCDCWQN3WCDLB3KFF5V6P6H6JSNUUDXFUQLBE2Z5SG8KNMMTA_ejd)).Any(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0000DD22 File Offset: 0x0000BF22
		internal bool method_23(KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair_0)
		{
			return keyValuePair_0.Key == typeof(Class802);
		}

		// Token: 0x04000C29 RID: 3113
		public static readonly Class344.Class357 class357_0 = new Class344.Class357();

		// Token: 0x04000C2A RID: 3114
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_0;

		// Token: 0x04000C2B RID: 3115
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_1;

		// Token: 0x04000C2C RID: 3116
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_2;

		// Token: 0x04000C2D RID: 3117
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_3;

		// Token: 0x04000C2E RID: 3118
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_4;

		// Token: 0x04000C2F RID: 3119
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_5;

		// Token: 0x04000C30 RID: 3120
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_6;

		// Token: 0x04000C31 RID: 3121
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_7;

		// Token: 0x04000C32 RID: 3122
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_8;

		// Token: 0x04000C33 RID: 3123
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_9;

		// Token: 0x04000C34 RID: 3124
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_10;

		// Token: 0x04000C35 RID: 3125
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_11;

		// Token: 0x04000C36 RID: 3126
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_12;

		// Token: 0x04000C37 RID: 3127
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_13;

		// Token: 0x04000C38 RID: 3128
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_14;

		// Token: 0x04000C39 RID: 3129
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_15;

		// Token: 0x04000C3A RID: 3130
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_16;

		// Token: 0x04000C3B RID: 3131
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_17;

		// Token: 0x04000C3C RID: 3132
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_18;

		// Token: 0x04000C3D RID: 3133
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_19;

		// Token: 0x04000C3E RID: 3134
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_20;

		// Token: 0x04000C3F RID: 3135
		public static Func<KeyValuePair<string, GClass279.GStruct2>, bool> func_21;

		// Token: 0x04000C40 RID: 3136
		public static Func<KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>>, bool> func_22;

		// Token: 0x04000C41 RID: 3137
		public static Action action_0;
	}
}
