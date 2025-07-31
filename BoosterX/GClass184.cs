using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

// Token: 0x02000412 RID: 1042
public sealed class GClass184 : GClass162
{
	// Token: 0x06001AEC RID: 6892 RVA: 0x0001215F File Offset: 0x0001035F
	public GClass184(GClass189 gclass189_1)
	{
		GClass184.smethod_0(ref this.list_0, ref this.bool_3, ref this.bool_4, ref this.bool_5);
		base..ctor();
		this.method_21(gclass189_1);
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x00074AE8 File Offset: 0x00072CE8
	private void method_2(object sender, PropertyChangedEventArgs e)
	{
		object[] object_ = new object[]
		{
			this,
			sender,
			e
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "-bd!qZa-hI", object_);
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00074B20 File Offset: 0x00072D20
	private void method_3()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "cG$]nZa-hN", object_);
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x00074B50 File Offset: 0x00072D50
	private void method_4()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "SA)D<Za-hR", object_);
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x00074B80 File Offset: 0x00072D80
	private void method_5()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "l+XR4Za-hV", object_);
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x00074BB0 File Offset: 0x00072DB0
	public Task method_6()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Task)Class392.smethod_3().method_105(Class392.smethod_1(), "b.b9jZa-h:", object_);
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x00074BE4 File Offset: 0x00072DE4
	private void method_7()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "XM2*LZa-hW", object_);
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x00074C14 File Offset: 0x00072E14
	private void method_8(GClass184 gclass184_0)
	{
		object[] object_ = new object[]
		{
			this,
			gclass184_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "LVC1'Za-h>", object_);
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0001218B File Offset: 0x0001038B
	// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x00012193 File Offset: 0x00010393
	public GClass189 WinServiceViewModel
	{
		get
		{
			return this.gclass189_0;
		}
		set
		{
			this.gclass189_0 = value;
		}
	}

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0001219C File Offset: 0x0001039C
	// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x000121A4 File Offset: 0x000103A4
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

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x000121B9 File Offset: 0x000103B9
	// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x000121C1 File Offset: 0x000103C1
	public bool Loaded
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			if (value == this.bool_2)
			{
				return;
			}
			this.bool_2 = value;
			base.method_0("Loaded");
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06001AFA RID: 6906 RVA: 0x000121E0 File Offset: 0x000103E0
	// (set) Token: 0x06001AFB RID: 6907 RVA: 0x000121E8 File Offset: 0x000103E8
	public bool ShowDescription
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (value == this.bool_0)
			{
				return;
			}
			this.bool_0 = value;
			base.method_0("ShowDescription");
		}
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00012207 File Offset: 0x00010407
	// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0001220F File Offset: 0x0001040F
	public bool ShowChildList
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			if (value == this.bool_1)
			{
				return;
			}
			this.bool_1 = value;
			base.method_0("ShowChildList");
		}
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x00074C48 File Offset: 0x00072E48
	public void method_9()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "F2#&hZa-hW", object_);
	}

	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0001222E File Offset: 0x0001042E
	// (set) Token: 0x06001B00 RID: 6912 RVA: 0x00012236 File Offset: 0x00010436
	public bool EnableParents
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			if (value == this.bool_3)
			{
				return;
			}
			this.bool_3 = value;
			base.method_0("EnableParents");
		}
	}

	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x06001B01 RID: 6913 RVA: 0x00012255 File Offset: 0x00010455
	// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0001225D File Offset: 0x0001045D
	public bool DisableChildren
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			if (value == this.bool_4)
			{
				return;
			}
			this.bool_4 = value;
			base.method_0("DisableChildren");
		}
	}

	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06001B03 RID: 6915 RVA: 0x00074C78 File Offset: 0x00072E78
	public GClass280 RevertCommand
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

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06001B04 RID: 6916 RVA: 0x00074CAC File Offset: 0x00072EAC
	public GClass280 RevertTreeCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_18), null));
			}
			return result;
		}
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x00074CE0 File Offset: 0x00072EE0
	private void method_10(GClass184 gclass184_0)
	{
		object[] object_ = new object[]
		{
			this,
			gclass184_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "MmTn!Za-jM", object_);
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0001227C File Offset: 0x0001047C
	// (set) Token: 0x06001B07 RID: 6919 RVA: 0x00012289 File Offset: 0x00010489
	public GClass165 Service
	{
		get
		{
			return this.WinServiceViewModel.Service;
		}
		set
		{
			this.WinServiceViewModel.Service = value;
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00012297 File Offset: 0x00010497
	public string DisplayName
	{
		get
		{
			return this.WinServiceViewModel.DisplayName;
		}
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06001B09 RID: 6921 RVA: 0x000122A4 File Offset: 0x000104A4
	public string CurrentLocalization
	{
		get
		{
			return Class298.smethod_2("CurrentLocalization");
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00074D14 File Offset: 0x00072F14
	public string WillBrake
	{
		get
		{
			GClass184.Class468 @class = new GClass184.Class468();
			if (this.WinServiceViewModel.WillBrake == null)
			{
				return Class298.smethod_2("Unknown");
			}
			if (this.WinServiceViewModel.WillBrake[0] == string.Empty)
			{
				return Class298.smethod_2("Unknown");
			}
			@class.list_0 = new List<string>();
			this.WinServiceViewModel.WillBrake.ForEach(new Action<string>(@class.method_0));
			return string.Join(", ", @class.list_0);
		}
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06001B0B RID: 6923 RVA: 0x000122B1 File Offset: 0x000104B1
	public bool IsService
	{
		get
		{
			return this.WinServiceViewModel.IsService;
		}
	}

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06001B0C RID: 6924 RVA: 0x000122BE File Offset: 0x000104BE
	public string ServiceName
	{
		get
		{
			return this.WinServiceViewModel.ServiceName;
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06001B0D RID: 6925 RVA: 0x000122CB File Offset: 0x000104CB
	public BitmapSource Icon
	{
		get
		{
			return this.WinServiceViewModel.Icon;
		}
	}

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000122D8 File Offset: 0x000104D8
	// (set) Token: 0x06001B0F RID: 6927 RVA: 0x000122E5 File Offset: 0x000104E5
	public string Description
	{
		get
		{
			return this.WinServiceViewModel.Description;
		}
		set
		{
			this.WinServiceViewModel.Description = value;
		}
	}

	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x06001B10 RID: 6928 RVA: 0x000122F3 File Offset: 0x000104F3
	public List<GClass189> DependenciesLinear
	{
		get
		{
			return this.WinServiceViewModel.DependenciesLinear;
		}
	}

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06001B11 RID: 6929 RVA: 0x00012300 File Offset: 0x00010500
	// (set) Token: 0x06001B12 RID: 6930 RVA: 0x00074DA4 File Offset: 0x00072FA4
	public List<GClass184> DependenciesTree
	{
		get
		{
			return this.list_0;
		}
		set
		{
			if (object.Equals(value, this.list_0))
			{
				return;
			}
			this.list_0.ForEach(new Action<GClass184>(this.method_19));
			this.list_0 = value;
			this.list_0.ForEach(new Action<GClass184>(this.method_20));
			base.method_0("DependenciesTree");
			base.method_0("DependenciesTreeHasChanges");
		}
	}

	// Token: 0x06001B13 RID: 6931 RVA: 0x00074E10 File Offset: 0x00073010
	private void method_11(object sender, PropertyChangedEventArgs e)
	{
		object[] object_ = new object[]
		{
			this,
			sender,
			e
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "iP)_,Za-hJ", object_);
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00012308 File Offset: 0x00010508
	public bool DependenciesTreeHasValue
	{
		get
		{
			return this.WinServiceViewModel.DependenciesTreeHasValue;
		}
	}

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00012315 File Offset: 0x00010515
	public bool DependenciesTreeHasChanges
	{
		get
		{
			return this.method_12(this.DependenciesTree);
		}
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x00074E48 File Offset: 0x00073048
	private bool method_12(List<GClass184> list_1)
	{
		object[] object_ = new object[]
		{
			this,
			list_1
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "PI.a)Za-j2", object_);
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x00074E84 File Offset: 0x00073084
	private bool method_13(GClass184 gclass184_0)
	{
		object[] object_ = new object[]
		{
			this,
			gclass184_0
		};
		return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "-FC1fZa-j2", object_);
	}

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06001B18 RID: 6936 RVA: 0x00012323 File Offset: 0x00010523
	public List<GClass189> DependOn
	{
		get
		{
			return this.WinServiceViewModel.DependOn;
		}
	}

	// Token: 0x17000470 RID: 1136
	// (set) Token: 0x06001B19 RID: 6937 RVA: 0x00012330 File Offset: 0x00010530
	public bool ShowDisplayName
	{
		set
		{
			this.WinServiceViewModel.ShowDisplayName = value;
		}
	}

	// Token: 0x17000471 RID: 1137
	// (get) Token: 0x06001B1A RID: 6938 RVA: 0x00074EC0 File Offset: 0x000730C0
	// (set) Token: 0x06001B1B RID: 6939 RVA: 0x00074EF8 File Offset: 0x000730F8
	public ServiceStartMode NewStartMode
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (ServiceStartMode)Class392.smethod_3().method_105(Class392.smethod_1(), "\"LPSDZa-j3", object_);
		}
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "TsV57Za-j4", object_);
		}
	}

	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0001233E File Offset: 0x0001053E
	public bool NewStartModeChanged
	{
		get
		{
			return this.WinServiceViewModel.NewStartModeChanged;
		}
	}

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00074F30 File Offset: 0x00073130
	// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00074F68 File Offset: 0x00073168
	public ServiceControllerStatus NewStatus
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (ServiceControllerStatus)Class392.smethod_3().method_105(Class392.smethod_1(), "34-*#Za-j4", object_);
		}
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), ">I:fFZa-j4", object_);
		}
	}

	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0001234B File Offset: 0x0001054B
	public bool NewStatusChanged
	{
		get
		{
			return this.WinServiceViewModel.NewStatusChanged;
		}
	}

	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00012358 File Offset: 0x00010558
	public bool HasChanges
	{
		get
		{
			return this.WinServiceViewModel.HasChanges;
		}
	}

	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00012365 File Offset: 0x00010565
	// (set) Token: 0x06001B22 RID: 6946 RVA: 0x00012372 File Offset: 0x00010572
	public string ServiceViewName
	{
		get
		{
			return this.WinServiceViewModel.ServiceViewName;
		}
		set
		{
			this.WinServiceViewModel.ServiceViewName = value;
		}
	}

	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00012380 File Offset: 0x00010580
	public ServiceStartMode? DefaultStartMode
	{
		get
		{
			return this.WinServiceViewModel.DefaultStartMode;
		}
	}

	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0001238D File Offset: 0x0001058D
	public bool DefaultStartNodeExists
	{
		get
		{
			return this.WinServiceViewModel.DefaultStartNodeExists;
		}
	}

	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0001239A File Offset: 0x0001059A
	public string DependOnString
	{
		get
		{
			return this.WinServiceViewModel.DependOnString;
		}
	}

	// Token: 0x1700047A RID: 1146
	// (get) Token: 0x06001B26 RID: 6950 RVA: 0x000123A7 File Offset: 0x000105A7
	public string ServiceDependencies
	{
		get
		{
			return this.WinServiceViewModel.ServiceDependencies;
		}
	}

	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x06001B27 RID: 6951 RVA: 0x000123B4 File Offset: 0x000105B4
	public bool IsBlocked
	{
		get
		{
			return this.WinServiceViewModel.IsBlocked;
		}
	}

	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06001B28 RID: 6952 RVA: 0x000123C1 File Offset: 0x000105C1
	public bool CheckBoxEnabled
	{
		get
		{
			return this.WinServiceViewModel.CheckBoxEnabled;
		}
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06001B29 RID: 6953 RVA: 0x00074FA0 File Offset: 0x000731A0
	// (set) Token: 0x06001B2A RID: 6954 RVA: 0x00074FD8 File Offset: 0x000731D8
	public bool IsChecked
	{
		get
		{
			object[] object_ = new object[]
			{
				this
			};
			return (bool)Class392.smethod_3().method_105(Class392.smethod_1(), "X0f:AZa-j0", object_);
		}
		set
		{
			object[] object_ = new object[]
			{
				this,
				value
			};
			Class392.smethod_3().method_64(Class392.smethod_1(), "cEt!dZa-j0", object_);
		}
	}

	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x06001B2B RID: 6955 RVA: 0x000123CE File Offset: 0x000105CE
	public bool IsDefault
	{
		get
		{
			return this.WinServiceViewModel.IsDefault;
		}
	}

	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06001B2C RID: 6956 RVA: 0x000123DB File Offset: 0x000105DB
	public bool IsDisabled
	{
		get
		{
			return this.WinServiceViewModel.IsDisabled;
		}
	}

	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x06001B2D RID: 6957 RVA: 0x000123E8 File Offset: 0x000105E8
	// (set) Token: 0x06001B2E RID: 6958 RVA: 0x000123F0 File Offset: 0x000105F0
	public bool IsClickable
	{
		get
		{
			return this.bool_5;
		}
		set
		{
			if (value == this.bool_5)
			{
				return;
			}
			this.bool_5 = value;
			base.method_0("IsClickable");
		}
	}

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0001240F File Offset: 0x0001060F
	// (set) Token: 0x06001B30 RID: 6960 RVA: 0x00012417 File Offset: 0x00010617
	public bool IsUserChecked
	{
		[CompilerGenerated]
		get
		{
			return this.bool_6;
		}
		[CompilerGenerated]
		set
		{
			this.bool_6 = value;
		}
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x00075010 File Offset: 0x00073210
	private void method_14(object sender, PropertyChangedEventArgs e)
	{
		object[] object_ = new object[]
		{
			this,
			sender,
			e
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "S%c;;Za-hK", object_);
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x00075048 File Offset: 0x00073248
	private Class799 method_15()
	{
		object[] object_ = new object[]
		{
			this
		};
		return (Class799)Class392.smethod_3().method_105(Class392.smethod_1(), "9XM47Za-j5", object_);
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x0007507C File Offset: 0x0007327C
	private void method_16()
	{
		object[] object_ = new object[]
		{
			this
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "X1l!KZa-hX", object_);
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x000750AC File Offset: 0x000732AC
	private void method_17(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "n?fU1Za-j6", object_);
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x000750E0 File Offset: 0x000732E0
	private void method_18(object object_0)
	{
		object[] object_ = new object[]
		{
			this,
			object_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "0=8-oZa-j6", object_);
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x00075114 File Offset: 0x00073314
	private void method_19(GClass184 gclass184_0)
	{
		object[] object_ = new object[]
		{
			this,
			gclass184_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "Q*ds+Za-j/", object_);
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x00075148 File Offset: 0x00073348
	private void method_20(GClass184 gclass184_0)
	{
		object[] object_ = new object[]
		{
			this,
			gclass184_0
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "'=>0SZa-j/", object_);
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x0007517C File Offset: 0x0007337C
	private static void smethod_0(ref List<GClass184> list_1, ref bool bool_7, ref bool bool_8, ref bool bool_9)
	{
		object[] array = new object[]
		{
			list_1,
			bool_7,
			bool_8,
			bool_9
		};
		Class31 @class = Class392.smethod_3();
		Stream stream_ = Class392.smethod_1();
		try
		{
			@class.method_64(stream_, "_S3FbZa-hd", array);
		}
		finally
		{
			list_1 = (List<GClass184>)array[0];
			bool_7 = (bool)array[1];
			bool_8 = (bool)array[2];
			bool_9 = (bool)array[3];
		}
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x00075248 File Offset: 0x00073448
	private void method_21(GClass189 gclass189_1)
	{
		object[] object_ = new object[]
		{
			this,
			gclass189_1
		};
		Class392.smethod_3().method_64(Class392.smethod_1(), "1;:0'Za-hh", object_);
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x00012420 File Offset: 0x00010620
	private static void smethod_1(ref GClass184.Struct259 struct259_0)
	{
		struct259_0.asyncVoidMethodBuilder_0.Start<GClass184.Struct259>(ref struct259_0);
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x0001242E File Offset: 0x0001062E
	private static void smethod_2(ref GClass184.Struct258 struct258_0)
	{
		struct258_0.asyncTaskMethodBuilder_0.Start<GClass184.Struct258>(ref struct258_0);
	}

	// Token: 0x040011FD RID: 4605
	private GClass189 gclass189_0;

	// Token: 0x040011FE RID: 4606
	private List<GClass184> list_0;

	// Token: 0x040011FF RID: 4607
	private bool bool_0;

	// Token: 0x04001200 RID: 4608
	private bool bool_1;

	// Token: 0x04001201 RID: 4609
	private bool bool_2;

	// Token: 0x04001202 RID: 4610
	private bool bool_3;

	// Token: 0x04001203 RID: 4611
	private bool bool_4;

	// Token: 0x04001204 RID: 4612
	private Visibility visibility_0;

	// Token: 0x04001205 RID: 4613
	private GClass280 gclass280_0;

	// Token: 0x04001206 RID: 4614
	private GClass280 gclass280_1;

	// Token: 0x04001207 RID: 4615
	private bool bool_5;

	// Token: 0x04001208 RID: 4616
	private bool bool_6;

	// Token: 0x02000413 RID: 1043
	[StructLayout(LayoutKind.Auto)]
	private struct Struct258 : IAsyncStateMachine
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x0007527C File Offset: 0x0007347C
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
				@class.method_64(stream_, ")SWVdZa-h;", array);
			}
			finally
			{
				this = (GClass184.Struct258)array[0];
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0001243C File Offset: 0x0001063C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0001244A File Offset: 0x0001064A
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass184.Struct258 struct258_0)
		{
			struct258_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass184.Struct258>(ref taskAwaiter_1, ref struct258_0);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0001244A File Offset: 0x0001064A
		private static void MoveNext_1(ref TaskAwaiter taskAwaiter_1, ref GClass184.Struct258 struct258_0)
		{
			struct258_0.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass184.Struct258>(ref taskAwaiter_1, ref struct258_0);
		}

		// Token: 0x04001209 RID: 4617
		public int int_0;

		// Token: 0x0400120A RID: 4618
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x0400120B RID: 4619
		public GClass184 gclass184_0;

		// Token: 0x0400120C RID: 4620
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000414 RID: 1044
	[StructLayout(LayoutKind.Auto)]
	private struct Struct259 : IAsyncStateMachine
	{
		// Token: 0x06001B40 RID: 6976 RVA: 0x000752E4 File Offset: 0x000734E4
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
				@class.method_64(stream_, "]=t\\[Za-hT", array);
			}
			finally
			{
				this = (GClass184.Struct259)array[0];
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00012459 File Offset: 0x00010659
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00012467 File Offset: 0x00010667
		private static void MoveNext(ref TaskAwaiter taskAwaiter_1, ref GClass184.Struct259 struct259_0)
		{
			struct259_0.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass184.Struct259>(ref taskAwaiter_1, ref struct259_0);
		}

		// Token: 0x0400120D RID: 4621
		public int int_0;

		// Token: 0x0400120E RID: 4622
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x0400120F RID: 4623
		public GClass184 gclass184_0;

		// Token: 0x04001210 RID: 4624
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000415 RID: 1045
	private sealed class Class468
	{
		// Token: 0x06001B44 RID: 6980 RVA: 0x00012476 File Offset: 0x00010676
		internal void method_0(string string_0)
		{
			this.list_0.Add(Class298.smethod_2(string_0));
		}

		// Token: 0x04001211 RID: 4625
		public List<string> list_0;
	}

	// Token: 0x02000416 RID: 1046
	[Serializable]
	private sealed class Class469
	{
		// Token: 0x06001B47 RID: 6983 RVA: 0x00012495 File Offset: 0x00010695
		internal GClass184 method_0(GClass189 gclass189_0)
		{
			return new GClass184(gclass189_0);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0000C810 File Offset: 0x0000AA10
		internal void method_1(GClass184 gclass184_0)
		{
			gclass184_0.WinServiceViewModel.method_7();
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0001249D File Offset: 0x0001069D
		internal void method_2(GClass189 gclass189_0)
		{
			gclass189_0.method_8();
		}

		// Token: 0x04001212 RID: 4626
		public static readonly GClass184.Class469 class469_0 = new GClass184.Class469();

		// Token: 0x04001213 RID: 4627
		public static Func<GClass189, GClass184> func_0;

		// Token: 0x04001214 RID: 4628
		public static Action<GClass184> action_0;

		// Token: 0x04001215 RID: 4629
		public static Action<GClass189> action_1;
	}
}
