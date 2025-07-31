using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000613 RID: 1555
internal sealed class Class745
{
	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x06002786 RID: 10118 RVA: 0x0001A38F File Offset: 0x0001858F
	// (set) Token: 0x06002787 RID: 10119 RVA: 0x0001A397 File Offset: 0x00018597
	[JsonProperty("Command")]
	public string Command
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

	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x06002788 RID: 10120 RVA: 0x0001A3A0 File Offset: 0x000185A0
	// (set) Token: 0x06002789 RID: 10121 RVA: 0x0001A3A8 File Offset: 0x000185A8
	[JsonProperty("DefaultValue")]
	public string DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			this.string_1 = value;
		}
	}

	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x0600278A RID: 10122 RVA: 0x0001A3B1 File Offset: 0x000185B1
	// (set) Token: 0x0600278B RID: 10123 RVA: 0x0001A3B9 File Offset: 0x000185B9
	[JsonProperty("IsCheat")]
	public bool IsCheat
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			this.bool_0 = value;
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x0600278C RID: 10124 RVA: 0x0001A3C2 File Offset: 0x000185C2
	// (set) Token: 0x0600278D RID: 10125 RVA: 0x0001A3CA File Offset: 0x000185CA
	[JsonProperty("IsClient")]
	public bool IsClient
	{
		[CompilerGenerated]
		get
		{
			return this.bool_1;
		}
		[CompilerGenerated]
		set
		{
			this.bool_1 = value;
		}
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x0600278E RID: 10126 RVA: 0x0001A3D3 File Offset: 0x000185D3
	// (set) Token: 0x0600278F RID: 10127 RVA: 0x0001A3DB File Offset: 0x000185DB
	[JsonProperty("IsServer")]
	public bool IsServer
	{
		[CompilerGenerated]
		get
		{
			return this.bool_2;
		}
		[CompilerGenerated]
		set
		{
			this.bool_2 = value;
		}
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x06002790 RID: 10128 RVA: 0x0001A3E4 File Offset: 0x000185E4
	// (set) Token: 0x06002791 RID: 10129 RVA: 0x0001A3EC File Offset: 0x000185EC
	[JsonProperty("Description")]
	public Dictionary<string, string> Description
	{
		[CompilerGenerated]
		get
		{
			return this.dictionary_0;
		}
		[CompilerGenerated]
		set
		{
			this.dictionary_0 = value;
		}
	}

	// Token: 0x04001A11 RID: 6673
	private string string_0;

	// Token: 0x04001A12 RID: 6674
	private string string_1;

	// Token: 0x04001A13 RID: 6675
	private bool bool_0;

	// Token: 0x04001A14 RID: 6676
	private bool bool_1;

	// Token: 0x04001A15 RID: 6677
	private bool bool_2;

	// Token: 0x04001A16 RID: 6678
	private Dictionary<string, string> dictionary_0;
}
