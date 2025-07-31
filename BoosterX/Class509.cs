using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

// Token: 0x02000348 RID: 840
internal sealed class Class509 : GClass162
{
	// Token: 0x060015D3 RID: 5587 RVA: 0x00065C18 File Offset: 0x00063E18
	public Class509()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_1_CollectionChanged;
		this.observableCollection_1.CollectionChanged += this.observableCollection_1_CollectionChanged;
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
	private void observableCollection_1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("UpdateCollectionProperty");
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x0000EFCE File Offset: 0x0000D1CE
	internal void method_2()
	{
		this.WinUwpAppsModels.Clear();
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0000EFDB File Offset: 0x0000D1DB
	// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0000EFE3 File Offset: 0x0000D1E3
	public ObservableCollection<Class525> WinUwpAppsModels
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("WinUwpAppsModels");
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
	// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0000F000 File Offset: 0x0000D200
	public ObservableCollection<Class512> CustomDebloatList
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("CustomDebloatList");
		}
	}

	// Token: 0x04000E79 RID: 3705
	private ObservableCollection<Class525> observableCollection_0 = new ObservableCollection<Class525>();

	// Token: 0x04000E7A RID: 3706
	private ObservableCollection<Class512> observableCollection_1 = new ObservableCollection<Class512>();
}
