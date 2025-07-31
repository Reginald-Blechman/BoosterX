using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using DiskDetector;
using DiskDetector.Models;
using ns0;

// Token: 0x02000260 RID: 608
public sealed class GClass174 : GClass162
{
	// Token: 0x0600105B RID: 4187 RVA: 0x0005775C File Offset: 0x0005595C
	public GClass174(dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd_1)
	{
		this.dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd_0 = dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd_1;
		this.icommand_0 = new GClass280(new Action<object>(this.method_7), null);
		this.method_2();
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x0600105C RID: 4188 RVA: 0x0000BF69 File Offset: 0x0000A169
	// (set) Token: 0x0600105D RID: 4189 RVA: 0x0000BF71 File Offset: 0x0000A171
	public string CurrentPF
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

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x0600105E RID: 4190 RVA: 0x0000BF7A File Offset: 0x0000A17A
	// (set) Token: 0x0600105F RID: 4191 RVA: 0x0000BF82 File Offset: 0x0000A182
	public SolidColorBrush CurrentPFColor
	{
		[CompilerGenerated]
		get
		{
			return this.solidColorBrush_0;
		}
		[CompilerGenerated]
		set
		{
			this.solidColorBrush_0 = value;
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06001060 RID: 4192 RVA: 0x0000BF8B File Offset: 0x0000A18B
	// (set) Token: 0x06001061 RID: 4193 RVA: 0x0000BF93 File Offset: 0x0000A193
	public string CurrentPFExistency
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

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06001062 RID: 4194 RVA: 0x0000BF9C File Offset: 0x0000A19C
	// (set) Token: 0x06001063 RID: 4195 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
	public SolidColorBrush CurrentPFExistsColor
	{
		[CompilerGenerated]
		get
		{
			return this.solidColorBrush_1;
		}
		[CompilerGenerated]
		set
		{
			this.solidColorBrush_1 = value;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06001064 RID: 4196 RVA: 0x0000BFAD File Offset: 0x0000A1AD
	// (set) Token: 0x06001065 RID: 4197 RVA: 0x0000BFB5 File Offset: 0x0000A1B5
	public string CurrentPFFreeSpace
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

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06001066 RID: 4198 RVA: 0x0000BFBE File Offset: 0x0000A1BE
	// (set) Token: 0x06001067 RID: 4199 RVA: 0x0000BFC6 File Offset: 0x0000A1C6
	public SolidColorBrush CurrentPFFreeSpacesColor
	{
		[CompilerGenerated]
		get
		{
			return this.solidColorBrush_2;
		}
		[CompilerGenerated]
		set
		{
			this.solidColorBrush_2 = value;
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06001068 RID: 4200 RVA: 0x0000BFCF File Offset: 0x0000A1CF
	// (set) Token: 0x06001069 RID: 4201 RVA: 0x0000BFD7 File Offset: 0x0000A1D7
	public Visibility PageFileNotSetWarnVisibility
	{
		[CompilerGenerated]
		get
		{
			return this.visibility_0;
		}
		[CompilerGenerated]
		set
		{
			this.visibility_0 = value;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x0600106A RID: 4202 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
	// (set) Token: 0x0600106B RID: 4203 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
	public Visibility FreeSpaceOnDisksWarnVisibility
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

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x0600106C RID: 4204 RVA: 0x0000BFF1 File Offset: 0x0000A1F1
	// (set) Token: 0x0600106D RID: 4205 RVA: 0x0000BFF9 File Offset: 0x0000A1F9
	public bool ShowDisks
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

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x0600106E RID: 4206 RVA: 0x0000C002 File Offset: 0x0000A202
	public Visibility DisksVisibility
	{
		get
		{
			if (!this.ShowDisks)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x0600106F RID: 4207 RVA: 0x0000C00F File Offset: 0x0000A20F
	// (set) Token: 0x06001070 RID: 4208 RVA: 0x0000C017 File Offset: 0x0000A217
	public ObservableCollection<GClass174.GClass175> Disks
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

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06001071 RID: 4209 RVA: 0x0000C020 File Offset: 0x0000A220
	// (set) Token: 0x06001072 RID: 4210 RVA: 0x0000C028 File Offset: 0x0000A228
	public string PFRecomendationText
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

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06001073 RID: 4211 RVA: 0x0000C031 File Offset: 0x0000A231
	// (set) Token: 0x06001074 RID: 4212 RVA: 0x0000C039 File Offset: 0x0000A239
	public Visibility EnableButtonVisibility
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

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06001075 RID: 4213 RVA: 0x0000C042 File Offset: 0x0000A242
	// (set) Token: 0x06001076 RID: 4214 RVA: 0x0000C04A File Offset: 0x0000A24A
	public string StatusText
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

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06001077 RID: 4215 RVA: 0x0000C053 File Offset: 0x0000A253
	// (set) Token: 0x06001078 RID: 4216 RVA: 0x0000C05B File Offset: 0x0000A25B
	public SolidColorBrush StatusColor
	{
		[CompilerGenerated]
		get
		{
			return this.solidColorBrush_3;
		}
		[CompilerGenerated]
		set
		{
			this.solidColorBrush_3 = value;
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06001079 RID: 4217 RVA: 0x0000C064 File Offset: 0x0000A264
	// (set) Token: 0x0600107A RID: 4218 RVA: 0x0000C06C File Offset: 0x0000A26C
	public double StatusOpacity
	{
		[CompilerGenerated]
		get
		{
			return this.double_0;
		}
		[CompilerGenerated]
		set
		{
			this.double_0 = value;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x0600107B RID: 4219 RVA: 0x0000C075 File Offset: 0x0000A275
	public ICommand EnableCmd
	{
		[CompilerGenerated]
		get
		{
			return this.icommand_0;
		}
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00057800 File Offset: 0x00055A00
	private void method_2()
	{
		this.StatusOpacity = 0.0;
		this.FreeSpaceOnDisksWarnVisibility = Visibility.Collapsed;
		GClass214.GClass215 gclass = GClass214.smethod_8();
		List<GClass214.GClass216> list = GClass214.smethod_6();
		if (gclass != null && gclass.method_6())
		{
			this.CurrentPF = Class298.smethod_2("Automatic");
			this.CurrentPFColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;
			this.PageFileNotSetWarnVisibility = Visibility.Collapsed;
		}
		else if (gclass == null)
		{
			this.CurrentPF = Class298.smethod_2("Disabled");
			this.CurrentPFColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
			this.PageFileNotSetWarnVisibility = Visibility.Visible;
		}
		else
		{
			this.CurrentPF = Class298.smethod_2("Manual");
			this.CurrentPFColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd;
			this.PageFileNotSetWarnVisibility = Visibility.Collapsed;
		}
		List<string> list2 = GClass214.smethod_3();
		if (Class746.smethod_3<string>(list2))
		{
			this.CurrentPFExistency = string.Join(", ", list2.Select(new Func<string, string>(GClass174.Class284.class284_0.method_0)));
			this.CurrentPFExistsColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;
		}
		else
		{
			this.CurrentPFExistency = "Отсутствует";
			this.CurrentPFExistsColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
		}
		if (Class746.smethod_3<string>(list2))
		{
			GClass174.Class282 @class = new GClass174.Class282();
			GClass174.Class282 class2 = @class;
			string pathRoot = Path.GetPathRoot(list2.First<string>());
			class2.string_0 = ((pathRoot != null) ? pathRoot.TrimEnd(new char[]
			{
				'\\'
			}) : null);
			GClass214.GClass216 gclass2 = list.FirstOrDefault(new Func<GClass214.GClass216, bool>(@class.method_0));
			if (gclass2 != null)
			{
				double num = Math.Round((double)gclass2.method_0() / 1024.0 / 1024.0 / 1024.0, 1);
				this.CurrentPFFreeSpace = string.Format("{0} ГБ", num);
				if ((double)gclass2.method_0() < (double)gclass2.method_2() * 0.1)
				{
					this.CurrentPFFreeSpacesColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd;
					this.FreeSpaceOnDisksWarnVisibility = Visibility.Visible;
				}
				else
				{
					this.CurrentPFFreeSpacesColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;
				}
			}
			else
			{
				this.CurrentPFFreeSpace = "-";
				this.CurrentPFFreeSpacesColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd;
			}
		}
		else
		{
			this.CurrentPFFreeSpace = "-";
			this.CurrentPFFreeSpacesColor = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zSYYZ9DTVXRCFXBZ_ejd;
		}
		this.Disks.Clear();
		GClass214.GClass216 gclass3;
		if ((gclass3 = list.Where(new Func<GClass214.GClass216, bool>(this.method_8)).OrderByDescending(new Func<GClass214.GClass216, long>(GClass174.Class284.class284_0.method_1)).FirstOrDefault<GClass214.GClass216>()) == null)
		{
			gclass3 = list.OrderByDescending(new Func<GClass214.GClass216, long>(GClass174.Class284.class284_0.method_2)).FirstOrDefault<GClass214.GClass216>();
		}
		GClass214.GClass216 gclass4 = gclass3;
		using (List<GClass214.GClass216>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass174.Class281 class3 = new GClass174.Class281();
				class3.gclass216_0 = enumerator.Current;
				bool flag = list2.Any(new Func<string, bool>(class3.method_0));
				this.Disks.Add(new GClass174.GClass175
				{
					Letter = class3.gclass216_0.Name,
					Type = this.method_4(class3.gclass216_0.Name),
					FreeSize = string.Format("{0} ГБ", Math.Round((double)class3.gclass216_0.method_0() / 1024.0 / 1024.0 / 1024.0, 1)),
					PFEnabled = (flag ? "Да" : "Нет"),
					PFRecommended = ((gclass4 == null || !(gclass4.Name == class3.gclass216_0.Name)) ? string.Empty : "Рекомендуется")
				});
			}
		}
		this.method_3(gclass, list);
		this.EnableButtonVisibility = ((this.PFRecomendationText != "Все параметры оптимальны.") ? Visibility.Visible : Visibility.Collapsed);
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00057BEC File Offset: 0x00055DEC
	private void method_3(GClass214.GClass215 gclass215_0, List<GClass214.GClass216> list_0)
	{
		List<string> list = new List<string>();
		List<string> list2 = GClass214.smethod_7();
		if (gclass215_0 != null && Class746.smethod_3<string>(list2))
		{
			if (gclass215_0.method_6() && !gclass215_0.method_8())
			{
				list.Add("Автоматический файл подкачки не найден. Проверьте настройки системы.");
			}
			if (gclass215_0.method_6())
			{
				goto IL_161;
			}
			using (List<string>.Enumerator enumerator = list2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string path = enumerator.Current;
					GClass174.Class283 @class = new GClass174.Class283();
					GClass174.Class283 class2 = @class;
					string pathRoot = Path.GetPathRoot(path);
					class2.string_0 = ((pathRoot != null) ? pathRoot.TrimEnd(new char[]
					{
						'\\'
					}) : null);
					GClass214.GClass216 gclass = list_0.FirstOrDefault(new Func<GClass214.GClass216, bool>(@class.method_0));
					if (gclass != null)
					{
						if (this.method_4(gclass.Name) == "HDD")
						{
							list.Add("Файл подкачки находится на медленном диске (" + @class.string_0 + "). Рекомендуется перенести на SSD.");
						}
						if ((double)gclass.method_0() < (double)gclass.method_2() * 0.1)
						{
							double num = Math.Round((double)gclass.method_0() / 1024.0 / 1024.0 / 1024.0, 1);
							list.Add(string.Format("На диске [{0}] осталось мало места ({1} ГБ). Рекомендуется освободить пространство или выбрать другой диск.", @class.string_0, num));
						}
					}
				}
				goto IL_161;
			}
		}
		list.Add("Файл подкачки отключен. Рекомендуется включить для улучшения производительности.");
		IL_161:
		this.PFRecomendationText = (Class746.smethod_3<string>(list) ? string.Join("\n", list.Distinct<string>()) : "Все параметры оптимальны.");
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00057D94 File Offset: 0x00055F94
	private string method_4(string string_5)
	{
		string result;
		try
		{
			HardwareType hardwareType = Detector.DetectDrive(string_5, 0, true).HardwareType;
			string text;
			if (hardwareType != 1)
			{
				if (hardwareType == 2)
				{
					text = "SSD";
				}
				else
				{
					text = "Unknown";
				}
			}
			else
			{
				text = "HDD";
			}
			result = text;
		}
		catch
		{
			result = "Unknown";
		}
		return result;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00057DF0 File Offset: 0x00055FF0
	private Task method_5()
	{
		GClass174.Struct141 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass174_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass174.Struct141>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00057E34 File Offset: 0x00056034
	private Task method_6(string string_5, SolidColorBrush solidColorBrush_4)
	{
		GClass174.Struct142 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass174_0 = this;
		@struct.string_0 = string_5;
		@struct.solidColorBrush_0 = solidColorBrush_4;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass174.Struct142>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00057E88 File Offset: 0x00056088
	private void method_7(object object_0)
	{
		GClass174.Struct140 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass174_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass174.Struct140>(ref @struct);
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x0000C07D File Offset: 0x0000A27D
	private bool method_8(GClass214.GClass216 gclass216_0)
	{
		return this.method_4(gclass216_0.Name) == "SSD";
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x0000C07D File Offset: 0x0000A27D
	private bool method_9(GClass214.GClass216 gclass216_0)
	{
		return this.method_4(gclass216_0.Name) == "SSD";
	}

	// Token: 0x04000A4F RID: 2639
	private readonly dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd dje_zH7SBHE869SWB4CTH5A3Q99ANXYSE8ZUTUKBN6PWX4AKBUCJPHXLBPUEGXCENFYGYXNUJTWBEDQ999A2_ejd_0;

	// Token: 0x04000A50 RID: 2640
	private readonly TimeSpan timeSpan_0 = TimeSpan.FromMilliseconds(10.0);

	// Token: 0x04000A51 RID: 2641
	private string string_0;

	// Token: 0x04000A52 RID: 2642
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;

	// Token: 0x04000A53 RID: 2643
	private string string_1;

	// Token: 0x04000A54 RID: 2644
	private SolidColorBrush solidColorBrush_1 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;

	// Token: 0x04000A55 RID: 2645
	private string string_2;

	// Token: 0x04000A56 RID: 2646
	private SolidColorBrush solidColorBrush_2 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd;

	// Token: 0x04000A57 RID: 2647
	private Visibility visibility_0 = Visibility.Collapsed;

	// Token: 0x04000A58 RID: 2648
	private Visibility visibility_1 = Visibility.Collapsed;

	// Token: 0x04000A59 RID: 2649
	private bool bool_0;

	// Token: 0x04000A5A RID: 2650
	private ObservableCollection<GClass174.GClass175> observableCollection_0 = new ObservableCollection<GClass174.GClass175>();

	// Token: 0x04000A5B RID: 2651
	private string string_3;

	// Token: 0x04000A5C RID: 2652
	private Visibility visibility_2 = Visibility.Collapsed;

	// Token: 0x04000A5D RID: 2653
	private string string_4 = string.Empty;

	// Token: 0x04000A5E RID: 2654
	private SolidColorBrush solidColorBrush_3 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04000A5F RID: 2655
	private double double_0;

	// Token: 0x04000A60 RID: 2656
	private readonly ICommand icommand_0;

	// Token: 0x02000261 RID: 609
	[StructLayout(LayoutKind.Auto)]
	private struct Struct140 : IAsyncStateMachine
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x00057EC0 File Offset: 0x000560C0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass174 gclass = this.gclass174_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = gclass.method_5().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct140>(ref awaiter, ref this);
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

		// Token: 0x06001085 RID: 4229 RVA: 0x0000C096 File Offset: 0x0000A296
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A61 RID: 2657
		public int int_0;

		// Token: 0x04000A62 RID: 2658
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000A63 RID: 2659
		public GClass174 gclass174_0;

		// Token: 0x04000A64 RID: 2660
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000262 RID: 610
	[StructLayout(LayoutKind.Auto)]
	private struct Struct141 : IAsyncStateMachine
	{
		// Token: 0x06001086 RID: 4230 RVA: 0x00057F74 File Offset: 0x00056174
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass174 gclass = this.gclass174_0;
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
					goto IL_E6;
				case 2:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_254;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_27C;
				case 4:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_2D8;
				default:
					awaiter = gclass.method_6("Применение рекомендаций...", dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct141>(ref awaiter, ref this);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = Task.Delay(1000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct141>(ref awaiter, ref this);
					return;
				}
				IL_E6:
				awaiter.GetResult();
				List<GClass214.GClass216> source = GClass214.smethod_6();
				GClass214.GClass216 gclass2;
				if ((gclass2 = source.Where(new Func<GClass214.GClass216, bool>(gclass.method_9)).OrderByDescending(new Func<GClass214.GClass216, long>(GClass174.Class284.class284_0.method_3)).FirstOrDefault<GClass214.GClass216>()) == null)
				{
					gclass2 = source.OrderByDescending(new Func<GClass214.GClass216, long>(GClass174.Class284.class284_0.method_4)).FirstOrDefault<GClass214.GClass216>();
				}
				GClass214.GClass216 gclass3 = gclass2;
				if (gclass3 != null)
				{
					string text = gclass3.Name + "\\pagefile.sys 0 0";
					int num2 = 0;
					try
					{
						GClass214.smethod_11(new string[]
						{
							text
						});
					}
					catch (Exception obj)
					{
						num2 = 1;
					}
					if (num2 == 1)
					{
						object obj;
						Exception ex = (Exception)obj;
						awaiter = gclass.method_6("Ошибка при применении: " + ex.Message, dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 2;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct141>(ref awaiter, ref this);
							return;
						}
						goto IL_254;
					}
				}
				awaiter = gclass.method_6("Настройки применены. Может потребоваться перезагрузка.", dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zRGEEN2XWKB2ZUBQ_ejd).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct141>(ref awaiter, ref this);
					return;
				}
				goto IL_27C;
				IL_254:
				awaiter.GetResult();
				goto IL_300;
				IL_27C:
				awaiter.GetResult();
				awaiter = Task.Delay(2000).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 4;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct141>(ref awaiter, ref this);
					return;
				}
				IL_2D8:
				awaiter.GetResult();
				gclass.method_2();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_300:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A65 RID: 2661
		public int int_0;

		// Token: 0x04000A66 RID: 2662
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000A67 RID: 2663
		public GClass174 gclass174_0;

		// Token: 0x04000A68 RID: 2664
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000263 RID: 611
	private sealed class Class281
	{
		// Token: 0x06001089 RID: 4233 RVA: 0x0000C0B2 File Offset: 0x0000A2B2
		internal bool method_0(string string_0)
		{
			return Path.GetPathRoot(string_0).TrimEnd(new char[]
			{
				'\\'
			}).Equals(this.gclass216_0.Name, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000A69 RID: 2665
		public GClass214.GClass216 gclass216_0;
	}

	// Token: 0x02000264 RID: 612
	public sealed class GClass175 : GClass162
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x0000C0DB File Offset: 0x0000A2DB
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x0000C0E3 File Offset: 0x0000A2E3
		public string Letter
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		public string Type
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0000C0FD File Offset: 0x0000A2FD
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x0000C105 File Offset: 0x0000A305
		public string FreeSize
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0000C10E File Offset: 0x0000A30E
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0000C116 File Offset: 0x0000A316
		public string PFEnabled
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0000C11F File Offset: 0x0000A31F
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x0000C127 File Offset: 0x0000A327
		public string PFRecommended
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

		// Token: 0x04000A6A RID: 2666
		private string string_0;

		// Token: 0x04000A6B RID: 2667
		private string string_1;

		// Token: 0x04000A6C RID: 2668
		private string string_2;

		// Token: 0x04000A6D RID: 2669
		private string string_3;

		// Token: 0x04000A6E RID: 2670
		private string string_4;
	}

	// Token: 0x02000265 RID: 613
	private sealed class Class282
	{
		// Token: 0x06001096 RID: 4246 RVA: 0x0000C130 File Offset: 0x0000A330
		internal bool method_0(GClass214.GClass216 gclass216_0)
		{
			return gclass216_0.Name.Equals(this.string_0, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000A6F RID: 2671
		public string string_0;
	}

	// Token: 0x02000266 RID: 614
	[StructLayout(LayoutKind.Auto)]
	private struct Struct142 : IAsyncStateMachine
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x000582C8 File Offset: 0x000564C8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass174 gclass = this.gclass174_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_A8;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_109;
				}
				IL_56:
				if (gclass.StatusOpacity <= 0.0)
				{
					gclass.StatusColor = this.solidColorBrush_0;
					gclass.StatusText = this.string_0;
					goto IL_110;
				}
				gclass.StatusOpacity = Math.Max(0.0, gclass.StatusOpacity - 0.1);
				awaiter = Task.Delay(gclass.timeSpan_0).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct142>(ref awaiter, ref this);
					return;
				}
				IL_A8:
				awaiter.GetResult();
				goto IL_56;
				IL_109:
				awaiter.GetResult();
				IL_110:
				if (gclass.StatusOpacity < 1.0)
				{
					gclass.StatusOpacity = Math.Min(1.0, gclass.StatusOpacity + 0.1333);
					awaiter = Task.Delay(gclass.timeSpan_0).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_109;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass174.Struct142>(ref awaiter, ref this);
					return;
				}
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

		// Token: 0x06001098 RID: 4248 RVA: 0x0000C144 File Offset: 0x0000A344
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000A70 RID: 2672
		public int int_0;

		// Token: 0x04000A71 RID: 2673
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000A72 RID: 2674
		public GClass174 gclass174_0;

		// Token: 0x04000A73 RID: 2675
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000A74 RID: 2676
		public string string_0;

		// Token: 0x04000A75 RID: 2677
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000267 RID: 615
	private sealed class Class283
	{
		// Token: 0x0600109A RID: 4250 RVA: 0x0000C152 File Offset: 0x0000A352
		internal bool method_0(GClass214.GClass216 gclass216_0)
		{
			return gclass216_0.Name == this.string_0;
		}

		// Token: 0x04000A76 RID: 2678
		public string string_0;
	}

	// Token: 0x02000268 RID: 616
	[Serializable]
	private sealed class Class284
	{
		// Token: 0x0600109D RID: 4253 RVA: 0x0000C171 File Offset: 0x0000A371
		internal string method_0(string string_0)
		{
			return Path.GetPathRoot(string_0).TrimEnd(new char[]
			{
				'\\'
			});
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0000C189 File Offset: 0x0000A389
		internal long method_1(GClass214.GClass216 gclass216_0)
		{
			return gclass216_0.method_0();
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0000C189 File Offset: 0x0000A389
		internal long method_2(GClass214.GClass216 gclass216_0)
		{
			return gclass216_0.method_0();
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0000C189 File Offset: 0x0000A389
		internal long method_3(GClass214.GClass216 gclass216_0)
		{
			return gclass216_0.method_0();
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0000C189 File Offset: 0x0000A389
		internal long method_4(GClass214.GClass216 gclass216_0)
		{
			return gclass216_0.method_0();
		}

		// Token: 0x04000A77 RID: 2679
		public static readonly GClass174.Class284 class284_0 = new GClass174.Class284();

		// Token: 0x04000A78 RID: 2680
		public static Func<string, string> func_0;

		// Token: 0x04000A79 RID: 2681
		public static Func<GClass214.GClass216, long> func_1;

		// Token: 0x04000A7A RID: 2682
		public static Func<GClass214.GClass216, long> func_2;

		// Token: 0x04000A7B RID: 2683
		public static Func<GClass214.GClass216, long> func_3;

		// Token: 0x04000A7C RID: 2684
		public static Func<GClass214.GClass216, long> func_4;
	}
}
