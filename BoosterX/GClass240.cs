using System;
using System.Text;
using Newtonsoft.Json;

// Token: 0x0200055D RID: 1373
public sealed class GClass240
{
	// Token: 0x06002270 RID: 8816 RVA: 0x000897E0 File Offset: 0x000879E0
	public static byte[] smethod_0<T>(T gparam_0, Encoding encoding_0)
	{
		string s = JsonConvert.SerializeObject(gparam_0, 0);
		return encoding_0.GetBytes(s).smethod_0();
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x00089808 File Offset: 0x00087A08
	public static T smethod_1<T>(byte[] byte_0, Encoding encoding_0)
	{
		byte[] bytes = byte_0.smethod_1();
		return JsonConvert.DeserializeObject<T>(encoding_0.GetString(bytes));
	}
}
