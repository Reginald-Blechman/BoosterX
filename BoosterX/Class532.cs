using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;

// Token: 0x020006B2 RID: 1714
internal sealed class Class532 : GClass162
{
	// Token: 0x06002B30 RID: 11056 RVA: 0x0001BEF9 File Offset: 0x0001A0F9
	public Class532(string string_3, Class495 class495_1)
	{
		Class532.smethod_0(ref this.string_1, ref this.solidColorBrush_0);
		base..ctor();
		this.method_16(class495_1, string_3);
	}

	// Token: 0x06002B31 RID: 11057 RVA: 0x000A6854 File Offset: 0x000A4A54
	private void method_2(string string_3)
	{
		object[] object_ = new object[]
		{
			this,
			string_3
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "\"gtbFZa-hY", object_);
	}

	// Token: 0x17000718 RID: 1816
	// (get) Token: 0x06002B32 RID: 11058 RVA: 0x0001BF1A File Offset: 0x0001A11A
	// (set) Token: 0x06002B33 RID: 11059 RVA: 0x0001BF22 File Offset: 0x0001A122
	public string StatusText
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x17000719 RID: 1817
	// (get) Token: 0x06002B34 RID: 11060 RVA: 0x0001BF37 File Offset: 0x0001A137
	// (set) Token: 0x06002B35 RID: 11061 RVA: 0x0001BF3F File Offset: 0x0001A13F
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

	// Token: 0x1700071A RID: 1818
	// (get) Token: 0x06002B36 RID: 11062 RVA: 0x0001BF54 File Offset: 0x0001A154
	// (set) Token: 0x06002B37 RID: 11063 RVA: 0x0001BF5C File Offset: 0x0001A15C
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

