using System;
using System.ServiceProcess;

// Token: 0x0200014A RID: 330
internal sealed class Class185
{
	// Token: 0x06000979 RID: 2425 RVA: 0x00045388 File Offset: 0x00043588
	public static GClass184 smethod_0()
	{
		return new GClass184(new GClass189(new GClass165(new ServiceController(string.Empty))
		{
			ServiceName = "Test Service Name",
			DisplayName = "Display Name",
			DefaultStartMode = new ServiceStartMode?(ServiceStartMode.Manual),
			IsBlocked = false,
			CurrentStartMode = ServiceStartMode.Disabled,
			Status = ServiceControllerStatus.Running,
			ServiceType = new ServiceType?(ServiceType.Win32ShareProcess)
		}));
	}
}
