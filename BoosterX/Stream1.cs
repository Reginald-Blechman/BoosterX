using System;
using System.IO;

// Token: 0x02000038 RID: 56
internal sealed class Stream1 : Stream
{
	// Token: 0x06000141 RID: 321 RVA: 0x00025130 File Offset: 0x00023330
	public Stream1(Stream stream_1, Interface1 interface1_1)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (interface1_1 == null)
		{
			throw new ArgumentNullException("transform");
		}
		this.stream_0 = stream_1;
		this.interface1_0 = interface1_1;
		if (this.stream_0.Length < 4L)
		{
			throw new InvalidOperationException();
		}
		this.method_0();
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00025194 File Offset: 0x00023394
	private void method_0()
	{
		this.int_4 = this.interface1_0.imethod_0();
		this.byte_0 = new byte[this.int_4];
		this.int_7 = this.interface1_0.imethod_1();
		this.byte_1 = new byte[this.int_7];
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000143 RID: 323 RVA: 0x00003982 File Offset: 0x00001B82
	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000144 RID: 324 RVA: 0x00003982 File Offset: 0x00001B82
	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000145 RID: 325 RVA: 0x00003056 File Offset: 0x00001256
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000146 RID: 326 RVA: 0x00003BC1 File Offset: 0x00001DC1
	public override long Length
	{
		get
		{
			this.method_4();
			return (long)this.int_0;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000147 RID: 327 RVA: 0x00003BD0 File Offset: 0x00001DD0
	// (set) Token: 0x06000148 RID: 328 RVA: 0x000251E8 File Offset: 0x000233E8
	public override long Position
	{
		get
		{
			return (long)(this.int_3 * this.int_7 + this.int_6);
		}
		set
		{
			int num = (int)value / this.int_7;
			this.int_6 = (int)value % this.int_7;
			if (this.int_3 != num)
			{
				this.int_3 = num;
				this.bool_2 = true;
				this.bool_0 = false;
			}
		}
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0002522C File Offset: 0x0002342C
	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			this.Position = offset;
			break;
		case SeekOrigin.Current:
			this.Position += offset;
			break;
		case SeekOrigin.End:
			this.Position = this.Length + offset;
			break;
		}
		return this.Position;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x000031EC File Offset: 0x000013EC
	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0002527C File Offset: 0x0002347C
	public override int Read(byte[] buffer, int offset, int count)
	{
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("#=z2_sBKLs=");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("#=z7VBd7Zo=");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException();
		}
		if (count == 0)
		{
			return 0;
		}
		int i = count;
		int num = offset;
		if (this.int_6 < this.int_7)
		{
			this.method_1();
			int num2 = this.int_5 - this.int_6;
			if (num2 > count)
			{
				Buffer.BlockCopy(this.byte_1, this.int_6, buffer, offset, count);
				this.int_6 += count;
				return count;
			}
			Buffer.BlockCopy(this.byte_1, this.int_6, buffer, offset, num2);
			this.int_6 = this.int_5;
			if (this.bool_1)
			{
				return num2;
			}
			i -= num2;
			num += num2;
		}
		if (this.bool_1)
		{
			return count - i;
		}
		while (i > 0)
		{
			this.method_2();
			if (this.bool_1)
			{
				return count - i;
			}
			int num3 = this.int_5;
			if (i < num3)
			{
				Buffer.BlockCopy(this.byte_1, 0, buffer, num, i);
				this.int_6 = i;
				return count;
			}
			Buffer.BlockCopy(this.byte_1, 0, buffer, num, num3);
			num += num3;
			i -= num3;
			this.int_6 = num3;
		}
		return count;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x000253A4 File Offset: 0x000235A4
	private void method_1()
	{
		this.method_4();
		if (!this.bool_0)
		{
			this.bool_0 = true;
			this.bool_1 = false;
			int num = this.int_3;
			if (this.bool_2)
			{
				this.stream_0.Position = (long)(4 + num * this.int_4);
				this.bool_2 = false;
			}
			this.method_3(num);
		}
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00025404 File Offset: 0x00023604
	private void method_2()
	{
		int int_ = this.int_3 + 1;
		if (this.method_3(int_))
		{
			this.int_3 = int_;
			this.int_6 = 0;
		}
		this.bool_0 = true;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00025438 File Offset: 0x00023638
	private bool method_3(int int_8)
	{
		int i = 0;
		while (i < this.int_4)
		{
			int num = this.stream_0.Read(this.byte_0, i, this.int_4 - i);
			if (num != 0)
			{
				i += num;
			}
			else
			{
				if (i != 0)
				{
					throw new InvalidOperationException();
				}
				this.bool_1 = true;
				return false;
			}
		}
		this.int_5 = this.interface1_0.imethod_2(this.byte_0, 0, this.int_4, this.byte_1, 0, null);
		if (int_8 == this.int_1)
		{
			this.int_5 = this.int_2;
		}
		return true;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000254C4 File Offset: 0x000236C4
	private void method_4()
	{
		if (!this.bool_3)
		{
			if (this.stream_0.Position != 0L)
			{
				this.stream_0.Position = 0L;
				this.bool_2 = true;
			}
			Struct7 @struct = Stream1.smethod_0(this.stream_0);
			this.int_0 = @struct.int_0;
			this.int_1 = this.int_0 / this.int_7;
			this.int_2 = this.int_0 % this.int_7;
			this.bool_3 = true;
		}
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00025548 File Offset: 0x00023748
	private static Struct7 smethod_0(Stream stream_1)
	{
		Class99 @class = new Class99(stream_1, 0);
		Struct7 result;
		try
		{
			Class8 class2 = new Class8(@class);
			try
			{
				result = new Struct7(class2.method_19());
			}
			finally
			{
				((IDisposable)class2).Dispose();
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		return result;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0000311B File Offset: 0x0000131B
	public override void Flush()
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x000031EC File Offset: 0x000013EC
	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	// Token: 0x04000068 RID: 104
	private int int_0;

	// Token: 0x04000069 RID: 105
	private int int_1;

	// Token: 0x0400006A RID: 106
	private int int_2;

	// Token: 0x0400006B RID: 107
	private Stream stream_0;

	// Token: 0x0400006C RID: 108
	private Interface1 interface1_0;

	// Token: 0x0400006D RID: 109
	private int int_3;

	// Token: 0x0400006E RID: 110
	private bool bool_0;

	// Token: 0x0400006F RID: 111
	private bool bool_1;

	// Token: 0x04000070 RID: 112
	private bool bool_2;

	// Token: 0x04000071 RID: 113
	private byte[] byte_0;

	// Token: 0x04000072 RID: 114
	private int int_4;

	// Token: 0x04000073 RID: 115
	private byte[] byte_1;

	// Token: 0x04000074 RID: 116
	private int int_5;

	// Token: 0x04000075 RID: 117
	private int int_6;

	// Token: 0x04000076 RID: 118
	private int int_7;

	// Token: 0x04000077 RID: 119
	private bool bool_3;
}
