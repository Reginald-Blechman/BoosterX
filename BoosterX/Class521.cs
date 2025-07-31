using System;
using System.Runtime.CompilerServices;
using System.Windows.Media;

// Token: 0x020004FC RID: 1276
internal sealed class Class521 : GClass162
{
	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x06002054 RID: 8276 RVA: 0x00015626 File Offset: 0x00013826
	// (set) Token: 0x06002055 RID: 8277 RVA: 0x0001562E File Offset: 0x0001382E
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

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x06002056 RID: 8278 RVA: 0x00015637 File Offset: 0x00013837
	public string Question
	{
		get
		{
			return Class298.smethod_2(this.Name);
		}
	}

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x06002057 RID: 8279 RVA: 0x00015644 File Offset: 0x00013844
	public string Description
	{
		get
		{
			return Class298.smethod_2(this.Name + "Desc");
		}
	}

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x06002058 RID: 8280 RVA: 0x0001565C File Offset: 0x0001385C
	public string Nuance
	{
		get
		{
			return Class298.smethod_2(this.Name + "Nuances");
		}
	}

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x06002059 RID: 8281 RVA: 0x00015674 File Offset: 0x00013874
	// (set) Token: 0x0600205A RID: 8282 RVA: 0x0001567C File Offset: 0x0001387C
	public string Image
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
			base.method_0("Image");
		}
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x0600205B RID: 8283 RVA: 0x00015691 File Offset: 0x00013891
	// (set) Token: 0x0600205C RID: 8284 RVA: 0x00015699 File Offset: 0x00013899
	public bool IsChecked
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
			base.method_0("IsChecked");
		}
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x0600205D RID: 8285 RVA: 0x000156AE File Offset: 0x000138AE
	// (set) Token: 0x0600205E RID: 8286 RVA: 0x000156BB File Offset: 0x000138BB
	public string MainButton
	{
		get
		{
			return Class298.smethod_2(this.string_2);
		}
		set
		{
			this.string_2 = value;
			base.method_0("MainButton");
		}
	}

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x0600205F RID: 8287 RVA: 0x000156D0 File Offset: 0x000138D0
	// (set) Token: 0x06002060 RID: 8288 RVA: 0x000156DD File Offset: 0x000138DD
	public string RedButton
	{
		get
		{
			return Class298.smethod_2(this.string_3);
		}
		set
		{
			this.string_3 = value;
			base.method_0("RedButton");
		}
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x06002061 RID: 8289 RVA: 0x000156F2 File Offset: 0x000138F2
	// (set) Token: 0x06002062 RID: 8290 RVA: 0x000156FA File Offset: 0x000138FA
	public Color Grad1
	{
		[CompilerGenerated]
		get
		{
			return this.color_0;
		}
		[CompilerGenerated]
		set
		{
			this.color_0 = value;
		}
	}

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x06002063 RID: 8291 RVA: 0x00015703 File Offset: 0x00013903
	// (set) Token: 0x06002064 RID: 8292 RVA: 0x0001570B File Offset: 0x0001390B
	public Color Grad2
	{
		[CompilerGenerated]
		get
		{
			return this.color_1;
		}
		[CompilerGenerated]
		set
		{
			this.color_1 = value;
		}
	}

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x06002065 RID: 8293 RVA: 0x00015714 File Offset: 0x00013914
	// (set) Token: 0x06002066 RID: 8294 RVA: 0x0001571C File Offset: 0x0001391C
	public Color Grad3
	{
		[CompilerGenerated]
		get
		{
			return this.color_2;
		}
		[CompilerGenerated]
		set
		{
			this.color_2 = value;
		}
	}

	// Token: 0x04001579 RID: 5497
	private string string_0;

	// Token: 0x0400157A RID: 5498
	private string string_1;

	// Token: 0x0400157B RID: 5499
	private bool bool_0;

	// Token: 0x0400157C RID: 5500
	private string string_2;

	// Token: 0x0400157D RID: 5501
	private string string_3;

	// Token: 0x0400157E RID: 5502
	private Color color_0;

	// Token: 0x0400157F RID: 5503
	private Color color_1;

	// Token: 0x04001580 RID: 5504
	private Color color_2;
}
