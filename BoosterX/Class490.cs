using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ns0;

// Token: 0x0200012B RID: 299
internal sealed class Class490 : GClass162
{
	// Token: 0x060008A5 RID: 2213 RVA: 0x00007584 File Offset: 0x00005784
	public Class490()
	{
		Class490.smethod_1(ref this.string_4, ref this.solidColorBrush_0, ref this.cancellationTokenSource_0);
		base..ctor();
		this.method_18();
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x000075A9 File Offset: 0x000057A9
	private Class804 method_2()
	{
		return this.class804_0;
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x000075B1 File Offset: 0x000057B1
	private void method_3(Class804 class804_1)
	{
		this.class804_0 = class804_1;
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000075BA File Offset: 0x000057BA
	// (set) Token: 0x060008A9 RID: 2217 RVA: 0x000075C2 File Offset: 0x000057C2
	public dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd Type
	{
		[CompilerGenerated]
		get
		{
			return this.dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd_0;
		}
		[CompilerGenerated]
		set
		{
			this.dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd_0 = value;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060008AA RID: 2218 RVA: 0x000075CB File Offset: 0x000057CB
	public string NameClean
	{
		get
		{
			return this.Name.smethod_7();
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060008AB RID: 2219 RVA: 0x000075D8 File Offset: 0x000057D8
	// (set) Token: 0x060008AC RID: 2220 RVA: 0x000075E0 File Offset: 0x000057E0
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x060008AD RID: 2221 RVA: 0x000075E9 File Offset: 0x000057E9
	// (set) Token: 0x060008AE RID: 2222 RVA: 0x000075F1 File Offset: 0x000057F1
	public string ARPath
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

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x060008AF RID: 2223 RVA: 0x000075FA File Offset: 0x000057FA
	// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00007602 File Offset: 0x00005802
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0000760B File Offset: 0x0000580B
	// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00007613 File Offset: 0x00005813
	public string Runs
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
		[CompilerGenerated]
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0000761C File Offset: 0x0000581C
	public BitmapSource Icon
	{
		get
		{
			return this.bitmapSource_0;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00007624 File Offset: 0x00005824
	public string IconSource
	{
		set
		{
			if (this.bitmapSource_0 == null)
			{
				this.method_4(value);
			}
		}
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00042FE0 File Offset: 0x000411E0
	private void method_4(string string_5)
	{
		object[] object_ = new object[]
		{
			this,
			string_5
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "\\$rcPZa-j)", object_);
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00007635 File Offset: 0x00005835
	// (set) Token: 0x060008B7 RID: 2231 RVA: 0x0000763D File Offset: 0x0000583D
	public bool? Status
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00007646 File Offset: 0x00005846
	// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00043014 File Offset: 0x00041214
	public bool? NewStatus
	{
		get
		{
			return this.nullable_1;
		}
		set
		{
			if (this.Status == null)
			{
				this.Status = value;
			}
			this.nullable_1 = value;
			if (this.nullable_1 != null)
			{
				this.ToDelete = false;
			}
			base.method_0("NewStatus");
			base.method_0("HasChanges");
			base.method_0("Status");
			this.method_5();
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060008BA RID: 2234 RVA: 0x0000764E File Offset: 0x0000584E
	// (set) Token: 0x060008BB RID: 2235 RVA: 0x00043080 File Offset: 0x00041280
	public bool ToDelete
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			if (value)
			{
				this.NewStatus = null;
			}
			if (this.nullable_1 == null && !value)
			{
				this.NewStatus = this.Status;
			}
			base.method_0("ToDelete");
		}
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x000430D0 File Offset: 0x000412D0
	private void method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "&\\#0TZa-jN", object_);
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00043100 File Offset: 0x00041300
	private void method_6()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "%(EXOZa-j0", object_);
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060008BE RID: 2238 RVA: 0x00043130 File Offset: 0x00041330
	public bool HasChanges
	{
		get
		{
			bool? newStatus = this.NewStatus;
			bool? status = this.Status;
			return !(newStatus.GetValueOrDefault() == status.GetValueOrDefault() & newStatus != null == (status != null));
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060008BF RID: 2239 RVA: 0x00043170 File Offset: 0x00041370
	internal bool Boolean_0
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "J%)hmZa-j,", object_);
		}
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x000431A8 File Offset: 0x000413A8
	private void method_7()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "4h%i+Za-j5", object_);
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x000431D8 File Offset: 0x000413D8
	public Task method_8()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "@^ibPZa-j.", object_);
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x0004320C File Offset: 0x0004140C
	private void method_9()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Ogha*Za-j;", object_);
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x0004323C File Offset: 0x0004143C
	public string method_10()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "f=//pZa-j&", object_);
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00007656 File Offset: 0x00005856
	public Visibility ChangeToTaskVisibility
	{
		get
		{
			if (this.Type == dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd.Task)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00043270 File Offset: 0x00041470
	private void method_11()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Kt\"IsZa-it", object_);
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000432A0 File Offset: 0x000414A0
	public GClass280 ChangeToTaskCmd
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_17), null));
			}
			return result;
		}
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x000432D4 File Offset: 0x000414D4
	private void method_12()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "n@,g4Za-j#", object_);
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00007664 File Offset: 0x00005864
	// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0000766C File Offset: 0x0000586C
	public string StatusText
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060008CA RID: 2250 RVA: 0x00007681 File Offset: 0x00005881
	// (set) Token: 0x060008CB RID: 2251 RVA: 0x00007689 File Offset: 0x00005889
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

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060008CC RID: 2252 RVA: 0x0000769E File Offset: 0x0000589E
	// (set) Token: 0x060008CD RID: 2253 RVA: 0x000076A6 File Offset: 0x000058A6
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

	// Token: 0x060008CE RID: 2254 RVA: 0x00043304 File Offset: 0x00041504
	public Task method_13(string string_5, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_5,
			solidColorBrush_1
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "Gd+T_Za-jG", object_);
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00043340 File Offset: 0x00041540
	private Task method_14()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "mC0L1Za-ih", object_);
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00043374 File Offset: 0x00041574
	private Class804 method_15()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class804)Class392.smethod_3().method_105(Class392.smethod_1(), "ZF@6KZa-j&", object_);
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x000433A8 File Offset: 0x000415A8
	private void method_16()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "3k)N(Za-j%", object_);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x000433D8 File Offset: 0x000415D8
	private void method_17(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "e?H?fZa-j9", object_);
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x000076BB File Offset: 0x000058BB
	private static void smethod_0(ref Class490.Struct47 struct47_0)
	{
		struct47_0.asyncTaskMethodBuilder_0.Start<Class490.Struct47>(ref struct47_0);
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x0004340C File Offset: 0x0004160C
	private static void smethod_1(ref string string_5, ref SolidColorBrush solidColorBrush_1, ref CancellationTokenSource cancellationTokenSource_1)
	{
		object[] array = new object[]
		{
			string_5,
			solidColorBrush_1,
			cancellationTokenSource_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "6FXA0Za-jL", array);
		}
		finally
		{
			string_5 = (string)array[0];
			solidColorBrush_1 = (SolidColorBrush)array[1];
			cancellationTokenSource_1 = (CancellationTokenSource)array[2];
		}
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x000434A0 File Offset: 0x000416A0
	private void method_18()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "q7!c=Za-jN", object_);
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x000076C9 File Offset: 0x000058C9
	private static void smethod_2(ref Class490.Struct49 struct49_0)
	{
		struct49_0.asyncVoidMethodBuilder_0.Start<Class490.Struct49>(ref struct49_0);
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x000076D7 File Offset: 0x000058D7
	private static void smethod_3(ref Class490.Struct45 struct45_0)
	{
		struct45_0.asyncVoidMethodBuilder_0.Start<Class490.Struct45>(ref struct45_0);
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x000076E5 File Offset: 0x000058E5
	private static void smethod_4(ref Class490.Struct50 struct50_0)
	{
		struct50_0.asyncVoidMethodBuilder_0.Start<Class490.Struct50>(ref struct50_0);
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x000076F3 File Offset: 0x000058F3
	private static void smethod_5(ref Class490.Struct46 struct46_0)
	{
		struct46_0.asyncTaskMethodBuilder_0.Start<Class490.Struct46>(ref struct46_0);
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00007701 File Offset: 0x00005901
	private static void smethod_6(ref Class490.Struct51 struct51_0)
	{
		struct51_0.asyncTaskMethodBuilder_0.Start<Class490.Struct51>(ref struct51_0);
	}

	// Token: 0x040004E6 RID: 1254
	private Class804 class804_0;

	// Token: 0x040004E7 RID: 1255
	private dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd dje_zRZMNULDC5BTJC2KLAMD28MSVW4VJ32CY3CF4SQTRUH394YCYCFTWVVLS4XBRS7DY8A_ejd_0;

	// Token: 0x040004E8 RID: 1256
	private string string_0;

	// Token: 0x040004E9 RID: 1257
	private string string_1;

	// Token: 0x040004EA RID: 1258
	private string string_2;

	// Token: 0x040004EB RID: 1259
	private string string_3;

	// Token: 0x040004EC RID: 1260
	public BitmapSource bitmapSource_0;

	// Token: 0x040004ED RID: 1261
	private bool? nullable_0;

	// Token: 0x040004EE RID: 1262
	private bool? nullable_1;

	// Token: 0x040004EF RID: 1263
	private bool bool_0;

	// Token: 0x040004F0 RID: 1264
	private GClass280 gclass280_0;

	// Token: 0x040004F1 RID: 1265
	private string string_4;

	// Token: 0x040004F2 RID: 1266
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x040004F3 RID: 1267
	private double double_0;

	// Token: 0x040004F4 RID: 1268
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0200012C RID: 300
	[StructLayout(LayoutKind.Auto)]
	private struct Struct45 : IAsyncStateMachine
	{
		// Token: 0x060008DB RID: 2267 RVA: 0x000434D0 File Offset: 0x000416D0
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
				@class.method_64(stream_, "T!u,7Za-j8", array);
			}
			finally
			{
				this = (Class490.Struct45)array[0];
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0000770F File Offset: 0x0000590F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000771D File Offset: 0x0000591D
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct45 struct45_0)
		{
			struct45_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct45>(ref taskAwaiter_1, ref struct45_0);
		}

		// Token: 0x040004F5 RID: 1269
		public int int_0;

		// Token: 0x040004F6 RID: 1270
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040004F7 RID: 1271
		public Class490 class490_0;

		// Token: 0x040004F8 RID: 1272
		private bool bool_0;

		// Token: 0x040004F9 RID: 1273
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200012D RID: 301
	[StructLayout(LayoutKind.Auto)]
	private struct Struct46 : IAsyncStateMachine
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00043538 File Offset: 0x00041738
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
				@class.method_64(stream_, "9t.O;Za-id", array);
			}
			finally
			{
				this = (Class490.Struct46)array[0];
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0000772C File Offset: 0x0000592C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0000773A File Offset: 0x0000593A
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct46 struct46_0)
		{
			struct46_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct46>(ref taskAwaiter_1, ref struct46_0);
		}

		// Token: 0x040004FA RID: 1274
		public int int_0;

		// Token: 0x040004FB RID: 1275
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040004FC RID: 1276
		public Class490 class490_0;

		// Token: 0x040004FD RID: 1277
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200012E RID: 302
	[StructLayout(LayoutKind.Auto)]
	private struct Struct47 : IAsyncStateMachine
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x000435A0 File Offset: 0x000417A0
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
				@class.method_64(stream_, "`NZbWZa-jK", array);
			}
			finally
			{
				this = (Class490.Struct47)array[0];
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00007749 File Offset: 0x00005949
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00007757 File Offset: 0x00005957
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct47 struct47_0)
		{
			struct47_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct47>(ref taskAwaiter_1, ref struct47_0);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00007757 File Offset: 0x00005957
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct47 struct47_0)
		{
			struct47_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct47>(ref taskAwaiter_1, ref struct47_0);
		}

		// Token: 0x040004FE RID: 1278
		public int int_0;

		// Token: 0x040004FF RID: 1279
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000500 RID: 1280
		public Class490 class490_0;

		// Token: 0x04000501 RID: 1281
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000502 RID: 1282
		public string string_0;

		// Token: 0x04000503 RID: 1283
		private CancellationToken cancellationToken_0;

		// Token: 0x04000504 RID: 1284
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200012F RID: 303
	private sealed class Class177
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00043608 File Offset: 0x00041808
		internal Task method_0()
		{
			Class490.Class177.Struct48 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class177_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class490.Class177.Struct48>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04000505 RID: 1285
		public string string_0;

		// Token: 0x04000506 RID: 1286
		public Class490 class490_0;

		// Token: 0x02000130 RID: 304
		[StructLayout(LayoutKind.Auto)]
		private struct Struct48 : IAsyncStateMachine
		{
			// Token: 0x060008E7 RID: 2279 RVA: 0x0004364C File Offset: 0x0004184C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class490.Class177 @class = this.class177_0;
				try
				{
					TaskAwaiter<BitmapSource> awaiter;
					if (num != 0)
					{
						awaiter = Class765.smethod_6(@class.string_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapSource>, Class490.Class177.Struct48>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<BitmapSource>);
						this.int_0 = -1;
					}
					BitmapSource result = awaiter.GetResult();
					@class.class490_0.bitmapSource_0 = result;
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

			// Token: 0x060008E8 RID: 2280 RVA: 0x00007766 File Offset: 0x00005966
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000507 RID: 1287
			public int int_0;

			// Token: 0x04000508 RID: 1288
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000509 RID: 1289
			public Class490.Class177 class177_0;

			// Token: 0x0400050A RID: 1290
			private TaskAwaiter<BitmapSource> taskAwaiter_0;
		}
	}

	// Token: 0x02000131 RID: 305
	[StructLayout(LayoutKind.Auto)]
	private struct Struct49 : IAsyncStateMachine
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x00043714 File Offset: 0x00041914
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
				@class.method_64(stream_, "J[`%oZa-j2", array);
			}
			finally
			{
				this = (Class490.Struct49)array[0];
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00007774 File Offset: 0x00005974
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00007782 File Offset: 0x00005982
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct49 struct49_0)
		{
			struct49_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct49>(ref taskAwaiter_1, ref struct49_0);
		}

		// Token: 0x0400050B RID: 1291
		public int int_0;

		// Token: 0x0400050C RID: 1292
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400050D RID: 1293
		public Class490 class490_0;

		// Token: 0x0400050E RID: 1294
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000132 RID: 306
	[StructLayout(LayoutKind.Auto)]
	private struct Struct50 : IAsyncStateMachine
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x0004377C File Offset: 0x0004197C
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
				@class.method_64(stream_, "DR[$\\Za-j*", array);
			}
			finally
			{
				this = (Class490.Struct50)array[0];
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00007791 File Offset: 0x00005991
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0000779F File Offset: 0x0000599F
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct50 struct50_0)
		{
			struct50_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct50>(ref taskAwaiter_1, ref struct50_0);
		}

		// Token: 0x0400050F RID: 1295
		public int int_0;

		// Token: 0x04000510 RID: 1296
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000511 RID: 1297
		public string string_0;

		// Token: 0x04000512 RID: 1298
		public Class490 class490_0;

		// Token: 0x04000513 RID: 1299
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000133 RID: 307
	[StructLayout(LayoutKind.Auto)]
	private struct Struct51 : IAsyncStateMachine
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x000437E4 File Offset: 0x000419E4
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
				@class.method_64(stream_, "p9:s3Za-j?", array);
			}
			finally
			{
				this = (Class490.Struct51)array[0];
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000077AE File Offset: 0x000059AE
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000077BC File Offset: 0x000059BC
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct51 struct51_0)
		{
			struct51_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct51>(ref taskAwaiter_1, ref struct51_0);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000077BC File Offset: 0x000059BC
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct51 struct51_0)
		{
			struct51_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct51>(ref taskAwaiter_1, ref struct51_0);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000077BC File Offset: 0x000059BC
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct51 struct51_0)
		{
			struct51_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct51>(ref taskAwaiter_1, ref struct51_0);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000077BC File Offset: 0x000059BC
		private static void MoveNext_3(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct51 struct51_0)
		{
			struct51_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct51>(ref taskAwaiter_1, ref struct51_0);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000077BC File Offset: 0x000059BC
		private static void MoveNext_4(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct51 struct51_0)
		{
			struct51_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct51>(ref taskAwaiter_1, ref struct51_0);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000077BC File Offset: 0x000059BC
		private static void MoveNext_5(ref TaskAwaiter taskAwaiter_1, ref Class490.Struct51 struct51_0)
		{
			struct51_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class490.Struct51>(ref taskAwaiter_1, ref struct51_0);
		}

		// Token: 0x04000514 RID: 1300
		public int int_0;

		// Token: 0x04000515 RID: 1301
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000516 RID: 1302
		public Class490 class490_0;

		// Token: 0x04000517 RID: 1303
		private TaskAwaiter taskAwaiter_0;
	}
}
