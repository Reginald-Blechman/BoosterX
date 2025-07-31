using System;
using NvidiaX.NVIDIA.Native.NVAPI;

// Token: 0x02000493 RID: 1171
public class GException6 : Exception
{
	// Token: 0x06001E64 RID: 7780 RVA: 0x0001409A File Offset: 0x0001229A
	public GException6(string string_0, NVAPI_STATUS nvapi_STATUS_1) : base(string_0 + " failed: " + nvapi_STATUS_1.ToString())
	{
		this.nvapi_STATUS_0 = nvapi_STATUS_1;
	}

	// Token: 0x04001426 RID: 5158
	public readonly NVAPI_STATUS nvapi_STATUS_0;
}
