using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows;
using ns0;

// Token: 0x020004D7 RID: 1239
internal sealed class Class589
{
	// Token: 0x06001FA0 RID: 8096 RVA: 0x00014F40 File Offset: 0x00013140
	public static void smethod_0()
	{
		Class589.class520_0.method_2();
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x00014F4C File Offset: 0x0001314C
	public static Class520 smethod_1(bool bool_2)
	{
		if (!Class589.bool_0 || bool_2)
		{
			Class589.bool_1 = false;
			Class589.bool_0 = true;
			GClass279.smethod_0().method_17<Class799>();
			Class589.smethod_2();
		}
		return Class589.class520_0;
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x00080AB4 File Offset: 0x0007ECB4
	private static void smethod_2()
	{
		Class589.Struct329 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class589.Struct329>(ref @struct);
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x00080AE4 File Offset: 0x0007ECE4
	private static List<GClass77> smethod_3(List<GClass184> list_0, GClass209.GClass210 gclass210_0)
	{
		Class589.Class592 @class = new Class589.Class592();
		@class.list_0 = list_0;
		return gclass210_0.method_0().Select(new Func<GClass209.GClass211, GClass77>(@class.method_0)).ToList<GClass77>();
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x00080B1C File Offset: 0x0007ED1C
	public static Task smethod_4()
	{
		Class589.Struct325 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class589.Struct325>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x00080B58 File Offset: 0x0007ED58
	public static Task smethod_5(RoutedEventArgs routedEventArgs_0)
	{
		Class589.Struct328 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class589.Struct328>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x00080B94 File Offset: 0x0007ED94
	public static Task smethod_6()
	{
		Class589.Struct326 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class589.Struct326>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x00080BD0 File Offset: 0x0007EDD0
	public static Task smethod_7()
	{
		Class589.Struct327 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class589.Struct327>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04001515 RID: 5397
	public static Class520 class520_0 = new Class520();

	// Token: 0x04001516 RID: 5398
	private static bool bool_0 = false;

	// Token: 0x04001517 RID: 5399
	private static bool bool_1 = false;

	// Token: 0x020004D8 RID: 1240
	private sealed class Class590
	{
		// Token: 0x06001FA9 RID: 8105 RVA: 0x00014F7A File Offset: 0x0001317A
		internal void method_0()
		{
			Class589.class520_0.AllServices.Add(this.gclass184_0);
		}

		// Token: 0x04001518 RID: 5400
		public GClass184 gclass184_0;
	}

	// Token: 0x020004D9 RID: 1241
	private sealed class Class591
	{
		// Token: 0x06001FAB RID: 8107 RVA: 0x00014F91 File Offset: 0x00013191
		internal void method_0(GClass209.GClass211 gclass211_0)
		{
			if (gclass211_0 == this.gclass77_0.ServicesViewGroupName)
			{
				this.gclass77_0.IsDisabled = new bool?(true);
			}
		}

		// Token: 0x04001519 RID: 5401
		public GClass77 gclass77_0;
	}

	// Token: 0x020004DA RID: 1242
	[StructLayout(LayoutKind.Auto)]
	private struct Struct325 : IAsyncStateMachine
	{
		// Token: 0x06001FAC RID: 8108 RVA: 0x00080C0C File Offset: 0x0007EE0C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class589.bool_1)
					{
						goto IL_6B;
					}
					awaiter = Class589.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class589.Struct325>(ref awaiter, ref this);
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
				IL_6B:
				IEnumerator<Class493> enumerator = Class589.class520_0.GroupServices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class493 @class = enumerator.Current;
						@class.ServicesViewGroupModels.ForEach(new Action<GClass77>(Class589.Class597.class597_0.method_2));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (!dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_9)
				{
					enumerator = Class589.class520_0.GroupServices.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class493 class2 = enumerator.Current;
							class2.ServicesViewGroupModels.ForEach(new Action<GClass77>(Class589.Class597.class597_0.method_3));
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

		// Token: 0x06001FAD RID: 8109 RVA: 0x00014FB2 File Offset: 0x000131B2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400151A RID: 5402
		public int int_0;

		// Token: 0x0400151B RID: 5403
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400151C RID: 5404
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DB RID: 1243
	private sealed class Class592
	{
		// Token: 0x06001FAF RID: 8111 RVA: 0x00080DB8 File Offset: 0x0007EFB8
		internal GClass77 method_0(GClass209.GClass211 gclass211_0)
		{
			Class589.Class595 @class = new Class589.Class595();
			@class.gclass211_0 = gclass211_0;
			List<GClass184> list_ = new List<GClass184>();
			if (Class551.class753_0.method_42().GetValueOrDefault())
			{
				list_ = this.list_0.Where(new Func<GClass184, bool>(@class.method_0)).ToList<GClass184>();
			}
			else
			{
				list_ = this.list_0.Where(new Func<GClass184, bool>(@class.method_1)).ToList<GClass184>();
			}
			return new GClass77(@class.gclass211_0, list_);
		}

		// Token: 0x0400151D RID: 5405
		public List<GClass184> list_0;
	}

	// Token: 0x020004DC RID: 1244
	[StructLayout(LayoutKind.Auto)]
	private struct Struct326 : IAsyncStateMachine
	{
		// Token: 0x06001FB0 RID: 8112 RVA: 0x00080E34 File Offset: 0x0007F034
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class589.bool_1)
					{
						goto IL_6B;
					}
					awaiter = Class589.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class589.Struct326>(ref awaiter, ref this);
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
				IL_6B:
				IEnumerator<Class493> enumerator = Class589.class520_0.GroupServices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class493 @class = enumerator.Current;
						@class.ServicesViewGroupModels.ForEach(new Action<GClass77>(Class589.Class597.class597_0.method_5));
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
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00014FC0 File Offset: 0x000131C0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400151E RID: 5406
		public int int_0;

		// Token: 0x0400151F RID: 5407
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001520 RID: 5408
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DD RID: 1245
	[StructLayout(LayoutKind.Auto)]
	private struct Struct327 : IAsyncStateMachine
	{
		// Token: 0x06001FB2 RID: 8114 RVA: 0x00080F50 File Offset: 0x0007F150
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
				if (Class589.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class589.Struct327>(ref awaiter, ref this);
					return;
				}
				IL_5E:
				awaiter.GetResult();
				if (this.int_1 <= 500)
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

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00014FCE File Offset: 0x000131CE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001521 RID: 5409
		public int int_0;

		// Token: 0x04001522 RID: 5410
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001523 RID: 5411
		private int int_1;

		// Token: 0x04001524 RID: 5412
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004DE RID: 1246
	public sealed class Class593
	{
		// Token: 0x06001FB5 RID: 8117 RVA: 0x00014FDC File Offset: 0x000131DC
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00014FE4 File Offset: 0x000131E4
		public void method_1(string string_2)
		{
			this.string_0 = string_2;
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00014FED File Offset: 0x000131ED
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x00014FF5 File Offset: 0x000131F5
		public string Desc
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00014FFE File Offset: 0x000131FE
		public List<GClass77> method_2()
		{
			return this.list_0;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00015006 File Offset: 0x00013206
		public void method_3(List<GClass77> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x04001525 RID: 5413
		private string string_0;

		// Token: 0x04001526 RID: 5414
		private string string_1;

		// Token: 0x04001527 RID: 5415
		private List<GClass77> list_0;
	}

	// Token: 0x020004DF RID: 1247
	[StructLayout(LayoutKind.Auto)]
	private struct Struct328 : IAsyncStateMachine
	{
		// Token: 0x06001FBB RID: 8123 RVA: 0x00081030 File Offset: 0x0007F230
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class589.bool_1)
					{
						goto IL_6B;
					}
					awaiter = Class589.smethod_7().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class589.Struct328>(ref awaiter, ref this);
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
				IL_6B:
				IEnumerator<Class493> enumerator = Class589.class520_0.GroupServices.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class493 @class = enumerator.Current;
						@class.ServicesViewGroupModels.ForEach(new Action<GClass77>(Class589.Class597.class597_0.method_4));
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
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x0001500F File Offset: 0x0001320F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001528 RID: 5416
		public int int_0;

		// Token: 0x04001529 RID: 5417
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400152A RID: 5418
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004E0 RID: 1248
	[StructLayout(LayoutKind.Auto)]
	private struct Struct329 : IAsyncStateMachine
	{
		// Token: 0x06001FBD RID: 8125 RVA: 0x0008114C File Offset: 0x0007F34C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class589.Class597.class597_0.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class589.Struct329>(ref awaiter, ref this);
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

		// Token: 0x06001FBE RID: 8126 RVA: 0x0001501D File Offset: 0x0001321D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0400152B RID: 5419
		public int int_0;

		// Token: 0x0400152C RID: 5420
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400152D RID: 5421
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020004E1 RID: 1249
	private sealed class Class594
	{
		// Token: 0x06001FC0 RID: 8128 RVA: 0x00081218 File Offset: 0x0007F418
		internal void method_0()
		{
			Class589.class520_0.GroupServices.Add(new Class493
			{
				HeaderText = this.class593_0.method_0(),
				DescText = this.class593_0.Desc,
				ServicesViewGroupModels = this.class593_0.method_2()
			});
		}

		// Token: 0x0400152E RID: 5422
		public Class589.Class593 class593_0;
	}

	// Token: 0x020004E2 RID: 1250
	private sealed class Class595
	{
		// Token: 0x06001FC2 RID: 8130 RVA: 0x0001502B File Offset: 0x0001322B
		internal bool method_0(GClass184 gclass184_0)
		{
			return this.gclass211_0.Services.Contains(GClass219.smethod_18(gclass184_0.Service.ServiceName)) && !gclass184_0.IsBlocked && gclass184_0.Service.Status == ServiceControllerStatus.Running;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00015067 File Offset: 0x00013267
		internal bool method_1(GClass184 gclass184_0)
		{
			return this.gclass211_0.Services.Contains(GClass219.smethod_18(gclass184_0.Service.ServiceName)) && !gclass184_0.IsBlocked;
		}

		// Token: 0x0400152F RID: 5423
		public GClass209.GClass211 gclass211_0;
	}

	// Token: 0x020004E3 RID: 1251
	private sealed class Class596
	{
		// Token: 0x06001FC5 RID: 8133 RVA: 0x00015096 File Offset: 0x00013296
		internal void method_0(GClass209.GClass211 gclass211_0)
		{
			if (gclass211_0 == this.gclass77_0.ServicesViewGroupName)
			{
				this.gclass77_0.IsDisabled = new bool?(true);
			}
		}

		// Token: 0x04001530 RID: 5424
		public GClass77 gclass77_0;
	}

	// Token: 0x020004E4 RID: 1252
	[Serializable]
	private sealed class Class597
	{
		// Token: 0x06001FC8 RID: 8136 RVA: 0x0008126C File Offset: 0x0007F46C
		internal void method_0()
		{
			Application.Current.Dispatcher.Invoke(new Action(Class589.Class597.class597_0.method_1));
			List<GClass184> list = Class546.smethod_0().method_8();
			using (List<GClass184>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class589.Class590 @class = new Class589.Class590();
					@class.gclass184_0 = enumerator.Current;
					Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				}
			}
			List<Class589.Class593> list2 = new List<Class589.Class593>();
			Class589.Class593 class2 = new Class589.Class593();
			class2.method_1("WinSerGroup1");
			class2.Desc = "WinSerGroup1Desc";
			class2.method_3(Class589.smethod_3(list, GClass60.gclass210_0));
			list2.Add(class2);
			Class589.Class593 class3 = new Class589.Class593();
			class3.method_1("WinSerGroup2");
			class3.Desc = "WinSerGroup2Desc";
			class3.method_3(Class589.smethod_3(list, GClass60.gclass210_1));
			list2.Add(class3);
			using (List<Class589.Class593>.Enumerator enumerator2 = list2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class589.Class594 class4 = new Class589.Class594();
					class4.class593_0 = enumerator2.Current;
					Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
				}
			}
			GClass279.smethod_0().method_10();
			Class589.bool_1 = true;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00014F40 File Offset: 0x00013140
		internal void method_1()
		{
			Class589.class520_0.method_2();
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000813F0 File Offset: 0x0007F5F0
		internal void method_2(GClass77 gclass77_0)
		{
			Class589.Class596 @class = new Class589.Class596();
			@class.gclass77_0 = gclass77_0;
			GClass60.gclass210_2.method_0().ForEach(new Action<GClass209.GClass211>(@class.method_0));
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x000150C3 File Offset: 0x000132C3
		internal void method_3(GClass77 gclass77_0)
		{
			if (gclass77_0.ServicesViewGroupName == GClass260.gclass211_22)
			{
				gclass77_0.IsDisabled = new bool?(true);
			}
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00081428 File Offset: 0x0007F628
		internal void method_4(GClass77 gclass77_0)
		{
			Class589.Class591 @class = new Class589.Class591();
			@class.gclass77_0 = gclass77_0;
			GClass60.gclass210_3.method_0().ForEach(new Action<GClass209.GClass211>(@class.method_0));
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x000150DE File Offset: 0x000132DE
		internal void method_5(GClass77 gclass77_0)
		{
			gclass77_0.IsDisabled = new bool?(false);
		}

		// Token: 0x04001531 RID: 5425
		public static readonly Class589.Class597 class597_0 = new Class589.Class597();

		// Token: 0x04001532 RID: 5426
		public static Action action_0;

		// Token: 0x04001533 RID: 5427
		public static Action action_1;

		// Token: 0x04001534 RID: 5428
		public static Action<GClass77> action_2;

		// Token: 0x04001535 RID: 5429
		public static Action<GClass77> action_3;

		// Token: 0x04001536 RID: 5430
		public static Action<GClass77> action_4;

		// Token: 0x04001537 RID: 5431
		public static Action<GClass77> action_5;
	}
}
