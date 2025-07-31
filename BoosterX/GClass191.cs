using System;
using System.Collections.ObjectModel;

// Token: 0x02000595 RID: 1429
public sealed class GClass191 : GClass162
{
	// Token: 0x17000600 RID: 1536
	// (get) Token: 0x060023FD RID: 9213 RVA: 0x0001799E File Offset: 0x00015B9E
	// (set) Token: 0x060023FE RID: 9214 RVA: 0x000179A6 File Offset: 0x00015BA6
	public bool ShowDisplayName
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (value == this.bool_0)
			{
				return;
			}
			this.bool_0 = value;
			base.method_0("ShowDisplayName");
		}
	}

	// Token: 0x17000601 RID: 1537
	// (get) Token: 0x060023FF RID: 9215 RVA: 0x000179C5 File Offset: 0x00015BC5
	// (set) Token: 0x06002400 RID: 9216 RVA: 0x000179CD File Offset: 0x00015BCD
	public ObservableCollection<GClass184> SingleServiceInfoViews
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			if (object.Equals(value, this.observableCollection_0))
			{
				return;
			}
			this.observableCollection_0 = value;
			base.method_0("SingleServiceInfoViews");
		}
	}

	// Token: 0x040017B5 RID: 6069
	private bool bool_0;

	// Token: 0x040017B6 RID: 6070
	private ObservableCollection<GClass184> observableCollection_0 = new ObservableCollection<GClass184>();
}
