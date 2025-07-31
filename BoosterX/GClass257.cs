using System;
using System.IO;
using System.Xml.Serialization;

// Token: 0x020005D7 RID: 1495
public sealed class GClass257
{
	// Token: 0x06002671 RID: 9841 RVA: 0x0009303C File Offset: 0x0009123C
	internal static dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd smethod_0(string string_0)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd));
		StringReader stringReader = new StringReader(string_0);
		dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd result;
		try
		{
			result = (dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd)xmlSerializer.Deserialize(stringReader);
		}
		finally
		{
			((IDisposable)stringReader).Dispose();
		}
		return result;
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x00093088 File Offset: 0x00091288
	internal static string smethod_1(dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd));
		StringWriter stringWriter = new StringWriter();
		string result;
		try
		{
			xmlSerializer.Serialize(stringWriter, dje_z4RT2DP2BX7MBBHD5ZCZSTEZLM4M6MXN5VTGTMM8DFUFGVGZ_ejd_0);
			result = stringWriter.ToString();
		}
		finally
		{
			((IDisposable)stringWriter).Dispose();
		}
		return result;
	}
}
