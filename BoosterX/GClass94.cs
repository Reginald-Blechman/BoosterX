using System;
using Newtonsoft.Json;

// Token: 0x020002DA RID: 730
public static class GClass94
{
	// Token: 0x06001357 RID: 4951 RVA: 0x0000DB57 File Offset: 0x0000BD57
	public static string smethod_0(this GClass16 gclass16_0)
	{
		return JsonConvert.SerializeObject(gclass16_0, Class273.jsonSerializerSettings_0);
	}
}
