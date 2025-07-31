using System;
using System.IO;

// Token: 0x0200003D RID: 61
internal sealed class Class99 : Class97
{
	// Token: 0x0600016C RID: 364 RVA: 0x00003CA4 File Offset: 0x00001EA4
	public Class99(Stream stream_1, int int_1)
	{
		this.stream_0 = stream_1;
		this.int_0 = (int_1 ^ -559030707);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00003CC0 File Offset: 0x00001EC0
	public Stream method_0()
	{
		return this.stream_0;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00003CC8 File Offset: 0x00001EC8
	public override bool vmethod_0()
	{
		return this.method_0().CanRead;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00003CD5 File Offset: 0x00001ED5
	public override bool vmethod_2()
	{
		return this.method_0().CanSeek;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00003CE2 File Offset: 0x00001EE2
	public override bool vmethod_1()
	{
		return this.method_0().CanWrite;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00003CEF File Offset: 0x00001EEF
	public override void vmethod_8()
	{
		this.method_0().Flush();
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00003CFC File Offset: 0x00001EFC
	public override long vmethod_3()
	{
		return this.method_0().Length;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00003D09 File Offset: 0x00001F09
	public override long vmethod_4()
	{
		return this.method_0().Position;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00003D16 File Offset: 0x00001F16
	public override void vmethod_5(long long_0)
	{
		this.method_0().Position = long_0;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00025A20 File Offset: 0x00023C20
	private byte method_1(byte byte_0, uint uint_0)
	{
		byte b = (byte)(this.int_0 ^ (int)uint_0);
		return byte_0 ^ b;
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00025A3C File Offset: 0x00023C3C
	public override void vmethod_13(byte[] byte_0, int int_1, int int_2)
	{
		uint num = (uint)this.vmethod_4();
		byte[] array = new byte[int_2];
		uint num2 = 0U;
		while ((ulong)num2 < (ulong)((long)int_2))
		{
			array[(int)num2] = this.method_1(byte_0[(int)(checked((IntPtr)(unchecked((ulong)num2 + (ulong)((long)int_1)))))], num + num2);
			num2 += 1U;
		}
		this.method_0().Write(array, 0, int_2);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00025A88 File Offset: 0x00023C88
	public override int vmethod_11(byte[] byte_0, int int_1, int int_2)
	{
		uint num = (uint)this.vmethod_4();
		int num2 = this.method_0().Read(byte_0, int_1, int_2);
		int num3 = int_1 + num2;
		for (int i = int_1; i < num3; i++)
		{
			byte_0[i] = this.method_1(byte_0[i], num++);
		}
		return num2;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00025AD0 File Offset: 0x00023CD0
	public override long vmethod_9(long long_0, int int_1)
	{
		SeekOrigin origin;
		switch (int_1)
		{
		case 0:
			origin = SeekOrigin.Begin;
			break;
		case 1:
			origin = SeekOrigin.Current;
			break;
		case 2:
			origin = SeekOrigin.End;
			break;
		default:
			throw new ArgumentException();
		}
		return this.method_0().Seek(long_0, origin);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00003D24 File Offset: 0x00001F24
	public override void vmethod_10(long long_0)
	{
		this.method_0().SetLength(long_0);
	}

	// Token: 0x0400007D RID: 125
	private readonly int int_0;

	// Token: 0x0400007E RID: 126
	private readonly Stream stream_0;
}
