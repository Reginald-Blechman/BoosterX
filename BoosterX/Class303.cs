using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

// Token: 0x0200028C RID: 652
internal sealed class Class303
{
	// Token: 0x17000264 RID: 612
	// (get) Token: 0x0600116E RID: 4462 RVA: 0x0000CB5A File Offset: 0x0000AD5A
	// (set) Token: 0x0600116F RID: 4463 RVA: 0x0000CB62 File Offset: 0x0000AD62
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

	// Token: 0x06001170 RID: 4464 RVA: 0x0000CB6B File Offset: 0x0000AD6B
	public string method_0()
	{
		return this.string_1;
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x0000CB73 File Offset: 0x0000AD73
	public void method_1(string string_2)
	{
		this.string_1 = string_2;
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x06001172 RID: 4466 RVA: 0x0000CB7C File Offset: 0x0000AD7C
	// (set) Token: 0x06001173 RID: 4467 RVA: 0x0000CB84 File Offset: 0x0000AD84
	public List<string> Services
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

	// Token: 0x06001174 RID: 4468 RVA: 0x0000CB8D File Offset: 0x0000AD8D
	public ObservableCollection<GClass184> method_2()
	{
		return this.observableCollection_0;
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x0000CB95 File Offset: 0x0000AD95
	public void method_3(ObservableCollection<GClass184> observableCollection_1)
	{
		this.observableCollection_0 = observableCollection_1;
	}

	// Token: 0x04000AD7 RID: 2775
	private string string_0;

	// Token: 0x04000AD8 RID: 2776
	private string string_1;

	// Token: 0x04000AD9 RID: 2777
	private List<string> list_0;

	// Token: 0x04000ADA RID: 2778
	private ObservableCollection<GClass184> observableCollection_0;
}
