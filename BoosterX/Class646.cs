using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using ns0;

// Token: 0x02000549 RID: 1353
internal sealed class Class646
{
	// Token: 0x06002221 RID: 8737 RVA: 0x000165D1 File Offset: 0x000147D1
	// Note: this type is marked as 'beforefieldinit'.
	static Class646()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "7_Z:;Za-k+", null);
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000889B8 File Offset: 0x00086BB8
	public static void smethod_0(Class490 class490_0)
	{
		object[] object_ = new object[]
		{
			class490_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "(V[;aZa-k2", object_);
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000889E8 File Offset: 0x00086BE8
	public static Class646.Class652 smethod_1(bool bool_2)
	{
		object[] object_ = new object[]
		{
			bool_2
		};
		return (Class646.Class652)Class392.smethod_3().method_105(Class392.smethod_1(), "_S3FbZa-k3", object_);
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x000165E8 File Offset: 0x000147E8
	private static void smethod_2()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "!ku(LZa-k-", null);
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x000165FF File Offset: 0x000147FF
	public static Task smethod_3()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "`4iXdZa-k5", null);
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x0001661B File Offset: 0x0001481B
	internal static Task smethod_4()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), ";80HFZa-jo", null);
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x00016637 File Offset: 0x00014837
	public static Task smethod_5()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "DSENcZa-k\"", null);
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x00016653 File Offset: 0x00014853
	public static Task smethod_6()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "qnBJFZa-k'", null);
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x0001666F File Offset: 0x0001486F
	public static Task<List<Class265>> smethod_7()
	{
		return (Task<List<Class265>>)Class392.smethod_3().method_105(Class392.smethod_1(), "+hk@kZa-j`", null);
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x0001668B File Offset: 0x0001488B
	private static void smethod_8(ref Class646.Struct356 struct356_0)
	{
		struct356_0.asyncVoidMethodBuilder_0.Start<Class646.Struct356>(ref struct356_0);
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x00016699 File Offset: 0x00014899
	private static void smethod_9(ref Class646.Struct358 struct358_0)
	{
		struct358_0.asyncTaskMethodBuilder_0.Start<Class646.Struct358>(ref struct358_0);
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000166A7 File Offset: 0x000148A7
	private static void smethod_10(ref Class646.Struct354 struct354_0)
	{
		struct354_0.asyncTaskMethodBuilder_0.Start<Class646.Struct354>(ref struct354_0);
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x000166B5 File Offset: 0x000148B5
	private static void smethod_11(ref Class646.Struct355 struct355_0)
	{
		struct355_0.asyncTaskMethodBuilder_0.Start<Class646.Struct355>(ref struct355_0);
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000166C3 File Offset: 0x000148C3
	private static void smethod_12(ref Class646.Struct353 struct353_0)
	{
		struct353_0.asyncTaskMethodBuilder_0.Start<Class646.Struct353>(ref struct353_0);
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000166D1 File Offset: 0x000148D1
	private static void smethod_13(ref Class646.Struct357 struct357_0)
	{
		struct357_0.asyncTaskMethodBuilder_0.Start<Class646.Struct357>(ref struct357_0);
	}

	// Token: 0x040016BA RID: 5818
	private static Class646.Class652 class652_0;

	// Token: 0x040016BB RID: 5819
	private static bool bool_0;

	// Token: 0x040016BC RID: 5820
	private static bool bool_1;

	// Token: 0x0200054A RID: 1354
	private sealed class Class647
	{
		// Token: 0x040016BD RID: 5821
		public RegistryKey registryKey_0;
	}

	// Token: 0x0200054B RID: 1355
	[StructLayout(LayoutKind.Auto)]
	private struct Struct353 : IAsyncStateMachine
	{
		// Token: 0x06002231 RID: 8753 RVA: 0x00088A20 File Offset: 0x00086C20
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
				@class.method_64(stream_, "X1l!KZa-k(", array);
			}
			finally
			{
				this = (Class646.Struct353)array[0];
			}
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x000166DF File Offset: 0x000148DF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000166ED File Offset: 0x000148ED
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class646.Struct353 struct353_0)
		{
			struct353_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class646.Struct353>(ref taskAwaiter_1, ref struct353_0);
		}

		// Token: 0x040016BE RID: 5822
		public int int_0;

		// Token: 0x040016BF RID: 5823
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040016C0 RID: 5824
		private int int_1;

		// Token: 0x040016C1 RID: 5825
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200054C RID: 1356
	private sealed class Class648
	{
		// Token: 0x06002235 RID: 8757 RVA: 0x00088A88 File Offset: 0x00086C88
		internal void method_0()
		{
			Class646.class652_0.ServiceARModels.Add(new Class490
			{
				IconSource = this.string_0,
				Type = dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Service,
				Name = this.class650_0.string_0.ToString(),
				Runs = this.string_0,
				Description = this.string_1,
				ARPath = this.registryKey_0.ToString(),
				NewStatus = this.nullable_0
			});
		}

		// Token: 0x040016C2 RID: 5826
		public string string_0;

		// Token: 0x040016C3 RID: 5827
		public string string_1;

		// Token: 0x040016C4 RID: 5828
		public RegistryKey registryKey_0;

		// Token: 0x040016C5 RID: 5829
		public bool? nullable_0;

		// Token: 0x040016C6 RID: 5830
		public Class646.Class650 class650_0;
	}

	// Token: 0x0200054D RID: 1357
	private sealed class Class649
	{
		// Token: 0x06002237 RID: 8759 RVA: 0x00088B08 File Offset: 0x00086D08
		internal void method_0()
		{
			Class646.class652_0.TaskARModels.Add(new Class490
			{
				IconSource = this.class663_0.Command,
				Type = dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Task,
				Name = this.class663_0.Name,
				Runs = this.class663_0.Command,
				Description = this.class663_0.Description,
				ARPath = this.class663_0.Path,
				NewStatus = new bool?(!this.class663_0.IsEnabled)
			});
		}

		// Token: 0x040016C7 RID: 5831
		public Class662.Class663 class663_0;
	}

	// Token: 0x0200054E RID: 1358
	[StructLayout(LayoutKind.Auto)]
	private struct Struct354 : IAsyncStateMachine
	{
		// Token: 0x06002238 RID: 8760 RVA: 0x00088BA0 File Offset: 0x00086DA0
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
				@class.method_64(stream_, "dD!#qZa-js", array);
			}
			finally
			{
				this = (Class646.Struct354)array[0];
			}
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x000166FC File Offset: 0x000148FC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0001670A File Offset: 0x0001490A
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class646.Struct354 struct354_0)
		{
			struct354_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class646.Struct354>(ref taskAwaiter_1, ref struct354_0);
		}

		// Token: 0x040016C8 RID: 5832
		public int int_0;

		// Token: 0x040016C9 RID: 5833
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040016CA RID: 5834
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200054F RID: 1359
	private sealed class Class650
	{
		// Token: 0x0600223C RID: 8764 RVA: 0x00016719 File Offset: 0x00014919
		internal bool method_0(string string_1)
		{
			return string_1.Contains(this.string_0);
		}

		// Token: 0x040016CB RID: 5835
		public string string_0;
	}

	// Token: 0x02000550 RID: 1360
	private sealed class Class651
	{
		// Token: 0x0600223E RID: 8766 RVA: 0x00016727 File Offset: 0x00014927
		internal void method_0(string string_0)
		{
			if (this.class655_0.class490_0.Name.ToLower().Contains(string_0))
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x040016CC RID: 5836
		public bool bool_0;

		// Token: 0x040016CD RID: 5837
		public Class646.Class655 class655_0;
	}

	// Token: 0x02000551 RID: 1361
	[StructLayout(LayoutKind.Auto)]
	private struct Struct355 : IAsyncStateMachine
	{
		// Token: 0x0600223F RID: 8767 RVA: 0x00088C08 File Offset: 0x00086E08
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
				@class.method_64(stream_, "-,-doZa-k#", array);
			}
			finally
			{
				this = (Class646.Struct355)array[0];
			}
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0001674D File Offset: 0x0001494D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0001675B File Offset: 0x0001495B
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class646.Struct355 struct355_0)
		{
			struct355_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class646.Struct355>(ref taskAwaiter_1, ref struct355_0);
		}

		// Token: 0x040016CE RID: 5838
		public int int_0;

		// Token: 0x040016CF RID: 5839
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040016D0 RID: 5840
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000552 RID: 1362
	[StructLayout(LayoutKind.Auto)]
	private struct Struct356 : IAsyncStateMachine
	{
		// Token: 0x06002242 RID: 8770 RVA: 0x00088C70 File Offset: 0x00086E70
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
				@class.method_64(stream_, "M8$C)Za-k/", array);
			}
			finally
			{
				this = (Class646.Struct356)array[0];
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0001676A File Offset: 0x0001496A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00016778 File Offset: 0x00014978
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class646.Struct356 struct356_0)
		{
			struct356_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class646.Struct356>(ref taskAwaiter_1, ref struct356_0);
		}

		// Token: 0x040016D1 RID: 5841
		public int int_0;

		// Token: 0x040016D2 RID: 5842
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040016D3 RID: 5843
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000553 RID: 1363
	public sealed class Class652
	{
		// Token: 0x06002246 RID: 8774 RVA: 0x00088CD8 File Offset: 0x00086ED8
		public ObservableCollection<Class490> method_0()
		{
			ObservableCollection<Class490> observableCollection = new ObservableCollection<Class490>();
			foreach (Class490 item in this.FileARModels)
			{
				observableCollection.Add(item);
			}
			foreach (Class490 item2 in this.TaskARModels)
			{
				observableCollection.Add(item2);
			}
			foreach (Class490 item3 in this.RegARModels)
			{
				observableCollection.Add(item3);
			}
			foreach (Class490 item4 in this.ServiceARModels)
			{
				observableCollection.Add(item4);
			}
			return observableCollection;
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x000167BB File Offset: 0x000149BB
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x000167C3 File Offset: 0x000149C3
		public ObservableCollection<Class490> FileARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_0 = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x000167CC File Offset: 0x000149CC
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x000167D4 File Offset: 0x000149D4
		public ObservableCollection<Class490> RegARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_1;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_1 = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x000167DD File Offset: 0x000149DD
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x000167E5 File Offset: 0x000149E5
		public ObservableCollection<Class490> TaskARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_2;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_2 = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000167EE File Offset: 0x000149EE
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x000167F6 File Offset: 0x000149F6
		public ObservableCollection<Class490> ServiceARModels
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_3;
			}
			[CompilerGenerated]
			set
			{
				this.observableCollection_3 = value;
			}
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x000167FF File Offset: 0x000149FF
		public void method_1()
		{
			this.FileARModels.Clear();
			this.RegARModels.Clear();
			this.TaskARModels.Clear();
			this.ServiceARModels.Clear();
		}

		// Token: 0x040016D4 RID: 5844
		private ObservableCollection<Class490> observableCollection_0 = new ObservableCollection<Class490>();

		// Token: 0x040016D5 RID: 5845
		private ObservableCollection<Class490> observableCollection_1 = new ObservableCollection<Class490>();

		// Token: 0x040016D6 RID: 5846
		private ObservableCollection<Class490> observableCollection_2 = new ObservableCollection<Class490>();

		// Token: 0x040016D7 RID: 5847
		private ObservableCollection<Class490> observableCollection_3 = new ObservableCollection<Class490>();
	}

	// Token: 0x02000554 RID: 1364
	[StructLayout(LayoutKind.Auto)]
	private struct Struct357 : IAsyncStateMachine
	{
		// Token: 0x06002250 RID: 8784 RVA: 0x00088DE8 File Offset: 0x00086FE8
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
				@class.method_64(stream_, "+25.iZa-ja", array);
			}
			finally
			{
				this = (Class646.Struct357)array[0];
			}
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x0001682D File Offset: 0x00014A2D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0001683B File Offset: 0x00014A3B
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class646.Struct357 struct357_0)
		{
			struct357_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class646.Struct357>(ref taskAwaiter_1, ref struct357_0);
		}

		// Token: 0x040016D8 RID: 5848
		public int int_0;

		// Token: 0x040016D9 RID: 5849
		public AsyncTaskMethodBuilder<List<Class265>> asyncTaskMethodBuilder_0;

		// Token: 0x040016DA RID: 5850
		private List<Class265> list_0;

		// Token: 0x040016DB RID: 5851
		private Class646.Class652 class652_0;

		// Token: 0x040016DC RID: 5852
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000555 RID: 1365
	private sealed class Class653
	{
		// Token: 0x06002254 RID: 8788 RVA: 0x00088E50 File Offset: 0x00087050
		internal void method_0()
		{
			Class646.class652_0.RegARModels.Add(new Class490
			{
				IconSource = this.string_1,
				Type = dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Registry,
				Name = this.string_0.ToString(),
				Runs = this.string_1,
				Description = this.string_0.ToString(),
				ARPath = this.class647_0.registryKey_0.ToString(),
				NewStatus = new bool?(this.class647_0.registryKey_0.ToString().EndsWith("AutorunsDisabled"))
			});
		}

		// Token: 0x040016DD RID: 5853
		public string string_0;

		// Token: 0x040016DE RID: 5854
		public string string_1;

		// Token: 0x040016DF RID: 5855
		public Class646.Class647 class647_0;
	}

	// Token: 0x02000556 RID: 1366
	private sealed class Class654
	{
		// Token: 0x06002256 RID: 8790 RVA: 0x00088EF0 File Offset: 0x000870F0
		internal void method_0()
		{
			Class646.class652_0.FileARModels.Add(new Class490
			{
				IconSource = this.string_0,
				Type = dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.File,
				Name = this.fileInfo_0.Name,
				Runs = this.string_0,
				Description = this.fileInfo_0.FullName,
				ARPath = this.string_1,
				NewStatus = new bool?(this.string_1.EndsWith("AutorunsDisabled"))
			});
		}

		// Token: 0x040016E0 RID: 5856
		public string string_0;

		// Token: 0x040016E1 RID: 5857
		public FileInfo fileInfo_0;

		// Token: 0x040016E2 RID: 5858
		public string string_1;
	}

	// Token: 0x02000557 RID: 1367
	[StructLayout(LayoutKind.Auto)]
	private struct Struct358 : IAsyncStateMachine
	{
		// Token: 0x06002257 RID: 8791 RVA: 0x00088F7C File Offset: 0x0008717C
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
				@class.method_64(stream_, "VnTRGZa-k7", array);
			}
			finally
			{
				this = (Class646.Struct358)array[0];
			}
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0001684A File Offset: 0x00014A4A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00016858 File Offset: 0x00014A58
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class646.Struct358 struct358_0)
		{
			struct358_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class646.Struct358>(ref taskAwaiter_1, ref struct358_0);
		}

		// Token: 0x040016E3 RID: 5859
		public int int_0;

		// Token: 0x040016E4 RID: 5860
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040016E5 RID: 5861
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000558 RID: 1368
	private sealed class Class655
	{
		// Token: 0x0600225B RID: 8795 RVA: 0x00016867 File Offset: 0x00014A67
		internal void method_0(string string_0)
		{
			if (this.class490_0.Name.ToLower().Contains(string_0))
			{
				this.class490_0.NewStatus = new bool?(true);
			}
		}

		// Token: 0x040016E6 RID: 5862
		public Class490 class490_0;
	}

	// Token: 0x02000559 RID: 1369
	[Serializable]
	private sealed class Class656
	{
		// Token: 0x0600225E RID: 8798 RVA: 0x00088FE4 File Offset: 0x000871E4
		internal void method_0()
		{
			Application.Current.Dispatcher.Invoke(new Action(Class646.Class656.class656_0.method_1));
			string[] array;
			using (List<RegistryKey>.Enumerator enumerator = Class169.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class646.Class647 @class = new Class646.Class647();
					@class.registryKey_0 = enumerator.Current;
					try
					{
						array = @class.registryKey_0.GetValueNames();
						for (int i = 0; i < array.Length; i++)
						{
							Class646.Class653 class2 = new Class646.Class653();
							class2.class647_0 = @class;
							class2.string_0 = array[i];
							if (!class2.string_0.smethod_9())
							{
								class2.string_1 = class2.class647_0.registryKey_0.GetValue(class2.string_0).ToString();
								Application.Current.Dispatcher.Invoke(new Action(class2.method_0));
							}
						}
					}
					catch
					{
					}
				}
			}
			foreach (string path in Class169.list_1)
			{
				if (Directory.Exists(path))
				{
					foreach (string text in Directory.GetFiles(path))
					{
						if (!text.Contains("desktop.ini"))
						{
							try
							{
								Class646.Class654 class3 = new Class646.Class654();
								class3.fileInfo_0 = new FileInfo(text);
								class3.string_1 = Path.GetFullPath(path);
								if (!class3.fileInfo_0.Name.smethod_9())
								{
									class3.string_0 = Class765.smethod_9(text);
									Application.Current.Dispatcher.Invoke(new Action(class3.method_0));
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			using (List<Class662.Class663>.Enumerator enumerator3 = Class662.smethod_2().GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					Class646.Class649 class4 = new Class646.Class649();
					class4.class663_0 = enumerator3.Current;
					try
					{
						if (!class4.class663_0.Path.StartsWith("\\Microsoft\\Windows") && !class4.class663_0.Path.StartsWith("Microsoft\\Windows") && !class4.class663_0.Name.smethod_9())
						{
							Application.Current.Dispatcher.Invoke(new Action(class4.method_0));
						}
					}
					catch
					{
					}
				}
			}
			array = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services").GetSubKeyNames();
			for (int i = 0; i < array.Length; i++)
			{
				Class646.Class650 class5 = new Class646.Class650();
				class5.string_0 = array[i];
				try
				{
					Class646.Class648 class6 = new Class646.Class648();
					class6.class650_0 = class5;
					if (!class6.class650_0.string_0.smethod_9())
					{
						class6.registryKey_0 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + class6.class650_0.string_0);
						if (!Class725.list_4.Any(new Func<string, bool>(class6.class650_0.method_0)))
						{
							if (class6.registryKey_0.GetValueNames().Any(new Func<string, bool>(Class646.Class656.class656_0.method_2)))
							{
								if (!class6.registryKey_0.GetValue("ImagePath").ToString().ToLower().Contains("system32") && !class6.registryKey_0.GetValue("ImagePath").ToString().ToLower().Contains("c:\\windows"))
								{
									class6.nullable_0 = null;
									if (class6.registryKey_0.GetValue("Start").ToString() == "4")
									{
										class6.nullable_0 = new bool?(true);
									}
									else
									{
										class6.nullable_0 = new bool?(false);
									}
									Class646.Class648 class7 = class6;
									object value = class6.registryKey_0.GetValue("ImagePath");
									class7.string_0 = ((value != null) ? value.ToString() : null);
									Class646.Class648 class8 = class6;
									object value2 = class6.registryKey_0.GetValue("Description");
									class8.string_1 = ((value2 != null) ? value2.ToString() : null);
									Application.Current.Dispatcher.Invoke(new Action(class6.method_0));
								}
							}
						}
					}
				}
				catch
				{
				}
			}
			Class646.bool_1 = true;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0001689E File Offset: 0x00014A9E
		internal void method_1()
		{
			Class646.class652_0.method_1();
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x000168AA File Offset: 0x00014AAA
		internal bool method_2(string string_0)
		{
			return string_0.ToString() == "ImagePath";
		}

		// Token: 0x040016E7 RID: 5863
		public static readonly Class646.Class656 class656_0 = new Class646.Class656();

		// Token: 0x040016E8 RID: 5864
		public static Action action_0;

		// Token: 0x040016E9 RID: 5865
		public static Func<string, bool> func_0;

		// Token: 0x040016EA RID: 5866
		public static Action action_1;
	}
}
