using System;
using System.IO;

// Token: 0x02000033 RID: 51
internal sealed class Stream0 : Stream
{
	// Token: 0x06000125 RID: 293 RVA: 0x00003A64 File Offset: 0x00001C64
	public Stream0(Stream stream_1, int int_1)
	{
		this.method_0(stream_1);
		this.int_0 = int_1;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00003A7A File Offset: 0x00001C7A
	public Stream K6L75MRJHiKN()
	{
		return this.stream_0;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00003A82 File Offset: 0x00001C82
	private void method_0(Stream stream_1)
	{
		this.stream_0 = stream_1;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000128 RID: 296 RVA: 0x00003A8B File Offset: 0x00001C8B
	public override bool CanRead
	{
		get
		{
			return this.K6L75MRJHiKN().CanRead;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000129 RID: 297 RVA: 0x00003A98 File Offset: 0x00001C98
	public override bool CanSeek
	{
		get
		{
			return this.K6L75MRJHiKN().CanSeek;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600012A RID: 298 RVA: 0x00003AA5 File Offset: 0x00001CA5
	public override bool CanWrite
	{
		get
		{
			return this.K6L75MRJHiKN().CanWrite;
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00003AB2 File Offset: 0x00001CB2
	public override void Flush()
	{
		this.K6L75MRJHiKN().Flush();
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600012C RID: 300 RVA: 0x00003ABF File Offset: 0x00001CBF
	public override long Length
	{
		get
		{
			return this.K6L75MRJHiKN().Length;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600012D RID: 301 RVA: 0x00003ACC File Offset: 0x00001CCC
	// (set) Token: 0x0600012E RID: 302 RVA: 0x00003AD9 File Offset: 0x00001CD9
	public override long Position
	{
		get
		{
			return this.K6L75MRJHiKN().Position;
		}
		set
		{
			this.K6L75MRJHiKN().Position = value;
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00025078 File Offset: 0x00023278
	private byte method_1(byte byte_0, long long_0)
	{
		byte b = (byte)((ulong)this.int_0 | (ulong)long_0);
		return byte_0 ^ b;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00025094 File Offset: 0x00023294
	public override void Write(byte[] buffer, int offset, int count)
	{
		byte[] array = new byte[count];
		Buffer.BlockCopy(buffer, offset, array, 0, count);
		long position = this.Position;
		for (int i = 0; i < count; i++)
		{
			array[i] = this.method_1(array[i], position + (long)i);
		}
		this.K6L75MRJHiKN().Write(array, 0, count);
	}

	// Token: 0x06000131 RID: 305 RVA: 0x000250E4 File Offset: 0x000232E4
	public override int Read(byte[] buffer, int offset, int count)
	{
		long position = this.Position;
		byte[] array = new byte[count];
		int num = this.K6L75MRJHiKN().Read(array, 0, count);
		for (int i = 0; i < num; i++)
		{
			buffer[i + offset] = this.method_1(array[i], position + (long)i);
		}
		return num;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00003AE7 File Offset: 0x00001CE7
	public override long Seek(long offset, SeekOrigin origin)
	{
		return this.K6L75MRJHiKN().Seek(offset, origin);
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00003AF6 File Offset: 0x00001CF6
	public override void SetLength(long value)
	{
		this.K6L75MRJHiKN().SetLength(value);
	}

	// Token: 0x04000064 RID: 100
	private readonly int int_0;

	// Token: 0x04000065 RID: 101
	private Stream stream_0;
}
