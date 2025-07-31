using System;

// Token: 0x0200050C RID: 1292
internal sealed class Class618
{
	// Token: 0x060020BA RID: 8378 RVA: 0x00015A04 File Offset: 0x00013C04
	public Class618(Class745 class745_1)
	{
		this.class745_0 = class745_1;
	}

	// Token: 0x170005A1 RID: 1441
	// (get) Token: 0x060020BB RID: 8379 RVA: 0x00015A13 File Offset: 0x00013C13
	public string Command
	{
		get
		{
			return this.class745_0.Command;
		}
	}

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x060020BC RID: 8380 RVA: 0x00015A20 File Offset: 0x00013C20
	public string DefaultValue
	{
		get
		{
			return this.class745_0.DefaultValue;
		}
	}

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x060020BD RID: 8381 RVA: 0x00015A2D File Offset: 0x00013C2D
	public bool IsCheat
	{
		get
		{
			return this.class745_0.IsCheat;
		}
	}

	// Token: 0x170005A4 RID: 1444
	// (get) Token: 0x060020BE RID: 8382 RVA: 0x00015A3A File Offset: 0x00013C3A
	public bool IsClient
	{
		get
		{
			return this.class745_0.IsClient;
		}
	}

	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x060020BF RID: 8383 RVA: 0x00015A47 File Offset: 0x00013C47
	public bool IsServer
	{
		get
		{
			return this.class745_0.IsServer;
		}
	}

	// Token: 0x170005A6 RID: 1446
	// (get) Token: 0x060020C0 RID: 8384 RVA: 0x000835E4 File Offset: 0x000817E4
	public string Description
	{
		get
		{
			if (!(this.class745_0.Description[Class298.smethod_2("CurrentLocalization")] == string.Empty))
			{
				return this.class745_0.Description[Class298.smethod_2("CurrentLocalization")];
			}
			return Class298.smethod_2("NoDescription");
		}
	}

	// Token: 0x040015AC RID: 5548
	private Class745 class745_0;
}
