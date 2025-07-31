using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000383 RID: 899
public abstract class GClass119
{
	// Token: 0x0600175E RID: 5982 RVA: 0x000100D9 File Offset: 0x0000E2D9
	public GClass119(GClass50 gclass50_1, GClass120 gclass120_1 = null)
	{
		this.gclass50_0 = gclass50_1;
		this.gclass120_0 = gclass120_1;
		this.float_0 = this.method_0();
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x0006AFE8 File Offset: 0x000691E8
	private float method_0()
	{
		float result = 0f;
		uint num = 0U;
		StringBuilder stringBuilder = new StringBuilder(64);
		if (NVAPIDrsWrapper.SYS_GetDriverAndBranchVersion.Invoke(ref num, stringBuilder) == null)
		{
			try
			{
				result = num / 100f;
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x000100FB File Offset: 0x0000E2FB
	protected void method_1(Action<IntPtr> action_0, bool bool_0, bool bool_1)
	{
		GClass265.smethod_0<bool>(new Func<IntPtr, bool>(new GClass119.Class421
		{
			action_0 = action_0
		}.method_0), bool_0, bool_1);
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x0001011C File Offset: 0x0000E31C
	protected T method_2<T>(Func<IntPtr, T> func_0, bool bool_0)
	{
		return GClass265.smethod_0<T>(func_0, bool_0, false);
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x0006B038 File Offset: 0x00069238
	protected IntPtr method_3(IntPtr intptr_0, string string_0)
	{
		IntPtr zero = IntPtr.Zero;
		if (string.IsNullOrEmpty(string_0))
		{
			NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_GetCurrentGlobalProfile.Invoke(intptr_0, ref zero);
			if (zero == IntPtr.Zero)
			{
				throw new GException6("DRS_GetCurrentGlobalProfile", -163);
			}
			if (nvapi_STATUS != null)
			{
				throw new GException6("DRS_GetCurrentGlobalProfile", nvapi_STATUS);
			}
		}
		else
		{
			NVAPI_STATUS nvapi_STATUS2 = NVAPIDrsWrapper.DRS_FindProfileByName.Invoke(intptr_0, new StringBuilder(string_0), ref zero);
			if (nvapi_STATUS2 == -163)
			{
				return IntPtr.Zero;
			}
			if (nvapi_STATUS2 != null)
			{
				throw new GException6("DRS_FindProfileByName", nvapi_STATUS2);
			}
		}
		return zero;
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x0006B0C4 File Offset: 0x000692C4
	protected IntPtr method_4(IntPtr intptr_0, string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException("#=zIiZaQCg=");
		}
		IntPtr zero = IntPtr.Zero;
		NVDRS_PROFILE nvdrs_PROFILE = default(NVDRS_PROFILE);
		nvdrs_PROFILE.version = NVAPIDrsWrapper.NVDRS_PROFILE_VER;
		nvdrs_PROFILE.profileName = string_0;
		NVDRS_PROFILE nvdrs_PROFILE2 = nvdrs_PROFILE;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_CreateProfile.Invoke(intptr_0, ref nvdrs_PROFILE2, ref zero);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_CreateProfile", nvapi_STATUS);
		}
		return zero;
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x0006B12C File Offset: 0x0006932C
	protected NVDRS_PROFILE method_5(IntPtr intptr_0, IntPtr intptr_1)
	{
		NVDRS_PROFILE nvdrs_PROFILE = default(NVDRS_PROFILE);
		nvdrs_PROFILE.version = NVAPIDrsWrapper.NVDRS_PROFILE_VER;
		NVDRS_PROFILE result = nvdrs_PROFILE;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_GetProfileInfo.Invoke(intptr_0, intptr_1, ref result);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_GetProfileInfo", nvapi_STATUS);
		}
		return result;
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x0006B170 File Offset: 0x00069370
	protected void method_6(IntPtr intptr_0, IntPtr intptr_1, NVDRS_SETTING nvdrs_SETTING_0)
	{
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_SetSetting(intptr_0, intptr_1, ref nvdrs_SETTING_0);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_SetSetting", nvapi_STATUS);
		}
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x0006B198 File Offset: 0x00069398
	protected void method_7(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1)
	{
		NVDRS_SETTING nvdrs_SETTING = default(NVDRS_SETTING);
		nvdrs_SETTING.version = NVAPIDrsWrapper.NVDRS_SETTING_VER;
		nvdrs_SETTING.settingId = uint_0;
		nvdrs_SETTING.settingType = 0;
		nvdrs_SETTING.settingLocation = 0;
		NVDRS_SETTING_UNION currentValue = default(NVDRS_SETTING_UNION);
		currentValue.dwordValue = uint_1;
		nvdrs_SETTING.currentValue = currentValue;
		NVDRS_SETTING nvdrs_SETTING2 = nvdrs_SETTING;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_SetSetting(intptr_0, intptr_1, ref nvdrs_SETTING2);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_SetSetting", nvapi_STATUS);
		}
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x0006B208 File Offset: 0x00069408
	protected void method_8(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, string string_0)
	{
		NVDRS_SETTING nvdrs_SETTING = default(NVDRS_SETTING);
		nvdrs_SETTING.version = NVAPIDrsWrapper.NVDRS_SETTING_VER;
		nvdrs_SETTING.settingId = uint_0;
		nvdrs_SETTING.settingType = 3;
		nvdrs_SETTING.settingLocation = 0;
		NVDRS_SETTING_UNION currentValue = default(NVDRS_SETTING_UNION);
		currentValue.stringValue = string_0;
		nvdrs_SETTING.currentValue = currentValue;
		NVDRS_SETTING nvdrs_SETTING2 = nvdrs_SETTING;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_SetSetting(intptr_0, intptr_1, ref nvdrs_SETTING2);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_SetSetting", nvapi_STATUS);
		}
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x0006B278 File Offset: 0x00069478
	protected void method_9(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, byte[] byte_0)
	{
		NVDRS_SETTING nvdrs_SETTING = default(NVDRS_SETTING);
		nvdrs_SETTING.version = NVAPIDrsWrapper.NVDRS_SETTING_VER;
		nvdrs_SETTING.settingId = uint_0;
		nvdrs_SETTING.settingType = 1;
		nvdrs_SETTING.settingLocation = 0;
		NVDRS_SETTING_UNION currentValue = default(NVDRS_SETTING_UNION);
		currentValue.binaryValue = byte_0;
		nvdrs_SETTING.currentValue = currentValue;
		NVDRS_SETTING nvdrs_SETTING2 = nvdrs_SETTING;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_SetSetting(intptr_0, intptr_1, ref nvdrs_SETTING2);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_SetSetting", nvapi_STATUS);
		}
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x0006B2E8 File Offset: 0x000694E8
	protected NVDRS_SETTING? method_10(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		NVDRS_SETTING nvdrs_SETTING = default(NVDRS_SETTING);
		nvdrs_SETTING.version = NVAPIDrsWrapper.NVDRS_SETTING_VER;
		NVDRS_SETTING value = nvdrs_SETTING;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_GetSetting(intptr_0, intptr_1, uint_0, ref value);
		if (nvapi_STATUS == -160)
		{
			return null;
		}
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_GetSetting", nvapi_STATUS);
		}
		if (this.gclass120_0 != null)
		{
			NVDRS_PROFILE nvdrs_PROFILE = this.method_5(intptr_0, intptr_1);
			this.gclass120_0.method_23(nvdrs_PROFILE.profileName, ref value);
		}
		return new NVDRS_SETTING?(value);
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x0006B364 File Offset: 0x00069564
	protected uint? method_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		NVDRS_SETTING? nvdrs_SETTING = this.method_10(intptr_0, intptr_1, uint_0);
		if (nvdrs_SETTING == null)
		{
			return null;
		}
		return new uint?(nvdrs_SETTING.Value.currentValue.dwordValue);
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x0006B3A8 File Offset: 0x000695A8
	protected void method_12(IntPtr intptr_0, IntPtr intptr_1, string string_0)
	{
		NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V = default(NVDRS_APPLICATION_V3);
		nvdrs_APPLICATION_V.version = NVAPIDrsWrapper.NVDRS_APPLICATION_VER_V3;
		nvdrs_APPLICATION_V.appName = string_0;
		NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V2 = nvdrs_APPLICATION_V;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_CreateApplication.Invoke(intptr_0, intptr_1, ref nvdrs_APPLICATION_V2);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_CreateApplication", nvapi_STATUS);
		}
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x0006B3F4 File Offset: 0x000695F4
	protected void method_13(IntPtr intptr_0, IntPtr intptr_1, NVDRS_APPLICATION_V3 nvdrs_APPLICATION_V3_0)
	{
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_DeleteApplicationEx.Invoke(intptr_0, intptr_1, ref nvdrs_APPLICATION_V3_0);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_DeleteApplication", nvapi_STATUS);
		}
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x0006B420 File Offset: 0x00069620
	protected List<IntPtr> method_14(IntPtr intptr_0)
	{
		List<IntPtr> list = new List<IntPtr>();
		IntPtr zero = IntPtr.Zero;
		uint num = 0U;
		NVAPI_STATUS nvapi_STATUS;
		do
		{
			nvapi_STATUS = NVAPIDrsWrapper.DRS_EnumProfiles.Invoke(intptr_0, num, ref zero);
			if (nvapi_STATUS == null)
			{
				list.Add(zero);
			}
			num += 1U;
		}
		while (nvapi_STATUS == null);
		if (nvapi_STATUS != -7)
		{
			throw new GException6("DRS_EnumProfiles", nvapi_STATUS);
		}
		return list;
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x0006B478 File Offset: 0x00069678
	protected List<NVDRS_SETTING> method_15(IntPtr intptr_0, IntPtr intptr_1)
	{
		uint num = 512U;
		NVDRS_SETTING[] array = new NVDRS_SETTING[512];
		array[0].version = NVAPIDrsWrapper.NVDRS_SETTING_VER;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_EnumSettings(intptr_0, intptr_1, 0U, ref num, ref array);
		if (nvapi_STATUS == -7)
		{
			return new List<NVDRS_SETTING>();
		}
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_EnumSettings", nvapi_STATUS);
		}
		if (this.gclass120_0 != null)
		{
			NVDRS_PROFILE nvdrs_PROFILE = this.method_5(intptr_0, intptr_1);
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				this.gclass120_0.method_23(nvdrs_PROFILE.profileName, ref array[num2]);
				num2++;
			}
		}
		return array.ToList<NVDRS_SETTING>();
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x0006B510 File Offset: 0x00069710
	protected List<NVDRS_APPLICATION_V3> method_16(IntPtr intptr_0, IntPtr intptr_1)
	{
		uint num = 512U;
		NVDRS_APPLICATION_V3[] array = new NVDRS_APPLICATION_V3[512];
		array[0].version = NVAPIDrsWrapper.NVDRS_APPLICATION_VER_V3;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_EnumApplications<NVDRS_APPLICATION_V3>(intptr_0, intptr_1, 0U, ref num, ref array);
		if (nvapi_STATUS == -7)
		{
			return new List<NVDRS_APPLICATION_V3>();
		}
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_EnumApplications", nvapi_STATUS);
		}
		return array.ToList<NVDRS_APPLICATION_V3>();
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x0006B570 File Offset: 0x00069770
	protected void method_17(IntPtr intptr_0)
	{
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_SaveSettings.Invoke(intptr_0);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_SaveSettings", nvapi_STATUS);
		}
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x0006B59C File Offset: 0x0006979C
	protected void method_18(IntPtr intptr_0, string string_0)
	{
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_LoadSettingsFromFileEx.Invoke(intptr_0, new StringBuilder(string_0));
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_LoadSettingsFromFileEx", nvapi_STATUS);
		}
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x0006B5CC File Offset: 0x000697CC
	protected void method_19(IntPtr intptr_0, string string_0)
	{
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_SaveSettingsToFileEx.Invoke(intptr_0, new StringBuilder(string_0));
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_SaveSettingsToFileEx", nvapi_STATUS);
		}
	}

	// Token: 0x04000F7A RID: 3962
	protected GClass50 gclass50_0;

	// Token: 0x04000F7B RID: 3963
	protected GClass120 gclass120_0;

	// Token: 0x04000F7C RID: 3964
	public readonly float float_0;

	// Token: 0x02000384 RID: 900
	private sealed class Class421
	{
		// Token: 0x06001774 RID: 6004 RVA: 0x00010126 File Offset: 0x0000E326
		internal bool method_0(IntPtr intptr_0)
		{
			this.action_0(intptr_0);
			return true;
		}

		// Token: 0x04000F7D RID: 3965
		public Action<IntPtr> action_0;
	}
}
