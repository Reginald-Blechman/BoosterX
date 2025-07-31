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
using WinCopies.Util;

// Token: 0x020000ED RID: 237
internal sealed class Class148
{
	// Token: 0x0600071A RID: 1818 RVA: 0x00006611 File Offset: 0x00004811
	// Note: this type is marked as 'beforefieldinit'.
	static Class148()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "^pUSWZa-j3", null);
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x0003E08C File Offset: 0x0003C28C
	public static void smethod_0(Class148.Delegate23 delegate23_1)
	{
		Class148.Delegate23 @delegate = Class148.delegate23_0;
		Class148.Delegate23 delegate2;
		do
		{
			delegate2 = @delegate;
			Class148.Delegate23 value = (Class148.Delegate23)Delegate.Combine(delegate2, delegate23_1);
			@delegate = Interlocked.CompareExchange<Class148.Delegate23>(ref Class148.delegate23_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x0003E0C0 File Offset: 0x0003C2C0
	public static void smethod_1(Class148.Delegate23 delegate23_1)
	{
		Class148.Delegate23 @delegate = Class148.delegate23_0;
		Class148.Delegate23 delegate2;
		do
		{
			delegate2 = @delegate;
			Class148.Delegate23 value = (Class148.Delegate23)Delegate.Remove(delegate2, delegate23_1);
			@delegate = Interlocked.CompareExchange<Class148.Delegate23>(ref Class148.delegate23_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x0003E0F4 File Offset: 0x0003C2F4
	public static Task<ObservableCollection<Class512>> smethod_2(Type type_0, bool bool_0)
	{
		object[] object_ = new object[]
		{
			type_0,
			bool_0
		};
		return (Task<ObservableCollection<Class512>>)Class392.smethod_3().method_105(Class392.smethod_1(), "9XV:8Za-j=", object_);
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00006628 File Offset: 0x00004828
	public static Task smethod_3()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "EOE3]Za-j,", null);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x0003E130 File Offset: 0x0003C330
	public static int smethod_4(Type type_0)
	{
		object[] object_ = new object[]
		{
			type_0
		};
		return (int)Class392.smethod_3().method_105(Class392.smethod_1(), "+LSVaZa-ij", object_);
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x0003E168 File Offset: 0x0003C368
	public static List<string> smethod_5(Type type_0)
	{
		object[] object_ = new object[]
		{
			type_0
		};
		return (List<string>)Class392.smethod_3().method_105(Class392.smethod_1(), "9=;17Za-ik", object_);
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00006644 File Offset: 0x00004844
	public static Task smethod_6()
	{
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "?a[;KZa-if", null);
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x0003E19C File Offset: 0x0003C39C
	public static Task<Class512> smethod_7(string string_0)
	{
		object[] object_ = new object[]
		{
			string_0
		};
		return (Task<Class512>)Class392.smethod_3().method_105(Class392.smethod_1(), "e?u]kZa-io", object_);
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00006660 File Offset: 0x00004860
	public static Task<List<Class512>> smethod_8()
	{
		return (Task<List<Class512>>)Class392.smethod_3().method_105(Class392.smethod_1(), "agJO`Za-i@", null);
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x0000667C File Offset: 0x0000487C
	public static void smethod_9()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "k-_V(Za-j9", null);
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00006693 File Offset: 0x00004893
	public static Task<bool> smethod_10()
	{
		return (Task<bool>)Class392.smethod_3().method_105(Class392.smethod_1(), "(q$cYZa-i&", null);
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x0003E1D0 File Offset: 0x0003C3D0
	public static Task smethod_11(Type type_0)
	{
		object[] object_ = new object[]
		{
			type_0
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "ijH2$Za-i*", object_);
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x0003E204 File Offset: 0x0003C404
	public static Task smethod_12(Type type_0)
	{
		object[] object_ = new object[]
		{
			type_0
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "O1)I'Za-j4", object_);
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x0003E238 File Offset: 0x0003C438
	public static Task smethod_13(Type type_0)
	{
		object[] object_ = new object[]
		{
			type_0
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "mC'F0Za-j:", object_);
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x000066AF File Offset: 0x000048AF
	public static Task<List<Class265>> smethod_14()
	{
		return (Task<List<Class265>>)Class392.smethod_3().method_105(Class392.smethod_1(), "#.CqHZa-j\"", null);
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x000066CB File Offset: 0x000048CB
	public static void smethod_15()
	{
		Class392.smethod_3().method_64(Class392.smethod_1(), "5IIo+Za-j;", null);
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000066E2 File Offset: 0x000048E2
	private static void smethod_16(ref Class148.Struct32 struct32_0)
	{
		struct32_0.asyncTaskMethodBuilder_0.Start<Class148.Struct32>(ref struct32_0);
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x000066F0 File Offset: 0x000048F0
	private static void smethod_17(ref Class148.Struct38 struct38_0)
	{
		struct38_0.asyncTaskMethodBuilder_0.Start<Class148.Struct38>(ref struct38_0);
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x000066FE File Offset: 0x000048FE
	private static void smethod_18(ref Class148.Struct40 struct40_0)
	{
		struct40_0.asyncTaskMethodBuilder_0.Start<Class148.Struct40>(ref struct40_0);
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x0000670C File Offset: 0x0000490C
	private static void smethod_19(ref Class148.Struct37 struct37_0)
	{
		struct37_0.asyncTaskMethodBuilder_0.Start<Class148.Struct37>(ref struct37_0);
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x0000671A File Offset: 0x0000491A
	private static void smethod_20(ref Class148.Struct34 struct34_0)
	{
		struct34_0.asyncTaskMethodBuilder_0.Start<Class148.Struct34>(ref struct34_0);
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00006728 File Offset: 0x00004928
	private static void smethod_21(ref Class148.Struct33 struct33_0)
	{
		struct33_0.asyncTaskMethodBuilder_0.Start<Class148.Struct33>(ref struct33_0);
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00006736 File Offset: 0x00004936
	private static void smethod_22(ref Class148.Struct35 struct35_0)
	{
		struct35_0.asyncTaskMethodBuilder_0.Start<Class148.Struct35>(ref struct35_0);
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00006744 File Offset: 0x00004944
	private static void smethod_23(ref Class148.Struct39 struct39_0)
	{
		struct39_0.asyncTaskMethodBuilder_0.Start<Class148.Struct39>(ref struct39_0);
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00006752 File Offset: 0x00004952
	private static void smethod_24(ref Class148.Struct36 struct36_0)
	{
		struct36_0.asyncTaskMethodBuilder_0.Start<Class148.Struct36>(ref struct36_0);
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00006760 File Offset: 0x00004960
	private static void smethod_25(ref Class148.Struct41 struct41_0)
	{
		struct41_0.asyncTaskMethodBuilder_0.Start<Class148.Struct41>(ref struct41_0);
	}

	// Token: 0x040003DF RID: 991
	private static readonly SemaphoreSlim semaphoreSlim_0;

	// Token: 0x040003E0 RID: 992
	private static Class148.Delegate23 delegate23_0;

	// Token: 0x040003E1 RID: 993
	private static readonly GClass46 gclass46_0;

	// Token: 0x040003E2 RID: 994
	public static readonly List<Class148.Class486> list_0;

	// Token: 0x040003E3 RID: 995
	public static readonly List<Class148.Class486> list_1;

	// Token: 0x020000EE RID: 238
	private sealed class Class149
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x0000676E File Offset: 0x0000496E
		internal bool method_0(Class148.Class486 class486_0)
		{
			return class486_0.Type == this.type_0;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00006781 File Offset: 0x00004981
		internal Class512 method_1(Class466 class466_0)
		{
			return new Class512(class466_0, this.type_0, false);
		}

		// Token: 0x040003E4 RID: 996
		public Type type_0;
	}

	// Token: 0x020000EF RID: 239
	private sealed class Class150
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x00006790 File Offset: 0x00004990
		internal bool method_0(Class148.Class486 class486_0)
		{
			return class486_0.Type == this.type_0;
		}

		// Token: 0x040003E5 RID: 997
		public Type type_0;
	}

	// Token: 0x020000F0 RID: 240
	[StructLayout(LayoutKind.Auto)]
	private struct Struct32 : IAsyncStateMachine
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x0003E26C File Offset: 0x0003C46C
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
				@class.method_64(stream_, "\\@/fPZa-j6", array);
			}
			finally
			{
				this = (Class148.Struct32)array[0];
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000067A3 File Offset: 0x000049A3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000067B1 File Offset: 0x000049B1
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_1, ref Class148.Struct32 struct32_0)
		{
			struct32_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class148.Struct32>(ref taskAwaiter_1, ref struct32_0);
		}

		// Token: 0x040003E6 RID: 998
		public int int_0;

		// Token: 0x040003E7 RID: 999
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040003E8 RID: 1000
		public Type type_0;

		// Token: 0x040003E9 RID: 1001
		private Class148.Class486 class486_0;

		// Token: 0x040003EA RID: 1002
		private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
	}

	// Token: 0x020000F1 RID: 241
	private sealed class Class151
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x000067C0 File Offset: 0x000049C0
		internal bool method_0(Class512 class512_0)
		{
			return class512_0.method_7() == this.string_0;
		}

		// Token: 0x040003EB RID: 1003
		public string string_0;
	}

	// Token: 0x020000F2 RID: 242
	[StructLayout(LayoutKind.Auto)]
	private struct Struct33 : IAsyncStateMachine
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x0003E2D4 File Offset: 0x0003C4D4
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
				@class.method_64(stream_, ";RNp>Za-ig", array);
			}
			finally
			{
				this = (Class148.Struct33)array[0];
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000067D3 File Offset: 0x000049D3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000067E1 File Offset: 0x000049E1
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_1, ref Class148.Struct33 struct33_0)
		{
			struct33_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>[]>, Class148.Struct33>(ref taskAwaiter_1, ref struct33_0);
		}

		// Token: 0x040003EC RID: 1004
		public int int_0;

		// Token: 0x040003ED RID: 1005
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040003EE RID: 1006
		private TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_0;
	}

	// Token: 0x020000F3 RID: 243
	[StructLayout(LayoutKind.Auto)]
	private struct Struct34 : IAsyncStateMachine
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x0003E33C File Offset: 0x0003C53C
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
				@class.method_64(stream_, "\\$`WNZa-j.", array);
			}
			finally
			{
				this = (Class148.Struct34)array[0];
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000067F0 File Offset: 0x000049F0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000067FE File Offset: 0x000049FE
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_1, ref Class148.Struct34 struct34_0)
		{
			struct34_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class148.Struct34>(ref taskAwaiter_1, ref struct34_0);
		}

		// Token: 0x040003EF RID: 1007
		public int int_0;

		// Token: 0x040003F0 RID: 1008
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040003F1 RID: 1009
		private IEnumerator<Class148.Class486> ienumerator_0;

		// Token: 0x040003F2 RID: 1010
		private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
	}

	// Token: 0x020000F4 RID: 244
	[StructLayout(LayoutKind.Auto)]
	private struct Struct35 : IAsyncStateMachine
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x0003E3A4 File Offset: 0x0003C5A4
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
				@class.method_64(stream_, "'=G6TZa-is", array);
			}
			finally
			{
				this = (Class148.Struct35)array[0];
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0000680D File Offset: 0x00004A0D
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0000681B File Offset: 0x00004A1B
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_2, ref Class148.Struct35 struct35_0)
		{
			struct35_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>[]>, Class148.Struct35>(ref taskAwaiter_2, ref struct35_0);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0000682A File Offset: 0x00004A2A
		private static void MoveNext_1(ref TaskAwaiter<bool> taskAwaiter_2, ref Class148.Struct35 struct35_0)
		{
			struct35_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class148.Struct35>(ref taskAwaiter_2, ref struct35_0);
		}

		// Token: 0x040003F3 RID: 1011
		public int int_0;

		// Token: 0x040003F4 RID: 1012
		public AsyncTaskMethodBuilder<Class512> asyncTaskMethodBuilder_0;

		// Token: 0x040003F5 RID: 1013
		public string string_0;

		// Token: 0x040003F6 RID: 1014
		private Class148.Class151 class151_0;

		// Token: 0x040003F7 RID: 1015
		private TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_0;

		// Token: 0x040003F8 RID: 1016
		private TaskAwaiter<bool> taskAwaiter_1;
	}

	// Token: 0x020000F5 RID: 245
	[StructLayout(LayoutKind.Auto)]
	private struct Struct36 : IAsyncStateMachine
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x0003E40C File Offset: 0x0003C60C
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
				@class.method_64(stream_, "?a[;KZa-i'", array);
			}
			finally
			{
				this = (Class148.Struct36)array[0];
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00006839 File Offset: 0x00004A39
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00006847 File Offset: 0x00004A47
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class148.Struct36 struct36_0)
		{
			struct36_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class148.Struct36>(ref taskAwaiter_1, ref struct36_0);
		}

		// Token: 0x040003F9 RID: 1017
		public int int_0;

		// Token: 0x040003FA RID: 1018
		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		// Token: 0x040003FB RID: 1019
		private int int_1;

		// Token: 0x040003FC RID: 1020
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F6 RID: 246
	[StructLayout(LayoutKind.Auto)]
	private struct Struct37 : IAsyncStateMachine
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x0003E474 File Offset: 0x0003C674
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
				@class.method_64(stream_, "5..f*Za-j&", array);
			}
			finally
			{
				this = (Class148.Struct37)array[0];
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00006856 File Offset: 0x00004A56
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00006864 File Offset: 0x00004A64
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class148.Struct37 struct37_0)
		{
			struct37_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class148.Struct37>(ref taskAwaiter_1, ref struct37_0);
		}

		// Token: 0x040003FD RID: 1021
		public int int_0;

		// Token: 0x040003FE RID: 1022
		public AsyncTaskMethodBuilder<ObservableCollection<Class512>> asyncTaskMethodBuilder_0;

		// Token: 0x040003FF RID: 1023
		public Type type_0;

		// Token: 0x04000400 RID: 1024
		private Class148.Class149 class149_0;

		// Token: 0x04000401 RID: 1025
		public bool bool_0;

		// Token: 0x04000402 RID: 1026
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020000F7 RID: 247
	[StructLayout(LayoutKind.Auto)]
	private struct Struct38 : IAsyncStateMachine
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x0003E4DC File Offset: 0x0003C6DC
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
				@class.method_64(stream_, "QF=3.Za-j<", array);
			}
			finally
			{
				this = (Class148.Struct38)array[0];
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00006873 File Offset: 0x00004A73
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00006881 File Offset: 0x00004A81
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_1, ref Class148.Struct38 struct38_0)
		{
			struct38_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class148.Struct38>(ref taskAwaiter_1, ref struct38_0);
		}

		// Token: 0x04000403 RID: 1027
		public int int_0;

		// Token: 0x04000404 RID: 1028
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000405 RID: 1029
		public Type type_0;

		// Token: 0x04000406 RID: 1030
		private Class148.Class486 class486_0;

		// Token: 0x04000407 RID: 1031
		private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
	}

	// Token: 0x020000F8 RID: 248
	private sealed class Class152
	{
		// Token: 0x06000753 RID: 1875 RVA: 0x00006890 File Offset: 0x00004A90
		internal bool method_0(Class148.Class486 class486_0)
		{
			return class486_0.Type == this.type_0;
		}

		// Token: 0x04000408 RID: 1032
		public Type type_0;
	}

	// Token: 0x020000F9 RID: 249
	private sealed class Class153
	{
		// Token: 0x06000755 RID: 1877 RVA: 0x000068A3 File Offset: 0x00004AA3
		internal bool method_0(Class148.Class486 class486_0)
		{
			return class486_0.Type == this.type_0;
		}

		// Token: 0x04000409 RID: 1033
		public Type type_0;
	}

	// Token: 0x020000FA RID: 250
	[StructLayout(LayoutKind.Auto)]
	private struct Struct39 : IAsyncStateMachine
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x0003E544 File Offset: 0x0003C744
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
				@class.method_64(stream_, "kd@h*Za-iB", array);
			}
			finally
			{
				this = (Class148.Struct39)array[0];
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000068B6 File Offset: 0x00004AB6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000068C4 File Offset: 0x00004AC4
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_2, ref Class148.Struct39 struct39_0)
		{
			struct39_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>[]>, Class148.Struct39>(ref taskAwaiter_2, ref struct39_0);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000068D3 File Offset: 0x00004AD3
		private static void MoveNext_1(ref TaskAwaiter<bool> taskAwaiter_2, ref Class148.Struct39 struct39_0)
		{
			struct39_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, Class148.Struct39>(ref taskAwaiter_2, ref struct39_0);
		}

		// Token: 0x0400040A RID: 1034
		public int int_0;

		// Token: 0x0400040B RID: 1035
		public AsyncTaskMethodBuilder<List<Class512>> asyncTaskMethodBuilder_0;

		// Token: 0x0400040C RID: 1036
		private TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_0;

		// Token: 0x0400040D RID: 1037
		private TaskAwaiter<bool> taskAwaiter_1;
	}

	// Token: 0x020000FB RID: 251
	[StructLayout(LayoutKind.Auto)]
	private struct Struct40 : IAsyncStateMachine
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x0003E5AC File Offset: 0x0003C7AC
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
				@class.method_64(stream_, "S[Pr5Za-j.", array);
			}
			finally
			{
				this = (Class148.Struct40)array[0];
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000068E2 File Offset: 0x00004AE2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000068F0 File Offset: 0x00004AF0
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_1, ref Class148.Struct40 struct40_0)
		{
			struct40_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>[]>, Class148.Struct40>(ref taskAwaiter_1, ref struct40_0);
		}

		// Token: 0x0400040E RID: 1038
		public int int_0;

		// Token: 0x0400040F RID: 1039
		public AsyncTaskMethodBuilder<List<Class265>> asyncTaskMethodBuilder_0;

		// Token: 0x04000410 RID: 1040
		private List<Class265> list_0;

		// Token: 0x04000411 RID: 1041
		private TaskAwaiter<ObservableCollection<Class512>[]> taskAwaiter_0;
	}

	// Token: 0x020000FC RID: 252
	// (Invoke) Token: 0x0600075E RID: 1886
	public delegate void Delegate23();

	// Token: 0x020000FD RID: 253
	[StructLayout(LayoutKind.Auto)]
	private struct Struct41 : IAsyncStateMachine
	{
		// Token: 0x06000761 RID: 1889 RVA: 0x0003E614 File Offset: 0x0003C814
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
				@class.method_64(stream_, "Njc@&Za-j/", array);
			}
			finally
			{
				this = (Class148.Struct41)array[0];
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000068FF File Offset: 0x00004AFF
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000690D File Offset: 0x00004B0D
		private static void MoveNext(ref TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_1, ref Class148.Struct41 struct41_0)
		{
			struct41_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ObservableCollection<Class512>>, Class148.Struct41>(ref taskAwaiter_1, ref struct41_0);
		}

		// Token: 0x04000412 RID: 1042
		public int int_0;

		// Token: 0x04000413 RID: 1043
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000414 RID: 1044
		public Type type_0;

		// Token: 0x04000415 RID: 1045
		private Class148.Class486 class486_0;

		// Token: 0x04000416 RID: 1046
		private TaskAwaiter<ObservableCollection<Class512>> taskAwaiter_0;
	}

	// Token: 0x020000FE RID: 254
	public sealed class Class486 : GClass162
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x0003E67C File Offset: 0x0003C87C
		public Class486(Type type_1, string string_1)
		{
			this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
			this.Type = type_1;
			this.JsonPath = string_1;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000691C File Offset: 0x00004B1C
		private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			base.method_0("DataContext");
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0000692A File Offset: 0x00004B2A
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00006932 File Offset: 0x00004B32
		public ObservableCollection<Class512> DataContext
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				base.method_1<ObservableCollection<Class512>>(ref this.observableCollection_0, value, "DataContext", null);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00006949 File Offset: 0x00004B49
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00006951 File Offset: 0x00004B51
		public Type Type
		{
			[CompilerGenerated]
			get
			{
				return this.type_0;
			}
			[CompilerGenerated]
			set
			{
				this.type_0 = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0000695A File Offset: 0x00004B5A
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00006962 File Offset: 0x00004B62
		public string JsonPath
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0000696B File Offset: 0x00004B6B
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00006973 File Offset: 0x00004B73
		public bool DataContextReady
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0000697C File Offset: 0x00004B7C
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00006984 File Offset: 0x00004B84
		public List<string> Settings
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

		// Token: 0x04000417 RID: 1047
		private ObservableCollection<Class512> observableCollection_0 = new ObservableCollection<Class512>();

		// Token: 0x04000418 RID: 1048
		private Type type_0;

		// Token: 0x04000419 RID: 1049
		private string string_0;

		// Token: 0x0400041A RID: 1050
		private bool bool_0;

		// Token: 0x0400041B RID: 1051
		private List<string> list_0 = new List<string>();
	}

	// Token: 0x020000FF RID: 255
	private sealed class Class154
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x0000698D File Offset: 0x00004B8D
		internal bool method_0(Class148.Class486 class486_0)
		{
			return class486_0.Type == this.type_0;
		}

		// Token: 0x0400041C RID: 1052
		public Type type_0;
	}

	// Token: 0x02000100 RID: 256
	private sealed class Class155
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x0003E6CC File Offset: 0x0003C8CC
		internal void method_0()
		{
			this.class486_0.Settings.Clear();
			this.class486_0.Settings.AddRange(this.list_0);
			this.class486_0.DataContext.Clear();
			ICollection<Class512> dataContext = this.class486_0.DataContext;
			IEnumerable<Class512> enumerable = this.list_1;
			Extensions.AddRange<Class512>(dataContext, ref enumerable);
		}

		// Token: 0x0400041D RID: 1053
		public Class148.Class486 class486_0;

		// Token: 0x0400041E RID: 1054
		public List<string> list_0;

		// Token: 0x0400041F RID: 1055
		public List<Class512> list_1;
	}

	// Token: 0x02000101 RID: 257
	private sealed class Class156
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x000069A0 File Offset: 0x00004BA0
		internal bool method_0(Class148.Class486 class486_0)
		{
			return class486_0.Type == this.type_0;
		}

		// Token: 0x04000420 RID: 1056
		public Type type_0;
	}

	// Token: 0x02000102 RID: 258
	[Serializable]
	private sealed class Class157
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x000069BF File Offset: 0x00004BBF
		internal bool method_0(Class466 class466_0)
		{
			return Class673.smethod_0(class466_0);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000069C7 File Offset: 0x00004BC7
		internal string method_1(Class512 class512_0)
		{
			return Class298.smethod_2(class512_0.method_7());
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000069D4 File Offset: 0x00004BD4
		internal bool method_2(Class148.Class486 class486_0)
		{
			return class486_0.DataContext.Count > 0;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000069E4 File Offset: 0x00004BE4
		internal Task<ObservableCollection<Class512>> method_3(Class148.Class486 class486_0)
		{
			return Class148.smethod_2(class486_0.Type, true);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000069F2 File Offset: 0x00004BF2
		internal Task<ObservableCollection<Class512>> method_4(Class148.Class486 class486_0)
		{
			return Class148.smethod_2(class486_0.Type, false);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00006A00 File Offset: 0x00004C00
		internal IEnumerable<Class512> method_5(Class148.Class486 class486_0)
		{
			return class486_0.DataContext;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000069F2 File Offset: 0x00004BF2
		internal Task<ObservableCollection<Class512>> method_6(Class148.Class486 class486_0)
		{
			return Class148.smethod_2(class486_0.Type, false);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00006A00 File Offset: 0x00004C00
		internal IEnumerable<Class512> method_7(Class148.Class486 class486_0)
		{
			return class486_0.DataContext;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00006A08 File Offset: 0x00004C08
		internal bool method_8(Class148.Class486 class486_0)
		{
			return class486_0.DataContextReady;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00006A10 File Offset: 0x00004C10
		internal bool method_9(Class148.Class486 class486_0)
		{
			if (class486_0.DataContextReady)
			{
				return class486_0.DataContext.Any(new Func<Class512, bool>(Class148.Class157.class157_0.method_10));
			}
			return true;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00006A46 File Offset: 0x00004C46
		internal bool method_10(Class512 class512_0)
		{
			return !class512_0.bool_2;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000069F2 File Offset: 0x00004BF2
		internal Task<ObservableCollection<Class512>> method_11(Class148.Class486 class486_0)
		{
			return Class148.smethod_2(class486_0.Type, false);
		}

		// Token: 0x04000421 RID: 1057
		public static readonly Class148.Class157 class157_0 = new Class148.Class157();

		// Token: 0x04000422 RID: 1058
		public static Func<Class466, bool> func_0;

		// Token: 0x04000423 RID: 1059
		public static Func<Class512, string> func_1;

		// Token: 0x04000424 RID: 1060
		public static Func<Class148.Class486, bool> func_2;

		// Token: 0x04000425 RID: 1061
		public static Func<Class148.Class486, Task<ObservableCollection<Class512>>> func_3;

		// Token: 0x04000426 RID: 1062
		public static Func<Class148.Class486, Task<ObservableCollection<Class512>>> func_4;

		// Token: 0x04000427 RID: 1063
		public static Func<Class148.Class486, IEnumerable<Class512>> func_5;

		// Token: 0x04000428 RID: 1064
		public static Func<Class148.Class486, Task<ObservableCollection<Class512>>> func_6;

		// Token: 0x04000429 RID: 1065
		public static Func<Class148.Class486, IEnumerable<Class512>> func_7;

		// Token: 0x0400042A RID: 1066
		public static Func<Class148.Class486, bool> func_8;

		// Token: 0x0400042B RID: 1067
		public static Func<Class512, bool> func_9;

		// Token: 0x0400042C RID: 1068
		public static Func<Class148.Class486, bool> func_10;

		// Token: 0x0400042D RID: 1069
		public static Func<Class148.Class486, Task<ObservableCollection<Class512>>> func_11;
	}
}
