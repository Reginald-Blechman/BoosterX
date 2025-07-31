using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Token: 0x020005C3 RID: 1475
internal sealed class Class707
{
	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x060025BB RID: 9659 RVA: 0x000191F4 File Offset: 0x000173F4
	// (set) Token: 0x060025BC RID: 9660 RVA: 0x000191FC File Offset: 0x000173FC
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

	// Token: 0x060025BD RID: 9661 RVA: 0x00019205 File Offset: 0x00017405
	public Action method_0()
	{
		return this.action_0;
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x0001920D File Offset: 0x0001740D
	public void method_1(Action action_1)
	{
		this.action_0 = action_1;
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x00019216 File Offset: 0x00017416
	public Task<bool> method_2()
	{
		return this.task_0;
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x0001921E File Offset: 0x0001741E
	public void method_3(Task<bool> task_1)
	{
		this.task_0 = task_1;
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x00019227 File Offset: 0x00017427
	public bool method_4()
	{
		return this.bool_0;
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x0001922F File Offset: 0x0001742F
	public void method_5(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	// Token: 0x040018D5 RID: 6357
	private string string_0;

	// Token: 0x040018D6 RID: 6358
	private Action action_0;

	// Token: 0x040018D7 RID: 6359
	private Task<bool> task_0;

	// Token: 0x040018D8 RID: 6360
	private bool bool_0;
}
