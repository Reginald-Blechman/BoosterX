using System;

// Token: 0x020000BC RID: 188
internal sealed class Class120 : Interface2
{
	// Token: 0x0600058B RID: 1419 RVA: 0x000059A5 File Offset: 0x00003BA5
	public Class120(byte[] byte_1)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("#=zPWibic8=");
		}
		this.byte_0 = (byte[])byte_1.Clone();
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00038914 File Offset: 0x00036B14
	public Class120(byte[] byte_1, int int_0, int int_1)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("#=zPWibic8=");
		}
		if (int_0 < 0 || int_0 > byte_1.Length)
		{
			throw new ArgumentOutOfRangeException("#=z2_sBKLs=");
		}
		if (int_1 < 0 || int_0 + int_1 > byte_1.Length)
		{
			throw new ArgumentOutOfRangeException("#=z7VBd7Zo=");
		}
		this.byte_0 = new byte[int_1];
		Array.Copy(byte_1, int_0, this.byte_0, 0, int_1);
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x000059CD File Offset: 0x00003BCD
	public byte[] method_0()
	{
		return (byte[])this.byte_0.Clone();
	}

	// Token: 0x0400030D RID: 781
	private readonly byte[] byte_0;
}
