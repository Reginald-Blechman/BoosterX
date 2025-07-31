using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using ns0;

// Token: 0x0200036B RID: 875
public sealed class GClass182 : GClass162
{
	// Token: 0x060016D8 RID: 5848 RVA: 0x000673AC File Offset: 0x000655AC
	public GClass182()
	{
		this.bool_0 = true;
		this.SettingItemsCollectionView = CollectionViewSource.GetDefaultView(this.SettingModels);
		this.SettingItemsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("GroupName"));
		this.SettingItemsCollectionView.SortDescriptions.Add(new SortDescription("GroupName", ListSortDirection.Ascending));
		this.RefreshCommand.Execute(null);
	}

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0000FCAA File Offset: 0x0000DEAA
	// (set) Token: 0x060016DA RID: 5850 RVA: 0x0000FCB2 File Offset: 0x0000DEB2
	public double AnimationOpacity
	{
		get
		{
			return this.double_0;
		}
		set
		{
			this.double_0 = value;
			base.method_0("AnimationOpacity");
		}
	}

	// Token: 0x17000397 RID: 919
	// (get) Token: 0x060016DB RID: 5851 RVA: 0x0000FCC7 File Offset: 0x0000DEC7
	// (set) Token: 0x060016DC RID: 5852 RVA: 0x0000FCCF File Offset: 0x0000DECF
	public Visibility AnimationVisibility
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			this.visibility_0 = value;
			base.method_0("AnimationVisibility");
		}
	}

	// Token: 0x17000398 RID: 920
	// (get) Token: 0x060016DD RID: 5853 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
	// (set) Token: 0x060016DE RID: 5854 RVA: 0x0000FCEC File Offset: 0x0000DEEC
	public double MainOpacity
	{
		get
		{
			return this.double_1;
		}
		set
		{
			this.double_1 = value;
			base.method_0("MainOpacity");
		}
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x00067460 File Offset: 0x00065660
	private void method_2()
	{
		GClass182.Struct193 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass182.Struct193>(ref @struct);
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x00067498 File Offset: 0x00065698
	private void method_3()
	{
		GClass182.Struct197 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass182.Struct197>(ref @struct);
	}

	// Token: 0x17000399 RID: 921
	// (get) Token: 0x060016E1 RID: 5857 RVA: 0x000674D0 File Offset: 0x000656D0
	public bool IsHardMode
	{
		get
		{
			return Class551.class753_0.method_82().GetValueOrDefault();
		}
	}

	// Token: 0x1700039A RID: 922
	// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0000FD01 File Offset: 0x0000DF01
	public Visibility IsHardModeVisibility
	{
		get
		{
			if (!this.IsHardMode)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0000FD0E File Offset: 0x0000DF0E
	// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0000FD16 File Offset: 0x0000DF16
	public bool IsScannedForPredefined
	{
		get
		{
			return this.bool_1;
		}
		private set
		{
			this.bool_1 = value;
			base.method_0("IsScannedForPredefined");
		}
	}

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0000FD2B File Offset: 0x0000DF2B
	// (set) Token: 0x060016E6 RID: 5862 RVA: 0x0000FD33 File Offset: 0x0000DF33
	public GClass32 BaseProfile
	{
		get
		{
			return this.gclass32_0;
		}
		private set
		{
			this.gclass32_0 = value;
			base.method_0("BaseProfile");
		}
	}

	// Token: 0x1700039D RID: 925
	// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0000FD48 File Offset: 0x0000DF48
	// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0000FD50 File Offset: 0x0000DF50
	public GClass32 CurrentProfile
	{
		get
		{
			return this.gclass32_1;
		}
		private set
		{
			this.gclass32_1 = value;
			this.method_11(Class298.smethod_2(value.ProfileName), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
			base.method_0("CurrentProfile");
		}
	}

	// Token: 0x1700039E RID: 926
	// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0000FD7B File Offset: 0x0000DF7B
	// (set) Token: 0x060016EA RID: 5866 RVA: 0x0000FD83 File Offset: 0x0000DF83
	public Dictionary<string, string> Applications
	{
		get
		{
			return this.dictionary_0;
		}
		private set
		{
			if (value != this.dictionary_0)
			{
				this.dictionary_0 = value;
				base.method_0("Applications");
				base.method_0("ApplicationsFormatted");
			}
		}
	}

	// Token: 0x1700039F RID: 927
	// (get) Token: 0x060016EB RID: 5867 RVA: 0x0000FDAD File Offset: 0x0000DFAD
	// (set) Token: 0x060016EC RID: 5868 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
	public int EditCount
	{
		get
		{
			return dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_0;
		}
		set
		{
			if (value != dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_0)
			{
				dje_z95XM7LSJTZRZ7N2X5FPMRL4DNZ4Q_ejd.int_0 = value;
				GClass279.smethod_0().method_10();
				base.method_0("EditCount");
			}
		}
	}

	// Token: 0x170003A0 RID: 928
	// (get) Token: 0x060016ED RID: 5869 RVA: 0x0000FDDA File Offset: 0x0000DFDA
	public string ApplicationsFormatted
	{
		get
		{
			return string.Join(" ; ", this.dictionary_0.Values);
		}
	}

	// Token: 0x170003A1 RID: 929
	// (get) Token: 0x060016EE RID: 5870 RVA: 0x0000FDF2 File Offset: 0x0000DFF2
	// (set) Token: 0x060016EF RID: 5871 RVA: 0x0000FDFA File Offset: 0x0000DFFA
	public ObservableCollection<GClass32> Profiles
	{
		get
		{
			return this.observableCollection_0;
		}
		private set
		{
			if (value != this.observableCollection_0)
			{
				this.observableCollection_0 = value;
				base.method_0("Profiles");
			}
		}
	}

	// Token: 0x170003A2 RID: 930
	// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0000FE18 File Offset: 0x0000E018
	// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0000FE20 File Offset: 0x0000E020
	public ObservableCollection<GClass164> SettingModels
	{
		get
		{
			return this.observableCollection_1;
		}
		private set
		{
			if (value != this.observableCollection_1)
			{
				this.observableCollection_1 = value;
				base.method_0("SettingModels");
			}
		}
	}

	// Token: 0x170003A3 RID: 931
	// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0000FE3E File Offset: 0x0000E03E
	// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0000FE46 File Offset: 0x0000E046
	public ICollectionView SettingItemsCollectionView
	{
		[CompilerGenerated]
		get
		{
			return this.icollectionView_0;
		}
		[CompilerGenerated]
		private set
		{
			this.icollectionView_0 = value;
		}
	}

	// Token: 0x170003A4 RID: 932
	// (get) Token: 0x060016F4 RID: 5876 RVA: 0x000674F0 File Offset: 0x000656F0
	public GClass280 RefreshCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_0) == null)
			{
				result = (this.gclass280_0 = new GClass280(new Action<object>(this.method_12), null));
			}
			return result;
		}
	}

	// Token: 0x170003A5 RID: 933
	// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00067524 File Offset: 0x00065724
	public GClass280 OnProfileChangedCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_1) == null)
			{
				result = (this.gclass280_1 = new GClass280(new Action<object>(this.method_14), null));
			}
			return result;
		}
	}

	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00067558 File Offset: 0x00065758
	public GClass280 OnSettingValueChangedCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_2) == null)
			{
				result = (this.gclass280_2 = new GClass280(new Action<object>(this.method_15), null));
			}
			return result;
		}
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x0006758C File Offset: 0x0006578C
	public void method_4()
	{
		GClass182.Struct192 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass182.Struct192>(ref @struct);
	}

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0000FE4F File Offset: 0x0000E04F
	// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0000FE57 File Offset: 0x0000E057
	public bool IsProfileExport
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
			base.method_0("IsProfileExport");
		}
	}

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x060016FA RID: 5882 RVA: 0x000675C4 File Offset: 0x000657C4
	public GClass280 ExportClickCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_3) == null)
			{
				result = (this.gclass280_3 = new GClass280(new Action<object>(this.method_17), null));
			}
			return result;
		}
	}

	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x060016FB RID: 5883 RVA: 0x0000FE6C File Offset: 0x0000E06C
	// (set) Token: 0x060016FC RID: 5884 RVA: 0x0000FE74 File Offset: 0x0000E074
	public bool IsProfileImport
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.bool_4 = value;
			base.method_0("IsProfileImport");
		}
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x0000FE89 File Offset: 0x0000E089
	private string method_5()
	{
		return this.string_0;
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x0000FE91 File Offset: 0x0000E091
	private void method_6(string string_2)
	{
		this.string_0 = string_2;
	}

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x060016FF RID: 5887 RVA: 0x000675F8 File Offset: 0x000657F8
	public GClass280 ImportClickCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_4) == null)
			{
				result = (this.gclass280_4 = new GClass280(new Action<object>(this.method_18), null));
			}
			return result;
		}
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x0006762C File Offset: 0x0006582C
	public void method_7(string string_2)
	{
		this.method_6(string_2);
		GClass279.smethod_0().method_9<Class800>("import", new Func<Class800>(GClass182.Class419.class419_0.method_4), this);
		this.method_11(Class298.smethod_2("ProfileWillBeImported"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
	}

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x06001701 RID: 5889 RVA: 0x00067688 File Offset: 0x00065888
	public GClass280 OptimalClickCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_5) == null)
			{
				result = (this.gclass280_5 = new GClass280(new Action<object>(this.method_19), null));
			}
			return result;
		}
	}

	// Token: 0x170003AC RID: 940
	// (get) Token: 0x06001702 RID: 5890 RVA: 0x000676BC File Offset: 0x000658BC
	public GClass280 ResetProfileClickCommand
	{
		get
		{
			GClass280 result;
			if ((result = this.gclass280_6) == null)
			{
				result = (this.gclass280_6 = new GClass280(new Action<object>(this.method_20), new Func<object, bool>(this.method_21)));
			}
			return result;
		}
	}

	// Token: 0x170003AD RID: 941
	// (get) Token: 0x06001703 RID: 5891 RVA: 0x0000FE9A File Offset: 0x0000E09A
	// (set) Token: 0x06001704 RID: 5892 RVA: 0x0000FEA2 File Offset: 0x0000E0A2
	public GEnum12 ResetType
	{
		get
		{
			return this.genum12_0;
		}
		private set
		{
			this.genum12_0 = value;
			base.method_0("ResetType");
		}
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x000676FC File Offset: 0x000658FC
	public Task method_8(CancellationToken cancellationToken_0)
	{
		GClass182.Struct201 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass182.Struct201>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x00067748 File Offset: 0x00065948
	public Task method_9(GClass32 gclass32_2, GEnum11 genum11_0, CancellationToken cancellationToken_0)
	{
		GClass182.Struct194 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.gclass32_0 = gclass32_2;
		@struct.genum11_0 = genum11_0;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass182.Struct194>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x000677A4 File Offset: 0x000659A4
	public Task method_10(CancellationToken cancellationToken_0)
	{
		GClass182.Struct200 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.cancellationToken_0 = cancellationToken_0;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass182.Struct200>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06001708 RID: 5896 RVA: 0x0000FEB7 File Offset: 0x0000E0B7
	// (set) Token: 0x06001709 RID: 5897 RVA: 0x0000FEBF File Offset: 0x0000E0BF
	public string StatusText
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("StatusText");
		}
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x0600170A RID: 5898 RVA: 0x0000FED4 File Offset: 0x0000E0D4
	// (set) Token: 0x0600170B RID: 5899 RVA: 0x0000FEDC File Offset: 0x0000E0DC
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

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x0600170C RID: 5900 RVA: 0x0000FEF1 File Offset: 0x0000E0F1
	// (set) Token: 0x0600170D RID: 5901 RVA: 0x0000FEF9 File Offset: 0x0000E0F9
	public double StatusOpacity
	{
		get
		{
			return this.double_2;
		}
		set
		{
			this.double_2 = value;
			base.method_0("StatusOpacity");
		}
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x000677F0 File Offset: 0x000659F0
	private void method_11(string string_2, SolidColorBrush solidColorBrush_1)
	{
		GClass182.Struct199 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.string_0 = string_2;
		@struct.solidColorBrush_0 = solidColorBrush_1;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass182.Struct199>(ref @struct);
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x00067838 File Offset: 0x00065A38
	private void method_12(object object_0)
	{
		GClass182.Struct195 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass182.Struct195>(ref @struct);
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00067870 File Offset: 0x00065A70
	private Task method_13()
	{
		GClass182.Struct203 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass182.Struct203>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x000678B4 File Offset: 0x00065AB4
	private void method_14(object object_0)
	{
		GClass182.Struct196 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.object_0 = object_0;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass182.Struct196>(ref @struct);
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x000678F4 File Offset: 0x00065AF4
	private void method_15(object object_0)
	{
		if (object_0 == null)
		{
			return;
		}
		this.IsProfileImport = false;
		this.IsProfileExport = false;
		ComboBox comboBox = (ComboBox)object_0;
		if (comboBox.Items.Count < 1)
		{
			return;
		}
		GClass164 gclass = (GClass164)comboBox.DataContext;
		GInterface11 ginterface = (GInterface11)comboBox.SelectedItem;
		int editCount;
		if (ginterface == gclass.ginterface11_1)
		{
			GClass279.smethod_0().method_15(typeof(Class800), gclass.SettingMeta.method_4());
			editCount = this.EditCount;
			this.EditCount = editCount - 1;
			gclass.IsEdited = false;
			return;
		}
		editCount = this.EditCount;
		this.EditCount = editCount + 1;
		GClass279.smethod_0().method_9<Class800>(gclass.SettingMeta.method_4(), new Func<Class800>(GClass182.Class419.class419_0.method_0), gclass.SettingItem.method_4());
		this.ResetType = (GEnum12)2;
		gclass.IsEdited = true;
		GClass208 settingItem = gclass.SettingItem;
		string string_;
		if (ginterface == null)
		{
			string_ = null;
		}
		else
		{
			object obj = ginterface.imethod_0();
			string_ = ((obj != null) ? obj.ToString() : null);
		}
		settingItem.method_5(string_);
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x00067A04 File Offset: 0x00065C04
	private Task method_16()
	{
		GClass182.Struct191 @struct;
		@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.int_0 = -1;
		@struct.asyncTaskMethodBuilder_0.Start<GClass182.Struct191>(ref @struct);
		return @struct.asyncTaskMethodBuilder_0.Task;
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x00067A48 File Offset: 0x00065C48
	private void method_17(object object_0)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog
		{
			Filter = "NVIDIA Profiles (*.nvx) | *.nvx",
			CheckPathExists = true
		};
		if (saveFileDialog.ShowDialog().Value)
		{
			this.IsProfileExport = true;
			this.CurrentProfile.smethod_17(saveFileDialog.FileName, true);
		}
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x00067A98 File Offset: 0x00065C98
	private void method_18(object object_0)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "NVIDIA Profiles (*.nvx; *.nip) | *.nvx; *.nip",
			CheckFileExists = true,
			CheckPathExists = true
		};
		if (openFileDialog.ShowDialog().Value)
		{
			this.EditCount = 1;
			this.IsProfileImport = true;
			this.IsProfileExport = false;
			this.method_6(openFileDialog.FileName);
			GClass279.smethod_0().method_9<Class800>("import", new Func<Class800>(GClass182.Class419.class419_0.method_3), this);
			this.method_11(Class298.smethod_2("ProfileWillBeImported"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
		}
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00067B40 File Offset: 0x00065D40
	private void method_19(object object_0)
	{
		GClass182.Struct198 @struct;
		@struct.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
		@struct.gclass182_0 = this;
		@struct.int_0 = -1;
		@struct.asyncVoidMethodBuilder_0.Start<GClass182.Struct198>(ref @struct);
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x00067B78 File Offset: 0x00065D78
	private void method_20(object object_0)
	{
		if (Keyboard.IsKeyDown(Key.LeftShift))
		{
			foreach (GClass164 gclass in this.SettingModels)
			{
				if (gclass.CurrentValue != gclass.SettingMeta.DefaultValue)
				{
					gclass.IsEdited = true;
					gclass.CurrentValue = gclass.SettingMeta.DefaultValue;
				}
			}
			this.ResetType = (GEnum12)0;
			this.method_11(Class298.smethod_2("CurrentProfileWillBeDefault"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
		}
		else
		{
			this.ResetType = (GEnum12)1;
			this.method_11(Class298.smethod_2("AllProfilesWillBeDefault"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_zUA9MYQN4ZPV2ETZ_ejd);
		}
		this.EditCount = 1;
		this.IsProfileImport = false;
		this.IsProfileExport = false;
		GClass279.smethod_0().method_9<Class800>("reset", new Func<Class800>(GClass182.Class419.class419_0.method_6), this);
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x0000FF0E File Offset: 0x0000E10E
	private bool method_21(object object_0)
	{
		return this.CurrentProfile != null;
	}

	// Token: 0x04000EFC RID: 3836
	public bool bool_0 = true;

	// Token: 0x04000EFD RID: 3837
	private double double_0;

	// Token: 0x04000EFE RID: 3838
	private Visibility visibility_0;

	// Token: 0x04000EFF RID: 3839
	private double double_1;

	// Token: 0x04000F00 RID: 3840
	private bool bool_1;

	// Token: 0x04000F01 RID: 3841
	private GClass32 gclass32_0;

	// Token: 0x04000F02 RID: 3842
	private GClass32 gclass32_1;

	// Token: 0x04000F03 RID: 3843
	private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	// Token: 0x04000F04 RID: 3844
	private ObservableCollection<GClass32> observableCollection_0 = new ObservableCollection<GClass32>();

	// Token: 0x04000F05 RID: 3845
	private ObservableCollection<GClass164> observableCollection_1 = new ObservableCollection<GClass164>();

	// Token: 0x04000F06 RID: 3846
	private ICollectionView icollectionView_0;

	// Token: 0x04000F07 RID: 3847
	public bool bool_2;

	// Token: 0x04000F08 RID: 3848
	private GClass280 gclass280_0;

	// Token: 0x04000F09 RID: 3849
	private GClass280 gclass280_1;

	// Token: 0x04000F0A RID: 3850
	private GClass280 gclass280_2;

	// Token: 0x04000F0B RID: 3851
	private bool bool_3;

	// Token: 0x04000F0C RID: 3852
	private GClass280 gclass280_3;

	// Token: 0x04000F0D RID: 3853
	private bool bool_4;

	// Token: 0x04000F0E RID: 3854
	private string string_0;

	// Token: 0x04000F0F RID: 3855
	private GClass280 gclass280_4;

	// Token: 0x04000F10 RID: 3856
	private GClass280 gclass280_5;

	// Token: 0x04000F11 RID: 3857
	private GClass280 gclass280_6;

	// Token: 0x04000F12 RID: 3858
	private GEnum12 genum12_0 = (GEnum12)2;

	// Token: 0x04000F13 RID: 3859
	private string string_1 = string.Empty;

	// Token: 0x04000F14 RID: 3860
	private SolidColorBrush solidColorBrush_0 = dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd;

	// Token: 0x04000F15 RID: 3861
	private double double_2;

	// Token: 0x0200036C RID: 876
	private sealed class Class414
	{
		// Token: 0x0600171A RID: 5914 RVA: 0x0000FF19 File Offset: 0x0000E119
		internal bool method_0(GInterface11 ginterface11_0)
		{
			return ginterface11_0.imethod_0().ToString() == this.dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0.String_1;
		}

		// Token: 0x04000F16 RID: 3862
		public dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0;
	}

	// Token: 0x0200036D RID: 877
	private sealed class Class415
	{
		// Token: 0x04000F17 RID: 3863
		public bool bool_0;

		// Token: 0x04000F18 RID: 3864
		public bool bool_1;
	}

	// Token: 0x0200036E RID: 878
	[StructLayout(LayoutKind.Auto)]
	private struct Struct191 : IAsyncStateMachine
	{
		// Token: 0x0600171C RID: 5916 RVA: 0x00067C78 File Offset: 0x00065E78
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<bool> awaiter2;
				switch (num)
				{
				case 0:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					break;
				case 1:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
					goto IL_159;
				case 2:
					awaiter2 = this.taskAwaiter_1;
					this.taskAwaiter_1 = default(TaskAwaiter<bool>);
					this.int_0 = -1;
					goto IL_1BD;
				case 3:
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_227;
				default:
				{
					if (gclass.method_5() != null)
					{
						GClass300.smethod_22(gclass.method_5());
						goto IL_249;
					}
					IEnumerable<GClass208> ienumerable_ = gclass.SettingModels.Where(new Func<GClass164, bool>(GClass182.Class419.class419_0.method_1)).Select(new Func<GClass164, GClass208>(GClass182.Class419.class419_0.method_2));
					awaiter = gclass.CurrentProfile.smethod_13(ienumerable_, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct191>(ref awaiter, ref this);
						return;
					}
					break;
				}
				}
				awaiter.GetResult();
				if (gclass.ResetType != (GEnum12)0)
				{
					goto IL_161;
				}
				awaiter2 = gclass.CurrentProfile.smethod_25().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, GClass182.Struct191>(ref awaiter2, ref this);
					return;
				}
				IL_159:
				awaiter2.GetResult();
				IL_161:
				if (gclass.ResetType != (GEnum12)1)
				{
					goto IL_1C5;
				}
				awaiter2 = GClass300.smethod_26().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					this.int_0 = 2;
					this.taskAwaiter_1 = awaiter2;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, GClass182.Struct191>(ref awaiter2, ref this);
					return;
				}
				IL_1BD:
				awaiter2.GetResult();
				IL_1C5:
				awaiter = gclass.method_9(gclass.CurrentProfile, (GEnum11)0, default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 3;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct191>(ref awaiter, ref this);
					return;
				}
				IL_227:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_249:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0000FF36 File Offset: 0x0000E136
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F19 RID: 3865
		public int int_0;

		// Token: 0x04000F1A RID: 3866
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000F1B RID: 3867
		public GClass182 gclass182_0;

		// Token: 0x04000F1C RID: 3868
		private TaskAwaiter taskAwaiter_0;

		// Token: 0x04000F1D RID: 3869
		private TaskAwaiter<bool> taskAwaiter_1;
	}

	// Token: 0x0200036F RID: 879
	[StructLayout(LayoutKind.Auto)]
	private struct Struct192 : IAsyncStateMachine
	{
		// Token: 0x0600171E RID: 5918 RVA: 0x00067F00 File Offset: 0x00066100
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 @object = this.gclass182_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_16)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct192>(ref awaiter, ref this);
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

		// Token: 0x0600171F RID: 5919 RVA: 0x0000FF44 File Offset: 0x0000E144
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F1E RID: 3870
		public int int_0;

		// Token: 0x04000F1F RID: 3871
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F20 RID: 3872
		public GClass182 gclass182_0;

		// Token: 0x04000F21 RID: 3873
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000370 RID: 880
	[StructLayout(LayoutKind.Auto)]
	private struct Struct193 : IAsyncStateMachine
	{
		// Token: 0x06001720 RID: 5920 RVA: 0x00067FC0 File Offset: 0x000661C0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					this.int_0 = -1;
					goto IL_A6;
				}
				gclass.MainOpacity = 0.0;
				gclass.AnimationVisibility = Visibility.Visible;
				IL_47:
				if (gclass.AnimationOpacity == 1.0)
				{
					goto IL_E8;
				}
				gclass.AnimationOpacity += 0.13333333333333333;
				if (gclass.AnimationOpacity > 0.95)
				{
					gclass.AnimationOpacity = 1.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct193>(ref awaiter, ref this);
					return;
				}
				IL_A6:
				awaiter.GetResult();
				goto IL_47;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_E8:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0000FF52 File Offset: 0x0000E152
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F22 RID: 3874
		public int int_0;

		// Token: 0x04000F23 RID: 3875
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F24 RID: 3876
		public GClass182 gclass182_0;

		// Token: 0x04000F25 RID: 3877
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000371 RID: 881
	[StructLayout(LayoutKind.Auto)]
	private struct Struct194 : IAsyncStateMachine
	{
		// Token: 0x06001722 RID: 5922 RVA: 0x000680D8 File Offset: 0x000662D8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(new GClass182.Class417
					{
						gclass32_0 = this.gclass32_0,
						genum11_0 = this.genum11_0,
						cancellationToken_0 = this.cancellationToken_0,
						gclass182_0 = this.gclass182_0
					}.method_0)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct194>(ref awaiter, ref this);
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

		// Token: 0x06001723 RID: 5923 RVA: 0x0000FF60 File Offset: 0x0000E160
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F26 RID: 3878
		public int int_0;

		// Token: 0x04000F27 RID: 3879
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000F28 RID: 3880
		public GClass32 gclass32_0;

		// Token: 0x04000F29 RID: 3881
		public GEnum11 genum11_0;

		// Token: 0x04000F2A RID: 3882
		public CancellationToken cancellationToken_0;

		// Token: 0x04000F2B RID: 3883
		public GClass182 gclass182_0;

		// Token: 0x04000F2C RID: 3884
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000372 RID: 882
	[StructLayout(LayoutKind.Auto)]
	private struct Struct195 : IAsyncStateMachine
	{
		// Token: 0x06001724 RID: 5924 RVA: 0x000681C4 File Offset: 0x000663C4
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 @object = this.gclass182_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run(new Func<Task>(@object.method_13)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct195>(ref awaiter, ref this);
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

		// Token: 0x06001725 RID: 5925 RVA: 0x0000FF6E File Offset: 0x0000E16E
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F2D RID: 3885
		public int int_0;

		// Token: 0x04000F2E RID: 3886
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F2F RID: 3887
		public GClass182 gclass182_0;

		// Token: 0x04000F30 RID: 3888
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000373 RID: 883
	[StructLayout(LayoutKind.Auto)]
	private struct Struct196 : IAsyncStateMachine
	{
		// Token: 0x06001726 RID: 5926 RVA: 0x00068284 File Offset: 0x00066484
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (this.object_0 == null)
					{
						goto IL_BE;
					}
					gclass.IsProfileImport = false;
					gclass.IsProfileExport = false;
					GClass32 gclass2 = (GClass32)this.object_0;
					gclass.CurrentProfile = gclass2;
					awaiter = gclass.method_9(gclass2, (GEnum11)1, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct196>(ref awaiter, ref this);
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
			IL_BE:
			this.int_0 = -2;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0000FF7C File Offset: 0x0000E17C
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F31 RID: 3889
		public int int_0;

		// Token: 0x04000F32 RID: 3890
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F33 RID: 3891
		public object object_0;

		// Token: 0x04000F34 RID: 3892
		public GClass182 gclass182_0;

		// Token: 0x04000F35 RID: 3893
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000374 RID: 884
	private sealed class Class416
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x00068374 File Offset: 0x00066574
		internal void method_0()
		{
			this.class417_0.gclass182_0.SettingModels.Clear();
			this.class417_0.gclass182_0.Applications = this.valueTuple_0.Item2;
			IEnumerable<GStruct0> enumerable = this.ienumerable_0;
			Action<GStruct0> action_;
			if ((action_ = this.class417_0.action_0) == null)
			{
				action_ = (this.class417_0.action_0 = new Action<GStruct0>(this.class417_0.method_1));
			}
			enumerable.smethod_0(action_);
		}

		// Token: 0x04000F36 RID: 3894
		public ValueTuple<List<GStruct0>, Dictionary<string, string>> valueTuple_0;

		// Token: 0x04000F37 RID: 3895
		public IEnumerable<GStruct0> ienumerable_0;

		// Token: 0x04000F38 RID: 3896
		public GClass182.Class417 class417_0;
	}

	// Token: 0x02000375 RID: 885
	[StructLayout(LayoutKind.Auto)]
	private struct Struct197 : IAsyncStateMachine
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x000683EC File Offset: 0x000665EC
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
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
					goto IL_116;
				}
				IL_56:
				if (gclass.AnimationOpacity == 0.0)
				{
					gclass.AnimationVisibility = Visibility.Collapsed;
					goto IL_11D;
				}
				gclass.AnimationOpacity -= 0.1;
				if (gclass.AnimationOpacity < 0.05)
				{
					gclass.AnimationOpacity = 0.0;
				}
				awaiter = Task.Delay(10).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 0;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct197>(ref awaiter, ref this);
					return;
				}
				IL_B8:
				awaiter.GetResult();
				goto IL_56;
				IL_116:
				awaiter.GetResult();
				IL_11D:
				if (gclass.MainOpacity != 1.0)
				{
					gclass.MainOpacity += 0.13333333333333333;
					if (gclass.MainOpacity > 0.95)
					{
						gclass.MainOpacity = 1.0;
					}
					awaiter = Task.Delay(10).GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_116;
					}
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct197>(ref awaiter, ref this);
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

		// Token: 0x0600172B RID: 5931 RVA: 0x0000FF8A File Offset: 0x0000E18A
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F39 RID: 3897
		public int int_0;

		// Token: 0x04000F3A RID: 3898
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F3B RID: 3899
		public GClass182 gclass182_0;

		// Token: 0x04000F3C RID: 3900
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000376 RID: 886
	[StructLayout(LayoutKind.Auto)]
	private struct Struct198 : IAsyncStateMachine
	{
		// Token: 0x0600172C RID: 5932 RVA: 0x000685B0 File Offset: 0x000667B0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
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
					goto IL_98;
				}
				if (num == 1)
				{
					awaiter = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter);
					int num3 = -1;
					num = -1;
					this.int_0 = num3;
					goto IL_22F;
				}
				this.class415_0 = new GClass182.Class415();
				this.int_1 = 0;
				IL_7A:
				if (!gclass.bool_2)
				{
					goto IL_D1;
				}
				awaiter = Task.Delay(20).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num4 = 0;
					num = 0;
					this.int_0 = num4;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct198>(ref awaiter, ref this);
					return;
				}
				IL_98:
				awaiter.GetResult();
				if (this.int_1 <= 500)
				{
					int num5 = this.int_1;
					this.int_1 = num5 + 1;
					goto IL_7A;
				}
				IL_D1:
				if (gclass.CurrentProfile.ProfileName != "Base Profile")
				{
					gclass.CurrentProfile = gclass.Profiles.FirstOrDefault(new Func<GClass32, bool>(GClass182.Class419.class419_0.method_5));
				}
				Class765.smethod_4("BoosterX", Class169.string_4, "Resources.EmbedRes.Tweaks.Nvidia", "BestProfile.nvx", false);
				dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd = GClass300.smethod_23(Path.Combine(Class169.string_4, "BestProfile.nvx"));
				this.class415_0.bool_1 = false;
				this.class415_0.bool_0 = false;
				IEnumerator<GClass164> enumerator = gclass.SettingModels.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						GClass182.Class418 @class = new GClass182.Class418();
						@class.class415_0 = this.class415_0;
						@class.gclass164_0 = enumerator.Current;
						Class746.smethod_0<dje_zW8L97HRQWDAMPWBALQDGJ2GGR6E426FDLNVFVWW483HEG9Q_ejd>(dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd.List_0).List_1.ForEach(new Action<dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd>(@class.method_0));
					}
				}
				finally
				{
					if (num < 0 && enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (this.class415_0.bool_0)
				{
					gclass.method_11(this.class415_0.bool_1 ? Class298.smethod_2("OldDriverSkippedSome") : Class298.smethod_2("willbeoptimal"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
					goto IL_2A5;
				}
				gclass.method_11(Class298.smethod_2("AllSettingsAreAlreadyOptimal"), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
				awaiter = Task.Delay(1500).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					int num6 = 1;
					num = 1;
					this.int_0 = num6;
					this.taskAwaiter_0 = awaiter;
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct198>(ref awaiter, ref this);
					return;
				}
				IL_22F:
				awaiter.GetResult();
				gclass.method_11(Class298.smethod_2(gclass.CurrentProfile.ProfileName), dje_zG25CMVCNLAXR669QGY4VQH2TVB3HB4JJZQ_ejd.dje_z7Y3AEKDZ_ejd);
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.class415_0 = null;
				this.asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			IL_2A5:
			this.int_0 = -2;
			this.class415_0 = null;
			this.asyncVoidMethodBuilder_0.SetResult();
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0000FF98 File Offset: 0x0000E198
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F3D RID: 3901
		public int int_0;

		// Token: 0x04000F3E RID: 3902
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F3F RID: 3903
		public GClass182 gclass182_0;

		// Token: 0x04000F40 RID: 3904
		private GClass182.Class415 class415_0;

		// Token: 0x04000F41 RID: 3905
		private int int_1;

		// Token: 0x04000F42 RID: 3906
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000377 RID: 887
	[StructLayout(LayoutKind.Auto)]
	private struct Struct199 : IAsyncStateMachine
	{
		// Token: 0x0600172E RID: 5934 RVA: 0x000688B0 File Offset: 0x00066AB0
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct199>(ref awaiter, ref this);
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
					this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct199>(ref awaiter, ref this);
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

		// Token: 0x0600172F RID: 5935 RVA: 0x0000FFA6 File Offset: 0x0000E1A6
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F43 RID: 3907
		public int int_0;

		// Token: 0x04000F44 RID: 3908
		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		// Token: 0x04000F45 RID: 3909
		public GClass182 gclass182_0;

		// Token: 0x04000F46 RID: 3910
		public SolidColorBrush solidColorBrush_0;

		// Token: 0x04000F47 RID: 3911
		public string string_0;

		// Token: 0x04000F48 RID: 3912
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000378 RID: 888
	[StructLayout(LayoutKind.Auto)]
	private struct Struct200 : IAsyncStateMachine
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x00068A84 File Offset: 0x00066C84
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = GClass300.smethod_10(this.cancellationToken_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct200>(ref awaiter, ref this);
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
				gclass.IsScannedForPredefined = true;
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

		// Token: 0x06001731 RID: 5937 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F49 RID: 3913
		public int int_0;

		// Token: 0x04000F4A RID: 3914
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000F4B RID: 3915
		public CancellationToken cancellationToken_0;

		// Token: 0x04000F4C RID: 3916
		public GClass182 gclass182_0;

		// Token: 0x04000F4D RID: 3917
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x02000379 RID: 889
	[StructLayout(LayoutKind.Auto)]
	private struct Struct201 : IAsyncStateMachine
	{
		// Token: 0x06001732 RID: 5938 RVA: 0x00068B44 File Offset: 0x00066D44
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter<GStruct1> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = this.taskAwaiter_1;
						this.taskAwaiter_1 = default(TaskAwaiter);
						this.int_0 = -1;
						goto IL_149;
					}
					awaiter2 = GClass300.smethod_4(this.cancellationToken_0, true).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter2;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<GStruct1>, GClass182.Struct201>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = this.taskAwaiter_0;
					this.taskAwaiter_0 = default(TaskAwaiter<GStruct1>);
					this.int_0 = -1;
				}
				GStruct1 result = awaiter2.GetResult();
				gclass.CurrentProfile = (gclass.BaseProfile = result.method_0());
				if (!gclass.IsHardMode)
				{
					gclass.Profiles = new ObservableCollection<GClass32>(result.Profiles);
				}
				else
				{
					gclass.Profiles = new ObservableCollection<GClass32>(result.Profiles.Where(new Func<GClass32, bool>(GClass182.Class419.class419_0.method_7)));
				}
				awaiter = gclass.method_9(gclass.gclass32_0, (GEnum11)0, default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_1 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct201>(ref awaiter, ref this);
					return;
				}
				IL_149:
				awaiter.GetResult();
				gclass.method_0("LoadProfilesAsync");
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

		// Token: 0x06001733 RID: 5939 RVA: 0x0000FFC2 File Offset: 0x0000E1C2
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F4E RID: 3918
		public int int_0;

		// Token: 0x04000F4F RID: 3919
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000F50 RID: 3920
		public CancellationToken cancellationToken_0;

		// Token: 0x04000F51 RID: 3921
		public GClass182 gclass182_0;

		// Token: 0x04000F52 RID: 3922
		private TaskAwaiter<GStruct1> taskAwaiter_0;

		// Token: 0x04000F53 RID: 3923
		private TaskAwaiter taskAwaiter_1;
	}

	// Token: 0x0200037A RID: 890
	private sealed class Class417
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x00068CF8 File Offset: 0x00066EF8
		internal Task method_0()
		{
			GClass182.Class417.Struct202 @struct;
			@struct.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@struct.class417_0 = this;
			@struct.int_0 = -1;
			@struct.asyncTaskMethodBuilder_0.Start<GClass182.Class417.Struct202>(ref @struct);
			return @struct.asyncTaskMethodBuilder_0.Task;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		internal void method_1(GStruct0 gstruct0_0)
		{
			this.gclass182_0.SettingModels.Add(new GClass164(gstruct0_0, this.gclass182_0.IsHardMode));
		}

		// Token: 0x04000F54 RID: 3924
		public GClass32 gclass32_0;

		// Token: 0x04000F55 RID: 3925
		public GEnum11 genum11_0;

		// Token: 0x04000F56 RID: 3926
		public CancellationToken cancellationToken_0;

		// Token: 0x04000F57 RID: 3927
		public GClass182 gclass182_0;

		// Token: 0x04000F58 RID: 3928
		public Action<GStruct0> action_0;

		// Token: 0x0200037B RID: 891
		[StructLayout(LayoutKind.Auto)]
		private struct Struct202 : IAsyncStateMachine
		{
			// Token: 0x06001737 RID: 5943 RVA: 0x00068D3C File Offset: 0x00066F3C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.int_0;
				GClass182.Class417 @class = this.class417_0;
				try
				{
					TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> awaiter;
					if (num != 0)
					{
						this.class416_0 = new GClass182.Class416();
						this.class416_0.class417_0 = @class;
						awaiter = @class.gclass32_0.smethod_8(@class.genum11_0, false, @class.cancellationToken_0).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.int_0 = 0;
							this.taskAwaiter_0 = awaiter;
							this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>, GClass182.Class417.Struct202>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = this.taskAwaiter_0;
						this.taskAwaiter_0 = default(TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>>);
						this.int_0 = -1;
					}
					ValueTuple<List<GStruct0>, Dictionary<string, string>> result = awaiter.GetResult();
					this.class416_0.valueTuple_0 = result;
					this.class416_0.ienumerable_0 = this.class416_0.valueTuple_0.Item1.Where(new Func<GStruct0, bool>(GClass182.Class419.class419_0.method_8));
					if (!@class.gclass182_0.IsHardMode)
					{
						this.class416_0.ienumerable_0 = this.class416_0.ienumerable_0.Where(new Func<GStruct0, bool>(GClass182.Class419.class419_0.method_9));
					}
					Application.Current.Dispatcher.Invoke(new Action(this.class416_0.method_0));
					@class.gclass182_0.bool_2 = false;
				}
				catch (Exception exception)
				{
					this.int_0 = -2;
					this.class416_0 = null;
					this.asyncTaskMethodBuilder_0.SetException(exception);
					return;
				}
				this.int_0 = -2;
				this.class416_0 = null;
				this.asyncTaskMethodBuilder_0.SetResult();
			}

			// Token: 0x06001738 RID: 5944 RVA: 0x0000FFF3 File Offset: 0x0000E1F3
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
			}

			// Token: 0x04000F59 RID: 3929
			public int int_0;

			// Token: 0x04000F5A RID: 3930
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x04000F5B RID: 3931
			public GClass182.Class417 class417_0;

			// Token: 0x04000F5C RID: 3932
			private GClass182.Class416 class416_0;

			// Token: 0x04000F5D RID: 3933
			private TaskAwaiter<ValueTuple<List<GStruct0>, Dictionary<string, string>>> taskAwaiter_0;
		}
	}

	// Token: 0x0200037C RID: 892
	[StructLayout(LayoutKind.Auto)]
	private struct Struct203 : IAsyncStateMachine
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00068EF8 File Offset: 0x000670F8
		void IAsyncStateMachine.MoveNext()
		{
			int num = this.int_0;
			GClass182 gclass = this.gclass182_0;
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
						goto IL_10F;
					}
					if (gclass.bool_2)
					{
						goto IL_14F;
					}
					gclass.bool_2 = true;
					gclass.bool_0 = true;
					gclass.method_2();
					gclass.EditCount = 0;
					GClass279.smethod_0().method_17<Class800>();
					GClass300.smethod_14();
					awaiter = gclass.method_10(default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.int_0 = 0;
						this.taskAwaiter_0 = awaiter;
						this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct203>(ref awaiter, ref this);
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
				awaiter = gclass.method_8(default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					this.int_0 = 1;
					this.taskAwaiter_0 = awaiter;
					this.asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, GClass182.Struct203>(ref awaiter, ref this);
					return;
				}
				IL_10F:
				awaiter.GetResult();
				GClass279.smethod_0().method_10();
				gclass.bool_0 = false;
				gclass.method_3();
				gclass.bool_2 = false;
			}
			catch (Exception exception)
			{
				this.int_0 = -2;
				this.asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			IL_14F:
			this.int_0 = -2;
			this.asyncTaskMethodBuilder_0.SetResult();
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00010001 File Offset: 0x0000E201
		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		// Token: 0x04000F5E RID: 3934
		public int int_0;

		// Token: 0x04000F5F RID: 3935
		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		// Token: 0x04000F60 RID: 3936
		public GClass182 gclass182_0;

		// Token: 0x04000F61 RID: 3937
		private TaskAwaiter taskAwaiter_0;
	}

	// Token: 0x0200037D RID: 893
	private sealed class Class418
	{
		// Token: 0x0600173C RID: 5948 RVA: 0x00069084 File Offset: 0x00067284
		internal void method_0(dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0)
		{
			GClass182.Class414 @class = new GClass182.Class414();
			@class.dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0 = dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0;
			try
			{
				if (this.gclass164_0.SettingItem.method_0() == @class.dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0.UInt32_0 && this.gclass164_0.CurrentValue.imethod_0().ToString() != @class.dje_zAA4BYQ5QMGN4SQKAJLF7X3XG6Z8XVF7MJUQDQ9ZC9L8F8RYWHH5CR_ejd_0.String_1)
				{
					this.class415_0.bool_0 = true;
					this.gclass164_0.IsEdited = true;
					this.gclass164_0.CurrentValue = this.gclass164_0.Values.FirstOrDefault(new Func<GInterface11, bool>(@class.method_0));
				}
			}
			catch
			{
				this.class415_0.bool_1 = true;
			}
		}

		// Token: 0x04000F62 RID: 3938
		public GClass164 gclass164_0;

		// Token: 0x04000F63 RID: 3939
		public GClass182.Class415 class415_0;
	}

	// Token: 0x0200037E RID: 894
	[Serializable]
	private sealed class Class419
	{
		// Token: 0x0600173F RID: 5951 RVA: 0x0001001B File Offset: 0x0000E21B
		internal Class800 method_0()
		{
			return new Class800();
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00010022 File Offset: 0x0000E222
		internal bool method_1(GClass164 gclass164_0)
		{
			return gclass164_0.IsEdited;
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0001002A File Offset: 0x0000E22A
		internal GClass208 method_2(GClass164 gclass164_0)
		{
			return gclass164_0.SettingItem;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0001001B File Offset: 0x0000E21B
		internal Class800 method_3()
		{
			return new Class800();
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0001001B File Offset: 0x0000E21B
		internal Class800 method_4()
		{
			return new Class800();
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00010032 File Offset: 0x0000E232
		internal bool method_5(GClass32 gclass32_0)
		{
			return gclass32_0.ProfileName == "Base Profile";
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0001001B File Offset: 0x0000E21B
		internal Class800 method_6()
		{
			return new Class800();
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00010045 File Offset: 0x0000E245
		internal bool method_7(GClass32 gclass32_0)
		{
			return !gclass32_0.ProfileName.StartsWith("0x", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0001005C File Offset: 0x0000E25C
		internal bool method_8(GStruct0 gstruct0_0)
		{
			return gstruct0_0.method_0().Values.Count<GInterface11>() > 1;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00069144 File Offset: 0x00067344
		internal bool method_9(GStruct0 gstruct0_0)
		{
			if (Class220.list_0.Contains(gstruct0_0.SettingItem.method_2()))
			{
				return gstruct0_0.method_0().Values.Count(new Func<GInterface11, bool>(GClass182.Class419.class419_0.method_10)) > 0;
			}
			return false;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0000718B File Offset: 0x0000538B
		internal bool method_10(GInterface11 ginterface11_0)
		{
			return !ginterface11_0.imethod_1().StartsWith("0x");
		}

		// Token: 0x04000F64 RID: 3940
		public static readonly GClass182.Class419 class419_0 = new GClass182.Class419();

		// Token: 0x04000F65 RID: 3941
		public static Func<Class800> func_0;

		// Token: 0x04000F66 RID: 3942
		public static Func<GClass164, bool> func_1;

		// Token: 0x04000F67 RID: 3943
		public static Func<GClass164, GClass208> func_2;

		// Token: 0x04000F68 RID: 3944
		public static Func<Class800> func_3;

		// Token: 0x04000F69 RID: 3945
		public static Func<Class800> func_4;

		// Token: 0x04000F6A RID: 3946
		public static Func<GClass32, bool> func_5;

		// Token: 0x04000F6B RID: 3947
		public static Func<Class800> func_6;

		// Token: 0x04000F6C RID: 3948
		public static Func<GClass32, bool> func_7;

		// Token: 0x04000F6D RID: 3949
		public static Func<GStruct0, bool> func_8;

		// Token: 0x04000F6E RID: 3950
		public static Func<GInterface11, bool> func_9;

		// Token: 0x04000F6F RID: 3951
		public static Func<GStruct0, bool> func_10;
	}
}
