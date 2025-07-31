using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x020002B5 RID: 693
internal sealed class Class326
{
	// Token: 0x1700029A RID: 666
	// (get) Token: 0x06001258 RID: 4696 RVA: 0x0000D247 File Offset: 0x0000B447
	// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000D24F File Offset: 0x0000B44F
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

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x0600125A RID: 4698 RVA: 0x0000D258 File Offset: 0x0000B458
	// (set) Token: 0x0600125B RID: 4699 RVA: 0x0000D260 File Offset: 0x0000B460
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

	// Token: 0x04000B85 RID: 2949
	private string string_0;

	// Token: 0x04000B86 RID: 2950
	private Dictionary<string, string> dictionary_0;
}
