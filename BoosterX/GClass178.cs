using System;

// Token: 0x020002EA RID: 746
public sealed class GClass178 : GClass162
{
	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x06001390 RID: 5008 RVA: 0x0000DD3A File Offset: 0x0000BF3A
	// (set) Token: 0x06001391 RID: 5009 RVA: 0x0000DD42 File Offset: 0x0000BF42
	public string OptCurrent
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("OptCurrent");
		}
	}

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x06001392 RID: 5010 RVA: 0x0000DD57 File Offset: 0x0000BF57
	// (set) Token: 0x06001393 RID: 5011 RVA: 0x0000DD5F File Offset: 0x0000BF5F
	public bool IsFinished
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsFinished");
		}
	}

	// Token: 0x04000C42 RID: 3138
	private string string_0;

	// Token: 0x04000C43 RID: 3139
	private bool bool_0;
}
