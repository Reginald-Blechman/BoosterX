using System;
using Newtonsoft.Json;

// Token: 0x02000392 RID: 914
public sealed class GClass125
{
	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x060017BA RID: 6074 RVA: 0x000103BA File Offset: 0x0000E5BA
	// (set) Token: 0x060017BB RID: 6075 RVA: 0x000103C2 File Offset: 0x0000E5C2
	[JsonProperty("PassedValidation")]
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

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x060017BC RID: 6076 RVA: 0x000103CB File Offset: 0x0000E5CB
	// (set) Token: 0x060017BD RID: 6077 RVA: 0x000103D3 File Offset: 0x0000E5D3
	[JsonProperty("RevisionId")]
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

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x060017BE RID: 6078 RVA: 0x000103DC File Offset: 0x0000E5DC
	// (set) Token: 0x060017BF RID: 6079 RVA: 0x000103E4 File Offset: 0x0000E5E4
	[JsonProperty("ValidationResultUri")]
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

	// Token: 0x04000FB6 RID: 4022
	private bool bool_0;

	// Token: 0x04000FB7 RID: 4023
	private string string_0;

	// Token: 0x04000FB8 RID: 4024
	private string string_1;
}
