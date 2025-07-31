using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using ns0;

// Token: 0x020001AC RID: 428
internal sealed class Class495 : GClass162
{
	// Token: 0x06000C00 RID: 3072 RVA: 0x00009432 File Offset: 0x00007632
	public Class495()
	{
		Class495.smethod_0(ref this.observableCollection_0, ref this.observableCollection_1, ref this.string_0, ref this.solidColorBrush_0);
		base..ctor();
		this.method_19();
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0004B8D0 File Offset: 0x00049AD0
	private void method_2(object sender, NotifyCollectionChangedEventArgs e)
	{
		object[] object_ = new object[]
		{
			this,
			sender,
			e
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "ijH2$Za-iH", object_);
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0004B908 File Offset: 0x00049B08
	public string CloudCount
	{
		get
		{
			return this.CloudProfiles.Count.ToString() + "/10";
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0000945D File Offset: 0x0000765D
	// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00009465 File Offset: 0x00007665
	public Class532 ChoosenForImport
	{
		get
		{
			return this.class532_0;
		}
		set
		{
			this.class532_0 = value;
			base.method_0("ChoosenForImport");
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0000947A File Offset: 0x0000767A
	// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00009482 File Offset: 0x00007682
	public ObservableCollection<Class532> LocalProfiles
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("LocalProfiles");
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00009497 File Offset: 0x00007697
	// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0000949F File Offset: 0x0000769F
	public ObservableCollection<Class535> CloudProfiles
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("CloudCount");
			base.method_0("CloudProfiles");
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000094C0 File Offset: 0x000076C0
	public GClass280 TakeSnapshotCmd
	{
		get
		{
			return new GClass280(new Action<object>(this.method_7), null);
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000094D4 File Offset: 0x000076D4
	public GClass280 ImportFileCmd
	{
		get
		{
			return new GClass280(new Action<object>(this.method_9), null);
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000C0B RID: 3083 RVA: 0x000094E8 File Offset: 0x000076E8
	public GClass280 Update
	{
		get
		{
			return new GClass280(new Action<object>(this.method_11), null);
		}
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x000094FC File Offset: 0x000076FC
	internal bool method_3()
	{
		return Class733.smethod_0();
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0004B934 File Offset: 0x00049B34
	public GClass280 ImportFromKey
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (GClass280)Class392.smethod_3().method_105(Class392.smethod_1(), ">IClGZa-iH", object_);
		}
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x0004B968 File Offset: 0x00049B68
	public void method_4()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "r3`r>Za-iV", object_);
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x0004B998 File Offset: 0x00049B98
	public void method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "279j!Za-iZ", object_);
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00009503 File Offset: 0x00007703
	// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0000950B File Offset: 0x0000770B
	public string StatusText
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00009520 File Offset: 0x00007720
	// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00009528 File Offset: 0x00007728
	public SolidColorBrush StatusColor
	{
		get
		{
			return this.solidColorBrush_0;
		}
		set
		{
			this.solidColorBrush_0 = value;
			base.method_0("StatusColor");
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0000953D File Offset: 0x0000773D
	// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00009545 File Offset: 0x00007745
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

	// Token: 0x06000C16 RID: 3094 RVA: 0x0004B9C8 File Offset: 0x00049BC8
	private void method_6(string string_1, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_1,
			solidColorBrush_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "^9tAUZa-iK", object_);
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x0004BA00 File Offset: 0x00049C00
	private void method_7(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "ZF.*IZa-iR", object_);
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x0004BA34 File Offset: 0x00049C34
	private Task method_8()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "S[Gl4Za-i=", object_);
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x0004BA68 File Offset: 0x00049C68
	private void method_9(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "QaO6.Za-i5", object_);
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x0004BA9C File Offset: 0x00049C9C
	private Task method_10()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "T<kr4Za-jH", object_);
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x0004BAD0 File Offset: 0x00049CD0
	private void method_11(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "*OW;^Za-i5", object_);
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x0004BB04 File Offset: 0x00049D04
	private void method_12()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "ZaI3JZa-i]", object_);
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x0004BB34 File Offset: 0x00049D34
	private void method_13(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "A[SqQZa-i7", object_);
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x0004BB68 File Offset: 0x00049D68
	private void method_14()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "(q$cYZa-ic", object_);
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x0004BB98 File Offset: 0x00049D98
	private void method_15()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "I^QSjZa-iF", object_);
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0004BBC8 File Offset: 0x00049DC8
	private Task method_16()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "MR0^tZa-j1", object_);
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x0004BBFC File Offset: 0x00049DFC
	private void method_17()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), ">.(cFZa-iG", object_);
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x0004BC2C File Offset: 0x00049E2C
	private void method_18(GClass24 gclass24_0)
	{
		object[] object_ = new object[]
		{
			this,
			gclass24_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "GI+]aZa-j5", object_);
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x0004BC60 File Offset: 0x00049E60
	private static void smethod_0(ref ObservableCollection<Class532> observableCollection_2, ref ObservableCollection<Class535> observableCollection_3, ref string string_1, ref SolidColorBrush solidColorBrush_1)
	{
		object[] array = new object[]
		{
			observableCollection_2,
			observableCollection_3,
			string_1,
			solidColorBrush_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "IC6JiZa-hG", array);
		}
		finally
		{
			observableCollection_2 = (ObservableCollection<Class532>)array[0];
			observableCollection_3 = (ObservableCollection<Class535>)array[1];
			string_1 = (string)array[2];
			solidColorBrush_1 = (SolidColorBrush)array[3];
		}
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x0004BD0C File Offset: 0x00049F0C
	private void method_19()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "]sY8TZa-iT", object_);
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0000955A File Offset: 0x0000775A
	private static void smethod_1(ref Class495.Struct90 struct90_0)
	{
		struct90_0.asyncVoidMethodBuilder_0.Start<Class495.Struct90>(ref struct90_0);
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00009568 File Offset: 0x00007768
	private static void smethod_2(ref Class495.Struct91 struct91_0)
	{
		struct91_0.asyncVoidMethodBuilder_0.Start<Class495.Struct91>(ref struct91_0);
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00009576 File Offset: 0x00007776
	private static void smethod_3(ref Class495.Struct92 struct92_0)
	{
		struct92_0.asyncVoidMethodBuilder_0.Start<Class495.Struct92>(ref struct92_0);
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00009584 File Offset: 0x00007784
	private static void smethod_4(ref Class495.Struct93 struct93_0)
	{
		struct93_0.asyncVoidMethodBuilder_0.Start<Class495.Struct93>(ref struct93_0);
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00009592 File Offset: 0x00007792
	private static void smethod_5(ref Class495.Struct96 struct96_0)
	{
		struct96_0.asyncVoidMethodBuilder_0.Start<Class495.Struct96>(ref struct96_0);
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x000095A0 File Offset: 0x000077A0
	private static void smethod_6(ref Class495.Struct95 struct95_0)
	{
		struct95_0.asyncTaskMethodBuilder_0.Start<Class495.Struct95>(ref struct95_0);
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x000095AE File Offset: 0x000077AE
	private static void smethod_7(ref Class495.Struct94 struct94_0)
	{
		struct94_0.asyncTaskMethodBuilder_0.Start<Class495.Struct94>(ref struct94_0);
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x000095BC File Offset: 0x000077BC
	private static void smethod_8(ref Class495.Struct97 struct97_0)
	{
		struct97_0.asyncTaskMethodBuilder_0.Start<Class495.Struct97>(ref struct97_0);
	}

	// Token: 0x040007B5 RID: 1973
	private Class532 class532_0;

	// Token: 0x040007B6 RID: 1974
	private ObservableCollection<Class532> observableCollection_0;

	// Token: 0x040007B7 RID: 1975
	private ObservableCollection<Class535> observableCollection_1;

	// Token: 0x040007B8 RID: 1976
	private bool bool_0;

	// Token: 0x040007B9 RID: 1977
	private string string_0;

	// Token: 0x040007BA RID: 1978
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x040007BB RID: 1979
	private double double_0;

	// Token: 0x020001AD RID: 429
	[StructLayout(LayoutKind.Auto)]
	private struct Struct90 : IAsyncStateMachine
	{
		// Token: 0x06000C2D RID: 3117 RVA: 0x0004BD3C File Offset: 0x00049F3C
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
				@class.method_64(stream_, "RC0H0Za-iW", array);
			}
			finally
			{
				this = (Class495.Struct90)array[0];
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000095CA File Offset: 0x000077CA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000095D8 File Offset: 0x000077D8
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct90 struct90_0)
		{
			struct90_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct90>(ref taskAwaiter_1, ref struct90_0);
		}

		// Token: 0x040007BC RID: 1980
		public int int_0;

		// Token: 0x040007BD RID: 1981
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007BE RID: 1982
		public Class495 class495_0;

		// Token: 0x040007BF RID: 1983
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001AE RID: 430
	[StructLayout(LayoutKind.Auto)]
	private struct Struct91 : IAsyncStateMachine
	{
		// Token: 0x06000C30 RID: 3120 RVA: 0x0004BDA4 File Offset: 0x00049FA4
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
				@class.method_64(stream_, "d^?KiZa-i[", array);
			}
			finally
			{
				this = (Class495.Struct91)array[0];
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000095E7 File Offset: 0x000077E7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000095F5 File Offset: 0x000077F5
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct91 struct91_0)
		{
			struct91_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct91>(ref taskAwaiter_1, ref struct91_0);
		}

		// Token: 0x040007C0 RID: 1984
		public int int_0;

		// Token: 0x040007C1 RID: 1985
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007C2 RID: 1986
		public Class495 class495_0;

		// Token: 0x040007C3 RID: 1987
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001AF RID: 431
	[StructLayout(LayoutKind.Auto)]
	private struct Struct92 : IAsyncStateMachine
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x0004BE0C File Offset: 0x0004A00C
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
				@class.method_64(stream_, "3OQ9%Za-iL", array);
			}
			finally
			{
				this = (Class495.Struct92)array[0];
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00009604 File Offset: 0x00007804
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00009612 File Offset: 0x00007812
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct92 struct92_0)
		{
			struct92_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct92>(ref taskAwaiter_1, ref struct92_0);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00009612 File Offset: 0x00007812
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct92 struct92_0)
		{
			struct92_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct92>(ref taskAwaiter_1, ref struct92_0);
		}

		// Token: 0x040007C4 RID: 1988
		public int int_0;

		// Token: 0x040007C5 RID: 1989
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007C6 RID: 1990
		public Class495 class495_0;

		// Token: 0x040007C7 RID: 1991
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040007C8 RID: 1992
		public string string_0;

		// Token: 0x040007C9 RID: 1993
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001B0 RID: 432
	[StructLayout(LayoutKind.Auto)]
	private struct Struct93 : IAsyncStateMachine
	{
		// Token: 0x06000C37 RID: 3127 RVA: 0x0004BE74 File Offset: 0x0004A074
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
				@class.method_64(stream_, "YI1dFZa-iS", array);
			}
			finally
			{
				this = (Class495.Struct93)array[0];
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00009621 File Offset: 0x00007821
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0000962F File Offset: 0x0000782F
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct93 struct93_0)
		{
			struct93_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct93>(ref taskAwaiter_1, ref struct93_0);
		}

		// Token: 0x040007CA RID: 1994
		public int int_0;

		// Token: 0x040007CB RID: 1995
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007CC RID: 1996
		public Class495 class495_0;

		// Token: 0x040007CD RID: 1997
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001B1 RID: 433
	[StructLayout(LayoutKind.Auto)]
	private struct Struct94 : IAsyncStateMachine
	{
		// Token: 0x06000C3A RID: 3130 RVA: 0x0004BEDC File Offset: 0x0004A0DC
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
				@class.method_64(stream_, "?*grGZa-jI", array);
			}
			finally
			{
				this = (Class495.Struct94)array[0];
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0000963E File Offset: 0x0000783E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0000964C File Offset: 0x0000784C
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct94 struct94_0)
		{
			struct94_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct94>(ref taskAwaiter_1, ref struct94_0);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0000964C File Offset: 0x0000784C
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct94 struct94_0)
		{
			struct94_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct94>(ref taskAwaiter_1, ref struct94_0);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0000964C File Offset: 0x0000784C
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct94 struct94_0)
		{
			struct94_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct94>(ref taskAwaiter_1, ref struct94_0);
		}

		// Token: 0x040007CE RID: 1998
		public int int_0;

		// Token: 0x040007CF RID: 1999
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040007D0 RID: 2000
		public Class495 class495_0;

		// Token: 0x040007D1 RID: 2001
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001B2 RID: 434
	private sealed class Class212
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x0000965B File Offset: 0x0000785B
		internal void method_0()
		{
			this.class495_0.LocalProfiles.Add(this.class532_0);
		}

		// Token: 0x040007D2 RID: 2002
		public Class532 class532_0;

		// Token: 0x040007D3 RID: 2003
		public Class495 class495_0;
	}

	// Token: 0x020001B3 RID: 435
	[StructLayout(LayoutKind.Auto)]
	private struct Struct95 : IAsyncStateMachine
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x0004BF44 File Offset: 0x0004A144
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
				@class.method_64(stream_, "_R$YWZa-jC", array);
			}
			finally
			{
				this = (Class495.Struct95)array[0];
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00009673 File Offset: 0x00007873
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00009681 File Offset: 0x00007881
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct95 struct95_0)
		{
			struct95_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct95>(ref taskAwaiter_1, ref struct95_0);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00009681 File Offset: 0x00007881
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct95 struct95_0)
		{
			struct95_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct95>(ref taskAwaiter_1, ref struct95_0);
		}

		// Token: 0x040007D4 RID: 2004
		public int int_0;

		// Token: 0x040007D5 RID: 2005
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040007D6 RID: 2006
		public Class495 class495_0;

		// Token: 0x040007D7 RID: 2007
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001B4 RID: 436
	[StructLayout(LayoutKind.Auto)]
	private struct Struct96 : IAsyncStateMachine
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x0004BFAC File Offset: 0x0004A1AC
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
				@class.method_64(stream_, "[C*ELZa-i9", array);
			}
			finally
			{
				this = (Class495.Struct96)array[0];
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00009690 File Offset: 0x00007890
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0000969E File Offset: 0x0000789E
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class495.Struct96 struct96_0)
		{
			struct96_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class495.Struct96>(ref taskAwaiter_1, ref struct96_0);
		}

		// Token: 0x040007D8 RID: 2008
		public int int_0;

		// Token: 0x040007D9 RID: 2009
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040007DA RID: 2010
		public Class495 class495_0;

		// Token: 0x040007DB RID: 2011
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001B5 RID: 437
	[StructLayout(LayoutKind.Auto)]
	private struct Struct97 : IAsyncStateMachine
	{
		// Token: 0x06000C48 RID: 3144 RVA: 0x0004C014 File Offset: 0x0004A214
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
				@class.method_64(stream_, "fsA)nZa-j2", array);
			}
			finally
			{
				this = (Class495.Struct97)array[0];
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000096AD File Offset: 0x000078AD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000096BB File Offset: 0x000078BB
		private static void MoveNext(ref TaskAwaiter<Class723> taskAwaiter_1, ref Class495.Struct97 struct97_0)
		{
			struct97_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class495.Struct97>(ref taskAwaiter_1, ref struct97_0);
		}

		// Token: 0x040007DC RID: 2012
		public int int_0;

		// Token: 0x040007DD RID: 2013
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040007DE RID: 2014
		public Class495 class495_0;

		// Token: 0x040007DF RID: 2015
		private TaskAwaiter<Class723> taskAwaiter_0;
	}

	// Token: 0x020001B6 RID: 438
	private sealed class Class213
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x000096CA File Offset: 0x000078CA
		internal void method_0()
		{
			this.class495_0.CloudProfiles.Add(new Class535(this.gclass24_0, this.class495_0));
		}

		// Token: 0x040007E0 RID: 2016
		public GClass24 gclass24_0;

		// Token: 0x040007E1 RID: 2017
		public Class495 class495_0;
	}

	// Token: 0x020001B7 RID: 439
	[Serializable]
	private sealed class Class214
	{
		// Token: 0x06000C4F RID: 3151 RVA: 0x000096F9 File Offset: 0x000078F9
		internal void method_0()
		{
			Class406.smethod_0().method_4(typeof(dje_z9W72JX5NFBD7VDUNQFL98TLYRBMQNF6RK3VAJ8539XLLSXY83S9Z4_ejd), Class406.smethod_0().frame_0);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00009719 File Offset: 0x00007919
		internal DateTime method_1(Class532 class532_0)
		{
			return DateTime.ParseExact(class532_0.DateCreated, "dd.MM.yyyy HH:mm", null);
		}

		// Token: 0x040007E2 RID: 2018
		public static readonly Class495.Class214 class214_0 = new Class495.Class214();

		// Token: 0x040007E3 RID: 2019
		public static Action action_0;

		// Token: 0x040007E4 RID: 2020
		public static Func<Class532, DateTime> func_0;
	}
}
