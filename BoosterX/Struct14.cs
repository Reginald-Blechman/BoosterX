using System;
using System.Threading;

// Token: 0x02000092 RID: 146
internal struct Struct14
{
	// Token: 0x0600049D RID: 1181 RVA: 0x000052FC File Offset: 0x000034FC
	public Struct14(string string_0)
	{
		this.nullable_0 = new int?(Class25.smethod_0(string_0));
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x0000530F File Offset: 0x0000350F
	public bool method_0()
	{
		return Class25.smethod_1(this.nullable_0);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x0000531C File Offset: 0x0000351C
	public void method_1(bool bool_0)
	{
		this.nullable_0 = new int?(Class25.smethod_4(bool_0));
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x0000532F File Offset: 0x0000352F
	public bool method_2()
	{
		bool result = Class25.smethod_1(this.nullable_0);
		Thread.MemoryBarrier();
		return result;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00005341 File Offset: 0x00003541
	public void method_3(bool bool_0)
	{
		Thread.MemoryBarrier();
		this.nullable_0 = new int?(Class25.smethod_4(bool_0));
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00005359 File Offset: 0x00003559
	public void method_4()
	{
		this.nullable_0 = new int?(Class25.smethod_4(false));
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00037018 File Offset: 0x00035218
	public int method_5()
	{
		return Class25.smethod_1(this.nullable_0).GetHashCode();
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00037038 File Offset: 0x00035238
	public bool method_6(bool bool_0)
	{
		return Class25.smethod_1(this.nullable_0).Equals(bool_0);
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x0003705C File Offset: 0x0003525C
	public bool method_7(object object_0)
	{
		return Class25.smethod_1(this.nullable_0).Equals(object_0);
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00037080 File Offset: 0x00035280
	public int method_8(bool bool_0)
	{
		return Class25.smethod_1(this.nullable_0).CompareTo(bool_0);
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x000370A4 File Offset: 0x000352A4
	public int method_9(object object_0)
	{
		return Class25.smethod_1(this.nullable_0).CompareTo(object_0);
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x000039A7 File Offset: 0x00001BA7
	public TypeCode method_10()
	{
		return TypeCode.Boolean;
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x000370C8 File Offset: 0x000352C8
	public string method_11()
	{
		return Class25.smethod_1(this.nullable_0).ToString();
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x000370E8 File Offset: 0x000352E8
	public string method_12(IFormatProvider iformatProvider_0)
	{
		return Class25.smethod_1(this.nullable_0).ToString(iformatProvider_0);
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0000536C File Offset: 0x0000356C
	public bool method_13()
	{
		return this.method_2();
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00005374 File Offset: 0x00003574
	public void method_14(bool bool_0)
	{
		this.method_3(bool_0);
	}

	// Token: 0x040002C4 RID: 708
	private int? nullable_0;
}
