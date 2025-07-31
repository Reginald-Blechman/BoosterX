using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Linearstar.Windows.RawInput.Native;
using Newtonsoft.Json;
using ns0;
using PIManagerX;

// Token: 0x02000657 RID: 1623
internal sealed class Class529 : GClass162
{
	// Token: 0x0600290B RID: 10507 RVA: 0x0009FA2C File Offset: 0x0009DC2C
	public Class529(dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_1, Class522 class522_1, Class669 class669_0 = null, string string_3 = "")
	{
		Class529.Class774 @class = new Class529.Class774();
		@class.class669_0 = class669_0;
		base..ctor();
		this.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0 = dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_1;
		this.class522_0 = class522_1;
		if (!string_3.smethod_9())
		{
			this.Name = string_3;
		}
		this.Values.CollectionChanged += this.method_4;
		if (@class.class669_0 != null)
		{
			this.Name = @class.class669_0.Name;
			if (this.TestingAreas.Any(new Func<Class398, bool>(@class.method_0)))
			{
				this.ChoosenArea = this.TestingAreas.First(new Func<Class398, bool>(@class.method_1));
			}
			else
			{
				this.ChoosenArea = this.TestingAreas[0];
			}
			this.SelectedClickCount = @class.class669_0.Int32_0;
			this.Date = @class.class669_0.DateTime_0;
			foreach (double item in @class.class669_0.Values)
			{
				this.Values.Add(item);
			}
		}
		base.method_0("Values");
		this.intptr_1 = PManagerX.GetWindowDC(this.intptr_0);
	}

	// Token: 0x0600290C RID: 10508 RVA: 0x0001AEBC File Offset: 0x000190BC
	private void method_2()
	{
		this.thread_0 = new Thread(new ThreadStart(this.method_17))
		{
			IsBackground = true,
			Priority = ThreadPriority.Highest
		};
	}

	// Token: 0x0600290D RID: 10509 RVA: 0x0009FC04 File Offset: 0x0009DE04
	private void method_3()
	{
		Class529.Struct441 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct441>(ref @struct);
	}

	// Token: 0x170006CD RID: 1741
	// (get) Token: 0x0600290E RID: 10510 RVA: 0x0009FC3C File Offset: 0x0009DE3C
	public List<Class398> TestingAreas
	{
		get
		{
			if (this.list_0 == null)
			{
				this.list_0 = new List<Class398>
				{
					new Class398
					{
						Name = "Auto",
						Icon = Class765.smethod_8()
					},
					new Class398
					{
						Name = "Click",
						Icon = Class765.smethod_8()
					}
				};
			}
			return this.list_0;
		}
	}

	// Token: 0x170006CE RID: 1742
	// (get) Token: 0x0600290F RID: 10511 RVA: 0x0001AEE3 File Offset: 0x000190E3
	// (set) Token: 0x06002910 RID: 10512 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
	public Class398 ChoosenArea
	{
		get
		{
			if (this.class398_0 == null)
			{
				this.class398_0 = this.TestingAreas[Convert.ToInt32(Class551.class753_0.method_22())];
			}
			return this.class398_0;
		}
		set
		{
			for (int i = 0; i < 3; i++)
			{
				if (this.TestingAreas[i] == value)
				{
					Class551.class753_0.method_23(new int?(i));
					IL_2F:
					this.class398_0 = value;
					base.method_0("ChoosenArea");
					return;
				}
			}
			goto IL_2F;
		}
	}

