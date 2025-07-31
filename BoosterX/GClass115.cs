using System;
using Newtonsoft.Json;

// Token: 0x0200034E RID: 846
public sealed class GClass115
{
	// Token: 0x060015FA RID: 5626 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
	internal GClass115(string string_1)
	{
		this.method_1(string_1);
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x0000F1BF File Offset: 0x0000D3BF
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x0000F1C7 File Offset: 0x0000D3C7
	private void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
	public static GClass115 smethod_0()
	{
		return new GClass115("256x256");
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x0000F1DD File Offset: 0x0000D3DD
	public static GClass115 smethod_1()
	{
		return new GClass115("512x512");
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x0000F1EA File Offset: 0x0000D3EA
	public static GClass115 smethod_2()
	{
		return new GClass115("1024x1024");
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x0000F1F7 File Offset: 0x0000D3F7
	public static GClass115 smethod_3()
	{
		return new GClass115("1024x1792");
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x0000F204 File Offset: 0x0000D404
	public static GClass115 smethod_4()
	{
		return new GClass115("1792x1024");
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x0000F211 File Offset: 0x0000D411
	public override string ToString()
	{
		return this.method_0();
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x00065E08 File Offset: 0x00064008
	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is GClass115)
		{
			return this.method_0().Equals(((GClass115)obj).method_0());
		}
		return obj is string && this.method_0().Equals((string)obj);
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x0000F219 File Offset: 0x0000D419
	public override int GetHashCode()
	{
		return this.method_0().GetHashCode();
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x0000F226 File Offset: 0x0000D426
	public static bool operator ==(GClass115 gclass115_0, GClass115 gclass115_1)
	{
		return gclass115_0.Equals(gclass115_1);
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x0000F22F File Offset: 0x0000D42F
	public static bool operator !=(GClass115 gclass115_0, GClass115 gclass115_1)
	{
		return !gclass115_0.Equals(gclass115_1);
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x0000F23B File Offset: 0x0000D43B
	public static implicit operator string(GClass115 gclass115_0)
	{
		return gclass115_0;
	}

	// Token: 0x04000E8C RID: 3724
	private string string_0;

	// Token: 0x0200034F RID: 847
	internal sealed class Class401 : JsonConverter<GClass115>
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x0000622D File Offset: 0x0000442D
		public override void WriteJson(JsonWriter jsonWriter_0, GClass115 gclass115_0, JsonSerializer jsonSerializer_0)
		{
			jsonWriter_0.WriteValue(gclass115_0.ToString());
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0000F24B File Offset: 0x0000D44B
		public override GClass115 ReadJson(JsonReader jsonReader_0, Type type_0, GClass115 gclass115_0, bool bool_0, JsonSerializer jsonSerializer_0)
		{
			return new GClass115(jsonReader_0.ReadAsString());
		}
	}
}
