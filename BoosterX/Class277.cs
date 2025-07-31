using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Dism;

// Token: 0x0200025A RID: 602
internal sealed class Class277
{
	// Token: 0x06001046 RID: 4166 RVA: 0x000570D4 File Offset: 0x000552D4
	public static List<Class785> smethod_0()
	{
		object obj = Class277.object_0;
		List<Class785> result;
		lock (obj)
		{
			if (!Class277.bool_0)
			{
				Class277.bool_0 = true;
				DismApi.Initialize(0);
				Class277.dismSession_0 = DismApi.OpenOnlineSessionEx(new DismSessionOptions
				{
					ThrowExceptionOnRebootRequired = false
				});
			}
			ReadOnlyCollection<DismFeature> features = DismApi.GetFeatures(Class277.dismSession_0);
			Class277.list_0.Clear();
			foreach (DismFeature dismFeature in features)
			{
				if (!string.IsNullOrEmpty(dismFeature.FeatureName))
				{
					List<Class785> list = Class277.list_0;
					Class785 @class = new Class785();
					@class.method_1(dismFeature.FeatureName);
					@class.State = dismFeature.State.ToString();
					list.Add(@class);
				}
			}
			result = Class277.list_0;
		}
		return result;
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x0000BEBF File Offset: 0x0000A0BF
	public static void smethod_1(string string_0)
	{
		Task.Run(new Func<Task>(new Class277.Class278
		{
			string_0 = string_0
		}.method_0)).Wait();
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x0000BEE2 File Offset: 0x0000A0E2
	public static void smethod_2(string string_0)
	{
		Task.Run(new Func<Task>(new Class277.Class280
		{
			string_0 = string_0
		}.method_0)).Wait();
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x000571C8 File Offset: 0x000553C8
	public static void smethod_3(string string_0)
	{
		if (Class277.bool_1 || Class277.bool_2)
		{
			return;
		}
		if (string_0 == "NetFx4-AdvSrvs")
		{
			return;
		}
		try
		{
			Class808.smethod_27("dism /online /disable-feature /featurename:" + string_0 + " /NoRestart");
		}
		catch
		{
		}
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00057220 File Offset: 0x00055420
	public static void smethod_4(string string_0)
	{
		if (!Class277.bool_1 && !Class277.bool_2)
		{
			try
			{
				Class808.smethod_27("dism /online /enable-feature /featurename:" + string_0 + " /NoRestart");
			}
			catch
			{
			}
			return;
		}
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x0000BF05 File Offset: 0x0000A105
	public static DismFeatureCollection smethod_5(string string_0)
	{
		return DismApi.GetFeatureParentByName(Class277.dismSession_0, string_0, null);
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x0000BF13 File Offset: 0x0000A113
	public static DismFeatureInfo smethod_6(string string_0)
	{
		return DismApi.GetFeatureInfo(Class277.dismSession_0, string_0);
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x0005726C File Offset: 0x0005546C
	public static string smethod_7(string string_0, bool bool_3)
	{
		Class277.Class279 @class = new Class277.Class279();
		@class.string_0 = string_0;
		object obj = Class277.object_0;
		string result;
		lock (obj)
		{
			Class785 class2 = Class277.list_0.FirstOrDefault(new Func<Class785, bool>(@class.method_0));
			if (class2 != null && class2 != null)
			{
				string state = class2.State;
				if (state == "Installed" && bool_3)
				{
					result = "BEST";
				}
				else if (state == "Installed" && !bool_3)
				{
					result = "DEFAULT";
				}
				else if (state == "Staged" && bool_3)
				{
					result = "DEFAULT";
				}
				else if (state == "Staged" && !bool_3)
				{
					result = "BEST";
				}
				else
				{
					result = "DEFAULT";
				}
			}
			else
			{
				result = "DEFAULT";
			}
		}
		return result;
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x0005735C File Offset: 0x0005555C
	internal static List<Class275> smethod_8(string string_0)
	{
		List<Class275> list = new List<Class275>();
		if (Class195.list_0.Contains(string_0))
		{
			list.Add(new Class275
			{
				String_0 = "Enable",
				List_0 = new List<string>
				{
					"ON",
					"BEST"
				}
			});
			list.Add(new Class275
			{
				String_0 = "Disable",
				List_0 = new List<string>
				{
					"OFF",
					"DEFAULT"
				}
			});
			return list;
		}
		list.Add(new Class275
		{
			String_0 = "Disable",
			List_0 = new List<string>
			{
				"OFF",
				"BEST"
			}
		});
		list.Add(new Class275
		{
			String_0 = "Enable",
			List_0 = new List<string>
			{
				"ON",
				"DEFAULT"
			}
		});
		return list;
	}

	// Token: 0x04000A3A RID: 2618
	private static bool bool_0 = false;

	// Token: 0x04000A3B RID: 2619
	private static DismSession dismSession_0;

	// Token: 0x04000A3C RID: 2620
	public static List<Class785> list_0 = new List<Class785>();

	// Token: 0x04000A3D RID: 2621
	private static object object_0 = new object();

	// Token: 0x04000A3E RID: 2622
	public static bool bool_1 = false;

	// Token: 0x04000A3F RID: 2623
	public static bool bool_2 = false;

	// Token: 0x0200025B RID: 603
	private sealed class Class278
	{
		// Token: 0x06001050 RID: 4176 RVA: 0x0005746C File Offset: 0x0005566C
		internal Task method_0()
		{
			Class277.Class278.Struct138 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class278_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class277.Class278.Struct138>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0000BF20 File Offset: 0x0000A120
		internal void method_1()
		{
			Class277.smethod_4(this.string_0);
		}

		// Token: 0x04000A40 RID: 2624
		public string string_0;

		// Token: 0x04000A41 RID: 2625
		public Action action_0;

		// Token: 0x0200025C RID: 604
		[StructLayout(LayoutKind.Auto)]
		private struct Struct138 : IAsyncStateMachine
		{
			// Token: 0x06001052 RID: 4178 RVA: 0x000574B0 File Offset: 0x000556B0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class277.Class278 @class = this.class278_0;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						Class277.bool_2 = !Class673.smethod_28();
						this.task_0 = Task.Delay(TimeSpan.FromMinutes(5.0));
						Action action;
						if ((action = @class.action_0) == null)
						{
							action = (@class.action_0 = new Action(@class.method_1));
						}
						Task task = Task.Run(action);
						awaiter = Task.WhenAny(new Task[]
						{
							task,
							this.task_0
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class277.Class278.Struct138>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Task>);
						this.int_0 = -1;
					}
					if (awaiter.GetResult() == this.task_0)
					{
						Class277.bool_1 = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.task_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.task_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001053 RID: 4179 RVA: 0x0000BF2D File Offset: 0x0000A12D
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A42 RID: 2626
			public int int_0;

			// Token: 0x04000A43 RID: 2627
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000A44 RID: 2628
			public Class277.Class278 class278_0;

			// Token: 0x04000A45 RID: 2629
			private Task task_0;

			// Token: 0x04000A46 RID: 2630
			private TaskAwaiter<Task> taskAwaiter_0;
		}
	}

	// Token: 0x0200025D RID: 605
	private sealed class Class279
	{
		// Token: 0x06001055 RID: 4181 RVA: 0x0000BF3B File Offset: 0x0000A13B
		internal bool method_0(Class785 class785_0)
		{
			return class785_0.method_0() == this.string_0;
		}

		// Token: 0x04000A47 RID: 2631
		public string string_0;
	}

	// Token: 0x0200025E RID: 606
	private sealed class Class280
	{
		// Token: 0x06001057 RID: 4183 RVA: 0x000575E4 File Offset: 0x000557E4
		internal Task method_0()
		{
			Class277.Class280.Struct139 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class280_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class277.Class280.Struct139>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0000BF4E File Offset: 0x0000A14E
		internal void method_1()
		{
			Class277.smethod_3(this.string_0);
		}

		// Token: 0x04000A48 RID: 2632
		public string string_0;

		// Token: 0x04000A49 RID: 2633
		public Action action_0;

		// Token: 0x0200025F RID: 607
		[StructLayout(LayoutKind.Auto)]
		private struct Struct139 : IAsyncStateMachine
		{
			// Token: 0x06001059 RID: 4185 RVA: 0x00057628 File Offset: 0x00055828
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class277.Class280 @class = this.class280_0;
				try
				{
					TaskAwaiter<Task> awaiter;
					if (num != 0)
					{
						Class277.bool_2 = !Class673.smethod_28();
						this.task_0 = Task.Delay(TimeSpan.FromMinutes(5.0));
						Action action;
						if ((action = @class.action_0) == null)
						{
							action = (@class.action_0 = new Action(@class.method_1));
						}
						Task task = Task.Run(action);
						awaiter = Task.WhenAny(new Task[]
						{
							task,
							this.task_0
						}).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Task>, Class277.Class280.Struct139>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<Task>);
						this.int_0 = -1;
					}
					if (awaiter.GetResult() == this.task_0)
					{
						Class277.bool_1 = true;
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.task_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.task_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x0600105A RID: 4186 RVA: 0x0000BF5B File Offset: 0x0000A15B
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000A4A RID: 2634
			public int int_0;

			// Token: 0x04000A4B RID: 2635
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000A4C RID: 2636
			public Class277.Class280 class280_0;

			// Token: 0x04000A4D RID: 2637
			private Task task_0;

			// Token: 0x04000A4E RID: 2638
			private TaskAwaiter<Task> taskAwaiter_0;
		}
	}
}
