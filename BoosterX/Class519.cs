using System;

// Token: 0x020004F5 RID: 1269
internal sealed class Class519 : GClass162
{
	// Token: 0x0600202B RID: 8235 RVA: 0x000154D6 File Offset: 0x000136D6
	public Class519(Class326 class326_1)
	{
		this.class326_0 = class326_1;
	}

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x0600202C RID: 8236 RVA: 0x000154E5 File Offset: 0x000136E5
	public string Command
	{
		get
		{
			return this.class326_0.Command;
		}
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x0600202D RID: 8237 RVA: 0x00082954 File Offset: 0x00080B54
	public string Description
	{
		get
		{
			if (!(this.class326_0.Description[Class298.smethod_2("CurrentLocalization")] == string.Empty))
			{
				return Class298.smethod_2("Description") + ": " + this.class326_0.Description[Class298.smethod_2("CurrentLocalization")];
			}
			return Class298.smethod_2("NoDescription");
		}
	}

	// Token: 0x0400156B RID: 5483
	private Class326 class326_0;
}
