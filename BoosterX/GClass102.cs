using System;
using System.Runtime.CompilerServices;
using System.ServiceProcess;

// Token: 0x0200030F RID: 783
public sealed class GClass102
{
	// Token: 0x170002EE RID: 750
	// (get) Token: 0x06001434 RID: 5172 RVA: 0x0000E262 File Offset: 0x0000C462
	// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000E26A File Offset: 0x0000C46A
	public string Name
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

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x06001436 RID: 5174 RVA: 0x0000E273 File Offset: 0x0000C473
	// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000E27B File Offset: 0x0000C47B
	public ServiceStartMode Status
	{
		[CompilerGenerated]
		get
		{
			return this.serviceStartMode_0;
		}
		[CompilerGenerated]
		set
		{
			this.serviceStartMode_0 = value;
		}
	}

	// Token: 0x04000DA0 RID: 3488
	private string string_0;

	// Token: 0x04000DA1 RID: 3489
	private ServiceStartMode serviceStartMode_0;
}
