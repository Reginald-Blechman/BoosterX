using System;
using Newtonsoft.Json;

// Token: 0x0200044C RID: 1100
public static class GClass159
{
	// Token: 0x06001C99 RID: 7321 RVA: 0x00012FA4 File Offset: 0x000111A4
	public static string smethod_0(this GClass42 gclass42_0)
	{
		return JsonConvert.SerializeObject(gclass42_0, GClass229.jsonSerializerSettings_0);
	}
}
