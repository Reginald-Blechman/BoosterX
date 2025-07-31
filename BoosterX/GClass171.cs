using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Material.Icons;
using ns0;

// Token: 0x02000234 RID: 564
public sealed class GClass171 : GClass162
{
	// Token: 0x06000F4E RID: 3918 RVA: 0x00053774 File Offset: 0x00051974
	public GClass171(GClass86 gclass86_1, GClass293 gclass293_1)
	{
		this.gclass86_0 = gclass86_1;
		this.string_2 = gclass86_1.method_0();
		this.string_3 = gclass86_1.DisplayName;
		this.DefaultLabel = gclass86_1.method_9();
		this.gclass293_0 = gclass293_1;
		this.string_0 = gclass86_1.method_7();
		this.bool_0 = gclass86_1.method_11();
		this.method_8(gclass86_1.Type);
		if (gclass86_1.method_5().Count > 0)
		{
			List<string> list_ = gclass86_1.method_5().Values.Distinct<string>().ToList<string>();
			this.ienumerable_0 = list_;
			foreach (KeyValuePair<string, string> keyValuePair in gclass86_1.method_5())
			{
				this.dictionary_0[keyValuePair.Value] = keyValuePair.Key;
			}
			string text2;
			string text;
			this.method_4(text = (this.dictionary_0.TryGetValue(gclass86_1.method_3(), out text2) ? gclass86_1.method_3() : (Class746.smethod_0<string>(list_) ?? string.Empty)));
			this.SelectedLabel = text;
		}
		else
		{
			this.ienumerable_0 = null;
			string text;
			this.method_6(text = gclass86_1.method_1());
			this.CustomValue = text;
		}
		this.class805_0 = new Class805(this, gclass293_1);
		this.method_2();
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000F4F RID: 3919 RVA: 0x0000B3BC File Offset: 0x000095BC
	public bool IsSelectedDefault
	{
		get
		{
			return this.SelectedLabel == this.DefaultLabel || this.CustomValue == this.string_0;
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0000B3E4 File Offset: 0x000095E4
	// (set) Token: 0x06000F51 RID: 3921 RVA: 0x0000B3EC File Offset: 0x000095EC
	public string DefaultLabel
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

	// Token: 0x06000F52 RID: 3922 RVA: 0x00053938 File Offset: 0x00051B38
	private void method_2()
	{
		MaterialIconKind icon;
		if (GClass117.dictionary_0.TryGetValue(this.NameClean, out icon))
		{
			this.Icon = icon;
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000F53 RID: 3923 RVA: 0x0000B3F5 File Offset: 0x000095F5
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0000B3FD File Offset: 0x000095FD
	public string NameClean
	{
		get
		{
			return this.Name.Replace("*", string.Empty);
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000F55 RID: 3925 RVA: 0x0000B415 File Offset: 0x00009615
	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0000B41D File Offset: 0x0000961D
	// (set) Token: 0x06000F57 RID: 3927 RVA: 0x0000B425 File Offset: 0x00009625
	public MaterialIconKind Icon
	{
		get
		{
			return this.materialIconKind_0;
		}
		private set
		{
			base.method_1<MaterialIconKind>(ref this.materialIconKind_0, value, "Icon", null);
		}
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0000B43C File Offset: 0x0000963C
	public IEnumerable<string> Values
	{
		[CompilerGenerated]
		get
		{
			return this.ienumerable_0;
		}
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x0000B444 File Offset: 0x00009644
	private string method_3()
	{
		return this.string_4;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x0000B44C File Offset: 0x0000964C
	private void method_4(string string_9)
	{
		this.string_4 = string_9;
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000F5B RID: 3931 RVA: 0x0000B455 File Offset: 0x00009655
	// (set) Token: 0x06000F5C RID: 3932 RVA: 0x0000B45D File Offset: 0x0000965D
	public string SelectedLabel
	{
		get
		{
			return this.string_5;
		}
		set
		{
			base.method_1<string>(ref this.string_5, value, "SelectedLabel", null);
			this.method_9();
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0000B47A File Offset: 0x0000967A
	public long? Min
	{
		get
		{
			return this.gclass86_0.method_13();
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0000B487 File Offset: 0x00009687
	public long? Max
	{
		get
		{
			return this.gclass86_0.method_15();
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0000B494 File Offset: 0x00009694
	public long? Step
	{
		get
		{
			return this.gclass86_0.method_17();
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0000B4A1 File Offset: 0x000096A1
	public long? LimitText
	{
		get
		{
			return this.gclass86_0.method_19();
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00053960 File Offset: 0x00051B60
	public string TextBoxToolTip
	{
		get
		{
			string text = this.string_0.smethod_9() ? Class298.smethod_2("EmptyValue") : this.string_0;
			if (this.method_7() == dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Int)
			{
				string[] array = new string[15];
				array[0] = Class298.smethod_2("MinimumShort");
				array[1] = " ";
				int num = 2;
				long? num2 = this.Min;
				array[num] = ((num2 != null) ? num2.GetValueOrDefault().ToString() : null);
				array[3] = "\n";
				array[4] = Class298.smethod_2("MaximumShort");
				array[5] = " ";
				int num3 = 6;
				num2 = this.Max;
				array[num3] = ((num2 != null) ? num2.GetValueOrDefault().ToString() : null);
				array[7] = "\n";
				array[8] = Class298.smethod_2("StepAsNumberStep");
				array[9] = " ";
				int num4 = 10;
				num2 = this.Step;
				array[num4] = ((num2 != null) ? num2.GetValueOrDefault().ToString() : null);
				array[11] = "\n";
				array[12] = Class298.smethod_2("default");
				array[13] = " ";
				array[14] = text;
				return string.Concat(array);
			}
			if (this.method_7() == dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Edit)
			{
				string[] array2 = new string[9];
				array2[0] = Class298.smethod_2("SymbolsLimit");
				array2[1] = " ";
				int num5 = 2;
				long? num2 = this.LimitText;
				array2[num5] = num2.ToString();
				array2[3] = "\n";
				array2[4] = Class298.smethod_2("default");
				array2[5] = " ";
				array2[6] = text;
				array2[7] = "\n\n";
				array2[8] = Class298.smethod_2("PossiblyMacAddress");
				return string.Concat(array2);
			}
			return string.Empty;
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00053B20 File Offset: 0x00051D20
	public string SelectedRaw
	{
		get
		{
			string result;
			if (!this.dictionary_0.TryGetValue(this.SelectedLabel, out result))
			{
				return this.SelectedLabel;
			}
			return result;
		}
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x0000B4AE File Offset: 0x000096AE
	private string method_5()
	{
		return this.string_7;
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x0000B4B6 File Offset: 0x000096B6
	private void method_6(string string_9)
	{
		this.string_7 = string_9;
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x0000B4BF File Offset: 0x000096BF
	private dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd method_7()
	{
		return this.dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd_0;
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x0000B4C7 File Offset: 0x000096C7
	private void method_8(dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd_1)
	{
		this.dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd_0 = dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd_1;
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000F67 RID: 3943 RVA: 0x0000B4D0 File Offset: 0x000096D0
	// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00053B4C File Offset: 0x00051D4C
	public string CustomValue
	{
		get
		{
			return this.string_6;
		}
		set
		{
			if (this.method_7() == dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Edit)
			{
				base.method_1<string>(ref this.string_6, value, "CustomValue", null);
				this.method_9();
				return;
			}
			if (string.IsNullOrWhiteSpace(value))
			{
				return;
			}
			long num;
			if (!long.TryParse(value, out num))
			{
				base.method_1<string>(ref this.string_6, this.string_6, "CustomValue", null);
				return;
			}
			if (this.Min != null && num < this.Min.Value)
			{
				num = this.Min.Value;
			}
			if (this.Max != null && num > this.Max.Value)
			{
				num = this.Max.Value;
			}
			if (this.Step != null && this.Step.Value > 0L)
			{
				long valueOrDefault = this.Min.GetValueOrDefault();
				num = valueOrDefault + (num - valueOrDefault) / this.Step.Value * this.Step.Value;
			}
			string gparam_ = num.ToString();
			base.method_1<string>(ref this.string_6, gparam_, "CustomValue", null);
			this.method_9();
		}
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00053C8C File Offset: 0x00051E8C
	private void method_9()
	{
		GClass171.Struct135 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass171_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass171.Struct135>(ref @struct);
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00053CC4 File Offset: 0x00051EC4
	private void method_10()
	{
		GClass171.Struct133 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass171_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass171.Struct133>(ref @struct);
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000F6B RID: 3947 RVA: 0x0000B4D8 File Offset: 0x000096D8
	public Visibility ComboBoxVisibility
	{
		get
		{
			if (this.method_7() != dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Enum)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0000B4E5 File Offset: 0x000096E5
	public Visibility TextBoxVisibility
	{
		get
		{
			if (this.method_7() == dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd.Enum)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0000B4F2 File Offset: 0x000096F2
	public bool CanReset
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x0000B4FA File Offset: 0x000096FA
	public void method_11()
	{
		if (!this.bool_0)
		{
			return;
		}
		if (this.Values != null)
		{
			this.SelectedLabel = this.DefaultLabel;
			return;
		}
		this.CustomValue = this.string_0;
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06000F6F RID: 3951 RVA: 0x0000B526 File Offset: 0x00009726
	public bool HasChanges
	{
		get
		{
			return this.SelectedLabel != this.method_3() || this.CustomValue != this.method_5();
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00053CFC File Offset: 0x00051EFC
	// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0000B54E File Offset: 0x0000974E
	public bool ShowFullDescription
	{
		get
		{
			bool? flag = this.nullable_0;
			if (flag == null)
			{
				return Class551.class753_0.method_34().GetValueOrDefault();
			}
			return flag.GetValueOrDefault();
		}
		set
		{
			this.nullable_0 = new bool?(value);
			base.method_0("ShowFullDescription");
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0000B568 File Offset: 0x00009768
	public string DescriptionShort
	{
		get
		{
			return Class298.smethod_2(this.NameClean + "SimpleDesc");
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0000B580 File Offset: 0x00009780
	public string DescriptionLong
	{
		get
		{
			return Class298.smethod_2(this.NameClean + "DeepDesc");
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0000B598 File Offset: 0x00009798
	public string Recommendation
	{
		get
		{
			return Class298.smethod_2(this.NameClean + "Recommendation");
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06000F75 RID: 3957 RVA: 0x0000B5B0 File Offset: 0x000097B0
	public string Consider
	{
		get
		{
			return Class298.smethod_2(this.NameClean + "Nuances");
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0000B5C8 File Offset: 0x000097C8
	public Visibility ConsiderVisibility
	{
		get
		{
			if (!(Class298.smethod_2(this.NameClean + "Nuances") != this.NameClean + "Nuances"))
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000F77 RID: 3959 RVA: 0x0000B5FB File Offset: 0x000097FB
	// (set) Token: 0x06000F78 RID: 3960 RVA: 0x0000B603 File Offset: 0x00009803
	public string Status
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
			base.method_0("Status");
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000F79 RID: 3961 RVA: 0x0000B618 File Offset: 0x00009818
	// (set) Token: 0x06000F7A RID: 3962 RVA: 0x0000B620 File Offset: 0x00009820
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

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0000B635 File Offset: 0x00009835
	// (set) Token: 0x06000F7C RID: 3964 RVA: 0x0000B63D File Offset: 0x0000983D
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

	// Token: 0x06000F7D RID: 3965 RVA: 0x00053D34 File Offset: 0x00051F34
	public Task method_12(string string_9, SolidColorBrush solidColorBrush_1)
	{
		GClass171.Struct134 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass171_0 = this;
		@struct.string_0 = string_9;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass171.Struct134>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00053D88 File Offset: 0x00051F88
	private void method_13()
	{
		if (this.HasChanges)
		{
			GClass279 gclass = GClass279.smethod_0();
			GClass293 gclass2 = this.gclass293_0;
			gclass.method_9<Class805>(((gclass2 != null) ? gclass2.ToString() : null) + this.Name, new Func<Class805>(this.method_14), null);
		}
		else
		{
			GClass279 gclass3 = GClass279.smethod_0();
			Type typeFromHandle = typeof(Class805);
			GClass293 gclass4 = this.gclass293_0;
			gclass3.method_15(typeFromHandle, ((gclass4 != null) ? gclass4.ToString() : null) + this.Name);
		}
		this.method_10();
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x0000B652 File Offset: 0x00009852
	private Class805 method_14()
	{
		return this.class805_0;
	}

	// Token: 0x040009C5 RID: 2501
	private Class805 class805_0;

	// Token: 0x040009C6 RID: 2502
	private GClass293 gclass293_0;

	// Token: 0x040009C7 RID: 2503
	private bool bool_0;

	// Token: 0x040009C8 RID: 2504
	private string string_0;

	// Token: 0x040009C9 RID: 2505
	private string string_1;

	// Token: 0x040009CA RID: 2506
	public GClass86 gclass86_0;

	// Token: 0x040009CB RID: 2507
	private readonly string string_2;

	// Token: 0x040009CC RID: 2508
	private readonly string string_3;

	// Token: 0x040009CD RID: 2509
	private MaterialIconKind materialIconKind_0 = 2002;

	// Token: 0x040009CE RID: 2510
	private readonly IEnumerable<string> ienumerable_0;

	// Token: 0x040009CF RID: 2511
	private string string_4 = string.Empty;

	// Token: 0x040009D0 RID: 2512
	private string string_5 = string.Empty;

	// Token: 0x040009D1 RID: 2513
	private readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x040009D2 RID: 2514
	private string string_6 = string.Empty;

	// Token: 0x040009D3 RID: 2515
	private string string_7 = string.Empty;

	// Token: 0x040009D4 RID: 2516
	private dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd dje_z86S8XV2DDV78XFY565BN8SUY2CHCDY5HXZ6KACAZL3MUCWTXPVBXSNQWECYT32F2CBB3TELU_ejd_0;

	// Token: 0x040009D5 RID: 2517
	public bool? nullable_0;

	// Token: 0x040009D6 RID: 2518
	private string string_8 = string.Empty;

	// Token: 0x040009D7 RID: 2519
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x040009D8 RID: 2520
	private double double_0;

	// Token: 0x040009D9 RID: 2521
	private CancellationTokenSource cancellationTokenSource_0 = new CancellationTokenSource();

	// Token: 0x02000235 RID: 565
	private sealed class Class267
	{
		// Token: 0x06000F81 RID: 3969 RVA: 0x00053E0C File Offset: 0x0005200C
		internal Task method_0()
		{
			GClass171.Class267.Struct132 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class267_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass171.Class267.Struct132>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x040009DA RID: 2522
		public GClass171 gclass171_0;

		// Token: 0x040009DB RID: 2523
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040009DC RID: 2524
		public string string_0;

		// Token: 0x02000236 RID: 566
		[StructLayout(LayoutKind.Auto)]
		private struct Struct132 : IAsyncStateMachine
		{
			// Token: 0x06000F82 RID: 3970 RVA: 0x00053E50 File Offset: 0x00052050
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass171.Class267 @class = this.class267_0;
				try
				{
					if (num > 1)
					{
						if (!Class406.smethod_0().method_2(typeof(dje_zYKWNAHPAA2WHHRJF4X7EG3NQ8TJT6P4HVXCZBEX5BLD2JKUFM4PCTXZ75CCLQQGATQ_ejd)))
						{
							@class.gclass171_0.double_0 = 1.0;
							@class.gclass171_0.solidColorBrush_0 = @class.solidColorBrush_0;
							@class.gclass171_0.string_8 = @class.string_0;
							goto IL_272;
						}
						try
						{
							@class.gclass171_0.cancellationTokenSource_0.Cancel();
							@class.gclass171_0.cancellationTokenSource_0.Dispose();
						}
						catch
						{
						}
						@class.gclass171_0.cancellationTokenSource_0 = new CancellationTokenSource();
						this.cancellationToken_0 = @class.gclass171_0.cancellationTokenSource_0.Token;
					}
					try
					{
						TaskAwaiter awaiter;
						if (num == 0)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num2 = -1;
							num = -1;
							this.int_0 = num2;
							goto IL_169;
						}
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.int_0 = num3;
							goto IL_1EB;
						}
						IL_FB:
						if (@class.gclass171_0.StatusOpacity <= 0.0)
						{
							@class.gclass171_0.StatusForeground = @class.solidColorBrush_0;
							@class.gclass171_0.Status = @class.string_0;
							goto IL_1F2;
						}
						this.cancellationToken_0.ThrowIfCancellationRequested();
						@class.gclass171_0.StatusOpacity = Math.Max(0.0, @class.gclass171_0.StatusOpacity - 0.1);
						awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							num = 0;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Class267.Struct132>(ref awaiter, ref this);
							return;
						}
						IL_169:
						awaiter.GetResult();
						goto IL_FB;
						IL_1EB:
						awaiter.GetResult();
						IL_1F2:
						if (@class.gclass171_0.StatusOpacity < 1.0)
						{
							this.cancellationToken_0.ThrowIfCancellationRequested();
							@class.gclass171_0.StatusOpacity = Math.Min(1.0, @class.gclass171_0.StatusOpacity + 0.13333333333333333);
							awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_1EB;
							}
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Class267.Struct132>(ref awaiter, ref this);
							return;
						}
					}
					catch
					{
					}
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.cancellationToken_0 = default(CancellationToken);
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				IL_272:
				this.int_0 = -2;
				this.cancellationToken_0 = default(CancellationToken);
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06000F83 RID: 3971 RVA: 0x0000B65A File Offset: 0x0000985A
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x040009DD RID: 2525
			public int int_0;

			// Token: 0x040009DE RID: 2526
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040009DF RID: 2527
			public GClass171.Class267 class267_0;

			// Token: 0x040009E0 RID: 2528
			private CancellationToken cancellationToken_0;

			// Token: 0x040009E1 RID: 2529
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x02000237 RID: 567
	[StructLayout(LayoutKind.Auto)]
	private struct Struct133 : IAsyncStateMachine
	{
		// Token: 0x06000F84 RID: 3972 RVA: 0x0005413C File Offset: 0x0005233C
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass171 gclass = this.gclass171_0;
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
					goto IL_1B4;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1D9;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_1FE;
				default:
					if (gclass.HasChanges)
					{
						if (gclass.bool_0 && gclass.IsSelectedDefault)
						{
							awaiter = gclass.method_12(Class298.smethod_2("WillBeDefault"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Struct133>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = gclass.method_12(Class298.smethod_2("willbechanged"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 1;
								this.taskAwaiter_0 = awaiter;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Struct133>(ref awaiter, ref this);
								return;
							}
							goto IL_1B4;
						}
					}
					else if (gclass.IsSelectedDefault)
					{
						awaiter = gclass.method_12(Class298.smethod_2("default"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z9KD2T3QNVQ26P9Q_ejd).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Struct133>(ref awaiter, ref this);
							return;
						}
						goto IL_1D9;
					}
					else
					{
						awaiter = gclass.method_12(Class298.smethod_2("Changed"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zBHWQM3TLFWTMTC2_ejd).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 3;
							this.taskAwaiter_0 = awaiter;
							this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Struct133>(ref awaiter, ref this);
							return;
						}
						goto IL_1FE;
					}
					break;
				}
				awaiter.GetResult();
				goto IL_205;
				IL_1B4:
				awaiter.GetResult();
				goto IL_205;
				IL_1D9:
				awaiter.GetResult();
				goto IL_205;
				IL_1FE:
				awaiter.GetResult();
				IL_205:;
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

		// Token: 0x06000F85 RID: 3973 RVA: 0x0000B668 File Offset: 0x00009868
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040009E2 RID: 2530
		public int int_0;

		// Token: 0x040009E3 RID: 2531
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040009E4 RID: 2532
		public GClass171 gclass171_0;

		// Token: 0x040009E5 RID: 2533
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000238 RID: 568
	[StructLayout(LayoutKind.Auto)]
	private struct Struct134 : IAsyncStateMachine
	{
		// Token: 0x06000F86 RID: 3974 RVA: 0x00054398 File Offset: 0x00052598
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(new GClass171.Class267
					{
						gclass171_0 = this.gclass171_0,
						solidColorBrush_0 = this.solidColorBrush_0,
						string_0 = this.string_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Struct134>(ref awaiter, ref this);
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
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0000B676 File Offset: 0x00009876
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040009E6 RID: 2534
		public int int_0;

		// Token: 0x040009E7 RID: 2535
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x040009E8 RID: 2536
		public GClass171 gclass171_0;

		// Token: 0x040009E9 RID: 2537
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x040009EA RID: 2538
		public string string_0;

		// Token: 0x040009EB RID: 2539
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000239 RID: 569
	[StructLayout(LayoutKind.Auto)]
	private struct Struct135 : IAsyncStateMachine
	{
		// Token: 0x06000F88 RID: 3976 RVA: 0x00054478 File Offset: 0x00052678
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass171 @object = this.gclass171_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Action(@object.method_13)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass171.Struct135>(ref awaiter, ref this);
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

		// Token: 0x06000F89 RID: 3977 RVA: 0x0000B684 File Offset: 0x00009884
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x040009EC RID: 2540
		public int int_0;

		// Token: 0x040009ED RID: 2541
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x040009EE RID: 2542
		public GClass171 gclass171_0;

		// Token: 0x040009EF RID: 2543
		private TaskAwaiter taskAwaiter_0;
	}
}
