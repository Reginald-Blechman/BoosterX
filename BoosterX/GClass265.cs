using System;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000610 RID: 1552
public sealed class GClass265
{
	// Token: 0x0600277E RID: 10110 RVA: 0x0009AA74 File Offset: 0x00098C74
	public static T smethod_0<T>(Func<IntPtr, T> func_0, bool bool_1, bool bool_2)
	{
		object obj = GClass265.object_0;
		lock (obj)
		{
			if (!GClass265.bool_0 || bool_1)
			{
				return GClass265.smethod_2<T>(func_0, bool_2);
			}
			if (GClass265.intptr_0 == IntPtr.Zero)
			{
				NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_CreateSession.Invoke(ref GClass265.intptr_0);
				if (nvapi_STATUS != null)
				{
					throw new GException6("DRS_CreateSession", nvapi_STATUS);
				}
				if (!bool_2)
				{
					NVAPI_STATUS nvapi_STATUS2 = NVAPIDrsWrapper.DRS_LoadSettings.Invoke(GClass265.intptr_0);
					if (nvapi_STATUS2 != null)
					{
						throw new GException6("DRS_LoadSettings", nvapi_STATUS2);
					}
				}
			}
		}
		if (GClass265.intptr_0 != IntPtr.Zero)
		{
			return func_0(GClass265.intptr_0);
		}
		throw new Exception("GlobalSession is Zero!");
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x0009AB50 File Offset: 0x00098D50
	public static void smethod_1()
	{
		object obj = GClass265.object_0;
		lock (obj)
		{
			if (GClass265.intptr_0 != IntPtr.Zero)
			{
				NVAPIDrsWrapper.DRS_DestroySession.Invoke(GClass265.intptr_0);
				GClass265.intptr_0 = IntPtr.Zero;
			}
		}
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x0009ABBC File Offset: 0x00098DBC
	private static T smethod_2<T>(Func<IntPtr, T> func_0, bool bool_1)
	{
		IntPtr zero = IntPtr.Zero;
		NVAPI_STATUS nvapi_STATUS = NVAPIDrsWrapper.DRS_CreateSession.Invoke(ref zero);
		if (nvapi_STATUS != null)
		{
			throw new GException6("DRS_CreateSession", nvapi_STATUS);
		}
		T result;
		try
		{
			if (!bool_1)
			{
				NVAPI_STATUS nvapi_STATUS2 = NVAPIDrsWrapper.DRS_LoadSettings.Invoke(zero);
				if (nvapi_STATUS2 != null)
				{
					throw new GException6("DRS_LoadSettings", nvapi_STATUS2);
				}
			}
			result = func_0(zero);
		}
		finally
		{
			NVAPI_STATUS nvapi_STATUS3 = NVAPIDrsWrapper.DRS_DestroySession.Invoke(zero);
			if (nvapi_STATUS3 != null)
			{
				throw new GException6("DRS_DestroySession", nvapi_STATUS3);
			}
		}
		return result;
	}

	// Token: 0x04001A0D RID: 6669
	public static volatile IntPtr intptr_0;

	// Token: 0x04001A0E RID: 6670
	public static volatile bool bool_0 = true;

	// Token: 0x04001A0F RID: 6671
	private static object object_0 = new object();
}
