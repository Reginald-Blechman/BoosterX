using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

// Token: 0x020002F7 RID: 759
public sealed class GClass99
{
	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x060013CA RID: 5066 RVA: 0x0000DF1E File Offset: 0x0000C11E
	// (set) Token: 0x060013CB RID: 5067 RVA: 0x0000DF26 File Offset: 0x0000C126
	public string Type
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

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x060013CC RID: 5068 RVA: 0x0000DF2F File Offset: 0x0000C12F
	// (set) Token: 0x060013CD RID: 5069 RVA: 0x0000DF37 File Offset: 0x0000C137
	public JsonElement Function
	{
		[CompilerGenerated]
		get
		{
			return this.jsonElement_0;
		}
		[CompilerGenerated]
		set
		{
			this.jsonElement_0 = value;
		}
	}

	// Token: 0x04000D42 RID: 3394
	private string string_0 = "function";

	// Token: 0x04000D43 RID: 3395
	private JsonElement jsonElement_0;
}
