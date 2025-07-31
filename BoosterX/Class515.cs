using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;

// Token: 0x0200049C RID: 1180
internal sealed class Class515 : GClass162
{
	// Token: 0x06001E97 RID: 7831 RVA: 0x0007D1B8 File Offset: 0x0007B3B8
	public Class515()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_2_CollectionChanged;
		this.observableCollection_1.CollectionChanged += this.observableCollection_2_CollectionChanged;
		this.observableCollection_2.CollectionChanged += this.observableCollection_2_CollectionChanged;
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x000142EF File Offset: 0x000124EF
	private void observableCollection_2_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("ColChanged");
		base.method_0("SettingsVisibility");
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06001E99 RID: 7833 RVA: 0x00014309 File Offset: 0x00012509
	// (set) Token: 0x06001E9A RID: 7834 RVA: 0x00014311 File Offset: 0x00012511
	public ObservableCollection<Class505> DeviceViewModels
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			base.method_0("DeviceViewModels");
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06001E9B RID: 7835 RVA: 0x00014326 File Offset: 0x00012526
	// (set) Token: 0x06001E9C RID: 7836 RVA: 0x0001432E File Offset: 0x0001252E
	public ObservableCollection<Class517> ChoosenDevThreads
	{
		get
		{
			return this.observableCollection_1;
		}
		set
		{
			this.observableCollection_1 = value;
			base.method_0("ChoosenDevThreads");
		}
	}

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x06001E9D RID: 7837 RVA: 0x00014343 File Offset: 0x00012543
	// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0001434B File Offset: 0x0001254B
	public ObservableCollection<Class512> JsonTweaks
	{
		get
		{
			return this.observableCollection_2;
		}
		set
		{
			this.observableCollection_2 = value;
			base.method_0("JsonTweaks");
		}
	}

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x06001E9F RID: 7839 RVA: 0x00014360 File Offset: 0x00012560
	public Visibility SettingsVisibility
	{
		get
		{
			if (this.observableCollection_2.Count<Class512>() <= 0)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	// Token: 0x04001436 RID: 5174
	private ObservableCollection<Class505> observableCollection_0 = new ObservableCollection<Class505>();

	// Token: 0x04001437 RID: 5175
	private ObservableCollection<Class517> observableCollection_1 = new ObservableCollection<Class517>();

	// Token: 0x04001438 RID: 5176
	private ObservableCollection<Class512> observableCollection_2 = new ObservableCollection<Class512>();
}
