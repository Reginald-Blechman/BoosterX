using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ns0;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x0200069B RID: 1691
public sealed class GClass123 : GClass119
{
	// Token: 0x06002AD6 RID: 10966 RVA: 0x0001BC32 File Offset: 0x00019E32
	public GClass123(GClass50 gclass50_1, GClass120 gclass120_1) : base(gclass50_1, gclass120_1)
	{
		this.list_0 = this.method_20();
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x0001BC48 File Offset: 0x00019E48
	private List<uint> method_20()
	{
		return base.method_2<List<uint>>(new Func<IntPtr, List<uint>>(this.method_40), false);
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x000A5080 File Offset: 0x000A3280
	private string method_21()
	{
		foreach (string path in Directory.EnumerateDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "NVIDIA Corporation\\Installer2"), "Display.Driver.*"))
		{
			FileInfo fileInfo = new FileInfo(Path.Combine(path, "dbInstaller.exe"));
			if (fileInfo.Exists)
			{
				string text = FileVersionInfo.GetVersionInfo(fileInfo.FullName).FileVersion.Replace(".", string.Empty);
				string value = this.float_0.ToString().Replace(",", string.Empty).Replace(".", string.Empty);
				if (text.EndsWith(value))
				{
					return fileInfo.DirectoryName;
				}
			}
		}
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "NVIDIA Corporation\\Drs");
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x000A5174 File Offset: 0x000A3374
	private void method_22()
	{
		string text = this.method_21();
		ProcessStartInfo processStartInfo = new ProcessStartInfo
		{
			UseShellExecute = true,
			WorkingDirectory = text,
			Arguments = "-init",
			FileName = Path.Combine(text, "dbInstaller.exe")
		};
		if (!GClass266.smethod_0())
		{
			processStartInfo.Verb = "runas";
		}
		Process.Start(processStartInfo).WaitForExit();
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x000A51D8 File Offset: 0x000A33D8
	public void method_23()
	{
		GClass123.Class827 @class = new GClass123.Class827();
		@class.gclass123_0 = this;
		@class.string_0 = GClass264.smethod_0();
		try
		{
			File.WriteAllText(@class.string_0, "BaseProfile \"Base Profile\"\r\nSelectedGlobalProfile \"Base Profile\"\r\nProfile \"Base Profile\"\r\nShowOn All\r\nProfileType Global\r\nEndProfile\r\n");
			base.method_1(new Action<IntPtr>(@class.method_0), true, true);
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x000A5250 File Offset: 0x000A3450
	public void method_24(string string_0)
	{
		GClass123.Class814 @class = new GClass123.Class814();
		@class.gclass123_0 = this;
		@class.string_1 = string_0;
		@class.string_0 = GClass264.smethod_0();
		try
		{
			GClass123.Class826 class2 = new GClass123.Class826();
			class2.class814_0 = @class;
			class2.string_0 = string.Empty;
			base.method_1(new Action<IntPtr>(class2.method_0), false, false);
			if (class2.string_0 != string.Empty)
			{
				base.method_1(new Action<IntPtr>(class2.class814_0.method_0), false, false);
			}
		}
		finally
		{
			if (File.Exists(@class.string_0))
			{
				File.Delete(@class.string_0);
			}
		}
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x000A5300 File Offset: 0x000A3500
	public void method_25(string string_0)
	{
		base.method_1(new Action<IntPtr>(new GClass123.Class817
		{
			gclass123_0 = this,
			string_0 = string_0
		}.method_0), false, false);
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x000A5338 File Offset: 0x000A3538
	public List<GClass32> method_26(ref GClass32 gclass32_0)
	{
		GClass123.Class828 @class = new GClass123.Class828();
		@class.gclass123_0 = this;
		@class.list_0 = new List<GClass32>();
		@class.gclass32_0 = null;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		gclass32_0 = @class.gclass32_0;
		return @class.list_0;
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x000A5388 File Offset: 0x000A3588
	public void method_27(string string_0, string string_1)
	{
		base.method_1(new Action<IntPtr>(new GClass123.Class815
		{
			gclass123_0 = this,
			string_0 = string_0,
			string_1 = string_1
		}.method_0), false, false);
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x0001BC5D File Offset: 0x00019E5D
	public void method_28()
	{
		base.method_1(new Action<IntPtr>(this.method_41), false, false);
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x000A53C4 File Offset: 0x000A35C4
	public void method_29(string string_0, out bool bool_0)
	{
		GClass123.Class824 @class = new GClass123.Class824();
		@class.gclass123_0 = this;
		@class.string_0 = string_0;
		@class.bool_0 = false;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		bool_0 = @class.bool_0;
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x000A5408 File Offset: 0x000A3608
	public void method_30(string string_0, uint uint_0, out bool bool_0)
	{
		GClass123.Class820 @class = new GClass123.Class820();
		@class.gclass123_0 = this;
		@class.string_0 = string_0;
		@class.uint_0 = uint_0;
		@class.bool_0 = false;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		bool_0 = @class.bool_0;
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x000A5454 File Offset: 0x000A3654
	public void method_31(string string_0, uint uint_0, out bool bool_0)
	{
		GClass123.Class819 @class = new GClass123.Class819();
		@class.gclass123_0 = this;
		@class.string_0 = string_0;
		@class.uint_0 = uint_0;
		@class.bool_0 = false;
		base.method_1(new Action<IntPtr>(@class.method_0), false, false);
		bool_0 = @class.bool_0;
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x000A54A0 File Offset: 0x000A36A0
	public uint method_32(string string_0, uint uint_0, bool bool_0, bool bool_1)
	{
		return base.method_2<uint>(new Func<IntPtr, uint>(new GClass123.Class816
		{
			gclass123_0 = this,
			string_0 = string_0,
			uint_0 = uint_0,
			bool_0 = bool_0
		}.method_0), false);
	}

	// Token: 0x06002AE4 RID: 10980 RVA: 0x000A54E4 File Offset: 0x000A36E4
	public void method_33(string string_0, uint uint_0, uint uint_1)
	{
		base.method_1(new Action<IntPtr>(new GClass123.Class818
		{
			gclass123_0 = this,
			string_0 = string_0,
			uint_0 = uint_0,
			uint_1 = uint_1
		}.method_0), false, false);
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x000A5528 File Offset: 0x000A3728
	public int method_34(GClass32 gclass32_0, IEnumerable<GClass208> ienumerable_0)
	{
		base.method_1(new Action<IntPtr>(new GClass123.Class823
		{
			gclass123_0 = this,
			gclass32_0 = gclass32_0,
			ienumerable_0 = ienumerable_0
		}.method_0), false, false);
		return 0;
	}

	// Token: 0x06002AE6 RID: 10982 RVA: 0x000A5568 File Offset: 0x000A3768
	private GClass208 method_35(NVDRS_SETTING nvdrs_SETTING_0, bool bool_0)
	{
		GClass112 gclass = this.gclass50_0.method_16(nvdrs_SETTING_0.settingId, (GEnum11)0);
		gclass.method_1(new NVDRS_SETTING_TYPE?(nvdrs_SETTING_0.settingType));
		if (gclass.method_18() == null)
		{
			gclass.method_19(new List<GClass277<uint>>());
		}
		if (gclass.method_16() == null)
		{
			gclass.method_17(new List<GClass277<string>>());
		}
		if (gclass.method_20() == null)
		{
			gclass.method_21(new List<GClass277<byte[]>>());
		}
		dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.NotAssiged;
		string string_ = string.Empty;
		string string_2 = string.Empty;
		object object_ = null;
		NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = gclass.method_0();
		if (nvdrs_SETTING_TYPE.GetValueOrDefault() == 0 & nvdrs_SETTING_TYPE != null)
		{
			if (bool_0)
			{
				string_ = GClass223.smethod_0(gclass.method_8());
				string_2 = GClass223.smethod_3(gclass, gclass.method_8());
				object_ = gclass.method_8();
			}
			else if (nvdrs_SETTING_0.isCurrentPredefined == 1U && nvdrs_SETTING_0.isPredefinedValid == 1U)
			{
				string_ = GClass223.smethod_0(nvdrs_SETTING_0.predefinedValue.dwordValue);
				string_2 = GClass223.smethod_3(gclass, nvdrs_SETTING_0.predefinedValue.dwordValue);
				object_ = nvdrs_SETTING_0.predefinedValue.dwordValue;
				if (nvdrs_SETTING_0.settingLocation == null)
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.NvidiaSetting;
				}
				else
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.GlobalSetting;
				}
			}
			else
			{
				string_ = GClass223.smethod_0(nvdrs_SETTING_0.currentValue.dwordValue);
				string_2 = GClass223.smethod_3(gclass, nvdrs_SETTING_0.currentValue.dwordValue);
				object_ = nvdrs_SETTING_0.currentValue.dwordValue;
				if (nvdrs_SETTING_0.settingLocation == null)
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.UserdefinedSetting;
				}
				else
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.GlobalSetting;
				}
			}
		}
		if (gclass.method_0().GetValueOrDefault() == 3)
		{
			if (bool_0)
			{
				string_ = gclass.method_6();
				string_2 = GClass223.smethod_5(gclass, gclass.method_6());
				object_ = gclass.method_6();
			}
			else if (nvdrs_SETTING_0.isCurrentPredefined == 1U && nvdrs_SETTING_0.isPredefinedValid == 1U)
			{
				string_ = nvdrs_SETTING_0.predefinedValue.stringValue;
				string_2 = GClass223.smethod_5(gclass, nvdrs_SETTING_0.predefinedValue.stringValue);
				object_ = nvdrs_SETTING_0.predefinedValue.stringValue;
				state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.NvidiaSetting;
			}
			else
			{
				string_ = nvdrs_SETTING_0.currentValue.stringValue;
				string_2 = GClass223.smethod_5(gclass, nvdrs_SETTING_0.currentValue.stringValue);
				object_ = nvdrs_SETTING_0.currentValue.stringValue;
				if (nvdrs_SETTING_0.settingLocation == null)
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.UserdefinedSetting;
				}
				else
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.GlobalSetting;
				}
			}
		}
		if (gclass.method_0().GetValueOrDefault() == 1)
		{
			if (bool_0)
			{
				string_ = GClass223.smethod_6(gclass.method_10());
				string_2 = GClass223.smethod_7(gclass, gclass.method_10());
				object_ = gclass.method_10();
			}
			else if (nvdrs_SETTING_0.isCurrentPredefined == 1U && nvdrs_SETTING_0.isPredefinedValid == 1U)
			{
				string_ = GClass223.smethod_6(nvdrs_SETTING_0.predefinedValue.binaryValue);
				string_2 = GClass223.smethod_7(gclass, nvdrs_SETTING_0.predefinedValue.binaryValue);
				object_ = nvdrs_SETTING_0.predefinedValue.binaryValue;
				state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.NvidiaSetting;
			}
			else
			{
				string_ = GClass223.smethod_6(nvdrs_SETTING_0.currentValue.binaryValue);
				string_2 = GClass223.smethod_7(gclass, nvdrs_SETTING_0.currentValue.binaryValue);
				object_ = nvdrs_SETTING_0.currentValue.binaryValue;
				if (nvdrs_SETTING_0.settingLocation == null)
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.UserdefinedSetting;
				}
				else
				{
					state = dje_zA9LCWLS2JV757ARNHV7EU7PZGRF5CUX46BNNGT4L_ejd.GlobalSetting;
				}
			}
		}
		GClass208 gclass2 = new GClass208();
		gclass2.method_1(nvdrs_SETTING_0.settingId);
		gclass2.method_3(gclass.method_4());
		gclass2.method_11(gclass.method_2());
		gclass2.method_9(object_);
		gclass2.method_7(string_);
		gclass2.method_5(string_2);
		gclass2.State = state;
		gclass2.method_13(gclass.method_0().GetValueOrDefault() == 3);
		gclass2.method_15(gclass.method_12());
		gclass2.method_17(gclass.method_14());
		return gclass2;
	}

	// Token: 0x06002AE7 RID: 10983 RVA: 0x000A58C8 File Offset: 0x000A3AC8
	public List<GClass208> method_36(string string_0, GEnum11 genum11_0, ref Dictionary<string, string> dictionary_0)
	{
		GClass123.Class825 @class = new GClass123.Class825();
		@class.gclass123_0 = this;
		@class.string_0 = string_0;
		@class.list_0 = new List<GClass208>();
		@class.list_1 = this.gclass50_0.method_11(genum11_0);
		@class.list_1.AddRange(this.list_0);
		@class.list_1 = @class.list_1.Distinct<uint>().ToList<uint>();
		dictionary_0 = base.method_2<Dictionary<string, string>>(new Func<IntPtr, Dictionary<string, string>>(@class.method_0), false);
		return @class.list_0.OrderBy(new Func<GClass208, string>(GClass123.Class829.class829_0.method_3)).ThenBy(new Func<GClass208, string>(GClass123.Class829.class829_0.method_4)).ToList<GClass208>();
	}

	// Token: 0x06002AE8 RID: 10984 RVA: 0x000A5998 File Offset: 0x000A3B98
	public void method_37(string string_0, string string_1)
	{
		base.method_1(new Action<IntPtr>(new GClass123.Class821
		{
			gclass123_0 = this,
			string_0 = string_0,
			string_1 = string_1
		}.method_0), false, false);
	}

	// Token: 0x06002AE9 RID: 10985 RVA: 0x000A59D4 File Offset: 0x000A3BD4
	public void method_38(string string_0, string string_1)
	{
		base.method_1(new Action<IntPtr>(new GClass123.Class822
		{
			gclass123_0 = this,
			string_0 = string_0,
			string_1 = string_1
		}.method_0), false, false);
	}

	// Token: 0x06002AEA RID: 10986 RVA: 0x000A5A10 File Offset: 0x000A3C10
	private string method_39(NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V3_0)
	{
		return string.Concat(new string[]
		{
			nvdrs_APPLICATION_V3_0.appName,
			"|",
			nvdrs_APPLICATION_V3_0.fileInFolder,
			"|",
			nvdrs_APPLICATION_V3_0.userFriendlyName,
			"|",
			nvdrs_APPLICATION_V3_0.launcher
		});
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x000A5A68 File Offset: 0x000A3C68
	private List<uint> method_40(IntPtr intptr_0)
	{
		IntPtr intptr_ = base.method_3(intptr_0, string.Empty);
		return base.method_15(intptr_0, intptr_).Select(new Func<NVDRS_SETTING, uint>(GClass123.Class829.class829_0.method_0)).ToList<uint>();
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x000A5AB4 File Offset: 0x000A3CB4
	private void method_41(IntPtr intptr_0)
	{
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_RestoreAllDefaults.Invoke(intptr_0);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_RestoreAllDefaults", nvapi_STATUS);
		}
		base.method_17(intptr_0);
	}

	// Token: 0x04001BD1 RID: 7121
	private readonly List<uint> list_0;

	// Token: 0x0200069C RID: 1692
	private sealed class Class814
	{
		// Token: 0x06002AEE RID: 10990 RVA: 0x0001BC73 File Offset: 0x00019E73
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass123_0.method_18(intptr_0, this.string_0);
			this.gclass123_0.method_17(intptr_0);
		}

		// Token: 0x04001BD2 RID: 7122
		public GClass123 gclass123_0;

		// Token: 0x04001BD3 RID: 7123
		public string string_0;

		// Token: 0x04001BD4 RID: 7124
		public string string_1;
	}

	// Token: 0x0200069D RID: 1693
	private sealed class Class815
	{
		// Token: 0x06002AF0 RID: 10992 RVA: 0x000A5AE4 File Offset: 0x000A3CE4
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_4(intptr_0, this.string_0);
			if (this.string_1 != null)
			{
				this.gclass123_0.method_12(intptr_0, intptr_, this.string_1);
			}
			this.gclass123_0.method_17(intptr_0);
		}

		// Token: 0x04001BD5 RID: 7125
		public GClass123 gclass123_0;

		// Token: 0x04001BD6 RID: 7126
		public string string_0;

		// Token: 0x04001BD7 RID: 7127
		public string string_1;
	}

	// Token: 0x0200069E RID: 1694
	private sealed class Class816
	{
		// Token: 0x06002AF2 RID: 10994 RVA: 0x000A5B2C File Offset: 0x000A3D2C
		internal uint method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_3(intptr_0, this.string_0);
			uint? num = this.gclass123_0.method_11(intptr_0, intptr_, this.uint_0);
			if (num != null)
			{
				return num.Value;
			}
			if (!this.bool_0)
			{
				throw new GException6("DRS_GetSetting", -160);
			}
			return this.gclass123_0.gclass50_0.method_16(this.uint_0, (GEnum11)0).method_8();
		}

		// Token: 0x04001BD8 RID: 7128
		public GClass123 gclass123_0;

		// Token: 0x04001BD9 RID: 7129
		public string string_0;

		// Token: 0x04001BDA RID: 7130
		public uint uint_0;

		// Token: 0x04001BDB RID: 7131
		public bool bool_0;
	}

	// Token: 0x0200069F RID: 1695
	private sealed class Class817
	{
		// Token: 0x06002AF4 RID: 10996 RVA: 0x000A5BA8 File Offset: 0x000A3DA8
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intPtr = this.gclass123_0.method_3(intptr_0, this.string_0);
			if (intPtr != IntPtr.Zero)
			{
				NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_DeleteProfile.Invoke(intptr_0, intPtr);
				if (nvapi_STATUS != null)
				{
					throw new GException6("DRS_DeleteProfile", nvapi_STATUS);
				}
				this.gclass123_0.method_17(intptr_0);
			}
		}

		// Token: 0x04001BDC RID: 7132
		public GClass123 gclass123_0;

		// Token: 0x04001BDD RID: 7133
		public string string_0;
	}

	// Token: 0x020006A0 RID: 1696
	private sealed class Class818
	{
		// Token: 0x06002AF6 RID: 10998 RVA: 0x000A5C00 File Offset: 0x000A3E00
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_3(intptr_0, this.string_0);
			this.gclass123_0.method_7(intptr_0, intptr_, this.uint_0, this.uint_1);
			this.gclass123_0.method_17(intptr_0);
		}

		// Token: 0x04001BDE RID: 7134
		public GClass123 gclass123_0;

		// Token: 0x04001BDF RID: 7135
		public string string_0;

		// Token: 0x04001BE0 RID: 7136
		public uint uint_0;

		// Token: 0x04001BE1 RID: 7137
		public uint uint_1;
	}

	// Token: 0x020006A1 RID: 1697
	private sealed class Class819
	{
		// Token: 0x06002AF8 RID: 11000 RVA: 0x000A5C48 File Offset: 0x000A3E48
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intPtr = this.gclass123_0.method_3(intptr_0, this.string_0);
			if (intPtr != IntPtr.Zero)
			{
				int num = 0;
				foreach (NVDRS_SETTING nvdrs_SETTING in this.gclass123_0.method_15(intptr_0, intPtr))
				{
					if (nvdrs_SETTING.settingId == this.uint_0 && nvdrs_SETTING.settingLocation == null && NVAPIDrsWrapper.DRS_DeleteProfileSetting.Invoke(intptr_0, intPtr, nvdrs_SETTING.settingId) == null)
					{
						num++;
						break;
					}
				}
				this.bool_0 = (num == 0);
				this.gclass123_0.method_17(intptr_0);
			}
		}

		// Token: 0x04001BE2 RID: 7138
		public GClass123 gclass123_0;

		// Token: 0x04001BE3 RID: 7139
		public string string_0;

		// Token: 0x04001BE4 RID: 7140
		public uint uint_0;

		// Token: 0x04001BE5 RID: 7141
		public bool bool_0;
	}

