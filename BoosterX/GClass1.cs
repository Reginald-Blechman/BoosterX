using System;
using Newtonsoft.Json;

// Token: 0x020000D5 RID: 213
public sealed class GClass1
{
	// Token: 0x06000698 RID: 1688 RVA: 0x000061CE File Offset: 0x000043CE
	private GClass1(string string_1)
	{
		this.method_1(string_1);
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x000061DD File Offset: 0x000043DD
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x000061E5 File Offset: 0x000043E5
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x000061EE File Offset: 0x000043EE
	public static GClass1 smethod_0()
	{
		return new GClass1("url");
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x000061FB File Offset: 0x000043FB
	public static GClass1 smethod_1()
	{
		return new GClass1("b64_json");
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00006208 File Offset: 0x00004408
	public override string ToString()
	{
		return this.method_0();
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00006210 File Offset: 0x00004410
	public static implicit operator string(GClass1 gclass1_0)
	{
		return gclass1_0;
	}

	// Token: 0x04000383 RID: 899
	private string string_0;

	// Token: 0x020000D6 RID: 214
	internal sealed class Class140 : JsonConverter<GClass1>
	{
		// Token: 0x060006A0 RID: 1696 RVA: 0x00006220 File Offset: 0x00004420
		public override GClass1 ReadJson(JsonReader jsonReader_0, Type type_0, GClass1 gclass1_0, bool bool_0, JsonSerializer jsonSerializer_0)
		{
			return new GClass1(jsonReader_0.ReadAsString());
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000622D File Offset: 0x0000442D
		public override void WriteJson(JsonWriter jsonWriter_0, GClass1 gclass1_0, JsonSerializer jsonSerializer_0)
		{
			jsonWriter_0.WriteValue(gclass1_0.ToString());
		}
	}
}
