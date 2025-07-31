using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

// Token: 0x020003C8 RID: 968
[JsonObject]
public sealed class GClass130
{
	// Token: 0x06001976 RID: 6518 RVA: 0x00070260 File Offset: 0x0006E460
	public void method_0(string string_0)
	{
		byte[] bytes = GClass240.smethod_0<GClass130>(this, Encoding.UTF8);
		File.WriteAllBytes(string_0, bytes);
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x00011498 File Offset: 0x0000F698
	public static GClass130 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<GClass130>(string_0);
	}

	// Token: 0x040010CC RID: 4300
	[JsonProperty("Settings")]
	public List<GClass254> list_0 = new List<GClass254>();
}
