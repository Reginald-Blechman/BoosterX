using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200021D RID: 541
internal sealed class Class254
{
	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0000ADE3 File Offset: 0x00008FE3
	// (set) Token: 0x06000EAB RID: 3755 RVA: 0x0000ADEB File Offset: 0x00008FEB
	public DateTime DateCreated
	{
		[CompilerGenerated]
		get
		{
			return this.dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			this.dateTime_0 = value;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0000ADF4 File Offset: 0x00008FF4
	// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0000ADFC File Offset: 0x00008FFC
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

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0000AE05 File Offset: 0x00009005
	// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0000AE0D File Offset: 0x0000900D
	public string Creator
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0000AE16 File Offset: 0x00009016
	// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x0000AE1E File Offset: 0x0000901E
	public List<Class322> Contents
	{
		[CompilerGenerated]
		get
		{
			return this.list_0;
		}
		[CompilerGenerated]
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0000AE27 File Offset: 0x00009027
	// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x0000AE2F File Offset: 0x0000902F
	public List<Class465> Buttons
	{
		[CompilerGenerated]
		get
		{
			return this.list_1;
		}
		[CompilerGenerated]
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x04000977 RID: 2423
	private DateTime dateTime_0;

	// Token: 0x04000978 RID: 2424
	private string string_0 = string.Empty;

	// Token: 0x04000979 RID: 2425
	private string string_1 = string.Empty;

	// Token: 0x0400097A RID: 2426
	private List<Class322> list_0;

	// Token: 0x0400097B RID: 2427
	private List<Class465> list_1;
}
