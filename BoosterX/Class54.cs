using System;

// Token: 0x02000080 RID: 128
internal abstract class Class54 : Interface4
{
	// Token: 0x06000433 RID: 1075
	public abstract string imethod_0();

	// Token: 0x06000434 RID: 1076
	public abstract void imethod_1(bool bool_0, Interface2 interface2_0);

	// Token: 0x06000435 RID: 1077
	public abstract int imethod_2();

	// Token: 0x06000436 RID: 1078
	public abstract int imethod_3(int int_0);

	// Token: 0x06000437 RID: 1079
	public abstract int imethod_4(int int_0);

	// Token: 0x06000438 RID: 1080 RVA: 0x00004F44 File Offset: 0x00003144
	public virtual byte[] imethod_5(byte[] byte_1)
	{
		return this.imethod_6(byte_1, 0, byte_1.Length);
	}

	// Token: 0x06000439 RID: 1081
	public abstract byte[] imethod_6(byte[] byte_1, int int_0, int int_1);

	// Token: 0x0600043A RID: 1082 RVA: 0x00004F51 File Offset: 0x00003151
	public virtual int imethod_7(byte[] byte_1, byte[] byte_2, int int_0)
	{
		return this.imethod_8(byte_1, 0, byte_1.Length, byte_2, int_0);
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00035EE8 File Offset: 0x000340E8
	public virtual int imethod_8(byte[] byte_1, int int_0, int int_1, byte[] byte_2, int int_2)
	{
		byte[] array = this.imethod_6(byte_1, int_0, int_1);
		if (array == null)
		{
			return 0;
		}
		if (int_2 + array.Length > byte_2.Length)
		{
			throw new Exception1("output buffer too short");
		}
		array.CopyTo(byte_2, int_2);
		return array.Length;
	}

	// Token: 0x0600043C RID: 1084
	public abstract byte[] imethod_9();

	// Token: 0x0600043D RID: 1085 RVA: 0x00004F60 File Offset: 0x00003160
	public virtual byte[] imethod_10(byte[] byte_1)
	{
		return this.imethod_11(byte_1, 0, byte_1.Length);
	}

	// Token: 0x0600043E RID: 1086
	public abstract byte[] imethod_11(byte[] byte_1, int int_0, int int_1);

	// Token: 0x0600043F RID: 1087 RVA: 0x00035F2C File Offset: 0x0003412C
	public virtual int imethod_12(byte[] byte_1, int int_0)
	{
		byte[] array = this.imethod_9();
		if (int_0 + array.Length > byte_1.Length)
		{
			throw new Exception1("output buffer too short");
		}
		array.CopyTo(byte_1, int_0);
		return array.Length;
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00004F6D File Offset: 0x0000316D
	public virtual int imethod_13(byte[] byte_1, byte[] byte_2, int int_0)
	{
		return this.imethod_14(byte_1, 0, byte_1.Length, byte_2, int_0);
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00035F64 File Offset: 0x00034164
	public virtual int imethod_14(byte[] byte_1, int int_0, int int_1, byte[] byte_2, int int_2)
	{
		int num = this.imethod_8(byte_1, int_0, int_1, byte_2, int_2);
		return num + this.imethod_12(byte_2, int_2 + num);
	}

	// Token: 0x06000442 RID: 1090
	public abstract void imethod_15();

	// Token: 0x040002AD RID: 685
	protected static readonly byte[] byte_0 = new byte[0];
}
