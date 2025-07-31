using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ns0;

// Token: 0x020002C4 RID: 708
internal sealed class Class335
{
	// Token: 0x060012F6 RID: 4854 RVA: 0x0005FEC0 File Offset: 0x0005E0C0
	public static void smethod_0(Class335.Delegate25 delegate25_1)
	{
		Class335.Delegate25 @delegate = Class335.delegate25_0;
		Class335.Delegate25 delegate2;
		do
		{
			delegate2 = @delegate;
			Class335.Delegate25 value = (Class335.Delegate25)Delegate.Combine(delegate2, delegate25_1);
			@delegate = Interlocked.CompareExchange<Class335.Delegate25>(ref Class335.delegate25_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x0005FEF4 File Offset: 0x0005E0F4
	public static void smethod_1(Class335.Delegate25 delegate25_1)
	{
		Class335.Delegate25 @delegate = Class335.delegate25_0;
		Class335.Delegate25 delegate2;
		do
		{
			delegate2 = @delegate;
			Class335.Delegate25 value = (Class335.Delegate25)Delegate.Remove(delegate2, delegate25_1);
			@delegate = Interlocked.CompareExchange<Class335.Delegate25>(ref Class335.delegate25_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x0005FF28 File Offset: 0x0005E128
	public static Class335.Class506 smethod_2(bool bool_2)
	{
		if (!Class335.bool_0 || bool_2)
		{
			Class335.bool_0 = true;
			Class335.bool_1 = false;
			GClass279.smethod_0().method_17<Class802>();
			Application.Current.Dispatcher.Invoke(new Action(Class335.Class342.class342_0.method_0));
			Class335.smethod_3();
		}
		return Class335.class506_0;
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0005FF90 File Offset: 0x0005E190
	private static void smethod_3()
	{
		Class335.Struct156 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class335.Struct156>(ref @struct);
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x0005FFC0 File Offset: 0x0005E1C0
	public static ObservableCollection<Class513> smethod_4(bool bool_2)
	{
		Class335.Class341 @class = new Class335.Class341();
		@class.bool_0 = bool_2;
		GClass46 gclass = new GClass46();
		@class.list_0 = null;
		@class.list_1 = gclass.method_2<List<Class757>>(Class148.list_0.First(new Func<Class148.Class486, bool>(Class335.Class342.class342_0.method_4)).JsonPath);
		Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
		using (List<Class757>.Enumerator enumerator = @class.list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class335.Class337 class2 = new Class335.Class337();
				class2.class341_0 = @class;
				class2.class757_0 = enumerator.Current;
				Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
			}
		}
		return Class335.class506_0.CleanUpModels;
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x000600B4 File Offset: 0x0005E2B4
	public static Task smethod_5()
	{
		Class335.Struct159 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class335.Struct159>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x000600F0 File Offset: 0x0005E2F0
	public static Task smethod_6()
	{
		Class335.Struct158 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class335.Struct158>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x0006012C File Offset: 0x0005E32C
	internal static Task smethod_7()
	{
		Class335.Struct157 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class335.Struct157>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00060168 File Offset: 0x0005E368
	internal static Task smethod_8()
	{
		Class335.Struct160 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class335.Struct160>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x000601A4 File Offset: 0x0005E3A4
	internal static Task smethod_9()
	{
		Class335.Struct155 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class335.Struct155>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x04000BD5 RID: 3029
	private static Class335.Delegate25 delegate25_0;

	// Token: 0x04000BD6 RID: 3030
	private static bool bool_0 = false;

	// Token: 0x04000BD7 RID: 3031
	private static bool bool_1 = false;

	// Token: 0x04000BD8 RID: 3032
	public static Class335.Class506 class506_0 = new Class335.Class506();

	// Token: 0x020002C5 RID: 709
	private sealed class Class336
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		internal void method_0()
		{
			Class335.class506_0.DisconnectedDevicesModels.Add(new Class528(this.gclass8_0));
		}

		// Token: 0x04000BD9 RID: 3033
		public GClass8 gclass8_0;
	}

	// Token: 0x020002C6 RID: 710
	[StructLayout(LayoutKind.Auto)]
	private struct Struct155 : IAsyncStateMachine
	{
		// Token: 0x06001302 RID: 4866 RVA: 0x000601E0 File Offset: 0x0005E3E0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class335.bool_1)
					{
						Class335.smethod_2(false);
					}
					awaiter = Class335.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class335.Struct155>(ref awaiter, ref this);
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
				IEnumerator<Class513> enumerator = Class335.class506_0.CleanUpModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class513 @class = enumerator.Current;
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
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000BDA RID: 3034
		public int int_0;

		// Token: 0x04000BDB RID: 3035
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000BDC RID: 3036
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002C7 RID: 711
	[StructLayout(LayoutKind.Auto)]
	private struct Struct156 : IAsyncStateMachine
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x000602E0 File Offset: 0x0005E4E0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(Class335.Class342.class342_0.method_1)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class335.Struct156>(ref awaiter, ref this);
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

		// Token: 0x06001305 RID: 4869 RVA: 0x0000D802 File Offset: 0x0000BA02
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000BDD RID: 3037
		public int int_0;

		// Token: 0x04000BDE RID: 3038
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000BDF RID: 3039
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002C8 RID: 712
	private sealed class Class337
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x0000D810 File Offset: 0x0000BA10
		internal void method_0()
		{
			Class335.class506_0.CleanUpModels.Add(new Class513(this.class757_0, this.class341_0.bool_0));
		}

		// Token: 0x04000BE0 RID: 3040
		public Class757 class757_0;

		// Token: 0x04000BE1 RID: 3041
		public Class335.Class341 class341_0;
	}

	// Token: 0x020002C9 RID: 713
	public sealed class Class506 : GClass162
	{
		// Token: 0x06001308 RID: 4872 RVA: 0x000603AC File Offset: 0x0005E5AC
		public Class506()
		{
			this.observableCollection_1.CollectionChanged += this.observableCollection_0_CollectionChanged;
			this.observableCollection_2.CollectionChanged += this.observableCollection_0_CollectionChanged;
			this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0000D837 File Offset: 0x0000BA37
		public void method_2()
		{
			this.DeletedUwpCleanModels.Clear();
			this.CleanUpModels.Clear();
			this.DisconnectedDevicesModels.Clear();
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0000D85A File Offset: 0x0000BA5A
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			base.method_0("DisDevColChanged");
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0000D868 File Offset: 0x0000BA68
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x0000D870 File Offset: 0x0000BA70
		public ObservableCollection<Class513> CleanUpModels
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				this.observableCollection_0 = value;
				base.method_0("CleanUpModels");
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x0000D885 File Offset: 0x0000BA85
		// (set) Token: 0x0600130E RID: 4878 RVA: 0x0000D88D File Offset: 0x0000BA8D
		public ObservableCollection<Class527> DeletedUwpCleanModels
		{
			get
			{
				return this.observableCollection_1;
			}
			set
			{
				this.observableCollection_1 = value;
				base.method_0("DeletedUwpCleanModels");
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x0000D8A2 File Offset: 0x0000BAA2
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x0000D8AA File Offset: 0x0000BAAA
		public ObservableCollection<Class528> DisconnectedDevicesModels
		{
			get
			{
				return this.observableCollection_2;
			}
			set
			{
				this.observableCollection_2 = value;
				base.method_0("DisconnectedDevicesModels");
			}
		}

		// Token: 0x04000BE2 RID: 3042
		private ObservableCollection<Class513> observableCollection_0 = new ObservableCollection<Class513>();

		// Token: 0x04000BE3 RID: 3043
		private ObservableCollection<Class527> observableCollection_1 = new ObservableCollection<Class527>();

		// Token: 0x04000BE4 RID: 3044
		private ObservableCollection<Class528> observableCollection_2 = new ObservableCollection<Class528>();
	}

	// Token: 0x020002CA RID: 714
	[StructLayout(LayoutKind.Auto)]
	private struct Struct157 : IAsyncStateMachine
	{
		// Token: 0x06001311 RID: 4881 RVA: 0x00060428 File Offset: 0x0005E628
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (Class335.bool_1)
					{
						goto IL_72;
					}
					Class335.smethod_2(false);
					awaiter = Class335.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class335.Struct157>(ref awaiter, ref this);
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
				IL_72:
				IEnumerator<Class528> enumerator = Class335.class506_0.DisconnectedDevicesModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class528 @class = enumerator.Current;
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
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0000D8BF File Offset: 0x0000BABF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000BE5 RID: 3045
		public int int_0;

		// Token: 0x04000BE6 RID: 3046
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000BE7 RID: 3047
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002CB RID: 715
	[StructLayout(LayoutKind.Auto)]
	private struct Struct158 : IAsyncStateMachine
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x00060528 File Offset: 0x0005E728
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
				if (Class335.bool_1)
				{
					goto IL_AD;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class335.Struct158>(ref awaiter, ref this);
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

		// Token: 0x06001314 RID: 4884 RVA: 0x0000D8CD File Offset: 0x0000BACD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000BE8 RID: 3048
		public int int_0;

		// Token: 0x04000BE9 RID: 3049
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000BEA RID: 3050
		private int int_1;

		// Token: 0x04000BEB RID: 3051
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002CC RID: 716
	private sealed class Class338
	{
		// Token: 0x06001316 RID: 4886 RVA: 0x0000D8DB File Offset: 0x0000BADB
		internal void method_0()
		{
			Class335.class506_0.DeletedUwpCleanModels.Add(new Class527
			{
				Name = this.string_0
			});
		}

		// Token: 0x04000BEC RID: 3052
		public string string_0;
	}

	// Token: 0x020002CD RID: 717
	private sealed class Class339
	{
		// Token: 0x06001318 RID: 4888 RVA: 0x0000D8FD File Offset: 0x0000BAFD
		internal void method_0(string string_1)
		{
			if (this.string_0 == string_1)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x04000BED RID: 3053
		public string string_0;

		// Token: 0x04000BEE RID: 3054
		public bool bool_0;
	}

	// Token: 0x020002CE RID: 718
	private sealed class Class340
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00060608 File Offset: 0x0005E808
		internal void method_0(string string_0)
		{
			Class335.Class339 @class = new Class335.Class339();
			@class.string_0 = string_0.Split(new char[]
			{
				'\\'
			}).Last<string>();
			@class.bool_0 = false;
			Class725.list_9.ForEach(new Action<string>(@class.method_0));
			if (!@class.bool_0)
			{
				this.list_0.Add(@class.string_0);
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00060670 File Offset: 0x0005E870
		internal void method_1(string string_0)
		{
			string item = string_0.Split(new char[]
			{
				'_'
			})[0] + "_" + string_0.Split(new char[]
			{
				'_'
			})[1];
			if (!this.list_1.Contains(item))
			{
				this.list_1.Add(item);
			}
		}

		// Token: 0x04000BEF RID: 3055
		public List<string> list_0;

		// Token: 0x04000BF0 RID: 3056
		public List<string> list_1;
	}

	// Token: 0x020002CF RID: 719
	// (Invoke) Token: 0x0600131D RID: 4893
	public delegate void Delegate25();

	// Token: 0x020002D0 RID: 720
	private sealed class Class341
	{
		// Token: 0x06001321 RID: 4897 RVA: 0x0000D914 File Offset: 0x0000BB14
		internal void method_0()
		{
			this.list_0 = new List<Class757>();
			this.list_0.AddRange(this.list_1);
		}

		// Token: 0x04000BF1 RID: 3057
		public List<Class757> list_0;

		// Token: 0x04000BF2 RID: 3058
		public List<Class757> list_1;

		// Token: 0x04000BF3 RID: 3059
		public bool bool_0;
	}

	// Token: 0x020002D1 RID: 721
	[StructLayout(LayoutKind.Auto)]
	private struct Struct159 : IAsyncStateMachine
	{
		// Token: 0x06001322 RID: 4898 RVA: 0x000606CC File Offset: 0x0005E8CC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class335.bool_1)
					{
						Class335.smethod_2(false);
					}
					awaiter = Class335.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class335.Struct159>(ref awaiter, ref this);
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
				IEnumerator<Class513> enumerator = Class335.class506_0.CleanUpModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class513 @class = enumerator.Current;
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
				IEnumerator<Class527> enumerator2 = Class335.class506_0.DeletedUwpCleanModels.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Class527 class2 = enumerator2.Current;
						class2.ToDelete = true;
					}
				}
				finally
				{
					if (num < 0 && enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				IEnumerator<Class528> enumerator3 = Class335.class506_0.DisconnectedDevicesModels.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						Class528 class3 = enumerator3.Current;
						class3.ToDelete = true;
					}
				}
				finally
				{
					if (num < 0 && enumerator3 != null)
					{
						enumerator3.Dispose();
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

		// Token: 0x06001323 RID: 4899 RVA: 0x0000D932 File Offset: 0x0000BB32
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000BF4 RID: 3060
		public int int_0;

		// Token: 0x04000BF5 RID: 3061
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000BF6 RID: 3062
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002D2 RID: 722
	[StructLayout(LayoutKind.Auto)]
	private struct Struct160 : IAsyncStateMachine
	{
		// Token: 0x06001324 RID: 4900 RVA: 0x00060888 File Offset: 0x0005EA88
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (!Class335.bool_1)
					{
						Class335.smethod_2(false);
					}
					awaiter = Class335.smethod_6().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						num = 0;
						this.int_0 = num2;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class335.Struct160>(ref awaiter, ref this);
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
				IEnumerator<Class527> enumerator = Class335.class506_0.DeletedUwpCleanModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class527 @class = enumerator.Current;
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
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0000D940 File Offset: 0x0000BB40
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000BF7 RID: 3063
		public int int_0;

		// Token: 0x04000BF8 RID: 3064
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000BF9 RID: 3065
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002D3 RID: 723
	[Serializable]
	private sealed class Class342
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x0000D95A File Offset: 0x0000BB5A
		internal void method_0()
		{
			Class335.class506_0.method_2();
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00060988 File Offset: 0x0005EB88
		internal void method_1()
		{
			Class335.smethod_4(true);
			try
			{
				Class304.smethod_1().ForEach(new Action<GClass8>(Class335.Class342.class342_0.method_2));
			}
			catch
			{
			}
			try
			{
				Class335.Class340 @class = new Class335.Class340();
				Class620.smethod_0().method_0();
				List<string> list = Directory.GetDirectories("C:\\Program Files\\WindowsApps").ToList<string>();
				@class.list_0 = new List<string>();
				list.ForEach(new Action<string>(@class.method_0));
				@class.list_1 = new List<string>();
				@class.list_0.ForEach(new Action<string>(@class.method_1));
				@class.list_1.ForEach(new Action<string>(Class335.Class342.class342_0.method_3));
			}
			catch
			{
			}
			Class335.Delegate25 delegate25_ = Class335.delegate25_0;
			if (delegate25_ != null)
			{
				delegate25_();
			}
			Class335.bool_1 = true;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00060A8C File Offset: 0x0005EC8C
		internal void method_2(GClass8 gclass8_0)
		{
			Class335.Class336 @class = new Class335.Class336();
			@class.gclass8_0 = gclass8_0;
			try
			{
				if (!@class.gclass8_0.Name.StartsWith("WAN Miniport"))
				{
					Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00060AF0 File Offset: 0x0005ECF0
		internal void method_3(string string_0)
		{
			Class335.Class338 @class = new Class335.Class338();
			@class.string_0 = string_0;
			if (!Class620.smethod_0().method_2(@class.string_0))
			{
				Application.Current.Dispatcher.Invoke(new Action(@class.method_0));
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0000D966 File Offset: 0x0000BB66
		internal bool method_4(Class148.Class486 class486_0)
		{
			return class486_0.Type == typeof(dje_zY8TJ7HVSSL9J9VQH6V7EV8TJKMJV32VYYNUD95ZXTD6G6DK4JKGTBNA9KKRA_ejd);
		}

		// Token: 0x04000BFA RID: 3066
		public static readonly Class335.Class342 class342_0 = new Class335.Class342();

		// Token: 0x04000BFB RID: 3067
		public static Action action_0;

		// Token: 0x04000BFC RID: 3068
		public static Action<GClass8> action_1;

		// Token: 0x04000BFD RID: 3069
		public static Action<string> action_2;

		// Token: 0x04000BFE RID: 3070
		public static Action action_3;

		// Token: 0x04000BFF RID: 3071
		public static Func<Class148.Class486, bool> func_0;
	}
}
