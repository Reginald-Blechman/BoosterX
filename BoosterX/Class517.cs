using System;

// Token: 0x020004C2 RID: 1218
internal sealed class Class517 : GClass162
{
	// Token: 0x06001F1E RID: 7966 RVA: 0x00014971 File Offset: 0x00012B71
	public Class517(Class505 class505_1 = null)
	{
		this.class505_0 = class505_1;
	}

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00014980 File Offset: 0x00012B80
	// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00014988 File Offset: 0x00012B88
	public int Core
	{
		get
		{
			return this.int_0;
		}
		set
		{
			this.int_0 = value;
			base.method_0("Core");
		}
	}

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x06001F21 RID: 7969 RVA: 0x0001499D File Offset: 0x00012B9D
	// (set) Token: 0x06001F22 RID: 7970 RVA: 0x000149A5 File Offset: 0x00012BA5
	public int Thread
	{
		get
		{
			return this.int_1;
		}
		set
		{
			this.int_1 = value;
			base.method_0("Thread");
		}
	}

	// Token: 0x1700053B RID: 1339
	// (get) Token: 0x06001F23 RID: 7971 RVA: 0x000149BA File Offset: 0x00012BBA
	// (set) Token: 0x06001F24 RID: 7972 RVA: 0x000149C2 File Offset: 0x00012BC2
	public bool IsECore
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsECore");
		}
	}

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x06001F25 RID: 7973 RVA: 0x000149D7 File Offset: 0x00012BD7
	// (set) Token: 0x06001F26 RID: 7974 RVA: 0x000149DF File Offset: 0x00012BDF
	public bool ShowCoreType
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			this.bool_1 = value;
			base.method_0("ShowCoreType");
		}
	}

	// Token: 0x1700053D RID: 1341
	// (get) Token: 0x06001F27 RID: 7975 RVA: 0x000149F4 File Offset: 0x00012BF4
	// (set) Token: 0x06001F28 RID: 7976 RVA: 0x000149FC File Offset: 0x00012BFC
	public bool IsChosen
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			this.bool_2 = value;
			Class505 @class = this.class505_0;
			if (@class != null)
			{
				@class.method_11();
			}
			base.method_0("IsChosen");
		}
	}

	// Token: 0x040014B5 RID: 5301
	private Class505 class505_0;

	// Token: 0x040014B6 RID: 5302
	public int int_0;

	// Token: 0x040014B7 RID: 5303
	public int int_1;

	// Token: 0x040014B8 RID: 5304
	public bool bool_0;

	// Token: 0x040014B9 RID: 5305
	public bool bool_1;

	// Token: 0x040014BA RID: 5306
	public bool bool_2;
}
