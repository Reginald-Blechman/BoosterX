using System;
using System.Collections.Generic;

// Token: 0x0200009B RID: 155
internal sealed class Class96 : IDisposable, Interface5
{
	// Token: 0x060004E6 RID: 1254 RVA: 0x0000551A File Offset: 0x0000371A
	public int imethod_0()
	{
		return this.list_0.Count;
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00005527 File Offset: 0x00003727
	public void imethod_3()
	{
		this.list_0.Clear();
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00005534 File Offset: 0x00003734
	public Interface5 imethod_4()
	{
		return new Class96();
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x0000553B File Offset: 0x0000373B
	public void Dispose()
	{
		this.imethod_3();
		this.list_0 = null;
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0000554A File Offset: 0x0000374A
	public void imethod_1(int int_0, out byte byte_0)
	{
		byte_0 = this.method_0(this.list_0[int_0], int_0);
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00037824 File Offset: 0x00035A24
	public void imethod_2(int int_0, ref byte byte_0)
	{
		for (int i = this.list_0.Count; i <= int_0; i++)
		{
			if (i == int_0)
			{
				this.list_0.Add(this.method_1(byte_0, i));
				return;
			}
			this.list_0.Add(this.method_1(0, i));
		}
		this.list_0[int_0] = this.method_1(byte_0, int_0);
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00003C75 File Offset: 0x00001E75
	private byte method_0(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00003C75 File Offset: 0x00001E75
	private byte method_1(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}

	// Token: 0x040002DA RID: 730
	private List<byte> list_0 = new List<byte>();
}