	// Token: 0x06002B38 RID: 11064 RVA: 0x000A6888 File Offset: 0x000A4A88
	private void method_3(string string_3, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_3,
			solidColorBrush_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "7('G0Za-h^", object_);
	}

	// Token: 0x1700071B RID: 1819
	// (get) Token: 0x06002B39 RID: 11065 RVA: 0x0001BF71 File Offset: 0x0001A171
	// (set) Token: 0x06002B3A RID: 11066 RVA: 0x0001BF79 File Offset: 0x0001A179
	public string Name
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x1700071C RID: 1820
	// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000A68C0 File Offset: 0x000A4AC0
	public string DateCreated
	{
		get
		{
			return this.class261_0.DateTime_0.ToString("dd.MM.yyyy HH:mm");
		}
	}

	// Token: 0x1700071D RID: 1821
	// (get) Token: 0x06002B3C RID: 11068 RVA: 0x0001BF8E File Offset: 0x0001A18E
	public GClass280 Rename
	{
		get
		{
			return new GClass280(new Action<object>(this.method_5), null);
		}
	}

	// Token: 0x1700071E RID: 1822
	// (get) Token: 0x06002B3D RID: 11069 RVA: 0x0001BFA2 File Offset: 0x0001A1A2
	public GClass280 Delete
	{
		get
		{
			return new GClass280(new Action<object>(this.method_7), null);
		}
	}

	// Token: 0x1700071F RID: 1823
	// (get) Token: 0x06002B3E RID: 11070 RVA: 0x0001BFB6 File Offset: 0x0001A1B6
	public GClass280 Choose
	{
		get
		{
			return new GClass280(new Action<object>(this.method_9), null);
		}
	}

	// Token: 0x17000720 RID: 1824
	// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0001BFCA File Offset: 0x0001A1CA
	public GClass280 OpenLocation
	{
		get
		{
			return new GClass280(new Action<object>(this.method_11), null);
		}
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x000094FC File Offset: 0x000076FC
	internal bool method_4()
	{
		return Class733.smethod_0();
	}

	// Token: 0x17000721 RID: 1825
	// (get) Token: 0x06002B41 RID: 11073 RVA: 0x000A68E8 File Offset: 0x000A4AE8
	public GClass280 UploadToCloud
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (GClass280)Class392.smethod_3().method_105(Class392.smethod_1(), "@C<MMZa-he", object_);
		}
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x000A691C File Offset: 0x000A4B1C
	private void method_5(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "hR0buZa-hf", object_);
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x000A6950 File Offset: 0x000A4B50
	private Task method_6()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "&@JpQZa-hN", object_);
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x000A6984 File Offset: 0x000A4B84
	private void method_7(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "=LGQDZa-hf", object_);
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x000A69B8 File Offset: 0x000A4BB8
	private void method_8()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), ")RZu[Za-h@", object_);
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x000A69E8 File Offset: 0x000A4BE8
	private void method_9(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "_R6eYZa-hg", object_);
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x000A6A1C File Offset: 0x000A4C1C
	private void method_10()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "(:CQWZa-hC", object_);
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x000A6A4C File Offset: 0x000A4C4C
	private void method_11(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "YdLmGZa-hh", object_);
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x000A6A80 File Offset: 0x000A4C80
	private void method_12()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Mm]t\"Za-hD", object_);
	}

	// Token: 0x06002B4A RID: 11082 RVA: 0x000A6AB0 File Offset: 0x000A4CB0
	private void method_13(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "S@,c3Za-hJ", object_);
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x000A6AE4 File Offset: 0x000A4CE4
	private Task method_14()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "6aa>/Za-hS", object_);
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x000A6B18 File Offset: 0x000A4D18
	private Task method_15()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "7('G0Za-h=", object_);
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x000A6B4C File Offset: 0x000A4D4C
	private static void smethod_0(ref string string_3, ref SolidColorBrush solidColorBrush_1)
	{
		object[] array = new object[]
		{
			string_3,
			solidColorBrush_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "iO-)#Za-ho", array);
		}
		finally
		{
			string_3 = (string)array[0];
			solidColorBrush_1 = (SolidColorBrush)array[1];
		}
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x000A6BC4 File Offset: 0x000A4DC4
	private void method_16(Class495 class495_1, string string_3)
	{
		object[] object_ = new object[]
		{
			this,
			class495_1,
			string_3
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "j0c;%Za-hp", object_);
	}

	// Token: 0x06002B4F RID: 11087 RVA: 0x0001BFDE File Offset: 0x0001A1DE
	private static void smethod_1(ref Class532.Struct455 struct455_0)
	{
		struct455_0.asyncVoidMethodBuilder_0.Start<Class532.Struct455>(ref struct455_0);
	}

	// Token: 0x06002B50 RID: 11088 RVA: 0x0001BFEC File Offset: 0x0001A1EC
	private static void smethod_2(ref Class532.Struct454 struct454_0)
	{
		struct454_0.asyncVoidMethodBuilder_0.Start<Class532.Struct454>(ref struct454_0);
	}

	// Token: 0x06002B51 RID: 11089 RVA: 0x0001BFFA File Offset: 0x0001A1FA
	private static void smethod_3(ref Class532.Struct458 struct458_0)
	{
		struct458_0.asyncTaskMethodBuilder_0.Start<Class532.Struct458>(ref struct458_0);
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x0001C008 File Offset: 0x0001A208
	private static void smethod_4(ref Class532.Struct457 struct457_0)
	{
		struct457_0.asyncTaskMethodBuilder_0.Start<Class532.Struct457>(ref struct457_0);
	}

	// Token: 0x06002B53 RID: 11091 RVA: 0x0001C016 File Offset: 0x0001A216
	private static void smethod_5(ref Class532.Struct456 struct456_0)
	{
		struct456_0.asyncTaskMethodBuilder_0.Start<Class532.Struct456>(ref struct456_0);
	}

	// Token: 0x04001C17 RID: 7191
	private Class495 class495_0;

	// Token: 0x04001C18 RID: 7192
	public Class261 class261_0;

	// Token: 0x04001C19 RID: 7193
	public byte[] byte_0;

	// Token: 0x04001C1A RID: 7194
	private string string_0;

	// Token: 0x04001C1B RID: 7195
	private string string_1;

	// Token: 0x04001C1C RID: 7196
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04001C1D RID: 7197
	private double double_0;

	// Token: 0x04001C1E RID: 7198
	private string string_2;

	// Token: 0x04001C1F RID: 7199
	private bool bool_0;

	// Token: 0x020006B3 RID: 1715
	[StructLayout(LayoutKind.Auto)]
	private struct Struct454 : IAsyncStateMachine
	{
		// Token: 0x06002B54 RID: 11092 RVA: 0x000A6BFC File Offset: 0x000A4DFC
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
				@class.method_64(stream_, "OL;L'Za-hK", array);
			}
			finally
			{
				this = (Class532.Struct454)array[0];
			}
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0001C024 File Offset: 0x0001A224
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x0001C032 File Offset: 0x0001A232
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class532.Struct454 struct454_0)
		{
			struct454_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct454>(ref taskAwaiter_1, ref struct454_0);
		}

		// Token: 0x04001C20 RID: 7200
		public int int_0;

		// Token: 0x04001C21 RID: 7201
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C22 RID: 7202
		public Class532 class532_0;

		// Token: 0x04001C23 RID: 7203
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006B4 RID: 1716
	[StructLayout(LayoutKind.Auto)]
	private struct Struct455 : IAsyncStateMachine
	{
		// Token: 0x06002B57 RID: 11095 RVA: 0x000A6C64 File Offset: 0x000A4E64
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
				@class.method_64(stream_, "caC0fZa-h`", array);
			}
			finally
			{
				this = (Class532.Struct455)array[0];
			}
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x0001C041 File Offset: 0x0001A241
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x0001C04F File Offset: 0x0001A24F
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class532.Struct455 struct455_0)
		{
			struct455_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct455>(ref taskAwaiter_1, ref struct455_0);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x0001C04F File Offset: 0x0001A24F
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class532.Struct455 struct455_0)
		{
			struct455_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct455>(ref taskAwaiter_1, ref struct455_0);
		}

		// Token: 0x04001C24 RID: 7204
		public int int_0;

		// Token: 0x04001C25 RID: 7205
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001C26 RID: 7206
		public Class532 class532_0;

		// Token: 0x04001C27 RID: 7207
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001C28 RID: 7208
		public string string_0;

		// Token: 0x04001C29 RID: 7209
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006B5 RID: 1717
	[StructLayout(LayoutKind.Auto)]
	private struct Struct456 : IAsyncStateMachine
	{
		// Token: 0x06002B5B RID: 11099 RVA: 0x000A6CCC File Offset: 0x000A4ECC
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
				@class.method_64(stream_, "A[SqQZa-h>", array);
			}
			finally
			{
				this = (Class532.Struct456)array[0];
			}
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x0001C05E File Offset: 0x0001A25E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x0001C06C File Offset: 0x0001A26C
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class532.Struct456 struct456_0)
		{
			struct456_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct456>(ref taskAwaiter_1, ref struct456_0);
		}

		// Token: 0x04001C2A RID: 7210
		public int int_0;

		// Token: 0x04001C2B RID: 7211
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001C2C RID: 7212
		public Class532 class532_0;

		// Token: 0x04001C2D RID: 7213
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020006B6 RID: 1718
	[StructLayout(LayoutKind.Auto)]
	private struct Struct457 : IAsyncStateMachine
	{
		// Token: 0x06002B5E RID: 11102 RVA: 0x000A6D34 File Offset: 0x000A4F34
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
				@class.method_64(stream_, "(:CQWZa-hV", array);
			}
			finally
			{
				this = (Class532.Struct457)array[0];
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x0001C07B File Offset: 0x0001A27B
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x0001C089 File Offset: 0x0001A289
		private static void MoveNext(ref TaskAwaiter taskAwaiter_2, ref Class532.Struct457 struct457_0)
		{
			struct457_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct457>(ref taskAwaiter_2, ref struct457_0);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0001C098 File Offset: 0x0001A298
		private static void MoveNext_1(ref TaskAwaiter<Class723> taskAwaiter_2, ref Class532.Struct457 struct457_0)
		{
			struct457_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class532.Struct457>(ref taskAwaiter_2, ref struct457_0);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x0001C089 File Offset: 0x0001A289
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_2, ref Class532.Struct457 struct457_0)
		{
			struct457_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct457>(ref taskAwaiter_2, ref struct457_0);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x0001C089 File Offset: 0x0001A289
		private static void MoveNext_3(ref TaskAwaiter taskAwaiter_2, ref Class532.Struct457 struct457_0)
		{
			struct457_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct457>(ref taskAwaiter_2, ref struct457_0);
		}

		// Token: 0x04001C2E RID: 7214
		public int int_0;

		// Token: 0x04001C2F RID: 7215
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001C30 RID: 7216
		public Class532 class532_0;

		// Token: 0x04001C31 RID: 7217
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04001C32 RID: 7218
		private TaskAwaiter<Class723> taskAwaiter_1;
	}

	// Token: 0x020006B7 RID: 1719
	[StructLayout(LayoutKind.Auto)]
	private struct Struct458 : IAsyncStateMachine
	{
		// Token: 0x06002B64 RID: 11108 RVA: 0x000A6D9C File Offset: 0x000A4F9C
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
				@class.method_64(stream_, "\"gtbFZa-hO", array);
			}
			finally
			{
				this = (Class532.Struct458)array[0];
			}
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x0001C0A7 File Offset: 0x0001A2A7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x0001C0B5 File Offset: 0x0001A2B5
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class532.Struct458 struct458_0)
		{
			struct458_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class532.Struct458>(ref taskAwaiter_1, ref struct458_0);
		}

		// Token: 0x04001C33 RID: 7219
		public int int_0;

		// Token: 0x04001C34 RID: 7220
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001C35 RID: 7221
		public Class532 class532_0;

		// Token: 0x04001C36 RID: 7222
		private TaskAwaiter taskAwaiter_0;
	}
}