	// Token: 0x020006A2 RID: 1698
	private sealed class Class820
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x000A5D04 File Offset: 0x000A3F04
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intPtr = this.gclass123_0.method_3(intptr_0, this.string_0);
			if (intPtr != IntPtr.Zero)
			{
				NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_RestoreProfileDefaultSetting.Invoke(intptr_0, intPtr, this.uint_0);
				if (nvapi_STATUS != null)
				{
					throw new GException6("DRS_RestoreProfileDefaultSetting", nvapi_STATUS);
				}
				this.gclass123_0.method_17(intptr_0);
				int num = 0;
				foreach (NVDRS_SETTING nvdrs_SETTING in this.gclass123_0.method_15(intptr_0, intPtr))
				{
					if (nvdrs_SETTING.isCurrentPredefined == 0U && nvdrs_SETTING.settingLocation == null)
					{
						num++;
					}
				}
				this.bool_0 = (num == 0);
			}
		}

		// Token: 0x04001BE6 RID: 7142
		public GClass123 gclass123_0;

		// Token: 0x04001BE7 RID: 7143
		public string string_0;

		// Token: 0x04001BE8 RID: 7144
		public uint uint_0;

		// Token: 0x04001BE9 RID: 7145
		public bool bool_0;
	}

	// Token: 0x020006A3 RID: 1699
	private sealed class Class821
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x000A5DCC File Offset: 0x000A3FCC
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_3(intptr_0, this.string_0);
			this.gclass123_0.method_12(intptr_0, intptr_, this.string_1);
			this.gclass123_0.method_17(intptr_0);
		}

		// Token: 0x04001BEA RID: 7146
		public GClass123 gclass123_0;

		// Token: 0x04001BEB RID: 7147
		public string string_0;

		// Token: 0x04001BEC RID: 7148
		public string string_1;
	}

	// Token: 0x020006A4 RID: 1700
	private sealed class Class822
	{
		// Token: 0x06002AFE RID: 11006 RVA: 0x000A5E0C File Offset: 0x000A400C
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_3(intptr_0, this.string_0);
			foreach (NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V3_ in this.gclass123_0.method_16(intptr_0, intptr_))
			{
				if (!(this.gclass123_0.method_39(nvdrs_APPLICATION_V3_) != this.string_1))
				{
					this.gclass123_0.method_13(intptr_0, intptr_, nvdrs_APPLICATION_V3_);
					break;
				}
			}
			this.gclass123_0.method_17(intptr_0);
		}

		// Token: 0x04001BED RID: 7149
		public GClass123 gclass123_0;

		// Token: 0x04001BEE RID: 7150
		public string string_0;

		// Token: 0x04001BEF RID: 7151
		public string string_1;
	}

	// Token: 0x020006A5 RID: 1701
	private sealed class Class823
	{
		// Token: 0x06002B00 RID: 11008 RVA: 0x000A5EA8 File Offset: 0x000A40A8
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_3(intptr_0, this.gclass32_0.ProfileName);
			foreach (GClass208 gclass in this.ienumerable_0)
			{
				GClass112 gclass2 = this.gclass123_0.gclass50_0.method_16(gclass.method_0(), (GEnum11)0);
				NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE = gclass2.method_0();
				NVDRS_SETTING_TYPE? nvdrs_SETTING_TYPE2 = nvdrs_SETTING_TYPE;
				if (nvdrs_SETTING_TYPE2.GetValueOrDefault() == 0 & nvdrs_SETTING_TYPE2 != null)
				{
					uint uint_ = GClass223.smethod_2(gclass2, gclass.method_4());
					this.gclass123_0.method_7(intptr_0, intptr_, gclass.method_0(), uint_);
				}
				else if (nvdrs_SETTING_TYPE.GetValueOrDefault() == 3)
				{
					string string_ = GClass223.smethod_4(gclass2, gclass.method_4());
					this.gclass123_0.method_8(intptr_0, intptr_, gclass.method_0(), string_);
				}
				else if (nvdrs_SETTING_TYPE.GetValueOrDefault() == 1)
				{
					byte[] byte_ = GClass223.smethod_8(gclass2, gclass.method_4());
					this.gclass123_0.method_9(intptr_0, intptr_, gclass.method_0(), byte_);
				}
			}
			this.gclass123_0.method_17(intptr_0);
		}

		// Token: 0x04001BF0 RID: 7152
		public GClass123 gclass123_0;

		// Token: 0x04001BF1 RID: 7153
		public GClass32 gclass32_0;

		// Token: 0x04001BF2 RID: 7154
		public IEnumerable<GClass208> ienumerable_0;
	}

	// Token: 0x020006A6 RID: 1702
	private sealed class Class824
	{
		// Token: 0x06002B02 RID: 11010 RVA: 0x000A5FD4 File Offset: 0x000A41D4
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intPtr = this.gclass123_0.method_3(intptr_0, this.string_0);
			NVDRS_PROFILE nvdrs_PROFILE = this.gclass123_0.method_5(intptr_0, intPtr);
			if (nvdrs_PROFILE.isPredefined != 1U)
			{
				if (nvdrs_PROFILE.numOfSettings > 0U)
				{
					int num = 0;
					foreach (NVDRS_SETTING nvdrs_SETTING in this.gclass123_0.method_15(intptr_0, intPtr))
					{
						if (nvdrs_SETTING.settingLocation == null && NVAPIDrsWrapper.DRS_DeleteProfileSetting.Invoke(intptr_0, intPtr, nvdrs_SETTING.settingId) == null)
						{
							num++;
						}
					}
					if (num > 0)
					{
						this.gclass123_0.method_17(intptr_0);
					}
				}
				return;
			}
			NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_RestoreProfileDefault.Invoke(intptr_0, intPtr);
			if (nvapi_STATUS != null)
			{
				throw new GException6("DRS_RestoreProfileDefault", nvapi_STATUS);
			}
			this.gclass123_0.method_17(intptr_0);
			this.bool_0 = true;
		}

		// Token: 0x04001BF3 RID: 7155
		public GClass123 gclass123_0;

		// Token: 0x04001BF4 RID: 7156
		public string string_0;

		// Token: 0x04001BF5 RID: 7157
		public bool bool_0;
	}

	// Token: 0x020006A7 RID: 1703
	private sealed class Class825
	{
		// Token: 0x06002B04 RID: 11012 RVA: 0x000A60C4 File Offset: 0x000A42C4
		internal Dictionary<string, string> method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_3(intptr_0, this.string_0);
			foreach (NVDRS_SETTING nvdrs_SETTING in this.gclass123_0.method_15(intptr_0, intptr_))
			{
				this.list_0.Add(this.gclass123_0.method_35(nvdrs_SETTING, false));
				if (this.list_1.Contains(nvdrs_SETTING.settingId))
				{
					this.list_1.Remove(nvdrs_SETTING.settingId);
				}
			}
			foreach (uint num in this.list_1)
			{
				if (num != 0U)
				{
					NVDRS_SETTING? nvdrs_SETTING2 = this.gclass123_0.method_10(intptr_0, intptr_, num);
					if (nvdrs_SETTING2 != null)
					{
						this.list_0.Add(this.gclass123_0.method_35(nvdrs_SETTING2.Value, false));
					}
					else
					{
						NVDRS_SETTING nvdrs_SETTING3 = default(NVDRS_SETTING);
						nvdrs_SETTING3.settingId = num;
						NVDRS_SETTING nvdrs_SETTING_ = nvdrs_SETTING3;
						this.list_0.Add(this.gclass123_0.method_35(nvdrs_SETTING_, true));
					}
				}
			}
			IEnumerable<NVDRS_APPLICATION_V3> source = this.gclass123_0.method_16(intptr_0, intptr_);
			Func<NVDRS_APPLICATION_V3, Tuple<string, string>> selector;
			if ((selector = this.func_0) == null)
			{
				selector = (this.func_0 = new Func<NVDRS_APPLICATION_V3, Tuple<string, string>>(this.method_1));
			}
			return source.Select(selector).ToDictionary(new Func<Tuple<string, string>, string>(GClass123.Class829.class829_0.method_1), new Func<Tuple<string, string>, string>(GClass123.Class829.class829_0.method_2));
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x0001BC93 File Offset: 0x00019E93
		internal Tuple<string, string> method_1(NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V3_0)
		{
			return Tuple.Create<string, string>(nvdrs_APPLICATION_V3_0.appName, this.gclass123_0.method_39(nvdrs_APPLICATION_V3_0));
		}

		// Token: 0x04001BF6 RID: 7158
		public GClass123 gclass123_0;

		// Token: 0x04001BF7 RID: 7159
		public string string_0;

		// Token: 0x04001BF8 RID: 7160
		public List<GClass208> list_0;

		// Token: 0x04001BF9 RID: 7161
		public List<uint> list_1;

		// Token: 0x04001BFA RID: 7162
		public Func<NVDRS_APPLICATION_V3, Tuple<string, string>> func_0;
	}

	// Token: 0x020006A8 RID: 1704
	private sealed class Class826
	{
		// Token: 0x06002B07 RID: 11015 RVA: 0x000A6284 File Offset: 0x000A4484
		internal void method_0(IntPtr intptr_0)
		{
			this.class814_0.gclass123_0.method_19(intptr_0, this.class814_0.string_0);
			this.string_0 = File.ReadAllText(this.class814_0.string_0);
			string pattern = "(?<rpl>\nProfile\\s\"" + Regex.Escape(this.class814_0.string_1) + "\".*?EndProfile.*?\n)";
			this.string_0 = Regex.Replace(this.string_0, pattern, string.Empty, RegexOptions.Singleline);
			File.WriteAllText(this.class814_0.string_0, this.string_0);
		}

		// Token: 0x04001BFB RID: 7163
		public string string_0;

		// Token: 0x04001BFC RID: 7164
		public GClass123.Class814 class814_0;
	}

	// Token: 0x020006A9 RID: 1705
	private sealed class Class827
	{
		// Token: 0x06002B09 RID: 11017 RVA: 0x0001BCAC File Offset: 0x00019EAC
		internal void method_0(IntPtr intptr_0)
		{
			this.gclass123_0.method_18(intptr_0, this.string_0);
			this.gclass123_0.method_17(intptr_0);
		}

		// Token: 0x04001BFD RID: 7165
		public GClass123 gclass123_0;

		// Token: 0x04001BFE RID: 7166
		public string string_0;
	}

	// Token: 0x020006AA RID: 1706
	private sealed class Class828
	{
		// Token: 0x06002B0B RID: 11019 RVA: 0x000A6314 File Offset: 0x000A4514
		internal void method_0(IntPtr intptr_0)
		{
			IntPtr intptr_ = this.gclass123_0.method_3(intptr_0, null);
			NVDRS_PROFILE nvdrs_PROFILE_ = this.gclass123_0.method_5(intptr_0, intptr_);
			this.gclass32_0 = new GClass32(nvdrs_PROFILE_);
			this.list_0.Add(this.gclass32_0);
			foreach (IntPtr intptr_2 in this.gclass123_0.method_14(intptr_0))
			{
				NVDRS_PROFILE nvdrs_PROFILE = this.gclass123_0.method_5(intptr_0, intptr_2);
				if (nvdrs_PROFILE.isPredefined == 0U || nvdrs_PROFILE.numOfApps > 0U)
				{
					this.list_0.Add(new GClass32(nvdrs_PROFILE));
				}
			}
		}

		// Token: 0x04001BFF RID: 7167
		public GClass123 gclass123_0;

		// Token: 0x04001C00 RID: 7168
		public GClass32 gclass32_0;

		// Token: 0x04001C01 RID: 7169
		public List<GClass32> list_0;
	}

	// Token: 0x020006AB RID: 1707
	[Serializable]
	private sealed class Class829
	{
		// Token: 0x06002B0E RID: 11022 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		internal uint method_0(NVDRS_SETTING nvdrs_SETTING_0)
		{
			return nvdrs_SETTING_0.settingId;
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x0001BCE0 File Offset: 0x00019EE0
		internal string method_1(Tuple<string, string> tuple_0)
		{
			return tuple_0.Item2;
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x0001BCE8 File Offset: 0x00019EE8
		internal string method_2(Tuple<string, string> tuple_0)
		{
			return tuple_0.Item1;
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		internal string method_3(GClass208 gclass208_0)
		{
			return gclass208_0.method_2();
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		internal string method_4(GClass208 gclass208_0)
		{
			return gclass208_0.method_10();
		}

		// Token: 0x04001C02 RID: 7170
		public static readonly GClass123.Class829 class829_0 = new GClass123.Class829();

		// Token: 0x04001C03 RID: 7171
		public static Func<NVDRS_SETTING, uint> func_0;

		// Token: 0x04001C04 RID: 7172
		public static Func<Tuple<string, string>, string> func_1;

		// Token: 0x04001C05 RID: 7173
		public static Func<Tuple<string, string>, string> func_2;

		// Token: 0x04001C06 RID: 7174
		public static Func<GClass208, string> func_3;

		// Token: 0x04001C07 RID: 7175
		public static Func<GClass208, string> func_4;
	}
}
