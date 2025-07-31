using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Material.Icons;

// Token: 0x02000596 RID: 1430
public sealed class GClass192 : GClass162
{
	// Token: 0x06002401 RID: 9217 RVA: 0x000179F1 File Offset: 0x00015BF1
	public GClass192()
	{
		GClass192.smethod_0(ref this.string_3, ref this.solidColorBrush_0, ref this.cancellationTokenSource_0);
		base..ctor();
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x0008CD34 File Offset: 0x0008AF34
	public void method_2()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "F0W-[Za-hb", object_);
	}

	// Token: 0x17000602 RID: 1538
	// (get) Token: 0x06002403 RID: 9219 RVA: 0x00017A10 File Offset: 0x00015C10
	// (set) Token: 0x06002404 RID: 9220 RVA: 0x00017A18 File Offset: 0x00015C18
	public string NameRaw
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("NameRaw");
		}
	}

	// Token: 0x17000603 RID: 1539
	// (get) Token: 0x06002405 RID: 9221 RVA: 0x00017A2D File Offset: 0x00015C2D
	public string Name
	{
		get
		{
			return Class298.smethod_2(this.NameRaw);
		}
	}

	// Token: 0x17000604 RID: 1540
	// (get) Token: 0x06002406 RID: 9222 RVA: 0x00017A3A File Offset: 0x00015C3A
	public string Description
	{
		get
		{
			return Class298.smethod_2(this.NameRaw + "Desc");
		}
	}

	// Token: 0x17000605 RID: 1541
	// (get) Token: 0x06002407 RID: 9223 RVA: 0x00017A52 File Offset: 0x00015C52
	// (set) Token: 0x06002408 RID: 9224 RVA: 0x00017A5A File Offset: 0x00015C5A
	public string Group
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = Class298.smethod_2(value);
			base.method_0("Group");
		}
	}

	// Token: 0x17000606 RID: 1542
	// (get) Token: 0x06002409 RID: 9225 RVA: 0x00017A74 File Offset: 0x00015C74
	// (set) Token: 0x0600240A RID: 9226 RVA: 0x00017A7C File Offset: 0x00015C7C
	public string RegistryValue
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("IsEnabled");
			this.method_7();
		}
	}

	// Token: 0x17000607 RID: 1543
	// (get) Token: 0x0600240B RID: 9227 RVA: 0x0008CD64 File Offset: 0x0008AF64
	// (set) Token: 0x0600240C RID: 9228 RVA: 0x0008CD9C File Offset: 0x0008AF9C
	internal bool? Nullable_0
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool?)Class392.smethod_3().method_105(Class392.smethod_1(), "os(p3Za-hh", object_);
		}
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "P-MF%Za-hJ", object_);
		}
	}

	// Token: 0x17000608 RID: 1544
	// (get) Token: 0x0600240D RID: 9229 RVA: 0x00017A97 File Offset: 0x00015C97
	// (set) Token: 0x0600240E RID: 9230 RVA: 0x00017A9F File Offset: 0x00015C9F
	public bool? IsEnabled
	{
		get
		{
			return this.Nullable_0;
		}
		set
		{
			this.Nullable_0 = value;
			base.method_0("IsEnabled");
		}
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x00017AB4 File Offset: 0x00015CB4
	internal bool method_3()
	{
		return this.bool_0;
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x00017ABC File Offset: 0x00015CBC
	internal void method_4(bool bool_1)
	{
		this.bool_0 = bool_1;
		base.method_0("IsPRO");
	}

	// Token: 0x17000609 RID: 1545
	// (get) Token: 0x06002411 RID: 9233 RVA: 0x00017AD1 File Offset: 0x00015CD1
	public Visibility ProVisibility
	{
		get
		{
			if (!this.method_3())
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x1700060A RID: 1546
	// (set) Token: 0x06002412 RID: 9234 RVA: 0x0008CDD4 File Offset: 0x0008AFD4
	public string IconString
	{
		set
		{
			try
			{
				MaterialIconKind icon;
				if (Enum.TryParse<MaterialIconKind>(value, out icon))
				{
					this.Icon = icon;
				}
			}
			catch
			{
				this.Icon = 2002;
			}
		}
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x00017ADE File Offset: 0x00015CDE
	private MaterialIconKind method_5()
	{
		return this.materialIconKind_0;
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x00017AE6 File Offset: 0x00015CE6
	private void method_6(MaterialIconKind materialIconKind_1)
	{
		this.materialIconKind_0 = materialIconKind_1;
	}

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x06002415 RID: 9237 RVA: 0x00017AEF File Offset: 0x00015CEF
	// (set) Token: 0x06002416 RID: 9238 RVA: 0x00017AF7 File Offset: 0x00015CF7
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_5();
		}
		set
		{
			this.method_6(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x0008CE14 File Offset: 0x0008B014
	private void method_7()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "*jN,[Za-hd", object_);
	}

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x06002418 RID: 9240 RVA: 0x00017B0C File Offset: 0x00015D0C
	// (set) Token: 0x06002419 RID: 9241 RVA: 0x00017B14 File Offset: 0x00015D14
	public string StatusText
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x0600241A RID: 9242 RVA: 0x00017B29 File Offset: 0x00015D29
	// (set) Token: 0x0600241B RID: 9243 RVA: 0x00017B31 File Offset: 0x00015D31
	public SolidColorBrush StatusForeground
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusForeground");
		}
	}

	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x0600241C RID: 9244 RVA: 0x00017B46 File Offset: 0x00015D46
	// (set) Token: 0x0600241D RID: 9245 RVA: 0x00017B4E File Offset: 0x00015D4E
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

	// Token: 0x0600241E RID: 9246 RVA: 0x0008CE44 File Offset: 0x0008B044
	public Task method_8(string string_4, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_4,
			solidColorBrush_1
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "Og2=$Za-hM", object_);
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x0008CE80 File Offset: 0x0008B080
	private Task method_9()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "[^!6IZa-hU", object_);
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x0008CEB4 File Offset: 0x0008B0B4
	private static void smethod_0(ref string string_4, ref SolidColorBrush solidColorBrush_1, ref CancellationTokenSource cancellationTokenSource_1)
	{
		object[] array = new object[]
		{
			string_4,
			solidColorBrush_1,
			cancellationTokenSource_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "os(p3Za-hb", array);
		}
		finally
		{
			string_4 = (string)array[0];
			solidColorBrush_1 = (SolidColorBrush)array[1];
			cancellationTokenSource_1 = (CancellationTokenSource)array[2];
		}
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x00017B63 File Offset: 0x00015D63
	private static void smethod_1(ref GClass192.Struct366 struct366_0)
	{
		struct366_0.asyncVoidMethodBuilder_0.Start<GClass192.Struct366>(ref struct366_0);
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x00017B71 File Offset: 0x00015D71
	private static void smethod_2(ref GClass192.Struct367 struct367_0)
	{
		struct367_0.asyncTaskMethodBuilder_0.Start<GClass192.Struct367>(ref struct367_0);
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x00017B7F File Offset: 0x00015D7F
	private static void smethod_3(ref GClass192.Struct365 struct365_0)
	{
		struct365_0.asyncTaskMethodBuilder_0.Start<GClass192.Struct365>(ref struct365_0);
	}

	// Token: 0x040017B7 RID: 6071
	private string string_0;

	// Token: 0x040017B8 RID: 6072
	private string string_1;

	// Token: 0x040017B9 RID: 6073
	private string string_2;

	// Token: 0x040017BA RID: 6074
	private bool bool_0;

	// Token: 0x040017BB RID: 6075
	private MaterialIconKind materialIconKind_0;

	// Token: 0x040017BC RID: 6076
	private string string_3;

	// Token: 0x040017BD RID: 6077
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x040017BE RID: 6078
	private double double_0;

	// Token: 0x040017BF RID: 6079
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x02000597 RID: 1431
	[StructLayout(LayoutKind.Auto)]
	private struct Struct365 : IAsyncStateMachine
	{
		// Token: 0x06002424 RID: 9252 RVA: 0x0008CF48 File Offset: 0x0008B148
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
				@class.method_64(stream_, "N3TdtZa-hV", array);
			}
			finally
			{
				this = (GClass192.Struct365)array[0];
			}
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00017B8D File Offset: 0x00015D8D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00017B9B File Offset: 0x00015D9B
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass192.Struct365 struct365_0)
		{
			struct365_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass192.Struct365>(ref taskAwaiter_1, ref struct365_0);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00017B9B File Offset: 0x00015D9B
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref GClass192.Struct365 struct365_0)
		{
			struct365_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass192.Struct365>(ref taskAwaiter_1, ref struct365_0);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00017B9B File Offset: 0x00015D9B
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_1, ref GClass192.Struct365 struct365_0)
		{
			struct365_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass192.Struct365>(ref taskAwaiter_1, ref struct365_0);
		}

		// Token: 0x040017C0 RID: 6080
		public int int_0;

		// Token: 0x040017C1 RID: 6081
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040017C2 RID: 6082
		public GClass192 gclass192_0;

		// Token: 0x040017C3 RID: 6083
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000598 RID: 1432
	[StructLayout(LayoutKind.Auto)]
	private struct Struct366 : IAsyncStateMachine
	{
		// Token: 0x06002429 RID: 9257 RVA: 0x0008CFB0 File Offset: 0x0008B1B0
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
				@class.method_64(stream_, "0<qplZa-he", array);
			}
			finally
			{
				this = (GClass192.Struct366)array[0];
			}
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00017BAA File Offset: 0x00015DAA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00017BB8 File Offset: 0x00015DB8
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass192.Struct366 struct366_0)
		{
			struct366_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass192.Struct366>(ref taskAwaiter_1, ref struct366_0);
		}

		// Token: 0x040017C4 RID: 6084
		public int int_0;

		// Token: 0x040017C5 RID: 6085
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040017C6 RID: 6086
		public GClass192 gclass192_0;

		// Token: 0x040017C7 RID: 6087
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000599 RID: 1433
	[StructLayout(LayoutKind.Auto)]
	private struct Struct367 : IAsyncStateMachine
	{
		// Token: 0x0600242C RID: 9260 RVA: 0x0008D018 File Offset: 0x0008B218
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
				@class.method_64(stream_, "9X2\"4Za-hN", array);
			}
			finally
			{
				this = (GClass192.Struct367)array[0];
			}
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00017BC7 File Offset: 0x00015DC7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00017BD5 File Offset: 0x00015DD5
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass192.Struct367 struct367_0)
		{
			struct367_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass192.Struct367>(ref taskAwaiter_1, ref struct367_0);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00017BD5 File Offset: 0x00015DD5
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref GClass192.Struct367 struct367_0)
		{
			struct367_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass192.Struct367>(ref taskAwaiter_1, ref struct367_0);
		}

		// Token: 0x040017C8 RID: 6088
		public int int_0;

		// Token: 0x040017C9 RID: 6089
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040017CA RID: 6090
		public GClass192 gclass192_0;

		// Token: 0x040017CB RID: 6091
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040017CC RID: 6092
		public string string_0;

		// Token: 0x040017CD RID: 6093
		private CancellationToken cancellationToken_0;

		// Token: 0x040017CE RID: 6094
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200059A RID: 1434
	[Serializable]
	private sealed class Class694
	{
		// Token: 0x06002432 RID: 9266 RVA: 0x00017BF0 File Offset: 0x00015DF0
		internal Task method_0()
		{
			return Class148.smethod_3();
		}

		// Token: 0x040017CF RID: 6095
		public static readonly GClass192.Class694 class694_0 = new GClass192.Class694();

		// Token: 0x040017D0 RID: 6096
		public static Func<Task> func_0;
	}
}