	// Token: 0x170006CF RID: 1743
	// (get) Token: 0x06002911 RID: 10513 RVA: 0x0001AF18 File Offset: 0x00019118
	// (set) Token: 0x06002912 RID: 10514 RVA: 0x0009FCF8 File Offset: 0x0009DEF8
	public bool IsChoosen
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (!value)
			{
				if (this.class522_0.Models.Where(new Func<Class529, bool>(Class529.Class776.class776_0.method_0)).Count<Class529>() > 1)
				{
					this.bool_0 = value;
					if (this.class522_0.byte_0 == 1)
					{
						this.class522_0.method_5(this);
					}
				}
			}
			if (value)
			{
				this.bool_0 = value;
				if (this.class522_0.byte_0 == 0)
				{
					foreach (Class529 @class in this.class522_0.Models)
					{
						if (@class != this)
						{
							@class.IsChoosen = false;
						}
					}
					this.class522_0.Choosen = this;
					this.method_3();
				}
				if (this.class522_0.byte_0 == 1)
				{
					this.class522_0.method_4(this);
				}
			}
			this.BorderOpacity = 0.6;
			base.method_0("IsChoosen");
			base.method_0("Values");
		}
	}

	// Token: 0x06002913 RID: 10515 RVA: 0x0009FE14 File Offset: 0x0009E014
	private void method_4(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("HasValues");
		base.method_0("AverageS");
		base.method_0("CountS");
		base.method_0("LastValueS");
		base.method_0("MinS");
		base.method_0("MaxS");
		base.method_0("StdDevS");
		base.method_0("StdDevS");
	}

	// Token: 0x170006D0 RID: 1744
	// (get) Token: 0x06002914 RID: 10516 RVA: 0x0001AF20 File Offset: 0x00019120
	// (set) Token: 0x06002915 RID: 10517 RVA: 0x0001AF28 File Offset: 0x00019128
	public string Name
	{
		get
		{
			return this.string_1;
		}
		set
		{
			if (this.string_0 == null)
			{
				this.string_0 = value;
			}
			this.string_1 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x170006D1 RID: 1745
	// (get) Token: 0x06002916 RID: 10518 RVA: 0x0001AF4C File Offset: 0x0001914C
	// (set) Token: 0x06002917 RID: 10519 RVA: 0x0001AF54 File Offset: 0x00019154
	public DateTime Date
	{
		[CompilerGenerated]
		get
		{
			return this.dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x170006D2 RID: 1746
	// (get) Token: 0x06002918 RID: 10520 RVA: 0x0009FE84 File Offset: 0x0009E084
	public string DateString
	{
		get
		{
			return this.Date.ToString("dd.MM.yyyy HH:mm");
		}
	}

	// Token: 0x170006D3 RID: 1747
	// (get) Token: 0x06002919 RID: 10521 RVA: 0x0001AF5D File Offset: 0x0001915D
	// (set) Token: 0x0600291A RID: 10522 RVA: 0x0001AF65 File Offset: 0x00019165
	public ObservableCollection<double> Values
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

	// Token: 0x170006D4 RID: 1748
	// (get) Token: 0x0600291B RID: 10523 RVA: 0x0001AF6E File Offset: 0x0001916E
	public bool HasValues
	{
		get
		{
			return this.Values.Count > 0;
		}
	}

	// Token: 0x170006D5 RID: 1749
	// (get) Token: 0x0600291C RID: 10524 RVA: 0x0009FEA8 File Offset: 0x0009E0A8
	public double Average
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Sum(new Func<double, double>(Class529.Class776.class776_0.method_1)) / (double)this.Values.Count<double>();
		}
	}

	// Token: 0x170006D6 RID: 1750
	// (get) Token: 0x0600291D RID: 10525 RVA: 0x0001AF7E File Offset: 0x0001917E
	public double LastValue
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Last<double>();
		}
	}

	// Token: 0x170006D7 RID: 1751
	// (get) Token: 0x0600291E RID: 10526 RVA: 0x0001AFA2 File Offset: 0x000191A2
	public double Min
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Min();
		}
	}

	// Token: 0x170006D8 RID: 1752
	// (get) Token: 0x0600291F RID: 10527 RVA: 0x0001AFC6 File Offset: 0x000191C6
	public double Max
	{
		get
		{
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			return this.Values.Max();
		}
	}

	// Token: 0x170006D9 RID: 1753
	// (get) Token: 0x06002920 RID: 10528 RVA: 0x0009FF04 File Offset: 0x0009E104
	public double StdDev
	{
		get
		{
			Class529.Class773 @class = new Class529.Class773();
			if (this.Values.Count<double>() == 0)
			{
				return 0.0;
			}
			@class.double_0 = this.Values.Average();
			return Math.Sqrt(this.Values.Sum(new Func<double, double>(@class.method_0)) / (double)this.Values.Count);
		}
	}

	// Token: 0x170006DA RID: 1754
	// (get) Token: 0x06002921 RID: 10529 RVA: 0x0009FF68 File Offset: 0x0009E168
	public string AverageS
	{
		get
		{
			return this.Average.ToString().smethod_17(2);
		}
	}

	// Token: 0x170006DB RID: 1755
	// (get) Token: 0x06002922 RID: 10530 RVA: 0x0009FF8C File Offset: 0x0009E18C
	public string LastValueS
	{
		get
		{
			return this.LastValue.ToString().smethod_17(2);
		}
	}

	// Token: 0x170006DC RID: 1756
	// (get) Token: 0x06002923 RID: 10531 RVA: 0x0009FFB0 File Offset: 0x0009E1B0
	public string MinS
	{
		get
		{
			return this.Min.ToString().smethod_17(2);
		}
	}

	// Token: 0x170006DD RID: 1757
	// (get) Token: 0x06002924 RID: 10532 RVA: 0x0009FFD4 File Offset: 0x0009E1D4
	public string MaxS
	{
		get
		{
			return this.Max.ToString().smethod_17(2);
		}
	}

	// Token: 0x170006DE RID: 1758
	// (get) Token: 0x06002925 RID: 10533 RVA: 0x0009FFF8 File Offset: 0x0009E1F8
	public string StdDevS
	{
		get
		{
			return this.StdDev.ToString().smethod_17(2);
		}
	}

	// Token: 0x170006DF RID: 1759
	// (get) Token: 0x06002926 RID: 10534 RVA: 0x000A001C File Offset: 0x0009E21C
	public string CountS
	{
		get
		{
			return this.Values.Count<double>().ToString();
		}
	}

	// Token: 0x170006E0 RID: 1760
	// (get) Token: 0x06002927 RID: 10535 RVA: 0x0001AFEA File Offset: 0x000191EA
	// (set) Token: 0x06002928 RID: 10536 RVA: 0x0001B014 File Offset: 0x00019214
	public int SelectedClickCount
	{
		get
		{
			if (this.int_0 == 0)
			{
				this.int_0 = Convert.ToInt32(Class551.class753_0.method_8());
			}
			return this.int_0;
		}
		set
		{
			Class551.class753_0.method_9(new int?(value));
			this.int_0 = value;
			base.method_0("SelectedClickCount");
		}
	}

	// Token: 0x170006E1 RID: 1761
	// (get) Token: 0x06002929 RID: 10537 RVA: 0x000A003C File Offset: 0x0009E23C
	public List<int> ClickCounts
	{
		get
		{
			if (this.list_1 == null)
			{
				this.list_1 = new List<int>
				{
					10,
					20,
					50,
					100,
					200,
					300,
					500
				};
			}
			return this.list_1;
		}
	}

	// Token: 0x170006E2 RID: 1762
	// (get) Token: 0x0600292A RID: 10538 RVA: 0x0001B039 File Offset: 0x00019239
	public int ClickCount
	{
		get
		{
			return this.SelectedClickCount;
		}
	}

	// Token: 0x170006E3 RID: 1763
	// (get) Token: 0x0600292B RID: 10539 RVA: 0x0001B041 File Offset: 0x00019241
	// (set) Token: 0x0600292C RID: 10540 RVA: 0x0001B049 File Offset: 0x00019249
	public int ClickCountLeft
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
			base.method_0("ClickCountLeftText");
		}
	}

	// Token: 0x170006E4 RID: 1764
	// (get) Token: 0x0600292D RID: 10541 RVA: 0x0001B05E File Offset: 0x0001925E
	// (set) Token: 0x0600292E RID: 10542 RVA: 0x0001B066 File Offset: 0x00019266
	public string ClickText1
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
			base.method_0("ClickText1");
		}
	}

	// Token: 0x170006E5 RID: 1765
	// (get) Token: 0x0600292F RID: 10543 RVA: 0x000A00A4 File Offset: 0x0009E2A4
	public string ClickCountLeftText
	{
		get
		{
			return this.ClickCountLeft.ToString();
		}
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x000A00C0 File Offset: 0x0009E2C0
	public static void smethod_0(Class529.Delegate32 delegate32_1)
	{
		Class529.Delegate32 @delegate = Class529.delegate32_0;
		Class529.Delegate32 delegate2;
		do
		{
			delegate2 = @delegate;
			Class529.Delegate32 value = (Class529.Delegate32)Delegate.Combine(delegate2, delegate32_1);
			@delegate = Interlocked.CompareExchange<Class529.Delegate32>(ref Class529.delegate32_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x000A00F4 File Offset: 0x0009E2F4
	public static void smethod_1(Class529.Delegate32 delegate32_1)
	{
		Class529.Delegate32 @delegate = Class529.delegate32_0;
		Class529.Delegate32 delegate2;
		do
		{
			delegate2 = @delegate;
			Class529.Delegate32 value = (Class529.Delegate32)Delegate.Remove(delegate2, delegate32_1);
			@delegate = Interlocked.CompareExchange<Class529.Delegate32>(ref Class529.delegate32_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x000A0128 File Offset: 0x0009E328
	private void method_5()
	{
		Class529.Struct447 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct447>(ref @struct);
	}

	// Token: 0x06002933 RID: 10547 RVA: 0x000A0160 File Offset: 0x0009E360
	private void method_6()
	{
		Class529.Struct439 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct439>(ref @struct);
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x000A0198 File Offset: 0x0009E398
	private void method_7()
	{
		Class529.Struct448 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct448>(ref @struct);
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x000A01D0 File Offset: 0x0009E3D0
	private Task method_8()
	{
		Class529.Struct440 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<Class529.Struct440>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06002936 RID: 10550 RVA: 0x000A0214 File Offset: 0x0009E414
	private void method_9()
	{
		Class529.Struct442 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct442>(ref @struct);
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x0001B07B File Offset: 0x0001927B
	private void method_10()
	{
		if (this.bool_1)
		{
			return;
		}
		this.bool_1 = true;
		this.timeSpan_0 = this.stopwatch_0.Elapsed;
		this.method_12();
	}

	// Token: 0x06002938 RID: 10552 RVA: 0x000A024C File Offset: 0x0009E44C
	private void method_11()
	{
		Class529.Struct446 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct446>(ref @struct);
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x000A0284 File Offset: 0x0009E484
	private void method_12()
	{
		Class529.Struct444 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct444>(ref @struct);
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x000A02BC File Offset: 0x0009E4BC
	private void method_13(RawKeyboard rawKeyboard_0)
	{
		Class529.Struct445 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.rawKeyboard_0 = rawKeyboard_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct445>(ref @struct);
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x0001B0A4 File Offset: 0x000192A4
	private void method_14()
	{
		if (this.list_2.Contains(17) && this.list_2.Contains(75))
		{
			this.list_2.Clear();
			this.method_9();
		}
	}

	// Token: 0x170006E6 RID: 1766
	// (get) Token: 0x0600293C RID: 10556 RVA: 0x000A02FC File Offset: 0x0009E4FC
	public GClass280 Start
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_23), null));
			}
			return result;
		}
	}

	// Token: 0x170006E7 RID: 1767
	// (get) Token: 0x0600293D RID: 10557 RVA: 0x000A0330 File Offset: 0x0009E530
	public GClass280 ReloadCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_25), null));
			}
			return result;
		}
	}

	// Token: 0x170006E8 RID: 1768
	// (get) Token: 0x0600293E RID: 10558 RVA: 0x000A0364 File Offset: 0x0009E564
	public GClass280 DeleteCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(this.method_26), null));
			}
			return result;
		}
	}

	// Token: 0x170006E9 RID: 1769
	// (get) Token: 0x0600293F RID: 10559 RVA: 0x0001B0D5 File Offset: 0x000192D5
	public GClass280 Rename
	{
		get
		{
			return new GClass280(new Action<object>(this.method_27), null);
		}
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x000A0398 File Offset: 0x0009E598
	private void method_15()
	{
		if (File.Exists(Path.Combine(Class169.string_8, this.string_0 + ".lx")))
		{
			File.Delete(Path.Combine(Class169.string_8, this.string_0 + ".lx"));
			this.string_0 = this.Name;
		}
		Class669 @class = new Class669
		{
			Name = this.Name,
			ChoosenArea = this.ChoosenArea.Name,
			DateTime_0 = this.Date,
			Int32_0 = this.ClickCount
		};
		foreach (double item in this.Values)
		{
			@class.Values.Add(item);
		}
		string contents = Class868.smethod_0(JsonConvert.SerializeObject(@class, 1));
		File.WriteAllText(Path.Combine(Class169.string_8, this.Name + ".lx"), contents);
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x0001B0E9 File Offset: 0x000192E9
	private void method_16()
	{
		File.Delete(Path.Combine(Class169.string_8, this.Name + ".lx"));
	}

	// Token: 0x170006EA RID: 1770
	// (get) Token: 0x06002942 RID: 10562 RVA: 0x0001B10B File Offset: 0x0001930B
	// (set) Token: 0x06002943 RID: 10563 RVA: 0x0001B113 File Offset: 0x00019313
	public double BorderOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("BorderOpacity");
		}
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x000A04A4 File Offset: 0x0009E6A4
	private void method_17()
	{
		while (this.bool_1)
		{
			this.int_4 = (int)PManagerX.GetPixel(this.intptr_1, this.int_2, this.int_3);
			this.color_0 = Color.FromArgb(255, this.int_4 & 255, this.int_4 >> 8 & 255, this.int_4 >> 16 & 255);
			if (this.color_0.Name == "ff000000")
			{
				this.bool_1 = false;
				this.method_6();
				this.method_7();
				return;
			}
		}
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x0001B128 File Offset: 0x00019328
	private void method_18()
	{
		this.BorderOpacity = 1.0;
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x0001B139 File Offset: 0x00019339
	private void method_19()
	{
		this.BorderOpacity = 0.6;
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x000A0540 File Offset: 0x0009E740
	private void method_20()
	{
		do
		{
			this.int_4 = (int)PManagerX.GetPixel(this.intptr_1, this.int_2, this.int_3);
			this.color_0 = Color.FromArgb(255, this.int_4 & 255, this.int_4 >> 8 & 255, this.int_4 >> 16 & 255);
		}
		while (!(this.color_0.Name != "ff000000"));
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x000A05BC File Offset: 0x0009E7BC
	private void method_21()
	{
		if (this.bool_2)
		{
			return;
		}
		this.bool_2 = true;
		this.timeSpan_0 = this.stopwatch_0.Elapsed;
		int clickCountLeft = this.ClickCountLeft;
		this.ClickCountLeft = clickCountLeft - 1;
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x000A04A4 File Offset: 0x0009E6A4
	private void method_22()
	{
		while (this.bool_1)
		{
			this.int_4 = (int)PManagerX.GetPixel(this.intptr_1, this.int_2, this.int_3);
			this.color_0 = Color.FromArgb(255, this.int_4 & 255, this.int_4 >> 8 & 255, this.int_4 >> 16 & 255);
			if (this.color_0.Name == "ff000000")
			{
				this.bool_1 = false;
				this.method_6();
				this.method_7();
				return;
			}
		}
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x000A05FC File Offset: 0x0009E7FC
	private void method_23(object object_0)
	{
		Class529.Struct443 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct443>(ref @struct);
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x000A0634 File Offset: 0x0009E834
	private void method_24()
	{
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = Class406.smethod_0().method_6(typeof(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)) as dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd;
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.method_24(false);
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.WindowState = WindowState.Normal;
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Width = 1072.0;
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Height = 754.0;
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.method_3();
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Topmost = true;
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.IsEnabled = false;
		dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.method_20();
		this.int_2 = (int)dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.ActualWidth - 50;
		this.int_3 = (int)dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.ActualHeight - 50;
		this.color_0 = Color.Black;
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x000A06CC File Offset: 0x0009E8CC
	private void method_25(object object_0)
	{
		Class529.Struct438 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.class529_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<Class529.Struct438>(ref @struct);
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x000A0704 File Offset: 0x0009E904
	private void method_26(object object_0)
	{
		this.method_16();
		this.class522_0.method_5(this);
		this.Values.Clear();
		this.class522_0.Models.Remove(this);
		if (this.class522_0.Models.Count<Class529>() == 0)
		{
			this.class522_0.NewTestCommand.Execute(null);
			return;
		}
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x0001B14A File Offset: 0x0001934A
	private void method_27(object object_0)
	{
		this.method_15();
	}

	// Token: 0x04001AE6 RID: 6886
	private Class522 class522_0;

	// Token: 0x04001AE7 RID: 6887
	private dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0;

	// Token: 0x04001AE8 RID: 6888
	private List<Class398> list_0;

	// Token: 0x04001AE9 RID: 6889
	private Class398 class398_0;

	// Token: 0x04001AEA RID: 6890
	public bool bool_0;

	// Token: 0x04001AEB RID: 6891
	private string string_0;

	// Token: 0x04001AEC RID: 6892
	private string string_1;

	// Token: 0x04001AED RID: 6893
	private DateTime dateTime_0 = DateTime.Now;

	// Token: 0x04001AEE RID: 6894
	private ObservableCollection<double> observableCollection_0 = new ObservableCollection<double>();

	// Token: 0x04001AEF RID: 6895
	private int int_0;

	// Token: 0x04001AF0 RID: 6896
	private List<int> list_1;

	// Token: 0x04001AF1 RID: 6897
	private int int_1;

	// Token: 0x04001AF2 RID: 6898
	private string string_2 = Class298.smethod_2("ClickLMB");

	// Token: 0x04001AF3 RID: 6899
	public Stopwatch stopwatch_0 = new Stopwatch();

	// Token: 0x04001AF4 RID: 6900
	private Color color_0;

	// Token: 0x04001AF5 RID: 6901
	private Thread thread_0;

	// Token: 0x04001AF6 RID: 6902
	private bool bool_1;

	// Token: 0x04001AF7 RID: 6903
	private bool bool_2;

	// Token: 0x04001AF8 RID: 6904
	private int int_2;

	// Token: 0x04001AF9 RID: 6905
	private int int_3;

	// Token: 0x04001AFA RID: 6906
	private TimeSpan timeSpan_0 = TimeSpan.Zero;

	// Token: 0x04001AFB RID: 6907
	private IntPtr intptr_0 = Process.GetCurrentProcess().MainWindowHandle;

	// Token: 0x04001AFC RID: 6908
	private IntPtr intptr_1 = PManagerX.GetWindowDC(Process.GetCurrentProcess().MainWindowHandle);

	// Token: 0x04001AFD RID: 6909
	private IntPtr intptr_2 = PManagerX.GetDC(IntPtr.Zero);

	// Token: 0x04001AFE RID: 6910
	private int int_4;

	// Token: 0x04001AFF RID: 6911
	private static Class529.Delegate32 delegate32_0;

	// Token: 0x04001B00 RID: 6912
	private List<int> list_2 = new List<int>();

	// Token: 0x04001B01 RID: 6913
	private bool bool_3;

	// Token: 0x04001B02 RID: 6914
	private GClass280 gclass280_0;

	// Token: 0x04001B03 RID: 6915
	private GClass280 gclass280_1;

	// Token: 0x04001B04 RID: 6916
	private GClass280 gclass280_2;

	// Token: 0x04001B05 RID: 6917
	private double double_0 = 0.6;

	// Token: 0x02000658 RID: 1624
	[StructLayout(LayoutKind.Auto)]
	private struct Struct438 : IAsyncStateMachine
	{
		// Token: 0x0600294F RID: 10575 RVA: 0x000A0764 File Offset: 0x0009E964
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @class = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_EC;
					}
					@class.method_16();
					@class.Values.Clear();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_3, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct438>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_1, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct438>(ref awaiter, ref this);
					return;
				}
				IL_EC:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_0);
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

		// Token: 0x06002950 RID: 10576 RVA: 0x0001B152 File Offset: 0x00019352
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B06 RID: 6918
		public int int_0;

		// Token: 0x04001B07 RID: 6919
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B08 RID: 6920
		public Class529 class529_0;

		// Token: 0x04001B09 RID: 6921
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000659 RID: 1625
	// (Invoke) Token: 0x06002952 RID: 10578
	public delegate void Delegate32();

	// Token: 0x0200065A RID: 1626
	[StructLayout(LayoutKind.Auto)]
	private struct Struct439 : IAsyncStateMachine
	{
		// Token: 0x06002955 RID: 10581 RVA: 0x000A08B0 File Offset: 0x0009EAB0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @object = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@object.method_19)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct439>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x06002956 RID: 10582 RVA: 0x0001B160 File Offset: 0x00019360
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B0A RID: 6922
		public int int_0;

		// Token: 0x04001B0B RID: 6923
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B0C RID: 6924
		public Class529 class529_0;

		// Token: 0x04001B0D RID: 6925
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200065B RID: 1627
	private sealed class Class773
	{
		// Token: 0x06002958 RID: 10584 RVA: 0x0001B16E File Offset: 0x0001936E
		internal double method_0(double double_1)
		{
			return Math.Pow(double_1 - this.double_0, 2.0);
		}

		// Token: 0x04001B0E RID: 6926
		public double double_0;
	}

	// Token: 0x0200065C RID: 1628
	[StructLayout(LayoutKind.Auto)]
	private struct Struct440 : IAsyncStateMachine
	{
		// Token: 0x06002959 RID: 10585 RVA: 0x000A0978 File Offset: 0x0009EB78
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @object = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_CF;
					}
					awaiter = Task.Run(new Action(@object.method_20)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct440>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct440>(ref awaiter, ref this);
					return;
				}
				IL_CF:
				awaiter.GetResult();
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

		// Token: 0x0600295A RID: 10586 RVA: 0x0001B186 File Offset: 0x00019386
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B0F RID: 6927
		public int int_0;

		// Token: 0x04001B10 RID: 6928
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001B11 RID: 6929
		public Class529 class529_0;

		// Token: 0x04001B12 RID: 6930
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200065D RID: 1629
	[StructLayout(LayoutKind.Auto)]
	private struct Struct441 : IAsyncStateMachine
	{
		// Token: 0x0600295B RID: 10587 RVA: 0x000A0A98 File Offset: 0x0009EC98
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @class = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_E7;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_14B;
				default:
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_3, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct441>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_2, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct441>(ref awaiter, ref this);
					return;
				}
				IL_E7:
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_0, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct441>(ref awaiter, ref this);
					return;
				}
				IL_14B:
				awaiter.GetResult();
				if (@class.Values.Count<double>() > 0)
				{
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_3);
				}
				else
				{
					dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_0);
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

		// Token: 0x0600295C RID: 10588 RVA: 0x0001B194 File Offset: 0x00019394
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B13 RID: 6931
		public int int_0;

		// Token: 0x04001B14 RID: 6932
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B15 RID: 6933
		public Class529 class529_0;

		// Token: 0x04001B16 RID: 6934
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200065E RID: 1630
	[StructLayout(LayoutKind.Auto)]
	private struct Struct442 : IAsyncStateMachine
	{
		// Token: 0x0600295D RID: 10589 RVA: 0x000A0C70 File Offset: 0x0009EE70
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @class = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_185;
					}
					@class.bool_3 = false;
					@class.bool_2 = false;
					@class.bool_1 = false;
					@class.method_6();
					Class839.smethod_3(new Class839.Delegate34(@class.method_13));
					Class839.smethod_5();
					Class839.smethod_1(new Class839.Delegate33(@class.method_10));
					Class529.smethod_1(new Class529.Delegate32(@class.method_10));
					Class529.smethod_1(new Class529.Delegate32(@class.method_5));
					Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;
					Application.Current.Dispatcher.Invoke(new Action(Class529.Class776.class776_0.method_2));
					@class.method_15();
					awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_2, 100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct442>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_1, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct442>(ref awaiter, ref this);
					return;
				}
				IL_185:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_3);
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

		// Token: 0x0600295E RID: 10590 RVA: 0x0001B1A2 File Offset: 0x000193A2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B17 RID: 6935
		public int int_0;

		// Token: 0x04001B18 RID: 6936
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B19 RID: 6937
		public Class529 class529_0;

		// Token: 0x04001B1A RID: 6938
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200065F RID: 1631
	[StructLayout(LayoutKind.Auto)]
	private struct Struct443 : IAsyncStateMachine
	{
		// Token: 0x0600295F RID: 10591 RVA: 0x000A0E64 File Offset: 0x0009F064
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @class = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_D3;
				case 1:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_174;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1E3;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_242;
				default:
					if (@class.bool_3)
					{
						goto IL_330;
					}
					@class.bool_3 = true;
					@class.ClickCountLeft = @class.ClickCount;
					@class.stopwatch_0.Reset();
					@class.stopwatch_0.Start();
					@class.method_6();
					Application.Current.Dispatcher.Invoke(new Action(@class.method_24));
					if (!dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_21)
					{
						goto IL_EC;
					}
					this.int_1 = 0;
					break;
				}
				IL_A9:
				if (dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.bool_21)
				{
					goto IL_EC;
				}
				if (this.int_1 > 2000)
				{
					goto IL_330;
				}
				awaiter = Task.Delay(100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct443>(ref awaiter, ref this);
					return;
				}
				IL_D3:
				awaiter.GetResult();
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
				goto IL_A9;
				IL_EC:
				awaiter = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_18(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_0, 100).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct443>(ref awaiter, ref this);
					return;
				}
				IL_174:
				awaiter.GetResult();
				dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.smethod_23(@class.dje_zTNNF6UN885JUKUZESJWF7RFE5TA3W9MBRB7P6C6JTQAGZV7ZX9VEBVTFBZZ3JX6G7W_ejd_0.grid_2);
				awaiter = Class406.smethod_0().method_8().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct443>(ref awaiter, ref this);
					return;
				}
				IL_1E3:
				awaiter.GetResult();
				awaiter = Task.Delay(2000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct443>(ref awaiter, ref this);
					return;
				}
				IL_242:
				awaiter.GetResult();
				if (@class.ChoosenArea == @class.TestingAreas[0])
				{
					@class.ClickText1 = Class298.smethod_2("WaitPlease");
					Class839.smethod_4();
					Class839.smethod_2(new Class839.Delegate34(@class.method_13));
					Class529.smethod_0(new Class529.Delegate32(@class.method_10));
					Class529.smethod_0(new Class529.Delegate32(@class.method_5));
					Class529.Delegate32 delegate32_ = Class529.delegate32_0;
					if (delegate32_ != null)
					{
						delegate32_();
					}
				}
				else if (@class.ChoosenArea == @class.TestingAreas[1])
				{
					@class.ClickText1 = Class298.smethod_2("ClickLMB");
					Class839.smethod_4();
					Class839.smethod_2(new Class839.Delegate34(@class.method_13));
					Class839.smethod_0(new Class839.Delegate33(@class.method_10));
					Class839.smethod_0(new Class839.Delegate33(@class.method_5));
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_330:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B1B RID: 6939
		public int int_0;

		// Token: 0x04001B1C RID: 6940
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B1D RID: 6941
		public Class529 class529_0;

		// Token: 0x04001B1E RID: 6942
		private int int_1;

		// Token: 0x04001B1F RID: 6943
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000660 RID: 1632
	private sealed class Class774
	{
		// Token: 0x06002962 RID: 10594 RVA: 0x0001B1BE File Offset: 0x000193BE
		internal bool method_0(Class398 class398_0)
		{
			return class398_0.Name == this.class669_0.ChoosenArea;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0001B1BE File Offset: 0x000193BE
		internal bool method_1(Class398 class398_0)
		{
			return class398_0.Name == this.class669_0.ChoosenArea;
		}

		// Token: 0x04001B20 RID: 6944
		public Class669 class669_0;
	}

	// Token: 0x02000661 RID: 1633
	[StructLayout(LayoutKind.Auto)]
	private struct Struct444 : IAsyncStateMachine
	{
		// Token: 0x06002964 RID: 10596 RVA: 0x000A11D0 File Offset: 0x0009F3D0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @object = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_22)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct444>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x06002965 RID: 10597 RVA: 0x0001B1D6 File Offset: 0x000193D6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B21 RID: 6945
		public int int_0;

		// Token: 0x04001B22 RID: 6946
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B23 RID: 6947
		public Class529 class529_0;

		// Token: 0x04001B24 RID: 6948
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000662 RID: 1634
	[StructLayout(LayoutKind.Auto)]
	private struct Struct445 : IAsyncStateMachine
	{
		// Token: 0x06002966 RID: 10598 RVA: 0x000A1290 File Offset: 0x0009F490
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(new Class529.Class775
					{
						rawKeyboard_0 = this.rawKeyboard_0,
						class529_0 = this.class529_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct445>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x06002967 RID: 10599 RVA: 0x0001B1E4 File Offset: 0x000193E4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B25 RID: 6949
		public int int_0;

		// Token: 0x04001B26 RID: 6950
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B27 RID: 6951
		public RawKeyboard rawKeyboard_0;

		// Token: 0x04001B28 RID: 6952
		public Class529 class529_0;

		// Token: 0x04001B29 RID: 6953
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000663 RID: 1635
	[StructLayout(LayoutKind.Auto)]
	private struct Struct446 : IAsyncStateMachine
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x000A1364 File Offset: 0x0009F564
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @object = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_21)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct446>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x06002969 RID: 10601 RVA: 0x0001B1F2 File Offset: 0x000193F2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B2A RID: 6954
		public int int_0;

		// Token: 0x04001B2B RID: 6955
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B2C RID: 6956
		public Class529 class529_0;

		// Token: 0x04001B2D RID: 6957
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000664 RID: 1636
	[StructLayout(LayoutKind.Auto)]
	private struct Struct447 : IAsyncStateMachine
	{
		// Token: 0x0600296A RID: 10602 RVA: 0x000A1424 File Offset: 0x0009F624
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @object = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Application.Current.Dispatcher.InvokeAsync(new Action(@object.method_18)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct447>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
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

		// Token: 0x0600296B RID: 10603 RVA: 0x0001B200 File Offset: 0x00019400
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B2E RID: 6958
		public int int_0;

		// Token: 0x04001B2F RID: 6959
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B30 RID: 6960
		public Class529 class529_0;

		// Token: 0x04001B31 RID: 6961
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000665 RID: 1637
	private sealed class Class775
	{
		// Token: 0x0600296D RID: 10605 RVA: 0x000A14EC File Offset: 0x0009F6EC
		internal void method_0()
		{
			if ((this.rawKeyboard_0.Flags & 1) == null)
			{
				if (!this.class529_0.list_2.Contains(this.rawKeyboard_0.VirutalKey))
				{
					this.class529_0.list_2.Add(this.rawKeyboard_0.VirutalKey);
				}
			}
			else if (this.class529_0.list_2.Contains(this.rawKeyboard_0.VirutalKey))
			{
				this.class529_0.list_2.Remove(this.rawKeyboard_0.VirutalKey);
			}
			this.class529_0.method_14();
		}

		// Token: 0x04001B32 RID: 6962
		public RawKeyboard rawKeyboard_0;

		// Token: 0x04001B33 RID: 6963
		public Class529 class529_0;
	}

	// Token: 0x02000666 RID: 1638
	[StructLayout(LayoutKind.Auto)]
	private struct Struct448 : IAsyncStateMachine
	{
		// Token: 0x0600296E RID: 10606 RVA: 0x000A1588 File Offset: 0x0009F788
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			Class529 @class = this.class529_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					double totalMilliseconds = (@class.stopwatch_0.Elapsed - @class.timeSpan_0).TotalMilliseconds;
					@class.Values.Add(totalMilliseconds);
					int num2 = @class.ClickCountLeft - 1;
					@class.ClickCountLeft = num2;
					if (num2 <= 0)
					{
						@class.method_9();
						goto IL_E4;
					}
					awaiter = @class.method_8().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class529.Struct448>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
				}
				awaiter.GetResult();
				Class529.Delegate32 delegate32_ = Class529.delegate32_0;
				if (delegate32_ != null)
				{
					delegate32_();
				}
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_E4:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0001B20E File Offset: 0x0001940E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04001B34 RID: 6964
		public int int_0;

		// Token: 0x04001B35 RID: 6965
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001B36 RID: 6966
		public Class529 class529_0;

		// Token: 0x04001B37 RID: 6967
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000667 RID: 1639
	[Serializable]
	private sealed class Class776
	{
		// Token: 0x06002972 RID: 10610 RVA: 0x0001B228 File Offset: 0x00019428
		internal bool method_0(Class529 class529_0)
		{
			return class529_0.IsChoosen;
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x0000E7F6 File Offset: 0x0000C9F6
		internal double method_1(double double_0)
		{
			return double_0;
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0001B230 File Offset: 0x00019430
		internal void method_2()
		{
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd = Class406.smethod_0().method_6(typeof(dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd)) as dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd;
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.Topmost = false;
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.IsEnabled = true;
			dje_zKFJMLBTQVAV35JM269DF3HJNA9QQ_ejd.method_21();
		}

		// Token: 0x04001B38 RID: 6968
		public static readonly Class529.Class776 class776_0 = new Class529.Class776();

		// Token: 0x04001B39 RID: 6969
		public static Func<Class529, bool> func_0;

		// Token: 0x04001B3A RID: 6970
		public static Func<double, double> func_1;

		// Token: 0x04001B3B RID: 6971
		public static Action action_0;
	}
}
