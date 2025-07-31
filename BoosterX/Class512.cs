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
using System.Windows;
using System.Windows.Media;
using Material.Icons;

// Token: 0x0200039F RID: 927
internal sealed class Class512 : GClass162
{
	// Token: 0x060017E7 RID: 6119 RVA: 0x0006CE04 File Offset: 0x0006B004
	internal Class512(Class466 class466_1, Type type_1, bool bool_12 = false)
	{
		Class512.smethod_1(ref this.materialIconKind_0, ref this.observableCollection_0, ref this.observableCollection_1, ref this.list_0, ref this.observableCollection_2, ref this.visibility_0, ref this.visibility_1, ref this.visibility_2, ref this.visibility_3, ref this.visibility_4, ref this.visibility_5, ref this.visibility_6, ref this.visibility_7, ref this.visibility_8, ref this.visibility_9, ref this.visibility_10, ref this.visibility_11, ref this.string_10, ref this.solidColorBrush_0, ref this.cancellationTokenSource_0);
		base..ctor();
		this.method_60(type_1, class466_1, bool_12);
	}

	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x060017E8 RID: 6120 RVA: 0x000104D8 File Offset: 0x0000E6D8
	// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00010512 File Offset: 0x0000E712
	public string NameB
	{
		get
		{
			if (!this.IsEditable)
			{
				return null;
			}
			if (this.string_0.smethod_9())
			{
				this.string_0 = (this.method_7() ?? Class298.smethod_2("EnterName"));
			}
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("NameB");
		}
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x060017EA RID: 6122 RVA: 0x00010527 File Offset: 0x0000E727
	// (set) Token: 0x060017EB RID: 6123 RVA: 0x00010561 File Offset: 0x0000E761
	public string DescB
	{
		get
		{
			if (!this.IsEditable)
			{
				return null;
			}
			if (this.string_1.smethod_9())
			{
				this.string_1 = (this.Description ?? Class298.smethod_2("EnterDesc"));
			}
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("DescB");
		}
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x00010576 File Offset: 0x0000E776
	public ObservableCollection<MaterialIconKind> AllIcons
	{
		get
		{
			if (!this.OnEdit)
			{
				return null;
			}
			return Class330.smethod_7();
		}
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x060017ED RID: 6125 RVA: 0x00010587 File Offset: 0x0000E787
	// (set) Token: 0x060017EE RID: 6126 RVA: 0x0001058F File Offset: 0x0000E78F
	public MaterialIconKind IconB
	{
		get
		{
			return this.materialIconKind_0;
		}
		set
		{
			this.materialIconKind_0 = value;
			base.method_0("IconB");
		}
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x060017EF RID: 6127 RVA: 0x000105A4 File Offset: 0x0000E7A4
	// (set) Token: 0x060017F0 RID: 6128 RVA: 0x000105AC File Offset: 0x0000E7AC
	public bool ChoosingIcon
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("ChoosingIcon");
			base.method_0("AllIcons");
		}
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0006CEA0 File Offset: 0x0006B0A0
	// (set) Token: 0x060017F2 RID: 6130 RVA: 0x000105CD File Offset: 0x0000E7CD
	public bool? IsScript
	{
		get
		{
			bool value = this.nullable_0.GetValueOrDefault();
			if (this.nullable_0 == null)
			{
				value = (this.class466_0.String_4 == "SCRIPT");
				this.nullable_0 = new bool?(value);
			}
			return this.nullable_0;
		}
		set
		{
			this.nullable_0 = value;
			base.method_0("IsScript");
		}
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x060017F3 RID: 6131 RVA: 0x0006CEF0 File Offset: 0x0006B0F0
	public GClass280 ChangeIcon
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_43), null));
			}
			return result;
		}
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0006CF24 File Offset: 0x0006B124
	public GClass280 IconChangeRequest
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_44), null));
			}
			return result;
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0006CF58 File Offset: 0x0006B158
	public GClass280 CancelEditCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(this.method_45), null));
			}
			return result;
		}
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x0006CF8C File Offset: 0x0006B18C
	public void method_2(Class489 class489_0)
	{
		object[] object_ = new object[]
		{
			this,
			class489_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "R'=!*Za-je", object_);
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0006CFC0 File Offset: 0x0006B1C0
	// (set) Token: 0x060017F8 RID: 6136 RVA: 0x000105E2 File Offset: 0x0000E7E2
	public ObservableCollection<Class489> TweakStepsScript
	{
		get
		{
			if (!this.IsEditable)
			{
				return this.observableCollection_0;
			}
			if (this.observableCollection_0.Count<Class489>() == 0 && this.class466_0.String_4 == "SCRIPT" && this.method_11().Count<Class245>() > 0)
			{
				this.observableCollection_0.Add(new Class489(this.method_11().First(new Func<Class245, bool>(Class512.Class434.class434_0.method_0)), this));
			}
			else if (this.observableCollection_0.Count<Class489>() == 0)
			{
				this.observableCollection_0.Add(new Class489(new Class245
				{
					String_0 = "SCRIPT",
					List_0 = new List<Class275>
					{
						new Class275
						{
							List_0 = new List<string>
							{
								"BEST"
							},
							String_0 = Class298.smethod_2("EnterScriptHere")
						}
					}
				}, this));
			}
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("TweakStepsScript");
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0006D0C0 File Offset: 0x0006B2C0
	// (set) Token: 0x060017FA RID: 6138 RVA: 0x000105F7 File Offset: 0x0000E7F7
	public ObservableCollection<Class489> TweakStepsDouble
	{
		get
		{
			if (!this.IsEditable)
			{
				return this.observableCollection_0;
			}
			if (this.observableCollection_1.Count<Class489>() == 0 && this.method_11().Count<Class245>() > 0 && this.class466_0.String_4 == "DOUBLE")
			{
				foreach (Class245 class245_ in this.method_11())
				{
					this.observableCollection_1.Add(new Class489(class245_, this));
				}
			}
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("TweakStepsDouble");
		}
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x060017FB RID: 6139 RVA: 0x0006D168 File Offset: 0x0006B368
	public GClass280 AddRegistry
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_3) == null)
			{
				result = (this.gclass280_3 = new GClass280(new Action<object>(this.method_46), null));
			}
			return result;
		}
	}

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x060017FC RID: 6140 RVA: 0x0006D19C File Offset: 0x0006B39C
	public GClass280 AddTask
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_4) == null)
			{
				result = (this.gclass280_4 = new GClass280(new Action<object>(this.method_47), null));
			}
			return result;
		}
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x060017FD RID: 6141 RVA: 0x0006D1D0 File Offset: 0x0006B3D0
	public GClass280 AddBcdedit
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_5) == null)
			{
				result = (this.gclass280_5 = new GClass280(new Action<object>(this.method_48), null));
			}
			return result;
		}
	}

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x060017FE RID: 6142 RVA: 0x0006D204 File Offset: 0x0006B404
	public GClass280 AddDevice
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_6) == null)
			{
				result = (this.gclass280_6 = new GClass280(new Action<object>(this.method_49), null));
			}
			return result;
		}
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x0006D238 File Offset: 0x0006B438
	public void method_3()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Nj,puZa-jg", object_);
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x0006D268 File Offset: 0x0006B468
	internal void method_4()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "hlsMqZa-jk", object_);
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x0006D298 File Offset: 0x0006B498
	private void method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "MQjLqZa-jm", object_);
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
	private void method_6(object sender, NotifyCollectionChangedEventArgs e)
	{
		object[] object_ = new object[]
		{
			this,
			sender,
			e
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "&$WIKZa-hW", object_);
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06001803 RID: 6147 RVA: 0x0001060C File Offset: 0x0000E80C
	// (set) Token: 0x06001804 RID: 6148 RVA: 0x00010614 File Offset: 0x0000E814
	public ObservableCollection<Class512> Childs
	{
		get
		{
			return this.observableCollection_2;
		}
		set
		{
			this.observableCollection_2 = value;
			base.method_0("Childs");
		}
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06001805 RID: 6149 RVA: 0x00010629 File Offset: 0x0000E829
	public string Name
	{
		get
		{
			return this.string_3;
		}
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x0006D300 File Offset: 0x0006B500
	public string method_7()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "Q*@['Za-k8", object_);
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x06001807 RID: 6151 RVA: 0x00010631 File Offset: 0x0000E831
	public string QuickDesk
	{
		get
		{
			return this.string_2;
		}
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06001808 RID: 6152 RVA: 0x00010639 File Offset: 0x0000E839
	public bool HasQuickDesk
	{
		get
		{
			return this.bool_3;
		}
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x06001809 RID: 6153 RVA: 0x00010641 File Offset: 0x0000E841
	public bool HasSimpleDesk
	{
		get
		{
			return this.bool_4;
		}
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x0600180A RID: 6154 RVA: 0x00010649 File Offset: 0x0000E849
	public string DescriptionShort
	{
		get
		{
			return this.string_4;
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x0600180B RID: 6155 RVA: 0x00010651 File Offset: 0x0000E851
	public string DescriptionLong
	{
		get
		{
			return this.string_5;
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x0600180C RID: 6156 RVA: 0x00010659 File Offset: 0x0000E859
	public string Recommendation
	{
		get
		{
			return Class298.smethod_2(this.class466_0.String_0 + "Recommendation");
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x0600180D RID: 6157 RVA: 0x00010676 File Offset: 0x0000E876
	public string Consider
	{
		get
		{
			return Class298.smethod_2(this.class466_0.String_0 + "Nuances");
		}
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x00010693 File Offset: 0x0000E893
	internal Class466 method_8()
	{
		return this.class466_0;
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x0001069B File Offset: 0x0000E89B
	internal int method_9()
	{
		return this.class466_0.Int32_0;
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x000106A8 File Offset: 0x0000E8A8
	internal Guid method_10()
	{
		return this.class466_0.Guid_0;
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x06001811 RID: 6161 RVA: 0x000106B5 File Offset: 0x0000E8B5
	public string GroupName
	{
		get
		{
			return Class298.smethod_2(this.class466_0.String_2);
		}
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x000106C7 File Offset: 0x0000E8C7
	internal List<Class245> method_11()
	{
		return this.class466_0.List_5;
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x000106D4 File Offset: 0x0000E8D4
	internal bool method_12()
	{
		return this.class466_0.List_1.Contains("LEVEL");
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x06001814 RID: 6164 RVA: 0x0006D334 File Offset: 0x0006B534
	public bool ShowIncluded
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "afr1[Za-k'", object_);
		}
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x000094FC File Offset: 0x000076FC
	private bool method_13()
	{
		return Class733.smethod_0();
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x06001816 RID: 6166 RVA: 0x000106EC File Offset: 0x0000E8EC
	public bool ShowIncluded2
	{
		get
		{
			return this.class466_0.List_1.Contains("VISIBLETWEAKS");
		}
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x00010704 File Offset: 0x0000E904
	private MaterialIconKind method_14()
	{
		return this.materialIconKind_1;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x0001070C File Offset: 0x0000E90C
	private void method_15(MaterialIconKind materialIconKind_2)
	{
		this.materialIconKind_1 = materialIconKind_2;
	}

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x06001819 RID: 6169 RVA: 0x00010715 File Offset: 0x0000E915
	// (set) Token: 0x0600181A RID: 6170 RVA: 0x0001071D File Offset: 0x0000E91D
	public MaterialIconKind Icon
	{
		get
		{
			return this.method_14();
		}
		set
		{
			this.method_15(value);
			base.method_0("Icon");
		}
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x0600181B RID: 6171 RVA: 0x00010732 File Offset: 0x0000E932
	public List<Class659> TweakInfoVMs
	{
		get
		{
			return this.list_1;
		}
	}

	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x0600181C RID: 6172 RVA: 0x0001073A File Offset: 0x0000E93A
	// (set) Token: 0x0600181D RID: 6173 RVA: 0x00010742 File Offset: 0x0000E942
	public string CurrentValueType
	{
		[CompilerGenerated]
		get
		{
			return this.string_6;
		}
		[CompilerGenerated]
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x0600181E RID: 6174 RVA: 0x0006D36C File Offset: 0x0006B56C
	internal bool Boolean_0
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "\\?NBJZa-k(", object_);
		}
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x0001074B File Offset: 0x0000E94B
	internal bool method_16()
	{
		return this.class466_0.List_1.Contains("PRO");
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x00010763 File Offset: 0x0000E963
	internal bool method_17()
	{
		return this.class466_0.Boolean_1;
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x00010770 File Offset: 0x0000E970
	internal bool method_18()
	{
		return this.CurrentValueType == "DEFAULT";
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x00010783 File Offset: 0x0000E983
	internal bool method_19()
	{
		return this.class466_0.List_2.Contains("EXPERIMENTAL");
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x0006D3A4 File Offset: 0x0006B5A4
	internal bool method_20()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "*3ciXZa-k(", object_);
	}

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06001824 RID: 6180 RVA: 0x0006D3DC File Offset: 0x0006B5DC
	// (set) Token: 0x06001825 RID: 6181 RVA: 0x0001079B File Offset: 0x0000E99B
	public bool ShowFullDescription
	{
		get
		{
			if (this.nullable_1 == null)
			{
				return Class551.class753_0.method_34().GetValueOrDefault();
			}
			return this.nullable_1.Value;
		}
		set
		{
			this.nullable_1 = new bool?(value);
			base.method_0("ShowFullDescription");
		}
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x06001826 RID: 6182 RVA: 0x000107B5 File Offset: 0x0000E9B5
	public Visibility ConsiderVisibility
	{
		get
		{
			return this.visibility_0;
		}
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x000107BD File Offset: 0x0000E9BD
	internal string method_21()
	{
		return this.class466_0.String_0;
	}

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x06001828 RID: 6184 RVA: 0x000107CA File Offset: 0x0000E9CA
	public List<string> WillBrake
	{
		get
		{
			return this.class466_0.List_0;
		}
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06001829 RID: 6185 RVA: 0x000107D7 File Offset: 0x0000E9D7
	// (set) Token: 0x0600182A RID: 6186 RVA: 0x000107DF File Offset: 0x0000E9DF
	public Visibility WarnTextVisibility
	{
		[CompilerGenerated]
		get
		{
			return this.visibility_1;
		}
		[CompilerGenerated]
		set
		{
			this.visibility_1 = value;
		}
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x0600182B RID: 6187 RVA: 0x000107E8 File Offset: 0x0000E9E8
	// (set) Token: 0x0600182C RID: 6188 RVA: 0x000107F0 File Offset: 0x0000E9F0
	public Visibility DescriptionVisibility
	{
		[CompilerGenerated]
		get
		{
			return this.visibility_2;
		}
		[CompilerGenerated]
		set
		{
			this.visibility_2 = value;
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x0600182D RID: 6189 RVA: 0x000107F9 File Offset: 0x0000E9F9
	public Visibility DescriptionVisibilityReverted
	{
		get
		{
			if (this.DescriptionVisibility != Visibility.Visible)
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x0600182E RID: 6190 RVA: 0x00010806 File Offset: 0x0000EA06
	public string WarnText
	{
		get
		{
			return this.string_7;
		}
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x0006D414 File Offset: 0x0006B614
	private string method_22()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "IB^,dZa-k9", object_);
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06001830 RID: 6192 RVA: 0x0001080E File Offset: 0x0000EA0E
	public string Description
	{
		get
		{
			if (!this.class466_0.String_1.smethod_9())
			{
				return Class298.smethod_2(this.class466_0.String_1);
			}
			return Class298.smethod_2(this.class466_0.String_0 + "Desc");
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x06001831 RID: 6193 RVA: 0x0001084E File Offset: 0x0000EA4E
	public string TmType
	{
		get
		{
			return this.class466_0.String_4;
		}
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x06001832 RID: 6194 RVA: 0x0006D448 File Offset: 0x0006B648
	public bool IsCheckReversed
	{
		get
		{
			bool value = this.nullable_2.GetValueOrDefault();
			if (this.nullable_2 == null)
			{
				value = (this.class466_0.String_4 == "DOUBLE" && this.class466_0.method_0());
				this.nullable_2 = new bool?(value);
			}
			return this.nullable_2.Value;
		}
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06001833 RID: 6195 RVA: 0x0001085B File Offset: 0x0000EA5B
	// (set) Token: 0x06001834 RID: 6196 RVA: 0x00010863 File Offset: 0x0000EA63
	public bool ShowDescription
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			this.bool_5 = value;
			base.method_0("ShowDescription");
		}
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06001835 RID: 6197 RVA: 0x00010878 File Offset: 0x0000EA78
	// (set) Token: 0x06001836 RID: 6198 RVA: 0x00010880 File Offset: 0x0000EA80
	public bool ShowTweaks
	{
		get
		{
			return this.bool_6;
		}
		set
		{
			this.bool_6 = value;
			base.method_0("ShowTweaks");
		}
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06001837 RID: 6199 RVA: 0x00010895 File Offset: 0x0000EA95
	// (set) Token: 0x06001838 RID: 6200 RVA: 0x0001089D File Offset: 0x0000EA9D
	public bool OnEdit
	{
		get
		{
			return this.bool_7;
		}
		set
		{
			if (!this.IsEditable)
			{
				return;
			}
			this.bool_7 = value;
			base.method_0("OnEdit");
			base.method_0("IsScript");
		}
	}

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06001839 RID: 6201 RVA: 0x000108C7 File Offset: 0x0000EAC7
	// (set) Token: 0x0600183A RID: 6202 RVA: 0x000108CF File Offset: 0x0000EACF
	public Visibility AddVisibility
	{
		get
		{
			return this.visibility_3;
		}
		set
		{
			this.visibility_3 = value;
			base.method_0("AddVisibility");
		}
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x0600183B RID: 6203 RVA: 0x000108E4 File Offset: 0x0000EAE4
	// (set) Token: 0x0600183C RID: 6204 RVA: 0x000108EC File Offset: 0x0000EAEC
	public Visibility ApplyVisibility
	{
		get
		{
			return this.visibility_4;
		}
		set
		{
			this.visibility_4 = value;
			base.method_0("ApplyVisibility");
		}
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x0600183D RID: 6205 RVA: 0x00010901 File Offset: 0x0000EB01
	// (set) Token: 0x0600183E RID: 6206 RVA: 0x00010909 File Offset: 0x0000EB09
	public Visibility DoubleCBVisibility
	{
		get
		{
			return this.visibility_5;
		}
		set
		{
			this.visibility_5 = value;
			base.method_0("DoubleCBVisibility");
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x0600183F RID: 6207 RVA: 0x0001091E File Offset: 0x0000EB1E
	// (set) Token: 0x06001840 RID: 6208 RVA: 0x00010926 File Offset: 0x0000EB26
	public Visibility DoubleReversedCBVisibility
	{
		get
		{
			return this.visibility_6;
		}
		set
		{
			this.visibility_6 = value;
			base.method_0("DoubleReversedCBVisibility");
		}
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06001841 RID: 6209 RVA: 0x0001093B File Offset: 0x0000EB3B
	// (set) Token: 0x06001842 RID: 6210 RVA: 0x00010943 File Offset: 0x0000EB43
	public Visibility MultiVisibility
	{
		get
		{
			return this.visibility_7;
		}
		set
		{
			this.visibility_7 = value;
			base.method_0("MultiVisibility");
		}
	}

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06001843 RID: 6211 RVA: 0x00010958 File Offset: 0x0000EB58
	// (set) Token: 0x06001844 RID: 6212 RVA: 0x00010960 File Offset: 0x0000EB60
	public Visibility CustomVisibility
	{
		get
		{
			return this.visibility_8;
		}
		set
		{
			this.visibility_8 = value;
			base.method_0("CustomVisibility");
		}
	}

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06001845 RID: 6213 RVA: 0x00010975 File Offset: 0x0000EB75
	// (set) Token: 0x06001846 RID: 6214 RVA: 0x0001097D File Offset: 0x0000EB7D
	public Visibility ImportVisibility
	{
		get
		{
			return this.visibility_9;
		}
		set
		{
			this.visibility_9 = value;
			base.method_0("ImportVisibility");
		}
	}

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06001847 RID: 6215 RVA: 0x00010992 File Offset: 0x0000EB92
	// (set) Token: 0x06001848 RID: 6216 RVA: 0x0001099A File Offset: 0x0000EB9A
	public Visibility ScriptVisibility
	{
		get
		{
			return this.visibility_10;
		}
		set
		{
			this.visibility_10 = value;
			base.method_0("ScriptVisibility");
		}
	}

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001849 RID: 6217 RVA: 0x000109AF File Offset: 0x0000EBAF
	// (set) Token: 0x0600184A RID: 6218 RVA: 0x000109B7 File Offset: 0x0000EBB7
	public Visibility DebloatVisibility
	{
		get
		{
			return this.visibility_11;
		}
		set
		{
			this.visibility_11 = value;
			base.method_0("DebloatVisibility");
		}
	}

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x0600184B RID: 6219 RVA: 0x000109CC File Offset: 0x0000EBCC
	public Visibility NoSupportVisibility
	{
		get
		{
			if (!this.method_20())
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
	}

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x0600184C RID: 6220 RVA: 0x000109D9 File Offset: 0x0000EBD9
	public Visibility ProVisibility
	{
		get
		{
			if (!this.method_16())
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x0600184D RID: 6221 RVA: 0x000109E6 File Offset: 0x0000EBE6
	public Visibility ExpVisibility
	{
		get
		{
			if (!this.method_19())
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x0600184E RID: 6222 RVA: 0x000109F3 File Offset: 0x0000EBF3
	public Visibility ForceOnOffVisibility
	{
		get
		{
			if (!(this.TmType == "DOUBLE"))
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x0600184F RID: 6223 RVA: 0x00010A0B File Offset: 0x0000EC0B
	public bool SignVisibility
	{
		get
		{
			return this.Childs.Count<Class512>() > 0;
		}
	}

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06001850 RID: 6224 RVA: 0x00010A1B File Offset: 0x0000EC1B
	// (set) Token: 0x06001851 RID: 6225 RVA: 0x00010A23 File Offset: 0x0000EC23
	public bool ShowChildList
	{
		get
		{
			return this.bool_8;
		}
		set
		{
			this.bool_8 = value;
			base.method_0("ShowChildList");
		}
	}

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06001852 RID: 6226 RVA: 0x00010A38 File Offset: 0x0000EC38
	// (set) Token: 0x06001853 RID: 6227 RVA: 0x00010A40 File Offset: 0x0000EC40
	public bool? CurrentStatusDouble
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_3;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_3 = value;
		}
	}

	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x06001854 RID: 6228 RVA: 0x00010A49 File Offset: 0x0000EC49
	// (set) Token: 0x06001855 RID: 6229 RVA: 0x0006D4AC File Offset: 0x0006B6AC
	public bool? IsChecked
	{
		get
		{
			return this.nullable_4;
		}
		set
		{
			if (this.method_17())
			{
				this.method_39();
				return;
			}
			if (this.bool_9)
			{
				return;
			}
			if (this.CurrentStatusDouble == null)
			{
				this.CurrentStatusDouble = value;
			}
			this.nullable_4 = value;
			base.method_0("IsChecked");
			base.method_0("HasChanges");
			if (this.bool_10)
			{
				this.method_39();
				this.bool_10 = false;
				return;
			}
			this.method_26();
		}
	}

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x06001856 RID: 6230 RVA: 0x00010A51 File Offset: 0x0000EC51
	// (set) Token: 0x06001857 RID: 6231 RVA: 0x00010A59 File Offset: 0x0000EC59
	public ObservableCollection<GClass176> MultiValues
	{
		get
		{
			return this.observableCollection_3;
		}
		set
		{
			this.observableCollection_3 = value;
			base.method_0("MultiValues");
		}
	}

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x06001858 RID: 6232 RVA: 0x00010A6E File Offset: 0x0000EC6E
	// (set) Token: 0x06001859 RID: 6233 RVA: 0x00010A76 File Offset: 0x0000EC76
	public ObservableCollection<GClass168> CustomValues
	{
		get
		{
			return this.observableCollection_4;
		}
		set
		{
			this.observableCollection_4 = value;
			base.method_0("CustomValues");
		}
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x0006D524 File Offset: 0x0006B724
	private void method_23()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "j05quZa-jQ", object_);
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x0006D554 File Offset: 0x0006B754
	private void method_24()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "gp\"2nZa-jU", object_);
	}

	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x0600185C RID: 6236 RVA: 0x00010A8B File Offset: 0x0000EC8B
	// (set) Token: 0x0600185D RID: 6237 RVA: 0x00010A93 File Offset: 0x0000EC93
	public GClass168 CurrentCustomSelectedValue
	{
		[CompilerGenerated]
		get
		{
			return this.gclass168_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass168_0 = value;
		}
	}

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x0600185E RID: 6238 RVA: 0x00010A9C File Offset: 0x0000EC9C
	// (set) Token: 0x0600185F RID: 6239 RVA: 0x0006D584 File Offset: 0x0006B784
	public GClass168 CustomSelectedValue
	{
		get
		{
			return this.gclass168_1;
		}
		set
		{
			if (this.bool_9)
			{
				return;
			}
			if (this.CurrentCustomSelectedValue == null)
			{
				this.CurrentCustomSelectedValue = value;
			}
			this.gclass168_1 = value;
			this.CustomValue = this.class466_0.method_11();
			this.CustomValueChangerVisible = (value.RawName == "OWNVALUE");
			base.method_0("CustomSelectedValue");
			base.method_0("HasChanges");
			if (this.bool_10)
			{
				this.method_39();
				this.bool_10 = false;
				return;
			}
			if (!this.CustomValueChangerVisible)
			{
				this.method_26();
			}
		}
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06001860 RID: 6240 RVA: 0x00010AA4 File Offset: 0x0000ECA4
	// (set) Token: 0x06001861 RID: 6241 RVA: 0x00010AAC File Offset: 0x0000ECAC
	public int? CurrentSelectedIndex
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_5;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_5 = value;
		}
	}

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06001862 RID: 6242 RVA: 0x00010AB5 File Offset: 0x0000ECB5
	// (set) Token: 0x06001863 RID: 6243 RVA: 0x0006D614 File Offset: 0x0006B814
	public int? SelectedIndex
	{
		get
		{
			return this.nullable_6;
		}
		set
		{
			if (this.bool_9)
			{
				return;
			}
			if (this.CurrentSelectedIndex == null)
			{
				this.CurrentSelectedIndex = value;
			}
			this.nullable_6 = value;
			base.method_0("SelectedIndex");
			base.method_0("HasChanges");
			if (this.bool_10)
			{
				this.method_39();
				this.bool_10 = false;
				return;
			}
			this.method_26();
		}
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x06001864 RID: 6244 RVA: 0x0006D67C File Offset: 0x0006B87C
	public bool HasChanges
	{
		get
		{
			bool? isChecked = this.IsChecked;
			bool? currentStatusDouble = this.CurrentStatusDouble;
			if (isChecked.GetValueOrDefault() == currentStatusDouble.GetValueOrDefault() & isChecked != null == (currentStatusDouble != null))
			{
				int? selectedIndex = this.SelectedIndex;
				int? currentSelectedIndex = this.CurrentSelectedIndex;
				if ((selectedIndex.GetValueOrDefault() == currentSelectedIndex.GetValueOrDefault() & selectedIndex != null == (currentSelectedIndex != null)) && !(this.CurrentCustomValue != this.CustomValue))
				{
					return this.gclass168_1 != this.CurrentCustomSelectedValue;
				}
			}
			return true;
		}
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06001865 RID: 6245 RVA: 0x00010ABD File Offset: 0x0000ECBD
	// (set) Token: 0x06001866 RID: 6246 RVA: 0x00010AC5 File Offset: 0x0000ECC5
	public bool CustomValueChangerVisible
	{
		get
		{
			return this.bool_11;
		}
		set
		{
			this.bool_11 = value;
			base.method_0("CustomValueChangerVisible");
		}
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06001867 RID: 6247 RVA: 0x00010ADA File Offset: 0x0000ECDA
	// (set) Token: 0x06001868 RID: 6248 RVA: 0x00010AE2 File Offset: 0x0000ECE2
	public string CurrentCustomValue
	{
		[CompilerGenerated]
		get
		{
			return this.string_8;
		}
		[CompilerGenerated]
		set
		{
			this.string_8 = value;
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06001869 RID: 6249 RVA: 0x00010AEB File Offset: 0x0000ECEB
	// (set) Token: 0x0600186A RID: 6250 RVA: 0x00010AF3 File Offset: 0x0000ECF3
	public string CustomValue
	{
		get
		{
			return this.string_9;
		}
		set
		{
			if (this.CurrentCustomValue == null)
			{
				this.CurrentCustomValue = value;
			}
			this.string_9 = value;
			base.method_0("HasChanges");
			base.method_0("CustomValue");
		}
	}

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x0600186B RID: 6251 RVA: 0x0006D714 File Offset: 0x0006B914
	public GClass280 CustomOkCmd
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_7) == null)
			{
				result = (this.gclass280_7 = new GClass280(new Action<object>(this.method_53), null));
			}
			return result;
		}
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x0600186C RID: 6252 RVA: 0x00010B23 File Offset: 0x0000ED23
	// (set) Token: 0x0600186D RID: 6253 RVA: 0x00010B30 File Offset: 0x0000ED30
	public bool IsEditable
	{
		get
		{
			return this.class466_0.Boolean_0;
		}
		set
		{
			this.class466_0.Boolean_0 = value;
			base.method_0("IsEditable");
		}
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x0006D748 File Offset: 0x0006B948
	public void method_25(bool bool_12)
	{
		object[] object_ = new object[]
		{
			this,
			bool_12
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), ":9_.5Za-j_", object_);
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x0006D780 File Offset: 0x0006B980
	private void method_26()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "26aKqZa-jY", object_);
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x0006D7B0 File Offset: 0x0006B9B0
	private void method_27()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), ".^6=fZa-j]", object_);
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x0006D7E0 File Offset: 0x0006B9E0
	private void method_28()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "S$9<-Za-hu", object_);
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x0006D810 File Offset: 0x0006BA10
	private GClass67 method_29()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (GClass67)Class392.smethod_3().method_105(Class392.smethod_1(), "qQRB7Za-h9", object_);
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x0006D844 File Offset: 0x0006BA44
	private string method_30()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "5d7Z'Za-jp", object_);
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x0006D878 File Offset: 0x0006BA78
	public string method_31()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (string)Class392.smethod_3().method_105(Class392.smethod_1(), "l`de(Za-jr", object_);
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x0006D8AC File Offset: 0x0006BAAC
	public Task method_32(string string_11)
	{
		object[] object_ = new object[]
		{
			this,
			string_11
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "0X.slZa-h;", object_);
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x0006D8E4 File Offset: 0x0006BAE4
	public Task method_33(GClass67 gclass67_0)
	{
		object[] object_ = new object[]
		{
			this,
			gclass67_0
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), ";R*X:Za-k'", object_);
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x0006D91C File Offset: 0x0006BB1C
	public void method_34()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "j05quZa-i\"", object_);
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x0006D94C File Offset: 0x0006BB4C
	public void method_35()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "`iukXZa-hZ", object_);
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x0006D97C File Offset: 0x0006BB7C
	public void method_36()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "afr1[Za-h]", object_);
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x0006D9AC File Offset: 0x0006BBAC
	public void method_37(string string_11)
	{
		object[] object_ = new object[]
		{
			this,
			string_11
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "gT\\)mZa-k&", object_);
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x0006D9E0 File Offset: 0x0006BBE0
	public void method_38()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "DQpOUZa-h_", object_);
	}

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x0600187C RID: 6268 RVA: 0x00010B4A File Offset: 0x0000ED4A
	public GClass280 ForceOn
	{
		get
		{
			return new GClass280(new Action<object>(this.method_56), null);
		}
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x0600187D RID: 6269 RVA: 0x00010B5E File Offset: 0x0000ED5E
	public GClass280 ForceOff
	{
		get
		{
			return new GClass280(new Action<object>(this.method_57), null);
		}
	}

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x0600187E RID: 6270 RVA: 0x0006DA10 File Offset: 0x0006BC10
	public GClass280 EditCommand
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (GClass280)Class392.smethod_3().method_105(Class392.smethod_1(), "Ej2sYZa-jc", object_);
		}
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x0006DA44 File Offset: 0x0006BC44
	public void method_39()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "c*4U_Za-hb", object_);
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x0006DA74 File Offset: 0x0006BC74
	public bool method_40()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "=Ko3?Za-k(", object_);
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x0006DAAC File Offset: 0x0006BCAC
	public int method_41()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (int)Class392.smethod_3().method_105(Class392.smethod_1(), "s0/o<Za-hX", object_);
	}

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06001882 RID: 6274 RVA: 0x00010B72 File Offset: 0x0000ED72
	// (set) Token: 0x06001883 RID: 6275 RVA: 0x00010B7A File Offset: 0x0000ED7A
	public string Status
	{
		get
		{
			return this.string_10;
		}
		set
		{
			this.string_10 = value;
			base.method_0("Status");
		}
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06001884 RID: 6276 RVA: 0x00010B8F File Offset: 0x0000ED8F
	// (set) Token: 0x06001885 RID: 6277 RVA: 0x00010B97 File Offset: 0x0000ED97
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

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06001886 RID: 6278 RVA: 0x00010BAC File Offset: 0x0000EDAC
	// (set) Token: 0x06001887 RID: 6279 RVA: 0x00010BB4 File Offset: 0x0000EDB4
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

	// Token: 0x06001888 RID: 6280 RVA: 0x0006DAE4 File Offset: 0x0006BCE4
	public Task method_42(string string_11, SolidColorBrush solidColorBrush_1)
	{
		object[] object_ = new object[]
		{
			this,
			string_11,
			solidColorBrush_1
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "m'3t*Za-jb", object_);
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x0006DB20 File Offset: 0x0006BD20
	private void method_43(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "i3B\\sZa-jf", object_);
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x0006DB54 File Offset: 0x0006BD54
	private void method_44(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "#dLeEZa-jf", object_);
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x0006DB88 File Offset: 0x0006BD88
	private void method_45(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "@'R,HZa-jg", object_);
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x0006DBBC File Offset: 0x0006BDBC
	private void method_46(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "A$NGKZa-jh", object_);
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x0006DBF0 File Offset: 0x0006BDF0
	private void method_47(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), ".^?CgZa-jj", object_);
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x0006DC24 File Offset: 0x0006BE24
	private void method_48(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "KsA%mZa-jl", object_);
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x0006DC58 File Offset: 0x0006BE58
	private void method_49(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "CpCCTZa-jm", object_);
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x0006DC8C File Offset: 0x0006BE8C
	private void method_50()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "%^<@JZa-hI", object_);
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x0006DCBC File Offset: 0x0006BEBC
	private void method_51()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "$F$qFZa-hO", object_);
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x0006DCEC File Offset: 0x0006BEEC
	private void method_52()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "#dC_DZa-hR", object_);
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x0006DD1C File Offset: 0x0006BF1C
	private void method_53(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "a0E%ZZa-jO", object_);
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0006DD50 File Offset: 0x0006BF50
	private void method_54()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "OKc.\"Za-hV", object_);
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x0006DD80 File Offset: 0x0006BF80
	private Class803 method_55()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class803)Class392.smethod_3().method_105(Class392.smethod_1(), "\\ZrQLZa-jR", object_);
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x0006DDB4 File Offset: 0x0006BFB4
	private void method_56(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "8[5\\1Za-jO", object_);
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
	private void method_57(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "GHnQ_Za-jP", object_);
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x0006DE1C File Offset: 0x0006C01C
	private void method_58(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "b-A@]Za-jQ", object_);
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x0006DE50 File Offset: 0x0006C050
	private Task method_59()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "8?oS0Za-jS", object_);
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x00010BC9 File Offset: 0x0000EDC9
	private static void smethod_0(ref Class512.Struct217 struct217_0)
	{
		struct217_0.asyncTaskMethodBuilder_0.Start<Class512.Struct217>(ref struct217_0);
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x0006DE84 File Offset: 0x0006C084
	private static void smethod_1(ref MaterialIconKind materialIconKind_2, ref ObservableCollection<Class489> observableCollection_5, ref ObservableCollection<Class489> observableCollection_6, ref List<Class512> list_2, ref ObservableCollection<Class512> observableCollection_7, ref Visibility visibility_12, ref Visibility visibility_13, ref Visibility visibility_14, ref Visibility visibility_15, ref Visibility visibility_16, ref Visibility visibility_17, ref Visibility visibility_18, ref Visibility visibility_19, ref Visibility visibility_20, ref Visibility visibility_21, ref Visibility visibility_22, ref Visibility visibility_23, ref string string_11, ref SolidColorBrush solidColorBrush_1, ref CancellationTokenSource cancellationTokenSource_1)
	{
		object[] array = new object[]
		{
			materialIconKind_2,
			observableCollection_5,
			observableCollection_6,
			list_2,
			observableCollection_7,
			visibility_12,
			visibility_13,
			visibility_14,
			visibility_15,
			visibility_16,
			visibility_17,
			visibility_18,
			visibility_19,
			visibility_20,
			visibility_21,
			visibility_22,
			visibility_23,
			string_11,
			solidColorBrush_1,
			cancellationTokenSource_1
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "Og)7#Za-k4", array);
		}
		finally
		{
			materialIconKind_2 = (MaterialIconKind)array[0];
			observableCollection_5 = (ObservableCollection<Class489>)array[1];
			observableCollection_6 = (ObservableCollection<Class489>)array[2];
			list_2 = (List<Class512>)array[3];
			observableCollection_7 = (ObservableCollection<Class512>)array[4];
			visibility_12 = (Visibility)array[5];
			visibility_13 = (Visibility)array[6];
			visibility_14 = (Visibility)array[7];
			visibility_15 = (Visibility)array[8];
			visibility_16 = (Visibility)array[9];
			visibility_17 = (Visibility)array[10];
			visibility_18 = (Visibility)array[11];
			visibility_19 = (Visibility)array[12];
			visibility_20 = (Visibility)array[13];
			visibility_21 = (Visibility)array[14];
			visibility_22 = (Visibility)array[15];
			visibility_23 = (Visibility)array[16];
			string_11 = (string)array[17];
			solidColorBrush_1 = (SolidColorBrush)array[18];
			cancellationTokenSource_1 = (CancellationTokenSource)array[19];
		}
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x0006E1A8 File Offset: 0x0006C3A8
	private void method_60(Type type_1, Class466 class466_1, bool bool_12)
	{
		object[] object_ = new object[]
		{
			this,
			type_1,
			class466_1,
			bool_12
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "`3?YVZa-k7", object_);
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00010BD7 File Offset: 0x0000EDD7
	private static void smethod_2(ref Class512.Struct221 struct221_0)
	{
		struct221_0.asyncVoidMethodBuilder_0.Start<Class512.Struct221>(ref struct221_0);
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x00010BE5 File Offset: 0x0000EDE5
	private static void smethod_3(ref Class512.Struct223 struct223_0)
	{
		struct223_0.asyncVoidMethodBuilder_0.Start<Class512.Struct223>(ref struct223_0);
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x00010BF3 File Offset: 0x0000EDF3
	private static void smethod_4(ref Class512.Struct222 struct222_0)
	{
		struct222_0.asyncVoidMethodBuilder_0.Start<Class512.Struct222>(ref struct222_0);
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x00010C01 File Offset: 0x0000EE01
	private static void smethod_5(ref Class512.Struct216 struct216_0)
	{
		struct216_0.asyncVoidMethodBuilder_0.Start<Class512.Struct216>(ref struct216_0);
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x00010C0F File Offset: 0x0000EE0F
	private static void smethod_6(ref Class512.Struct220 struct220_0)
	{
		struct220_0.asyncVoidMethodBuilder_0.Start<Class512.Struct220>(ref struct220_0);
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x00010C1D File Offset: 0x0000EE1D
	private static void smethod_7(ref Class512.Struct224 struct224_0)
	{
		struct224_0.asyncVoidMethodBuilder_0.Start<Class512.Struct224>(ref struct224_0);
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x00010C2B File Offset: 0x0000EE2B
	private static void smethod_8(ref Class512.Struct218 struct218_0)
	{
		struct218_0.asyncVoidMethodBuilder_0.Start<Class512.Struct218>(ref struct218_0);
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x00010C39 File Offset: 0x0000EE39
	private static void smethod_9(ref Class512.Struct215 struct215_0)
	{
		struct215_0.asyncTaskMethodBuilder_0.Start<Class512.Struct215>(ref struct215_0);
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x00010C47 File Offset: 0x0000EE47
	private static void smethod_10(ref Class512.Struct214 struct214_0)
	{
		struct214_0.asyncTaskMethodBuilder_0.Start<Class512.Struct214>(ref struct214_0);
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00010C55 File Offset: 0x0000EE55
	private static void smethod_11(ref Class512.Struct219 struct219_0)
	{
		struct219_0.asyncTaskMethodBuilder_0.Start<Class512.Struct219>(ref struct219_0);
	}

	// Token: 0x04000FE3 RID: 4067
	private string string_0;

	// Token: 0x04000FE4 RID: 4068
	private string string_1;

	// Token: 0x04000FE5 RID: 4069
	private MaterialIconKind materialIconKind_0;

	// Token: 0x04000FE6 RID: 4070
	private bool bool_0;

	// Token: 0x04000FE7 RID: 4071
	private bool? nullable_0;

	// Token: 0x04000FE8 RID: 4072
	private GClass280 gclass280_0;

	// Token: 0x04000FE9 RID: 4073
	private GClass280 gclass280_1;

	// Token: 0x04000FEA RID: 4074
	private GClass280 gclass280_2;

	// Token: 0x04000FEB RID: 4075
	private ObservableCollection<Class489> observableCollection_0;

	// Token: 0x04000FEC RID: 4076
	private ObservableCollection<Class489> observableCollection_1;

	// Token: 0x04000FED RID: 4077
	public GClass280 gclass280_3;

	// Token: 0x04000FEE RID: 4078
	public GClass280 gclass280_4;

	// Token: 0x04000FEF RID: 4079
	public GClass280 gclass280_5;

	// Token: 0x04000FF0 RID: 4080
	public GClass280 gclass280_6;

	// Token: 0x04000FF1 RID: 4081
	private bool bool_1;

	// Token: 0x04000FF2 RID: 4082
	private readonly Class466 class466_0;

	// Token: 0x04000FF3 RID: 4083
	internal Class803 class803_0;

	// Token: 0x04000FF4 RID: 4084
	internal Type type_0;

	// Token: 0x04000FF5 RID: 4085
	public bool bool_2;

	// Token: 0x04000FF6 RID: 4086
	public List<Class512> list_0;

	// Token: 0x04000FF7 RID: 4087
	private ObservableCollection<Class512> observableCollection_2;

	// Token: 0x04000FF8 RID: 4088
	private string string_2;

	// Token: 0x04000FF9 RID: 4089
	private string string_3;

	// Token: 0x04000FFA RID: 4090
	private bool bool_3;

	// Token: 0x04000FFB RID: 4091
	private bool bool_4;

	// Token: 0x04000FFC RID: 4092
	private string string_4;

	// Token: 0x04000FFD RID: 4093
	private string string_5;

	// Token: 0x04000FFE RID: 4094
	private MaterialIconKind materialIconKind_1;

	// Token: 0x04000FFF RID: 4095
	public List<Class659> list_1;

	// Token: 0x04001000 RID: 4096
	private string string_6;

	// Token: 0x04001001 RID: 4097
	public bool? nullable_1;

	// Token: 0x04001002 RID: 4098
	public Visibility visibility_0;

	// Token: 0x04001003 RID: 4099
	private Visibility visibility_1;

	// Token: 0x04001004 RID: 4100
	private Visibility visibility_2;

	// Token: 0x04001005 RID: 4101
	public string string_7;

	// Token: 0x04001006 RID: 4102
	private bool? nullable_2;

	// Token: 0x04001007 RID: 4103
	private bool bool_5;

	// Token: 0x04001008 RID: 4104
	private bool bool_6;

	// Token: 0x04001009 RID: 4105
	private bool bool_7;

	// Token: 0x0400100A RID: 4106
	private Visibility visibility_3;

	// Token: 0x0400100B RID: 4107
	private Visibility visibility_4;

	// Token: 0x0400100C RID: 4108
	private Visibility visibility_5;

	// Token: 0x0400100D RID: 4109
	private Visibility visibility_6;

	// Token: 0x0400100E RID: 4110
	private Visibility visibility_7;

	// Token: 0x0400100F RID: 4111
	private Visibility visibility_8;

	// Token: 0x04001010 RID: 4112
	private Visibility visibility_9;

	// Token: 0x04001011 RID: 4113
	private Visibility visibility_10;

	// Token: 0x04001012 RID: 4114
	private Visibility visibility_11;

	// Token: 0x04001013 RID: 4115
	private bool bool_8;

	// Token: 0x04001014 RID: 4116
	private bool? nullable_3;

	// Token: 0x04001015 RID: 4117
	private bool bool_9;

	// Token: 0x04001016 RID: 4118
	private bool bool_10;

	// Token: 0x04001017 RID: 4119
	private bool? nullable_4;

	// Token: 0x04001018 RID: 4120
	private ObservableCollection<GClass176> observableCollection_3;

	// Token: 0x04001019 RID: 4121
	private ObservableCollection<GClass168> observableCollection_4;

	// Token: 0x0400101A RID: 4122
	private GClass168 gclass168_0;

	// Token: 0x0400101B RID: 4123
	private GClass168 gclass168_1;

	// Token: 0x0400101C RID: 4124
	private int? nullable_5;

	// Token: 0x0400101D RID: 4125
	private int? nullable_6;

	// Token: 0x0400101E RID: 4126
	public bool bool_11;

	// Token: 0x0400101F RID: 4127
	private string string_8;

	// Token: 0x04001020 RID: 4128
	public string string_9;

	// Token: 0x04001021 RID: 4129
	private GClass280 gclass280_7;

	// Token: 0x04001022 RID: 4130
	private GClass280 gclass280_8;

	// Token: 0x04001023 RID: 4131
	private string string_10;

	// Token: 0x04001024 RID: 4132
	private SolidColorBrush solidColorBrush_0;

	// Token: 0x04001025 RID: 4133
	private double double_0;

	// Token: 0x04001026 RID: 4134
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x020003A0 RID: 928
	private sealed class Class426
	{
		// Token: 0x060018A8 RID: 6312 RVA: 0x00010C63 File Offset: 0x0000EE63
		internal void method_0()
		{
			Class803 class803_ = this.class512_0.class803_0;
			if (class803_ == null)
			{
				return;
			}
			class803_.imethod_3(this.gclass67_0);
		}

		// Token: 0x04001027 RID: 4135
		public Class512 class512_0;

		// Token: 0x04001028 RID: 4136
		public GClass67 gclass67_0;
	}

	// Token: 0x020003A1 RID: 929
	private sealed class Class427
	{
		// Token: 0x060018AA RID: 6314 RVA: 0x00010C80 File Offset: 0x0000EE80
		internal void method_0(string string_0)
		{
			this.list_0.Add(Class298.smethod_2(string_0));
		}

		// Token: 0x04001029 RID: 4137
		public List<string> list_0;
	}

	// Token: 0x020003A2 RID: 930
	private sealed class Class428
	{
		// Token: 0x060018AC RID: 6316 RVA: 0x00010C93 File Offset: 0x0000EE93
		internal bool method_0(GClass168 gclass168_0)
		{
			return gclass168_0.RawName == this.string_0;
		}

		// Token: 0x0400102A RID: 4138
		public string string_0;
	}

	// Token: 0x020003A3 RID: 931
	[StructLayout(LayoutKind.Auto)]
	private struct Struct214 : IAsyncStateMachine
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x0006E1E8 File Offset: 0x0006C3E8
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
				@class.method_64(stream_, ">d:]DZa-k)", array);
			}
			finally
			{
				this = (Class512.Struct214)array[0];
			}
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00010CA6 File Offset: 0x0000EEA6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct214 struct214_0)
		{
			struct214_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct214>(ref taskAwaiter_1, ref struct214_0);
		}

		// Token: 0x0400102B RID: 4139
		public int int_0;

		// Token: 0x0400102C RID: 4140
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400102D RID: 4141
		public Class512 class512_0;

		// Token: 0x0400102E RID: 4142
		public GClass67 gclass67_0;

		// Token: 0x0400102F RID: 4143
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A4 RID: 932
	[StructLayout(LayoutKind.Auto)]
	private struct Struct215 : IAsyncStateMachine
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x0006E250 File Offset: 0x0006C450
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
				@class.method_64(stream_, "qm!Q9Za-k$", array);
			}
			finally
			{
				this = (Class512.Struct215)array[0];
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00010CC3 File Offset: 0x0000EEC3
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00010CD1 File Offset: 0x0000EED1
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct215 struct215_0)
		{
			struct215_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct215>(ref taskAwaiter_1, ref struct215_0);
		}

		// Token: 0x04001030 RID: 4144
		public int int_0;

		// Token: 0x04001031 RID: 4145
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001032 RID: 4146
		public Class512 class512_0;

		// Token: 0x04001033 RID: 4147
		public string string_0;

		// Token: 0x04001034 RID: 4148
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A5 RID: 933
	[StructLayout(LayoutKind.Auto)]
	private struct Struct216 : IAsyncStateMachine
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x0006E2B8 File Offset: 0x0006C4B8
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
				@class.method_64(stream_, "q6796Za-jV", array);
			}
			finally
			{
				this = (Class512.Struct216)array[0];
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00010CEE File Offset: 0x0000EEEE
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct216 struct216_0)
		{
			struct216_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct216>(ref taskAwaiter_1, ref struct216_0);
		}

		// Token: 0x04001035 RID: 4149
		public int int_0;

		// Token: 0x04001036 RID: 4150
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001037 RID: 4151
		public Class512 class512_0;

		// Token: 0x04001038 RID: 4152
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A6 RID: 934
	[StructLayout(LayoutKind.Auto)]
	private struct Struct217 : IAsyncStateMachine
	{
		// Token: 0x060018B6 RID: 6326 RVA: 0x0006E320 File Offset: 0x0006C520
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
				@class.method_64(stream_, "kcqP&Za-j[", array);
			}
			finally
			{
				this = (Class512.Struct217)array[0];
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00010CFD File Offset: 0x0000EEFD
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_3(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_4(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_5(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_6(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_7(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_8(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_9(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_10(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_11(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_12(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_13(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_14(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_15(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_16(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_17(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_18(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_19(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_20(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00010D0B File Offset: 0x0000EF0B
		private static void MoveNext_21(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct217 struct217_0)
		{
			struct217_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct217>(ref taskAwaiter_1, ref struct217_0);
		}

		// Token: 0x04001039 RID: 4153
		public int int_0;

		// Token: 0x0400103A RID: 4154
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400103B RID: 4155
		public Class512 class512_0;

		// Token: 0x0400103C RID: 4156
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A7 RID: 935
	[StructLayout(LayoutKind.Auto)]
	private struct Struct218 : IAsyncStateMachine
	{
		// Token: 0x060018CE RID: 6350 RVA: 0x0006E388 File Offset: 0x0006C588
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
				@class.method_64(stream_, "m]a++Za-hc", array);
			}
			finally
			{
				this = (Class512.Struct218)array[0];
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00010D1A File Offset: 0x0000EF1A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00010D28 File Offset: 0x0000EF28
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct218 struct218_0)
		{
			struct218_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct218>(ref taskAwaiter_1, ref struct218_0);
		}

		// Token: 0x0400103D RID: 4157
		public int int_0;

		// Token: 0x0400103E RID: 4158
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400103F RID: 4159
		public Class512 class512_0;

		// Token: 0x04001040 RID: 4160
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003A8 RID: 936
	private sealed class Class429
	{
		// Token: 0x060018D2 RID: 6354 RVA: 0x00010D37 File Offset: 0x0000EF37
		internal void method_0()
		{
			Class803 class803_ = this.class512_0.class803_0;
			if (class803_ == null)
			{
				return;
			}
			GClass67 gclass = new GClass67();
			gclass.method_1(this.string_0);
			class803_.imethod_3(gclass);
		}

		// Token: 0x04001041 RID: 4161
		public Class512 class512_0;

		// Token: 0x04001042 RID: 4162
		public string string_0;
	}

	// Token: 0x020003A9 RID: 937
	private sealed class Class430
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		internal void method_0()
		{
			this.class512_0.CurrentCustomSelectedValue = null;
			this.class512_0.CurrentStatusDouble = null;
			this.class512_0.CurrentSelectedIndex = null;
			this.class512_0.CurrentCustomValue = null;
			this.class512_0.CurrentValueType = this.class512_0.class466_0.method_10(this.bool_0);
			if (this.class512_0.class466_0.String_4 == "DOUBLE")
			{
				if (this.class512_0.IsCheckReversed)
				{
					this.class512_0.IsChecked = new bool?(this.class512_0.CurrentValueType != "BEST");
					this.class512_0.DoubleReversedCBVisibility = Visibility.Visible;
				}
				else
				{
					this.class512_0.IsChecked = new bool?(this.class512_0.CurrentValueType != "DEFAULT");
					this.class512_0.DoubleCBVisibility = Visibility.Visible;
				}
			}
			else if (this.class512_0.class466_0.String_4 == "DEBLOAT")
			{
				this.class512_0.IsChecked = new bool?(this.class512_0.CurrentValueType != "DEFAULT");
				this.class512_0.DebloatVisibility = Visibility.Visible;
			}
			else if (this.class512_0.class466_0.String_4 == "CUSTOM_VALUE")
			{
				this.class512_0.CustomVisibility = Visibility.Visible;
				if (this.class512_0.observableCollection_4 == null)
				{
					this.class512_0.method_23();
				}
				else
				{
					this.class512_0.method_24();
				}
			}
			else if (this.class512_0.class466_0.String_4 == "MULTI")
			{
				this.class512_0.MultiVisibility = Visibility.Visible;
				if (this.class512_0.MultiValues == null)
				{
					this.class512_0.MultiValues = Class475.smethod_0().method_2(this.class512_0.class466_0.List_5.First<Class245>().List_0);
				}
				this.class512_0.SelectedIndex = new int?((this.class512_0.CurrentValueType == "DEFAULT") ? 0 : ((this.class512_0.CurrentValueType == "OPTIMAL") ? 1 : 2));
			}
			else if (this.class512_0.class466_0.String_4 == "IMPORT" || this.class512_0.class466_0.String_4 == "SCRIPT")
			{
				if (this.class512_0.class466_0.String_4 == "IMPORT")
				{
					this.class512_0.ImportVisibility = Visibility.Visible;
				}
				if (this.class512_0.class466_0.String_4 == "SCRIPT")
				{
					this.class512_0.ScriptVisibility = Visibility.Visible;
				}
				this.class512_0.IsChecked = new bool?(false);
			}
			this.class512_0.method_0("IsChecked");
			this.class512_0.method_0("HasChanges");
			this.class512_0.bool_2 = true;
		}

		// Token: 0x04001043 RID: 4163
		public Class512 class512_0;

		// Token: 0x04001044 RID: 4164
		public bool bool_0;
	}

	// Token: 0x020003AA RID: 938
	private sealed class Class431
	{
		// Token: 0x060018D6 RID: 6358 RVA: 0x0006E724 File Offset: 0x0006C924
		internal void method_0()
		{
			this.list_0.Add(new GClass168(new Class275
			{
				List_0 = new List<string>
				{
					"OWNVALUE"
				}
			}));
			this.class512_0.CustomValues = new ObservableCollection<GClass168>(this.list_0);
			this.class512_0.method_24();
		}

		// Token: 0x04001045 RID: 4165
		public List<GClass168> list_0;

		// Token: 0x04001046 RID: 4166
		public Class512 class512_0;
	}

	// Token: 0x020003AB RID: 939
	[StructLayout(LayoutKind.Auto)]
	private struct Struct219 : IAsyncStateMachine
	{
		// Token: 0x060018D7 RID: 6359 RVA: 0x0006E780 File Offset: 0x0006C980
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
				@class.method_64(stream_, "l*7Y'Za-jd", array);
			}
			finally
			{
				this = (Class512.Struct219)array[0];
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00010D5F File Offset: 0x0000EF5F
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00010D6D File Offset: 0x0000EF6D
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct219 struct219_0)
		{
			struct219_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct219>(ref taskAwaiter_1, ref struct219_0);
		}

		// Token: 0x04001047 RID: 4167
		public int int_0;

		// Token: 0x04001048 RID: 4168
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04001049 RID: 4169
		public Class512 class512_0;

		// Token: 0x0400104A RID: 4170
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x0400104B RID: 4171
		public string string_0;

		// Token: 0x0400104C RID: 4172
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003AC RID: 940
	[StructLayout(LayoutKind.Auto)]
	private struct Struct220 : IAsyncStateMachine
	{
		// Token: 0x060018DA RID: 6362 RVA: 0x0006E7E8 File Offset: 0x0006C9E8
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
				@class.method_64(stream_, "hQXDpZa-jZ", array);
			}
			finally
			{
				this = (Class512.Struct220)array[0];
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00010D7C File Offset: 0x0000EF7C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00010D8A File Offset: 0x0000EF8A
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct220 struct220_0)
		{
			struct220_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct220>(ref taskAwaiter_1, ref struct220_0);
		}

		// Token: 0x0400104D RID: 4173
		public int int_0;

		// Token: 0x0400104E RID: 4174
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400104F RID: 4175
		public Class512 class512_0;

		// Token: 0x04001050 RID: 4176
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003AD RID: 941
	private sealed class Class432
	{
		// Token: 0x060018DE RID: 6366 RVA: 0x00010D99 File Offset: 0x0000EF99
		internal bool method_0(GClass168 gclass168_0)
		{
			return gclass168_0.RawName == this.string_0;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00010D99 File Offset: 0x0000EF99
		internal bool method_1(GClass168 gclass168_0)
		{
			return gclass168_0.RawName == this.string_0;
		}

		// Token: 0x04001051 RID: 4177
		public string string_0;
	}

	// Token: 0x020003AE RID: 942
	[StructLayout(LayoutKind.Auto)]
	private struct Struct221 : IAsyncStateMachine
	{
		// Token: 0x060018E0 RID: 6368 RVA: 0x0006E850 File Offset: 0x0006CA50
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
				@class.method_64(stream_, "Fg/9\\Za-ja", array);
			}
			finally
			{
				this = (Class512.Struct221)array[0];
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00010DAC File Offset: 0x0000EFAC
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00010DBA File Offset: 0x0000EFBA
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct221 struct221_0)
		{
			struct221_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct221>(ref taskAwaiter_1, ref struct221_0);
		}

		// Token: 0x04001052 RID: 4178
		public int int_0;

		// Token: 0x04001053 RID: 4179
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001054 RID: 4180
		public Class512 class512_0;

		// Token: 0x04001055 RID: 4181
		public bool bool_0;

		// Token: 0x04001056 RID: 4182
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003AF RID: 943
	private sealed class Class433
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x00010DC9 File Offset: 0x0000EFC9
		internal void method_0()
		{
			this.class431_0.list_0.Add(new GClass168(this.class275_0));
		}

		// Token: 0x04001057 RID: 4183
		public Class275 class275_0;

		// Token: 0x04001058 RID: 4184
		public Class512.Class431 class431_0;
	}

	// Token: 0x020003B0 RID: 944
	[StructLayout(LayoutKind.Auto)]
	private struct Struct222 : IAsyncStateMachine
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x0006E8B8 File Offset: 0x0006CAB8
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
				@class.method_64(stream_, "J?ZGgZa-jR", array);
			}
			finally
			{
				this = (Class512.Struct222)array[0];
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00010DE6 File Offset: 0x0000EFE6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct222 struct222_0)
		{
			struct222_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct222>(ref taskAwaiter_1, ref struct222_0);
		}

		// Token: 0x04001059 RID: 4185
		public int int_0;

		// Token: 0x0400105A RID: 4186
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400105B RID: 4187
		public Class512 class512_0;

		// Token: 0x0400105C RID: 4188
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003B1 RID: 945
	[StructLayout(LayoutKind.Auto)]
	private struct Struct223 : IAsyncStateMachine
	{
		// Token: 0x060018E8 RID: 6376 RVA: 0x0006E920 File Offset: 0x0006CB20
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
				@class.method_64(stream_, "Qa!m)Za-jn", array);
			}
			finally
			{
				this = (Class512.Struct223)array[0];
			}
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00010E03 File Offset: 0x0000F003
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00010E11 File Offset: 0x0000F011
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref Class512.Struct223 struct223_0)
		{
			struct223_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct223>(ref taskAwaiter_1, ref struct223_0);
		}

		// Token: 0x0400105D RID: 4189
		public int int_0;

		// Token: 0x0400105E RID: 4190
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400105F RID: 4191
		public Class512 class512_0;

		// Token: 0x04001060 RID: 4192
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x020003B2 RID: 946
	[StructLayout(LayoutKind.Auto)]
	private struct Struct224 : IAsyncStateMachine
	{
		// Token: 0x060018EB RID: 6379 RVA: 0x0006E988 File Offset: 0x0006CB88
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
				@class.method_64(stream_, "\"gGDAZa-hl", array);
			}
			finally
			{
				this = (Class512.Struct224)array[0];
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00010E20 File Offset: 0x0000F020
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00010E2E File Offset: 0x0000F02E
		private static void MoveNext(ref TaskAwaiter<Class512> taskAwaiter_2, ref Class512.Struct224 struct224_0)
		{
			struct224_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class512>, Class512.Struct224>(ref taskAwaiter_2, ref struct224_0);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00010E2E File Offset: 0x0000F02E
		private static void MoveNext_1(ref TaskAwaiter<Class512> taskAwaiter_2, ref Class512.Struct224 struct224_0)
		{
			struct224_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<Class512>, Class512.Struct224>(ref taskAwaiter_2, ref struct224_0);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00010E3D File Offset: 0x0000F03D
		private static void MoveNext_2(ref TaskAwaiter taskAwaiter_2, ref Class512.Struct224 struct224_0)
		{
			struct224_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct224>(ref taskAwaiter_2, ref struct224_0);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00010E3D File Offset: 0x0000F03D
		private static void MoveNext_3(ref TaskAwaiter taskAwaiter_2, ref Class512.Struct224 struct224_0)
		{
			struct224_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Struct224>(ref taskAwaiter_2, ref struct224_0);
		}

		// Token: 0x04001061 RID: 4193
		public int int_0;

		// Token: 0x04001062 RID: 4194
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04001063 RID: 4195
		public Class512 class512_0;

		// Token: 0x04001064 RID: 4196
		private List<string>.Enumerator enumerator_0;

		// Token: 0x04001065 RID: 4197
		private TaskAwaiter<Class512> taskAwaiter_0;

		// Token: 0x04001066 RID: 4198
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x020003B3 RID: 947
	[Serializable]
	private sealed class Class434
	{
		// Token: 0x060018F3 RID: 6387 RVA: 0x00010E58 File Offset: 0x0000F058
		internal bool method_0(Class245 class245_0)
		{
			return class245_0.String_0 == "SCRIPT";
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00010E6B File Offset: 0x0000F06B
		internal bool method_1(GClass168 gclass168_0)
		{
			return gclass168_0.method_5();
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00010E73 File Offset: 0x0000F073
		internal void method_2(Class512 class512_0)
		{
			class512_0.IsChecked = new bool?(true);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00010E81 File Offset: 0x0000F081
		internal void method_3(Class512 class512_0)
		{
			class512_0.IsChecked = new bool?(false);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00010E8F File Offset: 0x0000F08F
		internal bool method_4(GClass168 gclass168_0)
		{
			return gclass168_0.method_6();
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00010E8F File Offset: 0x0000F08F
		internal bool method_5(GClass168 gclass168_0)
		{
			return gclass168_0.method_6();
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00010E97 File Offset: 0x0000F097
		internal bool method_6(GClass168 gclass168_0)
		{
			return gclass168_0.method_7();
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00010E97 File Offset: 0x0000F097
		internal bool method_7(GClass168 gclass168_0)
		{
			return gclass168_0.method_7();
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00010E6B File Offset: 0x0000F06B
		internal bool method_8(GClass168 gclass168_0)
		{
			return gclass168_0.method_5();
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00010E6B File Offset: 0x0000F06B
		internal bool method_9(GClass168 gclass168_0)
		{
			return gclass168_0.method_5();
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00010E9F File Offset: 0x0000F09F
		internal void method_10(GClass176 gclass176_0)
		{
			gclass176_0.method_2();
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00010EA7 File Offset: 0x0000F0A7
		internal void method_11(GClass168 gclass168_0)
		{
			gclass168_0.method_9();
		}

		// Token: 0x04001067 RID: 4199
		public static readonly Class512.Class434 class434_0 = new Class512.Class434();

		// Token: 0x04001068 RID: 4200
		public static Func<Class245, bool> func_0;

		// Token: 0x04001069 RID: 4201
		public static Func<GClass168, bool> func_1;

		// Token: 0x0400106A RID: 4202
		public static Action<Class512> action_0;

		// Token: 0x0400106B RID: 4203
		public static Action<Class512> action_1;

		// Token: 0x0400106C RID: 4204
		public static Func<GClass168, bool> func_2;

		// Token: 0x0400106D RID: 4205
		public static Func<GClass168, bool> func_3;

		// Token: 0x0400106E RID: 4206
		public static Func<GClass168, bool> func_4;

		// Token: 0x0400106F RID: 4207
		public static Func<GClass168, bool> func_5;

		// Token: 0x04001070 RID: 4208
		public static Func<GClass168, bool> func_6;

		// Token: 0x04001071 RID: 4209
		public static Func<GClass168, bool> func_7;

		// Token: 0x04001072 RID: 4210
		public static Action<GClass176> action_2;

		// Token: 0x04001073 RID: 4211
		public static Action<GClass168> action_3;
	}

	// Token: 0x020003B4 RID: 948
	private sealed class Class435
	{
		// Token: 0x06001900 RID: 6400 RVA: 0x0006E9F0 File Offset: 0x0006CBF0
		internal Task method_0()
		{
			Class512.Class435.Struct225 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class435_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<Class512.Class435.Struct225>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x04001074 RID: 4212
		public Class512 class512_0;

		// Token: 0x04001075 RID: 4213
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04001076 RID: 4214
		public string string_0;

		// Token: 0x020003B5 RID: 949
		[StructLayout(LayoutKind.Auto)]
		private struct Struct225 : IAsyncStateMachine
		{
			// Token: 0x06001901 RID: 6401 RVA: 0x0006EA34 File Offset: 0x0006CC34
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				Class512.Class435 @class = this.class435_0;
				try
				{
					if (num > 1)
					{
						if (@class.class512_0.type_0 != null && !Class406.smethod_0().method_2(@class.class512_0.type_0))
						{
							@class.class512_0.double_0 = 1.0;
							@class.class512_0.solidColorBrush_0 = @class.solidColorBrush_0;
							@class.class512_0.string_10 = @class.string_0;
							goto IL_280;
						}
						try
						{
							@class.class512_0.cancellationTokenSource_0.Cancel();
							@class.class512_0.cancellationTokenSource_0.Dispose();
						}
						catch
						{
						}
						@class.class512_0.cancellationTokenSource_0 = new CancellationTokenSource();
						this.cancellationToken_0 = @class.class512_0.cancellationTokenSource_0.Token;
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
							goto IL_177;
						}
						if (num == 1)
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							int num3 = -1;
							num = -1;
							this.int_0 = num3;
							goto IL_1F9;
						}
						IL_109:
						if (@class.class512_0.StatusOpacity <= 0.0)
						{
							@class.class512_0.StatusForeground = @class.solidColorBrush_0;
							@class.class512_0.Status = @class.string_0;
							goto IL_200;
						}
						this.cancellationToken_0.ThrowIfCancellationRequested();
						@class.class512_0.StatusOpacity = Math.Max(0.0, @class.class512_0.StatusOpacity - 0.1);
						awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							num = 0;
							this.int_0 = num4;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Class435.Struct225>(ref awaiter, ref this);
							return;
						}
						IL_177:
						awaiter.GetResult();
						goto IL_109;
						IL_1F9:
						awaiter.GetResult();
						IL_200:
						if (@class.class512_0.StatusOpacity < 1.0)
						{
							this.cancellationToken_0.ThrowIfCancellationRequested();
							@class.class512_0.StatusOpacity = Math.Min(1.0, @class.class512_0.StatusOpacity + 0.13333333333333333);
							awaiter = Task.Delay(10, this.cancellationToken_0).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_1F9;
							}
							int num5 = 1;
							num = 1;
							this.int_0 = num5;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Class512.Class435.Struct225>(ref awaiter, ref this);
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
				IL_280:
				this.int_0 = -2;
				this.cancellationToken_0 = default(CancellationToken);
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001902 RID: 6402 RVA: 0x00010EAF File Offset: 0x0000F0AF
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04001077 RID: 4215
			public int int_0;

			// Token: 0x04001078 RID: 4216
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04001079 RID: 4217
			public Class512.Class435 class435_0;

			// Token: 0x0400107A RID: 4218
			private CancellationToken cancellationToken_0;

			// Token: 0x0400107B RID: 4219
			private TaskAwaiter taskAwaiter_0;
		}
	}

	// Token: 0x020003B6 RID: 950
	private sealed class Class436
	{
		// Token: 0x06001904 RID: 6404 RVA: 0x00010EBD File Offset: 0x0000F0BD
		internal void method_0(Class245 class245_0)
		{
			this.list_0.Add(new Class659(class245_0, this.class512_0.ShowIncluded));
		}

		// Token: 0x0400107C RID: 4220
		public List<Class659> list_0;

		// Token: 0x0400107D RID: 4221
		public Class512 class512_0;
	}
}
