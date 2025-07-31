using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using ns0;

// Token: 0x0200029D RID: 669
internal sealed class Class313
{
	// Token: 0x060011CC RID: 4556 RVA: 0x0000CE5D File Offset: 0x0000B05D
	public static Class509 smethod_0(bool bool_2)
	{
		if (!Class313.bool_0 || bool_2)
		{
			Class313.bool_0 = true;
			Class313.bool_1 = false;
			GClass279.smethod_0().method_17<Class797>();
			Class313.smethod_1();
		}
		return Class313.class509_0;
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x0005A648 File Offset: 0x00058848
	public static void smethod_1()
	{
		Class313.Struct147 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class313.Struct147>(ref @struct);
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x0005A678 File Offset: 0x00058878
	public static Task smethod_2()
	{
		Class313.Struct149 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class313.Struct149>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x0005A6B4 File Offset: 0x000588B4
	public static Task smethod_3()
	{
		Class313.Struct150 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class313.Struct150>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x0005A6F0 File Offset: 0x000588F0
	public static Task smethod_4()
	{
		Class313.Struct148 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class313.Struct148>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x0005A72C File Offset: 0x0005892C
	public static Task<List<Class265>> smethod_5()
	{
		Class313.Struct151 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<List<Class265>>.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class313.Struct151>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x0005A768 File Offset: 0x00058968
	public static void smethod_6(Class525 class525_0)
	{
		Class313.Class314 @class = new Class313.Class314();
		@class.class525_0 = class525_0;
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
	}

	// Token: 0x04000B17 RID: 2839
	private static Class509 class509_0 = new Class509();

	// Token: 0x04000B18 RID: 2840
	private static bool bool_0 = false;

	// Token: 0x04000B19 RID: 2841
	private static bool bool_1 = false;

	// Token: 0x0200029E RID: 670
	private sealed class Class314
	{
		// Token: 0x060011D4 RID: 4564 RVA: 0x0000CE8B File Offset: 0x0000B08B
		internal void method_0()
		{
			Class313.class509_0.WinUwpAppsModels.Remove(this.class525_0);
		}

		// Token: 0x04000B1A RID: 2842
		public Class525 class525_0;
	}

	// Token: 0x0200029F RID: 671
	[StructLayout(LayoutKind.Auto)]
	private struct Struct147 : IAsyncStateMachine
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x0005A7A0 File Offset: 0x000589A0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(Class313.Class318.class318_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class313.Struct147>(ref awaiter, ref this);
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

		// Token: 0x060011D6 RID: 4566 RVA: 0x0000CEA3 File Offset: 0x0000B0A3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B1B RID: 2843
		public int int_0;

		// Token: 0x04000B1C RID: 2844
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000B1D RID: 2845
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002A0 RID: 672
	[StructLayout(LayoutKind.Auto)]
	private struct Struct148 : IAsyncStateMachine
	{
		// Token: 0x060011D7 RID: 4567 RVA: 0x0005A86C File Offset: 0x00058A6C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_5E;
				}
				this.int_1 = 0;
				IL_41:
				if (Class313.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class313.Struct148>(ref awaiter, ref this);
					return;
				}
				IL_5E:
				awaiter.GetResult();
				if (this.int_1 <= 1000)
				{
					int num2 = this.int_1;
					this.int_1 = num2 + 1;
					goto IL_41;
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_AD:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0000CEB1 File Offset: 0x0000B0B1
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B1E RID: 2846
		public int int_0;

		// Token: 0x04000B1F RID: 2847
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000B20 RID: 2848
		private int int_1;

		// Token: 0x04000B21 RID: 2849
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002A1 RID: 673
	private sealed class Class315
	{
		// Token: 0x060011DA RID: 4570 RVA: 0x0005A94C File Offset: 0x00058B4C
		internal void method_0()
		{
			Class313.class509_0.WinUwpAppsModels.Add(new Class525
			{
				AppxFriendlyName = this.gclass5_0.DisplayName,
				AppxLocation = this.gclass5_0.method_10(),
				AppxFullName = this.gclass5_0.method_8(),
				ToDelete = false
			});
		}

		// Token: 0x04000B22 RID: 2850
		public GClass4.GClass5 gclass5_0;
	}

	// Token: 0x020002A2 RID: 674
	[StructLayout(LayoutKind.Auto)]
	private struct Struct149 : IAsyncStateMachine
	{
		// Token: 0x060011DB RID: 4571 RVA: 0x0005A9A8 File Offset: 0x00058BA8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class313.bool_0)
					{
						Class313.smethod_0(false);
					}
					awaiter = Class313.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class313.Struct149>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				if (Class313.class509_0.WinUwpAppsModels.Count != 0)
				{
					IEnumerator<Class525> enumerator = Class313.class509_0.WinUwpAppsModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class313.Class317 @class = new Class313.Class317();
							@class.class525_0 = enumerator.Current;
							if (Class725.list_10.Any(new Func<string, bool>(@class.method_0)))
							{
								@class.class525_0.ToDelete = true;
							}
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				IEnumerator<Class512> enumerator2 = Class313.class509_0.CustomDebloatList.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class512 class2 = enumerator2.Current;
						class2.method_35();
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
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

		// Token: 0x060011DC RID: 4572 RVA: 0x0000CEBF File Offset: 0x0000B0BF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B23 RID: 2851
		public int int_0;

		// Token: 0x04000B24 RID: 2852
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000B25 RID: 2853
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002A3 RID: 675
	private sealed class Class316
	{
		// Token: 0x060011DE RID: 4574 RVA: 0x0000CECD File Offset: 0x0000B0CD
		internal void method_0()
		{
			Class313.class509_0.method_2();
			Class313.class509_0.CustomDebloatList = this.observableCollection_0;
		}

		// Token: 0x04000B26 RID: 2854
		public ObservableCollection<Class512> observableCollection_0;
	}

	// Token: 0x020002A4 RID: 676
	[StructLayout(LayoutKind.Auto)]
	private struct Struct150 : IAsyncStateMachine
	{
		// Token: 0x060011DF RID: 4575 RVA: 0x0005AB4C File Offset: 0x00058D4C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class313.bool_0)
					{
						Class313.smethod_0(false);
					}
					awaiter = Class313.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class313.Struct150>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				if (Class313.class509_0.WinUwpAppsModels.Count != 0)
				{
					IEnumerator<Class525> enumerator = Class313.class509_0.WinUwpAppsModels.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class525 @class = enumerator.Current;
							@class.ToDelete = true;
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				IEnumerator<Class512> enumerator2 = Class313.class509_0.CustomDebloatList.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class512 class2 = enumerator2.Current;
						class2.method_34();
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
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

		// Token: 0x060011E0 RID: 4576 RVA: 0x0000CEE9 File Offset: 0x0000B0E9
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B27 RID: 2855
		public int int_0;

		// Token: 0x04000B28 RID: 2856
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000B29 RID: 2857
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002A5 RID: 677
	[StructLayout(LayoutKind.Auto)]
	private struct Struct151 : IAsyncStateMachine
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x0005ACA0 File Offset: 0x00058EA0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			List<Class265> result;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					this.list_0 = new List<Class265>();
					this.class509_0 = Class313.smethod_0(false);
					awaiter = Class313.smethod_4().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class313.Struct151>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
				}
				awaiter.GetResult();
				IEnumerator<Class525> enumerator = this.class509_0.WinUwpAppsModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class525 @class = enumerator.Current;
						this.list_0.Add(new Class265
						{
							Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.APPX,
							Name = "APPX",
							State = @class.AppxFriendlyName
						});
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				IEnumerator<Class512> enumerator2 = this.class509_0.CustomDebloatList.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class512 class2 = enumerator2.Current;
						this.list_0.Add(new Class265
						{
							Type = dje_zU389FUMHLJXEWGUGK6AQQC3JPBAHJ4V5G6YN9BRZ_ejd.APPXCustom,
							Name = class2.method_21(),
							State = ((class2.CurrentValueType != "CUSTOM") ? class2.CurrentValueType : class2.CurrentCustomValue)
						});
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				result = this.list_0;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.list_0 = null;
				this.class509_0 = null;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.list_0 = null;
			this.class509_0 = null;
			this.asyncTaskMethodBuilder_0.SetResult(result);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0000CEF7 File Offset: 0x0000B0F7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000B2A RID: 2858
		public int int_0;

		// Token: 0x04000B2B RID: 2859
		public AsyncTaskMethodBuilder<List<Class265>> asyncTaskMethodBuilder_0;

		// Token: 0x04000B2C RID: 2860
		private List<Class265> list_0;

		// Token: 0x04000B2D RID: 2861
		private Class509 class509_0;

		// Token: 0x04000B2E RID: 2862
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002A6 RID: 678
	private sealed class Class317
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x0000CF05 File Offset: 0x0000B105
		internal bool method_0(string string_0)
		{
			return this.class525_0.AppxFullName.ToLower().StartsWith(string_0.ToLower());
		}

		// Token: 0x04000B2F RID: 2863
		public Class525 class525_0;
	}

	// Token: 0x020002A7 RID: 679
	[Serializable]
	private sealed class Class318
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x0005AEB0 File Offset: 0x000590B0
		internal Task method_0()
		{
			Class313.Class318.Struct152 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class313.Class318.Struct152>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000B30 RID: 2864
		public static readonly Class313.Class318 class318_0 = new Class313.Class318();

		// Token: 0x04000B31 RID: 2865
		public static Func<Task> func_0;

		// Token: 0x020002A8 RID: 680
		[StructLayout(LayoutKind.Auto)]
		private struct Struct152 : IAsyncStateMachine
		{
			// Token: 0x060011E8 RID: 4584 RVA: 0x0005AEEC File Offset: 0x000590EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				try
				{
					TaskAwaiter<ObservableCollection<Class512>> awaiter;
					if (num != 0)
					{
						this.class316_0 = new Class313.Class316();
						awaiter = Class148.smethod_2(typeof(dje_zV7JVTGZ7W7XZV5CGJLRZY5344P8GKSQ477YXNFFJYAV9GYM8S278FJ3VXSLSUGWV2W_ejd), true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num2 = 0;
							num = 0;
							this.int_0 = num2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class313.Class318.Struct152>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ObservableCollection<Class512>>);
						int num3 = -1;
						num = -1;
						this.int_0 = num3;
					}
					ObservableCollection<Class512> result = awaiter.GetResult();
					this.class316_0.observableCollection_0 = result;
					Application.Current.Dispatcher.Invoke(new Action(this.class316_0.method_0));
					List<GClass4.GClass5>.Enumerator enumerator = Class620.smethod_0().method_4().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class313.Class315 @class = new Class313.Class315();
							@class.gclass5_0 = enumerator.Current;
							if (!@class.gclass5_0.method_12() && !@class.gclass5_0.Name.ToLower().Contains("healthui"))
							{
								Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					Class313.bool_1 = true;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class316_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class316_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x060011E9 RID: 4585 RVA: 0x0000CF2E File Offset: 0x0000B12E
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000B32 RID: 2866
			public int int_0;

			// Token: 0x04000B33 RID: 2867
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000B34 RID: 2868
			private Class313.Class316 class316_0;

			// Token: 0x04000B35 RID: 2869
			private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
		}
	}
}
