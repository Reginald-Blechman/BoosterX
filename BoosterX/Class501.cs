using System;
using System.Runtime.CompilerServices;

// Token: 0x0200024F RID: 591
internal sealed class Class501 : GClass162
{
	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0000BB31 File Offset: 0x00009D31
	// (set) Token: 0x06000FFE RID: 4094 RVA: 0x0000BB39 File Offset: 0x00009D39
	public string _Name
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

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0000BB42 File Offset: 0x00009D42
	// (set) Token: 0x06001000 RID: 4096 RVA: 0x0000BB4A File Offset: 0x00009D4A
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			this._Name = value;
			base.method_0("Name");
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06001001 RID: 4097 RVA: 0x0000BB5F File Offset: 0x00009D5F
	// (set) Token: 0x06001002 RID: 4098 RVA: 0x0000BB67 File Offset: 0x00009D67
	public GClass280 _Click
	{
		[CompilerGenerated]
		get
		{
			return this.gclass280_0;
		}
		[CompilerGenerated]
		set
		{
			this.gclass280_0 = value;
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06001003 RID: 4099 RVA: 0x0000BB70 File Offset: 0x00009D70
	// (set) Token: 0x06001004 RID: 4100 RVA: 0x0000BB78 File Offset: 0x00009D78
	public GClass280 Click
	{
		get
		{
			return this._Click;
		}
		set
		{
			this._Click = value;
			base.method_0("Click");
		}
	}

	// Token: 0x04000A2B RID: 2603
	private string string_0;

	// Token: 0x04000A2C RID: 2604
	private GClass280 gclass280_0;
}
