using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Token: 0x0200032C RID: 812
public sealed class GClass180 : GClass162
{
	// Token: 0x060014FA RID: 5370 RVA: 0x0000E890 File Offset: 0x0000CA90
	public GClass180()
	{
		GClass180.smethod_1(ref this.observableCollection_0);
		base..ctor();
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x060014FB RID: 5371 RVA: 0x0000E8A3 File Offset: 0x0000CAA3
	// (set) Token: 0x060014FC RID: 5372 RVA: 0x0000E8AB File Offset: 0x0000CAAB
	public ObservableCollection<GClass179> NetworkAdapters
	{
		get
		{
			return this.observableCollection_0;
		}
		private set
		{
			base.method_1<ObservableCollection<GClass179>>(ref this.observableCollection_0, value, "NetworkAdapters", null);
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x060014FD RID: 5373 RVA: 0x0000E8C2 File Offset: 0x0000CAC2
	// (set) Token: 0x060014FE RID: 5374 RVA: 0x0000E8CA File Offset: 0x0000CACA
	public GClass179 CurrentNetworkAdapter
	{
		get
		{
			return this.gclass179_0;
		}
		set
		{
			base.method_1<GClass179>(ref this.gclass179_0, value, "CurrentNetworkAdapter", null);
		}
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00064F34 File Offset: 0x00063134
	public void method_2()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "<jT3@Za-jW", object_);
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x0000E8E1 File Offset: 0x0000CAE1
	private static string smethod_0()
	{
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "+1&A^Za-i!", null);
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x06001501 RID: 5377 RVA: 0x00064F64 File Offset: 0x00063164
	public GClass280 UpdateCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_5), null));
			}
			return result;
		}
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x06001502 RID: 5378 RVA: 0x00064F98 File Offset: 0x00063198
	public GClass280 DefaultCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_7), null));
			}
			return result;
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x06001503 RID: 5379 RVA: 0x00064FCC File Offset: 0x000631CC
	public GClass280 OptimalClickCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(this.method_8), null));
			}
			return result;
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x06001504 RID: 5380 RVA: 0x00065000 File Offset: 0x00063200
	public GClass280 MaximumClickCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_3) == null)
			{
				result = (this.gclass280_3 = new GClass280(new Action<object>(this.method_9), null));
			}
			return result;
		}
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x00065034 File Offset: 0x00063234
	private void method_3(IReadOnlyDictionary<string, int> ireadOnlyDictionary_0, IEnumerable<GClass171> ienumerable_0)
	{
		object[] object_ = new object[]
		{
			this,
			ireadOnlyDictionary_0,
			ienumerable_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "gU\";pZa-h^", object_);
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x0006506C File Offset: 0x0006326C
	private void method_4(IReadOnlyDictionary<string, int> ireadOnlyDictionary_0)
	{
		object[] object_ = new object[]
		{
			this,
			ireadOnlyDictionary_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "7'j;.Za-ha", object_);
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x000650A0 File Offset: 0x000632A0
	private void method_5(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "WjB+?Za-hI", object_);
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x000650D4 File Offset: 0x000632D4
	private Task method_6()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "$+%%HZa-hU", object_);
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00065108 File Offset: 0x00063308
	private void method_7(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "1paTsZa-hM", object_);
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x0006513C File Offset: 0x0006333C
	private void method_8(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "X0]4@Za-hS", object_);
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00065170 File Offset: 0x00063370
	private void method_9(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "0=/'nZa-hS", object_);
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x000651A4 File Offset: 0x000633A4
	private static void smethod_1(ref ObservableCollection<GClass179> observableCollection_1)
	{
		object[] array = new object[]
		{
			observableCollection_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "\\$NKLZa-jV", array);
		}
		finally
		{
			observableCollection_1 = (ObservableCollection<GClass179>)array[0];
		}
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x0000E8FD File Offset: 0x0000CAFD
	private static void smethod_2(ref GClass180.Struct179 struct179_0)
	{
		struct179_0.asyncVoidMethodBuilder_0.Start<GClass180.Struct179>(ref struct179_0);
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x0000E90B File Offset: 0x0000CB0B
	private static void smethod_3(ref GClass180.Struct178 struct178_0)
	{
		struct178_0.asyncVoidMethodBuilder_0.Start<GClass180.Struct178>(ref struct178_0);
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x0000E919 File Offset: 0x0000CB19
	private static void smethod_4(ref GClass180.Struct177 struct177_0)
	{
		struct177_0.asyncVoidMethodBuilder_0.Start<GClass180.Struct177>(ref struct177_0);
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x0000E927 File Offset: 0x0000CB27
	private static void smethod_5(ref GClass180.Struct176 struct176_0)
	{
		struct176_0.asyncVoidMethodBuilder_0.Start<GClass180.Struct176>(ref struct176_0);
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x0000E935 File Offset: 0x0000CB35
	private static void smethod_6(ref GClass180.Struct175 struct175_0)
	{
		struct175_0.asyncTaskMethodBuilder_0.Start<GClass180.Struct175>(ref struct175_0);
	}

	// Token: 0x04000DFE RID: 3582
	private ObservableCollection<GClass179> observableCollection_0;

	// Token: 0x04000DFF RID: 3583
	private GClass179 gclass179_0;

	// Token: 0x04000E00 RID: 3584
	public bool bool_0;

	// Token: 0x04000E01 RID: 3585
	private bool bool_1;

	// Token: 0x04000E02 RID: 3586
	private GClass280 gclass280_0;

	// Token: 0x04000E03 RID: 3587
	private GClass280 gclass280_1;

	// Token: 0x04000E04 RID: 3588
	private GClass280 gclass280_2;

	// Token: 0x04000E05 RID: 3589
	private GClass280 gclass280_3;

	// Token: 0x0200032D RID: 813
	private sealed class Class386
	{
		// Token: 0x06001513 RID: 5395 RVA: 0x00065200 File Offset: 0x00063400
		internal void method_0()
		{
			GClass180.Class389 @class = new GClass180.Class389();
			this.gclass180_0.NetworkAdapters.Clear();
			foreach (GClass293 gclass293_ in this.list_0)
			{
				this.gclass180_0.NetworkAdapters.Add(new GClass179(gclass293_));
			}
			@class.string_0 = GClass180.smethod_0();
			GClass180 gclass = this.gclass180_0;
			GClass179 currentNetworkAdapter;
			if ((currentNetworkAdapter = this.gclass180_0.NetworkAdapters.FirstOrDefault(new Func<GClass179, bool>(@class.method_0))) == null)
			{
				currentNetworkAdapter = (this.gclass180_0.NetworkAdapters.FirstOrDefault(new Func<GClass179, bool>(GClass180.Class390.class390_0.method_0)) ?? this.gclass180_0.NetworkAdapters.FirstOrDefault<GClass179>());
			}
			gclass.CurrentNetworkAdapter = currentNetworkAdapter;
		}

		// Token: 0x04000E06 RID: 3590
		public GClass180 gclass180_0;

		// Token: 0x04000E07 RID: 3591
		public List<GClass293> list_0;
	}

	// Token: 0x0200032E RID: 814
	private sealed class Class387
	{
		// Token: 0x06001515 RID: 5397 RVA: 0x000652F4 File Offset: 0x000634F4
		internal void method_0()
		{
			if (!this.bool_0)
			{
				using (IEnumerator<GClass171> enumerator = this.gclass180_0.CurrentNetworkAdapter.Settings.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GClass171 gclass = enumerator.Current;
						gclass.method_11();
					}
					return;
				}
			}
			foreach (GClass179 gclass2 in this.gclass180_0.NetworkAdapters)
			{
				foreach (GClass171 gclass3 in gclass2.Settings)
				{
					gclass3.method_11();
				}
			}
		}

		// Token: 0x04000E08 RID: 3592
		public bool bool_0;

		// Token: 0x04000E09 RID: 3593
		public GClass180 gclass180_0;
	}

	// Token: 0x0200032F RID: 815
	[StructLayout(LayoutKind.Auto)]
	private struct Struct175 : IAsyncStateMachine
	{
		// Token: 0x06001516 RID: 5398 RVA: 0x000653C4 File Offset: 0x000635C4
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
				@class.method_64(stream_, "0!hsmZa-hV", array);
			}
			finally
			{
				this = (GClass180.Struct175)array[0];
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0000E943 File Offset: 0x0000CB43
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0000E951 File Offset: 0x0000CB51
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass180.Struct175 struct175_0)
		{
			struct175_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass180.Struct175>(ref taskAwaiter_1, ref struct175_0);
		}

		// Token: 0x04000E0A RID: 3594
		public int int_0;

		// Token: 0x04000E0B RID: 3595
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000E0C RID: 3596
		public GClass180 gclass180_0;

		// Token: 0x04000E0D RID: 3597
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000330 RID: 816
	[StructLayout(LayoutKind.Auto)]
	private struct Struct176 : IAsyncStateMachine
	{
		// Token: 0x06001519 RID: 5401 RVA: 0x0006542C File Offset: 0x0006362C
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
				@class.method_64(stream_, "aKr:]Za-hO", array);
			}
			finally
			{
				this = (GClass180.Struct176)array[0];
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0000E960 File Offset: 0x0000CB60
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0000E96E File Offset: 0x0000CB6E
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass180.Struct176 struct176_0)
		{
			struct176_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass180.Struct176>(ref taskAwaiter_1, ref struct176_0);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0000E96E File Offset: 0x0000CB6E
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref GClass180.Struct176 struct176_0)
		{
			struct176_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass180.Struct176>(ref taskAwaiter_1, ref struct176_0);
		}

		// Token: 0x04000E0E RID: 3598
		public int int_0;

		// Token: 0x04000E0F RID: 3599
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000E10 RID: 3600
		public GClass180 gclass180_0;

		// Token: 0x04000E11 RID: 3601
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000331 RID: 817
	private sealed class Class388
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x00065494 File Offset: 0x00063694
		internal void method_0()
		{
			if (!this.bool_0)
			{
				this.gclass180_0.method_3(this.ireadOnlyDictionary_0, this.gclass180_0.CurrentNetworkAdapter.Settings);
				return;
			}
			foreach (GClass179 gclass in this.gclass180_0.NetworkAdapters)
			{
				this.gclass180_0.method_3(this.ireadOnlyDictionary_0, gclass.Settings);
			}
		}

		// Token: 0x04000E12 RID: 3602
		public bool bool_0;

		// Token: 0x04000E13 RID: 3603
		public GClass180 gclass180_0;

		// Token: 0x04000E14 RID: 3604
		public IReadOnlyDictionary<string, int> ireadOnlyDictionary_0;
	}

	// Token: 0x02000332 RID: 818
	private sealed class Class389
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x0000E97D File Offset: 0x0000CB7D
		internal bool method_0(GClass179 gclass179_0)
		{
			return gclass179_0.Model.method_2().Equals(this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000E15 RID: 3605
		public string string_0;
	}

	// Token: 0x02000333 RID: 819
	[StructLayout(LayoutKind.Auto)]
	private struct Struct177 : IAsyncStateMachine
	{
		// Token: 0x06001521 RID: 5409 RVA: 0x00065524 File Offset: 0x00063724
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
				@class.method_64(stream_, "VR*\\;Za-hJ", array);
			}
			finally
			{
				this = (GClass180.Struct177)array[0];
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0000E996 File Offset: 0x0000CB96
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass180.Struct177 struct177_0)
		{
			struct177_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass180.Struct177>(ref taskAwaiter_1, ref struct177_0);
		}

		// Token: 0x04000E16 RID: 3606
		public int int_0;

		// Token: 0x04000E17 RID: 3607
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000E18 RID: 3608
		public GClass180 gclass180_0;

		// Token: 0x04000E19 RID: 3609
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000334 RID: 820
	[StructLayout(LayoutKind.Auto)]
	private struct Struct178 : IAsyncStateMachine
	{
		// Token: 0x06001524 RID: 5412 RVA: 0x0006558C File Offset: 0x0006378C
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
				@class.method_64(stream_, "TsM/6Za-hd", array);
			}
			finally
			{
				this = (GClass180.Struct178)array[0];
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0000E9B3 File Offset: 0x0000CBB3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0000E9C1 File Offset: 0x0000CBC1
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass180.Struct178 struct178_0)
		{
			struct178_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass180.Struct178>(ref taskAwaiter_1, ref struct178_0);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0000E9C1 File Offset: 0x0000CBC1
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref GClass180.Struct178 struct178_0)
		{
			struct178_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass180.Struct178>(ref taskAwaiter_1, ref struct178_0);
		}

		// Token: 0x04000E1A RID: 3610
		public int int_0;

		// Token: 0x04000E1B RID: 3611
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000E1C RID: 3612
		public GClass180 gclass180_0;

		// Token: 0x04000E1D RID: 3613
		public IReadOnlyDictionary<string, int> ireadOnlyDictionary_0;

		// Token: 0x04000E1E RID: 3614
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000335 RID: 821
	[StructLayout(LayoutKind.Auto)]
	private struct Struct179 : IAsyncStateMachine
	{
		// Token: 0x06001528 RID: 5416 RVA: 0x000655F4 File Offset: 0x000637F4
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
				@class.method_64(stream_, "::%@8Za-hi", array);
			}
			finally
			{
				this = (GClass180.Struct179)array[0];
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0000E9DE File Offset: 0x0000CBDE
		private static void MoveNext(ref ConfiguredTaskAwaitable<List<GClass293>>.ConfiguredTaskAwaiter configuredTaskAwaiter_1, ref GClass180.Struct179 struct179_0)
		{
			struct179_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<List<GClass293>>.ConfiguredTaskAwaiter, GClass180.Struct179>(ref configuredTaskAwaiter_1, ref struct179_0);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0000E9ED File Offset: 0x0000CBED
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref GClass180.Struct179 struct179_0)
		{
			struct179_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass180.Struct179>(ref taskAwaiter_1, ref struct179_0);
		}

		// Token: 0x04000E1F RID: 3615
		public int int_0;

		// Token: 0x04000E20 RID: 3616
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000E21 RID: 3617
		public GClass180 gclass180_0;

		// Token: 0x04000E22 RID: 3618
		private GClass180.Class386 class386_0;

		// Token: 0x04000E23 RID: 3619
		private ConfiguredTaskAwaitable<List<GClass293>>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		// Token: 0x04000E24 RID: 3620
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000336 RID: 822
	[Serializable]
	private sealed class Class390
	{
		// Token: 0x0600152E RID: 5422 RVA: 0x0000EA08 File Offset: 0x0000CC08
		internal bool method_0(GClass179 gclass179_0)
		{
			return gclass179_0.Model.IsEnabled;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0000EA15 File Offset: 0x0000CC15
		internal bool method_1(NetworkInterface networkInterface_0)
		{
			return networkInterface_0.NetworkInterfaceType != NetworkInterfaceType.Loopback && networkInterface_0.OperationalStatus == OperationalStatus.Up;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		internal bool method_2(GatewayIPAddressInformation gatewayIPAddressInformation_0)
		{
			return !object.Equals(gatewayIPAddressInformation_0.Address, IPAddress.Any);
		}

		// Token: 0x04000E25 RID: 3621
		public static readonly GClass180.Class390 class390_0 = new GClass180.Class390();

		// Token: 0x04000E26 RID: 3622
		public static Func<GClass179, bool> func_0;

		// Token: 0x04000E27 RID: 3623
		public static Func<NetworkInterface, bool> func_1;

		// Token: 0x04000E28 RID: 3624
		public static Func<GatewayIPAddressInformation, bool> func_2;
	}
}
