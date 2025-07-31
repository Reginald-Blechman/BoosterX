using System;
using System.Collections.Generic;
using System.ServiceProcess;

// Token: 0x02000135 RID: 309
public sealed class GClass165 : GClass162
{
	// Token: 0x060008F7 RID: 2295 RVA: 0x0004384C File Offset: 0x00041A4C
	public GClass165(ServiceController serviceController_0)
	{
		this.ServiceName = serviceController_0.ServiceName;
		this.DisplayName = serviceController_0.DisplayName;
		this.DefaultStartMode = GClass219.smethod_12(serviceController_0.ServiceName);
		if (this.DefaultStartMode.GetValueOrDefault() == ServiceStartMode.Disabled)
		{
			this.DefaultStartMode = null;
		}
		this.IsBlocked = GClass219.smethod_11(serviceController_0.ServiceName);
		this.WillBrake = GClass219.smethod_10(serviceController_0.ServiceName);
		try
		{
			this.CurrentStartMode = serviceController_0.StartType;
		}
		catch
		{
			this.CurrentStartMode = GClass219.smethod_1(serviceController_0.ServiceName);
		}
		try
		{
			this.Status = serviceController_0.Status;
		}
		catch
		{
			this.Status = Class734.smethod_11(serviceController_0.ServiceName);
		}
		try
		{
			this.ServiceType = new ServiceType?(serviceController_0.ServiceType);
		}
		catch
		{
			this.ServiceType = null;
		}
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00043960 File Offset: 0x00041B60
	internal void method_2()
	{
		try
		{
			this.CurrentStartMode = GClass219.smethod_1(this.ServiceName);
		}
		catch
		{
		}
		try
		{
			this.Status = Class734.smethod_11(this.ServiceName);
		}
		catch
		{
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000077CB File Offset: 0x000059CB
	// (set) Token: 0x060008FA RID: 2298 RVA: 0x000077D3 File Offset: 0x000059D3
	public string ServiceName
	{
		get
		{
			return this.string_0;
		}
		set
		{
			base.method_1<string>(ref this.string_0, value, "ServiceName", null);
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x060008FB RID: 2299 RVA: 0x000077EA File Offset: 0x000059EA
	// (set) Token: 0x060008FC RID: 2300 RVA: 0x000077F2 File Offset: 0x000059F2
	public string DisplayName
	{
		get
		{
			return this.string_1;
		}
		set
		{
			base.method_1<string>(ref this.string_1, value, "DisplayName", null);
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060008FD RID: 2301 RVA: 0x00007809 File Offset: 0x00005A09
	// (set) Token: 0x060008FE RID: 2302 RVA: 0x00007811 File Offset: 0x00005A11
	public List<string> WillBrake
	{
		get
		{
			return this.list_0;
		}
		set
		{
			base.method_1<List<string>>(ref this.list_0, value, "WillBrake", null);
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060008FF RID: 2303 RVA: 0x00007828 File Offset: 0x00005A28
	// (set) Token: 0x06000900 RID: 2304 RVA: 0x00007830 File Offset: 0x00005A30
	public bool IsBlocked
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			base.method_1<bool>(ref this.bool_0, value, "IsBlocked", null);
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000901 RID: 2305 RVA: 0x00007847 File Offset: 0x00005A47
	// (set) Token: 0x06000902 RID: 2306 RVA: 0x0000784F File Offset: 0x00005A4F
	public ServiceStartMode? DefaultStartMode
	{
		get
		{
			return this.nullable_0;
		}
		set
		{
			base.method_1<ServiceStartMode?>(ref this.nullable_0, value, "DefaultStartMode", null);
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000903 RID: 2307 RVA: 0x00007866 File Offset: 0x00005A66
	// (set) Token: 0x06000904 RID: 2308 RVA: 0x0000786E File Offset: 0x00005A6E
	public ServiceStartMode CurrentStartMode
	{
		get
		{
			return this.serviceStartMode_0;
		}
		set
		{
			base.method_1<ServiceStartMode>(ref this.serviceStartMode_0, value, "CurrentStartMode", null);
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000905 RID: 2309 RVA: 0x00007885 File Offset: 0x00005A85
	// (set) Token: 0x06000906 RID: 2310 RVA: 0x0000788D File Offset: 0x00005A8D
	public ServiceControllerStatus Status
	{
		get
		{
			return this.serviceControllerStatus_0;
		}
		set
		{
			base.method_1<ServiceControllerStatus>(ref this.serviceControllerStatus_0, value, "Status", null);
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000907 RID: 2311 RVA: 0x000078A4 File Offset: 0x00005AA4
	// (set) Token: 0x06000908 RID: 2312 RVA: 0x000078AC File Offset: 0x00005AAC
	public ServiceType? ServiceType
	{
		get
		{
			return this.nullable_1;
		}
		set
		{
			base.method_1<ServiceType?>(ref this.nullable_1, value, "ServiceType", null);
		}
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x000078C3 File Offset: 0x00005AC3
	public bool method_3()
	{
		return !this.method_4();
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x000439B8 File Offset: 0x00041BB8
	public bool method_4()
	{
		ServiceType? serviceType = this.ServiceType;
		if (serviceType != null)
		{
			ServiceType valueOrDefault = serviceType.GetValueOrDefault();
			if (valueOrDefault - System.ServiceProcess.ServiceType.KernelDriver <= 1 || valueOrDefault == System.ServiceProcess.ServiceType.RecognizerDriver)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x000078CE File Offset: 0x00005ACE
	internal bool method_5(string string_2)
	{
		List<string> list = this.list_0;
		return list != null && list.Contains(string_2);
	}

	// Token: 0x0400060B RID: 1547
	private string string_0;

	// Token: 0x0400060C RID: 1548
	private string string_1;

	// Token: 0x0400060D RID: 1549
	private List<string> list_0;

	// Token: 0x0400060E RID: 1550
	private bool bool_0;

	// Token: 0x0400060F RID: 1551
	private ServiceStartMode? nullable_0;

	// Token: 0x04000610 RID: 1552
	private ServiceStartMode serviceStartMode_0;

	// Token: 0x04000611 RID: 1553
	private ServiceControllerStatus serviceControllerStatus_0;

	// Token: 0x04000612 RID: 1554
	private ServiceType? nullable_1;
}
