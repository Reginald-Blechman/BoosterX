using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

// Token: 0x020004C3 RID: 1219
public sealed class GClass188 : GClass162
{
	// Token: 0x06001F29 RID: 7977 RVA: 0x00014A22 File Offset: 0x00012C22
	public GClass188()
	{
		this.observableCollection_0.CollectionChanged += this.observableCollection_0_CollectionChanged;
	}

	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x06001F2A RID: 7978 RVA: 0x00014A53 File Offset: 0x00012C53
	// (set) Token: 0x06001F2B RID: 7979 RVA: 0x00014A5B File Offset: 0x00012C5B
	public string Name
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
			base.method_0("Name");
		}
	}

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x06001F2C RID: 7980 RVA: 0x00014A70 File Offset: 0x00012C70
	public BitmapSource Icon
	{
		get
		{
			return GClass275.smethod_0(this.observableCollection_0.First<GClass186>().ClassGuid);
		}
	}

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06001F2D RID: 7981 RVA: 0x00014A87 File Offset: 0x00012C87
	// (set) Token: 0x06001F2E RID: 7982 RVA: 0x00014A8F File Offset: 0x00012C8F
	public string Description
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("Description");
		}
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x00014AA4 File Offset: 0x00012CA4
	private void observableCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		base.method_0("Devices");
	}

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00014AB2 File Offset: 0x00012CB2
	// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0007F5A4 File Offset: 0x0007D7A4
	public ObservableCollection<GClass186> Devices
	{
		get
		{
			return this.observableCollection_0;
		}
		set
		{
			this.observableCollection_0 = value;
			if (this.observableCollection_0.All(new Func<GClass186, bool>(GClass188.Class579.class579_0.method_0)))
			{
				this.IsDisabled = new bool?(true);
			}
			else if (this.observableCollection_0.All(new Func<GClass186, bool>(GClass188.Class579.class579_0.method_1)))
			{
				this.IsDisabled = new bool?(false);
			}
			else
			{
				this.IsDisabled = null;
			}
			base.method_0("Devices");
		}
	}

	// Token: 0x17000542 RID: 1346
	// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00014ABA File Offset: 0x00012CBA
	// (set) Token: 0x06001F33 RID: 7987 RVA: 0x00014AC2 File Offset: 0x00012CC2
	public bool? CurrentIsDisabled
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			this.nullable_0 = value;
		}
	}

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00014ACB File Offset: 0x00012CCB
	// (set) Token: 0x06001F35 RID: 7989 RVA: 0x00014AD3 File Offset: 0x00012CD3
	public bool? IsDisabled
	{
		get
		{
			return this.nullable_1;
		}
		set
		{
			if (this.bool_0)
			{
				this.CurrentIsDisabled = value;
				this.bool_0 = false;
			}
			this.nullable_1 = value;
			this.method_2();
			base.method_0("IsDisabled");
			base.method_0("HasChanges");
		}
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x0007F648 File Offset: 0x0007D848
	private void method_2()
	{
		if (this.IsDisabled.GetValueOrDefault())
		{
			foreach (GClass186 gclass in this.observableCollection_0)
			{
				gclass.IsEnabled = false;
			}
		}
		bool? isDisabled = this.IsDisabled;
		if (!isDisabled.GetValueOrDefault() & isDisabled != null)
		{
			foreach (GClass186 gclass2 in this.observableCollection_0)
			{
				gclass2.IsEnabled = true;
			}
		}
	}

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00014B10 File Offset: 0x00012D10
	public bool HasChanges
	{
		get
		{
			return this.observableCollection_0.Any(new Func<GClass186, bool>(GClass188.Class579.class579_0.method_2));
		}
	}

	// Token: 0x040014BB RID: 5307
	private string string_0;

	// Token: 0x040014BC RID: 5308
	private string string_1;

	// Token: 0x040014BD RID: 5309
	private ObservableCollection<GClass186> observableCollection_0 = new ObservableCollection<GClass186>();

	// Token: 0x040014BE RID: 5310
	private bool bool_0 = true;

	// Token: 0x040014BF RID: 5311
	private bool? nullable_0;

	// Token: 0x040014C0 RID: 5312
	private bool? nullable_1;

	// Token: 0x020004C4 RID: 1220
	[Serializable]
	private sealed class Class579
	{
		// Token: 0x06001F3A RID: 7994 RVA: 0x00014B48 File Offset: 0x00012D48
		internal bool method_0(GClass186 gclass186_0)
		{
			return !gclass186_0.IsEnabled;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00014B53 File Offset: 0x00012D53
		internal bool method_1(GClass186 gclass186_0)
		{
			return gclass186_0.IsEnabled;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00014B5B File Offset: 0x00012D5B
		internal bool method_2(GClass186 gclass186_0)
		{
			return gclass186_0.HasChangesEnabled;
		}

		// Token: 0x040014C1 RID: 5313
		public static readonly GClass188.Class579 class579_0 = new GClass188.Class579();

		// Token: 0x040014C2 RID: 5314
		public static Func<GClass186, bool> func_0;

		// Token: 0x040014C3 RID: 5315
		public static Func<GClass186, bool> func_1;

		// Token: 0x040014C4 RID: 5316
		public static Func<GClass186, bool> func_2;
	}
}
