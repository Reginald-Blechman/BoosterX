using System;
using System.IO;
using Newtonsoft.Json;

// Token: 0x020001CB RID: 459
public class GClass46
{
	// Token: 0x06000CBB RID: 3259 RVA: 0x00009BAB File Offset: 0x00007DAB
	public T method_0<T>(string string_0)
	{
		return JsonConvert.DeserializeObject<T>(File.ReadAllText(string_0));
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x0004CB98 File Offset: 0x0004AD98
	public void method_1<T>(string string_0, T gparam_0)
	{
		string contents = JsonConvert.SerializeObject(gparam_0, 1);
		File.WriteAllText(string_0, contents);
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00009BB8 File Offset: 0x00007DB8
	public T method_2<T>(string string_0)
	{
		return JsonConvert.DeserializeObject<T>(GClass76.smethod_0(string_0));
	}
}
