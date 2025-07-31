using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x0200031E RID: 798
public sealed class GClass105
{
	// Token: 0x170002FF RID: 767
	// (get) Token: 0x0600148A RID: 5258 RVA: 0x0000E507 File Offset: 0x0000C707
	// (set) Token: 0x0600148B RID: 5259 RVA: 0x0000E50F File Offset: 0x0000C70F
	[JsonProperty("Applications")]
	public List<GClass45> List_0
	{
		get
		{
			return this.list_0;
		}
		set
		{
			this.list_0 = value;
		}
	}

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x0600148C RID: 5260 RVA: 0x0000E518 File Offset: 0x0000C718
	// (set) Token: 0x0600148D RID: 5261 RVA: 0x0000E520 File Offset: 0x0000C720
	[JsonProperty("Architectures")]
	public List<string> List_1
	{
		get
		{
			return this.list_1;
		}
		set
		{
			this.list_1 = value;
		}
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x0600148E RID: 5262 RVA: 0x0000E529 File Offset: 0x0000C729
	// (set) Token: 0x0600148F RID: 5263 RVA: 0x0000E531 File Offset: 0x0000C731
	[JsonProperty("Capabilities")]
	public List<string> List_2
	{
		get
		{
			return this.list_2;
		}
		set
		{
			this.list_2 = value;
		}
	}

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x06001490 RID: 5264 RVA: 0x0000E53A File Offset: 0x0000C73A
	// (set) Token: 0x06001491 RID: 5265 RVA: 0x0000E542 File Offset: 0x0000C742
	[JsonProperty("DeviceCapabilities")]
	public List<object> List_3
	{
		get
		{
			return this.list_3;
		}
		set
		{
			this.list_3 = value;
		}
	}

	// Token: 0x17000303 RID: 771
	// (get) Token: 0x06001492 RID: 5266 RVA: 0x0000E54B File Offset: 0x0000C74B
	// (set) Token: 0x06001493 RID: 5267 RVA: 0x0000E553 File Offset: 0x0000C753
	[JsonProperty("ExperienceIds")]
	public List<object> List_4
	{
		get
		{
			return this.list_4;
		}
		set
		{
			this.list_4 = value;
		}
	}

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x06001494 RID: 5268 RVA: 0x0000E55C File Offset: 0x0000C75C
	// (set) Token: 0x06001495 RID: 5269 RVA: 0x0000E564 File Offset: 0x0000C764
	[JsonProperty("FrameworkDependencies")]
	public List<object> List_5
	{
		get
		{
			return this.list_5;
		}
		set
		{
			this.list_5 = value;
		}
	}

	// Token: 0x17000305 RID: 773
	// (get) Token: 0x06001496 RID: 5270 RVA: 0x0000E56D File Offset: 0x0000C76D
	// (set) Token: 0x06001497 RID: 5271 RVA: 0x0000E575 File Offset: 0x0000C775
	[JsonProperty("HardwareDependencies")]
	public List<object> List_6
	{
		get
		{
			return this.list_6;
		}
		set
		{
			this.list_6 = value;
		}
	}

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x06001498 RID: 5272 RVA: 0x0000E57E File Offset: 0x0000C77E
	// (set) Token: 0x06001499 RID: 5273 RVA: 0x0000E586 File Offset: 0x0000C786
	[JsonProperty("HardwareRequirements")]
	public List<object> List_7
	{
		get
		{
			return this.list_7;
		}
		set
		{
			this.list_7 = value;
		}
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x0600149A RID: 5274 RVA: 0x0000E58F File Offset: 0x0000C78F
	// (set) Token: 0x0600149B RID: 5275 RVA: 0x0000E597 File Offset: 0x0000C797
	[JsonProperty("Hash")]
	public string String_0
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x0600149C RID: 5276 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
	// (set) Token: 0x0600149D RID: 5277 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
	[JsonProperty("HashAlgorithm")]
	public string String_1
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x0600149E RID: 5278 RVA: 0x0000E5B1 File Offset: 0x0000C7B1
	// (set) Token: 0x0600149F RID: 5279 RVA: 0x0000E5B9 File Offset: 0x0000C7B9
	[JsonProperty("IsStreamingApp")]
	public bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0000E5C2 File Offset: 0x0000C7C2
	// (set) Token: 0x060014A1 RID: 5281 RVA: 0x0000E5CA File Offset: 0x0000C7CA
	[JsonProperty("Languages")]
	public List<string> List_8
	{
		get
		{
			return this.list_8;
		}
		set
		{
			this.list_8 = value;
		}
	}

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0000E5D3 File Offset: 0x0000C7D3
	// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0000E5DB File Offset: 0x0000C7DB
	[JsonProperty("MaxDownloadSizeInBytes")]
	public long Int64_0
	{
		get
		{
			return this.long_0;
		}
		set
		{
			this.long_0 = value;
		}
	}

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
	// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0000E5EC File Offset: 0x0000C7EC
	[JsonProperty("MaxInstallSizeInBytes")]
	public string String_2
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0000E5F5 File Offset: 0x0000C7F5
	// (set) Token: 0x060014A7 RID: 5287 RVA: 0x0000E5FD File Offset: 0x0000C7FD
	[JsonProperty("PackageFormat")]
	public string String_3
	{
		get
		{
			return this.string_3;
		}
		set
		{
			this.string_3 = value;
		}
	}

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0000E606 File Offset: 0x0000C806
	// (set) Token: 0x060014A9 RID: 5289 RVA: 0x0000E60E File Offset: 0x0000C80E
	[JsonProperty("PackageFamilyName")]
	public string String_4
	{
		get
		{
			return this.string_4;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x060014AA RID: 5290 RVA: 0x0000E617 File Offset: 0x0000C817
	// (set) Token: 0x060014AB RID: 5291 RVA: 0x0000E61F File Offset: 0x0000C81F
	[JsonProperty("MainPackageFamilyNameForDlc")]
	public object Object_0
	{
		get
		{
			return this.object_0;
		}
		set
		{
			this.object_0 = value;
		}
	}

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x060014AC RID: 5292 RVA: 0x0000E628 File Offset: 0x0000C828
	// (set) Token: 0x060014AD RID: 5293 RVA: 0x0000E630 File Offset: 0x0000C830
	[JsonProperty("PackageFullName")]
	public string String_5
	{
		get
		{
			return this.string_5;
		}
		set
		{
			this.string_5 = value;
		}
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x060014AE RID: 5294 RVA: 0x0000E639 File Offset: 0x0000C839
	// (set) Token: 0x060014AF RID: 5295 RVA: 0x0000E641 File Offset: 0x0000C841
	[JsonProperty("PackageId")]
	public string String_6
	{
		get
		{
			return this.string_6;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0000E64A File Offset: 0x0000C84A
	// (set) Token: 0x060014B1 RID: 5297 RVA: 0x0000E652 File Offset: 0x0000C852
	[JsonProperty("ContentId")]
	public string String_7
	{
		get
		{
			return this.string_7;
		}
		set
		{
			this.string_7 = value;
		}
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0000E65B File Offset: 0x0000C85B
	// (set) Token: 0x060014B3 RID: 5299 RVA: 0x0000E663 File Offset: 0x0000C863
	[JsonProperty("KeyId")]
	public string String_8
	{
		get
		{
			return this.string_8;
		}
		set
		{
			this.string_8 = value;
		}
	}

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0000E66C File Offset: 0x0000C86C
	// (set) Token: 0x060014B5 RID: 5301 RVA: 0x0000E674 File Offset: 0x0000C874
	[JsonProperty("PackageRank")]
	public long Int64_1
	{
		get
		{
			return this.long_1;
		}
		set
		{
			this.long_1 = value;
		}
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0000E67D File Offset: 0x0000C87D
	// (set) Token: 0x060014B7 RID: 5303 RVA: 0x0000E685 File Offset: 0x0000C885
	[JsonProperty("PackageUri")]
	public string String_9
	{
		get
		{
			return this.string_9;
		}
		set
		{
			this.string_9 = value;
		}
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0000E68E File Offset: 0x0000C88E
	// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0000E696 File Offset: 0x0000C896
	[JsonProperty("PlatformDependencies")]
	public List<GClass17> List_9
	{
		get
		{
			return this.list_9;
		}
		set
		{
			this.list_9 = value;
		}
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x060014BA RID: 5306 RVA: 0x0000E69F File Offset: 0x0000C89F
	// (set) Token: 0x060014BB RID: 5307 RVA: 0x0000E6A7 File Offset: 0x0000C8A7
	[JsonProperty("PlatformDependencyXmlBlob")]
	public string String_10
	{
		get
		{
			return this.string_10;
		}
		set
		{
			this.string_10 = value;
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x060014BC RID: 5308 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
	// (set) Token: 0x060014BD RID: 5309 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
	[JsonProperty("ResourceId")]
	public string String_11
	{
		get
		{
			return this.string_11;
		}
		set
		{
			this.string_11 = value;
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x060014BE RID: 5310 RVA: 0x0000E6C1 File Offset: 0x0000C8C1
	// (set) Token: 0x060014BF RID: 5311 RVA: 0x0000E6C9 File Offset: 0x0000C8C9
	[JsonProperty("Version")]
	public string String_12
	{
		get
		{
			return this.string_12;
		}
		set
		{
			this.string_12 = value;
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0000E6D2 File Offset: 0x0000C8D2
	// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0000E6DA File Offset: 0x0000C8DA
	[JsonProperty("PackageDownloadUris")]
	public List<GClass93> List_10
	{
		get
		{
			return this.list_10;
		}
		set
		{
			this.list_10 = value;
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0000E6E3 File Offset: 0x0000C8E3
	// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0000E6EB File Offset: 0x0000C8EB
	[JsonProperty("DriverDependencies")]
	public List<object> List_11
	{
		get
		{
			return this.list_11;
		}
		set
		{
			this.list_11 = value;
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0000E6F4 File Offset: 0x0000C8F4
	// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0000E6FC File Offset: 0x0000C8FC
	[JsonProperty("FulfillmentData")]
	public GClass111 GClass111_0
	{
		get
		{
			return this.gclass111_0;
		}
		set
		{
			this.gclass111_0 = value;
		}
	}

	// Token: 0x04000DC4 RID: 3524
	private List<GClass45> list_0;

	// Token: 0x04000DC5 RID: 3525
	private List<string> list_1;

	// Token: 0x04000DC6 RID: 3526
	private List<string> list_2;

	// Token: 0x04000DC7 RID: 3527
	private List<object> list_3;

	// Token: 0x04000DC8 RID: 3528
	private List<object> list_4;

	// Token: 0x04000DC9 RID: 3529
	private List<object> list_5;

	// Token: 0x04000DCA RID: 3530
	private List<object> list_6;

	// Token: 0x04000DCB RID: 3531
	private List<object> list_7;

	// Token: 0x04000DCC RID: 3532
	private string string_0;

	// Token: 0x04000DCD RID: 3533
	private string string_1;

	// Token: 0x04000DCE RID: 3534
	private bool bool_0;

	// Token: 0x04000DCF RID: 3535
	private List<string> list_8;

	// Token: 0x04000DD0 RID: 3536
	private long long_0;

	// Token: 0x04000DD1 RID: 3537
	private string string_2;

	// Token: 0x04000DD2 RID: 3538
	private string string_3;

	// Token: 0x04000DD3 RID: 3539
	private string string_4;

	// Token: 0x04000DD4 RID: 3540
	private object object_0;

	// Token: 0x04000DD5 RID: 3541
	private string string_5;

	// Token: 0x04000DD6 RID: 3542
	private string string_6;

	// Token: 0x04000DD7 RID: 3543
	private string string_7;

	// Token: 0x04000DD8 RID: 3544
	private string string_8;

	// Token: 0x04000DD9 RID: 3545
	private long long_1;

	// Token: 0x04000DDA RID: 3546
	private string string_9;

	// Token: 0x04000DDB RID: 3547
	private List<GClass17> list_9;

	// Token: 0x04000DDC RID: 3548
	private string string_10;

	// Token: 0x04000DDD RID: 3549
	private string string_11;

	// Token: 0x04000DDE RID: 3550
	private string string_12;

	// Token: 0x04000DDF RID: 3551
	private List<GClass93> list_10;

	// Token: 0x04000DE0 RID: 3552
	private List<object> list_11;

	// Token: 0x04000DE1 RID: 3553
	private GClass111 gclass111_0;
}
