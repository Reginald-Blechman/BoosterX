using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media;

// Token: 0x020002BF RID: 703
internal sealed class Class505 : GClass162
{
	// Token: 0x060012BB RID: 4795 RVA: 0x0000D59D File Offset: 0x0000B79D
	public Class505(Class515 class515_1)
	{
		Class505.smethod_0(ref this.observableCollection_0, ref this.bool_2, ref this.string_5, ref this.solidColorBrush_0);
		base..ctor();
		this.method_17(class515_1);
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x0000D5C9 File Offset: 0x0000B7C9
	private Class801 method_2()
	{
		return this.class801_0;
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x0000D5D1 File Offset: 0x0000B7D1
	private void method_3(Class801 class801_1)
	{
		this.class801_0 = class801_1;
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0005FA9C File Offset: 0x0005DC9C
	private void method_4(object sender, NotifyCollectionChangedEventArgs e)
	{
		object[] object_ = new object[]
		{
			this,
			sender,
			e
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "rjK5AZa-i@", object_);
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x060012BF RID: 4799 RVA: 0x0000D5DA File Offset: 0x0000B7DA
	// (set) Token: 0x060012C0 RID: 4800 RVA: 0x0000D5E2 File Offset: 0x0000B7E2
	public ObservableCollection<Class517> AffinityModel
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("AffinityModel");
		}
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x0000D5F7 File Offset: 0x0000B7F7
	private string method_5()
	{
		return this.string_0;
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x0000D5FF File Offset: 0x0000B7FF
	private void method_6(string string_6)
	{
		this.string_0 = string_6;
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0000D608 File Offset: 0x0000B808
	// (set) Token: 0x060012C4 RID: 4804 RVA: 0x0000D610 File Offset: 0x0000B810
	public string Name
	{
		get
		{
			return this.method_5();
		}
		set
		{
			this.method_6(value);
			base.method_0("Name");
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0000D625 File Offset: 0x0000B825
	// (set) Token: 0x060012C6 RID: 4806 RVA: 0x0000D62D File Offset: 0x0000B82D
	public string DeviceTypeName
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

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0000D636 File Offset: 0x0000B836
	// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0000D63E File Offset: 0x0000B83E
	public DrawingImage Icon
	{
		[CompilerGenerated]
		get
		{
			return this.drawingImage_0;
		}
		[CompilerGenerated]
		set
		{
			this.drawingImage_0 = value;
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0000D647 File Offset: 0x0000B847
	// (set) Token: 0x060012CA RID: 4810 RVA: 0x0000D64F File Offset: 0x0000B84F
	public string Path
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

	// Token: 0x060012CB RID: 4811 RVA: 0x0000D658 File Offset: 0x0000B858
	private bool method_7()
	{
		return this.bool_0;
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x0000D660 File Offset: 0x0000B860
	private void method_8(bool bool_4)
	{
		this.bool_0 = bool_4;
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x060012CD RID: 4813 RVA: 0x0000D669 File Offset: 0x0000B869
	// (set) Token: 0x060012CE RID: 4814 RVA: 0x0000D671 File Offset: 0x0000B871
	public bool IsChecked
	{
		get
		{
			return this.method_7();
		}
		set
		{
			this.method_8(value);
			if (this.method_7() && this.class515_0 != null)
			{
				this.class515_0.ChoosenDevThreads = this.AffinityModel;
			}
			base.method_0("IsChecked");
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x060012CF RID: 4815 RVA: 0x0000D6A7 File Offset: 0x0000B8A7
	// (set) Token: 0x060012D0 RID: 4816 RVA: 0x0000D6AF File Offset: 0x0000B8AF
	public string Affinity
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

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
	// (set) Token: 0x060012D2 RID: 4818 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
	public string _NewAffinity
	{
		[CompilerGenerated]
		get
		{
			return this.string_4;
		}
		[CompilerGenerated]
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0000D6C9 File Offset: 0x0000B8C9
	// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0000D6D1 File Offset: 0x0000B8D1
	public string NewAffinity
	{
		get
		{
			return this._NewAffinity;
		}
		set
		{
			if (this.Affinity == null)
			{
				this.Affinity = value;
			}
			this._NewAffinity = value;
			this.method_10();
			base.method_0("NewAffinity");
			base.method_0("HasChanges");
			this.method_9();
		}
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x0005FAD4 File Offset: 0x0005DCD4
	private void method_9()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "XL>ODZa-iA", object_);
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x0005FB04 File Offset: 0x0005DD04
	public void method_10()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "d^HQjZa-i,", object_);
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0005FB34 File Offset: 0x0005DD34
	public void method_11()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), ".(6OjZa-i0", object_);
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0005FB64 File Offset: 0x0005DD64
	public void method_12()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "hmTr\"Za-i2", object_);
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0000D70D File Offset: 0x0000B90D
	public bool HasChanges
	{
		get
		{
			return this._NewAffinity != this.Affinity;
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x060012DA RID: 4826 RVA: 0x0005FB94 File Offset: 0x0005DD94
	internal bool Boolean_0
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "+L\\\\bZa-i@", object_);
		}
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0005FBCC File Offset: 0x0005DDCC
	private void method_13()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "iO?5%Za-j@", object_);
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0005FBFC File Offset: 0x0005DDFC
	private void method_14()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "[(!HMZa-jA", object_);
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x060012DD RID: 4829 RVA: 0x0000D720 File Offset: 0x0000B920
	// (set) Token: 0x060012DE RID: 4830 RVA: 0x0000D728 File Offset: 0x0000B928
	public string StatusText
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x060012DF RID: 4831 RVA: 0x0000D73D File Offset: 0x0000B93D
	// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0000D745 File Offset: 0x0000B945
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

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0000D75A File Offset: 0x0000B95A
	// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0000D762 File Offset: 0x0000B962
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

	// Token: 0x060012E3 RID: 4835 RVA: 0x0005FC2C File Offset: 0x0005DE2C
	private void method_15(string string_6, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_6,
			solidColorBrush_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "&%AsRZa-jC", object_);
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0005FC64 File Offset: 0x0005DE64
	private Class801 method_16()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class801)Class392.smethod_3().method_105(Class392.smethod_1(), "agSUaZa-i?", object_);
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0005FC98 File Offset: 0x0005DE98
	private static void smethod_0(ref ObservableCollection<Class517> observableCollection_1, ref bool bool_4, ref string string_6, ref SolidColorBrush solidColorBrush_1)
	{
		object[] array = new object[]
		{
			observableCollection_1,
			bool_4,
			string_6,
			solidColorBrush_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "6+42.Za-i:", array);
		}
		finally
		{
			observableCollection_1 = (ObservableCollection<Class517>)array[0];
			bool_4 = (bool)array[1];
			string_6 = (string)array[2];
			solidColorBrush_1 = (SolidColorBrush)array[3];
		}
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0005FD50 File Offset: 0x0005DF50
	private void method_17(Class515 class515_1)
	{
		object[] object_ = new object[]
		{
			this,
			class515_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Dmm'\\Za-i>", object_);
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0000D777 File Offset: 0x0000B977
	private static void smethod_1(ref Class505.Struct154 struct154_0)
	{
		struct154_0.asyncVoidMethodBuilder_0.Start<Class505.Struct154>(ref struct154_0);
	}

	// Token: 0x04000BB7 RID: 2999
	private Class515 class515_0;

	// Token: 0x04000BB8 RID: 3000
	private Class801 class801_0;

	// Token: 0x04000BB9 RID: 3001
	private ObservableCollection<Class517> observableCollection_0;

	// Token: 0x04000BBA RID: 3002
	private string string_0;

	// Token: 0x04000BBB RID: 3003
	private string string_1;

	// Token: 0x04000BBC RID: 3004
	private DrawingImage drawingImage_0;

	// Token: 0x04000BBD RID: 3005
	private string string_2;

	// Token: 0x04000BBE RID: 3006
	private bool bool_0;

	// Token: 0x04000BBF RID: 3007
	private string string_3;

	// Token: 0x04000BC0 RID: 3008
	private string string_4;

	// Token: 0x04000BC1 RID: 3009
	public bool bool_1;

	// Token: 0x04000BC2 RID: 3010
	private bool bool_2;

	// Token: 0x04000BC3 RID: 3011
	public bool bool_3;

	// Token: 0x04000BC4 RID: 3012
	private string string_5;

	// Token: 0x04000BC5 RID: 3013
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04000BC6 RID: 3014
	private double double_0;

	// Token: 0x020002C0 RID: 704
	private sealed class Class332
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x0005FD84 File Offset: 0x0005DF84
		internal void method_0()
		{
			Collection<Class517> affinityModel = this.class333_0.class505_0.AffinityModel;
			Class517 @class = new Class517(this.class333_0.class505_0);
			@class.Core = this.class552_0.Core;
			IEnumerable<string> string_ = this.class333_0.string_0;
			Func<string, bool> predicate;
			if ((predicate = this.func_0) == null)
			{
				predicate = (this.func_0 = new Func<string, bool>(this.method_1));
			}
			@class.IsChosen = string_.Any(predicate);
			@class.Thread = this.class552_0.Thread;
			@class.IsECore = this.class552_0.IsECore;
			@class.ShowCoreType = this.class333_0.bool_0;
			affinityModel.Add(@class);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005FE30 File Offset: 0x0005E030
		internal bool method_1(string string_0)
		{
			return string_0 == this.class552_0.Thread.ToString();
		}

		// Token: 0x04000BC7 RID: 3015
		public Class552 class552_0;

		// Token: 0x04000BC8 RID: 3016
		public Class505.Class333 class333_0;

		// Token: 0x04000BC9 RID: 3017
		public Func<string, bool> func_0;
	}

	// Token: 0x020002C1 RID: 705
	private sealed class Class333
	{
		// Token: 0x060012EC RID: 4844 RVA: 0x0000D785 File Offset: 0x0000B985
		internal void method_0()
		{
			this.class505_0.AffinityModel.Clear();
		}

		// Token: 0x04000BCA RID: 3018
		public Class505 class505_0;

		// Token: 0x04000BCB RID: 3019
		public string[] string_0;

		// Token: 0x04000BCC RID: 3020
		public bool bool_0;
	}

	// Token: 0x020002C2 RID: 706
	[StructLayout(LayoutKind.Auto)]
	private struct Struct154 : IAsyncStateMachine
	{
		// Token: 0x060012ED RID: 4845 RVA: 0x0005FE58 File Offset: 0x0005E058
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
				@class.method_64(stream_, "%_&jQZa-jG", array);
			}
			finally
			{
				this = (Class505.Struct154)array[0];
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0000D797 File Offset: 0x0000B997
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0000D7A5 File Offset: 0x0000B9A5
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class505.Struct154 struct154_0)
		{
			struct154_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class505.Struct154>(ref taskAwaiter_1, ref struct154_0);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0000D7A5 File Offset: 0x0000B9A5
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class505.Struct154 struct154_0)
		{
			struct154_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class505.Struct154>(ref taskAwaiter_1, ref struct154_0);
		}

		// Token: 0x04000BCD RID: 3021
		public int int_0;

		// Token: 0x04000BCE RID: 3022
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000BCF RID: 3023
		public Class505 class505_0;

		// Token: 0x04000BD0 RID: 3024
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000BD1 RID: 3025
		public string string_0;

		// Token: 0x04000BD2 RID: 3026
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020002C3 RID: 707
	[Serializable]
	private sealed class Class334
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0000B1A1 File Offset: 0x000093A1
		internal bool method_0(Class552 class552_0)
		{
			return class552_0.IsECore;
		}

		// Token: 0x04000BD3 RID: 3027
		public static readonly Class505.Class334 class334_0 = new Class505.Class334();

		// Token: 0x04000BD4 RID: 3028
		public static Func<Class552, bool> func_0;
	}
}
