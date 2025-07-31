using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000155 RID: 341
internal sealed class Class492 : GClass162
{
	// Token: 0x060009D0 RID: 2512 RVA: 0x00007FA5 File Offset: 0x000061A5
	public Class492()
	{
		Class492.smethod_0(ref this.observableCollection_0);
		base..ctor();
		this.method_6();
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00007FBE File Offset: 0x000061BE
	// Note: this type is marked as 'beforefieldinit'.
	static Class492()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "PI%[(Za-jS", null);
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00045564 File Offset: 0x00043764
	private void method_2(object sender, NotifyCollectionChangedEventArgs e)
	{
		object[] object_ = new object[]
		{
			this,
			sender,
			e
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "mBa4-Za-jS", object_);
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00007FD5 File Offset: 0x000061D5
	// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00007FDD File Offset: 0x000061DD
	public ObservableCollection<Class512> Tweaks
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("Tweaks");
		}
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x0004559C File Offset: 0x0004379C
	internal void method_3()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "PI%[(Za-k)", object_);
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x000455CC File Offset: 0x000437CC
	public void method_4()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "1paTsZa-jk", object_);
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x000455FC File Offset: 0x000437FC
	public void method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "LU4CqZa-jP", object_);
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0004562C File Offset: 0x0004382C
	private static void smethod_0(ref ObservableCollection<Class512> observableCollection_1)
	{
		object[] array = new object[]
		{
			observableCollection_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "f<_llZa-k&", array);
		}
		finally
		{
			observableCollection_1 = (ObservableCollection<Class512>)array[0];
		}
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00045688 File Offset: 0x00043888
	private void method_6()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "8@,_2Za-k&", object_);
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00007FF2 File Offset: 0x000061F2
	private static void smethod_1(ref Class492.Struct63 struct63_0)
	{
		struct63_0.asyncVoidMethodBuilder_0.Start<Class492.Struct63>(ref struct63_0);
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00008000 File Offset: 0x00006200
	private static void smethod_2(ref Class492.Struct65 struct65_0)
	{
		struct65_0.asyncVoidMethodBuilder_0.Start<Class492.Struct65>(ref struct65_0);
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0000800E File Offset: 0x0000620E
	private static void smethod_3(ref Class492.Struct64 struct64_0)
	{
		struct64_0.asyncVoidMethodBuilder_0.Start<Class492.Struct64>(ref struct64_0);
	}

	// Token: 0x04000691 RID: 1681
	private static readonly SemaphoreSlim semaphoreSlim_0;

	// Token: 0x04000692 RID: 1682
	public ObservableCollection<Class512> observableCollection_0;

	// Token: 0x02000156 RID: 342
	[StructLayout(LayoutKind.Auto)]
	private struct Struct63 : IAsyncStateMachine
	{
		// Token: 0x060009DD RID: 2525 RVA: 0x000456B8 File Offset: 0x000438B8
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
				@class.method_64(stream_, "&$r[NZa-jc", array);
			}
			finally
			{
				this = (Class492.Struct63)array[0];
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0000801C File Offset: 0x0000621C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0000802A File Offset: 0x0000622A
		private static void MoveNext(ref TaskAwaiter taskAwaiter_2, ref Class492.Struct63 struct63_0)
		{
			struct63_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class492.Struct63>(ref taskAwaiter_2, ref struct63_0);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00008039 File Offset: 0x00006239
		private static void MoveNext_1(ref TaskAwaiter<Class723> taskAwaiter_2, ref Class492.Struct63 struct63_0)
		{
			struct63_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class723>, Class492.Struct63>(ref taskAwaiter_2, ref struct63_0);
		}

		// Token: 0x04000693 RID: 1683
		public int int_0;

		// Token: 0x04000694 RID: 1684
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000695 RID: 1685
		public Class492 class492_0;

		// Token: 0x04000696 RID: 1686
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000697 RID: 1687
		private TaskAwaiter<Class723> taskAwaiter_1;
	}

	// Token: 0x02000157 RID: 343
	[StructLayout(LayoutKind.Auto)]
	private struct Struct64 : IAsyncStateMachine
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x00045720 File Offset: 0x00043920
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
				@class.method_64(stream_, ";7![;Za-jP", array);
			}
			finally
			{
				this = (Class492.Struct64)array[0];
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00008048 File Offset: 0x00006248
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00008056 File Offset: 0x00006256
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class492.Struct64 struct64_0)
		{
			struct64_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class492.Struct64>(ref taskAwaiter_1, ref struct64_0);
		}

		// Token: 0x04000698 RID: 1688
		public int int_0;

		// Token: 0x04000699 RID: 1689
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400069A RID: 1690
		public Class492 class492_0;

		// Token: 0x0400069B RID: 1691
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000158 RID: 344
	[StructLayout(LayoutKind.Auto)]
	private struct Struct65 : IAsyncStateMachine
	{
		// Token: 0x060009E4 RID: 2532 RVA: 0x00045788 File Offset: 0x00043988
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
				@class.method_64(stream_, "NjH.#Za-jl", array);
			}
			finally
			{
				this = (Class492.Struct65)array[0];
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00008065 File Offset: 0x00006265
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00008073 File Offset: 0x00006273
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class492.Struct65 struct65_0)
		{
			struct65_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class492.Struct65>(ref taskAwaiter_1, ref struct65_0);
		}

		// Token: 0x0400069C RID: 1692
		public int int_0;

		// Token: 0x0400069D RID: 1693
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400069E RID: 1694
		public Class492 class492_0;

		// Token: 0x0400069F RID: 1695
		private TaskAwaiter taskAwaiter_0;
	}
}
