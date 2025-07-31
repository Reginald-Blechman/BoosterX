using System;
using System.Text;

// Token: 0x02000523 RID: 1315
public sealed class GClass231
{
	// Token: 0x0600218B RID: 8587 RVA: 0x0001610A File Offset: 0x0001430A
	public GClass231()
	{
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x00016129 File Offset: 0x00014329
	public GClass231(uint uint_2, string string_1)
	{
		this.uint_0 = uint_2;
		this.stringBuilder_0 = new StringBuilder(string_1);
		this.uint_1 = 1U;
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x00016162 File Offset: 0x00014362
	public GClass231(string string_1, string string_2)
	{
		this.string_0 = string_1;
		this.stringBuilder_0 = new StringBuilder(string_2);
		this.uint_1 = 1U;
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x0001619B File Offset: 0x0001439B
	public GClass231(byte[] byte_1, string string_1)
	{
		this.byte_0 = byte_1;
		this.stringBuilder_0 = new StringBuilder(string_1);
		this.uint_1 = 1U;
	}

	// Token: 0x04001632 RID: 5682
	public string string_0 = string.Empty;

	// Token: 0x04001633 RID: 5683
	public uint uint_0;

	// Token: 0x04001634 RID: 5684
	public byte[] byte_0 = new byte[0];

	// Token: 0x04001635 RID: 5685
	public StringBuilder stringBuilder_0;

	// Token: 0x04001636 RID: 5686
	public uint uint_1;
}
