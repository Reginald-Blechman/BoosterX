using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

// Token: 0x0200044F RID: 1103
public sealed class GClass186 : GClass162
{
	// Token: 0x06001CA3 RID: 7331 RVA: 0x00012FF1 File Offset: 0x000111F1
	public GClass186(GClass8 gclass8_1, bool bool_3 = false, string string_1 = "")
	{
		GClass186.smethod_0(ref this.string_0);
		base..ctor();
		this.method_13(gclass8_1, bool_3, string_1);
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x00078978 File Offset: 0x00076B78
	private void method_2()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "n@l<;Za-hn", object_);
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x000789A8 File Offset: 0x00076BA8
	private void method_3()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "iP)_,Za-hr", object_);
	}

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0001300D File Offset: 0x0001120D
	public string Name
	{
		get
		{
			return this.gclass8_0.Name;
		}
	}

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x0001301A File Offset: 0x0001121A
	public string ClassName
	{
		get
		{
			return this.gclass8_0.method_2();
		}
	}

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00013027 File Offset: 0x00011227
	public string ClassGuid
	{
		get
		{
			return this.gclass8_0.method_4();
		}
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00013034 File Offset: 0x00011234
	public BitmapSource Icon
	{
		get
		{
			return GClass275.smethod_0(this.gclass8_0.method_4());
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00013046 File Offset: 0x00011246
	public string Id
	{
		get
		{
			return this.gclass8_0.method_0();
		}
	}

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000789D8 File Offset: 0x00076BD8
	public string Description
	{
		get
		{
			string text = string.Empty;
			if (this.string_0 == string.Empty)
			{
				text += (this.bool_0 ? Class298.smethod_2("MsiDeviceDesc") : Class298.smethod_2("DisableDeviceDesc"));
			}
			else
			{
				text += this.string_0;
			}
			text += "\n\n";
			return string.Concat(new string[]
			{
				text,
				"ID: ",
				this.gclass8_0.method_0(),
				"\r\n",
				Class298.smethod_2("Name"),
				": ",
				this.gclass8_0.Name,
				"\r\n",
				Class298.smethod_2("Driver"),
				": ",
				this.gclass8_0.method_8(),
				"\r\n",
				Class298.smethod_2("Manufacturer"),
				": ",
				this.gclass8_0.method_6(),
				"\r\n",
				Class298.smethod_2("Status"),
				": ",
				this.gclass8_0.Status
			});
		}
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00013053 File Offset: 0x00011253
	// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0001305B File Offset: 0x0001125B
	public bool? CurrentStatus
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

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00013064 File Offset: 0x00011264
	// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00078B2C File Offset: 0x00076D2C
	public bool IsEnabled
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			if (this.CurrentStatus == null)
			{
				this.CurrentStatus = new bool?(value);
			}
			this.bool_1 = value;
			base.method_0("HasChangesEnabled");
			base.method_0("IsEnabled");
			this.method_4();
		}
	}

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0001306C File Offset: 0x0001126C
	// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00013074 File Offset: 0x00011274
	public bool? MsiCurrentStatus
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_1;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_1 = value;
		}
	}

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0001307D File Offset: 0x0001127D
	// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00078B7C File Offset: 0x00076D7C
	public bool MsiStatus
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			bool? msiCurrentStatus = this.MsiCurrentStatus;
			bool valueOrDefault = msiCurrentStatus.GetValueOrDefault();
			if (msiCurrentStatus == null)
			{
				bool? msiCurrentStatus2 = new bool?(value);
				this.MsiCurrentStatus = msiCurrentStatus2;
			}
			this.bool_2 = value;
			base.method_0("HasChangesMSI");
			base.method_0("MsiStatus");
			this.method_5();
		}
	}

	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00078BD8 File Offset: 0x00076DD8
	public bool HasChangesMSI
	{
		get
		{
			bool msiStatus = this.MsiStatus;
			bool? msiCurrentStatus = this.MsiCurrentStatus;
			return !(msiStatus == msiCurrentStatus.GetValueOrDefault() & msiCurrentStatus != null);
		}
	}

	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00078C08 File Offset: 0x00076E08
	public bool HasChangesEnabled
	{
		get
		{
			bool isEnabled = this.IsEnabled;
			bool? currentStatus = this.CurrentStatus;
			return !(isEnabled == currentStatus.GetValueOrDefault() & currentStatus != null);
		}
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x00078C38 File Offset: 0x00076E38
	private void method_4()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "9YRpAZa-ht", object_);
	}

	// Token: 0x06001CB7 RID: 7351 RVA: 0x00078C68 File Offset: 0x00076E68
	private void method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "ahG0iZa-hu", object_);
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x00078C98 File Offset: 0x00076E98
	private void method_6()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "aM,'hZa-i\"", object_);
	}

	// Token: 0x06001CB9 RID: 7353 RVA: 0x00078CC8 File Offset: 0x00076EC8
	public Task method_7()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "=h_;NZa-h`", object_);
	}

	// Token: 0x06001CBA RID: 7354 RVA: 0x00078CFC File Offset: 0x00076EFC
	private void method_8()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "8\\VU>Za-h[", object_);
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x00078D2C File Offset: 0x00076F2C
	private void method_9()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "@_T7WZa-h\\", object_);
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x00078D5C File Offset: 0x00076F5C
	private void method_10()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "E5&`eZa-h]", object_);
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x00078D8C File Offset: 0x00076F8C
	private Class798 method_11()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class798)Class392.smethod_3().method_105(Class392.smethod_1(), "._`<tZa-hc", object_);
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x00078DC0 File Offset: 0x00076FC0
	private void method_12()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "$GNpTZa-h^", object_);
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x00078DF0 File Offset: 0x00076FF0
	private static void smethod_0(ref string string_1)
	{
		object[] array = new object[]
		{
			string_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "=h_;NZa-hj", array);
		}
		finally
		{
			string_1 = (string)array[0];
		}
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x00078E4C File Offset: 0x0007704C
	private void method_13(GClass8 gclass8_1, bool bool_3, string string_1)
	{
		object[] object_ = new object[]
		{
			this,
			gclass8_1,
			bool_3,
			string_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "R(fu8Za-hl", object_);
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x00013085 File Offset: 0x00011285
	private static void smethod_1(ref GClass186.Struct283 struct283_0)
	{
		struct283_0.asyncVoidMethodBuilder_0.Start<GClass186.Struct283>(ref struct283_0);
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x00013093 File Offset: 0x00011293
	private static void smethod_2(ref GClass186.Struct281 struct281_0)
	{
		struct281_0.asyncVoidMethodBuilder_0.Start<GClass186.Struct281>(ref struct281_0);
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x000130A1 File Offset: 0x000112A1
	private static void smethod_3(ref GClass186.Struct282 struct282_0)
	{
		struct282_0.asyncVoidMethodBuilder_0.Start<GClass186.Struct282>(ref struct282_0);
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x000130AF File Offset: 0x000112AF
	private static void smethod_4(ref GClass186.Struct284 struct284_0)
	{
		struct284_0.asyncTaskMethodBuilder_0.Start<GClass186.Struct284>(ref struct284_0);
	}

	// Token: 0x04001310 RID: 4880
	private GClass8 gclass8_0;

	// Token: 0x04001311 RID: 4881
	private Class798 class798_0;

	// Token: 0x04001312 RID: 4882
	private bool bool_0;

	// Token: 0x04001313 RID: 4883
	private string string_0;

	// Token: 0x04001314 RID: 4884
	private bool? nullable_0;

	// Token: 0x04001315 RID: 4885
	private bool bool_1;

	// Token: 0x04001316 RID: 4886
	private bool? nullable_1;

	// Token: 0x04001317 RID: 4887
	private bool bool_2;

	// Token: 0x02000450 RID: 1104
	[StructLayout(LayoutKind.Auto)]
	private struct Struct281 : IAsyncStateMachine
	{
		// Token: 0x06001CC5 RID: 7365 RVA: 0x00078E8C File Offset: 0x0007708C
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
				@class.method_64(stream_, "NkVp.Za-hs", array);
			}
			finally
			{
				this = (GClass186.Struct281)array[0];
			}
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x000130BD File Offset: 0x000112BD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x000130CB File Offset: 0x000112CB
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass186.Struct281 struct281_0)
		{
			struct281_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass186.Struct281>(ref taskAwaiter_1, ref struct281_0);
		}

		// Token: 0x04001318 RID: 4888
		public int int_0;

		// Token: 0x04001319 RID: 4889
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400131A RID: 4890
		public GClass186 gclass186_0;

		// Token: 0x0400131B RID: 4891
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000451 RID: 1105
	[StructLayout(LayoutKind.Auto)]
	private struct Struct282 : IAsyncStateMachine
	{
		// Token: 0x06001CC8 RID: 7368 RVA: 0x00078EF4 File Offset: 0x000770F4
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
				@class.method_64(stream_, "n@l<;Za-hY", array);
			}
			finally
			{
				this = (GClass186.Struct282)array[0];
			}
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000130DA File Offset: 0x000112DA
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000130E8 File Offset: 0x000112E8
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass186.Struct282 struct282_0)
		{
			struct282_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass186.Struct282>(ref taskAwaiter_1, ref struct282_0);
		}

		// Token: 0x0400131C RID: 4892
		public int int_0;

		// Token: 0x0400131D RID: 4893
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400131E RID: 4894
		public GClass186 gclass186_0;

		// Token: 0x0400131F RID: 4895
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000452 RID: 1106
	[StructLayout(LayoutKind.Auto)]
	private struct Struct283 : IAsyncStateMachine
	{
		// Token: 0x06001CCB RID: 7371 RVA: 0x00078F5C File Offset: 0x0007715C
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
				@class.method_64(stream_, "Q+jZ5Za-ho", array);
			}
			finally
			{
				this = (GClass186.Struct283)array[0];
			}
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000130F7 File Offset: 0x000112F7
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00013105 File Offset: 0x00011305
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass186.Struct283 struct283_0)
		{
			struct283_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass186.Struct283>(ref taskAwaiter_1, ref struct283_0);
		}

		// Token: 0x04001320 RID: 4896
		public int int_0;

		// Token: 0x04001321 RID: 4897
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001322 RID: 4898
		public GClass186 gclass186_0;

		// Token: 0x04001323 RID: 4899
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000453 RID: 1107
	[StructLayout(LayoutKind.Auto)]
	private struct Struct284 : IAsyncStateMachine
	{
		// Token: 0x06001CCE RID: 7374 RVA: 0x00078FC4 File Offset: 0x000771C4
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
				@class.method_64(stream_, "8\\VU>Za-ha", array);
			}
			finally
			{
				this = (GClass186.Struct284)array[0];
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00013114 File Offset: 0x00011314
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00013122 File Offset: 0x00011322
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass186.Struct284 struct284_0)
		{
			struct284_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass186.Struct284>(ref taskAwaiter_1, ref struct284_0);
		}

		// Token: 0x04001324 RID: 4900
		public int int_0;

		// Token: 0x04001325 RID: 4901
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001326 RID: 4902
		public GClass186 gclass186_0;

		// Token: 0x04001327 RID: 4903
		private TaskAwaiter taskAwaiter_0;
	}
}
