using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x020001ED RID: 493
public sealed class GClass170 : GClass162
{
	// Token: 0x06000D71 RID: 3441 RVA: 0x0004E888 File Offset: 0x0004CA88
	public GClass170(dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_1)
	{
		this.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0 = dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_1;
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0000A12F File Offset: 0x0000832F
	// (set) Token: 0x06000D73 RID: 3443 RVA: 0x0000A137 File Offset: 0x00008337
	public string WhatWillBrake
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

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0000A140 File Offset: 0x00008340
	// (set) Token: 0x06000D75 RID: 3445 RVA: 0x0000A148 File Offset: 0x00008348
	public string WhatWillBrakeEng
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

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0000A151 File Offset: 0x00008351
	// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0000A159 File Offset: 0x00008359
	public List<string> ServicesNames
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0000A162 File Offset: 0x00008362
	// (set) Token: 0x06000D79 RID: 3449 RVA: 0x0000A16A File Offset: 0x0000836A
	public List<string> TweaksNames
	{
		[CompilerGenerated]
		get
		{
			return this.list_1;
		}
		[CompilerGenerated]
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0000A173 File Offset: 0x00008373
	// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0000A17B File Offset: 0x0000837B
	public List<string> DevicesNames
	{
		[CompilerGenerated]
		get
		{
			return this.list_2;
		}
		[CompilerGenerated]
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
	public void method_2()
	{
		if (this.Visibility == Visibility.Collapsed)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (string text in this.ServicesNames)
		{
			Dictionary<Type, Dictionary<string, GClass279.GStruct2>> dictionary = GClass279.smethod_0().method_19();
			if (dictionary.Count == 0)
			{
				list.Add(text);
			}
			foreach (KeyValuePair<Type, Dictionary<string, GClass279.GStruct2>> keyValuePair in dictionary)
			{
				if (!(keyValuePair.Key == null) && !(keyValuePair.Key != typeof(Class799)) && !keyValuePair.Value.ContainsKey(text))
				{
					list.Add(text);
				}
			}
		}
		list.ForEach(new Action<string>(this.method_6));
		base.method_0("DisablingServicesName");
		if (this.ServicesNames.Count == 0 && this.TweaksNames.Count == 0 && this.DevicesNames.Count == 0)
		{
			this.method_4();
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0004EA24 File Offset: 0x0004CC24
	public string DisablingServicesName
	{
		get
		{
			List<string> list = new List<string>();
			foreach (string text in this.ServicesNames)
			{
				list.Add(Class298.smethod_2("Service") + " " + GClass219.smethod_0(text));
			}
			foreach (string text2 in this.TweaksNames)
			{
				list.Add(Class298.smethod_2("Setting") + " " + Class298.smethod_2(text2));
			}
			foreach (string str in this.DevicesNames)
			{
				list.Add(Class298.smethod_2("Device") + " " + str);
			}
			return string.Join("\n", list);
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0004EB60 File Offset: 0x0004CD60
	public GClass280 Cancel
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_7), null));
			}
			return result;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0004EB94 File Offset: 0x0004CD94
	public SolidColorBrush Color
	{
		get
		{
			SolidColorBrush result;
			if (GClass68.gclass69_0.method_1(this.WhatWillBrakeEng, out result))
			{
				return result;
			}
			return dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0000A184 File Offset: 0x00008384
	public int Sort
	{
		get
		{
			if (this.Color == dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd)
			{
				return 1;
			}
			if (this.Color == dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd)
			{
				return 2;
			}
			if (this.Color == dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd)
			{
				return 3;
			}
			return 4;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0000A1B4 File Offset: 0x000083B4
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_3();
		}
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x0004EBBC File Offset: 0x0004CDBC
	private MaterialIconKind method_3()
	{
		MaterialIconKind materialIconKind = Class330.smethod_3(this.WhatWillBrakeEng);
		if (materialIconKind == null)
		{
			return 2015;
		}
		return materialIconKind;
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0000A1BC File Offset: 0x000083BC
	// (set) Token: 0x06000D84 RID: 3460 RVA: 0x0000A1C4 File Offset: 0x000083C4
	public double Opacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("Opacity");
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0000A1D9 File Offset: 0x000083D9
	// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0000A1E1 File Offset: 0x000083E1
	public Visibility Visibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("Visibility");
		}
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0004EBE0 File Offset: 0x0004CDE0
	private void method_4()
	{
		GClass170.Struct109 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass170_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass170.Struct109>(ref @struct);
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0000A1F6 File Offset: 0x000083F6
	// (set) Token: 0x06000D89 RID: 3465 RVA: 0x0000A1FE File Offset: 0x000083FE
	public string StatusText
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0000A213 File Offset: 0x00008413
	// (set) Token: 0x06000D8B RID: 3467 RVA: 0x0000A21B File Offset: 0x0000841B
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

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0000A230 File Offset: 0x00008430
	// (set) Token: 0x06000D8D RID: 3469 RVA: 0x0000A238 File Offset: 0x00008438
	public double StatusOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x0004EC18 File Offset: 0x0004CE18
	private void method_5(string string_3, SolidColorBrush solidColorBrush_1)
	{
		GClass170.Struct111 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass170_0 = this;
		@struct.string_0 = string_3;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass170.Struct111>(ref @struct);
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x0000A24D File Offset: 0x0000844D
	private void method_6(string string_3)
	{
		this.ServicesNames.Remove(string_3);
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x0004EC60 File Offset: 0x0004CE60
	private void method_7(object object_0)
	{
		GClass170.Struct110 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass170_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass170.Struct110>(ref @struct);
	}

	// Token: 0x04000895 RID: 2197
	private dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0;

	// Token: 0x04000896 RID: 2198
	private string string_0;

	// Token: 0x04000897 RID: 2199
	private string string_1;

	// Token: 0x04000898 RID: 2200
	private List<string> list_0 = new List<string>();

	// Token: 0x04000899 RID: 2201
	private List<string> list_1 = new List<string>();

	// Token: 0x0400089A RID: 2202
	private List<string> list_2 = new List<string>();

	// Token: 0x0400089B RID: 2203
	private GClass280 gclass280_0;

	// Token: 0x0400089C RID: 2204
	private double double_0 = 1.0;

	// Token: 0x0400089D RID: 2205
	private Visibility visibility_0;

	// Token: 0x0400089E RID: 2206
	private string string_2 = string.Empty;

	// Token: 0x0400089F RID: 2207
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x040008A0 RID: 2208
	private double double_1;

	// Token: 0x020001EE RID: 494
	[StructLayout(LayoutKind.Auto)]
	private struct Struct109 : IAsyncStateMachine
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x0004EC98 File Offset: 0x0004CE98
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass170 gclass = this.gclass170_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_8E;
				}
				IL_2F:
				if (gclass.Opacity == 0.0)
				{
					gclass.Visibility = Visibility.Collapsed;
					goto IL_D7;
				}
				gclass.Opacity -= 0.1;
				if (gclass.Opacity < 0.05)
				{
					gclass.Opacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass170.Struct109>(ref awaiter, ref this);
					return;
				}
				IL_8E:
				awaiter.GetResult();
				goto IL_2F;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_D7:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0000A25C File Offset: 0x0000845C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008A1 RID: 2209
		public int int_0;

		// Token: 0x040008A2 RID: 2210
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008A3 RID: 2211
		public GClass170 gclass170_0;

		// Token: 0x040008A4 RID: 2212
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001EF RID: 495
	[StructLayout(LayoutKind.Auto)]
	private struct Struct110 : IAsyncStateMachine
	{
		// Token: 0x06000D93 RID: 3475 RVA: 0x0004EDA0 File Offset: 0x0004CFA0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass170 gclass = this.gclass170_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						int num2 = -1;
						num = -1;
						this.int_0 = num2;
						goto IL_29E;
					}
					gclass.method_5(Class298.smethod_2("Removing"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd);
					List<string>.Enumerator enumerator = gclass.ServicesNames.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string text = enumerator.Current;
							GClass279.smethod_0().method_15(typeof(Class799), text);
							IEnumerator<GClass184> enumerator2 = Class589.smethod_1(false).AllServices.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									GClass184 gclass2 = enumerator2.Current;
									if (text == gclass2.ServiceName)
									{
										gclass2.DependOn.ForEach(new Action<GClass189>(GClass170.Class236.class236_0.method_0));
										break;
									}
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
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					enumerator = gclass.TweaksNames.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string string_ = enumerator.Current;
							GClass279.smethod_0().method_15(typeof(Class803), Class298.smethod_2(string_));
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					enumerator = gclass.DevicesNames.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string string_2 = enumerator.Current;
							GClass279.smethod_0().method_15(typeof(Class798), string_2);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
					List<GClass170>.Enumerator enumerator3 = gclass.dje_z2JLZCGZ3QXEER9XV34JWZVWRQG36ZLYPFWG4AK5XUE7JPWQ_ejd_0.list_0.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							GClass170 gclass3 = enumerator3.Current;
							gclass3.method_2();
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator3).Dispose();
						}
					}
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num3 = 0;
						num = 0;
						this.int_0 = num3;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass170.Struct110>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num4 = -1;
					num = -1;
					this.int_0 = num4;
				}
				awaiter.GetResult();
				gclass.method_5(Class298.smethod_2("success"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				awaiter = Task.Delay(500).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num5 = 1;
					num = 1;
					this.int_0 = num5;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass170.Struct110>(ref awaiter, ref this);
					return;
				}
				IL_29E:
				awaiter.GetResult();
				gclass.method_4();
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

		// Token: 0x06000D94 RID: 3476 RVA: 0x0000A26A File Offset: 0x0000846A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008A5 RID: 2213
		public int int_0;

		// Token: 0x040008A6 RID: 2214
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008A7 RID: 2215
		public GClass170 gclass170_0;

		// Token: 0x040008A8 RID: 2216
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001F0 RID: 496
	[StructLayout(LayoutKind.Auto)]
	private struct Struct111 : IAsyncStateMachine
	{
		// Token: 0x06000D95 RID: 3477 RVA: 0x0004F11C File Offset: 0x0004D31C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass170 gclass = this.gclass170_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_B8;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_127;
				}
				IL_56:
				if (gclass.StatusOpacity == 0.0)
				{
					gclass.StatusColor = this.solidColorBrush_0;
					gclass.StatusText = this.string_0;
					goto IL_12E;
				}
				gclass.StatusOpacity -= 0.1;
				if (gclass.StatusOpacity < 0.05)
				{
					gclass.StatusOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass170.Struct111>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_127:
				awaiter.GetResult();
				IL_12E:
				if (gclass.StatusOpacity != 1.0)
				{
					gclass.StatusOpacity += 0.13333333333333333;
					if (gclass.StatusOpacity > 0.95)
					{
						gclass.StatusOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_127;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass170.Struct111>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06000D96 RID: 3478 RVA: 0x0000A278 File Offset: 0x00008478
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040008A9 RID: 2217
		public int int_0;

		// Token: 0x040008AA RID: 2218
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040008AB RID: 2219
		public GClass170 gclass170_0;

		// Token: 0x040008AC RID: 2220
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040008AD RID: 2221
		public string string_0;

		// Token: 0x040008AE RID: 2222
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020001F1 RID: 497
	[Serializable]
	private sealed class Class236
	{
		// Token: 0x06000D99 RID: 3481 RVA: 0x0000A292 File Offset: 0x00008492
		internal void method_0(GClass189 gclass189_0)
		{
			GClass279.smethod_0().method_15(typeof(Class799), gclass189_0.ServiceName);
		}

		// Token: 0x040008AF RID: 2223
		public static readonly GClass170.Class236 class236_0 = new GClass170.Class236();

		// Token: 0x040008B0 RID: 2224
		public static Action<GClass189> action_0;
	}
}
