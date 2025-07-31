using System;
using System.Security.Cryptography;

// Token: 0x02000007 RID: 7
internal sealed class Class2 : DeriveBytes
{
	// Token: 0x0600004D RID: 77 RVA: 0x00022428 File Offset: 0x00020628
	public Class2(byte[] byte_2, byte[] byte_3, int int_1)
	{
		this.byte_0 = byte_2;
		this.byte_1 = byte_3;
		this.int_0 = int_1;
		if (!Class2.bool_0)
		{
			try
			{
				this.deriveBytes_0 = new Rfc2898DeriveBytes(byte_2, byte_3, int_1);
			}
			catch
			{
				Class2.bool_0 = true;
			}
		}
		if (this.deriveBytes_0 == null)
		{
			this.deriveBytes_0 = new Class48(byte_2, byte_3, int_1);
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0002249C File Offset: 0x0002069C
	public override byte[] GetBytes(int cb)
	{
		byte[] array = null;
		if (!Class2.bool_0)
		{
			try
			{
				array = this.deriveBytes_0.GetBytes(cb);
			}
			catch
			{
				Class2.bool_0 = true;
			}
		}
		if (array == null)
		{
			this.deriveBytes_0 = new Class48(this.byte_0, this.byte_1, this.int_0);
			array = this.deriveBytes_0.GetBytes(cb);
		}
		return array;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000031EC File Offset: 0x000013EC
	public override void Reset()
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000018 RID: 24
	private static volatile bool bool_0;

	// Token: 0x04000019 RID: 25
	private DeriveBytes deriveBytes_0;

	// Token: 0x0400001A RID: 26
	private readonly byte[] byte_0;

	// Token: 0x0400001B RID: 27
	private readonly byte[] byte_1;

	// Token: 0x0400001C RID: 28
	private readonly int int_0;
}
