using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// Token: 0x0200024D RID: 589
internal static class Class273
{
	// Token: 0x04000A24 RID: 2596
	public static readonly JsonSerializerSettings jsonSerializerSettings_0 = new JsonSerializerSettings
	{
		MetadataPropertyHandling = 2,
		DateParseHandling = 0,
		Converters = 
		{
			new IsoDateTimeConverter
			{
				DateTimeStyles = DateTimeStyles.AssumeUniversal
			}
		}
	};
}
