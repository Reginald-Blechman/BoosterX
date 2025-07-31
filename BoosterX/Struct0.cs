using System;

// Token: 0x02000004 RID: 4
internal struct Struct0
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002FE6 File Offset: 0x000011E6
	public Struct0(int int_1, byte byte_1)
	{
		this.method_1(int_1);
		this.byte_0 = byte_1;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002FF6 File Offset: 0x000011F6
	[Attribute2]
	public int method_0()
	{
		return this.int_0;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002FFE File Offset: 0x000011FE
	public void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003007 File Offset: 0x00001207
	[Attribute2]
	public byte method_2()
	{
		return this.byte_0;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00021AC4 File Offset: 0x0001FCC4
	public override bool Equals(object obj)
	{
		if (obj is Struct0)
		{
			Struct0 struct0_ = (Struct0)obj;
			return this.method_3(struct0_);
		}
		return false;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000300F File Offset: 0x0000120F
	public bool method_3(Struct0 struct0_0)
	{
		return struct0_0.method_0() == this.method_0();
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003020 File Offset: 0x00001220
	public static bool operator ==(Struct0 struct0_0, Struct0 struct0_1)
	{
		return struct0_0.method_3(struct0_1);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000302A File Offset: 0x0000122A
	public static bool operator !=(Struct0 struct0_0, Struct0 struct0_1)
	{
		return !(struct0_0 == struct0_1);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00021AEC File Offset: 0x0001FCEC
	public override int GetHashCode()
	{
		return this.method_0().GetHashCode();
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00021B08 File Offset: 0x0001FD08
	public override string ToString()
	{
		return this.method_0().ToString();
	}

	// Token: 0x04000007 RID: 7
	private int int_0;

	// Token: 0x04000008 RID: 8
	private readonly byte byte_0;
}
