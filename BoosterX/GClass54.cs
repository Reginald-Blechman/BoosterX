using System;

// Token: 0x020001F3 RID: 499
public sealed class GClass54 : IEquatable<GClass54>
{
	// Token: 0x06000DA4 RID: 3492 RVA: 0x0000A31C File Offset: 0x0000851C
	private GClass54(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x0000A35D File Offset: 0x0000855D
	public static GClass54 smethod_0(string string_1)
	{
		if (string_1 == "system")
		{
			return GClass54.smethod_1();
		}
		if (string_1 == "user")
		{
			return GClass54.smethod_2();
		}
		if (!(string_1 == "assistant"))
		{
			return null;
		}
		return GClass54.smethod_3();
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x0000A39C File Offset: 0x0000859C
	private string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x0000A3A4 File Offset: 0x000085A4
	public static GClass54 smethod_1()
	{
		return GClass54.gclass54_0;
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x0000A3AB File Offset: 0x000085AB
	public static GClass54 smethod_2()
	{
		return GClass54.gclass54_1;
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0000A3B2 File Offset: 0x000085B2
	public static GClass54 smethod_3()
	{
		return GClass54.gclass54_2;
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x0000A3B9 File Offset: 0x000085B9
	public override string ToString()
	{
		return this.method_0();
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x0000A3C1 File Offset: 0x000085C1
	public override bool Equals(object obj)
	{
		return this.method_0().Equals((obj as GClass54).method_0());
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x0000A3D9 File Offset: 0x000085D9
	public override int GetHashCode()
	{
		return this.method_0().GetHashCode();
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x0000A3E6 File Offset: 0x000085E6
	public bool Equals(GClass54 other)
	{
		return this.method_0().Equals(other.method_0());
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x0000A3F9 File Offset: 0x000085F9
	public static implicit operator string(GClass54 gclass54_3)
	{
		return gclass54_3.method_0();
	}

	// Token: 0x040008B5 RID: 2229
	private readonly string string_0;

	// Token: 0x040008B6 RID: 2230
	private static readonly GClass54 gclass54_0 = new GClass54("system");

	// Token: 0x040008B7 RID: 2231
	private static readonly GClass54 gclass54_1 = new GClass54("user");

	// Token: 0x040008B8 RID: 2232
	private static readonly GClass54 gclass54_2 = new GClass54("assistant");
}
