using System;
using System.Runtime.CompilerServices;

// Token: 0x02000616 RID: 1558
internal sealed class Class748
{
	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x060027AC RID: 10156 RVA: 0x0001A54A File Offset: 0x0001874A
	// (set) Token: 0x060027AD RID: 10157 RVA: 0x0001A552 File Offset: 0x00018752
	public TimeSpan KeyExpiry
	{
		[CompilerGenerated]
		get
		{
			return this.timeSpan_0;
		}
		[CompilerGenerated]
		set
		{
			this.timeSpan_0 = value;
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x060027AE RID: 10158 RVA: 0x0001A55B File Offset: 0x0001875B
	// (set) Token: 0x060027AF RID: 10159 RVA: 0x0001A563 File Offset: 0x00018763
	public int NextUnhwidDaysCount
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			this.int_0 = value;
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x060027B0 RID: 10160 RVA: 0x0001A56C File Offset: 0x0001876C
	// (set) Token: 0x060027B1 RID: 10161 RVA: 0x0001A574 File Offset: 0x00018774
	public bool IsAvailable
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x04001A19 RID: 6681
	private TimeSpan timeSpan_0;

	// Token: 0x04001A1A RID: 6682
	private int int_0;

	// Token: 0x04001A1B RID: 6683
	private bool bool_0;
}
